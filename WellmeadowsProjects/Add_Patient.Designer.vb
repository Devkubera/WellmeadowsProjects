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
        Me.components = New System.ComponentModel.Container()
        Dim local_panel_clinicID As System.Windows.Forms.Label
        Me.Add_panel = New System.Windows.Forms.Panel()
        Me.pt_gender = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.local_clinic_ID = New System.Windows.Forms.TextBox()
        Me.kin_rela = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pt_date = New System.Windows.Forms.DateTimePicker()
        Me.pt_birthday = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kin_tel = New System.Windows.Forms.TextBox()
        Me.pt_status = New System.Windows.Forms.ComboBox()
        Me.local_address = New System.Windows.Forms.RichTextBox()
        Me.btnCheckLocal = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pt_address = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pt_tel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pt_lastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.pt_firstName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.Patient_kinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_kinsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Patient_kinsTableAdapter()
        Me.LocalDoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalDoctorsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.LocalDoctorsTableAdapter()
        local_panel_clinicID = New System.Windows.Forms.Label()
        Me.Add_panel.SuspendLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_kinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalDoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'local_panel_clinicID
        '
        local_panel_clinicID.AutoSize = True
        local_panel_clinicID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        local_panel_clinicID.Location = New System.Drawing.Point(555, 633)
        local_panel_clinicID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        local_panel_clinicID.Name = "local_panel_clinicID"
        local_panel_clinicID.Size = New System.Drawing.Size(190, 30)
        local_panel_clinicID.TabIndex = 211
        local_panel_clinicID.Text = "หมายเลขประจำคลินิค"
        '
        'Add_panel
        '
        Me.Add_panel.AutoScroll = True
        Me.Add_panel.Controls.Add(Me.pt_gender)
        Me.Add_panel.Controls.Add(Me.Label19)
        Me.Add_panel.Controls.Add(Me.local_clinic_ID)
        Me.Add_panel.Controls.Add(Me.kin_rela)
        Me.Add_panel.Controls.Add(Me.Label18)
        Me.Add_panel.Controls.Add(Me.pt_date)
        Me.Add_panel.Controls.Add(Me.pt_birthday)
        Me.Add_panel.Controls.Add(Me.Label17)
        Me.Add_panel.Controls.Add(Me.Label9)
        Me.Add_panel.Controls.Add(Me.kin_tel)
        Me.Add_panel.Controls.Add(Me.pt_status)
        Me.Add_panel.Controls.Add(Me.local_address)
        Me.Add_panel.Controls.Add(local_panel_clinicID)
        Me.Add_panel.Controls.Add(Me.btnCheckLocal)
        Me.Add_panel.Controls.Add(Me.Label16)
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
        Me.Add_panel.Controls.Add(Me.Label8)
        Me.Add_panel.Controls.Add(Me.pt_address)
        Me.Add_panel.Controls.Add(Me.Label6)
        Me.Add_panel.Controls.Add(Me.Label7)
        Me.Add_panel.Controls.Add(Me.Label5)
        Me.Add_panel.Controls.Add(Me.pt_tel)
        Me.Add_panel.Controls.Add(Me.Label2)
        Me.Add_panel.Controls.Add(Me.pt_lastName)
        Me.Add_panel.Controls.Add(Me.Label4)
        Me.Add_panel.Controls.Add(Me.Label3)
        Me.Add_panel.Controls.Add(Me.Lable1)
        Me.Add_panel.Controls.Add(Me.pt_firstName)
        Me.Add_panel.Controls.Add(Me.btnAdd)
        Me.Add_panel.Controls.Add(Me.btnClear)
        Me.Add_panel.Controls.Add(Me.Label1)
        Me.Add_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Add_panel.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_panel.Location = New System.Drawing.Point(0, 0)
        Me.Add_panel.Name = "Add_panel"
        Me.Add_panel.Size = New System.Drawing.Size(1755, 1055)
        Me.Add_panel.TabIndex = 0
        '
        'pt_gender
        '
        Me.pt_gender.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_gender.FormattingEnabled = True
        Me.pt_gender.Items.AddRange(New Object() {"ชาย", "หญิง"})
        Me.pt_gender.Location = New System.Drawing.Point(76, 394)
        Me.pt_gender.Name = "pt_gender"
        Me.pt_gender.Size = New System.Drawing.Size(190, 38)
        Me.pt_gender.TabIndex = 224
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(1525, 566)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 30)
        Me.Label19.TabIndex = 223
        Me.Label19.Text = "ที่อยู่"
        '
        'local_clinic_ID
        '
        Me.local_clinic_ID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.local_clinic_ID.Location = New System.Drawing.Point(559, 673)
        Me.local_clinic_ID.Margin = New System.Windows.Forms.Padding(0)
        Me.local_clinic_ID.Name = "local_clinic_ID"
        Me.local_clinic_ID.Size = New System.Drawing.Size(247, 38)
        Me.local_clinic_ID.TabIndex = 222
        '
        'kin_rela
        '
        Me.kin_rela.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kin_rela.FormattingEnabled = True
        Me.kin_rela.Items.AddRange(New Object() {"บิดา", "มารดา", "ปู่", "ย่า", "ตา", "ยาย", "พี่", "น้อง", "หลาน", "เหลน", "แฟน", "ไม่ระบุ", "ไม่ชัดเจน", "ไม่ได้เป็นอะไรกัน", "ไม่รู้จัก"})
        Me.kin_rela.Location = New System.Drawing.Point(559, 394)
        Me.kin_rela.Name = "kin_rela"
        Me.kin_rela.Size = New System.Drawing.Size(247, 38)
        Me.kin_rela.TabIndex = 221
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(559, 349)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(201, 30)
        Me.Label18.TabIndex = 220
        Me.Label18.Text = "ความสัมพันธ์กับผู้ป่วย"
        '
        'pt_date
        '
        Me.pt_date.Location = New System.Drawing.Point(77, 511)
        Me.pt_date.Name = "pt_date"
        Me.pt_date.Size = New System.Drawing.Size(416, 38)
        Me.pt_date.TabIndex = 218
        '
        'pt_birthday
        '
        Me.pt_birthday.Location = New System.Drawing.Point(76, 281)
        Me.pt_birthday.Name = "pt_birthday"
        Me.pt_birthday.Size = New System.Drawing.Size(416, 38)
        Me.pt_birthday.TabIndex = 217
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(696, 994)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 30)
        Me.Label17.TabIndex = 216
        Me.Label17.Text = "ที่อยู่"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(825, 355)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 30)
        Me.Label9.TabIndex = 215
        Me.Label9.Text = "เบอร์โทรศัพท์"
        '
        'kin_tel
        '
        Me.kin_tel.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kin_tel.Location = New System.Drawing.Point(830, 394)
        Me.kin_tel.Margin = New System.Windows.Forms.Padding(0)
        Me.kin_tel.Name = "kin_tel"
        Me.kin_tel.Size = New System.Drawing.Size(199, 38)
        Me.kin_tel.TabIndex = 214
        '
        'pt_status
        '
        Me.pt_status.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_status.FormattingEnabled = True
        Me.pt_status.Items.AddRange(New Object() {"โสด", "สมรส", "หย่าร้าง", "ไม่ชัดเจน"})
        Me.pt_status.Location = New System.Drawing.Point(77, 630)
        Me.pt_status.Name = "pt_status"
        Me.pt_status.Size = New System.Drawing.Size(413, 38)
        Me.pt_status.TabIndex = 213
        '
        'local_address
        '
        Me.local_address.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.local_address.Location = New System.Drawing.Point(1064, 567)
        Me.local_address.Margin = New System.Windows.Forms.Padding(4)
        Me.local_address.Name = "local_address"
        Me.local_address.Size = New System.Drawing.Size(342, 232)
        Me.local_address.TabIndex = 212
        Me.local_address.Text = ""
        '
        'btnCheckLocal
        '
        Me.btnCheckLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheckLocal.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckLocal.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheckLocal.Location = New System.Drawing.Point(559, 566)
        Me.btnCheckLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheckLocal.Name = "btnCheckLocal"
        Me.btnCheckLocal.Size = New System.Drawing.Size(212, 38)
        Me.btnCheckLocal.TabIndex = 209
        Me.btnCheckLocal.Text = "ตรวจสอบ"
        Me.btnCheckLocal.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(554, 519)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(198, 30)
        Me.Label16.TabIndex = 208
        Me.Label16.Text = "ตรวจสอบหมอท้องถิ่น"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(825, 633)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 30)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "เบอร์โทรศัพท์"
        '
        'local_tel
        '
        Me.local_tel.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.local_tel.Location = New System.Drawing.Point(830, 672)
        Me.local_tel.Margin = New System.Windows.Forms.Padding(0)
        Me.local_tel.Name = "local_tel"
        Me.local_tel.Size = New System.Drawing.Size(199, 38)
        Me.local_tel.TabIndex = 205
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1059, 519)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 30)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "ที่อยู่"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(554, 727)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 30)
        Me.Label13.TabIndex = 203
        Me.Label13.Text = "ชื่อ - นามสกุล"
        '
        'local_fullName
        '
        Me.local_fullName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.local_fullName.Location = New System.Drawing.Point(559, 761)
        Me.local_fullName.Margin = New System.Windows.Forms.Padding(4)
        Me.local_fullName.Name = "local_fullName"
        Me.local_fullName.Size = New System.Drawing.Size(470, 38)
        Me.local_fullName.TabIndex = 202
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1061, 158)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 30)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "ที่อยู่"
        '
        'kin_address
        '
        Me.kin_address.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kin_address.Location = New System.Drawing.Point(1064, 208)
        Me.kin_address.Margin = New System.Windows.Forms.Padding(4)
        Me.kin_address.Name = "kin_address"
        Me.kin_address.Size = New System.Drawing.Size(342, 224)
        Me.kin_address.TabIndex = 149
        Me.kin_address.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(557, 235)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 30)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "ชื่อ - สกุล"
        '
        'kin_fullName
        '
        Me.kin_fullName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kin_fullName.Location = New System.Drawing.Point(560, 280)
        Me.kin_fullName.Margin = New System.Windows.Forms.Padding(4)
        Me.kin_fullName.Name = "kin_fullName"
        Me.kin_fullName.Size = New System.Drawing.Size(469, 38)
        Me.kin_fullName.TabIndex = 147
        '
        'btnCheck_kin
        '
        Me.btnCheck_kin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_kin.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_kin.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_kin.Location = New System.Drawing.Point(559, 172)
        Me.btnCheck_kin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_kin.Name = "btnCheck_kin"
        Me.btnCheck_kin.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_kin.TabIndex = 146
        Me.btnCheck_kin.Text = "ตรวจสอบ"
        Me.btnCheck_kin.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(554, 125)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 30)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "ตรวจสอบข้อมูลญาติ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 701)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 30)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "ที่อยู่"
        '
        'pt_address
        '
        Me.pt_address.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_address.Location = New System.Drawing.Point(78, 751)
        Me.pt_address.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_address.Name = "pt_address"
        Me.pt_address.Size = New System.Drawing.Size(415, 121)
        Me.pt_address.TabIndex = 142
        Me.pt_address.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 464)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 30)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "วันที่ลงทะเบียน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(70, 582)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 30)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "สถานะสมรส"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 349)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 30)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "เบอร์โทร"
        '
        'pt_tel
        '
        Me.pt_tel.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_tel.Location = New System.Drawing.Point(304, 394)
        Me.pt_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_tel.Name = "pt_tel"
        Me.pt_tel.Size = New System.Drawing.Size(188, 38)
        Me.pt_tel.TabIndex = 136
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 30)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "นามสกุล"
        '
        'pt_lastName
        '
        Me.pt_lastName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_lastName.Location = New System.Drawing.Point(304, 173)
        Me.pt_lastName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_lastName.Name = "pt_lastName"
        Me.pt_lastName.Size = New System.Drawing.Size(188, 38)
        Me.pt_lastName.TabIndex = 134
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 349)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 30)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "เพศ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 235)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 30)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "วันเกิด"
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable1.Location = New System.Drawing.Point(72, 126)
        Me.Lable1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(37, 30)
        Me.Lable1.TabIndex = 129
        Me.Lable1.Text = "ชื่อ"
        '
        'pt_firstName
        '
        Me.pt_firstName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_firstName.Location = New System.Drawing.Point(78, 173)
        Me.pt_firstName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_firstName.Name = "pt_firstName"
        Me.pt_firstName.Size = New System.Drawing.Size(188, 38)
        Me.pt_firstName.TabIndex = 128
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1028, 31)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 49)
        Me.btnAdd.TabIndex = 127
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(891, 31)
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
        Me.Label1.Font = New System.Drawing.Font("Prompt", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 40)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "ลงทะเบียนข้อมูลผู้ป่วย"
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.In_PatientsTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Login_logsTableAdapter = Nothing
        Me.TableAdapterManager.Med_EquipmentsTableAdapter = Nothing
        Me.TableAdapterManager.Med_MedicinesTableAdapter = Nothing
        Me.TableAdapterManager.Patient_kinsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_VisitsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_WardsTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Me.PatientsTableAdapter
        Me.TableAdapterManager.PW_PrescriptsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.Staff_ExperiencesTableAdapter = Nothing
        Me.TableAdapterManager.Staff_QualificatesTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppilersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'Patient_kinsBindingSource
        '
        Me.Patient_kinsBindingSource.DataMember = "Patient_kins"
        Me.Patient_kinsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Patient_kinsTableAdapter
        '
        Me.Patient_kinsTableAdapter.ClearBeforeFill = True
        '
        'LocalDoctorsBindingSource
        '
        Me.LocalDoctorsBindingSource.DataMember = "LocalDoctors"
        Me.LocalDoctorsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'LocalDoctorsTableAdapter
        '
        Me.LocalDoctorsTableAdapter.ClearBeforeFill = True
        '
        'Add_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1755, 1055)
        Me.Controls.Add(Me.Add_panel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Patient"
        Me.Add_panel.ResumeLayout(False)
        Me.Add_panel.PerformLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_kinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalDoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Add_panel As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents kin_address As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents kin_fullName As TextBox
    Friend WithEvents btnCheck_kin As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents pt_address As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pt_tel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pt_lastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lable1 As Label
    Friend WithEvents pt_firstName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents local_address As RichTextBox
    Friend WithEvents btnCheckLocal As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents local_tel As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents local_fullName As TextBox
    Friend WithEvents pt_status As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As WellmeadowsDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pt_birthday As DateTimePicker
    Friend WithEvents pt_date As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents kin_tel As TextBox
    Friend WithEvents kin_rela As ComboBox
    Friend WithEvents local_clinic_ID As TextBox
    Friend WithEvents Patient_kinsBindingSource As BindingSource
    Friend WithEvents Patient_kinsTableAdapter As WellmeadowsDataSetTableAdapters.Patient_kinsTableAdapter
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents LocalDoctorsBindingSource As BindingSource
    Friend WithEvents LocalDoctorsTableAdapter As WellmeadowsDataSetTableAdapters.LocalDoctorsTableAdapter
    Friend WithEvents pt_gender As ComboBox
End Class
