Public Class FrmManageZoneTable
    Private Sub Table_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ModuleZoneTable.LoadZone()

        ''ตำแหน่งปุ่ม
        ''ปิด
        Close_table.Location = New System.Drawing.Point(
            Me.ClientRectangle.Width - Close_table.Width, 0)
        Close_table.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        Top_tap.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        Top_tap.Width = Me.Width
        'Dim BtnManage As New FrmButtonManageZone()
        'BtnManage.TopLevel = False
        'PanelButtonManageZone.Controls.Add(BtnManage)
        'BtnManage.Show()

    End Sub


    Private Sub Close_table_Click(sender As Object, e As EventArgs) Handles Close_table.Click
        Me.Close()
    End Sub

    Private Sub Top_tap_Click(sender As Object, e As EventArgs) Handles Top_tap.Click

    End Sub
End Class