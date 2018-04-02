Public Class CustomerMenu
    Private Sub SearchMoviesButton_Click(sender As Object, e As EventArgs) Handles SearchMoviesButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub OrderMoviesButton_Click(sender As Object, e As EventArgs) Handles OrderMoviesButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub UpdateAccountButton_Click(sender As Object, e As EventArgs) Handles UpdateAccountButton.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class