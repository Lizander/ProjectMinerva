Public Class ReportsHome

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdministrationPanel.Show()
        Me.Close()
    End Sub

    Private Sub GenerateReportButton_Click(sender As Object, e As EventArgs) Handles GenerateReportButton.Click
        If ClosingRadio.Checked Then
            ClosingReport.Show()
        ElseIf PeriodRadio.Checked Then
            PeriodReport.Show()
        End If
    End Sub
End Class