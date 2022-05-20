Module ModuleAdd
    Sub AddCountry()
        Dim CountryNameTH As String = FrmDifinitionProvince.TxtSearchCountry.Text
        Dim CountryNameENG As String = FrmDifinitionProvince.TxtSearchCountryNameENG.Text
        If CountryNameTH = "" Or CountryNameENG = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน", MsgBoxStyle.Information)
            Exit Sub
        ElseIf CountryNameTH <> "" And CountryNameENG <> "" Then
            executesql("INSERT INTO Countries(CountryNameTH,CountryNameENG,Active) VALUES('" & CountryNameTH & "','" & CountryNameENG & "',1)")
            FrmDifinitionProvince.LoadCountry()
            MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub
    Sub AddProvince()
        Dim ProvinceNameTH As String = FrmDifinitionProvince.TxtSerachProvince.Text
        Dim ProvinceNameENG As String = FrmDifinitionProvince.TxtProvinceENG.Text
        Dim CountryId As Integer = FrmDifinitionProvince.Country
        If CountryId = 0 Then
            MsgBox("กรุณาเลือกประเทศก่อนบันทึก", MsgBoxStyle.Information)
            Exit Sub
        ElseIf CountryId <> 0 Then
            If ProvinceNameTH = "" Or ProvinceNameENG = "" Then
                MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน", MsgBoxStyle.Information)
                Exit Sub
            ElseIf ProvinceNameTH <> "" And ProvinceNameENG <> "" Then
                executesql("INSERT INTO Provinces(CountryId,ProvinceNameTH,ProvinceNameENG,Active) VALUES('" & CountryId & "','" & ProvinceNameTH & "','" & ProvinceNameENG & "',1)")
                FrmDifinitionProvince.LoadProvince()
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
    End Sub
    Sub AddDistrict()
        Dim DistrictNameTH As String = FrmDifinitionProvince.TxtSearchDistrict.Text
        Dim DistrictNameENG As String = FrmDifinitionProvince.TxtDistrictENG.Text
        Dim ProvinceId As Integer = FrmDifinitionProvince.Province
        If ProvinceId = 0 Then
            MsgBox("กรุณาเลือกจังหวัดก่อนบันทึก", MsgBoxStyle.Information)
            Exit Sub
        ElseIf ProvinceId <> 0 Then
            If DistrictNameTH = "" Or DistrictNameENG = "" Then
                MsgBox("กรุณากรอกข้อมูลก่อนทำการบันทึก", MsgBoxStyle.Information)
                Exit Sub
            ElseIf DistrictNameTH <> "" And DistrictNameENG <> "" Then
                executesql("INSERT INTO Districts(DistrictNameTH,DistrictNameENG,ProvinceId,Active) VALUES('" & DistrictNameTH & "','" & DistrictNameENG & "','" & ProvinceId & "',1)")
                FrmDifinitionProvince.LoadDistrict()
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
    End Sub
    Sub AddSubDistrict()
        Dim DistrictId As Integer = FrmDifinitionProvince.District
        Dim SubDistrictNameTH As String = FrmDifinitionProvince.TxtSerachSubDistrict.Text
        Dim SubDistrictNameENG As String = FrmDifinitionProvince.TxtSubDistrictENG.Text
        If DistrictId = 0 Then
            MsgBox("กรุณาเลือก อำเภอก่อน บันทึก", MsgBoxStyle.Information)
        ElseIf DistrictId <> 0 Then
            If SubDistrictNameTH = "" Or SubDistrictNameENG = "" Then
                MsgBox("กรุณาใส่ข้อมูลให้ครบก่อนบันทึก", MsgBoxStyle.Information)
                Exit Sub
            ElseIf SubDistrictNameTH <> "" And SubDistrictNameENG <> "" Then
                executesql("INSERT INTO SubDistricts(DistrictId,SubDistrictNameTH,SubDistrictNameENG,Active) VALUES('" & DistrictId & "','" & SubDistrictNameTH & "','" & SubDistrictNameENG & "',1)")
                FrmDifinitionProvince.LoadSubDistrict()
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub
End Module
