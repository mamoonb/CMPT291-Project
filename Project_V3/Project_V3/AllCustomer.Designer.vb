﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(776, 330)
        Me.DataGridView1.TabIndex = 0
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(717, 381)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(71, 56)
        Me.BackButton.TabIndex = 1
        Me.BackButton.Text = "<<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Filter By:"
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(229, 13)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(378, 26)
        Me.SearchBox.TabIndex = 6
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(532, 381)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(169, 57)
        Me.UpdateButton.TabIndex = 8
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AllCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AllCustomer"
        Me.Text = "AllCustomer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents UpdateButton As Button
End Class
