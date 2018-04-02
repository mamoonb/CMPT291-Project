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
        Me.OrderMoviesButton = New System.Windows.Forms.Button()
        Me.UpdateAccountButton = New System.Windows.Forms.Button()
        Me.SearchMoviesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OrderMoviesButton
        '
        Me.OrderMoviesButton.Location = New System.Drawing.Point(12, 170)
        Me.OrderMoviesButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderMoviesButton.Name = "OrderMoviesButton"
        Me.OrderMoviesButton.Size = New System.Drawing.Size(354, 61)
        Me.OrderMoviesButton.TabIndex = 0
        Me.OrderMoviesButton.Text = "Order Movies"
        Me.OrderMoviesButton.UseVisualStyleBackColor = True
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
        'CustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 244)
        Me.Controls.Add(Me.SearchMoviesButton)
        Me.Controls.Add(Me.UpdateAccountButton)
        Me.Controls.Add(Me.OrderMoviesButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CustomerMenu"
        Me.Text = "Customer Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OrderMoviesButton As Button
    Friend WithEvents UpdateAccountButton As Button
    Friend WithEvents SearchMoviesButton As Button
End Class
