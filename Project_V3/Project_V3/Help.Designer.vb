<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Help
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
        Me.GoBack = New System.Windows.Forms.Button()
        Me.TopicBox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoBack
        '
        Me.GoBack.Location = New System.Drawing.Point(703, 350)
        Me.GoBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(44, 50)
        Me.GoBack.TabIndex = 19
        Me.GoBack.Text = "<<"
        Me.GoBack.UseVisualStyleBackColor = True
        '
        'TopicBox
        '
        Me.TopicBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TopicBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TopicBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TopicBox.Items.AddRange(New Object() {"FAQ", "How to edit customer info.", "How to edit employee info.", "How to edit movies"})
        Me.TopicBox.Location = New System.Drawing.Point(209, 11)
        Me.TopicBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TopicBox.Name = "TopicBox"
        Me.TopicBox.Size = New System.Drawing.Size(328, 24)
        Me.TopicBox.Sorted = True
        Me.TopicBox.TabIndex = 20
        Me.TopicBox.Text = "Choose a Topic"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(735, 305)
        Me.DataGridView1.TabIndex = 21
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 411)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TopicBox)
        Me.Controls.Add(Me.GoBack)
        Me.Name = "Help"
        Me.Text = "Help"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GoBack As Button
    Friend WithEvents TopicBox As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
