Public Class ManageCustomers
    Private Sub ManageCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
        DgCustomers.RowTemplate.Height = 35
        DataGridView2.RowTemplate.Height = 35
        DataGridView1.RowTemplate.Height = 35

        ModuleCheckRoles.CheckRolesUserAuthority()
        ModuleDataCustomers.LoadCustomerId()
        ModuleDataCustomers.loadCustomerType()

        'load Customer 
        ModuleDataCustomers.loadCustomer()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MsgBox("ต้องการลบหรือไม่", MsgBoxStyle.OkCancel, "ข้อมูลสมาชิกสมาชิก") = MsgBoxResult.Ok Then
            ModuleDataCustomers.DeleteCustomers()
        End If

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
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmCustomerType.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.6
            plexi.Show()
            FrmCustomerType.StartPosition = FormStartPosition.CenterParent
            FrmCustomerType.ShowDialog(plexi)
        End Using
        'FrmCustomerType.Show()
    End Sub

    Private Sub BtnSearch1_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        SearchData()
    End Sub

    Sub change_to_th_text()
        PageManagementBrand.Text = My.Resources.customer_th.customerData
        Label31.Text = My.Resources.customer_th.search
        Label32.Text = My.Resources.customer_th.customerType
        Label2.Text = My.Resources.customer_th.detail
        Label4.Text = My.Resources.customer_th.customerCode
        Label10.Text = My.Resources.customer_th.customerType
        Label3.Text = My.Resources.customer_th.fullName
        Label8.Text = My.Resources.customer_th.email
        Label18.Text = My.Resources.customer_th.phoneNumber
        Label58.Text = My.Resources.customer_th.address

        Label22.Text = My.Resources.customer_th.historyBuy
        Label23.Text = My.Resources.customer_th.historyPoint

        DgCustomers.Columns(0).HeaderText = My.Resources.customer_th.customerCode
        DgCustomers.Columns(1).HeaderText = My.Resources.customer_th.customerName

        DataGridView2.Columns(0).HeaderText = My.Resources.customer_th._date
        DataGridView2.Columns(1).HeaderText = My.Resources.customer_th.detail
        DataGridView2.Columns(2).HeaderText = My.Resources.customer_th.qty
        DataGridView2.Columns(3).HeaderText = My.Resources.customer_th.discount
        DataGridView2.Columns(4).HeaderText = My.Resources.customer_th.total
        DataGridView2.Columns(5).HeaderText = My.Resources.customer_th.billNo


        DataGridView1.Columns(0).HeaderText = My.Resources.customer_th._date
        DataGridView1.Columns(1).HeaderText = My.Resources.customer_th.detail
        DataGridView1.Columns(2).HeaderText = My.Resources.customer_th.qty
        DataGridView1.Columns(3).HeaderText = My.Resources.customer_th.pointUnit
        DataGridView1.Columns(4).HeaderText = My.Resources.customer_th.totalPoint

    End Sub

    Sub change_to_eng_text()
        PageManagementBrand.Text = My.Resources.customer_en.customerData
        Label31.Text = My.Resources.customer_en.search
        Label32.Text = My.Resources.customer_en.customerType
        Label2.Text = My.Resources.customer_en.detail
        Label4.Text = My.Resources.customer_en.customerCode
        Label10.Text = My.Resources.customer_en.customerType
        Label3.Text = My.Resources.customer_en.fullName
        Label8.Text = My.Resources.customer_en.email
        Label18.Text = My.Resources.customer_en.phoneNumber
        Label58.Text = My.Resources.customer_en.address

        Label22.Text = My.Resources.customer_en.historyBuy
        Label23.Text = My.Resources.customer_en.historyPoint

        DgCustomers.Columns(0).HeaderText = My.Resources.customer_en.customerCode
        DgCustomers.Columns(1).HeaderText = My.Resources.customer_en.customerName

        DataGridView2.Columns(0).HeaderText = My.Resources.customer_en._date
        DataGridView2.Columns(1).HeaderText = My.Resources.customer_en.detail
        DataGridView2.Columns(2).HeaderText = My.Resources.customer_en.qty
        DataGridView2.Columns(3).HeaderText = My.Resources.customer_en.discount
        DataGridView2.Columns(4).HeaderText = My.Resources.customer_en.total
        DataGridView2.Columns(5).HeaderText = My.Resources.customer_en.billNo


        DataGridView1.Columns(0).HeaderText = My.Resources.customer_en._date
        DataGridView1.Columns(1).HeaderText = My.Resources.customer_en.detail
        DataGridView1.Columns(2).HeaderText = My.Resources.customer_en.qty
        DataGridView1.Columns(3).HeaderText = My.Resources.customer_en.pointUnit
        DataGridView1.Columns(4).HeaderText = My.Resources.customer_en.totalPoint
    End Sub

End Class