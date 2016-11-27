Imports System.Text.RegularExpressions

Public Class CreateCustomer
    Dim NewCustomer As New Customer
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
            NewCustomer.FirstName = FirstNameTextBox.Text.ToUpper
            NewCustomer.FirstLastName = FirstLastNameTextBox.Text.ToUpper
            NewCustomer.SecondLastName = SecondLastNameTextBox.Text.ToUpper
            NewCustomer.EmailAddress = EmailAddressTextBox.Text.ToUpper
            NewCustomer.City = CityTextBox.Text.ToUpper
            NewCustomer.Gender = GenderComboBox.SelectedItem
            NewCustomer.PhoneNumber = PhoneNumberMaskedTextBox.Text
            NewCustomer.StateExempt = StateExemptComboBox.SelectedItem
            NewCustomer.MunicipalExempt = MunicipalExemptComboBox.SelectedItem
            NewCustomer.Discount = DiscountNumericUpDown.Value
            NewCustomer.LatestVisit = Date.Today
            NewCustomer.Create(Me.CustomersTableAdapter)
            Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
            CustomersHome.Show()
            Me.Close()
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

    Private Sub CreateCustomer_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FirstNameTextBox.Text = ""
        FirstNameTextBox.BackColor = Color.White
        FirstLastNameTextBox.Text = ""
        FirstLastNameTextBox.BackColor = Color.White
        SecondLastNameTextBox.Text = ""
        PhoneNumberMaskedTextBox.Text = ""
        PhoneNumberMaskedTextBox.BackColor = Color.White
        EmailAddressTextBox.Text = ""
        CityTextBox.Text = ""

    End Sub
End Class