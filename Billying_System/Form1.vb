Imports Billying_System.MySQL


Public Class fHome





    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        HideAll()
        fClient.Show()
        fClient.MdiParent = Me
    End Sub

 

    Private Sub tsSale_Click(sender As Object, e As EventArgs)
        HideAll()
        fSale.Show()
        fSale.MdiParent = Me
    End Sub

    Private Sub tsProduct_Click(sender As Object, e As EventArgs)
        HideAll()
        fProduct.Show()
        fSale.MdiParent = Me
    End Sub

   
    Private Sub ctsmClient_Click(sender As Object, e As EventArgs) Handles ctsmClient.Click
        HideAll()
        fClient.Show()
        fClient.MdiParent = Me

    End Sub

    Private Sub ptsmProduct_Click(sender As Object, e As EventArgs) Handles ptsmProduct.Click
        HideAll()
        fProduct.Show()
        fProduct.MdiParent = Me
    End Sub

    Private Sub HideAll()
        For Each child As Form In Me.MdiChildren
            child.Hide()
        Next

    End Sub


    Private Sub ststmSale_Click(sender As Object, e As EventArgs) Handles ststmSale.Click
        HideAll()
        fSale.Show()
        fSale.MdiParent = Me
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub fHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL.Connect()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click

        fFactura.Show()
        fFactura.MdiParent = Me
    End Sub
End Class
