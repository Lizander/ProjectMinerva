Public Class CreateProduct
    Dim NewProduct As New Product

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub CreateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
        Me.ProductsTableAdapter.Fill(Me.JupiterDataSet.Products)
    End Sub

    Private Sub CreateProduct_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StateExemptComboBox.SelectedIndex = 0
        MunicipalExemptComboBox.SelectedIndex = 0
        SupplierIDComboBox.SelectedIndex = 0
        NameTextBox.Text = ""
        NameTextBox.BackColor = Color.White
        CategoryComboBox.Text = ""
        CategoryComboBox.BackColor = Color.White
        DescriptionTextBox.Text = ""
        WarrantyTextBox.Text = ""
        _PriceNumericUpDown.Value = 0
        CostNumericUpDown.Value = 0
        StockNumericUpDown.Value = 0
        ReorderPointNumericUpDown.Value = 0
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

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
            NameTextBox.Focus()
        ElseIf CategoryComboBox.Text.Length <= 0 Then
            CategoryComboBox.BackColor = Color.Red
            CategoryComboBox.Focus()
        Else
            NewProduct.Name = NameTextBox.Text
            NewProduct.Category = CategoryComboBox.Text
            NewProduct.Description = DescriptionTextBox.Text
            NewProduct.Warranty = WarrantyTextBox.Text
            NewProduct.Price = _PriceNumericUpDown.Value
            NewProduct.Cost = CostNumericUpDown.Value
            NewProduct.Stock = StockNumericUpDown.Value
            NewProduct.ReorderPoint = ReorderPointNumericUpDown.Value
            NewProduct.SupplierID = SupplierIDComboBox.SelectedValue
            NewProduct.StateExempt = StateExemptComboBox.SelectedItem
            NewProduct.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            NewProduct.Create(Me.ProductsTableAdapter)
            If NewProduct.Saved() Then
                MessageBox.Show("The product was saved.", "Create Product - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                ProductsHome.Show()
                Me.Close()
            Else
                MessageBox.Show("Something went wrong.", "Create Product - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ProductsHome.Show()
        Me.Close()
    End Sub
End Class