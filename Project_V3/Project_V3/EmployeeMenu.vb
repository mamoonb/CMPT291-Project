﻿Public Class EmployeeMenu
    Private Sub UpdateCustomer_Click(sender As Object, e As EventArgs) Handles UpdateCustomer.Click
        Dim oForm As CustomerUpdateScreen
        oForm = New CustomerUpdateScreen()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub UpdateEmployee_Click(sender As Object, e As EventArgs) Handles UpdateEmployee.Click
        Dim oForm As EmployeeUpdateScreen
        oForm = New EmployeeUpdateScreen()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class