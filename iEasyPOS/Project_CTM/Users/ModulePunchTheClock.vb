Module ModulePunchTheClock
    'Dim userId As Integer = Frm_Login.SendUserId
    'Dim timeNow = TimeOfDay
    Sub loadUserData()
        Try
            'Dim selectUser As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=Users.FristName,Users.LastName,Users.Image,Roles.RoleName&table=Users INNER JOIN Roles ON Roles.RoleId=Users.RoleId&where=Users.UserId='" & Frm_Login.SendUserId & "' and Users.Active = 1")
            Dim selectUser As DataTable = executesql("SELECT Users.FristName,Users.LastName,Users.Image,Roles.RoleName FROM Users INNER JOIN Roles ON Roles.RoleId=Users.RoleId WHERE Users.UserId='" & Frm_Login.SendUserId & "' and Users.Active = 1")
            Frm_PunchTheClock.LabelUserName.Text = selectUser(0)("FristName") & " " & selectUser(0)("LastName")
            Frm_PunchTheClock.LabelUserPosition.Text = selectUser(0)("RoleName")
            'Convert Base64String To Image 
            Dim img As System.Drawing.Image
            Dim Ms As System.IO.MemoryStream = New System.IO.MemoryStream
            Dim b() As Byte
            'Convert Base64 encoded msg To Image Data 
            b = Convert.FromBase64String(selectUser(0)("Image"))
            Ms = New System.IO.MemoryStream(b)
            'Create Image 
            img = System.Drawing.Image.FromStream(Ms)
            Frm_PunchTheClock.PictureBoxUser.BackgroundImage = img
            Frm_PunchTheClock.PictureBoxUser.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

    End Sub
    Sub loadTime()
        'Frm_PunchTheClock.timeNow.Text = TimeOfDay
        showtime()
        checkTime()
    End Sub
    Sub checkTime()
        'Try
        'Dim checkTimeIn As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockIn&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim checkTimeIn As DataTable = executesql("SELECT ClockIn FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        If checkTimeIn.Rows.Count = 0 Then
            Frm_PunchTheClock.btnTimeIn.Enabled = True
            Exit Sub
        Else Frm_PunchTheClock.btnTimeIn.Enabled = False
        End If
        'Dim checkTimeOut As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockIn,ClockOut&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim checkTimeOut As DataTable = executesql("SELECT ClockIn,ClockOut FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        If IsDBNull(checkTimeOut(0)("ClockOut")) Then
            Frm_PunchTheClock.btnTimeOut.Enabled = True
            Frm_PunchTheClock.btnBreakIn.Enabled = True
            Frm_PunchTheClock.btnBreakOut.Enabled = True
        Else
            Frm_PunchTheClock.btnTimeOut.Enabled = False
            Frm_PunchTheClock.btnBreakIn.Enabled = False
            Frm_PunchTheClock.btnBreakOut.Enabled = False
        End If
        'Dim checkClockBreakIn As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockBreakIn&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim checkClockBreakIn As DataTable = executesql("SELECT ClockBreakIn FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        If IsDBNull(checkClockBreakIn(0)("ClockBreakIn")) Then
            Frm_PunchTheClock.btnBreakIn.Enabled = True
        Else Frm_PunchTheClock.btnBreakIn.Enabled = False
        End If
        'Dim checkClockBreakOut As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockBreakOut&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim checkClockBreakOut As DataTable = executesql("SELECT ClockBreakOut FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        If IsDBNull(checkClockBreakOut(0)("ClockBreakOut")) Then
            Frm_PunchTheClock.btnBreakOut.Enabled = True
        Else Frm_PunchTheClock.btnBreakOut.Enabled = False
        End If
        ' Dim checkClockOTIn As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockOTIn&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim checkClockOTIn As DataTable = executesql("SELECT ClockOTIn FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        If IsDBNull(checkClockOTIn(0)("ClockOTIn")) Then
            Frm_PunchTheClock.btnOTIn.Enabled = True
        Else Frm_PunchTheClock.btnOTIn.Enabled = False
        End If
        'Dim checkClockOTOut As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockOTOut&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim checkClockOTOut As DataTable = executesql("SELECT ClockOTOut FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        If IsDBNull(checkClockOTOut(0)("ClockOTOut")) Then
            Frm_PunchTheClock.btnOTOut.Enabled = True
        Else Frm_PunchTheClock.btnOTOut.Enabled = False
        End If
        'Catch ex As Exception

        'End Try

    End Sub
    Sub btnTimeIn()
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&field=UserId,DateOfWork,ClockIn,Active&table=PunchTheClock&value='" & Frm_Login.SendUserId & "','" & Format(Now, "yyyy-MM-dd") & "','" & Frm_PunchTheClock.timeNow.Text & "','1'")
        executesql("INSERT INTO PunchTheClock(UserId,DateOfWork,ClockIn,Active) VALUES('" & Frm_Login.SendUserId & "','" & Format(Now, "yyyy-MM-dd") & "','" & Frm_PunchTheClock.timeNow.Text & "','1')")
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

        loadTime()
    End Sub
    Sub btnTimeOut()

        Dim selectTimeIn2 As DataTable = executesql("SELECT ClockIn FROM PunchTheClock WHERE  UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Dim Tnow As String = Frm_PunchTheClock.timeNow.Text
        Dim Tin As String = selectTimeIn2(0)("ClockIn").ToString
        Dim totalTimeOfDay = DateDiff(DateInterval.Hour, CDate(Tin), CDate(Tnow))
        MsgBox(totalTimeOfDay)
        executesql("UPDATE PunchTheClock SET ClockOut='" & Frm_PunchTheClock.timeNow.Text & "' WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False
        Frm_PunchTheClock.btnBreakIn.Enabled = False
        Frm_PunchTheClock.btnBreakOut.Enabled = False
        Frm_PunchTheClock.btnTimeOut.Enabled = False
        loadTime()
    End Sub
    Sub btnBreakIn()
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=PunchTheClock&value=ClockBreakIn='" & Frm_PunchTheClock.timeNow.Text & "' WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        executesql("UPDATE PunchTheClock SET ClockBreakIn='" & Frm_PunchTheClock.timeNow.Text & "' WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False
        loadTime()
    End Sub
    Sub btnBreakOut()
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=PunchTheClock&value=ClockBreakOut='" & Frm_PunchTheClock.timeNow.Text & "' WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        executesql("UPDATE PunchTheClock SET ClockBreakOut='" & Frm_PunchTheClock.timeNow.Text & "' WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False
        loadTime()
    End Sub
    Sub btnOTIn()
        'Dim checkTimeOut As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockOut&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Dim checkTimeOut As DataTable = executesql("SELECT ClockOut FROM PunchTheClock WHERE  UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        If IsDBNull(checkTimeOut(0)("ClockOut")) Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาตอกบัตรออกงานก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=PunchTheClock&value=ClockOTIn='" & Frm_PunchTheClock.timeNow.Text & "'&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        executesql("UPDATE PunchTheClock SET ClockOTIn='" & Frm_PunchTheClock.timeNow.Text & "' WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False
        loadTime()
    End Sub
    Sub btnOTOut()
        'Dim checkOTIn As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=ClockOTIn&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Dim checkOTIn As DataTable = executesql("SELECT ClockOTIn FROM PunchTheClock WHERE  UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        If IsDBNull(checkOTIn(0)("ClockOTIn")) Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาตอกบัตรเข้า OT ก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        Dim totalTimeOTOfDay = DateDiff(DateInterval.Hour, CDate(checkOTIn(0)("ClockOTIn").ToString), CDate(Frm_PunchTheClock.timeNow.Text))
        MsgBox(totalTimeOTOfDay)
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=PunchTheClock&value=ClockOTOut='" & Frm_PunchTheClock.timeNow.Text & "',ClockTotalTimeOfOT='" & totalTimeOTOfDay & "'&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        executesql("UPDATE PunchTheClock SET ClockOTOut='" & Frm_PunchTheClock.timeNow.Text & "' WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork='" & Format(Now, "yyyy-MM-dd") & "'")
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False
        loadTime()
    End Sub
    Sub showtime()
        Frm_PunchTheClock.DataGridViewShowTimeInOut.Rows.Clear()
        'Dim selectTime As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=UserId,DateOfWork,ClockIn,ClockOut,ClockBreakIn,ClockBreakOut,ClockOTIn,ClockOTOut,ClockTotalTimeOfDay,ClockTotalTimeOfOT,Active&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim selectTime As DataTable = executesql("SELECT UserId,DateOfWork,ClockIn,ClockOut,ClockBreakIn,ClockBreakOut,ClockOTIn,ClockOTOut,ClockTotalTimeOfDay,ClockTotalTimeOfOT,Active FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Now, "yyyy-MM-dd") & "' AND Active = 1")
        Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
        For i As Integer = 0 To selectTime.Rows.Count - 1
            Dim dateFromDB As DateTime = Convert.ToDateTime(selectTime(i)("DateOfWork"), _cultureEnInfo)
            Frm_PunchTheClock.DataGridViewShowTimeInOut.Rows.Add(dateFromDB.ToString("dd MMM yyyy", _cultureEnInfo), selectTime(i)("ClockIn"), selectTime(i)("ClockBreakIn"), selectTime(i)("ClockBreakOut"), selectTime(i)("ClockOut"), selectTime(i)("ClockOTIn"), selectTime(i)("ClockOTOut"))
        Next
    End Sub
    Sub btnSearch()
        Frm_PunchTheClock.DataGridViewShowTimeInOut.Rows.Clear()
        'Dim selectTime As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=UserId,DateOfWork,ClockIn,ClockOut,ClockBreakIn,ClockBreakOut,ClockOTIn,ClockOTOut,ClockTotalTimeOfDay,ClockTotalTimeOfOT,Active&table=PunchTheClock&where=UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Frm_PunchTheClock.DateTimePickerSearch.Value, "yyyy-MM-dd") & "' AND Active = 1")
        Dim selectTime As DataTable = executesql("SELECT UserId,DateOfWork,ClockIn,ClockOut,ClockBreakIn,ClockBreakOut,ClockOTIn,ClockOTOut,ClockTotalTimeOfDay,ClockTotalTimeOfOT,Active FROM PunchTheClock WHERE UserId='" & Frm_Login.SendUserId & "' AND DateOfWork = '" & Format(Frm_PunchTheClock.DateTimePickerSearch.Value, "yyyy-MM-dd") & "' AND Active = 1")
        Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
        For i As Integer = 0 To selectTime.Rows.Count - 1
            Dim dateFromDB As DateTime = Convert.ToDateTime(selectTime(i)("DateOfWork"), _cultureEnInfo)
            Frm_PunchTheClock.DataGridViewShowTimeInOut.Rows.Add(dateFromDB.ToString("dd MMM yyyy", _cultureEnInfo), selectTime(i)("ClockIn"), selectTime(i)("ClockBreakIn"), selectTime(i)("ClockBreakOut"), selectTime(i)("ClockOut"))
        Next
    End Sub
End Module
