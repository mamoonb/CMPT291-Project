Public Class ParentForm
    Private Sub ParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initialForm = New CustomerInfo
        initialForm.MdiParent = Me
        initialForm.Show()
    End Sub
End Class