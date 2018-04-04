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
        Me.SearchMovieButton = New System.Windows.Forms.Button()
        Me.OrderMoiveButton = New System.Windows.Forms.Button()
        Me.EditAccountButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearchMovieButton
        '
        Me.SearchMovieButton.Location = New System.Drawing.Point(41, 27)
        Me.SearchMovieButton.Name = "SearchMovieButton"
        Me.SearchMovieButton.Size = New System.Drawing.Size(200, 50)
        Me.SearchMovieButton.TabIndex = 0
        Me.SearchMovieButton.Text = "Search Movie"
        Me.SearchMovieButton.UseVisualStyleBackColor = True
        '
        'OrderMoiveButton
        '
        Me.OrderMoiveButton.Location = New System.Drawing.Point(41, 106)
        Me.OrderMoiveButton.Name = "OrderMoiveButton"
        Me.OrderMoiveButton.Size = New System.Drawing.Size(200, 50)
        Me.OrderMoiveButton.TabIndex = 1
        Me.OrderMoiveButton.Text = "Order Movie"
        Me.OrderMoiveButton.UseVisualStyleBackColor = True
        '
        'EditAccountButton
        '
        Me.EditAccountButton.Location = New System.Drawing.Point(41, 180)
        Me.EditAccountButton.Name = "EditAccountButton"
        Me.EditAccountButton.Size = New System.Drawing.Size(200, 50)
        Me.EditAccountButton.TabIndex = 2
        Me.EditAccountButton.Text = "Edit Account"
        Me.EditAccountButton.UseVisualStyleBackColor = True
        '
        'CustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.EditAccountButton)
        Me.Controls.Add(Me.OrderMoiveButton)
        Me.Controls.Add(Me.SearchMovieButton)
        Me.Name = "CustomerMenu"
        Me.Text = "CustomerMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchMovieButton As Button
    Friend WithEvents OrderMoiveButton As Button
    Friend WithEvents EditAccountButton As Button
End Class
