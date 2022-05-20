Public Class Frm_Void
    Private Sub Frm_Void_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.QrThaiParNerId = "" Then
            Panel1.Visible = False
        End If
        If My.Settings.QrAliPartnerId = "" Then
            Panel4.Visible = False
        End If
        If My.Settings.Comport = 0 Then
            Panel11.Visible = False
        End If
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If Frm_RecallBill.Sale_Id = 0 Then
            MsgBox("กรุณาเลิอกรายการบิล", MsgBoxStyle.Critical, "")
            Exit Sub
        Else
            Dim selectSaleData As DataTable = executesql("SELECT SaleNo,partnerTxnUid FROM Sale WHERE SaleId='" & Frm_RecallBill.Sale_Id & "'")
            If IsNothing(selectSaleData) Then
                Exit Sub
            ElseIf selectSaleData.Rows.Count = 0 Then
                Exit Sub
            End If
            If IsDBNull(selectSaleData(0)("partnerTxnUid")) Then
                MsgBox("ไม่สามารถทำรายการได้", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If
            Dim SaleNo As String = selectSaleData(0)("SaleNo")
            ModuleGetDataAPI.gett("http://qrpay.ieasy.asia/ctmAPI/cancel.php?order_id=" & SaleNo & "&dbname=" & ModuleVoid.dbname & "&dbusername=" & ModuleVoid.dbusername & "")
            Dim QrCodeData As DataTable = ModuleGetDataAPI.gettQRCode("http://qrpay.ieasy.asia/ctmAPI/vbapi2.php?action=SELECT&table=cancel_e&field=Bill_Number&where=Bill_Number='" & SaleNo & "'&dbname=" & ModuleVoid.dbname & "&dbusername=" & ModuleVoid.dbusername & "")
            If IsNothing(QrCodeData) Then
                MsgBox("ไม่สำเร็จ", MsgBoxStyle.Critical, "")
                Exit Sub
            ElseIf QrCodeData.Rows.Count = 0 Then
                MsgBox("ไม่สำเร็จ", MsgBoxStyle.Critical, "")
                Exit Sub
            ElseIf QrCodeData.Rows.Count > 0 Then
                Dim requestDt As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
                executesql("update Sale set Active=2,VoidDate='" & requestDt & "',VoidUserId='" & Frm_Login.UserId & "',HqSync=0 where SaleId=" & Frm_RecallBill.Sale_Id)
                executesql("UPDATE SaleItem Set Active = 2 WHERE SaleId=" & Frm_RecallBill.Sale_Id & "")
                Dim selectItemId As DataTable = executesql("select SaleItem.ItemId,Item.IsTrackStock,SaleItem.Qty from SaleItem inner join Item on(Item.ItemId = SaleItem.ItemId) where SaleId='" & Frm_RecallBill.Sale_Id & "'")
                For i As Integer = 0 To selectItemId.Rows.Count - 1
                    If selectItemId(i)("IsTrackStock") = 1 Then
                        executesql("UPDATE UnitInStock SET Qty = Qty +'" & selectItemId(i)("Qty") & "' WHERE ItemId='" & selectItemId(i)("ItemId") & "'")
                    End If
                Next
                writeLog("User ID " + Frm_Login.UserId.ToString + " Void sale QR Ali/Wechat sale id:" + Frm_RecallBill.Sale_Id.ToString)
                MsgBox("ทำการยกเลิกสำเร็จ", MsgBoxStyle.Information, "")
                'GetSaleId = Sale_Id
                ModulePrintPosSlip.PrintSlip(Frm_RecallBill.Sale_Id)
                GetSaleId = 0
                Frm_RecallBill.Sale_Id = 0
                Frm_RecallBill.LoadData(Now, Now)
                Frm_RecallBill.GridView_Sale.ClearSelection()
                Frm_RecallBill.GridView_SaleDetail.Rows.Clear()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Frm_RecallBill.Sale_Id = 0 Then
            MsgBox("กรุณาเลิอกรายการบิล", MsgBoxStyle.Critical, "")
            Exit Sub
        Else
            Dim checkBill As DataTable = executesql("SELECT partnerTxnUid FROM Sale WHERE SaleId='" & Frm_RecallBill.Sale_Id & "'")
            If IsDBNull(checkBill(0)("partnerTxnUid")) Then
                MsgBox("ไม่สามารถทำรายการได้", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            Else
                Dim selectSaleData As DataTable = executesql("SELECT partnerTxnUid FROM Sale WHERE SaleId='" & Frm_RecallBill.Sale_Id & "'")
                If IsNothing(selectSaleData) Then
                    Exit Sub
                ElseIf selectSaleData.Rows.Count = 0 Then
                    Exit Sub
                End If
                Dim partnerTxnUidSend As String = selectSaleData(0)("partnerTxnUid")
                ModuleVoid.checkStatus(partnerTxnUidSend)
                writeLog("User ID " + Frm_Login.UserId.ToString + " Void sale Qr Thai sale id :" + Frm_RecallBill.Sale_Id.ToString)
            End If
        End If
        GetSaleId = 0
        Frm_RecallBill.Sale_Id = 0
        Frm_RecallBill.GridView_Sale.ClearSelection()
        Frm_RecallBill.GridView_SaleDetail.Rows.Clear()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        VoidEDC.ShowDialog()
        Frm_RecallBill.GridView_Sale.ClearSelection()
        Frm_RecallBill.GridView_SaleDetail.Rows.Clear()
    End Sub
End Class