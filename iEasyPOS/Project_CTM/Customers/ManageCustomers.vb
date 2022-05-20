Public Class ManageCustomers
    Private Sub ManageCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleCheckRoles.CheckRolesUserAuthority()
        ModuleDataCustomers.LoadCountry()
        ModuleDataCustomers.LoadTitleName()
        ModuleDataCustomers.LoadCustomerId()
        ModuleDataCustomers.loadGender()
        ModuleDataCustomers.loadCustomerType()

        'load Customer 
        ModuleDataCustomers.loadCustomer()
    End Sub

    Private Sub ComboCountryName_Validated(sender As Object, e As EventArgs) Handles ComboCountryName.Validated
        ModuleDataCustomers.LoadProvinces(ComboCountryName.Text)
    End Sub
    Private Sub ComboProvinceName_Validated(sender As Object, e As EventArgs) Handles ComboProvinceName.Validated
        ModuleDataCustomers.LoadDistricts(ComboProvinceName.Text)
    End Sub

    Private Sub ComboDistrictName_Validated(sender As Object, e As EventArgs) Handles ComboDistrictName.Validated
        ModuleDataCustomers.LoadSubDistricts(ComboDistrictName.Text)
    End Sub

    Private Sub Close_pos_Click(sender As Object, e As EventArgs) Handles Close_pos.Click
        Me.Close()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ModuleDataCustomers.DeleteCustomers()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ModuleDataCustomers.AddCustomers()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ModuleDataCustomers.ClearTxt()
        ModuleDataCustomers.LoadCustomerId()
    End Sub
    Public Shared CustomerDataId As Integer = 0
    Private Sub DgCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCustomers.CellClick
        Try
            CustomerDataId = DgCustomers.CurrentRow.Cells(2).Value
            ModuleDataCustomers.ShowCusData()
            ModuleDataCustomers.HistoryBuy()
            ModuleDataCustomers.HistoryUsePoint()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnManageCustype_Click(sender As Object, e As EventArgs) Handles btnManageCustype.Click
        FrmCustomerType.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        SearchData()
    End Sub
End Class