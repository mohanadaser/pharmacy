Imports System.Data.OleDb
Public Class masrofat

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub masrofat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If txtmasrof.Text = "" Then
                MsgBox("يجب ادخال اسم المصروف")
                Exit Sub
            End If
            dt.Clear()
            da = New OleDbDataAdapter("select * from masrofat", con)
            da.Fill(dt)
            dt.Rows.Add()
            Dim last As Integer = dt.Rows.Count - 1
            dt.Rows(last).Item("masrof_name") = txtmasrof.Text
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم الحفظ بنجاح")
            txtmasrof.Text = ""
            txtmasrof.Focus()

        Catch ex As Exception

        End Try
    End Sub
End Class