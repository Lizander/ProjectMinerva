Imports Microsoft.Reporting.WinForms

Public Class CustomerSalesReport

    Private Sub CustomerSalesReport_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.SalesFullInfoTableAdapter.FillByDatePeriod(Me.JupiterDataSet.SalesFullInfo, StartDatePicker.Value.ToShortDateString, EndDatePicker.Value.ToShortDateString)
        Dim StartDate = New ReportParameter("StartDate", StartDatePicker.Value.ToShortDateString)
        Dim EndDate = New ReportParameter("EndDate", EndDatePicker.Value.ToShortDateString)
        ReportViewer1.LocalReport.SetParameters(StartDate)
        ReportViewer1.LocalReport.SetParameters(EndDate)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CustomerSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.SalesFullInfo' table. You can move, or remove it, as needed.
        Me.SalesFullInfoTableAdapter.Fill(Me.JupiterDataSet.SalesFullInfo)
        'TODO: This line of code loads data into the 'JupiterDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.JupiterDataSet.Stores)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub StartDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles StartDatePicker.ValueChanged
        Dim StartDate = StartDatePicker.Value
        Dim EndDate = EndDatePicker.Value
        If StartDate <= EndDate Then
            Dim StartDateString = StartDate.ToShortDateString
            Dim EndDateString = EndDate.ToShortDateString
            Me.SalesFullInfoTableAdapter.FillByDatePeriod(Me.JupiterDataSet.SalesFullInfo, StartDatePicker.Value.ToShortDateString, EndDatePicker.Value.ToShortDateString)
            Dim StartDateParameter = New ReportParameter("StartDate", StartDateString)
            Dim EndDateParameter = New ReportParameter("EndDate", EndDateString)
            ReportViewer1.LocalReport.SetParameters(StartDateParameter)
            ReportViewer1.LocalReport.SetParameters(EndDateParameter)
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("The start date cannot be later than the end date!", "Period Report - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EndDatePicker.Value = StartDatePicker.Value
        End If
    End Sub

    Private Sub EndDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles EndDatePicker.ValueChanged
        Dim StartDate = StartDatePicker.Value
        Dim EndDate = EndDatePicker.Value
        If StartDate <= EndDate Then
            Dim StartDateString = StartDate.ToShortDateString
            Dim EndDateString = EndDate.ToShortDateString
            Me.SalesFullInfoTableAdapter.FillByDatePeriod(Me.JupiterDataSet.SalesFullInfo, StartDatePicker.Value.ToShortDateString, EndDatePicker.Value.ToShortDateString)
            Dim StartDateParameter = New ReportParameter("StartDate", StartDateString)
            Dim EndDateParameter = New ReportParameter("EndDate", EndDateString)
            ReportViewer1.LocalReport.SetParameters(StartDateParameter)
            ReportViewer1.LocalReport.SetParameters(EndDateParameter)
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("The start date cannot be later than the end date!", "Period Report - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            StartDatePicker.Value = EndDatePicker.Value
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ReportsHome.Show()
        Me.Close()
    End Sub
End Class