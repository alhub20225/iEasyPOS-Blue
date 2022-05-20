Public Class FrmSelectBill
    Private Sub FrmSelectBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtZoneName.Text = FrmTable.LbZoneSelect.Text
        TxtTableName.Text = FrmTable.LbTableSelect.Text
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
    End Sub
End Class