Public Class Pos_Search
    Private Sub Pos_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridSearch.RowTemplate.Height = 35
        DataGridSearch.Rows.Clear()
        TextSearch.Text = ""

        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        DataGridSearch.Rows.Clear()
        Dim DataItems As DataTable = executesql("select ItemId,ItemCode,ItemName,ItemPrice from Item Where ItemName LIKE '%" & TextSearch.Text & "%'  and Active = 1 order by ItemName asc")

        For i As Integer = 0 To DataItems.Rows.Count - 1
            DataGridSearch.Rows.Add(DataItems(i)("ItemId"), DataItems(i)("ItemCode"), DataItems(i)("ItemName"), (FormatNumber(DataItems(i)("ItemPrice"), 2)))
        Next
    End Sub

    Private Sub BtnSerchEnter_Click(sender As Object, e As EventArgs) Handles BtnSerchEnter.Click
        POS.TextBox3.Focus()
        If DataGridSearch.Rows.Count = 0 Then
            Exit Sub
        Else
            sender.Name = DataGridSearch.CurrentRow.Cells(0).Value
            sender.Text = DataGridSearch.CurrentRow.Cells(2).Value
        End If

        ModulePOS.AddPOSItem(sender, e)
        sender.Name = Nothing
        sender.Text = Nothing
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
        DataGridSearch.Rows.Clear()
        TextSearch.Text = ""
        POS.TextBox3.Focus()
    End Sub

    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_search_product_th.searchproduct
        Label24.Text = My.Resources.pos_search_product_th.searchproduct
        BtnSerchEnter.Text = My.Resources.pos_search_product_th.ok


        DataGridSearch.Columns(1).HeaderText = My.Resources.pos_search_product_th.productcode
        DataGridSearch.Columns(2).HeaderText = My.Resources.pos_search_product_th.productName
        DataGridSearch.Columns(3).HeaderText = My.Resources.pos_search_product_th.price
    End Sub
    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_search_product_en.searchproduct
        Label24.Text = My.Resources.pos_search_product_en.searchproduct
        BtnSerchEnter.Text = My.Resources.pos_search_product_en.ok


        DataGridSearch.Columns(1).HeaderText = My.Resources.pos_search_product_en.productcode
        DataGridSearch.Columns(2).HeaderText = My.Resources.pos_search_product_en.productName
        DataGridSearch.Columns(3).HeaderText = My.Resources.pos_search_product_en.price
    End Sub
End Class