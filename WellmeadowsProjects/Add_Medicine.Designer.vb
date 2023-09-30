<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Medicine
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.m_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
        Me.m_desc = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m_method = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.m_stock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.m_unit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.m_scale = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.m_dosage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(840, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.Text = "เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(749, 28)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(330, 101)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(93, 24)
        Me.lableSearch.TabIndex = 37
        Me.lableSearch.Text = "หมายเลขยา"
        '
        'm_Id
        '
        Me.m_Id.Location = New System.Drawing.Point(334, 139)
        Me.m_Id.Name = "m_Id"
        Me.m_Id.Size = New System.Drawing.Size(142, 20)
        Me.m_Id.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(396, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 29)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "เพิ่มข้อมูลเวชภัณฑ์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(554, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "ชื่อยา"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(558, 138)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(142, 20)
        Me.m_name.TabIndex = 49
        '
        'm_desc
        '
        Me.m_desc.Location = New System.Drawing.Point(334, 449)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(366, 100)
        Me.m_desc.TabIndex = 51
        Me.m_desc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(330, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "คำอธิบายเกี่ยวกับตัวยา"
        '
        'm_method
        '
        Me.m_method.FormattingEnabled = True
        Me.m_method.Items.AddRange(New Object() {"Oral", "Skin"})
        Me.m_method.Location = New System.Drawing.Point(334, 217)
        Me.m_method.Name = "m_method"
        Me.m_method.Size = New System.Drawing.Size(142, 21)
        Me.m_method.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(330, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 24)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "วิธีการให้ยากับผู้ป่วย"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(554, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "จำนวนในสต็อก"
        '
        'm_stock
        '
        Me.m_stock.Location = New System.Drawing.Point(558, 218)
        Me.m_stock.Name = "m_stock"
        Me.m_stock.Size = New System.Drawing.Size(142, 20)
        Me.m_stock.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(554, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 24)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "ราคาต่อชิ้น"
        '
        'm_unit
        '
        Me.m_unit.Location = New System.Drawing.Point(558, 301)
        Me.m_unit.Name = "m_unit"
        Me.m_unit.Size = New System.Drawing.Size(142, 20)
        Me.m_unit.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(330, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 24)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "ระดับการสั่งซื้อในแต่ละครั้ง"
        '
        'm_scale
        '
        Me.m_scale.Location = New System.Drawing.Point(334, 302)
        Me.m_scale.Name = "m_scale"
        Me.m_scale.Size = New System.Drawing.Size(142, 20)
        Me.m_scale.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(330, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 24)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "ปริมาณ(Dosage)"
        '
        'm_dosage
        '
        Me.m_dosage.Location = New System.Drawing.Point(334, 378)
        Me.m_dosage.Name = "m_dosage"
        Me.m_dosage.Size = New System.Drawing.Size(142, 20)
        Me.m_dosage.TabIndex = 61
        '
        'Add_Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.m_dosage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.m_unit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.m_scale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.m_stock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.m_method)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.m_desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.m_name)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.m_Id)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Medicine"
        Me.Text = "Add_Medicine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lableSearch As Label
    Friend WithEvents m_Id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents m_name As TextBox
    Friend WithEvents m_desc As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents m_method As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents m_stock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents m_unit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents m_scale As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents m_dosage As TextBox
End Class
