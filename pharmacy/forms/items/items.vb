Imports System.Data.OleDb
Imports System.Threading.Thread
Public Class items

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
    'load data in dgv
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items", con)
            da.Fill(dt)
            dgvitems.AutoGenerateColumns = False
            dgvitems.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'serch items
    Sub serch_items()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where item_name like'%" & serchtxt.Text & "%'", con)
            da.Fill(dt)
            dgvitems.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'serch barcode
    Sub serchby_barcode()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where barcode_item like'%" & serchbarcode.Text & "%'", con)
            da.Fill(dt)
            dgvitems.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'get max id
    Public Function getmax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(id_item) from items", con)
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
    'clear items
    Sub clear_items()
        Try
            id_item.Text = getmax_id()
            item_name.Text = ""
            company.Text = ""
            barcode_item.Text = ""
            limit_item.Text = "0"
            categorycmb.Text = ""
            item_unitcmb.Text = ""
            sale_price.Text = "0"
            buy_price.Text = "0"
            qty.Text = "0"
            item_expire.Text = ""
            item_name.Focus()
        Catch ex As Exception

        End Try
    End Sub
    'save items
    Sub save_items()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where id_item=" & id_item.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذا الصنف مسجل من قبل", MsgBoxStyle.Critical, "بيانات مكرره")
                clear_items()
                load_dgv()
            Else
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("id_item") = id_item.Text
                dt.Rows(last).Item("item_name") = item_name.Text
                dt.Rows(last).Item("category") = categorycmb.Text
                dt.Rows(last).Item("item_unit") = item_unitcmb.Text
                dt.Rows(last).Item("qty") = qty.Text
                dt.Rows(last).Item("company") = company.Text
                dt.Rows(last).Item("sale_price") = sale_price.Text
                dt.Rows(last).Item("buy_price") = buy_price.Text
                dt.Rows(last).Item("expire_date") = item_expire.Value.ToString("yyyy/MM/dd")
                dt.Rows(last).Item("limit_item") = limit_item.Text
                dt.Rows(last).Item("barcode_item") = barcode_item.Text

                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم حفظ البيانات بنجاح", MsgBoxStyle.Information, "تاكيد")
                save_followuser(login.cmbnam.Text, "قام باضافة صنف جديد اسمه:" & item_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                load_dgv()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'update items
    Sub update_items()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where id_item=" & id_item.Text, con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("لاتوجد بيانات لتعديلها", MsgBoxStyle.Critical, "تحذير")
                clear_items()
                load_dgv()
            Else
                Dim pos As Integer = BindingContext(dt).Position
                dt.Rows(pos).Item("id_item") = id_item.Text
                dt.Rows(pos).Item("item_name") = item_name.Text
                dt.Rows(pos).Item("category") = categorycmb.Text
                dt.Rows(pos).Item("item_unit") = item_unitcmb.Text
                dt.Rows(pos).Item("qty") = qty.Text
                dt.Rows(pos).Item("company") = company.Text
                dt.Rows(pos).Item("sale_price") = sale_price.Text
                dt.Rows(pos).Item("buy_price") = buy_price.Text
                dt.Rows(pos).Item("expire_date") = item_expire.Value.ToString("yyyy/MM/dd")
                dt.Rows(pos).Item("limit_item") = limit_item.Text
                dt.Rows(pos).Item("barcode_item") = barcode_item.Text
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم تعديل البيانات بنجاح", MsgBoxStyle.Information, "تأكيد")
                save_followuser(login.cmbnam.Text, "قام بتعديل صنف اسمه:" & item_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                load_dgv()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'delete data
    Sub delete_items()

        Try
            If MsgBox("هل تريد حذف البيانات المحدده", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                Exit Sub
            Else
                dt.Clear()
                da = New OleDbDataAdapter("select * from items where id_item=" & id_item.Text, con)
                da.Fill(dt)
                If dt.Rows.Count < 0 Then
                    MsgBox("لايوجد بيانات لحذفها", MsgBoxStyle.Critical, "تحذير")
                    Exit Sub
                Else
                    Dim pos As Integer = BindingContext(dt).Position
                    dt.Rows(pos).Delete()
                    Dim save As New OleDbCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    save_followuser(login.cmbnam.Text, "قام بحذف صنف اسمه:" & item_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                    clear_items()
                    load_dgv()
                    MsgBox("تم الحذف بنجاح", MsgBoxStyle.Information, "تأكيد الحذف")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            clear_items()
            load_dgv()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub serchtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serchtxt.TextChanged
        serch_items()
    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear_items()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If qty.Text = "" Or buy_price.Text = "" Or sale_price.Text = "" Or limit_item.Text = "" Then
            MsgBox("يجب ادخال رقم فى هذه الخانات")
            Exit Sub
        End If
        If item_name.Text = "" Or item_unitcmb.Text = "" Or categorycmb.Text = "" Then
            MsgBox("يجب ادخال بيانات فى هذه الخانات")
            Exit Sub
        End If
        save_items()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If qty.Text = "" Or buy_price.Text = "" Or sale_price.Text = "" Or limit_item.Text = "" Then
            MsgBox("يجب ادخال رقم فى هذه الخانات")
        End If
        update_items()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        delete_items()
    End Sub
    'data show in txt
    Private Sub dgvitems_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvitems.Click

        Try
            If dgvitems.CurrentRow.Cells(0).Selected = True Then
                'da = New OleDbDataAdapter("select * from items where id_item=" & dgvitems.CurrentRow.Cells(1).Value, con)
                'da.Fill(dt)
                'If dt.Rows.Count > 0 Then
                id_item.Text = dgvitems.CurrentRow.Cells(1).Value
                item_name.Text = dgvitems.CurrentRow.Cells(2).Value
                categorycmb.Text = dgvitems.CurrentRow.Cells(3).Value
                item_unitcmb.Text = dgvitems.CurrentRow.Cells(4).Value
                qty.Text = dgvitems.CurrentRow.Cells(5).Value
                company.Text = dgvitems.CurrentRow.Cells(6).Value
                sale_price.Text = dgvitems.CurrentRow.Cells(7).Value
                buy_price.Text = Convert.ToDouble(dgvitems.CurrentRow.Cells(8).Value)
                limit_item.Text = dgvitems.CurrentRow.Cells(9).Value
                item_expire.Text = dgvitems.CurrentRow.Cells(10).Value
                barcode_item.Text = dgvitems.CurrentRow.Cells(11).Value
            End If
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub serchbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serchbarcode.TextChanged
        serchby_barcode()
    End Sub

    Private Sub qty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles qty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub limit_item_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles limit_item.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub discount_item_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub buy_price_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles buy_price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub sale_price_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sale_price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class