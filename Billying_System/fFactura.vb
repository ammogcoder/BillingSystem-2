Imports CFD_VB2010

Imports System.Web

Imports System.Net.Mail
Imports System.IO

Imports iTextSharp
Imports iTextSharp.text.pdf

Public Class fFactura

    Dim Version As CFDx.VersionCFD = CFDx.VersionCFD.CFDv3_2
    Dim mail As Mailing

    Dim prueba As String
    Dim bruto As Double = 0
    Dim iva As Double = 0.16
    Dim ivatotal As Double = 1.16
    Dim neto As Double = 0

    Dim tippago As String = "EN UNA SOLA EXHIBICION"
    Dim formapago As String = "EFECTIVO"
    Dim lugexp As String = "QUERETARO"

    Dim emirfc As String = "AUBG780220IQZ"
    Dim emidir As String = "BOULEVARD DR NORMAN E. BORLAUG"
    Dim emimun As String = "CAJEME"
    Dim emiedo As String = "SONORA"
    Dim emipai As String = "MEXICO"
    Dim emicp As String = "85139"
    Dim eminam As String = "ALFONSO R. BOURS"

    Dim regint As String = "REGIMEN INTERMEDIO"
    Dim reggen As String = "REGIMEN GENERAL"

    Public Sub FACTURARCHINGON(ByVal recrfc As String, ByVal recnom As String, ByVal recdir As String, ByVal recmun As String, ByVal recedo As String, ByVal recpais As String, ByVal reccp As String, ByVal recnumext As String, ByVal recnumint As String, ByVal reccol As String, ByVal reccorreo As String, ByRef compra As DataGridView)
        Dim CFDs As New CFDx
        With CFDs

            For Each row As DataGridViewRow In compra.Rows
                prueba = row.Cells("Price").Value
                bruto = bruto + CType(prueba, Double)
            Next
            .Comprobante(Version, 123, FormatDateTime(Now, DateFormat.GeneralDate), _
                        tippago, bruto, bruto * ivatotal,
                        ComprobanteTipoDeComprobante.ingreso, formapago, lugexp, lugexp)

            .AgregaEmisor(emirfc, emidir, emimun, emiedo, emipai, emicp, Nombre:=eminam)

            .AgregaReceptor(recrfc, recnom, recdir, recmun, recedo, recpais, reccp, recnumext, recnumint, Colonia:=reccol)

            .AgregaRegimenFiscal(regint, reggen)

            For Each row As DataGridViewRow In compra.Rows
                .AgregaConcepto(1, "PZA", row.Cells("Descripcion").Value, row.Cells("Price").Value)
            Next


            .AgregaImpuesto(ComprobanteImpuestosTrasladoImpuesto.IVA, bruto * iva, 16)

        End With

        Dim camino As String = IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Cert")
        Dim CertFile As String = IO.Path.Combine(camino, "CSD09_AAA010101AAA.cer")
        Dim KeyFile As String = IO.Path.Combine(camino, "CSD09_AAA010101AAA.key")
        Dim KeyPass As String = "12345678a"
        Dim Errores As String = ""

        If CFDs.CreaFacturaXML(KeyFile, KeyPass, CertFile, Errores) = False Then
            MsgBox("Se encontraron los siguientes Errores: " & vbNewLine & Errores, MsgBoxStyle.Exclamation)
        Else
            MsgBox("Proceso Terminado!", MsgBoxStyle.Information)
            CFDs.AbreCFDIcredo("CFDI.xml")
        End If
    End Sub



    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click

        FACTURARCHINGON(RFC.Text, Nombre.Text, Street.Text, Municipio.Text, Estado.Text, txtPais.Text, CP.Text, NumExt.Text, NumInt.Text, Colonia.Text, Correo.Text, dtgvVenta)
        Create_PDF(dtgvVenta)
        emaila(Correo.Text)

    End Sub

    Public Sub emaila(ByVal correo As String)
        Using mail As MailMessage = New MailMessage
            mail.Subject = "Factura Electronica"
            mail.To.Add(correo)
            mail.From = New MailAddress("proyecto.dass@gmail.com") '
            mail.Body = "Le enviamos cordialmente su factura a su correo."
            mail.Attachments.Add(New Attachment("C:\Users\alex\Documents\Carrera\10moSemestre\DASS\FINAL_DASS\Billying_System\bin\x64\Debug\CFDI.xml"))
            mail.Attachments.Add(New Attachment("C:\Users\alex\Documents\Carrera\10moSemestre\DASS\FINAL_DASS\Billying_System\bin\x64\Debug\CFDI_PDF.pdf"))
            Dim smtp As New SmtpClient("smtp.gmail.com")
            Using TryCast(smtp, IDisposable)
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("proyecto.dass@gmail.com", "fulanito123")
                smtp.Port = 587
                smtp.Send(mail)
            End Using
        End Using
        MsgBox("Sent Successfully")
    End Sub

    Public Sub Create_PDF(ByRef carrito As DataGridView)
        Dim pdfDoc As New iTextSharp.text.Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("CFDI_PDF.pdf", FileMode.Create))

        Dim table As PdfPTable = New PdfPTable(4)
        For Each row As DataGridViewRow In carrito.Rows
            table.AddCell(row.Cells("NProducto").Value)
            table.AddCell(row.Cells("Descripcion").Value)
            table.AddCell("PZA")
            table.AddCell(row.Cells("Price").Value)
        Next

        Dim clientetable As PdfPTable = New PdfPTable(1)
        clientetable.AddCell(Nombre.Text)
        clientetable.AddCell(Street.Text)
        clientetable.AddCell(Colonia.Text)
        clientetable.AddCell(Municipio.Text + " " + Estado.Text + " " + txtPais.Text)
        clientetable.AddCell(CP.Text)
        clientetable.AddCell(RFC.Text)

        Dim emisor As PdfPTable = New PdfPTable(1)
        emisor.AddCell(eminam)
        emisor.AddCell(emidir)
        emisor.AddCell(emimun + " " + emiedo + " " + emipai)
        emisor.AddCell(emicp)

        Dim baseline As New iTextSharp.text.Phrase
        Dim baseftime As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim times As iTextSharp.text.Font = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 20)

        pdfDoc.Open()
        pdfDoc.Add(New iTextSharp.text.Paragraph("Datos de Expedicion"))
        pdfDoc.Add(emisor)
        pdfDoc.Add(New iTextSharp.text.Paragraph(" "))
        pdfDoc.Add(New iTextSharp.text.Paragraph("Cliente"))
        pdfDoc.Add(clientetable)
        pdfDoc.Add(New iTextSharp.text.Paragraph(" "))
        pdfDoc.Add(table)
        pdfDoc.Add(New iTextSharp.text.Paragraph(" "))
        pdfDoc.Add(New iTextSharp.text.Paragraph("Cadena Original del Complemento de Certificacion Digital del Sat"))
        pdfDoc.Add(New iTextSharp.text.Paragraph("MIIEYTCCA0mgAwIBAgIUMjAwMDEwMDAwMDAyMDAwMDE0MzYwDQYJKoZIhvcNAQEFBQAwggFcMRowGAYDVQQDDBFBLkMuIDIgZGUgcHJ1ZWJhczEvMC0GA1UECgwmU2VydmljaW8gZGUgQWRtaW5pc3RyYWNpw7NuIFRyaWJ1dGFyaWExODA2BgNVBAsML0FkbWluaXN0cmFjacOzbiBkZSBTZWd1cmlkYWQgZGUgbGEgSW5mb3JtYWNpw7NuMSkwJwYJKoZIhvcNAQkBFhphc2lzbmV0QHBydWViYXMuc2F0LmdvYi5teDEmMCQGA1UECQwdQXYuIEhpZGFsZ28gNzcsIENvbC4gR3VlcnJlcm8xDjAMBgNVBBEMBTA2MzAwMQswCQYDVQQGEwJNWDEZMBcGA1UECAwQRGlzdHJpdG8gRmVkZXJhbDESMBAGA1UEBwwJQ295b2Fjw6FuMTQwMgYJKoZIhvcNAQkCDCVSZXNwb25zYWJsZTogQXJhY2VsaSBHYW5kYXJhIEJhdXRpc3RhMB4XDTEzMDUwNzE3MzkzOVoXDTE3MDUwNzE3MzkzOVowgdsxKTAnBgNVBAMTIEFDQ0VNIFNFUlZJQ0lPUyBFTVBSRVNBUklBTEVTIFNDMSkwJwYDVQQpEyBBQ0NFTSBTRVJWSUNJT1MgRU1QUkVTQVJJQUxFUyBTQzEpMCcGA1UEChMgQUNDRU0gU0VSVklDSU9TIEVNUFJFU0FSSUFMRVMgU0MxJTAjBgNVBC0THEFBQTAxMDEwMUFBQSAvIEhFR1Q3NjEwMDM0UzIxHjAcBgNVBAUTFSAvIEhFR1Q3NjEwMDNNREZOU1IwODERMA8GA1UECxMIcHJvZHVjdG8wgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBAK5u01+YhUIypqmD+lI/is/EkhYE7UaRxUwQDFW3xlRPsbuKeytQIdOPmJuW8iQqjklhUkEVTjkUqdc730yc6ENcWmXmQ9CZ+DJ19ccqltHbWa2MxvN1Xceigs3mcy4vKnqjxt4Yu/QF+lQz0BAeYxlPUPW0gZP+K9ZnuWw6mgdAgMBAAGjHTAbMAwGA1UdEwEB/wQCMAAwCwYDVR0PBAQDAgbAMA0GCSqGSIb3DQEBBQUAA4IBAQADrL2kw0ym5IZ/5NdPhNwZObz3GtkxZmitFKuCPuA+Pi/9/qkXiQT6LW3qsypQP9hgqFsZKzpnmJVqnQzEn+t+eQRuK4d11zz1tQnf0rFvdmF9HJCxx0AHto/yd+y3oOn5kA00LBDo2M23BLWlNRqG4jxOLO6zObBRYl+wK4a/pTEbN5ypwMXReqhSdGLiqr9+KryWFiAiJNCaEMfKAM3P/RXxYv/0Hel+dPljXqCnC2u039+gr5Ce36d4GW4vVqGgsUl33Kot3Ha3f+Cqzhi8fmgZNKYclBBvNxSdSFaX8p6nHnVTnF6NBXG3/RSowE1of4l63ULKRPAg5qjW5Lb3"))
        pdfDoc.Add(New iTextSharp.text.Paragraph(" "))
        pdfDoc.Add(New iTextSharp.text.Paragraph("Sello Digital"))
        pdfDoc.Add(New iTextSharp.text.Paragraph("fkRW8MUCz7TjqGdRx2Z67eb9lz8Jjnr6RzXPoAaQS0AAvgzTL73POksEDlE3SUxrYWQ0F8AdtqNFDK43X9tHxj4kmQWysaP4BBf7rKlYuIfQ0FMpRbluHYHrOIpMk7hP2fQ3RpRmJ+wWM/ZMKM1nzFq+FZzjdcgmaIZF2SgVNvI="))


        pdfDoc.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim rfcd As String = RFC.Text
        MySQL.showData("select cli.rfc, cli.nombre,cli.Correo, ad.Street, ad.Colonia, ad.Municipio, ad.Estado, ad.CP, ad.NumExt, ad.NumInt from Client cli, Address ad where ad.Id = cli.Id_Address and cli.rfc like '" & rfcd & "%'", Me)
        txtPais.Text = "MEXICO"
        enab()

    End Sub


   
    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        enab()

        MySQL.fillGrid(dtgvVenta, "select Products.NProducto, Products.Price, Products.Descripcion from SaleProducts, Products where SaleProducts.Id_Product = Products.Id and SaleProducts.Id_Sale = " & txtTicket.Text)
    End Sub

    Private Sub enab()
        If RFC.Text <> "" And txtTicket.Text <> "" Then
            btnCompra.Enabled = True
        End If
    End Sub

End Class