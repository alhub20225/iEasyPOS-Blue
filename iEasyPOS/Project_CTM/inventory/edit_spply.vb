Public Class edit_spply
    Private Sub edit_spply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmManageSupplier.TopLevel = False
        Panel1.Controls.Add(FrmManageSupplier)
        FrmManageSupplier.Show()
    End Sub

    Private Sub cloes_edit_supply_Click(sender As Object, e As EventArgs) Handles cloes_edit_supply.Click
        ModuleInventory.LoadSupplier()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class