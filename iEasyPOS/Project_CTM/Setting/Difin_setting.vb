Public Class Difin_setting
    Private Sub Difin_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmDifinitionProvince.TopLevel = False
        TabPage1.Controls.Add(FrmDifinitionProvince)
        FrmDifinitionProvince.Show()
        FrmDifinitionTitle.TopLevel = False
        TabPage2.Controls.Add(FrmDifinitionTitle)
        FrmDifinitionTitle.Show()
        FrmManageTax.TopLevel = False
        TabPage3.Controls.Add(FrmManageTax)
        FrmManageTax.Show()
        Frm_Nationality.TopLevel = False
        TabPage4.Controls.Add(Frm_Nationality)
        Frm_Nationality.Show()
    End Sub
End Class