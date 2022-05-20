Public Class EditFrmItem
    Public Sub BtnEditTax()
        FrmManageTax.TopLevel = False
        Panel1.Controls.Add(FrmManageTax)
        FrmManageTax.Show()
        FrmUnit.Close()
    End Sub
    Public Sub BtnEditUnit()
        FrmUnit.TopLevel = False
        Panel1.Controls.Add(FrmUnit)
        FrmUnit.Show()
        FrmManageTax.Close()
    End Sub

End Class