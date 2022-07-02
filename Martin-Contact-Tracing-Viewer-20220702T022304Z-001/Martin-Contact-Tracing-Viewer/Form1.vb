Public Class Form1
    Dim iExit As DialogResult
    Dim F_name As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_name = "C:\Users\63907\Desktop\Random\New Folder\test2\test.txt"
        If System.IO.File.Exists(F_name) = True Then

            Dim objReader As New System.IO.StreamReader(F_name)
            RichTextBox1.Text = objReader.ReadToEnd
            objReader.Close()

        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iExit = MessageBox.Show("Do you want to exit? ", "Contact Tracing Viewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
