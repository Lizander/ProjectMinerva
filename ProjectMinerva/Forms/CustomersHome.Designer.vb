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
        Me.CreateCustomerButton = New System.Windows.Forms.Button()
        Me.FindCustomerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateCustomerButton
        '
        Me.CreateCustomerButton.Location = New System.Drawing.Point(469, 115)
        Me.CreateCustomerButton.Name = "CreateCustomerButton"
        Me.CreateCustomerButton.Size = New System.Drawing.Size(352, 135)
        Me.CreateCustomerButton.TabIndex = 0
        Me.CreateCustomerButton.Text = "Create Customer"
        Me.CreateCustomerButton.UseVisualStyleBackColor = True
        '
        'FindCustomerButton
        '
        Me.FindCustomerButton.Location = New System.Drawing.Point(469, 305)
        Me.FindCustomerButton.Name = "FindCustomerButton"
        Me.FindCustomerButton.Size = New System.Drawing.Size(352, 135)
        Me.FindCustomerButton.TabIndex = 1
        Me.FindCustomerButton.Text = "Find Customer"
        Me.FindCustomerButton.UseVisualStyleBackColor = True
        '
        'CustomersHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 574)
        Me.Controls.Add(Me.FindCustomerButton)
        Me.Controls.Add(Me.CreateCustomerButton)
        Me.Name = "CustomersHome"
        Me.Text = "CustomersHome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CreateCustomerButton As System.Windows.Forms.Button
    Friend WithEvents FindCustomerButton As System.Windows.Forms.Button
End Class
