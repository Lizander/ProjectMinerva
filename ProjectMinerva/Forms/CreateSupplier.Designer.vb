<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSupplier
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
        Dim BusinessNameLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim ContactFirstLastNameLabel As System.Windows.Forms.Label
        Dim ContactSecondLastNameLabel As System.Windows.Forms.Label
        Dim BusinessPhoneLabel As System.Windows.Forms.Label
        Dim ContactPhoneLabel As System.Windows.Forms.Label
        Dim BusinessEmailLabel As System.Windows.Forms.Label
        Dim AddressLineOneLabel As System.Windows.Forms.Label
        Dim AddressLineTwoLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ZipcodeLabel As System.Windows.Forms.Label
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.BusinessNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactFirstLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactSecondLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessEmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLineOneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLineTwoTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        BusinessNameLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        ContactFirstLastNameLabel = New System.Windows.Forms.Label()
        ContactSecondLastNameLabel = New System.Windows.Forms.Label()
        BusinessPhoneLabel = New System.Windows.Forms.Label()
        ContactPhoneLabel = New System.Windows.Forms.Label()
        BusinessEmailLabel = New System.Windows.Forms.Label()
        AddressLineOneLabel = New System.Windows.Forms.Label()
        AddressLineTwoLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ZipcodeLabel = New System.Windows.Forms.Label()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.JupiterDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.LineItemsTableAdapter = Nothing
        Me.TableAdapterManager.NotesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.ServicesTableAdapter = Nothing
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.TiresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'BusinessNameLabel
        '
        BusinessNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BusinessNameLabel.AutoSize = True
        BusinessNameLabel.Location = New System.Drawing.Point(417, 141)
        BusinessNameLabel.Name = "BusinessNameLabel"
        BusinessNameLabel.Size = New System.Drawing.Size(83, 13)
        BusinessNameLabel.TabIndex = 0
        BusinessNameLabel.Text = "Business Name:"
        '
        'BusinessNameTextBox
        '
        Me.BusinessNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusinessNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "BusinessName", True))
        Me.BusinessNameTextBox.Location = New System.Drawing.Point(506, 138)
        Me.BusinessNameTextBox.Name = "BusinessNameTextBox"
        Me.BusinessNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BusinessNameTextBox.TabIndex = 1
        '
        'ContactNameLabel
        '
        ContactNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Location = New System.Drawing.Point(417, 177)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(78, 13)
        ContactNameLabel.TabIndex = 2
        ContactNameLabel.Text = "Contact Name:"
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ContactName", True))
        Me.ContactNameTextBox.Location = New System.Drawing.Point(501, 174)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactNameTextBox.TabIndex = 3
        '
        'ContactFirstLastNameLabel
        '
        ContactFirstLastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactFirstLastNameLabel.AutoSize = True
        ContactFirstLastNameLabel.Location = New System.Drawing.Point(607, 180)
        ContactFirstLastNameLabel.Name = "ContactFirstLastNameLabel"
        ContactFirstLastNameLabel.Size = New System.Drawing.Size(123, 13)
        ContactFirstLastNameLabel.TabIndex = 4
        ContactFirstLastNameLabel.Text = "Contact First Last Name:"
        '
        'ContactFirstLastNameTextBox
        '
        Me.ContactFirstLastNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactFirstLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ContactFirstLastName", True))
        Me.ContactFirstLastNameTextBox.Location = New System.Drawing.Point(736, 177)
        Me.ContactFirstLastNameTextBox.Name = "ContactFirstLastNameTextBox"
        Me.ContactFirstLastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactFirstLastNameTextBox.TabIndex = 5
        '
        'ContactSecondLastNameLabel
        '
        ContactSecondLastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactSecondLastNameLabel.AutoSize = True
        ContactSecondLastNameLabel.Location = New System.Drawing.Point(842, 180)
        ContactSecondLastNameLabel.Name = "ContactSecondLastNameLabel"
        ContactSecondLastNameLabel.Size = New System.Drawing.Size(141, 13)
        ContactSecondLastNameLabel.TabIndex = 6
        ContactSecondLastNameLabel.Text = "Contact Second Last Name:"
        '
        'ContactSecondLastNameTextBox
        '
        Me.ContactSecondLastNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactSecondLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ContactSecondLastName", True))
        Me.ContactSecondLastNameTextBox.Location = New System.Drawing.Point(989, 181)
        Me.ContactSecondLastNameTextBox.Name = "ContactSecondLastNameTextBox"
        Me.ContactSecondLastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactSecondLastNameTextBox.TabIndex = 7
        '
        'BusinessPhoneLabel
        '
        BusinessPhoneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BusinessPhoneLabel.AutoSize = True
        BusinessPhoneLabel.Location = New System.Drawing.Point(624, 141)
        BusinessPhoneLabel.Name = "BusinessPhoneLabel"
        BusinessPhoneLabel.Size = New System.Drawing.Size(86, 13)
        BusinessPhoneLabel.TabIndex = 8
        BusinessPhoneLabel.Text = "Business Phone:"
        '
        'BusinessPhoneTextBox
        '
        Me.BusinessPhoneTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusinessPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "BusinessPhone", True))
        Me.BusinessPhoneTextBox.Location = New System.Drawing.Point(716, 138)
        Me.BusinessPhoneTextBox.Name = "BusinessPhoneTextBox"
        Me.BusinessPhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BusinessPhoneTextBox.TabIndex = 9
        '
        'ContactPhoneLabel
        '
        ContactPhoneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactPhoneLabel.AutoSize = True
        ContactPhoneLabel.Location = New System.Drawing.Point(417, 206)
        ContactPhoneLabel.Name = "ContactPhoneLabel"
        ContactPhoneLabel.Size = New System.Drawing.Size(81, 13)
        ContactPhoneLabel.TabIndex = 10
        ContactPhoneLabel.Text = "Contact Phone:"
        '
        'ContactPhoneTextBox
        '
        Me.ContactPhoneTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ContactPhone", True))
        Me.ContactPhoneTextBox.Location = New System.Drawing.Point(504, 203)
        Me.ContactPhoneTextBox.Name = "ContactPhoneTextBox"
        Me.ContactPhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactPhoneTextBox.TabIndex = 11
        '
        'BusinessEmailLabel
        '
        BusinessEmailLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BusinessEmailLabel.AutoSize = True
        BusinessEmailLabel.Location = New System.Drawing.Point(822, 141)
        BusinessEmailLabel.Name = "BusinessEmailLabel"
        BusinessEmailLabel.Size = New System.Drawing.Size(80, 13)
        BusinessEmailLabel.TabIndex = 12
        BusinessEmailLabel.Text = "Business Email:"
        '
        'BusinessEmailTextBox
        '
        Me.BusinessEmailTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusinessEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "BusinessEmail", True))
        Me.BusinessEmailTextBox.Location = New System.Drawing.Point(908, 138)
        Me.BusinessEmailTextBox.Name = "BusinessEmailTextBox"
        Me.BusinessEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BusinessEmailTextBox.TabIndex = 13
        '
        'AddressLineOneLabel
        '
        AddressLineOneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AddressLineOneLabel.AutoSize = True
        AddressLineOneLabel.Location = New System.Drawing.Point(417, 256)
        AddressLineOneLabel.Name = "AddressLineOneLabel"
        AddressLineOneLabel.Size = New System.Drawing.Size(94, 13)
        AddressLineOneLabel.TabIndex = 14
        AddressLineOneLabel.Text = "Address Line One:"
        '
        'AddressLineOneTextBox
        '
        Me.AddressLineOneTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressLineOneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "AddressLineOne", True))
        Me.AddressLineOneTextBox.Location = New System.Drawing.Point(517, 253)
        Me.AddressLineOneTextBox.Name = "AddressLineOneTextBox"
        Me.AddressLineOneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressLineOneTextBox.TabIndex = 15
        '
        'AddressLineTwoLabel
        '
        AddressLineTwoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AddressLineTwoLabel.AutoSize = True
        AddressLineTwoLabel.Location = New System.Drawing.Point(663, 256)
        AddressLineTwoLabel.Name = "AddressLineTwoLabel"
        AddressLineTwoLabel.Size = New System.Drawing.Size(95, 13)
        AddressLineTwoLabel.TabIndex = 16
        AddressLineTwoLabel.Text = "Address Line Two:"
        '
        'AddressLineTwoTextBox
        '
        Me.AddressLineTwoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressLineTwoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "AddressLineTwo", True))
        Me.AddressLineTwoTextBox.Location = New System.Drawing.Point(764, 253)
        Me.AddressLineTwoTextBox.Name = "AddressLineTwoTextBox"
        Me.AddressLineTwoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressLineTwoTextBox.TabIndex = 17
        '
        'CityLabel
        '
        CityLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(417, 296)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 18
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(450, 293)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 19
        '
        'CountryLabel
        '
        CountryLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(571, 296)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 20
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(629, 289)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 21
        '
        'ZipcodeLabel
        '
        ZipcodeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ZipcodeLabel.AutoSize = True
        ZipcodeLabel.Location = New System.Drawing.Point(747, 292)
        ZipcodeLabel.Name = "ZipcodeLabel"
        ZipcodeLabel.Size = New System.Drawing.Size(49, 13)
        ZipcodeLabel.TabIndex = 22
        ZipcodeLabel.Text = "Zipcode:"
        '
        'ZipcodeTextBox
        '
        Me.ZipcodeTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZipcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Zipcode", True))
        Me.ZipcodeTextBox.Location = New System.Drawing.Point(802, 289)
        Me.ZipcodeTextBox.Name = "ZipcodeTextBox"
        Me.ZipcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipcodeTextBox.TabIndex = 23
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(350, 421)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(150, 81)
        Me.SaveButton.TabIndex = 24
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackButton.Location = New System.Drawing.Point(890, 421)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(150, 81)
        Me.BackButton.TabIndex = 25
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(590, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 42)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Create Supplier"
        '
        'CreateSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 609)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(ZipcodeLabel)
        Me.Controls.Add(Me.ZipcodeTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLineTwoLabel)
        Me.Controls.Add(Me.AddressLineTwoTextBox)
        Me.Controls.Add(AddressLineOneLabel)
        Me.Controls.Add(Me.AddressLineOneTextBox)
        Me.Controls.Add(BusinessEmailLabel)
        Me.Controls.Add(Me.BusinessEmailTextBox)
        Me.Controls.Add(ContactPhoneLabel)
        Me.Controls.Add(Me.ContactPhoneTextBox)
        Me.Controls.Add(BusinessPhoneLabel)
        Me.Controls.Add(Me.BusinessPhoneTextBox)
        Me.Controls.Add(ContactSecondLastNameLabel)
        Me.Controls.Add(Me.ContactSecondLastNameTextBox)
        Me.Controls.Add(ContactFirstLastNameLabel)
        Me.Controls.Add(Me.ContactFirstLastNameTextBox)
        Me.Controls.Add(ContactNameLabel)
        Me.Controls.Add(Me.ContactNameTextBox)
        Me.Controls.Add(BusinessNameLabel)
        Me.Controls.Add(Me.BusinessNameTextBox)
        Me.Name = "CreateSupplier"
        Me.Text = "Create Supplier"
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BusinessNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactFirstLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactSecondLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BusinessPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BusinessEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressLineOneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressLineTwoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
