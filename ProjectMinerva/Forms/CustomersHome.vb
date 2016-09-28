Public Class CustomersHome

    Private Sub CreateCustomerButton_Click(sender As Object, e As EventArgs) Handles CreateCustomerButton.Click
        CreateCustomer.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FindCustomerButton_Click(sender As Object, e As EventArgs) Handles FindCustomerButton.Click
        FindCustomers.ShowDialog()
        Me.Close()
    End Sub
End Class