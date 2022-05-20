Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Module ModulePrinrOrder
    Sub PrintOrderTable()
        GetSaleId = TB_GetSaleId
        Try
            Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where statusprint= 0 and SaleId='" & GetSaleId & "' group by PrinterName")
            For e As Integer = 0 To Printer_name.Rows.Count - 1
                Dim Datatable As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE StatusPrint=0 and SaleId='" & GetSaleId & "'")

                Dim Dx_Order As New OrderTable
                    Dim PrintToll As New ReportPrintTool(Dx_Order)
                Dx_Order.PrinterName = Printer_name(e)("PrinterName")
                Dx_Order.Parameter1.Value = TB_GetSaleId
                    PrintToll.Print()
                For i As Integer = 0 To Datatable.Rows.Count - 1
                    executesql("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & Datatable(i)("SaleItemId") & "'")
                Next
                Dim Datatable2 As DataTable = executesql("SELECT SaleItemId FROM SaleItemOrder WHERE StatusPrint=0")
                For i As Integer = 0 To Datatable.Rows.Count - 1
                    executesql("UPDATE SaleItemOrder SET StatusPrint=1 WHERE SaleItemId='" & Datatable(i)("SaleItemId") & "'")
                Next

            Next
            TB_GetSaleId = 0
            GetSaleId = 0
        Catch ex As Exception

        End Try

    End Sub
    Sub PrinteOrder()

        Try
            Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where statusprint= 0 group by PrinterName")
            For e As Integer = 0 To Printer_name.Rows.Count - 1
                Dim Datatable As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE StatusPrint=0")
                Dim Dx_Order As New Order
                Dim PrintToll As New ReportPrintTool(Dx_Order)
                Dx_Order.PrinterName = Printer_name(e)("PrinterName")

                PrintToll.Print()
                For i As Integer = 0 To Datatable.Rows.Count - 1
                    executesql("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & Datatable(i)("SaleItemId") & "'")
                Next
            Next
            GetSaleId = 0
        Catch ex As Exception

        End Try
    End Sub

End Module
