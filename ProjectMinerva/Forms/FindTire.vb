Public Class FindTire

    Private Sub TiresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TiresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub FindTire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Tires' table. You can move, or remove it, as needed.
        Me.TiresTableAdapter.Fill(Me.JupiterDataSet.Tires)

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
        EditTire.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim TireToEdit As New Tire
        TireToEdit.SetFromRow(TiresDataGridView.CurrentRow)
        EditTire.OriginalTire = TireToEdit
        EditTire.Show()
        Me.Close()
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
End Class