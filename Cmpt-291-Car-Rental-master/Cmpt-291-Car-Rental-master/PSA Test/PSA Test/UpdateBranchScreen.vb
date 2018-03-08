
Imports System.Data.SqlClient
Public Class UpdateBranchScreen

    Private Sub UpdateBranchScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'returns the string we add as the return value
    Private Shared Function GetConnectionString() As String
        Return "Server=DESKTOP-KPG72J8;Database=CMPT291_GROUP; Trusted_Connection=True"

    End Function

    'handler generated when we create a button. The actual events within the button 
    'handler is defined by us.
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        Dim connectionString As String = GetConnectionString()

        Dim comma As Integer


        Dim updateCmd As String = "update dbo.Branch Set "

        If Not BranchTextBox.Text = String.Empty Then

            updateCmd += "Name = '" & BranchTextBox.Text & "'"
            comma = 1

        End If

        If Not StreetTextBox.Text = String.Empty Then
            If comma = 0 Then
                updateCmd += "Address_Street = '" & StreetTextBox.Text & "'"
                comma = 1
            Else
                updateCmd += " ,Address_Street = '" & StreetTextBox.Text & "'"
            End If
        End If
        If Not AveTextBox.Text = String.Empty Then
            If comma = 0 Then
                updateCmd += "Address_Ave = '" & AveTextBox.Text & "'"
                comma = 1
            Else
                updateCmd += " ,Address_Ave = '" & AveTextBox.Text & "'"
            End If
        End If

        If Not CityTextBox.Text = String.Empty Then
            If comma = 0 Then
                updateCmd += "City = '" & CityTextBox.Text & "'"
                comma = 1
            Else
                updateCmd += " ,City = '" & CityTextBox.Text & "'"
            End If
        End If
        If Not CountryTextbox.Text = String.Empty Then
            If comma = 0 Then
                updateCmd += "Country = '" & CountryTextbox.Text & "'"
                comma = 1
            Else
                updateCmd += " ,Country = '" & CountryTextbox.Text & "'"
            End If
        End If
        If Not PostalCodeTextBox.Text = String.Empty Then
            If comma = 0 Then
                updateCmd += "Postal_Code = '" & PostalCodeTextBox.Text & "'"
                comma = 1
            Else
                updateCmd += " ,Postal_Code = '" & PostalCodeTextBox.Text & "'"
            End If
        End If

        If Not PhoneNumberTextBox.Text = String.Empty Then
            If comma = 0 Then
                updateCmd += "Phone_Number = '" & PhoneNumberTextBox.Text & "'"
                comma = 1
            Else
                updateCmd += " ,Phone_Number = '" & PhoneNumberTextBox.Text & "'"
            End If
        End If
        Dim flag As Integer = 0

        If BranchIDTextBox.Text = String.Empty Then
            HiddenMsg.Show()
            HiddenMsg.ForeColor = Color.Red
            flag = 1

        Else

            updateCmd += " where Branch_ID ='" & BranchIDTextBox.Text & "'"

        End If

        If flag = 0 Then

            ResultsBox.Items.Add(updateCmd)

            Using connection As SqlConnection = New SqlConnection(connectionString)

                Using command As SqlCommand = New SqlCommand(updateCmd, connection)

                    Try
                        connection.Open()

                        command.CommandType = CommandType.Text

                        If (command.ExecuteNonQuery().Equals(1)) Then
                            ResultsBox.Items.Add("Branch info updated")
                        Else
                            ResultsBox.Items.Add("Error updating. Try again")
                        End If

                        'Catch Exception if data u
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)

                    End Try

                End Using
                connection.Close()
            End Using
        End If
    End Sub
    Private Sub UpdateBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles BranchButton.Click

    'End Sub
End Class
