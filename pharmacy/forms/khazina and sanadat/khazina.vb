Imports System.Data.OleDb
Public Class khazina
    ' clear data
    Sub clear_data()
        Try
            kh_id.Text = getmax_id("kh_id", "khazina")
            kh_name.Text = ""
            kh_credit.Text = ""
        Catch ex As Exception
        End Try
    End Sub
    ' save data
    Sub save_data()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from khazina where kh_id=" & CInt(kh_id.Text), con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("kh_id") = kh_id.Text
                dt.Rows(last).Item("kh_name") = kh_name.Text
                dt.Rows(last).Item("kh_credit") = kh_credit.Text
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم حفظ البيانات", MsgBoxStyle.Information, "حفظ")
                load_dgv("khazina", dgvkhazina)
            ElseIf dt.Rows.Count > 0 Then
                Dim pos As Integer = BindingContext(dt).Position
                dt.Rows(pos).Item("kh_name") = kh_name.Text
                dt.Rows(pos).Item("kh_credit") = kh_credit.Text
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم تعديل البيانات", MsgBoxStyle.Information, "التعديل")
                load_dgv("khazina", dgvkhazina)
            End If
        Catch ex As Exception

        End Try
    End Sub
    ' delete data
    Sub delete_data()
        Try
            If MsgBox("هل تريد الحذف فعلا", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                dt.Clear()
                da = New OleDbDataAdapter("select * from khazina where kh_id=" & CInt(kh_id.Text), con)
                da.Fill(dt)
                If dt.Rows.Count < 0 Then
                    Exit Sub
                Else
                    Dim x As Integer = BindingContext(dt).Position
                    dt.Rows(x).Delete()

                    Dim save As New OleDbCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    MsgBox("تم حذف البيانات", MsgBoxStyle.Information, "حذف")
                    load_dgv("khazina", dgvkhazina)
                    clear_data()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub khazina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kh_id.Text = getmax_id("kh_id", "khazina")
        load_dgv("khazina", dgvkhazina)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
    'button save
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        save_data()
        clear_data()
    End Sub
    'show data in dgv
    Private Sub dgvkhazina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvkhazina.Click
        Try
            If dgvkhazina.CurrentRow.Cells(3).Selected = True Then
                kh_id.Text = dgvkhazina.CurrentRow.Cells(0).Value
                kh_name.Text = dgvkhazina.CurrentRow.Cells(1).Value
                kh_credit.Text = dgvkhazina.CurrentRow.Cells(2).Value
            End If
        Catch ex As Exception

        End Try
    End Sub
    'button data
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        delete_data()
        clear_data()
    End Sub

    Private Sub kh_credit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kh_credit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class