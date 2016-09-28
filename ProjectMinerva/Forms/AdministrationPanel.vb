Public Class AdministrationPanel

    Private Sub SupplierButton_Click(sender As Object, e As EventArgs) Handles SupplierButton.Click
        SuppliersHome.ShowDialog()
        Me.Close()
    End Sub

    Private Sub TireButton_Click(sender As Object, e As EventArgs) Handles TireButton.Click
        TiresHome.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ServiceButton_Click(sender As Object, e As EventArgs) Handles ServiceButton.Click
        ServicesHome.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles ProductButton.Click
        ProductsHome.ShowDialog()
        Me.Close()
    End Sub

    Private Sub CustomerButton_Click(sender As Object, e As EventArgs) Handles CustomerButton.Click
        CustomersHome.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Main.ShowDialog()
        Me.Close()
    End Sub
End Class