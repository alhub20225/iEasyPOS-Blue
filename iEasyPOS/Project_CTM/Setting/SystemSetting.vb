Public Class SystemSetting
    Dim GetSetting As DataTable = executesql("SELECT SettingValue From Setting")
    Private Sub HardSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        If GetSetting(7)("SettingValue") = 1 Then
            CheckUseTable.CheckState = CheckState.Checked
        Else
            CheckUseTable.Checked = CheckState.Unchecked
        End If
        LoadPrinter()
        ReceipText()
    End Sub
    Sub LoadPrinter()
        DropDownPrinterName.Items.Clear()
        Dim i As Integer
        Dim RecieptPrinter As String
        For i = 0 To System.Drawing.Printing.PrinterSettings.
          InstalledPrinters.Count - 1
            RecieptPrinter = System.Drawing.Printing.PrinterSettings.
              InstalledPrinters.Item(i)
            DropDownPrinterName.Items.Add(RecieptPrinter)
        Next

        Dim GetPrinterName As DataTable = executesql("Select SettingValue From Setting Where SettingId=1")
        DropDownPrinterName.Text = GetPrinterName(0)("SettingValue")

        Dim GetPrintOption As DataTable = executesql("Select SettingValue From Setting Where SettingId=6")
        If GetPrintOption(0)("SettingValue") = 1 Then
            CheckBoxPrintOption.CheckState = CheckState.Checked
        Else CheckBoxPrintOption.CheckState = CheckState.Unchecked
        End If

    End Sub


    Private Sub BtnSaveReceipText_Click(sender As Object, e As EventArgs) Handles BtnSaveReceipText.Click
        executesql("Update Setting Set SettingValue='" & txtHeader1.Text & "' Where SettingId=2")
        executesql("Update Setting Set SettingValue='" & txtHeader2.Text & "' Where SettingId=3")
        executesql("Update Setting Set SettingValue='" & txtFooter1.Text & "' Where SettingId=4")
        executesql("Update Setting Set SettingValue='" & txtFooter2.Text & "' Where SettingId=5")



        executesql("Update Setting Set SettingValue='" & DropDownPrinterName.Text & "' Where SettingId=1")

        executesql("Update Setting Set SettingValue='" & CheckBoxPrintOption.CheckState & "' Where SettingId=6")

        executesql("Update Setting Set SettingValue='" & CheckUseTable.CheckState & "' Where SettingId=8")

        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False


        ReceipText()

    End Sub
    Sub ReceipText()

        Dim GetHeader1 As DataTable = executesql("Select SettingValue From Setting Where SettingId=2")
        txtHeader1.Text = GetHeader1(0)("SettingValue")

        Dim GetHeader2 As DataTable = executesql("Select SettingValue From Setting Where SettingId=3")
        txtHeader2.Text = GetHeader2(0)("SettingValue")

        Dim GetFooter1 As DataTable = executesql("Select SettingValue From Setting Where SettingId=4")
        txtFooter1.Text = GetFooter1(0)("SettingValue")

        Dim GetFooter2 As DataTable = executesql("Select SettingValue From Setting Where SettingId=5")
        txtFooter2.Text = GetFooter2(0)("SettingValue")
    End Sub


End Class