<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersHome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreateCustomerButton = New System.Windows.Forms.Button()
        Me.FindCustomerButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CreateCustomerButton)
        Me.Panel1.Controls.Add(Me.FindCustomerButton)
        Me.Panel1.Location = New System.Drawing.Point(482, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 528)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Image = Global.ProjectMinerva.My.Resources.Resources.Male_icon
        Me.Label1.Location = New System.Drawing.Point(97, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 107)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CreateCustomerButton
        '
        Me.CreateCustomerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateCustomerButton.BackColor = System.Drawing.Color.Transparent
        Me.CreateCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CreateCustomerButton.FlatAppearance.BorderSize = 0
        Me.CreateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateCustomerButton.Image = Global.ProjectMinerva.My.Resources.Resources.New_file_icon
        Me.CreateCustomerButton.Location = New System.Drawing.Point(97, 180)
        Me.CreateCustomerButton.Name = "CreateCustomerButton"
        Me.CreateCustomerButton.Size = New System.Drawing.Size(179, 141)
        Me.CreateCustomerButton.TabIndex = 0
        Me.CreateCustomerButton.Text = "Create Customer"
        Me.CreateCustomerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CreateCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CreateCustomerButton.UseVisualStyleBackColor = False
        '
        'FindCustomerButton
        '
        Me.FindCustomerButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindCustomerButton.FlatAppearance.BorderSize = 0
        Me.FindCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindCustomerButton.Image = Global.ProjectMinerva.My.Resources.Resources.search_icon__1_
        Me.FindCustomerButton.Location = New System.Drawing.Point(97, 373)
        Me.FindCustomerButton.Name = "FindCustomerButton"
        Me.FindCustomerButton.Size = New System.Drawing.Size(179, 141)
        Me.FindCustomerButton.TabIndex = 1
        Me.FindCustomerButton.Text = "Find Customer"
        Me.FindCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.FindCustomerButton.UseVisualStyleBackColor = True
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
        Me.BackButton.Location = New System.Drawing.Point(12, 465)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(144, 97)
        Me.BackButton.TabIndex = 10
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'CustomersHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1330, 574)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomersHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreateCustomerButton As System.Windows.Forms.Button
    Friend WithEvents FindCustomerButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
