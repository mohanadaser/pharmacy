Imports System.Data.OleDb
Public Class buybill
    Private Function getmax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(buybill_id) from buybill ", con)
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
    'load cmb suppliers
    Public Sub load_cmbsupplier()
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers ", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmbnam.DataSource = dt
                cmbnam.ValueMember = "import_id"
                cmbnam.DisplayMember = "import_name"
            End If
            getdata_cmb()
        Catch ex As Exception
        End Try
    End Sub
    'get data to cmbimporter
    Sub getdata_cmb()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where import_id=" & cmbnam.SelectedValue & "", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                lbladdress.Text = dt.Rows(0).Item("import_address")
                lbltel.Text = dt.Rows(0).Item("import_tel")
                lblmadin.Text = Val(dt.Rows(0).Item("import_depet"))
                lbldaen.Text = Val(dt.Rows(0).Item("import_credit"))
                lblcode.Text = dt.Rows(0).Item("import_id")
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
            For i As Integer = 0 To dgvbuybill.Rows.Count - 1
                If serchbyid.Text = dgvbuybill.Rows(i).Cells(0).Value Then
                    MsgBox("هذا الصنف تم اختياره من قبل")
                    serchbyid.Text = ""
                    serchbyid.Focus()
                    Exit Sub
                End If
            Next
            If dt.Rows.Count > 0 Then
                dgvbuybill.Rows.Add()
                Dim last As Integer = dgvbuybill.Rows.Count - 1
                dgvbuybill.Rows(last).Cells(0).Value = dt.Rows(0).Item("id_item")
                dgvbuybill.Rows(last).Cells(1).Value = dt.Rows(0).Item("barcode_item")
                dgvbuybill.Rows(last).Cells(2).Value = dt.Rows(0).Item("item_name")
                dgvbuybill.Rows(last).Cells(3).Value = dt.Rows(0).Item("item_unit")
                dgvbuybill.Rows(last).Cells(4).Value = dt.Rows(0).Item("company")
                dgvbuybill.Rows(last).Cells(5).Value = dt.Rows(0).Item("expire_date")
                dgvbuybill.Rows(last).Cells(6).Value = dt.Rows(0).Item("sale_price")
                dgvbuybill.Rows(last).Cells(7).Value = dt.Rows(0).Item("buy_price")
                dgvbuybill.Rows(last).Cells(8).Value = 0
                dgvbuybill.Rows(last).Cells(9).Value = 0
            Else
                MsgBox("هذا الصنف غير موجود", MsgBoxStyle.Information)
            End If
            serchbyid.Text = ""
            serchbyid.Focus()
            lblno_items.Text = Convert.ToUInt32(dgvbuybill.Rows.Count)
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
            For i As Integer = 0 To dgvbuybill.Rows.Count - 1
                If serchbybarcode.Text = dgvbuybill.Rows(i).Cells(1).Value Then
                    MsgBox("هذا الصنف تم اختياره من قبل")
                    serchbybarcode.Text = ""
                    serchbybarcode.Focus()
                    Exit Sub
                End If
            Next
            If dt.Rows.Count > 0 Then
                dgvbuybill.Rows.Add()
                Dim last As Integer = dgvbuybill.Rows.Count - 1
                dgvbuybill.Rows(last).Cells(0).Value = dt.Rows(0).Item("id_item")
                dgvbuybill.Rows(last).Cells(1).Value = dt.Rows(0).Item("barcode_item")
                dgvbuybill.Rows(last).Cells(2).Value = dt.Rows(0).Item("item_name")
                dgvbuybill.Rows(last).Cells(3).Value = dt.Rows(0).Item("item_unit")
                dgvbuybill.Rows(last).Cells(4).Value = dt.Rows(0).Item("company")
                dgvbuybill.Rows(last).Cells(5).Value = dt.Rows(0).Item("expire_date")
                dgvbuybill.Rows(last).Cells(6).Value = dt.Rows(0).Item("sale_price")
                dgvbuybill.Rows(last).Cells(7).Value = dt.Rows(0).Item("buy_price")
                dgvbuybill.Rows(last).Cells(8).Value = 0
                dgvbuybill.Rows(last).Cells(9).Value = 0
            Else
                MsgBox("هذا الصنف غير موجود", MsgBoxStyle.Information)
            End If
            serchbybarcode.Text = ""
            serchbybarcode.Focus()
            lblno_items.Text = Convert.ToUInt32(dgvbuybill.Rows.Count)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'calculate dgv
    Sub calcu_dgv()
        Try
            dgvbuybill.CurrentRow.Cells(9).Value = Convert.ToDouble(dgvbuybill.CurrentRow.Cells(7).Value) * Convert.ToDouble(dgvbuybill.CurrentRow.Cells(8).Value)
            Dim tot As Double
            For i As Integer = 0 To dgvbuybill.Rows.Count - 1
                tot = tot + dgvbuybill.Rows(i).Cells(9).Value
            Next
            buybill_total.Text = tot
            buybill_reqired.Text = tot
            buybill_remaine.Text = tot
        Catch ex As Exception
        End Try
    End Sub
    'clear buy bill
    Sub clear_bill()
        Try
            buybill_id.Text = getmax_id()
            buybill_date.Text = Now.Date.ToString("yyyy/MM/dd")
            buybill_user.Text = 0
            cmbtype.SelectedIndex = 0
            nobill_supplier.Text = 0
            cmbnam.SelectedValue = 0
            buybill_total.Text = 0
            buybill_disc.Text = 0
            buybill_reqired.Text = 0
            buybill_paid.Text = 0
            buybill_remaine.Text = 0
            lblno_items.Text = 0
            dgvbuybill.Rows.Clear()
            load_cmbsupplier()
        Catch ex As Exception
        End Try
    End Sub
    ' save buybill
    Sub save_buybill()
       
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from buybill where buybill_id= " & buybill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            Else
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("buybill_id") = buybill_id.Text
                dt.Rows(last).Item("buybill_date") = buybill_date.Text
                dt.Rows(last).Item("buybill_type") = cmbtype.Text
                dt.Rows(last).Item("nobill_importer") = nobill_supplier.Text
                dt.Rows(last).Item("buybill_user") = login.cmbnam.Text
                dt.Rows(last).Item("no_items") = Val(lblno_items.Text)
                dt.Rows(last).Item("buybill_total") = Val(buybill_total.Text)
                dt.Rows(last).Item("buybill_disc") = Val(buybill_disc.Text)
                dt.Rows(last).Item("buybill_tax") = 0
                dt.Rows(last).Item("buybill_reqired") = Val(buybill_reqired.Text)
                dt.Rows(last).Item("buybill_paid") = Val(buybill_paid.Text)
                dt.Rows(last).Item("buybill_remaine") = Val(buybill_remaine.Text)
            End If
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
        Catch ex As Exception
        End Try
    End Sub
    'save buybill details
    Sub save_buybill_details()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from buybill_details where buybillid_details=" & buybill_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            End If
            For i As Integer = 0 To dgvbuybill.Rows.Count - 1
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("buybillid_details") = buybill_id.Text
                dt.Rows(last).Item("buybillid_item") = dgvbuybill.Rows(i).Cells(0).Value
                dt.Rows(last).Item("buybillid_importer") = cmbnam.SelectedValue
                dt.Rows(last).Item("buybill_unit") = dgvbuybill.Rows(i).Cells(3).Value
                dt.Rows(last).Item("buybill_company") = dgvbuybill.Rows(i).Cells(4).Value
                dt.Rows(last).Item("buybill_qty") = dgvbuybill.Rows(i).Cells(8).Value
                dt.Rows(last).Item("buybill_expiredate") = dgvbuybill.Rows(i).Cells(5).Value
                dt.Rows(last).Item("buybill_price_s") = dgvbuybill.Rows(i).Cells(6).Value
                dt.Rows(last).Item("buybill_price_b") = dgvbuybill.Rows(i).Cells(7).Value
                dt.Rows(last).Item("buybilltotal_details") = dgvbuybill.Rows(i).Cells(9).Value
            Next
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MsgBox("تم حفظ الفاتوره بنجاح", MsgBoxStyle.Information, "حفظ")
            'الحفظ فى حركة حساب المورد
            save_operimporter(cmbnam.SelectedValue, cmbnam.Text, Label1.Text, buybill_date.Text, 0, Val(buybill_remaine.Text), "قيمة فاتورة المشتريات رقم:" & buybill_id.Text)
            update_qty_price_expiredate()
            update_importer()
            payment.ShowDialog()
            print_buybill()
            btnprintbuy.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    'update qty
    Sub update_qty_price_expiredate()
        Try
            dt.Clear()
            For x As Integer = 0 To dgvbuybill.Rows.Count - 1
                da = New OleDbDataAdapter(" select * from items where id_item=" & dgvbuybill.Rows(x).Cells(0).Value, con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    dt.Rows(0).Item("qty") = dt.Rows(0).Item("qty") + dgvbuybill.Rows(x).Cells(8).Value
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
            da = New OleDbDataAdapter("select * from importers where import_id=" & lblcode.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("import_credit") = Val(dt.Rows(0).Item("import_credit")) + Val(buybill_remaine.Text)
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                'MsgBox("تم التعديل فى رصيد المورد")
                load_cmbsupplier()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'print buybill
    Sub print_buybill()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from buybill where buybill_id=" & buybill_id.Text, con)
            da.Fill(dt)
            Dim rp As New CrystalReportbuy
            rp.SetDataSource(dt)
            cryfrmbuybill.CrystalReportViewer1.ReportSource = rp
            cryfrmbuybill.CrystalReportViewer1.Refresh()
            cryfrmbuybill.CrystalReportViewer1.Zoom(100%)
            cryfrmbuybill.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub buybill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_cmbsupplier()
            buybill_id.Text = getmax_id()
            buybill_user.Text = login.cmbnam.Text
            cmbtype.SelectedIndex = 0
            buybill_date.Text = Now.Date.ToString("yyyy/MM/dd")
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
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        manage_items.ShowDialog()
        load_cmbsupplier()
    End Sub

    Private Sub dgvbuybill_CellEndEdit_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbuybill.CellEndEdit
        calcu_dgv()
    End Sub

    Private Sub buybill_paid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buybill_paid.TextChanged
        Try
            buybill_remaine.Text = Val(buybill_reqired.Text) - Val(buybill_paid.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub buybill_disc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buybill_disc.TextChanged
        Try
            buybill_reqired.Text = Val(buybill_total.Text) - Val(buybill_disc.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear_bill()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            dgvbuybill.Rows.RemoveAt(dgvbuybill.CurrentRow.Index)
            lblno_items.Text = Convert.ToUInt32(dgvbuybill.Rows.Count)
            If dgvbuybill.Rows.Count = Nothing Then
                buybill_total.Text = 0
                buybill_reqired.Text = 0
                buybill_remaine.Text = 0
            Else
                calcu_dgv()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Val(buybill_total.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If
        If Val(buybill_reqired.Text) = 0 Then
            MsgBox("لايوجد بيانات لحفظها", MsgBoxStyle.Critical, "تاكيد")
            Exit Sub
        End If

        save_buybill()
        save_buybill_details()
    End Sub

    
    Private Sub serchbyid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles serchbyid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub buybill_paid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles buybill_paid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbnam_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnam.DropDown
        getdata_cmb()
    End Sub

    Private Sub dgvbuybill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvbuybill.Click
        Try
            If dgvbuybill.Rows.Count > 0 Then
                If dgvbuybill.CurrentRow.Cells(5).Selected = True Then
                    expire_date.ShowDialog()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintbuy.Click
        print_buybill()
    End Sub

   
End Class