Public Class FrmUsePoint
    Private Sub FrmUsePoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If

        ModulePosPointItem.loadItem()
        ModulePosPointItem.customerData()
    End Sub
    Private Sub btnSaveUsePointItem_Click(sender As Object, e As EventArgs) Handles btnSaveUsePointItem.Click
        ModulePosPointItem.btnSave()
    End Sub

    Sub change_to_th_text()
        Label1.Text = My.Resources.pos_use_point_th.memberID
        Label5.Text = My.Resources.pos_use_point_th.memberName
        btnSaveUsePointItem.Text = My.Resources.pos_use_point_th.save
        Label4.Text = My.Resources.pos_use_point_th.TotalPoint

        DataGridViewUseItemPoint.Columns(0).HeaderText = My.Resources.pos_use_point_th.ProductName
        DataGridViewUseItemPoint.Columns(1).HeaderText = My.Resources.pos_use_point_th.Qty
        DataGridViewUseItemPoint.Columns(2).HeaderText = My.Resources.pos_use_point_th.Point
        DataGridViewUseItemPoint.Columns(3).HeaderText = My.Resources.pos_use_point_th.TotalPoint
    End Sub
    Sub change_to_eng_text()
        Label1.Text = My.Resources.pos_use_point_en.memberID
        Label5.Text = My.Resources.pos_use_point_en.memberName
        btnSaveUsePointItem.Text = My.Resources.pos_use_point_en.save
        Label4.Text = My.Resources.pos_use_point_en.TotalPoint

        DataGridViewUseItemPoint.Columns(0).HeaderText = My.Resources.pos_use_point_en.ProductName
        DataGridViewUseItemPoint.Columns(1).HeaderText = My.Resources.pos_use_point_en.Qty
        DataGridViewUseItemPoint.Columns(2).HeaderText = My.Resources.pos_use_point_en.Point
        DataGridViewUseItemPoint.Columns(3).HeaderText = My.Resources.pos_use_point_en.TotalPoint
    End Sub
End Class