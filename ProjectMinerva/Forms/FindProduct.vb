Public Class FindProduct
    Friend ReturnTo As String

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub FindProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.JupiterDataSet.Products)

    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim ProductToEdit As New Product
        ProductToEdit.SetFromRow(ProductsDataGridView.CurrentRow)
        EditProduct.OriginalProduct = ProductToEdit
        ReturnTo = "EditProduct"
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.Clear()
        ClearButton.Enabled = False
        SearchTextBox.Focus()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text.Length > 0 Then
            JupiterDataSet.Products.Clear()
            Me.ProductsTableAdapter.FillBySearch(JupiterDataSet.Products, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.ProductsTableAdapter.Fill(Me.JupiterDataSet.Products)
            ClearButton.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FindProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Go = ReturnTo
        ReturnTo = Nothing
        Select Case Go
            Case "SaleHome"
                SalesHome.Show()
            Case "EditProduct"
                EditProduct.Show()
            Case "AdminPanel"
                AdministrationPanel.Show()
            Case "Home"
                ProductsHome.Show()
            Case Else
                Main.Show()
        End Select
    End Sub

    Private Sub AddToSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToSaleToolStripMenuItem.Click
        Dim QuantityForm As New QuantityModal
        Dim ChosenProduct As New Product
        ChosenProduct.SetFromRow(ProductsDataGridView.CurrentRow)
        QuantityForm.MaxQuantity = ChosenProduct.Stock
        If QuantityForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim QuantityToAdd As New Integer
            QuantityToAdd = QuantityForm.QuantityToAddNumeric.Value
            Dim ActiveSale As New Sale
            ActiveSale.SetFromRow(Sale.GetActiveSale(Me.SalesTableAdapter))
            ActiveSale.AddLineItem(ChosenProduct, QuantityToAdd, Me.LineItemsTableAdapter, Me.ProductsTableAdapter)
            Me.ProductsTableAdapter.Fill(Me.JupiterDataSet.Products)
            If QuantityToAdd = 1 Then
                MessageBox.Show("1" + ChosenProduct.Name + " was added to the sale.", "Find Product - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf QuantityToAdd > 1 Then
                MessageBox.Show(QuantityToAdd.ToString + " " + ChosenProduct.Name + " were added to the sale.", "Find Product - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Item addition was canceled.", "Find Product - Project Minvera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ProductsDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles ProductsDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            ProductsDataGridView.ClearSelection()
            Dim NewRow = ProductsDataGridView.HitTest(e.X, e.Y)
            If NewRow.RowIndex > -1 Then
                ProductsDataGridView.CurrentCell = ProductsDataGridView.Rows(NewRow.RowIndex).Cells(1)
                ProductsDataGridView.CurrentRow.Selected = True
                Application.DoEvents()
                ProductsContextMenu.Show(Cursor.Position)
            End If
            NewRow = Nothing
        End If
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        Call ModifyButton_Click(sender, e)
    End Sub

End Class