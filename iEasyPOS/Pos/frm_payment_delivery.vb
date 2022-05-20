Public Class frm_payment_delivery
    Private Sub BtnGrabFood_Click(sender As Object, e As EventArgs) Handles BtnGrabFood.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " select pay Grab Food")
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_PaymentGrabFood.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.9
            plexi.Show()
            Pos_PaymentGrabFood.StartPosition = FormStartPosition.CenterParent
            Pos_PaymentGrabFood.ShowDialog(plexi)
            Pos_PaymentGrabFood.txtGrabNumber.Select()
        End Using
    End Sub

    Private Sub btnLineman_Click(sender As Object, e As EventArgs) Handles btnLineman.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " select pay Grab Food")
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_paymentLineman.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.9
            plexi.Show()
            Pos_paymentLineman.StartPosition = FormStartPosition.CenterParent
            Pos_paymentLineman.ShowDialog(plexi)
            Pos_paymentLineman.txtGrabNumber.Select()
        End Using
    End Sub

    Private Sub btnRobinhood_Click(sender As Object, e As EventArgs) Handles btnRobinhood.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_paymentRobinhood.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.9
            plexi.Show()
            Pos_paymentRobinhood.StartPosition = FormStartPosition.CenterParent
            Pos_paymentRobinhood.ShowDialog(plexi)
            Pos_paymentRobinhood.txtGrabNumber.Select()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_paymentShopeeFood.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.9
            plexi.Show()
            Pos_paymentShopeeFood.StartPosition = FormStartPosition.CenterParent
            Pos_paymentShopeeFood.ShowDialog(plexi)
            Pos_paymentShopeeFood.txtGrabNumber.Select()
        End Using
    End Sub

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_paymentFoodPanda.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.9
            plexi.Show()
            Pos_paymentFoodPanda.StartPosition = FormStartPosition.CenterParent
            Pos_paymentFoodPanda.ShowDialog(plexi)
            Pos_paymentFoodPanda.txtGrabNumber.Select()
        End Using
    End Sub
End Class