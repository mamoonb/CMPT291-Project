<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeMenu
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
        Me.UpdateCustomer = New System.Windows.Forms.Button()
        Me.UpdateEmployee = New System.Windows.Forms.Button()
        Me.AddMovie = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UpdateCustomer
        '
        Me.UpdateCustomer.Location = New System.Drawing.Point(11, 26)
        Me.UpdateCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateCustomer.Name = "UpdateCustomer"
        Me.UpdateCustomer.Size = New System.Drawing.Size(165, 41)
        Me.UpdateCustomer.TabIndex = 0
        Me.UpdateCustomer.Text = "Update Customer"
        Me.UpdateCustomer.UseVisualStyleBackColor = True
        '
        'UpdateEmployee
        '
        Me.UpdateEmployee.Location = New System.Drawing.Point(11, 86)
        Me.UpdateEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateEmployee.Name = "UpdateEmployee"
        Me.UpdateEmployee.Size = New System.Drawing.Size(165, 39)
        Me.UpdateEmployee.TabIndex = 1
        Me.UpdateEmployee.Text = "Update Employee"
        Me.UpdateEmployee.UseVisualStyleBackColor = True
        '
        'AddMovie
        '
        Me.AddMovie.Location = New System.Drawing.Point(11, 143)
        Me.AddMovie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddMovie.Name = "AddMovie"
        Me.AddMovie.Size = New System.Drawing.Size(165, 40)
        Me.AddMovie.TabIndex = 2
        Me.AddMovie.Text = "Add Movie"
        Me.AddMovie.UseVisualStyleBackColor = True
        '
        'EmployeeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 360)
        Me.Controls.Add(Me.AddMovie)
        Me.Controls.Add(Me.UpdateEmployee)
        Me.Controls.Add(Me.UpdateCustomer)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EmployeeMenu"
        Me.Text = "EmployeeMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpdateCustomer As Button
    Friend WithEvents UpdateEmployee As Button
    Friend WithEvents AddMovie As Button
End Class
