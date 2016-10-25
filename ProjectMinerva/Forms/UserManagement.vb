Public Class UserManagement

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.JupiterDataSet.Users)

    End Sub

    Private Sub UsersDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellClick

    End Sub
End Class