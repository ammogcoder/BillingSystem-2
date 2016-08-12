<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSale
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
        Me.Books = New System.Windows.Forms.DataGridView()
        Me.Borrow = New System.Windows.Forms.DataGridView()
        Me.btnVende = New System.Windows.Forms.Button()
        Me.btnNoVendas = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.cmbMaxid = New System.Windows.Forms.ComboBox()
        CType(Me.Books, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Books
        '
        Me.Books.AllowUserToAddRows = False
        Me.Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Books.Location = New System.Drawing.Point(12, 12)
        Me.Books.Name = "Books"
        Me.Books.Size = New System.Drawing.Size(456, 116)
        Me.Books.TabIndex = 0
        '
        'Borrow
        '
        Me.Borrow.AllowUserToAddRows = False
        Me.Borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Borrow.Location = New System.Drawing.Point(12, 197)
        Me.Borrow.Name = "Borrow"
        Me.Borrow.Size = New System.Drawing.Size(456, 119)
        Me.Borrow.TabIndex = 1
        '
        'btnVende
        '
        Me.btnVende.Location = New System.Drawing.Point(257, 148)
        Me.btnVende.Name = "btnVende"
        Me.btnVende.Size = New System.Drawing.Size(97, 36)
        Me.btnVende.TabIndex = 2
        Me.btnVende.Text = "Agregar"
        Me.btnVende.UseVisualStyleBackColor = True
        '
        'btnNoVendas
        '
        Me.btnNoVendas.Location = New System.Drawing.Point(154, 148)
        Me.btnNoVendas.Name = "btnNoVendas"
        Me.btnNoVendas.Size = New System.Drawing.Size(97, 36)
        Me.btnNoVendas.TabIndex = 3
        Me.btnNoVendas.Text = "Quitar"
        Me.btnNoVendas.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.Location = New System.Drawing.Point(360, 148)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(97, 36)
        Me.btnCobrar.TabIndex = 4
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'cmbMaxid
        '
        Me.cmbMaxid.FormattingEnabled = True
        Me.cmbMaxid.Location = New System.Drawing.Point(521, 106)
        Me.cmbMaxid.Name = "cmbMaxid"
        Me.cmbMaxid.Size = New System.Drawing.Size(121, 21)
        Me.cmbMaxid.TabIndex = 6
        '
        'fSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 385)
        Me.Controls.Add(Me.cmbMaxid)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.btnNoVendas)
        Me.Controls.Add(Me.btnVende)
        Me.Controls.Add(Me.Borrow)
        Me.Controls.Add(Me.Books)
        Me.Name = "fSale"
        Me.Text = "Sale"
        CType(Me.Books, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Books As System.Windows.Forms.DataGridView
    Friend WithEvents Borrow As System.Windows.Forms.DataGridView
    Friend WithEvents btnVende As System.Windows.Forms.Button
    Friend WithEvents btnNoVendas As System.Windows.Forms.Button
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents cmbMaxid As System.Windows.Forms.ComboBox
End Class
