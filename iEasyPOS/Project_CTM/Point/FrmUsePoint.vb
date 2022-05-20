Public Class FrmUsePoint
    Private Sub FrmUsePoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ModulePosPointItem.loadItem()
        ModulePosPointItem.customerData()
    End Sub
    Private Sub btnSaveUsePointItem_Click(sender As Object, e As EventArgs) Handles btnSaveUsePointItem.Click
        ModulePosPointItem.btnSave()
    End Sub
End Class