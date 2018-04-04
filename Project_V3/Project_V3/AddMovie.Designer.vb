<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovie
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
        Me.MovieName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MovieType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DistributionFee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumberOfCopies = New System.Windows.Forms.TextBox()
        Me.Rating = New System.Windows.Forms.TextBox()
        Me.Update = New System.Windows.Forms.Button()
        Me.GoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MovieName
        '
        Me.MovieName.Location = New System.Drawing.Point(208, 76)
        Me.MovieName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MovieName.Name = "MovieName"
        Me.MovieName.Size = New System.Drawing.Size(192, 26)
        Me.MovieName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Movie Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movie Type"
        '
        'MovieType
        '
        Me.MovieType.Location = New System.Drawing.Point(208, 136)
        Me.MovieType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MovieType.Name = "MovieType"
        Me.MovieType.Size = New System.Drawing.Size(192, 26)
        Me.MovieType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Distribution Fee"
        '
        'DistributionFee
        '
        Me.DistributionFee.Location = New System.Drawing.Point(208, 199)
        Me.DistributionFee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DistributionFee.Name = "DistributionFee"
        Me.DistributionFee.Size = New System.Drawing.Size(192, 26)
        Me.DistributionFee.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number of Copies"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Rating"
        '
        'NumberOfCopies
        '
        Me.NumberOfCopies.Location = New System.Drawing.Point(208, 255)
        Me.NumberOfCopies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumberOfCopies.Name = "NumberOfCopies"
        Me.NumberOfCopies.Size = New System.Drawing.Size(192, 26)
        Me.NumberOfCopies.TabIndex = 8
        '
        'Rating
        '
        Me.Rating.Location = New System.Drawing.Point(208, 312)
        Me.Rating.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Rating.Name = "Rating"
        Me.Rating.Size = New System.Drawing.Size(192, 26)
        Me.Rating.TabIndex = 9
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(208, 392)
        Me.Update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(111, 48)
        Me.Update.TabIndex = 10
        Me.Update.Text = "Add"
        Me.Update.UseVisualStyleBackColor = True
        '
        'GoBack
        '
        Me.GoBack.Location = New System.Drawing.Point(326, 392)
        Me.GoBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(74, 48)
        Me.GoBack.TabIndex = 11
        Me.GoBack.Text = "<<"
        Me.GoBack.UseVisualStyleBackColor = True
        '
        'AddMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 512)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Rating)
        Me.Controls.Add(Me.NumberOfCopies)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DistributionFee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MovieType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MovieName)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddMovie"
        Me.Text = "AddMovie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MovieName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MovieType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DistributionFee As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumberOfCopies As TextBox
    Friend WithEvents Rating As TextBox
    Friend WithEvents Update As Button
    Friend WithEvents GoBack As Button
End Class
