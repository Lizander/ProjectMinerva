Public Class SuppliersHome

    Private Sub CreateSupplierButton_Click(sender As Object, e As EventArgs) Handles CreateSupplierButton.Click
        CreateSupplier.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FindSupplierButton_Click(sender As Object, e As EventArgs) Handles FindSupplierButton.Click
        FindSupplier.ShowDialog()
        Me.Close()
    End Sub
End Class