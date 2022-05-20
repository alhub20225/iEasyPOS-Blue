Module ModuleSearch
    Sub SearchCountry()
        Dim SearchCountryNameTH As String = FrmDifinitionProvince.TxtSearchCountry.Text
        Dim SearchCountryNameENG As String = FrmDifinitionProvince.TxtSearchCountryNameENG.Text

        If SearchCountryNameTH = "" And SearchCountryNameENG = "" Then
            MsgBox("กรุณาใส่ชื่อเพื่อค้นหา", MsgBoxStyle.Information)
            Exit Sub
        ElseIf SearchCountryNameTH <> "" And SearchCountryNameENG = "" Then
            FrmDifinitionProvince.Dg_Country.Rows.Clear()
            Dim SrcTHName As DataTable = executesql("SELECT CountryId,CountryNameTH,CountryNameENG FROM Countries WHERE CountryNameTH LIKE '%" & SearchCountryNameTH & "%' AND Active=1")
            For i As Integer = 0 To SrcTHName.Rows.Count - 1
                FrmDifinitionProvince.Dg_Country.Rows.Add(SrcTHName(i)("CountryNameTH"), SrcTHName(i)("CountryNameENG"), SrcTHName(i)("CountryId"))
            Next
            Exit Sub
        ElseIf SearchCountryNameTH = "" And SearchCountryNameENG <> "" Then

            Dim SrcENGName As DataTable = executesql("SELECT CountryId,CountryNameTH,CountryNameENG FROM Countries WHERE CountryNameENG LIKE '%" & SearchCountryNameENG & "%' AND Active=1")
            For i As Integer = 0 To SrcENGName.Rows.Count - 1
                FrmDifinitionProvince.Dg_Country.Rows.Add(SrcENGName(i)("CountryNameTH"), SrcENGName(i)("CountryNameENG"), SrcENGName(i)("CountryId"))
            Next
            Exit Sub
        ElseIf SearchCountryNameTH <> "" And SearchCountryNameENG <> "" Then
            MsgBox("ค้นหาได้ทีละภาษา", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub
    Sub SerachProvince()
        Dim CountryId As Integer = FrmDifinitionProvince.Country
        Dim SrcProvinceNameTH As String = FrmDifinitionProvince.TxtSerachProvince.Text
        Dim SrcProvinceNameENG As String = FrmDifinitionProvince.TxtProvinceENG.Text
        Dim field As String
        Dim table As String
        Dim where As String
        If CountryId = 0 Then
            MsgBox("กรุณาเลือกประเทศก่อน", MsgBoxStyle.Information)
            Exit Sub
        ElseIf CountryId <> 0 Then
            If SrcProvinceNameTH = "" And SrcProvinceNameENG = "" Then
                MsgBox("กรุณากรอกคำค้นหา", MsgBoxStyle.Information)
                Exit Sub
            ElseIf SrcProvinceNameTH <> "" And SrcProvinceNameENG = "" Then
                FrmDifinitionProvince.DGProvince.Rows.Clear()
                Dim DataProvinceTH As DataTable = executesql("SELECT ProvinceId,ProvinceNameTH,ProvinceNameENG FROM Provinces WHERE ProvinceNameTH LIKE '%" & SrcProvinceNameTH & "%' AND CountryId='" & CountryId & "' AND Active=1")
                For i As Integer = 0 To DataProvinceTH.Rows.Count - 1
                    FrmDifinitionProvince.DGProvince.Rows.Add(DataProvinceTH(i)("ProvinceNameTH"), DataProvinceTH(i)("ProvinceNameENG"), DataProvinceTH(i)("ProvinceId"))
                Next
                Exit Sub
            ElseIf SrcProvinceNameTH = "" And SrcProvinceNameENG <> "" Then
                FrmDifinitionProvince.DGProvince.Rows.Clear()
                field = "ProvinceId,ProvinceNameTH,ProvinceNameENG"
                table = "Provinces"
                where = "ProvinceNameENG LIKE '%" & SrcProvinceNameENG & "%' AND CountryId='" & CountryId & "' AND Active=1"
                Dim DataProvinceTH As DataTable = executesql("SELECT ProvinceId,ProvinceNameTH,ProvinceNameENG FROM Provinces WHERE ProvinceNameENG LIKE '%" & SrcProvinceNameENG & "%' AND CountryId='" & CountryId & "' AND Active=1")
                For i As Integer = 0 To DataProvinceTH.Rows.Count - 1
                    FrmDifinitionProvince.DGProvince.Rows.Add(DataProvinceTH(i)("ProvinceNameTH"), DataProvinceTH(i)("ProvinceNameENG"), DataProvinceTH(i)("ProvinceId"))
                Next
                Exit Sub
            ElseIf SrcProvinceNameTH <> "" And SrcProvinceNameENG <> "" Then
                MsgBox("ค้นหาได้ทีละภาษา", MsgBoxStyle.Information)
            End If
        End If

    End Sub
    Sub SearchDistrict()
        Dim ProvinceId As Integer = FrmDifinitionProvince.Province
        Dim SrcProvinceTH As String = FrmDifinitionProvince.TxtSearchDistrict.Text
        Dim SrcProvinceENG As String = FrmDifinitionProvince.TxtDistrictENG.Text

        If ProvinceId = 0 Then
            MsgBox("กรุณาเลือกจังหวัดก่อน", MsgBoxStyle.Information)
            Exit Sub
        ElseIf ProvinceId <> 0 Then
            If SrcProvinceTH = "" And SrcProvinceENG = "" Then
                MsgBox("กรุณากรอกชื่อที่ต้องการค้นหา", MsgBoxStyle.Information)
                Exit Sub
            ElseIf SrcProvinceTH <> "" And SrcProvinceENG = "" Then
                FrmDifinitionProvince.DGDistrict.Rows.Clear()
                Dim DataProvinceTH As DataTable = executesql("SELECT DistrictId,DistrictNameTH,DistrictNameENG FROM Districts WHERE DistrictNameTH LIKE '%" & SrcProvinceTH & "%' AND ProvinceId='" & ProvinceId & "' AND Active=1")
                For i As Integer = 0 To DataProvinceTH.Rows.Count - 1
                    FrmDifinitionProvince.DGDistrict.Rows.Add(DataProvinceTH(i)("DistrictNameTH"), DataProvinceTH(i)("DistrictNameENG"), DataProvinceTH(i)("DistrictId"))
                Next
                Exit Sub
            ElseIf SrcProvinceTH = "" And SrcProvinceENG <> "" Then
                FrmDifinitionProvince.DGDistrict.Rows.Clear()
                Dim DataProvinceENG As DataTable = executesql("SELECT DistrictId,DistrictNameTH,DistrictNameENG FROM Districts WHERE DistrictNameENG LIKE '%" & SrcProvinceENG & "%' AND ProvinceId='" & ProvinceId & "' AND Active=1")
                For i As Integer = 0 To DataProvinceENG.Rows.Count - 1
                    FrmDifinitionProvince.DGDistrict.Rows.Add(DataProvinceENG(i)("DistrictNameTH"), DataProvinceENG(i)("DistrictNameENG"), DataProvinceENG(i)("DistrictId"))
                Next
                Exit Sub
            ElseIf SrcProvinceTH <> "" And SrcProvinceENG <> "" Then
                MsgBox("ค้นหาได้ทีละภาษา", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

    End Sub
    Sub SearchSubDistrci()
        Dim District As Integer = FrmDifinitionProvince.District
        Dim SrcSubDistrictNameTH As String = FrmDifinitionProvince.TxtSerachSubDistrict.Text
        Dim SrcSubDistrictNameENG As String = FrmDifinitionProvince.TxtSubDistrictENG.Text

        If District = 0 Then
            MsgBox("กรุณาเลือกอำเภอก่อน", MsgBoxStyle.Information)
            Exit Sub
        ElseIf District <> 0 Then
            If SrcSubDistrictNameTH = "" And SrcSubDistrictNameENG = "" Then
                MsgBox("กรุณาใส่คำค้นหา", MsgBoxStyle.Information)
                Exit Sub
            ElseIf SrcSubDistrictNameTH <> "" And SrcSubDistrictNameENG = "" Then
                FrmDifinitionProvince.DgSubDistrict.Rows.Clear()
                Dim DataSrcDistrictNameTH As DataTable = executesql("SELECT SubDistrictId,SubDistrictNameTH,SubDistrictNameENG FROM SubDistricts WHERE SubDistrictNameTH LIKE '%" & SrcSubDistrictNameTH & "%' AND DistrictId='" & District & "' AND Active=1")
                For i As Integer = 0 To DataSrcDistrictNameTH.Rows.Count - 1
                    FrmDifinitionProvince.DgSubDistrict.Rows.Add(DataSrcDistrictNameTH(i)("SubDistrictNameTH"), DataSrcDistrictNameTH(i)("SubDistrictNameENG"), DataSrcDistrictNameTH(i)("SubDistrictId"))
                Next
                Exit Sub
            ElseIf SrcSubDistrictNameTH = "" And SrcSubDistrictNameENG <> "" Then
                FrmDifinitionProvince.DgSubDistrict.Rows.Clear()
                Dim DataSrcDistrictNameENG As DataTable = executesql("SELECT SubDistrictId,SubDistrictNameTH,SubDistrictNameENG FROM SubDistricts WHERE SubDistrictNameENG LIKE '%" & SrcSubDistrictNameENG & "%' AND DistrictId='" & District & "' AND Active=1")
                For i As Integer = 0 To DataSrcDistrictNameENG.Rows.Count - 1
                    FrmDifinitionProvince.DgSubDistrict.Rows.Add(DataSrcDistrictNameENG(i)("SubDistrictNameTH"), DataSrcDistrictNameENG(i)("SubDistrictNameENG"), DataSrcDistrictNameENG(i)("SubDistrictId"))
                Next
                Exit Sub
            ElseIf SrcSubDistrictNameTH = "" And SrcSubDistrictNameENG = "" Then
                MsgBox("ค้นหาได้ทีละภาษา", MsgBoxStyle.Information)
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub
End Module
