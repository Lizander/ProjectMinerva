Public Class CreateService
    Dim NewService As New Service

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
        ServicesHome.Show()
        Me.Close()
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
            NameTextBox.Focus()
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
        CategoryComboBox.Text = ""
        CategoryComboBox.BackColor = Color.White
        NameTextBox.Text = ""
        DescriptionTextBox.Text = ""
        PriceNumericUpDown.Value = 0
        CostNumericUpDown.Value = 0
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
            NameTextBox.Focus()
        ElseIf CategoryComboBox.Text.Length <= 0 Then
            CategoryComboBox.BackColor = Color.Red
            CategoryComboBox.Focus()
        Else
            NewService.Name = NameTextBox.Text
            NewService.Description = DescriptionTextBox.Text
            NewService.Category = CategoryComboBox.Text
            NewService.Price = PriceNumericUpDown.Value
            NewService.Cost = CostNumericUpDown.Value
            NewService.StateExempt = StateExemptComboBox.SelectedItem
            NewService.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            NewService.Create(Me.ServicesTableAdapter)
            If NewService.Saved() Then
                MessageBox.Show("The service was saved.", "Create Service - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                ServicesHome.Show()
                Me.Close()
            Else
                MessageBox.Show("Something went wrong.", "Create Service - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class