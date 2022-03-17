Imports System.Data.OleDb
Public Class bills_show

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Button1.Text = "انشاء فاتورة مرتجع شراء" Then
                'تحميل فاتورة مرتجع المشتريات
                rebuybill.rebuybill_idbuy.Text = lblid.Text
                rebuybill.importernam.Text = txtimporter.Text
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                da = New OleDbDataAdapter("SELECT * from q_details where buybillid_details=" & rebuybill.rebuybill_idbuy.Text & "", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    rebuybill.redgvbuybill.Rows.Add()
                    For i As Integer = 0 To rebuybill.redgvbuybill.Rows.Count - 1
                        rebuybill.redgvbuybill.Rows(i).Cells(0).Value = dt.Rows(0).Item("buybillid_item")
                        rebuybill.redgvbuybill.Rows(i).Cells(1).Value = dt.Rows(0).Item("barcode_item")
                        rebuybill.redgvbuybill.Rows(i).Cells(2).Value = dt.Rows(0).Item("item_name")
                        rebuybill.redgvbuybill.Rows(i).Cells(3).Value = dt.Rows(0).Item("buybill_unit")
                        rebuybill.redgvbuybill.Rows(i).Cells(4).Value = dt.Rows(0).Item("buybill_expiredate")
                        rebuybill.redgvbuybill.Rows(i).Cells(5).Value = dt.Rows(0).Item("buybill_price_b")
                        rebuybill.redgvbuybill.Rows(i).Cells(6).Value = 0
                        rebuybill.redgvbuybill.Rows(i).Cells(7).Value = 0
                    Next
                    rebuybill.redgvbuybill.AutoGenerateColumns = False
                    rebuybill.redgvbuybill.DataSource = dt
                    rebuybill.Show()
                End If
            Else
                'تحميل فاتورة مرتجع البيع
                re_salebill.resalebill_idsale.Text = lblid.Text
                re_salebill.custnam.Text = txtimporter.Text
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                da = New OleDbDataAdapter("SELECT * from sale_detailsview where salebillid_details=" & re_salebill.resalebill_idsale.Text & "", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    re_salebill.redgvsalebill.Rows.Add()
                    For i As Integer = 0 To re_salebill.redgvsalebill.Rows.Count - 1
                        re_salebill.redgvsalebill.Rows(i).Cells(0).Value = dt.Rows(0).Item("salebillid_item")
                        re_salebill.redgvsalebill.Rows(i).Cells(1).Value = dt.Rows(0).Item("barcode_item")
                        re_salebill.redgvsalebill.Rows(i).Cells(2).Value = dt.Rows(0).Item("item_name")
                        re_salebill.redgvsalebill.Rows(i).Cells(3).Value = dt.Rows(0).Item("salebill_unit")
                        re_salebill.redgvsalebill.Rows(i).Cells(4).Value = dt.Rows(0).Item("salebill_price_s")
                        re_salebill.redgvsalebill.Rows(i).Cells(5).Value = 0
                        re_salebill.redgvsalebill.Rows(i).Cells(6).Value = 0
                    Next
                    re_salebill.redgvsalebill.AutoGenerateColumns = False
                    re_salebill.redgvsalebill.DataSource = dt
                    re_salebill.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bills_show_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Text = login.cmbnam.Text
    End Sub
End Class