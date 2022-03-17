Imports System.Data.OleDb
Public Class rebuybill
    Private Function getmax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(rebuybill_id) from rebuybill ", con)
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
            redgvbuybill.CurrentRow.Cells(7).Value = Convert.ToDouble(redgvbuybill.CurrentRow.Cells(5).Value) * Convert.ToDouble(redgvbuybill.CurrentRow.Cells(6).Value)
            Dim tot As Double
            For i As Integer = 0 To redgvbuybill.Rows.Count - 1
                tot = tot + redgvbuybill.Rows(i).Cells(7).Value
            Next
            rebuybill_total.Text = tot
            rebuybill_reqired.Text = tot
            rebuybill_remaine.Text = tot
        Catch ex As Exception
        End Try
    End Sub
    Sub getdata_importers()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where import_id=" & showbuybills.dgvshowbuybill.CurrentRow.Cells(1).Value, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'Grpimporter.Visible = False
                lbladdress.Text = dt.Rows(0).Item("import_address")
                lbltel.Text = dt.Rows(0).Item("import_tel")
                lbldebt.Text = Val(dt.Rows(0).Item("import_depet"))
                lblcredit.Text = Val(dt.Rows(0).Item("import_credit"))
            End If
        Catch ex As Exception
        End Try
    End Sub
    ' save rebuybill
    Sub save_rebuybill()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from rebuybill where rebuybill_id= " & rebuybill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            Else
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("rebuybill_id") = rebuybill_id.Text
                dt.Rows(last).Item("rebuybill_date") = rebuybill_date.Text
                dt.Rows(last).Item("rebuybill_type") = recmbtype.Text
                dt.Rows(last).Item("rebuybill_importernam") = importernam.Text
                dt.Rows(last).Item("rebuybill_user") = login.cmbnam.Text
                dt.Rows(last).Item("rerebuybill_idbuy") = Val(rebuybill_idbuy.Text)
                dt.Rows(last).Item("rebuybill_total") = Val(rebuybill_total.Text)
                dt.Rows(last).Item("rebuybill_disc") = Val(rebuybill_disc.Text)
                dt.Rows(last).Item("rebuybill_tax") = 0
                dt.Rows(last).Item("rebuybill_reqired") = Val(rebuybill_reqired.Text)
                dt.Rows(last).Item("rebuybill_paid") = Val(rebuybill_paid.Text)
                dt.Rows(last).Item("rebuybill_remaine") = Val(rebuybill_remaine.Text)
            End If
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
        Catch ex As Exception

        End Try
    End Sub
    'clear buy bill
    Sub clear_bill()
        Try
            rebuybill_id.Text = getmax_id()
            rebuybill_date.Text = Now.Date.ToString("yyyy/MM/dd")
            rebuybill_user.Text = 0
            recmbtype.SelectedIndex = 0
            rebuybill_idbuy.Text = 0
            importernam.Text = ""
            rebuybill_total.Text = 0
            rebuybill_disc.Text = 0
            rebuybill_reqired.Text = 0
            rebuybill_paid.Text = 0
            rebuybill_remaine.Text = 0
            redgvbuybill.Rows.Clear()
        Catch ex As Exception
        End Try
    End Sub
    'save rebuybill details
    Sub save_rebuybill_details()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from rebuybill_details where rebuybillid_details=" & rebuybill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            End If
            For i As Integer = 0 To redgvbuybill.Rows.Count - 1
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("rebuybillid_details") = rebuybill_id.Text
                dt.Rows(last).Item("rebuybillid_item") = redgvbuybill.Rows(i).Cells(0).Value
                dt.Rows(last).Item("rebuybill_itemnam") = redgvbuybill.Rows(i).Cells(2).Value
                dt.Rows(last).Item("rebuybill_unit") = redgvbuybill.Rows(i).Cells(3).Value
                dt.Rows(last).Item("rebuybill_expiredate") = redgvbuybill.Rows(i).Cells(4).Value
                dt.Rows(last).Item("rebuybill_price_b") = redgvbuybill.Rows(i).Cells(5).Value
                dt.Rows(last).Item("rebuybill_qty") = redgvbuybill.Rows(i).Cells(6).Value
                dt.Rows(last).Item("rebuybilltotal_details") = redgvbuybill.Rows(i).Cells(7).Value
                dt.Rows(last).Item("rebuybill_idimporter") = showbuybills.dgvshowbuybill.CurrentRow.Cells(1).Value
            Next
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم حفظ الفاتوره بنجاح", MsgBoxStyle.Information, "حفظ")
            save_operimporter(showbuybills.dgvshowbuybill.CurrentRow.Cells(1).Value, importernam.Text, Label1.Text, rebuybill_date.Text, Val(rebuybill_remaine.Text), 0, "قيمة فاتورة مرتجع مشتريات :" & rebuybill_id.Text)
            update_qty()
            update_importer()
            print_rebuybill()
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
            For x As Integer = 0 To redgvbuybill.Rows.Count - 1
                da = New OleDbDataAdapter(" select * from items where id_item=" & redgvbuybill.Rows(x).Cells(0).Value, con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    dt.Rows(0).Item("qty") = dt.Rows(0).Item("qty") - redgvbuybill.Rows(x).Cells(6).Value
                End If
            Next
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            'MsgBox("تم التعديل فى جدول الاصناف")
        Catch ex As Exception

        End Try
    End Sub
    'update importer balance
    Sub update_importer()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where import_credit=" & Val(lblcredit.Text) & "", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("import_credit") = Val(dt.Rows(0).Item("import_credit")) - Val(rebuybill_remaine.Text)
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                'MsgBox("تم التعديل فى رصيد المورد")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'print rebuybill
    Sub print_rebuybill()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from rebuybill where rebuybill_id=" & rebuybill_id.Text, con)
            da.Fill(dt)
            Dim rp As New CrystalReportrebuy
            rp.SetDataSource(dt)
            reportrebuy.CrystalReportViewer1.ReportSource = rp
            reportrebuy.CrystalReportViewer1.Refresh()
            reportrebuy.CrystalReportViewer1.Zoom(100%)
            reportrebuy.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub rebuybill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            rebuybill_id.Text = getmax_id()
            rebuybill_date.Text = Now.Date.ToString("yyyy/MM/dd")
            rebuybill_user.Text = login.cmbnam.Text
            recmbtype.SelectedIndex = 0
            btnprint.Enabled = False
            getdata_importers()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub redgvbuybill_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles redgvbuybill.CellEndEdit
        calcu_dgv()
    End Sub

    Private Sub rebuybill_paid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rebuybill_paid.TextChanged
        Try
            rebuybill_remaine.Text = Val(rebuybill_reqired.Text) - Val(rebuybill_paid.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rebuybill_disc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rebuybill_disc.TextChanged
        Try
            rebuybill_reqired.Text = Val(rebuybill_total.Text) - Val(rebuybill_disc.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            redgvbuybill.Rows.RemoveAt(redgvbuybill.CurrentRow.Index)
            If redgvbuybill.Rows.Count = Nothing Then
                rebuybill_total.Text = 0
                rebuybill_reqired.Text = 0
                rebuybill_remaine.Text = 0
            Else
                calcu_dgv()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Val(rebuybill_total.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If
        If Val(rebuybill_reqired.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If
        save_rebuybill()
        save_rebuybill_details()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clear_bill()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        print_rebuybill()
    End Sub

  
End Class