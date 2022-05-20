
Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading

Public Class Frm_RecallBill
    Private Sub Frm_RecallBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        'Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Frm_Login.ComboLang.Text)
        'Dim res As ComponentResourceManager = New ComponentResourceManager(Me.GetType)
        CheckRolesUserMain2()
        writeLog("User ID " + Frm_Login.UserId.ToString + " Recall bill")
        Panel5.Width = Me.Width / 2
        GridView_SaleDetail.RowTemplate.Height = 35
        GridView_Sale.RowTemplate.Height = 35
        GetSaleId = 0
        Sale_Id = 0
        LoadData(Now, Now)
        GridView_Sale.ClearSelection()
        txtDateTime.DateTime = Now

        If My.Settings.QrThaiParNerId = "" Or My.Settings.QrAliPartnerId = "" Or My.Settings.Comport = 0 Then
            BtnVoid.Visible = False
        Else
            BtnVoid.Visible = True
        End If
        'If My.Settings.QrAliPartnerId = "" Then
        '    BtnVoid.Visible = False
        'End If
        'If My.Settings.Comport = 0 Then
        '    BtnVoid.Visible = False
        'End If
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs)
        GetSaleId = 0
        Sale_Id = 0
        Me.Close()
    End Sub
    Sub LoadData(D1 As Date, D2 As Date)
        GridView_Sale.Rows.Clear()
        Dim Date_src1 As String = Convert.ToDateTime(D1).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Dim Date_src2 As String = Convert.ToDateTime(D2).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))

        Dim DataSale As DataTable = executesql("Select Sale.SaleId,Sale.SaleDate,Sale.SaleNo,Sale.SubTotal,Sale.Active From Sale inner Join PaymentDetail on(Sale.SaleId = PaymentDetail.SaleId) inner Join PaymentType on(PaymentDetail.PaymentTypeId = PaymentType.PaymentId) Where Sale.SaleDate Between CONVERT(datetime, '" & Date_src1 & "', 126) AND CONVERT(datetime, '" & Date_src2 & "', 126) AND Sale.Active in(1,2) GROUP BY Sale.SaleId,Sale.SaleDate,Sale.SaleNo,Sale.SubTotal,Sale.Active")
        If IsNothing(DataSale) Then
            Exit Sub
        ElseIf DataSale.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim PaymentName As String = ""
        For i As Integer = 0 To DataSale.Rows.Count - 1
            Dim selectpaymentDetail As DataTable = executesql("SELECT PaymentType.PaymentName FROM PaymentDetail inner Join PaymentType on(PaymentDetail.PaymentTypeId = PaymentType.PaymentId) WHERE PaymentDetail.SaleId='" & DataSale(i)("SaleId") & "'")
            If selectpaymentDetail.Rows.Count > 1 Then
                PaymentName = ""
                For a As Integer = 0 To selectpaymentDetail.Rows.Count - 1
                    If a = 0 Then
                        PaymentName = selectpaymentDetail(a)("PaymentName")
                    Else
                        PaymentName += "," & selectpaymentDetail(a)("PaymentName")
                    End If
                Next
            Else
                PaymentName = selectpaymentDetail(0)("PaymentName")
            End If
            Dim Sale_Date As String = Convert.ToDateTime(DataSale(i)("SaleDate")).ToString("dd/MM/yyyy  HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            GridView_Sale.Rows.Add(DataSale(i)("SaleNo"), Sale_Date, FormatNumber(DataSale(i)("SubTotal"), 2), DataSale(i)("SaleId"), PaymentName)

            If DataSale(i)("Active") = 2 Then
                GridView_Sale.Rows(i).DefaultCellStyle.ForeColor = Color.Red

            Else
                GridView_Sale.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
    Public Shared Sale_Id As Integer = 0

    Private Sub GridView_Sale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView_Sale.CellClick
        Sale_Id = 0
        GridView_SaleDetail.Rows.Clear()
        Sale_Id = GridView_Sale.CurrentRow.Cells(3).Value
        Dim DataDetail As DataTable = executesql("SELECT ItemCode,ItemName,UnitPrice,Qty,Total,InitPrice,Tax,PercentDC,BahtDC,AmtDC,Active FROM SaleItem WHERE SaleId=" & Sale_Id & " AND Active in (1,2)")
        'MsgBox(Sale_Id)
        For i As Integer = 0 To DataDetail.Rows.Count - 1
            GridView_SaleDetail.Rows.Add(DataDetail(i)("ItemCode"), DataDetail(i)("ItemName"), FormatNumber(DataDetail(i)("UnitPrice"), 2), FormatNumber(DataDetail(i)("Qty"), 0), FormatNumber(DataDetail(i)("Total"), 2))
            If DataDetail(i)("Active") = 2 Then
                GridView_SaleDetail.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            Else
                GridView_SaleDetail.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
        GridView_SaleDetail.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridView_SaleDetail.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridView_SaleDetail.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Dim Data_Disc As DataTable = executesql("SELECT SUM(PercentDC) as PercentDC,SUM(BahtDC) as BahtDC,SUM(AmtDC) as AmtDC FROM SaleItem WHERE SaleId=" & Sale_Id & "")
        Dim DataSale As DataTable = executesql("select SubTotal,Total from Sale where SaleId =" & Sale_Id & "")
        txt_total.Text = FormatNumber(DataSale(0)("Total"), 2)
        'txt_Discount.Text = FormatNumber((Data_Disc(0)("PercentDC") + Data_Disc(0)("BahtDC") + Data_Disc(0)("AmtDC")), 2)
        txt_Discount.Text = FormatNumber(DataSale(0)("SubTotal") - DataSale(0)("Total"), 2)
        txt_Subtotal.Text = FormatNumber(DataSale(0)("SubTotal"), 2)
    End Sub

    Private Sub BtnRePrint_Click(sender As Object, e As EventArgs) Handles BtnRePrint.Click
        If Sale_Id = 0 Then
            MsgBox("กรุณาเลือกรายการ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        ModulePrintPosSlip.PrintSlip(Sale_Id)

        Sale_Id = 0
        GridView_Sale.ClearSelection()
        GridView_SaleDetail.Rows.Clear()
    End Sub

    Private Sub txtDateTime_TextChanged(sender As Object, e As EventArgs) Handles txtDateTime.TextChanged
        LoadData(txtDateTime.DateTime, txtDateTime.DateTime)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Sale_Id = 0
        GridView_Sale.Rows.Clear()
        If txtSearch.Text = "" Then
            LoadData(txtDateTime.DateTime, txtDateTime.DateTime)
        Else
            Dim DataSale As DataTable = executesql("select SaleId,SaleDate,SaleNo,SubTotal from Sale where SaleNo='" & txtSearch.Text & "'")
            If DataSale.Rows.Count = 0 Then
                Exit Sub
            Else
                Dim Sale_Date As String = Convert.ToDateTime(DataSale(0)("SaleDate")).ToString("dd/MM/yyyy  HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
                GridView_Sale.Rows.Add(DataSale(0)("SaleNo"), Sale_Date, FormatNumber(DataSale(0)("SubTotal"), 2), DataSale(0)("SaleId"))
            End If
        End If

    End Sub


    Private Sub BtnVoid_Click(sender As Object, e As EventArgs) Handles BtnVoid.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Frm_Void.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            Frm_Void.StartPosition = FormStartPosition.CenterParent
            Frm_Void.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub btnDeleteSale_Click(sender As Object, e As EventArgs) Handles btnDeleteSale.Click
        If Sale_Id = 0 Then
            MsgBox("กรุณาเลิอกรายการบิล", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        If MsgBox("ต้องการยกเลิกการขายหรือไม่", MsgBoxStyle.OkCancel, "ยกเลิกบิลการขาย") = MsgBoxResult.Ok Then
            Dim CheckSale As DataTable = executesql("select partnerTxnUid from Sale where SaleId='" & Sale_Id & "'")
            If IsDBNull(CheckSale(0)("partnerTxnUid")) Then
                Dim Datetime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
                Dim idUser As DataTable = executesql("SELECT UserId FROM Users WHERE FirstName='" & Frm_Login.UserName & "'")
                executesql("UPDATE Sale set Active = 2,VoidDate=CONVERT(datetime, '" & Datetime & "', 126),VoidUserId='" & idUser(0)("UserId") & "',HqSync=0 WHERE SaleId=" & Sale_Id & "")
                executesql("UPDATE SaleItem Set Active = 2 WHERE SaleId=" & Sale_Id & "")
                Dim selectItemId As DataTable = executesql("select SaleItem.ItemId,Item.IsTrackStock,SaleItem.Qty from SaleItem inner join Item on(Item.ItemId = SaleItem.ItemId) where SaleId='" & Sale_Id & "'")
                For i As Integer = 0 To selectItemId.Rows.Count - 1
                    If selectItemId(i)("IsTrackStock") = 1 Then
                        executesql("UPDATE UnitInStock SET Qty = Qty +'" & selectItemId(i)("Qty") & "' WHERE ItemId='" & selectItemId(i)("ItemId") & "'")
                    End If
                Next
                writeLog("User ID " + Frm_Login.UserId.ToString + " Void sale " + Sale_Id.ToString)
                'GetSaleId = Sale_Id
                ModulePrintPosSlip.PrintSlip(Sale_Id)
                LoadData(txtDateTime.DateTime, txtDateTime.DateTime)
                GetSaleId = 0
                Sale_Id = 0
                GridView_Sale.ClearSelection()
                GridView_SaleDetail.Rows.Clear()
            Else
                MsgBox("ยกเลิกได้เฉพาะรายการที่ขายจากหน้าร้านเท่านั้น !!", MsgBoxStyle.Critical, "คำเตือน")
            End If
        Else
            GetSaleId = 0
            Sale_Id = 0
            GridView_Sale.ClearSelection()
            GridView_SaleDetail.Rows.Clear()
            Exit Sub
        End If
    End Sub

    'Private Sub BtnVoidEDC_Click(sender As Object, e As EventArgs) Handles BtnVoidEDC.Click
    '    VoidEDC.ShowDialog()
    '    GridView_Sale.ClearSelection()
    '    GridView_SaleDetail.Rows.Clear()
    'End Sub

    'Private Sub BtnVoidQrAlipay_Click(sender As Object, e As EventArgs) Handles BtnVoidQrAlipay.Click
    '    If Sale_Id = 0 Then
    '        MsgBox("กรุณาเลิอกรายการบิล", MsgBoxStyle.Critical, "")
    '        Exit Sub
    '    Else
    '        Dim selectSaleData As DataTable = executesql("SELECT SaleNo,partnerTxnUid FROM Sale WHERE SaleId='" & Sale_Id & "'")
    '        If IsNothing(selectSaleData) Then
    '            Exit Sub
    '        ElseIf selectSaleData.Rows.Count = 0 Then
    '            Exit Sub
    '        End If
    '        If IsDBNull(selectSaleData(0)("partnerTxnUid")) Then
    '            MsgBox("ไม่สามารถทำรายการได้", MsgBoxStyle.Critical, "คำเตือน")
    '            Exit Sub
    '        End If
    '        Dim SaleNo As String = selectSaleData(0)("SaleNo")
    '        ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/cancel.php?order_id=" & SaleNo & "&dbname=" & ModuleVoid.dbname & "&dbusername=" & ModuleVoid.dbusername & "")
    '        Dim QrCodeData As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=cancel_e&field=Bill_Number&where=Bill_Number='" & SaleNo & "'&dbname=" & ModuleVoid.dbname & "&dbusername=" & ModuleVoid.dbusername & "")
    '        If IsNothing(QrCodeData) Then
    '            MsgBox("ไม่สำเร็จ", MsgBoxStyle.Critical, "")
    '            Exit Sub
    '        ElseIf QrCodeData.Rows.Count = 0 Then
    '            MsgBox("ไม่สำเร็จ", MsgBoxStyle.Critical, "")
    '            Exit Sub
    '        ElseIf QrCodeData.Rows.Count > 0 Then
    '            Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
    '            executesql("update Sale set Active=2,VoidDate='" & requestDt & "',VoidUserId='" & Frm_Login.UserId & "',HqSync=0 where SaleId=" & Sale_Id)
    '            executesql("UPDATE SaleItem Set Active = 2 WHERE SaleId=" & Sale_Id & "")
    '            Dim selectItemId As DataTable = executesql("select SaleItem.ItemId,Item.IsTrackStock,SaleItem.Qty from SaleItem inner join Item on(Item.ItemId = SaleItem.ItemId) where SaleId='" & Sale_Id & "'")
    '            For i As Integer = 0 To selectItemId.Rows.Count - 1
    '                If selectItemId(i)("IsTrackStock") = 1 Then
    '                    executesql("UPDATE UnitInStock SET Qty = Qty +'" & selectItemId(i)("Qty") & "' WHERE ItemId='" & selectItemId(i)("ItemId") & "'")
    '                End If
    '            Next
    '            writeLog("User ID " + Frm_Login.UserId.ToString + " Void sale QR Ali/Wechat sale id:" + Sale_Id.ToString)
    '            MsgBox("ทำการยกเลิกสำเร็จ", MsgBoxStyle.Information, "")
    '            'GetSaleId = Sale_Id
    '            ModulePrintPosSlip.PrintSlip(Sale_Id)
    '            GetSaleId = 0
    '            Sale_Id = 0
    '            LoadData()
    '            GridView_Sale.ClearSelection()
    '            GridView_SaleDetail.Rows.Clear()
    '            Exit Sub
    '        End If
    '    End If
    'End Sub

    'Private Sub btnVoidQrThai_Click(sender As Object, e As EventArgs) Handles btnVoidQrThai.Click
    '    If Sale_Id = 0 Then
    '        MsgBox("กรุณาเลิอกรายการบิล", MsgBoxStyle.Critical, "")
    '        Exit Sub
    '    Else
    '        Dim checkBill As DataTable = executesql("SELECT partnerTxnUid FROM Sale WHERE SaleId='" & Sale_Id & "'")
    '        If IsDBNull(checkBill(0)("partnerTxnUid")) Then
    '            MsgBox("ไม่สามารถทำรายการได้", MsgBoxStyle.Critical, "คำเตือน")
    '            Exit Sub
    '        Else
    '            Dim selectSaleData As DataTable = executesql("SELECT partnerTxnUid FROM Sale WHERE SaleId='" & Sale_Id & "'")
    '            If IsNothing(selectSaleData) Then
    '                Exit Sub
    '            ElseIf selectSaleData.Rows.Count = 0 Then
    '                Exit Sub
    '            End If
    '            Dim partnerTxnUidSend As String = selectSaleData(0)("partnerTxnUid")
    '            ModuleVoid.checkStatus(partnerTxnUidSend)
    '            writeLog("User ID " + Frm_Login.UserId.ToString + " Void sale Qr Thai sale id :" + Sale_Id.ToString)
    '        End If
    '    End If
    '    GetSaleId = 0
    '    Sale_Id = 0
    '    GridView_Sale.ClearSelection()
    '    GridView_SaleDetail.Rows.Clear()
    'End Sub
    Sub change_to_th_text()
        PageManagementBrand.Text = My.Resources.reCallBill_th.bill
        Label3.Text = My.Resources.reCallBill_th.subTotal
        Label4.Text = My.Resources.reCallBill_th.discount
        Label15.Text = My.Resources.reCallBill_th.total
        Label34.Text = My.Resources.reCallBill_th.search
        Label1.Text = My.Resources.reCallBill_th.search
        Label31.Text = My.Resources.reCallBill_th._date
        btnDeleteSale.Text = My.Resources.reCallBill_th.deleteSale
        BtnRePrint.Text = My.Resources.reCallBill_th.Print

        GridView_SaleDetail.Columns(0).HeaderText = My.Resources.reCallBill_th.productCode
        GridView_SaleDetail.Columns(1).HeaderText = My.Resources.reCallBill_th.productName
        GridView_SaleDetail.Columns(2).HeaderText = My.Resources.reCallBill_th.price
        GridView_SaleDetail.Columns(3).HeaderText = My.Resources.reCallBill_th.qty
        GridView_SaleDetail.Columns(4).HeaderText = My.Resources.reCallBill_th.total

        GridView_Sale.Columns(0).HeaderText = My.Resources.reCallBill_th.saleno
        GridView_Sale.Columns(1).HeaderText = My.Resources.reCallBill_th.datadate
        GridView_Sale.Columns(2).HeaderText = My.Resources.reCallBill_th.datatotal
        GridView_Sale.Columns(4).HeaderText = My.Resources.reCallBill_th.paymentType

    End Sub
    Sub change_to_eng_text()
        PageManagementBrand.Text = My.Resources.reCallBill_en.bill
        Label3.Text = My.Resources.reCallBill_en.subTotal
        Label4.Text = My.Resources.reCallBill_en.discount
        Label15.Text = My.Resources.reCallBill_en.total
        Label34.Text = My.Resources.reCallBill_en.search
        Label1.Text = My.Resources.reCallBill_en.search
        Label31.Text = My.Resources.reCallBill_en._date
        btnDeleteSale.Text = My.Resources.reCallBill_en.deleteSale
        BtnRePrint.Text = My.Resources.reCallBill_en.Print

        GridView_SaleDetail.Columns(0).HeaderText = My.Resources.reCallBill_en.productCode
        GridView_SaleDetail.Columns(1).HeaderText = My.Resources.reCallBill_en.productName
        GridView_SaleDetail.Columns(2).HeaderText = My.Resources.reCallBill_en.price
        GridView_SaleDetail.Columns(3).HeaderText = My.Resources.reCallBill_en.qty
        GridView_SaleDetail.Columns(4).HeaderText = My.Resources.reCallBill_en.total

        GridView_Sale.Columns(0).HeaderText = My.Resources.reCallBill_en.saleno
        GridView_Sale.Columns(1).HeaderText = My.Resources.reCallBill_en.datadate
        GridView_Sale.Columns(2).HeaderText = My.Resources.reCallBill_en.datatotal
        GridView_Sale.Columns(4).HeaderText = My.Resources.reCallBill_en.paymentType
    End Sub
End Class