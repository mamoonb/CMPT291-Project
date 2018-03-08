<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Experience
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
        Me.TrackBar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValueField = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResultsBox = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar
        '
        Me.TrackBar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TrackBar.Location = New System.Drawing.Point(158, 217)
        Me.TrackBar.Maximum = 5
        Me.TrackBar.Minimum = 1
        Me.TrackBar.Name = "TrackBar"
        Me.TrackBar.Size = New System.Drawing.Size(598, 69)
        Me.TrackBar.TabIndex = 1
        Me.TrackBar.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Value Selected:"
        '
        'ValueField
        '
        Me.ValueField.AutoSize = True
        Me.ValueField.Location = New System.Drawing.Point(442, 329)
        Me.ValueField.Name = "ValueField"
        Me.ValueField.Size = New System.Drawing.Size(0, 20)
        Me.ValueField.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(533, 37)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Please Rate Customer Experience"
        '
        'ResultsBox
        '
        Me.ResultsBox.AutoSize = True
        Me.ResultsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsBox.Location = New System.Drawing.Point(536, 320)
        Me.ResultsBox.Name = "ResultsBox"
        Me.ResultsBox.Size = New System.Drawing.Size(26, 29)
        Me.ResultsBox.TabIndex = 5
        Me.ResultsBox.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(769, 58)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Please select your rating:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1: Poor, 2: Needs Improvement, 3: Average, 4: Very g" &
    "ood, 5: Excellent)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(153, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(594, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "  1                     2                     3                     4            " &
    "         5"
        '
        'Experience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 498)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ResultsBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ValueField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar)
        Me.Name = "Experience"
        Me.Text = "Experience"
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents ValueField As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ResultsBox As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
