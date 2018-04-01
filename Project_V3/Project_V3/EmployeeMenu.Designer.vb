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
        Me.CustomerDisplayButton = New System.Windows.Forms.Button()
<<<<<<< HEAD
        Me.DisplayEmployeeButton = New System.Windows.Forms.Button()
=======
        Me.DisplayMovie = New System.Windows.Forms.Button()
>>>>>>> master
        Me.SuspendLayout()
        '
        'UpdateCustomer
        '
        Me.UpdateCustomer.Location = New System.Drawing.Point(11, 26)
        Me.UpdateCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateCustomer.Name = "UpdateCustomer"
        Me.UpdateCustomer.Size = New System.Drawing.Size(165, 41)
        Me.UpdateCustomer.TabIndex = 0
        Me.UpdateCustomer.Text = "Add Customer"
        Me.UpdateCustomer.UseVisualStyleBackColor = True
        '
        'UpdateEmployee
        '
        Me.UpdateEmployee.Location = New System.Drawing.Point(11, 86)
        Me.UpdateEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateEmployee.Name = "UpdateEmployee"
        Me.UpdateEmployee.Size = New System.Drawing.Size(165, 39)
        Me.UpdateEmployee.TabIndex = 1
        Me.UpdateEmployee.Text = "Add Employee"
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
        'CustomerDisplayButton
        '
        Me.CustomerDisplayButton.Location = New System.Drawing.Point(11, 199)
        Me.CustomerDisplayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerDisplayButton.Name = "CustomerDisplayButton"
        Me.CustomerDisplayButton.Size = New System.Drawing.Size(165, 40)
        Me.CustomerDisplayButton.TabIndex = 4
        Me.CustomerDisplayButton.Text = "Display Customers"
        Me.CustomerDisplayButton.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'DisplayEmployeeButton
        '
        Me.DisplayEmployeeButton.Location = New System.Drawing.Point(12, 333)
        Me.DisplayEmployeeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DisplayEmployeeButton.Name = "DisplayEmployeeButton"
        Me.DisplayEmployeeButton.Size = New System.Drawing.Size(186, 50)
        Me.DisplayEmployeeButton.TabIndex = 5
        Me.DisplayEmployeeButton.Text = "Display Employee"
        Me.DisplayEmployeeButton.UseVisualStyleBackColor = True
=======
        'DisplayMovie
        '
        Me.DisplayMovie.Location = New System.Drawing.Point(208, 199)
        Me.DisplayMovie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DisplayMovie.Name = "DisplayMovie"
        Me.DisplayMovie.Size = New System.Drawing.Size(165, 40)
        Me.DisplayMovie.TabIndex = 5
        Me.DisplayMovie.Text = "Display Movies"
        Me.DisplayMovie.UseVisualStyleBackColor = True
>>>>>>> master
        '
        'EmployeeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(576, 450)
        Me.Controls.Add(Me.DisplayEmployeeButton)
=======
        Me.ClientSize = New System.Drawing.Size(388, 344)
        Me.Controls.Add(Me.DisplayMovie)
>>>>>>> master
        Me.Controls.Add(Me.CustomerDisplayButton)
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
    Friend WithEvents CustomerDisplayButton As Button
<<<<<<< HEAD
    Friend WithEvents DisplayEmployeeButton As Button
=======
    Friend WithEvents DisplayMovie As Button
>>>>>>> master
End Class
