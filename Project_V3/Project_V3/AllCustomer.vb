﻿Imports System.Data.SqlClient
Public Class AllCustomer
    Dim connection As New SqlConnection("Server = MAMOON-XPS;Database = project;Integrated Security = true ")
    Private Sub AllCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("SELECT * FROM Customer", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

<<<<<<< HEAD
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
=======
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

>>>>>>> cf0a9921661e75a8bcbe79358bc0f4e6fcd4e822
    End Sub
End Class