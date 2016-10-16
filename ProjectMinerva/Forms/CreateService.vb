Public Class CreateService

    Private Sub ServicesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ServicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub CreateService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.JupiterDataSet.Services)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        TiresHome.Show()
        Me.Close()
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
        Else
            NameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        If CategoryComboBox.Text.Length <= 0 Then
            CategoryComboBox.BackColor = Color.Red
        Else
            CategoryComboBox.BackColor = Color.White
        End If
    End Sub

    Private Sub CreateService_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MunicipalExemptComboBox.SelectedIndex = 0
        StateExemptComboBox.SelectedIndex = 0
    End Sub
End Class