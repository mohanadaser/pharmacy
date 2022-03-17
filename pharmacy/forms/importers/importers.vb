Imports System.Data.OleDb
Public Class importers
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers", con)
            da.Fill(dt)
            dgvimporters.AutoGenerateColumns = False
            dgvimporters.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function gettomax_id()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select max(import_id) from importers ", con)
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
    Sub clear_data()
        Try
            import_id.Text = gettomax_id()
            import_name.Text = ""
            import_tel.Text = ""
            import_address.Text = ""
            import_credit.Text = "0,0"
            import_depit.Text = "0,0"
            import_name.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Sub save_data()
        If import_name.Text = "" And import_address.Text = "" And import_tel.Text = "" Then
            MsgBox("يجب تعبئة هذه البيانات")
            Exit Sub
        End If
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where import_id=" & import_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("هذا العميل مسجل من قبل", MsgBoxStyle.Critical, "بيانات مكرره")
                clear_data()
                load_dgv()
            Else
                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1
                dt.Rows(last).Item("import_id") = import_id.Text
                dt.Rows(last).Item("import_name") = import_name.Text
                dt.Rows(last).Item("import_tel") = import_tel.Text
                dt.Rows(last).Item("import_address") = import_address.Text
                dt.Rows(last).Item("import_depet") = import_depit.Text
                dt.Rows(last).Item("import_credit") = import_credit.Text
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                save_followuser(login.cmbnam.Text, "قام باضافة مورد جديد اسمه:" & import_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                save_operimporter(import_id.Text, import_name.Text, Label1.Text, mainpage.lblstatedate.Text, 0, import_credit.Text, "اضافة مورد جديد")
                MsgBox("تم حفظ البيانات بنجاح", MsgBoxStyle.Information, "تاكيد")
                load_dgv()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub update_data()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where import_id=" & import_id.Text, con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("لايوجد بيانات لتعديلها", MsgBoxStyle.Critical, "تحذير")
                clear_data()
                load_dgv()
            Else
                Dim pos As Integer = BindingContext(dt).Position
                dt.Rows(pos).Item("import_id") = import_id.Text
                dt.Rows(pos).Item("import_name") = import_name.Text
                dt.Rows(pos).Item("import_tel") = import_tel.Text
                dt.Rows(pos).Item("import_address") = import_address.Text
                dt.Rows(pos).Item("import_depet") = import_depit.Text
                dt.Rows(pos).Item("import_credit") = import_credit.Text
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم تعديل البيانات بنجاح", MsgBoxStyle.Information, "تاكيد")
                save_followuser(login.cmbnam.Text, "قام بتعديل بيانات مورد اسمه:" & import_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
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
                da = New OleDbDataAdapter("select * from importers where import_id=" & import_id.Text, con)
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
                    save_followuser(login.cmbnam.Text, "قام بحذف بيانات مورد اسمه:" & import_name.Text, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
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
            da = New OleDbDataAdapter("select * from importers where import_name like'%" & serchimport.Text & "%'", con)
            da.Fill(dt)
            dgvimporters.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear_data()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        save_data()
    End Sub

    Private Sub importers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear_data()
        load_dgv()
    End Sub

    Private Sub dgvimporters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvimporters.Click
        Try
            If dgvimporters.CurrentRow.Cells(0).Selected = True Then
                import_id.Text = dgvimporters.CurrentRow.Cells(1).Value
                import_name.Text = dgvimporters.CurrentRow.Cells(2).Value
                import_tel.Text = dgvimporters.CurrentRow.Cells(3).Value
                import_address.Text = dgvimporters.CurrentRow.Cells(4).Value
                import_depit.Text = dgvimporters.CurrentRow.Cells(5).Value
                import_credit.Text = dgvimporters.CurrentRow.Cells(6).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        update_data()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        delete_data()
    End Sub

    Private Sub serchimport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serchimport.TextChanged
        serch_byname()
    End Sub

    Private Sub import_depit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles import_depit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub import_credit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles import_credit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class