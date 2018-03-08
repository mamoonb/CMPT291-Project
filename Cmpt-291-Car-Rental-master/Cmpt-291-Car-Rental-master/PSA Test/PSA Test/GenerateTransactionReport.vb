Imports System.Data.SqlClient

Public Class GenerateTransactionReport
    Private Sub GenerateTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setting date picker default values to ' ' for checking in if statements.
        FromDatePicker.Format = DateTimePickerFormat.Custom
        FromDatePicker.CustomFormat = " ".ToString
        FromDatePicker.Checked = False
        ToDatePicker.Format = DateTimePickerFormat.Custom
        ToDatePicker.CustomFormat = " ".ToString
        ToDatePicker.Checked = False

        Dim connectionString As String = GetConnectionString()

        'defining queries
        Dim queryGetYear As String = "SELECT distinct From_Year from dbo.Rental_Log"

        'setting query results into datatables, then setting data tables to data source of comboBoxes
        'First populate the Year Box
        Using connection As SqlConnection = New SqlConnection(connectionString)
            connection.Open()
            Using makeSource As SqlCommand = New SqlCommand(queryGetYear, connection)
                'first for vehicle make
                Dim reader As SqlDataReader = makeSource.ExecuteReader
                Dim dataTable As DataTable = New DataTable

                'load result of reader into dataTable
                dataTable.Load(reader)

                'iterate through all rows of dataTable and add to combobox
                For i = 0 To dataTable.Rows.Count - 1
                    YearCombobox.Items.Add(dataTable.Rows(i).Item(0).ToString)
                Next
            End Using
            connection.Close()
        End Using
    End Sub

    'returns the string we add as the return value
    Private Shared Function GetConnectionString() As String
        Return "Server=DESKTOP-KPG72J8;Database=CMPT291_GROUP; Trusted_Connection=True"
        'Return "Server=STEVENPC\LOCALDB;Database=CMPT291_GROUP;Integrated Security=True;Trusted_Connection=True"
    End Function

    Private Sub Year_Click(sender As Object, e As EventArgs) Handles YearLabel.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles FirstNameLabel.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles AccountNumberLabel.Click

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim connectionString As String = GetConnectionString()
        Dim flag As Integer = 0

        Dim transactionQuery As String = "SELECT * from dbo.Rental_Log as R, dbo.Customer as C where"
        If Not FirstNameTextbox.Text = String.Empty Then
            If flag = 0 Then
                transactionQuery += " C.FirstName='" + FirstNameTextbox.Text + "' and C.Driver_ID=R.Driver_ID"
                flag = 1
            ElseIf flag = 1 Then
                transactionQuery += " and C.FirstName='" + FirstNameTextbox.Text + "' and C.Driver_ID=R.Driver_ID"
            End If
        End If
        If Not SurnameTextbox.Text = String.Empty Then
            If flag = 0 Then
                transactionQuery += " C.LastName='" + SurnameTextbox.Text + "' and C.Driver_ID=R.Driver_ID"
                flag = 1
            ElseIf flag = 1 Then
                transactionQuery += " and C.LastName='" + SurnameTextbox.Text + "' and C.Driver_ID=R.Driver_ID"
            End If
        End If
        If Not AccountNumberTextbox.Text = String.Empty Then
            If flag = 0 Then
                transactionQuery += " R.Account_Number='" + AccountNumberTextbox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                transactionQuery += " and R.Account_Number='" + AccountNumberTextbox.Text + "'"
            End If
        End If
        If Not FromDatePicker.Value.ToString = "" And FromDatePicker.Checked = True Then
            Dim chosenDate As String = FromDatePicker.Value.ToString
            Dim splitDate() As String = chosenDate.Split("-")
            Dim splitYear() As String = splitDate(2).ToString.Split(" ")
            If flag = 0 Then
                transactionQuery += " R.From_Year<='" + splitDate(0) + "' and R.From_Month<='" + splitDate(1) + "' and R.From_Date<='" + splitYear(0) + "'"
                flag = 1
            ElseIf flag = 1 Then
                transactionQuery += " and R.From_Year<='" + splitDate(0) + "' and R.From_Month<='" + splitDate(1) + "' and R.From_Date<='" + splitYear(0) + "'"
            End If
        End If
        If Not ToDatePicker.Value.ToString = "" And ToDatePicker.Checked = True Then
            Dim chosenDate As String = ToDatePicker.Value.ToString
            Dim splitDate() As String = chosenDate.Split("-")
            Dim splitYear() As String = splitDate(2).ToString.Split(" ")
            If flag = 0 Then
                transactionQuery += " R.To_Year>='" + splitDate(0) + "' and R.To_Month>='" + splitDate(1) + "' and R.To_Date>='" + splitYear(0) + "'"
                flag = 1
            ElseIf flag = 1 Then
                transactionQuery += " and R.To_Year>='" + splitDate(0) + "' and R.To_Month>='" + splitDate(1) + "' and R.To_Date>='" + splitYear(0) + "'"
            End If
        End If
        ReportResultsBox.Items.Add(transactionQuery)
        ReportResultsBox.Refresh()

        'setting date picker default values to ' ' for checking in if statements.
        FromDatePicker.Format = DateTimePickerFormat.Custom
        FromDatePicker.CustomFormat = " "
        FromDatePicker.Checked = False
        ToDatePicker.Format = DateTimePickerFormat.Custom
        ToDatePicker.CustomFormat = " "
        ToDatePicker.Checked = False

        ReportResultsBox.Items.Add(transactionQuery)
        ReportResultsBox.Refresh()
        Dim SQLDA As SqlDataAdapter
        Dim SQLDataSet As DataSet

        'REMEMBER TO ADD BACK THE CONNECTION THINGS HERE
        Using connection As New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()

            Try
                connection.Open()
                command = New SqlCommand(transactionQuery, connection)

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
    End Sub

    Private Sub ToDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles ToDatePicker.ValueChanged
        ToDatePicker.Checked = True
        ToDatePicker.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridResults.CellContentClick

    End Sub
End Class