Public Class SalesHome
    Dim CurrentSale As New Sale
    Dim TooltipText As String

    Private Sub LineItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LineItemsBindingSource.EndEdit()


    End Sub

    Private Sub SalesHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.LineItems' table. You can move, or remove it, as needed.
        Me.LineItemsTableAdapter.FillByActiveSale(Me.JupiterDataSet.LineItems)
    End Sub

    Private Sub SalesHome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If SalesTableAdapter.GetDataWithActive.Count > 0 Then
            UpdateSaleInfo()
        Else
            CurrentSale.LineItemSource = LineItemsTableAdapter
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

    Private Sub LineItemsDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles LineItemsDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            LineItemsDataGridView.ClearSelection()
            Dim NewRow = LineItemsDataGridView.HitTest(e.X, e.Y)
            If NewRow.RowIndex > -1 Then
                LineItemsDataGridView.CurrentCell = LineItemsDataGridView.Rows(NewRow.RowIndex).Cells(6)
                LineItemsDataGridView.CurrentRow.Selected = True
                Application.DoEvents()
                ManageLineItemsMenu.Show(Cursor.Position)
            End If
            NewRow = Nothing
        End If
    End Sub

    Private Sub EditQuantityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditQuantityToolStripMenuItem.Click
        Dim QuantityForm As New QuantityModal
        Dim ChosenItem As New LineItem
        ChosenItem.SetFromRow(LineItemsDataGridView.CurrentRow)
        If ChosenItem.ItemType = "Tire" Then
            Dim ChosenTire As New Tire
            ChosenTire.SetFromRow(TiresTableAdapter.GetByID(ChosenItem.ItemID).Rows(0))
            ChosenTire.Stock += ChosenItem.Quantity
            QuantityForm.MaxQuantity = ChosenTire.Stock
            If QuantityForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ChosenItem.Quantity = QuantityForm.QuantityToAddNumeric.Value
                ChosenTire.Stock -= ChosenItem.Quantity
                ChosenItem.Update(LineItemsTableAdapter)
                ChosenTire.Update(TiresTableAdapter)
                UpdateSaleInfo()
            Else
                MessageBox.Show("Quantity editing was canceled.", "Sales Home - Project Minvera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf ChosenItem.ItemType = "Product" Then
            Dim ChosenProduct As New Product
            ChosenProduct.SetFromRow(ProductsTableAdapter.GetByID(ChosenItem.ItemID).Rows(0))
            ChosenProduct.Stock += ChosenItem.Quantity
            QuantityForm.MaxQuantity = ChosenProduct.Stock
            If QuantityForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ChosenItem.Quantity = QuantityForm.QuantityToAddNumeric.Value
                ChosenProduct.Stock -= ChosenItem.Quantity
                ChosenItem.Update(LineItemsTableAdapter)
                ChosenProduct.Update(ProductsTableAdapter)
                UpdateSaleInfo()
            Else
                MessageBox.Show("Quantity editing was canceled.", "Sales Home - Project Minvera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf ChosenItem.ItemType = "Service" Then
            QuantityForm.MaxQuantity = "N/A"
            If QuantityForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ChosenItem.Quantity = QuantityForm.QuantityToAddNumeric.Value
                ChosenItem.Update(LineItemsTableAdapter)
                Me.SalesTableAdapter.Update(JupiterDataSet)
                UpdateSaleInfo()
            Else
                MessageBox.Show("Quantity editing was canceled.", "Sales Home - Project Minvera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub UpdateSaleInfo()
        Me.LineItemsTableAdapter.Update(JupiterDataSet.LineItems)
        Me.SalesTableAdapter.Update(JupiterDataSet.Sales)
        Me.LineItemsTableAdapter.FillByActiveSale(Me.JupiterDataSet.LineItems)
        CurrentSale.DataSource = SalesTableAdapter
        CurrentSale.LineItemSource = LineItemsTableAdapter
        CurrentSale.SetFromRow(Sale.GetActiveSale(SalesTableAdapter))
        CurrentSale.Calculations()
        DiscountBox.Text = CurrentSale.Discount.ToString("C")
        SubtotalBox.Text = CurrentSale.Subotal.ToString("C")
        StateTaxBox.Text = CurrentSale.StateTax.ToString("C")
        MunicipalTaxBox.Text = CurrentSale.MunicipalTax.ToString("C")
        TotalBox.Text = CurrentSale.Total.ToString("C")
        If CurrentSale.CustomerID > 0 Then
            CustomerBox.Text = CurrentSale.GetCustomerName(CustomersTableAdapter)
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim Result = MessageBox.Show("Are you sure you want to delete " + LineItemsDataGridView.CurrentRow.Cells(5).Value + "?", "Sales Home - Project Minerva",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim ChosenItem As New LineItem
            ChosenItem.SetFromRow(LineItemsDataGridView.CurrentRow)
            If ChosenItem.ItemType = "Tire" Then
                Dim ChosenTire As New Tire
                ChosenTire.SetFromRow(TiresTableAdapter.GetByID(ChosenItem.ItemID).Rows(0))
                ChosenItem.ReturnStock(ChosenTire, TiresTableAdapter)
                ChosenTire.Update(TiresTableAdapter)
            ElseIf ChosenItem.ItemType = "Product" Then
                Dim ChosenProduct As New Product
                ChosenProduct.SetFromRow(ProductsTableAdapter.GetByID(ChosenItem.ItemID).Rows(0))
                ChosenItem.ReturnStock(ChosenProduct, ProductsTableAdapter)
                ChosenProduct.Update(ProductsTableAdapter)
            End If
            LineItemsTableAdapter.DeleteByID(LineItemsDataGridView.CurrentRow.Cells(0).Value)
            UpdateSaleInfo()
        End If
    End Sub

    Private Sub AddDiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDiscountToolStripMenuItem.Click
        Dim ChosenItem As New LineItem
        Dim DiscountForm As New DiscountModal
        ChosenItem.SetFromRow(LineItemsDataGridView.CurrentRow)
        If DiscountForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim DiscountType = DiscountForm.TypeBox.SelectedItem
            Dim DiscountAmount = DiscountForm.DiscountNumeric.Value
            ChosenItem.DiscountType = DiscountType
            ChosenItem.DiscountAmount = DiscountAmount
            ChosenItem.Update(LineItemsTableAdapter)
            UpdateSaleInfo()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub FinishSaleButton_Click_1(sender As Object, e As EventArgs) Handles FinishSaleButton.Click
        If CurrentSale.CustomerID > 0 Then
            If LineItemsDataGridView.RowCount > 0 Then
                Dim PaymentForm As New AdditionalSaleInfo
                If PaymentForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    CurrentSale.PaymentType = PaymentForm.PaymentTypeBox.SelectedItem
                    CurrentSale.Update(SalesTableAdapter)
                    UpdateSaleInfo()
                    SalesReceipt.ChosenSale = CurrentSale
                    SalesReceipt.Show()
                Else
                    MessageBox.Show("The sale was not completed.", "Sales Home - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("There are no items in the sale!", "Sales Home - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("You need a customer!", "Sales Home - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class