Public Class ProductsHome

    Private Sub CreateProductButton_Click(sender As Object, e As EventArgs) Handles CreateProductButton.Click
        CreateProduct.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FindProductButton_Click(sender As Object, e As EventArgs) Handles FindProductButton.Click
        FindProduct.ShowDialog()
        Me.Close()
    End Sub
End Class