Imports System.IO.Ports
Public Class Pos_Payment_EDC
    Private tool As New Tool()
    Private Com As New SerialPort()
    Private szOutput As String = ""
    Private szInput As String = ""
    Private T1 As String = ""
    Private T2 As String = ""
    Private T3 As String = ""
    Private T4 As String = ""
    Private T5 As String = ""
    Private T6 As String = ""
    Private T7 As String = ""
    Private T8 As String = ""
    Private T9 As String = ""
    Private T10 As String = ""
    Private T11 As String = ""
    Private T12 As String = ""
    Private T13 As String = ""
    Private T14 As String = ""
    Private T15 As String = ""
    Private checkPort As Boolean = False
    Private EdcType As Integer = 0

    Private Sub Pos_Payment_EDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BckColor As System.Drawing.Color
        If My.Settings.PosType = 1 Then
            BckColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(239, Byte), Integer))
        ElseIf My.Settings.PosType = 0 Then
            BckColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        End If
        Top_tap.BackColor = BckColor
        Label3.BackColor = BckColor
        Label1.BackColor = BckColor

        Dim bySendBuf() As Byte = {&H36, &H30, &H30, &HA1, &HA2, &HA3, &HB0, &HD0, &H30, &H30, &H31, &H30, &H32, &H30, &H30, &H30, &H30, &H1C}
        Dim str As String = tool.ByteToStr(bySendBuf)

        Dim ss As String = String.Format("{0,6}", "22")
        Timer1.Start()

        Dim totalPrice As Integer = POS.txtSubTotal.Text * 100
        textBoxAmount.Text = totalPrice
        txtShowTotal.Text = POS.txtSubTotal.Text
        textBoxCom.Text = My.Settings.Comport
        If OpenPort() = False Then
            Exit Sub
        End If
        'bn1()
    End Sub
    Private Function OpenPort() As Boolean

        Try
            If Com.IsOpen Then
                Return False
            End If

            Com = New SerialPort("COM" & textBoxCom.Text, 9600, Parity.None, 8, StopBits.One)

            Com.BaudRate = 9600
            Com.Parity = Parity.None
            Com.StopBits = StopBits.One

            AddHandler Com.DataReceived, AddressOf port_DataReceived
            Com.ReadBufferSize = 5000
            Com.WriteBufferSize = 5000
            Com.ReadTimeout = 2000
            Com.WriteTimeout = 2000
            Com.Open()

            Timer2.Enabled = True
            ' LabelCom.Text = "PORT OPEN";
            Return True
        Catch
            '  LabelCom.Text = "PORT CLOSE";
            MessageBox.Show("OpenPort,!Port not open")
            writeLog("User ID " + Frm_Login.UserId.ToString + " OpenPort,!Port not open")
            Me.Close()
            Return False
        End Try
    End Function
    Private Sub OpenComm()
        checkPort = False
        Try
            If Com.IsOpen Then
                Return
            End If

            Com = New SerialPort("COM" & textBoxCom.Text, 9600, Parity.None, 8, StopBits.One)

            Com.BaudRate = 9600
            Com.Parity = Parity.None
            Com.StopBits = StopBits.One

            AddHandler Com.DataReceived, AddressOf port_DataReceived
            Com.ReadBufferSize = 5000
            Com.WriteBufferSize = 5000
            Com.ReadTimeout = 2000
            Com.WriteTimeout = 2000
            Com.Open()

            Timer2.Enabled = True
            'LabelCom.Text = "PORT OPEN";

            checkPort = False
        Catch

            'Pos_payment.Close()
            Me.Close()

            MessageBox.Show("OpenComm,!Port not open")
            writeLog("User ID " + Frm_Login.UserId.ToString + " OpenPort,!Port not open")
            checkPort = True

        End Try
    End Sub
    Private Sub port_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        'MsgBox("port_DataReceived")
        Dim byRead(4999) As Byte
        Dim byData() As Byte
        Dim inReadLen, inBytesToRead, inBytesToReadOld As Integer

        inReadLen = 0
        Do
            'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
            'ORIGINAL LINE: inBytesToRead = inBytesToReadOld = 0;
            inBytesToReadOld = 0
            inBytesToRead = inBytesToReadOld
            Do
                System.Threading.Thread.Sleep(200)
                inBytesToRead = Com.BytesToRead
                If inBytesToReadOld = inBytesToRead Then
                    Exit Do
                End If
                inBytesToReadOld = inBytesToRead
            Loop While True

            inReadLen = Com.Read(byRead, 0, inBytesToRead)

            If inReadLen > 0 Then
                ' check ACK, NAK
                If byRead(0) = CByte(&H15) Then
                    szOutput = "NAK"

                    Return
                End If
                If byRead(0) = CByte(&H6) Then
                    szOutput = "ACK"

                    Return
                End If

                byData = tool.UnpackSerial(byRead, inReadLen)
                If byData.Length > 0 Then
                    Exit Do
                Else
                    szOutput = tool.szErrorString

                End If

            Else
                'Com.Close();
                Return
            End If
        Loop
        ' EDC return POS data
        If byData(0) = CByte(&H36) Then
            If byData(14) <> AscW("0"c) OrElse byData(15) <> AscW("0"c) Then
                ' error
                Dim byBuf(1) As Byte
                Buffer.BlockCopy(byData, 14, byBuf, 0, 2)
                Dim szRes As String = tool.ByteToStr(byBuf)
                szOutput &= "->EDC Pos not applove, Error Code : " & szRes

                Com.Close()
                Return
            End If
            'LabelCom.Text = "PORT CLOSE";
            Com.Close()

            szOutput = tool.HexToAscii(byData)
            szOutput &= vbCrLf & vbCrLf
            T1 &= vbCrLf & vbCrLf
            'T2 &= vbCrLf & vbCrLf
            T3 &= vbCrLf & vbCrLf
            T4 &= vbCrLf & vbCrLf
            T5 &= vbCrLf & vbCrLf
            T6 &= vbCrLf & vbCrLf
            T7 &= vbCrLf & vbCrLf
            T8 &= vbCrLf & vbCrLf
            T9 &= vbCrLf & vbCrLf
            T10 &= vbCrLf & vbCrLf
            T11 &= vbCrLf & vbCrLf
            T12 &= vbCrLf & vbCrLf
            T13 &= vbCrLf & vbCrLf
            T14 &= vbCrLf & vbCrLf
            T15 &= vbCrLf & vbCrLf

            ' cut header
            Dim byFieldData(byData.Length - 19) As Byte
            Buffer.BlockCopy(byData, 18, byFieldData, 0, byData.Length - 18)

            Dim inFieldNo As Integer = 1
            Dim szDataOfField As String = ""
            Do
                szDataOfField = inGetDataByNo(byFieldData, inFieldNo)
                If szDataOfField <> "" Then

                    szOutput &= vbCrLf & szDataOfField
                    T1 &= vbCrLf & szDataOfField
                    'T2 &= vbCrLf & szDataOfField
                    T3 &= vbCrLf & szDataOfField
                    T4 &= vbCrLf & szDataOfField
                    T5 &= vbCrLf & szDataOfField
                    T6 &= vbCrLf & szDataOfField
                    T7 &= vbCrLf & szDataOfField
                    T8 &= vbCrLf & szDataOfField
                    T9 &= vbCrLf & szDataOfField
                    T10 &= vbCrLf & szDataOfField
                    T11 &= vbCrLf & szDataOfField
                    T12 &= vbCrLf & szDataOfField
                    T13 &= vbCrLf & szDataOfField
                    T14 &= vbCrLf & szDataOfField
                    T15 &= vbCrLf & szDataOfField

                Else
                    Exit Do
                End If
                inFieldNo += 1
            Loop

            Dim a As String = T1
            Dim strr() As String = a.Split(" ")
            T1 = strr(3)
            Dim strr13() As String = a.Split("=")
            T3 = Mid(strr13(3).Split(" ")(1), 1, 6)
            T4 = Mid(strr13(4).Split(" ")(1), 1, 6)
            T5 = Mid(strr13(5).Split(" ")(1), 1, 6)
            T6 = Mid(strr13(6).Split(" ")(1), 1, 6)
            T7 = Mid(strr13(7).Split(" ")(1), 1, 8)
            T8 = Mid(strr13(8).Split(" ")(1), 1, 15)
            T9 = strr13(9).Split(" ")(1) & " " & Replace(strr13(9).Split(" ")(2), "30", "")
            T10 = Mid(strr13(10).Split(" ")(1), 1, 16)
            T11 = Mid(strr13(11).Split(" ")(1), 1, 4)
            T12 = Mid(strr13(12).Split(" ")(1), 1, 6)
            T13 = Mid(strr13(13).Split(" ")(1), 1, 12)
            T14 = Mid(strr13(14).Split(" ")(1), 1, 2)
            T15 = strr13(15).Split(" ")(1) & " " & strr13(15).Split(" ")(2)

        End If
    End Sub

    Public Function inGetData(ByVal byData() As Byte, ByVal szID As String) As String
        'MsgBox("inGetData")
        Dim i As Integer = 0
        Dim byLen(1) As Byte
        Dim byId() As Byte
        'string szlen;
        Dim inLen As Integer
        Dim inDataLen As Integer = byData.Length
        'INSTANT VB NOTE: The variable tool was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
        Dim tool_Renamed As New Tool()

        Try
            Do
                ' end data
                If i >= inDataLen Then
                    Exit Do
                End If
                If byData(i) = CByte(&H3) Then
                    Exit Do
                End If

                byLen(0) = byData(i + 2)
                byLen(1) = byData(i + 3)
                Dim szLen As String = tool_Renamed.HexToAscii(byLen)
                inLen = System.Convert.ToInt16(szLen)

                If inLen + i > inDataLen Then
                    Exit Do
                End If

                ' check ID == My ID
                byId = tool_Renamed.StrToByte(szID)
                If byData(i + 0) = byId(0) AndAlso byData(i + 1) = byId(1) Then
                    Dim byBuf(inLen - 1) As Byte
                    Buffer.BlockCopy(byData, i + 4, byBuf, 0, inLen)
                    Dim szData As String = tool_Renamed.ByteToStr(byBuf)

                    Return szData
                End If

                i += inLen + 5
            Loop
        Catch
            Return ""
        End Try

        Return ""
    End Function
    ' struct = II + NN + data + 0x1C
    Public Function inGetDataByNo(ByVal byData() As Byte, ByVal inFieldNo As Integer) As String
        'MsgBox("inGetDataByNo")
        Dim i As Integer = 0
        Dim byLen(1) As Byte
        Dim byId(1) As Byte
        'string szlen;
        Dim inLen As Integer
        Dim inDataLen As Integer = byData.Length
        Dim inFiledCount As Integer = 1
        'INSTANT VB NOTE: The variable tool was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
        Dim tool_Renamed As New Tool()

        Try
            Do
                ' end data
                If i >= inDataLen Then
                    Exit Do
                End If
                If byData(i) = CByte(&H3) Then
                    Exit Do
                End If

                byLen(0) = byData(i + 2)
                byLen(1) = byData(i + 3)
                Dim szLen As String = tool_Renamed.HexToAscii(byLen)
                inLen = System.Convert.ToInt16(szLen)

                If inLen + i > inDataLen Then
                    Exit Do
                End If

                byId(0) = byData(i + 0)
                byId(1) = byData(i + 1)
                Dim szId As String = tool_Renamed.ByteToStr(byId)
                If inFiledCount = inFieldNo Then
                    Dim byBuf(inLen - 1) As Byte
                    Buffer.BlockCopy(byData, i + 4, byBuf, 0, inLen)
                    Dim szData As String = tool_Renamed.ByteToStr(byBuf)

                    Return "" & szId & " [" & inLen & "] = " & szData
                End If

                i += inLen + 5
                inFiledCount += 1
            Loop
        Catch
            Return ""
        End Try

        Return ""
    End Function
    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        textBoxOutput.Text = szOutput

        textBoxInput.Text = szInput

        TextBox1.Text = T1

        TextBox2.Text = T2

        TextBox3.Text = T3

        TextBox4.Text = T4

        TextBox5.Text = T5

        TextBox6.Text = T6

        TextBox7.Text = T7

        TextBox8.Text = T8

        TextBox9.Text = T9

        TextBox10.Text = T10

        TextBox11.Text = T11

        TextBox12.Text = T12

        TextBox13.Text = T13

        TextBox14.Text = T14

        TextBox15.Text = T15

    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Panel2.Visible = False
        Panel1.Visible = True
        'Dim bySend() As Byte ' = new byte[100];

        'OpenComm()
        'bySend = tool.PackECRSale(textBoxAmount.Text, textBoxMerchant.Text)

        'szInput = tool.HexToAscii(bySend) ' display out data

        'Com.Write(bySend, 0, bySend.Length)

        'szOutput = "SEND"

        'EdcType = 0
        writeLog("User ID " + Frm_Login.UserId.ToString + " Pay Debit/Credir card click")

        bn1()

    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        writeLog("User ID " + Frm_Login.UserId.ToString + " Pay Alipay click")
        Label2.Text = "แสกน QR CODE"
        Panel2.Visible = False
        Panel1.Visible = True


        OpenComm()
        Dim bySendBuf() As Byte = tool.PackECRHeader("70")
        bySendBuf = tool.PackTLV(bySendBuf, "40", 12, String.Format("{0,12}", textBoxAmount.Text))
        bySendBuf = tool.PackTLV(bySendBuf, "A1", 2, tbAlipayA1.Text)

        Dim bySend() As Byte = tool.PackSerial(bySendBuf, bySendBuf.Length)

        szInput = tool.HexToAscii(bySendBuf) ' display out data

        Com.Write(bySend, 0, bySend.Length)
        szOutput = "SEND"

        EdcType = 1
    End Sub
    Sub bn1()
        Dim bySend() As Byte ' = new byte[100];

        OpenComm()
        'If checkPort = True Then
        '    ModuleKiosk.Page = 0
        '    ModuleKiosk.backHome()
        '    Exit Sub
        'End If
        bySend = tool.PackECRSale(textBoxAmount.Text, textBoxMerchant.Text)

        szInput = tool.HexToAscii(bySend) ' display out data
        Com.Write(bySend, 0, bySend.Length)

        szOutput = "SEND"

        EdcType = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        writeLog("PosPaymentEDC Text1 : " + TextBox1.Text)
        If TextBox1.Text = "APPROVAL" Then
            writeLog("User ID " + Frm_Login.UserId.ToString + " EDC APPROVAL")
            'ModuleEDCPayment.EDCPayment()
            'EDC_Payment()
            Dim TIDs As String = T7
            Dim MIDs As String = T8
            Dim VisaType As String = T9
            Dim Batch As String = T12
            Dim CradId As String = T10
            Dim APPRCode As String = T5
            Dim RefNo As String = T13
            Dim CradName As String = T15
            Dim Trace As String = T6
            writeLog("APPROVAL:" + T7 + "," + T8 + "," + T9 + "," + T12 + "," + T5 + "," + T13 + "," + T15 + "," + T6)

            If EdcType = 0 Then
                Pos_payment.totalPay += txtShowTotal.Text
                Pos_payment.AmountPaid = txtShowTotal.Text
                Pos_payment.txtPayTotal.Text = FormatNumber(Pos_payment.totalPay, 2)
                Pos_payment.PaymentType = "บัตรเครดิต"

                EDCAddSale(11, txtShowTotal.Text)

                'AddPaymentToDGCreditCard()
                'ModulePayMent.BtnAddSale()

                POS.DiscountByItem2 = 0
                Pos_payment.totalPay = 0
                Pos_payment.AmountPaid = 0
                POS.TextBox3.Focus()

                Dim GetSaleNo As DataTable = executesql("SELECT SaleNo,SaleId FROM Sale WHERE SaleId = (SELECT MAX(SaleId) FROM Sale)")

                executesql("INSERT INTO CardDetail(SaleId,TIDs,MIds,VisaType,Batch,CradId,APPRCode,RefNo,CardName,Trace,SaleNo) VALUES('" & GetSaleNo(0)("SaleId") & "','" & TIDs & "','" & MIDs & "','" & VisaType & "','" & Batch & "','" & CradId & "','" & APPRCode & "','" & RefNo & "','" & CradName & "','" & Trace & "','" & GetSaleNo(0)("SaleNo") & "')")
                Me.Close()

            ElseIf EdcType = 1 Then
                Pos_payment.totalPay += txtShowTotal.Text
                Pos_payment.AmountPaid = txtShowTotal.Text
                Pos_payment.txtPayTotal.Text = FormatNumber(Pos_payment.totalPay, 2)
                Pos_payment.PaymentType = "QR Alipay"
                Pos_payment.DataGridViewSale.Rows.Add("QR Alipay", FormatNumber(Pos_payment.AmountPaid, 2))

                EDCAddSale(16, txtShowTotal.Text)
                'ModulePayMent.BtnAddSale()

                POS.DiscountByItem2 = 0
                Pos_payment.totalPay = 0
                Pos_payment.AmountPaid = 0
                POS.TextBox3.Focus()

                Dim GetSaleNo As DataTable = executesql("SELECT SaleNo,SaleId FROM Sale WHERE SaleId = (SELECT MAX(SaleId) FROM Sale)")

                executesql("INSERT INTO CardDetail(SaleId,TIDs,MIds,VisaType,Batch,CradId,APPRCode,RefNo,CardName,Trace,SaleNo) VALUES('" & GetSaleNo(0)("SaleId") & "','" & TIDs & "','" & MIDs & "','" & VisaType & "','" & Batch & "','" & CradId & "','" & APPRCode & "','" & RefNo & "','" & CradName & "','" & Trace & "','" & GetSaleNo(0)("SaleNo") & "')")

                Me.Close()

            ElseIf EdcType = 2 Then

                Pos_payment.totalPay += txtShowTotal.Text
                Pos_payment.AmountPaid = txtShowTotal.Text
                Pos_payment.txtPayTotal.Text = FormatNumber(Pos_payment.totalPay, 2)
                Pos_payment.PaymentType = "QR Thai"
                Pos_payment.DataGridViewSale.Rows.Add("QR Thai", FormatNumber(Pos_payment.AmountPaid, 2))

                EDCAddSale(15, txtShowTotal.Text)
                'ModulePayMent.BtnAddSale()

                POS.DiscountByItem2 = 0
                Pos_payment.totalPay = 0
                Pos_payment.AmountPaid = 0
                POS.TextBox3.Focus()

                Dim GetSaleNo As DataTable = executesql("SELECT SaleNo,SaleId FROM Sale WHERE SaleId = (SELECT MAX(SaleId) FROM Sale)")

                executesql("INSERT INTO CardDetail(SaleId,TIDs,MIds,VisaType,Batch,CradId,APPRCode,RefNo,CardName,Trace,SaleNo) VALUES('" & GetSaleNo(0)("SaleId") & "','" & TIDs & "','" & MIDs & "','" & VisaType & "','" & Batch & "','" & CradId & "','" & APPRCode & "','" & RefNo & "','" & CradName & "','" & Trace & "','" & GetSaleNo(0)("SaleNo") & "')")

                Me.Close()

            ElseIf EdcType = 3 Then

                Pos_payment.totalPay += txtShowTotal.Text
                Pos_payment.AmountPaid = txtShowTotal.Text
                Pos_payment.txtPayTotal.Text = FormatNumber(Pos_payment.totalPay, 2)
                Pos_payment.PaymentType = "QR WeChat"
                Pos_payment.DataGridViewSale.Rows.Add("QR WeChat", FormatNumber(Pos_payment.AmountPaid, 2))

                EDCAddSale(17, txtShowTotal.Text)
                'ModulePayMent.BtnAddSale()

                POS.DiscountByItem2 = 0
                Pos_payment.totalPay = 0
                Pos_payment.AmountPaid = 0
                POS.TextBox3.Focus()

                Dim GetSaleNo As DataTable = executesql("SELECT SaleNo,SaleId FROM Sale WHERE SaleId = (SELECT MAX(SaleId) FROM Sale)")

                executesql("INSERT INTO CardDetail(SaleId,TIDs,MIds,VisaType,Batch,CradId,APPRCode,RefNo,CardName,Trace,SaleNo) VALUES('" & GetSaleNo(0)("SaleId") & "','" & TIDs & "','" & MIDs & "','" & VisaType & "','" & Batch & "','" & CradId & "','" & APPRCode & "','" & RefNo & "','" & CradName & "','" & Trace & "','" & GetSaleNo(0)("SaleNo") & "')")

                Me.Close()
            End If

        Else
            MsgBox("error ," + TextBox1.Text, MsgBoxStyle.Critical, "")
            writeLog("User ID " + Frm_Login.UserId.ToString + TextBox1.Text + " error ")
        End If

    End Sub


    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub textBoxOutput_TextChanged(sender As Object, e As EventArgs) Handles textBoxOutput.TextChanged
        If textBoxOutput.Text = "ACK->EDC Pos not applove, Error Code : ND" Then
            writeLog("User ID " + Frm_Login.UserId.ToString + " ACK->EDC Pos not applove, Error Code : ND")

            Com.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        writeLog("User ID " + Frm_Login.UserId.ToString + " Pos_Payment_EDC cancle click")

        Com.Close()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Qr Thai
        writeLog("User ID " + Frm_Login.UserId.ToString + " Pay QR Thai click")

        Label2.Text = "แสกน QR CODE"
        Panel2.Visible = False
        Panel1.Visible = True
        tbAlipayA1.Text = "03"

        OpenComm()
        Dim bySendBuf() As Byte = tool.PackECRHeader("70")
        bySendBuf = tool.PackTLV(bySendBuf, "40", 12, String.Format("{0,12}", textBoxAmount.Text))
        bySendBuf = tool.PackTLV(bySendBuf, "A1", 2, tbAlipayA1.Text)

        Dim bySend() As Byte = tool.PackSerial(bySendBuf, bySendBuf.Length)

        szInput = tool.HexToAscii(bySendBuf) ' display out data

        Com.Write(bySend, 0, bySend.Length)
        szOutput = "SEND"

        EdcType = 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' WeChat
        writeLog("User ID " + Frm_Login.UserId.ToString + " Pay weChat click")

        Label2.Text = "แสกน QR CODE"
        Panel2.Visible = False
        Panel1.Visible = True
        tbAlipayA1.Text = "02"

        OpenComm()
        Dim bySendBuf() As Byte = tool.PackECRHeader("70")
        bySendBuf = tool.PackTLV(bySendBuf, "40", 12, String.Format("{0,12}", textBoxAmount.Text))
        bySendBuf = tool.PackTLV(bySendBuf, "A1", 2, tbAlipayA1.Text)

        Dim bySend() As Byte = tool.PackSerial(bySendBuf, bySendBuf.Length)

        szInput = tool.HexToAscii(bySendBuf) ' display out data

        Com.Write(bySend, 0, bySend.Length)
        szOutput = "SEND"

        EdcType = 3
    End Sub
End Class