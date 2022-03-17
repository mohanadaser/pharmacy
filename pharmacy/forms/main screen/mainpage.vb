Public Class mainpage

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblstatedate.Text = DateAndTime.Now
    End Sub
    Private Sub اضافةصنفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةصنفToolStripMenuItem.Click
        make_allows("a1", items)
    End Sub

    Private Sub ادارةالاصنافToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالاصنافToolStripMenuItem1.Click
        make_allows("a2", manage_items)
    End Sub

    Private Sub اضافةعميلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةعميلToolStripMenuItem.Click
        make_allows("c1", newcustomers)
    End Sub

    Private Sub بحثالعملاءToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بحثالعملاءToolStripMenuItem.Click
        make_allows("c2", custdetails)
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        make_allows("m1", importers)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        make_allows("m2", importdetails)
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        make_allows("b1", buybill)
    End Sub

    Private Sub عرضفواتيرالشراءToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضفواتيرالشراءToolStripMenuItem.Click
        make_allows("rb2", showbuybills)

    End Sub

    Private Sub فاتورةمرتجعشراءToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فاتورةمرتجعشراءToolStripMenuItem.Click
        rebuy_show.TopLevel = False
        panelmain.Controls.Clear()
        panelmain.Controls.Add(rebuy_show)
        rebuy_show.BringToFront()
        rebuy_show.Show()
    End Sub

    Private Sub lblstatedate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstatedate.Click

    End Sub

    Private Sub كشفحسابموردToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كشفحسابموردToolStripMenuItem.Click
        make_allows("m3", oper_importer)
    End Sub

    Private Sub فاتورةبيعToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فاتورةبيعToolStripMenuItem.Click
        make_allows("s1", salebill)
    End Sub

    Private Sub عرضفواتيرالبيعToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضفواتيرالبيعToolStripMenuItem.Click
        make_allows("rs2", showsale_bills)
    End Sub

    Private Sub عرضفواتيرمرتجعالمبيعاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضفواتيرمرتجعالمبيعاتToolStripMenuItem.Click
        show_resale.TopLevel = False
        panelmain.Controls.Clear()
        panelmain.Controls.Add(show_resale)
        show_resale.BringToFront()
        show_resale.Show()
    End Sub

    Private Sub كشفحسابعميلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كشفحسابعميلToolStripMenuItem.Click
        make_allows("c3", oper_cust)
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        make_allows2("kh1", khazina)
    End Sub

    Private Sub اضافةمصروفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةمصروفToolStripMenuItem.Click
        masrofat.ShowDialog()
    End Sub

    Private Sub صرفوتوريدنقديهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صرفوتوريدنقديهToolStripMenuItem.Click
        make_allows("sf1", sanadat)
    End Sub

    Private Sub عرضسنداتالصرفوالتوريدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضسنداتالصرفوالتوريدToolStripMenuItem.Click
        sanadat_show.TopLevel = False
        panelmain.Controls.Clear()
        panelmain.Controls.Add(sanadat_show)
        sanadat_show.BringToFront()
        sanadat_show.Show()
    End Sub
    Private Sub صلاحياتالمستخدمينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صلاحياتالمستخدمينToolStripMenuItem.Click
        make_allows("us1", allow_users)
    End Sub

    Private Sub تعديلالمستخدمينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلالمستخدمينToolStripMenuItem.Click
        make_allows2("u1", users)
    End Sub

    Private Sub تتبعالمستخدمينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تتبعالمستخدمينToolStripMenuItem.Click
        make_allows("fu1", follow_user)
    End Sub

    Private Sub صلاحياتالاصنافوالنواقصToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صلاحياتالاصنافوالنواقصToolStripMenuItem.Click
        exp_qty.TopLevel = False
        panelmain.Controls.Clear()
        panelmain.Controls.Add(exp_qty)
        exp_qty.BringToFront()
        exp_qty.Show()
    End Sub

    Private Sub النسخوالاسترجاعالاحتياطىToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles النسخوالاسترجاعالاحتياطىToolStripMenuItem.Click
        backupvb.ShowDialog()
    End Sub

    Private Sub بياناتالشركهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        companydata.ShowDialog()
    End Sub


End Class
