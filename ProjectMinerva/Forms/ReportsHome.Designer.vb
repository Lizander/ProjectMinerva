<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClosingRadio = New System.Windows.Forms.RadioButton()
        Me.PeriodRadio = New System.Windows.Forms.RadioButton()
        Me.EmployeeSalesRadio = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TireInventoryRadio = New System.Windows.Forms.RadioButton()
        Me.ProductInventoryRadio = New System.Windows.Forms.RadioButton()
        Me.TireReorderRadio = New System.Windows.Forms.RadioButton()
        Me.ProductReorderRadio = New System.Windows.Forms.RadioButton()
        Me.CustomerSaleRadio = New System.Windows.Forms.RadioButton()
        Me.GenerateReportButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Reports:"
        '
        'ClosingRadio
        '
        Me.ClosingRadio.AutoSize = True
        Me.ClosingRadio.Location = New System.Drawing.Point(330, 124)
        Me.ClosingRadio.Name = "ClosingRadio"
        Me.ClosingRadio.Size = New System.Drawing.Size(94, 17)
        Me.ClosingRadio.TabIndex = 1
        Me.ClosingRadio.TabStop = True
        Me.ClosingRadio.Text = "Closing Report"
        Me.ClosingRadio.UseVisualStyleBackColor = True
        '
        'PeriodRadio
        '
        Me.PeriodRadio.AutoSize = True
        Me.PeriodRadio.Location = New System.Drawing.Point(330, 147)
        Me.PeriodRadio.Name = "PeriodRadio"
        Me.PeriodRadio.Size = New System.Drawing.Size(90, 17)
        Me.PeriodRadio.TabIndex = 2
        Me.PeriodRadio.TabStop = True
        Me.PeriodRadio.Text = "Period Report"
        Me.PeriodRadio.UseVisualStyleBackColor = True
        '
        'EmployeeSalesRadio
        '
        Me.EmployeeSalesRadio.AutoSize = True
        Me.EmployeeSalesRadio.Location = New System.Drawing.Point(330, 170)
        Me.EmployeeSalesRadio.Name = "EmployeeSalesRadio"
        Me.EmployeeSalesRadio.Size = New System.Drawing.Size(100, 17)
        Me.EmployeeSalesRadio.TabIndex = 7
        Me.EmployeeSalesRadio.TabStop = True
        Me.EmployeeSalesRadio.Text = "Employee Sales"
        Me.EmployeeSalesRadio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(628, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Inventory Reports:"
        '
        'TireInventoryRadio
        '
        Me.TireInventoryRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TireInventoryRadio.AutoSize = True
        Me.TireInventoryRadio.Location = New System.Drawing.Point(631, 129)
        Me.TireInventoryRadio.Name = "TireInventoryRadio"
        Me.TireInventoryRadio.Size = New System.Drawing.Size(90, 17)
        Me.TireInventoryRadio.TabIndex = 9
        Me.TireInventoryRadio.TabStop = True
        Me.TireInventoryRadio.Text = "Tire Inventory"
        Me.TireInventoryRadio.UseVisualStyleBackColor = True
        '
        'ProductInventoryRadio
        '
        Me.ProductInventoryRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProductInventoryRadio.AutoSize = True
        Me.ProductInventoryRadio.Location = New System.Drawing.Point(631, 153)
        Me.ProductInventoryRadio.Name = "ProductInventoryRadio"
        Me.ProductInventoryRadio.Size = New System.Drawing.Size(109, 17)
        Me.ProductInventoryRadio.TabIndex = 10
        Me.ProductInventoryRadio.TabStop = True
        Me.ProductInventoryRadio.Text = "Product Inventory"
        Me.ProductInventoryRadio.UseVisualStyleBackColor = True
        '
        'TireReorderRadio
        '
        Me.TireReorderRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TireReorderRadio.AutoSize = True
        Me.TireReorderRadio.Location = New System.Drawing.Point(631, 177)
        Me.TireReorderRadio.Name = "TireReorderRadio"
        Me.TireReorderRadio.Size = New System.Drawing.Size(103, 17)
        Me.TireReorderRadio.TabIndex = 11
        Me.TireReorderRadio.TabStop = True
        Me.TireReorderRadio.Text = "Tire Reorder List"
        Me.TireReorderRadio.UseVisualStyleBackColor = True
        '
        'ProductReorderRadio
        '
        Me.ProductReorderRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProductReorderRadio.AutoSize = True
        Me.ProductReorderRadio.Location = New System.Drawing.Point(631, 201)
        Me.ProductReorderRadio.Name = "ProductReorderRadio"
        Me.ProductReorderRadio.Size = New System.Drawing.Size(122, 17)
        Me.ProductReorderRadio.TabIndex = 12
        Me.ProductReorderRadio.TabStop = True
        Me.ProductReorderRadio.Text = "Product Reorder List"
        Me.ProductReorderRadio.UseVisualStyleBackColor = True
        '
        'CustomerSaleRadio
        '
        Me.CustomerSaleRadio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerSaleRadio.AutoSize = True
        Me.CustomerSaleRadio.Location = New System.Drawing.Point(330, 193)
        Me.CustomerSaleRadio.Name = "CustomerSaleRadio"
        Me.CustomerSaleRadio.Size = New System.Drawing.Size(98, 17)
        Me.CustomerSaleRadio.TabIndex = 13
        Me.CustomerSaleRadio.TabStop = True
        Me.CustomerSaleRadio.Text = "Customer Sales"
        Me.CustomerSaleRadio.UseVisualStyleBackColor = True
        '
        'GenerateReportButton
        '
        Me.GenerateReportButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenerateReportButton.AutoSize = True
        Me.GenerateReportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GenerateReportButton.BackColor = System.Drawing.Color.Transparent
        Me.GenerateReportButton.FlatAppearance.BorderSize = 0
        Me.GenerateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateReportButton.Image = Global.ProjectMinerva.My.Resources.Resources.Autoship_icon
        Me.GenerateReportButton.Location = New System.Drawing.Point(487, 431)
        Me.GenerateReportButton.Name = "GenerateReportButton"
        Me.GenerateReportButton.Size = New System.Drawing.Size(96, 95)
        Me.GenerateReportButton.TabIndex = 15
        Me.GenerateReportButton.Text = "Generate Report"
        Me.GenerateReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.GenerateReportButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(12, 446)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(80, 80)
        Me.BackButton.TabIndex = 14
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ReportsHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1021, 538)
        Me.Controls.Add(Me.GenerateReportButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CustomerSaleRadio)
        Me.Controls.Add(Me.ProductReorderRadio)
        Me.Controls.Add(Me.TireReorderRadio)
        Me.Controls.Add(Me.ProductInventoryRadio)
        Me.Controls.Add(Me.TireInventoryRadio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmployeeSalesRadio)
        Me.Controls.Add(Me.PeriodRadio)
        Me.Controls.Add(Me.ClosingRadio)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportsHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClosingRadio As System.Windows.Forms.RadioButton
    Friend WithEvents PeriodRadio As System.Windows.Forms.RadioButton
    Friend WithEvents EmployeeSalesRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TireInventoryRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ProductInventoryRadio As System.Windows.Forms.RadioButton
    Friend WithEvents TireReorderRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ProductReorderRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CustomerSaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents GenerateReportButton As System.Windows.Forms.Button
End Class
