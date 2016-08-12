Public Class SaleSQL

    Dim sqlcommmand As String
    Public Sub Crea_Ticket(ByVal otro As String)
        sqlcommmand = "insert into Sale (otro) values ('" & otro & "')"
        MySQL.execute(sqlcommmand)
    End Sub

    Public Sub Venta(ByVal ticket As Integer, ByVal product As Integer)
        sqlcommmand = "insert into SaleProducts (Id_Sale, Id_Product) values (" & ticket & "," & product & ")"
        MySQL.execute(sqlcommmand)
    End Sub

End Class
