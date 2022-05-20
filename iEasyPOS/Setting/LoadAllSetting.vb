Module LoadAllSetting
    Public SettingList As New Settings
    Sub LoadSetting()
        Dim AllSetting As DataTable = executesql("SELECT SettingId,SettingValue From Setting where Active=1")

        SettingList.PrinterReceipt = AllSetting(0)("SettingValue")
        SettingList.ReceiptHeader1 = AllSetting(1)("SettingValue")
        SettingList.ReceiptHeader2 = AllSetting(2)("SettingValue")
        SettingList.ReceiptFooter1 = AllSetting(3)("SettingValue")
        SettingList.ReceiptFooter1 = AllSetting(4)("SettingValue")
        SettingList.AlwaysPrintReceipt = AllSetting(5)("SettingValue")
        SettingList.ShowBranchAddress = AllSetting(6)("SettingValue")
        SettingList.UsePosTable = AllSetting(7)("SettingValue")
        SettingList.PosImge = AllSetting(8)("SettingValue")
    End Sub
End Module
