<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Staff
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
        Me.components = New System.ComponentModel.Container()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Staff_gender = New System.Windows.Forms.ComboBox()
        Me.Staff_position = New System.Windows.Forms.ComboBox()
        Me.StaffQualificatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MedicalDirectorsTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.MedicalDirectorsTableAdapter()
        Me.Staff_QualificatesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Staff_QualificatesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.statuslb2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorsTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.DoctorsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.Staff_ExperiencesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Staff_ExperiencesTableAdapter()
        Me.StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.StaffsTableAdapter()
        Me.addresslb = New System.Windows.Forms.Label()
        Me.Staff_ExperiencesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_address = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.doblb = New System.Windows.Forms.Label()
        Me.subheaderlb2 = New System.Windows.Forms.Label()
        Me.positionlb = New System.Windows.Forms.Label()
        Me.lnamelb = New System.Windows.Forms.Label()
        Me.Staff_lastName = New System.Windows.Forms.TextBox()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.fnamelb = New System.Windows.Forms.Label()
        Me.Staff_firstName = New System.Windows.Forms.TextBox()
        Me.subheaderlb1 = New System.Windows.Forms.Label()
        Me.ChargeNursesTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.ChargeNursesTableAdapter()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffQualificatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_ExperiencesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Staff_gender
        '
        Me.Staff_gender.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_gender.FormattingEnabled = True
        Me.Staff_gender.Items.AddRange(New Object() {"ชาย", "หญิง"})
        Me.Staff_gender.Location = New System.Drawing.Point(475, 311)
        Me.Staff_gender.Name = "Staff_gender"
        Me.Staff_gender.Size = New System.Drawing.Size(202, 34)
        Me.Staff_gender.TabIndex = 186
        '
        'Staff_position
        '
        Me.Staff_position.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_position.FormattingEnabled = True
        Me.Staff_position.Items.AddRange(New Object() {"หัวหน้าพยาบาล. Charge Nurse", "ผู้อำนวยการโรงพยาบาล. Medical Director", "แพทย์. Doctor", "เจ้าหน้าที่ฝ่ายบุคคล. Personal Officer", "พยาบาล. Nurse", "พนักงานรักษาความปลอดภัย. Guard", "บุรุษพยาบาล. Men-Nurse"})
        Me.Staff_position.Location = New System.Drawing.Point(790, 239)
        Me.Staff_position.Name = "Staff_position"
        Me.Staff_position.Size = New System.Drawing.Size(424, 34)
        Me.Staff_position.TabIndex = 185
        Me.Staff_position.Tag = ""
        '
        'StaffQualificatesBindingSource
        '
        Me.StaffQualificatesBindingSource.DataMember = "Staff_Qualificates"
        Me.StaffQualificatesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(1547, 578)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 30)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "ตำแหน่ง"
        '
        'MedicalDirectorsTableAdapter1
        '
        Me.MedicalDirectorsTableAdapter1.ClearBeforeFill = True
        '
        'Staff_QualificatesTableAdapter
        '
        Me.Staff_QualificatesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(490, 1005)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 30)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "ตำแหน่ง"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(879, 52)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 49)
        Me.btnAdd.TabIndex = 177
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(758, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 49)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "ล้างค่า"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'statuslb2
        '
        Me.statuslb2.AutoSize = True
        Me.statuslb2.ForeColor = System.Drawing.Color.Red
        Me.statuslb2.Location = New System.Drawing.Point(1549, 294)
        Me.statuslb2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.statuslb2.Name = "statuslb2"
        Me.statuslb2.Size = New System.Drawing.Size(0, 16)
        Me.statuslb2.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(1718, 512)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 30)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "วันทำงานวันแรก"
        '
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "Staffs"
        Me.StaffsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'DoctorsTableAdapter1
        '
        Me.DoctorsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.ChargeNursesTableAdapter = Nothing
        Me.TableAdapterManager.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.In_PatientsTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Login_logsTableAdapter = Nothing
        Me.TableAdapterManager.Med_EquipmentsTableAdapter = Nothing
        Me.TableAdapterManager.Med_MedicinesTableAdapter = Nothing
        Me.TableAdapterManager.MedicalDirectorsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_kinsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_VisitsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_WardsTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PW_PrescriptsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.Staff_ExperiencesTableAdapter = Me.Staff_ExperiencesTableAdapter
        Me.TableAdapterManager.Staff_QualificatesTableAdapter = Me.Staff_QualificatesTableAdapter
        Me.TableAdapterManager.StaffsTableAdapter = Me.StaffsTableAdapter
        Me.TableAdapterManager.SuppilersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'Staff_ExperiencesTableAdapter
        '
        Me.Staff_ExperiencesTableAdapter.ClearBeforeFill = True
        '
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
        '
        'addresslb
        '
        Me.addresslb.AutoSize = True
        Me.addresslb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresslb.Location = New System.Drawing.Point(246, 434)
        Me.addresslb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addresslb.Name = "addresslb"
        Me.addresslb.Size = New System.Drawing.Size(51, 30)
        Me.addresslb.TabIndex = 158
        Me.addresslb.Text = "ที่อยู่"
        '
        'Staff_ExperiencesBindingSource
        '
        Me.Staff_ExperiencesBindingSource.DataMember = "Staff_Experiences"
        Me.Staff_ExperiencesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Staff_address
        '
        Me.Staff_address.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_address.Location = New System.Drawing.Point(249, 467)
        Me.Staff_address.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_address.Name = "Staff_address"
        Me.Staff_address.Size = New System.Drawing.Size(426, 105)
        Me.Staff_address.TabIndex = 157
        Me.Staff_address.Text = ""
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Staff_gender)
        Me.Panel1.Controls.Add(Me.Staff_position)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.statuslb2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.addresslb)
        Me.Panel1.Controls.Add(Me.Staff_address)
        Me.Panel1.Controls.Add(Me.Staff_contactType)
        Me.Panel1.Controls.Add(Me.contacttylelb)
        Me.Panel1.Controls.Add(Me.Staff_paidType)
        Me.Panel1.Controls.Add(Me.hoursweeklb)
        Me.Panel1.Controls.Add(Me.Staff_hoursWeek)
        Me.Panel1.Controls.Add(Me.paidtypelb)
        Me.Panel1.Controls.Add(Me.salaryscallb)
        Me.Panel1.Controls.Add(Me.Staff_salaryScale)
        Me.Panel1.Controls.Add(Me.salarylb)
        Me.Panel1.Controls.Add(Me.Staff_salary)
        Me.Panel1.Controls.Add(Me.ninlb)
        Me.Panel1.Controls.Add(Me.Staff_nin)
        Me.Panel1.Controls.Add(Me.tellb)
        Me.Panel1.Controls.Add(Me.Staff_tel)
        Me.Panel1.Controls.Add(Me.Staff_dob)
        Me.Panel1.Controls.Add(Me.genderlb)
        Me.Panel1.Controls.Add(Me.doblb)
        Me.Panel1.Controls.Add(Me.subheaderlb2)
        Me.Panel1.Controls.Add(Me.positionlb)
        Me.Panel1.Controls.Add(Me.lnamelb)
        Me.Panel1.Controls.Add(Me.Staff_lastName)
        Me.Panel1.Controls.Add(Me.headerlb)
        Me.Panel1.Controls.Add(Me.fnamelb)
        Me.Panel1.Controls.Add(Me.Staff_firstName)
        Me.Panel1.Controls.Add(Me.subheaderlb1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1877, 1017)
        Me.Panel1.TabIndex = 1
        '
        'Staff_contactType
        '
        Me.Staff_contactType.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_contactType.FormattingEnabled = True
        Me.Staff_contactType.Items.AddRange(New Object() {"P", "T"})
        Me.Staff_contactType.Location = New System.Drawing.Point(788, 475)
        Me.Staff_contactType.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_contactType.Name = "Staff_contactType"
        Me.Staff_contactType.Size = New System.Drawing.Size(424, 34)
        Me.Staff_contactType.TabIndex = 156
        '
        'contacttylelb
        '
        Me.contacttylelb.AutoSize = True
        Me.contacttylelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contacttylelb.Location = New System.Drawing.Point(785, 441)
        Me.contacttylelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.contacttylelb.Name = "contacttylelb"
        Me.contacttylelb.Size = New System.Drawing.Size(165, 30)
        Me.contacttylelb.TabIndex = 155
        Me.contacttylelb.Text = "รูปแบบสัญญาจ้าง"
        '
        'Staff_paidType
        '
        Me.Staff_paidType.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_paidType.FormattingEnabled = True
        Me.Staff_paidType.Items.AddRange(New Object() {"W", "M"})
        Me.Staff_paidType.Location = New System.Drawing.Point(788, 393)
        Me.Staff_paidType.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_paidType.Name = "Staff_paidType"
        Me.Staff_paidType.Size = New System.Drawing.Size(202, 34)
        Me.Staff_paidType.TabIndex = 154
        '
        'hoursweeklb
        '
        Me.hoursweeklb.AutoSize = True
        Me.hoursweeklb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursweeklb.Location = New System.Drawing.Point(1011, 360)
        Me.hoursweeklb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hoursweeklb.Name = "hoursweeklb"
        Me.hoursweeklb.Size = New System.Drawing.Size(192, 30)
        Me.hoursweeklb.TabIndex = 153
        Me.hoursweeklb.Text = "ชั่วโมงทำงาน/สัปดาห์"
        '
        'Staff_hoursWeek
        '
        Me.Staff_hoursWeek.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_hoursWeek.Location = New System.Drawing.Point(1014, 394)
        Me.Staff_hoursWeek.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_hoursWeek.Name = "Staff_hoursWeek"
        Me.Staff_hoursWeek.Size = New System.Drawing.Size(200, 33)
        Me.Staff_hoursWeek.TabIndex = 152
        '
        'paidtypelb
        '
        Me.paidtypelb.AutoSize = True
        Me.paidtypelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paidtypelb.Location = New System.Drawing.Point(785, 360)
        Me.paidtypelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.paidtypelb.Name = "paidtypelb"
        Me.paidtypelb.Size = New System.Drawing.Size(168, 30)
        Me.paidtypelb.TabIndex = 151
        Me.paidtypelb.Text = "รูปแบบการจ่ายเงิน"
        '
        'salaryscallb
        '
        Me.salaryscallb.AutoSize = True
        Me.salaryscallb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salaryscallb.Location = New System.Drawing.Point(1011, 283)
        Me.salaryscallb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.salaryscallb.Name = "salaryscallb"
        Me.salaryscallb.Size = New System.Drawing.Size(128, 30)
        Me.salaryscallb.TabIndex = 150
        Me.salaryscallb.Text = "Salary Scale"
        '
        'Staff_salaryScale
        '
        Me.Staff_salaryScale.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_salaryScale.Location = New System.Drawing.Point(1014, 314)
        Me.Staff_salaryScale.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_salaryScale.Name = "Staff_salaryScale"
        Me.Staff_salaryScale.Size = New System.Drawing.Size(198, 33)
        Me.Staff_salaryScale.TabIndex = 149
        '
        'salarylb
        '
        Me.salarylb.AutoSize = True
        Me.salarylb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salarylb.Location = New System.Drawing.Point(785, 283)
        Me.salarylb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.salarylb.Name = "salarylb"
        Me.salarylb.Size = New System.Drawing.Size(152, 30)
        Me.salarylb.TabIndex = 148
        Me.salarylb.Text = "เงินเดือนปัจจุบัน"
        '
        'Staff_salary
        '
        Me.Staff_salary.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_salary.Location = New System.Drawing.Point(788, 314)
        Me.Staff_salary.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_salary.Name = "Staff_salary"
        Me.Staff_salary.Size = New System.Drawing.Size(199, 33)
        Me.Staff_salary.TabIndex = 147
        '
        'ninlb
        '
        Me.ninlb.AutoSize = True
        Me.ninlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ninlb.Location = New System.Drawing.Point(470, 357)
        Me.ninlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ninlb.Name = "ninlb"
        Me.ninlb.Size = New System.Drawing.Size(46, 30)
        Me.ninlb.TabIndex = 146
        Me.ninlb.Text = "NIN"
        '
        'Staff_nin
        '
        Me.Staff_nin.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_nin.Location = New System.Drawing.Point(475, 388)
        Me.Staff_nin.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_nin.Name = "Staff_nin"
        Me.Staff_nin.Size = New System.Drawing.Size(202, 33)
        Me.Staff_nin.TabIndex = 145
        '
        'tellb
        '
        Me.tellb.AutoSize = True
        Me.tellb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tellb.Location = New System.Drawing.Point(248, 357)
        Me.tellb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tellb.Name = "tellb"
        Me.tellb.Size = New System.Drawing.Size(84, 30)
        Me.tellb.TabIndex = 144
        Me.tellb.Text = "เบอร์โทร"
        '
        'Staff_tel
        '
        Me.Staff_tel.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_tel.Location = New System.Drawing.Point(251, 388)
        Me.Staff_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_tel.Name = "Staff_tel"
        Me.Staff_tel.Size = New System.Drawing.Size(202, 33)
        Me.Staff_tel.TabIndex = 143
        '
        'Staff_dob
        '
        Me.Staff_dob.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Staff_dob.Location = New System.Drawing.Point(248, 309)
        Me.Staff_dob.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_dob.Name = "Staff_dob"
        Me.Staff_dob.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Staff_dob.Size = New System.Drawing.Size(202, 33)
        Me.Staff_dob.TabIndex = 142
        '
        'genderlb
        '
        Me.genderlb.AutoSize = True
        Me.genderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlb.Location = New System.Drawing.Point(472, 278)
        Me.genderlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.genderlb.Name = "genderlb"
        Me.genderlb.Size = New System.Drawing.Size(97, 30)
        Me.genderlb.TabIndex = 141
        Me.genderlb.Text = "เพศสภาพ"
        '
        'doblb
        '
        Me.doblb.AutoSize = True
        Me.doblb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doblb.Location = New System.Drawing.Point(245, 278)
        Me.doblb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.doblb.Name = "doblb"
        Me.doblb.Size = New System.Drawing.Size(71, 30)
        Me.doblb.TabIndex = 139
        Me.doblb.Text = "วันเกิด"
        '
        'subheaderlb2
        '
        Me.subheaderlb2.AutoSize = True
        Me.subheaderlb2.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subheaderlb2.Location = New System.Drawing.Point(784, 164)
        Me.subheaderlb2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subheaderlb2.Name = "subheaderlb2"
        Me.subheaderlb2.Size = New System.Drawing.Size(180, 36)
        Me.subheaderlb2.TabIndex = 138
        Me.subheaderlb2.Text = "ข้อมูลการทำงาน"
        '
        'positionlb
        '
        Me.positionlb.AutoSize = True
        Me.positionlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionlb.Location = New System.Drawing.Point(785, 206)
        Me.positionlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.positionlb.Name = "positionlb"
        Me.positionlb.Size = New System.Drawing.Size(116, 30)
        Me.positionlb.TabIndex = 137
        Me.positionlb.Text = "ตำแหน่งงาน"
        '
        'lnamelb
        '
        Me.lnamelb.AutoSize = True
        Me.lnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnamelb.Location = New System.Drawing.Point(472, 207)
        Me.lnamelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnamelb.Name = "lnamelb"
        Me.lnamelb.Size = New System.Drawing.Size(84, 30)
        Me.lnamelb.TabIndex = 135
        Me.lnamelb.Text = "นามสกุล"
        '
        'Staff_lastName
        '
        Me.Staff_lastName.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_lastName.Location = New System.Drawing.Point(475, 241)
        Me.Staff_lastName.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_lastName.Name = "Staff_lastName"
        Me.Staff_lastName.Size = New System.Drawing.Size(202, 33)
        Me.Staff_lastName.TabIndex = 134
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(400, 52)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(244, 40)
        Me.headerlb.TabIndex = 133
        Me.headerlb.Text = "แก้ไขข้อมูลเจ้าหน้าที่"
        '
        'fnamelb
        '
        Me.fnamelb.AutoSize = True
        Me.fnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnamelb.Location = New System.Drawing.Point(245, 207)
        Me.fnamelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fnamelb.Name = "fnamelb"
        Me.fnamelb.Size = New System.Drawing.Size(37, 30)
        Me.fnamelb.TabIndex = 132
        Me.fnamelb.Text = "ชื่อ"
        '
        'Staff_firstName
        '
        Me.Staff_firstName.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_firstName.Location = New System.Drawing.Point(248, 241)
        Me.Staff_firstName.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_firstName.Name = "Staff_firstName"
        Me.Staff_firstName.Size = New System.Drawing.Size(202, 33)
        Me.Staff_firstName.TabIndex = 131
        '
        'subheaderlb1
        '
        Me.subheaderlb1.AutoSize = True
        Me.subheaderlb1.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subheaderlb1.Location = New System.Drawing.Point(242, 164)
        Me.subheaderlb1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subheaderlb1.Name = "subheaderlb1"
        Me.subheaderlb1.Size = New System.Drawing.Size(155, 36)
        Me.subheaderlb1.TabIndex = 130
        Me.subheaderlb1.Text = "ประวัติส่วนตัว"
        '
        'ChargeNursesTableAdapter1
        '
        Me.ChargeNursesTableAdapter1.ClearBeforeFill = True
        '
        'Edit_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1877, 1017)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Edit_Staff"
        Me.Text = "Edit_Staff"
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffQualificatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_ExperiencesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents Staff_gender As ComboBox
    Friend WithEvents Staff_position As ComboBox
    Friend WithEvents StaffQualificatesBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents MedicalDirectorsTableAdapter1 As WellmeadowsDataSetTableAdapters.MedicalDirectorsTableAdapter
    Friend WithEvents Staff_QualificatesTableAdapter As WellmeadowsDataSetTableAdapters.Staff_QualificatesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents statuslb2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents DoctorsTableAdapter1 As WellmeadowsDataSetTableAdapters.DoctorsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Staff_ExperiencesTableAdapter As WellmeadowsDataSetTableAdapters.Staff_ExperiencesTableAdapter
    Friend WithEvents StaffsTableAdapter As WellmeadowsDataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents addresslb As Label
    Friend WithEvents Staff_ExperiencesBindingSource As BindingSource
    Friend WithEvents Staff_address As RichTextBox
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents doblb As Label
    Friend WithEvents subheaderlb2 As Label
    Friend WithEvents positionlb As Label
    Friend WithEvents lnamelb As Label
    Friend WithEvents Staff_lastName As TextBox
    Friend WithEvents headerlb As Label
    Friend WithEvents fnamelb As Label
    Friend WithEvents Staff_firstName As TextBox
    Friend WithEvents subheaderlb1 As Label
    Friend WithEvents ChargeNursesTableAdapter1 As WellmeadowsDataSetTableAdapters.ChargeNursesTableAdapter
End Class
