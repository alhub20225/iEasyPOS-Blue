Imports System.Drawing
Public Class FloorPlan
    Private Sub FloorPlan_Load(sender As Object, e As EventArgs) Handles Me.Load
        ModuleFloorPlan.LoadZone_floor()
        load_table_floor()
    End Sub

    Sub udate_loxy()
        For i As Integer = 0 To Floor.Controls.Count - 1
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=tables&value=set x = '" & Floor.Controls.Item(i).Location.X & "' where tableid = '" & Floor.Controls.Item(i).Name & "'")
            executesql("update tables set x = '" & Floor.Controls.Item(i).Location.X & "' where tableid = '" & Floor.Controls.Item(i).Name & "'")
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=tables&value=set y = '" & Floor.Controls.Item(i).Location.Y & "' where tableid = '" & Floor.Controls.Item(i).Name & "'")
            executesql("update tables set y = '" & Floor.Controls.Item(i).Location.Y & "' where tableid = '" & Floor.Controls.Item(i).Name & "'")
        Next
    End Sub
    Sub update_wh()
        For i As Integer = 0 To Floor.Controls.Count - 1
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=tables&value=set w = '" & Floor.Controls.Item(i).Width & "' where tableid = '" & Floor.Controls.Item(i).Name & "'")
            executesql("update tables set w = '" & Floor.Controls.Item(i).Width & "' where tableid = '" & Floor.Controls.Item(i).Name & "' ")
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=tables&value=set h = '" & Floor.Controls.Item(i).Height & "' where tableid = '" & Floor.Controls.Item(i).Name & "'")
            executesql("update tables set h = '" & Floor.Controls.Item(i).Height & "' where tableid = '" & Floor.Controls.Item(i).Name & "' ")
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        udate_loxy()
        update_wh()
        load_table_floor()
    End Sub

    Private Sub Close_table_Click(sender As Object, e As EventArgs) Handles Close_table.Click
        udate_loxy()
        update_wh()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Zone_img.Show()
    End Sub
End Class