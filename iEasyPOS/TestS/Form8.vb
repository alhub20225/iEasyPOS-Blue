Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        XtraTabMain.SelectedTabPageIndex = 0
        Form8_1.TopLevel = False
        Form8_1.FormBorderStyle = FormBorderStyle.None
        Form8_1.WindowState = FormWindowState.Maximized
        Form8_1.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Form8_1)
        Form8_1.Show()

        Panel5.Visible = True
        Panel3.Visible = False
        PageManagementBrand.Text = "ตั้งค่าทั่วไป"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        XtraTabMain.SelectedTabPageIndex = 0
        Form8_1.TopLevel = False
        Form8_1.FormBorderStyle = FormBorderStyle.None
        Form8_1.WindowState = FormWindowState.Maximized
        Form8_1.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Form8_1)
        Form8_1.Show()

        Panel5.Visible = True
        Panel3.Visible = False
        PageManagementBrand.Text = "ตั้งค่าทั่วไป"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        XtraTabMain.SelectedTabPageIndex = 7
        Form8_3.TopLevel = False
        Form8_3.FormBorderStyle = FormBorderStyle.None
        Form8_3.WindowState = FormWindowState.Maximized
        Form8_3.Dock = DockStyle.Fill
        XtraTabPage8.Controls.Add(Form8_3)
        Form8_3.Show()

        Panel5.Visible = False
        Panel3.Visible = True
        PageManagementBrand.Text = "ตั้งค่าระบบ"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        XtraTabMain.SelectedTabPageIndex = 0
        Form8_1.TopLevel = False
        Form8_1.FormBorderStyle = FormBorderStyle.None
        Form8_1.WindowState = FormWindowState.Maximized
        Form8_1.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Form8_1)
        Form8_1.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Button6.Click
        XtraTabMain.SelectedTabPageIndex = 1
        Form8_4.TopLevel = False
        Form8_4.FormBorderStyle = FormBorderStyle.None
        Form8_4.WindowState = FormWindowState.Maximized
        Form8_4.Dock = DockStyle.Fill
        XtraTabPage2.Controls.Add(Form8_4)
        Form8_4.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Button9.Click
        XtraTabMain.SelectedTabPageIndex = 2
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Button10.Click
        XtraTabMain.SelectedTabPageIndex = 3
        Form8_5.TopLevel = False
        Form8_5.FormBorderStyle = FormBorderStyle.None
        Form8_5.WindowState = FormWindowState.Maximized
        Form8_5.Dock = DockStyle.Fill
        XtraTabPage4.Controls.Add(Form8_5)
        Form8_5.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Button8.Click
        XtraTabMain.SelectedTabPageIndex = 4
        Form8_6.TopLevel = False
        Form8_6.FormBorderStyle = FormBorderStyle.None
        Form8_6.WindowState = FormWindowState.Maximized
        Form8_6.Dock = DockStyle.Fill
        XtraTabPage5.Controls.Add(Form8_6)
        Form8_6.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Button11.Click
        XtraTabMain.SelectedTabPageIndex = 5
        Form8_7.TopLevel = False
        Form8_7.FormBorderStyle = FormBorderStyle.None
        Form8_7.WindowState = FormWindowState.Maximized
        Form8_7.Dock = DockStyle.Fill
        XtraTabPage6.Controls.Add(Form8_7)
        Form8_7.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Button7.Click
        XtraTabMain.SelectedTabPageIndex = 6
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Button5.Click
        XtraTabMain.SelectedTabPageIndex = 7
        Form8_3.TopLevel = False
        Form8_3.FormBorderStyle = FormBorderStyle.None
        Form8_3.WindowState = FormWindowState.Maximized
        Form8_3.Dock = DockStyle.Fill
        XtraTabPage8.Controls.Add(Form8_3)
        Form8_3.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Button3.Click
        XtraTabMain.SelectedTabPageIndex = 8
        Form9.TopLevel = False
        Form9.FormBorderStyle = FormBorderStyle.None
        Form9.WindowState = FormWindowState.Maximized
        Form9.Dock = DockStyle.Fill
        XtraTabPage9.Controls.Add(Form9)
        Form9.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Button2.Click
        XtraTabMain.SelectedTabPageIndex = 9
        Form8_2.TopLevel = False
        Form8_2.FormBorderStyle = FormBorderStyle.None
        Form8_2.WindowState = FormWindowState.Maximized
        Form8_2.Dock = DockStyle.Fill
        XtraTabPage10.Controls.Add(Form8_2)
        Form8_2.Show()
    End Sub
End Class