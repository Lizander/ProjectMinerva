<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrationPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrationPanel))
        Me.UserButton = New System.Windows.Forms.Button()
        Me.OptionButton = New System.Windows.Forms.Button()
        Me.SaleButton = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CustomerButton = New System.Windows.Forms.Button()
        Me.ProductButton = New System.Windows.Forms.Button()
        Me.ServiceButton = New System.Windows.Forms.Button()
        Me.TireButton = New System.Windows.Forms.Button()
        Me.SupplierButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserButton
        '
        Me.UserButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserButton.AutoSize = True
        Me.UserButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.UserButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.UserButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UserButton.Location = New System.Drawing.Point(1018, 161)
        Me.UserButton.Name = "UserButton"
        Me.UserButton.Size = New System.Drawing.Size(144, 72)
        Me.UserButton.TabIndex = 6
        Me.UserButton.Text = "Users"
        Me.UserButton.UseVisualStyleBackColor = False
        '
        'OptionButton
        '
        Me.OptionButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptionButton.AutoSize = True
        Me.OptionButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.OptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.OptionButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptionButton.Location = New System.Drawing.Point(1018, 55)
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(144, 72)
        Me.OptionButton.TabIndex = 5
        Me.OptionButton.Text = "Options"
        Me.OptionButton.UseVisualStyleBackColor = False
        '
        'SaleButton
        '
        Me.SaleButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaleButton.AutoSize = True
        Me.SaleButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.SaleButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.SaleButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SaleButton.Location = New System.Drawing.Point(1018, 399)
        Me.SaleButton.Name = "SaleButton"
        Me.SaleButton.Size = New System.Drawing.Size(144, 72)
        Me.SaleButton.TabIndex = 8
        Me.SaleButton.Text = "Search Sales"
        Me.SaleButton.UseVisualStyleBackColor = False
        '
        'ReportButton
        '
        Me.ReportButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportButton.AutoSize = True
        Me.ReportButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.ReportButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReportButton.Location = New System.Drawing.Point(1018, 293)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(144, 72)
        Me.ReportButton.TabIndex = 7
        Me.ReportButton.Text = "Reports"
        Me.ReportButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.AutoSize = True
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(12, 551)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(144, 97)
        Me.BackButton.TabIndex = 9
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'CustomerButton
        '
        Me.CustomerButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerButton.BackColor = System.Drawing.Color.Transparent
        Me.CustomerButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.CustomerButton.FlatAppearance.BorderSize = 0
        Me.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CustomerButton.Image = CType(resources.GetObject("CustomerButton.Image"), System.Drawing.Image)
        Me.CustomerButton.Location = New System.Drawing.Point(164, 467)
        Me.CustomerButton.Name = "CustomerButton"
        Me.CustomerButton.Size = New System.Drawing.Size(144, 95)
        Me.CustomerButton.TabIndex = 4
        Me.CustomerButton.Text = "Customers"
        Me.CustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CustomerButton.UseVisualStyleBackColor = False
        '
        'ProductButton
        '
        Me.ProductButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductButton.BackColor = System.Drawing.Color.Transparent
        Me.ProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.ProductButton.FlatAppearance.BorderSize = 0
        Me.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProductButton.Image = Global.ProjectMinerva.My.Resources.Resources.product_icon
        Me.ProductButton.Location = New System.Drawing.Point(164, 355)
        Me.ProductButton.Name = "ProductButton"
        Me.ProductButton.Size = New System.Drawing.Size(144, 94)
        Me.ProductButton.TabIndex = 3
        Me.ProductButton.Text = "Products"
        Me.ProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ProductButton.UseVisualStyleBackColor = False
        '
        'ServiceButton
        '
        Me.ServiceButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceButton.BackColor = System.Drawing.Color.Transparent
        Me.ServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.ServiceButton.FlatAppearance.BorderSize = 0
        Me.ServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ServiceButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ServiceButton.Image = Global.ProjectMinerva.My.Resources.Resources.configure_icon
        Me.ServiceButton.Location = New System.Drawing.Point(164, 248)
        Me.ServiceButton.Name = "ServiceButton"
        Me.ServiceButton.Size = New System.Drawing.Size(144, 90)
        Me.ServiceButton.TabIndex = 2
        Me.ServiceButton.Text = "Services"
        Me.ServiceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ServiceButton.UseVisualStyleBackColor = False
        '
        'TireButton
        '
        Me.TireButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TireButton.BackColor = System.Drawing.Color.Transparent
        Me.TireButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.TireButton.FlatAppearance.BorderSize = 0
        Me.TireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TireButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TireButton.Image = Global.ProjectMinerva.My.Resources.Resources._1476067665_carwheel
        Me.TireButton.Location = New System.Drawing.Point(164, 119)
        Me.TireButton.Name = "TireButton"
        Me.TireButton.Size = New System.Drawing.Size(144, 101)
        Me.TireButton.TabIndex = 1
        Me.TireButton.Text = "Tires"
        Me.TireButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TireButton.UseVisualStyleBackColor = False
        '
        'SupplierButton
        '
        Me.SupplierButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierButton.BackColor = System.Drawing.Color.Transparent
        Me.SupplierButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.SupplierButton.FlatAppearance.BorderSize = 0
        Me.SupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SupplierButton.Image = CType(resources.GetObject("SupplierButton.Image"), System.Drawing.Image)
        Me.SupplierButton.Location = New System.Drawing.Point(164, 12)
        Me.SupplierButton.Name = "SupplierButton"
        Me.SupplierButton.Size = New System.Drawing.Size(144, 87)
        Me.SupplierButton.TabIndex = 0
        Me.SupplierButton.Text = "Suppliers"
        Me.SupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SupplierButton.UseVisualStyleBackColor = False
        '
        'AdministrationPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1474, 660)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaleButton)
        Me.Controls.Add(Me.ReportButton)
        Me.Controls.Add(Me.UserButton)
        Me.Controls.Add(Me.OptionButton)
        Me.Controls.Add(Me.CustomerButton)
        Me.Controls.Add(Me.ProductButton)
        Me.Controls.Add(Me.ServiceButton)
        Me.Controls.Add(Me.TireButton)
        Me.Controls.Add(Me.SupplierButton)
        Me.Name = "AdministrationPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdministrationPanel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SupplierButton As System.Windows.Forms.Button
    Friend WithEvents TireButton As System.Windows.Forms.Button
    Friend WithEvents ServiceButton As System.Windows.Forms.Button
    Friend WithEvents ProductButton As System.Windows.Forms.Button
    Friend WithEvents CustomerButton As System.Windows.Forms.Button
    Friend WithEvents UserButton As System.Windows.Forms.Button
    Friend WithEvents OptionButton As System.Windows.Forms.Button
    Friend WithEvents SaleButton As System.Windows.Forms.Button
    Friend WithEvents ReportButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
