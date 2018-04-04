Public Class CustomerMenu
    Private Sub EditAccountButton_Click(sender As Object, e As EventArgs) Handles EditAccountButton.Click
        Dim oForm As CustomerUpdateScreen
        oForm = New CustomerUpdateScreen()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub OrderMoiveButton_Click(sender As Object, e As EventArgs) Handles OrderMoiveButton.Click
        Dim oForm As OrderMovies
        oForm = New OrderMovies()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub CustomerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class