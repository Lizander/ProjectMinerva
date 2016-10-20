Public Class FindProduct

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
        EditProduct.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
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
End Class