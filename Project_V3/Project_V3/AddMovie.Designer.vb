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
        Me.Add = New System.Windows.Forms.Button()
        Me.GoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MovieName
        '
        Me.MovieName.Location = New System.Drawing.Point(185, 61)
        Me.MovieName.Name = "MovieName"
        Me.MovieName.Size = New System.Drawing.Size(171, 22)
        Me.MovieName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Movie Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Movie Type"
        '
        'MovieType
        '
        Me.MovieType.Location = New System.Drawing.Point(185, 109)
        Me.MovieType.Name = "MovieType"
        Me.MovieType.Size = New System.Drawing.Size(171, 22)
        Me.MovieType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Distribution Fee"
        '
        'DistributionFee
        '
        Me.DistributionFee.Location = New System.Drawing.Point(185, 159)
        Me.DistributionFee.Name = "DistributionFee"
        Me.DistributionFee.Size = New System.Drawing.Size(171, 22)
        Me.DistributionFee.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number of Copies"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Rating"
        '
        'NumberOfCopies
        '
        Me.NumberOfCopies.Location = New System.Drawing.Point(185, 204)
        Me.NumberOfCopies.Name = "NumberOfCopies"
        Me.NumberOfCopies.Size = New System.Drawing.Size(171, 22)
        Me.NumberOfCopies.TabIndex = 8
        '
        'Rating
        '
        Me.Rating.Location = New System.Drawing.Point(185, 250)
        Me.Rating.Name = "Rating"
        Me.Rating.Size = New System.Drawing.Size(171, 22)
        Me.Rating.TabIndex = 9
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(185, 314)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(99, 38)
        Me.Add.TabIndex = 10
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'GoBack
        '
        Me.GoBack.Location = New System.Drawing.Point(290, 314)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(66, 38)
        Me.GoBack.TabIndex = 11
        Me.GoBack.Text = "<<"
        Me.GoBack.UseVisualStyleBackColor = True
        '
        'AddMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 410)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.Add)
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
    Friend WithEvents Add As Button
    Friend WithEvents GoBack As Button
End Class
