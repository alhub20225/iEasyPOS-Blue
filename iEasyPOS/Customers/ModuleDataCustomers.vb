Module ModuleDataCustomers
    Sub LoadSubDistricts(District As String)
        'If District = "" Then
        '    Exit Sub
        'End If
        'ManageCustomers.txtSubDistrict.Properties.Items.Clear()
        'Dim DistrctName As String = District

        'Dim DistrictId As DataTable = executesql("SELECT DistrictId FROM Districts WHERE DistrictNameTH ='" & DistrctName & "' AND Active=1")

        'Dim DataSubDistrict As DataTable = executesql("SELECT SubDistrictNameTH FROM SubDistricts WHERE DistrictId ='" & DistrictId(0)("DistrictId") & "' AND Active=1")

        'For i As Integer = 0 To DataSubDistrict.Rows.Count - 1
        '    ManageCustomers.txtSubDistrict.Properties.Items.Add(DataSubDistrict(i)("SubDistrictNameTH"))
        'Next
    End Sub
    Sub LoadCustomerId()
        'Load CustomersId 
        Dim MaxCustomersId As DataTable = executesql("SELECT Max(CustomerId) as CustomerId FROM Customer")
        Dim CustomerId As Integer = 0
        If Not IsDBNull(MaxCustomersId(0)("CustomerId")) Then
            CustomerId = MaxCustomersId(0)("CustomerId")
        End If
        If MaxCustomersId.Rows.Count = 0 Then
            CustomerId = 1
        End If
        ManageCustomers.TxtCustomerId.Text = CustomerId
    End Sub
    Sub loadCustomerType()
        Dim selectData As DataTable = executesql("SELECT CustomerTypeId,CustomerTypeName FROM CustomerType WHERE Active='1'")
        ManageCustomers.ComboDataTypeCustomer.Properties.Items.Clear()
        ManageCustomers.ComboCustomerType.Properties.Items.Clear()

        For i As Integer = 0 To selectData.Rows.Count - 1
            ManageCustomers.ComboDataTypeCustomer.Properties.Items.Add(selectData(i)("CustomerTypeName"))
            ManageCustomers.ComboCustomerType.Properties.Items.Add(selectData(i)("CustomerTypeName"))

        Next
    End Sub
    Sub AddCustomers()
        'Insert Customers
        If ManageCustomers.ComboDataTypeCustomer.Text = "" Then
            MsgBox("กรุณาเลือกประเภทลูกค้า", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim CusType As DataTable = executesql("SELECT CustomerTypeId FROM CustomerType WHERE CustomerTypeName='" & ManageCustomers.ComboDataTypeCustomer.Text & "'")

        If ManageCustomers.TxtCustomerId.Text = "" Then
            MsgBox("กรุณากรอกรหัสลูกค้า", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim CusMember As String = ManageCustomers.TxtCustomerId.Text

        If ManageCustomers.TxtFirstName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim FirstName As String = ManageCustomers.TxtFirstName.Text

        Dim Email As String = ManageCustomers.TxtEmail.Text
        Dim Address1 As String = ManageCustomers.TxtAddress1.Text

        Dim PhoneNumber As String = ""
        If ManageCustomers.TxtPhone.Text = "" Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        If ManageCustomers.TxtPhone.Text <> "" Then
            PhoneNumber = ManageCustomers.TxtPhone.Text
        End If

        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))

        If ManageCustomers.CustomerDataId = 0 Then
            Dim checkCusMember As DataTable = executesql("SELECT MemberNo FROM Customer WHERE MemberNo = '" & CusMember & "'")
            If checkCusMember.Rows.Count > 0 Then
                MsgBox("รหัสลูกค้าซ้ำ !!", MsgBoxStyle.Critical, "")
                Exit Sub
            End If

            executesql("INSERT INTO Customer(MemberNo,FirstName,Active,InsertDate,UserId,DefaultTelephone,Email,CustomerType) 
                        VALUES('" & CusMember & "','" & FirstName & "','1','" & InsertDate & "','" & Frm_Login.UserId & "','" & PhoneNumber & "','" & Email & "','" & CusType(0)("CustomerTypeId") & "')")
            Dim CusId As DataTable = executesql("SELECT Max(CustomerId) As CustomerId FROM Customer")

            executesql("INSERT INTO CustAddress(CustomerId,Address1,Address2,CountryId,DistrictId,SubDistrict,ProvinceId,Zipcode,MobilePhone,TelePhone,Fax) VALUES('" & CusId(0)("CustomerId") & "','" & Address1 & "','','','','','','','','" & PhoneNumber & "','')")

        Else
            Dim checkCusMember As DataTable = executesql("SELECT MemberNo FROM Customer WHERE MemberNo = '" & CusMember & "' AND CustomerId<>'" & ManageCustomers.CustomerDataId & "'")
            If checkCusMember.Rows.Count > 0 Then
                MsgBox("รหัสลูกค้าซ้ำ !!", MsgBoxStyle.Critical, "")
                Exit Sub
            End If
            executesql("UPDATE Customer SET MemberNo='" & CusMember & "',FirstName='" & FirstName & "',UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',DefaultTelephone='" & PhoneNumber & "',Email='" & Email & "',CustomerType='" & CusType(0)("CustomerTypeId") & "' WHERE CustomerId='" & ManageCustomers.CustomerDataId & "'")
            executesql("UPDATE CustAddress SET Address1='" & Address1 & "',TelePhone='" & PhoneNumber & "' WHERE CustomerId='" & ManageCustomers.CustomerDataId & "'")
        End If
        MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "")
        ClearTxt()
        loadCustomer()
    End Sub
    Sub EditCustomers()
        'Edit Customer
    End Sub
    Sub DeleteCustomers()
        If ManageCustomers.CustomerDataId = 0 Then
            MsgBox("กรุณาเลือกข้อมูลต้องการลบ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        'Delete Customers
        Dim DeleteTime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim UserIdDelete As Integer = Frm_Login.UserId
        executesql("UPDATE Customer SET Active = 0, DeleteDate='" & DeleteTime & "',DeleteUserId='" & UserIdDelete & "' WHERE CustomerId='" & ManageCustomers.CustomerDataId & "'")
        ManageCustomers.DgCustomers.Rows.RemoveAt(ManageCustomers.DgCustomers.CurrentRow.Index)
        loadCustomer()
        ClearTxt()
    End Sub
    Sub ShowCusData()
        Dim selectData As DataTable = executesql("SELECT Customer.*,CustAddress.* FROM Customer INNER JOIN CustAddress ON(Customer.CustomerId = CustAddress.CustomerId) WHERE Customer.CustomerId='" & ManageCustomers.CustomerDataId & "'")

        Dim CusType As DataTable = executesql("SELECT CustomerTypeName FROM CustomerType WHERE CustomerTypeId='" & selectData(0)("CustomerType") & "'")
        ManageCustomers.ComboDataTypeCustomer.Text = CusType(0)("CustomerTypeName")

        ManageCustomers.TxtCustomerId.Text = selectData(0)("MemberNo")

        ManageCustomers.TxtFirstName.Text = selectData(0)("FirstName")

        ManageCustomers.TxtEmail.Text = selectData(0)("Email")

        ManageCustomers.TxtAddress1.Text = selectData(0)("Address1")

        ManageCustomers.TxtPhone.Text = selectData(0)("DefaultTelephone")

        ManageCustomers.TxtPhone.Text = selectData(0)("DefaultMobliePhone")

        ManageCustomers.ComboDataTypeCustomer.Text = selectData(0)("Fax")

    End Sub
    Sub ClearTxt()
        ManageCustomers.TxtCustomerId.Clear()
        ManageCustomers.TxtFirstName.Clear()
        ManageCustomers.TxtEmail.Clear()
        ManageCustomers.TxtAddress1.Clear()
        ManageCustomers.TxtPhone.Clear()
        ManageCustomers.CustomerDataId = 0
        HistoryBuy()
        ManageCustomers.DataGridView1.Rows.Clear()
        ManageCustomers.ComboDataTypeCustomer.Text = ""
    End Sub
    Sub loadCustomer()
        Dim selectDataCustomer As DataTable = executesql("SELECT CustomerId,MemberNo,FirstName,LastName FROM Customer WHERE Active=1")
        If IsNothing(selectDataCustomer) Then
            Exit Sub
        End If
        If selectDataCustomer.Rows.Count = 0 Then
            Exit Sub
        End If
        ManageCustomers.DgCustomers.Rows.Clear()
        For i As Integer = 0 To selectDataCustomer.Rows.Count - 1
            ManageCustomers.DgCustomers.Rows.Add(selectDataCustomer(i)("MemberNo"), selectDataCustomer(i)("FirstName") & " " & selectDataCustomer(i)("LastName"), selectDataCustomer(i)("CustomerId"))
        Next
    End Sub
    Sub SearchData()
        If ManageCustomers.TxtSearch.Text = "" And ManageCustomers.ComboCustomerType.Text <> "" Then
            Dim SearchData As DataTable = executesql("SELECT Customer.MemberNo,Customer.FirstName,Customer.LastName,Customer.CustomerId FROM Customer INNER JOIN CustomerType ON (CustomerType.CustomerTypeId = Customer.CustomerType) WHERE CustomerType.CustomerTypeName='" & ManageCustomers.ComboCustomerType.Text & "' AND Customer.Active='1'")
            ManageCustomers.DgCustomers.Rows.Clear()
            For i As Integer = 0 To SearchData.Rows.Count - 1
                ManageCustomers.DgCustomers.Rows.Add(SearchData(i)("MemberNo"), SearchData(i)("FirstName") & " " & SearchData(i)("LastName"), SearchData(i)("CustomerId"))
            Next
        ElseIf ManageCustomers.TxtSearch.Text <> "" And ManageCustomers.ComboCustomerType.Text = "" Then
            Dim SearchData As DataTable = executesql("SELECT Customer.MemberNo,Customer.FirstName,Customer.LastName,Customer.CustomerId FROM Customer INNER JOIN CustomerType ON (CustomerType.CustomerTypeId = Customer.CustomerType) WHERE Customer.DefaultMobliePhone LIKE '%" & ManageCustomers.TxtSearch.Text & "%' OR Customer.DefaultTelephone LIKE '%" & ManageCustomers.TxtSearch.Text & "%' OR Customer.MemberNo LIKE '%" & ManageCustomers.TxtSearch.Text & "%' OR Customer.FirstName LIKE '%" & ManageCustomers.TxtSearch.Text & "%' AND Customer.Active='1'")
            ManageCustomers.DgCustomers.Rows.Clear()
            For i As Integer = 0 To SearchData.Rows.Count - 1
                ManageCustomers.DgCustomers.Rows.Add(SearchData(i)("MemberNo"), SearchData(i)("FirstName") & " " & SearchData(i)("LastName"), SearchData(i)("CustomerId"))
            Next
        ElseIf ManageCustomers.TxtSearch.Text <> "" And ManageCustomers.ComboCustomerType.Text <> "" Then
            Dim SearchData As DataTable = executesql("SELECT Customer.MemberNo,Customer.FirstName,Customer.LastName,Customer.CustomerId FROM Customer INNER JOIN CustomerType ON (CustomerType.CustomerTypeId = Customer.CustomerType) WHERE CustomerType.CustomerTypeName='" & ManageCustomers.ComboCustomerType.Text & "' AND Customer.DefaultMobliePhone LIKE '%" & ManageCustomers.TxtSearch.Text & "%' OR Customer.DefaultTelephone LIKE '%" & ManageCustomers.TxtSearch.Text & "%' OR Customer.MemberNo LIKE '%" & ManageCustomers.TxtSearch.Text & "%' OR Customer.FirstName LIKE '%" & ManageCustomers.TxtSearch.Text & "%' AND Customer.Active='1'")
            ManageCustomers.DgCustomers.Rows.Clear()
            For i As Integer = 0 To SearchData.Rows.Count - 1
                ManageCustomers.DgCustomers.Rows.Add(SearchData(i)("MemberNo"), SearchData(i)("FirstName") & " " & SearchData(i)("LastName"), SearchData(i)("CustomerId"))
            Next
        End If
    End Sub
    Sub HistoryBuy()
        Dim selectDataSale As DataTable = executesql("select Sale.InsertDate,SaleItem.ItemName,SaleItem.Qty,SaleItem.Total,SaleItem.BahtDC,SaleItem.PercentDC,Sale.SaleNo from Sale
            inner join SaleItem on(Sale.SaleId = SaleItem.SaleId ) 
            inner join PaymentDetail on(Sale.SaleId = PaymentDetail.SaleId ) 
            inner join Customer on(Customer.CustomerId = sale.CustomerId) 
            where Customer.CustomerId ='" & ManageCustomers.CustomerDataId & "'")
        If IsNothing(selectDataSale) Then
            ManageCustomers.DataGridView2.Rows.Clear()
            Exit Sub
        End If
        If selectDataSale.Rows.Count = 0 Then
            ManageCustomers.DataGridView2.Rows.Clear()
            Exit Sub
        End If
        ManageCustomers.DataGridView2.Rows.Clear()
        Dim DC As Decimal
        For i As Integer = 0 To selectDataSale.Rows.Count - 1
            If selectDataSale(i)("BahtDC") = 0 Then
                DC = selectDataSale(i)("PercentDC")
            ElseIf selectDataSale(i)("PercentDC") = 0 Then
                DC = selectDataSale(i)("BahtDC")
            End If
            ManageCustomers.DataGridView2.Rows.Add(Convert.ToDateTime(selectDataSale(i)("InsertDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH")), selectDataSale(i)("ItemName"), FormatNumber(selectDataSale(i)("Qty"), 2), FormatNumber(DC, 2), FormatNumber((selectDataSale(i)("Total") / selectDataSale(i)("Qty")) - DC, 2), FormatNumber(selectDataSale(i)("Total") - DC, 2), selectDataSale(i)("SaleNo"))
        Next
    End Sub
    Sub HistoryUsePoint()
        Dim selectDataUsePoint As DataTable = executesql("select UsePointItem.InsertDate,UsePointItem.Qty,UsePointItem.PointRate,Item.ItemName from UsePointItem inner join Item on(Item.ItemId=UsePointItem.ItemId) inner join Customer on(UsePointItem.CustomerNo = Customer.MemberNo) where Customer.CustomerId = '" & ManageCustomers.CustomerDataId & "'")
        If IsNothing(selectDataUsePoint) Then
            ManageCustomers.DataGridView1.Rows.Clear()
            Exit Sub
        End If
        If selectDataUsePoint.Rows.Count = 0 Then
            ManageCustomers.DataGridView1.Rows.Clear()
            Exit Sub
        End If
        ManageCustomers.DataGridView1.Rows.Clear()
        For i As Integer = 0 To selectDataUsePoint.Rows.Count - 1
            ManageCustomers.DataGridView1.Rows.Add(Convert.ToDateTime(selectDataUsePoint(i)("InsertDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), selectDataUsePoint(i)("ItemName"), selectDataUsePoint(i)("Qty"), FormatNumber(selectDataUsePoint(i)("PointRate") / selectDataUsePoint(i)("Qty"), 2), FormatNumber(selectDataUsePoint(i)("PointRate"), 2))
        Next
    End Sub
    'CustomerType 
    Sub SaveCustype()
        If FrmCustomerType.txtCustype.Text = "" Then
            MsgBox("กรุณากรอกชื่อประเภทลูกค้า", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        If FrmCustomerType.CustomerTypeId = 0 Then
            'insert
            executesql("INSERT INTO CustomerType(CustomerTypeName,Active) VALUES('" & FrmCustomerType.txtCustype.Text & "','1')")
        Else
            'update  
        End If
        MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "")
        ShowCustype()
        ClearCustype()
        loadCustomerType()
    End Sub
    Sub ShowCustype()
        Dim SelectData As DataTable = executesql("SELECT CustomerTypeId,CustomerTypeName FROM CustomerType WHERE Active='1'")
        If IsNothing(SelectData) Then
            Exit Sub
        End If
        If SelectData.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmCustomerType.DataGridViewShowData.Rows.Clear()
        For i As Integer = 0 To SelectData.Rows.Count - 1
            FrmCustomerType.DataGridViewShowData.Rows.Add(SelectData(i)("CustomerTypeName"), SelectData(i)("CustomerTypeId"))
        Next
    End Sub
    Sub DelCustype()
        If FrmCustomerType.CustomerTypeId = 0 Then
            MsgBox("กรุณาเลือกรายการที่ต้องการลบ")
            Exit Sub
        End If
        executesql("UPDATE CustomerType SET Active='0' WHERE CustomerTypeId='" & FrmCustomerType.CustomerTypeId & "'")
        ShowCustype()
        ClearCustype()
    End Sub
    Sub ClearCustype()
        FrmCustomerType.txtCustype.Clear()
        FrmCustomerType.CustomerTypeId = 0
    End Sub
End Module
