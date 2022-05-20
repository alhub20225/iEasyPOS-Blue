
Public Class FrmDifinitionProvince
    Public Shared Country As Integer
    Public Shared Province As Integer
    Public Shared District As Integer
    Public Shared SubDistrict As Integer
    Sub LoadCountry()
        Dg_Country.Rows.Clear()
        Dim DataCountry As DataTable = executesql("SELECT CountryId,CountryNameTH,CountryNameENG FROM Countries WHERE Active=1")
        For i As Integer = 0 To DataCountry.Rows.Count - 1
            Dg_Country.Rows.Add(DataCountry(i)("CountryNameTH"), DataCountry(i)("CountryNameENG"), DataCountry(i)("CountryId"))
        Next
    End Sub
    Sub LoadProvince()
        DGProvince.Rows.Clear()
        Dim field As String = "ProvinceId,ProvinceNameTH,ProvinceNameENG"
        Dim table As String = "Provinces"
        Dim where As String = "CountryId ='" & Country & "' AND Active=1"
        Dim DataProvince As DataTable = executesql("SELECT ProvinceId,ProvinceNameTH,ProvinceNameENG FROM Provinces WHERE CountryId ='" & Country & "' AND Active=1")
        For i As Integer = 0 To DataProvince.Rows.Count - 1
            DGProvince.Rows.Add(DataProvince(i)("ProvinceNameTH"), DataProvince(i)("ProvinceNameENG"), DataProvince(i)("ProvinceId"))
        Next
    End Sub
    Sub LoadDistrict()
        DGDistrict.Rows.Clear()
        Dim DataDistrict As DataTable = executesql("SELECT DistrictId,DistrictNameTH,DistrictNameENG FROM Districts WHERE ProvinceId='" & Province & "' AND Active=1")
        For i As Integer = 0 To DataDistrict.Rows.Count - 1
            DGDistrict.Rows.Add(DataDistrict(i)("DistrictNameTH"), DataDistrict(i)("DistrictNameENG"), DataDistrict(i)("DistrictId"))
        Next
    End Sub
    Sub LoadSubDistrict()
        DgSubDistrict.Rows.Clear()
        Dim field As String = "SubDistrictId,SubDistrictNameTH,SubDistrictNameENG"
        Dim table As String = "SubDistricts"
        Dim where As String = "DistrictId='" & District & "' AND Active =1"
        Dim DataSubDistrict As DataTable = executesql("SELECT SubDistrictId,SubDistrictNameTH,SubDistrictNameENG FROM SubDistricts WHERE DistrictId='" & District & "' AND Active =1")
        For i As Integer = 0 To DataSubDistrict.Rows.Count - 1
            DgSubDistrict.Rows.Add(DataSubDistrict(i)("SubDistrictNameTH"), DataSubDistrict(i)("SubDistrictNameENG"), DataSubDistrict(i)("SubDistrictId"))
        Next
    End Sub

    Private Sub FrmDifinitionProvince_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountry()
    End Sub
    Private Sub Dg_Country_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Country.CellClick
        'Load Province
        Country = Dg_Country.CurrentRow.Cells(2).Value
        LoadProvince()
    End Sub
    Private Sub DGProvince_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProvince.CellClick
        'Load District
        Province = DGProvince.CurrentRow.Cells(2).Value
        LoadDistrict()
    End Sub
    Private Sub DGDistrict_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDistrict.CellClick
        'LoadSubDistrict
        District = DGDistrict.CurrentRow.Cells(2).Value
        LoadSubDistrict()
    End Sub

    Private Sub BtnSearchCountry_Click(sender As Object, e As EventArgs) Handles BtnSearchCountry.Click
        'apiT
        ModuleSearch.SearchCountry()
    End Sub
    Private Sub BtnSearchProvince_Click(sender As Object, e As EventArgs) Handles BtnSearchProvince.Click
        'apiT
        ModuleSearch.SerachProvince()
    End Sub
    Private Sub BtnSearchDistrict_Click(sender As Object, e As EventArgs) Handles BtnSearchDistrict.Click
        'apiT
        ModuleSearch.SearchDistrict()
    End Sub
    Private Sub BtnSerachSubDistrcit_Click(sender As Object, e As EventArgs) Handles BtnSerachSubDistrcit.Click
        'apiT
        ModuleSearch.SearchSubDistrci()
    End Sub

    Private Sub BtnAddCountry_Click(sender As Object, e As EventArgs) Handles BtnAddCountry.Click
        'apiT
        ModuleAdd.AddCountry()
    End Sub

    Private Sub BtnAddProvince_Click(sender As Object, e As EventArgs) Handles BtnAddProvince.Click
        'apiT
        ModuleAdd.AddProvince()
    End Sub

    Private Sub BtnAddDistrict_Click(sender As Object, e As EventArgs) Handles BtnAddDistrict.Click
        'apiT
        ModuleAdd.AddDistrict()
    End Sub

    Private Sub BtnAddsubDistrict_Click(sender As Object, e As EventArgs) Handles BtnAddsubDistrict.Click
        'apiT
        ModuleAdd.AddSubDistrict()
    End Sub

    Private Sub BtnDeleteSubDistrict_Click(sender As Object, e As EventArgs) Handles BtnDeleteSubDistrict.Click
        'apiT
        ModuleDelete.ActiveSubDistrict()
    End Sub
    Private Sub BtnDeleteDistrict_Click(sender As Object, e As EventArgs) Handles BtnDeleteDistrict.Click
        'apiT
        ModuleDelete.ActiveDistrict()
    End Sub

    Private Sub BtnDeleteProvince_Click(sender As Object, e As EventArgs) Handles BtnDeleteProvince.Click
        'apiT
        ModuleDelete.ActiveProvince()
    End Sub

    Private Sub BtnDeleteCountry_Click(sender As Object, e As EventArgs) Handles BtnDeleteCountry.Click
        'apiT
        ModuleDelete.ActiveCountry()
    End Sub
End Class