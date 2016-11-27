<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TireInventoryReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TireInventoryReport))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.TiresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiresTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter()
        Me.StoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoresTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.StoresTableAdapter()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Tires"
        ReportDataSource1.Value = Me.TiresBindingSource
        ReportDataSource2.Name = "Stores"
        ReportDataSource2.Value = Me.StoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjectMinerva.TireInventoryReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1010, 674)
        Me.ReportViewer1.TabIndex = 0
        '
        'JupiterDataSet
        '
        Me.JupiterDataSet.DataSetName = "JupiterDataSet"
        Me.JupiterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiresBindingSource
        '
        Me.TiresBindingSource.DataMember = "Tires"
        Me.TiresBindingSource.DataSource = Me.JupiterDataSet
        '
        'TiresTableAdapter
        '
        Me.TiresTableAdapter.ClearBeforeFill = True
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
        'TireInventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1010, 674)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TireInventoryReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tire Inventory Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TiresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents StoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiresTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.TiresTableAdapter
    Friend WithEvents StoresTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.StoresTableAdapter
End Class
