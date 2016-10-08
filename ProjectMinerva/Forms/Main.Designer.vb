<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SalesHomeButton = New System.Windows.Forms.Button()
        Me.TireSearchButton = New System.Windows.Forms.Button()
        Me.AdministrationButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SalesHomeButton
        '
        Me.SalesHomeButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SalesHomeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SalesHomeButton.BackColor = System.Drawing.Color.SkyBlue
        Me.SalesHomeButton.FlatAppearance.BorderSize = 0
        Me.SalesHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesHomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesHomeButton.Location = New System.Drawing.Point(179, 215)
        Me.SalesHomeButton.Name = "SalesHomeButton"
        Me.SalesHomeButton.Size = New System.Drawing.Size(205, 149)
        Me.SalesHomeButton.TabIndex = 0
        Me.SalesHomeButton.Text = "Sale Home Screen"
        Me.SalesHomeButton.UseVisualStyleBackColor = False
        '
        'TireSearchButton
        '
        Me.TireSearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TireSearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TireSearchButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TireSearchButton.FlatAppearance.BorderSize = 0
        Me.TireSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TireSearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TireSearchButton.Location = New System.Drawing.Point(618, 215)
        Me.TireSearchButton.Name = "TireSearchButton"
        Me.TireSearchButton.Size = New System.Drawing.Size(205, 149)
        Me.TireSearchButton.TabIndex = 1
        Me.TireSearchButton.Text = "Tire Search"
        Me.TireSearchButton.UseVisualStyleBackColor = False
        '
        'AdministrationButton
        '
        Me.AdministrationButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdministrationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AdministrationButton.BackColor = System.Drawing.Color.Transparent
        Me.AdministrationButton.FlatAppearance.BorderSize = 0
        Me.AdministrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdministrationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrationButton.Image = CType(resources.GetObject("AdministrationButton.Image"), System.Drawing.Image)
        Me.AdministrationButton.Location = New System.Drawing.Point(1060, 215)
        Me.AdministrationButton.Name = "AdministrationButton"
        Me.AdministrationButton.Size = New System.Drawing.Size(205, 149)
        Me.AdministrationButton.TabIndex = 2
        Me.AdministrationButton.Text = "Adminitration Panel"
        Me.AdministrationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AdministrationButton.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1481, 672)
        Me.Controls.Add(Me.AdministrationButton)
        Me.Controls.Add(Me.TireSearchButton)
        Me.Controls.Add(Me.SalesHomeButton)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Minerva"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SalesHomeButton As System.Windows.Forms.Button
    Friend WithEvents TireSearchButton As System.Windows.Forms.Button
    Friend WithEvents AdministrationButton As System.Windows.Forms.Button

End Class
