Imports System.Data.SqlClient
Public Class EmployeeUpdateScreen
    Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
    Dim command As New SqlCommand
    Dim count As Int16
    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub EmployeeUpdateScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim query As String = "SELECT COUNT(EID) AS EIDcount FROM Employee"

        connection.Open()
        getCIDCount(query)
        command.Connection = connection
        command.CommandText = "INSERT INTO Employee (EID,SIN, FName, LName, Telephone, Address, StartDate, HourlyRate) VALUES('" & count & "', '" & SINTextBox.Text & "', '" & FNameTextBox.Text & "', '" & LNameTextBox.Text & "', '" & TelephoneTextBox.Text & "', '" & AddressTextBox.Text & "', '" & 123 & "', '" & HourlyRateTextBox.Text & "')"
        command.ExecuteNonQuery()
        connection.Close()


        MessageBox.Show("Data Has Been updated")    'This will pop up a confirmation window


    End Sub

    'Count the number of Customers in the SQL table and convert it to a String 
    Public Sub getCIDCount(query As String)
        Dim connStr As String = "Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true "
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

    Private Sub SINTextBox_TextChanged(sender As Object, e As EventArgs) Handles SINTextBox.TextChanged

    End Sub

    Private Sub FNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FNameTextBox.TextChanged

    End Sub

    Private Sub LNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LNameTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub TelephoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelephoneTextBox.TextChanged

    End Sub

    Private Sub StartDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StartDateTextBox.TextChanged

    End Sub

    Private Sub HourlyRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles HourlyRateTextBox.TextChanged

    End Sub
End Class