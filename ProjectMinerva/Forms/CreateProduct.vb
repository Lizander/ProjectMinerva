Public Class CreateProduct

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub CreateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
        'TODO: This line of code loads data into the 'JupiterDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.JupiterDataSet.Products)

    End Sub

    Private Sub CreateProduct_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StateExemptComboBox.SelectedIndex = 0
        MunicipalExemptComboBox.SelectedIndex = 0
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
        Else
            NameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub CategoryComboBox_TextChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.TextChanged
        If CategoryComboBox.Text.Length <= 0 Then
            CategoryComboBox.BackColor = Color.Red
        Else
            CategoryComboBox.BackColor = Color.White
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class