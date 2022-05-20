Module ModuleVoid
    Public dbname As String = My.Settings.QrDb_Name
    Public dbusername As String = My.Settings.QrDb_username
    Public sub_merchant_id As String
    Public terminal_id As String

    Function checkStatus(partnerTxnUidSend As String)
        Dim RowStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=GetStatus&field=partnerTxnUid&dbname=" & dbname & "&dbusername=" & dbusername & "")
        Dim partnerId As String = My.Settings.QrThaiParNerId
        Dim partnerName As String = My.Settings.QrThaiParNerName
        Dim partnerSecret As String = My.Settings.QrThaiPartnerSecret
        Dim merchantId As String = My.Settings.QrThaiMerchantId
        If IsNothing(RowStatus) Then
            Dim rows As Integer = RowStatus.Rows.Count
            Dim DateStatus As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH"))
            Dim partnerTxnUid As String = "INQ" + DateStatus + (rows).ToString
            Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

            Dim terminalId As String = Environment.MachineName
            Dim qrType As String = "3"
            Dim origPartnerTxnUid As String = partnerTxnUidSend
            'ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/get_status.php?dataVB=check&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & terminalId & "&qrType=" & qrType & "&origPartnerTxnUid=" & origPartnerTxnUid & "&dbname=" & dbname & "&dbusername=" & dbusername & "")
            Dim DataStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=GetStatus&field=txtStatus&where=origPartnerTxnUid='" & origPartnerTxnUid & "'&dbname=" & dbname & "&dbusername=" & dbusername & "")
            If DataStatus.Rows.Count > 0 Then
                Dim returnStatus As String = DataStatus(0)("txtStatus")
                If returnStatus = "PAID" Then
                    ModuleVoid.Void(partnerTxnUidSend)
                ElseIf returnStatus = "REQUESTED" Then
                    MsgBox("ไม่มีรายการชำระเงิน", MsgBoxStyle.Critical, "")
                End If
            End If
        ElseIf RowStatus.Rows.Count = 0 Then
            Dim rows As Integer = RowStatus.Rows.Count
            Dim DateStatus As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH"))
            Dim partnerTxnUid As String = "INQ" + DateStatus + (rows).ToString
            Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

            Dim terminalId As String = Environment.MachineName
            Dim qrType As String = "3"
            Dim origPartnerTxnUid As String = partnerTxnUidSend
            ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/get_status.php?dataVB=check&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & terminalId & "&qrType=" & qrType & "&origPartnerTxnUid=" & origPartnerTxnUid & "&dbname=" & dbname & "&dbusername=" & dbusername & "")
            Dim DataStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=GetStatus&field=txtStatus&where=origPartnerTxnUid='" & origPartnerTxnUid & "'&dbname=" & dbname & "&dbusername=" & dbusername & "")
            If DataStatus.Rows.Count > 0 Then
                Dim returnStatus As String = DataStatus(0)("txtStatus")
                If returnStatus = "PAID" Then
                    ModuleVoid.Void(partnerTxnUidSend)
                ElseIf returnStatus = "REQUESTED" Then
                    MsgBox("ไม่มีรายการชำระเงิน", MsgBoxStyle.Critical, "")
                End If
            End If
        ElseIf RowStatus.Rows.Count > 0 Then
            Dim rows As Integer = RowStatus.Rows.Count
            Dim DateStatus As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH"))
            Dim partnerTxnUid As String = "INQ" + DateStatus + (rows).ToString
            Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

            Dim terminalId As String = Environment.MachineName
            Dim qrType As String = "3"
            Dim origPartnerTxnUid As String = partnerTxnUidSend
            ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/get_status.php?dataVB=check&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & terminalId & "&qrType=" & qrType & "&origPartnerTxnUid=" & origPartnerTxnUid & "&dbname=" & dbname & "&dbusername=" & dbusername & "")
            Dim DataStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=GetStatus&field=txtStatus&where=origPartnerTxnUid='" & origPartnerTxnUid & "'&dbname=" & dbname & "&dbusername=" & dbusername & "")
            If DataStatus.Rows.Count > 0 Then
                Dim returnStatus As String = DataStatus(0)("txtStatus")
                If returnStatus = "PAID" Then
                    ModuleVoid.Void(partnerTxnUidSend)
                ElseIf returnStatus = "REQUESTED" Then
                    MsgBox("ไม่มีรายการชำระเงิน", MsgBoxStyle.Critical, "")
                End If
            End If
        End If
    End Function
    Sub Void(partnerTxnUidSend As String)
        Dim RowStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=VoidThaiQR&field=partnerTxnUid&dbname=" & dbname & "&dbusername=" & dbusername & "")
        Dim partnerId As String = My.Settings.QrThaiParNerId
        Dim partnerName As String = My.Settings.QrThaiParNerName
        Dim partnerSecret As String = My.Settings.QrThaiPartnerSecret
        Dim merchantId As String = My.Settings.QrThaiMerchantId
        If IsNothing(RowStatus) Then
            Dim rows As Integer = RowStatus.Rows.Count
            Dim DateStatus As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH"))
            Dim partnerTxnUid As String = "VOD" + DateStatus + (rows).ToString
            Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

            Dim terminalId As String = Environment.MachineName
            Dim qrType As String = "3"
            Dim origPartnerTxnUid As String = partnerTxnUidSend
            ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/void.php?dataVB=true&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & terminalId & "&qrType=" & qrType & "&origPartnerTxnUid=" & origPartnerTxnUid & "&dbname=" & dbname & "&dbusername=" & dbusername & "")
            Dim DataStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=VoidThaiQR&field=StatusCode,errorCode,errorDesc&where=origPartnerTxnUid='" & origPartnerTxnUid & "'&dbname=" & dbname & "&dbusername=" & dbusername & "")
            If DataStatus.Rows.Count > 0 Then
                Dim returnStatus As String = DataStatus(0)("StatusCode")
                'Return returnStatus
                If returnStatus = "00" Then
                    executesql("update Sale set Active=2,VoidDate='" & requestDt & "',VoidUserId='" & Frm_Login.UserId & "' where SaleId=" & Frm_RecallBill.Sale_Id & "")
                    executesql("UPDATE SaleItem Set Active = 2 WHERE SaleId=" & Frm_RecallBill.Sale_Id & "")
                    Dim selectItemId As DataTable = executesql("select SaleItem.ItemId,Item.IsTrackStock,SaleItem.Qty from SaleItem inner join Item on(Item.ItemId = SaleItem.ItemId) where SaleId='" & Frm_RecallBill.Sale_Id & "'")
                    For i As Integer = 0 To selectItemId.Rows.Count - 1
                        If selectItemId(i)("IsTrackStock") = 1 Then
                            executesql("UPDATE UnitInStock SET Qty = Qty +'" & selectItemId(i)("Qty") & "' WHERE ItemId='" & selectItemId(i)("ItemId") & "'")
                        End If
                    Next
                    MsgBox("ทำรายการเสร็จสิ้น !!", MsgBoxStyle.Information, "คำเตือน")
                    Frm_RecallBill.LoadData(Now, Now)
                Else returnStatus = "10"
                    MsgBox(DataStatus(0)("errorCode") & "(" & DataStatus(0)("errorDesc") & ")", MsgBoxStyle.Critical, "คำเตือน")
                End If
            End If
        ElseIf RowStatus.Rows.Count = 0 Then
            Dim rows As Integer = RowStatus.Rows.Count
            Dim DateStatus As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH"))
            Dim partnerTxnUid As String = "VOD" + DateStatus + (rows).ToString
            Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

            Dim terminalId As String = Environment.MachineName
            Dim qrType As String = "3"
            Dim origPartnerTxnUid As String = partnerTxnUidSend
            ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/void.php?dataVB=true&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & terminalId & "&qrType=" & qrType & "&origPartnerTxnUid=" & origPartnerTxnUid & "&dbname=" & dbname & "&dbusername=" & dbusername & "")
            Dim DataStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=VoidThaiQR&field=StatusCode,errorCode,errorDesc&where=origPartnerTxnUid='" & origPartnerTxnUid & "'&dbname=" & dbname & "&dbusername=" & dbusername & "")
            If DataStatus.Rows.Count > 0 Then
                Dim returnStatus As String = DataStatus(0)("StatusCode")
                'Return returnStatus
                If returnStatus = "00" Then
                    executesql("update Sale set Active=2,VoidDate='" & requestDt & "',VoidUserId='" & Frm_Login.UserId & "' where SaleId=" & Frm_RecallBill.Sale_Id & "")
                    executesql("UPDATE SaleItem Set Active = 2 WHERE SaleId=" & Frm_RecallBill.Sale_Id & "")
                    Dim selectItemId As DataTable = executesql("select SaleItem.ItemId,Item.IsTrackStock,SaleItem.Qty from SaleItem inner join Item on(Item.ItemId = SaleItem.ItemId) where SaleId='" & Frm_RecallBill.Sale_Id & "'")
                    For i As Integer = 0 To selectItemId.Rows.Count - 1
                        If selectItemId(i)("IsTrackStock") = 1 Then
                            executesql("UPDATE UnitInStock SET Qty = Qty +'" & selectItemId(i)("Qty") & "' WHERE ItemId='" & selectItemId(i)("ItemId") & "'")
                        End If
                    Next
                    MsgBox("ทำรายการเสร็จสิ้น !!", MsgBoxStyle.Information, "คำเตือน")
                    'GetSaleId = Frm_RecallBill.Sale_Id
                    ModulePrintPosSlip.PrintSlip(Frm_RecallBill.Sale_Id)
                    Frm_RecallBill.LoadData(Now, Now)
                Else returnStatus = "10"
                    MsgBox(DataStatus(0)("errorCode") & "(" & DataStatus(0)("errorDesc") & ")", MsgBoxStyle.Critical, "คำเตือน")
                End If
            End If
        ElseIf RowStatus.Rows.Count > 0 Then
            Dim rows As Integer = RowStatus.Rows.Count
            Dim DateStatus As String = Convert.ToDateTime(Now).ToString("yyyyMMdd", New System.Globalization.CultureInfo("th-TH"))
            Dim partnerTxnUid As String = "VOD" + DateStatus + (rows).ToString
            Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))

            Dim terminalId As String = Environment.MachineName
            Dim qrType As String = "3"
            Dim origPartnerTxnUid As String = partnerTxnUidSend
            ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/void.php?dataVB=true&partnerTxnUid=" & partnerTxnUid & "&partnerId=" & partnerId & "&partnerSecret=" & partnerSecret & "&requestDt=" & requestDt & "&merchantId=" & merchantId & "&terminalId=" & terminalId & "&qrType=" & qrType & "&origPartnerTxnUid=" & origPartnerTxnUid & "&dbname=" & dbname & "&dbusername=" & dbusername & "")
            Dim DataStatus As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=VoidThaiQR&field=StatusCode,errorCode,errorDesc&where=origPartnerTxnUid='" & origPartnerTxnUid & "'&dbname=" & dbname & "&dbusername=" & dbusername & "")
            If DataStatus.Rows.Count > 0 Then
                Dim returnStatus As String = DataStatus(0)("StatusCode")
                'Return returnStatus
                If returnStatus = "00" Then
                    executesql("update Sale set Active=2,VoidDate='" & requestDt & "',VoidUserId='" & Frm_Login.UserId & "' where SaleId=" & Frm_RecallBill.Sale_Id & "")
                    executesql("UPDATE SaleItem Set Active = 2 WHERE SaleId=" & Frm_RecallBill.Sale_Id & "")

                    Dim selectItemId As DataTable = executesql("select SaleItem.ItemId,Item.IsTrackStock,SaleItem.Qty from SaleItem inner join Item on(Item.ItemId = SaleItem.ItemId) where SaleId='" & Frm_RecallBill.Sale_Id & "'")
                    For i As Integer = 0 To selectItemId.Rows.Count - 1
                        If selectItemId(i)("IsTrackStock") = 1 Then
                            executesql("UPDATE UnitInStock SET Qty = Qty +'" & selectItemId(i)("Qty") & "' WHERE ItemId='" & selectItemId(i)("ItemId") & "'")
                        End If
                    Next
                    MsgBox("ทำรายการเสร็จสิ้น !!", MsgBoxStyle.Information, "คำเตือน")
                    'GetSaleId = Frm_RecallBill.Sale_Id
                    ModulePrintPosSlip.PrintSlip(Frm_RecallBill.Sale_Id)
                    Frm_RecallBill.LoadData(Now, Now)
                Else returnStatus = "10"
                    MsgBox(DataStatus(0)("errorCode") & "(" & DataStatus(0)("errorDesc") & ")", MsgBoxStyle.Critical, "คำเตือน")
                End If
            End If
        End If
    End Sub
End Module
