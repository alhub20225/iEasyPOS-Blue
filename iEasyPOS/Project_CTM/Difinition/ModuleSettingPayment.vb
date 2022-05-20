Module ModuleSettingPayment
    Function ValidateNumberTextBox(e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถกดได้แค่ตัวเลข")
        End Select
    End Function
    Sub ClearDataFrmAddBank()
        FrmAddBank.TxtBankName.Clear()
        FrmAddBank.RadBrowseImage.Controls.Clear()
        FrmAddBank.PictureBoxBank.Controls.Clear()
    End Sub
    Sub SaveBank()
        Dim BankName As String = FrmAddBank.TxtBankName.Text
        If BankName = "" Then
            Exit Sub
        End If
        'Check BankName 
        Dim CheckNameBank As DataTable = executesql("SELECT BankName FROM Bank WHERE BankName='" & BankName & "' AND Active=1")
        If CheckNameBank.Rows.Count > 0 Then
            MsgBox("มีข้อมูลธนาคารนี้แล้ว")
            Exit Sub
        End If
        executesql("INSERT INTO Bank(BankName) VALUES('" & BankName & "')")
        MsgBox("บันทึกเรียบร้อย")
        ClearDataFrmAddBank()
        LoadBank()
    End Sub
    Sub LoadBank()
        Dim DataBank As DataTable = executesql("SELECT BankId,BankName FROM Bank WHERE Active=1")
        If DataBank.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmAddBank.DgBank.Rows.Clear()
        For i As Integer = 0 To DataBank.Rows.Count - 1
            FrmAddBank.DgBank.Rows.Add(DataBank(i)("BankId"), DataBank(i)("BankName"))
        Next
    End Sub
    Function DeleteBank(BankId As Integer)
        executesql("UPDATE Bank SET Active=0 WHERE BankId='" & BankId & "'")
        ClearDataFrmAddBank()
        LoadBank()
    End Function
    Function CellClickDgBank(BankId As Integer)
        Dim DataBank As DataTable = executesql("SELECT BankId,BankName FROM Bank WHERE BankId='" & BankId & "' AND Active=1")
        If DataBank.Rows.Count = 0 Then
            Exit Function
        End If
        FrmAddBank.TxtBankName.Text = DataBank(0)("BankName")
    End Function
    Sub ClearDataBankCardTypeName()
        FrmAddBankCardType.TxtCardTypeName.Clear()
        FrmAddBankCardType.RadBrowseEditorImageCaedType.Controls.Clear()
        FrmAddBankCardType.PictureBoxImageCardType.Controls.Clear()
        FrmAddBankCardType.BankCardTypeNameIdSend = 0
    End Sub
    Sub LoadBankCardType()
        FrmAddBankCardType.DgBankCardType.Rows.Clear()
        Dim DataBankCardType As DataTable = executesql("SELECT BankCardTypeId,BankCardTypeName FROM BankCardType WHERE Active=1")
        If DataBankCardType.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To DataBankCardType.Rows.Count - 1
            FrmAddBankCardType.DgBankCardType.Rows.Add(DataBankCardType(i)("BankCardTypeId"), DataBankCardType(i)("BankCardTypeName"))
        Next
    End Sub
    Function SaveBankCardType(BankCardTypeNameSend As Integer)
        If BankCardTypeNameSend = 0 Then
            'Insert To BankCardTypeName Table
            If FrmAddBankCardType.TxtCardTypeName.Text = "" Then
                MsgBox("กรุณากรอกข้อมูลก่อน")
                Exit Function
            End If
            'Check BankCardTypeName 
            Dim BankCardTypeName As String = FrmAddBankCardType.TxtCardTypeName.Text
            Dim CheckBankCardTypeName As DataTable = executesql("SELECT BankCardTypeName FROM BankCardType WHERE BankCardTypeName='" & BankCardTypeName & "' AND Active=1")
            If CheckBankCardTypeName.Rows.Count > 0 Then
                MsgBox("มีประเภทบัตรนี้อยู่แล้ว")
                Exit Function
            End If
            'Insert BankCardTypeName 
            executesql("INSERT INTO BankCardType(BankCardTypeName,Active) VALUES('" & BankCardTypeName & "',1)")
            MsgBox("บันทึกเรียบร้อย")
            ClearDataBankCardTypeName()
            LoadBankCardType()
        ElseIf BankCardTypeNameSend > 0
            'UpDate To BankCardtypename Table
            Dim BankCardTypeName As String = FrmAddBankCardType.TxtCardTypeName.Text
            executesql("UPDATE BankCardType SET BankCardTypeName='" & BankCardTypeName & "' WHERE BankCardTypeId='" & BankCardTypeNameSend & "'")
            LoadBankCardType()
            ClearDataBankCardTypeName()
        End If
    End Function
    Function CellClickBankCardType(BankCardTypeNameIdSend As Integer)
        Dim DataBankCardType As DataTable = executesql("SELECT BankCardTypeId,BankCardTypeName FROM BankCardType WHERE BankCardTypeId='" & BankCardTypeNameIdSend & "' AND Active=1")
        FrmAddBankCardType.TxtCardTypeName.Text = DataBankCardType(0)("BankCardTypeName")
    End Function
    Function DeleteBankCardType(BankCardTypeNameIdSend As Integer)
        If BankCardTypeNameIdSend = 0 Then
            Exit Function
        Else
            executesql("UPDATE BankCardType SET Active=0 WHERE BankCardTypeId='" & BankCardTypeNameIdSend & "'")
            LoadBankCardType()
            ClearDataBankCardTypeName()
        End If
    End Function
    Sub ClearDataCardType()
        FrmAddCardType.TxtCardTypeName.Clear()
        FrmAddCardType.RadBrowseEditorImageCaedType.Controls.Clear()
        FrmAddCardType.PictureBoxImageCardType.Controls.Clear()
        FrmAddCardType.TxtBoxCharge.Clear()
        FrmAddCardType.TxtDisCount.Clear()
        FrmAddCardType.TxtMoreMoney.Clear()
        FrmAddCardType.CardTypeIdSend = 0
        LoadCardType()
    End Sub
    Sub LoadCardType()
        FrmAddCardType.DgCardType.Rows.Clear()
        Dim DataCardType As DataTable = executesql("SELECT CardTypeId,CardTypeName FROM CardType WHERE Active=1")
        If DataCardType.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To DataCardType.Rows.Count - 1
            FrmAddCardType.DgCardType.Rows.Add(DataCardType(i)("CardTypeId"), DataCardType(i)("CardTypeName"))
        Next
    End Sub
    Sub LoadComboBoxBankCardType()
        Dim DataBank As DataTable = executesql("SELECT BankId,BankName FROM Bank WHERE Active=1")
        If IsNothing(DataBank) Then
            Exit Sub
        ElseIf DataBank.Rows.Count > 0
            FrmAddCardType.ComboBoxBank.DataSource = DataBank
            FrmAddCardType.ComboBoxBank.DisplayMember = "BankName"
            FrmAddCardType.ComboBoxBank.ValueMember = "BankId"
        End If
    End Sub
    Function SaveCardType(CardTypeIdSend As Integer)
        Dim Discount As Decimal
        Dim Charge As Decimal
        Dim MoreMoney As Decimal
        Dim CardTypeName As String
        If FrmAddCardType.TxtCardTypeName.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Function
        Else
            CardTypeName = FrmAddCardType.TxtCardTypeName.Text
        End If
        If FrmAddCardType.TxtDisCount.Text = "" Then
            Discount = 0.00
        Else
            Discount = CDbl(FrmAddCardType.TxtDisCount.Text)
        End If
        If FrmAddCardType.TxtBoxCharge.Text = "" Then
            Charge = 0.00
        Else
            Charge = CDbl(FrmAddCardType.TxtBoxCharge.Text)
        End If
        If FrmAddCardType.TxtMoreMoney.Text = "" Then
            MoreMoney = 0.00
        Else
            MoreMoney = CDbl(FrmAddCardType.TxtMoreMoney.Text)
        End If
        If FrmAddCardType.ComboBoxBank.SelectedValue = 0 Then
            MsgBox("กรุณาเลือกธนาคาร", MsgBoxStyle.Information)
            Exit Function
        End If
        Dim BankId As Integer = FrmAddCardType.ComboBoxBank.SelectedValue
        If CardTypeIdSend = 0 Then
            'CheckCardTypeName
            Dim CheckCardTypeName As DataTable = executesql("SELECT CardTypeName FROM CardType WHERE CardTypeName='" & CardTypeName & "' AND Active=1")
            If CheckCardTypeName.Rows.Count > 0 Then
                MsgBox("มีข้อมูลชนิดบัตรนี้อยู่แล้ว")
                Exit Function
            End If
            'Insert 
            executesql("INSERT INTO CardType(CardTypeName,Charge,MoreMoney,Discount,BankId,Active) VALUES('" & CardTypeName & "','" & Charge & "','" & MoreMoney & "','" & Discount & "','" & BankId & "',1)")
            ClearDataCardType()
            LoadCardType()
        ElseIf CardTypeIdSend <> 0
            executesql("UPDATE CardType SET CardTypeName='" & CardTypeName & "',Charge='" & Charge & "',MoreMoney='" & MoreMoney & "',Discount='" & Discount & "',BankId='" & BankId & "' WHERE CardTypeId='" & CardTypeIdSend & "'")
            ClearDataCardType()
            LoadCardType()
        End If
    End Function
    Function CellClickCardType(CardTypeIdSend As Integer)
        Dim DataCardType As DataTable = executesql("SELECT CardTypeId,CardTypeName,Charge,MoreMoney,Discount,BankId FROM CardType WHERE CardTypeId='" & CardTypeIdSend & "' AND Active=1")
        If DataCardType.Rows.Count = 0 Then
            Exit Function
        End If
        FrmAddCardType.TxtCardTypeName.Text = DataCardType(0)("CardTypeName")
        FrmAddCardType.TxtBoxCharge.Text = FormatNumber(DataCardType(0)("Charge"), 2)
        FrmAddCardType.TxtMoreMoney.Text = FormatNumber(DataCardType(0)("MoreMoney"), 2)
        FrmAddCardType.TxtDisCount.Text = FormatNumber(DataCardType(0)("Discount"), 2)
    End Function
    Function DeleteCardType(CardTypeIdSend As Integer)
        If CardTypeIdSend = 0 Then
            Exit Function
        End If
        executesql("UPDATE CardType SET Active=0 WHERE CardTypeId='" & CardTypeIdSend & "' AND Active=1")
        ClearDataCardType()
        LoadCardType()
    End Function
    Sub ClearTxtFrmAddEDC()
        FrmAddEDC.TxtEDCName.Clear()
        FrmAddEDC.TxtEDCBarCode.Clear()
        FrmAddEDC.RadBrowseImage.Controls.Clear()
        FrmAddEDC.EDCIdSend = 0
        LoadDgEDC()
    End Sub
    Sub LoadDgEDC()
        FrmAddEDC.DgEDC.Rows.Clear()
        Dim DataEDC As DataTable = executesql("SELECT EdcBankId,EdcBankName FROM EdcBank WHERE Active=1")
        If DataEDC.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To DataEDC.Rows.Count - 1
            FrmAddEDC.DgEDC.Rows.Add(DataEDC(i)("EdcBankid"), DataEDC(i)("EdcBankName"))
        Next
    End Sub
    Function SaveEDC(EDCIdSend As Integer)
        Dim EDCName As String = FrmAddEDC.TxtEDCName.Text
        Dim EDCBarcode As String = FrmAddEDC.TxtEDCBarCode.Text
        If EDCName = "" Then
            MsgBox("กรุณากรอกชื่อ EDC")
            Exit Function
        End If
        If EDCIdSend = 0 Then
            'Check EDCName
            Dim CheckDataEDC As DataTable = executesql("SELECT EdcBankId FROM EdcBank WHERE EdcBankName='" & EDCName & "' AND Active=1")
            If CheckDataEDC.Rows.Count > 0 Then
                MsgBox("มีเครื่อง EDC นี้อยู๋แล้ว")
                Exit Function
            End If
            'insert
            executesql("INSERT INTO EdcBank(EdcBankName,EdcBarcode) VALUES('" & EDCName & "','" & EDCBarcode & "')")
            Clipboard.SetText("INSERT INTO EdcBank(EdcBankName,EdcBarcode) VALUES('" & EDCName & "','" & EDCBarcode & "')")
            ClearTxtFrmAddEDC()
        ElseIf EDCIdSend <> 0
            'Update
            executesql("UPDATE EdcBank SET EdcBankName='" & EDCName & "',EdcBarcode='" & EDCBarcode & "' WHERE EdcBankId='" & EDCIdSend & "' AND ACtive=1")
            ClearTxtFrmAddEDC()
        End If
    End Function
    Function CellClickDgEdc(EDCIdSend As Integer)
        Dim DataEdcBank As DataTable = executesql("SELECT EdcBankId,EdcBankName,EdcBarCode FROM EdcBank WHERE EdcBankId='" & EDCIdSend & "' AND Active=1")
        FrmAddEDC.TxtEDCName.Text = DataEdcBank(0)("EdcBankName")
        FrmAddEDC.TxtEDCBarCode.Text = DataEdcBank(0)("EdcBarCode")
    End Function
    Function DeleteEdcBank(EDCIdSend As Integer)
        If EDCIdSend = 0 Then
            Exit Function
        End If
        executesql("UPDATE EdcBank SET Active=0 WHERE EdcBankId='" & EDCIdSend & "'")
        ClearTxtFrmAddEDC()
    End Function
    Sub ClearVoucher()
        FrmManageVoucher.TxtSearchVoucher.Clear()
        FrmManageVoucher.TxtVoucherName.Clear()
        FrmManageVoucher.TxtVoucherNumber.Clear()
        FrmManageVoucher.TxtVoucherValue.Clear()
        FrmManageVoucher.DateTimePickerStart.Value = Now
        FrmManageVoucher.DateTimePickerEnd.Value = Now
        FrmManageVoucher.VoucherIdSend = 0
        LoadDataVoucher()
    End Sub
    Sub BtnSaveVoucher()
        Dim VoucherName As String = FrmManageVoucher.TxtVoucherName.Text
        Dim VoucherNumber As String = FrmManageVoucher.TxtVoucherNumber.Text
        Dim VoucherValue As String = FrmManageVoucher.TxtVoucherValue.Text
        Dim DateStartVocher As String = Convert.ToDateTime(FrmManageVoucher.DateTimePickerStart.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim DateEndVoucher As String = Convert.ToDateTime(FrmManageVoucher.DateTimePickerEnd.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim InsDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        If VoucherName = "" Or VoucherNumber = "" Or VoucherValue = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If
        If FrmManageVoucher.VoucherIdSend = 0 Then
            'CheckVoucherNumber
            Dim CheckDataVoucherNumber As DataTable = executesql("SELECT VoucherId FROM Voucher WHERE VoucherNumber LIKE '" & VoucherNumber & "%' AND Active=1")
            If CheckDataVoucherNumber.Rows.Count > 0 Then
                MsgBox("เลขที่ Voucher ซ้ำ", MsgBoxStyle.Information)
                Exit Sub
            End If
            'Insert
            executesql("INSERT INTO Voucher(VoucherName,VoucherNumber,VoucherPrice,StatusId,StartVoucherDate,ExpDate,InsertDate,UserId,Active) VALUES('" & VoucherName & "','" & VoucherNumber & "','" & VoucherValue & "',1,'" & DateStartVocher & "','" & DateEndVoucher & "','" & InsDate & "','" & UserId & "',1)")
            ClearVoucher()
        ElseIf FrmManageVoucher.VoucherIdSend > 0
                'Update 
                Dim VoucherIdSend As Integer = FrmManageVoucher.VoucherIdSend
            If VoucherName = "" Or VoucherNumber = "" Or VoucherValue = "" Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ")
                Exit Sub
            End If
            executesql("UPDATE Voucher SET VoucherName='" & VoucherName & "',VoucherNumber='" & VoucherNumber & "',VoucherPrice='" & VoucherValue & "',StartVoucherDate='" & DateStartVocher & "',Expdate='" & DateEndVoucher & "' WHERE VoucherId='" & VoucherIdSend & "'")
            ClearVoucher()
        End If
    End Sub
    Sub LoadDataVoucher()
        Dim DataVoucher As DataTable = executesql("SELECT VoucherId,VoucherName,VoucherNumber FROM Voucher WHERE Active=1")
        If DataVoucher.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmManageVoucher.DgVoucher.Rows.Clear()
        For i As Integer = 0 To DataVoucher.Rows.Count - 1
            FrmManageVoucher.DgVoucher.Rows.Add(DataVoucher(i)("VoucherId"), DataVoucher(i)("VoucherName"), DataVoucher(i)("VoucherNumber"))
        Next
    End Sub
    Function CellClickDgVoucher(VoucherIdSend As Integer)
        If VoucherIdSend = 0 Then
            Exit Function
        End If
        Dim DataCellClickVoucher As DataTable = executesql("SELECT VoucherName,VoucherId,VoucherNumber,VoucherPrice,StartVoucherDate,ExpDate FROM Voucher WHERE VoucherId='" & VoucherIdSend & "' AND Active=1")
        Dim VoucherName As String = DataCellClickVoucher(0)("VoucherName")
        Dim VoucherPrice As Decimal = DataCellClickVoucher(0)("VoucherPrice")
        Dim VoucherNumber As String = DataCellClickVoucher(0)("VoucherNumber")
        Dim StartDate As String = DataCellClickVoucher(0)("StartVoucherDate")
        Dim EndDate As String = DataCellClickVoucher(0)("ExpDate")
        MsgBox(EndDate)
        FrmManageVoucher.TxtVoucherName.Text = VoucherName
        FrmManageVoucher.TxtVoucherNumber.Text = VoucherNumber
        FrmManageVoucher.TxtVoucherValue.Text = VoucherPrice
        FrmManageVoucher.DateTimePickerStart.Value = StartDate
        FrmManageVoucher.DateTimePickerEnd.Value = EndDate
    End Function
    Function SearchVoucher(WordSearch As String)
        If WordSearch = "" Then
            ClearVoucher()
        ElseIf WordSearch <> ""
            Dim SearchData As DataTable = executesql("SELECT VoucherId,VoucherName,VoucherNumber FROM Voucher WHERE VoucherName LIKE '" & WordSearch & "%' OR VoucherNumber LIKE '" & WordSearch & "%'")
            FrmManageVoucher.DgVoucher.Rows.Clear()
            If SearchData.Rows.Count = 0 Then
                Exit Function
            End If
            For i As Integer = 0 To SearchData.Rows.Count - 1
                Dim VoucherId As String = SearchData(i)("VoucherId")
                Dim VoucherName As String = SearchData(i)("VoucherName")
                Dim VoucherNumber As String = SearchData(i)("VoucherNumber")
                FrmManageVoucher.DgVoucher.Rows.Add(VoucherId, VoucherName, VoucherNumber)
            Next
        End If

    End Function
    Function DeleteVoucher(VoucherIdSend As Integer)
        If VoucherIdSend = 0 Then
            Exit Function
        End If
        executesql("UPDATE Voucher SET Active=0 WHERE Voucherid='" & VoucherIdSend & "'")
        ClearVoucher()
    End Function
    Sub ClearDataCoupon()
        FrmManageCoupon.TxtSearchCoupon.Clear()
        FrmManageCoupon.TxtCouponNumber.Clear()
        FrmManageCoupon.TxtValueCoupon.Clear()
        FrmManageCoupon.DatetimeStart.Value = Now
        FrmManageCoupon.DateTimeEnd.Value = Now
        FrmManageCoupon.CouponIdSend = 0
        LoadDataCoupon()
    End Sub
    Sub LoadDataCoupon()
        Dim DataCoupon As DataTable = executesql("SELECT CouponId,CouponNumber FROM Coupon WHERE Active=1")
        If IsNothing(DataCoupon) Then
            Exit Sub
        End If
        FrmManageCoupon.DgCoupon.Rows.Clear()
        For i As Integer = 0 To DataCoupon.Rows.Count - 1
            FrmManageCoupon.DgCoupon.Rows.Add(DataCoupon(i)("CouponId"), DataCoupon(i)("CouponNumber"))
        Next
    End Sub
    Function BtnSaveCoupon(CouponIdSend As Integer)
        Dim NumberCoupon As Integer
        Dim CouponValue As Decimal
        Dim DateStart As String = Convert.ToDateTime(FrmManageCoupon.DatetimeStart.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim EndStart As String = Convert.ToDateTime(FrmManageCoupon.DateTimeEnd.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim InsDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim Active As Integer = 1
        If FrmManageCoupon.TxtCouponNumber.Text = "" Then
            MsgBox("กรุณากรอกเลยที่คูปอง", MsgBoxStyle.Information)
            Exit Function
        ElseIf FrmManageCoupon.TxtCouponNumber.Text <> ""
            NumberCoupon = FrmManageCoupon.TxtCouponNumber.Text
        End If
        If FrmManageCoupon.TxtValueCoupon.Text = "" Then
            MsgBox("กรุณากรอกมูลค่าคูปอง", MsgBoxStyle.Information)
            Exit Function
        Else
            CouponValue = CDbl(FrmManageCoupon.TxtValueCoupon.Text)
        End If
        If CouponIdSend = 0 Then
            'Check CouponNumber
            Dim CheckDataCoupon As DataTable = executesql("SELECT CouponId FROM Coupon WHERE CouponNumber='" & NumberCoupon & "' AND Active=1")
            If CheckDataCoupon.Rows.Count > 0 Then
                MsgBox("รหัส Coupon ซ้ำ", MsgBoxStyle.Information)
                Exit Function
            End If
            'Insert
            executesql("INSERT INTO Coupon(CouponNumber,CouponPrice,CouponBalance,ExpDate,InsertDate,UserId,Active) VALUES('" & NumberCoupon & "','" & CouponValue & "','" & CouponValue & "','" & EndStart & "','" & InsDate & "','" & UserId & "','" & Active & "')")
            ClearDataCoupon()
            Exit Function
        ElseIf CouponIdSend <> 0
            'Update
            executesql("UPDATE Coupon SET CouponNumber='" & NumberCoupon & "',CouponPrice='" & CouponValue & "',ExpDate='" & EndStart & "',InsertDate='" & InsDate & "',UserId='" & UserId & "' WHERE CouponId='" & CouponIdSend & "'")
            ClearDataCoupon()
            Exit Function
        End If
    End Function
    Function CellClickCoupon(CouponIdSend As Integer)
        'Select DataCoupon
        Dim DataCoupon As DataTable = executesql("SELECT CouponId,CouponNumber,CouponPrice,ExpDate,InsertDate FROM Coupon WHERE CouponId='" & CouponIdSend & "'")
        If DataCoupon.Rows.Count = 0 Then
            Exit Function
        End If
        FrmManageCoupon.TxtCouponNumber.Text = DataCoupon(0)("CouponNumber")
        FrmManageCoupon.TxtValueCoupon.Text = FormatNumber(DataCoupon(0)("CouponPrice"), 2)
        FrmManageCoupon.DatetimeStart.Value = DataCoupon(0)("InsertDate")
        FrmManageCoupon.DateTimeEnd.Value = DataCoupon(0)("ExpDate")
        'Select History Coupon
        Dim DataHistoryCoupon As DataTable = executesql("SELECT HistoryCouponId,CouponId,PaidAmount,Balance,InsertDate,SaleId FROM HistoryCoupon WHERE CouponId='" & CouponIdSend & "'")
        If DataHistoryCoupon.Rows.Count = 0 Then
            Exit Function
        End If
        For i As Integer = 0 To DataHistoryCoupon.Rows.Count - 1
            Dim SaleId As Integer = DataHistoryCoupon(i)("SaleId")
            'Select SaleNo 
            Dim DataSaleNo As DataTable = executesql("SELECT SaleNo FROM Sale WHERE SaleId='" & SaleId & "'")
            Dim SaleNo As String = DataSaleNo(0)("SaleNo")
            Dim PaidAmount As Decimal = DataHistoryCoupon(i)("PaidAmount")
            Dim Balance As Decimal = DataHistoryCoupon(i)("Balance")
            Dim DateUse As String = DataHistoryCoupon(i)("InsertDate")
            FrmManageCoupon.DgHistoryCoupon.Rows.Add(SaleNo, PaidAmount, Balance, DateUse)
        Next
    End Function
    Function Deletecoupon(CouponIdSend As Integer)
        If CouponIdSend = 0 Then
            Exit Function
        End If
        executesql("UPDATE Coupon SET Active=0 WHERE CouponId='" & CouponIdSend & "'")
        ClearDataCoupon()
    End Function
    Function SearchCoupon(WordSearch As String)
        If WordSearch = "" Then
            Exit Function
        End If
        Dim DataSearch As DataTable = executesql("SELECT CouponId,CouponNumber FROM Coupon WHERE CouponNumber LIKE '" & WordSearch & "%' AND Active=1")
        FrmManageCoupon.DgCoupon.Rows.Clear()
        If DataSearch.Rows.Count = 0 Then
            Exit Function
        End If
        For i As Integer = 0 To DataSearch.Rows.Count - 1
            FrmManageCoupon.DgCoupon.Rows.Add(DataSearch(i)("CouponId"), DataSearch(i)("CouponNumber"))
        Next
    End Function
End Module
