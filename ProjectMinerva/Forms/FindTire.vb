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
End Class