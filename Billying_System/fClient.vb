
Public Class fClient

    Dim Clientsql As New ClientSQL
    Dim idAdd As Integer = 0
    Dim aki As Long

    Public Function GetRFC()
        Return RFC.Text
    End Function

    Public Function GetName()
        Return Nombre.Text
    End Function

    Public Function GetDireccion()
        Return Street.Text
    End Function

    Public Function GetColonia()
        Return Colonia.Text
    End Function

    Public Function GetCP()
        Return CP.Text
    End Function

    Public Function GetNumExt()
        Return NumExt.Text
    End Function

    Public Function GetNumInt()
        Return NumInt.Text
    End Function

    Public Function GetCiudad()
        Return Ciudad.Text
    End Function

    Public Function GetMunicipio()
        Return Municipio.Text
    End Function

    Public Function GetEstado()
        Return Estado.Text
    End Function

    Public Function GetCorreo()
        Return Correo.Text
    End Function

    Public Function GetTelefono()
        Return Telephone.Text
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        RFC.Text = ""
        Nombre.Text = ""
        Street.Text = ""
        Colonia.Text = ""
        CP.Text = ""
        NumExt.Text = ""
        NumInt.Text = ""
        Ciudad.Text = ""
        Municipio.Text = ""
        Estado.Text = ""
        Correo.Text = ""
        Telephone.Text = ""

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        If RFC.Text <> "" Or Nombre.Text <> "" Or Street.Text <> "" Or Colonia.Text <> "" Or CP.Text <> "" Or NumExt.Text <> "" Or Ciudad.Text <> "" Or Municipio.Text <> "" Or Estado.Text <> "" Or Correo.Text <> "" Or Telephone.Text <> "" Then

            Clientsql.InsertNewAddress_NewClient(Street.Text, Colonia.Text, CP.Text, NumExt.Text, NumInt.Text, Ciudad.Text, Municipio.Text, Estado.Text)
            MessageBox.Show(idAdd)
            idAdd = cmboMax.Text + 1

            aki = CType(Telephone.Text, Long)
            Clientsql.InsertNewClient_NewAddress(RFC.Text, Nombre.Text, Correo.Text, aki, idAdd)

            MessageBox.Show("Se ha agregado el Cliente")
        Else
            MessageBox.Show("Campos Vacios")

        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim RFCd As String
        RFCd = RFC.Text

        MySQL.showData("select cli.rfc, cli.nombre,cli.telephone, cli.Correo, ad.Street, ad.NumExt, ad.NumInt, ad.Colonia, ad.CP, ad.Municipio, ad.Ciudad, ad.Estado from Client cli, Address ad where ad.Id = cli.Id_Address and cli.rfc like '" & RFCd & "%'", Me)

    End Sub

    Private Sub fClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL.fillList(cmboMax, "select max(id) AS Prueba from Address")

    End Sub

  
End Class