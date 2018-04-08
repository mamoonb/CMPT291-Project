Imports System.Data.SqlClient
<<<<<<< HEAD
Public Class Login
=======

Public Class Login
    'Dim connection As New SqlConnection("Server = MAMOON-XPS;Database = project;Integrated Security = true ")
>>>>>>> Mamoon
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim oForm As CustomerRegisterScreen
        oForm = New CustomerRegisterScreen()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

<<<<<<< HEAD
    Private Sub Log_InCustomer_Click(sender As Object, e As EventArgs) Handles Log_InCustomer.Click
        Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
        connection.Open()
        Dim command As New SqlCommand("select * from LoginCustomer where UserName=@username and Password=@password", connection)


        command.Parameters.Add("@username", SqlDbType.VarChar).Value = UserTextBox.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = PassTextBox.Text


        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are Invalid")

        Else

            Dim oForm As CustomerMenu
            oForm = New CustomerMenu()
            oForm.Show()
            oForm = Nothing
            Me.Hide()
        End If
        connection.Close()
    End Sub

    Private Sub Log_InManager_Click(sender As Object, e As EventArgs) Handles Log_InManager.Click
        Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
        connection.Open()
        Dim command As New SqlCommand("select * from LoginManager where UserName=@username and Password=@password", connection)


        command.Parameters.Add("@username", SqlDbType.VarChar).Value = UserTextBox.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = PassTextBox.Text


        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are Invalid")

        Else

            Dim oForm As EmployeeMenu
            oForm = New EmployeeMenu()
            oForm.Show()
            oForm = Nothing
            Me.Hide()
        End If
        connection.Close()
    End Sub

    Private Sub Log_InEmployee_Click(sender As Object, e As EventArgs) Handles Log_InEmployee.Click
        Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
        connection.Open()
        Dim command As New SqlCommand("select * from LoginEmployee where UserName=@username and Password=@password", connection)


        command.Parameters.Add("@username", SqlDbType.VarChar).Value = UserTextBox.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = PassTextBox.Text


        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are Invalid")

        Else

            Dim oForm As EmployeeMenu
            oForm = New EmployeeMenu()
            oForm.Show()
            oForm = Nothing
            Me.Hide()
        End If
        connection.Close()
    End Sub

=======
    Private Sub Log_In_Click(sender As Object, e As EventArgs) Handles Log_In.Click
        Dim connection As New SqlConnection("Server = MAMOON-XPS;Database = project;Integrated Security = true ")
        connection.Open()
        Dim command As New SqlCommand("select UserName, Password, AccountType from Login where UserName = @username and Password = @password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = UNTextBox.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = PWTextBox.Text

        ' connection.Close()

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        'Dim conn As New SqlConnection("Server = MAMOON-XPS;Database = project;Integrated Security = true ")

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password is Incorrect")

        Else
            Dim Query As String
            'Dim Type As String
            'Query = String.Format("select AccountType from Login where UserName = '{0}'", Me.AccountType.Text.Trim())
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                If reader.HasRows = True Then
                    If reader(3).ToString = "Manager" Then
                        Dim oForm As EmployeeMenu
                        oForm = New EmployeeMenu()
                        oForm.Show()
                        oForm = Nothing
                        Me.Hide()
                    End If
                End If
            End While
            'MessageBox.Show("Login Successful")
            'Dim search As String = ("Select AccountType from Login where UserName = '" & UNTextBox.Text & "'")


            connection.Close()
            End If
    End Sub
>>>>>>> Mamoon
End Class