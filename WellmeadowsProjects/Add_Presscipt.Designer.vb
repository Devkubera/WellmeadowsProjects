<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Presscipt
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.m_dosage = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.m_id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.m_desc = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pt_lastName = New System.Windows.Forms.TextBox()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.pt_id = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pt_firstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.m_method = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.m_endDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.m_startDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label14.Location = New System.Drawing.Point(700, 233)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(213, 24)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "ปริมาณยาที่ผู้ป่วยได้รับต่อวัน"
        '
        'm_dosage
        '
        Me.m_dosage.Location = New System.Drawing.Point(704, 271)
        Me.m_dosage.Name = "m_dosage"
        Me.m_dosage.Size = New System.Drawing.Size(142, 20)
        Me.m_dosage.TabIndex = 152
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(700, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 24)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "ชื่อยา"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(704, 204)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(142, 20)
        Me.m_name.TabIndex = 150
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(530, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 24)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "หมายเลขยา"
        '
        'm_id
        '
        Me.m_id.Location = New System.Drawing.Point(534, 204)
        Me.m_id.Name = "m_id"
        Me.m_id.Size = New System.Drawing.Size(143, 20)
        Me.m_id.TabIndex = 148
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(530, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 24)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "รายละเอียดการรักษา"
        '
        'm_desc
        '
        Me.m_desc.Location = New System.Drawing.Point(534, 428)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(313, 96)
        Me.m_desc.TabIndex = 146
        Me.m_desc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(263, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "นามสกุล"
        '
        'pt_lastName
        '
        Me.pt_lastName.Location = New System.Drawing.Point(267, 271)
        Me.pt_lastName.Name = "pt_lastName"
        Me.pt_lastName.Size = New System.Drawing.Size(142, 20)
        Me.pt_lastName.TabIndex = 129
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lable1.Location = New System.Drawing.Point(84, 163)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(115, 24)
        Me.Lable1.TabIndex = 124
        Me.Lable1.Text = "หมายเลขผู้ป่วย"
        '
        'pt_id
        '
        Me.pt_id.Location = New System.Drawing.Point(88, 201)
        Me.pt_id.Name = "pt_id"
        Me.pt_id.Size = New System.Drawing.Size(142, 20)
        Me.pt_id.TabIndex = 123
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(818, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 122
        Me.btnAdd.Text = "เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(727, 30)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 121
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 29)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "เพิ่มข้อมูลการให้ยา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(84, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 24)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "ชื่อ"
        '
        'pt_firstName
        '
        Me.pt_firstName.Location = New System.Drawing.Point(88, 271)
        Me.pt_firstName.Name = "pt_firstName"
        Me.pt_firstName.Size = New System.Drawing.Size(142, 20)
        Me.pt_firstName.TabIndex = 154
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "ผู้ป่วย"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 25)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "ข้อมูลยา"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(531, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 24)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "วิธีการให้ยากับผู้ป่วย"
        '
        'm_method
        '
        Me.m_method.FormattingEnabled = True
        Me.m_method.Items.AddRange(New Object() {"Oral", "Skin"})
        Me.m_method.Location = New System.Drawing.Point(535, 270)
        Me.m_method.Name = "m_method"
        Me.m_method.Size = New System.Drawing.Size(142, 21)
        Me.m_method.TabIndex = 160
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(701, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 24)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "วันที่ให้ยาครบตามที่แพทย์สั่ง"
        '
        'm_endDate
        '
        Me.m_endDate.Location = New System.Drawing.Point(705, 347)
        Me.m_endDate.Name = "m_endDate"
        Me.m_endDate.Size = New System.Drawing.Size(142, 20)
        Me.m_endDate.TabIndex = 163
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(531, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "วันที่เริ่มให้ยา"
        '
        'm_startDate
        '
        Me.m_startDate.Location = New System.Drawing.Point(535, 347)
        Me.m_startDate.Name = "m_startDate"
        Me.m_startDate.Size = New System.Drawing.Size(143, 20)
        Me.m_startDate.TabIndex = 161
        '
        'Add_Presscipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.m_endDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.m_startDate)
        Me.Controls.Add(Me.m_method)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pt_firstName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.m_dosage)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.m_name)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.m_id)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.m_desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pt_lastName)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.pt_id)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Presscipt"
        Me.Text = "Add_Presscipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents m_dosage As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents m_name As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents m_id As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents m_desc As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pt_lastName As TextBox
    Friend WithEvents Lable1 As Label
    Friend WithEvents pt_id As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pt_firstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents m_method As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents m_endDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents m_startDate As TextBox
End Class
