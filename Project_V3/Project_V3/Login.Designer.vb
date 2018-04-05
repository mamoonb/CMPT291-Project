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
        Me.Log_In = New System.Windows.Forms.Button()
        Me.UNTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PWTextBox = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Log_In
        '
        Me.Log_In.Location = New System.Drawing.Point(277, 156)
        Me.Log_In.Name = "Log_In"
        Me.Log_In.Size = New System.Drawing.Size(98, 46)
        Me.Log_In.TabIndex = 0
        Me.Log_In.Text = "Login"
        Me.Log_In.UseVisualStyleBackColor = True
        '
        'UNTextBox
        '
        Me.UNTextBox.Location = New System.Drawing.Point(179, 83)
        Me.UNTextBox.Name = "UNTextBox"
        Me.UNTextBox.Size = New System.Drawing.Size(196, 22)
        Me.UNTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'PWTextBox
        '
        Me.PWTextBox.Location = New System.Drawing.Point(179, 116)
        Me.PWTextBox.Name = "PWTextBox"
        Me.PWTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PWTextBox.Size = New System.Drawing.Size(196, 22)
        Me.PWTextBox.TabIndex = 4
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(173, 156)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(98, 46)
        Me.Register.TabIndex = 5
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
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
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 288)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.PWTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UNTextBox)
        Me.Controls.Add(Me.Log_In)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Log_In As Button
    Friend WithEvents UNTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PWTextBox As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
