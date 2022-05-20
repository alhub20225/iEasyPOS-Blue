Public Class Frm_OpenShift
    Dim UserId As Integer = Frm_Login.UserId
    Private Sub Frm_OpenShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        TxtMoney.Focus()
        Timer1.Start()
        Me.BtnCancel.Visible = True
        If UserId = 0 Then
            Me.Close()
        Else
            ModuleShift.LoadUserName(UserId)
        End If
        Me.BtnCancel.Visible = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LbDate.Text = Now.ToShortDateString
        Lbtime.Text = TimeOfDay
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()

        Main2.XtraTabPage1.PageVisible = False
        Main2.XtraTabPage2.PageVisible = False
    End Sub
    Private Sub BtnOpenShift_Click(sender As Object, e As EventArgs) Handles BtnOpenShift.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " Open Shift")
        ModuleShift.OpenShift(UserId, Convert.ToDecimal(TxtMoney.Text), Main.SendTypeSale)
        Main.LoadBtnCloseShift()
        If SettingList.AlwaysPrintReceipt = 1 Then
            PrintDOC.OpenShift()
            open_cash.OpenCashdrawer()
        End If

    End Sub
    Sub change_to_th_text()
        Label34.Text = My.Resources.openShift_th.openShift
        Label30.Text = My.Resources.openShift_th.date_openShift
        BtnOpenShift.Text = My.Resources.openShift_th.openShift
        Label9.Text = My.Resources.openShift_th.change
        Label31.Text = My.Resources.openShift_th.change
    End Sub
    Sub change_to_eng_text()
        Label34.Text = My.Resources.openShift_en.openShift
        Label30.Text = My.Resources.openShift_en.date_openShift
        BtnOpenShift.Text = My.Resources.openShift_en.openShift
        Label9.Text = My.Resources.openShift_en.change
        Label31.Text = My.Resources.openShift_en.change
    End Sub

End Class