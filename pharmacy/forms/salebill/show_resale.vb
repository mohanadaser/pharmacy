Imports System.Data.OleDb
Public Class show_resale
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from show_resalebill", con)
            da.Fill(dt)
            dgvresaleshow.AutoGenerateColumns = False
            dgvresaleshow.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " resalebill_date >= #" & date_from.Value.ToString("yyyy/MM/dd") & "# and resalebill_date <= #" & date_to.Value.ToString("yyyy/MM/dd") & "# "
        Catch ex As Exception
        End Try
    End Sub

    Private Sub serchname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serchname.TextChanged
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = "cust_name like'%" & serchname.Text & "%'"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub serchidresale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serchidresale.TextChanged
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from show_resalebill where resalebillid_details like'%" & serchidresale.Text & "%'", con)
            da.Fill(dt)
            dgvresaleshow.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub show_resale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv()
    End Sub

    Private Sub dgvresaleshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvresaleshow.Click
        Try
            If dgvresaleshow.CurrentRow.Cells(7).Selected = True Then
                If MsgBox("هل تريد الحذف فعلا", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                    Dim dt As New DataTable
                    Dim da As New OleDbDataAdapter
                    dt.Clear()
                    da = New OleDbDataAdapter("select * from resalebill where resalebill_id=" & dgvresaleshow.CurrentRow.Cells(0).Value, con)
                    da.Fill(dt)
                    Dim x As Integer = BindingContext(dt).Position
                    dt.Rows(x).Delete()
                    Dim save As New OleDbCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    MsgBox("تم حذف البيانات", MsgBoxStyle.Information, "حذف")
                    save_followuser(login.cmbnam.Text, "قام بحذف فاتورة مرتجع المبيعات رقم:" & dgvresaleshow.CurrentRow.Cells(0).Value, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                    load_dgv()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class