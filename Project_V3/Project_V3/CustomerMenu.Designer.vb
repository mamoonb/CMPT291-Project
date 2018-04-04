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
<<<<<<< HEAD
        Me.OrderMoviesButton = New System.Windows.Forms.Button()
        Me.SearchMoviesButton = New System.Windows.Forms.Button()
        Me.UpdateAccountButton = New System.Windows.Forms.Button()
=======
        Me.OrderMovies = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
>>>>>>> master
        Me.SuspendLayout()
        '
        'OrderMoviesButton
        '
<<<<<<< HEAD
        Me.OrderMoviesButton.Location = New System.Drawing.Point(12, 170)
        Me.OrderMoviesButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderMoviesButton.Name = "OrderMoviesButton"
        Me.OrderMoviesButton.Size = New System.Drawing.Size(354, 61)
        Me.OrderMoviesButton.TabIndex = 0
        Me.OrderMoviesButton.Text = "Order Movies"
        Me.OrderMoviesButton.UseVisualStyleBackColor = True
        '
        'SearchMoviesButton
        '
        Me.SearchMoviesButton.Location = New System.Drawing.Point(12, 91)
        Me.SearchMoviesButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchMoviesButton.Name = "SearchMoviesButton"
        Me.SearchMoviesButton.Size = New System.Drawing.Size(354, 61)
        Me.SearchMoviesButton.TabIndex = 2
        Me.SearchMoviesButton.Text = "Search Movies"
        Me.SearchMoviesButton.UseVisualStyleBackColor = True
        '
        'UpdateAccountButton
        '
        Me.UpdateAccountButton.Location = New System.Drawing.Point(12, 13)
        Me.UpdateAccountButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateAccountButton.Name = "UpdateAccountButton"
        Me.UpdateAccountButton.Size = New System.Drawing.Size(354, 61)
        Me.UpdateAccountButton.TabIndex = 1
        Me.UpdateAccountButton.Text = "Update Account"
        Me.UpdateAccountButton.UseVisualStyleBackColor = True
=======
        Me.OrderMovies.Location = New System.Drawing.Point(23, 45)
        Me.OrderMovies.Name = "OrderMovies"
        Me.OrderMovies.Size = New System.Drawing.Size(164, 49)
        Me.OrderMovies.TabIndex = 0
        Me.OrderMovies.Text = "Order Movies"
        Me.OrderMovies.UseVisualStyleBackColor = True
>>>>>>> master
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(378, 244)
        Me.Controls.Add(Me.SearchMoviesButton)
        Me.Controls.Add(Me.UpdateAccountButton)
        Me.Controls.Add(Me.OrderMoviesButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.ClientSize = New System.Drawing.Size(409, 352)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.OrderMovies)
>>>>>>> master
        Me.Name = "CustomerMenu"
        Me.Text = "Customer Menu"
        Me.ResumeLayout(False)

    End Sub

<<<<<<< HEAD
    Friend WithEvents OrderMoviesButton As Button
    Friend WithEvents SearchMoviesButton As Button
    Friend WithEvents UpdateAccountButton As Button
=======
    Friend WithEvents OrderMovies As Button
    Friend WithEvents LogoutButton As Button
>>>>>>> master
End Class
