Imports System.Data.OleDb
Public Class newcustomers
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers", con)
            da.Fill(dt)
            dgvcust.AutoGenerateColumns = False
            dgvcust.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function gettomax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(cust_id) from customers ", con)
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
    Sub save_data()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_id=" & cust_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذا العميل مسجل من قبل", MsgBoxStyle.Critical, "بيانات مكرره")
                clear_data()
                load_dgv()
            Else
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("cust_id") = cust_id.Text
                dt.Rows(last).Item("cust_name") = cust_name.Text
                dt.Rows(last).Item("cust_tel") = cust_tel.Text
                dt.Rows(last).Item("cust_address") = cust_address.Text
                dt.Rows(last).Item("cust_depet") = cust_depit.Text
                dt.Rows(last).Item("cust_credit") = cust_credit.Text
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم حفظ البيانات بنجاح", MsgBoxStyle.Information, "تاكيد")
                save_followuser(login.cmbnam.Text, "قام باضافة عميل جديد اسمه:" & cust_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                load_dgv()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear_data()
        Try
            cust_id.Text = gettomax_id()
            cust_name.Text = ""
            cust_tel.Text = ""
            cust_address.Text = ""
            cust_credit.Text = "0,0"
            cust_depit.Text = "0,0"
            cust_name.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Sub update_data()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_id=" & cust_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("لايوجد بيانات لتعديلها", MsgBoxStyle.Critical, "تحذير")
                clear_data()
                load_dgv()
            Else
                Dim pos As Integer = BindingContext(dt).Position
                dt.Rows(pos).Item("cust_id") = cust_id.Text
                dt.Rows(pos).Item("cust_name") = cust_name.Text
                dt.Rows(pos).Item("cust_tel") = cust_tel.Text
                dt.Rows(pos).Item("cust_address") = cust_address.Text
                dt.Rows(pos).Item("cust_depet") = cust_depit.Text
                dt.Rows(pos).Item("cust_credit") = cust_credit.Text
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم تعديل البيانات بنجاح", MsgBoxStyle.Information, "تاكيد")
                save_followuser(login.cmbnam.Text, "قام بتعديل بيانات عميل اسمه:" & cust_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                load_dgv()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub delete_data()
        Try
            If MsgBox("هل تريد حذف البيانات المحدده", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                Exit Sub
                load_dgv()
            Else
                dt.Clear()
                da = New OleDbDataAdapter("select * from customers where cust_id=" & cust_id.Text, con)
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
                    save_followuser(login.cmbnam.Text, "قام بحذف عميل اسمه:" & cust_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                    clear_data()
                    load_dgv()
                    MsgBox("تم الحذف بنجاح", MsgBoxStyle.Information, "تأكيد الحذف")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub serch_byname()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_name like'%" & serchcust.Text & "%'", con)
            da.Fill(dt)
            dgvcust.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub newcustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear_data()
        load_dgv()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear_data()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        save_data()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        update_data()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        delete_data()
        clear_data()
    End Sub

    Private Sub serchcust_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serchcust.TextChanged
        serch_byname()
    End Sub

    Private Sub dgvcust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvcust.Click
        Try
            If dgvcust.CurrentRow.Cells(0).Selected = True Then
                cust_id.Text = dgvcust.CurrentRow.Cells(1).Value
                cust_name.Text = dgvcust.CurrentRow.Cells(2).Value
                cust_tel.Text = dgvcust.CurrentRow.Cells(3).Value
                cust_address.Text = dgvcust.CurrentRow.Cells(4).Value
                cust_depit.Text = dgvcust.CurrentRow.Cells(5).Value
                cust_credit.Text = dgvcust.CurrentRow.Cells(6).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cust_depit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cust_depit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cust_credit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cust_credit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class