<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdditionalSaleInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdditionalSaleInfo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaymentTypeBox = New System.Windows.Forms.ComboBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment Type:"
        '
        'PaymentTypeBox
        '
        Me.PaymentTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentTypeBox.FormattingEnabled = True
        Me.PaymentTypeBox.Items.AddRange(New Object() {"Cash", "Cheque", "Credit Card", "Other"})
        Me.PaymentTypeBox.Location = New System.Drawing.Point(122, 54)
        Me.PaymentTypeBox.Name = "PaymentTypeBox"
        Me.PaymentTypeBox.Size = New System.Drawing.Size(121, 21)
        Me.PaymentTypeBox.TabIndex = 1
        '
        'BackButton
        '
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ProjectMinerva.My.Resources.Resources.back_icon
        Me.BackButton.Location = New System.Drawing.Point(12, 134)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(78, 78)
        Me.BackButton.TabIndex = 2
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.ProjectMinerva.My.Resources.Resources.success_icon
        Me.Button1.Location = New System.Drawing.Point(165, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 78)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AdditionalSaleInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(289, 224)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PaymentTypeBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdditionalSaleInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Additional Sale Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PaymentTypeBox As System.Windows.Forms.ComboBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
