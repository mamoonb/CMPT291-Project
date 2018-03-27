﻿
Imports System.Data.SqlClient
Public Class CustomerUpdateScreen
    Dim connection As New SqlConnection("Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true ")
    Dim command As New SqlCommand
    Dim count As Int16
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim query As String = "SELECT COUNT(CID) AS CIDcount FROM Customer"

        connection.Open()
        Dim todayDate As String = DateTime.Now.ToShortDateString()
        Dim Plantype As String = PlanTypeComboBox.Text
        getCIDCount(query)
        command.Connection = connection
        command.CommandText = "INSERT INTO Customer (CID, FName, LName, Address, Telephone, Email, AccountNum, AccountType, CreditCardNumber, OrderCount, Rating, DateCreated) VALUES('" & count & "', '" & FirstNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & AddressTextBox.Text & "', '" & TelephoneTextBox.Text & "', '" & EmailTextBox.Text & "', '" & count & "', '" & Plantype & "', '" & CreditCardTextBox.Text & "', '" & 1 & "', '" & 1 & "', '" & todayDate & "')"
        command.ExecuteNonQuery()
        connection.Close()


        'This If statement will change the label showing an error message in red
        'If connection.State = ConnectionState.Closed Then
        'connection.Open()
        'lbl_Conn.Text = "***ERROR: Customer NOT added***"
        'lbl_Conn.ForeColor = Color.Red
        'connection.Close()
        'End If

        MessageBox.Show("Data Has Been updated")    'This will pop up a confirmation window
        FirstNameTextBox.Text = Nothing
        PlanTypeComboBox.Text = Nothing

    End Sub

    'Count the number of Customers in the SQL table and convert it to a String 
    Public Sub getCIDCount(query As String)
        Dim connStr As String = "Server = DESKTOP-4GN0VE3;Database = project;Integrated Security = true "
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

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class
