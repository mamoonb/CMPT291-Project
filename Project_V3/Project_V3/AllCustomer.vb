﻿Imports System.Data.SqlClient
Public Class AllCustomer
    Dim connection As New SqlConnection("Server = LAPTOP-7VEJQMDT;Database = project;Integrated Security = true ")
    Private Sub AllCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("SELECT CID,FName,LName,Address,Telephone,Email,AccountNum,AccountType,CreditCardNumber,OrderCount,Rating,DateCreated FROM Customer", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class