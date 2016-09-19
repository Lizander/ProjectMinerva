Imports System.Text.RegularExpressions

Public Class CreateCustomer

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub CreateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Customers' table. You can move, or remove it, as needed.
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
            FirstNameTextBox.Text = FirstNameTextBox.Text.ToUpper
            FirstLastNameTextBox.Text = FirstLastNameTextBox.Text.ToUpper
            SecondLastNameTextBox.Text = SecondLastNameTextBox.Text.ToUpper
            EmailAddressTextBox.Text = EmailAddressTextBox.Text.ToUpper
            CityTextBox.Text = CityTextBox.Text.ToUpper
            Me.CustomersTableAdapter.InsertCustomer(FirstNameTextBox.Text, FirstLastNameTextBox.Text, SecondLastNameTextBox.Text, PhoneNumberMaskedTextBox.Text, EmailAddressTextBox.Text,
                                                GenderComboBox.SelectedItem, CityTextBox.Text, StateExemptComboBox.SelectedItem, MunicipalExemptComboBox.SelectedItem, DiscountNumericUpDown.Value,
                                                Date.Today)
            Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
            Me.Close()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
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
End Class