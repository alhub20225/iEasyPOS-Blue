Imports System.Threading
Imports DevExpress.XtraReports.UI
Public Class Form1
    Dim Dx_Order As New Order
    Private XThread As Thread
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim XThread = New Thread(AddressOf ProcessPrintOrder)
        XThread.IsBackground = True
        XThread.Start()
    End Sub
    Sub PrinteOrder()
        'MsgBox("PrinteOrder")
        Try

            Dim Printer_name As DataTable = executesql("select PrinterName from SaleItem where statusprint= 0 group by PrinterName")

            For e As Integer = 0 To Printer_name.Rows.Count - 1
                Dim Datatable As DataTable = executesql("SELECT SaleItemId,SaleId FROM SaleItem WHERE StatusPrint=0")


                Dim PrintToll As New ReportPrintTool(Dx_Order)
                Dx_Order.PrinterName = Printer_name(e)("PrinterName")
                Dx_Order.Parameter1.Value = Datatable(0)("SaleId")
                Dx_Order.LoadLayout("Order01.repx")
                PrintToll.Print()

                executesql("UPDATE SaleItem SET StatusPrint=1 WHERE SaleId='" & Datatable(0)("SaleId") & "'")

            Next

        Catch ex As Exception

        End Try
    End Sub

    Sub ProcessPrintOrder()
        While (True)
            PrinteOrder()
            Thread.Sleep(3000)
        End While
    End Sub

    Private Sub ToolStripMenuExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuExit.Click
        NotifyIcon1.Visible = False
        Me.Close()
    End Sub

    Private Sub ToolStripEditLayOut_Click(sender As Object, e As EventArgs) Handles ToolStripEditLayOut.Click
        Dx_Order.ShowDesigner
    End Sub

    Private Sub ToolStripLoadTemplate_Click(sender As Object, e As EventArgs) Handles ToolStripLoadTemplate.Click
        Dx_Order.LoadLayout("Order01.repx")
    End Sub
End Class
