<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeUpdateScreen
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
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.GoBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SINTextBox = New System.Windows.Forms.TextBox()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.HourlyRateTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(545, 375)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(148, 63)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'GoBack
        '
        Me.GoBack.Location = New System.Drawing.Point(699, 375)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(50, 63)
        Me.GoBack.TabIndex = 18
        Me.GoBack.Text = "<<"
        Me.GoBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "SIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hourly Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(325, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Telephone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "First Name"
        '
        'SINTextBox
        '
        Me.SINTextBox.Location = New System.Drawing.Point(103, 31)
        Me.SINTextBox.Name = "SINTextBox"
        Me.SINTextBox.Size = New System.Drawing.Size(189, 26)
        Me.SINTextBox.TabIndex = 26
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Location = New System.Drawing.Point(103, 125)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(189, 26)
        Me.LNameTextBox.TabIndex = 28
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Location = New System.Drawing.Point(103, 75)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(189, 26)
        Me.FNameTextBox.TabIndex = 29
        '
        'HourlyRateTextBox
        '
        Me.HourlyRateTextBox.Location = New System.Drawing.Point(424, 125)
        Me.HourlyRateTextBox.Name = "HourlyRateTextBox"
        Me.HourlyRateTextBox.Size = New System.Drawing.Size(215, 26)
        Me.HourlyRateTextBox.TabIndex = 30
        '
        'StartDateTextBox
        '
        Me.StartDateTextBox.Location = New System.Drawing.Point(424, 75)
        Me.StartDateTextBox.Name = "StartDateTextBox"
        Me.StartDateTextBox.Size = New System.Drawing.Size(215, 26)
        Me.StartDateTextBox.TabIndex = 31
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.Location = New System.Drawing.Point(424, 31)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(215, 26)
        Me.TelephoneTextBox.TabIndex = 32
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(103, 189)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(189, 118)
        Me.AddressTextBox.TabIndex = 34
        '
        'EmployeeUpdateScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(Me.StartDateTextBox)
        Me.Controls.Add(Me.HourlyRateTextBox)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(Me.SINTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.UpdateButton)
        Me.Name = "EmployeeUpdateScreen"
        Me.Text = "EmployeeUpdateScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents GoBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SINTextBox As TextBox
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents HourlyRateTextBox As TextBox
    Friend WithEvents StartDateTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
End Class
