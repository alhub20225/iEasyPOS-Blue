Module ModuleTaxV2
    Sub LoadTax()
        'loadData Tax 
        FrmManageTaxV2.Dg_Tax.Rows.Clear()
        Dim DataTax As DataTable = executesql("SELECT TaxId,TaxName,Multiply FROM Tax WHERE Active=1 ORDER BY Taxid ASC")
        Dim RowsDataTax As Integer = DataTax.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataTax - 1
            Dim TaxName As String = DataTax(i)("TaxName")
            Dim TaxId As Integer = DataTax(i)("TaxId")
            Dim Multiply As Decimal = DataTax(i)("Multiply")
            FrmManageTaxV2.Dg_Tax.Rows.Add(TaxName, Multiply, TaxId)
        Next

        ClearData()
    End Sub
    Sub ClearData()
        FrmManageTaxV2.TxtnameTax.Clear()
        FrmManageTaxV2.NumerricMultiply.Value = 0
        FrmManageTaxV2.TaxIdSend = 0
    End Sub
    Sub SaveTax()
        If FrmManageTaxV2.TxtnameTax.Text = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Insert To tax
        Dim TaxName As String = FrmManageTaxV2.TxtnameTax.Text
        Dim Multiply As Decimal = FrmManageTaxV2.NumerricMultiply.Value
        executesql("INSERT INTO Tax(TaxName,Multiply,Active) VALUES('" & TaxName & "','" & Multiply & "','1')")
        LoadTax()
        ModuleTax.LoadTax()
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

    End Sub
    Sub CellClickDataGridView()
        'Load Detail Tax 
        Dim DataDetailTax As DataTable = executesql("SELECT TaxName,Multiply FROM Tax WHERE TaxId='" & FrmManageTaxV2.TaxIdSend & "' AND Active=1")
        FrmManageTaxV2.TxtnameTax.Text = DataDetailTax(0)("TaxName")
        FrmManageTaxV2.NumerricMultiply.Value = DataDetailTax(0)("Multiply")
    End Sub
    Sub UpdateTax()

        'Update Tax 
        If FrmManageTaxV2.TxtnameTax.Text = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Check TaxName 
        Dim CheckDataTaxname As DataTable = executesql("SELECT TaxId FROM Tax WHERE TaxName='" & FrmManageTaxV2.TxtnameTax.Text & "' AND Active=1")
        If CheckDataTaxname.Rows.Count > 0 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "ข้อมูลซ้ำ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Update Tax 
        Dim TaxId As Integer = FrmManageTaxV2.TaxIdSend
        Dim TaxName As String = FrmManageTaxV2.TxtnameTax.Text
        Dim Multiply As Decimal = FrmManageTaxV2.NumerricMultiply.Value
        executesql("UPDATE Tax SET Taxname='" & TaxName & "',Multiply='" & Multiply & "' WHERE TaxId='" & TaxId & "'")
        LoadTax()
        ModuleTax.LoadTax()
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

    End Sub
    Sub Deletetax()
        'Deletetax
        If FrmManageTaxV2.TaxIdSend = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกข้อมูลก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        executesql("UPDATE Tax SET Active=0 WHERE TaxId='" & FrmManageTaxV2.TaxIdSend & "'")
        FrmManageTaxV2.TaxIdSend = 0
        LoadTax()
        ModuleTax.LoadTax()
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "ลบข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

    End Sub
End Module
