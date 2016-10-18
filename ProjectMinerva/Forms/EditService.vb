Public Class EditService
    Friend OriginalService As New Service
    Friend EditedService As New Service


    Private Sub EditService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ServicesTableAdapter.Fill(Me.JupiterDataSet.Services)
    End Sub

    Private Sub EditService_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        NameTextBox.Text = OriginalService.Name
        DescriptionTextBox.Text = OriginalService.Description
        CategoryComboBox.Text = OriginalService.Category
        PriceNumericUpDown.Value = OriginalService.Price
        CostNumericUpDown.Value = OriginalService.Cost
        StateExemptComboBox.Text = OriginalService.StateExempt
        MunicipalExemptComboBox.Text = OriginalService.MunicipalExempt
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        FindService.Show()
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NameTextBox.Text.Length <= 0 Then
            NameTextBox.BackColor = Color.Red
            NameTextBox.Focus()
        ElseIf CategoryComboBox.Text.Length <= 0 Then
            CategoryComboBox.BackColor = Color.Red
            CategoryComboBox.Focus()
        Else
            EditedService.Name = NameTextBox.Text
            EditedService.Description = DescriptionTextBox.Text
            EditedService.Category = CategoryComboBox.Text
            EditedService.Price = PriceNumericUpDown.Value
            EditedService.Cost = CostNumericUpDown.Value
            EditedService.StateExempt = StateExemptComboBox.SelectedItem
            EditedService.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            If EditedService.IsSame(OriginalService) Then
                MessageBox.Show("No changes were necessary.", "Edit Service - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FindService.Show()
                Me.Close()
            Else
                EditedService.ID = OriginalService.ID
                EditedService.Update(Me.ServicesTableAdapter)
                If EditedService.Saved() Then
                    Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                    MessageBox.Show("Your changes were saved.", "Edit Service - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FindService.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Something went wrong.", "Create Service - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class