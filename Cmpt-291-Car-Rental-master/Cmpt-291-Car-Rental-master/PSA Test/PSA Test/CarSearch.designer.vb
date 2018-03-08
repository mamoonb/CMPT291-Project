<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarSearch
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
        Me.SearchQuery = New System.Windows.Forms.TextBox()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.MakeBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.ModelBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CapacityBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearchQuery
        '
        Me.SearchQuery.Location = New System.Drawing.Point(388, 78)
        Me.SearchQuery.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchQuery.Multiline = True
        Me.SearchQuery.Name = "SearchQuery"
        Me.SearchQuery.Size = New System.Drawing.Size(397, 89)
        Me.SearchQuery.TabIndex = 1
        '
        'ResultBox
        '
        Me.ResultBox.Location = New System.Drawing.Point(388, 177)
        Me.ResultBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResultBox.Multiline = True
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(397, 175)
        Me.ResultBox.TabIndex = 2
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(146, 251)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(98, 36)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'MakeBox
        '
        Me.MakeBox.Location = New System.Drawing.Point(119, 77)
        Me.MakeBox.Multiline = True
        Me.MakeBox.Name = "MakeBox"
        Me.MakeBox.Size = New System.Drawing.Size(171, 26)
        Me.MakeBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Make"
        '
        'YearBox
        '
        Me.YearBox.Location = New System.Drawing.Point(119, 162)
        Me.YearBox.Multiline = True
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(171, 26)
        Me.YearBox.TabIndex = 8
        '
        'ModelBox
        '
        Me.ModelBox.Location = New System.Drawing.Point(119, 118)
        Me.ModelBox.Multiline = True
        Me.ModelBox.Name = "ModelBox"
        Me.ModelBox.Size = New System.Drawing.Size(171, 26)
        Me.ModelBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Model"
        '
        'CapacityBox
        '
        Me.CapacityBox.Location = New System.Drawing.Point(119, 209)
        Me.CapacityBox.Multiline = True
        Me.CapacityBox.Name = "CapacityBox"
        Me.CapacityBox.Size = New System.Drawing.Size(171, 26)
        Me.CapacityBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Capacity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(491, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Search Results"
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(244, 303)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(98, 36)
        Me.NextButton.TabIndex = 19
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(58, 303)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(98, 36)
        Me.BackButton.TabIndex = 20
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CarSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 395)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CapacityBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ModelBox)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MakeBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.SearchQuery)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CarSearch"
        Me.Text = "Car Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchQuery As TextBox
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents MakeBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents YearBox As TextBox
    Friend WithEvents ModelBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CapacityBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents BackButton As Button
End Class
