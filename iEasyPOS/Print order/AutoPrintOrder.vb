Imports System.Threading
Imports DevExpress.XtraReports.UI

Module AutoPrintOrder
    Sub Start()
        Dim nThread = New Thread(AddressOf RunPrintOrder)
        nThread.IsBackground = True
        nThread.Start()
    End Sub
    Sub PrinteOrder()

        Try
            Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where statusprint= 0 group by PrinterName")
            For e As Integer = 0 To Printer_name.Rows.Count - 1
                Dim Datatable As DataTable = executesql("SELECT SaleItemId FROM SaleItem WHERE StatusPrint=0")
                Dim Dx_Order As New Order
                Dim PrintToll As New ReportPrintTool(Dx_Order)
                Dx_Order.PrinterName = Printer_name(e)("PrinterName")
                Dx_Order.SqlDataSource1.Connection.ConnectionString = rptConStr
                PrintToll.Print()
                For i As Integer = 0 To Datatable.Rows.Count - 1
                    executesql("UPDATE SaleItem SET StatusPrint=1 WHERE SaleItemId='" & Datatable(i)("SaleItemId") & "'")
                Next
                TB_GetSaleId = 0
                GetSaleId = 0
            Next
            MsgBox(GetSaleId)
        Catch ex As Exception

        End Try
    End Sub

    Sub RunPrintOrder()
        While (True)
            PrinteOrder()
            Thread.Sleep(6000)
        End While
    End Sub
End Module
