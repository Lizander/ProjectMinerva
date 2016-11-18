<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesHome
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesHome))
        Me.LineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ManageLineItemsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTiresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DiscountBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubtotalBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StateTaxBox = New System.Windows.Forms.TextBox()
        Me.TotalBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MunicipalTaxBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomerBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OwlsDataSet = New ProjectMinerva.OwlsDataSet()
        Me.AddDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscountAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.LineItemsTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.LineItemsTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.SalesTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter()
        Me.CustomersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.CustomersTableAdapter()
        Me.SalesTableAdapterOwl = New ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter()
        Me.TiresTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter()
        Me.ProductsTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.LineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManageLineItemsMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.OwlsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LineItemsDataGridView
        '
        Me.LineItemsDataGridView.AllowUserToAddRows = False
        Me.LineItemsDataGridView.AllowUserToDeleteRows = False
        Me.LineItemsDataGridView.AutoGenerateColumns = False
        Me.LineItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LineItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.LineItemsDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.LineItemsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LineItemsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.LineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LineItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DiscountAmount, Me.DiscountType})
        Me.LineItemsDataGridView.DataSource = Me.LineItemsBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LineItemsDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.LineItemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.LineItemsDataGridView.GridColor = System.Drawing.Color.MediumTurquoise
        Me.LineItemsDataGridView.Location = New System.Drawing.Point(12, 67)
        Me.LineItemsDataGridView.MultiSelect = False
        Me.LineItemsDataGridView.Name = "LineItemsDataGridView"
        Me.LineItemsDataGridView.ReadOnly = True
        Me.LineItemsDataGridView.RowHeadersVisible = False
        Me.LineItemsDataGridView.RowTemplate.ContextMenuStrip = Me.ManageLineItemsMenu
        Me.LineItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LineItemsDataGridView.ShowEditingIcon = False
        Me.LineItemsDataGridView.Size = New System.Drawing.Size(305, 220)
        Me.LineItemsDataGridView.TabIndex = 1
        '
        'ManageLineItemsMenu
        '
        Me.ManageLineItemsMenu.BackColor = System.Drawing.Color.Azure
        Me.ManageLineItemsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditQuantityToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.AddDiscountToolStripMenuItem})
        Me.ManageLineItemsMenu.Name = "ManageLineItemsMenu"
        Me.ManageLineItemsMenu.Size = New System.Drawing.Size(138, 70)
        '
        'EditQuantityToolStripMenuItem
        '
        Me.EditQuantityToolStripMenuItem.Name = "EditQuantityToolStripMenuItem"
        Me.EditQuantityToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EditQuantityToolStripMenuItem.Text = "Edit Quantity"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.AddCustomerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1355, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.AddItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTiresToolStripMenuItem, Me.AddProductsToolStripMenuItem, Me.AddServicesToolStripMenuItem})
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'AddTiresToolStripMenuItem
        '
        Me.AddTiresToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.AddTiresToolStripMenuItem.Name = "AddTiresToolStripMenuItem"
        Me.AddTiresToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AddTiresToolStripMenuItem.Text = "Add Tires"
        '
        'AddProductsToolStripMenuItem
        '
        Me.AddProductsToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.AddProductsToolStripMenuItem.Name = "AddProductsToolStripMenuItem"
        Me.AddProductsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AddProductsToolStripMenuItem.Text = "Add Products"
        '
        'AddServicesToolStripMenuItem
        '
        Me.AddServicesToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.AddServicesToolStripMenuItem.Name = "AddServicesToolStripMenuItem"
        Me.AddServicesToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AddServicesToolStripMenuItem.Text = "Add Services"
        '
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.AddCustomerToolStripMenuItem.Text = "Add Customer"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Discount:"
        '
        'DiscountBox
        '
        Me.DiscountBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountBox.Enabled = False
        Me.DiscountBox.Location = New System.Drawing.Point(167, 13)
        Me.DiscountBox.Name = "DiscountBox"
        Me.DiscountBox.Size = New System.Drawing.Size(100, 20)
        Me.DiscountBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Subtotal:"
        '
        'SubtotalBox
        '
        Me.SubtotalBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubtotalBox.Enabled = False
        Me.SubtotalBox.Location = New System.Drawing.Point(167, 64)
        Me.SubtotalBox.Name = "SubtotalBox"
        Me.SubtotalBox.Size = New System.Drawing.Size(100, 20)
        Me.SubtotalBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "State Tax:"
        '
        'StateTaxBox
        '
        Me.StateTaxBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StateTaxBox.Enabled = False
        Me.StateTaxBox.Location = New System.Drawing.Point(167, 113)
        Me.StateTaxBox.Name = "StateTaxBox"
        Me.StateTaxBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTaxBox.TabIndex = 8
        '
        'TotalBox
        '
        Me.TotalBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalBox.Enabled = False
        Me.TotalBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBox.Location = New System.Drawing.Point(167, 205)
        Me.TotalBox.Name = "TotalBox"
        Me.TotalBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total:"
        '
        'MunicipalTaxBox
        '
        Me.MunicipalTaxBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MunicipalTaxBox.Enabled = False
        Me.MunicipalTaxBox.Location = New System.Drawing.Point(167, 156)
        Me.MunicipalTaxBox.Name = "MunicipalTaxBox"
        Me.MunicipalTaxBox.Size = New System.Drawing.Size(100, 20)
        Me.MunicipalTaxBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Municipal Tax:"
        '
        'CustomerBox
        '
        Me.CustomerBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerBox.Enabled = False
        Me.CustomerBox.Location = New System.Drawing.Point(167, 251)
        Me.CustomerBox.Name = "CustomerBox"
        Me.CustomerBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Customer:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DiscountBox)
        Me.Panel1.Controls.Add(Me.CustomerBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TotalBox)
        Me.Panel1.Controls.Add(Me.SubtotalBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.MunicipalTaxBox)
        Me.Panel1.Controls.Add(Me.StateTaxBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(1003, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 295)
        Me.Panel1.TabIndex = 15
        '
        'OwlsDataSet
        '
        Me.OwlsDataSet.DataSetName = "OwlsDataSet"
        Me.OwlsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddDiscountToolStripMenuItem
        '
        Me.AddDiscountToolStripMenuItem.Name = "AddDiscountToolStripMenuItem"
        Me.AddDiscountToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AddDiscountToolStripMenuItem.Text = "Add Discount"
        '
        'DiscountAmount
        '
        Me.DiscountAmount.DataPropertyName = "DiscountAmount"
        Me.DiscountAmount.HeaderText = "DiscountAmount"
        Me.DiscountAmount.Name = "DiscountAmount"
        Me.DiscountAmount.ReadOnly = True
        Me.DiscountAmount.Visible = False
        '
        'DiscountType
        '
        Me.DiscountType.DataPropertyName = "DiscountType"
        Me.DiscountType.HeaderText = "DiscountType"
        Me.DiscountType.Name = "DiscountType"
        Me.DiscountType.ReadOnly = True
        Me.DiscountType.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ItemID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ItemType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ItemType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SaleID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SaleID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ExtendedPrice"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ExtendedPrice"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SubtotalOne"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SubtotalOne"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SubtotalTwo"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DiscountPrice"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DiscountPrice"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "StateTax"
        Me.DataGridViewTextBoxColumn13.HeaderText = "StateTax"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "MunicipalTax"
        Me.DataGridViewTextBoxColumn14.HeaderText = "MunicipalTax"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'LineItemsBindingSource
        '
        Me.LineItemsBindingSource.DataMember = "LineItems"
        Me.LineItemsBindingSource.DataSource = Me.JupiterDataSet
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineItemsTableAdapter
        '
        Me.LineItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.LineItemsTableAdapter = Me.LineItemsTableAdapter
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
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapterOwl
        '
        Me.SalesTableAdapterOwl.ClearBeforeFill = True
        '
        'TiresTableAdapter
        '
        Me.TiresTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'SalesHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1355, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LineItemsDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManageLineItemsMenu.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OwlsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents LineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineItemsTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.LineItemsTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LineItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTiresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DiscountBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubtotalBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StateTaxBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MunicipalTaxBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CustomerBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CustomersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents OwlsDataSet As ProjectMinerva.OwlsDataSet
    Friend WithEvents SalesTableAdapterOwl As ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents ManageLineItemsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditQuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiresTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter
    Friend WithEvents ProductsTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents AddDiscountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
