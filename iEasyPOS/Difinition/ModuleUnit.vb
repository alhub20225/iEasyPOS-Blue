Module ModuleUnit
    Sub ClearUnitData()
        'Clear Data in FrmUnit 
        FrmUnit.TxtUnitName.Clear()
        FrmUnit.TxtUnit.Text = 0
    End Sub
    Sub LoadDataUnit()
        'Load Data Unit 
        FrmUnit.Dg_ItemUnit.Rows.Clear()
        Dim DataUnit As DataTable = executesql("SELECT ItemUnitId,ItemUnitName,Multiply FROM ItemUnit WHERE Active=1")
        For i As Integer = 0 To DataUnit.Rows.Count - 1
            Dim ItemId As Integer = DataUnit(i)("ItemUnitId")
            Dim UnitName As String = DataUnit(i)("ItemUnitName")
            Dim Multiply As Decimal = DataUnit(i)("Multiply")
            FrmUnit.Dg_ItemUnit.Rows.Add(ItemId, UnitName, FormatNumber(Multiply, 2))
        Next
    End Sub
    Sub AddUnit()
        'Insert into Unit 
        Dim UnitName As String = FrmUnit.TxtUnitName.Text
        Dim multiply As Decimal = FrmUnit.TxtUnit.Text
        Dim Active As Integer = 1

        If UnitName = Nothing Or multiply = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        Else
            executesql("INSERT INTO ItemUnit(ItemUnitName,Multiply,Active) VALUES('" & UnitName & "','" & multiply & "','" & Active & "')")
            ClearUnitData()
            LoadDataUnit()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
    End Sub
    Sub UpdateUnit()
        'UpdateUnit 
        Dim UnitId As Integer = FrmUnit.SendUnitId
        Dim UnitName As String = FrmUnit.TxtUnitName.Text
        Dim UnitValue As Decimal = FrmUnit.TxtUnit.Text
        executesql("UPDATE ItemUnit SET ItemUnitName='" & UnitName & "',Multiply='" & UnitValue & "' WHERE ItemUnitId='" & UnitId & "' AND Active=1")
        ClearUnitData()
        LoadDataUnit()
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False
        Exit Sub
    End Sub
End Module
