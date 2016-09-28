<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateProduct
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim ReorderPointLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim StateExemptLabel As System.Windows.Forms.Label
        Dim MunicipalExemptLabel As System.Windows.Forms.Label
        Dim WarrantyLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim _PriceLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ReorderPointNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.StateExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.MunicipalExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.WarrantyTextBox = New System.Windows.Forms.TextBox()
        Me.StockNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me._PriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ReorderPointLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        StateExemptLabel = New System.Windows.Forms.Label()
        MunicipalExemptLabel = New System.Windows.Forms.Label()
        WarrantyLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        _PriceLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._PriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(295, 141)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(394, 138)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(538, 141)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 5
        CategoryLabel.Text = "Category:"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Category", True))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(637, 138)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox.TabIndex = 6
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(865, 141)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 7
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(964, 138)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DescriptionTextBox.TabIndex = 8
        '
        'ReorderPointLabel
        '
        ReorderPointLabel.AutoSize = True
        ReorderPointLabel.Location = New System.Drawing.Point(295, 195)
        ReorderPointLabel.Name = "ReorderPointLabel"
        ReorderPointLabel.Size = New System.Drawing.Size(75, 13)
        ReorderPointLabel.TabIndex = 9
        ReorderPointLabel.Text = "Reorder Point:"
        '
        'ReorderPointNumericUpDown
        '
        Me.ReorderPointNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "ReorderPoint", True))
        Me.ReorderPointNumericUpDown.Location = New System.Drawing.Point(394, 195)
        Me.ReorderPointNumericUpDown.Name = "ReorderPointNumericUpDown"
        Me.ReorderPointNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me.ReorderPointNumericUpDown.TabIndex = 10
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(792, 202)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(62, 13)
        SupplierIDLabel.TabIndex = 11
        SupplierIDLabel.Text = "Supplier ID:"
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(891, 199)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SupplierIDComboBox.TabIndex = 12
        '
        'StateExemptLabel
        '
        StateExemptLabel.AutoSize = True
        StateExemptLabel.Location = New System.Drawing.Point(297, 296)
        StateExemptLabel.Name = "StateExemptLabel"
        StateExemptLabel.Size = New System.Drawing.Size(73, 13)
        StateExemptLabel.TabIndex = 13
        StateExemptLabel.Text = "State Exempt:"
        '
        'StateExemptComboBox
        '
        Me.StateExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "StateExempt", True))
        Me.StateExemptComboBox.FormattingEnabled = True
        Me.StateExemptComboBox.Location = New System.Drawing.Point(396, 293)
        Me.StateExemptComboBox.Name = "StateExemptComboBox"
        Me.StateExemptComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StateExemptComboBox.TabIndex = 14
        '
        'MunicipalExemptLabel
        '
        MunicipalExemptLabel.AutoSize = True
        MunicipalExemptLabel.Location = New System.Drawing.Point(532, 296)
        MunicipalExemptLabel.Name = "MunicipalExemptLabel"
        MunicipalExemptLabel.Size = New System.Drawing.Size(93, 13)
        MunicipalExemptLabel.TabIndex = 15
        MunicipalExemptLabel.Text = "Municipal Exempt:"
        '
        'MunicipalExemptComboBox
        '
        Me.MunicipalExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "MunicipalExempt", True))
        Me.MunicipalExemptComboBox.FormattingEnabled = True
        Me.MunicipalExemptComboBox.Location = New System.Drawing.Point(631, 296)
        Me.MunicipalExemptComboBox.Name = "MunicipalExemptComboBox"
        Me.MunicipalExemptComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MunicipalExemptComboBox.TabIndex = 16
        '
        'WarrantyLabel
        '
        WarrantyLabel.AutoSize = True
        WarrantyLabel.Location = New System.Drawing.Point(801, 254)
        WarrantyLabel.Name = "WarrantyLabel"
        WarrantyLabel.Size = New System.Drawing.Size(53, 13)
        WarrantyLabel.TabIndex = 17
        WarrantyLabel.Text = "Warranty:"
        '
        'WarrantyTextBox
        '
        Me.WarrantyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Warranty", True))
        Me.WarrantyTextBox.Location = New System.Drawing.Point(900, 251)
        Me.WarrantyTextBox.Name = "WarrantyTextBox"
        Me.WarrantyTextBox.Size = New System.Drawing.Size(121, 20)
        Me.WarrantyTextBox.TabIndex = 18
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(532, 197)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 19
        StockLabel.Text = "Stock:"
        '
        'StockNumericUpDown
        '
        Me.StockNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "Stock", True))
        Me.StockNumericUpDown.Location = New System.Drawing.Point(631, 197)
        Me.StockNumericUpDown.Name = "StockNumericUpDown"
        Me.StockNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me.StockNumericUpDown.TabIndex = 20
        '
        '_PriceLabel
        '
        _PriceLabel.AutoSize = True
        _PriceLabel.Location = New System.Drawing.Point(296, 252)
        _PriceLabel.Name = "_PriceLabel"
        _PriceLabel.Size = New System.Drawing.Size(37, 13)
        _PriceLabel.TabIndex = 21
        _PriceLabel.Text = " Price:"
        '
        '_PriceNumericUpDown
        '
        Me._PriceNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, " Price", True))
        Me._PriceNumericUpDown.Location = New System.Drawing.Point(395, 252)
        Me._PriceNumericUpDown.Name = "_PriceNumericUpDown"
        Me._PriceNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me._PriceNumericUpDown.TabIndex = 22
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(559, 254)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 23
        CostLabel.Text = "Cost:"
        '
        'CostNumericUpDown
        '
        Me.CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "Cost", True))
        Me.CostNumericUpDown.Location = New System.Drawing.Point(658, 254)
        Me.CostNumericUpDown.Name = "CostNumericUpDown"
        Me.CostNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me.CostNumericUpDown.TabIndex = 24
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(298, 347)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(160, 93)
        Me.SaveButton.TabIndex = 25
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(911, 347)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(160, 93)
        Me.BackButton.TabIndex = 26
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(569, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 33)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Create Product"
        '
        'CreateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 588)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(ReorderPointLabel)
        Me.Controls.Add(Me.ReorderPointNumericUpDown)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDComboBox)
        Me.Controls.Add(StateExemptLabel)
        Me.Controls.Add(Me.StateExemptComboBox)
        Me.Controls.Add(MunicipalExemptLabel)
        Me.Controls.Add(Me.MunicipalExemptComboBox)
        Me.Controls.Add(WarrantyLabel)
        Me.Controls.Add(Me.WarrantyTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockNumericUpDown)
        Me.Controls.Add(_PriceLabel)
        Me.Controls.Add(Me._PriceNumericUpDown)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostNumericUpDown)
        Me.Name = "CreateProduct"
        Me.Text = "CreateProduct"
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._PriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReorderPointNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StateExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MunicipalExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WarrantyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents _PriceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CostNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
