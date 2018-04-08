
Imports System.Data.SqlClient
Public Class AddMovie
    'Dim connection As New SqlConnection("Server = MAMOON-XPS;Database = project;Integrated Security = true ")
    Dim connection As New SqlConnection("Server = Server = MAMOON-XPS;Database = project;Integrated Security = true ")
    Dim command As New SqlCommand
    Dim count As Int16

    Private Sub AddMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim query As String = "SELECT COUNT(MID) AS MIDcount FROM Movie"
        connection.Open()
        getCIDCount(query)
        command.Connection = connection
        command.CommandText = "INSERT INTO Movie (MID, Name, Genre, DistributionFee, Copies, Rating) VALUES('" & count & "','" & MovieName.Text & "', '" & MovieType.Text & "', '" & DistributionFee.Text & "', '" & NumberOfCopies.Text & "', '" & Rating.Text & "')"
        command.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Data Has Been Updated")    'This will pop up a confirmation window
        MovieName.Text = Nothing
        MovieType.Text = Nothing
        DistributionFee.Text = Nothing
        NumberOfCopies.Text = Nothing
        Rating.Text = Nothing

    End Sub

    'Count the number of Customers in the SQL table and convert it to a String 
    Public Sub getCIDCount(query As String)
        Dim connStr As String = "Server = MAMOON-XPS;Database = project;Integrated Security = true "
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MoiveNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles MovieName.TextChanged

    End Sub

    Private Sub MovieTypeTextBox_TextChanged(sender As Object, e As EventArgs) Handles MovieType.TextChanged

    End Sub

    Private Sub TDistributionFeeTextBox_TextChanged(sender As Object, e As EventArgs) Handles DistributionFee.TextChanged

    End Sub

    Private Sub NumberOfCopiesTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumberOfCopies.TextChanged

    End Sub

    Private Sub RatingTextBox_TextChanged(sender As Object, e As EventArgs) Handles Rating.TextChanged

    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub MovieName_TextChanged(sender As Object, e As EventArgs) Handles MovieName.TextChanged

    End Sub

    Private Sub MovieType_TextChanged(sender As Object, e As EventArgs) Handles MovieType.TextChanged

    End Sub
End Class