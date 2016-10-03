Public Class CreateSupplier
    Dim NewSupplier As New Supplier

    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
    End Sub

    Private Sub CreateSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)
        BusinessPhoneMaskedTextBox.BackColor = Color.White
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs)
        SuppliersHome.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click_1(sender As Object, e As EventArgs) Handles BackButton.Click
        SuppliersHome.Show()
        Me.Close()
    End Sub

    Private Sub BusinessNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BusinessNameTextBox.TextChanged
        If BusinessNameTextBox.Text.Length > 0 Then
            BusinessNameTextBox.BackColor = Color.White
        Else
            BusinessNameTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub BusinessPhoneMaskedTextBox_TextChanged(sender As Object, e As EventArgs)
        If BusinessPhoneMaskedTextBox.MaskFull Then
            BusinessPhoneMaskedTextBox.BackColor = Color.White
        Else
            BusinessPhoneMaskedTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub ContactNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNameTextBox.TextChanged
        If ContactNameTextBox.MaxLength > 0 Then
            ContactNameTextBox.BackColor = Color.White
        Else
            ContactNameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ContactFirstLastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactFirstLastNameTextBox.TextChanged
        If ContactFirstLastNameTextBox.Text.Length > 0 Then
            ContactFirstLastNameTextBox.BackColor = Color.White
        Else
            ContactFirstLastNameTextBox.BackColor = Color.Red
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If BusinessNameTextBox.Text.Length <= 0 Then
            BusinessNameTextBox.Focus()
            BusinessNameTextBox.BackColor = Color.Red
        ElseIf Not BusinessPhoneMaskedTextBox.MaskFull Then
            BusinessPhoneMaskedTextBox.Focus()
            BusinessPhoneMaskedTextBox.BackColor = Color.Red
        ElseIf ContactNameTextBox.Text.Length <= 0 Then
            ContactNameTextBox.Focus()
            ContactNameTextBox.BackColor = Color.Red
        ElseIf ContactFirstLastNameTextBox.Text.Length <= 0 Then
            ContactFirstLastNameTextBox.Focus()
            ContactFirstLastNameTextBox.BackColor = Color.Red
        Else
            NewSupplier.BusinessName = BusinessNameTextBox.Text
            NewSupplier.BusinessPhone = BusinessPhoneMaskedTextBox.Text
            NewSupplier.BusinessEmail = BusinessEmailTextBox.Text
            NewSupplier.ContactName = ContactNameTextBox.Text
            NewSupplier.ContactFirstLastName = ContactFirstLastNameTextBox.Text
            NewSupplier.ContactSecondLastName = ContactSecondLastNameTextBox.Text
            NewSupplier.ContactPhone = ContactPhoneMaskedTextBox.Text
            NewSupplier.AddressLineOne = AddressLineOneTextBox.Text
            NewSupplier.AddressLineTwo = AddressLineTwoTextBox.Text
            NewSupplier.City = CityTextBox.Text
            NewSupplier.Country = CountryTextBox.Text
            NewSupplier.Zipcode = ZipcodeTextBox.Text
            NewSupplier.Create(Me.SuppliersTableAdapter)
            Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
            Me.Close()
        End If
    End Sub
End Class