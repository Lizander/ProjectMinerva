<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiresHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TiresHome))
        Me.FindTireButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreateTireButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FindTireButton
        '
        Me.FindTireButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindTireButton.FlatAppearance.BorderSize = 0
        Me.FindTireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindTireButton.Image = Global.ProjectMinerva.My.Resources.Resources.search_icon__1_
        Me.FindTireButton.Location = New System.Drawing.Point(84, 329)
        Me.FindTireButton.Name = "FindTireButton"
        Me.FindTireButton.Size = New System.Drawing.Size(197, 94)
        Me.FindTireButton.TabIndex = 3
        Me.FindTireButton.Text = "Find Tire"
        Me.FindTireButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.FindTireButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Image = Global.ProjectMinerva.My.Resources.Resources._1476067665_carwheel
        Me.Label1.Location = New System.Drawing.Point(81, 11)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 98)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tires"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CreateTireButton
        '
        Me.CreateTireButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateTireButton.BackColor = System.Drawing.Color.Transparent
        Me.CreateTireButton.FlatAppearance.BorderSize = 0
        Me.CreateTireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateTireButton.Image = Global.ProjectMinerva.My.Resources.Resources.New_file_icon
        Me.CreateTireButton.Location = New System.Drawing.Point(84, 167)
        Me.CreateTireButton.Name = "CreateTireButton"
        Me.CreateTireButton.Size = New System.Drawing.Size(197, 94)
        Me.CreateTireButton.TabIndex = 2
        Me.CreateTireButton.Text = "Create Tire"
        Me.CreateTireButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CreateTireButton.UseVisualStyleBackColor = False
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
        Me.BackButton.Location = New System.Drawing.Point(12, 496)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(144, 78)
        Me.BackButton.TabIndex = 14
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CreateTireButton)
        Me.Panel1.Controls.Add(Me.FindTireButton)
        Me.Panel1.Location = New System.Drawing.Point(574, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 542)
        Me.Panel1.TabIndex = 15
        '
        'TiresHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1438, 586)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TiresHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tires Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FindTireButton As System.Windows.Forms.Button
    Friend WithEvents CreateTireButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
