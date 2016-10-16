Public Class TiresHome

    Private Sub CreateTireButton_Click(sender As Object, e As EventArgs) Handles CreateTireButton.Click
        CreateTire.Show()
        Me.Close()
    End Sub

    Private Sub FindTireButton_Click(sender As Object, e As EventArgs) Handles FindTireButton.Click
        FindTire.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub

    Private Sub TiresHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class