Imports System.Data.OleDb
Module Module1
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\data\pharmacy.accdb")
    Public da As New OleDbDataAdapter
    Public dt As New DataTable
    Public newid As Integer
    'search about data
    Public Sub serch_data(ByVal tblnam As String, ByVal colname As String, ByVal txtserch As TextBox, ByVal dgv As DataGridView)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from (" & tblnam & ") where " & colname & " like'%" & txtserch.Text & "%'", con)
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
        End Try

    End Sub
    'save operation importer
    Public Sub save_operimporter(ByVal importid As String, ByVal importname As String, ByVal opertype As String, ByVal operdate As String, ByVal opermadin As String, ByVal operdaen As String, ByVal opernotes As String)
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("select * from importer_operation", con)
            da.Fill(dt)
            dt.Rows.Add()
            Dim last As Integer = dt.Rows.Count - 1
            dt.Rows(last).Item("operimport_id") = importid
            dt.Rows(last).Item("operimport_name") = importname
            dt.Rows(last).Item("oper_type") = opertype
            dt.Rows(last).Item("oper_date") = operdate
            dt.Rows(last).Item("oper_madin") = opermadin
            dt.Rows(last).Item("oper_daen") = operdaen
            dt.Rows(last).Item("oper_notes") = opernotes
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            'MsgBox("تم الحفظ فى حركة حساب المورد")
        Catch ex As Exception

        End Try
    End Sub
    'save operation customer
    Public Sub save_opercust(ByVal custid As String, ByVal custname As String, ByVal opertype As String, ByVal operdate As String, ByVal opermadin As String, ByVal operdaen As String, ByVal opernotes As String)
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("select * from cust_operation", con)
            da.Fill(dt)
            dt.Rows.Add()
            Dim last As Integer = dt.Rows.Count - 1
            dt.Rows(last).Item("opercust_id") = custid
            dt.Rows(last).Item("opercust_name") = custname
            dt.Rows(last).Item("oper_type") = opertype
            dt.Rows(last).Item("oper_date") = operdate
            dt.Rows(last).Item("oper_madin") = opermadin
            dt.Rows(last).Item("oper_daen") = operdaen
            dt.Rows(last).Item("oper_notes") = opernotes
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            'MsgBox("تم الحفظ فى حركة حساب العميل")
        Catch ex As Exception

        End Try
    End Sub
    'load combobox
    Public Sub load_cmb(ByVal tblnam As String, ByVal idval As String, ByVal disnam As String, ByVal cmb As ComboBox)
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from " & tblnam & " ", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cmb.DataSource = dt
                cmb.ValueMember = idval
                cmb.DisplayMember = disnam
            End If
        Catch ex As Exception
        End Try
    End Sub
    'load dgv
    Public Sub load_dgv(ByVal tblnam As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter(" select * from " & tblnam & "", con)
            da.Fill(dt)
            'If dt.Rows.Count > 0 Then
            dgv.AutoGenerateColumns = False
            dgv.DataSource = dt
            'End If
        Catch ex As Exception

        End Try
    End Sub
    'update balance of khazina
    Public Sub update_khazina()

        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from khazina where kh_id= " & CInt(payment.ComboBox1.SelectedValue), con)
            da.Fill(dt)
            If dt.Rows.Count >= 0 Then
                If buybill.Label1.Text = "فاتورة المشتريات" Then
                    dt.Rows(0).Item("kh_credit") = Val(dt.Rows(0).Item("kh_credit")) - Val(buybill.buybill_paid.Text)
                End If
                If rebuybill.Label1.Text = "فاتورة مرتجع شراء" Then
                    dt.Rows(0).Item("kh_credit") = Val(dt.Rows(0).Item("kh_credit")) + Val(rebuybill.rebuybill_paid.Text)
                End If
                If salebill.Label1.Text = "فاتورة المبيعات" Then
                    dt.Rows(0).Item("kh_credit") = Val(dt.Rows(0).Item("kh_credit")) + Val(salebill.salebill_paid.Text)
                End If
                If re_salebill.Label1.Text = "فاتورة مرتجع بيع" Then
                    dt.Rows(0).Item("kh_credit") = Val(dt.Rows(0).Item("kh_credit")) - Val(re_salebill.resalebill_paid.Text)
                End If
                If sanadat.Label1.Text = "صرف النقديه" Then
                    dt.Rows(0).Item("kh_credit") = Val(dt.Rows(0).Item("kh_credit")) - Val(sanadat.amount.Text)
                End If
                If sanadat.Label1.Text = "توريد النقديه" Then
                    dt.Rows(0).Item("kh_credit") = Val(dt.Rows(0).Item("kh_credit")) + Val(sanadat.amount.Text)
                End If
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم التعديل فى الخزينه")
                payment.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub
    'update balance of credit  import
    Public Sub update_import(ByVal importnam As String, ByVal credit As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where import_id=" & importnam, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("import_credit") = dt.Rows(0).Item("import_credit") - credit
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'update balance of credit  customers
    Public Sub update_cust(ByVal custtnam As String, ByVal credit As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where cust_id=" & custtnam, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("cust_depet") = dt.Rows(0).Item("cust_depet") - credit
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'get max id function
    Public Function getmax_id(ByVal colnam As String, ByVal tblnam As String)
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(" & colnam & ") from (" & tblnam & ") ", con)
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
    'عمل صلاحيات للمستخدمين
    Public Sub make_allows(ByVal namcol As String, ByVal frm As Form)
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from allows_users where fullname='" & login.cmbnam.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("" & namcol & "") = True Then
                    frm.TopLevel = False
                    mainpage.panelmain.Controls.Clear()
                    mainpage.panelmain.Controls.Add(frm)
                    frm.BringToFront()
                    frm.Show()
                Else
                    MsgBox("ليس لديك صلاحيات")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    'عمل صلاحيات اخرى للمستخدم
    Public Sub make_allows2(ByVal namcol As String, ByVal frm As Form)
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from allows_users where fullname='" & login.cmbnam.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("" & namcol & "") = True Then
                    frm.ShowDialog()
                Else
                    MsgBox("ليس لديك صلاحيات")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    'save data in user follow 
    Public Sub save_followuser(ByVal nam As String, ByVal evnt As String, ByVal dte As String)
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from follow_user", con)
            da.Fill(dt)
            dt.Rows.Add()
            Dim last As Integer = dt.Rows.Count - 1
            dt.Rows(last).Item("username") = nam
            dt.Rows(last).Item("event") = evnt
            dt.Rows(last).Item("notes_date") = dte
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            'MsgBox("تم الحفظ فى تتبع المستخدمين")

        Catch ex As Exception

        End Try

    End Sub
End Module
