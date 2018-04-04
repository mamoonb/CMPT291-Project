<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllEmployee
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(828, 364)
        Me.DataGridView1.TabIndex = 0
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(570, 423)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(169, 57)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(745, 423)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 57)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "<<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Filter By:"
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(242, 20)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(378, 26)
        Me.SearchBox.TabIndex = 6
        '
        'AllEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 492)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AllEmployee"
        Me.Text = "AllEmployee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UpdateButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBox As TextBox
End Class
