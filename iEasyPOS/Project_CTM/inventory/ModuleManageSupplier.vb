Module ModuleManageSupplier
    Dim field As String = ""
    Dim table As String = ""
    Dim Where As String = ""
    Dim join As String = ""
    Dim value As String = ""
    Sub ClearText()
        FrmManageSupplier.TxtCodeSupplier.Clear()
        FrmManageSupplier.TxtSupplierName.Clear()
        FrmManageSupplier.TxtAddress.Clear()
        LoadPaymentTerm()
    End Sub
    Sub LoadPaymentTerm()
        FrmManageSupplier.RadDropDownListPaymentTerm.Items.Clear()
        field = "PaymentName"
        table = "PaymentType"
        Where = ""
        Dim DataPaymentTerm As DataTable = executesql("SELECT PaymentName FROM PaymentType")
        If IsNothing(DataPaymentTerm) Then
            MsgBox("ไม่มีประเภทการชำระเงิน", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "")
        'Dim DataPaymentTerm As DataTable = executesql("SELECT PaymentName FROM PaymentType")
        Dim RowsDataPaymentTerm As Integer = DataPaymentTerm.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataPaymentTerm - 1
            Dim PaymentName As String = DataPaymentTerm(i)("PaymentName")
            FrmManageSupplier.RadDropDownListPaymentTerm.Items.Add(PaymentName)
        Next
    End Sub
    Sub LoadDataSupplier()
        FrmManageSupplier.DgSupplier.Rows.Clear()
        field = "SupplierId,SupCode,SupName"
        table = "Supplier"
        Where = "Active=1"
        Dim DataSupplier As DataTable = executesql("SELECT SupplierId,SupCode,SupName FROM Supplier WHERE Active=1 ")
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
        'Dim DataSupplier As DataTable = executesql("SELECT SupplierId,SupCode,SupName FROM Supplier WHERE Active=1 ")
        'Check DBNull
        If DataSupplier.Rows.Count = 0 Then
            'MsgBox("ไม่มีข้อมูลผู้ขาย", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim RowsDataSupplier As Integer = DataSupplier.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataSupplier - 1
            Dim SupCode As String = DataSupplier(i)("Supcode")
            Dim SupName As String = DataSupplier(i)("SupName")
            Dim SupId As String = DataSupplier(i)("SupplierId")
            FrmManageSupplier.DgSupplier.Rows.Add(SupCode, SupName, SupId)
        Next
    End Sub
    Sub LoadCodeSupplier()
        'Load Code Supplier
        Dim DataMaxIdSupplier As DataTable = executesql("SELECT Max(SupplierId) FROM Supplier")
        'If IsNothing(DataMaxIdSupplier) Then
        '    Exit Sub
        'End If
        Dim SupCode As String
        Dim DateNow As String = Convert.ToDateTime(Now).ToString("ddMM", New System.Globalization.CultureInfo("th-TH"))
        If IsDBNull(DataMaxIdSupplier(0)(0)) Then
            SupCode = 1
        Else
            Dim SupplierId As Integer = DataMaxIdSupplier(0)(0)
            SupCode = SupplierId + 1
        End If
        SupCode = "S" & DateNow & SupCode
        FrmManageSupplier.TxtCodeSupplier.Text = SupCode
    End Sub
    Sub SaveSupplier()
        'CheckSupplierCode()
        'Check Data Detail 
        If FrmManageSupplier.TxtCodeSupplier.Text = "" Or FrmManageSupplier.TxtSupplierName.Text = "" Or FrmManageSupplier.TxtAddress.Text = "" Or FrmManageSupplier.RadDropDownListPaymentTerm.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            'Insert Supplier
            Dim SupCode As String = FrmManageSupplier.TxtCodeSupplier.Text
            Dim SupName As String = FrmManageSupplier.TxtSupplierName.Text
            Dim Address As String = FrmManageSupplier.TxtAddress.Text
            Dim PaymentTerm As String = FrmManageSupplier.RadDropDownListPaymentTerm.Text
            Dim PaymentTermId As Integer
            Dim PaymentTermName As DataTable = executesql("SELECT PaymentId FROM PaymentType WHERE PaymentName='" & FrmManageSupplier.RadDropDownListPaymentTerm.Text & "'")
            If IsNothing(PaymentTermName) Then
                MsgBox("Not PaymentTermName")
                Exit Sub
            End If
            Dim InsDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            Dim Active As Integer = 1
            Dim UserId As Integer = Frm_Login.UserId
            PaymentTermId = PaymentTermName(0)("PaymentId")
            executesql("INSERT INTO Supplier(SupCode,SupName,Address,PaymentTermId,Active,InsertDate,UserId) VALUES('" & SupCode & "','" & SupName & "','" & Address & "','" & PaymentTermId & "','" & Active & "','" & InsDate & "','" & UserId & "')")
            ClearText()
            LoadDataSupplier()
            LoadCodeSupplier()
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub LoadDetailSupplier()
        'Load Detail Supplier 
        Dim SupId As Integer = FrmManageSupplier.SupidSend
        Dim DataDetailSupplier As DataTable = executesql("SELECT SupCode,SupName,Address,PaymentTermId FROM Supplier WHERE SupplierId='" & SupId & "'")
        If IsNothing(DataDetailSupplier) Then
            MsgBox("ไม่มีข้อมูลรายละเอียด ผู้ขาย", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim SupCode As String = DataDetailSupplier(0)("SupCode")
        Dim SupName As String = DataDetailSupplier(0)("SupName")
        Dim Address As String = DataDetailSupplier(0)("Address")
        Dim PaymentTermId As Integer = DataDetailSupplier(0)("PaymentTermId")
        'Select PaymentName
        Dim PaymentName As String = ""
        Dim PaymentTermName As DataTable = executesql("SELECT PaymentName FROM PaymentType WHERE PaymentId='" & PaymentTermId & "'")
        If PaymentTermName.Rows.Count = 0 Then
            PaymentName = ""
            'MsgBox("ไม่มีข้อมูลประเภท การจ่ายเงิน", MsgBoxStyle.Critical)
            'Exit Sub
        Else
            PaymentName = PaymentTermName(0)("PaymentName")
        End If
        FrmManageSupplier.TxtCodeSupplier.Text = SupCode
        FrmManageSupplier.TxtSupplierName.Text = SupName
        FrmManageSupplier.TxtAddress.Text = Address
        FrmManageSupplier.RadDropDownListPaymentTerm.Text = PaymentName
    End Sub
    Sub UpdateSupplier()
        'UpdateSupplier
        'Check Data Detail 
        'CheckSupplierCode()
        If FrmManageSupplier.TxtCodeSupplier.Text = "" Or FrmManageSupplier.TxtSupplierName.Text = "" Or FrmManageSupplier.TxtAddress.Text = "" Or FrmManageSupplier.RadDropDownListPaymentTerm.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim SupCode As String = FrmManageSupplier.TxtCodeSupplier.Text
        Dim SupName As String = FrmManageSupplier.TxtSupplierName.Text
        Dim Address As String = FrmManageSupplier.TxtAddress.Text
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim SupId As Integer = FrmManageSupplier.SupidSend
        Dim UserId As Integer = Frm_Login.UserId
        Dim PaymentTerm As String = FrmManageSupplier.RadDropDownListPaymentTerm.Text
        Dim PaymentTermId As Integer
        Dim PaymentTermName As DataTable = executesql("SELECT PaymentId FROM PaymentType WHERE PaymentName='" & FrmManageSupplier.RadDropDownListPaymentTerm.Text & "'")
        PaymentTermId = PaymentTermName(0)("PaymentId")
        executesql("UPDATE Supplier SET SupCode='" & SupCode & "',SupName='" & SupName & "',Address='" & Address & "',PaymentTermId='" & PaymentTermId & "',UserId='" & UserId & "',UpdateDate='" & UpdateDate & "' WHERE SupplierId='" & SupId & "'")
        ClearText()
        LoadDataSupplier()
        LoadCodeSupplier()
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub DeleteSupplier()
        'Delete Supplier 
        Dim SupId As Integer = FrmManageSupplier.SupidSend
        If SupId = 0 Then
            Exit Sub
        End If
        If MsgBox("ต้องการลบข้อมูลหรือไม่", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            value = "Active=0"
            table = "Supplier"
            Where = "SupplierId='" & SupId & "'"
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&value=" & value & "&table=" & table & "&where=" & Where & "")
            executesql("UPDATE Supplier SET Active=0 WHERE SupplierId='" & SupId & "'")
            ClearText()
            LoadDataSupplier()
            LoadCodeSupplier()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Sub SearchSupplier()
        'SearchSupplier
        Dim WordSreach As String = FrmManageSupplier.TxtSrc.Text
        If WordSreach = "" Then
            Exit Sub
        End If
        Dim DataSearchSupplier As DataTable = executesql("SELECT SupplierId,SupCode,SupName FROM Supplier WHERE SupName LIKE '%" & WordSreach & "%' OR SupCode LIKE '%" & WordSreach & "%'")
        If IsNothing(DataSearchSupplier) Then
            Exit Sub
        End If
        Dim RowsDataSearchSupplier As Integer = DataSearchSupplier.Rows.Count
        Dim i As Integer
        FrmManageSupplier.DgSupplier.Rows.Clear()
        For i = 0 To RowsDataSearchSupplier - 1
            Dim SupCode As String = DataSearchSupplier(i)("SupCode")
            Dim SupName As String = DataSearchSupplier(i)("SupName")
            Dim SupId As Integer = DataSearchSupplier(i)("SupplierId")
            FrmManageSupplier.DgSupplier.Rows.Add(SupCode, SupName, SupId)
        Next
    End Sub
    'Sub CheckSupplierCode()
    '    Dim SupCode As String = FrmManageSupplier.TxtCodeSupplier.Text
    '    field = "SupCode"
    '    table = "Supplier"
    '    Where = "SupCode='" & SupCode & "'"
    '    Dim DataCheckSupCode As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=" & field & "&table=" & table & "&where=" & Where & "")
    '    'Dim DataCheckSupCode As DataTable = executesql("SELECT SupCode FROM Supplier WHERE SupCode='" & SupCode & "'")
    '    Dim RowsDataCheckSupCode As Integer = DataCheckSupCode.Rows.Count
    '    If RowsDataCheckSupCode > 0 Then
    '        MessageBox.Show("มีรหัสผู้จัดจำหน่ายนี้เเล้ว", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If
    'End Sub
End Module
