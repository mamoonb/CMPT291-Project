Public Class EmployeeMenu
    Private Sub UpdateCustomer_Click(sender As Object, e As EventArgs) Handles UpdateCustomer.Click
        Dim oForm As CustomerRegisterScreen
        oForm = New CustomerRegisterScreen()
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

    Private Sub AddMovie_Click(sender As Object, e As EventArgs) Handles AddMovie.Click
        Dim oForm As AddMovie
        oForm = New AddMovie()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub EmployeeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustomerDisplayButton_Click(sender As Object, e As EventArgs) Handles CustomerDisplayButton.Click
        Dim oForm As AllCustomer
        oForm = New AllCustomer()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class