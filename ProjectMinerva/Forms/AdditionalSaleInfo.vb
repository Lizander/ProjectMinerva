Public Class AdditionalSaleInfo

    Private Sub AdditionalSaleInfo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PaymentTypeBox.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class