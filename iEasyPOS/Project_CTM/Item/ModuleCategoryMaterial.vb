Module ModuleCategoryMaterial
    Dim cateMatId As Integer
    Sub loadData()
        CategoryMaterial.FlowLayoutPanelShowCategoryMaterial.Controls.Clear()

        Dim selectCategoryMaterial As DataTable = executesql("SELECT CategoryId,CategoryName FROM CategoryItem WHERE CateGroupId=2 AND Active=1")
        If IsNothing(selectCategoryMaterial) Then
            Exit Sub
        ElseIf selectCategoryMaterial.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectCategoryMaterial.Rows.Count - 1
            Dim btnCategoryMaterial As New Button
            btnCategoryMaterial.Text = selectCategoryMaterial(i)("CategoryName")
            btnCategoryMaterial.Name = selectCategoryMaterial(i)("CategoryId")
            btnCategoryMaterial.Height = 50
            btnCategoryMaterial.Width = 100
            CategoryMaterial.FlowLayoutPanelShowCategoryMaterial.Controls.Add(btnCategoryMaterial)
            AddHandler btnCategoryMaterial.Click, AddressOf getBtnCategoryMatId
        Next
        cateMatId = 0
    End Sub
    Sub clear()
        CategoryMaterial.txtCateMatId.Clear()
        CategoryMaterial.txtCateMatNameTH.Clear()
        CategoryMaterial.txtCateMatNameEN.Clear()
        CategoryMaterial.NumericUpDownMaxCateMateId.Value = 0
        cateMatId = 0
    End Sub
    Sub getBtnCategoryMatId(sender As Object, e As EventArgs)
        cateMatId = sender.Name

        Dim selectCategory As DataTable = executesql("SELECT CategoryName,CategoryName2,CateCode,NumberItemCode FROM CategoryItem WHERE CategoryId='" & cateMatId & "'")
        CategoryMaterial.txtCateMatId.Text = selectCategory(0)("CateCode")
        CategoryMaterial.txtCateMatNameTH.Text = selectCategory(0)("CategoryName")
        CategoryMaterial.txtCateMatNameEN.Text = selectCategory(0)("CategoryName2")
        CategoryMaterial.NumericUpDownMaxCateMateId.Value = selectCategory(0)("NumberItemCode")
    End Sub
    Sub btnSave()
        Dim table As String
        Dim field As String
        Dim value As String
        Dim where As String
        If CategoryMaterial.txtCateMatId.Text = "" Then
            MsgBox("กรุณากรอก Category Material Id", MsgBoxStyle.Critical)
            CategoryMaterial.txtCateMatId.Focus()
            Exit Sub
        End If
        If CategoryMaterial.txtCateMatNameTH.Text = "" Then
            MsgBox("กรุณากรอก Category Material Name", MsgBoxStyle.Critical)
            CategoryMaterial.txtCateMatNameTH.Focus()
            Exit Sub
        End If
        If CategoryMaterial.txtCateMatNameEN.Text = "" Then
            MsgBox("กรุณากรอก Category Material Name EN", MsgBoxStyle.Critical)
            CategoryMaterial.txtCateMatNameEN.Focus()
            Exit Sub
        End If
        If CategoryMaterial.NumericUpDownMaxCateMateId.Value = 0 Then
            MsgBox("กรุณากรอก Max Id", MsgBoxStyle.Critical)
            CategoryMaterial.NumericUpDownMaxCateMateId.Focus()
            Exit Sub
        End If
        If cateMatId = 0 Then

            Dim checkCategoryMaterialName As DataTable = executesql("SELECT CateCode FROM CategoryItem WHERE CateCode='" & CategoryMaterial.txtCateMatId.Text & "'")
            If checkCategoryMaterialName.Rows.Count > 0 Then
                If CategoryMaterial.txtCateMatId.Text = checkCategoryMaterialName(0)("CateCode") Then
                    MsgBox("มี Category Material Id ซ้ำ", MsgBoxStyle.Critical)
                    CategoryMaterial.txtCateMatId.Focus()
                    Exit Sub
                End If
            End If

            executesql("INSERT INTO CategoryItem(CategoryName,CategoryName2,CateCode,NumberItemCode,InsertDate,CateGroupId,Active,UserId,FontColor,BackGroundButton) VALUES('" & CategoryMaterial.txtCateMatNameTH.Text & "','" & CategoryMaterial.txtCateMatNameEN.Text & "','" & CategoryMaterial.txtCateMatId.Text & "','" & CategoryMaterial.NumericUpDownMaxCateMateId.Value & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','2','1','" & Frm_Login.UserId & "','-1','-16085761')")

            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)
            clear()
            loadData()
            Exit Sub
        Else

            executesql("UPDATE CategoryItem SET CategoryName='" & CategoryMaterial.txtCateMatNameTH.Text & "',CategoryName2='" & CategoryMaterial.txtCateMatNameEN.Text & "',CateCode='" & CategoryMaterial.txtCateMatId.Text & "',NumberItemCode='" & CategoryMaterial.NumericUpDownMaxCateMateId.Value & "',Updatedate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' WHERE CategoryId='" & cateMatId & "'")
            clear()
            loadData()
            Exit Sub
        End If
    End Sub
    Sub btnDelete()
        If cateMatId = 0 Then
            MsgBox("กรุณาเลือกรายการทึ่ต้องการลบ", MsgBoxStyle.Critical)
            Exit Sub
        Else
            executesql("UPDATE CategoryItem SET DeleteDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',DeleteUserId='" & Frm_Login.UserId & "',Active=0")
            clear()
            loadData()
            Exit Sub
        End If
    End Sub
End Module
