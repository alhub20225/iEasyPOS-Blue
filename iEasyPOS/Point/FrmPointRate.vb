Public Class FrmPointRate
    Private Sub FrmPointRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewPoint.RowTemplate.Height = 35

        DateTimePicker1.EditValue = Now
        DateStart.EditValue = Now
        DateEnd.EditValue = Now

        rTotalAmount.Checked = True
        rTotalPrice.Checked = False
        totalAmount.Enabled = True
        totalAmount.Value = 0
        totalPrice.Enabled = False
        totalPrice.Value = 0

        ModulePointRate.loadData()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ModulePointRate.btnSave()
        'ModulePointRate.loadDataPointToItem()
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

    'Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    '    ModulePointRate.btnSearch()
    'End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModulePointRate.btnDel()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModulePointRate.btnClear()
    End Sub

    Private Sub rTotalAmount_Click(sender As Object, e As EventArgs) Handles rTotalAmount.Click
        rTotalAmount.Checked = True
        rTotalPrice.Checked = False
        totalAmount.Enabled = True
        totalAmount.Value = 0
        totalPrice.Enabled = False
        totalPrice.Value = 0
    End Sub

    Private Sub rTotalPrice_Click(sender As Object, e As EventArgs) Handles rTotalPrice.Click
        rTotalAmount.Checked = False
        rTotalPrice.Checked = True
        totalAmount.Enabled = False
        totalAmount.Value = 0
        totalPrice.Enabled = True
        totalPrice.Value = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ModulePointRate.btnSearch()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
        TimeStart.Properties.Items.Clear()
        TimeEnd.Properties.Items.Clear()
        PointRate.Value = 0
    End Sub
End Class