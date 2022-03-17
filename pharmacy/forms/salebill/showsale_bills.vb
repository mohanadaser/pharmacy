Imports System.Data.OleDb
Public Class showsale_bills
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
    Sub load_dgv()
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter("select * from showsaleview", con)
            da.Fill(dt)
            dgvshowsale.AutoGenerateColumns = False
            dgvshowsale.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'prbarty name of dgv show bills
    Sub dgv_propname()
        bills_show.dgvbills_show.Columns(0).DataPropertyName = "salebillid_item"
        bills_show.dgvbills_show.Columns(1).DataPropertyName = "barcode_item"
        bills_show.dgvbills_show.Columns(2).DataPropertyName = "item_name"
        bills_show.dgvbills_show.Columns(3).DataPropertyName = "salebill_unit"
        bills_show.dgvbills_show.Columns(5).DataPropertyName = "salebill_price_s"
        bills_show.dgvbills_show.Columns(6).DataPropertyName = "salebill_qty"
        bills_show.dgvbills_show.Columns(7).DataPropertyName = "salebilltotal_details"
    End Sub
    Sub calcu_dgv()
        Dim tot As Double
        For i As Integer = 0 To dgvshowsale.Rows.Count - 1
            tot = tot + dgvshowsale.Rows(i).Cells(5).Value
        Next
        lblcount.Text = dgvshowsale.Rows.Count
        lbltotal.Text = Val(tot)
    End Sub
    Sub serch_salebill(ByVal colname As String, ByVal txtserch As TextBox)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from showsaleview where " & colname & " like'%" & txtserch.Text & "%'", con)
            da.Fill(dt)
            dgvshowsale.DataSource = dt
        Catch ex As Exception
        End Try

    End Sub

    Private Sub showsale_bills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv()
        calcu_dgv()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("select * from showsaleview where salebill_date >= '" & date_from.Value.ToString("yyyy/MM/dd") & "' and salebill_date <= '" & date_to.Value.ToString("yyyy/MM/dd") & "' ", con)
            da.Fill(dt)
            dgvshowsale.DataSource = dt
            calcu_dgv()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub id_custserch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_custserch.TextChanged
        serch_salebill("salebillid_customer", id_custserch)
        calcu_dgv()
    End Sub

    Private Sub id_salebillserch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_salebillserch.TextChanged
        serch_salebill("salebill_id", id_salebillserch)
        calcu_dgv()
    End Sub

    Private Sub custnam_serch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custnam_serch.TextChanged
        serch_salebill("cust_name", custnam_serch)
        calcu_dgv()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dgvshowsale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvshowsale.Click
        'delete data of dgv
        Try
            If dgvshowsale.CurrentRow.Cells(6).Selected = True Then
                If MsgBox("هل تريد الحذف فعلا", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Dim dt As New DataTable
                    Dim da As New OleDbDataAdapter
                    dt.Clear()
                    da = New OleDbDataAdapter("select * from salebill where salebill_id=" & dgvshowsale.CurrentRow.Cells(0).Value, con)
                    da.Fill(dt)
                    Dim x As Integer = BindingContext(dt).Position
                    dt.Rows(x).Delete()
                    Dim save As New OleDbCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    MsgBox("تم حذف البيانات", MsgBoxStyle.Information, "حذف")
                    save_followuser(login.cmbnam.Text, "قام بحذف فاتورة المبيعات رقم:" & dgvshowsale.CurrentRow.Cells(0).Value, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                    load_dgv()
                    calcu_dgv()
                Else
                    Exit Sub
                End If
            End If
            'show data dgv
            If dgvshowsale.CurrentRow.Cells(7).Selected = True Then
                bills_show.Label8.Visible = False
                bills_show.Label9.Text = "اسم البائع"
                bills_show.Button1.Text = "انشاء فاتورة مرتجع بيع"
                bills_show.dgvbills_show.Columns(4).Visible = False
                bills_show.dgvbills_show.Columns(5).HeaderText = "سعر البيع"
                'get data of salebill
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                dt.Clear()
                da = New OleDbDataAdapter(" select * from salebill where salebill_id=" & dgvshowsale.CurrentRow.Cells(0).Value, con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    bills_show.lblid.Text = dt.Rows(0).Item("salebill_id")
                    bills_show.txtdate.Text = dt.Rows(0).Item("salebill_date")
                    bills_show.txtuser.Text = dt.Rows(0).Item("salebilll_user")
                    bills_show.txttype.Text = dt.Rows(0).Item("salebill_type")
                    bills_show.txttotal.Text = dt.Rows(0).Item("salebill_total")
                    bills_show.txtdisc.Text = dt.Rows(0).Item("salebill_disc")
                    bills_show.txttax.Text = dt.Rows(0).Item("salebill_tax")
                    bills_show.txtreqierd.Text = dt.Rows(0).Item("salebill_reqired")
                    bills_show.txtpaid.Text = dt.Rows(0).Item("salebill_paid")
                    bills_show.txtremaine.Text = dt.Rows(0).Item("salebill_remaine")
                    bills_show.txtimporter.Text = dgvshowsale.CurrentRow.Cells(2).Value
                End If
                'get data of salebill details
                Dim dt1 As New DataTable
                Dim da1 As New OleDbDataAdapter
                dt.Clear()
                da1 = New OleDbDataAdapter("SELECT * from sale_detailsview where salebillid_details=" & dgvshowsale.CurrentRow.Cells(0).Value, con)
                da1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    For i As Integer = 0 To bills_show.dgvbills_show.Rows.Count - 2
                        bills_show.dgvbills_show.Rows(i).Cells(0).Value = dt1.Rows(0).Item("salebillid_item")
                        bills_show.dgvbills_show.Rows(i).Cells(1).Value = dt1.Rows(0).Item("barcode_item")
                        bills_show.dgvbills_show.Rows(i).Cells(2).Value = dt1.Rows(0).Item("item_name")
                        bills_show.dgvbills_show.Rows(i).Cells(3).Value = dt1.Rows(0).Item("salebill_unit")
                        bills_show.dgvbills_show.Rows(i).Cells(5).Value = dt1.Rows(0).Item("salebill_price_s")
                        bills_show.dgvbills_show.Rows(i).Cells(6).Value = dt1.Rows(0).Item("salebill_qty")
                        bills_show.dgvbills_show.Rows(i).Cells(7).Value = dt1.Rows(0).Item("salebilltotal_details")
                    Next
                    dgv_propname()
                    bills_show.dgvbills_show.AutoGenerateColumns = False
                    bills_show.dgvbills_show.DataSource = dt1
                    bills_show.Show()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class