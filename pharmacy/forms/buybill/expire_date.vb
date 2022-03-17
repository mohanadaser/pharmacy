Public Class expire_date

    Private Sub dt_expiredate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_expiredate.ValueChanged
        buybill.dgvbuybill.CurrentRow.Cells(5).Value = dt_expiredate.Value
    End Sub
End Class