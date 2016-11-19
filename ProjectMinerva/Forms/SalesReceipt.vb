Public Class SalesReceipt
    Friend ChosenSale As New Sale

    Private Sub SalesReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.JupiterDataSet.Sales)
        'TODO: This line of code loads data into the 'JupiterDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.JupiterDataSet.Stores)
        'TODO: This line of code loads data into the 'JupiterDataSet.LineItems' table. You can move, or remove it, as needed.
        Me.LineItemsTableAdapter.Fill(Me.JupiterDataSet.LineItems)
        'TODO: This line of code loads data into the 'JupiterDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.JupiterDataSet.Customers)
        'TODO: This line of code loads data into the 'JupiterDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.JupiterDataSet.Users)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SalesReceipt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.SalesTableAdapter.FillByID(Me.JupiterDataSet.Sales, ChosenSale.ID)
        Me.LineItemsTableAdapter.FillBySale(Me.JupiterDataSet.LineItems, ChosenSale.ID)
        Me.CustomersTableAdapter.FillByID(Me.JupiterDataSet.Customers, ChosenSale.CustomerID)
        Me.UsersTableAdapter.FillByID(Me.JupiterDataSet.Users, ChosenSale.UserID)
    End Sub
End Class