<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_payment_delivery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_payment_delivery))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancle = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRobinhood = New System.Windows.Forms.Button()
        Me.btnLineman = New System.Windows.Forms.Button()
        Me.BtnGrabFood = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 36)
        Me.Panel1.TabIndex = 149
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(145, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 31)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "เลือกการชำระเงิน"
        '
        'BtnCancle
        '
        Me.BtnCancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnCancle.FlatAppearance.BorderSize = 0
        Me.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancle.Font = New System.Drawing.Font("Kanit", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancle.ForeColor = System.Drawing.Color.White
        Me.BtnCancle.Location = New System.Drawing.Point(151, 250)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(119, 42)
        Me.BtnCancle.TabIndex = 150
        Me.BtnCancle.Text = "ยกเลิก"
        Me.BtnCancle.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(50, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 66)
        Me.Button1.TabIndex = 148
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnRobinhood
        '
        Me.btnRobinhood.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnRobinhood.BackgroundImage = CType(resources.GetObject("btnRobinhood.BackgroundImage"), System.Drawing.Image)
        Me.btnRobinhood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRobinhood.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRobinhood.FlatAppearance.BorderSize = 2
        Me.btnRobinhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRobinhood.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRobinhood.ForeColor = System.Drawing.Color.White
        Me.btnRobinhood.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRobinhood.Location = New System.Drawing.Point(293, 76)
        Me.btnRobinhood.Name = "btnRobinhood"
        Me.btnRobinhood.Size = New System.Drawing.Size(84, 66)
        Me.btnRobinhood.TabIndex = 147
        Me.btnRobinhood.UseVisualStyleBackColor = False
        '
        'btnLineman
        '
        Me.btnLineman.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnLineman.BackgroundImage = CType(resources.GetObject("btnLineman.BackgroundImage"), System.Drawing.Image)
        Me.btnLineman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLineman.FlatAppearance.BorderSize = 0
        Me.btnLineman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLineman.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLineman.ForeColor = System.Drawing.Color.White
        Me.btnLineman.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLineman.Location = New System.Drawing.Point(173, 76)
        Me.btnLineman.Name = "btnLineman"
        Me.btnLineman.Size = New System.Drawing.Size(84, 66)
        Me.btnLineman.TabIndex = 146
        Me.btnLineman.UseVisualStyleBackColor = False
        '
        'BtnGrabFood
        '
        Me.BtnGrabFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BtnGrabFood.BackgroundImage = CType(resources.GetObject("BtnGrabFood.BackgroundImage"), System.Drawing.Image)
        Me.BtnGrabFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGrabFood.FlatAppearance.BorderSize = 0
        Me.BtnGrabFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabFood.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGrabFood.ForeColor = System.Drawing.Color.White
        Me.BtnGrabFood.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnGrabFood.Location = New System.Drawing.Point(50, 76)
        Me.BtnGrabFood.Name = "BtnGrabFood"
        Me.BtnGrabFood.Size = New System.Drawing.Size(84, 66)
        Me.BtnGrabFood.TabIndex = 145
        Me.BtnGrabFood.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(173, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 66)
        Me.Button2.TabIndex = 151
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_payment_delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 317)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRobinhood)
        Me.Controls.Add(Me.btnLineman)
        Me.Controls.Add(Me.BtnGrabFood)
        Me.Controls.Add(Me.BtnCancle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_payment_delivery"
        Me.Text = "frm_payment_delivery"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRobinhood As Button
    Friend WithEvents btnLineman As Button
    Friend WithEvents BtnGrabFood As Button
    Friend WithEvents BtnCancle As Button
    Friend WithEvents Button2 As Button
End Class
