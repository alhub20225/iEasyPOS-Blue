Public Class FrmToppings
    Private Sub FrmToppings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        DataGridViewToppingList.RowTemplate.Height = 35
        DataGridViewToppingReceipe.RowTemplate.Height = 35
        DataGridViewShowMatToppingList.RowTemplate.Height = 35

        XtraTabMain.SelectedTabPageIndex = 0
        Btn1.ForeColor = Color.FromArgb(45, 149, 239)
        PN1.Visible = True
        Btn2.ForeColor = Color.FromArgb(65, 73, 86)
        PN2.Visible = False

        ModuleTopping.loadCategoryTopping()
        ModuleTopping.loadData()
        'Receipe Topping
        ModuleAddToppingReceipe.loadMatCate()
    End Sub

    'Private Sub RadDropDownListCateTopping_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
    '    ModuleTopping.getToppingCode()
    'End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ModuleTopping.clearData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        ModuleTopping.btnSave()
    End Sub
    Public Shared toppingIds As Integer = 0
    Private Sub DataGridViewToppingList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingList.CellClick
        Try
            toppingIds = DataGridViewToppingList.CurrentRow.Cells(0).Value
            ModuleTopping.showData()
            ModuleAddToppingReceipe.showData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCate_Click(sender As Object, e As EventArgs) Handles btnCate.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(FrmCategoryTopping.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.2
            plexi.Show()
            FrmCategoryTopping.StartPosition = FormStartPosition.CenterParent
            FrmCategoryTopping.ShowDialog(plexi)
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ModuleTopping.btnSearch()
    End Sub

    Private Sub btnSearchMatTopping_Click(sender As Object, e As EventArgs) Handles btnSearchMatTopping.Click
        ModuleAddToppingReceipe.btnSearch()
    End Sub
    Public Shared ItemIdToTopping As Integer = 0
    Public Shared ItemNameTopping As String
    Public Shared ItemCodeToppings As String
    Private Sub btnAddToppingReceipe_Click(sender As Object, e As EventArgs) Handles btnAddToppingReceipe.Click
        Try
            If toppingIds = 0 Then
                MsgBox("กรุณาเลือกรายการ Topping", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf ItemIdToTopping = 0 Then
                MsgBox("กรุณาเลือกวัตถุดิบ", MsgBoxStyle.Critical)
                Exit Sub
            End If
            ItemNameTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(1).Value
            ItemIdToTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(3).Value
            ItemCodeToppings = DataGridViewShowMatToppingList.CurrentRow.Cells(4).Value
            FrmAddToppingReceipe.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewShowMatToppingList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowMatToppingList.CellClick
        Try
            ItemNameTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(1).Value
            ItemIdToTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(3).Value
            ItemCodeToppings = DataGridViewShowMatToppingList.CurrentRow.Cells(4).Value
            'FrmAddToppingReceipe.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridViewShowMatToppingList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowMatToppingList.CellContentDoubleClick
        Try
            If toppingIds = 0 Then
                MsgBox("กรุณาเลือกรายการ Topping", MsgBoxStyle.Critical)
                Exit Sub
            End If
            ItemNameTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(1).Value
            ItemIdToTopping = DataGridViewShowMatToppingList.CurrentRow.Cells(3).Value
            ItemCodeToppings = DataGridViewShowMatToppingList.CurrentRow.Cells(4).Value
            FrmAddToppingReceipe.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleTopping.clearData()
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        ModuleTopping.btnSave()
        ModuleTopping.loadData()
    End Sub
    Public Shared ToppingReceipeId As Integer = 0
    Private Sub DataGridViewToppingReceipe_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingReceipe.CellDoubleClick
        Try
            ToppingReceipeId = DataGridViewToppingReceipe.CurrentRow.Cells(2).Value
            FrmAddToppingReceipe.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridViewToppingReceipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingReceipe.CellClick
        Try
            ToppingReceipeId = DataGridViewToppingReceipe.CurrentRow.Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModuleAddToppingReceipe.btnDel()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        XtraTabMain.SelectedTabPageIndex = 0
        Btn1.ForeColor = Color.FromArgb(45, 149, 239)
        PN1.Visible = True
        Btn2.ForeColor = Color.FromArgb(65, 73, 86)
        PN2.Visible = False

        RadDropDownListCateToppingSearch.Properties.Items.Clear()
        txtNameSearch.Clear()
        txtMatTopping.Clear()
        RadDropDownListCategoryMatTopping.Properties.Items.Clear()
        ComboBox1.Items.Clear()
        txtToppingCode.Clear()
        txtNameTopping.Clear()
        txtToppingNameEN.Clear()
        txtPricing.Clear()
        txtToppingCosting.Clear()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        XtraTabMain.SelectedTabPageIndex = 1
        Btn1.ForeColor = Color.FromArgb(45, 149, 239)
        PN1.Visible = False
        Btn2.ForeColor = Color.FromArgb(65, 73, 86)
        PN2.Visible = True

        RadDropDownListCateToppingSearch.Properties.Items.Clear()
        txtNameSearch.Clear()
        txtMatTopping.Clear()
        RadDropDownListCategoryMatTopping.Properties.Items.Clear()
        ComboBox1.Items.Clear()
        txtToppingCode.Clear()
        txtNameTopping.Clear()
        txtToppingNameEN.Clear()
        txtPricing.Clear()
        txtToppingCosting.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        RadDropDownListCateToppingSearch.Properties.Items.Clear()
        txtNameSearch.Clear()
        txtMatTopping.Clear()
        RadDropDownListCategoryMatTopping.Properties.Items.Clear()
        ComboBox1.Items.Clear()
        txtToppingCode.Clear()
        txtNameTopping.Clear()
        txtToppingNameEN.Clear()
        txtPricing.Clear()
        txtToppingCosting.Clear()
    End Sub

    Private Sub RadDropDownListCateTopping_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ModuleTopping.getToppingCode()
    End Sub

    'Private Sub DataGridViewToppingList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewToppingList.CellContentClick
    '    toppingIds = DataGridViewToppingList.CurrentRow.Cells(0).Value
    '    ModuleTopping.showData()
    'End Sub
End Class