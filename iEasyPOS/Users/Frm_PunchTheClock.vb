Public Class Frm_PunchTheClock
    Private Sub Frm_PunchTheClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerNow.Start()
        ModulePunchTheClock.loadUserData()
        ModulePunchTheClock.loadTime()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerNow.Tick
        timeNow.Text = TimeOfDay
        dateNow.Text = Format(Date.Now, "ddd dd MMM yyyy")
    End Sub
    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click
        ModulePunchTheClock.btnTimeIn()
    End Sub
    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click
        ModulePunchTheClock.btnTimeOut()
    End Sub

    Private Sub btnBreakIn_Click(sender As Object, e As EventArgs) Handles btnBreakIn.Click
        ModulePunchTheClock.btnBreakIn()
    End Sub
    Private Sub btnOTIn_Click(sender As Object, e As EventArgs) Handles btnOTIn.Click
        ModulePunchTheClock.btnOTIn()
    End Sub

    Private Sub btnOTOut_Click(sender As Object, e As EventArgs) Handles btnOTOut.Click
        ModulePunchTheClock.btnOTOut()
    End Sub

    Private Sub btnBreakOut_Click(sender As Object, e As EventArgs) Handles btnBreakOut.Click
        ModulePunchTheClock.btnBreakOut()
    End Sub

    Private Sub DateTimePickerSearch_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerSearch.ValueChanged
        ModulePunchTheClock.btnSearch()
    End Sub
End Class