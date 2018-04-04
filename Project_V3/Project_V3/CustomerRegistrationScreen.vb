
Imports System.Data.SqlClient
Public Class CustomerRegisterScreen
    Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    Dim command As New SqlCommand
    Dim count As Int16
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim query As String = "SELECT COUNT(CID) AS CIDcount FROM Customer"
        Dim todayDate As String = DateTime.Now.ToShortDateString()
        Dim Accttype As String = AccountTypeComboBox.Text

        If FirstNameTextBox.Text.Length = 0 Or LastNameTextBox.Text.Length = 0 Or StreetNameTextBox.Text.Length = 0 Or StreetNumTextBox.Text.Length = 0 Or CityTextBox.Text.Length = 0 Or StateTextBox.Text.Length = 0 Or ZipTextBox.Text.Length = 0 Or AccountTypeComboBox.Text.Length = 0 Or CreditCardTextBox.Text.Length = 0 Or UserNameTextBox.Text.Length = 0 Or PasswordTextBox.Text.Length = 0 Then
            MessageBox.Show("Error. Please fill out all the required fields")

        Else
            connection.Open()
            getCIDCount(query)
            command.Connection = connection
            command.CommandText = "INSERT INTO Customer (CID, FName, LName, StreetName, StreetNum, ApptNum, City, State, ZIP, Telephone, Email, AccountNum, AccountType, CreditCardNumber, OrderCount, Rating, DateCreated, UserName, Password) VALUES('" & count & "', '" & FirstNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & StreetNameTextBox.Text & "', '" & StreetNumTextBox.Text & "', '" & ApptNumTextBox.Text & "', '" & CityTextBox.Text & "', '" & StateTextBox.Text & "', '" & ZipTextBox.Text & "', '" & TelephoneTextBox.Text & "', '" & EmailTextBox.Text & "', '" & count & "', '" & Accttype & "', '" & CreditCardTextBox.Text & "', '" & 1 & "', '" & 1 & "', '" & todayDate & "','" & UserNameTextBox.Text & "','" & PasswordTextBox.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Data Has Been Updated")    'This will pop up a confirmation window
            FirstNameTextBox.Text = Nothing
            LastNameTextBox.Text = Nothing
            ApptNumTextBox.Text = Nothing
            StreetNameTextBox.Text = Nothing
            StreetNumTextBox.Text = Nothing
            CityTextBox.Text = Nothing
            StateTextBox.Text = Nothing
            ZipTextBox.Text = Nothing
            AccountTypeComboBox.Text = Nothing
            CreditCardTextBox.Text = Nothing
            UserNameTextBox.Text = Nothing
            PasswordTextBox.Text = Nothing

        End If
    End Sub

    'Count the number of Customers in the SQL table and convert it to a String 
    Public Sub getCIDCount(query As String)
        Dim connStr As String = "Server = DESKTOP-4GN0VE3; Database = project;Integrated Security = true "
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

    Private Sub lbl_Conn_Click(sender As Object, e As EventArgs)

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

    Private Sub AccountTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountTypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub StreetNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetNameTextBox.TextChanged

    End Sub

    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub UserNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub ZipTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipTextBox.TextChanged

    End Sub

    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

    End Sub

    Private Sub StreetNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetNumTextBox.TextChanged

    End Sub

    Private Sub ApptNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles ApptNumTextBox.TextChanged

    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub PlanTypeLabel_Click(sender As Object, e As EventArgs) Handles AccountTypeLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class
