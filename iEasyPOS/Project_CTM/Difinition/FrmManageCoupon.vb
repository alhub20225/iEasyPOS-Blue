Public Class FrmManageCoupon
    Public Shared CouponIdSend As Integer
    Private Sub BtnAddCoupon_Click(sender As Object, e As EventArgs) Handles BtnAddCoupon.Click
        ModuleSettingPayment.ClearDataCoupon()
    End Sub

    Private Sub BtnSaveCoupon_Click(sender As Object, e As EventArgs) Handles BtnSaveCoupon.Click
        If CouponIdSend = 0 Then
            'insert
            ModuleSettingPayment.BtnSaveCoupon(CouponIdSend)
        ElseIf CouponIdSend <> 0
            'Update 
            ModuleSettingPayment.BtnSaveCoupon(CouponIdSend)
        End If
    End Sub
    Private Sub FrmManageCoupon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSettingPayment.LoadDataCoupon()
    End Sub
    Private Sub BtnDeleteCoupon_Click(sender As Object, e As EventArgs) Handles BtnDeleteCoupon.Click
        ModuleSettingPayment.Deletecoupon(CouponIdSend)
    End Sub
    Private Sub DgCoupon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCoupon.CellClick
        CouponIdSend = DgCoupon.CurrentRow.Cells(0).Value
        ModuleSettingPayment.CellClickCoupon(CouponIdSend)
    End Sub
    Private Sub BtnSearchCoupon_Click(sender As Object, e As EventArgs) Handles BtnSearchCoupon.Click
        ModuleSettingPayment.SearchCoupon(TxtSearchCoupon.Text)
    End Sub
End Class