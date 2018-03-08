Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class CarSearch
    Private Sub CarSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'returns the string we add as the return value
    Private Shared Function GetConnectionString() As String
        Return "Server=DESKTOP-KPG72J8;Database=CMPT291_GROUP; Trusted_Connection=True"
    End Function

    'a query predefined by us
    Dim query As String = "SELECT * from dbo.Branch"

    'handler generated when we create a button. The actual events within the button 
    'handler is defined by us.
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim connectionString As String = GetConnectionString()

        SearchQuery.Text = query

        Using connection As New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = query

            Try
                connection.Open()
                'sends our CommandText(query) to the connection at command
                Dim dataReader As SqlDataReader = command.ExecuteReader
                ResultBox.Clear()
                Do While dataReader.Read()
                    ResultBox.Text += dataReader(1).ToString
                Loop

                ResultBox.Refresh()

                dataReader.Close()

            Catch ex As Exception
                Console.WriteLine(ex.Message)

            End Try

        End Using

    End Sub

    Private Sub MakeBox_TextChanged(sender As Object, e As EventArgs) Handles MakeBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Dim connectionString As String = GetConnectionString()
        Dim flag As Integer = 0

        Dim carQuery As String = "SELECT * from dbo.Vehicle where"
        If Not MakeBox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " Make='" + MakeBox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and Make='" + MakeBox.Text + "'"
            End If
        End If
        If Not YearBox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " Year='" + YearBox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and Year='" + YearBox.Text + "'"
            End If
        End If
        If Not ModelBox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " Model='" + ModelBox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and Model='" + ModelBox.Text + "'"
            End If
        End If
        If Not CapacityBox.Text = String.Empty Then
            If flag = 0 Then
                carQuery += " Capacity='" + CapacityBox.Text + "'"
                flag = 1
            ElseIf flag = 1 Then
                carQuery += " and Capacity='" + CapacityBox.Text + "'"
            End If
        End If

        SearchQuery.Text = carQuery

        Using connection As New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = carQuery

            Try
                connection.Open()
                'sends our CommandText(query) to the connection at command
                Dim dataReader As SqlDataReader = command.ExecuteReader
                ResultBox.Clear()

                Do While dataReader.Read()
                    ResultBox.Text += dataReader("Vehicle_ID").ToString
                Loop

                ResultBox.Refresh()

                dataReader.Close()

            Catch ex As Exception
                Console.WriteLine(ex.Message)

            End Try

        End Using

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchQuery.TextChanged

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim newExtras = New Extras
        newExtras.MdiParent = Me.MdiParent
        newExtras.Show()
    End Sub
End Class
