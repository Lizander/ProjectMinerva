<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeriodReport
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeriodReport))
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.LineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineItemsTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.LineItemsTableAdapter()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter()
        Me.StoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoresTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.StoresTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Location = New System.Drawing.Point(148, 28)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.StartDatePicker.TabIndex = 23
        '
        'EndDatePicker
        '
        Me.EndDatePicker.Location = New System.Drawing.Point(404, 28)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.EndDatePicker.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "To:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "LineItems"
        ReportDataSource1.Value = Me.LineItemsBindingSource
        ReportDataSource2.Name = "Sales"
        ReportDataSource2.Value = Me.SalesBindingSource
        ReportDataSource3.Name = "Stores"
        ReportDataSource3.Value = Me.StoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjectMinerva.PeriodReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 108)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(741, 258)
        Me.ReportViewer1.TabIndex = 29
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(12, 500)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(80, 80)
        Me.BackButton.TabIndex = 28
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectMinerva.My.Resources.Resources.search_icon_small
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineItemsBindingSource
        '
        Me.LineItemsBindingSource.DataMember = "LineItems"
        Me.LineItemsBindingSource.DataSource = Me.JupiterDataSet
        '
        'LineItemsTableAdapter
        '
        Me.LineItemsTableAdapter.ClearBeforeFill = True
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.JupiterDataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'StoresBindingSource
        '
        Me.StoresBindingSource.DataMember = "Stores"
        Me.StoresBindingSource.DataSource = Me.JupiterDataSet
        '
        'StoresTableAdapter
        '
        Me.StoresTableAdapter.ClearBeforeFill = True
        '
        'PeriodReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(786, 592)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EndDatePicker)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PeriodReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Period Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents LineItemsTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.LineItemsTableAdapter
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents StoresTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.StoresTableAdapter
End Class
