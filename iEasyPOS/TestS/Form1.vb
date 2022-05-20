Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        Panel2.Visible = False

        TabControlMain.SelectedTabPageIndex = 0
        Form2.TopLevel = False
        Form2.FormBorderStyle = FormBorderStyle.None
        Form2.WindowState = FormWindowState.Maximized
        Form2.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Form2)
        Form2.Show()

    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TabControlMain.SelectedTabPageIndex = 0
        Form2.TopLevel = False
        Form2.FormBorderStyle = FormBorderStyle.None
        Form2.WindowState = FormWindowState.Maximized
        Form2.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Form2)
        Form2.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        TabControlMain.SelectedTabPageIndex = 1
        Form22.TopLevel = False
        Form22.FormBorderStyle = FormBorderStyle.None
        Form22.WindowState = FormWindowState.Maximized
        Form22.Dock = DockStyle.Fill
        XtraTabPage2.Controls.Add(Form22)
        Form22.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TabControlMain.SelectedTabPageIndex = 2
        Form5.TopLevel = False
        Form5.FormBorderStyle = FormBorderStyle.None
        Form5.WindowState = FormWindowState.Maximized
        Form5.Dock = DockStyle.Fill
        XtraTabPage3.Controls.Add(Form5)
        Form5.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TabControlMain.SelectedTabPageIndex = 3
        Form3.TopLevel = False
        Form3.FormBorderStyle = FormBorderStyle.None
        Form3.WindowState = FormWindowState.Maximized
        Form3.Dock = DockStyle.Fill
        XtraTabPage4.Controls.Add(Form3)
        Form3.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TabControlMain.SelectedTabPageIndex = 4
        Form4.TopLevel = False
        Form4.FormBorderStyle = FormBorderStyle.None
        Form4.WindowState = FormWindowState.Maximized
        Form4.Dock = DockStyle.Fill
        XtraTabPage5.Controls.Add(Form4)
        Form4.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        TabControlMain.SelectedTabPageIndex = 5
        Form6.TopLevel = False
        Form6.FormBorderStyle = FormBorderStyle.None
        Form4.WindowState = FormWindowState.Maximized
        Form6.Dock = DockStyle.Fill
        XtraTabPage6.Controls.Add(Form6)
        Form6.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        TabControlMain.SelectedTabPageIndex = 6
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TabControlMain.SelectedTabPageIndex = 7
        Form7.TopLevel = False
        Form7.FormBorderStyle = FormBorderStyle.None
        Form7.WindowState = FormWindowState.Maximized
        Form7.Dock = DockStyle.Fill
        XtraTabPage8.Controls.Add(Form7)
        Form7.Show()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        TabControlMain.SelectedTabPageIndex = 8
        Form10.TopLevel = False
        Form10.FormBorderStyle = FormBorderStyle.None
        Form10.WindowState = FormWindowState.Maximized
        Form10.Dock = DockStyle.Fill
        XtraTabPage9.Controls.Add(Form10)
        Form10.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        TabControlMain.SelectedTabPageIndex = 9
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        'ตั้งค่า
        TabControlMain.SelectedTabPageIndex = 10
        Form8.TopLevel = False
        Form8.FormBorderStyle = FormBorderStyle.None
        Form8.WindowState = FormWindowState.Maximized
        Form8.Dock = DockStyle.Fill
        XtraTabPage11.Controls.Add(Form8)
        Form8.Show()

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        TabControlMain.SelectedTabPageIndex = 11
    End Sub

    Private Sub BtnCloseShift_Click(sender As Object, e As EventArgs) Handles BtnCloseShift.Click
        Using plexi = New Form()
            plexi.FormBorderStyle = FormBorderStyle.None
            plexi.Bounds = Screen.FromPoint(Form17.Location).Bounds
            plexi.StartPosition = FormStartPosition.Manual
            plexi.AutoScaleMode = AutoScaleMode.None
            plexi.ShowInTaskbar = False
            plexi.BackColor = Color.Black
            plexi.Opacity = 0.2
            plexi.Show()
            Form17.ShowDialog(plexi)
        End Using
    End Sub
End Class