Public Class AdministrationPanel

    Private Sub SupplierButton_Click(sender As Object, e As EventArgs) Handles SupplierButton.Click
        SuppliersHome.Show()
        Me.Close()
    End Sub

    Private Sub TireButton_Click(sender As Object, e As EventArgs) Handles TireButton.Click
        TiresHome.Show()
        Me.Close()
    End Sub

    Private Sub ServiceButton_Click(sender As Object, e As EventArgs) Handles ServiceButton.Click
        ServicesHome.Show()
        Me.Close()
    End Sub

    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles ProductButton.Click
        ProductsHome.Show()
        Me.Close()
    End Sub

    Private Sub CustomerButton_Click(sender As Object, e As EventArgs) Handles CustomerButton.Click
        CustomersHome.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub AdministrationPanel_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub

    Private Sub UserButton_Click(sender As Object, e As EventArgs) Handles UserButton.Click
        UserManagement.Show()
        Me.Close()
    End Sub

    Private Sub SaleButton_Click(sender As Object, e As EventArgs) Handles SaleButton.Click
        SearchSales.Show()
        Me.Close()
    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        ReportsHome.Show()
        Me.Close()
    End Sub
End Class