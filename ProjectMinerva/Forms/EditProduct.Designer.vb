<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProduct
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
        Dim StockLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim ReorderPointLabel As System.Windows.Forms.Label
        Dim _PriceLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim MunicipalExemptLabel As System.Windows.Forms.Label
        Dim StateExemptLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim WarrantyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProduct))
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReorderPointNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.StockNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me._PriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MunicipalExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.StateExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.WarrantyTextBox = New System.Windows.Forms.TextBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        StockLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        ReorderPointLabel = New System.Windows.Forms.Label()
        _PriceLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        MunicipalExemptLabel = New System.Windows.Forms.Label()
        StateExemptLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        WarrantyLabel = New System.Windows.Forms.Label()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._PriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StockLabel
        '
        StockLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(11, 91)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 19
        StockLabel.Text = "Stock:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(11, 149)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIDLabel.TabIndex = 21
        SupplierIDLabel.Text = "Supplier:"
        '
        'ReorderPointLabel
        '
        ReorderPointLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReorderPointLabel.AutoSize = True
        ReorderPointLabel.Location = New System.Drawing.Point(11, 43)
        ReorderPointLabel.Name = "ReorderPointLabel"
        ReorderPointLabel.Size = New System.Drawing.Size(75, 13)
        ReorderPointLabel.TabIndex = 17
        ReorderPointLabel.Text = "Reorder Point:"
        '
        '_PriceLabel
        '
        _PriceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        _PriceLabel.AutoSize = True
        _PriceLabel.Location = New System.Drawing.Point(23, 45)
        _PriceLabel.Name = "_PriceLabel"
        _PriceLabel.Size = New System.Drawing.Size(37, 13)
        _PriceLabel.TabIndex = 9
        _PriceLabel.Text = " Price:"
        '
        'CostLabel
        '
        CostLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(23, 90)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 11
        CostLabel.Text = "Cost:"
        '
        'MunicipalExemptLabel
        '
        MunicipalExemptLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MunicipalExemptLabel.AutoSize = True
        MunicipalExemptLabel.Location = New System.Drawing.Point(23, 195)
        MunicipalExemptLabel.Name = "MunicipalExemptLabel"
        MunicipalExemptLabel.Size = New System.Drawing.Size(93, 13)
        MunicipalExemptLabel.TabIndex = 15
        MunicipalExemptLabel.Text = "Municipal Exempt:"
        '
        'StateExemptLabel
        '
        StateExemptLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StateExemptLabel.AutoSize = True
        StateExemptLabel.Location = New System.Drawing.Point(23, 151)
        StateExemptLabel.Name = "StateExemptLabel"
        StateExemptLabel.Size = New System.Drawing.Size(73, 13)
        StateExemptLabel.TabIndex = 13
        StateExemptLabel.Text = "State Exempt:"
        '
        'NameLabel
        '
        NameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(4, 48)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(4, 158)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'CategoryLabel
        '
        CategoryLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(4, 103)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 3
        CategoryLabel.Text = "Category:"
        '
        'WarrantyLabel
        '
        WarrantyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        WarrantyLabel.AutoSize = True
        WarrantyLabel.Location = New System.Drawing.Point(4, 215)
        WarrantyLabel.Name = "WarrantyLabel"
        WarrantyLabel.Size = New System.Drawing.Size(53, 13)
        WarrantyLabel.TabIndex = 7
        WarrantyLabel.Text = "Warranty:"
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.JupiterDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.LineItemsTableAdapter = Nothing
        Me.TableAdapterManager.NotesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.ServicesTableAdapter = Nothing
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TiresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
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
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.ReorderPointNumericUpDown)
        Me.Panel3.Controls.Add(Me.StockNumericUpDown)
        Me.Panel3.Controls.Add(StockLabel)
        Me.Panel3.Controls.Add(Me.SupplierIDComboBox)
        Me.Panel3.Controls.Add(SupplierIDLabel)
        Me.Panel3.Controls.Add(ReorderPointLabel)
        Me.Panel3.Location = New System.Drawing.Point(923, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 372)
        Me.Panel3.TabIndex = 34
        '
        'ReorderPointNumericUpDown
        '
        Me.ReorderPointNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReorderPointNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "ReorderPoint", True))
        Me.ReorderPointNumericUpDown.Location = New System.Drawing.Point(110, 43)
        Me.ReorderPointNumericUpDown.Name = "ReorderPointNumericUpDown"
        Me.ReorderPointNumericUpDown.Size = New System.Drawing.Size(243, 20)
        Me.ReorderPointNumericUpDown.TabIndex = 18
        '
        'StockNumericUpDown
        '
        Me.StockNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "Stock", True))
        Me.StockNumericUpDown.Location = New System.Drawing.Point(110, 91)
        Me.StockNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.StockNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StockNumericUpDown.Name = "StockNumericUpDown"
        Me.StockNumericUpDown.Size = New System.Drawing.Size(243, 20)
        Me.StockNumericUpDown.TabIndex = 20
        Me.StockNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.DataSource = Me.SuppliersBindingSource
        Me.SupplierIDComboBox.DisplayMember = "BusinessName"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(110, 146)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(243, 21)
        Me.SupplierIDComboBox.TabIndex = 22
        Me.SupplierIDComboBox.ValueMember = "Id"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(_PriceLabel)
        Me.Panel2.Controls.Add(Me.CostNumericUpDown)
        Me.Panel2.Controls.Add(CostLabel)
        Me.Panel2.Controls.Add(Me._PriceNumericUpDown)
        Me.Panel2.Controls.Add(Me.MunicipalExemptComboBox)
        Me.Panel2.Controls.Add(MunicipalExemptLabel)
        Me.Panel2.Controls.Add(Me.StateExemptComboBox)
        Me.Panel2.Controls.Add(StateExemptLabel)
        Me.Panel2.Location = New System.Drawing.Point(463, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 372)
        Me.Panel2.TabIndex = 33
        '
        'CostNumericUpDown
        '
        Me.CostNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "Cost", True))
        Me.CostNumericUpDown.DecimalPlaces = 2
        Me.CostNumericUpDown.Location = New System.Drawing.Point(122, 90)
        Me.CostNumericUpDown.Name = "CostNumericUpDown"
        Me.CostNumericUpDown.Size = New System.Drawing.Size(223, 20)
        Me.CostNumericUpDown.TabIndex = 12
        '
        '_PriceNumericUpDown
        '
        Me._PriceNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._PriceNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, " Price", True))
        Me._PriceNumericUpDown.DecimalPlaces = 2
        Me._PriceNumericUpDown.Location = New System.Drawing.Point(122, 45)
        Me._PriceNumericUpDown.Name = "_PriceNumericUpDown"
        Me._PriceNumericUpDown.Size = New System.Drawing.Size(223, 20)
        Me._PriceNumericUpDown.TabIndex = 10
        '
        'MunicipalExemptComboBox
        '
        Me.MunicipalExemptComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MunicipalExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "MunicipalExempt", True))
        Me.MunicipalExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MunicipalExemptComboBox.FormattingEnabled = True
        Me.MunicipalExemptComboBox.Items.AddRange(New Object() {"No", "Yes"})
        Me.MunicipalExemptComboBox.Location = New System.Drawing.Point(122, 195)
        Me.MunicipalExemptComboBox.Name = "MunicipalExemptComboBox"
        Me.MunicipalExemptComboBox.Size = New System.Drawing.Size(223, 21)
        Me.MunicipalExemptComboBox.TabIndex = 16
        '
        'StateExemptComboBox
        '
        Me.StateExemptComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StateExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "StateExempt", True))
        Me.StateExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateExemptComboBox.FormattingEnabled = True
        Me.StateExemptComboBox.Items.AddRange(New Object() {"No", "Yes"})
        Me.StateExemptComboBox.Location = New System.Drawing.Point(122, 148)
        Me.StateExemptComboBox.Name = "StateExemptComboBox"
        Me.StateExemptComboBox.Size = New System.Drawing.Size(223, 21)
        Me.StateExemptComboBox.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Panel1.Controls.Add(DescriptionLabel)
        Me.Panel1.Controls.Add(CategoryLabel)
        Me.Panel1.Controls.Add(Me.DescriptionTextBox)
        Me.Panel1.Controls.Add(Me.WarrantyTextBox)
        Me.Panel1.Controls.Add(WarrantyLabel)
        Me.Panel1.Location = New System.Drawing.Point(27, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 372)
        Me.Panel1.TabIndex = 32
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(103, 45)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(201, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Category", True))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(103, 100)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(201, 21)
        Me.CategoryComboBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(103, 155)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(201, 20)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'WarrantyTextBox
        '
        Me.WarrantyTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WarrantyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Warranty", True))
        Me.WarrantyTextBox.Location = New System.Drawing.Point(103, 212)
        Me.WarrantyTextBox.Name = "WarrantyTextBox"
        Me.WarrantyTextBox.Size = New System.Drawing.Size(201, 20)
        Me.WarrantyTextBox.TabIndex = 8
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(12, 494)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(160, 93)
        Me.BackButton.TabIndex = 31
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Image = Global.ProjectMinerva.My.Resources.Resources.Save_as_icon
        Me.SaveButton.Location = New System.Drawing.Point(606, 494)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(160, 93)
        Me.SaveButton.TabIndex = 30
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'EditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1355, 599)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._PriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ReorderPointNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents StockNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CostNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents _PriceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MunicipalExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StateExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WarrantyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
