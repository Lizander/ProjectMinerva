<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsHome
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
        Me.CreateProductButton = New System.Windows.Forms.Button()
        Me.FindProductButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateProductButton
        '
        Me.CreateProductButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateProductButton.Location = New System.Drawing.Point(441, 86)
        Me.CreateProductButton.Name = "CreateProductButton"
        Me.CreateProductButton.Size = New System.Drawing.Size(244, 127)
        Me.CreateProductButton.TabIndex = 0
        Me.CreateProductButton.Text = "Create Product"
        Me.CreateProductButton.UseVisualStyleBackColor = True
        '
        'FindProductButton
        '
        Me.FindProductButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindProductButton.Location = New System.Drawing.Point(441, 318)
        Me.FindProductButton.Name = "FindProductButton"
        Me.FindProductButton.Size = New System.Drawing.Size(244, 127)
        Me.FindProductButton.TabIndex = 1
        Me.FindProductButton.Text = "Find Product"
        Me.FindProductButton.UseVisualStyleBackColor = True
        '
        'ProductsHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 560)
        Me.Controls.Add(Me.FindProductButton)
        Me.Controls.Add(Me.CreateProductButton)
        Me.Name = "ProductsHome"
        Me.Text = "ProductsHome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CreateProductButton As System.Windows.Forms.Button
    Friend WithEvents FindProductButton As System.Windows.Forms.Button
End Class
