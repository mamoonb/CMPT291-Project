' www.youtube.com/watch?v=FClfOn3a4C8
Imports System.Data.SqlClient
Public Class AllEmployee
    Private SQL As New SQLControl
    Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
    'Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")

    Private Sub AllEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.ExecQuery("SELECT * FROM Employee")

        '(SQL.RecordCount)

        loadGrid()

    End Sub

    Private Sub LoadGrid()
        If SQL.RecordCount > 0 Then
            DataGridView1.DataSource = SQL.SQLDS.Tables(0)
            DataGridView1.Rows(0).Selected = True

            SQL.SQLDA.UpdateCommand = New SqlCommandBuilder(SQL.SQLDA).GetUpdateCommand
        End If

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        SQL.SQLDA.Update(SQL.SQLDS)

        LoadGrid()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        FilterData(SearchBox.Text)
    End Sub

    Public Sub FilterData(valueToSearch)
        Dim searchQuery As String = "SELECT * From Employee WHERE CONCAT(EID,SIN, FName, LName, Telephone, StreetName, StreetNum, ApptName, City, State, ZIP, StartDate, HourlyRate) like '%" & SearchBox.Text & "%' "
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
End Class