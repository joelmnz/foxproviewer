Public Class TextBoxForm

    Shared Sub ShowMessage(title As String, message As String)

        Dim f As New TextBoxForm
        f.Text = title
        f.TxtMessage.Text = message
        f.Show

    End Sub

End Class