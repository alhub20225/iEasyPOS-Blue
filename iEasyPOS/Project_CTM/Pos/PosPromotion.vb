Public Class PosPromotion
    Public Shared GiftvalueId As Integer = 0
    Public Shared PromotionId As Integer = 0
    Private Sub PosPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModulePosPromotion.GetFree()
    End Sub
End Class