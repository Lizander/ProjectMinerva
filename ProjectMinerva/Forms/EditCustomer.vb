Public Class EditCustomer
    Friend OriginalCustomer As New Customer
    Friend EditedCustomer As New Customer

    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomersTableAdapter.Fill(Me.JupiterDataSet.Customers)
        StateExemptComboBox.SelectedIndex = 1
        MunicipalExemptComboBox.SelectedIndex = 1
        GenderComboBox.SelectedIndex = 2
        PhoneNumberMaskedTextBox.BackColor = Color.White
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If FirstNameTextBox.TextLength <= 0 Then
            FirstNameTextBox.Focus()
            FirstNameTextBox.BackColor = Color.Red
        ElseIf FirstLastNameTextBox.TextLength <= 0 Then
            FirstLastNameTextBox.Focus()
            FirstLastNameTextBox.BackColor = Color.Red
        ElseIf Not PhoneNumberMaskedTextBox.MaskFull Then
            PhoneNumberMaskedTextBox.Focus()
            PhoneNumberMaskedTextBox.BackColor = Color.Red
        ElseIf CityTextBox.TextLength <= 0 Then
            CityTextBox.Focus()
            CityTextBox.BackColor = Color.Red
        Else
            EditedCustomer.FirstName = FirstNameTextBox.Text.ToUpper
            EditedCustomer.FirstLastName = FirstLastNameTextBox.Text.ToUpper
            EditedCustomer.SecondLastName = SecondLastNameTextBox.Text.ToUpper
            EditedCustomer.EmailAddress = EmailAddressTextBox.Text.ToUpper
            EditedCustomer.City = CityTextBox.Text.ToUpper
            EditedCustomer.Gender = GenderComboBox.SelectedItem
            EditedCustomer.PhoneNumber = PhoneNumberMaskedTextBox.Text
            EditedCustomer.StateExempt = StateExemptComboBox.SelectedItem
            EditedCustomer.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            EditedCustomer.Discount = DiscountNumericUpDown.Value
            If EditedCustomer.IsSame(OriginalCustomer) Then
                MessageBox.Show("No changes were necessary.", "Edit Customer - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FindCustomers.Show()
                Me.Close()
            Else
                EditedCustomer.ID = OriginalCustomer.ID
                EditedCustomer.Update(Me.CustomersTableAdapter)
                If EditedCustomer.Saved() Then
                    Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                    MessageBox.Show("Your changes were saved.", "Edit Customer - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FindCustomers.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CustomersHome.Show()
        Me.Close()
    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
        If FirstNameTextBox.TextLength > 0 Then
            FirstNameTextBox.BackColor = Color.White
        Else
            FirstNameTextBox.Focus()
            FirstNameTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub FirstLastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstLastNameTextBox.TextChanged
        If FirstLastNameTextBox.TextLength > 0 Then
            FirstLastNameTextBox.BackColor = Color.White
        Else
            FirstLastNameTextBox.Focus()
            FirstLastNameTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub PhoneNumberMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumberMaskedTextBox.TextChanged
        If PhoneNumberMaskedTextBox.MaskFull Then
            PhoneNumberMaskedTextBox.BackColor = Color.White
        Else
            PhoneNumberMaskedTextBox.Focus()
            PhoneNumberMaskedTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub EditCustomer_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FirstNameTextBox.Text = OriginalCustomer.FirstName
        FirstLastNameTextBox.Text = OriginalCustomer.FirstLastName
        SecondLastNameTextBox.Text = OriginalCustomer.SecondLastName
        PhoneNumberMaskedTextBox.Text = OriginalCustomer.PhoneNumber
        EmailAddressTextBox.Text = OriginalCustomer.EmailAddress
        GenderComboBox.Text = OriginalCustomer.Gender
        CityTextBox.Text = OriginalCustomer.City
        StateExemptComboBox.Text = OriginalCustomer.StateExempt
        MunicipalExemptComboBox.Text = OriginalCustomer.MunicipalExempt
        DiscountNumericUpDown.Value = OriginalCustomer.Discount
    End Sub
End Class