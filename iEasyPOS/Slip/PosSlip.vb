Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class PosSlip
    Dim PayCash As Decimal = 0
    Dim PayCard As Decimal = 0
    Public rpSaleId As Integer = 0
    Private Sub PosSlip_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint
        Try
            Dim Dataset1 As New DataSet
            Dataset1.DataSetName = "DataSet1"
            'MsgBox(GetSaleId)
            Dim Datatable1 As DataTable = executesql("SELECT SaleId,SaleDate,SaleNo,Total,SubTotal,Amountdc,partnerTxnUid,CustomerId FROM Sale WHERE SaleId=" & rpSaleId & "")

            Dim Datatable2 As DataTable
            If Frm_Login.ComboLang.Text = "th-TH" Then
                Datatable2 = executesql("SELECT ItemCode,ItemName,UnitPrice,Qty,Total,SubTotal,InitPrice,Tax,PercentDC,BahtDC,AmtDC FROM SaleItem WHERE SaleId=" & rpSaleId & " AND SaleItem.Active=1")
            Else
                Datatable2 = executesql("SELECT SaleItem.ItemCode, SaleItem.UnitPrice, SaleItem.Qty, SaleItem.Total, SaleItem.SubTotal, SaleItem.InitPrice, SaleItem.Tax, SaleItem.PercentDC, SaleItem.BahtDC, SaleItem.AmtDC, Item.ItemName2 as ItemName FROM SaleItem INNER JOIN Item ON SaleItem.ItemId = Item.ItemId WHERE SaleItem.SaleId=" & rpSaleId & " AND SaleItem.Active=1")
            End If
            Dim Datatable3 As DataTable = executesql("SELECT PaymentDetail.SaleId,PaymentDetail.PaidAmount,PaymentType.PaymentName,PaymentType.PaymentId FROM PaymentDetail INNER JOIN PaymentType ON (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) WHERE PaymentDetail.SaleId=" & rpSaleId & "")
            Dim Datatable4 As DataTable = executesql("SELECT BranchCode,BranchName,CompanyName,Address,Address2,Provinces,ZipCode,TaxId,Telephone,Fax FROM Branch WHERE Active=1")


            Dim DT_PayCash As DataTable = executesql("SELECT PaidAmount FROM PaymentDetail INNER JOIN PaymentType ON (PaymentType.PaymentId = PaymentDetail.PaymentTypeId)WHERE PaymentDetail.SaleId=" & rpSaleId & " AND PaymentDetail.PaymentTypeId = 9")
            If DT_PayCash.Rows.Count = 0 Then
                Row_Change.Visible = False
            Else
                PayCash = DT_PayCash(0)("PaidAmount")

                txtChange.Text = FormatNumber((PayCash - (Datatable1(0)("SubTotal") - PayCard)), 2)
            End If
            Dim Dt As DataTable = executesql("SELECT PaymentType.PaymentName,PaymentType.PaymentId,Sale.TerminalName FROM PaymentDetail INNER JOIN PaymentType ON (PaymentType.PaymentId = PaymentDetail.PaymentTypeId) INNER JOIN Sale on (Sale.SaleId = PaymentDetail.SaleId) WHERE PaymentDetail.SaleId=" & rpSaleId & "")
            Dataset1.Tables.Add(Datatable1)
            Dataset1.Tables.Add(Datatable2)
            Dataset1.Tables.Add(Datatable3)
            Dataset1.Tables.Add(Datatable4)
            Datatable1.TableName = "Sale"
            Datatable2.TableName = "SaleItem"
            Datatable3.TableName = "PaymentDetail"
            Datatable4.TableName = "Branch"
            DataSource = Dataset1
            If XrTableCell12.Text = "" Then
                XrTableCell12.Visible = False
                XrTableCell11.WidthF = 658.36
                XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            End If
            XrLabel1.Text = Convert.ToDateTime(Datatable1(0)("SaleDate")).ToString("dd/MM/yyyy HH:mm:ss", New System.Globalization.CultureInfo("en-US"))
            XrLabel5.Text = ModulePayMent.NumQ
            Dim DataCustomer As DataTable = executesql("SELECT FirstName,LastName FROM Customer WHERE CustomerId = '" & Datatable1(0)("CustomerId") & "'")

            If DataCustomer.Rows.Count = 0 Then
                txtCustomerName.Text = "โต๊ะ : " & TableName
            Else
                txtCustomerName.Text = DataCustomer(0)("FirstName") + " " + DataCustomer(0)("LastName")
            End If

            If TableName = "" Then GroupHeader3.Visible = False

            If Datatable3(0)("PaymentId") = 15 Then 'Thaiqr
                XrLabel12.Text = Dt(0)("TerminalName")
            ElseIf Datatable3(0)("PaymentId") = 16 Then 'Ali
                XrLabel12.Text = My.Settings.AliTerminal_id   '"55101049"
            ElseIf Datatable3(0)("PaymentId") = 17 Then  'wechat
                XrLabel12.Text = My.Settings.WechatTerminal_id  '"55201491"
            Else
                GroupHeader2.Visible = False
            End If

            txtPayName.Text = "ชำระด้วย " & Datatable3(0)("PaymentName")
            txtPay.Text = FormatNumber(Datatable3(0)("PaidAmount"), 2)
        Catch ex As Exception

        End Try
    End Sub




    Private Sub Table_PercentDC_BeforePrint(sender As Object, e As PrintEventArgs) Handles Table_DC.BeforePrint

        If txtPercentDC.Text = 0 Then
            Row_PercentDC.Visible = False
        End If
        If txtBathDC.Text = 0 Then
            Row_BathDC.Visible = False
        End If
        Console.WriteLine(txtAmtDC.Text)
        'If txtAmtDC.Text = 0 Then
        '    Row_AmtDC.Visible = False
        'End If
        'If txtVat.Text = 0 Then
        '    Row_vat.Visible = False
        '    Row_init.Visible = False
        'End If
    End Sub

    Private Sub txtAmtDC_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtAmtDC.BeforePrint

        txtAmtDC.Text = FormatNumber(txtAmtDC.Text, 2)
    End Sub

    Private Sub txtBathDC_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtBathDC.BeforePrint
        txtBathDC.Text = FormatNumber(txtBathDC.Text, 2)
    End Sub

    'Private Sub txtChange_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtChange.BeforePrint
    '    txtChange.Text = txtPay.Text - txtSubtotal.Text
    'End Sub

    Private Sub txtFooter1_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtFooter1.BeforePrint

        Dim GetFooter As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=4")
        txtFooter1.Text = GetFooter(0)("SettingValue")
    End Sub

    Private Sub txtFooter2_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtFooter2.BeforePrint

        Dim GetFooter As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=5")
        txtFooter2.Text = GetFooter(0)("SettingValue")
    End Sub

    Private Sub txtHeader1_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtHeader1.BeforePrint

        Dim GetHeader1 As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=2")
        txtHeader1.Text = GetHeader1(0)("SettingValue")
    End Sub

    Private Sub txtHeader2_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtHeader2.BeforePrint

        Dim GetHeader2 As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=3")
        txtHeader2.Text = GetHeader2(0)("SettingValue")
    End Sub


    Private Sub txtPayName_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtPayName.BeforePrint

    End Sub

    Private Sub txtPercentDC_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtPercentDC.BeforePrint
        txtPercentDC.Text = FormatNumber(txtPercentDC.Text, 2)
    End Sub

    Private Sub txtSubtotal_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtSubtotal.BeforePrint
        txtSubtotal.Text = FormatNumber(txtSubtotal.Text, 2)
    End Sub

    Private Sub XrLabel13_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtTotal.BeforePrint
        txtTotal.Text = FormatNumber(txtTotal.Text, 2)
    End Sub

    Private Sub xrHeader_BeforePrint(sender As Object, e As PrintEventArgs) Handles xrHeader.BeforePrint
        If XrTableCell7.Text = "" Then
            XrTableRow2.Visible = False
        End If
        If XrTableCell8.Text = "" Then
            XrTableRow3.Visible = False
        End If
        If XrTableCell10.Text = "" Then
            XrTableRow4.Visible = False
        End If

        If XrTableCell11.Text = "" Then
            XrTableRow5.Visible = False
        End If

        If XrTableCell13.Text = "" Then
            XrTableRow6.Visible = False
        End If
        Dim GetHeader1 As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=2")
        If GetHeader1(0)("SettingValue") = "" Then
            XrTableRow7.Visible = False
        End If

        Dim GetHeader2 As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=3")
        If GetHeader2(0)("SettingValue") = "" Then
            XrTableRow10.Visible = False
        End If

        Dim GetFooter1 As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=4")
        If GetFooter1(0)("SettingValue") = "" Then
            XrTableRow8.Visible = False
        End If

        Dim GetFooter2 As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=5")
        If GetFooter2(0)("SettingValue") = "" Then
            XrTableRow9.Visible = False
        End If

        Dim BranchShow As DataTable = executesql("SELECT SettingValue FROM Setting WHERE SettingId=7")
        If BranchShow(0)("SettingValue") = 0 Then
            XrTableRow2.Visible = False
            XrTableRow3.Visible = False
            XrTableRow4.Visible = False
            XrTableRow5.Visible = False
            XrTableRow6.Visible = False
        End If
    End Sub

    Private Sub txt_qty_BeforePrint(sender As Object, e As PrintEventArgs) Handles txt_qty.BeforePrint
        txt_qty.Text = FormatNumber(txt_qty.Text, 0)
    End Sub

    Private Sub txtItem_PriceTotal_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtItem_PriceTotal.BeforePrint
        txtItem_PriceTotal.Text = FormatNumber(txtItem_PriceTotal.Text, 2)
    End Sub

    Private Sub XrLabel9_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel9.BeforePrint
        Dim sts As DataTable = executesql("SELECT Active FROM Sale WHERE SaleId=" & rpSaleId & "")
        If sts(0)("Active") = 2 Then
            XrLabel9.Text = "ยกเลิกการขาย"
            XrLabel4.Text = ""
            XrLabel5.Text = ""
        End If
    End Sub

    Private Sub txtInnit_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtInnit.BeforePrint
        Dim selectTaxData As DataTable = executesql("SELECT sum(SubTotal - Tax) As Tax From SaleItem WHERE SaleId=" & rpSaleId & "")
        txtInnit.Text = FormatNumber(selectTaxData(0)("Tax"), 2)
    End Sub

    Private Sub labelBranch_BeforePrint(sender As Object, e As PrintEventArgs) Handles labelBranch.BeforePrint
        If isDemo = True Then labelBranch.Text = "**** Demo test Not for sale ****"
    End Sub



    'Private Sub txtVat_BeforePrint(sender As Object, e As PrintEventArgs) Handles txtVat.BeforePrint
    '    txtVat.Text = FormatNumber(txtVat.Text, 2)
    'End Sub

End Class