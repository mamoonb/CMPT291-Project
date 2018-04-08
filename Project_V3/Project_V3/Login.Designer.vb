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
<<<<<<< HEAD
        Me.Log_InCustomer = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.Log_InEmployee = New System.Windows.Forms.Button()
        Me.Log_InManager = New System.Windows.Forms.Button()
=======
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Log_In = New System.Windows.Forms.Button()
        Me.UNTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PWTextBox = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> Mamoon
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
<<<<<<< HEAD
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(201, 104)
        Me.UserTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(220, 26)
        Me.UserTextBox.TabIndex = 1
=======
        'UNTextBox
        '
        Me.UNTextBox.Location = New System.Drawing.Point(179, 83)
        Me.UNTextBox.Name = "UNTextBox"
        Me.UNTextBox.Size = New System.Drawing.Size(196, 22)
        Me.UNTextBox.TabIndex = 1
>>>>>>> Mamoon
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
<<<<<<< HEAD
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(201, 145)
        Me.PassTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.Size = New System.Drawing.Size(220, 26)
        Me.PassTextBox.TabIndex = 4
=======
        'PWTextBox
        '
        Me.PWTextBox.Location = New System.Drawing.Point(179, 116)
        Me.PWTextBox.Name = "PWTextBox"
        Me.PWTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PWTextBox.Size = New System.Drawing.Size(196, 22)
        Me.PWTextBox.TabIndex = 4
>>>>>>> Mamoon
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(12, 289)
        Me.Register.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(110, 58)
        Me.Register.TabIndex = 5
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
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
=======
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
>>>>>>> Mamoon
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(550, 360)
        Me.Controls.Add(Me.Log_InManager)
        Me.Controls.Add(Me.Log_InEmployee)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Log_InCustomer)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.ClientSize = New System.Drawing.Size(489, 288)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.PWTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UNTextBox)
        Me.Controls.Add(Me.Log_In)
>>>>>>> Mamoon
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents Log_InCustomer As Button
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents Log_InEmployee As Button
    Friend WithEvents Log_InManager As Button
=======
    Friend WithEvents Log_In As Button
    Friend WithEvents UNTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PWTextBox As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents PictureBox1 As PictureBox
>>>>>>> Mamoon
End Class
