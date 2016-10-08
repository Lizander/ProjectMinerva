<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppliersHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuppliersHome))
        Me.CreateSupplierButton = New System.Windows.Forms.Button()
        Me.FindSupplierButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CreateSupplierButton
        '
        Me.CreateSupplierButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateSupplierButton.BackColor = System.Drawing.Color.Transparent
        Me.CreateSupplierButton.FlatAppearance.BorderSize = 0
        Me.CreateSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateSupplierButton.Image = CType(resources.GetObject("CreateSupplierButton.Image"), System.Drawing.Image)
        Me.CreateSupplierButton.Location = New System.Drawing.Point(634, 173)
        Me.CreateSupplierButton.Name = "CreateSupplierButton"
        Me.CreateSupplierButton.Size = New System.Drawing.Size(203, 94)
        Me.CreateSupplierButton.TabIndex = 0
        Me.CreateSupplierButton.Text = "Create Supplier"
        Me.CreateSupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CreateSupplierButton.UseVisualStyleBackColor = False
        '
        'FindSupplierButton
        '
        Me.FindSupplierButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindSupplierButton.BackColor = System.Drawing.Color.Transparent
        Me.FindSupplierButton.FlatAppearance.BorderSize = 0
        Me.FindSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindSupplierButton.Image = CType(resources.GetObject("FindSupplierButton.Image"), System.Drawing.Image)
        Me.FindSupplierButton.Location = New System.Drawing.Point(634, 307)
        Me.FindSupplierButton.Name = "FindSupplierButton"
        Me.FindSupplierButton.Size = New System.Drawing.Size(203, 113)
        Me.FindSupplierButton.TabIndex = 1
        Me.FindSupplierButton.Text = "Find Supplier"
        Me.FindSupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.FindSupplierButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackButton.AutoSize = True
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(12, 439)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(144, 78)
        Me.BackButton.TabIndex = 10
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(689, 9)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 87)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Supliers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SuppliersHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1461, 529)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.FindSupplierButton)
        Me.Controls.Add(Me.CreateSupplierButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SuppliersHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suppliers Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreateSupplierButton As System.Windows.Forms.Button
    Friend WithEvents FindSupplierButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
