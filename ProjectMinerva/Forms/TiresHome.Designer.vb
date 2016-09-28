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
        Me.FindTireButton = New System.Windows.Forms.Button()
        Me.CreateTireButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FindTireButton
        '
        Me.FindTireButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindTireButton.Location = New System.Drawing.Point(610, 262)
        Me.FindTireButton.Name = "FindTireButton"
        Me.FindTireButton.Size = New System.Drawing.Size(203, 94)
        Me.FindTireButton.TabIndex = 3
        Me.FindTireButton.Text = "Find Tire"
        Me.FindTireButton.UseVisualStyleBackColor = True
        '
        'CreateTireButton
        '
        Me.CreateTireButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateTireButton.Location = New System.Drawing.Point(610, 115)
        Me.CreateTireButton.Name = "CreateTireButton"
        Me.CreateTireButton.Size = New System.Drawing.Size(203, 94)
        Me.CreateTireButton.TabIndex = 2
        Me.CreateTireButton.Text = "Create Tire"
        Me.CreateTireButton.UseVisualStyleBackColor = True
        '
        'TiresHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 586)
        Me.Controls.Add(Me.FindTireButton)
        Me.Controls.Add(Me.CreateTireButton)
        Me.Name = "TiresHome"
        Me.Text = "Tires Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FindTireButton As System.Windows.Forms.Button
    Friend WithEvents CreateTireButton As System.Windows.Forms.Button
End Class
