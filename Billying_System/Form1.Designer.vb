<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fHome
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fHome))
        Me.msHome = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsmClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptsmProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ststmSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'msHome
        '
        Me.msHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShowToolStripMenuItem, Me.BillToolStripMenuItem})
        Me.msHome.Location = New System.Drawing.Point(0, 0)
        Me.msHome.Name = "msHome"
        Me.msHome.Size = New System.Drawing.Size(746, 24)
        Me.msHome.TabIndex = 5
        Me.msHome.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctsmClient, Me.ptsmProduct})
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ShowToolStripMenuItem.Text = "Add"
        '
        'ctsmClient
        '
        Me.ctsmClient.Image = CType(resources.GetObject("ctsmClient.Image"), System.Drawing.Image)
        Me.ctsmClient.Name = "ctsmClient"
        Me.ctsmClient.Size = New System.Drawing.Size(152, 22)
        Me.ctsmClient.Text = "Client"
        '
        'ptsmProduct
        '
        Me.ptsmProduct.Image = CType(resources.GetObject("ptsmProduct.Image"), System.Drawing.Image)
        Me.ptsmProduct.Name = "ptsmProduct"
        Me.ptsmProduct.Size = New System.Drawing.Size(152, 22)
        Me.ptsmProduct.Text = "Product"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ststmSale, Me.FacturaToolStripMenuItem})
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.BillToolStripMenuItem.Text = "Make"
        '
        'ststmSale
        '
        Me.ststmSale.Image = CType(resources.GetObject("ststmSale.Image"), System.Drawing.Image)
        Me.ststmSale.Name = "ststmSale"
        Me.ststmSale.Size = New System.Drawing.Size(152, 22)
        Me.ststmSale.Text = "Sale"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'fHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 406)
        Me.Controls.Add(Me.msHome)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msHome
        Me.Name = "fHome"
        Me.Text = "Home"
        Me.msHome.ResumeLayout(False)
        Me.msHome.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msHome As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctsmClient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptsmProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ststmSale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
