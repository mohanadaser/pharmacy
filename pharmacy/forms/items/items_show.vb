Public Class items_show

    Private Sub items_show_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv("items", dgvitms)
    End Sub
    Private Sub dgvitms_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvitms.DoubleClick
        'اختيار الصنف وتحميله فى فاتورة المبيعات
        Try
            For i As Integer = 0 To salebill.dgvsalebill.Rows.Count - 1
                If dgvitms.CurrentRow.Cells(0).Value = salebill.dgvsalebill.Rows(i).Cells(0).Value Then
                    MsgBox("هذا الصنف تم اختياره من قبل")
                    Exit Sub
                End If
            Next
            salebill.dgvsalebill.Rows.Add()
            Dim x As Integer = salebill.dgvsalebill.Rows.Count - 1
            salebill.dgvsalebill.Rows(x).Cells(0).Value = dgvitms.CurrentRow.Cells(0).Value
            salebill.dgvsalebill.Rows(x).Cells(1).Value = dgvitms.CurrentRow.Cells(1).Value
            salebill.dgvsalebill.Rows(x).Cells(2).Value = dgvitms.CurrentRow.Cells(2).Value
            salebill.dgvsalebill.Rows(x).Cells(3).Value = dgvitms.CurrentRow.Cells(3).Value
            salebill.dgvsalebill.Rows(x).Cells(4).Value = dgvitms.CurrentRow.Cells(4).Value
            salebill.dgvsalebill.Rows(x).Cells(5).Value = 0
            salebill.dgvsalebill.Rows(x).Cells(6).Value = 0
            salebill.lblno_items.Text = Convert.ToUInt32(buybill.dgvbuybill.Rows.Count)
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            serch_data("items", "item_name", TextBox1, dgvitms)
        Catch ex As Exception

        End Try
    End Sub
End Class