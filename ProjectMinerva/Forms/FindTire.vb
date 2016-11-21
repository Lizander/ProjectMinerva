Public Class FindTire
    Friend ReturnTo As String

    Private Sub TiresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TiresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub FindTire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Tires' table. You can move, or remove it, as needed.
        Me.TiresTableAdapter.Fill(Me.JupiterDataSet.Tires)
        Me.SalesTableAdapter.Fill(Me.JupiterDataSet.Sales)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.Clear()
        ClearButton.Enabled = False
        SearchTextBox.Focus()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text.Length > 0 Then
            JupiterDataSet.Tires.Clear()
            Me.TiresTableAdapter.FillBySearch(JupiterDataSet.Tires, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.TiresTableAdapter.Fill(Me.JupiterDataSet.Tires)
            ClearButton.Enabled = False
        End If
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim TireToEdit As New Tire
        TireToEdit.SetFromRow(TiresDataGridView.CurrentRow)
        EditTire.OriginalTire = TireToEdit
        ReturnTo = "EditTire"
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        Call ModifyButton_Click(sender, e)
    End Sub

    Private Sub TiresDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles TiresDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            TiresDataGridView.ClearSelection()
            Dim NewRow = TiresDataGridView.HitTest(e.X, e.Y)
            If NewRow.RowIndex > -1 Then
                TiresDataGridView.CurrentCell = TiresDataGridView.Rows(NewRow.RowIndex).Cells(1)
                TiresDataGridView.CurrentRow.Selected = True
                Application.DoEvents()
                TiresContextMenu.Show(Cursor.Position)
            End If
            NewRow = Nothing
        End If
    End Sub

    Private Sub AddToSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToSaleToolStripMenuItem.Click
        Dim QuantityForm As New QuantityModal
        Dim ChosenTire As New Tire
        ChosenTire.SetFromRow(TiresDataGridView.CurrentRow)
        QuantityForm.MaxQuantity = ChosenTire.Stock
        If QuantityForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim QuantityToAdd As New Integer
            QuantityToAdd = QuantityForm.QuantityToAddNumeric.Value
            Dim ActiveSale As New Sale
            ActiveSale.SetFromRow(Sale.GetActiveSale(Me.SalesTableAdapter))
            ActiveSale.AddLineItem(ChosenTire, QuantityToAdd, Me.LineItemsTableAdapter, Me.TiresTableAdapter)
            Me.TiresTableAdapter.Fill(Me.JupiterDataSet.Tires)
            If QuantityToAdd = 1 Then
                MessageBox.Show("1" + ChosenTire.GetDescription + " was added to the sale.", "Find Tire - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf QuantityToAdd > 1 Then
                MessageBox.Show(QuantityToAdd.ToString + " " + ChosenTire.GetDescription + " were added to the sale.", "Find Tire - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Item addition was canceled.", "Find Tire - Project Minvera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FindTire_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Go = ReturnTo
        ReturnTo = Nothing
        Select Case Go
            Case "SaleHome"
                SalesHome.Show()
            Case "EditTire"
                EditTire.Show()
            Case "AdminPanel"
                AdministrationPanel.Show()
            Case "Home"
                TiresHome.Show()
            Case Else
                Main.Show()
        End Select
    End Sub
End Class