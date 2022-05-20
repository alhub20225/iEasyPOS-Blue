Public Class FrmSplitBill

    Private Sub FrmSplitBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''ModuleManageTable.LoadSaveSaleTable()
        ModuleManageTable.LoadBill()
        'Me.txtSubTotal.Clear()
        'Me.txtSubTotal2.Clear()
        'Me.txtDiscount.Clear()
        'Me.txtDiscount2.Clear()
        'Me.txtTotal.Clear()
        'Me.txtTotal2.Clear()
    End Sub

    'Private Sub DataGridViewPOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPOS.CellClick
    '    Dim checked As Boolean = CType(DataGridViewPOS.CurrentRow.Cells("Column5").Value, Boolean)
    '    If checked = True Then
    '        DataGridViewPOS.CurrentRow.Cells("Column5").Value = False
    '    Else
    '        DataGridViewPOS.CurrentRow.Cells("Column5").Value = True
    '    End If
    'End Sub

    'Private Sub DataGridViewPOS2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPOS2.CellClick
    '    Dim checked As Boolean = CType(DataGridViewPOS2.CurrentRow.Cells("Column4").Value, Boolean)
    '    If checked = True Then
    '        DataGridViewPOS2.CurrentRow.Cells("Column4").Value = False
    '    Else
    '        DataGridViewPOS2.CurrentRow.Cells("Column4").Value = True
    '    End If
    'End Sub

    'Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
    '    ModuleManageTable.MoveRight()
    'End Sub

    'Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
    '    ModuleManageTable.MoveLeft()
    'End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    ModuleManageTable.btnSaveSplitBill()
    '    Me.Close()
    '    POS.Close()
    '    FrmTable.Close()
    '    FrmTable.Show()
    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'TableId = 0
        'First_LoadTable()
        'POS.DataGridViewPOS.Rows.Clear()
        'POS.txtTotal.Text = "0.00"
        'POS.txtSubTotal.Text = "0.00"
        'POS.txtDiscount.Text = "0.00"
    End Sub
End Class