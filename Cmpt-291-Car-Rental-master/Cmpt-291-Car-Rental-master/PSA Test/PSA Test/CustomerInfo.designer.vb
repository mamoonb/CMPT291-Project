<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PickupBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DropoffBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PickupBox
        '
        Me.PickupBox.FormattingEnabled = True
        Me.PickupBox.Items.AddRange(New Object() {"Northside Location", "Southside Location", "Westend Location", "Eastend Location"})
        Me.PickupBox.Location = New System.Drawing.Point(206, 31)
        Me.PickupBox.Name = "PickupBox"
        Me.PickupBox.Size = New System.Drawing.Size(200, 28)
        Me.PickupBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Pickup Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(481, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Dropoff Location"
        '
        'DropoffBox
        '
        Me.DropoffBox.FormattingEnabled = True
        Me.DropoffBox.Items.AddRange(New Object() {"Northside Location", "Southside Location", "Westend Location", "Eastend Location"})
        Me.DropoffBox.Location = New System.Drawing.Point(674, 31)
        Me.DropoffBox.Name = "DropoffBox"
        Me.DropoffBox.Size = New System.Drawing.Size(200, 28)
        Me.DropoffBox.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(206, 96)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(674, 96)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select Dropoff Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Select Pickup Time"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(608, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 110)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Must be age 25+ to proceed"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(608, 150)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(266, 24)
        Me.CheckBox.TabIndex = 9
        Me.CheckBox.Text = "Must be over age 25 to continue."
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(206, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 26)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "(Optional)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Enter Account Number"
        '
        'CustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 319)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DropoffBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PickupBox)
        Me.Name = "CustomerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PSA Car Rentals"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PickupBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DropoffBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
End Class
