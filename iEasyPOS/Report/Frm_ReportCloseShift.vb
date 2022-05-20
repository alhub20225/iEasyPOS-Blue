Imports DevExpress.XtraReports.UI
Public Class Frm_ReportCloseShift
    Dim DateStart As String = ""
    Dim DateEnd As String = ""
    Private Sub Frm_ReportCloseShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP1.EditValue = Now
    End Sub

    Private Sub DTP1_DateTimeChanged(sender As Object, e As EventArgs) Handles DTP1.DateTimeChanged
        DateStart = Convert.ToDateTime(DTP1.DateTime).ToString("yyyy-MM-dd 00:00:00", New System.Globalization.CultureInfo("th-TH"))
        DateEnd = Convert.ToDateTime(DTP1.DateTime).ToString("yyyy-MM-dd 23:59:59", New System.Globalization.CultureInfo("th-TH"))
        Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID  from OpenCloseShift where DateTimeOpen Between '" & DateStart & "' and '" & DateEnd & "' AND TypeShift='CLOSE'")
        ComboBox1.DataSource = Nothing

        If CheckShiftNum.Rows.Count > 0 Then
            ComboBox1.DataSource = CheckShiftNum
            ComboBox1.DisplayMember = "shiftNumber"

            BtnShow.Enabled = True

        Else
            BtnShow.Enabled = False
        End If
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim TerminalName As String = Environment.MachineName

        Dim CheckShiftNum As DataTable = executesql("SELECT ROW_NUMBER() OVER(ORDER BY shiftid ASC) AS shiftNumber,ShiftId from OpenCloseShift where DateTimeOpen Between '" & DateStart & "' and '" & DateEnd & "' AND TypeShift='CLOSE'")
        Dim result() As DataRow = CheckShiftNum.Select("shiftNumber='" & ComboBox1.Text & "'")
        Dim ShiftId As Integer = result(0)("ShiftId")
        Console.WriteLine("ShiftId " & ShiftId.ToString)

        Dim CheckDataRows As DataTable = executesql("SELECT ShiftId,MoneyCash,UserId,TypeShift,DateTimeOpen,StatusShift,TerminalName,DateTimeClose,CloseUserID FROM OpenCloseShift WHERE ShiftId = " & ShiftId & " AND TypeShift='CLOSE'")

        If CheckDataRows.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical, "")
            Exit Sub
        Else
            Dim DT1 As String = Convert.ToDateTime(CheckDataRows(0)("DateTimeOpen")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
            Dim DT2 As String = Convert.ToDateTime(CheckDataRows(0)("DateTimeClose")).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-US"))

            Dim report_CloseShift As New ResendReportCloseShift
            report_CloseShift.Parameter1.Value = TerminalName
            report_CloseShift.Parameter2.Value = DT1
            report_CloseShift.Parameter3.Value = DT2
            report_CloseShift.DateTimeOpenShift = DT1
            report_CloseShift.DateTimeCloseShift = DT2
            report_CloseShift.shiftId = ShiftId
            report_CloseShift.SqlDataSource1.Connection.ConnectionString = rptConStr
            report_CloseShift.CreateDocument()
            DocumentViewer1.DocumentSource = report_CloseShift
        End If
    End Sub
End Class