Imports System.Data.OleDb
Public Class allow_users
    Public Sub clear_checks()
        Try
            cusoper.Checked = False
            itmadd.Checked = False
            users.Checked = False
            khazina.Checked = False
            cusmng.Checked = False
            cusadd.Checked = False
            impoper.Checked = False
            impmng.Checked = False
            impadd.Checked = False
            sanadatshow.Checked = False
            rebuyshow.Checked = False
            buyshow.Checked = False
            allows_users.Checked = False
            resaleshow.Checked = False
            saleshow.Checked = False
            itmmng.Checked = False
            chkfu1.Checked = False

        Catch ex As Exception

        End Try

    End Sub
    ' show data
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear_checks()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from allows_users where fullname='" & ComboBox1.Text & "' ", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cusoper.Checked = dt.Rows(0).Item("c3")
                itmadd.Checked = dt.Rows(0).Item("a1")
                users.Checked = dt.Rows(0).Item("u1")
                khazina.Checked = dt.Rows(0).Item("kh1")
                cusmng.Checked = dt.Rows(0).Item("c2")
                cusadd.Checked = dt.Rows(0).Item("c1")
                impoper.Checked = dt.Rows(0).Item("m3")
                impmng.Checked = dt.Rows(0).Item("m2")
                impadd.Checked = dt.Rows(0).Item("m1")
                sanadatshow.Checked = dt.Rows(0).Item("sf1")
                rebuyshow.Checked = dt.Rows(0).Item("rb2")
                buyshow.Checked = dt.Rows(0).Item("b1")
                allows_users.Checked = dt.Rows(0).Item("us1")
                resaleshow.Checked = dt.Rows(0).Item("rs2")
                saleshow.Checked = dt.Rows(0).Item("s1")
                itmmng.Checked = dt.Rows(0).Item("a2")
            Else
                MsgBox("لايوجد صلاحيات لهذا المستخدم")
            End If
        Catch ex As Exception

        End Try

    End Sub
    'edit data
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from allows_users where fullname='" & ComboBox1.Text & "' ", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'تعديل بيانات
                Dim pos As Integer = BindingContext(dt).Position
                dt.Rows(pos).Item("c3") = cusoper.Checked
                dt.Rows(pos).Item("a1") = itmadd.Checked
                dt.Rows(pos).Item("u1") = users.Checked
                dt.Rows(pos).Item("kh1") = khazina.Checked
                dt.Rows(pos).Item("c2") = cusmng.Checked
                dt.Rows(pos).Item("c1") = cusadd.Checked
                dt.Rows(pos).Item("m3") = impoper.Checked
                dt.Rows(pos).Item("m2") = impmng.Checked
                dt.Rows(pos).Item("m1") = impadd.Checked
                dt.Rows(pos).Item("sf1") = sanadatshow.Checked
                dt.Rows(pos).Item("rb2") = rebuyshow.Checked
                dt.Rows(pos).Item("b1") = buyshow.Checked
                dt.Rows(pos).Item("us1") = allows_users.Checked
                dt.Rows(pos).Item("rs2") = resaleshow.Checked
                dt.Rows(pos).Item("s1") = saleshow.Checked
                dt.Rows(pos).Item("a2") = itmmng.Checked
                dt.Rows(pos).Item("fu1") = chkfu1.Checked
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم التعديل بنجاح")
            End If
        Catch ex As Exception

        End Try
        'Else

        '    ''    'savedata
        '    Dim last As Integer = dt.Rows.Count - 1
        '    dt.Rows(last).Item("c3") = cusoper.Checked
        '    dt.Rows(last).Item("a1") = itmadd.Checked
        '    dt.Rows(last).Item("u1") = users.Checked
        '    dt.Rows(last).Item("kh1") = khazina.Checked
        '    dt.Rows(last).Item("c2") = cusmng.Checked
        '    dt.Rows(last).Item("c1") = cusadd.Checked
        '    dt.Rows(last).Item("m3") = impoper.Checked
        '    dt.Rows(last).Item("m2") = impmng.Checked
        '    dt.Rows(last).Item("m1") = impadd.Checked
        '    dt.Rows(last).Item("sf1") = sanadatshow.Checked
        '    dt.Rows(last).Item("rb2") = rebuyshow.Checked
        '    dt.Rows(last).Item("b1") = buyshow.Checked
        '    dt.Rows(last).Item("us1") = allows_users.Checked
        '    dt.Rows(last).Item("rs2") = resaleshow.Checked
        '    dt.Rows(last).Item("s1") = saleshow.Checked
        '    dt.Rows(last).Item("a2") = itmmng.Checked
        '    Dim save As New OleDbCommandBuilder(da)
        '    da.Update(dt)
        '    dt.AcceptChanges()
        '    MsgBox("تم الحفظ بنجاح")




    End Sub

    Private Sub ComboBox1_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDown
        load_cmb("users", "id_users", "user_name", ComboBox1)
    End Sub

    Private Sub allow_users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class