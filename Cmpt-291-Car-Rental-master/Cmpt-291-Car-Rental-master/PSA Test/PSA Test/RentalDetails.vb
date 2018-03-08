Imports System.Data.SqlClient

Public Class RentalDetails
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Shared Function GetConnectionString() As String
        Return "Server=DESKTOP-KPG72J8;Database=CMPT291_GROUP; Trusted_Connection=True"
        'Return "Server=STEVENPC\LOCALDB;Database=CMPT291_GROUP;Integrated Security=True;Trusted_Connection=True"
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles DriversLicenseTextbox.TextChanged

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        Dim connectionString As String = GetConnectionString()
        Dim flag As Integer = 0

        Dim insertQuery As String = "INSERT INTO dbo.Customer values('"

        insertQuery += DriversLicenseTextbox.Text + "','" + DriversLicenseTextbox.Text + "','" + FirstNameTextbox.Text + "','" + LastNameTextbox.Text + "','"
        insertQuery += AgeTextbox.Text + "','" + AddressTextbox.Text + "','" + StreetTextbox.Text + "','" + CityTextbox.Text + "','" + IssuingCountryTextbox.Text + "','"
        insertQuery += PhoneTextBox.Text + "','" + EmailTextBox.Text + "')"

        ResultsBox.Items.Add(insertQuery)

        'connectionString = GetConnectionString()

        Using connection As SqlConnection = New SqlConnection(connectionString)
            connection.Open()
            Using command As SqlCommand = New SqlCommand(insertQuery, connection)
                command.CommandType = CommandType.Text

                If (command.ExecuteNonQuery().Equals(1)) Then
                    ResultsBox.Items.Add("yay")
                Else
                    ResultsBox.Items.Add("nay")
                End If

            End Using
            connection.Close()
        End Using


    End Sub
End Class