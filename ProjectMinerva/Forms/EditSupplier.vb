Public Class EditSupplier
    Friend OriginalSupplier As New Supplier
    Friend EditedSupplier As New Supplier

    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub


    Private Sub SuppliersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)

    End Sub

    Private Sub EditSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JupiterDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.JupiterDataSet.Suppliers)

    End Sub

    Private Sub EditSupplier_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        BusinessNameTextBox.Text = OriginalSupplier.BusinessName
        BusinessPhoneMaskedTextBox.Text = OriginalSupplier.BusinessPhone
        BusinessEmailTextBox.Text = OriginalSupplier.BusinessEmail
        ContactNameTextBox.Text = OriginalSupplier.ContactName
        ContactFirstLastNameTextBox.Text = OriginalSupplier.ContactFirstLastName
        ContactSecondLastNameTextBox.Text = OriginalSupplier.ContactSecondLastName
        ContactPhoneMaskedTextBox.Text = OriginalSupplier.ContactPhone
        AddressLineOneTextBox.Text = OriginalSupplier.AddressLineOne
        AddressLineTwoTextBox.Text = OriginalSupplier.AddressLineTwo
        CityTextBox.Text = OriginalSupplier.City
        CountryTextBox.Text = OriginalSupplier.Country
        ZipcodeTextBox.Text = OriginalSupplier.Zipcode
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
            EditedSupplier.BusinessName = BusinessNameTextBox.Text
            EditedSupplier.BusinessPhone = BusinessPhoneMaskedTextBox.Text
            EditedSupplier.BusinessEmail = BusinessEmailTextBox.Text
            EditedSupplier.ContactName = ContactNameTextBox.Text
            EditedSupplier.ContactFirstLastName = ContactFirstLastNameTextBox.Text
            EditedSupplier.ContactSecondLastName = ContactSecondLastNameTextBox.Text
            EditedSupplier.ContactPhone = ContactPhoneMaskedTextBox.Text
            EditedSupplier.AddressLineOne = AddressLineOneTextBox.Text
            EditedSupplier.AddressLineTwo = AddressLineTwoTextBox.Text
            EditedSupplier.City = CityTextBox.Text
            EditedSupplier.Country = CountryTextBox.Text
            EditedSupplier.Zipcode = ZipcodeTextBox.Text
            If EditedSupplier.IsSame(OriginalSupplier) Then
                MessageBox.Show("No changes were necessary.", "Edit Supplier - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FindSupplier.Show()
                Me.Close()
            Else
                EditedSupplier.ID = OriginalSupplier.ID
                EditedSupplier.Update(Me.SuppliersTableAdapter)
                If EditedSupplier.Saved() Then
                    Me.TableAdapterManager.UpdateAll(Me.JupiterDataSet)
                    MessageBox.Show("Your changes were saved.", "Edit Supplier - Project Minerva", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FindSupplier.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class