Public Class TiresHome

    Private Sub CreateTireButton_Click(sender As Object, e As EventArgs) Handles CreateTireButton.Click
        CreateTire.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FindTireButton_Click(sender As Object, e As EventArgs) Handles FindTireButton.Click
        FindTire.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub
End Class