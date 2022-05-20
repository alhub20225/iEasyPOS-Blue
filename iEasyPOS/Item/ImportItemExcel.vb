Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class ImportItemExcel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dadapter As New SqlDataAdapter
        Dim dtable As New DataTable
        Dim mycmd As New SqlCommand
        Dim conn As OleDbConnection
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet
        Dim excel As String
        Dim OpenFileDialog As New OpenFileDialog
        Try
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx)|*.xlsx|Xls Files (*.xls)|*.xls"
            If OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
                Dim FileName As String = OpenFileDialog.FileName
                excel = fi.FullName
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                dta = New OleDbDataAdapter("select * from [Sheet1$]", conn)
                dts = New DataSet
                'DGV1.Columns.Item(0).ValueType = GetType(System.String)
                dta.Fill(dts, "[Sheet1$]")
                DGV1.DataSource = dts
                DGV1.DataMember = "[Sheet1$]"
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim checkCateIsNotError = Check_Cate()
        Dim checkUnitIsNotError = Check_unit()
        Dim checkTaxIsNotError = Check_tax()
        If checkCateIsNotError = True And checkCateIsNotError = True And checkCateIsNotError = True Then
            Dim InsertDate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            Dim UserId As Integer = Frm_Login.UserId
            Dim BtnBackGround As Integer = -4473925
            Dim ForeColor As Integer = -1
            For i As Integer = 0 To DGV1.Rows.Count - 2 Step +1

                Console.WriteLine(i)
                If Not IsDBNull(DGV1.Rows(i).Cells(0).Value) Then
                    If Not IsNothing(DGV1.Rows(i).Cells(0).Value) Then

                        Dim ItemCode As String = DGV1.Rows(i).Cells(0).Value
                        Dim checkItemCode As DataTable = executesql("select * from item where ItemCode='" & ItemCode & "' and active=1")
                        If checkItemCode.Rows.Count > 0 Then
                            MsgBox("รหัสสินค้า " & ItemCode & " ซ้ำ!!", MsgBoxStyle.Critical)
                        Else
                            Dim ItemName1 As String = DGV1.Rows(i).Cells(1).Value
                            Dim ItemName2 As String = DGV1.Rows(i).Cells(2).Value
                            Dim Price As Decimal = DGV1.Rows(i).Cells(3).Value
                            Dim CheckCate As DataTable = executesql("SELECT CategoryID,CatePrinterName FROM CategoryItem WHERE CategoryName='" & DGV1.Rows(i).Cells(4).Value.ToString & "'")
                            Dim DataUnitId As DataTable = executesql("SELECT ItemUnitID FROM ItemUnit WHERE ItemUnitName='" & DGV1.Rows(i).Cells(6).Value.ToString & "' AND Active=1 AND Multiply=1")
                            Dim Stock As Integer = DGV1.Rows(i).Cells(7).Value
                            Dim Point As Integer = DGV1.Rows(i).Cells(8).Value
                            Dim Promotion As Integer = DGV1.Rows(i).Cells(9).Value
                            Dim PrinterName As String = CheckCate(0)("CatePrinterName")
                            Dim DisCount As Integer = DGV1.Rows(i).Cells(10).Value
                            Dim IsVat As Integer = DGV1.Rows(i).Cells(11).Value
                            Dim getTax As DataTable = executesql("SELECT TaxID FROM Tax WHERE TaxName='" & DGV1.Rows(i).Cells(12).Value.ToString & "' AND Active=1")
                            Dim TaxID As String = getTax(0)("TaxID")
                            Dim ActiveStatusItem As Integer = DGV1.Rows(i).Cells(13).Value.ToString
                            Dim IsKiosk As Integer = DGV1.Rows(i).Cells(14).Value.ToString
                            executesql("INSERT INTO Item(ItemCode,ItemName,ItemName2,ItemPrice,CategoryId,Active,InsertDate,UserId,USUnitId,POUnitId,POUnitId2,IsTrackStock,AllowRedeemPoint,IsPromotion,PrinterName,AllowDC,IsVatChecked,TaxId,ButtonColor,FontColor,IsActive,ItemKiOsk) VALUES('" & ItemCode & "','" & ItemName1 & "','" & ItemName2 & "','" & Price & "','" & CheckCate(0)("CategoryId") & "',1,'" & InsertDate & "','" & UserId & "','" & DataUnitId(0)("ItemUnitId") & "','" & DataUnitId(0)("ItemUnitId") & "','" & DataUnitId(0)("ItemUnitId") & "','" & Stock & "','" & Point & "','" & Promotion & "','" & PrinterName & "','" & DisCount & "','" & IsVat & "','" & TaxID & "','" & BtnBackGround & "','" & ForeColor & "','" & ActiveStatusItem & "','" & IsKiosk & "')")
                        End If

                    Else
                        'Exit For
                    End If

                    'InsertBranchItem(Price)
                Else
                    'Exit For
                End If
            Next

            ModuleItems.LoadDataItem()
            MsgBox("นำเข้าสินค้าแล้ว", MsgBoxStyle.Information, "นำเข้าสินค้า")
            Me.Close()
        End If
    End Sub
    Function Check_Cate()
        For i As Integer = 0 To DGV1.Rows.Count - 2 Step +1
            If Not IsDBNull(DGV1.Rows(i).Cells(4).Value) Then
                If Not IsNothing(DGV1.Rows(i).Cells(4).Value) Then
                    Dim CheckCate As DataTable = executesql("SELECT CategoryID FROM CategoryItem WHERE CategoryName='" & Trim(DGV1.Rows(i).Cells(4).Value) & "' AND Active=1")
                    If CheckCate.Rows.Count = 0 Then
                        MsgBox("ไม่พบหมวดสินค้า  (พิมพ์ ให้ถูกทุกตัวอักษร)" + DGV1.Rows(i).ToString, MsgBoxStyle.Critical, "")
                        Return False
                        Exit Function
                        Me.Close()
                    End If
                End If
            Else
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Function Check_unit()
        For i As Integer = 0 To DGV1.Rows.Count - 2 Step +1
            If Not IsDBNull(DGV1.Rows(i).Cells(6).Value) Then
                If Not IsNothing(DGV1.Rows(i).Cells(6).Value) Then
                    Dim CheckUnit As DataTable = executesql("SELECT ItemUnitID FROM ItemUnit WHERE ItemUnitName='" & DGV1.Rows(i).Cells(6).Value & "' AND Active=1 AND Multiply=1")
                    If CheckUnit.Rows.Count = 0 Then
                        MsgBox("ไม่พบหน่วยสินค้า (ใส่เป็นตัวอักษร ชื่อหน่วย)", MsgBoxStyle.Critical, "")
                        Return False
                        Exit Function
                        Me.Close()
                    End If
                End If
            Else
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Function Check_tax()
        For i As Integer = 0 To DGV1.Rows.Count - 2 Step +1
            If Not IsDBNull(DGV1.Rows(i).Cells(12).Value) Then
                If Not IsNothing(DGV1.Rows(i).Cells(12).Value) Then
                    Dim CheckTax As DataTable = executesql("SELECT TaxID FROM Tax WHERE TaxName='" & DGV1.Rows(i).Cells(12).Value & "' AND Active=1")
                    If CheckTax.Rows.Count = 0 Then
                        MsgBox("ไม่พบหน่วยภาษีสินค้า (ใส่เป็นตัวเลข)", MsgBoxStyle.Critical, "")
                        Return False
                        Exit Function
                        Me.Close()
                    End If
                End If

            Else
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
End Class