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
        Me.CreateServiceButton = New System.Windows.Forms.Button()
        Me.FindServiceButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateServiceButton
        '
        Me.CreateServiceButton.Location = New System.Drawing.Point(544, 67)
        Me.CreateServiceButton.Name = "CreateServiceButton"
        Me.CreateServiceButton.Size = New System.Drawing.Size(234, 124)
        Me.CreateServiceButton.TabIndex = 0
        Me.CreateServiceButton.Text = "Create Service"
        Me.CreateServiceButton.UseVisualStyleBackColor = True
        '
        'FindServiceButton
        '
        Me.FindServiceButton.Location = New System.Drawing.Point(544, 281)
        Me.FindServiceButton.Name = "FindServiceButton"
        Me.FindServiceButton.Size = New System.Drawing.Size(234, 124)
        Me.FindServiceButton.TabIndex = 1
        Me.FindServiceButton.Text = "Find Service"
        Me.FindServiceButton.UseVisualStyleBackColor = True
        '
        'ServicesHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 585)
        Me.Controls.Add(Me.FindServiceButton)
        Me.Controls.Add(Me.CreateServiceButton)
        Me.Name = "ServicesHome"
        Me.Text = "ServicesHome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CreateServiceButton As System.Windows.Forms.Button
    Friend WithEvents FindServiceButton As System.Windows.Forms.Button
End Class
