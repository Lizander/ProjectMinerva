Public Class EditProduct
    Friend OriginalProduct As New Product
    Friend EditedProduct As New Product

    Private Sub EditProduct_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        NameTextBox.Text = OriginalProduct.Name
        CategoryComboBox.Text = OriginalProduct.Category
        DescriptionTextBox.Text = OriginalProduct.Description
        WarrantyTextBox.Text = OriginalProduct.Warranty
        SupplierIDComboBox.SelectedValue = OriginalProduct.SupplierID
        StateExemptComboBox.Text = OriginalProduct.StateExempt
        MunicipalExemptComboBox.Text = OriginalProduct.MunicipalExempt
        StockNumericUpDown.Value = OriginalProduct.Stock
        CostNumericUpDown.Value = OriginalProduct.Cost
        _PriceNumericUpDown.Value = OriginalProduct.Price
        ReorderPointNumericUpDown.Value = OriginalProduct.ReorderPoint
    End Sub

    Private Sub EditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
        'TODO: This line of code loads data into the 'JupiterDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.JupiterDataSet.Products)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
            NameTextBox.Focus()
        ElseIf CategoryComboBox.Text.Length <= 0 Then
            CategoryComboBox.BackColor = Color.Red
            CategoryComboBox.Focus()
        Else
            EditedProduct.Name = NameTextBox.Text
            EditedProduct.Category = CategoryComboBox.Text
            EditedProduct.Description = DescriptionTextBox.Text
            EditedProduct.Warranty = WarrantyTextBox.Text
            EditedProduct.Price = _PriceNumericUpDown.Value
            EditedProduct.Cost = CostNumericUpDown.Value
            EditedProduct.Stock = StockNumericUpDown.Value
            EditedProduct.ReorderPoint = ReorderPointNumericUpDown.Value
            EditedProduct.SupplierID = SupplierIDComboBox.SelectedValue
            EditedProduct.StateExempt = StateExemptComboBox.SelectedItem
            EditedProduct.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            If EditedProduct.IsSame(OriginalProduct) Then
                MessageBox.Show("No changes were necessary.", "Edit Product - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FindProduct.Show()
                Me.Close()
            Else
                EditedProduct.ID = OriginalProduct.ID
                EditedProduct.Update(Me.ProductsTableAdapter)
                If EditedProduct.Saved() Then
                    Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                    MessageBox.Show("Your changes were saved.", "Edit Product - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FindProduct.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
        Else
            NameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub CategoryComboBox_TextChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.TextChanged
        If CategoryComboBox.Text.Length <= 0 Then
            CategoryComboBox.BackColor = Color.Red
        Else
            CategoryComboBox.BackColor = Color.White
        End If
    End Sub
End Class