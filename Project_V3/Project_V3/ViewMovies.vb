Imports System.Data.SqlClient
Public Class ViewMovies
    Dim connection As New SqlConnection("Server = MAMOON-XPS;Database = project;Integrated Security = true ")
    Private Sub ViewMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub

    Public Sub FilterData(valueToSearch)
        Dim searchQuery As String = "SELECT * From Movie WHERE CONCAT(MID, Name, Genre, DistributionFee, Copies, Rating) like '%" & SearchBox.Text & "%' "
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
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

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        FilterData(SearchBox.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class