<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateService
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim StateExemptLabel As System.Windows.Forms.Label
        Dim MunicipalExemptLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateService))
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.ServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicesTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.ServicesTableAdapter()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.StateExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.MunicipalExemptComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        StateExemptLabel = New System.Windows.Forms.Label()
        MunicipalExemptLabel = New System.Windows.Forms.Label()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(24, 35)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(24, 80)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(24, 133)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 7
        CategoryLabel.Text = "Category:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(30, 35)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 9
        PriceLabel.Text = "Price:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(30, 80)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 11
        CostLabel.Text = "Cost:"
        '
        'StateExemptLabel
        '
        StateExemptLabel.AutoSize = True
        StateExemptLabel.Location = New System.Drawing.Point(30, 138)
        StateExemptLabel.Name = "StateExemptLabel"
        StateExemptLabel.Size = New System.Drawing.Size(73, 13)
        StateExemptLabel.TabIndex = 15
        StateExemptLabel.Text = "State Exempt:"
        '
        'MunicipalExemptLabel
        '
        MunicipalExemptLabel.AutoSize = True
        MunicipalExemptLabel.Location = New System.Drawing.Point(30, 201)
        MunicipalExemptLabel.Name = "MunicipalExemptLabel"
        MunicipalExemptLabel.Size = New System.Drawing.Size(93, 13)
        MunicipalExemptLabel.TabIndex = 17
        MunicipalExemptLabel.Text = "Municipal Exempt:"
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicesBindingSource
        '
        Me.ServicesBindingSource.DataMember = "Services"
        Me.ServicesBindingSource.DataSource = Me.JupiterDataSet
        '
        'ServicesTableAdapter
        '
        Me.ServicesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ServicesTableAdapter = Me.ServicesTableAdapter
        Me.TableAdapterManager.StoresTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TiresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(123, 32)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(123, 77)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Category", True))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(123, 130)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox.TabIndex = 8
        '
        'PriceNumericUpDown
        '
        Me.PriceNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ServicesBindingSource, "Price", True))
        Me.PriceNumericUpDown.DecimalPlaces = 2
        Me.PriceNumericUpDown.Location = New System.Drawing.Point(129, 35)
        Me.PriceNumericUpDown.Name = "PriceNumericUpDown"
        Me.PriceNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me.PriceNumericUpDown.TabIndex = 10
        '
        'CostNumericUpDown
        '
        Me.CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ServicesBindingSource, "Cost", True))
        Me.CostNumericUpDown.DecimalPlaces = 2
        Me.CostNumericUpDown.Location = New System.Drawing.Point(129, 80)
        Me.CostNumericUpDown.Name = "CostNumericUpDown"
        Me.CostNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me.CostNumericUpDown.TabIndex = 12
        '
        'StateExemptComboBox
        '
        Me.StateExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "StateExempt", True))
        Me.StateExemptComboBox.FormattingEnabled = True
        Me.StateExemptComboBox.Items.AddRange(New Object() {"No", "Yes"})
        Me.StateExemptComboBox.Location = New System.Drawing.Point(129, 135)
        Me.StateExemptComboBox.Name = "StateExemptComboBox"
        Me.StateExemptComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StateExemptComboBox.TabIndex = 16
        '
        'MunicipalExemptComboBox
        '
        Me.MunicipalExemptComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "MunicipalExempt", True))
        Me.MunicipalExemptComboBox.FormattingEnabled = True
        Me.MunicipalExemptComboBox.Items.AddRange(New Object() {"No", "Yes"})
        Me.MunicipalExemptComboBox.Location = New System.Drawing.Point(129, 198)
        Me.MunicipalExemptComboBox.Name = "MunicipalExemptComboBox"
        Me.MunicipalExemptComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MunicipalExemptComboBox.TabIndex = 18
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Image = Global.ProjectMinerva.My.Resources.Resources.Save_as_icon
        Me.SaveButton.Location = New System.Drawing.Point(652, 394)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(188, 122)
        Me.SaveButton.TabIndex = 19
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(12, 424)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(188, 122)
        Me.BackButton.TabIndex = 20
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.DescriptionTextBox)
        Me.Panel1.Controls.Add(CategoryLabel)
        Me.Panel1.Controls.Add(DescriptionLabel)
        Me.Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Panel1.Location = New System.Drawing.Point(230, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 338)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PriceNumericUpDown)
        Me.Panel2.Controls.Add(PriceLabel)
        Me.Panel2.Controls.Add(Me.CostNumericUpDown)
        Me.Panel2.Controls.Add(CostLabel)
        Me.Panel2.Controls.Add(MunicipalExemptLabel)
        Me.Panel2.Controls.Add(StateExemptLabel)
        Me.Panel2.Controls.Add(Me.MunicipalExemptComboBox)
        Me.Panel2.Controls.Add(Me.StateExemptComboBox)
        Me.Panel2.Location = New System.Drawing.Point(846, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 328)
        Me.Panel2.TabIndex = 22
        '
        'CreateService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1401, 558)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Service"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents ServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServicesTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.ServicesTableAdapter
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PriceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CostNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents StateExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MunicipalExemptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
