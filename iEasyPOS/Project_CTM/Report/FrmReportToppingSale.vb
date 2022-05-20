Public Class FrmReportToppingSale
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        If ComboPeper.Text = "A4" Then
            Dim report As New Report_ToppingSale

            report.Parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
            report.Parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
            Dim CheckDtata As DataTable = executesql("select count(UseTopping.ToppingId) as Count_ToppingId,
                           UseTopping.ToppingName,
                           sum(Topping.Pricing) as Sum_Pricing,
                           Item.ItemName,
                           CategoryItem.CategoryName
                      from (((((dbo.UseTopping UseTopping
                      inner join dbo.Topping Topping
                           on (Topping.ToppingId = UseTopping.ToppingId))
                      inner join dbo.SaleItem SaleItem
                           on (SaleItem.SaleItemId = UseTopping.SaleItemId))
                      inner join dbo.Sale Sale
                           on (Sale.SaleId = SaleItem.SaleId))
                      inner join dbo.Item Item
                           on (Item.ItemId = SaleItem.ItemId))
                      inner join dbo.CategoryItem CategoryItem
                           on (CategoryItem.CategoryId = Item.CategoryId))
                    where Sale.SaleDate BETWEEN '" & report.Parameter1.Value & "' AND '" & report.Parameter2.Value & "' AND Sale.Active = 1
                    group by CategoryItem.CategoryName,
                           SaleItem.ItemName, Item.ItemName,
                           UseTopping.ToppingName")
            If CheckDtata.Rows.Count = 0 Then
                MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "รายงานการขายสินค้า(Topping)")
                Exit Sub
            End If
            report.CreateDocument()
            DocumentViewer1.DocumentSource = report
        ElseIf ComboPeper.Text = "80mm" Then
            Dim report As New Report_ToppingSale80mm

            report.Parameter1.Value = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
            report.Parameter2.Value = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
            Dim CheckDtata As DataTable = executesql("select count(UseTopping.ToppingId) as Count_ToppingId,
                           UseTopping.ToppingName,
                           sum(Topping.Pricing) as Sum_Pricing,
                           Item.ItemName,
                           CategoryItem.CategoryName
                      from (((((dbo.UseTopping UseTopping
                      inner join dbo.Topping Topping
                           on (Topping.ToppingId = UseTopping.ToppingId))
                      inner join dbo.SaleItem SaleItem
                           on (SaleItem.SaleItemId = UseTopping.SaleItemId))
                      inner join dbo.Sale Sale
                           on (Sale.SaleId = SaleItem.SaleId))
                      inner join dbo.Item Item
                           on (Item.ItemId = SaleItem.ItemId))
                      inner join dbo.CategoryItem CategoryItem
                           on (CategoryItem.CategoryId = Item.CategoryId))
                    where Sale.SaleDate BETWEEN '" & report.Parameter1.Value & "' AND '" & report.Parameter2.Value & "' AND Sale.Active = 1
                    group by CategoryItem.CategoryName,
                           SaleItem.ItemName, Item.ItemName,
                           UseTopping.ToppingName")
            If CheckDtata.Rows.Count = 0 Then
                MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "รายงานการขายสินค้า(Topping)")
                Exit Sub
            End If
            report.CreateDocument()
            DocumentViewer1.DocumentSource = report
        End If


    End Sub

    Private Sub FrmReportToppingSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class