<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateTransactionReport
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
        Me.ReportResultsBox = New System.Windows.Forms.ListBox()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.FromDateLabel = New System.Windows.Forms.Label()
        Me.ToDateLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.AccountNumberLabel = New System.Windows.Forms.Label()
        Me.SurnameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextbox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextbox = New System.Windows.Forms.TextBox()
        Me.SurnameTextbox = New System.Windows.Forms.TextBox()
        Me.FromDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.YearCombobox = New System.Windows.Forms.ComboBox()
        Me.DataGridResults = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportResultsBox
        '
        Me.ReportResultsBox.FormattingEnabled = True
        Me.ReportResultsBox.HorizontalScrollbar = True
        Me.ReportResultsBox.Location = New System.Drawing.Point(36, 174)
        Me.ReportResultsBox.Name = "ReportResultsBox"
        Me.ReportResultsBox.Size = New System.Drawing.Size(264, 251)
        Me.ReportResultsBox.TabIndex = 0
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Location = New System.Drawing.Point(33, 74)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(29, 13)
        Me.YearLabel.TabIndex = 1
        Me.YearLabel.Text = "Year"
        '
        'FromDateLabel
        '
        Me.FromDateLabel.AutoSize = True
        Me.FromDateLabel.Location = New System.Drawing.Point(33, 109)
        Me.FromDateLabel.Name = "FromDateLabel"
        Me.FromDateLabel.Size = New System.Drawing.Size(56, 13)
        Me.FromDateLabel.TabIndex = 4
        Me.FromDateLabel.Text = "From Date"
        '
        'ToDateLabel
        '
        Me.ToDateLabel.AutoSize = True
        Me.ToDateLabel.Location = New System.Drawing.Point(33, 140)
        Me.ToDateLabel.Name = "ToDateLabel"
        Me.ToDateLabel.Size = New System.Drawing.Size(46, 13)
        Me.ToDateLabel.TabIndex = 5
        Me.ToDateLabel.Text = "To Date"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(33, 14)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 6
        Me.FirstNameLabel.Text = "First Name"
        '
        'AccountNumberLabel
        '
        Me.AccountNumberLabel.AutoSize = True
        Me.AccountNumberLabel.Location = New System.Drawing.Point(320, 13)
        Me.AccountNumberLabel.Name = "AccountNumberLabel"
        Me.AccountNumberLabel.Size = New System.Drawing.Size(87, 13)
        Me.AccountNumberLabel.TabIndex = 7
        Me.AccountNumberLabel.Text = "Account Number"
        '
        'SurnameLabel
        '
        Me.SurnameLabel.AutoSize = True
        Me.SurnameLabel.Location = New System.Drawing.Point(33, 43)
        Me.SurnameLabel.Name = "SurnameLabel"
        Me.SurnameLabel.Size = New System.Drawing.Size(49, 13)
        Me.SurnameLabel.TabIndex = 8
        Me.SurnameLabel.Text = "Surname"
        '
        'FirstNameTextbox
        '
        Me.FirstNameTextbox.Location = New System.Drawing.Point(149, 11)
        Me.FirstNameTextbox.Name = "FirstNameTextbox"
        Me.FirstNameTextbox.Size = New System.Drawing.Size(151, 20)
        Me.FirstNameTextbox.TabIndex = 9
        '
        'AccountNumberTextbox
        '
        Me.AccountNumberTextbox.Location = New System.Drawing.Point(436, 10)
        Me.AccountNumberTextbox.Name = "AccountNumberTextbox"
        Me.AccountNumberTextbox.Size = New System.Drawing.Size(293, 20)
        Me.AccountNumberTextbox.TabIndex = 10
        '
        'SurnameTextbox
        '
        Me.SurnameTextbox.Location = New System.Drawing.Point(149, 39)
        Me.SurnameTextbox.Name = "SurnameTextbox"
        Me.SurnameTextbox.Size = New System.Drawing.Size(151, 20)
        Me.SurnameTextbox.TabIndex = 11
        '
        'FromDatePicker
        '
        Me.FromDatePicker.Location = New System.Drawing.Point(149, 106)
        Me.FromDatePicker.Name = "FromDatePicker"
        Me.FromDatePicker.ShowCheckBox = True
        Me.FromDatePicker.Size = New System.Drawing.Size(151, 20)
        Me.FromDatePicker.TabIndex = 15
        '
        'ToDatePicker
        '
        Me.ToDatePicker.Location = New System.Drawing.Point(149, 138)
        Me.ToDatePicker.Name = "ToDatePicker"
        Me.ToDatePicker.ShowCheckBox = True
        Me.ToDatePicker.Size = New System.Drawing.Size(151, 20)
        Me.ToDatePicker.TabIndex = 16
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(654, 436)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 17
        Me.SaveButton.Text = "Save to File"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(491, 436)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 18
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(323, 436)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 19
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'YearCombobox
        '
        Me.YearCombobox.FormattingEnabled = True
        Me.YearCombobox.Location = New System.Drawing.Point(149, 70)
        Me.YearCombobox.Name = "YearCombobox"
        Me.YearCombobox.Size = New System.Drawing.Size(151, 21)
        Me.YearCombobox.TabIndex = 20
        '
        'DataGridResults
        '
        Me.DataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridResults.Location = New System.Drawing.Point(323, 39)
        Me.DataGridResults.Name = "DataGridResults"
        Me.DataGridResults.Size = New System.Drawing.Size(406, 380)
        Me.DataGridResults.TabIndex = 21
        '
        'GenerateTransactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 471)
        Me.Controls.Add(Me.DataGridResults)
        Me.Controls.Add(Me.YearCombobox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ToDatePicker)
        Me.Controls.Add(Me.FromDatePicker)
        Me.Controls.Add(Me.SurnameTextbox)
        Me.Controls.Add(Me.AccountNumberTextbox)
        Me.Controls.Add(Me.FirstNameTextbox)
        Me.Controls.Add(Me.SurnameLabel)
        Me.Controls.Add(Me.AccountNumberLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.ToDateLabel)
        Me.Controls.Add(Me.FromDateLabel)
        Me.Controls.Add(Me.YearLabel)
        Me.Controls.Add(Me.ReportResultsBox)
        Me.Name = "GenerateTransactionReport"
        Me.Text = "Transaction Reporting"
        CType(Me.DataGridResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportResultsBox As ListBox
    Friend WithEvents YearLabel As Label
    Friend WithEvents FromDateLabel As Label
    Friend WithEvents ToDateLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents SurnameLabel As Label
    Friend WithEvents AccountNumberLabel As Label
    Friend WithEvents FirstNameTextbox As TextBox
    Friend WithEvents AccountNumberTextbox As TextBox
    Friend WithEvents SurnameTextbox As TextBox
    Friend WithEvents FromDatePicker As DateTimePicker
    Friend WithEvents ToDatePicker As DateTimePicker
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents YearCombobox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridResults As DataGridView
End Class
