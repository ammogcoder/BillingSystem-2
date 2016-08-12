Imports System.Data
Imports System.Data.SqlClient
Imports Billying_System.MySQL
Imports Billying_System.fProduct
Public Class ProductSQL

    Dim sqlcommand As String

    Public Sub Add_Product(ByVal name As String, ByVal desc As String, ByVal price As Integer, ByVal quant As Integer)

        sqlcommand = "insert into Products (NProducto,Descripcion,Price,Quantity) values ('" & name & "','" & desc & "','" & price & "','" & quant & "')"
        MySQL.execute(sqlcommand)

    End Sub

    Public Sub Modify_Product(ByVal name As String, ByVal descr As String, ByVal price As Integer, ByVal quan As Integer, ByVal id As Integer)

        sqlcommand = "update Products set NProducto = '" & name & "',  Descripcion = '" & descr & "', Price = " & price & ", Quantity = " & quan & " where id = " & id & ";"
        MySQL.execute(sqlcommand)
    End Sub

End Class
