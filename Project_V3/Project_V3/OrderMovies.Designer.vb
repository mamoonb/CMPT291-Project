<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderMovies
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Order = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(736, 454)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(54, 52)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "<<"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 71)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(776, 379)
        Me.DataGridView1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter By:"
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(212, 26)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(378, 26)
        Me.SearchBox.TabIndex = 7
        '
        'Order
        '
        Me.Order.Location = New System.Drawing.Point(651, 454)
        Me.Order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Order.Name = "Order"
        Me.Order.Size = New System.Drawing.Size(79, 51)
        Me.Order.TabIndex = 8
        Me.Order.Text = "Order"
        Me.Order.UseVisualStyleBackColor = True
        '
        'OrderMovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 511)
        Me.Controls.Add(Me.Order)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BackButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OrderMovies"
        Me.Text = "OrderMovies"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Order As Button
End Class
