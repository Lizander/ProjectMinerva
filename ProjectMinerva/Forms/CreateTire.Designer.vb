<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTire
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
        Dim ModelLabel As System.Windows.Forms.Label
        Dim WidthLabel As System.Windows.Forms.Label
        Dim RazonAvALabel As System.Windows.Forms.Label
        Dim DiameterLabel As System.Windows.Forms.Label
        Dim TractionLabel As System.Windows.Forms.Label
        Dim TemperatureLabel As System.Windows.Forms.Label
        Dim TreadwearLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim ReorderPointLabel As System.Windows.Forms.Label
        Dim StateExemptLabel As System.Windows.Forms.Label
        Dim MunicipalExemptLabel As System.Windows.Forms.Label
        Dim ConditionLabel As System.Windows.Forms.Label
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.TiresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiresTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.RazonAvATextBox = New System.Windows.Forms.TextBox()
        Me.DiameterTextBox = New System.Windows.Forms.TextBox()
        Me.TractionTextBox = New System.Windows.Forms.TextBox()
        Me.TemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.TreadwearTextBox = New System.Windows.Forms.TextBox()
        Me.BrandComboBox = New System.Windows.Forms.ComboBox()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.StockNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ReorderPointNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.StateExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.MunicipalExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConditionComboBox = New System.Windows.Forms.ComboBox()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter()
        ModelLabel = New System.Windows.Forms.Label()
        WidthLabel = New System.Windows.Forms.Label()
        RazonAvALabel = New System.Windows.Forms.Label()
        DiameterLabel = New System.Windows.Forms.Label()
        TractionLabel = New System.Windows.Forms.Label()
        TemperatureLabel = New System.Windows.Forms.Label()
        TreadwearLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        ReorderPointLabel = New System.Windows.Forms.Label()
        StateExemptLabel = New System.Windows.Forms.Label()
        MunicipalExemptLabel = New System.Windows.Forms.Label()
        ConditionLabel = New System.Windows.Forms.Label()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModelLabel
        '
        ModelLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(572, 130)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 5
        ModelLabel.Text = "Model:"
        '
        'WidthLabel
        '
        WidthLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        WidthLabel.AutoSize = True
        WidthLabel.Location = New System.Drawing.Point(366, 170)
        WidthLabel.Name = "WidthLabel"
        WidthLabel.Size = New System.Drawing.Size(38, 13)
        WidthLabel.TabIndex = 7
        WidthLabel.Text = "Width:"
        '
        'RazonAvALabel
        '
        RazonAvALabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RazonAvALabel.AutoSize = True
        RazonAvALabel.Location = New System.Drawing.Point(594, 174)
        RazonAvALabel.Name = "RazonAvALabel"
        RazonAvALabel.Size = New System.Drawing.Size(67, 13)
        RazonAvALabel.TabIndex = 9
        RazonAvALabel.Text = "Razon Av A:"
        '
        'DiameterLabel
        '
        DiameterLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiameterLabel.AutoSize = True
        DiameterLabel.Location = New System.Drawing.Point(814, 177)
        DiameterLabel.Name = "DiameterLabel"
        DiameterLabel.Size = New System.Drawing.Size(52, 13)
        DiameterLabel.TabIndex = 11
        DiameterLabel.Text = "Diameter:"
        '
        'TractionLabel
        '
        TractionLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TractionLabel.AutoSize = True
        TractionLabel.Location = New System.Drawing.Point(366, 217)
        TractionLabel.Name = "TractionLabel"
        TractionLabel.Size = New System.Drawing.Size(49, 13)
        TractionLabel.TabIndex = 13
        TractionLabel.Text = "Traction:"
        '
        'TemperatureLabel
        '
        TemperatureLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TemperatureLabel.AutoSize = True
        TemperatureLabel.Location = New System.Drawing.Point(591, 217)
        TemperatureLabel.Name = "TemperatureLabel"
        TemperatureLabel.Size = New System.Drawing.Size(70, 13)
        TemperatureLabel.TabIndex = 15
        TemperatureLabel.Text = "Temperature:"
        '
        'TreadwearLabel
        '
        TreadwearLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TreadwearLabel.AutoSize = True
        TreadwearLabel.Location = New System.Drawing.Point(814, 221)
        TreadwearLabel.Name = "TreadwearLabel"
        TreadwearLabel.Size = New System.Drawing.Size(61, 13)
        TreadwearLabel.TabIndex = 27
        TreadwearLabel.Text = "Treadwear:"
        '
        'BrandLabel
        '
        BrandLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(366, 130)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(38, 13)
        BrandLabel.TabIndex = 36
        BrandLabel.Text = "Brand:"
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiresBindingSource
        '
        Me.TiresBindingSource.DataMember = "Tires"
        Me.TiresBindingSource.DataSource = Me.JupiterDataSet
        '
        'TiresTableAdapter
        '
        Me.TiresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TiresTableAdapter = Me.TiresTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(671, 127)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelTextBox.TabIndex = 6
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WidthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Width", True))
        Me.WidthTextBox.Location = New System.Drawing.Point(465, 167)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WidthTextBox.TabIndex = 8
        '
        'RazonAvATextBox
        '
        Me.RazonAvATextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RazonAvATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "RazonAvA", True))
        Me.RazonAvATextBox.Location = New System.Drawing.Point(693, 171)
        Me.RazonAvATextBox.Name = "RazonAvATextBox"
        Me.RazonAvATextBox.Size = New System.Drawing.Size(100, 20)
        Me.RazonAvATextBox.TabIndex = 10
        '
        'DiameterTextBox
        '
        Me.DiameterTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiameterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Diameter", True))
        Me.DiameterTextBox.Location = New System.Drawing.Point(913, 174)
        Me.DiameterTextBox.Name = "DiameterTextBox"
        Me.DiameterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiameterTextBox.TabIndex = 12
        '
        'TractionTextBox
        '
        Me.TractionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TractionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Traction", True))
        Me.TractionTextBox.Location = New System.Drawing.Point(465, 214)
        Me.TractionTextBox.Name = "TractionTextBox"
        Me.TractionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TractionTextBox.TabIndex = 14
        '
        'TemperatureTextBox
        '
        Me.TemperatureTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TemperatureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Temperature", True))
        Me.TemperatureTextBox.Location = New System.Drawing.Point(690, 214)
        Me.TemperatureTextBox.Name = "TemperatureTextBox"
        Me.TemperatureTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TemperatureTextBox.TabIndex = 16
        '
        'TreadwearTextBox
        '
        Me.TreadwearTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreadwearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Treadwear", True))
        Me.TreadwearTextBox.Location = New System.Drawing.Point(913, 218)
        Me.TreadwearTextBox.Name = "TreadwearTextBox"
        Me.TreadwearTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TreadwearTextBox.TabIndex = 28
        '
        'BrandComboBox
        '
        Me.BrandComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrandComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Brand", True))
        Me.BrandComboBox.FormattingEnabled = True
        Me.BrandComboBox.Location = New System.Drawing.Point(410, 127)
        Me.BrandComboBox.Name = "BrandComboBox"
        Me.BrandComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BrandComboBox.TabIndex = 37
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(814, 265)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIDLabel.TabIndex = 37
        SupplierIDLabel.Text = "Supplier:"
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.DataSource = Me.SuppliersBindingSource
        Me.SupplierIDComboBox.DisplayMember = "BusinessName"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(882, 262)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SupplierIDComboBox.TabIndex = 38
        Me.SupplierIDComboBox.ValueMember = "BusinessName"
        '
        'PriceLabel
        '
        PriceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(370, 262)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 38
        PriceLabel.Text = "Price:"
        '
        'PriceNumericUpDown
        '
        Me.PriceNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PriceNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "Price", True))
        Me.PriceNumericUpDown.Location = New System.Drawing.Point(410, 262)
        Me.PriceNumericUpDown.Name = "PriceNumericUpDown"
        Me.PriceNumericUpDown.Size = New System.Drawing.Size(131, 20)
        Me.PriceNumericUpDown.TabIndex = 39
        '
        'CostLabel
        '
        CostLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(594, 262)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 39
        CostLabel.Text = "Cost:"
        '
        'CostNumericUpDown
        '
        Me.CostNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "Cost", True))
        Me.CostNumericUpDown.Location = New System.Drawing.Point(631, 262)
        Me.CostNumericUpDown.Name = "CostNumericUpDown"
        Me.CostNumericUpDown.Size = New System.Drawing.Size(140, 20)
        Me.CostNumericUpDown.TabIndex = 40
        '
        'StockLabel
        '
        StockLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(370, 311)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 40
        StockLabel.Text = "Stock:"
        '
        'StockNumericUpDown
        '
        Me.StockNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "Stock", True))
        Me.StockNumericUpDown.Location = New System.Drawing.Point(414, 311)
        Me.StockNumericUpDown.Name = "StockNumericUpDown"
        Me.StockNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.StockNumericUpDown.TabIndex = 41
        '
        'ReorderPointLabel
        '
        ReorderPointLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReorderPointLabel.AutoSize = True
        ReorderPointLabel.Location = New System.Drawing.Point(591, 311)
        ReorderPointLabel.Name = "ReorderPointLabel"
        ReorderPointLabel.Size = New System.Drawing.Size(75, 13)
        ReorderPointLabel.TabIndex = 41
        ReorderPointLabel.Text = "Reorder Point:"
        '
        'ReorderPointNumericUpDown
        '
        Me.ReorderPointNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReorderPointNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "ReorderPoint", True))
        Me.ReorderPointNumericUpDown.Location = New System.Drawing.Point(672, 311)
        Me.ReorderPointNumericUpDown.Name = "ReorderPointNumericUpDown"
        Me.ReorderPointNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.ReorderPointNumericUpDown.TabIndex = 42
        '
        'StateExemptLabel
        '
        StateExemptLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StateExemptLabel.AutoSize = True
        StateExemptLabel.Location = New System.Drawing.Point(366, 369)
        StateExemptLabel.Name = "StateExemptLabel"
        StateExemptLabel.Size = New System.Drawing.Size(73, 13)
        StateExemptLabel.TabIndex = 42
        StateExemptLabel.Text = "State Exempt:"
        '
        'StateExemptComboBox
        '
        Me.StateExemptComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StateExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "StateExempt", True))
        Me.StateExemptComboBox.FormattingEnabled = True
        Me.StateExemptComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.StateExemptComboBox.Location = New System.Drawing.Point(445, 366)
        Me.StateExemptComboBox.Name = "StateExemptComboBox"
        Me.StateExemptComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StateExemptComboBox.TabIndex = 43
        '
        'MunicipalExemptLabel
        '
        MunicipalExemptLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MunicipalExemptLabel.AutoSize = True
        MunicipalExemptLabel.Location = New System.Drawing.Point(594, 369)
        MunicipalExemptLabel.Name = "MunicipalExemptLabel"
        MunicipalExemptLabel.Size = New System.Drawing.Size(93, 13)
        MunicipalExemptLabel.TabIndex = 43
        MunicipalExemptLabel.Text = "Municipal Exempt:"
        '
        'MunicipalExemptComboBox
        '
        Me.MunicipalExemptComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MunicipalExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "MunicipalExempt", True))
        Me.MunicipalExemptComboBox.FormattingEnabled = True
        Me.MunicipalExemptComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.MunicipalExemptComboBox.Location = New System.Drawing.Point(693, 366)
        Me.MunicipalExemptComboBox.Name = "MunicipalExemptComboBox"
        Me.MunicipalExemptComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MunicipalExemptComboBox.TabIndex = 44
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackButton.Location = New System.Drawing.Point(904, 482)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(176, 82)
        Me.BackButton.TabIndex = 46
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(315, 482)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(176, 82)
        Me.SaveButton.TabIndex = 47
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(587, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 39)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Create Tire"
        '
        'ConditionLabel
        '
        ConditionLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ConditionLabel.AutoSize = True
        ConditionLabel.Location = New System.Drawing.Point(814, 127)
        ConditionLabel.Name = "ConditionLabel"
        ConditionLabel.Size = New System.Drawing.Size(54, 13)
        ConditionLabel.TabIndex = 48
        ConditionLabel.Text = "Condition:"
        '
        'ConditionComboBox
        '
        Me.ConditionComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConditionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Condition", True))
        Me.ConditionComboBox.FormattingEnabled = True
        Me.ConditionComboBox.Items.AddRange(New Object() {"New", "Used"})
        Me.ConditionComboBox.Location = New System.Drawing.Point(874, 124)
        Me.ConditionComboBox.Name = "ConditionComboBox"
        Me.ConditionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ConditionComboBox.TabIndex = 49
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
        'CreateTire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 683)
        Me.Controls.Add(ConditionLabel)
        Me.Controls.Add(Me.ConditionComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(MunicipalExemptLabel)
        Me.Controls.Add(Me.MunicipalExemptComboBox)
        Me.Controls.Add(StateExemptLabel)
        Me.Controls.Add(Me.StateExemptComboBox)
        Me.Controls.Add(ReorderPointLabel)
        Me.Controls.Add(Me.ReorderPointNumericUpDown)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockNumericUpDown)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostNumericUpDown)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceNumericUpDown)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDComboBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandComboBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(WidthLabel)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(RazonAvALabel)
        Me.Controls.Add(Me.RazonAvATextBox)
        Me.Controls.Add(DiameterLabel)
        Me.Controls.Add(Me.DiameterTextBox)
        Me.Controls.Add(TractionLabel)
        Me.Controls.Add(Me.TractionTextBox)
        Me.Controls.Add(TemperatureLabel)
        Me.Controls.Add(Me.TemperatureTextBox)
        Me.Controls.Add(TreadwearLabel)
        Me.Controls.Add(Me.TreadwearTextBox)
        Me.Name = "CreateTire"
        Me.Text = "CreateTire"
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents TiresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiresTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WidthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RazonAvATextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiameterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TractionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemperatureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TreadwearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PriceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CostNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents StockNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ReorderPointNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents StateExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MunicipalExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConditionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter
End Class
