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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.pt_address = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kin_tel = New System.Windows.Forms.TextBox()
        Me.btnCheck_kin = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kin_lastName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.kin_firstName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.kin_address = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.local_address = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.doc_fullName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.local_tel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(850, 23)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 68
        Me.btnAdd.Text = "เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(759, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 67
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 29)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ลงทะเบียนข้อมูลผู้ป่วย"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(270, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 24)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "วันที่ลงทะเบียน"
        '
        'pt_date
        '
        Me.pt_date.Location = New System.Drawing.Point(274, 288)
        Me.pt_date.Name = "pt_date"
        Me.pt_date.Size = New System.Drawing.Size(142, 20)
        Me.pt_date.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(100, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "สถานะสมรส"
        '
        'pt_status
        '
        Me.pt_status.Location = New System.Drawing.Point(104, 362)
        Me.pt_status.Name = "pt_status"
        Me.pt_status.Size = New System.Drawing.Size(142, 20)
        Me.pt_status.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(100, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 24)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "เบอร์โทร"
        '
        'pt_tel
        '
        Me.pt_tel.Location = New System.Drawing.Point(104, 288)
        Me.pt_tel.Name = "pt_tel"
        Me.pt_tel.Size = New System.Drawing.Size(142, 20)
        Me.pt_tel.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(270, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "นามสกุล"
        '
        'pt_lastName
        '
        Me.pt_lastName.Location = New System.Drawing.Point(274, 144)
        Me.pt_lastName.Name = "pt_lastName"
        Me.pt_lastName.Size = New System.Drawing.Size(142, 20)
        Me.pt_lastName.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(270, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 24)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "เพศ"
        '
        'pt_gender
        '
        Me.pt_gender.Location = New System.Drawing.Point(274, 218)
        Me.pt_gender.Name = "pt_gender"
        Me.pt_gender.Size = New System.Drawing.Size(142, 20)
        Me.pt_gender.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(100, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "วันเกิด"
        '
        'pt_birthday
        '
        Me.pt_birthday.Location = New System.Drawing.Point(104, 218)
        Me.pt_birthday.Name = "pt_birthday"
        Me.pt_birthday.Size = New System.Drawing.Size(142, 20)
        Me.pt_birthday.TabIndex = 79
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lable1.Location = New System.Drawing.Point(100, 106)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(30, 24)
        Me.Lable1.TabIndex = 78
        Me.Lable1.Text = "ชื่อ"
        '
        'pt_firstName
        '
        Me.pt_firstName.Location = New System.Drawing.Point(104, 144)
        Me.pt_firstName.Name = "pt_firstName"
        Me.pt_firstName.Size = New System.Drawing.Size(142, 20)
        Me.pt_firstName.TabIndex = 77
        '
        'pt_address
        '
        Me.pt_address.Location = New System.Drawing.Point(104, 451)
        Me.pt_address.Name = "pt_address"
        Me.pt_address.Size = New System.Drawing.Size(312, 96)
        Me.pt_address.TabIndex = 91
        Me.pt_address.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(100, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 24)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "ที่อยู่"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(552, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 24)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "ตรวจสอบข้อมูลญาติ"
        '
        'kin_tel
        '
        Me.kin_tel.Location = New System.Drawing.Point(556, 144)
        Me.kin_tel.Name = "kin_tel"
        Me.kin_tel.Size = New System.Drawing.Size(142, 20)
        Me.kin_tel.TabIndex = 93
        '
        'btnCheck_kin
        '
        Me.btnCheck_kin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_kin.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_kin.Location = New System.Drawing.Point(726, 127)
        Me.btnCheck_kin.Name = "btnCheck_kin"
        Me.btnCheck_kin.Size = New System.Drawing.Size(120, 37)
        Me.btnCheck_kin.TabIndex = 107
        Me.btnCheck_kin.Text = "ตรวจสอบ"
        Me.btnCheck_kin.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(722, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 24)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "นามสกุล"
        '
        'kin_lastName
        '
        Me.kin_lastName.Location = New System.Drawing.Point(726, 218)
        Me.kin_lastName.Name = "kin_lastName"
        Me.kin_lastName.Size = New System.Drawing.Size(142, 20)
        Me.kin_lastName.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(552, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 24)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "ชื่อ"
        '
        'kin_firstName
        '
        Me.kin_firstName.Location = New System.Drawing.Point(556, 218)
        Me.kin_firstName.Name = "kin_firstName"
        Me.kin_firstName.Size = New System.Drawing.Size(142, 20)
        Me.kin_firstName.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(552, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 24)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "ที่อยู่"
        '
        'kin_address
        '
        Me.kin_address.Location = New System.Drawing.Point(556, 288)
        Me.kin_address.Name = "kin_address"
        Me.kin_address.Size = New System.Drawing.Size(312, 96)
        Me.kin_address.TabIndex = 112
        Me.kin_address.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(553, 480)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 24)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "ที่อยู่"
        '
        'local_address
        '
        Me.local_address.Location = New System.Drawing.Point(557, 518)
        Me.local_address.Name = "local_address"
        Me.local_address.Size = New System.Drawing.Size(142, 20)
        Me.local_address.TabIndex = 116
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(552, 413)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 24)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "ชื่อ - นามสกุล"
        '
        'doc_fullName
        '
        Me.doc_fullName.Location = New System.Drawing.Point(556, 451)
        Me.doc_fullName.Name = "doc_fullName"
        Me.doc_fullName.Size = New System.Drawing.Size(312, 20)
        Me.doc_fullName.TabIndex = 114
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label14.Location = New System.Drawing.Point(722, 480)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 24)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "เบอร์โทรศัพท์"
        '
        'local_tel
        '
        Me.local_tel.Location = New System.Drawing.Point(726, 518)
        Me.local_tel.Name = "local_tel"
        Me.local_tel.Size = New System.Drawing.Size(142, 20)
        Me.local_tel.TabIndex = 118
        '
        'Add_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.local_tel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.local_address)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.doc_fullName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.kin_address)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.kin_lastName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.kin_firstName)
        Me.Controls.Add(Me.btnCheck_kin)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.kin_tel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pt_address)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pt_date)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pt_status)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pt_tel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pt_lastName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pt_gender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pt_birthday)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.pt_firstName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Patient"
        Me.Text = "Add_Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
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
    Friend WithEvents pt_address As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents kin_tel As TextBox
    Friend WithEvents btnCheck_kin As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents kin_lastName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents kin_firstName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents kin_address As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents local_address As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents doc_fullName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents local_tel As TextBox
End Class
