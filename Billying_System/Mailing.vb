Imports Microsoft.Office.Interop
Imports System.Net.Mail
Imports System.IO


Public Class Mailing

    Public Sub emaila()
        Using mail As MailMessage = New MailMessage
            mail.Subject = "test email"
            mail.To.Add("olzabre@hotmail.com")
            mail.From = New MailAddress("zerverus13@gmail.com") '
            mail.Body = "This is an email!"
            mail.Attachments.Add(New Attachment("C:\Users\alex\Documents\Carrera\10moSemestre\DASS\FINAL_DASS\Billying_System\bin\x64\Debug\CFDI.xml"))
            'PDF
            'mail.Attachments.Add(New Attachment("C:\Users\alex\Documents\Carrera\10moSemestre\DASS\FINAL_DASS\Billying_System\bin\x64\Debug\CFDI.xml"))
            Dim smtp As New SmtpClient("smtp.gmail.com")
            Using TryCast(smtp, IDisposable)
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("zerverus13@gmail.com", "chooper13")
                smtp.Port = 587
                smtp.Send(mail)
            End Using
        End Using
        MsgBox("Sent Successfully")
    End Sub






End Class
