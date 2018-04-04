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
        Me.OrderMoiveButton = New System.Windows.Forms.Button()
        Me.EditAccountButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OrderMoiveButton
        '
        Me.OrderMoiveButton.Location = New System.Drawing.Point(46, 26)
        Me.OrderMoiveButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderMoiveButton.Name = "OrderMoiveButton"
        Me.OrderMoiveButton.Size = New System.Drawing.Size(225, 62)
        Me.OrderMoiveButton.TabIndex = 1
        Me.OrderMoiveButton.Text = "Order Movie"
        Me.OrderMoiveButton.UseVisualStyleBackColor = True
        '
        'EditAccountButton
        '
        Me.EditAccountButton.Location = New System.Drawing.Point(46, 120)
        Me.EditAccountButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EditAccountButton.Name = "EditAccountButton"
        Me.EditAccountButton.Size = New System.Drawing.Size(225, 62)
        Me.EditAccountButton.TabIndex = 2
        Me.EditAccountButton.Text = "Edit Account"
        Me.EditAccountButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 69)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "LogOut"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 316)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EditAccountButton)
        Me.Controls.Add(Me.OrderMoiveButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CustomerMenu"
        Me.Text = "CustomerMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrderMoiveButton As Button
    Friend WithEvents EditAccountButton As Button
    Friend WithEvents Button1 As Button
End Class
