Public Class FrmPointRate
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ModulePointRate.btnSave()
        ModulePointRate.loadDataPointToItem()
        ModulePointRate.loadData()
        ModulePointRate.btnClear()
    End Sub
    Public Shared PointId As Integer = 0
    Private Sub DataGridViewPoint_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPoint.CellClick
        Try
            PointId = DataGridViewPoint.CurrentRow.Cells("PointRateId").Value
            ModulePointRate.showData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmPointRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModulePointRate.loadData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ModulePointRate.btnSearch()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModulePointRate.btnDel()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModulePointRate.btnClear()
    End Sub

    Private Sub rTotalAmount_Click(sender As Object, e As EventArgs) Handles rTotalAmount.Click
        rTotalAmount.Checked = True
        rTotalPrice.Checked = False
        pAmount.Enabled = True
        totalAmount.Value = 0
        pPrice.Enabled = False
        totalPrice.Value = 0
    End Sub

    Private Sub rTotalPrice_Click(sender As Object, e As EventArgs) Handles rTotalPrice.Click
        rTotalAmount.Checked = False
        rTotalPrice.Checked = True
        pAmount.Enabled = False
        totalAmount.Value = 0
        pPrice.Enabled = True
        totalPrice.Value = 0
    End Sub
End Class