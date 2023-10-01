<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_StaffForm
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
        Me.finishdatelb = New System.Windows.Forms.Label()
        Me.majorlb = New System.Windows.Forms.Label()
        Me.typelb = New System.Windows.Forms.Label()
        Me.btnDelRow = New System.Windows.Forms.Button()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.subheader3 = New System.Windows.Forms.Label()
        Me.addresslb = New System.Windows.Forms.Label()
        Me.Staff_address = New System.Windows.Forms.RichTextBox()
        Me.Staff_contactType = New System.Windows.Forms.ComboBox()
        Me.contacttylelb = New System.Windows.Forms.Label()
        Me.Staff_paidType = New System.Windows.Forms.ComboBox()
        Me.hoursweeklb = New System.Windows.Forms.Label()
        Me.Staff_hoursWeek = New System.Windows.Forms.TextBox()
        Me.paidtypelb = New System.Windows.Forms.Label()
        Me.salaryscallb = New System.Windows.Forms.Label()
        Me.Staff_salaryScale = New System.Windows.Forms.TextBox()
        Me.salarylb = New System.Windows.Forms.Label()
        Me.Staff_salary = New System.Windows.Forms.TextBox()
        Me.ninlb = New System.Windows.Forms.Label()
        Me.Staff_nin = New System.Windows.Forms.TextBox()
        Me.tellb = New System.Windows.Forms.Label()
        Me.Staff_tel = New System.Windows.Forms.TextBox()
        Me.Staff_dob = New System.Windows.Forms.DateTimePicker()
        Me.genderlb = New System.Windows.Forms.Label()
        Me.Staff_gender = New System.Windows.Forms.TextBox()
        Me.doblb = New System.Windows.Forms.Label()
        Me.subheaderlb2 = New System.Windows.Forms.Label()
        Me.positionlb = New System.Windows.Forms.Label()
        Me.Staff_position = New System.Windows.Forms.TextBox()
        Me.lnamelb = New System.Windows.Forms.Label()
        Me.Staff_lastName = New System.Windows.Forms.TextBox()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.fnamelb = New System.Windows.Forms.Label()
        Me.Staff_firstName = New System.Windows.Forms.TextBox()
        Me.subheaderlb1 = New System.Windows.Forms.Label()
        Me.statuslb = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.subheader4 = New System.Windows.Forms.Label()
        Me.btnDelRow2 = New System.Windows.Forms.Button()
        Me.btnAddRow2 = New System.Windows.Forms.Button()
        Me.hisstartdatelb = New System.Windows.Forms.Label()
        Me.hiscompanylb = New System.Windows.Forms.Label()
        Me.hispositionlb = New System.Windows.Forms.Label()
        Me.hisenddatelb = New System.Windows.Forms.Label()
        Me.statuslb2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'finishdatelb
        '
        Me.finishdatelb.AutoSize = True
        Me.finishdatelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishdatelb.Location = New System.Drawing.Point(416, 457)
        Me.finishdatelb.Name = "finishdatelb"
        Me.finishdatelb.Size = New System.Drawing.Size(126, 24)
        Me.finishdatelb.TabIndex = 98
        Me.finishdatelb.Text = "วันเที่จบการศึกษา"
        '
        'majorlb
        '
        Me.majorlb.AutoSize = True
        Me.majorlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.majorlb.Location = New System.Drawing.Point(249, 457)
        Me.majorlb.Name = "majorlb"
        Me.majorlb.Size = New System.Drawing.Size(82, 24)
        Me.majorlb.TabIndex = 97
        Me.majorlb.Text = "คณะ/สาขา"
        '
        'typelb
        '
        Me.typelb.AutoSize = True
        Me.typelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typelb.Location = New System.Drawing.Point(67, 457)
        Me.typelb.Name = "typelb"
        Me.typelb.Size = New System.Drawing.Size(148, 24)
        Me.typelb.TabIndex = 96
        Me.typelb.Text = "ประเภทวุฒิการศึกษา"
        '
        'btnDelRow
        '
        Me.btnDelRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelRow.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelRow.ForeColor = System.Drawing.Color.White
        Me.btnDelRow.Location = New System.Drawing.Point(341, 408)
        Me.btnDelRow.Name = "btnDelRow"
        Me.btnDelRow.Size = New System.Drawing.Size(120, 37)
        Me.btnDelRow.TabIndex = 95
        Me.btnDelRow.Text = "ลบแถวกรอกข้อมูล"
        Me.btnDelRow.UseVisualStyleBackColor = False
        '
        'btnAddRow
        '
        Me.btnAddRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddRow.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRow.ForeColor = System.Drawing.Color.White
        Me.btnAddRow.Location = New System.Drawing.Point(205, 408)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(120, 37)
        Me.btnAddRow.TabIndex = 94
        Me.btnAddRow.Text = "เพิ่มจำนวนข้อมูล"
        Me.btnAddRow.UseVisualStyleBackColor = False
        '
        'subheader3
        '
        Me.subheader3.AutoSize = True
        Me.subheader3.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subheader3.Location = New System.Drawing.Point(52, 412)
        Me.subheader3.Name = "subheader3"
        Me.subheader3.Size = New System.Drawing.Size(142, 29)
        Me.subheader3.TabIndex = 93
        Me.subheader3.Text = "ประวัติการศึกษา"
        '
        'addresslb
        '
        Me.addresslb.AutoSize = True
        Me.addresslb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresslb.Location = New System.Drawing.Point(63, 271)
        Me.addresslb.Name = "addresslb"
        Me.addresslb.Size = New System.Drawing.Size(40, 24)
        Me.addresslb.TabIndex = 92
        Me.addresslb.Text = "ที่อยู่"
        '
        'Staff_address
        '
        Me.Staff_address.Location = New System.Drawing.Point(65, 298)
        Me.Staff_address.Name = "Staff_address"
        Me.Staff_address.Size = New System.Drawing.Size(281, 86)
        Me.Staff_address.TabIndex = 91
        Me.Staff_address.Text = ""
        '
        'Staff_contactType
        '
        Me.Staff_contactType.FormattingEnabled = True
        Me.Staff_contactType.Items.AddRange(New Object() {"P", "T"})
        Me.Staff_contactType.Location = New System.Drawing.Point(396, 298)
        Me.Staff_contactType.Name = "Staff_contactType"
        Me.Staff_contactType.Size = New System.Drawing.Size(131, 21)
        Me.Staff_contactType.TabIndex = 90
        '
        'contacttylelb
        '
        Me.contacttylelb.AutoSize = True
        Me.contacttylelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contacttylelb.Location = New System.Drawing.Point(394, 271)
        Me.contacttylelb.Name = "contacttylelb"
        Me.contacttylelb.Size = New System.Drawing.Size(132, 24)
        Me.contacttylelb.TabIndex = 89
        Me.contacttylelb.Text = "รูปแบบสัญญาจ้าง"
        '
        'Staff_paidType
        '
        Me.Staff_paidType.FormattingEnabled = True
        Me.Staff_paidType.Items.AddRange(New Object() {"W", "M"})
        Me.Staff_paidType.Location = New System.Drawing.Point(396, 247)
        Me.Staff_paidType.Name = "Staff_paidType"
        Me.Staff_paidType.Size = New System.Drawing.Size(131, 21)
        Me.Staff_paidType.TabIndex = 88
        '
        'hoursweeklb
        '
        Me.hoursweeklb.AutoSize = True
        Me.hoursweeklb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursweeklb.Location = New System.Drawing.Point(544, 222)
        Me.hoursweeklb.Name = "hoursweeklb"
        Me.hoursweeklb.Size = New System.Drawing.Size(153, 24)
        Me.hoursweeklb.TabIndex = 87
        Me.hoursweeklb.Text = "ชั่วโมงทำงาน/สัปดาห์"
        '
        'Staff_hoursWeek
        '
        Me.Staff_hoursWeek.Location = New System.Drawing.Point(546, 247)
        Me.Staff_hoursWeek.Name = "Staff_hoursWeek"
        Me.Staff_hoursWeek.Size = New System.Drawing.Size(131, 20)
        Me.Staff_hoursWeek.TabIndex = 86
        '
        'paidtypelb
        '
        Me.paidtypelb.AutoSize = True
        Me.paidtypelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paidtypelb.Location = New System.Drawing.Point(394, 220)
        Me.paidtypelb.Name = "paidtypelb"
        Me.paidtypelb.Size = New System.Drawing.Size(133, 24)
        Me.paidtypelb.TabIndex = 85
        Me.paidtypelb.Text = "รูปแบบการจ่ายเงิน"
        '
        'salaryscallb
        '
        Me.salaryscallb.AutoSize = True
        Me.salaryscallb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salaryscallb.Location = New System.Drawing.Point(544, 168)
        Me.salaryscallb.Name = "salaryscallb"
        Me.salaryscallb.Size = New System.Drawing.Size(103, 24)
        Me.salaryscallb.TabIndex = 84
        Me.salaryscallb.Text = "Salary Scale"
        '
        'Staff_salaryScale
        '
        Me.Staff_salaryScale.Location = New System.Drawing.Point(546, 193)
        Me.Staff_salaryScale.Name = "Staff_salaryScale"
        Me.Staff_salaryScale.Size = New System.Drawing.Size(131, 20)
        Me.Staff_salaryScale.TabIndex = 83
        '
        'salarylb
        '
        Me.salarylb.AutoSize = True
        Me.salarylb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salarylb.Location = New System.Drawing.Point(394, 168)
        Me.salarylb.Name = "salarylb"
        Me.salarylb.Size = New System.Drawing.Size(119, 24)
        Me.salarylb.TabIndex = 82
        Me.salarylb.Text = "เงินเดือนปัจจุบัน"
        '
        'Staff_salary
        '
        Me.Staff_salary.Location = New System.Drawing.Point(396, 193)
        Me.Staff_salary.Name = "Staff_salary"
        Me.Staff_salary.Size = New System.Drawing.Size(131, 20)
        Me.Staff_salary.TabIndex = 81
        '
        'ninlb
        '
        Me.ninlb.AutoSize = True
        Me.ninlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ninlb.Location = New System.Drawing.Point(213, 218)
        Me.ninlb.Name = "ninlb"
        Me.ninlb.Size = New System.Drawing.Size(36, 24)
        Me.ninlb.TabIndex = 80
        Me.ninlb.Text = "NIN"
        '
        'Staff_nin
        '
        Me.Staff_nin.Location = New System.Drawing.Point(215, 243)
        Me.Staff_nin.Name = "Staff_nin"
        Me.Staff_nin.Size = New System.Drawing.Size(131, 20)
        Me.Staff_nin.TabIndex = 79
        '
        'tellb
        '
        Me.tellb.AutoSize = True
        Me.tellb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tellb.Location = New System.Drawing.Point(63, 218)
        Me.tellb.Name = "tellb"
        Me.tellb.Size = New System.Drawing.Size(66, 24)
        Me.tellb.TabIndex = 78
        Me.tellb.Text = "เบอร์โทร"
        '
        'Staff_tel
        '
        Me.Staff_tel.Location = New System.Drawing.Point(65, 243)
        Me.Staff_tel.Name = "Staff_tel"
        Me.Staff_tel.Size = New System.Drawing.Size(131, 20)
        Me.Staff_tel.TabIndex = 77
        '
        'Staff_dob
        '
        Me.Staff_dob.Location = New System.Drawing.Point(63, 193)
        Me.Staff_dob.Name = "Staff_dob"
        Me.Staff_dob.Size = New System.Drawing.Size(131, 20)
        Me.Staff_dob.TabIndex = 76
        '
        'genderlb
        '
        Me.genderlb.AutoSize = True
        Me.genderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.Location = New System.Drawing.Point(211, 168)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(37, 24)
        Me.genderlb.TabIndex = 75
        Me.genderlb.Text = "เพศ"
        '
        'Staff_gender
        '
        Me.Staff_gender.Location = New System.Drawing.Point(213, 193)
        Me.Staff_gender.Name = "Staff_gender"
        Me.Staff_gender.Size = New System.Drawing.Size(131, 20)
        Me.Staff_gender.TabIndex = 74
        '
        'doblb
        '
        Me.doblb.AutoSize = True
        Me.doblb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doblb.Location = New System.Drawing.Point(61, 168)
        Me.doblb.Name = "doblb"
        Me.doblb.Size = New System.Drawing.Size(55, 24)
        Me.doblb.TabIndex = 73
        Me.doblb.Text = "วันเกิด"
        '
        'subheaderlb2
        '
        Me.subheaderlb2.AutoSize = True
        Me.subheaderlb2.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subheaderlb2.Location = New System.Drawing.Point(392, 86)
        Me.subheaderlb2.Name = "subheaderlb2"
        Me.subheaderlb2.Size = New System.Drawing.Size(143, 29)
        Me.subheaderlb2.TabIndex = 72
        Me.subheaderlb2.Text = "ข้อมูลการทำงาน"
        '
        'positionlb
        '
        Me.positionlb.AutoSize = True
        Me.positionlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionlb.Location = New System.Drawing.Point(394, 120)
        Me.positionlb.Name = "positionlb"
        Me.positionlb.Size = New System.Drawing.Size(94, 24)
        Me.positionlb.TabIndex = 71
        Me.positionlb.Text = "ตำแหน่งงาน"
        '
        'Staff_position
        '
        Me.Staff_position.Location = New System.Drawing.Point(396, 145)
        Me.Staff_position.Name = "Staff_position"
        Me.Staff_position.Size = New System.Drawing.Size(213, 20)
        Me.Staff_position.TabIndex = 70
        '
        'lnamelb
        '
        Me.lnamelb.AutoSize = True
        Me.lnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnamelb.Location = New System.Drawing.Point(211, 120)
        Me.lnamelb.Name = "lnamelb"
        Me.lnamelb.Size = New System.Drawing.Size(67, 24)
        Me.lnamelb.TabIndex = 69
        Me.lnamelb.Text = "นามสกุล"
        '
        'Staff_lastName
        '
        Me.Staff_lastName.Location = New System.Drawing.Point(213, 145)
        Me.Staff_lastName.Name = "Staff_lastName"
        Me.Staff_lastName.Size = New System.Drawing.Size(131, 20)
        Me.Staff_lastName.TabIndex = 68
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(341, 36)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(179, 32)
        Me.headerlb.TabIndex = 67
        Me.headerlb.Text = "เพิ่มข้อมูลเจ้าหน้าที่"
        '
        'fnamelb
        '
        Me.fnamelb.AutoSize = True
        Me.fnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnamelb.Location = New System.Drawing.Point(61, 120)
        Me.fnamelb.Name = "fnamelb"
        Me.fnamelb.Size = New System.Drawing.Size(29, 24)
        Me.fnamelb.TabIndex = 66
        Me.fnamelb.Text = "ชื่อ"
        '
        'Staff_firstName
        '
        Me.Staff_firstName.Location = New System.Drawing.Point(63, 145)
        Me.Staff_firstName.Name = "Staff_firstName"
        Me.Staff_firstName.Size = New System.Drawing.Size(131, 20)
        Me.Staff_firstName.TabIndex = 65
        '
        'subheaderlb1
        '
        Me.subheaderlb1.AutoSize = True
        Me.subheaderlb1.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subheaderlb1.Location = New System.Drawing.Point(59, 86)
        Me.subheaderlb1.Name = "subheaderlb1"
        Me.subheaderlb1.Size = New System.Drawing.Size(125, 29)
        Me.subheaderlb1.TabIndex = 64
        Me.subheaderlb1.Text = "ประวัติส่วนตัว"
        '
        'statuslb
        '
        Me.statuslb.AutoSize = True
        Me.statuslb.ForeColor = System.Drawing.Color.Red
        Me.statuslb.Location = New System.Drawing.Point(473, 423)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(0, 13)
        Me.statuslb.TabIndex = 99
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(661, 900)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(140, 37)
        Me.btnSubmit.TabIndex = 100
        Me.btnSubmit.Text = "เพิ่มข้อมูล"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'subheader4
        '
        Me.subheader4.AutoSize = True
        Me.subheader4.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subheader4.Location = New System.Drawing.Point(52, 652)
        Me.subheader4.Name = "subheader4"
        Me.subheader4.Size = New System.Drawing.Size(148, 29)
        Me.subheader4.TabIndex = 101
        Me.subheader4.Text = "ประวัติการทำงาน"
        '
        'btnDelRow2
        '
        Me.btnDelRow2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelRow2.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelRow2.ForeColor = System.Drawing.Color.White
        Me.btnDelRow2.Location = New System.Drawing.Point(342, 648)
        Me.btnDelRow2.Name = "btnDelRow2"
        Me.btnDelRow2.Size = New System.Drawing.Size(120, 37)
        Me.btnDelRow2.TabIndex = 103
        Me.btnDelRow2.Text = "ลบแถวกรอกข้อมูล"
        Me.btnDelRow2.UseVisualStyleBackColor = False
        '
        'btnAddRow2
        '
        Me.btnAddRow2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddRow2.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRow2.ForeColor = System.Drawing.Color.White
        Me.btnAddRow2.Location = New System.Drawing.Point(206, 648)
        Me.btnAddRow2.Name = "btnAddRow2"
        Me.btnAddRow2.Size = New System.Drawing.Size(120, 37)
        Me.btnAddRow2.TabIndex = 102
        Me.btnAddRow2.Text = "เพิ่มจำนวนข้อมูล"
        Me.btnAddRow2.UseVisualStyleBackColor = False
        '
        'hisstartdatelb
        '
        Me.hisstartdatelb.AutoSize = True
        Me.hisstartdatelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hisstartdatelb.Location = New System.Drawing.Point(405, 698)
        Me.hisstartdatelb.Name = "hisstartdatelb"
        Me.hisstartdatelb.Size = New System.Drawing.Size(119, 24)
        Me.hisstartdatelb.TabIndex = 106
        Me.hisstartdatelb.Text = "วันทำงานวันแรก"
        '
        'hiscompanylb
        '
        Me.hiscompanylb.AutoSize = True
        Me.hiscompanylb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hiscompanylb.Location = New System.Drawing.Point(230, 700)
        Me.hiscompanylb.Name = "hiscompanylb"
        Me.hiscompanylb.Size = New System.Drawing.Size(77, 24)
        Me.hiscompanylb.TabIndex = 105
        Me.hiscompanylb.Text = "ชื่อองค์กร"
        '
        'hispositionlb
        '
        Me.hispositionlb.AutoSize = True
        Me.hispositionlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hispositionlb.Location = New System.Drawing.Point(56, 698)
        Me.hispositionlb.Name = "hispositionlb"
        Me.hispositionlb.Size = New System.Drawing.Size(67, 24)
        Me.hispositionlb.TabIndex = 104
        Me.hispositionlb.Text = "ตำแหน่ง"
        '
        'hisenddatelb
        '
        Me.hisenddatelb.AutoSize = True
        Me.hisenddatelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hisenddatelb.Location = New System.Drawing.Point(637, 698)
        Me.hisenddatelb.Name = "hisenddatelb"
        Me.hisenddatelb.Size = New System.Drawing.Size(119, 24)
        Me.hisenddatelb.TabIndex = 107
        Me.hisenddatelb.Text = "วันทำงานวันแรก"
        '
        'statuslb2
        '
        Me.statuslb2.AutoSize = True
        Me.statuslb2.ForeColor = System.Drawing.Color.Red
        Me.statuslb2.Location = New System.Drawing.Point(473, 663)
        Me.statuslb2.Name = "statuslb2"
        Me.statuslb2.Size = New System.Drawing.Size(0, 13)
        Me.statuslb2.TabIndex = 108
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(35, 900)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 37)
        Me.btnClear.TabIndex = 109
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Add_StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 961)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.statuslb2)
        Me.Controls.Add(Me.hisenddatelb)
        Me.Controls.Add(Me.hisstartdatelb)
        Me.Controls.Add(Me.hiscompanylb)
        Me.Controls.Add(Me.hispositionlb)
        Me.Controls.Add(Me.btnDelRow2)
        Me.Controls.Add(Me.btnAddRow2)
        Me.Controls.Add(Me.subheader4)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.statuslb)
        Me.Controls.Add(Me.finishdatelb)
        Me.Controls.Add(Me.majorlb)
        Me.Controls.Add(Me.typelb)
        Me.Controls.Add(Me.btnDelRow)
        Me.Controls.Add(Me.btnAddRow)
        Me.Controls.Add(Me.subheader3)
        Me.Controls.Add(Me.addresslb)
        Me.Controls.Add(Me.Staff_address)
        Me.Controls.Add(Me.Staff_contactType)
        Me.Controls.Add(Me.contacttylelb)
        Me.Controls.Add(Me.Staff_paidType)
        Me.Controls.Add(Me.hoursweeklb)
        Me.Controls.Add(Me.Staff_hoursWeek)
        Me.Controls.Add(Me.paidtypelb)
        Me.Controls.Add(Me.salaryscallb)
        Me.Controls.Add(Me.Staff_salaryScale)
        Me.Controls.Add(Me.salarylb)
        Me.Controls.Add(Me.Staff_salary)
        Me.Controls.Add(Me.ninlb)
        Me.Controls.Add(Me.Staff_nin)
        Me.Controls.Add(Me.tellb)
        Me.Controls.Add(Me.Staff_tel)
        Me.Controls.Add(Me.Staff_dob)
        Me.Controls.Add(Me.genderlb)
        Me.Controls.Add(Me.Staff_gender)
        Me.Controls.Add(Me.doblb)
        Me.Controls.Add(Me.subheaderlb2)
        Me.Controls.Add(Me.positionlb)
        Me.Controls.Add(Me.Staff_position)
        Me.Controls.Add(Me.lnamelb)
        Me.Controls.Add(Me.Staff_lastName)
        Me.Controls.Add(Me.headerlb)
        Me.Controls.Add(Me.fnamelb)
        Me.Controls.Add(Me.Staff_firstName)
        Me.Controls.Add(Me.subheaderlb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Add_StaffForm"
        Me.Text = "เพิ่มข้อมูลเจ้าหน้าที่"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents finishdatelb As Label
    Friend WithEvents majorlb As Label
    Friend WithEvents typelb As Label
    Friend WithEvents btnDelRow As Button
    Friend WithEvents btnAddRow As Button
    Friend WithEvents subheader3 As Label
    Friend WithEvents addresslb As Label
    Friend WithEvents Staff_address As RichTextBox
    Friend WithEvents Staff_contactType As ComboBox
    Friend WithEvents contacttylelb As Label
    Friend WithEvents Staff_paidType As ComboBox
    Friend WithEvents hoursweeklb As Label
    Friend WithEvents Staff_hoursWeek As TextBox
    Friend WithEvents paidtypelb As Label
    Friend WithEvents salaryscallb As Label
    Friend WithEvents Staff_salaryScale As TextBox
    Friend WithEvents salarylb As Label
    Friend WithEvents Staff_salary As TextBox
    Friend WithEvents ninlb As Label
    Friend WithEvents Staff_nin As TextBox
    Friend WithEvents tellb As Label
    Friend WithEvents Staff_tel As TextBox
    Friend WithEvents Staff_dob As DateTimePicker
    Friend WithEvents genderlb As Label
    Friend WithEvents Staff_gender As TextBox
    Friend WithEvents doblb As Label
    Friend WithEvents subheaderlb2 As Label
    Friend WithEvents positionlb As Label
    Friend WithEvents Staff_position As TextBox
    Friend WithEvents lnamelb As Label
    Friend WithEvents Staff_lastName As TextBox
    Friend WithEvents headerlb As Label
    Friend WithEvents fnamelb As Label
    Friend WithEvents Staff_firstName As TextBox
    Friend WithEvents subheaderlb1 As Label
    Friend WithEvents statuslb As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents subheader4 As Label
    Friend WithEvents btnDelRow2 As Button
    Friend WithEvents btnAddRow2 As Button
    Friend WithEvents hisstartdatelb As Label
    Friend WithEvents hiscompanylb As Label
    Friend WithEvents hispositionlb As Label
    Friend WithEvents hisenddatelb As Label
    Friend WithEvents statuslb2 As Label
    Friend WithEvents btnClear As Button
End Class
