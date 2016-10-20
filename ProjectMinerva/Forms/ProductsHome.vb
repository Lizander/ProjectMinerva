Public Class ProductsHome

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub

    Private Sub CreateProductButton_Click_1(sender As Object, e As EventArgs) Handles CreateProductButton.Click
        CreateProduct.Show()
        Me.Close()
    End Sub

    Private Sub FindProductButton_Click(sender As Object, e As EventArgs) Handles FindProductButton.Click
        FindProduct.Show()
        Me.Close()
    End Sub
End Class