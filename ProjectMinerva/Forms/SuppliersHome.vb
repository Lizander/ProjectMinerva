Public Class SuppliersHome

    Private Sub CreateSupplierButton_Click(sender As Object, e As EventArgs) Handles CreateSupplierButton.Click
        CreateSupplier.Show()
        CreateSupplier.BringToFront()
        Me.Close()
    End Sub

    Private Sub FindSupplierButton_Click(sender As Object, e As EventArgs) Handles FindSupplierButton.Click
        FindSupplier.Show()
        FindSupplier.BringToFront()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        AdministrationPanel.BringToFront()
        Me.Close()
    End Sub

    Private Sub SuppliersHome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub
End Class