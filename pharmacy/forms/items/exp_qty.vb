Imports System.Data.OleDb
Public Class exp_qty
    Sub calcudgv()
        'Try
        For i As Integer = 0 To dgvexpqty.Rows.Count - 1
            If (dgvexpqty.Rows(i).Cells(5).Value) IsNot DBNull.Value Then
                If dgvexpqty.Rows(i).Cells(5).Value >= dgvexpqty.Rows(i).Cells(4).Value Then
                    dgvexpqty.Rows(i).Cells(4).Style.BackColor = Color.Red
                End If
            End If
        Next
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub exp_qty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        calcudgv()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where (expire_date >= '" & dtpk1.Value.ToString("yyyy/MM/dd") & "') and (expire_date <= '" & dtpk2.Value.ToString("yyyy/MM/dd") & "') ", con)
            da.Fill(dt)
            dgvexpqty.AutoGenerateColumns = False
            dgvexpqty.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        load_dgv("items", dgvexpqty)
    End Sub
End Class