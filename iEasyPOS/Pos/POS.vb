Imports DevExpress.XtraReports.UI

Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel
Public Class POS
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        BtnMember.Visible = True
        Panel1.Height = 42

        Panel15.Visible = True
        Panel28.Visible = False
        Me.Refresh()
        If BtnPoint.Enabled = False Then
            BtnPoint.ForeColor = Color.Gray
        Else
            BtnPoint.ForeColor = Color.FromArgb(65, 73, 86)
        End If

        DataGridViewPOS.RowTemplate.Height = 35
        Panel7.Width = My.Settings.Panel_POS_size.Width
        Panel5.Height = My.Settings.Split1_panel1.Height
        DiscountByItem2 = 0
        'Timer1.Start()
        ModuleCheckRoles.CheckRolesUserAuthority()
        ModulePOS.LoadUser()
        ModulePOS.LoadCategory()

        DataGridViewPOS.Rows.Clear()
        DataGridViewPOS.ClearSelection()

        'txtTotal.Text = 0
        txtTotal.Text = FormatNumber(0, 2)
        txtDiscount.Text = FormatNumber(0, 2)
        txtSubTotal.Text = FormatNumber(0, 2)

        If TableId = 0 Then
            BtnDelSale.Text = "ยกเลิกการขาย"
        Else
            BtnDelSale.Text = "ยกเลิกโต๊ะ"
        End If

        'customer

        TextBox3.Focus()

        'If TableId = 0 Then
        '    BtnCheck.Visible = False
        '    BtnMoveTable.Visible = False
        '    BtnSplitBill.Visible = False
        '    BtnGroupTable.Visible = False
        '    BtnSaveOrder.Visible = False 'ปุ่มบันทึก
        'Else
        '    BtnCheck.Visible = True
        '    BtnSaveOrder.Visible = True 'ปุ่มบันทึก
        '    BtnMoveTable.Visible = True
        '    BtnSplitBill.Visible = True
        '    BtnGroupTable.Visible = True
        'End If
        DataGridViewPOS.DefaultCellStyle.Font = My.Settings.ButtonFont
        DataGridViewPOS.RowsDefaultCellStyle.Font = My.Settings.ButtonFont
        DataGridViewPOS.AlternatingRowsDefaultCellStyle.Font = My.Settings.ButtonFont

        BtnOpenSaveSale.Visible = False

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

    Private Sub btnPosClose_Click(sender As Object, e As EventArgs)
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
        'Try
        '    Dim checkItemIsDiscount As DataTable = executesql("SELECT AllowDC FROM Item WHERE ItemId = '" & DataGridViewPOS.CurrentRow.Cells("ItemId").Value & "'")
        '    If checkItemIsDiscount(0)("AllowDC") = 0 Then
        '        MsgBox("สินค้านี้ไม่สามารถใช้ส่วนลดได้", MsgBoxStyle.Critical, "คำเตือน")
        '        Exit Sub
        '    End If
        '    If DiscountByItem2 = 2 Then
        '        MsgBox("มีส่วนลดต่อบิลแล้ว")
        '        Exit Sub
        '    End If
        '    'POS.DiscountByItem2 = 1
        '    'Pos_DiscountByItem.Close()

        'If dtRolesUser.cancleSale = True Then
        '    Using plexi = New Form()
        '        plexi.FormBorderStyle = FormBorderStyle.None
        '        plexi.Bounds = Screen.FromPoint(POS_Price.Location).Bounds
        '        plexi.StartPosition = FormStartPosition.Manual
        '        plexi.AutoScaleMode = AutoScaleMode.None
        '        plexi.ShowInTaskbar = False
        '        plexi.BackColor = Color.Black
        '        plexi.Opacity = 0.6
        '        plexi.Show()
        '        POS_Price.StartPosition = FormStartPosition.CenterParent
        '        POS_Price.ShowDialog(plexi)
        '    End Using
        'Else
        '    Exit Sub
        'End If

        '    'Pos_DiscountByItem.ShowDialog()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnSeeSaveSale_Click(sender As Object, e As EventArgs)
        'Pos_SaveSale.Close()
        Pos_SaveSale.ShowDialog()
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    txtPosTime.Text = TimeOfDay
    'End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)
        If DataGridViewPOS.RowCount = 0 Then
            If Frm_Login.language = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
            End If

        Else
            ModulePrintPosSlip.PrintBillCheck()
        End If

    End Sub

    'Private Sub BtnPay_Click(sender As Object, e As EventArgs)
    '    Pos_payment.Close()
    '    Pos_payment.Show()
    'End Sub

    Private Sub ToptabPos_DoubleClick(sender As Object, e As EventArgs)
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
    Private Sub ToptabPos_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub ToptabPos_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub

    Private Sub ToptabPos_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmUsePoint.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmUsePoint.StartPosition = FormStartPosition.CenterParent
            FrmUsePoint.ShowDialog(plexi)
        End Using
        'FrmUsePoint.ShowDialog()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs)

        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmCustomerMemberNo.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmCustomerMemberNo.StartPosition = FormStartPosition.CenterParent
            FrmCustomerMemberNo.ShowDialog(plexi)
        End Using
        'FrmCustomerMemberNo.ShowDialog()
    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown

        If e.KeyCode = Keys.Enter Then
            writeLog("UserID " + Frm_Login.UserId.ToString + " Scan barcode " + TextBox3.Text)
            Dim txt_txtItemCode As String = TextBox3.Text
            For Each txt_number As String In txt_txtItemCode
                If Not IsNumeric(txt_number) Then

                    If Frm_Login.language = 0 Then
                        MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข  / เปลี่ยนคีย์เป็น EN", "โปรดระวัง !!!     ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("Please enter numeric data only.", "warning !!!     ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                    TextBox3.Clear()
                    TextBox3.Focus()
                    Exit Sub
                    Exit For
                End If
            Next

            Dim selectItemId As DataTable = executesql("SELECT ItemId FROM Item WHERE ItemCode='" & TextBox3.Text & "'")
            If selectItemId.Rows.Count > 0 Then
                ModulePOS.AddItemFromBarCode(selectItemId(0)("ItemId"))
                ModulePosPromotion.checkPromotion()
                TextBox3.Clear()
            Else

                If Frm_Login.language = 0 Then
                    MsgBox("ไม่พบข้อมูลสินค้า", MsgBoxStyle.Critical, "คำเตือน")
                Else
                    MsgBox("No Data.", MsgBoxStyle.Critical, "คำเตือน")
                End If
                TextBox3.Clear()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            TextBox3.Focus()
            If DataGridViewPOS.RowCount = 0 Then
                If Frm_Login.language = 0 Then
                    MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
                Else
                    MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
                End If
            Else
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(Pos_payment.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.6
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

        If DataGridViewPOS.CurrentCell.ColumnIndex = 13 Then
            If DataGridViewPOS.RowCount = 0 Then
                If Frm_Login.language = 0 Then
                    MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
                Else
                    MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
                End If
                Exit Sub
            End If
            If TableId = 0 Then
                DiscountByItem2 = 0
                writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDelItem ItemId:" + DataGridViewPOS.CurrentRow.Cells(4).Value.ToString)
                ModulePOS.DelItem()
            Else
                writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDelItem ItemId:" + DataGridViewPOS.CurrentRow.Cells(4).Value.ToString)
                ModulePosTable.DelItem()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " Spot check")
        Frm_PreviewSpotCheck.Show()
    End Sub
    Public Shared TableManageTypeId As Integer = 0


    Private Sub FlowLayoutPanelCategory_SizeChanged(sender As Object, e As EventArgs) Handles FlowLayoutPanelCategory.SizeChanged
        'ModulePosTable.LoadCategory

    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click
        'ModulePOS.GetItem_Next()
        ModulePOS.LoadPage(True)
    End Sub

    Private Sub BtnBackPage_Click(sender As Object, e As EventArgs) Handles BtnBackPage.Click
        'ModulePOS.GetItem_Back()
        ModulePOS.LoadPage(False)
    End Sub

    Private Sub BtnOpenSaveSale_Click_1(sender As Object, e As EventArgs) Handles BtnOpenSaveSale.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_SaveSale.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            Pos_SaveSale.StartPosition = FormStartPosition.CenterParent
            Pos_SaveSale.ShowDialog(plexi)
        End Using
        'Pos_SaveSale.ShowDialog()
    End Sub

    Private Sub BtnQty_Click(sender As Object, e As EventArgs) Handles BtnQty.Click
        If DataGridViewPOS.RowCount = 0 Then
            If Frm_Login.language = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
            End If
            Exit Sub
        End If
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_AddAmount.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            Pos_AddAmount.StartPosition = FormStartPosition.CenterParent
            Pos_AddAmount.ShowDialog(plexi)
        End Using
        writeLog("User ID " + Frm_Login.UserId.ToString + " Btn Qty.Click")
        Pos_AddAmount.txtAmount.Clear()
        'Pos_AddAmount.ShowDialog()
        Pos_AddAmount.txtAmount.Focus()
    End Sub

    Private Sub BtnDiscPerCent_Click_1(sender As Object, e As EventArgs) Handles BtnDiscPerCent.Click
        If DataGridViewPOS.RowCount = 0 Then
            If Frm_Login.language = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
            End If
            Exit Sub
        End If
        If DiscountByItem2 = 1 Then

            If Frm_Login.language = 0 Then
                MsgBox("มีส่วนลดต่อชิ้นแล้ว", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("already have a discount.", MsgBoxStyle.Critical, "warning")
            End If
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
            plexi.Opacity = 0.6
            plexi.Show()
            Pos_DiscountPercent.StartPosition = FormStartPosition.CenterParent
            Pos_DiscountPercent.ShowDialog(plexi)
        End Using
        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDisc Percent.Click")
        'Pos_DiscountPercent.ShowDialog()
        Pos_DiscountPercent.txtDiscPercent.Focus()
    End Sub

    Private Sub BtnDiscBath_Click(sender As Object, e As EventArgs) Handles BtnDiscBath.Click
        If DataGridViewPOS.RowCount = 0 Then
            If Frm_Login.language = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
            End If
            Exit Sub
        End If
        If DiscountByItem2 = 1 Then 'And DataGridViewPOS.CurrentRow.Cells("AllowDC").Value = 1
            If Frm_Login.language = 0 Then
                MsgBox("มีส่วนลดต่อชิ้นแล้ว", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("already have a discount.", MsgBoxStyle.Critical, "warning")
            End If
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
            plexi.Opacity = 0.6
            plexi.Show()
            Pos_Discount.StartPosition = FormStartPosition.CenterParent
            Pos_Discount.ShowDialog(plexi)
        End Using
        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDiscBath.Click")
        'Pos_Discount.ShowDialog()
        Pos_Discount.txtDiscount.Focus()
    End Sub

    Private Sub BtnTopping_Click(sender As Object, e As EventArgs) Handles BtnTopping.Click
        If DataGridViewPOS.RowCount = 0 Then
            MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        ElseIf DataGridViewPOS.SelectedRows.Count = 0 Then
            If Frm_Login.language = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
            End If
            Exit Sub
        Else
            'ToppingList.Show()
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(ToppingList.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.6
                plexi.Show()
                ToppingList.StartPosition = FormStartPosition.CenterParent
                ToppingList.ShowDialog(plexi)
            End Using
        End If
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        If GetSaleId = 0 Then

            If Frm_Login.language = 0 Then
                MsgBox("กรุณาเลือกรายการพักการขาย", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("Please select Save Biil.", MsgBoxStyle.Critical, "warning")
            End If
        Else
            ModulePrintPosSlip.PrintBillCheck()
        End If
    End Sub

    ''Private Sub BtnDelItem_Click(sender As Object, e As EventArgs) Handles BtnDelItem.Click
    ''    If DataGridViewPOS.RowCount = 0 Then
    ''        MsgBox("กรุณาเลิอกรายการสินค้า", MsgBoxStyle.Critical, "คำเตือน")
    ''        Exit Sub
    ''    End If
    ''    If TableId = 0 Then
    ''        DiscountByItem2 = 0
    ''        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDelItem ItemId:" + DataGridViewPOS.CurrentRow.Cells("ItemId").Value)
    ''        ModulePOS.DelItem()
    ''    Else
    ''        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDelItem ItemId:" + DataGridViewPOS.CurrentRow.Cells("ItemId").Value)
    ''        ModulePosTable.DelItem()
    ''        Exit Sub
    ''    End If
    ''End Sub

    Private Sub BtnDelSale_Click(sender As Object, e As EventArgs) Handles BtnDelSale.Click
        If TableId = 0 Then
            If DataGridViewPOS.RowCount = 0 Then
                ModulePOS.CancelBill()
            Else

                If Frm_Login.language = 0 Then
                    If MsgBox("ต้องการยกเลิกการขายหรือไม่", MsgBoxStyle.OkCancel, "ยกเลิกการขาย") = MsgBoxResult.Ok Then
                        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDel Sale.Click Total :" + txtSubTotal.Text)
                        DiscountByItem2 = 0
                        ModulePOS.CancelBill()
                        GetSaleId = 0
                        'customer
                        FrmCustomerMemberNo.CustomerId = 0
                        BtnPoint.Enabled = False
                        PanelMember.Visible = False
                        FrmCustomerMemberNo.customerMemNo = 0
                    Else
                        Exit Sub
                    End If
                Else
                    If MsgBox("Are you sure?", MsgBoxStyle.OkCancel, "Warning") = MsgBoxResult.Ok Then
                        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDel Sale.Click Total :" + txtSubTotal.Text)
                        DiscountByItem2 = 0
                        ModulePOS.CancelBill()
                        GetSaleId = 0
                        'customer
                        FrmCustomerMemberNo.CustomerId = 0
                        BtnPoint.Enabled = False
                        PanelMember.Visible = False
                        FrmCustomerMemberNo.customerMemNo = 0
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Else 'ยกเลิกโต๊ะ
            ModulePosTable.CancelBill()
            'Refresh หน้าโต๊ะ
            Dim MinZone As DataTable = executesql("select min(ZoneId) as ZoneId ,ZoneName from Zones where Active=1 GROUP BY ZoneName")
            If MinZone.Rows.Count = 0 Then
                Exit Sub
            End If
            ModuleZoneTable.LoadTable(MinZone(0)("ZoneId"))
            FrmTable.LbZoneSelect.Text = MinZone(0)("ZoneName")
            FrmTable.LbTableSelect.Text = ""
            ZoneId = MinZone(0)("ZoneId")

            writeLog("User ID " + Frm_Login.UserId.ToString + " BtnDel Sale.Click")
        End If
    End Sub

    Private Sub BtnWithdraw_Click(sender As Object, e As EventArgs) Handles BtnWithdraw.Click
        'FrmWithdrawMoney.ShowDialog()
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmWithdrawMoney.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmWithdrawMoney.StartPosition = FormStartPosition.CenterParent
            FrmWithdrawMoney.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnPayMent_Click(sender As Object, e As EventArgs) Handles BtnPayMent.Click
        'MsgBox(GetSaleId)
        TextBox3.Focus()
        If DataGridViewPOS.RowCount = 0 Then
            If Frm_Login.language = 0 Then
                MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Else
                MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
            End If
        Else
            writeLog("User ID " + Frm_Login.UserId.ToString + " BtnPayMent.Click")
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(Pos_payment.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.6
                plexi.Show()
                Pos_payment.StartPosition = FormStartPosition.CenterParent
                Pos_payment.ShowDialog(plexi)
            End Using
            'Pos_payment.ShowDialog()
            'Pos_payment.Show()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Pos_Search.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            Pos_Search.StartPosition = FormStartPosition.CenterParent
            Pos_Search.ShowDialog(plexi)
        End Using
        'Pos_Search.ShowDialog()
    End Sub

    Private Sub BtnSaveOrder_Click(sender As Object, e As EventArgs) Handles BtnSaveOrder.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " BtnSaveOrder.Click")
        If TableId = 0 Then
            If DataGridViewPOS.RowCount = 0 Then
                If Frm_Login.language = 0 Then
                    MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
                Else
                    MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
                End If
            Else
                'Pos_SaveSaleName.Close()
                Using plexi = New Form()
                    plexi.FormBorderStyle = FormBorderStyle.None
                    plexi.Bounds = Screen.FromPoint(Pos_SaveSaleName.Location).Bounds
                    plexi.StartPosition = FormStartPosition.Manual
                    plexi.AutoScaleMode = AutoScaleMode.None
                    plexi.ShowInTaskbar = False
                    plexi.BackColor = Color.Black
                    plexi.Opacity = 0.6
                    plexi.Show()
                    Pos_SaveSaleName.StartPosition = FormStartPosition.CenterParent
                    Pos_SaveSaleName.ShowDialog(plexi)
                End Using
                'Pos_SaveSaleName.ShowDialog()
            End If
        Else
            If DataGridViewPOS.RowCount = 0 Then
                If Frm_Login.language = 0 Then
                    MsgBox("กรุณาเลือกสินค้า", MsgBoxStyle.Critical, "คำเตือน")
                Else
                    MsgBox("Please select item.", MsgBoxStyle.Critical, "warning")
                End If
            Else
                writeLog("User ID " + Frm_Login.UserId.ToString + " Save Order Table " & TableName)
                ModulePosTable.SaveSaleTable()
                'MsgBox("TB_GetSaleId " & TB_GetSaleId)

                'ModulePrinrOrder.PrintOrderTable(TB_GetSaleId, TableName)

                TB_GetSaleId = 0
                GetSaleId = 0
                'Me.Close()
                'Table.Close()
                'Table.Show()

                Main2.TabControlMain.SelectedTabPageIndex = 1
                Main2.LabelPageName.Text = "โต๊ะและโซน"
                FrmTable.TopLevel = False
                FrmTable.FormBorderStyle = FormBorderStyle.None
                FrmTable.WindowState = FormWindowState.Maximized
                FrmTable.Dock = DockStyle.Fill
                FrmTable.LoadRefresh()
                Main2.XtraTabPage2.Controls.Add(FrmTable)
                FrmTable.Show()
                TableId = 0
            End If
        End If
    End Sub

    Private Sub BtnGroupTable_Click_1(sender As Object, e As EventArgs) Handles BtnGroupTable.Click
        If TableId = 0 Then
            BtnGroupTable.Visible = False
        Else
            If DataGridViewPOS.Rows.Count = 0 Then
                MsgBox("สั่งอาหารก่อนทำรายการ", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If BackColorTable = "violet" Then
                MsgBox("โต๊ะนี้ได้ทำการรวมโต๊ะแล้ว", MsgBoxStyle.Critical)
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
                plexi.Opacity = 0.6
                plexi.Show()
                FrmTable_Manage.StartPosition = FormStartPosition.CenterParent
                FrmTable_Manage.ShowDialog(plexi)
            End Using
        End If
    End Sub

    Private Sub BtnMoveTable_Click(sender As Object, e As EventArgs) Handles BtnMoveTable.Click
        If DataGridViewPOS.Rows.Count = 0 Then
            MsgBox("สั่งอาหารก่อนทำรายการ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If BackColorTable = "violet" Then
            MsgBox("โต๊ะนี้ได้ทำการรวมโต๊ะแล้ว", MsgBoxStyle.Critical)
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
            plexi.Opacity = 0.6
            plexi.Show()
            FrmTable_Manage.StartPosition = FormStartPosition.CenterParent
            FrmTable_Manage.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnSplitBill_Click(sender As Object, e As EventArgs) Handles BtnSplitBill.Click
        If DataGridViewPOS.Rows.Count = 0 Then
            MsgBox("สั่งอาหารก่อนทำรายการ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'FrmTable_Manage.FlowLayoutPanelZone.Controls.Clear()
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmSplitBillMoveOrder.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmSplitBillMoveOrder.StartPosition = FormStartPosition.CenterParent
            FrmSplitBillMoveOrder.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnPoint_Click(sender As Object, e As EventArgs) Handles BtnPoint.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmUsePoint.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmUsePoint.StartPosition = FormStartPosition.CenterParent
            FrmUsePoint.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub BtnMember_Click(sender As Object, e As EventArgs) Handles BtnMember.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmCustomerMemberNo.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmCustomerMemberNo.StartPosition = FormStartPosition.CenterParent
            FrmCustomerMemberNo.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://ieasy.asia/")
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Process.Start("https://ieasy.asia/")
    End Sub
    Sub change_to_eng_text()
        LabelPageName.Text = My.Resources.pos_En.POS
        Label3.Text = My.Resources.pos_En.subTotal
        Label4.Text = My.Resources.pos_En.discount
        Label2.Text = My.Resources.pos_En.total
        BtnSaveOrder.Text = My.Resources.pos_En.save
        BtnDelSale.Text = My.Resources.pos_En.cancelBill
        BtnMember.Text = My.Resources.pos_En.customer
        BtnPoint.Text = My.Resources.pos_En.point
        BtnWithdraw.Text = My.Resources.pos_En.costing
        SimpleButton1.Text = My.Resources.pos_En.daily
        Label34.Text = My.Resources.pos_En.barcode
        Label31.Text = My.Resources.pos_En.barcode
        BtnSearch.Text = My.Resources.pos_En.search
        BtnQty.Text = My.Resources.pos_En.amount
        BtnTopping.Text = My.Resources.pos_En.topping
        BtnDiscBath.Text = My.Resources.pos_En.discountBath
        BtnDiscPerCent.Text = My.Resources.pos_En.discountPercent
        BtnOpenSaveSale.Text = My.Resources.pos_En.saveSale
        BtnCheck.Text = My.Resources.pos_En.Invoice
        BtnGroupTable.Text = My.Resources.pos_En.groupTable
        BtnMoveTable.Text = My.Resources.pos_En.moveTable
        BtnSplitBill.Text = My.Resources.pos_En.splitBill
        BtnPayMent.Text = My.Resources.pos_En.payment
        Label11.Text = My.Resources.pos_En.product

        DataGridViewPOS.Columns(0).HeaderText = My.Resources.pos_En.POS
        DataGridViewPOS.Columns(1).HeaderText = My.Resources.pos_En.qty
        DataGridViewPOS.Columns(3).HeaderText = My.Resources.pos_En.totalprice
    End Sub
    Sub change_to_th_text()
        LabelPageName.Text = My.Resources.pos_Th.POS
        Label3.Text = My.Resources.pos_Th.subTotal
        Label4.Text = My.Resources.pos_Th.discount
        Label2.Text = My.Resources.pos_Th.total
        BtnSaveOrder.Text = My.Resources.pos_Th.save
        BtnDelSale.Text = My.Resources.pos_Th.cancelBill
        BtnMember.Text = My.Resources.pos_Th.customer
        BtnPoint.Text = My.Resources.pos_Th.point
        BtnWithdraw.Text = My.Resources.pos_Th.costing
        SimpleButton1.Text = My.Resources.pos_Th.daily
        Label34.Text = My.Resources.pos_Th.barcode
        Label31.Text = My.Resources.pos_Th.barcode
        BtnSearch.Text = My.Resources.pos_Th.search
        BtnQty.Text = My.Resources.pos_Th.amount
        BtnTopping.Text = My.Resources.pos_Th.topping
        BtnDiscBath.Text = My.Resources.pos_Th.discountBath
        BtnDiscPerCent.Text = My.Resources.pos_Th.discountPercent
        BtnOpenSaveSale.Text = My.Resources.pos_Th.saveSale
        BtnCheck.Text = My.Resources.pos_Th.Invoice
        BtnGroupTable.Text = My.Resources.pos_Th.groupTable
        BtnMoveTable.Text = My.Resources.pos_Th.moveTable
        BtnSplitBill.Text = My.Resources.pos_Th.splitBill
        BtnPayMent.Text = My.Resources.pos_Th.payment
        Label11.Text = My.Resources.pos_Th.product

        DataGridViewPOS.Columns(0).HeaderText = My.Resources.pos_Th.POS
        DataGridViewPOS.Columns(1).HeaderText = My.Resources.pos_Th.qty
        DataGridViewPOS.Columns(3).HeaderText = My.Resources.pos_Th.totalprice
    End Sub

End Class