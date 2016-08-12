Public Class fProduct

    Dim ProductSql As New ProductSQL

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        NProducto.Text = ""
        Descripcion.Text = ""
        Price.Text = ""
        Quantity.Text = ""

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If NProducto.Text <> "" Or Descripcion.Text <> "" Or Price.Text <> "" Or Quantity.Text <> "" Then

            ProductSql.Add_Product(NProducto.Text, Descripcion.Text, Price.Text, Quantity.Text)
            MessageBox.Show("Se ha guardado el producto")

        Else

            MessageBox.Show("campos vacios")

        End If


    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        MySQL.showData("select p.Id, p.NProducto, p.Descripcion, p.Price, p.Quantity from Products p where p.NProducto like '" & NProducto.Text & "%'", Me)


    End Sub

    Private Sub btnRegrsar_Click(sender As Object, e As EventArgs) Handles btnRegrsar.Click
        Me.Hide()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        ProductSql.Modify_Product(NProducto.Text, Descripcion.Text, Price.Text, Quantity.Text, Id.Text)
        MessageBox.Show("Se han realizado los cambios")


    End Sub
End Class