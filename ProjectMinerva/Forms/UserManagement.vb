Public Class UserManagement

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OwlsDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapterOwl.Fill(Me.OwlsDataSet.Users)
        'TODO: This line of code loads data into the 'JupiterDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.JupiterDataSet.Users)

    End Sub

    Private Sub UsersDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellClick
        Dim SelectedUser As New User
        DisableControls()
        EditButton.Enabled = True
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If EditButton.Enabled Then
            'Edit User Logic
            
            If UsernameTextBox.Text.Length <= 0 Then
                UsernameTextBox.BackColor = Color.Red
                UsernameTextBox.Focus()
            ElseIf PositionTextBox.Text.Length <= 0 Then
                PositionTextBox.BackColor = Color.Red
                PositionTextBox.Focus()
                'Password doesn't have to be present if user doesn't want to change it
            ElseIf PasswordTextBox.Text.Length > 0 Then
                If PasswordTextBox.Text = ConfirmationTextBox.Text Then
                    ConfirmationTextBox.BackColor = Color.White
                    EditUserFunction()
                Else
                    ConfirmationTextBox.BackColor = Color.Red
                    ConfirmationTextBox.Focus()
                End If
            Else
                EditUserFunction()
            End If
        Else
            If UsernameTextBox.Text.Length <= 0 Then
                UsernameTextBox.BackColor = Color.Red
                UsernameTextBox.Focus()
            ElseIf PositionTextBox.Text.Length <= 0 Then
                PositionTextBox.BackColor = Color.Red
                PositionTextBox.Focus()
            ElseIf PasswordTextBox.Text.Length <= 0 Then
                PasswordTextBox.BackColor = Color.Red
                PasswordTextBox.Focus()
            ElseIf ConfirmationTextBox.Text <> PasswordTextBox.Text Then
                ConfirmationTextBox.BackColor = Color.Red
                ConfirmationTextBox.Focus()
            Else
                Dim NewUser As New User
                NewUser.Username = UsernameTextBox.Text
                NewUser.Position = PositionTextBox.Text
                NewUser.Password = PasswordTextBox.Text
                NewUser.Create(Me.UsersTableAdapter)
                If NewUser.Saved() Then
                    MessageBox.Show("The user was saved.", "User Management - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                    Me.UsersTableAdapterOwl.Fill(Me.OwlsDataSet.Users)
                    Me.UsersTableAdapter.Fill(Me.JupiterDataSet.Users)
                    DisableControls()
                    EditButton.Enabled = True
                Else
                    MessageBox.Show("Something went wrong.", "User Management - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        If UsernameTextBox.Text.Length <= 0 Then
            UsernameTextBox.BackColor = Color.Red
        Else
            UsernameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub PositionTextBox_TextChanged(sender As Object, e As EventArgs) Handles PositionTextBox.TextChanged
        If PositionTextBox.Text.Length <= 0 Then
            PositionTextBox.BackColor = Color.Red
        Else
            PositionTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ConfirmationTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmationTextBox.TextChanged
        If PasswordTextBox.Text.Length > 0 Then
            If PasswordTextBox.Text = ConfirmationTextBox.Text Then
                ConfirmationTextBox.BackColor = Color.White
            Else
                ConfirmationTextBox.BackColor = Color.Red
            End If
        Else
            PasswordTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        PasswordLabel.Visible = True
        PasswordTextBox.Visible = True
        ConfirmationTextBox.Visible = True
        ConfirmationLabel.Visible = True
        SaveButton.Enabled = True
        EditButton.Enabled = False
        UsernameTextBox.Enabled = True
        UsernameTextBox.Text = ""
        PositionTextBox.Enabled = True
        PositionTextBox.Text = ""
    End Sub

    Private Sub DisableControls()
        PasswordLabel.Visible = False
        PasswordTextBox.Visible = False
        ConfirmationTextBox.Visible = False
        ConfirmationLabel.Visible = False
        SaveButton.Enabled = False
        UsernameTextBox.Enabled = False
        PositionTextBox.Enabled = False
        PasswordTextBox.Text = ""
        PasswordTextBox.BackColor = Color.White
        ConfirmationTextBox.Text = ""
    End Sub

    Private Sub EditUserFunction()
        Dim EditedUser As New User
        Dim SelectedUser As New User
        SelectedUser.SetFromRow(UsersDataGridView.CurrentRow)
        EditedUser.Password = PasswordTextBox.Text
        EditedUser.ID = SelectedUser.ID
        If EditedUser.Password = Nothing Then
            EditedUser.Password = SelectedUser.Password
        End If
        EditedUser.Username = UsernameTextBox.Text
        EditedUser.Position = PositionTextBox.Text
        If EditedUser.IsSame(SelectedUser) Then
            MessageBox.Show("No changes were necessary.", "User Management - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DisableControls()
        Else
            EditedUser.Update(Me.UsersTableAdapter)
            If EditedUser.Saved() Then
                Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                MessageBox.Show("Your changes were saved.", "User Management - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UsersTableAdapterOwl.Fill(Me.OwlsDataSet.Users)
                Me.UsersTableAdapter.Fill(Me.JupiterDataSet.Users)
                DisableControls()
            End If
        End If
    End Sub
End Class