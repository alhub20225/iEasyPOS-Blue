Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Module ModuleWithdrawMoney

    Sub btnSave()
        If FrmWithdrawMoney.txtWithdrawAmount.Text = "" Then
            MsgBox("กรุณากรอกรายละเอียด", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        ElseIf Not IsNumeric(FrmWithdrawMoney.txtWithdrawAmount.Text) Then
            MsgBox("ใส่ตัวเลขเท่านั้น", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        If FrmWithdrawMoney.txtWithdrawName.Text = "" Then
            MsgBox("กรุณากรอกรายละเอียด", MsgBoxStyle.Critical, "คำเตือน")
            Exit Sub
        End If
        Dim Terminal As String = Environment.MachineName
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim DataOpenShift As Data.DataTable = executesql("SELECT ShiftId,TypeShift,DateTimeOpen,UserId,MoneyCash FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Terminal & "')")
        If IsNothing(DataOpenShift) Then
            Exit Sub
        ElseIf DataOpenShift.Rows.Count = 0 Then
            Exit Sub
        End If
        If DataOpenShift(0)("TypeShift") = "CLOSE" Then
            MsgBox("กรุณาทำการเปิดการขายก่อน", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        executesql("INSERT INTO WithdrawMoney(TypeShift,TerminalName,InsertDate,WithdrawAmount,WithdrawName,UserId,Active) VALUES('" & DataOpenShift(0)("TypeShift") & "','" & Terminal & "',CONVERT(datetime, '" & InsertDate & "', 126),'" & FrmWithdrawMoney.txtWithdrawAmount.Text & "','" & FrmWithdrawMoney.txtWithdrawName.Text & "','" & Frm_Login.UserId & "','1')")

        Dim selectData As DataTable = executesql("SELECT MAX(WithdrawMoneyId) AS WithdrawMoneyId FROM WithdrawMoney WHERE Active= 1")
        FrmWithdrawMoney.WithdrawMoneyId = selectData(0)("WithdrawMoneyId")
        Dim Report As New withdrawmoney
        Dim Printool As New ReportPrintTool(Report)
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        Dim GetPrintOption As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=6")
        If GetPrintOption(0)("SettingValue") = 1 Then
            Printool.Print()
        Else
            Exit Sub
        End If
        clearData()
        loadData()
    End Sub
    Sub btnDel()
        If FrmWithdrawMoney.WithdrawMoneyId = 0 Then
            MsgBox("กรุณาเลิอกรายการที่ต้องการลบ", MsgBoxStyle.Critical, "")
            Exit Sub
        Else
            executesql("UPDATE WithdrawMoney SET Active='0' WHERE WithdrawMoneyId='" & FrmWithdrawMoney.WithdrawMoneyId & "'")
        End If
        MsgBox("บันทึกข้อมูลเรียบ", MsgBoxStyle.Information, "")

        Dim Report As New withdrawmoney
        Dim Printool As New ReportPrintTool(Report)
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        Dim GetPrintOption As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=6")
        If GetPrintOption(0)("SettingValue") = 1 Then
            Printool.Print()
        Else
            Exit Sub
        End If

        clearData()
        loadData()
    End Sub
    Sub loadData()
        Dim DataOpenShift As Data.DataTable = executesql("SELECT DateTimeOpen FROM OpenCloseShift WHERE ShiftId=(SELECT MAX(ShiftId) FROM OpenCloseShift WHERE TerminalName='" & Environment.MachineName & "' AND TypeShift= 'OPEN')")
        Dim DateTimeOpen As String = Convert.ToDateTime(DataOpenShift(0)("DateTimeOpen")).ToString("yyyy-MM-ddTHH:mm:ss", New Globalization.CultureInfo("en-US"))
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-ddTHH:mm:ss", New System.Globalization.CultureInfo("en-US"))
        Dim selectData As DataTable = executesql("SELECT * FROM WithdrawMoney WHERE  InsertDate BETWEEN CONVERT(datetime, '" & DateTimeOpen & "', 126) AND CONVERT(datetime, '" & DateNows & "', 126)")
        FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Clear()
        For i As Integer = 0 To selectData.Rows.Count - 1
            Dim dateInsert As String = Convert.ToDateTime(selectData(i)("InsertDate")).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Add(dateInsert, selectData(i)("WithdrawName"), FormatNumber(selectData(i)("WithdrawAmount"), 2), selectData(i)("WithdrawMoneyId"))

            If selectData(i)("Active") = 0 Then
                FrmWithdrawMoney.DataGridViewShowWithdraw.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                FrmWithdrawMoney.DataGridViewShowWithdraw.Rows(i).Cells(1).Value = selectData(i)("WithdrawName") & " (ยกเลิก)"
            Else
                FrmWithdrawMoney.DataGridViewShowWithdraw.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
    Sub showData()
        Dim selectData As DataTable = executesql("SELECT * FROM WithdrawMoney WHERE WithdrawMoneyId='" & FrmWithdrawMoney.WithdrawMoneyId & "'")
        FrmWithdrawMoney.txtWithdrawAmount.Text = FormatNumber(selectData(0)("WithdrawAmount"), 2)
        FrmWithdrawMoney.txtWithdrawName.Text = selectData(0)("WithdrawName")
    End Sub
    Sub search()
        Dim DT1 As String = Convert.ToDateTime(FrmWithdrawMoney.DateTimePickerSearchWithdraw.EditValue).ToString("yyyy-MM-ddT00:00:00", New System.Globalization.CultureInfo("en-US"))
        Dim DT2 As String = Convert.ToDateTime(FrmWithdrawMoney.DateTimePickerSearchWithdraw.EditValue).ToString("yyyy-MM-ddT23:59:59", New System.Globalization.CultureInfo("en-US"))
        Dim selectData As DataTable = executesql("SELECT * FROM WithdrawMoney WHERE InsertDate BETWEEN CONVERT(datetime, '" & DT1 & "', 126) AND CONVERT(datetime, '" & DT2 & "', 126)")

        FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Clear()
        If selectData.Rows.Count = 0 Then Exit Sub
        For i As Integer = 0 To selectData.Rows.Count - 1
            Dim dateInsert As String = Convert.ToDateTime(selectData(i)("InsertDate")).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Add(dateInsert, selectData(i)("WithdrawName"), FormatNumber(selectData(i)("WithdrawAmount"), 2), selectData(i)("WithdrawMoneyId"))

            If selectData(i)("Active") = 0 Then
                FrmWithdrawMoney.DataGridViewShowWithdraw.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                FrmWithdrawMoney.DataGridViewShowWithdraw.Rows(i).Cells(1).Value = selectData(i)("WithdrawName") & " (ยกเลิก)"
            Else
                FrmWithdrawMoney.DataGridViewShowWithdraw.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
    Sub clearData()
        FrmWithdrawMoney.txtWithdrawAmount.Clear()
        FrmWithdrawMoney.txtWithdrawName.Clear()
        FrmWithdrawMoney.WithdrawMoneyId = 0
    End Sub
End Module
