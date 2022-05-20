Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class ReportMaterial
    Dim DateOpenShift As DateTime
    Dim DateCloseShift As DateTime
    Private Sub ReportMaterial_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim Terminal As String = Environment.MachineName
        Dim DataOpenShift As DataTable = executesql("SELECT ShiftId,TypeShift,DateTimeOpen,UserId,MoneyCash FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "' AND TypeShift='OPEN')")
        Dim DataCloseShift As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,B1000,B500,B100,B50,B20,C10,C5,C2,C1,C05,C025 
                                                  FROM OpenCloseShift WHERE ShiftId = (SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "' AND TypeShift='CLOSE')")
        'DateOpen = getdate(DataOpenShift(0)("DateTimeOpen"))
        'DateClose = getdate(DataCloseShift(0)("DateTimeOpen"))
        Dim Date_start = Convert.ToDateTime(FrmReportDay_mat.Datetime_Start.Value).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        Dim Date_End = Convert.ToDateTime(FrmReportDay_mat.Datetime_End.Value).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim datatable1 As DataTable = executesql("SELECT  
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
	                                              WHERE UseReceipeItem.InsertDate BETWEEN '" & Date_start & "' AND '" & Date_End & "'
	                                              GROUP BY  UseReceipeItem.MatId,
                                                  UseReceipeItem.MatInitCostUseReceipe,
                                                  UseReceipeItem.MatUnitCostUseReceipe,
                                                  UseReceipeItem.TotalInitCostUseReceipe,
                                                  UseReceipeItem.TotalCostUseReceipe,
                                                  Item.ItemCode,
                                                  Item.ItemName,
												  ItemUnit.ItemUnitName,
	                                              Costing.UnitCost")

        DataSource = datatable1
    End Sub

    'Private Sub LabelDateOpenShift_BeforePrint(sender As Object, e As PrintEventArgs) 
    '    LabelDateOpenShift.Text = DateOpen
    'End Sub

    'Private Sub LabelDateCloseShift_BeforePrint(sender As Object, e As PrintEventArgs) 
    '    LabelDateCloseShift.Text = DateClose
    'End Sub
End Class