Public Class Form1
    Private Sub pictureBoxViewer_Click(sender As Object, e As EventArgs) Handles pictureBoxViewer.Click

    End Sub

    Private Sub btnSelectPicture_Click(sender As Object, e As EventArgs) Handles btnSelectPicture.Click

        If (ofPictureFileDialog.ShowDialog = DialogResult.OK) Then
            pictureBoxViewer.Image = Image.FromFile(ofPictureFileDialog.FileName)
            Me.Text = "Picture Viewer(" & ofPictureFileDialog.FileName & ")"
        End If
    End Sub
End Class
