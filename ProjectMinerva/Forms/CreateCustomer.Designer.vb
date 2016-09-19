<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateCustomer
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
        Me.components = New System.ComponentModel.Container()
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim FirstLastNameLabel As System.Windows.Forms.Label
        Dim SecondLastNameLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateExemptLabel As System.Windows.Forms.Label
        Dim MunicipalExemptLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.FirstLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.SecondLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.MunicipalExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.DiscountNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CustomersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.PhoneNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        FirstNameLabel = New System.Windows.Forms.Label()
        FirstLastNameLabel = New System.Windows.Forms.Label()
        SecondLastNameLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateExemptLabel = New System.Windows.Forms.Label()
        MunicipalExemptLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(27, 60)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 0
        FirstNameLabel.Text = "First Name:"
        '
        'FirstLastNameLabel
        '
        FirstLastNameLabel.AutoSize = True
        FirstLastNameLabel.Location = New System.Drawing.Point(220, 60)
        FirstLastNameLabel.Name = "FirstLastNameLabel"
        FirstLastNameLabel.Size = New System.Drawing.Size(83, 13)
        FirstLastNameLabel.TabIndex = 2
        FirstLastNameLabel.Text = "First Last Name:"
        '
        'SecondLastNameLabel
        '
        SecondLastNameLabel.AutoSize = True
        SecondLastNameLabel.Location = New System.Drawing.Point(429, 60)
        SecondLastNameLabel.Name = "SecondLastNameLabel"
        SecondLastNameLabel.Size = New System.Drawing.Size(101, 13)
        SecondLastNameLabel.TabIndex = 4
        SecondLastNameLabel.Text = "Second Last Name:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(220, 98)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 8
        EmailAddressLabel.Text = "Email Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(429, 95)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 10
        CityLabel.Text = "City:"
        '
        'StateExemptLabel
        '
        StateExemptLabel.AutoSize = True
        StateExemptLabel.Location = New System.Drawing.Point(27, 139)
        StateExemptLabel.Name = "StateExemptLabel"
        StateExemptLabel.Size = New System.Drawing.Size(73, 13)
        StateExemptLabel.TabIndex = 12
        StateExemptLabel.Text = "State Exempt:"
        '
        'MunicipalExemptLabel
        '
        MunicipalExemptLabel.AutoSize = True
        MunicipalExemptLabel.Location = New System.Drawing.Point(220, 139)
        MunicipalExemptLabel.Name = "MunicipalExemptLabel"
        MunicipalExemptLabel.Size = New System.Drawing.Size(93, 13)
        MunicipalExemptLabel.TabIndex = 14
        MunicipalExemptLabel.Text = "Municipal Exempt:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(27, 169)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 18
        GenderLabel.Text = "Gender:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(429, 139)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(52, 13)
        DiscountLabel.TabIndex = 16
        DiscountLabel.Text = "Discount:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(27, 99)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 6
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(114, 57)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.JupiterDataSet
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirstLastNameTextBox
        '
        Me.FirstLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FirstLastName", True))
        Me.FirstLastNameTextBox.Location = New System.Drawing.Point(314, 56)
        Me.FirstLastNameTextBox.Name = "FirstLastNameTextBox"
        Me.FirstLastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstLastNameTextBox.TabIndex = 3
        '
        'SecondLastNameTextBox
        '
        Me.SecondLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "SecondLastName", True))
        Me.SecondLastNameTextBox.Location = New System.Drawing.Point(536, 57)
        Me.SecondLastNameTextBox.Name = "SecondLastNameTextBox"
        Me.SecondLastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondLastNameTextBox.TabIndex = 5
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(314, 95)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailAddressTextBox.TabIndex = 9
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(536, 92)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 11
        '
        'StateExemptComboBox
        '
        Me.StateExemptComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.StateExemptComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StateExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StateExempt", True))
        Me.StateExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateExemptComboBox.FormattingEnabled = True
        Me.StateExemptComboBox.Items.AddRange(New Object() {"YES", "NO"})
        Me.StateExemptComboBox.Location = New System.Drawing.Point(114, 136)
        Me.StateExemptComboBox.Name = "StateExemptComboBox"
        Me.StateExemptComboBox.Size = New System.Drawing.Size(100, 21)
        Me.StateExemptComboBox.TabIndex = 13
        '
        'MunicipalExemptComboBox
        '
        Me.MunicipalExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "MunicipalExempt", True))
        Me.MunicipalExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MunicipalExemptComboBox.FormattingEnabled = True
        Me.MunicipalExemptComboBox.Items.AddRange(New Object() {"YES", "NO"})
        Me.MunicipalExemptComboBox.Location = New System.Drawing.Point(314, 135)
        Me.MunicipalExemptComboBox.Name = "MunicipalExemptComboBox"
        Me.MunicipalExemptComboBox.Size = New System.Drawing.Size(100, 21)
        Me.MunicipalExemptComboBox.TabIndex = 15
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(30, 221)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 20
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(561, 221)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 21
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Create Customer"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Gender", True))
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.GenderComboBox.Location = New System.Drawing.Point(114, 166)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(100, 21)
        Me.GenderComboBox.TabIndex = 19
        '
        'DiscountNumericUpDown
        '
        Me.DiscountNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersBindingSource, "Discount", True))
        Me.DiscountNumericUpDown.Location = New System.Drawing.Point(536, 135)
        Me.DiscountNumericUpDown.Name = "DiscountNumericUpDown"
        Me.DiscountNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.DiscountNumericUpDown.TabIndex = 17
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PhoneNumberMaskedTextBox
        '
        Me.PhoneNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "PhoneNumber", True))
        Me.PhoneNumberMaskedTextBox.Location = New System.Drawing.Point(114, 96)
        Me.PhoneNumberMaskedTextBox.Mask = "(999)-000-0000"
        Me.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox"
        Me.PhoneNumberMaskedTextBox.RejectInputOnFirstFailure = True
        Me.PhoneNumberMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberMaskedTextBox.TabIndex = 7
        '
        'CreateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 285)
        Me.ControlBox = False
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberMaskedTextBox)
        Me.Controls.Add(DiscountLabel)
        Me.Controls.Add(Me.DiscountNumericUpDown)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(MunicipalExemptLabel)
        Me.Controls.Add(Me.MunicipalExemptComboBox)
        Me.Controls.Add(StateExemptLabel)
        Me.Controls.Add(Me.StateExemptComboBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(EmailAddressLabel)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(SecondLastNameLabel)
        Me.Controls.Add(Me.SecondLastNameTextBox)
        Me.Controls.Add(FirstLastNameLabel)
        Me.Controls.Add(Me.FirstLastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateCustomer"
        Me.Text = "Create Customer"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecondLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MunicipalExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiscountNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents PhoneNumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
