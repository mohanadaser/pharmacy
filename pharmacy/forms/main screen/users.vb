Imports System.Data.OleDb
Public Class users

    Sub update_pass()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from users where id_users=" & CInt(dgvusers.CurrentRow.Cells(0).Value), con)
            da.Fill(dt)
            Dim pos As Integer = BindingContext(dt).Position
            dt.Rows(pos).Item("user_name") = dgvusers.CurrentRow.Cells(1).Value
            dt.Rows(pos).Item("pass") = dgvusers.CurrentRow.Cells(2).Value
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم التغيير بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv("users", dgvusers)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        update_pass()
    End Sub
End Class