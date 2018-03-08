Imports System.Data.SqlClient

Public Class GenerateInventoryReport
    Private Sub GenerateInventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMPT291_GROUPDataSet.Vehicle' table. You can move, or remove it, as needed.

        'setting date picker default values to ' ' for checking in if statements.
        FromDatePicker.Format = DateTimePickerFormat.Custom
        FromDatePicker.CustomFormat = " "
        FromDatePicker.Checked = False
        ToDatePicker.Format = DateTimePickerFormat.Custom
        ToDatePicker.CustomFormat = " "
        ToDatePicker.Checked = False

        Dim connectionString As String = GetConnectionString()

        'defining queries
        Dim queryVehicleMake As String = "SELECT distinct Make from dbo.Vehicle"

        'setting query results into datatables, then setting data tables to data source of comboBoxes
        'First populate the Make Box
        Using connection As SqlConnection = New SqlConnection(connectionString)
            connection.Open()
            Using makeSource As SqlCommand = New SqlCommand(queryVehicleMake, connection)
                'first for vehicle make
                Dim reader As SqlDataReader = makeSource.ExecuteReader
                Dim dataTable As DataTable = New DataTable

                'load result of reader into dataTable
                dataTable.Load(reader)

                'iterate through all rows of dataTable and add to combobox
                For i = 0 To dataTable.Rows.Count - 1
                    VehicleMakeCombobox.Items.Add(dataTable.Rows(i).Item(0).ToString)
                Next
            End Using
            connection.Close()
        End Using

        'REMEMBER TO ADD BACK THE CONNECTION THINGS HERE

    End Sub

    'returns the string we add as the return value
    Private Shared Function GetConnectionString() As String
        Return "Server=DESKTOP-KPG72J8;Database=CMPT291_GROUP; Trusted_Connection=True"
        'Return "Server=STEVENPC\LOCALDB;Database=CMPT291_GROUP;Integrated Security=True;Trusted_Connection=True"
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReportResultsBox.SelectedIndexChanged

    End Sub

    Private Sub ToDateLabel_Click(sender As Object, e As EventArgs) Handles ToDateLabel.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles AccountNumberTextbox.TextChanged

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles FirstNameLabel.Click

    End Sub

    Private Sub VehicleMakeCombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VehicleMakeCombobox.SelectedIndexChanged
        Dim connectionString As String = GetConnectionString()

        Dim queryVehicleModel As String = "Select distinct Model from dbo.Vehicle where"
        queryVehicleModel += " Make='" + VehicleMakeCombobox.SelectedItem.ToString + "'"

        VehicleModelCombobox.ResetText()
        VehicleModelCombobox.Items.Clear()

        Using connection As SqlConnection = New SqlConnection(connectionString)
            connection.Open()
            'repeat for vehicle make
            Using makeSource As SqlCommand = New SqlCommand(queryVehicleModel, connection)
                'first for vehicle make
                Dim reader As SqlDataReader = makeSource.ExecuteReader
                Dim dataTable As DataTable = New DataTable

                'load result of reader into dataTable
                dataTable.Load(reader)

                'iterate through all rows of dataTable and add to combobox
                For i = 0 To dataTable.Rows.Count - 1
                    VehicleModelCombobox.Items.Add(dataTable.Rows(i).Item(0).ToString)
                Next
            End Using
            connection.Close()
        End Using
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Dim connectionString As String = GetConnectionString()
        Dim flag As Integer = 0

        Dim carQuery As String = "SELECT DISTINCT * from dbo.Vehicle as V, dbo.Rental_Log as R where"
        If Not VehicleMakeCombobox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " V.Make='" + VehicleMakeCombobox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and V.Make='" + VehicleMakeCombobox.Text + "'"
            End If
        End If
        If Not VehicleModelCombobox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " V.Model='" + VehicleModelCombobox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and V.Model='" + VehicleModelCombobox.Text + "'"
            End If
        End If
        If Not PhoneTextbox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " R.Phone_Number='" + PhoneTextbox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and R.Phone_Number='" + PhoneTextbox.Text + "'"
            End If
        End If
        If Not VehicleIDTextbox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " V.Vehicle_ID='" + VehicleIDTextbox.Text + "'" '"' and R.Vehicle_ID='" + VehicleIDTextbox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and V.Vehicle_ID='" + VehicleIDTextbox.Text + "'" '"' and R.Vehicle_ID='" + VehicleIDTextbox.Text + "'"
            End If
        End If
        If Not FirstNameTextBox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " R.FirstName='" + FirstNameTextBox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and R.FirstName='" + FirstNameTextBox.Text + "'"
            End If
        End If
        If Not SurnameTextbox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " R.LastName='" + SurnameTextbox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and R.LastName='" + SurnameTextbox.Text + "'"
            End If
        End If
        If Not AccountNumberTextbox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " R.Account_Number='" + AccountNumberTextbox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and R.Account_Number='" + AccountNumberTextbox.Text + "'"
            End If
        End If
        If Not FromDatePicker.Value.ToString = "" And FromDatePicker.Checked = True Then
            Dim chosenDate As String = FromDatePicker.Value.ToString
            Dim splitDate() As String = chosenDate.Split("-")
            Dim splitYear() As String = splitDate(2).ToString.Split(" ")
            If flag = 0 Then
                carQuery += " R.From_Year<='" + splitDate(0) + "' and R.From_Month<='" + splitDate(1) + "' and R.From_Date<='" + splitYear(0) + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and R.From_Year<='" + splitDate(0) + "' and R.From_Month<='" + splitDate(1) + "' and R.From_Date<='" + splitYear(0) + "'"
            End If
        End If
        If Not ToDatePicker.Value.ToString = "" And ToDatePicker.Checked = True Then
            Dim chosenDate As String = ToDatePicker.Value.ToString
            Dim splitDate() As String = chosenDate.Split("-")
            Dim splitYear() As String = splitDate(2).ToString.Split(" ")
            If flag = 0 Then
                carQuery += " R.To_Year>='" + splitDate(0) + "' and R.To_Month>='" + splitDate(1) + "' and R.To_Date>='" + splitYear(0) + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and R.To_Year>='" + splitDate(0) + "' and R.To_Month>='" + splitDate(1) + "' and R.To_Date>='" + splitYear(0) + "'"
            End If
        End If
        'If flag = 1 Then
        'carQuery += " and Vehicle_ID=Vehicle_ID1"
        'End If

        'setting date picker default values to ' ' for checking in if statements.
        FromDatePicker.Format = DateTimePickerFormat.Custom
        FromDatePicker.CustomFormat = " "
        FromDatePicker.Checked = False
        ToDatePicker.Format = DateTimePickerFormat.Custom
        ToDatePicker.CustomFormat = " "
        ToDatePicker.Checked = False

        ReportResultsBox.Items.Add(carQuery)
        ReportResultsBox.Refresh()
        Dim SQLDA As SqlDataAdapter
        Dim SQLDataSet As DataSet

        'REMEMBER TO ADD BACK THE CONNECTION THINGS HERE
        Using connection As New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()

            Try
                connection.Open()
                command = New SqlCommand(carQuery, connection)

                'load sql records for datagrid
                SQLDA = New SqlDataAdapter(command)
                SQLDataSet = New DataSet

                'fill dataset with whatever comes out of adapter
                SQLDA.Fill(SQLDataSet)

                'fill datagrid with contents of DataSet IF query actually returned information
                'sorted by tables.
                If SQLDataSet.Tables.Count > 0 Then
                    DataGridResults.DataSource = SQLDataSet.Tables(0)
                End If

                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)

                'close connection in case DataAdapter fails
                If (connection.State = ConnectionState.Open) Then
                    connection.Close()
                End If

            End Try

        End Using



    End Sub

    Private Sub FromDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles FromDatePicker.ValueChanged
        FromDatePicker.Checked = True
        FromDatePicker.Format = DateTimePickerFormat.Short
        'FromDatePicker.Value = Date.Now
    End Sub

    Private Sub ToDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles ToDatePicker.ValueChanged
        ToDatePicker.Checked = True
        ToDatePicker.Format = DateTimePickerFormat.Short
        'ToDatePicker.Value = Date.Now
    End Sub

    Private Sub VehicleModelCombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VehicleModelCombobox.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridResults.CellContentClick

    End Sub
End Class