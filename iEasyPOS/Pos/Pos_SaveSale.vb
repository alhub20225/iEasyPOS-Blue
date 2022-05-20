Public Class Pos_SaveSale
    Private Sub Pos_SaveSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If

        DataGridViewSaveSale.RowTemplate.Height = 35
        ModuleSaveSale.loadData()
    End Sub

    Private Sub DataGridViewSaveSale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSaveSale.CellClick
        ModuleSaveSale.showData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_savesale_th.saveSale
        DataGridViewSaveSale.Columns(0).HeaderText = My.Resources.pos_savesale_th._date
        DataGridViewSaveSale.Columns(1).HeaderText = My.Resources.pos_savesale_th.list

    End Sub
    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_savesale_en.saveSale
        DataGridViewSaveSale.Columns(0).HeaderText = My.Resources.pos_savesale_en._date
        DataGridViewSaveSale.Columns(1).HeaderText = My.Resources.pos_savesale_en.list

    End Sub
End Class