Public Class SearchSales

    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub SearchSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.SalesFullInfo' table. You can move, or remove it, as needed.
        Me.SalesFullInfoTableAdapter.Fill(Me.JupiterDataSet.SalesFullInfo)
        'TODO: This line of code loads data into the 'JupiterDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.JupiterDataSet.Sales)

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text.Length > 0 Then
            JupiterDataSet.Customers.Clear()
            Me.SalesFullInfoTableAdapter.FillBySearch(JupiterDataSet.SalesFullInfo, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.SalesFullInfoTableAdapter.Fill(Me.JupiterDataSet.SalesFullInfo)
            ClearButton.Enabled = False
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.Clear()
        ClearButton.Enabled = False
        SearchTextBox.Focus()
    End Sub

    Private Sub ViewReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReceiptToolStripMenuItem.Click
        Dim ChosenSale As New Sale
        ChosenSale.SetFromRow(SalesDataGridView.CurrentRow)
        SalesReceipt.ChosenSale = ChosenSale
        SalesReceipt.Show()
    End Sub

    Private Sub SalesDataGridView_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SalesDataGridView.CellMouseDown
        If e.Button = MouseButtons.Right Then
            SalesDataGridView.ClearSelection()
            Dim NewRow = SalesDataGridView.HitTest(e.X, e.Y)
            If NewRow.RowIndex > -1 Then
                SalesDataGridView.CurrentCell = SalesDataGridView.Rows(NewRow.RowIndex).Cells(18)
                SalesDataGridView.CurrentRow.Selected = True
                Application.DoEvents()
                SalesContextMenu.Show(Cursor.Position)
            End If
            NewRow = Nothing
        End If
    End Sub
End Class