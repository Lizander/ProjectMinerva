Public Class CreateCustomer

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub CreateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.JupiterDataSet.Customers)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Me.CustomersTableAdapter.InsertCustomer(FirstNameTextBox.Text, FirstLastNameTextBox.Text, SecondLastNameTextBox.Text, PhoneNumberTextBox.Text, EmailAddressTextBox.Text,
                                                GenderComboBox.SelectedItem, CityTextBox.Text, StateExemptComboBox.SelectedItem, MunicipalExemptComboBox.SelectedItem, DiscountNumericUpDown.Value,
                                                Date.Today)
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class