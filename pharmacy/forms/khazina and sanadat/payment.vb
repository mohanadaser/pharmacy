Imports System.Data.OleDb
Public Class payment
    'get data to cmb
    Sub getdata_cmbkhazina()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("select * from khazina where kh_id = " & CInt(ComboBox1.SelectedValue), con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                lbkcredit.Text = dt.Rows(0).Item("kh_credit")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_cmb("khazina", "kh_id", "kh_name", ComboBox1)
        getdata_cmbkhazina()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        getdata_cmbkhazina()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        update_khazina()
    End Sub
End Class