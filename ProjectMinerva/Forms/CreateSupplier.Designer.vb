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
        Dim ContactSecondLastNameLabel As System.Windows.Forms.Label
        Dim BusinessEmailLabel As System.Windows.Forms.Label
        Dim ContactFirstLastNameLabel As System.Windows.Forms.Label
        Dim BusinessPhoneLabel As System.Windows.Forms.Label
        Dim AddressLineTwoLabel As System.Windows.Forms.Label
        Dim ZipcodeLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ContactPhoneLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim AddressLineOneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateSupplier))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ContactSecondLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BusinessEmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactFirstLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLineTwoTextBox = New System.Windows.Forms.TextBox()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLineOneTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BusinessPhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContactPhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.SuppliersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        BusinessNameLabel = New System.Windows.Forms.Label()
        ContactSecondLastNameLabel = New System.Windows.Forms.Label()
        BusinessEmailLabel = New System.Windows.Forms.Label()
        ContactFirstLastNameLabel = New System.Windows.Forms.Label()
        BusinessPhoneLabel = New System.Windows.Forms.Label()
        AddressLineTwoLabel = New System.Windows.Forms.Label()
        ZipcodeLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ContactPhoneLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        AddressLineOneLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BusinessNameLabel
        '
        BusinessNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BusinessNameLabel.AutoSize = True
        BusinessNameLabel.Location = New System.Drawing.Point(15, 25)
        BusinessNameLabel.Name = "BusinessNameLabel"
        BusinessNameLabel.Size = New System.Drawing.Size(83, 13)
        BusinessNameLabel.TabIndex = 1
        BusinessNameLabel.Text = "Business Name:"
        '
        'ContactSecondLastNameLabel
        '
        ContactSecondLastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactSecondLastNameLabel.AutoSize = True
        ContactSecondLastNameLabel.Location = New System.Drawing.Point(7, 103)
        ContactSecondLastNameLabel.Name = "ContactSecondLastNameLabel"
        ContactSecondLastNameLabel.Size = New System.Drawing.Size(141, 13)
        ContactSecondLastNameLabel.TabIndex = 11
        ContactSecondLastNameLabel.Text = "Contact Second Last Name:"
        '
        'BusinessEmailLabel
        '
        BusinessEmailLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BusinessEmailLabel.AutoSize = True
        BusinessEmailLabel.Location = New System.Drawing.Point(15, 102)
        BusinessEmailLabel.Name = "BusinessEmailLabel"
        BusinessEmailLabel.Size = New System.Drawing.Size(80, 13)
        BusinessEmailLabel.TabIndex = 5
        BusinessEmailLabel.Text = "Business Email:"
        '
        'ContactFirstLastNameLabel
        '
        ContactFirstLastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactFirstLastNameLabel.AutoSize = True
        ContactFirstLastNameLabel.Location = New System.Drawing.Point(7, 63)
        ContactFirstLastNameLabel.Name = "ContactFirstLastNameLabel"
        ContactFirstLastNameLabel.Size = New System.Drawing.Size(123, 13)
        ContactFirstLastNameLabel.TabIndex = 9
        ContactFirstLastNameLabel.Text = "Contact First Last Name:"
        '
        'BusinessPhoneLabel
        '
        BusinessPhoneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BusinessPhoneLabel.AutoSize = True
        BusinessPhoneLabel.Location = New System.Drawing.Point(14, 65)
        BusinessPhoneLabel.Name = "BusinessPhoneLabel"
        BusinessPhoneLabel.Size = New System.Drawing.Size(86, 13)
        BusinessPhoneLabel.TabIndex = 3
        BusinessPhoneLabel.Text = "Business Phone:"
        '
        'AddressLineTwoLabel
        '
        AddressLineTwoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AddressLineTwoLabel.AutoSize = True
        AddressLineTwoLabel.Location = New System.Drawing.Point(2, 62)
        AddressLineTwoLabel.Name = "AddressLineTwoLabel"
        AddressLineTwoLabel.Size = New System.Drawing.Size(95, 13)
        AddressLineTwoLabel.TabIndex = 17
        AddressLineTwoLabel.Text = "Address Line Two:"
        '
        'ZipcodeLabel
        '
        ZipcodeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ZipcodeLabel.AutoSize = True
        ZipcodeLabel.Location = New System.Drawing.Point(2, 163)
        ZipcodeLabel.Name = "ZipcodeLabel"
        ZipcodeLabel.Size = New System.Drawing.Size(49, 13)
        ZipcodeLabel.TabIndex = 23
        ZipcodeLabel.Text = "Zipcode:"
        '
        'ContactNameLabel
        '
        ContactNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Location = New System.Drawing.Point(7, 26)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(78, 13)
        ContactNameLabel.TabIndex = 7
        ContactNameLabel.Text = "Contact Name:"
        '
        'CountryLabel
        '
        CountryLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(3, 125)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 21
        CountryLabel.Text = "Country:"
        '
        'ContactPhoneLabel
        '
        ContactPhoneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ContactPhoneLabel.AutoSize = True
        ContactPhoneLabel.Location = New System.Drawing.Point(7, 136)
        ContactPhoneLabel.Name = "ContactPhoneLabel"
        ContactPhoneLabel.Size = New System.Drawing.Size(81, 13)
        ContactPhoneLabel.TabIndex = 13
        ContactPhoneLabel.Text = "Contact Phone:"
        '
        'CityLabel
        '
        CityLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(3, 89)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 19
        CityLabel.Text = "City:"
        '
        'AddressLineOneLabel
        '
        AddressLineOneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AddressLineOneLabel.AutoSize = True
        AddressLineOneLabel.Location = New System.Drawing.Point(2, 26)
        AddressLineOneLabel.Name = "AddressLineOneLabel"
        AddressLineOneLabel.Size = New System.Drawing.Size(94, 13)
        AddressLineOneLabel.TabIndex = 15
        AddressLineOneLabel.Text = "Address Line One:"
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(12, 516)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(140, 81)
        Me.BackButton.TabIndex = 26
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ContactSecondLastNameTextBox
        '
        Me.ContactSecondLastNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactSecondLastNameTextBox.Location = New System.Drawing.Point(175, 100)
        Me.ContactSecondLastNameTextBox.Name = "ContactSecondLastNameTextBox"
        Me.ContactSecondLastNameTextBox.Size = New System.Drawing.Size(335, 20)
        Me.ContactSecondLastNameTextBox.TabIndex = 12
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.Location = New System.Drawing.Point(576, 499)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(228, 98)
        Me.SaveButton.TabIndex = 25
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BusinessEmailTextBox
        '
        Me.BusinessEmailTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusinessEmailTextBox.Location = New System.Drawing.Point(104, 99)
        Me.BusinessEmailTextBox.Name = "BusinessEmailTextBox"
        Me.BusinessEmailTextBox.Size = New System.Drawing.Size(277, 20)
        Me.BusinessEmailTextBox.TabIndex = 6
        '
        'ContactFirstLastNameTextBox
        '
        Me.ContactFirstLastNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactFirstLastNameTextBox.Location = New System.Drawing.Point(175, 63)
        Me.ContactFirstLastNameTextBox.Name = "ContactFirstLastNameTextBox"
        Me.ContactFirstLastNameTextBox.Size = New System.Drawing.Size(335, 20)
        Me.ContactFirstLastNameTextBox.TabIndex = 10
        '
        'BusinessNameTextBox
        '
        Me.BusinessNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusinessNameTextBox.Location = New System.Drawing.Point(104, 22)
        Me.BusinessNameTextBox.Name = "BusinessNameTextBox"
        Me.BusinessNameTextBox.Size = New System.Drawing.Size(277, 20)
        Me.BusinessNameTextBox.TabIndex = 2
        '
        'AddressLineTwoTextBox
        '
        Me.AddressLineTwoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressLineTwoTextBox.Location = New System.Drawing.Point(103, 59)
        Me.AddressLineTwoTextBox.Name = "AddressLineTwoTextBox"
        Me.AddressLineTwoTextBox.Size = New System.Drawing.Size(240, 20)
        Me.AddressLineTwoTextBox.TabIndex = 18
        '
        'ZipcodeTextBox
        '
        Me.ZipcodeTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZipcodeTextBox.Location = New System.Drawing.Point(103, 160)
        Me.ZipcodeTextBox.Name = "ZipcodeTextBox"
        Me.ZipcodeTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ZipcodeTextBox.TabIndex = 24
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContactNameTextBox.Location = New System.Drawing.Point(175, 26)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(335, 20)
        Me.ContactNameTextBox.TabIndex = 8
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountryTextBox.Location = New System.Drawing.Point(103, 122)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(240, 20)
        Me.CountryTextBox.TabIndex = 22
        '
        'AddressLineOneTextBox
        '
        Me.AddressLineOneTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressLineOneTextBox.Location = New System.Drawing.Point(103, 23)
        Me.AddressLineOneTextBox.Name = "AddressLineOneTextBox"
        Me.AddressLineOneTextBox.Size = New System.Drawing.Size(240, 20)
        Me.AddressLineOneTextBox.TabIndex = 16
        '
        'CityTextBox
        '
        Me.CityTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CityTextBox.Location = New System.Drawing.Point(103, 89)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(240, 20)
        Me.CityTextBox.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BusinessPhoneMaskedTextBox)
        Me.Panel1.Controls.Add(BusinessNameLabel)
        Me.Panel1.Controls.Add(BusinessPhoneLabel)
        Me.Panel1.Controls.Add(Me.BusinessNameTextBox)
        Me.Panel1.Controls.Add(Me.BusinessEmailTextBox)
        Me.Panel1.Controls.Add(BusinessEmailLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 418)
        Me.Panel1.TabIndex = 54
        '
        'BusinessPhoneMaskedTextBox
        '
        Me.BusinessPhoneMaskedTextBox.Location = New System.Drawing.Point(104, 62)
        Me.BusinessPhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.BusinessPhoneMaskedTextBox.Name = "BusinessPhoneMaskedTextBox"
        Me.BusinessPhoneMaskedTextBox.Size = New System.Drawing.Size(277, 20)
        Me.BusinessPhoneMaskedTextBox.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.ContactPhoneMaskedTextBox)
        Me.Panel2.Controls.Add(Me.ContactNameTextBox)
        Me.Panel2.Controls.Add(ContactNameLabel)
        Me.Panel2.Controls.Add(Me.ContactFirstLastNameTextBox)
        Me.Panel2.Controls.Add(ContactFirstLastNameLabel)
        Me.Panel2.Controls.Add(Me.ContactSecondLastNameTextBox)
        Me.Panel2.Controls.Add(ContactSecondLastNameLabel)
        Me.Panel2.Controls.Add(ContactPhoneLabel)
        Me.Panel2.Location = New System.Drawing.Point(420, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 418)
        Me.Panel2.TabIndex = 55
        '
        'ContactPhoneMaskedTextBox
        '
        Me.ContactPhoneMaskedTextBox.Location = New System.Drawing.Point(175, 133)
        Me.ContactPhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.ContactPhoneMaskedTextBox.Name = "ContactPhoneMaskedTextBox"
        Me.ContactPhoneMaskedTextBox.Size = New System.Drawing.Size(335, 20)
        Me.ContactPhoneMaskedTextBox.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(AddressLineOneLabel)
        Me.Panel3.Controls.Add(Me.AddressLineOneTextBox)
        Me.Panel3.Controls.Add(AddressLineTwoLabel)
        Me.Panel3.Controls.Add(Me.AddressLineTwoTextBox)
        Me.Panel3.Controls.Add(Me.CityTextBox)
        Me.Panel3.Controls.Add(CityLabel)
        Me.Panel3.Controls.Add(Me.ZipcodeTextBox)
        Me.Panel3.Controls.Add(ZipcodeLabel)
        Me.Panel3.Controls.Add(CountryLabel)
        Me.Panel3.Controls.Add(Me.CountryTextBox)
        Me.Panel3.Location = New System.Drawing.Point(983, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(459, 418)
        Me.Panel3.TabIndex = 56
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.JupiterDataSet
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
        'CreateSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1454, 609)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Supplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ContactSecondLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BusinessEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactFirstLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BusinessNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressLineTwoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressLineOneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ContactPhoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BusinessPhoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents SuppliersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
End Class
