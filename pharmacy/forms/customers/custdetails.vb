Imports System.Data.OleDb
Public Class custdetails
    Sub load_dgv()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers", con)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("لايوجد بيانات لعرضها", MsgBoxStyle.Information, "تنبيه")
            Else
                dgvcustdetails.AutoGenerateColumns = False
                dgvcustdetails.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub serch_cust(ByVal colname As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where " & colname & " like'%" & txtserch.Text & "%'", con)
            da.Fill(dt)
            dgvcustdetails.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub
    Sub calcu_customers()
        Try
            Dim dept As Double
            Dim crdt As Double
            For i As Integer = 0 To dgvcustdetails.Rows.Count - 1
                dept = dept + Val(dgvcustdetails.Rows(i).Cells(4).Value)
                crdt = crdt + Val(dgvcustdetails.Rows(i).Cells(5).Value)
            Next
            debit.Text = dept
            credit.Text = crdt
        Catch ex As Exception
        End Try
    End Sub
    Sub print_data(ByVal colname As String)
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers where " & colname & " like'%" & txtserch.Text & "%'", con)
            da.Fill(dt)
            dgvcustdetails.DataSource = dt
            Dim rp As New Crystalrptcust
            rp.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rp
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub report_customers()
        Try
            dt.Clear()
            da = New OleDbDataAdapter("select * from customers", con)
            da.Fill(dt)
            dgvcustdetails.DataSource = dt
            Dim rp As New Crystalrptcust
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

    Private Sub custdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv()
        report_customers()
        calcu_customers()
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

    Private Sub txtserch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtserch.TextChanged
        Try
            If ComboBox1.Text = "الاسم" Then
                serch_cust("cust_name")
                print_data("cust_name")
                calcu_customers()
            End If
            If ComboBox1.Text = "العنوان" Then
                serch_cust("cust_address")
                print_data("cust_address")
                calcu_customers()
            End If
            If ComboBox1.Text = "التليفون" Then
                serch_cust("cust_tel")
                print_data("cust_tel")
                calcu_customers()
            End If
            If ComboBox1.Text = "الكود" Then
                serch_cust("cust_id")
                print_data("cust_id")
                calcu_customers()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvcustdetails_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvcustdetails.DoubleClick
        buybill.buybill_user.Text = dgvcustdetails.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class