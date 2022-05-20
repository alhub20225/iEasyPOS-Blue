Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        TabControlMain.SelectedTabPageIndex = 0
        Label12.Text = "ปุ่มด่วน"
        PictureBox4.Visible = True
        PictureBox3.Visible = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TabControlMain.SelectedTabPageIndex = 1
        Label12.Text = "ตัวเลข"
        PictureBox4.Visible = False
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TabControlMain.SelectedTabPageIndex = 0
        Label12.Text = "ปุ่มด่วน"
        PictureBox4.Visible = True
        PictureBox3.Visible = False
    End Sub
End Class