Public Class DiscountModal

    Private Sub DiscountModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub DiscountModal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TypeBox.SelectedIndex = 0
    End Sub
End Class