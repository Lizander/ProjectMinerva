Public Class FindCustomers

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub ShowCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.JupiterDataSet.Customers)

    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim CustomerToEdit As New Customer
        CustomerToEdit.SetFromRow(CustomersDataGridView.CurrentRow)
        EditCustomer.OriginalCustomer = CustomerToEdit
        EditCustomer.Show()
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
            JupiterDataSet.Customers.Clear()
            Me.CustomersTableAdapter.FillBySearch(JupiterDataSet.Customers, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.CustomersTableAdapter.Fill(Me.JupiterDataSet.Customers)
            ClearButton.Enabled = False
        End If
    End Sub
End Class