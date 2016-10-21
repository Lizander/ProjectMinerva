<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomer
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
        Dim CityLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim StateExemptLabel As System.Windows.Forms.Label
        Dim MunicipalExemptLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim FirstLastNameLabel As System.Windows.Forms.Label
        Dim SecondLastNameLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCustomer))
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.CustomersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.StateExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.DiscountNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MunicipalExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.FirstLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.SecondLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        CityLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        StateExemptLabel = New System.Windows.Forms.Label()
        MunicipalExemptLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        FirstLastNameLabel = New System.Windows.Forms.Label()
        SecondLastNameLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DiscountNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CityLabel
        '
        CityLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(35, 22)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 10
        CityLabel.Text = "City:"
        '
        'GenderLabel
        '
        GenderLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(35, 248)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 18
        GenderLabel.Text = "Gender:"
        '
        'DiscountLabel
        '
        DiscountLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(35, 179)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(52, 13)
        DiscountLabel.TabIndex = 16
        DiscountLabel.Text = "Discount:"
        '
        'StateExemptLabel
        '
        StateExemptLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StateExemptLabel.AutoSize = True
        StateExemptLabel.Location = New System.Drawing.Point(35, 67)
        StateExemptLabel.Name = "StateExemptLabel"
        StateExemptLabel.Size = New System.Drawing.Size(73, 13)
        StateExemptLabel.TabIndex = 12
        StateExemptLabel.Text = "State Exempt:"
        '
        'MunicipalExemptLabel
        '
        MunicipalExemptLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MunicipalExemptLabel.AutoSize = True
        MunicipalExemptLabel.Location = New System.Drawing.Point(35, 122)
        MunicipalExemptLabel.Name = "MunicipalExemptLabel"
        MunicipalExemptLabel.Size = New System.Drawing.Size(93, 13)
        MunicipalExemptLabel.TabIndex = 14
        MunicipalExemptLabel.Text = "Municipal Exempt:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(25, 198)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 6
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(25, 35)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 0
        FirstNameLabel.Text = "First Name:"
        '
        'FirstLastNameLabel
        '
        FirstLastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FirstLastNameLabel.AutoSize = True
        FirstLastNameLabel.Location = New System.Drawing.Point(25, 84)
        FirstLastNameLabel.Name = "FirstLastNameLabel"
        FirstLastNameLabel.Size = New System.Drawing.Size(83, 13)
        FirstLastNameLabel.TabIndex = 2
        FirstLastNameLabel.Text = "First Last Name:"
        '
        'SecondLastNameLabel
        '
        SecondLastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SecondLastNameLabel.AutoSize = True
        SecondLastNameLabel.Location = New System.Drawing.Point(25, 144)
        SecondLastNameLabel.Name = "SecondLastNameLabel"
        SecondLastNameLabel.Size = New System.Drawing.Size(101, 13)
        SecondLastNameLabel.TabIndex = 4
        SecondLastNameLabel.Text = "Second Last Name:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(25, 248)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 8
        EmailAddressLabel.Text = "Email Address:"
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
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.LineItemsTableAdapter = Nothing
        Me.TableAdapterManager.NotesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.ServicesTableAdapter = Nothing
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TiresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.CityTextBox)
        Me.Panel2.Controls.Add(CityLabel)
        Me.Panel2.Controls.Add(GenderLabel)
        Me.Panel2.Controls.Add(DiscountLabel)
        Me.Panel2.Controls.Add(Me.GenderComboBox)
        Me.Panel2.Controls.Add(Me.StateExemptComboBox)
        Me.Panel2.Controls.Add(Me.DiscountNumericUpDown)
        Me.Panel2.Controls.Add(StateExemptLabel)
        Me.Panel2.Controls.Add(Me.MunicipalExemptComboBox)
        Me.Panel2.Controls.Add(MunicipalExemptLabel)
        Me.Panel2.Location = New System.Drawing.Point(926, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 363)
        Me.Panel2.TabIndex = 27
        '
        'CityTextBox
        '
        Me.CityTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(142, 19)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(123, 20)
        Me.CityTextBox.TabIndex = 11
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Gender", True))
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.GenderComboBox.Location = New System.Drawing.Point(142, 243)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(123, 21)
        Me.GenderComboBox.TabIndex = 19
        '
        'StateExemptComboBox
        '
        Me.StateExemptComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StateExemptComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.StateExemptComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StateExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StateExempt", True))
        Me.StateExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateExemptComboBox.FormattingEnabled = True
        Me.StateExemptComboBox.Items.AddRange(New Object() {"YES", "NO"})
        Me.StateExemptComboBox.Location = New System.Drawing.Point(142, 64)
        Me.StateExemptComboBox.Name = "StateExemptComboBox"
        Me.StateExemptComboBox.Size = New System.Drawing.Size(123, 21)
        Me.StateExemptComboBox.TabIndex = 13
        '
        'DiscountNumericUpDown
        '
        Me.DiscountNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersBindingSource, "Discount", True))
        Me.DiscountNumericUpDown.DecimalPlaces = 2
        Me.DiscountNumericUpDown.Location = New System.Drawing.Point(142, 175)
        Me.DiscountNumericUpDown.Name = "DiscountNumericUpDown"
        Me.DiscountNumericUpDown.Size = New System.Drawing.Size(123, 20)
        Me.DiscountNumericUpDown.TabIndex = 17
        '
        'MunicipalExemptComboBox
        '
        Me.MunicipalExemptComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MunicipalExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "MunicipalExempt", True))
        Me.MunicipalExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MunicipalExemptComboBox.FormattingEnabled = True
        Me.MunicipalExemptComboBox.Items.AddRange(New Object() {"YES", "NO"})
        Me.MunicipalExemptComboBox.Location = New System.Drawing.Point(142, 119)
        Me.MunicipalExemptComboBox.Name = "MunicipalExemptComboBox"
        Me.MunicipalExemptComboBox.Size = New System.Drawing.Size(123, 21)
        Me.MunicipalExemptComboBox.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.Panel1.Controls.Add(PhoneNumberLabel)
        Me.Panel1.Controls.Add(FirstNameLabel)
        Me.Panel1.Controls.Add(Me.PhoneNumberMaskedTextBox)
        Me.Panel1.Controls.Add(Me.FirstLastNameTextBox)
        Me.Panel1.Controls.Add(FirstLastNameLabel)
        Me.Panel1.Controls.Add(Me.SecondLastNameTextBox)
        Me.Panel1.Controls.Add(SecondLastNameLabel)
        Me.Panel1.Controls.Add(Me.EmailAddressTextBox)
        Me.Panel1.Controls.Add(EmailAddressLabel)
        Me.Panel1.Location = New System.Drawing.Point(258, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 365)
        Me.Panel1.TabIndex = 26
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(132, 28)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(119, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'PhoneNumberMaskedTextBox
        '
        Me.PhoneNumberMaskedTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhoneNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "PhoneNumber", True))
        Me.PhoneNumberMaskedTextBox.Location = New System.Drawing.Point(132, 195)
        Me.PhoneNumberMaskedTextBox.Mask = "(999)-000-0000"
        Me.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox"
        Me.PhoneNumberMaskedTextBox.RejectInputOnFirstFailure = True
        Me.PhoneNumberMaskedTextBox.Size = New System.Drawing.Size(119, 20)
        Me.PhoneNumberMaskedTextBox.TabIndex = 7
        '
        'FirstLastNameTextBox
        '
        Me.FirstLastNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FirstLastName", True))
        Me.FirstLastNameTextBox.Location = New System.Drawing.Point(132, 81)
        Me.FirstLastNameTextBox.Name = "FirstLastNameTextBox"
        Me.FirstLastNameTextBox.Size = New System.Drawing.Size(119, 20)
        Me.FirstLastNameTextBox.TabIndex = 3
        '
        'SecondLastNameTextBox
        '
        Me.SecondLastNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SecondLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "SecondLastName", True))
        Me.SecondLastNameTextBox.Location = New System.Drawing.Point(132, 141)
        Me.SecondLastNameTextBox.Name = "SecondLastNameTextBox"
        Me.SecondLastNameTextBox.Size = New System.Drawing.Size(119, 20)
        Me.SecondLastNameTextBox.TabIndex = 5
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(132, 245)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(119, 20)
        Me.EmailAddressTextBox.TabIndex = 9
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.AutoSize = True
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(23, 488)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(78, 78)
        Me.BackButton.TabIndex = 25
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.AutoSize = True
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Image = Global.ProjectMinerva.My.Resources.Resources.Save_as_icon
        Me.SaveButton.Location = New System.Drawing.Point(741, 471)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(114, 95)
        Me.SaveButton.TabIndex = 24
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'EditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1476, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DiscountNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents CustomersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StateExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiscountNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MunicipalExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FirstLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecondLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
