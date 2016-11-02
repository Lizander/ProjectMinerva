Public Class QuantityModal
    Friend MaxQuantity As String
    Private Sub QuantityToAddNumeric_ValueChanged(sender As Object, e As EventArgs) Handles QuantityToAddNumeric.ValueChanged
        If QuantityAvailableBox.Text.Length > 0 Then
            Dim QuantityAvailable As Integer
            QuantityAvailable = Integer.Parse(QuantityAvailableBox.Text)
            If QuantityAvailable < QuantityToAddNumeric.Value Then
                QuantityToAddNumeric.BackColor = Color.Red
                SaveButton.Enabled = False
            Else
                QuantityToAddNumeric.BackColor = Color.White
                SaveButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub QuantityModal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        QuantityAvailableBox.Text = MaxQuantity
    End Sub
End Class