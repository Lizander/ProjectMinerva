Public Class SalesHome

    Private Sub LineItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LineItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub SalesHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.LineItems' table. You can move, or remove it, as needed.
        Me.LineItemsTableAdapter.Fill(Me.JupiterDataSet.LineItems)

    End Sub

    Private Sub AddTiresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTiresToolStripMenuItem.Click
        FindTire.Show()
    End Sub
End Class