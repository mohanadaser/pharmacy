Imports System.Data.OleDb
Public Class oper_importer
    'calculate dgv
    Sub calcu_dgv()
        Try
            Dim totalmaden As Double
            Dim totaldaen As Double
            For i As Integer = 0 To dgvoper_import.Rows.Count - 1
                totaldaen = totaldaen + dgvoper_import.Rows(i).Cells(6).Value
                totalmaden = totalmaden + dgvoper_import.Rows(i).Cells(5).Value
            Next
            totdaen.Text = Val(totaldaen)
            totmadin.Text = Val(totalmaden)
            Totcredit.Text = Val(totaldaen) - Val(totalmaden)
        Catch ex As Exception

        End Try
    End Sub
    'delete data
    Sub delete_data()

        Try
            If MsgBox("هل تريد الحذف فعلا", MsgBoxStyle.OkCancel) = vbOK Then
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                dt.Clear()
                da = New OleDbDataAdapter("select * from importer_operation where id=" & dgvoper_import.CurrentRow.Cells(0).Value, con)
                da.Fill(dt)
                Dim pos As Integer = BindingContext(dt).Position
                dt.Rows(pos).Delete()
                Dim save As New OleDbCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MsgBox("تم حذف الفاتوره")
                save_followuser(login.cmbnam.Text, "قام بحذف حركة حساب مورد اسمه:" & dgvoper_import.CurrentRow.Cells(2).Value, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                load_dgv("importer_operation", dgvoper_import)
                calcu_dgv()
            Else
                Exit Sub
                load_dgv("importer_operation", dgvoper_import)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Close()
    End Sub

    Private Sub oper_importer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_cmb("importers", "import_id", "import_name", ComboBox1)
        load_dgv("importer_operation", dgvoper_import)
        calcu_dgv()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter("select * from importer_operation where (oper_date >= '" & DateTimePicker1.Value.ToString("yyyy/MM/dd") & "') and (oper_date <= '" & DateTimePicker2.Value.ToString("yyyy/MM/dd") & "')and( operimport_id=" & ComboBox1.SelectedValue & ")", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dgvoper_import.DataSource = dt
                calcu_dgv()
            Else
                dgvoper_import.DataSource = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        delete_data()
        calcu_dgv()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        load_dgv("importer_operation", dgvoper_import)
    End Sub
End Class