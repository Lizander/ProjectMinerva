<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindSupplier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SuppliersDataView = New System.Windows.Forms.DataGridView()
        Me.BusinessNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactFirstLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactSecondLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressLineOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressLineTwoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.SuppliersTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.ModifyButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.SuppliersDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuppliersDataView
        '
        Me.SuppliersDataView.AllowUserToAddRows = False
        Me.SuppliersDataView.AllowUserToDeleteRows = False
        Me.SuppliersDataView.AllowUserToResizeColumns = False
        Me.SuppliersDataView.AllowUserToResizeRows = False
        Me.SuppliersDataView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuppliersDataView.AutoGenerateColumns = False
        Me.SuppliersDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SuppliersDataView.BackgroundColor = System.Drawing.Color.Azure
        Me.SuppliersDataView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SuppliersDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SuppliersDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SuppliersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppliersDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BusinessNameDataGridViewTextBoxColumn, Me.ContactNameDataGridViewTextBoxColumn, Me.ContactFirstLastNameDataGridViewTextBoxColumn, Me.ContactSecondLastNameDataGridViewTextBoxColumn, Me.BusinessPhoneDataGridViewTextBoxColumn, Me.ContactPhoneDataGridViewTextBoxColumn, Me.BusinessEmailDataGridViewTextBoxColumn, Me.AddressLineOneDataGridViewTextBoxColumn, Me.AddressLineTwoDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.ZipcodeDataGridViewTextBoxColumn})
        Me.SuppliersDataView.DataSource = Me.SuppliersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SuppliersDataView.DefaultCellStyle = DataGridViewCellStyle2
        Me.SuppliersDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SuppliersDataView.GridColor = System.Drawing.Color.LightSeaGreen
        Me.SuppliersDataView.Location = New System.Drawing.Point(12, 125)
        Me.SuppliersDataView.MultiSelect = False
        Me.SuppliersDataView.Name = "SuppliersDataView"
        Me.SuppliersDataView.ReadOnly = True
        Me.SuppliersDataView.RowHeadersVisible = False
        Me.SuppliersDataView.Size = New System.Drawing.Size(1425, 333)
        Me.SuppliersDataView.TabIndex = 0
        '
        'BusinessNameDataGridViewTextBoxColumn
        '
        Me.BusinessNameDataGridViewTextBoxColumn.DataPropertyName = "BusinessName"
        Me.BusinessNameDataGridViewTextBoxColumn.HeaderText = "Business Name"
        Me.BusinessNameDataGridViewTextBoxColumn.Name = "BusinessNameDataGridViewTextBoxColumn"
        Me.BusinessNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactNameDataGridViewTextBoxColumn
        '
        Me.ContactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.HeaderText = "Contact Name"
        Me.ContactNameDataGridViewTextBoxColumn.Name = "ContactNameDataGridViewTextBoxColumn"
        Me.ContactNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactFirstLastNameDataGridViewTextBoxColumn
        '
        Me.ContactFirstLastNameDataGridViewTextBoxColumn.DataPropertyName = "ContactFirstLastName"
        Me.ContactFirstLastNameDataGridViewTextBoxColumn.HeaderText = "Contact First Last Name"
        Me.ContactFirstLastNameDataGridViewTextBoxColumn.Name = "ContactFirstLastNameDataGridViewTextBoxColumn"
        Me.ContactFirstLastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactSecondLastNameDataGridViewTextBoxColumn
        '
        Me.ContactSecondLastNameDataGridViewTextBoxColumn.DataPropertyName = "ContactSecondLastName"
        Me.ContactSecondLastNameDataGridViewTextBoxColumn.HeaderText = "Contact Second Last Name"
        Me.ContactSecondLastNameDataGridViewTextBoxColumn.Name = "ContactSecondLastNameDataGridViewTextBoxColumn"
        Me.ContactSecondLastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BusinessPhoneDataGridViewTextBoxColumn
        '
        Me.BusinessPhoneDataGridViewTextBoxColumn.DataPropertyName = "BusinessPhone"
        Me.BusinessPhoneDataGridViewTextBoxColumn.HeaderText = "Business Phone"
        Me.BusinessPhoneDataGridViewTextBoxColumn.Name = "BusinessPhoneDataGridViewTextBoxColumn"
        Me.BusinessPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactPhoneDataGridViewTextBoxColumn
        '
        Me.ContactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone"
        Me.ContactPhoneDataGridViewTextBoxColumn.HeaderText = "Contact Phone"
        Me.ContactPhoneDataGridViewTextBoxColumn.Name = "ContactPhoneDataGridViewTextBoxColumn"
        Me.ContactPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BusinessEmailDataGridViewTextBoxColumn
        '
        Me.BusinessEmailDataGridViewTextBoxColumn.DataPropertyName = "BusinessEmail"
        Me.BusinessEmailDataGridViewTextBoxColumn.HeaderText = "Business Email"
        Me.BusinessEmailDataGridViewTextBoxColumn.Name = "BusinessEmailDataGridViewTextBoxColumn"
        Me.BusinessEmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressLineOneDataGridViewTextBoxColumn
        '
        Me.AddressLineOneDataGridViewTextBoxColumn.DataPropertyName = "AddressLineOne"
        Me.AddressLineOneDataGridViewTextBoxColumn.HeaderText = "Address Line One"
        Me.AddressLineOneDataGridViewTextBoxColumn.Name = "AddressLineOneDataGridViewTextBoxColumn"
        Me.AddressLineOneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressLineTwoDataGridViewTextBoxColumn
        '
        Me.AddressLineTwoDataGridViewTextBoxColumn.DataPropertyName = "AddressLineTwo"
        Me.AddressLineTwoDataGridViewTextBoxColumn.HeaderText = "Address Line Two"
        Me.AddressLineTwoDataGridViewTextBoxColumn.Name = "AddressLineTwoDataGridViewTextBoxColumn"
        Me.AddressLineTwoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZipcodeDataGridViewTextBoxColumn
        '
        Me.ZipcodeDataGridViewTextBoxColumn.DataPropertyName = "Zipcode"
        Me.ZipcodeDataGridViewTextBoxColumn.HeaderText = "Zipcode"
        Me.ZipcodeDataGridViewTextBoxColumn.Name = "ZipcodeDataGridViewTextBoxColumn"
        Me.ZipcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.JupiterDataSet
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
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.Location = New System.Drawing.Point(89, 51)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(179, 20)
        Me.SearchTextBox.TabIndex = 1
        '
        'ModifyButton
        '
        Me.ModifyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ModifyButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ModifyButton.Location = New System.Drawing.Point(626, 508)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(203, 91)
        Me.ModifyButton.TabIndex = 3
        Me.ModifyButton.Text = "Modify"
        Me.ModifyButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.DeleteButton.Location = New System.Drawing.Point(1234, 508)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(203, 91)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectMinerva.My.Resources.Resources.search_icon_small
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearButton.Enabled = False
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Image = Global.ProjectMinerva.My.Resources.Resources.cancel_icon_small
        Me.ClearButton.Location = New System.Drawing.Point(294, 37)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 75)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(12, 508)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(102, 91)
        Me.BackButton.TabIndex = 5
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'FindSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1449, 611)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ModifyButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SuppliersDataView)
        Me.Name = "FindSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Supplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SuppliersDataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SuppliersDataView As System.Windows.Forms.DataGridView
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents BusinessNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactFirstLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactSecondLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BusinessPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BusinessEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressLineOneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressLineTwoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModifyButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As ProjectMinerva.JupiterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
