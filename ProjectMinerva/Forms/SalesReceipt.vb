Public Class SalesReceipt
    Friend ChosenSale As New Sale

    Private Sub SalesReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StoresTableAdapter.Fill(Me.JupiterDataSet.Stores)
        Me.SalesTableAdapter.FillByID(Me.JupiterDataSet.Sales, ChosenSale.ID)
        Me.LineItemsTableAdapter.FillBySale(Me.JupiterDataSet.LineItems, ChosenSale.ID)
        Me.CustomersTableAdapter.FillByID(Me.JupiterDataSet.Customers, ChosenSale.CustomerID)
        Me.UsersTableAdapter.FillByID(Me.JupiterDataSet.Users, ChosenSale.UserID)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SalesReceipt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.SalesTableAdapter.FillByID(Me.JupiterDataSet.Sales, ChosenSale.ID)
        Me.LineItemsTableAdapter.FillBySale(Me.JupiterDataSet.LineItems, ChosenSale.ID)
        Me.CustomersTableAdapter.FillByID(Me.JupiterDataSet.Customers, ChosenSale.CustomerID)
        Me.UsersTableAdapter.FillByID(Me.JupiterDataSet.Users, ChosenSale.UserID)
    End Sub
End Class