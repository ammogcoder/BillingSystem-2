
Public Class fSale

    Dim Salessql As New SaleSQL
    Private Sub fSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL.fillList(cmbMaxid, "select max(id), max(id) from Sale")
        MySQL.fillGrid(Books, "select p.id, p.NProducto, p.Descripcion, p.Price from Products p")
        Borrow.ColumnCount = 4
        Borrow.Columns(0).Name = "Id"
        Borrow.Columns(1).Name = "Nombre"
        Borrow.Columns(2).Name = "Descripcion"
        Borrow.Columns(3).Name = "Precio"

    End Sub


    Private Sub btnVende_Click(sender As Object, e As EventArgs) Handles btnVende.Click
        mueve(Books, Borrow)
    End Sub


    Private Sub mueve(ByRef source As DataGridView, ByRef target As DataGridView)
        For Each rows In source.SelectedRows
            Dim cell As DataGridViewCellCollection = rows.Cells
            Dim row As String() = New String() {cell(0).Value, cell(1).Value, cell(2).Value, cell(3).Value}
            target.Rows.Add(row)

        Next
    End Sub

    Private Sub quita(ByRef source As DataGridView)
        For Each rows In source.SelectedRows
            source.Rows.RemoveAt(rows.Index)
        Next
    End Sub

    Private Sub btnNoVendas_Click(sender As Object, e As EventArgs) Handles btnNoVendas.Click
        quita(Borrow)
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Dim aux As Integer = 0
        Dim aux2 As String
        aux2 = cmbMaxid.SelectedValue + 1

        If aux >= aux2 Then
            Salessql.Crea_Ticket(aux.ToString)
            ShoppingCart(Borrow, aux2)
        Else
            Salessql.Crea_Ticket(aux2)
            ShoppingCart(Borrow, aux2)
        End If

        MessageBox.Show("Se ha realizado la compra con el ticket numero " & aux2)


    End Sub

    Public Sub ShoppingCart(ByVal source As DataGridView, ByVal ticket As String)
        Dim x As Integer
        x = CInt(ticket)
        Dim prueba As String
        For Each row As DataGridViewRow In source.Rows
            prueba = row.Cells("Id").Value
            Salessql.Venta(x, row.Cells("Id").Value)
        Next



    End Sub

End Class