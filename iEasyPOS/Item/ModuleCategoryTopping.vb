Module ModuleCategoryTopping
    Dim CateToppingId As Integer
    Sub loadCateTopping()
        FrmCategoryTopping.FlowLayoutPanelCateTopping.Controls.Clear()
        Dim selectCateTopping As DataTable = executesql("SELECT * FROM CategoryTopping")
        If IsNothing(selectCateTopping) Then
            Exit Sub
        ElseIf selectCateTopping.Rows.Count = 0 Then
            Exit Sub
        End If

        For i As Integer = 0 To selectCateTopping.Rows.Count - 1
            Dim btnCateTopping As New DevExpress.XtraEditors.SimpleButton
            btnCateTopping.Text = selectCateTopping(i)("CategoryToppingName")
            btnCateTopping.Name = selectCateTopping(i)("CategoryToppingId")
            btnCateTopping.LookAndFeel.SkinMaskColor = Color.FromArgb(45, 149, 239)
            btnCateTopping.Size = New System.Drawing.Size(185, 60)
            btnCateTopping.Font = New Font("Kanit", 12, FontStyle.Bold)
            btnCateTopping.ForeColor = Color.White
            btnCateTopping.LookAndFeel.SkinName = "Office 2019 Colorful"
            btnCateTopping.LookAndFeel.UseDefaultLookAndFeel = False
            btnCateTopping.Cursor = Cursors.Hand
            FrmCategoryTopping.FlowLayoutPanelCateTopping.Controls.Add(btnCateTopping)
            AddHandler btnCateTopping.Click, AddressOf getBtnCategoryTopping
        Next
    End Sub
    Sub getBtnCategoryTopping(sender As Object, e As EventArgs)
        CateToppingId = sender.Name
        Dim selectCategory As DataTable = executesql("SELECT * FROM CategoryTopping WHERE CategoryToppingId='" & CateToppingId & "'")
        FrmCategoryTopping.txtCode.Text = selectCategory(0)("CateToppingCode")
        FrmCategoryTopping.txtName.Text = selectCategory(0)("CategoryToppingName")
        FrmCategoryTopping.txtName2.Text = selectCategory(0)("CategoryToppingName2")
        FrmCategoryTopping.NumericUpDownMaxNumber.Value = selectCategory(0)("NumberToppingCode")
        FrmCategoryTopping.RadDropDownPrinter.Text = selectCategory(0)("PrinterName")
    End Sub
    Sub LoadPrinter()
        Dim i As Integer
        Dim ItemPrinter As String
        For i = 0 To System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count - 1
            ItemPrinter = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Item(i)
            FrmCategoryTopping.RadDropDownPrinter.Properties.Items.Add(ItemPrinter)
        Next
    End Sub
    Sub AddCategoryTopping()
        Dim NameCateTopping As String = FrmCategoryTopping.txtName.Text
        Dim NameENCateTopping As String = FrmCategoryTopping.txtName2.Text
        Dim ToppingCode As String = FrmCategoryTopping.txtCode.Text
        Dim Printer As String = FrmCategoryTopping.RadDropDownPrinter.Text
        Dim NumberToppingCode As Integer = FrmCategoryTopping.NumericUpDownMaxNumber.Value
        'Check Validatetion
        If NameCateTopping = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If NameENCateTopping = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ToppingCode = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Printer = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If NumberToppingCode <= 0 Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
        Dim userId As Integer = Frm_Login.UserId
        If CateToppingId = 0 Then
            'insert Cate Topping
            Dim checkCodeValidate As DataTable = executesql("SELECT * FROM CategoryTopping WHERE CateToppingCode ='" & ToppingCode & "'")
            If checkCodeValidate.Rows.Count > 0 Then
                MsgBox("รหัสหมวดหมู่ซ้ำ !!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            executesql("INSERT INTO CategoryTopping(CategoryToppingName,CategoryToppingName2,CateToppingCode,NumberToppingCode,InsertDate,UserId,PrinterName) VALUES('" & NameCateTopping & "','" & NameENCateTopping & "','" & ToppingCode & "','" & NumberToppingCode & "','" & InsertDate & "','" & userId & "','" & Printer & "')")
        Else
            'insert Cate Topping
            executesql("UPDATE CategoryTopping SET CategoryToppingName='" & NameCateTopping & "',CategoryToppingName2='" & NameENCateTopping & "',CateToppingCode='" & ToppingCode & "',NumberToppingCode='" & NumberToppingCode & "',UpdateDate='" & InsertDate & "',UserId='" & userId & "',PrinterName='" & Printer & "' WHERE CategoryToppingId='" & CateToppingId & "'")
        End If
        loadCateTopping()
        ClearData()
    End Sub
    Sub btndelete()
        If CateToppingId = 0 Then
            MsgBox("กรุณาเลือกรายการที่ต้องการลบ", MsgBoxStyle.Critical)
            Exit Sub
        Else
            executesql("DELETE FROM CategoryTopping WHERE CategoryToppingId='" & CateToppingId & "'")
        End If
        loadCateTopping()
        ClearData()
    End Sub
    Sub ClearData()
        CateToppingId = 0
        FrmCategoryTopping.txtName.Clear()
        FrmCategoryTopping.txtName2.Clear()
        FrmCategoryTopping.txtCode.Clear()
        FrmCategoryTopping.RadDropDownPrinter.Text = ""
    End Sub
End Module
