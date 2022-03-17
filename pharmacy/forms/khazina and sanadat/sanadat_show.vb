Imports System.Data.OleDb
Public Class sanadat_show

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable
            dt.Clear()
            da = New OleDbDataAdapter("select * from sanadat where date_sanad >= '" & date_from.Value.ToString("yyyy/MM/dd") & "' and date_sanad <= '" & date_to.Value.ToString("yyyy/MM/dd") & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dgvsanadat.DataSource = dt
            Else
                MsgBox("لايوجد فواتير فى هذا التاريخ")
                load_dgv("sanadat", dgvsanadat)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub sanadat_show_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_dgv("sanadat", dgvsanadat)
    End Sub

    Private Sub dgvsanadat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvsanadat.Click
        Try
            If dgvsanadat.CurrentRow.Cells(10).Selected = True Then

                If MsgBox("هل تريد الحذف فعلا", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                    Dim dt As New DataTable
                    Dim da As New OleDbDataAdapter
                    dt.Clear()
                    da = New OleDbDataAdapter("select * from sanadat where id_sanad=" & dgvsanadat.CurrentRow.Cells(0).Value, con)
                    da.Fill(dt)
                    Dim x As Integer = BindingContext(dt).Position
                    dt.Rows(x).Delete()
                    Dim save As New OleDbCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    MsgBox("تم حذف البيانات", MsgBoxStyle.Information, "حذف")
                    save_followuser(login.cmbnam.Text, "قام بحذف المستند نوعه:" & dgvsanadat.CurrentRow.Cells(7).Value, DateAndTime.Now.ToString("yyyy/MM/dd/hh:mm"))
                    load_dgv("sanadat", dgvsanadat)
                Else
                    Exit Sub
                End If
            End If
            Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub custnam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custnam.TextChanged
        serch_data("sanadat", "hesab_t", custnam, dgvsanadat)
    End Sub

    Private Sub importnam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles importnam.TextChanged
        serch_data("sanadat", "hesab_f", importnam, dgvsanadat)
    End Sub

    Private Sub masrofat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles masrofat.TextChanged
        serch_data("sanadat", "hesab_f", masrofat, dgvsanadat)
    End Sub
End Class