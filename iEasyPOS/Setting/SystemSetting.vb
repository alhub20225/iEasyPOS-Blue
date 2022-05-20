Public Class SystemSetting

    Private Sub HardSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        writeLog("User ID " + Frm_Login.UserId.ToString + " System Setting")
        If SettingList.UsePosTable = 1 Then
            CheckUseTable.CheckState = CheckState.Checked
        Else
            CheckUseTable.Checked = CheckState.Unchecked
        End If
        If SettingList.PosImge = 1 Then
            CheckBoxPosImge.Checked = True
        Else
            CheckBoxPosImge.Checked = False
        End If
        LoadPrinter()
        ReceipText()

        NumericBill.Text = My.Settings.BillCopies
        NumericItemHeight.Text = My.Settings.ButtonItemSize.Height
        NumericCateHeight.Text = My.Settings.ButtonCateSize.Height
        FontEdit1.Text = My.Settings.ButtonFont.Name
        NumericFontSize.Text = My.Settings.ButtonFont.Size
        NumericComport.Text = My.Settings.Comport
        NumericItemColumn.Text = My.Settings.ItemColumn
        NumericReportCopie.Text = My.Settings.ReportCopies
        NumericReportCloseShift.Text = My.Settings.ReportCloseShift_copies
        NumericCloseShiftPrint.Text = My.Settings.CloseShiftPrint_copies

        If My.Settings.PrintOrder = True Then
            CheckBoxPrintOrder.CheckState = CheckState.Checked
        Else
            CheckBoxPrintOrder.CheckState = CheckState.Unchecked
        End If

        If My.Settings.isDelivery = True Then
            CheckBoxDelivery.CheckState = CheckState.Checked
        Else
            CheckBoxDelivery.CheckState = CheckState.Unchecked
        End If
    End Sub
    Sub LoadPrinter()
        DropDownPrinterName.Properties.Items.Clear()
        Dim i As Integer
        Dim RecieptPrinter As String
        For i = 0 To System.Drawing.Printing.PrinterSettings.
          InstalledPrinters.Count - 1
            RecieptPrinter = System.Drawing.Printing.PrinterSettings.
              InstalledPrinters.Item(i)
            DropDownPrinterName.Properties.Items.Add(RecieptPrinter)
        Next

        'Dim GetPrinterName As DataTable = executesql("Select SettingValue From Setting Where SettingId=1")
        DropDownPrinterName.Text = SettingList.PrinterReceipt

        'Dim GetPrintOption As DataTable = executesql("Select SettingValue From Setting Where SettingId=6")
        If SettingList.AlwaysPrintReceipt = 1 Then
            CheckBoxPrintOption.CheckState = CheckState.Checked
        Else CheckBoxPrintOption.CheckState = CheckState.Unchecked
        End If

    End Sub


    Private Sub BtnSaveReceipText_Click(sender As Object, e As EventArgs) Handles BtnSaveReceipText.Click
        executesql("Update Setting Set SettingValue='" & txtHeader1.Text & "' Where SettingId=2")
        executesql("Update Setting Set SettingValue='" & txtHeader2.Text & "' Where SettingId=3")
        executesql("Update Setting Set SettingValue='" & txtFooter1.Text & "' Where SettingId=4")
        executesql("Update Setting Set SettingValue='" & txtFooter2.Text & "' Where SettingId=5")

        executesql("Update Setting Set SettingValue='" & DropDownPrinterName.Text & "' Where SettingId=1")

        executesql("Update Setting Set SettingValue='" & CheckBoxPrintOption.CheckState & "' Where SettingId=6")

        executesql("Update Setting Set SettingValue='" & CheckUseTable.CheckState & "' Where SettingId=8")

        executesql("Update Setting Set SettingValue='" & CheckBoxPosImge.CheckState & "' Where SettingId=9")

        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

        ReceipText()

        My.Settings.BillCopies = NumericBill.Text
        My.Settings.ButtonItemSize = New Size(100, CInt(NumericItemHeight.Text))
        My.Settings.ButtonCateSize = New Size(100, CInt(NumericCateHeight.Text))
        My.Settings.ButtonFont = New Drawing.Font(FontEdit1.Text, CSng(NumericFontSize.Text), FontStyle.Regular)
        My.Settings.Comport = NumericComport.Text
        My.Settings.ItemColumn = NumericItemColumn.Text
        My.Settings.ReportCopies = NumericReportCopie.Text
        My.Settings.ReportCloseShift_copies = NumericReportCloseShift.Text
        My.Settings.CloseShiftPrint_copies = NumericCloseShiftPrint.Text
        My.Settings.PrintOrder = CheckBoxPrintOrder.CheckState
        My.Settings.Save()
        writeLog("User ID " + Frm_Login.UserId.ToString + " System setting save")
        LoadSetting()
    End Sub
    Sub ReceipText()

        'Dim GetHeader1 As DataTable = executesql("Select SettingValue From Setting Where SettingId=2")
        txtHeader1.Text = SettingList.ReceiptHeader1

        'Dim GetHeader2 As DataTable = executesql("Select SettingValue From Setting Where SettingId=3")
        txtHeader2.Text = SettingList.ReceiptHeader2

        'Dim GetFooter1 As DataTable = executesql("Select SettingValue From Setting Where SettingId=4")
        txtFooter1.Text = SettingList.ReceiptFooter1

        'Dim GetFooter2 As DataTable = executesql("Select SettingValue From Setting Where SettingId=5")
        txtFooter2.Text = SettingList.ReceiptFooter2
    End Sub

    Sub change_to_th_text()
        Label2.Text = My.Resources.settingSystem_th.settingPrinterReceipt
        Label3.Text = My.Resources.settingSystem_th.copy
        Label26.Text = My.Resources.settingSystem_th.allowPrint
        Label7.Text = My.Resources.settingSystem_th.copyReportSaleCloseShift
        Label9.Text = My.Resources.settingSystem_th.copyReportCloseShift
        Label4.Text = My.Resources.settingSystem_th.copyCloseShift
        Label18.Text = My.Resources.settingSystem_th.settingReceipt
        Label17.Text = My.Resources.settingSystem_th.header
        Label11.Text = My.Resources.settingSystem_th.header2
        Label13.Text = My.Resources.settingSystem_th.bottom2
        Label10.Text = My.Resources.settingSystem_th.bottom
        Label6.Text = My.Resources.settingSystem_th.more
        Label21.Text = My.Resources.settingSystem_th.tablesystem
        Label5.Text = My.Resources.settingSystem_th.allowPrintOrder
        Label19.Text = My.Resources.settingSystem_th.showImageProduct
        Label25.Text = My.Resources.settingSystem_th.settingButtonProduct
        Label24.Text = My.Resources.settingSystem_th.categoryHeight
        Label22.Text = My.Resources.settingSystem_th.productHeight
        Label20.Text = My.Resources.settingSystem_th.rows
        BtnSavePrinterSetting.Text = My.Resources.settingSystem_th.save
        BtnSaveReceipText.Text = My.Resources.settingSystem_th.save
    End Sub
    Sub change_to_eng_text()
        Label2.Text = My.Resources.settingSystem_en.settingPrinterReceipt
        Label3.Text = My.Resources.settingSystem_en.copy
        Label26.Text = My.Resources.settingSystem_en.allowPrint
        Label7.Text = My.Resources.settingSystem_en.copyReportSaleCloseShift
        Label9.Text = My.Resources.settingSystem_en.copyReportCloseShift
        Label4.Text = My.Resources.settingSystem_en.copyCloseShift
        Label18.Text = My.Resources.settingSystem_en.settingReceipt
        Label17.Text = My.Resources.settingSystem_en.header
        Label11.Text = My.Resources.settingSystem_en.header2
        Label13.Text = My.Resources.settingSystem_en.bottom2
        Label10.Text = My.Resources.settingSystem_en.bottom
        Label6.Text = My.Resources.settingSystem_en.more
        Label21.Text = My.Resources.settingSystem_en.tablesystem
        Label5.Text = My.Resources.settingSystem_en.allowPrintOrder
        Label19.Text = My.Resources.settingSystem_en.showImageProduct
        Label25.Text = My.Resources.settingSystem_en.settingButtonProduct
        Label24.Text = My.Resources.settingSystem_en.categoryHeight
        Label22.Text = My.Resources.settingSystem_en.productHeight
        Label20.Text = My.Resources.settingSystem_en.rows
        BtnSavePrinterSetting.Text = My.Resources.settingSystem_en.save
        BtnSaveReceipText.Text = My.Resources.settingSystem_en.save
    End Sub

    Private Sub CheckBoxPrintOrder_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPrintOrder.CheckedChanged
        My.Settings.PrintOrder = CheckBoxPrintOrder.Checked
    End Sub

    Private Sub CheckBoxDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDelivery.CheckedChanged
        My.Settings.isDelivery = CheckBoxDelivery.Checked
    End Sub
End Class