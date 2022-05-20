Public Class FrmCustomerMemberNo
    Public Shared customerMemNo As String = 0
    Public Shared CustomerId As String = 0
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        If txtCustomerMemNo.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim selectCustId As DataTable = executesql("SELECT CustomerId,FirstName,LastName FROM Customer WHERE MemberNo='" & txtCustomerMemNo.Text & "'")
        If IsNothing(selectCustId) Then
            CustomerId = 0
            MsgBox("ไม่พบข้อมูล")
            Exit Sub
        End If
        If selectCustId.Rows.Count = 0 Then
            CustomerId = 0
            MsgBox("ไม่พบข้อมูล")
            Exit Sub
        Else
            CustomerId = selectCustId(0)("CustomerId")
            POS.btnUsePoint.Visible = True
            customerMemNo = txtCustomerMemNo.Text
            POS.btnUsePoint.Text = "Customer : " & selectCustId(0)("FirstName")
            POS.Button2.Visible = True
            txtCustomerMemNo.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub FrmCustomerMemberNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustomerMemNo.Focus()
        Me.TopMost = True
    End Sub
End Class