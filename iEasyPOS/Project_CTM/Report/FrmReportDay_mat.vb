Public Class FrmReportDay_mat
    Dim Date_start As String
    Dim Date_End As String

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Date_start = Convert.ToDateTime(Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Date_End = Convert.ToDateTime(Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim Report As New ReportMaterial
        Dim DataMat As DataTable = executesql("SELECT  
                                                   UseReceipeItem.MatId,
                                                   SUM(UseReceipeItem.Qty) as TotalQty,
	                                             Sum(UseReceipeItem.Qty)*Costing.UnitCost as TotalCosting,
                                                   Item.ItemCode,
                                                   Item.ItemName,
	                                             ItemUnit.ItemUnitName, 
	                                             Costing.UnitCost
	                                             FROM (UseReceipeItem 
                                                   INNER JOIN Item 
                                                   ON (Item.ItemId = UseReceipeItem.MatId)) 
	                                             INNER JOIN ItemUnit
	                                             ON (Item.USUnitId = ItemUnit.ItemUnitId)
	                                             INNER JOIN Costing
	                                             ON (Costing.ItemId = UseReceipeItem.MatId)  
                                                    WHERE  UseReceipeItem.InsertDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'
	                                             GROUP BY  UseReceipeItem.MatId,
                                                   UseReceipeItem.MatInitCostUseReceipe,
                                                   UseReceipeItem.MatUnitCostUseReceipe,
                                                   UseReceipeItem.TotalInitCostUseReceipe,
                                                   UseReceipeItem.TotalCostUseReceipe,
                                                   Item.ItemCode,
                                                   Item.ItemName,
	                                             ItemUnit.ItemUnitName,
	                                             Costing.UnitCost")
        Report.DataSource = DataMat
        Report.txtDateStart.Text = Convert.ToDateTime(Datetime_Start.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report.txtDateEnd.Text = Convert.ToDateTime(Datetime_End.Value).ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Report.CreateDocument()
        DocumentViewer1.DocumentSource = Report
    End Sub

    Private Sub FrmReportDay_mat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datetime_Start.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Datetime_End.Value = Convert.ToDateTime(Now).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
    End Sub
End Class