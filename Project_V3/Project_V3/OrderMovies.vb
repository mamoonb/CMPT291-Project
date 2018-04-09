Imports System.Data.SqlClient
Public Class OrderMovies
    'Dim connection As New SqlConnection("Server = MAMOON-XPS;Database = project;Integrated Security = true ")
    'Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
    Dim command As New SqlCommand
    Dim count As Int16
    Dim MovieID As String
    Private Sub ViewMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub

    Public Sub FilterData(valueToSearch)
        Dim searchQuery As String = "SELECT MID, Name, Genre, Copies, Rating From Movie WHERE CONCAT(MID, Name, Genre, Copies, Rating) like '%" & SearchBox.Text & "%' "
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim oForm As CustomerMenu
        oForm = New CustomerMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        FilterData(SearchBox.Text)
    End Sub

    Private Sub Order_Click(sender As Object, e As EventArgs) Handles Order.Click
        Dim query As String = "SELECT COUNT(OID) AS OIDcount FROM [Order]"
        Dim todayDate As String = DateTime.Now.ToShortDateString()

        'If selectedRow = NULL Then
        '    MessageBox.Show("Error. Please fill out all the required fields")

        'Else
        connection.Open()
        getOIDCount(query)

        command.Connection = connection
        command.CommandText = "INSERT INTO [Order] (OID, CID, MID, CheckIn, Checkout) VALUES ('" & count & "', '" & 1.ToString() & "', '" & MovieID & "', '" & 12 & "', '" & todayDate & "')"
        'command.CommandText = "INSERT INTO Order(OID, CID, Checkin, Checkout)  VALUES ('" & OrderID & "', '" & 1 & "', '" & 12 & "', '" & todayDate & "')"
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Order has been placed ")
        decrementCount()

    End Sub

    Private Sub decrementCount()
        Dim query As String = "SELECT COUNT(MID) AS OMIDcount FROM Movie"
        connection.Open()
        'Dim count1 As String = "SELECT Copies FROM Movie INNER JOIN Movie on Movie.MID = '" & MovieID & "' "
        Dim count1 As String = "SELECT Copies FROM Movie WHERE Movie.MID ='" & MovieID & "' "
        Dim count2 As Int16
        Int16.TryParse(count1, count2)
        count2 = count2
        count1 = count2.ToString()
        command.Connection = connection
        'command.CommandText = "UPDATE [Movie] SET Copies = @Copies WHERE Movie.MID = '" & MovieID & "'"
        command.CommandText = "UPDATE Movie SET Copies = '" & count1 & "' WHERE MID = " & MovieID & " "
        'Try
        'command.Parameters.AddWithValue("@Copies", count1)
        'Catch ex As Exception

        'End Try
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub getOIDCount(query As String)

        'Dim connStr As String = "Server = Server = MAMOON-XPS; Database = project;Integrated Security = true "
        Dim connStr As String = "Server = LAPTOP-7VEJQMDT; Database = project;Integrated Security = true "
        'Dim query As String = "SELECT COUNT(CID) AS CIDcount FROM Customer"
        Using conn As New SqlConnection(connStr)
            Using comm As New SqlCommand()
                With comm
                    conn.Open()
                    .Connection = conn
                    .CommandText = query
                    .CommandType = CommandType.Text
                End With
                Try
                    count = Convert.ToInt16(comm.ExecuteScalar())
                    count.ToString()
                Catch ex As SqlException
                    ' Count unable to return value  '
                End Try
            End Using
        End Using
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        MovieID = selectedRow.Cells(0).Value
        MovieID = MovieID.ToString().Trim()
    End Sub
End Class