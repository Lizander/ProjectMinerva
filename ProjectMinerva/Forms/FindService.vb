Public Class FindService
    Friend ReturnTo As String

    Private Sub ServicesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ServicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub FindService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.JupiterDataSet.Services)

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text.Length > 0 Then
            JupiterDataSet.Suppliers.Clear()
            Me.ServicesTableAdapter.FillBySearch(JupiterDataSet.Services, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.ServicesTableAdapter.Fill(Me.JupiterDataSet.Services)
            ClearButton.Enabled = False
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.Clear()
        ClearButton.Enabled = False
        SearchTextBox.Focus()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim ServiceToEdit As New Service
        ServiceToEdit.SetFromRow(ServicesDataGridView.CurrentRow)
        EditService.OriginalService = ServiceToEdit
        ReturnTo = "EditService"
        Me.Close()
    End Sub

    Private Sub AddToSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToSaleToolStripMenuItem.Click
        Dim QuantityForm As New QuantityModal
        Dim ChosenService As New Service
        ChosenService.SetFromRow(ServicesDataGridView.CurrentRow)
        QuantityForm.MaxQuantity = "N/A"
        If QuantityForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim QuantityToAdd As New Integer
            QuantityToAdd = QuantityForm.QuantityToAddNumeric.Value
            Dim ActiveSale As New Sale
            ActiveSale.SetFromRow(Sale.GetActiveSale(Me.SalesTableAdapter))
            ActiveSale.AddLineItem(ChosenService, QuantityToAdd, Me.LineItemsTableAdapter, Me.ServicesTableAdapter)
            Me.ServicesTableAdapter.Fill(Me.JupiterDataSet.Services)
            If QuantityToAdd = 1 Then
                MessageBox.Show("1" + ChosenService.Name + " was added to the sale.", "Find Service - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf QuantityToAdd > 1 Then
                MessageBox.Show(QuantityToAdd.ToString + " " + ChosenService.Name + " were added to the sale.", "Find Service - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Item addition was canceled.", "Find Service - Project Minvera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ServicesDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles ServicesDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            ServicesDataGridView.ClearSelection()
            Dim NewRow = ServicesDataGridView.HitTest(e.X, e.Y)
            If NewRow.RowIndex > -1 Then
                ServicesDataGridView.CurrentCell = ServicesDataGridView.Rows(NewRow.RowIndex).Cells(1)
                ServicesDataGridView.CurrentRow.Selected = True
                Application.DoEvents()
                ServicesContextMenu.Show(Cursor.Position)
            End If
            NewRow = Nothing
        End If
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        Call ModifyButton_Click(sender, e)
    End Sub

    Private Sub FindService_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Go = ReturnTo
        ReturnTo = Nothing
        Select Case Go
            Case "SaleHome"
                SalesHome.Show()
            Case "EditService"
                EditService.Show()
            Case "AdminPanel"
                AdministrationPanel.Show()
            Case "Home"
                ServicesHome.Show()
            Case Else
                Main.Show()
        End Select
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class