Public Class Frm_Promotion
    Private Sub Frm_Promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        XtraTabMain.SelectedTabPageIndex = 0
        FrmManagePromotion.TopLevel = False
        FrmManagePromotion.FormBorderStyle = FormBorderStyle.None
        FrmManagePromotion.WindowState = FormWindowState.Maximized
        FrmManagePromotion.Dock = DockStyle.Fill
        FrmManagePromotion.TopLevel = False
        XtraTabPage1.Controls.Add(FrmManagePromotion)
        FrmManagePromotion.Show()

        Button1.ForeColor = Color.FromArgb(45, 149, 239)
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_Pomotion2Blue
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_PiontGray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        XtraTabMain.SelectedTabPageIndex = 0
        FrmManagePromotion.TopLevel = False
        FrmManagePromotion.FormBorderStyle = FormBorderStyle.None
        FrmManagePromotion.WindowState = FormWindowState.Maximized
        FrmManagePromotion.Dock = DockStyle.Fill
        FrmManagePromotion.TopLevel = False
        XtraTabPage1.Controls.Add(FrmManagePromotion)
        FrmManagePromotion.Show()

        Button1.ForeColor = Color.FromArgb(45, 149, 239)
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_Pomotion2Blue
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_PiontGray
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        XtraTabMain.SelectedTabPageIndex = 1
        FrmManagePoint.TopLevel = False
        FrmManagePoint.FormBorderStyle = FormBorderStyle.None
        FrmManagePoint.WindowState = FormWindowState.Maximized
        FrmManagePoint.Dock = DockStyle.Fill
        FrmManagePoint.TopLevel = False
        XtraTabPage2.Controls.Add(FrmManagePoint)
        FrmManagePoint.Show()

        Button1.ForeColor = Color.FromArgb(65, 73, 86)
        Button1.Image = iEasyPOS.My.Resources.Resources.Icon_Pomotion2Gray
        Button6.ForeColor = Color.FromArgb(45, 149, 239)
        Button6.Image = iEasyPOS.My.Resources.Resources.Icon_PiontBlue
    End Sub
End Class