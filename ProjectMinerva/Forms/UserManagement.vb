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
        PasswordLabel.Visible = False
        PasswordTextBox.Visible = False
        ConfirmationTextBox.Visible = False
        ConfirmationLabel.Visible = False
        SaveButton.Enabled = False
        UsernameTextBox.Enabled = False
        PositionTextBox.Enabled = False
        Dim SelectedUser As New User
        SelectedUser.SetFromRow(UsersDataGridView.CurrentRow)
        UsernameTextBox.Text = SelectedUser.Username
        PositionTextBox.Text = SelectedUser.Position
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text.Length > 0 Then
            JupiterDataSet.Suppliers.Clear()
            Me.UsersTableAdapter.FillBySearch(JupiterDataSet.Users, SearchTextBox.Text)
            ClearButton.Enabled = True
        Else
            Me.UsersTableAdapter.Fill(Me.JupiterDataSet.Users)
            ClearButton.Enabled = False
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchTextBox.Clear()
        ClearButton.Enabled = False
        SearchTextBox.Focus()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        PasswordLabel.Visible = True
        PasswordTextBox.Visible = True
        ConfirmationTextBox.Visible = True
        ConfirmationLabel.Visible = True
        SaveButton.Enabled = True
        UsernameTextBox.Enabled = True
        PositionTextBox.Enabled = True
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If PasswordTextBox.Text.Length > 0 Then
            If PasswordTextBox.Text = ConfirmationTextBox.Text Then
                ConfirmationTextBox.BackColor = Color.White
            Else
                ConfirmationTextBox.BackColor = Color.Red
            End If
        End If
    End Sub
End Class