Imports DevExpress.XtraReports.UI
Public Class Frm_ReportSale_ByItem
    Public Shared Date_start As String
    Public Shared Date_End As String
    Public Shared CateName As String
    Dim DateTimeOpenShift As String
    Dim DateTimeCloseShift As String
    Private Sub Frm_ReportSale_ByItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_start = Convert.ToDateTime(DateStart.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Date_End = Convert.ToDateTime(DateEnd.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        ComboBoxCategory.Controls.Clear()
        Dim selectCategory As DataTable = executesql("Select CategoryName from CategoryItem where CateGroupId = 1 And Active=1")
        If selectCategory.Rows.Count > 0 Then
            For i As Integer = 0 To selectCategory.Rows.Count - 1
                ComboBoxCategory.Items.Add(selectCategory(i)("CategoryName"))
            Next
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If ComboBoxCategory.Text = "" Then
            MsgBox("กรุณาเลือกหมวดสินค้า", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        CateName = ComboBoxCategory.Text
        Dim Terminal As String = Environment.MachineName
        Date_start = Convert.ToDateTime(DateStart.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Date_End = Convert.ToDateTime(DateEnd.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim report As New ReportSale_ByItem
        Dim Datatable1 As DataTable = executesql("select 
Item.ItemName,
SUM(SaleItem.Qty) As Qty,
Item.ItemPrice,
SUM(SaleItem.BahtDC + SaleItem.PercentDC) As Discount,
SUM(SaleItem.SubTotal) As SubTotal,
SUM(SaleItem.Tax) As Tax
from Sale 
inner join SaleItem on(Sale.SaleId = SaleItem.SaleId)
inner join Item on(SaleItem.ItemId = Item.ItemId)
inner join PaymentDetail on(PaymentDetail.SaleId = Sale.SaleId)
inner join CategoryItem on(CategoryItem.CategoryId = Item.CategoryId)
Where SaleDate BETWEEN '" & Date_start & "' AND '" & Date_End & "' and Sale.Active = 1 and CategoryItem.CategoryName = '" & CateName & "'
Group by Item.ItemName,Item.ItemId,Item.ItemPrice
Order by Item.ItemId ASC")
        report.DataSource = Datatable1
        report.CreateDocument()
        DocumentViewer1.DocumentSource = report
    End Sub
End Class