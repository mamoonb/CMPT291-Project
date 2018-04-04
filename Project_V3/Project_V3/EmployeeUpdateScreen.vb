﻿Imports System.Data.SqlClient
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
        Dim todaydate As String = DateTime.Now.ToShortDateString()

        If SINTextBox.Text.Length = 0 Or FNameTextBox.Text.Length = 0 Or LNameTextBox.Text.Length = 0 Or StreetNameTextBox.Text.Length = 0 Or StreetNumTextBox.Text.Length = 0 Or CityTextBox.Text.Length = 0 Or StateTextBox.Text.Length = 0 Or ZipTextBox.Text.Length = 0 Or StartDateTextBox.Text.Length = 0 Or HourlyRateTextBox.Text.Length = 0 Then
            MessageBox.Show("Error.Please fill out all the required fields...")

            '----------------------------------------------------
            'FirstNameTextBox.Text = Nothing
        Else
            connection.Open()
            getCIDCount(query)
            command.Connection = connection
            command.CommandText = "INSERT INTO Employee (EID,SIN, FName, LName, Telephone, StreetName, StreetNum, ApptNum, City, State, ZIP, StartDate, HourlyRate) VALUES('" & count & "', '" & SINTextBox.Text & "', '" & FNameTextBox.Text & "', '" & LNameTextBox.Text & "', '" & TelephoneTextBox.Text & "', '" & StreetNameTextBox.Text & "', '" & StreetNumTextBox.Text & "', '" & ApptNumTextBox.Text & "', '" & CityTextBox.Text & "', '" & StateTextBox.Text & "', '" & ZipTextBox.Text & "', '" & StartDateTextBox.Text & "', '" & HourlyRateTextBox.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()


            MessageBox.Show("Data Has Been updated")    'This will pop up a confirmation window

            SINTextBox.Text = Nothing
            FNameTextBox.Text = Nothing
            LNameTextBox.Text = Nothing
            TelephoneTextBox.Text = Nothing
            StreetNameTextBox.Text = Nothing
            StreetNumTextBox.Text = Nothing
            CityTextBox.Text = Nothing
            StateTextBox.Text = Nothing
            ApptNumTextBox.Text = Nothing
            ZipTextBox.Text = Nothing
            StartDateTextBox.Text = Nothing
            HourlyRateTextBox.Text = Nothing

        End If

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

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TelephoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelephoneTextBox.TextChanged

    End Sub

    Private Sub StartDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StartDateTextBox.TextChanged

    End Sub

    Private Sub HourlyRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles HourlyRateTextBox.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

    End Sub
End Class