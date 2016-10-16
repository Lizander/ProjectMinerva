<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicesHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServicesHome))
        Me.CreateServiceButton = New System.Windows.Forms.Button()
        Me.FindServiceButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CreateServiceButton
        '
        Me.CreateServiceButton.BackColor = System.Drawing.Color.Transparent
        Me.CreateServiceButton.FlatAppearance.BorderSize = 0
        Me.CreateServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateServiceButton.Image = Global.ProjectMinerva.My.Resources.Resources.New_file_icon
        Me.CreateServiceButton.Location = New System.Drawing.Point(88, 171)
        Me.CreateServiceButton.Name = "CreateServiceButton"
        Me.CreateServiceButton.Size = New System.Drawing.Size(234, 124)
        Me.CreateServiceButton.TabIndex = 0
        Me.CreateServiceButton.Text = "Create Service"
        Me.CreateServiceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CreateServiceButton.UseVisualStyleBackColor = False
        '
        'FindServiceButton
        '
        Me.FindServiceButton.BackColor = System.Drawing.Color.Transparent
        Me.FindServiceButton.FlatAppearance.BorderSize = 0
        Me.FindServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindServiceButton.Image = Global.ProjectMinerva.My.Resources.Resources.search_icon__1_
        Me.FindServiceButton.Location = New System.Drawing.Point(88, 345)
        Me.FindServiceButton.Name = "FindServiceButton"
        Me.FindServiceButton.Size = New System.Drawing.Size(234, 124)
        Me.FindServiceButton.TabIndex = 1
        Me.FindServiceButton.Text = "Find Service"
        Me.FindServiceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.FindServiceButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CreateServiceButton)
        Me.Panel1.Controls.Add(Me.FindServiceButton)
        Me.Panel1.Location = New System.Drawing.Point(528, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 541)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Image = Global.ProjectMinerva.My.Resources.Resources.configure_icon
        Me.Label1.Location = New System.Drawing.Point(105, 22)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 98)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Services"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ServicesHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1349, 585)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ServicesHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ServicesHome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CreateServiceButton As System.Windows.Forms.Button
    Friend WithEvents FindServiceButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
