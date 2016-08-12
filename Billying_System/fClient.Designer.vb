<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fClient
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RFC = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Street = New System.Windows.Forms.TextBox()
        Me.Colonia = New System.Windows.Forms.TextBox()
        Me.CP = New System.Windows.Forms.TextBox()
        Me.NumExt = New System.Windows.Forms.TextBox()
        Me.NumInt = New System.Windows.Forms.TextBox()
        Me.Ciudad = New System.Windows.Forms.TextBox()
        Me.Municipio = New System.Windows.Forms.TextBox()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.Correo = New System.Windows.Forms.TextBox()
        Me.Telephone = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.cmboMax = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RFC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Num Ext"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(430, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Num Int"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Colonia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "CP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(168, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Municipio"
        '
        'RFC
        '
        Me.RFC.Location = New System.Drawing.Point(47, 6)
        Me.RFC.Name = "RFC"
        Me.RFC.Size = New System.Drawing.Size(118, 20)
        Me.RFC.TabIndex = 12
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(65, 28)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(477, 20)
        Me.Nombre.TabIndex = 13
        '
        'Street
        '
        Me.Street.Location = New System.Drawing.Point(65, 51)
        Me.Street.Name = "Street"
        Me.Street.Size = New System.Drawing.Size(477, 20)
        Me.Street.TabIndex = 14
        '
        'Colonia
        '
        Me.Colonia.Location = New System.Drawing.Point(65, 77)
        Me.Colonia.Name = "Colonia"
        Me.Colonia.Size = New System.Drawing.Size(100, 20)
        Me.Colonia.TabIndex = 15
        '
        'CP
        '
        Me.CP.Location = New System.Drawing.Point(203, 77)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(100, 20)
        Me.CP.TabIndex = 16
        '
        'NumExt
        '
        Me.NumExt.Location = New System.Drawing.Point(362, 77)
        Me.NumExt.Name = "NumExt"
        Me.NumExt.Size = New System.Drawing.Size(62, 20)
        Me.NumExt.TabIndex = 17
        '
        'NumInt
        '
        Me.NumInt.Location = New System.Drawing.Point(480, 77)
        Me.NumInt.Name = "NumInt"
        Me.NumInt.Size = New System.Drawing.Size(62, 20)
        Me.NumInt.TabIndex = 18
        '
        'Ciudad
        '
        Me.Ciudad.Location = New System.Drawing.Point(65, 101)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(100, 20)
        Me.Ciudad.TabIndex = 19
        '
        'Municipio
        '
        Me.Municipio.Location = New System.Drawing.Point(217, 101)
        Me.Municipio.Name = "Municipio"
        Me.Municipio.Size = New System.Drawing.Size(100, 20)
        Me.Municipio.TabIndex = 20
        '
        'Estado
        '
        Me.Estado.Location = New System.Drawing.Point(369, 101)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(100, 20)
        Me.Estado.TabIndex = 21
        '
        'Correo
        '
        Me.Correo.Location = New System.Drawing.Point(65, 125)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(100, 20)
        Me.Correo.TabIndex = 22
        '
        'Telephone
        '
        Me.Telephone.Location = New System.Drawing.Point(217, 125)
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Size = New System.Drawing.Size(100, 20)
        Me.Telephone.TabIndex = 23
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(16, 168)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(71, 43)
        Me.btnAgregar.TabIndex = 24
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(108, 168)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 43)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(203, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 43)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Limpiar"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(312, 168)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(78, 43)
        Me.btnRegresar.TabIndex = 28
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'cmboMax
        '
        Me.cmboMax.FormattingEnabled = True
        Me.cmboMax.Location = New System.Drawing.Point(369, 128)
        Me.cmboMax.Name = "cmboMax"
        Me.cmboMax.Size = New System.Drawing.Size(121, 21)
        Me.cmboMax.TabIndex = 29
        Me.cmboMax.Visible = False
        '
        'fClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 266)
        Me.Controls.Add(Me.cmboMax)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Telephone)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Municipio)
        Me.Controls.Add(Me.Ciudad)
        Me.Controls.Add(Me.NumInt)
        Me.Controls.Add(Me.NumExt)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.Colonia)
        Me.Controls.Add(Me.Street)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.RFC)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
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
        Me.Name = "fClient"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RFC As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Street As System.Windows.Forms.TextBox
    Friend WithEvents Colonia As System.Windows.Forms.TextBox
    Friend WithEvents CP As System.Windows.Forms.TextBox
    Friend WithEvents NumExt As System.Windows.Forms.TextBox
    Friend WithEvents NumInt As System.Windows.Forms.TextBox
    Friend WithEvents Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Municipio As System.Windows.Forms.TextBox
    Friend WithEvents Estado As System.Windows.Forms.TextBox
    Friend WithEvents Correo As System.Windows.Forms.TextBox
    Friend WithEvents Telephone As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents cmboMax As System.Windows.Forms.ComboBox
End Class
