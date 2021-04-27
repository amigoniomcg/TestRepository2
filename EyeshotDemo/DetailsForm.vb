Public Class DetailsForm

    Private Sub closeButton_Click(sender As System.Object, e As System.EventArgs) Handles closeButton.Click
        ''4
        Close()
    End Sub

    Private Sub copyToClipboardButton_Click(sender As Object, e As EventArgs) Handles copyToClipboardButton.Click
        Clipboard.SetText(contentTextBox.Text)
    End Sub
End Class
