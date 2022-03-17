Imports System.Data.OleDb
Public Class follow_user

    Private Sub follow_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv("follow_user", dgvfollow)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        load_dgv("follow_user", dgvfollow)
    End Sub

    Private Sub dgvfollow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvfollow.Click
        Try
            If dgvfollow.CurrentRow.Cells(4).Selected = True Then
                If MsgBox("هل تريد الحذف فعلا", MsgBoxStyle.OkCancel) = vbOK Then
                    Dim dt As New DataTable
                    Dim da As New OleDbDataAdapter
                    dt.Clear()
                    da = New OleDbDataAdapter("select * from follow_user where id=" & dgvfollow.CurrentRow.Cells(0).Value, con)
                    da.Fill(dt)
                    Dim pos As Integer = BindingContext(dt).Position
                    dt.Rows(pos).Delete()
                    Dim save As New OleDbCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    MsgBox("تم الحذف بنجاح")
                    load_dgv("follow_user", dgvfollow)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter("select * from follow_user where (notes_date >= '" & DateTimePicker1.Value.ToString("yyyy/MM/dd/hh:mm") & "') and (notes_date <= '" & DateTimePicker2.Value.ToString("yyyy/MM/dd/hh:mm") & "') ", con)
            da.Fill(dt)
            'If dt.Rows.Count > 0 Then
            dgvfollow.DataSource = dt
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("delete * from follow_user", con)
            da.Fill(dt)
            dgvfollow.DataSource = dt
            MsgBox("تم حذف جميع السجلات")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class