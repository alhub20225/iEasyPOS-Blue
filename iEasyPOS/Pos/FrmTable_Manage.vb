Public Class FrmTable_Manage
    Private Sub FrmTable_Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Frm_Login.language = 0 Then
            change_to_th_text()
            If POS.TableManageTypeId = 1 Then
                BtnClear.Visible = False
                Label4.Image = iEasyPOS.My.Resources.Resources.Icon_MoveTableGray
                Label36.Text = "ย้ายโต๊ะ"
                Label4.Text = "ย้ายโต๊ะ :"
            ElseIf POS.TableManageTypeId = 2 Then
                BtnClear.Visible = False
                Label4.Image = iEasyPOS.My.Resources.Resources.Icon_Combined_TableGray
                Label36.Text = "รวมโต๊ะ"
                Label4.Text = "รวมโต๊ะ :"
            End If
        Else

            change_to_eng_text()
            If POS.TableManageTypeId = 1 Then
                BtnClear.Visible = False
                Label4.Image = iEasyPOS.My.Resources.Resources.Icon_MoveTableGray
                Label36.Text = "Move"
                Label4.Text = "Move :"
            ElseIf POS.TableManageTypeId = 2 Then
                BtnClear.Visible = False
                Label4.Image = iEasyPOS.My.Resources.Resources.Icon_Combined_TableGray
                Label36.Text = "Group"
                Label4.Text = "Group :"
            End If
        End If


        FlowLayoutPanelTable.Controls.Clear()
        LabelID.Text = ""
        LabelName.Text = ""
        txtGroupTableName.Text = ""
        ModuleManageTable.LoadZone()
        txtTableName.Text = ModuleZoneTable.TableName
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        BtnClear.Visible = False
        FlowLayoutPanelTable.Controls.Clear()
        LabelID.Text = ""
        LabelName.Text = ""
        txtGroupTableName.Text = ""
        ModuleManageTable.LoadZone()
        txtTableName.Text = ModuleZoneTable.TableName
    End Sub
    Sub change_to_th_text()
        Label36.Text = My.Resources.pos_groupTable_th.groupTable
        Label6.Text = My.Resources.pos_groupTable_th.table
        Label4.Text = My.Resources.pos_groupTable_th.moveTable
        Label1.Text = My.Resources.pos_groupTable_th.zone
        Label3.Text = My.Resources.pos_groupTable_th.table
        BtnDel.Text = My.Resources.pos_groupTable_th.cancel
        RadButton10.Text = My.Resources.pos_groupTable_th.save
    End Sub

    Sub change_to_eng_text()
        Label36.Text = My.Resources.pos_groupTable_en.groupTable
        Label6.Text = My.Resources.pos_groupTable_en.table
        Label4.Text = My.Resources.pos_groupTable_en.moveTable
        Label1.Text = My.Resources.pos_groupTable_en.zone
        Label3.Text = My.Resources.pos_groupTable_en.table
        BtnDel.Text = My.Resources.pos_groupTable_en.cancel
        RadButton10.Text = My.Resources.pos_groupTable_en.save
    End Sub

End Class