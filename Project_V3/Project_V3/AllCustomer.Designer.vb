<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllCustomer
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
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '<<<<<<< HEAD
        'Me.DataGridView1.Location = New System.Drawing.Point(14, 71)
        '=======
        Me.DataGridView1.Location = New System.Drawing.Point(11, 10)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        '>>>>>>> cf0a9921661e75a8bcbe79358bc0f4e6fcd4e822
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(690, 341)
        Me.DataGridView1.TabIndex = 0
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(14, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(54, 53)
        Me.BackButton.TabIndex = 1
        Me.BackButton.Text = "<<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AllCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        '<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(802, 509)
        Me.Controls.Add(Me.BackButton)
        '=======
        Me.ClientSize = New System.Drawing.Size(711, 360)
        '>>>>>>> cf0a9921661e75a8bcbe79358bc0f4e6fcd4e822
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AllCustomer"
        Me.Text = "AllCustomer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackButton As Button
End Class
