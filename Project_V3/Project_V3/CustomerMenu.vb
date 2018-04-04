Public Class CustomerMenu
<<<<<<< HEAD
    Private Sub SearchMoviesButton_Click(sender As Object, e As EventArgs) Handles SearchMoviesButton.Click

    End Sub

    Private Sub OrderMoviesButton_Click(sender As Object, e As EventArgs) Handles OrderMoviesButton.Click

    End Sub

    Private Sub UpdateAccountButton_Click(sender As Object, e As EventArgs) Handles UpdateAccountButton.Click
        Dim oForm As CustomerUpdateScreen
        oForm = New CustomerUpdateScreen()
=======
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
>>>>>>> master
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class