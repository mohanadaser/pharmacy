Imports System.Data.OleDb
Public Class re_salebill
    Private Function getmax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(resalebill_id) from resalebill ", con)
            da.Fill(dt)
            If IsDBNull(dt(0)(0)) = True Then
                newid = 1
            Else
                newid = dt(0)(0) + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return newid
    End Function
    Sub calcu_dgv()
        Try
            redgvsalebill.CurrentRow.Cells(6).Value = Convert.ToDouble(redgvsalebill.CurrentRow.Cells(4).Value) * Convert.ToDouble(redgvsalebill.CurrentRow.Cells(5).Value)
            Dim tot As Double
            For i As Integer = 0 To redgvsalebill.Rows.Count - 1
                tot = tot + redgvsalebill.Rows(i).Cells(6).Value
            Next
            resalebill_total.Text = tot
            resalebill_reqired.Text = tot
            resalebill_remaine.Text = tot
        Catch ex As Exception
        End Try
    End Sub
    Sub qty_credit()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select qty from items where id_item=" & redgvsalebill.CurrentRow.Cells(0).Value, con)
            da.Fill(dt)
            For q As Integer = 0 To dt.Rows.Count - 1
                If Val(redgvsalebill.CurrentRow.Cells(5).Value) > dt.Rows(q).Item("qty") Then
                    MsgBox("رصيد الصنف لايسمح")
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub getdata_customers()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_id=" & showsale_bills.dgvshowsale.CurrentRow.Cells(1).Value, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'Grpimporter.Visible = False
                lbladdress.Text = dt.Rows(0).Item("cust_address")
                lbltel.Text = dt.Rows(0).Item("cust_tel")
                lbldebt.Text = Val(dt.Rows(0).Item("cust_depet"))
                lblcredit.Text = Val(dt.Rows(0).Item("cust_credit"))
            End If
        Catch ex As Exception
        End Try
    End Sub
    'clear resale bill
    Sub clear_bill()
        Try
            resalebill_id.Text = getmax_id()
            resalebill_date.Text = Now.Date.ToString("yyyy/MM/dd")
            resalebill_user.Text = 0
            recmbtype.SelectedIndex = 0
            resalebill_idsale.Text = 0
            custnam.Text = ""
            resalebill_total.Text = 0
            resalebill_disc.Text = 0
            resalebill_reqired.Text = 0
            resalebill_paid.Text = 0
            resalebill_remaine.Text = 0
            redgvsalebill.Rows.Clear()
        Catch ex As Exception
        End Try
    End Sub
    ' save resalebill
    Sub save_resalebill()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from resalebill where resalebill_id= " & resalebill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            Else
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("resalebill_id") = resalebill_id.Text
                dt.Rows(last).Item("resalebill_date") = resalebill_date.Text
                dt.Rows(last).Item("resalebill_type") = recmbtype.Text
                dt.Rows(last).Item("resalebill_custnam") = custnam.Text
                dt.Rows(last).Item("resalebill_user") = login.cmbnam.Text
                dt.Rows(last).Item("resalebill_idsale") = Val(resalebill_idsale.Text)
                dt.Rows(last).Item("resalebill_total") = Val(resalebill_total.Text)
                dt.Rows(last).Item("resalebill_disc") = Val(resalebill_disc.Text)
                dt.Rows(last).Item("resalebill_tax") = 0
                dt.Rows(last).Item("resalebill_reqired") = Val(resalebill_reqired.Text)
                dt.Rows(last).Item("resalebill_paid") = Val(resalebill_paid.Text)
                dt.Rows(last).Item("resalebill_remaine") = Val(resalebill_remaine.Text)
            End If
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
        Catch ex As Exception

        End Try
    End Sub
    'save resalebill details
    Sub save_resalebill_details()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from resalebill_details where resalebillid_details=" & resalebill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            End If
            For i As Integer = 0 To redgvsalebill.Rows.Count - 1
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("resalebillid_details") = resalebill_id.Text
                dt.Rows(last).Item("resalebillid_item") = redgvsalebill.Rows(i).Cells(0).Value
                dt.Rows(last).Item("resalebill_itemnam") = redgvsalebill.Rows(i).Cells(2).Value
                dt.Rows(last).Item("resalebill_unit") = redgvsalebill.Rows(i).Cells(3).Value
                dt.Rows(last).Item("resalebill_price_s") = redgvsalebill.Rows(i).Cells(4).Value
                dt.Rows(last).Item("resalebill_qty") = redgvsalebill.Rows(i).Cells(5).Value
                dt.Rows(last).Item("resalebilltotal_details") = redgvsalebill.Rows(i).Cells(6).Value
                dt.Rows(last).Item("resalebill_idcust") = showsale_bills.dgvshowsale.CurrentRow.Cells(1).Value
            Next
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم حفظ الفاتوره بنجاح", MsgBoxStyle.Information, "حفظ")
            'الحفظ فى حركة حساب العميل
            save_opercust(showsale_bills.dgvshowsale.CurrentRow.Cells(1).Value, custnam.Text, Label1.Text, resalebill_date.Text, 0, Val(resalebill_remaine.Text), "قيمة فاتورةمرتجع المبيعات رقم:" & resalebill_id.Text)
            update_qty()
            update_customer()
            print_resalebill()
            payment.ShowDialog()
            btnprint.Enabled = True
            showbuybills.Close()
            bills_show.Close()
        Catch ex As Exception

        End Try
    End Sub
    'update qty
    Sub update_qty()
        Try
            dt.Clear()
            For x As Integer = 0 To redgvsalebill.Rows.Count - 1
                da = New OleDbDataAdapter(" select * from items where id_item=" & redgvsalebill.Rows(x).Cells(0).Value, con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    dt.Rows(0).Item("qty") = dt.Rows(0).Item("qty") + redgvsalebill.Rows(x).Cells(5).Value
                End If
            Next
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم التعديل فى جدول الاصناف")
        Catch ex As Exception

        End Try
    End Sub
    'update customer balance
    Sub update_customer()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_depet=" & Val(lbldebt.Text) & "", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("cust_depet") = Val(dt.Rows(0).Item("cust_depet")) - Val(resalebill_remaine.Text)
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم التعديل فى رصيد العميل")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub print_resalebill()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from resalebill where resalebill_id=" & resalebill_id.Text, con)
            da.Fill(dt)
            Dim rp As New CrystalResale
            rp.SetDataSource(dt)
            resalereport.CrystalReportViewer1.ReportSource = rp
            resalereport.CrystalReportViewer1.Refresh()
            resalereport.CrystalReportViewer1.Zoom(100%)
            resalereport.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub re_salebill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            resalebill_id.Text = getmax_id()
            resalebill_date.Text = Now.Date.ToString("yyyy/MM/dd")
            resalebill_user.Text = login.cmbnam.Text
            recmbtype.SelectedIndex = 0
            btnprint.Enabled = False
            getdata_customers()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub redgvsalebill_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles redgvsalebill.CellEndEdit
        qty_credit()
        calcu_dgv()
    End Sub

    Private Sub resalebill_paid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resalebill_paid.TextChanged
        Try
            resalebill_remaine.Text = Val(resalebill_reqired.Text) - Val(resalebill_paid.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub resalebill_disc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resalebill_disc.TextChanged
        Try
            resalebill_reqired.Text = Val(resalebill_total.Text) - Val(resalebill_disc.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            redgvsalebill.Rows.RemoveAt(redgvsalebill.CurrentRow.Index)
            If redgvsalebill.Rows.Count = Nothing Then
                resalebill_total.Text = 0
                resalebill_reqired.Text = 0
                resalebill_remaine.Text = 0
            Else
                calcu_dgv()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Val(resalebill_total.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If
        If Val(resalebill_reqired.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If
        save_resalebill()
        save_resalebill_details()
    End Sub
End Class