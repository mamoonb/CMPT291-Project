<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Log_InCustomer = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.Log_InEmployee = New System.Windows.Forms.Button()
        Me.Log_InManager = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SignupCustomerButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Log_InCustomer
        '
        Me.Log_InCustomer.Location = New System.Drawing.Point(84, 190)
        Me.Log_InCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Log_InCustomer.Name = "Log_InCustomer"
        Me.Log_InCustomer.Size = New System.Drawing.Size(110, 58)
        Me.Log_InCustomer.TabIndex = 0
        Me.Log_InCustomer.Text = "Login Customer"
        Me.Log_InCustomer.UseVisualStyleBackColor = True
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(221, 104)
        Me.UserTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(220, 26)
        Me.UserTextBox.TabIndex = 1
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(221, 148)
        Me.PassTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.Size = New System.Drawing.Size(220, 26)
        Me.PassTextBox.TabIndex = 4
        '
        'Log_InEmployee
        '
        Me.Log_InEmployee.Location = New System.Drawing.Point(221, 190)
        Me.Log_InEmployee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Log_InEmployee.Name = "Log_InEmployee"
        Me.Log_InEmployee.Size = New System.Drawing.Size(110, 58)
        Me.Log_InEmployee.TabIndex = 6
        Me.Log_InEmployee.Text = "Login Employee"
        Me.Log_InEmployee.UseVisualStyleBackColor = True
        '
        'Log_InManager
        '
        Me.Log_InManager.Location = New System.Drawing.Point(362, 190)
        Me.Log_InManager.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Log_InManager.Name = "Log_InManager"
        Me.Log_InManager.Size = New System.Drawing.Size(110, 58)
        Me.Log_InManager.TabIndex = 7
        Me.Log_InManager.Text = "Login Manager"
        Me.Log_InManager.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'SignupCustomerButton
        '
        Me.SignupCustomerButton.Location = New System.Drawing.Point(12, 261)
        Me.SignupCustomerButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SignupCustomerButton.Name = "SignupCustomerButton"
        Me.SignupCustomerButton.Size = New System.Drawing.Size(110, 58)
        Me.SignupCustomerButton.TabIndex = 10
        Me.SignupCustomerButton.Text = " Signup Customer"
        Me.SignupCustomerButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 332)
        Me.Controls.Add(Me.SignupCustomerButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Log_InManager)
        Me.Controls.Add(Me.Log_InEmployee)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Log_InCustomer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents Log_InCustomer As Button
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents Log_InEmployee As Button
    Friend WithEvents Log_InManager As Button
    'Friend WithEvents Register As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SignupCustomerButton As Button
End Class
