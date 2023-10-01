<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Medicine
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.m_dosage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.m_unit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.m_scale = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.m_stock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.m_method = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m_desc = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.m_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_Edit_Med = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.View_Edit_Med, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(72, 424)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 29)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "ปริมาณ(Dosage)"
        '
        'm_dosage
        '
        Me.m_dosage.Location = New System.Drawing.Point(77, 471)
        Me.m_dosage.Margin = New System.Windows.Forms.Padding(4)
        Me.m_dosage.Name = "m_dosage"
        Me.m_dosage.Size = New System.Drawing.Size(188, 22)
        Me.m_dosage.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(371, 330)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 29)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "ราคาต่อชิ้น"
        '
        'm_unit
        '
        Me.m_unit.Location = New System.Drawing.Point(376, 376)
        Me.m_unit.Margin = New System.Windows.Forms.Padding(4)
        Me.m_unit.Name = "m_unit"
        Me.m_unit.Size = New System.Drawing.Size(188, 22)
        Me.m_unit.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(72, 331)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 29)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "ระดับการสั่งซื้อในแต่ละครั้ง"
        '
        'm_scale
        '
        Me.m_scale.Location = New System.Drawing.Point(77, 378)
        Me.m_scale.Margin = New System.Windows.Forms.Padding(4)
        Me.m_scale.Name = "m_scale"
        Me.m_scale.Size = New System.Drawing.Size(188, 22)
        Me.m_scale.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(371, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 29)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "จำนวนในสต็อก"
        '
        'm_stock
        '
        Me.m_stock.Location = New System.Drawing.Point(376, 274)
        Me.m_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.m_stock.Name = "m_stock"
        Me.m_stock.Size = New System.Drawing.Size(188, 22)
        Me.m_stock.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(72, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 29)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "วิธีการให้ยากับผู้ป่วย"
        '
        'm_method
        '
        Me.m_method.FormattingEnabled = True
        Me.m_method.Items.AddRange(New Object() {"Oral", "Skin"})
        Me.m_method.Location = New System.Drawing.Point(77, 273)
        Me.m_method.Margin = New System.Windows.Forms.Padding(4)
        Me.m_method.Name = "m_method"
        Me.m_method.Size = New System.Drawing.Size(188, 24)
        Me.m_method.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(72, 508)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 29)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "คำอธิบายเกี่ยวกับตัวยา"
        '
        'm_desc
        '
        Me.m_desc.Location = New System.Drawing.Point(77, 559)
        Me.m_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(487, 122)
        Me.m_desc.TabIndex = 70
        Me.m_desc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(371, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 29)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "ชื่อยา"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(376, 176)
        Me.m_name.Margin = New System.Windows.Forms.Padding(4)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(188, 22)
        Me.m_name.TabIndex = 68
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(72, 130)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(120, 29)
        Me.lableSearch.TabIndex = 65
        Me.lableSearch.Text = "หมายเลขยา"
        '
        'm_Id
        '
        Me.m_Id.Location = New System.Drawing.Point(77, 177)
        Me.m_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.m_Id.Name = "m_Id"
        Me.m_Id.Size = New System.Drawing.Size(188, 22)
        Me.m_Id.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 36)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "แก้ไขข้อมูลเวชภัณฑ์"
        '
        'View_Edit_Med
        '
        Me.View_Edit_Med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Edit_Med.Location = New System.Drawing.Point(647, 130)
        Me.View_Edit_Med.Name = "View_Edit_Med"
        Me.View_Edit_Med.RowHeadersWidth = 51
        Me.View_Edit_Med.RowTemplate.Height = 24
        Me.View_Edit_Med.Size = New System.Drawing.Size(548, 551)
        Me.View_Edit_Med.TabIndex = 82
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1035, 44)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 46)
        Me.btnAdd.TabIndex = 83
        Me.btnAdd.Text = "แก้ไขข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Edit_Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 757)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.View_Edit_Med)
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
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.m_Id)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Medicine"
        Me.Text = "Edit_Medicine"
        CType(Me.View_Edit_Med, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents m_dosage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents m_unit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents m_scale As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents m_stock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents m_method As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents m_desc As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents m_name As TextBox
    Friend WithEvents lableSearch As Label
    Friend WithEvents m_Id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents View_Edit_Med As DataGridView
    Friend WithEvents btnAdd As Button
End Class
