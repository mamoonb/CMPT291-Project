' www.youtube.com/watch?v=FClfOn3a4C8
Imports System.Data.SqlClient
Public Class AllEmployee
    Private SQL As New SQLControl


    Private Sub AllEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.ExecQuery("SELECT * FROM Employee")

        '(SQL.RecordCount)

        loadGrid()

    End Sub

    Private Sub LoadGrid()
        If SQL.RecordCount > 0 Then
            DataGridView1.DataSource = SQL.SQLDS.Tables(0)
            DataGridView1.Rows(0).Selected = True

            SQL.SQLDA.UpdateCommand = New SqlCommandBuilder(SQL.SQLDA).GetUpdateCommand
        End If

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        SQL.SQLDA.Update(SQL.SQLDS)

        LoadGrid()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class