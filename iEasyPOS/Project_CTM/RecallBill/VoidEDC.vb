
Imports System.IO.Ports

Public Class VoidEDC
    Private tool As New Tool()
    Private Com As New SerialPort()
    Private szOutput As String = ""
    Private szInput As String = ""
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
            MessageBox.Show("Port not open")
            Return False
        End Try
    End Function
    Private Sub port_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
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
                    'Com.Close();
                    Return
                End If
                If byRead(0) = CByte(&H6) Then
                    szOutput = "ACK"
                    'Com.Close();
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

                'LabelCom.Text = "PORT CLOSE";
                Com.Close()
                Return
            End If
            'LabelCom.Text = "PORT CLOSE";
            Com.Close()

            szOutput = tool.HexToAscii(byData)
            szOutput &= vbCrLf & vbCrLf

            ' cut header
            Dim byFieldData(byData.Length - 19) As Byte
            Buffer.BlockCopy(byData, 18, byFieldData, 0, byData.Length - 18)

            Dim inFieldNo As Integer = 1
            Dim szDataOfField As String = ""
            Do
                szDataOfField = inGetDataByNo(byFieldData, inFieldNo)
                If szDataOfField <> "" Then
                    szOutput &= vbCrLf & szDataOfField
                Else
                    Exit Do
                End If
                inFieldNo += 1
            Loop



            Dim szP1 As String = inGetData(byFieldData, "P1")
            Dim inP1Index As Integer = 0
            If szP1.Length > 0 Then
                Try
                    szOutput &= vbCrLf & " (P1) ------- DATA ------- " & vbCrLf & szP1
                    szOutput &= vbCrLf & " (P1) szCarLicense[6] = " & szP1.Substring(inP1Index, 6)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szCustomerName[48] = " + szP1.Substring(inP1Index += 6, 48);
                    szOutput &= vbCrLf & " (P1) szCustomerName[48] = " & szP1.Substring(inP1Index + 6, 48)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szTaxNo[6] = " + szP1.Substring(inP1Index += 48, 6);
                    szOutput &= vbCrLf & " (P1) szTaxNo[6] = " & szP1.Substring(inP1Index + 48, 6)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) lnAmtExcVat[12] = " + szP1.Substring(inP1Index += 6, 12);
                    szOutput &= vbCrLf & " (P1) lnAmtExcVat[12] = " & szP1.Substring(inP1Index + 6, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szVat[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szVat[12] = " & szP1.Substring(inP1Index + 12, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szQuanity[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szQuanity[12] = " & szP1.Substring(inP1Index + 12, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szPricePerUnit[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szPricePerUnit[12] = " & szP1.Substring(inP1Index + 12, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szCardFlag[1] = " + szP1.Substring(inP1Index += 12, 1);
                    szOutput &= vbCrLf & " (P1) szCardFlag[1] = " & szP1.Substring(inP1Index + 12, 1)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szCardBalance[12] = " + szP1.Substring(inP1Index += 1, 12);
                    szOutput &= vbCrLf & " (P1) szCardBalance[12] = " & szP1.Substring(inP1Index + 1, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szDiscountAmount[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szDiscountAmount[12] = " & szP1.Substring(inP1Index + 12, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szRedeemAmt[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szRedeemAmt[12] = " & szP1.Substring(inP1Index + 12, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szRedeemPoint[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szRedeemPoint[12] = " & szP1.Substring(inP1Index + 12, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szCreditAmt[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szCreditAmt[12] = " & szP1.Substring(inP1Index + 12, 12)
                    'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB:
                    'ORIGINAL LINE: szOutput += vbCrLf + " (P1) szNetAmt[12] = " + szP1.Substring(inP1Index += 12, 12);
                    szOutput &= vbCrLf & " (P1) szNetAmt[12] = " & szP1.Substring(inP1Index + 12, 12)
                Catch

                End Try
            End If

        End If
    End Sub
    Public Function inGetDataByNo(ByVal byData() As Byte, ByVal inFieldNo As Integer) As String
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
    Public Function inGetData(ByVal byData() As Byte, ByVal szID As String) As String
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

    Private Sub BtnVoidEDC_Click(sender As Object, e As EventArgs) Handles BtnVoidEDC.Click

        If MsgBox("ต้องการยกเลิกบิลหรือไม่", MsgBoxStyle.OkCancel, "คำเตือน") = MsgBoxResult.Ok Then

            Dim tracNo As DataTable = executesql("SELECT CardDetail.Trace,CardDetail.SaleId,Sale.Active FROM CardDetail inner join Sale on (CardDetail.SaleId = Sale.SaleId) WHERE CardDetail.SaleNo = '" & TextBox1.Text & "' AND Sale.TerminalName = '" & Environment.MachineName & "'")
            If tracNo.Rows.Count = 0 Then
                MsgBox("ไม่พบรายการนี้", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            ElseIf tracNo(0)("Active") = 2 Then
                MsgBox("รายการนี้ถูกยกเลิกแล้ว", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            Else
                MsgBox("กด OK ที่เครื่อง EDC", MsgBoxStyle.Critical, "คำเตือน")
                textBoxTraceNo.Text = tracNo(0)("Trace")
                GetSaleId = tracNo(0)("SaleId")
                'MsgBox(GetSaleId)
            End If

            Dim bySend() As Byte ' = new byte[100];

            If Not OpenPort() Then
                Return
            End If
            'MsgBox(textBoxTraceNo.Text)
            bySend = tool.PackECRVoid(textBoxTraceNo.Text, textBoxMerchant.Text)
            szInput = tool.HexToAscii(bySend) ' display out data
            Com.Write(bySend, 0, bySend.Length)
            szOutput = "SEND"

            Dim Datetime As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            executesql("UPDATE Sale set Active = 2,VoidDate='" & Datetime & "',VoidUserId=" & Frm_Login.UserId & " WHERE SaleId=" & GetSaleId & "")
            executesql("UPDATE SaleItem Set Active = 2 WHERE SaleId=" & GetSaleId & "")
            MsgBox("ยกเลิกบิลเรียบร้อย", MsgBoxStyle.Information, "ระบบ")
            ModulePrintPosSlip.PrintSlip()
            Me.Close()
        Else
            Exit Sub
            Me.Close()
        End If


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        TextBox1.Text += "1"
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim tracNo As DataTable = executesql("SELECT Trace,SaleId FROM CardDetail WHERE SaleNo='" & TextBox1.Text & "'")
        If tracNo.Rows.Count = 0 Then
            textBoxTraceNo.Text = ""
        Else
            textBoxTraceNo.Text = tracNo(0)("Trace")
        End If
    End Sub

    Private Sub VoidEDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxCom.Text = My.Settings.Comport
        TextBox1.Focus()
    End Sub
End Class