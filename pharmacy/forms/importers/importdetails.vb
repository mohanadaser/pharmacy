Imports System.Data.OleDb
Public Class importdetails
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers", con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("لايوجد بيانات لعرضها", MsgBoxStyle.Information, "تنبيه")
            Else
                dgvimportdetails.AutoGenerateColumns = False
                dgvimportdetails.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub serch_import(ByVal colname As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where " & colname & " like'%" & txtserch.Text & "%'", con)
            da.Fill(dt)
            dgvimportdetails.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub
    Sub calcu_importers()
        Try
            Dim dept As Double
            Dim crdt As Double
            For i As Integer = 0 To dgvimportdetails.Rows.Count - 1
                dept = dept + Val(dgvimportdetails.Rows(i).Cells(4).Value)
                crdt = crdt + Val(dgvimportdetails.Rows(i).Cells(5).Value)
            Next
            debit.Text = dept
            credit.Text = crdt
        Catch ex As Exception
        End Try
    End Sub
    Sub print_data(ByVal colname As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers where " & colname & " like'%" & txtserch.Text & "%'", con)
            da.Fill(dt)
            dgvimportdetails.DataSource = dt
            Dim rp As New CrystalRptimport
            rp.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub report_importers()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from importers", con)
            da.Fill(dt)
            dgvimportdetails.DataSource = dt
            Dim rp As New Crystalrptimport
            rp.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BindingContext(dt).Position = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingContext(dt).Position += 1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BindingContext(dt).Position -= 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim last As Integer = BindingContext(dt).Count - 1
        BindingContext(dt).Position = last
    End Sub

    Private Sub importdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv()
        calcu_importers()
        report_importers()
    End Sub

    Private Sub txtserch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtserch.TextChanged
        Try
            If ComboBox1.Text = "الاسم" Then
                serch_import("import_name")
                print_data("import_name")
                calcu_importers()
            End If
            If ComboBox1.Text = "العنوان" Then
                serch_import("import_address")
                print_data("import_address")
                calcu_importers()
            End If
            If ComboBox1.Text = "التليفون" Then
                serch_import("import_tel")
                print_data("import_tel")
                calcu_importers()
            End If
            If ComboBox1.Text = "الكود" Then
                serch_import("import_id")
                print_data("import_id")
                calcu_importers()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class