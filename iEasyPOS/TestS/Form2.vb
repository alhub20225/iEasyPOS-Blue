Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewPOS.RowTemplate.Height = 35
        For i As Integer = 0 To 2
            DataGridViewPOS.Rows.Add("น้ำส้มปั่น", 5, "", 50)
        Next

        Label12.Text = "ปุ่มทำรายการ"
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        Panel15.Visible = True
        Panel28.Visible = False
        TextBox3.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Label12.Text = "ปุ่มจัดการโต๊ะ"
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        Panel15.Visible = False
        Panel28.Visible = True
        Me.Refresh()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Label12.Text = "ปุ่มทำรายการ"
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        Panel15.Visible = True
        Panel28.Visible = False
        Me.Refresh()
    End Sub

End Class