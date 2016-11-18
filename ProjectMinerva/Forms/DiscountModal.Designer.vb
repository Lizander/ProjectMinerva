<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiscountModal))
        Me.DiscountNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        CType(Me.DiscountNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiscountNumeric
        '
        Me.DiscountNumeric.Location = New System.Drawing.Point(197, 43)
        Me.DiscountNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.DiscountNumeric.Name = "DiscountNumeric"
        Me.DiscountNumeric.Size = New System.Drawing.Size(120, 20)
        Me.DiscountNumeric.TabIndex = 13
        Me.DiscountNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Discount:"
        '
        'BackButton
        '
        Me.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(45, 141)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(78, 78)
        Me.BackButton.TabIndex = 15
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.AutoSize = True
        Me.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Image = Global.ProjectMinerva.My.Resources.Resources.success_icon
        Me.SaveButton.Location = New System.Drawing.Point(239, 141)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(78, 78)
        Me.SaveButton.TabIndex = 14
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Type:"
        '
        'TypeBox
        '
        Me.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"Dollars", "Percentage"})
        Me.TypeBox.Location = New System.Drawing.Point(197, 80)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(121, 21)
        Me.TypeBox.TabIndex = 17
        '
        'DiscountModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(380, 231)
        Me.Controls.Add(Me.TypeBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DiscountNumeric)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiscountModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Discount"
        CType(Me.DiscountNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents DiscountNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TypeBox As System.Windows.Forms.ComboBox
End Class
