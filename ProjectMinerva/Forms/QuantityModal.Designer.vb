<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuantityModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuantityModal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuantityAvailableBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuantityToAddNumeric = New System.Windows.Forms.NumericUpDown()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.QuantityToAddNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quanity Available:"
        '
        'QuantityAvailableBox
        '
        Me.QuantityAvailableBox.Enabled = False
        Me.QuantityAvailableBox.Location = New System.Drawing.Point(167, 39)
        Me.QuantityAvailableBox.Name = "QuantityAvailableBox"
        Me.QuantityAvailableBox.Size = New System.Drawing.Size(120, 20)
        Me.QuantityAvailableBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity To Add To Sale:"
        '
        'QuantityToAddNumeric
        '
        Me.QuantityToAddNumeric.Location = New System.Drawing.Point(167, 78)
        Me.QuantityToAddNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantityToAddNumeric.Name = "QuantityToAddNumeric"
        Me.QuantityToAddNumeric.Size = New System.Drawing.Size(120, 20)
        Me.QuantityToAddNumeric.TabIndex = 3
        Me.QuantityToAddNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SaveButton
        '
        Me.SaveButton.AutoSize = True
        Me.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Image = Global.ProjectMinerva.My.Resources.Resources.success_icon
        Me.SaveButton.Location = New System.Drawing.Point(209, 132)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(78, 78)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(12, 132)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(78, 78)
        Me.BackButton.TabIndex = 9
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuantityModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(372, 256)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.QuantityToAddNumeric)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuantityAvailableBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuantityModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quantity"
        Me.TopMost = True
        CType(Me.QuantityToAddNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuantityAvailableBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QuantityToAddNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
