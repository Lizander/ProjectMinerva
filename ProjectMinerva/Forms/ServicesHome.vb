Public Class ServicesHome

    Private Sub CreateServiceButton_Click(sender As Object, e As EventArgs) Handles CreateServiceButton.Click
        CreateService.Show()
        Me.Close()
    End Sub

    Private Sub FindServiceButton_Click(sender As Object, e As EventArgs) Handles FindServiceButton.Click
        FindService.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub
End Class