Public Class FindCustomers
    Friend ReturnTo As String

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
        ReturnTo = "EditCustomer"
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
            JupiterDataSet.Customers.Clear()
            Me.CustomersTableAdapter.FillBySearch(JupiterDataSet.Customers, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.CustomersTableAdapter.Fill(Me.JupiterDataSet.Customers)
            ClearButton.Enabled = False
        End If
    End Sub

    Private Sub FindCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Go = ReturnTo
        ReturnTo = Nothing
        Select Case Go
            Case "SaleHome"
                SalesHome.Show()
            Case "EditCustomer"
                EditCustomer.Show()
            Case "AdminPanel"
                AdministrationPanel.Show()
            Case "Home"
                CustomersHome.Show()
            Case Else
                Main.Show()
        End Select
    End Sub

    Private Sub AddToSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToSaleToolStripMenuItem.Click
        Dim ChosenCustomer As New Customer
        ChosenCustomer.SetFromRow(CustomersDataGridView.CurrentRow)
        Dim ActiveSale As New Sale
        ActiveSale.SetFromRow(Sale.GetActiveSale(Me.SalesTableAdapter))
        ActiveSale.AddCustomer(ChosenCustomer, Me.SalesTableAdapter)
        MessageBox.Show(ChosenCustomer.FirstName + " " + ChosenCustomer.FirstLastName + " was added to the sale.", "Find Customer - Project Minvera", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CustomersDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles CustomersDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            CustomersDataGridView.ClearSelection()
            Dim NewRow = CustomersDataGridView.HitTest(e.X, e.Y)
            If NewRow.RowIndex > -1 Then
                CustomersDataGridView.CurrentCell = CustomersDataGridView.Rows(NewRow.RowIndex).Cells(1)
                CustomersDataGridView.CurrentRow.Selected = True
                Application.DoEvents()
                CustomersContextMenu.Show(Cursor.Position)
            End If
            NewRow = Nothing
        End If
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        Call ModifyButton_Click(sender, e)
    End Sub
End Class