Public Class ServicesHome

    Private Sub CreateServiceButton_Click(sender As Object, e As EventArgs) Handles CreateServiceButton.Click
        CreateService.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FindServiceButton_Click(sender As Object, e As EventArgs) Handles FindServiceButton.Click
        FindService.ShowDialog()
        Me.Close()
    End Sub
End Class