Imports System.Data.SqlClient
'﻿Imports System.Data.SqlClient
Public Class CustomerUpdateScreen
    '<<<<<<< HEAD
    'Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
    '=======
    '<<<<<<< HEAD
    'adrian
    Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")

    'tahmid
    'Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")

    '=======
    'Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
    '>>>>>>> 0dff35cac2a491088bd08adc7a66a45dc84e9179
    '>>>>>>> master
    Dim command As New SqlCommand
    Dim count As Int16
    'Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
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
            StreetNameTextBox.Text = Nothing
            StreetNumTextBox.Text = Nothing
            ApptNumTextBox.Text = Nothing
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
        '<<<<<<< HEAD
        'Dim connStr As String = "Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true "
        '=======
        '<<<<<<< HEAD
        'adrian
        Dim connStr As String = "Server = DESKTOP-4GN0VE3; Database = project;Integrated Security = true "
        'tahmid
        'Dim connStr As String = "Server = LAPTOP-7VEJQMDT; Database = project;Integrated Security = true "

        '=======
        'Dim connStr As String = "Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true "
        '>>>>>>> 0dff35cac2a491088bd08adc7a66a45dc84e9179
        '>>>>>>> master
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


    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Dim oForm As CustomerMenu
        oForm = New CustomerMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub UserName_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub StreetNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetNameTextBox.TextChanged

    End Sub

    Private Sub StreetNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetNumTextBox.TextChanged

    End Sub

    Private Sub ApptNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles ApptNumTextBox.TextChanged

    End Sub

    Private Sub EditButton_Click_1(sender As Object, e As EventArgs) Handles EditButton.Click

    End Sub
End Class
'>>>>>>> ed50f17c66eaae98d373d61b7f9e45650f00566a
