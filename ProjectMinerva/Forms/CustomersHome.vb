Public Class CustomersHome

    Private Sub CreateCustomerButton_Click(sender As Object, e As EventArgs) Handles CreateCustomerButton.Click
        CreateCustomer.Show()
        Me.Close()
    End Sub

    Private Sub FindCustomerButton_Click(sender As Object, e As EventArgs) Handles FindCustomerButton.Click
        FindCustomers.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub
End Class