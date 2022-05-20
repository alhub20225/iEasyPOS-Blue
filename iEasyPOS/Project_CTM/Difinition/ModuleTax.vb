Module ModuleTax
    Sub LoadTax()
        'loadData Tax 
        FrmManageTax.Dg_Tax.Rows.Clear()
        Dim DataTax As DataTable = executesql("SELECT TaxId,TaxName,Multiply FROM Tax WHERE Active=1 ORDER BY Taxid ASC")
        Dim RowsDataTax As Integer = DataTax.Rows.Count
            Dim i As Integer
            For i = 0 To RowsDataTax - 1
                Dim TaxName As String = DataTax(i)("TaxName")
                Dim TaxId As Integer = DataTax(i)("TaxId")
                Dim Multiply As Decimal = DataTax(i)("Multiply")
                FrmManageTax.Dg_Tax.Rows.Add(TaxName, Multiply, TaxId)
            Next

        ClearData()
    End Sub
    Sub ClearData()
        FrmManageTax.TxtnameTax.Clear()
        FrmManageTax.NumerricMultiply.Value = 0
        FrmManageTax.TaxIdSend = 0
    End Sub
    Sub SaveTax()
        If FrmManageTax.TxtnameTax.Text = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Insert To tax
        Dim TaxName As String = FrmManageTax.TxtnameTax.Text
        Dim Multiply As Decimal = FrmManageTax.NumerricMultiply.Value
        executesql("INSERT INTO Tax(TaxName,Multiply,Active) VALUES('" & TaxName & "','" & Multiply & "','1')")
        LoadTax()
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

    End Sub
    Sub CellClickDataGridView()
        'Load Detail Tax 
        Dim DataDetailTax As DataTable = executesql("SELECT TaxName,Multiply FROM Tax WHERE TaxId='" & FrmManageTax.TaxIdSend & "' AND Active=1")
        FrmManageTax.TxtnameTax.Text = DataDetailTax(0)("TaxName")
        FrmManageTax.NumerricMultiply.Value = DataDetailTax(0)("Multiply")
    End Sub
    Sub UpdateTax()

        'Update Tax 
        If FrmManageTax.TxtnameTax.Text = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกข้อมูลให้ครบ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Check TaxName 
        Dim CheckDataTaxname As DataTable = executesql("SELECT TaxId FROM Tax WHERE TaxName='" & FrmManageTax.TxtnameTax.Text & "' AND Active=1")
        If CheckDataTaxname.Rows.Count > 0 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "ข้อมูลซ้ำ"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Update Tax 
        Dim TaxId As Integer = FrmManageTax.TaxIdSend
        Dim TaxName As String = FrmManageTax.TxtnameTax.Text
        Dim Multiply As Decimal = FrmManageTax.NumerricMultiply.Value
        executesql("UPDATE Tax SET Taxname='" & TaxName & "',Multiply='" & Multiply & "' WHERE TaxId='" & TaxId & "'")
        LoadTax()
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

    End Sub
    Sub Deletetax()
        'Deletetax
        If FrmManageTax.TaxIdSend = Nothing Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกข้อมูลก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        executesql("UPDATE Tax SET Active=0 WHERE TaxId='" & FrmManageTax.TaxIdSend & "'")
        FrmManageTax.TaxIdSend = 0
        LoadTax()
        Frm_Critical.Show()
        Frm_Critical.head_Label.Text = "ลบข้อมูลเรียบร้อย"
        Frm_Critical.Panel1.BackColor = Color.ForestGreen
        Frm_Critical.TableOkCancel.Visible = False

    End Sub
End Module
