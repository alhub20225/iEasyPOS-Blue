Public Class FrmTable_Manage
    Private Sub FrmTable_Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleManageTable.LoadZone()
        txtTableName.Text = ModuleZoneTable.TableName
    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click

    End Sub
End Class