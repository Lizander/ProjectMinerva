Public Class TireInventoryReport

    Private Sub TireInventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Tires' table. You can move, or remove it, as needed.
        Me.TiresTableAdapter.Fill(Me.JupiterDataSet.Tires)
        'TODO: This line of code loads data into the 'JupiterDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.JupiterDataSet.Stores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class