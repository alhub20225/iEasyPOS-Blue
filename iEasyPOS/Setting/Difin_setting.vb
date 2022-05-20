Public Class Difin_setting
    Private Sub Difin_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        XtraTabMain.SelectedTabPageIndex = 0
        Button6.ForeColor = Color.FromArgb(45, 149, 239)
        Panel23.Visible = True
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        FrmDifinitionProvince.TopLevel = False
        FrmDifinitionProvince.FormBorderStyle = FormBorderStyle.None
        FrmDifinitionProvince.WindowState = FormWindowState.Maximized
        FrmDifinitionProvince.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(FrmDifinitionProvince)
        FrmDifinitionProvince.Show()

        'Dim BckColor As System.Drawing.Color
        'If My.Settings.PosType = 1 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(239, Byte), Integer))
        'ElseIf My.Settings.PosType = 0 Then
        '    BckColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        'End If
        'Me.BackColor = BckColor
        'FrmDifinitionProvince.TopLevel = False
        'TabPage1.Controls.Add(FrmDifinitionProvince)
        'FrmDifinitionProvince.Show()
        'FrmDifinitionTitle.TopLevel = False
        'TabPage2.Controls.Add(FrmDifinitionTitle)
        'FrmDifinitionTitle.Show()
        'FrmManageTax.TopLevel = False
        'TabPage3.Controls.Add(FrmManageTax)
        'FrmManageTax.Show()
        'Frm_Nationality.TopLevel = False
        'TabPage4.Controls.Add(Frm_Nationality)
        'Frm_Nationality.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        XtraTabMain.SelectedTabPageIndex = 0
        Button6.ForeColor = Color.FromArgb(45, 149, 239)
        Panel23.Visible = True
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        FrmDifinitionProvince.TopLevel = False
        FrmDifinitionProvince.FormBorderStyle = FormBorderStyle.None
        FrmDifinitionProvince.WindowState = FormWindowState.Maximized
        FrmDifinitionProvince.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(FrmDifinitionProvince)
        FrmDifinitionProvince.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        XtraTabMain.SelectedTabPageIndex = 1
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Panel23.Visible = False
        Label1.ForeColor = Color.FromArgb(45, 149, 239)
        Panel7.Visible = True
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        FrmDifinitionTitle.TopLevel = False
        FrmDifinitionTitle.FormBorderStyle = FormBorderStyle.None
        FrmDifinitionTitle.WindowState = FormWindowState.Maximized
        FrmDifinitionTitle.Dock = DockStyle.Fill
        XtraTabPage2.Controls.Add(FrmDifinitionTitle)
        FrmDifinitionTitle.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        XtraTabMain.SelectedTabPageIndex = 2
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Panel23.Visible = False
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(45, 149, 239)
        Panel12.Visible = True
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        FrmManageTax.TopLevel = False
        FrmManageTax.FormBorderStyle = FormBorderStyle.None
        FrmManageTax.WindowState = FormWindowState.Maximized
        FrmManageTax.Dock = DockStyle.Fill
        XtraTabPage3.Controls.Add(FrmManageTax)
        FrmManageTax.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        XtraTabMain.SelectedTabPageIndex = 3
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Panel23.Visible = False
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(45, 149, 239)
        Panel17.Visible = True

        Frm_Nationality.TopLevel = False
        Frm_Nationality.FormBorderStyle = FormBorderStyle.None
        Frm_Nationality.WindowState = FormWindowState.Maximized
        Frm_Nationality.Dock = DockStyle.Fill
        XtraTabPage4.Controls.Add(Frm_Nationality)
        Frm_Nationality.Show()
    End Sub
End Class