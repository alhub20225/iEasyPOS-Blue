Module ModulePosPointItem
    Sub customerData()
        Dim cusMemberNo As String = FrmCustomerMemberNo.customerMemNo
        Dim selectCustomer As DataTable = executesql("SELECT FirstName,MidName,LastName,Point,MemberNo FROM Customer WHERE MemberNo = '" & cusMemberNo & "'")
        Dim point As Integer
        If IsDBNull(selectCustomer(0)("Point")) Then
            point = 0
        Else
            point = selectCustomer(0)("Point")
        End If
        FrmUsePoint.txtMemberNo.Text = selectCustomer(0)("MemberNo")
        FrmUsePoint.txtCustomerName.Text = selectCustomer(0)("FirstName") & " " & selectCustomer(0)("LastName")
        FrmUsePoint.txtCustomerPoint.Text = point
    End Sub
    Sub loadItem()
        Dim selectItem As DataTable = executesql("SELECT ItemId,ItemName,PointToRedeem,ImageText,ButtonColor,FontColor FROM Item WHERE AllowRedeemPoint ='1'")
        If IsNothing(selectItem) Then
            Exit Sub
        End If
        If selectItem.Rows.Count = 0 Then
            Exit Sub
        End If
        FrmUsePoint.FlowLayoutPanelItemPoint.Controls.Clear()
        For i As Integer = 0 To selectItem.Rows.Count - 1
            If Not IsDBNull(selectItem(i)("PointToRedeem")) Then
                Dim ItemPoint As New Button
                ItemPoint.Name = selectItem(i)("ItemId")
                ItemPoint.Text = selectItem(i)("ItemName")
                If IsDBNull(selectItem(i)("ImageText")) Then
                    ItemPoint.BackColor = Color.FromArgb(selectItem(i)("ButtonColor"))
                Else
                    If selectItem(i)("ImageText") <> "" Then
                        'Setup image and get data stream together
                        Dim img As System.Drawing.Image
                        Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                        Dim b() As Byte
                        'Converts the base64 encoded msg to image data
                        b = Convert.FromBase64String(selectItem(i)("ImageText"))
                        MS = New System.IO.MemoryStream(b)
                        'creates image
                        img = System.Drawing.Image.FromStream(MS)
                        ItemPoint.BackgroundImage = img
                        ItemPoint.BackgroundImageLayout = ImageLayout.Stretch
                    End If
                End If
                ItemPoint.FlatStyle = FlatStyle.Flat
                ItemPoint.ForeColor = Color.FromArgb(selectItem(i)("FontColor"))
                ItemPoint.Font = New Font("Sukhumvit Set", 12, FontStyle.Bold)
                ItemPoint.Width = 120
                ItemPoint.Height = 122
                FrmUsePoint.FlowLayoutPanelItemPoint.Controls.Add(ItemPoint)
                AddHandler ItemPoint.Click, AddressOf getItem
            End If
        Next
    End Sub
    Dim UItemId As Integer
    Dim UItemName As String
    Sub getItem(sender As Object, e As EventArgs)
        UItemId = sender.Name
        UItemName = sender.Text
        If FrmUsePoint.DataGridViewUseItemPoint.Rows.Count = 0 Then
            Dim selectItem As DataTable = executesql("SELECT PointToRedeem FROM Item WHERE ItemId='" & UItemId & "'")
            FrmUsePoint.DataGridViewUseItemPoint.Rows.Add(UItemName, 1, selectItem(0)("PointToRedeem"), selectItem(0)("PointToRedeem"), UItemId)
        Else
            CheckItem()
        End If
        calPoint()
    End Sub
    Sub CheckItem()
        Dim checkExists As Boolean = False
        Dim j As Integer
        For i As Integer = 0 To FrmUsePoint.DataGridViewUseItemPoint.Rows.Count - 1
            If UItemId = FrmUsePoint.DataGridViewUseItemPoint.Rows(i).Cells("UseItemId").Value Then
                checkExists = True
                j = i
                Exit For
            End If
        Next
        Dim selectPoint As DataTable = executesql("SELECT PointToRedeem FROM Item WHERE ItemId = '" & UItemId & "'")
        If checkExists = True Then
            Dim Qty As Integer = CDbl(FrmUsePoint.DataGridViewUseItemPoint.Rows(j).Cells(1).Value + 1)
            FrmUsePoint.DataGridViewUseItemPoint.Rows(j).Cells(1).Value = Qty
            FrmUsePoint.DataGridViewUseItemPoint.Rows(j).Cells(2).Value = selectPoint(0)("PointToRedeem")
            FrmUsePoint.DataGridViewUseItemPoint.Rows(j).Cells(3).Value = selectPoint(0)("PointToRedeem") * Qty
        Else
            FrmUsePoint.DataGridViewUseItemPoint.Rows.Add(UItemName, 1, selectPoint(0)("PointToRedeem"), selectPoint(0)("PointToRedeem"), UItemId)
        End If
    End Sub
    Sub calPoint()
        Dim txtTotalPoint As Integer
        For i As Integer = 0 To FrmUsePoint.DataGridViewUseItemPoint.RowCount - 1
            txtTotalPoint += FrmUsePoint.DataGridViewUseItemPoint.Rows(i).Cells(3).Value
        Next
        FrmUsePoint.txtTotalPoint.Text = txtTotalPoint
    End Sub
    Sub btnSave()
        If FrmUsePoint.DataGridViewUseItemPoint.RowCount <> 0 Then
            Dim checkPointCustomer As DataTable = executesql("SELECT Point FROM Customer WHERE MemberNo ='" & FrmCustomerMemberNo.customerMemNo & "'")

            If Frm_Login.language = 0 Then
                If IsNothing(checkPointCustomer) Then
                    MsgBox("แต้มไม่เพียงพอ", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If checkPointCustomer.Rows.Count = 0 Then
                    MsgBox("แต้มไม่เพียงพอ", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If IsDBNull(checkPointCustomer(0)("Point")) Then
                    MsgBox("แต้มไม่เพียงพอ", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If checkPointCustomer(0)("Point") < FrmUsePoint.txtTotalPoint.Text Then
                    MsgBox("แต้มไม่เพียงพอ", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Else
                If IsNothing(checkPointCustomer) Then
                    MsgBox("not enough point.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If checkPointCustomer.Rows.Count = 0 Then
                    MsgBox("not enough point.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If IsDBNull(checkPointCustomer(0)("Point")) Then
                    MsgBox("not enough point.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If checkPointCustomer(0)("Point") < FrmUsePoint.txtTotalPoint.Text Then
                    MsgBox("not enough point.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If


            Dim ItemId As Integer
            Dim PointToRedeem As Decimal
            Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("en-EN"))
            For i As Integer = 0 To FrmUsePoint.DataGridViewUseItemPoint.RowCount - 1
                'insert use point
                ItemId = FrmUsePoint.DataGridViewUseItemPoint.Rows(i).Cells(4).Value
                PointToRedeem = FrmUsePoint.DataGridViewUseItemPoint.Rows(i).Cells(3).Value

                executesql("INSERT INTO UsePointItem(ItemId,InsertDate,PointRate,CustomerNo,UserId,Qty,StatusPrint) VALUES('" & ItemId & "','" & InsertDate & "','" & PointToRedeem & "','" & FrmCustomerMemberNo.customerMemNo & "','" & Frm_Login.UserId & "','" & FrmUsePoint.DataGridViewUseItemPoint.Rows(i).Cells(1).Value & "',0)")
                'update point customer
                executesql("UPDATE Customer Set Point -='" & FrmUsePoint.DataGridViewUseItemPoint.Rows(i).Cells(3).Value & "' WHERE MemberNo='" & FrmCustomerMemberNo.customerMemNo & "'")
            Next
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information)
            clearData()
        End If
    End Sub
    Sub clearData()
        'customer
        FrmCustomerMemberNo.customerMemNo = 0
        POS.BtnPoint.Enabled = False
        POS.PanelMember.Text = ""
        FrmUsePoint.Close()
    End Sub
End Module
