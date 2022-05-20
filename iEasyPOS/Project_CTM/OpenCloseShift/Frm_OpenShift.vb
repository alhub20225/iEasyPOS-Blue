Public Class Frm_OpenShift
    Dim UserId As Integer = Frm_Login.UserId
    Private Sub Frm_OpenShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtMoney.Focus()
        Timer1.Start()
        If UserId = 0 Then
            Me.Close()
        Else
            ModuleShift.LoadUserName(UserId)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LbDate.Text = Now.ToShortDateString
        Lbtime.Text = TimeOfDay
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()

        Main2.XtraTabPage1.PageVisible = False
        'Main2.XtraTabPage2.PageVisible = False
    End Sub
    Private Sub BtnOpenShift_Click(sender As Object, e As EventArgs) Handles BtnOpenShift.Click
        ModuleShift.OpenShift(UserId, Convert.ToDecimal(TxtMoney.Text), Main.SendTypeSale)
        Main.LoadBtnCloseShift()
        PrintDOC.OpenShift()
        open_cash.OpenCashdrawer()
    End Sub
End Class