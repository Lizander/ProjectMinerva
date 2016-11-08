Public Class SalesHome
    Dim CurrentSale As New Sale

    Private Sub LineItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LineItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub SalesHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.LineItems' table. You can move, or remove it, as needed.
        Me.LineItemsTableAdapter.FillByActiveSale(Me.JupiterDataSet.LineItems)

    End Sub

    Private Sub SalesHome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If SalesTableAdapter.GetDataWithActive.Count > 0 Then
            CurrentSale.SetFromRow(Sale.GetActiveSale(SalesTableAdapter))
        Else
            CurrentSale.DataSource = SalesTableAdapter
            CurrentSale.MakeActive()
            CurrentSale.SaveChanges(SalesTableAdapter)
        End If
        If CurrentSale.CustomerID > 0 Then
            AddCustomerToolStripMenuItem.Text = "Change Customer"
        End If
        Me.LineItemsTableAdapter.Update(JupiterDataSet.LineItems)
        Me.LineItemsTableAdapter.FillByActiveSale(Me.JupiterDataSet.LineItems)
    End Sub

    Private Sub AddTiresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTiresToolStripMenuItem.Click
        FindTire.ReturnTo = "SaleHome"
        FindTire.Show()
        Me.Close()
    End Sub

    Private Sub AddProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductsToolStripMenuItem.Click
        FindProduct.ReturnTo = "SaleHome"
        FindProduct.Show()
        Me.Close()
    End Sub

    Private Sub AddServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddServicesToolStripMenuItem.Click
        FindService.ReturnTo = "SaleHome"
        FindService.Show()
        Me.Close()
    End Sub

    Private Sub AddCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomerToolStripMenuItem.Click
        FindCustomers.ReturnTo = "SaleHome"
        FindCustomers.Show()
        Me.Close()
    End Sub
End Class