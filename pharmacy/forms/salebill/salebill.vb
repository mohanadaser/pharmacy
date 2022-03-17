Imports System.Data.OleDb
Public Class salebill
    Private Function getmax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(salebill_id) from salebill ", con)
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
    'load cmb customers
    Public Sub load_cmbcustomer()
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers ", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmbnam.DataSource = dt
                cmbnam.ValueMember = "cust_id"
                cmbnam.DisplayMember = "cust_name"
            End If
            getdata_cmb()
        Catch ex As Exception
        End Try
    End Sub
    'get data to cmbcustomer
    Sub getdata_cmb()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_id=" & cmbnam.SelectedValue & "", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                lbladdress.Text = dt.Rows(0).Item("cust_address")
                lbltel.Text = dt.Rows(0).Item("cust_tel")
                lblmadin.Text = Val(dt.Rows(0).Item("cust_depet"))
                lbldaen.Text = Val(dt.Rows(0).Item("cust_credit"))
                lblcode.Text = dt.Rows(0).Item("cust_id")
            End If
        Catch ex As Exception
        End Try
    End Sub
    'insert data bycode
    Sub getdata_bycode()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where id_item=" & serchbyid.Text, con)
            da.Fill(dt)
            For i As Integer = 0 To dgvsalebill.Rows.Count - 1
                If serchbyid.Text = dgvsalebill.Rows(i).Cells(0).Value Then
                    MsgBox("هذا الصنف تم اختياره من قبل")
                    serchbyid.Text = ""
                    serchbyid.Focus()
                    Exit Sub
                End If
            Next
            If dt.Rows.Count > 0 Then
                dgvsalebill.Rows.Add()
                Dim last As Integer = dgvsalebill.Rows.Count - 1
                dgvsalebill.Rows(last).Cells(0).Value = dt.Rows(0).Item("id_item")
                dgvsalebill.Rows(last).Cells(1).Value = dt.Rows(0).Item("barcode_item")
                dgvsalebill.Rows(last).Cells(2).Value = dt.Rows(0).Item("item_name")
                dgvsalebill.Rows(last).Cells(3).Value = dt.Rows(0).Item("item_unit")
                dgvsalebill.Rows(last).Cells(4).Value = dt.Rows(0).Item("sale_price")
                dgvsalebill.Rows(last).Cells(5).Value = 0
                dgvsalebill.Rows(last).Cells(6).Value = 0
            Else
                MsgBox("هذا الصنف غير موجود", MsgBoxStyle.Information)
            End If
            serchbyid.Text = ""
            serchbyid.Focus()
            lblno_items.Text = Convert.ToUInt32(dgvsalebill.Rows.Count)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'insert data bybarcode
    Sub getdata_bybarcode()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where barcode_item='" & serchbybarcode.Text & "'", con)
            da.Fill(dt)
            For i As Integer = 0 To dgvsalebill.Rows.Count - 1
                If serchbybarcode.Text = dgvsalebill.Rows(i).Cells(1).Value Then
                    MsgBox("هذا الصنف تم اختياره من قبل")
                    serchbybarcode.Text = ""
                    serchbybarcode.Focus()
                    Exit Sub
                End If
            Next
            If dt.Rows.Count > 0 Then
                dgvsalebill.Rows.Add()
                Dim last As Integer = dgvsalebill.Rows.Count - 1
                dgvsalebill.Rows(last).Cells(0).Value = dt.Rows(0).Item("id_item")
                dgvsalebill.Rows(last).Cells(1).Value = dt.Rows(0).Item("barcode_item")
                dgvsalebill.Rows(last).Cells(2).Value = dt.Rows(0).Item("item_name")
                dgvsalebill.Rows(last).Cells(3).Value = dt.Rows(0).Item("item_unit")
                dgvsalebill.Rows(last).Cells(4).Value = dt.Rows(0).Item("sale_price")
                dgvsalebill.Rows(last).Cells(5).Value = 0
                dgvsalebill.Rows(last).Cells(6).Value = 0
            Else
                MsgBox("هذا الصنف غير موجود", MsgBoxStyle.Information)
            End If
            serchbybarcode.Text = ""
            serchbybarcode.Focus()
            lblno_items.Text = Convert.ToUInt32(dgvsalebill.Rows.Count)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub calcu_dgv()
        Try
            dgvsalebill.CurrentRow.Cells(6).Value = Convert.ToDouble(dgvsalebill.CurrentRow.Cells(4).Value) * Convert.ToDouble(dgvsalebill.CurrentRow.Cells(5).Value)
            Dim tot As Double
            For i As Integer = 0 To dgvsalebill.Rows.Count - 1
                tot = tot + dgvsalebill.Rows(i).Cells(6).Value
            Next
            salebill_total.Text = tot
            salebill_reqired.Text = tot
            salebill_remaine.Text = tot
        Catch ex As Exception
        End Try
    End Sub
    'clear sale bill
    Sub clear_bill()
        Try
            salebill_id.Text = getmax_id()
            salebill_date.Text = Now.Date.ToString("yyyy/MM/dd")
            salebill_user.Text = 0
            cmbtype.SelectedIndex = 0
            cmbnam.SelectedValue = 0
            salebill_total.Text = 0
            salebill_disc.Text = 0
            salebill_reqired.Text = 0
            salebill_paid.Text = 0
            salebill_remaine.Text = 0
            lblno_items.Text = 0
            dgvsalebill.Rows.Clear()
            load_cmbcustomer()
        Catch ex As Exception
        End Try
    End Sub
    'qty credit limit
    Sub qty_credit()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select qty from items where id_item=" & dgvsalebill.CurrentRow.Cells(0).Value, con)
            da.Fill(dt)
            For q As Integer = 0 To dt.Rows.Count - 1
                If Val(dgvsalebill.CurrentRow.Cells(5).Value) > dt.Rows(q).Item("qty") Then
                    MsgBox("رصيد الصنف لايسمح")
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub save_salebill()

        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from salebill where salebill_id= " & salebill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            Else
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("salebill_id") = salebill_id.Text
                dt.Rows(last).Item("salebill_date") = salebill_date.Text
                dt.Rows(last).Item("salebill_type") = cmbtype.Text
                dt.Rows(last).Item("salebilll_user") = login.cmbnam.Text
                dt.Rows(last).Item("no_items") = Val(lblno_items.Text)
                dt.Rows(last).Item("salebill_total") = Val(salebill_total.Text)
                dt.Rows(last).Item("salebill_disc") = Val(salebill_disc.Text)
                dt.Rows(last).Item("salebill_tax") = 0
                dt.Rows(last).Item("salebill_reqired") = Val(salebill_reqired.Text)
                dt.Rows(last).Item("salebill_paid") = Val(salebill_paid.Text)
                dt.Rows(last).Item("salebill_remaine") = Val(salebill_remaine.Text)
            End If
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            'MsgBox("تم حفظ الفاتوره بنجاح", MsgBoxStyle.Information, "حفظ")
        Catch ex As Exception
        End Try
    End Sub
    'save salebill details
    Sub save_salebill_details()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from salebill_details where salebillid_details=" & salebill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            End If
            For i As Integer = 0 To dgvsalebill.Rows.Count - 1
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("salebillid_details") = salebill_id.Text
                dt.Rows(last).Item("salebillid_item") = dgvsalebill.Rows(i).Cells(0).Value
                dt.Rows(last).Item("salebillid_customer") = cmbnam.SelectedValue
                dt.Rows(last).Item("salebill_unit") = dgvsalebill.Rows(i).Cells(3).Value
                dt.Rows(last).Item("salebill_qty") = dgvsalebill.Rows(i).Cells(5).Value
                dt.Rows(last).Item("salebill_price_s") = dgvsalebill.Rows(i).Cells(4).Value
                dt.Rows(last).Item("salebilltotal_details") = dgvsalebill.Rows(i).Cells(6).Value
            Next
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم حفظ الفاتوره بنجاح", MsgBoxStyle.Information, "حفظ")
            'الحفظ فى حركة حساب العميل
            save_opercust(cmbnam.SelectedValue, cmbnam.Text, Label1.Text, salebill_date.Text, Val(salebill_remaine.Text), 0, "قيمة فاتورة المبيعات رقم:" & salebill_id.Text)
            update_qty()
            update_customer()
            payment.ShowDialog()
            print_salebill()
            btnprintbuy.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    'update qty
    Sub update_qty()
        Try
            dt.Clear()
            For x As Integer = 0 To dgvsalebill.Rows.Count - 1
                da = New OleDbDataAdapter(" select * from items where id_item=" & dgvsalebill.Rows(x).Cells(0).Value, con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    dt.Rows(0).Item("qty") = dt.Rows(0).Item("qty") - dgvsalebill.Rows(x).Cells(5).Value
                End If
            Next
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            'MsgBox("تم التعديل فى جدول الاصناف")
        Catch ex As Exception

        End Try
    End Sub
    'update customer balance
    Sub update_customer()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_id=" & lblcode.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("cust_depet") = Val(dt.Rows(0).Item("cust_depet")) + Val(salebill_remaine.Text)
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                'MsgBox("تم التعديل فى رصيد العميل")
                load_cmbcustomer()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'print salebill
    Sub print_salebill()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from salebill where salebill_id=" & salebill_id.Text, con)
            da.Fill(dt)
            Dim rp As New CrystalRepsalebill
            rp.SetDataSource(dt)
            reportsalebill.CrystalReportViewer1.ReportSource = rp
            reportsalebill.CrystalReportViewer1.Refresh()
            reportsalebill.CrystalReportViewer1.Zoom(100%)
            reportsalebill.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub salebill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_cmbcustomer()
            salebill_id.Text = getmax_id()
            salebill_user.Text = login.cmbnam.Text
            cmbtype.SelectedIndex = 0
            salebill_date.Text = Now.Date.ToString("yyyy/MM/dd")
            btnprintbuy.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbnam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnam.SelectedIndexChanged
        getdata_cmb()
    End Sub

    Private Sub serchbyid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles serchbyid.KeyDown
        If e.KeyCode = Keys.Enter Then
            getdata_bycode()
        End If
    End Sub

   
    Private Sub serchbybarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles serchbybarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            getdata_bybarcode()
        End If
    End Sub

    Private Sub dgvsalebill_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsalebill.CellEndEdit
        qty_credit()
        calcu_dgv()
    End Sub

    Private Sub salebill_paid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salebill_paid.TextChanged
        Try
            salebill_remaine.Text = Val(salebill_reqired.Text) - Val(salebill_paid.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub salebill_disc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salebill_disc.TextChanged
        Try
            salebill_reqired.Text = Val(salebill_total.Text) - Val(salebill_disc.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub salebill_disc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salebill_paid.KeyPress, salebill_disc.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub serchbyid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles serchbyid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear_bill()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Val(salebill_total.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If
        If Val(salebill_reqired.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If
        save_salebill()
        save_salebill_details()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            dgvsalebill.Rows.RemoveAt(dgvsalebill.CurrentRow.Index)
            lblno_items.Text = Convert.ToUInt32(dgvsalebill.Rows.Count)
            If dgvsalebill.Rows.Count = Nothing Then
                salebill_total.Text = 0
                salebill_reqired.Text = 0
                salebill_remaine.Text = 0
            Else
                calcu_dgv()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprintbuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintbuy.Click
        print_salebill()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        items_show.ShowDialog()
        load_cmbcustomer()
    End Sub
End Class