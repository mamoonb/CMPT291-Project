Imports System.Data.SqlClient
Public Class AllCustomer
    Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    Private Sub AllCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("SELECT * FROM Customer", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class