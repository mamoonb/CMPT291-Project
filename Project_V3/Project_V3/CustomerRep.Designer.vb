﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRep
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CustomerDisplayButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 366)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 40)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "LogOut"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CustomerDisplayButton
        '
        Me.CustomerDisplayButton.Location = New System.Drawing.Point(12, 26)
        Me.CustomerDisplayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerDisplayButton.Name = "CustomerDisplayButton"
        Me.CustomerDisplayButton.Size = New System.Drawing.Size(165, 40)
        Me.CustomerDisplayButton.TabIndex = 9
        Me.CustomerDisplayButton.Text = "Display Customers"
        Me.CustomerDisplayButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 79)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "View Movies"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustomerRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 417)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustomerDisplayButton)
        Me.Controls.Add(Me.Button2)
        Me.Name = "CustomerRep"
        Me.Text = "CustomerRep"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents CustomerDisplayButton As Button
    Friend WithEvents Button1 As Button
End Class
