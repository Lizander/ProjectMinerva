<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClosingReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClosingReport))
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JupiterDataSet = New ProjectMinerva.JupiterDataSet()
        Me.LineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalesTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter()
        Me.LineItemsTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.LineItemsTableAdapter()
        Me.SalesFullInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesFullInfoTableAdapter = New ProjectMinerva.JupiterDataSetTableAdapters.SalesFullInfoTableAdapter()
        Me.ReportsDataSet = New ProjectMinerva.ReportsDataSet()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesFullInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.JupiterDataSet
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "SaleItemsInfo"
        ReportDataSource1.Value = Me.SalesFullInfoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjectMinerva.ClosingReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(186, 119)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'LineItemsTableAdapter
        '
        Me.LineItemsTableAdapter.ClearBeforeFill = True
        '
        'SalesFullInfoBindingSource
        '
        Me.SalesFullInfoBindingSource.DataMember = "SalesFullInfo"
        Me.SalesFullInfoBindingSource.DataSource = Me.JupiterDataSet
        '
        'SalesFullInfoTableAdapter
        '
        Me.SalesFullInfoTableAdapter.ClearBeforeFill = True
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClosingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(949, 623)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClosingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Closing Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JupiterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesFullInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JupiterDataSet As ProjectMinerva.JupiterDataSet
    Friend WithEvents LineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents LineItemsTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.LineItemsTableAdapter
    Friend WithEvents SalesFullInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesFullInfoTableAdapter As ProjectMinerva.JupiterDataSetTableAdapters.SalesFullInfoTableAdapter
    Friend WithEvents ReportsDataSet As ProjectMinerva.ReportsDataSet
End Class
