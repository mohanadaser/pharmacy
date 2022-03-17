Imports System.Data.OleDb
Public Class showbuybills
    Sub serch_buybill(ByVal colname As String, ByVal txtserch As TextBox)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from showbuybill_q where " & colname & " like'%" & txtserch.Text & "%'", con)
            da.Fill(dt)
            dgvshowbuybill.DataSource = dt
        Catch ex As Exception
        End Try

    End Sub
    Sub calcu_dgv()
        Try
            Dim tot As Double
            For i As Integer = 0 To dgvshowbuybill.Rows.Count - 1
                tot = tot + dgvshowbuybill.Rows(i).Cells(5).Value
            Next
            lblcount.Text = dgvshowbuybill.Rows.Count
            lbltotal.Text = Val(tot)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from showbuybill_q", con)
            da.Fill(dt)
            dgvshowbuybill.AutoGenerateColumns = False
            dgvshowbuybill.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub showbuybills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv()
        calcu_dgv()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        serch_buybill("import_name", TextBox1)
        calcu_dgv()

    End Sub

    Private Sub id_importserch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_importserch.TextChanged
        serch_buybill("import_id", id_importserch)
        calcu_dgv()
    End Sub

    Private Sub id_buybillserch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_buybillserch.TextChanged
        serch_buybill("buybillid_details", id_buybillserch)
        calcu_dgv()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = " buybill_date >= #" & date_from.Value.ToString("yyyy/MM/dd") & "# and buybill_date <= #" & date_to.Value.ToString("yyyy/MM/dd") & "# "
            calcu_dgv()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvshowbuybill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvshowbuybill.Click
        Try
            If dgvshowbuybill.CurrentRow.Cells(6).Selected = True Then
                'get data of buybill
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                dt.Clear()
                da = New OleDbDataAdapter(" select * from buybill where buybill_id=" & dgvshowbuybill.CurrentRow.Cells(0).Value, con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    bills_show.lblid.Text = dt.Rows(0).Item("buybill_id")
                    bills_show.txtdate.Text = dt.Rows(0).Item("buybill_date")
                    bills_show.txtuser.Text = dt.Rows(0).Item("buybill_user")
                    bills_show.txttype.Text = dt.Rows(0).Item("buybill_type")
                    bills_show.txtnobill.Text = dt.Rows(0).Item("nobill_importer")
                    bills_show.txttotal.Text = dt.Rows(0).Item("buybill_total")
                    bills_show.txtdisc.Text = dt.Rows(0).Item("buybill_disc")
                    bills_show.txttax.Text = dt.Rows(0).Item("buybill_tax")
                    bills_show.txtreqierd.Text = dt.Rows(0).Item("buybill_reqired")
                    bills_show.txtpaid.Text = dt.Rows(0).Item("buybill_paid")
                    bills_show.txtremaine.Text = dt.Rows(0).Item("buybill_remaine")
                    bills_show.txtimporter.Text = dgvshowbuybill.CurrentRow.Cells(2).Value
                End If
                'get data of buybill details
                Dim dt1 As New DataTable
                Dim da1 As New OleDbDataAdapter
                dt.Clear()
                da1 = New OleDbDataAdapter("SELECT * from q_details where buybillid_details=" & dgvshowbuybill.CurrentRow.Cells(0).Value, con)
                da1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    For i As Integer = 0 To bills_show.dgvbills_show.Rows.Count - 2
                        bills_show.dgvbills_show.Rows(i).Cells(0).Value = dt1.Rows(0).Item("buybillid_item")
                        bills_show.dgvbills_show.Rows(i).Cells(1).Value = dt1.Rows(0).Item("barcode_item")
                        bills_show.dgvbills_show.Rows(i).Cells(2).Value = dt1.Rows(0).Item("item_name")
                        bills_show.dgvbills_show.Rows(i).Cells(3).Value = dt1.Rows(0).Item("buybill_unit")
                        bills_show.dgvbills_show.Rows(i).Cells(4).Value = dt1.Rows(0).Item("buybill_expiredate")
                        bills_show.dgvbills_show.Rows(i).Cells(5).Value = dt1.Rows(0).Item("buybill_price_b")
                        bills_show.dgvbills_show.Rows(i).Cells(6).Value = dt1.Rows(0).Item("buybill_qty")
                        bills_show.dgvbills_show.Rows(i).Cells(7).Value = dt1.Rows(0).Item("buybilltotal_details")
                    Next
                    bills_show.dgvbills_show.AutoGenerateColumns = False
                    bills_show.dgvbills_show.DataSource = dt1
                    bills_show.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'delete dgv
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("هل تريد الحذف فعلا", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from buybill where buybill_id=" & dgvshowbuybill.CurrentRow.Cells(0).Value, con)
            da.Fill(dt)
            Dim x As Integer = BindingContext(dt).Position
            dt.Rows(x).Delete()
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم حذف البيانات", MsgBoxStyle.Information, "حذف")
            save_followuser(login.cmbnam.Text, "قام بحذف فاتورة المشتريات رقم:" & dgvshowbuybill.CurrentRow.Cells(0).Value, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
            load_dgv()
            calcu_dgv()
        Else
            Exit Sub
        End If
    End Sub
End Class