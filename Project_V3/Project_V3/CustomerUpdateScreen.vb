Imports System.Data.SqlClient
Public Class CustomerUpdateScreen
    Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    'Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    'Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        Dim CID As Integer  'Declare the CID counter 
        Dim Fname As String  'Declare the CID counter
        Dim Lname As String  'Declare the CID counter
        Dim Address As String  'Declare the CID counter
        Dim Telephone As Integer
        Dim Email As String
        Dim AccountNum As Integer
        Dim AccountType As String

        CID = 1 'Initialize the CID counter to 1

        'This If statement will change the label showing an error message in red
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            lbl_Conn.Text = "***ERROR: Customer NOT added***"
            lbl_Conn.ForeColor = Color.Red
            connection.Close()
        End If

        Dim insertQuery As String = "INSERT INTO Customer (FName, LName, Address, Email) VALUES('" & FirstNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & AddressTextBox.Text & "', '" & EmailTextBox.Text & "')"
        'Dim insertQueryint As Integer = "INSERT INTO Customer (CID, Telephone, AccountNum, CreditCardNumber, OrderCount, Rating) VALUES('" & CID & "', '" & TelephoneTextBox.Text & "', '" & CID & "', '" & CreditCardTextBox.Text & "', '" & CID & "', '" & CID & "')"
        ExecuteQuery(insertQuery)

        MessageBox.Show("Data Has Been updated")    'This will pop up a confirmation window

        CID += 1    'Increment the CID counter 
    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub lbl_Conn_Click(sender As Object, e As EventArgs) Handles lbl_Conn.Click

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged

    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub TelephoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelephoneTextBox.TextChanged

    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub CreditCardTextBox_TextChanged(sender As Object, e As EventArgs) Handles CreditCardTextBox.TextChanged

    End Sub

    Private Sub PlanTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlanTypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub
End Class
