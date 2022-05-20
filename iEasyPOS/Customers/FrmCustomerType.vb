Public Class FrmCustomerType
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataGridViewShowData.RowTemplate.Height = 35
        ModuleDataCustomers.SaveCustype()
    End Sub
    Public Shared CustomerTypeId As Integer = 0
    Private Sub DataGridViewShowData2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowData.CellClick
        Try
            CustomerTypeId = DataGridViewShowData.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleDataCustomers.ClearCustype()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModuleDataCustomers.DelCustype()
    End Sub

    Private Sub FrmCustomerType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ModuleDataCustomers.ShowCustype()
    End Sub

    Private Sub Cloes_Click(sender As Object, e As EventArgs) Handles cloes.Click
        Me.Close()
        txtSearch.Clear()
        txtCustype.Clear()
        DataGridViewShowData.Rows.Clear()
    End Sub

End Class