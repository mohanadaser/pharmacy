Imports System.IO
Public Class backupvb
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim fpd As New FolderBrowserDialog
            If fpd.ShowDialog = vbOK Then
                File.Copy("data\pharmacy.accdb", fpd.SelectedPath & "\pharmacy.accdb")
                MsgBox("تم اخذ نسخه احتياطيه")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim fpd As New FolderBrowserDialog
            If fpd.ShowDialog = vbOK Then
                File.Delete("data\pharmacy.accdb")
                File.Copy(fpd.SelectedPath & "\pharmacy.accdb", "data\pharmacy.accdb")
                MsgBox("تم استرجاع النسخه الاحتياطيه")
                Application.Restart()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class