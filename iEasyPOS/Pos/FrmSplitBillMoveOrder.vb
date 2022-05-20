Public Class FrmSplitBillMoveOrder
    Private Sub FrmSplitBillMoveOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        DataGridViewPOS.RowTemplate.Height = 35
        DataGridViewPOS2.RowTemplate.Height = 35
        FlowLayoutPanelBillList.Controls.Clear()
        DataGridViewPOS.Rows.Clear()
        DataGridViewPOS2.Rows.Clear()
        txtBill1.Clear()
        txtSubTotal.Text = 0
        txtSubTotal.Text = FormatNumber(txtSubTotal.Text, 2)
        txtSubTotal2.Text = 0
        txtSubTotal2.Text = FormatNumber(txtSubTotal2.Text, 2)
        txtDiscount.Text = 0
        txtDiscount.Text = FormatNumber(txtDiscount.Text, 2)
        txtDiscount2.Text = 0
        txtDiscount2.Text = FormatNumber(txtDiscount2.Text, 2)
        txtTotal.Text = 0
        txtTotal.Text = FormatNumber(txtTotal.Text, 2)
        txtTotal2.Text = 0
        txtTotal2.Text = FormatNumber(txtTotal2.Text, 2)
        'ModuleManageTable.LoadSaveSaleTable()
        ModuleManageTable.LoadBill()
    End Sub

    Private Sub DataGridViewPOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPOS.CellClick
        Dim checked As Boolean = CType(DataGridViewPOS.CurrentRow.Cells("Column5").Value, Boolean)
        If checked = True Then
            DataGridViewPOS.CurrentRow.Cells("Column5").Value = False
        Else
            DataGridViewPOS.CurrentRow.Cells("Column5").Value = True
        End If
    End Sub

    Private Sub DataGridViewPOS2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPOS2.CellClick
        Dim checked As Boolean = CType(DataGridViewPOS2.CurrentRow.Cells("Column4").Value, Boolean)
        If checked = True Then
            DataGridViewPOS2.CurrentRow.Cells("Column4").Value = False
        Else
            DataGridViewPOS2.CurrentRow.Cells("Column4").Value = True
        End If
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        ModuleManageTable.MoveRight()
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        ModuleManageTable.MoveLeft()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        DataGridViewPOS.Rows.Clear()
        DataGridViewPOS2.Rows.Clear()
        txtBill1.Clear()
        txtSubTotal.Text = 0
        txtSubTotal.Text = FormatNumber(txtSubTotal.Text, 2)
        txtSubTotal2.Text = 0
        txtSubTotal2.Text = FormatNumber(txtSubTotal2.Text, 2)
        txtDiscount.Text = 0
        txtDiscount.Text = FormatNumber(txtDiscount.Text, 2)
        txtDiscount2.Text = 0
        txtDiscount2.Text = FormatNumber(txtDiscount2.Text, 2)
        txtTotal.Text = 0
        txtTotal.Text = FormatNumber(txtTotal.Text, 2)
        txtTotal2.Text = 0
        txtTotal2.Text = FormatNumber(txtTotal2.Text, 2)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DataGridViewPOS2.Rows.Count = 0 Then
            MsgBox("กรุณาย้ายรายการบิล", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txtBill1.Text = Nothing Then
            MsgBox("กรุณาเลือกบิล", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ModuleManageTable.btnSaveSplitBill()
        Me.Close()
        Main2.TabControlMain.SelectedTabPageIndex = 1
        FrmTable.TopLevel = False
        FrmTable.FormBorderStyle = FormBorderStyle.None
        FrmTable.WindowState = FormWindowState.Maximized
        FrmTable.Dock = DockStyle.Fill
        FrmTable.LoadRefresh()
        Main2.XtraTabPage2.Controls.Add(FrmTable)
        FrmTable.Show()
        TableId = 0
    End Sub

    Private Sub BtnSearchBill1_Click(sender As Object, e As EventArgs) Handles BtnSearchBill1.Click

        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmSplitBill.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.2
            plexi.Show()
            'FrmSplitBill.FlowLayoutPanelBillList.Controls.Clear()
            FrmSplitBill.StartPosition = FormStartPosition.CenterParent
            FrmSplitBill.ShowDialog(plexi)
        End Using
    End Sub
    Sub change_to_th_text()
        Label36.Text = My.Resources.pos_splitTable_th.splitBill
        Label4.Text = My.Resources.pos_splitTable_th.manageBill
        Label5.Text = My.Resources.pos_splitTable_th._event
        btnSave.Text = My.Resources.pos_splitTable_th.save
        Label9.Text = My.Resources.pos_splitTable_th.billName
        Label14.Text = My.Resources.pos_splitTable_th.newBill
        Label3.Text = My.Resources.pos_splitTable_th.subTotal
        Label11.Text = My.Resources.pos_splitTable_th.subTotal
        Label1.Text = My.Resources.pos_splitTable_th.discount
        Label8.Text = My.Resources.pos_splitTable_th.discount
        Label7.Text = My.Resources.pos_splitTable_th.total
        Label16.Text = My.Resources.pos_splitTable_th.total

        DataGridViewPOS.Columns(0).HeaderText = My.Resources.pos_splitTable_th.list
        DataGridViewPOS.Columns(1).HeaderText = My.Resources.pos_splitTable_th.qty
        DataGridViewPOS.Columns(3).HeaderText = My.Resources.pos_splitTable_th.totalprice
        DataGridViewPOS.Columns(13).HeaderText = My.Resources.pos_splitTable_th._select

        DataGridViewPOS2.Columns(0).HeaderText = My.Resources.pos_splitTable_th.list
        DataGridViewPOS2.Columns(1).HeaderText = My.Resources.pos_splitTable_th.qty
        DataGridViewPOS2.Columns(3).HeaderText = My.Resources.pos_splitTable_th.totalprice
        DataGridViewPOS2.Columns(13).HeaderText = My.Resources.pos_splitTable_th._select
    End Sub
    Sub change_to_eng_text()

    End Sub
End Class