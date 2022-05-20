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
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
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
        If FrmWithdrawMoney.WithdrawMoneyId = 0 Then
            executesql("INSERT INTO WithdrawMoney(TypeShift,TerminalName,InsertDate,WithdrawAmount,WithdrawName,UserId,Active) VALUES('" & DataOpenShift(0)("TypeShift") & "','" & Terminal & "','" & InsertDate & "','" & FrmWithdrawMoney.txtWithdrawAmount.Text & "','" & FrmWithdrawMoney.txtWithdrawName.Text & "','" & Frm_Login.UserId & "','1')")
        Else
            'executesql("UPDATE WithdrawMoney SET TypeShift='" & DataOpenShift(0)("TypeShift") & "',TerminalName='" & Terminal & "',UpdateDate='" & InsertDate & "',WithdrawAmount='" & FrmWithdrawMoney.txtWithdrawAmount.Text & "',WithdrawName='" & FrmWithdrawMoney.txtWithdrawName.Text & "',UserId='" & Frm_Login.UserId & "' WHERE WithdrawMoneyId='" & FrmWithdrawMoney.WithdrawMoneyId & "'")
        End If
        Dim Report As New withdrawmoney
        Dim Printool As New ReportPrintTool(Report)
        Dim GetPrinterName As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=1")
        Report.PrinterName = GetPrinterName(0)("SettingValue")
        Dim GetPrintOption As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=6")
        If GetPrintOption(0)("SettingValue") = 1 Then
            Printool.PrinterSettings.Copies = My.Settings.BillCopies
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
        clearData()
        loadData()
    End Sub
    Sub loadData()
        Dim DateNows As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim selectData As DataTable = executesql("SELECT * FROM WithdrawMoney WHERE Active='1' AND InsertDate LIKE '%" & DateNows & "%'")
        FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Clear()
        For i As Integer = 0 To selectData.Rows.Count - 1
            Dim dateInsert As String = Convert.ToDateTime(selectData(i)("InsertDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
            FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Add(dateInsert, selectData(i)("WithdrawName"), FormatNumber(selectData(i)("WithdrawAmount"), 2), selectData(i)("WithdrawMoneyId"))
        Next
    End Sub
    Sub showData()
        Dim selectData As DataTable = executesql("SELECT * FROM WithdrawMoney WHERE WithdrawMoneyId='" & FrmWithdrawMoney.WithdrawMoneyId & "'")
        FrmWithdrawMoney.txtWithdrawAmount.Text = FormatNumber(selectData(0)("WithdrawAmount"), 2)
        FrmWithdrawMoney.txtWithdrawName.Text = selectData(0)("WithdrawName")
    End Sub
    Sub search()
        Dim DateNows As String = Convert.ToDateTime(FrmWithdrawMoney.DateTimePickerSearchWithdraw.Value).ToString("yyyy-MM-dd", New System.Globalization.CultureInfo("th-TH"))
        Dim selectData As DataTable = executesql("SELECT * FROM WithdrawMoney WHERE Active='1' AND InsertDate LIKE '%" & DateNows & "%'")
        FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Clear()
        For i As Integer = 0 To selectData.Rows.Count - 1
            Dim dateInsert As String = Convert.ToDateTime(selectData(i)("InsertDate")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
            FrmWithdrawMoney.DataGridViewShowWithdraw.Rows.Add(dateInsert, selectData(i)("WithdrawName"), FormatNumber(selectData(i)("WithdrawAmount"), 2), selectData(i)("WithdrawMoneyId"))
        Next
    End Sub
    Sub clearData()
        FrmWithdrawMoney.txtWithdrawAmount.Clear()
        FrmWithdrawMoney.txtWithdrawName.Clear()
        FrmWithdrawMoney.WithdrawMoneyId = 0
    End Sub
End Module
