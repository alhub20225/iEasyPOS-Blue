Module ModuleDataCustomers
    Sub LoadCountry()
        ManageCustomers.ComboCountryName.Items.Clear()
        'Dim DataCountry As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=CountryNameTH&table=Countries&where=Active=1")
        Dim DataCountry As DataTable = executesql("SELECT CountryNameTH FROM Countries WHERE Active=1")
        For i As Integer = 0 To DataCountry.Rows.Count - 1
            ManageCustomers.ComboCountryName.Items.Add(DataCountry(i)("CountryNameTH"))
        Next
    End Sub
    Sub LoadProvinces(CountryNameSent As String)
        If CountryNameSent = "" Then
            Exit Sub
        End If
        Dim CountryName As String = CountryNameSent
        ManageCustomers.ComboProvinceName.Items.Clear()
        'Dim CountryId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=CountryId&table=Countries&where=CountryNameTH='" & CountryName & "' AND Active=1")
        Dim CountryId As DataTable = executesql("SELECT CountryId FROM Countries WHERE CountryNameTH='" & CountryName & "' AND Active=1")
        'Dim DataProvince As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ProvinceNameTH&table=Provinces&where=CountryId='" & CountryId(0)("CountryId") & "' AND Active=1")
        Dim DataProvince As DataTable = executesql("SELECT ProvinceNameTH FROM Provinces WHERE CountryId='" & CountryId(0)("CountryId") & "' AND Active=1")
        For i As Integer = 0 To DataProvince.Rows.Count - 1
            ManageCustomers.ComboProvinceName.Items.Add(DataProvince(i)("ProvinceNameTH"))
        Next
    End Sub
    Sub LoadDistricts(ProvinceSent As String)
        If ProvinceSent = "" Then
            Exit Sub
        End If
        ManageCustomers.ComboDistrictName.Items.Clear()
        Dim Province As String = ProvinceSent
        'Dim ProvinceId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ProvinceId&table=Provinces&where=ProvinceNameTH='" & Province & "' AND Active=1")
        Dim ProvinceId As DataTable = executesql("SELECT ProvinceId FROM Provinces WHERE ProvinceNameTH='" & Province & "' AND Active=1")
        'Dim DataDistrict As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=DistrictNameTH&table=Districts&where=ProvinceId='" & ProvinceId(0)("ProvinceId") & "' AND Active=1")
        Dim DataDistrict As DataTable = executesql("SELECT DistrictNameTH FROM Districts WHERE ProvinceId='" & ProvinceId(0)("ProvinceId") & "' AND Active=1")
        For i As Integer = 0 To DataDistrict.Rows.Count - 1
            ManageCustomers.ComboDistrictName.Items.Add(DataDistrict(i)("DistrictNameTH"))
        Next
    End Sub
    Sub LoadSubDistricts(District As String)
        'If District = "" Then
        '    Exit Sub
        'End If
        'ManageCustomers.ComboSubDistrict.Items.Clear()
        'Dim DistrctName As String = District
        ''Dim DistrictId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=DistrictId&table=Districts&where=DistrictNameTH ='" & DistrctName & "' AND Active=1")
        'Dim DistrictId As DataTable = executesql("SELECT DistrictId FROM Districts WHERE DistrictNameTH ='" & DistrctName & "' AND Active=1")
        ''Dim DataSubDistrict As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=SubDistrictNameTH&table=SubDistricts&where=DistrictId ='" & DistrictId(0)("DistrictId") & "' AND Active=1")
        'Dim DataSubDistrict As DataTable = executesql("SELECT SubDistrictNameTH FROM SubDistricts WHERE DistrictId ='" & DistrictId(0)("DistrictId") & "' AND Active=1")
        ''Clipboard.SetText("SELECT SubDistrictNameTH FROM SubDistricts WHERE DistrictId ='" & DistrictId(0)("DistrictId") & "' AND Active=1")
        'For i As Integer = 0 To DataSubDistrict.Rows.Count - 1
        '    ManageCustomers.ComboSubDistrict.Items.Add(DataSubDistrict(i)("SubDistrictNameTH"))
        'Next
    End Sub
    Sub LoadTitleName()
        ManageCustomers.ComboTitles.Items.Clear()
        'Dim DataTitle As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=TitleName&table=Titles")
        Dim DataTitle As DataTable = executesql("SELECT TitleName FROM Titles")
        For i As Integer = 0 To DataTitle.Rows.Count - 1
            ManageCustomers.ComboTitles.Items.Add(DataTitle(i)("TitleName"))
        Next
    End Sub
    Sub LoadCustomerId()
        'Load CustomersId 
        Try
            'Dim MaxCustomersId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=Max(CustomerId)&table=Customer")
            Dim MaxCustomersId As DataTable = executesql("SELECT Max(CustomerId) FROM Customer")
            Dim CustomerId As Integer = MaxCustomersId(0)(0)
            MsgBox(MaxCustomersId(0)(0).GetType)
            If MaxCustomersId.Rows.Count = 0 Then
                CustomerId = 1
            End If
            ManageCustomers.TxtCustomerId.Text = CustomerId
            MsgBox(CustomerId)
        Catch ex As Exception

        End Try
    End Sub
    Sub loadCustomerType()
        Dim selectData As DataTable = executesql("SELECT CustomerTypeId,CustomerTypeName FROM CustomerType WHERE Active='1'")
        ManageCustomers.ComboDataTypeCustomer.Items.Clear()
        ManageCustomers.ComboCustomerType.Items.Clear()

        For i As Integer = 0 To selectData.Rows.Count - 1
            ManageCustomers.ComboDataTypeCustomer.Items.Add(selectData(i)("CustomerTypeName"))
            ManageCustomers.ComboCustomerType.Items.Add(selectData(i)("CustomerTypeName"))

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

        If ManageCustomers.ComboTitles.Text = "" Then
            MsgBox("กรุณาเลือกคำนำหน้า", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim Title As DataTable = executesql("SELECT TitleId FROM Titles WHERE TitleName = '" & ManageCustomers.ComboTitles.Text & "'")

        If ManageCustomers.TxtFristName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim FirstName As String = ManageCustomers.TxtFristName.Text

        Dim MidName As String = ""
        If ManageCustomers.TxtMidName.Text <> "" Then
            MidName = ManageCustomers.TxtMidName.Text
        End If

        If ManageCustomers.TxtLastName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim LastName As String = ManageCustomers.TxtLastName.Text

        Dim NickName As String = ""
        If ManageCustomers.TxtNickname.Text <> "" Then
            NickName = ManageCustomers.TxtNickname.Text
        End If

        If ManageCustomers.DatetimeBirthDay.Text = "" Then
            MsgBox("กรุณากรอกวันที่", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim BirthDay As String = ManageCustomers.DatetimeBirthDay.Text

        Dim Email As String = ""
        If ManageCustomers.TxtEmail.Text <> "" Then
            Email = ManageCustomers.TxtEmail.Text
        End If

        If ManageCustomers.ComboGender.Text = "" Then
            MsgBox("กรุณากรอกเพศ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim Gender As DataTable = executesql("SELECT GenderId FROM Gender WHERE GenderName='" & ManageCustomers.ComboGender.Text & "'")

        If ManageCustomers.TxtAddress1.Text = "" Then
            MsgBox("กรุณากรอกที่อยู่", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim Address1 As String = ManageCustomers.TxtAddress1.Text

        Dim Address2 As String = ""
        If ManageCustomers.TxtAddress2.Text <> "" Then
            Address2 = ManageCustomers.TxtAddress2.Text
        End If

        If ManageCustomers.ComboCountryName.Text = "" Then
            MsgBox("กรุณากรอกประเทศ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim Country As DataTable = executesql("SELECT CountryId FROM Countries WHERE CountryNameTH='" & ManageCustomers.ComboCountryName.Text & "'")

        If ManageCustomers.ComboProvinceName.Text = "" Then
            MsgBox("กรุณาเลือกจังหวัด", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim Province As DataTable = executesql("SELECT ProvinceId FROM Provinces WHERE ProvinceNameTH='" & ManageCustomers.ComboProvinceName.Text & "'")

        If ManageCustomers.TxtPostNumber.Text = "" Then
            MsgBox("กรุณากรอกรหัสไปรษณีย์", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim ZipCode As String = ManageCustomers.TxtPostNumber.Text

        If ManageCustomers.ComboDistrictName.Text = "" Then
            MsgBox("กรุณาเลือกอำเภอ", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim District As DataTable = executesql("SELECT DistrictId FROM Districts WHERE DistrictNameTH = '" & ManageCustomers.ComboDistrictName.Text & "'")

        If ManageCustomers.txtSubDistrict.Text = "" Then
            MsgBox("กรุณากรอกตำบล", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        Dim SubDistrict As String = ManageCustomers.txtSubDistrict.Text

        Dim PhoneNumber As String = ""
        If ManageCustomers.TxtPhone.Text <> "" Then
            PhoneNumber = ManageCustomers.TxtPhone.Text
        End If

        Dim MobileNumber As String = ""
        If ManageCustomers.TxtMobilePhone.Text <> "" Then
            MobileNumber = ManageCustomers.TxtMobilePhone.Text
        End If

        Dim Fax As String = ""
        If ManageCustomers.TxtFax.Text <> "" Then
            Fax = ManageCustomers.TxtFax.Text
        End If

        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))

        If ManageCustomers.CustomerDataId = 0 Then
            Dim checkCusMember As DataTable = executesql("SELECT MemberNo FROM Customer WHERE MemberNo = '" & CusMember & "'")
            If checkCusMember.Rows.Count > 0 Then
                MsgBox("รหัสลูกค้าซ้ำ !!", MsgBoxStyle.Critical, "")
                Exit Sub
            End If

            executesql("INSERT INTO Customer(MemberNo,Title,FirstName,MidName,LastName,Active,InsertDate,UserId,DefaultMobliePhone,DefaultTelephone,Email,NickName,BirthDay,Gender,CustomerType) 
                        VALUES('" & CusMember & "','" & Title(0)("TitleId") & "','" & FirstName & "','" & MidName & "','" & LastName & "','1','" & InsertDate & "','" & Frm_Login.UserId & "','" & MobileNumber & "','" & PhoneNumber & "','" & Email & "','" & NickName & "','" & Convert.ToDateTime(BirthDay).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & Gender(0)("GenderId") & "','" & CusType(0)("CustomerTypeId") & "')")
            Clipboard.SetText("INSERT INTO Customer(MemberNo,Title,FirstName,MidName,LastName,Active,InsertDate,UserId,DefaultMobliePhone,DefaultTelephone,Email,NickName,BirthDay,Gender,CustomerType) 
                        VALUES('" & CusMember & "','" & Title(0)("TitleId") & "','" & FirstName & "','" & MidName & "','" & LastName & "','1','" & InsertDate & "','" & Frm_Login.UserId & "','" & MobileNumber & "','" & PhoneNumber & "','" & Email & "','" & NickName & "','" & Convert.ToDateTime(BirthDay).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "','" & Gender(0)("GenderId") & "','" & CusType(0)("CustomerTypeId") & "')")
            Dim CusId As DataTable = executesql("SELECT Max(CustomerId) As CustomerId FROM Customer")

            executesql("INSERT INTO CustAddress(CustomerId,Address1,Address2,CountryId,DistrictId,SubDistrict,ProvinceId,Zipcode,MobilePhone,TelePhone,Fax) VALUES('" & CusId(0)("CustomerId") & "','" & Address1 & "','" & Address2 & "','" & Country(0)("CountryId") & "','" & District(0)("DistrictId") & "','" & SubDistrict & "','" & Province(0)("ProvinceId") & "','" & ZipCode & "','" & MobileNumber & "','" & PhoneNumber & "','" & Fax & "')")

        Else
            Dim checkCusMember As DataTable = executesql("SELECT MemberNo FROM Customer WHERE MemberNo = '" & CusMember & "' AND CustomerId<>'" & ManageCustomers.CustomerDataId & "'")
            If checkCusMember.Rows.Count > 0 Then
                MsgBox("รหัสลูกค้าซ้ำ !!", MsgBoxStyle.Critical, "")
                Exit Sub
            End If
            executesql("UPDATE Customer SET MemberNo='" & CusMember & "',Title='" & Title(0)("TitleId") & "',FirstName='" & FirstName & "',MidName='" & MidName & "',LastName='" & LastName & "',UpdateDate='" & InsertDate & "',UserId='" & Frm_Login.UserId & "',DefaultMobliePhone='" & MobileNumber & "',DefaultTelephone='" & PhoneNumber & "',Email='" & Email & "',NickName='" & NickName & "',BirthDay='" & Convert.ToDateTime(BirthDay).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US")) & "',Gender='" & Gender(0)("GenderId") & "',CustomerType='" & CusType(0)("CustomerTypeId") & "' WHERE CustomerId='" & ManageCustomers.CustomerDataId & "'")
            executesql("UPDATE CustAddress SET Address1='" & Address1 & "',Address2='" & Address2 & "',CountryId='" & Country(0)("CountryId") & "',DistrictId='" & District(0)("DistrictId") & "',SubDistrict='" & SubDistrict & "',ProvinceId='" & Province(0)("ProvinceId") & "',Zipcode='" & ZipCode & "',MobilePhone='" & MobileNumber & "',TelePhone='" & PhoneNumber & "',Fax='" & Fax & "' WHERE CustomerId='" & ManageCustomers.CustomerDataId & "'")
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
        executesql("UPDATE Customer SET Active = '0', DeleteDate='" & DeleteTime & "',DeleteUserId='" & UserIdDelete & "' WHERE CustomerId='" & ManageCustomers.CustomerDataId & "'")
        loadCustomer()
        ClearTxt()
    End Sub
    Sub ShowCusData()
        Dim selectData As DataTable = executesql("SELECT Customer.*,CustAddress.* FROM Customer INNER JOIN CustAddress ON(Customer.CustomerId = CustAddress.CustomerId) WHERE Customer.CustomerId='" & ManageCustomers.CustomerDataId & "'")

        Dim CusType As DataTable = executesql("SELECT CustomerTypeName FROM CustomerType WHERE CustomerTypeId='" & selectData(0)("CustomerType") & "'")
        ManageCustomers.ComboDataTypeCustomer.Text = CusType(0)("CustomerTypeName")

        ManageCustomers.TxtCustomerId.Text = selectData(0)("MemberNo")

        Dim Title As DataTable = executesql("SELECT TitleName FROM Titles WHERE TitleId='" & selectData(0)("Title") & "'")
        ManageCustomers.ComboTitles.Text = Title(0)("TitleName")

        ManageCustomers.TxtFristName.Text = selectData(0)("FirstName")

        ManageCustomers.TxtMidName.Text = selectData(0)("MidName")
        ManageCustomers.TxtLastName.Text = selectData(0)("LastName")

        ManageCustomers.TxtNickname.Text = selectData(0)("NickName")


        ManageCustomers.DatetimeBirthDay.Text = selectData(0)("BirthDay")

        ManageCustomers.TxtEmail.Text = selectData(0)("Email")

        Dim Gender As DataTable = executesql("SELECT GenderName FROM Gender WHERE GenderId='" & selectData(0)("Gender") & "'")
        ManageCustomers.ComboGender.Text = Gender(0)("GenderName")

        ManageCustomers.TxtAddress1.Text = selectData(0)("Address1")

        ManageCustomers.TxtAddress2.Text = selectData(0)("Address2")

        Dim Country As DataTable = executesql("SELECT CountryNameTH FROM Countries WHERE CountryId='" & selectData(0)("CountryId") & "'")
        ManageCustomers.ComboCountryName.Text = Country(0)("CountryNameTH")

        Dim Province As DataTable = executesql("SELECT ProvinceNameTH FROM Provinces WHERE ProvinceId='" & selectData(0)("ProvinceId") & "'")
        ManageCustomers.ComboProvinceName.Text = Province(0)("ProvinceNameTH")

        ManageCustomers.TxtPostNumber.Text = selectData(0)("Zipcode")

        Dim District As DataTable = executesql("SELECT DistrictNameTH FROM Districts WHERE DistrictId = '" & selectData(0)("DistrictId") & "'")
        ManageCustomers.ComboDistrictName.Text = District(0)("DistrictNameTH")

        ManageCustomers.txtSubDistrict.Text = selectData(0)("SubDistrict")

        ManageCustomers.TxtPhone.Text = selectData(0)("DefaultTelephone")

        ManageCustomers.TxtMobilePhone.Text = selectData(0)("DefaultMobliePhone")

        ManageCustomers.TxtFax.Text = selectData(0)("Fax")

    End Sub
    Sub ClearTxt()
        ManageCustomers.TxtCustomerId.Clear()
        ManageCustomers.TxtFristName.Clear()
        ManageCustomers.TxtMidName.Clear()
        ManageCustomers.TxtLastName.Clear()
        ManageCustomers.TxtNickname.Clear()
        ManageCustomers.TxtEmail.Clear()
        ManageCustomers.TxtAddress1.Clear()
        ManageCustomers.TxtAddress2.Clear()
        ManageCustomers.TxtPostNumber.Clear()
        ManageCustomers.TxtMobilePhone.Clear()
        ManageCustomers.TxtPhone.Clear()
        ManageCustomers.TxtFax.Clear()
        ManageCustomers.CustomerDataId = 0
        HistoryBuy()
        ManageCustomers.DataGridView1.Rows.Clear()
        ManageCustomers.ComboCountryName.Text = ""
        ManageCustomers.ComboProvinceName.Text = ""
        ManageCustomers.ComboDistrictName.Text = ""
        ManageCustomers.txtSubDistrict.Clear()
        ManageCustomers.ComboDataTypeCustomer.Text = ""
        ManageCustomers.ComboTitles.Text = ""
        ManageCustomers.ComboGender.Text = ""
    End Sub
    Sub loadGender()
        Dim selectGender As DataTable = executesql("SELECT * FROM Gender WHERE Active='1'")
        ManageCustomers.ComboGender.Items.Clear()
        For i As Integer = 0 To selectGender.Rows.Count - 1
            ManageCustomers.ComboGender.Items.Add(selectGender(i)("GenderName"))
        Next
    End Sub
    Sub loadCustomer()
        Dim selectDataCustomer As DataTable = executesql("SELECT CustomerId,MemberNo,FirstName,LastName FROM Customer WHERE Active='1'")
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
            ManageCustomers.DataGridView2.Rows.Add(Convert.ToDateTime(selectDataSale(i)("InsertDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")), selectDataSale(i)("ItemName"), FormatNumber(selectDataSale(i)("Qty"), 2), FormatNumber(DC, 2), FormatNumber((selectDataSale(i)("Total") / selectDataSale(i)("Qty")) - DC, 2), FormatNumber(selectDataSale(i)("Total") - DC, 2), selectDataSale(i)("SaleNo"))
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
            ManageCustomers.DataGridView1.Rows.Add(Convert.ToDateTime(selectDataUsePoint(i)("InsertDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH")), selectDataUsePoint(i)("ItemName"), selectDataUsePoint(i)("Qty"), FormatNumber(selectDataUsePoint(i)("PointRate") / selectDataUsePoint(i)("Qty"), 2), FormatNumber(selectDataUsePoint(i)("PointRate"), 2))
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
