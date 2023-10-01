<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim local_panel_clinicID As System.Windows.Forms.Label
        Dim local_clinic_id As System.Windows.Forms.TextBox
        Me.Add_panel = New System.Windows.Forms.Panel()
        Me.local_address = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.local_search_tel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.local_tel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.local_fullName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.kin_address = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.kin_fullName = New System.Windows.Forms.TextBox()
        Me.btnCheck_kin = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kin_tel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pt_address = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pt_date = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pt_status = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pt_tel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pt_lastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pt_gender = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pt_birthday = New System.Windows.Forms.TextBox()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.pt_firstName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        local_panel_clinicID = New System.Windows.Forms.Label()
        local_clinic_id = New System.Windows.Forms.TextBox()
        Me.Add_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'local_panel_clinicID
        '
        local_panel_clinicID.AutoSize = True
        local_panel_clinicID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        local_panel_clinicID.Location = New System.Drawing.Point(692, 548)
        local_panel_clinicID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        local_panel_clinicID.Name = "local_panel_clinicID"
        local_panel_clinicID.Size = New System.Drawing.Size(210, 29)
        local_panel_clinicID.TabIndex = 211
        local_panel_clinicID.Text = "หมายเลขประจำคลินิค"
        '
        'local_clinic_id
        '
        local_clinic_id.Location = New System.Drawing.Point(697, 595)
        local_clinic_id.Margin = New System.Windows.Forms.Padding(4)
        local_clinic_id.Name = "local_clinic_id"
        local_clinic_id.Size = New System.Drawing.Size(205, 22)
        local_clinic_id.TabIndex = 210
        '
        'Add_panel
        '
        Me.Add_panel.AutoScroll = True
        Me.Add_panel.Controls.Add(Me.local_address)
        Me.Add_panel.Controls.Add(local_panel_clinicID)
        Me.Add_panel.Controls.Add(local_clinic_id)
        Me.Add_panel.Controls.Add(Me.Button1)
        Me.Add_panel.Controls.Add(Me.Label16)
        Me.Add_panel.Controls.Add(Me.local_search_tel)
        Me.Add_panel.Controls.Add(Me.Label14)
        Me.Add_panel.Controls.Add(Me.local_tel)
        Me.Add_panel.Controls.Add(Me.Label12)
        Me.Add_panel.Controls.Add(Me.Label13)
        Me.Add_panel.Controls.Add(Me.local_fullName)
        Me.Add_panel.Controls.Add(Me.Label11)
        Me.Add_panel.Controls.Add(Me.kin_address)
        Me.Add_panel.Controls.Add(Me.Label10)
        Me.Add_panel.Controls.Add(Me.kin_fullName)
        Me.Add_panel.Controls.Add(Me.btnCheck_kin)
        Me.Add_panel.Controls.Add(Me.Label15)
        Me.Add_panel.Controls.Add(Me.kin_tel)
        Me.Add_panel.Controls.Add(Me.Label8)
        Me.Add_panel.Controls.Add(Me.pt_address)
        Me.Add_panel.Controls.Add(Me.Label6)
        Me.Add_panel.Controls.Add(Me.pt_date)
        Me.Add_panel.Controls.Add(Me.Label7)
        Me.Add_panel.Controls.Add(Me.pt_status)
        Me.Add_panel.Controls.Add(Me.Label5)
        Me.Add_panel.Controls.Add(Me.pt_tel)
        Me.Add_panel.Controls.Add(Me.Label2)
        Me.Add_panel.Controls.Add(Me.pt_lastName)
        Me.Add_panel.Controls.Add(Me.Label4)
        Me.Add_panel.Controls.Add(Me.pt_gender)
        Me.Add_panel.Controls.Add(Me.Label3)
        Me.Add_panel.Controls.Add(Me.pt_birthday)
        Me.Add_panel.Controls.Add(Me.Lable1)
        Me.Add_panel.Controls.Add(Me.pt_firstName)
        Me.Add_panel.Controls.Add(Me.btnAdd)
        Me.Add_panel.Controls.Add(Me.btnClear)
        Me.Add_panel.Controls.Add(Me.Label1)
        Me.Add_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Add_panel.Location = New System.Drawing.Point(0, 0)
        Me.Add_panel.Name = "Add_panel"
        Me.Add_panel.Size = New System.Drawing.Size(1339, 867)
        Me.Add_panel.TabIndex = 0
        '
        'local_address
        '
        Me.local_address.Location = New System.Drawing.Point(700, 775)
        Me.local_address.Margin = New System.Windows.Forms.Padding(4)
        Me.local_address.Name = "local_address"
        Me.local_address.Size = New System.Drawing.Size(415, 74)
        Me.local_address.TabIndex = 212
        Me.local_address.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(952, 486)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 46)
        Me.Button1.TabIndex = 209
        Me.Button1.Text = "ตรวจสอบ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label16.Location = New System.Drawing.Point(692, 463)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(194, 29)
        Me.Label16.TabIndex = 208
        Me.Label16.Text = "ตรวจสอบข้อมูลญาติ"
        '
        'local_search_tel
        '
        Me.local_search_tel.Location = New System.Drawing.Point(697, 510)
        Me.local_search_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.local_search_tel.Name = "local_search_tel"
        Me.local_search_tel.Size = New System.Drawing.Size(247, 22)
        Me.local_search_tel.TabIndex = 207
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label14.Location = New System.Drawing.Point(922, 548)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 29)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "เบอร์โทรศัพท์"
        '
        'local_tel
        '
        Me.local_tel.Location = New System.Drawing.Point(927, 595)
        Me.local_tel.Margin = New System.Windows.Forms.Padding(0)
        Me.local_tel.Name = "local_tel"
        Me.local_tel.Size = New System.Drawing.Size(188, 22)
        Me.local_tel.TabIndex = 205
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(693, 726)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 29)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "ที่อยู่"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(692, 640)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 29)
        Me.Label13.TabIndex = 203
        Me.Label13.Text = "ชื่อ - นามสกุล"
        '
        'local_fullName
        '
        Me.local_fullName.Location = New System.Drawing.Point(697, 684)
        Me.local_fullName.Margin = New System.Windows.Forms.Padding(4)
        Me.local_fullName.Name = "local_fullName"
        Me.local_fullName.Size = New System.Drawing.Size(415, 22)
        Me.local_fullName.TabIndex = 202
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(692, 309)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 29)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "ที่อยู่"
        '
        'kin_address
        '
        Me.kin_address.Location = New System.Drawing.Point(697, 359)
        Me.kin_address.Margin = New System.Windows.Forms.Padding(4)
        Me.kin_address.Name = "kin_address"
        Me.kin_address.Size = New System.Drawing.Size(415, 98)
        Me.kin_address.TabIndex = 149
        Me.kin_address.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(692, 227)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 29)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "ชื่อ"
        '
        'kin_fullName
        '
        Me.kin_fullName.Location = New System.Drawing.Point(697, 273)
        Me.kin_fullName.Margin = New System.Windows.Forms.Padding(4)
        Me.kin_fullName.Name = "kin_fullName"
        Me.kin_fullName.Size = New System.Drawing.Size(415, 22)
        Me.kin_fullName.TabIndex = 147
        '
        'btnCheck_kin
        '
        Me.btnCheck_kin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_kin.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_kin.Location = New System.Drawing.Point(952, 158)
        Me.btnCheck_kin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_kin.Name = "btnCheck_kin"
        Me.btnCheck_kin.Size = New System.Drawing.Size(160, 46)
        Me.btnCheck_kin.TabIndex = 146
        Me.btnCheck_kin.Text = "ตรวจสอบ"
        Me.btnCheck_kin.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(692, 135)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 29)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "ตรวจสอบข้อมูลญาติ"
        '
        'kin_tel
        '
        Me.kin_tel.Location = New System.Drawing.Point(697, 182)
        Me.kin_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.kin_tel.Name = "kin_tel"
        Me.kin_tel.Size = New System.Drawing.Size(247, 22)
        Me.kin_tel.TabIndex = 144
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(89, 510)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 29)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "ที่อยู่"
        '
        'pt_address
        '
        Me.pt_address.Location = New System.Drawing.Point(95, 560)
        Me.pt_address.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_address.Name = "pt_address"
        Me.pt_address.Size = New System.Drawing.Size(415, 117)
        Me.pt_address.TabIndex = 142
        Me.pt_address.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(316, 313)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 29)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "วันที่ลงทะเบียน"
        '
        'pt_date
        '
        Me.pt_date.Location = New System.Drawing.Point(321, 359)
        Me.pt_date.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_date.Name = "pt_date"
        Me.pt_date.Size = New System.Drawing.Size(188, 22)
        Me.pt_date.TabIndex = 140
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(89, 404)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 29)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "สถานะสมรส"
        '
        'pt_status
        '
        Me.pt_status.Location = New System.Drawing.Point(95, 451)
        Me.pt_status.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_status.Name = "pt_status"
        Me.pt_status.Size = New System.Drawing.Size(188, 22)
        Me.pt_status.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(89, 313)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 29)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "เบอร์โทร"
        '
        'pt_tel
        '
        Me.pt_tel.Location = New System.Drawing.Point(95, 359)
        Me.pt_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_tel.Name = "pt_tel"
        Me.pt_tel.Size = New System.Drawing.Size(188, 22)
        Me.pt_tel.TabIndex = 136
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(316, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "นามสกุล"
        '
        'pt_lastName
        '
        Me.pt_lastName.Location = New System.Drawing.Point(321, 182)
        Me.pt_lastName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_lastName.Name = "pt_lastName"
        Me.pt_lastName.Size = New System.Drawing.Size(188, 22)
        Me.pt_lastName.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(316, 227)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 29)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "เพศ"
        '
        'pt_gender
        '
        Me.pt_gender.Location = New System.Drawing.Point(321, 273)
        Me.pt_gender.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_gender.Name = "pt_gender"
        Me.pt_gender.Size = New System.Drawing.Size(188, 22)
        Me.pt_gender.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(89, 227)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "วันเกิด"
        '
        'pt_birthday
        '
        Me.pt_birthday.Location = New System.Drawing.Point(95, 273)
        Me.pt_birthday.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_birthday.Name = "pt_birthday"
        Me.pt_birthday.Size = New System.Drawing.Size(188, 22)
        Me.pt_birthday.TabIndex = 130
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lable1.Location = New System.Drawing.Point(89, 135)
        Me.Lable1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(39, 29)
        Me.Lable1.TabIndex = 129
        Me.Lable1.Text = "ชื่อ"
        '
        'pt_firstName
        '
        Me.pt_firstName.Location = New System.Drawing.Point(95, 182)
        Me.pt_firstName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_firstName.Name = "pt_firstName"
        Me.pt_firstName.Size = New System.Drawing.Size(188, 22)
        Me.pt_firstName.TabIndex = 128
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1089, 30)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 49)
        Me.btnAdd.TabIndex = 127
        Me.btnAdd.Text = "เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(968, 30)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 49)
        Me.btnClear.TabIndex = 126
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(497, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 36)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "ลงทะเบียนข้อมูลผู้ป่วย"
        '
        'Add_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 867)
        Me.Controls.Add(Me.Add_panel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Patient"
        Me.Text = "Add_Patient"
        Me.Add_panel.ResumeLayout(False)
        Me.Add_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Add_panel As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents kin_address As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents kin_fullName As TextBox
    Friend WithEvents btnCheck_kin As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents kin_tel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pt_address As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pt_date As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pt_status As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pt_tel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pt_lastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pt_gender As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pt_birthday As TextBox
    Friend WithEvents Lable1 As Label
    Friend WithEvents pt_firstName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents local_address As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents local_search_tel As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents local_tel As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents local_fullName As TextBox
End Class
