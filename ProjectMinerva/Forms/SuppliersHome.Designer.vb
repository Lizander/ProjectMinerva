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
        Me.CreateSupplierButton = New System.Windows.Forms.Button()
        Me.FindSupplierButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateSupplierButton
        '
        Me.CreateSupplierButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateSupplierButton.Location = New System.Drawing.Point(639, 86)
        Me.CreateSupplierButton.Name = "CreateSupplierButton"
        Me.CreateSupplierButton.Size = New System.Drawing.Size(203, 94)
        Me.CreateSupplierButton.TabIndex = 0
        Me.CreateSupplierButton.Text = "Create Supplier"
        Me.CreateSupplierButton.UseVisualStyleBackColor = True
        '
        'FindSupplierButton
        '
        Me.FindSupplierButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindSupplierButton.Location = New System.Drawing.Point(639, 233)
        Me.FindSupplierButton.Name = "FindSupplierButton"
        Me.FindSupplierButton.Size = New System.Drawing.Size(203, 94)
        Me.FindSupplierButton.TabIndex = 1
        Me.FindSupplierButton.Text = "Find Supplier"
        Me.FindSupplierButton.UseVisualStyleBackColor = True
        '
        'SuppliersHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 529)
        Me.Controls.Add(Me.FindSupplierButton)
        Me.Controls.Add(Me.CreateSupplierButton)
        Me.Name = "SuppliersHome"
        Me.Text = "Suppliers Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CreateSupplierButton As System.Windows.Forms.Button
    Friend WithEvents FindSupplierButton As System.Windows.Forms.Button
End Class
