<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFactura
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
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.lblNoTicket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.RFC = New System.Windows.Forms.TextBox()
        Me.Street = New System.Windows.Forms.TextBox()
        Me.Municipio = New System.Windows.Forms.TextBox()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.CP = New System.Windows.Forms.TextBox()
        Me.NumExt = New System.Windows.Forms.TextBox()
        Me.NumInt = New System.Windows.Forms.TextBox()
        Me.Colonia = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Correo = New System.Windows.Forms.TextBox()
        Me.dtgvVenta = New System.Windows.Forms.DataGridView()
        Me.btnTicket = New System.Windows.Forms.Button()
        CType(Me.dtgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCompra
        '
        Me.btnCompra.Enabled = False
        Me.btnCompra.Location = New System.Drawing.Point(545, 55)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(84, 44)
        Me.btnCompra.TabIndex = 0
        Me.btnCompra.Text = "Facturar"
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(82, 26)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(100, 20)
        Me.txtTicket.TabIndex = 1
        '
        'lblNoTicket
        '
        Me.lblNoTicket.AutoSize = True
        Me.lblNoTicket.Location = New System.Drawing.Point(24, 29)
        Me.lblNoTicket.Name = "lblNoTicket"
        Me.lblNoTicket.Size = New System.Drawing.Size(52, 13)
        Me.lblNoTicket.TabIndex = 2
        Me.lblNoTicket.Text = "N° Ticket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RFC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Municipio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Pais"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Num Ext"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(192, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Num Int"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(194, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Colonia"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(82, 78)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(100, 20)
        Me.Nombre.TabIndex = 13
        '
        'RFC
        '
        Me.RFC.Location = New System.Drawing.Point(82, 58)
        Me.RFC.Name = "RFC"
        Me.RFC.Size = New System.Drawing.Size(100, 20)
        Me.RFC.TabIndex = 14
        '
        'Street
        '
        Me.Street.Location = New System.Drawing.Point(82, 107)
        Me.Street.Name = "Street"
        Me.Street.Size = New System.Drawing.Size(100, 20)
        Me.Street.TabIndex = 15
        '
        'Municipio
        '
        Me.Municipio.Location = New System.Drawing.Point(82, 136)
        Me.Municipio.Name = "Municipio"
        Me.Municipio.Size = New System.Drawing.Size(100, 20)
        Me.Municipio.TabIndex = 16
        '
        'Estado
        '
        Me.Estado.Location = New System.Drawing.Point(82, 163)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(100, 20)
        Me.Estado.TabIndex = 17
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(82, 187)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(100, 20)
        Me.txtPais.TabIndex = 18
        '
        'CP
        '
        Me.CP.Location = New System.Drawing.Point(82, 223)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(100, 20)
        Me.CP.TabIndex = 19
        '
        'NumExt
        '
        Me.NumExt.Location = New System.Drawing.Point(261, 29)
        Me.NumExt.Name = "NumExt"
        Me.NumExt.Size = New System.Drawing.Size(100, 20)
        Me.NumExt.TabIndex = 20
        '
        'NumInt
        '
        Me.NumInt.Location = New System.Drawing.Point(261, 54)
        Me.NumInt.Name = "NumInt"
        Me.NumInt.Size = New System.Drawing.Size(100, 20)
        Me.NumInt.TabIndex = 21
        '
        'Colonia
        '
        Me.Colonia.Location = New System.Drawing.Point(261, 81)
        Me.Colonia.Name = "Colonia"
        Me.Colonia.Size = New System.Drawing.Size(100, 20)
        Me.Colonia.TabIndex = 22
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(400, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 50)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(195, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Correo"
        '
        'Correo
        '
        Me.Correo.Location = New System.Drawing.Point(261, 111)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(100, 20)
        Me.Correo.TabIndex = 25
        '
        'dtgvVenta
        '
        Me.dtgvVenta.AllowUserToAddRows = False
        Me.dtgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvVenta.Location = New System.Drawing.Point(207, 137)
        Me.dtgvVenta.Name = "dtgvVenta"
        Me.dtgvVenta.Size = New System.Drawing.Size(408, 148)
        Me.dtgvVenta.TabIndex = 26
        '
        'btnTicket
        '
        Me.btnTicket.Location = New System.Drawing.Point(400, 75)
        Me.btnTicket.Name = "btnTicket"
        Me.btnTicket.Size = New System.Drawing.Size(75, 45)
        Me.btnTicket.TabIndex = 27
        Me.btnTicket.Text = "Ticket"
        Me.btnTicket.UseVisualStyleBackColor = True
        '
        'fFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 315)
        Me.Controls.Add(Me.btnTicket)
        Me.Controls.Add(Me.dtgvVenta)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Colonia)
        Me.Controls.Add(Me.NumInt)
        Me.Controls.Add(Me.NumExt)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Municipio)
        Me.Controls.Add(Me.Street)
        Me.Controls.Add(Me.RFC)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNoTicket)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.btnCompra)
        Me.Name = "fFactura"
        Me.Text = "Facturar"
        CType(Me.dtgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCompra As System.Windows.Forms.Button
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents lblNoTicket As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents RFC As System.Windows.Forms.TextBox
    Friend WithEvents Street As System.Windows.Forms.TextBox
    Friend WithEvents Municipio As System.Windows.Forms.TextBox
    Friend WithEvents Estado As System.Windows.Forms.TextBox
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents CP As System.Windows.Forms.TextBox
    Friend WithEvents NumExt As System.Windows.Forms.TextBox
    Friend WithEvents NumInt As System.Windows.Forms.TextBox
    Friend WithEvents Colonia As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Correo As System.Windows.Forms.TextBox
    Friend WithEvents dtgvVenta As System.Windows.Forms.DataGridView
    Friend WithEvents btnTicket As System.Windows.Forms.Button
End Class
