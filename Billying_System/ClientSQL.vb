Imports System.Data.SqlClient
Imports System.Data
Imports Billying_System.MySQL
Imports Billying_System.fClient
Public Class ClientSQL


    Dim sqlcommand As String

    Public Sub InsertNewAddress_NewClient(ByVal address As String, ByVal colony As String, ByVal cp As Integer, ByVal numext As Integer, ByVal numint As Integer, ByVal ciudad As String, ByVal municipio As String, ByVal estado As String)
        sqlcommand = "insert into Address (Street,NumExt,NumInt,Colonia,CP,Municipio,Ciudad,Estado) values ('" & address & "','" & numext & "','" & numint & "','" & colony & "','" & cp & "','" & municipio & "','" & ciudad & "','" & estado & "')"
        MySQL.execute(sqlcommand)
    End Sub

    Public Sub InsertNewClient_NewAddress(ByVal rfc As String, ByVal name As String, ByVal mail As String, ByVal tel As Long, ByVal idAdd As Integer)
        sqlcommand = "insert into Client (Nombre, RFC, Id_Address, Telephone, Correo) values ('" & name & "','" & rfc & "','" & idAdd & "','" & tel & "','" & mail & "')"
        MySQL.execute(sqlcommand)
    End Sub



End Class
