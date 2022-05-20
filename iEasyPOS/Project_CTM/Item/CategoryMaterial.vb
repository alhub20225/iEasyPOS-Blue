Public Class CategoryMaterial
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ModuleCategoryMaterial.btnSave()
        ModuleMaterial.loadData()
    End Sub

    Private Sub CategoryMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleCategoryMaterial.loadData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleCategoryMaterial.clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ModuleCategoryMaterial.btnDelete()
    End Sub
End Class