Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub SignupCustomerButton_Click(sender As Object, e As EventArgs) Handles SignupCustomerButton.Click
        Dim oForm As CustomerRegisterScreen
        oForm = New CustomerRegisterScreen()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub


End Class