Imports System.Data.OleDb
Public Class manage_items
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items", con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("لايوجد بيانات لعرضها", MsgBoxStyle.Information, "تنبيه")
            Else
                dgvmngitems.AutoGenerateColumns = False
                dgvmngitems.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub serchby_rbd(ByVal colname As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where " & colname & " like'%" & TextBox1.Text & "%'", con)
            da.Fill(dt)
            dgvmngitems.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub
    'Sub calcu_dgv()
    '    Dim ts As Double
    '    Dim db As Double
    '    dgvmngitems.CurrentRow.Cells(11).Value = dgvmngitems.CurrentRow.Cells(6).Value * dgvmngitems.CurrentRow.Cells(4).Value
    '    dgvmngitems.CurrentRow.Cells(12).Value = dgvmngitems.CurrentRow.Cells(7).Value * dgvmngitems.CurrentRow.Cells(4).Value
    '    For i As Integer = 0 To dgvmngitems.Rows.Count

    '        ts = ts + dgvmngitems.Rows(i).Cells(11).Value
    '        db = db + dgvmngitems.Rows(i).Cells(12).Value
    '    Next
    '    lblbuy.Text = db
    '    lblsale.Text = ts
    '    lblearn.Text = Val(ts - db)
    'End Sub
    Sub print_data(ByVal colname As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items where " & colname & " like'%" & TextBox1.Text & "%'", con)
            da.Fill(dt)
            dgvmngitems.DataSource = dt
            Dim rp As New CrystalReport1
            rp.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub report_items()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from items", con)
            da.Fill(dt)
            dgvmngitems.DataSource = dt
            Dim rp As New CrystalReport1
            rp.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub dgvmngitems_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvmngitems.DoubleClick
        'اختيار الصنف وتحميله فى فاتورة المشتريات
        Try
            da = New OleDbDataAdapter(" select * from items where id_item=" & dgvmngitems.CurrentRow.Cells(0).Value, con)
            da.Fill(dt)
            For i As Integer = 0 To buybill.dgvbuybill.Rows.Count - 1
                If dgvmngitems.CurrentRow.Cells(0).Value = buybill.dgvbuybill.Rows(i).Cells(0).Value Then
                    MsgBox("هذا الصنف تم اختياره من قبل")
                    Exit Sub
                End If
            Next

            buybill.dgvbuybill.Rows.Add()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim x As Integer = buybill.dgvbuybill.Rows.Count - 1
                buybill.dgvbuybill.Rows(x).Cells(0).Value = dt.Rows(i).Item("id_item")
                buybill.dgvbuybill.Rows(x).Cells(1).Value = dt.Rows(i).Item("barcode_item")
                buybill.dgvbuybill.Rows(x).Cells(2).Value = dt.Rows(i).Item("item_name")
                buybill.dgvbuybill.Rows(x).Cells(3).Value = dt.Rows(i).Item("item_unit")
                buybill.dgvbuybill.Rows(x).Cells(4).Value = dt.Rows(i).Item("company")
                buybill.dgvbuybill.Rows(x).Cells(5).Value = dt.Rows(i).Item("expire_date")
                buybill.dgvbuybill.Rows(x).Cells(6).Value = dt.Rows(i).Item("sale_price")
                buybill.dgvbuybill.Rows(x).Cells(7).Value = dt.Rows(i).Item("buy_price")
                buybill.dgvbuybill.Rows(x).Cells(8).Value = 0
                buybill.dgvbuybill.Rows(x).Cells(9).Value = 0
            Next
            buybill.lblno_items.Text = Convert.ToUInt32(buybill.dgvbuybill.Rows.Count)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.Text = "الاسم" Then
                serchby_rbd("item_name")
                print_data("item_name")
                'calcu_dgv()
            End If
            If ComboBox1.Text = "الباركود" Then
                serchby_rbd("barcode_item")
                print_data("barcode_item")
                'calcu_dgv()
            End If
            If ComboBox1.Text = "القسم" Then
                serchby_rbd("category")
                print_data("category")
                'calcu_dgv()
            End If
            If ComboBox1.Text = "الشركه" Then
                serchby_rbd("company")
                print_data("company")
                'calcu_dgv()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub manage_items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        report_items()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            load_dgv()
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class