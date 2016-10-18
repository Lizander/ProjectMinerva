Public Class FindService

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
        EditService.Show()
        Me.Close()
    End Sub
End Class