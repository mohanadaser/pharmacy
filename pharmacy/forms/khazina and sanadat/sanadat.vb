Imports System.Data.OleDb
Public Class sanadat
    Private Function gettomax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(id_sanad) from sanadat ", con)
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
    'save operation of customers and importer and update balance
    Sub save_operation()
        Try
            If from_hesab.Text = "الموردين" Then
                save_operimporter(hesab_f.SelectedValue, hesab_f.Text, Label1.Text, date_sanad.Text, Val(amount.Text), 0, notes.Text)
                update_import(hesab_f.SelectedValue, Val(amount.Text))
            ElseIf to_hesab.Text = "العملاء" Then
                save_opercust(hesab_t.SelectedValue, hesab_t.Text, Label1.Text, date_sanad.Text, 0, Val(amount.Text), notes.Text)
                update_cust(hesab_t.SelectedValue, Val(amount.Text))
            End If
        Catch ex As Exception

        End Try
    End Sub
    'save sanadat
    Sub save_data()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from sanadat where id_sanad=" & id_sanad.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذه البيانات مسجله من قبل")
                Exit Sub
            End If
            dt.Rows.Add()
            Dim last As Integer = dt.Rows.Count - 1
            dt.Rows(last).Item("id_sanad") = id_sanad.Text
            dt.Rows(last).Item("date_sanad") = date_sanad.Text
            dt.Rows(last).Item("type_sanad") = Label1.Text
            dt.Rows(last).Item("user_sanad") = user_sanad.Text
            dt.Rows(last).Item("amount") = Val(amount.Text)
            dt.Rows(last).Item("from_hesab") = from_hesab.Text
            dt.Rows(last).Item("hesab_f") = hesab_f.Text
            dt.Rows(last).Item("to_hesab") = to_hesab.Text
            dt.Rows(last).Item("hesab_t") = hesab_t.Text
            dt.Rows(last).Item("notes") = notes.Text
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            payment.ShowDialog()
            save_operation()
            MsgBox("تم الحفظ بنجاح", MsgBoxStyle.Information, "حفظ")
            clear_data()
        Catch ex As Exception

        End Try
    End Sub
    'clear data
    Sub clear_data()
        Try
            Label1.Text = "مستند النقديه"
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            id_sanad.Text = gettomax_id()
            amount.Text = 0
            notes.Text = ""
            from_hesab.Text = ""
            to_hesab.Text = ""
            hesab_f.Text = ""
            hesab_t.Text = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub sanadat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            date_sanad.Text = Now.Date.ToString("yyyy/MM/dd")
            id_sanad.Text = gettomax_id()
            user_sanad.Text = login.cmbnam.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label1.Text = "صرف النقديه"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Text = "توريد النقديه"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles from_hesab.SelectedIndexChanged
        Try
            If from_hesab.Text = "العملاء" Then
                load_cmb("customers", "cust_id", "cust_name", hesab_f)
            End If
            If from_hesab.Text = "الموردين" Then
                load_cmb("importers", "import_id", "import_name", hesab_f)
            End If
            If from_hesab.Text = "الموظفين" Then
                load_cmb("users", "id_users", "user_name", hesab_f)
            End If
            If from_hesab.Text = "الخزينه" Then
                load_cmb("khazina", "kh_id", "kh_name", hesab_f)
            End If
            If from_hesab.Text = "المصروفات" Then
                load_cmb("masrofat", "id_masrof", "masrof_name", hesab_f)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_hesab.SelectedIndexChanged
        Try
            If to_hesab.Text = "العملاء" Then
                load_cmb("customers", "cust_id", "cust_name", hesab_t)
            End If
            If to_hesab.Text = "الموردين" Then
                load_cmb("importers", "import_id", "import_name", hesab_t)
            End If
            If to_hesab.Text = "الموظفين" Then
                load_cmb("users", "id_users", "user_name", hesab_t)
            End If
            If to_hesab.Text = "الخزينه" Then
                load_cmb("khazina", "kh_id", "kh_name", hesab_t)
            End If
            If to_hesab.Text = "المصروفات" Then
                load_cmb("masrofat", "id_masrof", "masrof_name", hesab_t)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles amount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("يجب اختيار نوع الصرف اولا")
            Exit Sub
        End If
        If amount.Text = 0 Then
            MsgBox("يجب ادخال المبلغ اولا")
            Exit Sub
        End If
        If from_hesab.Text = "" Or to_hesab.Text = "" Or hesab_f.Text = "" Or hesab_t.Text = "" Then
            MsgBox("يجب ادخال اسم الحساب")
            Exit Sub
        End If
        save_data()

    End Sub
End Class