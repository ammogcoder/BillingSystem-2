Imports System.Data.SqlClient
Imports System.Data

Module MySQL

    Private connection As New SqlConnection

    Public Sub Connect()
        Try
            connection.ConnectionString = "Data Source=(LocalDB)\v11.0;Initial Catalog=Billing;Integrated Security=True;Pooling=False"
            connection.Open()
            connection.Close()

        Catch sqlex As SqlException
            Dim Err As String
            Err = "Error al realizar la conexión con local/server " & vbCrLf & _
                  sqlex.Message
            msgError(Err)

        Catch ex As Exception
            msgError("Error al intentar abrir conexión")

        End Try

    End Sub

    Public Sub Disconnect()
        Try
            connection.Close()
            MessageBox.Show("Connection to Database has been closed.")
        Catch ex As SqlException
            MessageBox.Show("Cannot connect to database: " & ex.Message)

        End Try

    End Sub

    Public Sub msgError(ByVal err As String)
        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
    End Sub

    Public Function execute(ByVal dml As String) As Boolean
        Try
            Dim command As New SqlCommand(dml, connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch sqlex As SqlException
            msgError(sqlex.Message)
            connection.Close()
            Return False
        Catch ex As Exception
            msgError(ex.Message)
            connection.Close()
            Return False
        End Try
    End Function

    Public Sub showData(ByVal query As String, ByVal form As Form)
        Dim dt As DataTable
        Dim ctrl As Control
        dt = getDataTable(query)
        If Not dt Is Nothing Then
            For Each ctrl In form.Controls
                If dt.Columns.Contains(ctrl.Name) Then
                    If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is MaskedTextBox Then
                        ctrl.Text = dt.Rows(0)(ctrl.Name)
                    ElseIf TypeOf (ctrl) Is ComboBox Or TypeOf (ctrl) Is ListBox Then
                        DirectCast(ctrl, ComboBox).SelectedValue = dt.Rows(0)(ctrl.Name)
                    ElseIf TypeOf (ctrl) Is DateTimePicker Then
                        DirectCast(ctrl, DateTimePicker).Value = dt.Rows(0)(ctrl.Name)
                    Else
                        Try
                            ctrl.Text = dt.Rows(0)(ctrl.Name)
                        Catch ex As Exception
                        End Try
                    End If
                End If
            Next
        End If
    End Sub

    Public Sub fillList(ByVal lst As Windows.Forms.ComboBox, ByVal query As String)
        Dim table As DataTable
        table = getDataTable(query)
        If Not table Is Nothing Then
            lst.DataSource = Nothing
            lst.Items.Clear()
            lst.DataSource = table
            If table.Columns.Count = 2 Then
                lst.ValueMember = table.Columns(0).ToString
                lst.DisplayMember = table.Columns(1).ToString
            Else
                lst.DisplayMember = table.Columns(0).ToString
            End If
        End If
    End Sub

    Public Function getDataTable(ByVal query As String) As DataTable
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        Try
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                Return table
            Else
                Return Nothing
            End If
        Catch sqlex As SqlException
            Dim err As String
            err = "Error de base de datos al ejecutar el query" & vbCrLf & _
                  sqlex.Message
            msgError(err)
        Catch ex As Exception
            msgError("Error al ejecutar el query")
        End Try
        Return Nothing
    End Function

    Public Sub fillGrid(ByVal grid As Windows.Forms.DataGridView, ByVal query As String)
        Dim table As DataTable
        table = getDataTable(query)
        If Not table Is Nothing Then
            grid.DataSource = table
        End If
    End Sub


End Module
