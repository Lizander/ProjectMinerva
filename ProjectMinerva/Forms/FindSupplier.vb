Public Class FindSupplier

    Private Sub FindSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text.Length > 0 Then
            JupiterDataSet.Suppliers.Clear()
            Me.SuppliersTableAdapter.FillBySearch(JupiterDataSet.Suppliers, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
            ClearButton.Enabled = False
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.Clear()
        ClearButton.Enabled = False
        SearchTextBox.Focus()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim SupplierToEdit As New Supplier
        SupplierToEdit.SetSupplierFromRow(SuppliersDataView.CurrentRow)
        EditSupplier.OriginalSupplier = SupplierToEdit
        EditSupplier.Show()
        Me.Close()
    End Sub
End Class