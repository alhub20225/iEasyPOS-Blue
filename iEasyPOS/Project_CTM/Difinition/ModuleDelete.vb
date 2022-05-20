Module ModuleDelete
    Sub ActiveCountry()
        If FrmDifinitionProvince.Dg_Country.Rows.Count = 0 Then

            Exit Sub
        End If
        Dim CountryNameTH As String = FrmDifinitionProvince.Dg_Country.CurrentRow.Cells(0).Value
        Dim CountryNameENG As String = FrmDifinitionProvince.Dg_Country.CurrentRow.Cells(1).Value
        Dim CountryId As Integer = FrmDifinitionProvince.Dg_Country.CurrentRow.Cells(2).Value

        If CountryId = 0 Then
            MsgBox("กรุณาเลือกข้อมูลก่อนทำการลบ", MsgBoxStyle.Information)
            Exit Sub
        ElseIf CountryId <> 0 Then
            'Countries Table
            executesql("UPDATE Countries SET Active=0 WHERE CountryId='" & CountryId & "'")
            'Provinces Table
            executesql("UPDATE Provinces SET Active=0 WHERE CountryId='" & CountryId & "'")
            'Districts
            executesql("UPDATE Districts SET Active=0 WHERE CountryId='" & CountryId & "'")
            'SubDistricts
            FrmDifinitionProvince.LoadCountry()
            MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub
    Sub ActiveProvince()
        If FrmDifinitionProvince.DGProvince.Rows.Count = 0 Then

            Exit Sub
        End If
        Dim ProvinceNameTH As String = FrmDifinitionProvince.DGProvince.CurrentRow.Cells(0).Value
        Dim ProvinceNameENG As String = FrmDifinitionProvince.DGProvince.CurrentRow.Cells(1).Value
        Dim ProvinceId As Integer = FrmDifinitionProvince.DGProvince.CurrentRow.Cells(2).Value
        If ProvinceId = 0 Then
            MsgBox("กรุณาเลือกข้อมูลก่อนทำการลบ", MsgBoxStyle.Information)
            Exit Sub
        ElseIf ProvinceId <> 0 Then
            'Privince Table
            executesql("UPDATE Provinces SET Active=0 WHERE ProvinceId='" & ProvinceId & "'")
            'Districts
            Dim DataDistrict As DataTable = executesql("SELECT DistrictId  FROM Districts WHERE ProvinceId='" & ProvinceId & "' GROUP BY DistrictId ")
            For i As Integer = 0 To DataDistrict.Rows.Count - 1
                'SubDistricts
                executesql("UPDATE SubDistricts SET Active=0 WHERE DistrictId='" & DataDistrict(i)(0) & "'")
            Next
            executesql("UPDATE Districts SET Active=0 WHERE ProvinceId='" & ProvinceId & "'")
            FrmDifinitionProvince.LoadProvince()
            FrmDifinitionProvince.LoadDistrict()
            FrmDifinitionProvince.LoadSubDistrict()
            MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub
    Sub ActiveDistrict()
        If FrmDifinitionProvince.DGDistrict.Rows.Count = 0 Then

            Exit Sub
        End If
        Dim DistrictNameTH As String = FrmDifinitionProvince.DGDistrict.CurrentRow.Cells(0).Value
        Dim DistrictNameENG As String = FrmDifinitionProvince.DGDistrict.CurrentRow.Cells(1).Value
        Dim DistrictId As Integer = FrmDifinitionProvince.DGDistrict.CurrentRow.Cells(2).Value

        If DistrictId = 0 Then
            MsgBox("กรุณาเลือกข้อมูลก่อนทำการลบ", MsgBoxStyle.Information)
            Exit Sub
        ElseIf DistrictId <> 0 Then
            'District
            executesql("UPDATE Districts SET Active=0 WHERE DistrictId='" & DistrictId & "'")
            'SubDistricts
            executesql("UPDATE SubDistricts SET Active=0 WHERE DistrictId='" & DistrictId & "'")
            FrmDifinitionProvince.LoadDistrict()
            FrmDifinitionProvince.LoadSubDistrict()
            MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub
    Sub ActiveSubDistrict()
        If FrmDifinitionProvince.DgSubDistrict.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim SubDistrictNameTH As String = FrmDifinitionProvince.DgSubDistrict.CurrentRow.Cells(0).Value
        Dim SubDistrictNameENG As String = FrmDifinitionProvince.DgSubDistrict.CurrentRow.Cells(1).Value
        Dim SubDistrictId As Integer = FrmDifinitionProvince.DgSubDistrict.CurrentRow.Cells(2).Value

        If SubDistrictId = 0 Then
            MsgBox("กรุณาเลือกข้อมูลก่อนทำการลบ", MsgBoxStyle.Information)
            Exit Sub
        ElseIf SubDistrictId <> 0 Then
            'SubDistrict Table
            executesql("UPDATE SubDistricts SET Active=0 WHERE SubDistrictId='" & SubDistrictId & "'")
            FrmDifinitionProvince.LoadSubDistrict()
            MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub
End Module
