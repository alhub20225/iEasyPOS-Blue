Public Class FrmQRPayment
    Private Sub FrmQRPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabControl1.ShowTabHeader = False
        Dim Qr_Code As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Dim TotalPrice As Decimal = POS.txtSubTotal.Text
        'FrmHome.txtTotalQrThai.Text = TotalPrice
        Dim DataQRCode As DataTable = ModuleQrPayment.ThaiQr(TotalPrice)
        'If IsNothing(DataQRCode) Then
        '    'ModuleKiosk.backHome()
        '    Exit Sub
        'End If
        'If IsDBNull(DataQRCode(0)("QRcode")) Then
        '    'ModuleKiosk.backHome()
        '    Exit Sub
        'End If
        PictureBoxQR.BackgroundImage = Nothing
        PictureBoxQR.BackgroundImage = Qr_Code.Encode(DataQRCode(0)("QRcode"))
        'TimeOut.Start()
    End Sub
End Class