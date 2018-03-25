Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim oForm As CustomerUpdateScreen
        oForm = New CustomerUpdateScreen()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class