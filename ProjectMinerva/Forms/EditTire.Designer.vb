<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTire
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
        Dim TractionLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim TemperatureLabel As System.Windows.Forms.Label
        Dim TreadwearLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim WidthLabel As System.Windows.Forms.Label
        Dim ConditionLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim RazonAvALabel As System.Windows.Forms.Label
        Dim DiameterLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim StateExemptLabel As System.Windows.Forms.Label
        Dim ReorderPointLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim MunicipalExemptLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditTire))
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.SuppliersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter()
        Me.TiresTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.TractionTextBox = New System.Windows.Forms.TextBox()
        Me.TiresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.TemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.TreadwearTextBox = New System.Windows.Forms.TextBox()
        Me.CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.PriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ReorderPointNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.StateExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.MunicipalExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.BrandComboBox = New System.Windows.Forms.ComboBox()
        Me.ConditionComboBox = New System.Windows.Forms.ComboBox()
        Me.RazonAvATextBox = New System.Windows.Forms.TextBox()
        Me.DiameterTextBox = New System.Windows.Forms.TextBox()
        Me.StockNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        TractionLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        TemperatureLabel = New System.Windows.Forms.Label()
        TreadwearLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        WidthLabel = New System.Windows.Forms.Label()
        ConditionLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        RazonAvALabel = New System.Windows.Forms.Label()
        DiameterLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        StateExemptLabel = New System.Windows.Forms.Label()
        ReorderPointLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        MunicipalExemptLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TractionLabel
        '
        TractionLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TractionLabel.AutoSize = True
        TractionLabel.Location = New System.Drawing.Point(14, 99)
        TractionLabel.Name = "TractionLabel"
        TractionLabel.Size = New System.Drawing.Size(49, 13)
        TractionLabel.TabIndex = 13
        TractionLabel.Text = "Traction:"
        '
        'ModelLabel
        '
        ModelLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(14, 38)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 11
        ModelLabel.Text = "Model:"
        '
        'TemperatureLabel
        '
        TemperatureLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TemperatureLabel.AutoSize = True
        TemperatureLabel.Location = New System.Drawing.Point(14, 168)
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
        TreadwearLabel.Location = New System.Drawing.Point(14, 225)
        TreadwearLabel.Name = "TreadwearLabel"
        TreadwearLabel.Size = New System.Drawing.Size(61, 13)
        TreadwearLabel.TabIndex = 17
        TreadwearLabel.Text = "Treadwear:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(14, 291)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIDLabel.TabIndex = 19
        SupplierIDLabel.Text = "Supplier:"
        '
        'WidthLabel
        '
        WidthLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        WidthLabel.AutoSize = True
        WidthLabel.Location = New System.Drawing.Point(33, 38)
        WidthLabel.Name = "WidthLabel"
        WidthLabel.Size = New System.Drawing.Size(38, 13)
        WidthLabel.TabIndex = 1
        WidthLabel.Text = "Width:"
        '
        'ConditionLabel
        '
        ConditionLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ConditionLabel.AutoSize = True
        ConditionLabel.Location = New System.Drawing.Point(33, 291)
        ConditionLabel.Name = "ConditionLabel"
        ConditionLabel.Size = New System.Drawing.Size(54, 13)
        ConditionLabel.TabIndex = 9
        ConditionLabel.Text = "Condition:"
        '
        'BrandLabel
        '
        BrandLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(32, 225)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(38, 13)
        BrandLabel.TabIndex = 7
        BrandLabel.Text = "Brand:"
        '
        'RazonAvALabel
        '
        RazonAvALabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RazonAvALabel.AutoSize = True
        RazonAvALabel.Location = New System.Drawing.Point(32, 99)
        RazonAvALabel.Name = "RazonAvALabel"
        RazonAvALabel.Size = New System.Drawing.Size(44, 13)
        RazonAvALabel.TabIndex = 3
        RazonAvALabel.Text = "R Av A:"
        '
        'DiameterLabel
        '
        DiameterLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DiameterLabel.AutoSize = True
        DiameterLabel.Location = New System.Drawing.Point(32, 168)
        DiameterLabel.Name = "DiameterLabel"
        DiameterLabel.Size = New System.Drawing.Size(52, 13)
        DiameterLabel.TabIndex = 5
        DiameterLabel.Text = "Diameter:"
        '
        'PriceLabel
        '
        PriceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(22, 38)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 21
        PriceLabel.Text = "Price:"
        '
        'CostLabel
        '
        CostLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(22, 99)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 23
        CostLabel.Text = "Cost:"
        '
        'StateExemptLabel
        '
        StateExemptLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StateExemptLabel.AutoSize = True
        StateExemptLabel.Location = New System.Drawing.Point(22, 343)
        StateExemptLabel.Name = "StateExemptLabel"
        StateExemptLabel.Size = New System.Drawing.Size(73, 13)
        StateExemptLabel.TabIndex = 31
        StateExemptLabel.Text = "State Exempt:"
        '
        'ReorderPointLabel
        '
        ReorderPointLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReorderPointLabel.AutoSize = True
        ReorderPointLabel.Location = New System.Drawing.Point(22, 168)
        ReorderPointLabel.Name = "ReorderPointLabel"
        ReorderPointLabel.Size = New System.Drawing.Size(75, 13)
        ReorderPointLabel.TabIndex = 25
        ReorderPointLabel.Text = "Reorder Point:"
        '
        'StockLabel
        '
        StockLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(22, 225)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 27
        StockLabel.Text = "Stock:"
        '
        'MunicipalExemptLabel
        '
        MunicipalExemptLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MunicipalExemptLabel.AutoSize = True
        MunicipalExemptLabel.Location = New System.Drawing.Point(22, 291)
        MunicipalExemptLabel.Name = "MunicipalExemptLabel"
        MunicipalExemptLabel.Size = New System.Drawing.Size(93, 13)
        MunicipalExemptLabel.TabIndex = 29
        MunicipalExemptLabel.Text = "Municipal Exempt:"
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
        Me.TableAdapterManager.TiresTableAdapter = Me.TiresTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'TiresTableAdapter
        '
        Me.TiresTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.SupplierIDComboBox)
        Me.Panel2.Controls.Add(Me.TractionTextBox)
        Me.Panel2.Controls.Add(TractionLabel)
        Me.Panel2.Controls.Add(Me.ModelTextBox)
        Me.Panel2.Controls.Add(ModelLabel)
        Me.Panel2.Controls.Add(Me.TemperatureTextBox)
        Me.Panel2.Controls.Add(TemperatureLabel)
        Me.Panel2.Controls.Add(Me.TreadwearTextBox)
        Me.Panel2.Controls.Add(TreadwearLabel)
        Me.Panel2.Controls.Add(SupplierIDLabel)
        Me.Panel2.Location = New System.Drawing.Point(563, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 419)
        Me.Panel2.TabIndex = 56
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "BusinessName", True))
        Me.SupplierIDComboBox.DataSource = Me.SuppliersBindingSource
        Me.SupplierIDComboBox.DisplayMember = "BusinessName"
        Me.SupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(112, 288)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(228, 21)
        Me.SupplierIDComboBox.TabIndex = 20
        Me.SupplierIDComboBox.ValueMember = "Id"
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.AllowNew = False
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.JupiterDataSet
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TractionTextBox
        '
        Me.TractionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TractionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Traction", True))
        Me.TractionTextBox.Location = New System.Drawing.Point(112, 96)
        Me.TractionTextBox.Name = "TractionTextBox"
        Me.TractionTextBox.Size = New System.Drawing.Size(228, 20)
        Me.TractionTextBox.TabIndex = 14
        '
        'TiresBindingSource
        '
        Me.TiresBindingSource.DataMember = "Tires"
        Me.TiresBindingSource.DataSource = Me.JupiterDataSet
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(113, 35)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(228, 20)
        Me.ModelTextBox.TabIndex = 12
        '
        'TemperatureTextBox
        '
        Me.TemperatureTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TemperatureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Temperature", True))
        Me.TemperatureTextBox.Location = New System.Drawing.Point(112, 165)
        Me.TemperatureTextBox.Name = "TemperatureTextBox"
        Me.TemperatureTextBox.Size = New System.Drawing.Size(228, 20)
        Me.TemperatureTextBox.TabIndex = 16
        '
        'TreadwearTextBox
        '
        Me.TreadwearTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreadwearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Treadwear", True))
        Me.TreadwearTextBox.Location = New System.Drawing.Point(112, 225)
        Me.TreadwearTextBox.Name = "TreadwearTextBox"
        Me.TreadwearTextBox.Size = New System.Drawing.Size(228, 20)
        Me.TreadwearTextBox.TabIndex = 18
        '
        'CostNumericUpDown
        '
        Me.CostNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "Cost", True))
        Me.CostNumericUpDown.DecimalPlaces = 2
        Me.CostNumericUpDown.Location = New System.Drawing.Point(117, 97)
        Me.CostNumericUpDown.Name = "CostNumericUpDown"
        Me.CostNumericUpDown.Size = New System.Drawing.Size(179, 20)
        Me.CostNumericUpDown.TabIndex = 24
        '
        'PriceNumericUpDown
        '
        Me.PriceNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PriceNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "Price", True))
        Me.PriceNumericUpDown.DecimalPlaces = 2
        Me.PriceNumericUpDown.Location = New System.Drawing.Point(117, 36)
        Me.PriceNumericUpDown.Name = "PriceNumericUpDown"
        Me.PriceNumericUpDown.Size = New System.Drawing.Size(179, 20)
        Me.PriceNumericUpDown.TabIndex = 22
        '
        'ReorderPointNumericUpDown
        '
        Me.ReorderPointNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReorderPointNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "ReorderPoint", True))
        Me.ReorderPointNumericUpDown.Location = New System.Drawing.Point(117, 165)
        Me.ReorderPointNumericUpDown.Name = "ReorderPointNumericUpDown"
        Me.ReorderPointNumericUpDown.Size = New System.Drawing.Size(179, 20)
        Me.ReorderPointNumericUpDown.TabIndex = 26
        '
        'StateExemptComboBox
        '
        Me.StateExemptComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StateExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "StateExempt", True))
        Me.StateExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateExemptComboBox.FormattingEnabled = True
        Me.StateExemptComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.StateExemptComboBox.Location = New System.Drawing.Point(117, 340)
        Me.StateExemptComboBox.Name = "StateExemptComboBox"
        Me.StateExemptComboBox.Size = New System.Drawing.Size(179, 21)
        Me.StateExemptComboBox.TabIndex = 32
        '
        'MunicipalExemptComboBox
        '
        Me.MunicipalExemptComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MunicipalExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "MunicipalExempt", True))
        Me.MunicipalExemptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MunicipalExemptComboBox.FormattingEnabled = True
        Me.MunicipalExemptComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.MunicipalExemptComboBox.Location = New System.Drawing.Point(116, 288)
        Me.MunicipalExemptComboBox.Name = "MunicipalExemptComboBox"
        Me.MunicipalExemptComboBox.Size = New System.Drawing.Size(180, 21)
        Me.MunicipalExemptComboBox.TabIndex = 30
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Image = Global.ProjectMinerva.My.Resources.Resources.Save_as_icon
        Me.SaveButton.Location = New System.Drawing.Point(677, 446)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(176, 107)
        Me.SaveButton.TabIndex = 54
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(12, 489)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(176, 82)
        Me.BackButton.TabIndex = 53
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.WidthTextBox)
        Me.Panel1.Controls.Add(WidthLabel)
        Me.Panel1.Controls.Add(ConditionLabel)
        Me.Panel1.Controls.Add(Me.BrandComboBox)
        Me.Panel1.Controls.Add(Me.ConditionComboBox)
        Me.Panel1.Controls.Add(BrandLabel)
        Me.Panel1.Controls.Add(RazonAvALabel)
        Me.Panel1.Controls.Add(Me.RazonAvATextBox)
        Me.Panel1.Controls.Add(Me.DiameterTextBox)
        Me.Panel1.Controls.Add(DiameterLabel)
        Me.Panel1.Location = New System.Drawing.Point(54, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 419)
        Me.Panel1.TabIndex = 55
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WidthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Width", True))
        Me.WidthTextBox.Location = New System.Drawing.Point(132, 35)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(198, 20)
        Me.WidthTextBox.TabIndex = 2
        '
        'BrandComboBox
        '
        Me.BrandComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrandComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Brand", True))
        Me.BrandComboBox.FormattingEnabled = True
        Me.BrandComboBox.Items.AddRange(New Object() {"N/A"})
        Me.BrandComboBox.Location = New System.Drawing.Point(131, 225)
        Me.BrandComboBox.Name = "BrandComboBox"
        Me.BrandComboBox.Size = New System.Drawing.Size(198, 21)
        Me.BrandComboBox.TabIndex = 8
        '
        'ConditionComboBox
        '
        Me.ConditionComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConditionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Condition", True))
        Me.ConditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConditionComboBox.FormattingEnabled = True
        Me.ConditionComboBox.Items.AddRange(New Object() {"New", "Used"})
        Me.ConditionComboBox.Location = New System.Drawing.Point(131, 288)
        Me.ConditionComboBox.Name = "ConditionComboBox"
        Me.ConditionComboBox.Size = New System.Drawing.Size(199, 21)
        Me.ConditionComboBox.TabIndex = 10
        '
        'RazonAvATextBox
        '
        Me.RazonAvATextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RazonAvATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "RazonAvA", True))
        Me.RazonAvATextBox.Location = New System.Drawing.Point(131, 96)
        Me.RazonAvATextBox.Name = "RazonAvATextBox"
        Me.RazonAvATextBox.Size = New System.Drawing.Size(198, 20)
        Me.RazonAvATextBox.TabIndex = 4
        '
        'DiameterTextBox
        '
        Me.DiameterTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiameterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiresBindingSource, "Diameter", True))
        Me.DiameterTextBox.Location = New System.Drawing.Point(131, 165)
        Me.DiameterTextBox.Name = "DiameterTextBox"
        Me.DiameterTextBox.Size = New System.Drawing.Size(198, 20)
        Me.DiameterTextBox.TabIndex = 6
        '
        'StockNumericUpDown
        '
        Me.StockNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TiresBindingSource, "Stock", True))
        Me.StockNumericUpDown.Location = New System.Drawing.Point(117, 223)
        Me.StockNumericUpDown.Name = "StockNumericUpDown"
        Me.StockNumericUpDown.Size = New System.Drawing.Size(180, 20)
        Me.StockNumericUpDown.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(PriceLabel)
        Me.Panel3.Controls.Add(Me.CostNumericUpDown)
        Me.Panel3.Controls.Add(CostLabel)
        Me.Panel3.Controls.Add(Me.PriceNumericUpDown)
        Me.Panel3.Controls.Add(Me.ReorderPointNumericUpDown)
        Me.Panel3.Controls.Add(StateExemptLabel)
        Me.Panel3.Controls.Add(Me.StateExemptComboBox)
        Me.Panel3.Controls.Add(ReorderPointLabel)
        Me.Panel3.Controls.Add(StockLabel)
        Me.Panel3.Controls.Add(Me.MunicipalExemptComboBox)
        Me.Panel3.Controls.Add(Me.StockNumericUpDown)
        Me.Panel3.Controls.Add(MunicipalExemptLabel)
        Me.Panel3.Location = New System.Drawing.Point(1058, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(388, 419)
        Me.Panel3.TabIndex = 57
        '
        'EditTire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1487, 583)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditTire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Tire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderPointNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StockNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TractionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TiresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemperatureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TreadwearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents PriceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ReorderPointNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents StateExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MunicipalExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents SuppliersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents WidthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ConditionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RazonAvATextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiameterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TiresTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter
End Class
