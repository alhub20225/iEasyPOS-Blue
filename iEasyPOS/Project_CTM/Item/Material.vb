Public Class Material

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ModuleMaterial.btnSave()
    End Sub

    Private Sub Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleMaterial.loadData()
        ModuleMaterial.AutoCompeleteSearchLoadUnitDefault()
    End Sub

    Private Sub ComboBoxMaterialCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMaterialCategory.SelectedIndexChanged
        ModuleMaterial.getMaterialCode()
    End Sub
    Public ImageBase64String As String
    Private Sub BrowsImageUsers_ValueChanged(sender As Object, e As EventArgs) Handles BrowsImageMaterial.ValueChanged
        'Resize Image
        Dim PathFName As String = "C:\ImageFilesPOS\ItemresizePOS.jpg"
        PictureBoxOriginal.Image = Image.FromFile(BrowsImageMaterial.Value)
        ResizeImage(PictureBoxOriginal.Image, New Size(200, 200), True)
        'Convert to Base64String 
        Dim Imageaaray() As Byte = System.IO.File.ReadAllBytes(PathFName)
        ImageBase64String = Convert.ToBase64String(Imageaaray)
    End Sub
    Public Shared MatId As Integer
    Private Sub DataGridViewMaterial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMaterial.CellClick
        Try
            MatId = DataGridViewMaterial.CurrentRow.Cells(0).Value
            ModuleMaterial.showData()
            ModuleMaterial.LoadDgUnitUse()
            'ModuleMaterial.AddUnitUseMaterial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleMaterial.clear()
        ModuleMaterial.LoadComboboxVat()
        ModuleMaterial.loadCombobox()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ModuleMaterial.btnDelete()
    End Sub
    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        ModuleMaterial.btnSearch()
    End Sub
    Private Sub Close_pos_Click(sender As Object, e As EventArgs) Handles Close_pos.Click
        Me.Close()
        Main.Close()
        Main.ShowDialog()
    End Sub

    Private Sub btb_add_cate_Click(sender As Object, e As EventArgs) Handles btb_add_cate.Click
        CategoryMaterial.ShowDialog()
    End Sub

    Private Sub BtnSelected_Click(sender As Object, e As EventArgs) Handles BtnSelected.Click
        'Btn Selected Material
        ModuleMaterial.AddUseItemUnit()
    End Sub

    Private Sub BtnEditUnit_Click(sender As Object, e As EventArgs) Handles BtnEditUnit.Click
        EditFrmItem.ShowDialog()
        EditFrmItem.BtnEditUnit()
    End Sub

    Private Sub BtnEditPo1_Click(sender As Object, e As EventArgs) Handles BtnEditPo1.Click
        EditFrmItem.ShowDialog()
        EditFrmItem.BtnEditUnit()
    End Sub

    Private Sub BtnEditPO2_Click(sender As Object, e As EventArgs) Handles BtnEditPO2.Click
        EditFrmItem.ShowDialog()
        EditFrmItem.BtnEditUnit()
    End Sub

    Private Sub BtnEditTax_Click(sender As Object, e As EventArgs) Handles BtnEditTax.Click
        EditFrmItem.ShowDialog()
        EditFrmItem.BtnEditTax()
    End Sub
End Class