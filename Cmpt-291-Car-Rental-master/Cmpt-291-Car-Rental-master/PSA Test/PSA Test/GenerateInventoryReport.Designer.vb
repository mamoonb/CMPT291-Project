<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateInventoryReport
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VehicleID = New System.Windows.Forms.Label()
        Me.AccountNumber = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.VehicleType = New System.Windows.Forms.Label()
        Me.VehicleMake = New System.Windows.Forms.Label()
        Me.ReportResultsBox = New System.Windows.Forms.ListBox()
        Me.AccountNumberTextbox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextbox = New System.Windows.Forms.TextBox()
        Me.VehicleIDTextbox = New System.Windows.Forms.TextBox()
        Me.FromDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateLabel = New System.Windows.Forms.Label()
        Me.ToDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SurnameTextbox = New System.Windows.Forms.TextBox()
        Me.SurnameLabel = New System.Windows.Forms.Label()
        Me.VehicleMakeCombobox = New System.Windows.Forms.ComboBox()
        Me.VehicleModelCombobox = New System.Windows.Forms.ComboBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DataGridResults = New System.Windows.Forms.DataGridView()
        Me.DataGridResultsRented = New System.Windows.Forms.DataGridView()
        Me.AvailableCarsLabel = New System.Windows.Forms.Label()
        Me.RentedCarsLabel = New System.Windows.Forms.Label()
        Me.GenerateInventoryReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridResultsRented, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerateInventoryReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 302)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From Date"
        '
        'VehicleID
        '
        Me.VehicleID.AutoSize = True
        Me.VehicleID.Location = New System.Drawing.Point(50, 157)
        Me.VehicleID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VehicleID.Name = "VehicleID"
        Me.VehicleID.Size = New System.Drawing.Size(82, 20)
        Me.VehicleID.TabIndex = 2
        Me.VehicleID.Text = "Vehicle ID"
        '
        'AccountNumber
        '
        Me.AccountNumber.AutoSize = True
        Me.AccountNumber.Location = New System.Drawing.Point(476, 17)
        Me.AccountNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(128, 20)
        Me.AccountNumber.TabIndex = 3
        Me.AccountNumber.Text = "Account Number"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(51, 20)
        Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(86, 20)
        Me.FirstNameLabel.TabIndex = 4
        Me.FirstNameLabel.Text = "First Name"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Location = New System.Drawing.Point(50, 111)
        Me.PhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(115, 20)
        Me.PhoneNumber.TabIndex = 5
        Me.PhoneNumber.Text = "Phone Number"
        '
        'VehicleType
        '
        Me.VehicleType.AutoSize = True
        Me.VehicleType.Location = New System.Drawing.Point(50, 252)
        Me.VehicleType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VehicleType.Name = "VehicleType"
        Me.VehicleType.Size = New System.Drawing.Size(108, 20)
        Me.VehicleType.TabIndex = 6
        Me.VehicleType.Text = "Vehicle Model"
        '
        'VehicleMake
        '
        Me.VehicleMake.AutoSize = True
        Me.VehicleMake.Location = New System.Drawing.Point(50, 205)
        Me.VehicleMake.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VehicleMake.Name = "VehicleMake"
        Me.VehicleMake.Size = New System.Drawing.Size(104, 20)
        Me.VehicleMake.TabIndex = 7
        Me.VehicleMake.Text = "Vehicle Make"
        '
        'ReportResultsBox
        '
        Me.ReportResultsBox.FormattingEnabled = True
        Me.ReportResultsBox.HorizontalScrollbar = True
        Me.ReportResultsBox.ItemHeight = 20
        Me.ReportResultsBox.Location = New System.Drawing.Point(54, 397)
        Me.ReportResultsBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReportResultsBox.Name = "ReportResultsBox"
        Me.ReportResultsBox.Size = New System.Drawing.Size(392, 264)
        Me.ReportResultsBox.TabIndex = 9
        '
        'AccountNumberTextbox
        '
        Me.AccountNumberTextbox.Location = New System.Drawing.Point(654, 12)
        Me.AccountNumberTextbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AccountNumberTextbox.Name = "AccountNumberTextbox"
        Me.AccountNumberTextbox.Size = New System.Drawing.Size(445, 26)
        Me.AccountNumberTextbox.TabIndex = 12
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(224, 15)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(222, 26)
        Me.FirstNameTextBox.TabIndex = 13
        '
        'PhoneTextbox
        '
        Me.PhoneTextbox.Location = New System.Drawing.Point(224, 106)
        Me.PhoneTextbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhoneTextbox.Name = "PhoneTextbox"
        Me.PhoneTextbox.Size = New System.Drawing.Size(222, 26)
        Me.PhoneTextbox.TabIndex = 14
        '
        'VehicleIDTextbox
        '
        Me.VehicleIDTextbox.Location = New System.Drawing.Point(225, 152)
        Me.VehicleIDTextbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VehicleIDTextbox.Name = "VehicleIDTextbox"
        Me.VehicleIDTextbox.Size = New System.Drawing.Size(222, 26)
        Me.VehicleIDTextbox.TabIndex = 15
        '
        'FromDatePicker
        '
        Me.FromDatePicker.Location = New System.Drawing.Point(225, 294)
        Me.FromDatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FromDatePicker.Name = "FromDatePicker"
        Me.FromDatePicker.ShowCheckBox = True
        Me.FromDatePicker.Size = New System.Drawing.Size(222, 26)
        Me.FromDatePicker.TabIndex = 18
        Me.FromDatePicker.Value = New Date(2016, 11, 20, 0, 0, 0, 0)
        '
        'ToDateLabel
        '
        Me.ToDateLabel.AutoSize = True
        Me.ToDateLabel.Location = New System.Drawing.Point(50, 346)
        Me.ToDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToDateLabel.Name = "ToDateLabel"
        Me.ToDateLabel.Size = New System.Drawing.Size(66, 20)
        Me.ToDateLabel.TabIndex = 8
        Me.ToDateLabel.Text = "To Date"
        '
        'ToDatePicker
        '
        Me.ToDatePicker.Location = New System.Drawing.Point(225, 340)
        Me.ToDatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToDatePicker.Name = "ToDatePicker"
        Me.ToDatePicker.ShowCheckBox = True
        Me.ToDatePicker.Size = New System.Drawing.Size(222, 26)
        Me.ToDatePicker.TabIndex = 19
        Me.ToDatePicker.Value = New Date(2016, 11, 20, 0, 0, 0, 0)
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(746, 674)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(112, 35)
        Me.SaveButton.TabIndex = 20
        Me.SaveButton.Text = "Back"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(988, 674)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(112, 35)
        Me.BackButton.TabIndex = 21
        Me.BackButton.Text = "Save to File"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SurnameTextbox
        '
        Me.SurnameTextbox.Location = New System.Drawing.Point(225, 60)
        Me.SurnameTextbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SurnameTextbox.Name = "SurnameTextbox"
        Me.SurnameTextbox.Size = New System.Drawing.Size(222, 26)
        Me.SurnameTextbox.TabIndex = 23
        '
        'SurnameLabel
        '
        Me.SurnameLabel.AutoSize = True
        Me.SurnameLabel.Location = New System.Drawing.Point(51, 65)
        Me.SurnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SurnameLabel.Name = "SurnameLabel"
        Me.SurnameLabel.Size = New System.Drawing.Size(74, 20)
        Me.SurnameLabel.TabIndex = 22
        Me.SurnameLabel.Text = "Surname"
        '
        'VehicleMakeCombobox
        '
        Me.VehicleMakeCombobox.FormattingEnabled = True
        Me.VehicleMakeCombobox.Location = New System.Drawing.Point(225, 200)
        Me.VehicleMakeCombobox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VehicleMakeCombobox.Name = "VehicleMakeCombobox"
        Me.VehicleMakeCombobox.Size = New System.Drawing.Size(222, 28)
        Me.VehicleMakeCombobox.TabIndex = 24
        '
        'VehicleModelCombobox
        '
        Me.VehicleModelCombobox.FormattingEnabled = True
        Me.VehicleModelCombobox.Location = New System.Drawing.Point(225, 248)
        Me.VehicleModelCombobox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VehicleModelCombobox.Name = "VehicleModelCombobox"
        Me.VehicleModelCombobox.Size = New System.Drawing.Size(222, 28)
        Me.VehicleModelCombobox.TabIndex = 25
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(476, 674)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(112, 35)
        Me.SearchButton.TabIndex = 26
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'DataGridResults
        '
        Me.DataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridResults.Location = New System.Drawing.Point(476, 88)
        Me.DataGridResults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridResults.Name = "DataGridResults"
        Me.DataGridResults.Size = New System.Drawing.Size(626, 278)
        Me.DataGridResults.TabIndex = 27
        '
        'DataGridResultsRented
        '
        Me.DataGridResultsRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridResultsRented.Location = New System.Drawing.Point(476, 398)
        Me.DataGridResultsRented.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridResultsRented.Name = "DataGridResultsRented"
        Me.DataGridResultsRented.Size = New System.Drawing.Size(626, 266)
        Me.DataGridResultsRented.TabIndex = 28
        '
        'AvailableCarsLabel
        '
        Me.AvailableCarsLabel.AutoSize = True
        Me.AvailableCarsLabel.Location = New System.Drawing.Point(476, 60)
        Me.AvailableCarsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AvailableCarsLabel.Name = "AvailableCarsLabel"
        Me.AvailableCarsLabel.Size = New System.Drawing.Size(109, 20)
        Me.AvailableCarsLabel.TabIndex = 29
        Me.AvailableCarsLabel.Text = "Available Cars"
        '
        'RentedCarsLabel
        '
        Me.RentedCarsLabel.AutoSize = True
        Me.RentedCarsLabel.Location = New System.Drawing.Point(476, 375)
        Me.RentedCarsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RentedCarsLabel.Name = "RentedCarsLabel"
        Me.RentedCarsLabel.Size = New System.Drawing.Size(99, 20)
        Me.RentedCarsLabel.TabIndex = 30
        Me.RentedCarsLabel.Text = "Rented Cars"
        '
        'GenerateInventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 725)
        Me.Controls.Add(Me.RentedCarsLabel)
        Me.Controls.Add(Me.AvailableCarsLabel)
        Me.Controls.Add(Me.DataGridResultsRented)
        Me.Controls.Add(Me.DataGridResults)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.VehicleModelCombobox)
        Me.Controls.Add(Me.VehicleMakeCombobox)
        Me.Controls.Add(Me.SurnameTextbox)
        Me.Controls.Add(Me.SurnameLabel)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ToDatePicker)
        Me.Controls.Add(Me.FromDatePicker)
        Me.Controls.Add(Me.VehicleIDTextbox)
        Me.Controls.Add(Me.PhoneTextbox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.AccountNumberTextbox)
        Me.Controls.Add(Me.ReportResultsBox)
        Me.Controls.Add(Me.ToDateLabel)
        Me.Controls.Add(Me.VehicleMake)
        Me.Controls.Add(Me.VehicleType)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.AccountNumber)
        Me.Controls.Add(Me.VehicleID)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "GenerateInventoryReport"
        Me.Text = "Inventory Reporting"
        CType(Me.DataGridResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridResultsRented, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerateInventoryReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents VehicleID As Label
    Friend WithEvents AccountNumber As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents VehicleType As Label
    Friend WithEvents VehicleMake As Label
    Friend WithEvents ReportResultsBox As ListBox
    Friend WithEvents AccountNumberTextbox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents PhoneTextbox As TextBox
    Friend WithEvents VehicleIDTextbox As TextBox
    Friend WithEvents FromDatePicker As DateTimePicker
    Friend WithEvents ToDateLabel As Label
    Friend WithEvents ToDatePicker As DateTimePicker
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents SurnameTextbox As TextBox
    Friend WithEvents SurnameLabel As Label
    Friend WithEvents VehicleMakeCombobox As ComboBox
    Friend WithEvents VehicleModelCombobox As ComboBox
    Friend WithEvents GenerateInventoryReportBindingSource As BindingSource
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents DataGridResults As DataGridView
    Friend WithEvents DataGridResultsRented As DataGridView
    Friend WithEvents AvailableCarsLabel As Label
    Friend WithEvents RentedCarsLabel As Label
End Class
