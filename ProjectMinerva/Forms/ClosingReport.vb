Imports Microsoft.Reporting.WinForms

Public Class ClosingReport

    Private Sub ClosingReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.JupiterDataSet.Stores)
        'TODO: This line of code loads data into the 'JupiterDataSet.LineItems' table. You can move, or remove it, as needed.
        Me.LineItemsTableAdapter.FillBySalesDate(Me.JupiterDataSet.LineItems, SaleDatePicker.Value.ToShortDateString)
        'TODO: This line of code loads data into the 'JupiterDataSet.SalesFullInfo' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.FillByDate(Me.JupiterDataSet.Sales, SaleDatePicker.Value.ToShortDateString)
        Dim SaleDate = New ReportParameter("ReportDate", SaleDatePicker.Value.ToShortDateString)
        ReportViewer1.LocalReport.SetParameters(SaleDate)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ClosingReport_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.LineItemsTableAdapter.FillBySalesDate(Me.JupiterDataSet.LineItems, SaleDatePicker.Value.ToShortDateString)
        Me.SalesTableAdapter.FillByDate(Me.JupiterDataSet.Sales, SaleDatePicker.Value.ToShortDateString)
        Dim SaleDate = New ReportParameter("ReportDate", SaleDatePicker.Value.ToShortDateString)
        ReportViewer1.LocalReport.SetParameters(SaleDate)
    End Sub

    Private Sub SaleDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles SaleDatePicker.ValueChanged
        Me.LineItemsTableAdapter.FillBySalesDate(Me.JupiterDataSet.LineItems, SaleDatePicker.Value.ToShortDateString)
        Me.SalesTableAdapter.FillByDate(Me.JupiterDataSet.Sales, SaleDatePicker.Value.ToShortDateString)
        Dim SaleDate = New ReportParameter("ReportDate", SaleDatePicker.Value.ToShortDateString)
        ReportViewer1.LocalReport.SetParameters(SaleDate)
    End Sub
End Class