Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        XtraTabMain.SelectedTabPageIndex = 0
        Button6.ForeColor = Color.FromArgb(45, 149, 239)
        Panel23.Visible = True
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        Form9_1.TopLevel = False
        Form9_1.FormBorderStyle = FormBorderStyle.None
        Form9_1.WindowState = FormWindowState.Maximized
        Form9_1.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Form9_1)
        Form9_1.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        XtraTabMain.SelectedTabPageIndex = 0
        Button6.ForeColor = Color.FromArgb(45, 149, 239)
        Panel23.Visible = True
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        Form9_1.TopLevel = False
        Form9_1.FormBorderStyle = FormBorderStyle.None
        Form9_1.WindowState = FormWindowState.Maximized
        Form9_1.Dock = DockStyle.Fill
        XtraTabPage1.Controls.Add(Form9_1)
        Form9_1.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        XtraTabMain.SelectedTabPageIndex = 1
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Panel23.Visible = False
        Label1.ForeColor = Color.FromArgb(45, 149, 239)
        Panel7.Visible = True
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        Form9_2.TopLevel = False
        Form9_2.FormBorderStyle = FormBorderStyle.None
        Form9_2.WindowState = FormWindowState.Maximized
        Form9_2.Dock = DockStyle.Fill
        XtraTabPage2.Controls.Add(Form9_2)
        Form9_2.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        XtraTabMain.SelectedTabPageIndex = 2
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Panel23.Visible = False
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(45, 149, 239)
        Panel12.Visible = True
        Label3.ForeColor = Color.FromArgb(65, 73, 86)
        Panel17.Visible = False

        Form9_3.TopLevel = False
        Form9_3.FormBorderStyle = FormBorderStyle.None
        Form9_3.WindowState = FormWindowState.Maximized
        Form9_3.Dock = DockStyle.Fill
        XtraTabPage3.Controls.Add(Form9_3)
        Form9_3.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        XtraTabMain.SelectedTabPageIndex = 3
        Button6.ForeColor = Color.FromArgb(65, 73, 86)
        Panel23.Visible = False
        Label1.ForeColor = Color.FromArgb(65, 73, 86)
        Panel7.Visible = False
        Label2.ForeColor = Color.FromArgb(65, 73, 86)
        Panel12.Visible = False
        Label3.ForeColor = Color.FromArgb(45, 149, 239)
        Panel17.Visible = True

        Form9_4.TopLevel = False
        Form9_4.FormBorderStyle = FormBorderStyle.None
        Form9_4.WindowState = FormWindowState.Maximized
        Form9_4.Dock = DockStyle.Fill
        XtraTabPage4.Controls.Add(Form9_4)
        Form9_4.Show()
    End Sub

End Class