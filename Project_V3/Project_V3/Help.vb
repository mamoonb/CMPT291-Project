Public Class Help
    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Dim oForm As EmployeeMenu
        oForm = New EmployeeMenu()
        oForm.Show()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AccountTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TopicBox.SelectedIndexChanged

    End Sub
End Class