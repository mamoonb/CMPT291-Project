Public Class CustomerInfo
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DropoffBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropoffBox.SelectedIndexChanged
        Dim locations As New ArrayList
        locations.Add("North Location")
        locations.Add("South Location")
        locations.Add("East Location")
        locations.Add("West Location")


        DropoffBox.Items.Add(locations)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PickupBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PickupBox.SelectedIndexChanged
        'Dim locations As New ArrayList
        'locations.Add("North Location")
        'locations.Add("South Location")
        'locations.Add("East Location")
        'locations.Add("West Location")


        'PickupBox.Items.Add(locations)



    End Sub

    Private Sub CustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox.Checked Then
            Dim Child As New CarSearch()
            Child.MdiParent = Me.MdiParent
            Child.Show()

        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If CheckBox.Checked Then
            Button1.Text = "GO!"
        ElseIf Not CheckBox.Checked Then
            Button1.Text = "Must be age 25+ to proceed"
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class