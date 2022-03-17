Imports System.Data.OleDb
Public Class login
    Sub login_data()
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("select* from users where user_name='" & cmbnam.Text & "'and pass='" & txtpass.Text & "'  ", con)
            da.Fill(dt)
            If cmbnam.Text = "" And txtpass.Text = "" Then
                MsgBox("يجب ادخال اسم المستخدم وكلمة المرور")
                Exit Sub
            End If
            If dt.Rows.Count > 0 Then
                MsgBox("تم تسجيل الدخول بنجاح")
                mainpage.Show()
                Me.Hide()
            Else
                MsgBox("خطأ فى تسجيل الدخول حاول مره اخرى")
                txtpass.Text = ""
                cmbnam.SelectedValue = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_cmb("users", "id_users", "user_name", cmbnam)
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnlogn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogn.Click
        login_data()
    End Sub
End Class