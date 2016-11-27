Public Class ClosingReport

    Private Sub ClosingReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.JupiterDataSet.Stores)
        'TODO: This line of code loads data into the 'JupiterDataSet.LineItems' table. You can move, or remove it, as needed.
        Me.LineItemsTableAdapter.Fill(Me.JupiterDataSet.LineItems)
        'TODO: This line of code loads data into the 'JupiterDataSet.SalesFullInfo' table. You can move, or remove it, as needed.
        Me.SalesFullInfoTableAdapter.Fill(Me.JupiterDataSet.SalesFullInfo)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ClosingReport_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub
End Class