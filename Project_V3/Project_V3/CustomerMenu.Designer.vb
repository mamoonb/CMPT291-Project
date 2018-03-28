<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OrderMovies = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OrderMovies
        '
        Me.OrderMovies.Location = New System.Drawing.Point(23, 45)
        Me.OrderMovies.Name = "OrderMovies"
        Me.OrderMovies.Size = New System.Drawing.Size(164, 49)
        Me.OrderMovies.TabIndex = 0
        Me.OrderMovies.Text = "Order Movies"
        Me.OrderMovies.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(161, 296)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(90, 44)
        Me.LogoutButton.TabIndex = 1
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'CustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 352)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.OrderMovies)
        Me.Name = "CustomerMenu"
        Me.Text = "CustomerMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OrderMovies As Button
    Friend WithEvents LogoutButton As Button
End Class
