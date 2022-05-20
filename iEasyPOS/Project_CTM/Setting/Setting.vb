Public Class Setting

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_ManageUsers.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(Frm_ManageUsers)
        Frm_ManageUsers.Show()
    End Sub
    Private Sub Close_pos_Click(sender As Object, e As EventArgs) Handles Close_pos.Click
        Me.Close()
        Main.Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_ManageUsers.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(Frm_ManageUsers)
        Frm_ManageUsers.Show()
        Frm_RolesManage.Close()
        Difin_setting.Close()
        FrmUnit.Close()
        FrmManageStock.Close()
        Frm_Employee.Close()
        FrmManageSupplier.Close()
        SystemSetting.Close()
        CompanySetting.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Frm_RolesManage.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(Frm_RolesManage)
        Frm_RolesManage.Show()
        Frm_ManageUsers.Close()
        Difin_setting.Close()
        FrmUnit.Close()
        FrmManageStock.Close()
        Frm_Employee.Close()
        FrmManageSupplier.Close()
        SystemSetting.Close()
        CompanySetting.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Difin_setting.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(Difin_setting)
        Difin_setting.Show()
        Frm_ManageUsers.Close()
        Frm_RolesManage.Close()
        FrmUnit.Close()
        FrmManageStock.Close()
        Frm_Employee.Close()
        FrmManageSupplier.Close()
        SystemSetting.Close()
        CompanySetting.Close()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Frm_Employee.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(Frm_Employee)
        Frm_Employee.Show()
        Difin_setting.Close()
        Frm_ManageUsers.Close()
        Frm_RolesManage.Close()
        FrmUnit.Close()
        FrmManageStock.Close()
        FrmManageSupplier.Close()
        SystemSetting.Close()
        CompanySetting.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FrmManageStock.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(FrmManageStock)
        FrmUnit.TopLevel = False
        Frm_Employee.Close()
        Difin_setting.Close()
        Frm_ManageUsers.Close()
        Frm_RolesManage.Close()
        FrmManageStock.Show()
        FrmUnit.Close()
        Frm_Employee.Close()
        FrmManageSupplier.Close()
        SystemSetting.Close()
        CompanySetting.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FrmUnit.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(FrmUnit)
        Frm_Employee.Close()
        Difin_setting.Close()
        Frm_ManageUsers.Close()
        Frm_RolesManage.Close()
        FrmManageStock.Close()
        FrmUnit.Show()
        Frm_Employee.Close()
        CompanySetting.Close()
        FrmManageSupplier.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FrmManageSupplier.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(FrmManageSupplier)
        Frm_Employee.Close()
        Difin_setting.Close()
        Frm_ManageUsers.Close()
        Frm_RolesManage.Close()
        FrmManageStock.Close()
        FrmUnit.Close()
        Frm_Employee.Close()
        FrmManageSupplier.Show()
        CompanySetting.Close()
        SystemSetting.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SystemSetting.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(SystemSetting)
        Frm_Employee.Close()
        Difin_setting.Close()
        Frm_ManageUsers.Close()
        Frm_RolesManage.Close()
        FrmManageStock.Close()
        FrmUnit.Close()
        Frm_Employee.Close()
        FrmManageSupplier.Close()
        CompanySetting.Close()
        SystemSetting.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CompanySetting.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(CompanySetting)
        Frm_Employee.Close()
        Difin_setting.Close()
        Frm_ManageUsers.Close()
        Frm_RolesManage.Close()
        FrmManageStock.Close()
        FrmUnit.Close()
        Frm_Employee.Close()
        FrmManageSupplier.Close()
        SystemSetting.Close()
        CompanySetting.Show()
    End Sub

End Class