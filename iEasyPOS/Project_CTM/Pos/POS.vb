Imports DevExpress.XtraReports.UI

Public Class POS
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Width = My.Settings.Panel_POS_size.Width
        Panel14.Height = My.Settings.Split1_panel1.Height
        DiscountByItem2 = 0
        Timer1.Start()
        ModuleCheckRoles.CheckRolesUserAuthority()
        If TableId = 0 Then
            ModulePOS.LoadUser()
            ModulePOS.LoadCategory()
        Else
            ModulePosTable.LoadUser()
            ModulePosTable.LoadCategory()
        End If
        DataGridViewPOS.Rows.Clear()
        DataGridViewPOS.ClearSelection()

        'customer
        Button2.Visible = False
        txtItemCode.Focus()

        If TableId = 0 Then
            RadButton9.Visible = False
            RadButton10.Visible = False
            btnGroupTable.Visible = False
            RadBtnSaveOrder.Visible = False 'ปุ่มบันทึก
        Else
            RadBtnSaveOrder.Visible = True 'ปุ่มบันทึก
            RadButton9.Visible = True
            RadButton10.Visible = True
            btnGroupTable.Visible = True
        End If
        '        Dim selectcheckPoint As DataTable = executesql("Select GiftValue.DiscountPer,GiftValue.DiscountB,GiftValue.GetFree,GiftValue.Point,ConditionPromotion.ConDateStart,ConditionPromotion.ConDateEnd,ConditionPromotion.ConTimeStart,ConditionPromotion.ConTimeEnd 
        'From PromotionItem 
        'inner join Promotion on(Promotion.ProId = PromotionItem.PromotionId)
        'inner join ConditionPromotion on(ConditionPromotion.ConId = Promotion.ConditionId)
        'inner join GiftValue on(GiftValue.GiftId = ConditionPromotion.GiftId)
        'Where PromotionItem.ItemId='1' And PromotionItem.Active ='1'")
        '        If Convert.ToDateTime(selectcheckPoint(0)("ConTimeStart")).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) <= Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) And Convert.ToDateTime(selectcheckPoint(0)("ConTimeStart")).ToString("HH:mm:ss", New System.Globalization.CultureInfo("th-TH")) <= Convert.ToDateTime(Now).ToString("HH:mm:ss", New System.Globalization.CultureInfo("th-TH")) Then
        '            MsgBox(Convert.ToDateTime(selectcheckPoint(0)("ConTimeStart")).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) >= Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH")) And Convert.ToDateTime(selectcheckPoint(0)("ConTimeStart")).ToString("HH:mm:ss", New System.Globalization.CultureInfo("th-TH")) >= Convert.ToDateTime(Now).ToString("HH:mm:ss", New System.Globalization.CultureInfo("th-TH")))
        '        Else
        '            MsgBox(2)
        '        End If
        'FlowLayoutPanel1.Controls.OfType<VScrollBar>().First().Width = 20
    End Sub
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnClosing(e)
        My.Settings.Panel_POS_size = Panel1.Size
        My.Settings.Split1_panel1 = Panel14.Size
        My.Settings.Save()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Pos_payment.Show()
    End Sub

    Private Sub btnPosClose_Click(sender As Object, e As EventArgs) Handles btnPosClose.Click
        SaleItemNoSave()
        Me.Close()
        Main.Close()
        Main.Show()
    End Sub

    Private Sub RectangleShape7_Click(sender As Object, e As EventArgs)
        Pos_AddAmount.ShowDialog()
        Pos_AddAmount.txtAmount.Focus()
    End Sub
    Private Sub Label15_Click(sender As Object, e As EventArgs)
        Pos_AddAmount.ShowDialog()
        Pos_AddAmount.txtAmount.Focus()
        'ModulePOS.AddAmount()
    End Sub
    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs)
        ModulePOS.AddDiscountPercent()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs)
        Pos_DiscountPercent.ShowDialog()
        Pos_DiscountPercent.txtDiscPercent.Focus()
        'ModulePOS.AddDiscountPercent()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        Pos_Discount.ShowDialog()
        Pos_Discount.txtDiscount.Focus()
        'ModulePOS.AddDiscount()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        ModulePOS.DelItem()
    End Sub

    Private Sub RectangleShape8_Click(sender As Object, e As EventArgs)
        ModulePOS.DelItem()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        ModulePOS.CancelBill()
    End Sub
    Private Sub RectangleShape10_Click(sender As Object, e As EventArgs)
        ModulePOS.CancelBill()
    End Sub
    Public DiscountByItem2 As Integer
    Private Sub DataGridViewPOS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPOS.CellDoubleClick
        Try
            Dim checkItemIsDiscount As DataTable = executesql("SELECT AllowDC FROM Item WHERE ItemId = '" & DataGridViewPOS.CurrentRow.Cells("ItemId").Value & "'")
            If checkItemIsDiscount(0)("AllowDC") = 0 Then
                MsgBox("สินค้านี้ไม่สามารถใช้ส่วนลดได้", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            If DiscountByItem2 = 2 Then
                MsgBox("มีส่วนลดต่อบิลแล้ว")
                Exit Sub
            End If
            'POS.DiscountByItem2 = 1
            'Pos_DiscountByItem.Close()
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Pos_DiscountByItem.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.7
                plexi.Show()
                Pos_DiscountByItem.StartPosition = FormStartPosition.CenterParent
                Pos_DiscountByItem.ShowDialog(plexi)
            End Using
            'Pos_DiscountByItem.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSeeSaveSale_Click(sender As Object, e As EventArgs)
        'Pos_SaveSale.Close()
        Pos_SaveSale.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtPosTime.Text = TimeOfDay
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
        Else
            ModulePrintPosSlip.PrintBillCheck()
        End If

    End Sub

    'Private Sub BtnPay_Click(sender As Object, e As EventArgs)
    '    Pos_payment.Close()
    '    Pos_payment.Show()
    'End Sub

    Private Sub ToptabPos_DoubleClick(sender As Object, e As EventArgs) Handles ToptabPos.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
        Else
            Me.WindowState = FormWindowState.Maximized
            Me.StartPosition = FormStartPosition.CenterScreen
        End If
    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub ToptabPos_MouseDown(sender As Object, e As MouseEventArgs) Handles ToptabPos.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub ToptabPos_MouseUp(sender As Object, e As MouseEventArgs) Handles ToptabPos.MouseUp
        drag = False
    End Sub

    Private Sub ToptabPos_MouseMove(sender As Object, e As MouseEventArgs) Handles ToptabPos.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub RadBtnPay_Click(sender As Object, e As EventArgs) Handles RadBtnPay.Click
        txtItemCode.Focus()
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
        Else
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Pos_payment.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.7
                plexi.Show()
                Pos_payment.StartPosition = FormStartPosition.CenterParent
                Pos_payment.ShowDialog(plexi)
            End Using
            'Pos_payment.ShowDialog()
            'Pos_payment.Show()
        End If
    End Sub

    Private Sub RadBtnSaveOrder_Click(sender As Object, e As EventArgs) Handles RadBtnSaveOrder.Click
        If TableId = 0 Then
            If DataGridViewPOS.RowCount = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                'Pos_SaveSaleName.Close()
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(Pos_SaveSaleName.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.7
                    plexi.Show()
                    Pos_SaveSaleName.StartPosition = FormStartPosition.CenterParent
                    Pos_SaveSaleName.ShowDialog(plexi)
                End Using
                'Pos_SaveSaleName.ShowDialog()
            End If
        Else
            If DataGridViewPOS.RowCount = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                ModulePosTable.SaveSaleTable()
                ModulePrinrOrder.PrintOrderTable()
                Me.Close()
                Table.Close()
                Table.Show()
            End If
        End If
    End Sub
    Private Sub BtnDiscPerCent_Click(sender As Object, e As EventArgs) Handles BtnDiscPerCent.Click
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        If DiscountByItem2 = 1 Then
            MsgBox("มีส่วนลดต่อชิ้นแล้ว", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        'POS.DiscountByItem2 = 2

        'Dim checkItemIsDiscount As DataTable = executesql("SELECT AllowDC FROM Item WHERE ItemId = '" & DataGridViewPOS.CurrentRow.Cells("ItemId").Value & "'")
        'If checkItemIsDiscount(0)("AllowDC") = 0 Then
        '    MsgBox("สินค้านี้ไม่สามารถใช้ส่วนลดได้", MsgBoxStyle.Critical, "คำเตือน")
        '    Exit Sub
        'End If
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_DiscountPercent.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            Pos_DiscountPercent.StartPosition = FormStartPosition.CenterParent
            Pos_DiscountPercent.ShowDialog(plexi)
        End Using
        'Pos_DiscountPercent.ShowDialog()
        Pos_DiscountPercent.txtDiscPercent.Focus()
    End Sub
    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles RadButton8.Click
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        If DiscountByItem2 = 1 Then 'And DataGridViewPOS.CurrentRow.Cells("AllowDC").Value = 1
            MsgBox("มีส่วนลดต่อชิ้นแล้ว", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        'POS.DiscountByItem2 = 2

        'Dim checkItemIsDiscount As DataTable = executesql("SELECT AllowDC FROM Item WHERE ItemId = '" & DataGridViewPOS.CurrentRow.Cells("ItemId").Value & "'")
        'If checkItemIsDiscount(0)("AllowDC") = 0 Then
        '    MsgBox("สินค้านี้ไม่สามารถใช้ส่วนลดได้", MsgBoxStyle.Critical, "คำเตือน")
        '    Exit Sub
        'End If
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_Discount.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            Pos_Discount.StartPosition = FormStartPosition.CenterParent
            Pos_Discount.ShowDialog(plexi)
        End Using
        'Pos_Discount.ShowDialog()
        Pos_Discount.txtDiscount.Focus()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        If GetSaleId = 0 Then
            MsgBox("กรุณาเลือกรายการพักการขาย", MsgBoxStyle.Critical, "คำเตือน")
        Else
            ModulePrintPosSlip.PrintBillCheck()
        End If
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        ElseIf DataGridViewPOS.SelectedRows.Count = 0 Then
            MsgBox("กรุณากดเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        Else
            ToppingList.Show()
        End If

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If TableId = 0 Then
            If DataGridViewPOS.RowCount = 0 Then
                ModulePosTable.CancelBill()
            Else
                If MsgBox("ต้องการยกเลิกการขายหรือไม่", MsgBoxStyle.OkCancel, "ยกเลิกการขาย") = MsgBoxResult.Ok Then
                    DiscountByItem2 = 0
                    ModulePOS.CancelBill()
                    GetSaleId = 0
                    'customer
                    btnUsePoint.Visible = False
                    Button2.Visible = False
                    FrmCustomerMemberNo.customerMemNo = 0
                Else
                    Exit Sub
                End If
            End If
        Else
            If DataGridViewPOS.RowCount = 0 Then
                'If MsgBox("ต้องการยกเลิกการขายหรือไม่", MsgBoxStyle.OkCancel, "ยกเลิกการขาย") = MsgBoxResult.Ok Then
                '    ModulePosTable.CancelBill()
                'Else
                Exit Sub
                'End If

            Else
                If MsgBox("ต้องการยกเลิกการขายหรือไม่", MsgBoxStyle.OkCancel, "ยกเลิกการขาย") = MsgBoxResult.Ok Then
                    ModulePosTable.CancelBill()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        If TableId = 0 Then
            DiscountByItem2 = 0
            ModulePOS.DelItem()
        Else
            ModulePosTable.DelItem()
            Exit Sub
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_AddAmount.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            Pos_AddAmount.StartPosition = FormStartPosition.CenterParent
            Pos_AddAmount.ShowDialog(plexi)
        End Using
        Pos_AddAmount.txtAmount.Clear()
        'Pos_AddAmount.ShowDialog()
        Pos_AddAmount.txtAmount.Focus()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

    End Sub

    Private Sub BtnOpenSaveSale_Click(sender As Object, e As EventArgs) Handles BtnOpenSaveSale.Click
        'Pos_SaveSale.Close()
        Pos_SaveSale.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmUsePoint.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            FrmUsePoint.StartPosition = FormStartPosition.CenterParent
            FrmUsePoint.ShowDialog(plexi)
        End Using
        'FrmUsePoint.ShowDialog()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmCustomerMemberNo.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            FrmCustomerMemberNo.StartPosition = FormStartPosition.CenterParent
            FrmCustomerMemberNo.ShowDialog(plexi)
        End Using
        'FrmCustomerMemberNo.ShowDialog()
    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim selectItemId As DataTable = executesql("SELECT ItemId FROM Item WHERE ItemCode='" & txtItemCode.Text & "'")
            If selectItemId.Rows.Count > 0 Then
                ModulePOS.AddItemFromBarCode(selectItemId(0)("ItemId"))
                ModulePosPromotion.checkPromotion()
                txtItemCode.Clear()
            Else
                MsgBox("ไม่พบข้อมูลสินค้า", MsgBoxStyle.Critical, "คำเตือน")
                txtItemCode.Clear()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            txtItemCode.Focus()
            If DataGridViewPOS.RowCount = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(Pos_payment.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.7
                    plexi.Show()
                    Pos_payment.StartPosition = FormStartPosition.CenterParent
                    Pos_payment.ShowDialog(plexi)
                End Using

            End If
        End If
    End Sub

    Private Sub DataGridViewPOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPOS.CellClick
        If DataGridViewPOS.RowCount = 0 Then
            Exit Sub
        End If
        ModulePOS.ItemId = DataGridViewPOS.CurrentRow.Cells("ItemId").Value
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Frm_PreviewSpotCheck.Show()
    End Sub
    Public Shared TableManageTypeId As Integer = 0
    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles RadButton9.Click
        If DataGridViewPOS.Rows.Count = 0 Then
            MsgBox("สั่งอาหารก่อนทำรายการ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        TableManageTypeId = 1
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmTable_Manage.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            FrmTable_Manage.StartPosition = FormStartPosition.CenterParent
            FrmTable_Manage.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub btnGroupTable_Click(sender As Object, e As EventArgs) Handles btnGroupTable.Click
        If TableId = 0 Then
            btnGroupTable.Visible = False
        Else
            If DataGridViewPOS.Rows.Count = 0 Then
                MsgBox("สั่งอาหารก่อนทำรายการ", MsgBoxStyle.Critical)
                Exit Sub
            End If
            TableManageTypeId = 2
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(FrmTable_Manage.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.7
                plexi.Show()
                FrmTable_Manage.StartPosition = FormStartPosition.CenterParent
                FrmTable_Manage.ShowDialog(plexi)
            End Using
        End If
    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click
        If DataGridViewPOS.Rows.Count = 0 Then
            MsgBox("สั่งอาหารก่อนทำรายการ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        FrmTable_Manage.FlowLayoutPanelZone.Controls.Clear()
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmSplitBill.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.7
            plexi.Show()
            FrmSplitBill.StartPosition = FormStartPosition.CenterParent
            FrmSplitBill.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnWithdraw_Click(sender As Object, e As EventArgs) Handles BtnWithdraw.Click
        FrmWithdrawMoney.ShowDialog()
    End Sub
End Class