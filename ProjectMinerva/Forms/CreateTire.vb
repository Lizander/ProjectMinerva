Public Class CreateTire
    Dim NewTire As New Tire

    Private Sub TiresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TiresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub CreateTire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Suppliers' table. You can move, or remove it, as needed.
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
            NewTire.Width = WidthTextBox.Text
            NewTire.Razon = RazonAvATextBox.Text
            NewTire.Diameter = DiameterTextBox.Text
            NewTire.Brand = BrandComboBox.Text
            NewTire.Condition = ConditionComboBox.SelectedItem
            NewTire.Model = ModelTextBox.Text
            NewTire.Traction = TractionTextBox.Text
            NewTire.Treadwear = TreadwearTextBox.Text
            NewTire.Temperature = TemperatureTextBox.Text
            NewTire.SupplierID = SupplierIDComboBox.SelectedValue
            NewTire.StateExempt = StateExemptComboBox.SelectedItem
            NewTire.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            NewTire.Price = PriceNumericUpDown.Value
            NewTire.Cost = CostNumericUpDown.Value
            NewTire.ReorderPoint = ReorderPointNumericUpDown.Value
            NewTire.Stock = StockNumericUpDown.Value
            NewTire.Create(Me.TiresTableAdapter)
            If NewTire.Saved() Then
                MessageBox.Show("The tire was saved.", "Create Tire - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                TiresHome.Show()
                Me.Close()
            Else
                MessageBox.Show("Something went wrong.", "Create Tire - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        End If
    End Sub

    Private Sub WidthTextBox_TextChanged(sender As Object, e As EventArgs) Handles WidthTextBox.TextChanged
        If WidthTextBox.Text.Length <= 0 Then
            WidthTextBox.BackColor = Color.Red
        Else
            WidthTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub RazonAvATextBox_TextChanged(sender As Object, e As EventArgs) Handles RazonAvATextBox.TextChanged
        If RazonAvATextBox.Text.Length <= 0 Then
            RazonAvATextBox.BackColor = Color.Red
        Else
            RazonAvATextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub DiameterTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiameterTextBox.TextChanged
        If DiameterTextBox.Text.Length <= 0 Then
            DiameterTextBox.BackColor = Color.Red
        Else
            DiameterTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub CreateTire_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ConditionComboBox.SelectedIndex = 0
        BrandComboBox.SelectedIndex = 0
        MunicipalExemptComboBox.SelectedIndex = 1
        StateExemptComboBox.SelectedIndex = 1
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        TiresHome.Show()
        Me.Close()
    End Sub
End Class