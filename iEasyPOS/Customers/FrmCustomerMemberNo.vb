Public Class FrmCustomerMemberNo
    Public Shared customerMemNo As String = 0
    Public Shared CustomerId As String = 0
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        If txtCustomerMemNo.Text = "" Then
            If Frm_Login.language = 0 Then
                MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Else
                MsgBox("Please fill in the form", MsgBoxStyle.Critical)
            End If
            Exit Sub
        End If
        Dim selectCustId As DataTable = executesql("SELECT CustomerId,FirstName,LastName FROM Customer WHERE MemberNo='" & txtCustomerMemNo.Text & "'")
        If IsNothing(selectCustId) Then
            CustomerId = 0
            If Frm_Login.language = 0 Then
                MsgBox("ไม่พบข้อมูล")
            Else
                MsgBox("No Data.")
            End If

            Exit Sub
        End If
        If selectCustId.Rows.Count = 0 Then
            CustomerId = 0
            If Frm_Login.language = 0 Then
                MsgBox("ไม่พบข้อมูล")
            Else
                MsgBox("No Data.")
            End If

            Exit Sub
        Else
            CustomerId = selectCustId(0)("CustomerId")
            POS.PanelMember.Visible = True
            customerMemNo = txtCustomerMemNo.Text
            POS.LabelMemberName.Text = "Customer : " & selectCustId(0)("FirstName")
            POS.BtnPoint.Enabled = True
            txtCustomerMemNo.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub FrmCustomerMemberNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustomerMemNo.Select()
        txtCustomerMemNo.Text = ""
        If Frm_Login.language = 0 Then
            change_to_th_text()
        Else
            change_to_eng_text()
        End If
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Me.Close()
    End Sub

    Sub change_to_eng_text()
        Label34.Text = My.Resources.pos_member_en.member
        Label31.Text = My.Resources.pos_member_en.membercode
        BtnDel.Text = My.Resources.pos_member_en.cancel
        btn.Text = My.Resources.pos_member_en.ok

    End Sub
    Sub change_to_th_text()
        Label34.Text = My.Resources.pos_member_th.member
        Label31.Text = My.Resources.pos_member_th.membercode
        BtnDel.Text = My.Resources.pos_member_th.cancel
        btn.Text = My.Resources.pos_member_th.ok
    End Sub
End Class