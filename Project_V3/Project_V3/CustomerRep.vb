Public Class CustomerRep
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oForm As Login
        oForm = New Login()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub CustomerDisplayButton_Click(sender As Object, e As EventArgs) Handles CustomerDisplayButton.Click
        Dim oForm As AllCustomer
        oForm = New AllCustomer()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As ViewMovies
        oForm = New ViewMovies()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub CustomerRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class