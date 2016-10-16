Public Class EditTire
    Friend OriginalTire As New Tire
    Friend EditedTire As New Tire

    Private Sub EditTire_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WidthTextBox.Text = OriginalTire.Width
        RazonAvATextBox.Text = OriginalTire.Razon
        DiameterTextBox.Text = OriginalTire.Diameter
        BrandComboBox.Text = OriginalTire.Brand
        ConditionComboBox.Text = OriginalTire.Condition
        ModelTextBox.Text = OriginalTire.Model
        TractionTextBox.Text = OriginalTire.Traction
        TemperatureTextBox.Text = OriginalTire.Temperature
        TreadwearTextBox.Text = OriginalTire.Treadwear
        SupplierIDComboBox.SelectedValue = OriginalTire.SupplierID
        PriceNumericUpDown.Value = OriginalTire.Price
        CostNumericUpDown.Value = OriginalTire.Cost
        ReorderPointNumericUpDown.Value = OriginalTire.ReorderPoint
        StockNumericUpDown.Value = OriginalTire.Stock
        MunicipalExemptComboBox.Text = OriginalTire.MunicipalExempt
        StateExemptComboBox.Text = OriginalTire.StateExempt
    End Sub

    Private Sub EditTire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If WidthTextBox.Text.Length <= 0 Then
            WidthTextBox.BackColor = Color.Red
            WidthTextBox.Focus()
        ElseIf RazonAvATextBox.Text.Length <= 0 Then
            RazonAvATextBox.BackColor = Color.Red
            RazonAvATextBox.Focus()
        ElseIf DiameterTextBox.Text.Length <= 0 Then
            DiameterTextBox.BackColor = Color.Red
            DiameterTextBox.Focus()
        Else
            EditedTire.Width = WidthTextBox.Text
            EditedTire.Razon = RazonAvATextBox.Text
            EditedTire.Diameter = DiameterTextBox.Text
            EditedTire.Brand = BrandComboBox.Text
            EditedTire.Condition = ConditionComboBox.SelectedItem
            EditedTire.Model = ModelTextBox.Text
            EditedTire.Traction = TractionTextBox.Text
            EditedTire.Treadwear = TreadwearTextBox.Text
            EditedTire.Temperature = TemperatureTextBox.Text
            EditedTire.SupplierID = SupplierIDComboBox.SelectedValue
            EditedTire.StateExempt = StateExemptComboBox.SelectedItem
            EditedTire.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            EditedTire.Price = PriceNumericUpDown.Value
            EditedTire.Cost = CostNumericUpDown.Value
            EditedTire.Stock = StockNumericUpDown.Value
            EditedTire.ReorderPoint = ReorderPointNumericUpDown.Value
            If EditedTire.IsSame(OriginalTire) Then
                MessageBox.Show("No changes were necessary.", "Edit Tire - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FindTire.Show()
                Me.Close()
            Else
                EditedTire.ID = OriginalTire.ID
                EditedTire.Update(Me.TiresTableAdapter)
                If EditedTire.Saved() Then
                    Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                    MessageBox.Show("Your changes were saved.", "Edit Tire - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FindTire.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        FindTire.Show()
        Me.Close()
    End Sub
End Class