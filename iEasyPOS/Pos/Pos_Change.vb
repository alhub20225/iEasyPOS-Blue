Public Class Pos_Change
    Private Sub Pos_Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        txtChange.Text = FormatNumber(change, 2)
        Timer1.Start()
    End Sub
    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        GetSaleId = 0
        TB_GetSaleId = 0
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetSaleId = 0
        TB_GetSaleId = 0
        Me.Close()
    End Sub

    Sub change_to_th_text()
        Label355.Text = "เงินทอน"
        Label36.Text = "เงินทอน"
    End Sub
    Sub change_to_eng_text()
        Label355.Text = "Change"
        Label36.Text = "Change"
    End Sub
End Class