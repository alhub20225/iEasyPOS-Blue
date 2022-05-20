Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        DaterimePickerSrcStart.Text = "เลือกวันที่"
        DaterimePickerSrcEnd.Text = "เลือกวันที่"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        XtraTabMain.SelectedTabPageIndex = 0
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        XtraTabMain.SelectedTabPageIndex = 1
    End Sub

End Class