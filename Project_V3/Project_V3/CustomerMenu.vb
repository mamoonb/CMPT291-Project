Public Class CustomerMenu
    Private Sub CustomerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OrderMovies_Click(sender As Object, e As EventArgs) Handles OrderMovies.Click
        Dim oForm As OrderMovies
        oForm = New OrderMovies()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim oForm As Login
        oForm = New Login()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class