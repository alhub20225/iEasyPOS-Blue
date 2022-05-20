Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Module ModulePrinrOrder
    Sub PrintOrderTable(id As Integer, tableName As String)
        Console.WriteLine("PrintOrderTable " & tableName)
        Try
            Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where statusprint= 0 AND SaleId=" & id & "  group by PrinterName")
            Dim checkRow As DataTable = executesql("SELECT SaleItemOrder.ItemName FROM  SaleItemOrder INNER JOIN SaleItem ON SaleItemOrder.SaleItemId = SaleItem.SaleItemId INNER JOIN CategoryItem ON SaleItem.CategoryId = CategoryItem.CategoryId INNER JOIN Sale ON SaleItem.SaleId = Sale.SaleId WHERE Sale.SaleId = " & id & " AND SaleItemOrder.StatusPrint = 0 And CategoryItem.AllowPrint=1")
            Console.WriteLine("checkRow.Rows.Count " & checkRow.Rows.Count)
            If checkRow.Rows.Count = 0 Then

                Dim Datatable As DataTable = executesql("SELECT id FROM SaleItemOrder WHERE StatusPrint=0")
                For i As Integer = 0 To Datatable.Rows.Count - 1
                    executesql("UPDATE SaleItemOrder SET StatusPrint=1 WHERE Id='" & Datatable(i)("Id") & "'")
                Next

                Dim dtSaleItem As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE StatusPrint=0 AND SaleId=" & id & "")
                For a As Integer = 0 To dtSaleItem.Rows.Count - 1
                    Console.WriteLine("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & dtSaleItem(a)("SaleItemId") & "'")
                    executesql("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & dtSaleItem(a)("SaleItemId") & "'")
                Next
                Exit Sub
            End If

            For e As Integer = 0 To Printer_name.Rows.Count - 1
                Dim Dx_Order As New OrderTable
                Dim PrintToll As New ReportPrintTool(Dx_Order)
                Dx_Order.Parameter1.Value = id
                Dx_Order.SqlDataSource1.Connection.ConnectionString = rptConStr
                Dx_Order.PrinterName = Printer_name(e)("PrinterName")
                PrintToll.Print()

                writeLog("User ID " + Frm_Login.UserId.ToString + " PrintOrder SaleId " + id.ToString)
                Dim Datatable As DataTable = executesql("SELECT id FROM SaleItemOrder WHERE StatusPrint=0")
                For i As Integer = 0 To Datatable.Rows.Count - 1
                    executesql("UPDATE SaleItemOrder SET StatusPrint=1 WHERE Id='" & Datatable(i)("Id") & "'")
                Next

                Dim dtSaleItem As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE StatusPrint=0 AND SaleId=" & id & "")
                For a As Integer = 0 To dtSaleItem.Rows.Count - 1
                    Console.WriteLine("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & dtSaleItem(a)("SaleItemId") & "'")
                    executesql("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & dtSaleItem(a)("SaleItemId") & "'")
                Next
            Next

        Catch ex As Exception

        End Try


    End Sub

    Sub PrintCancleOrder(Saleid As Integer, SaleItemID As Integer)
        If Saleid = 0 Or SaleItemID = 0 Then Exit Sub
        Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where Active= 0 AND SaleItemId=" & SaleItemID & " group by PrinterName")
        Dim Dx_Order As New OrderTable
        Dim PrintToll As New ReportPrintTool(Dx_Order)
        Dim ctq As DevExpress.DataAccess.Sql.CustomSqlQuery
        ctq = Dx_Order.SqlDataSource1.Queries(0)
        ctq.Sql = "select SaleItemOrder.Qty,
                       SaleItemOrder.ItemName,
                       SaleTable.SaleName, Users.FirstName
                  from ((((dbo.SaleItemOrder SaleItemOrder
                  inner join dbo.SaleItem SaleItem
                       on (SaleItem.SaleItemId = SaleItemOrder.SaleItemId))
                  inner join dbo.Sale Sale
                       on (Sale.SaleId = SaleItem.SaleId))
                  inner join dbo.SaleTable SaleTable
                       on (SaleTable.SaleId = Sale.SaleId))
                  inner join dbo.Users Users
                       on (Users.UserId = SaleItemOrder.UserId))
	                inner join CategoryItem on(CategoryItem.CategoryId = SaleItem.CategoryId)
                  WHERE Sale.SaleId = " & Saleid & " AND SaleItem.SaleItemId=" & SaleItemID & " AND SaleItem.Active = 0"
        Dx_Order.SqlDataSource1.Connection.ConnectionString = rptConStr
        Dx_Order.XrLabel5.Text = "***ยกเลิกรายการ***"
        Dx_Order.PrinterName = Printer_name(0)("PrinterName")
        PrintToll.Print()

    End Sub
    Sub PrintCancleBill(id As Integer)
        If id = 0 Then Exit Sub
        Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where Active= 4 AND SaleId = " & id & " group by PrinterName")
        Dim Dx_Order As New CancelOrderTable
        Dim PrintToll As New ReportPrintTool(Dx_Order)
        Dim ctq As DevExpress.DataAccess.Sql.CustomSqlQuery
        ctq = Dx_Order.SqlDataSource1.Queries(0)
        ctq.Sql = "select SaleItem.SaleId,SaleItem.Qty,SaleItem.ItemName,SaleTable.SaleName,Users.FirstName,SaleItem.BillSplit_id,SaleItem.BillSplit_Name,SaleItem.Active
	                from (dbo.SaleItem SaleItem
	                    inner join dbo.SaleTable SaleTable
	                        on(SaleItem.SaleId = SaleTable.SaleId)
	                    inner join dbo.Users Users
                            on (Users.UserId = SaleItem.UserId))
                    WHERE SaleItem.SaleId = '" & id & "' AND SaleItem.Active = 4"

        Dx_Order.SqlDataSource1.Connection.ConnectionString = rptConStr
        'Dx_Order.XrLabel5.Text = "***ยกเลิกรายการ***"
        Dx_Order.PrinterName = Printer_name(0)("PrinterName")
        PrintToll.Print()
    End Sub
    Sub PrintCancleBill2(id As Integer)
        If id = 0 Then Exit Sub
        Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where Active= 5 AND SaleId = " & id & " group by PrinterName")
        Dim Dx_Order As New CancelOrderTable
        Dim PrintToll As New ReportPrintTool(Dx_Order)
        Dim ctq As DevExpress.DataAccess.Sql.CustomSqlQuery
        ctq = Dx_Order.SqlDataSource1.Queries(0)
        ctq.Sql = "select SaleItem.SaleId,SaleItem.Qty,SaleItem.ItemName,SaleTable.SaleName,Users.FirstName,SaleItem.BillSplit_id,SaleItem.BillSplit_Name,SaleItem.Active
	                from (dbo.SaleItem SaleItem
	                    inner join dbo.SaleTable SaleTable
	                        on(SaleItem.SaleId = SaleTable.SaleId)
	                    inner join dbo.Users Users
                            on (Users.UserId = SaleItem.UserId))
                    WHERE SaleItem.SaleId = '" & id & "' AND SaleItem.Active = 5"
        Dx_Order.SqlDataSource1.Connection.ConnectionString = rptConStr
        'Dx_Order.XrLabel5.Text = "***ยกเลิกรายการ***"
        Dx_Order.PrinterName = Printer_name(0)("PrinterName")
        PrintToll.Print()
    End Sub
    Sub PrinteOrder(id As Integer)
        Try
            Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where statusprint= 0 group by PrinterName")
            If Printer_name.Rows.Count = 0 Then Exit Sub
            For e As Integer = 0 To Printer_name.Rows.Count - 1
                Dim Datatable As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE StatusPrint=0")
                Dim Dx_Order As New Order
                Dim PrintToll As New ReportPrintTool(Dx_Order)
                Dx_Order.Parameter1.Value = id
                Dx_Order.XrLabel11.Text = ModulePayMent.NumQ
                Dx_Order.PrinterName = Printer_name(e)("PrinterName")
                Dx_Order.SqlDataSource1.Connection.ConnectionString = rptConStr
                PrintToll.Print()
                writeLog("User ID " + Frm_Login.UserId.ToString + " PrintOrder SaleId " + id.ToString)

                For i As Integer = 0 To Datatable.Rows.Count - 1
                    executesql("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & Datatable(i)("SaleItemId") & "'")
                Next
            Next

        Catch ex As Exception

        End Try
    End Sub

End Module
