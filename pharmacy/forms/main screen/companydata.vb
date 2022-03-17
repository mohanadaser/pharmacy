Imports System.Data.OleDb

Public Class companydata
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'opfd.Filter = "all images |*.PNG; *.IMG; *.JBG; *.BMP"
            OpenFileDialog1.ShowDialog()
            'pic1.Image = Image.FromFile(opfd.FileName)
            'pic1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception

        End Try
    End Sub

End Class