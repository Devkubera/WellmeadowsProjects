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
        Me.components = New System.ComponentModel.Container()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.m_dosage = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCheck_patient = New System.Windows.Forms.Button()
        Me.btnCheck_medicine = New System.Windows.Forms.Button()
        Me.btnCheck_doc = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.doc_firstname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.doc_lastname = New System.Windows.Forms.TextBox()
        Me.m_id = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.m_startDate = New System.Windows.Forms.DateTimePicker()
        Me.m_endDate = New System.Windows.Forms.DateTimePicker()
        Me.PatientsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.StaffsTableAdapter()
        Me.Med_MedicinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Med_MedicinesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter()
        Me.PW_PrescriptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PW_PrescriptsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PW_PrescriptsTableAdapter()
        Me.DoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.DoctorsTableAdapter()
        Me.Patient_WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_WardsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Med_MedicinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PW_PrescriptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label14.Location = New System.Drawing.Point(440, 552)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(276, 29)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "ปริมาณยาที่ผู้ป่วยได้รับต่อวัน"
        '
        'm_dosage
        '
        Me.m_dosage.Location = New System.Drawing.Point(446, 599)
        Me.m_dosage.Margin = New System.Windows.Forms.Padding(4)
        Me.m_dosage.Name = "m_dosage"
        Me.m_dosage.Size = New System.Drawing.Size(188, 22)
        Me.m_dosage.TabIndex = 152
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(440, 469)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 29)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "ชื่อยา"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(446, 516)
        Me.m_name.Margin = New System.Windows.Forms.Padding(4)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(188, 22)
        Me.m_name.TabIndex = 150
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(791, 465)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 29)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "รายละเอียดการรักษา"
        '
        'm_desc
        '
        Me.m_desc.Location = New System.Drawing.Point(796, 516)
        Me.m_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(416, 117)
        Me.m_desc.TabIndex = 146
        Me.m_desc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(351, 287)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "นามสกุล"
        '
        'pt_lastName
        '
        Me.pt_lastName.Location = New System.Drawing.Point(356, 334)
        Me.pt_lastName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_lastName.Name = "pt_lastName"
        Me.pt_lastName.Size = New System.Drawing.Size(188, 22)
        Me.pt_lastName.TabIndex = 129
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lable1.Location = New System.Drawing.Point(112, 201)
        Me.Lable1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(149, 29)
        Me.Lable1.TabIndex = 124
        Me.Lable1.Text = "หมายเลขผู้ป่วย"
        '
        'pt_id
        '
        Me.pt_id.Location = New System.Drawing.Point(117, 247)
        Me.pt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_id.Name = "pt_id"
        Me.pt_id.Size = New System.Drawing.Size(188, 22)
        Me.pt_id.TabIndex = 123
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1091, 37)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 46)
        Me.btnAdd.TabIndex = 122
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(969, 37)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 46)
        Me.btnClear.TabIndex = 121
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 36)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "เพิ่มข้อมูลการให้ยา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(112, 287)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 29)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "ชื่อ"
        '
        'pt_firstName
        '
        Me.pt_firstName.Location = New System.Drawing.Point(117, 334)
        Me.pt_firstName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_firstName.Name = "pt_firstName"
        Me.pt_firstName.Size = New System.Drawing.Size(188, 22)
        Me.pt_firstName.TabIndex = 154
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 31)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "ผู้ป่วย"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 414)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 31)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "ข้อมูลยา"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(136, 552)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 29)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "วิธีการให้ยากับผู้ป่วย"
        '
        'm_method
        '
        Me.m_method.FormattingEnabled = True
        Me.m_method.Items.AddRange(New Object() {"Oral", "Skin"})
        Me.m_method.Location = New System.Drawing.Point(141, 597)
        Me.m_method.Margin = New System.Windows.Forms.Padding(4)
        Me.m_method.Name = "m_method"
        Me.m_method.Size = New System.Drawing.Size(188, 24)
        Me.m_method.TabIndex = 160
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(442, 645)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 29)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "วันที่ให้ยาครบตามที่แพทย์สั่ง"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(136, 645)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 29)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "วันที่เริ่มให้ยา"
        '
        'btnCheck_patient
        '
        Me.btnCheck_patient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_patient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_patient.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_patient.Location = New System.Drawing.Point(212, 149)
        Me.btnCheck_patient.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_patient.Name = "btnCheck_patient"
        Me.btnCheck_patient.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_patient.TabIndex = 165
        Me.btnCheck_patient.Text = "ตรวจสอบ"
        Me.btnCheck_patient.UseVisualStyleBackColor = False
        '
        'btnCheck_medicine
        '
        Me.btnCheck_medicine.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_medicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_medicine.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_medicine.Location = New System.Drawing.Point(291, 412)
        Me.btnCheck_medicine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_medicine.Name = "btnCheck_medicine"
        Me.btnCheck_medicine.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_medicine.TabIndex = 166
        Me.btnCheck_medicine.Text = "ตรวจสอบ"
        Me.btnCheck_medicine.UseVisualStyleBackColor = False
        '
        'btnCheck_doc
        '
        Me.btnCheck_doc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_doc.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_doc.Location = New System.Drawing.Point(890, 151)
        Me.btnCheck_doc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_doc.Name = "btnCheck_doc"
        Me.btnCheck_doc.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_doc.TabIndex = 174
        Me.btnCheck_doc.Text = "ตรวจสอบ"
        Me.btnCheck_doc.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(790, 153)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 31)
        Me.Label9.TabIndex = 173
        Me.Label9.Text = "แพทย์"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(794, 200)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 29)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "ชื่อ"
        '
        'doc_firstname
        '
        Me.doc_firstname.Location = New System.Drawing.Point(799, 247)
        Me.doc_firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.doc_firstname.Name = "doc_firstname"
        Me.doc_firstname.Size = New System.Drawing.Size(188, 22)
        Me.doc_firstname.TabIndex = 171
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(1033, 200)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 29)
        Me.Label15.TabIndex = 170
        Me.Label15.Text = "นามสกุล"
        '
        'doc_lastname
        '
        Me.doc_lastname.Location = New System.Drawing.Point(1038, 247)
        Me.doc_lastname.Margin = New System.Windows.Forms.Padding(4)
        Me.doc_lastname.Name = "doc_lastname"
        Me.doc_lastname.Size = New System.Drawing.Size(188, 22)
        Me.doc_lastname.TabIndex = 169
        '
        'm_id
        '
        Me.m_id.Location = New System.Drawing.Point(140, 516)
        Me.m_id.Margin = New System.Windows.Forms.Padding(4)
        Me.m_id.Name = "m_id"
        Me.m_id.Size = New System.Drawing.Size(189, 22)
        Me.m_id.TabIndex = 148
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(135, 469)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 29)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "หมายเลขยา"
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'm_startDate
        '
        Me.m_startDate.Location = New System.Drawing.Point(140, 692)
        Me.m_startDate.Name = "m_startDate"
        Me.m_startDate.Size = New System.Drawing.Size(200, 22)
        Me.m_startDate.TabIndex = 176
        '
        'm_endDate
        '
        Me.m_endDate.Location = New System.Drawing.Point(447, 692)
        Me.m_endDate.Name = "m_endDate"
        Me.m_endDate.Size = New System.Drawing.Size(200, 22)
        Me.m_endDate.TabIndex = 177
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
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
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "Staffs"
        Me.StaffsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
        '
        'Med_MedicinesBindingSource
        '
        Me.Med_MedicinesBindingSource.DataMember = "Med_Medicines"
        Me.Med_MedicinesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Med_MedicinesTableAdapter
        '
        Me.Med_MedicinesTableAdapter.ClearBeforeFill = True
        '
        'PW_PrescriptsBindingSource
        '
        Me.PW_PrescriptsBindingSource.DataMember = "PW_Prescripts"
        Me.PW_PrescriptsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'PW_PrescriptsTableAdapter
        '
        Me.PW_PrescriptsTableAdapter.ClearBeforeFill = True
        '
        'DoctorsBindingSource
        '
        Me.DoctorsBindingSource.DataMember = "Doctors"
        Me.DoctorsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'DoctorsTableAdapter
        '
        Me.DoctorsTableAdapter.ClearBeforeFill = True
        '
        'Patient_WardsBindingSource
        '
        Me.Patient_WardsBindingSource.DataMember = "Patient_Wards"
        Me.Patient_WardsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Patient_WardsTableAdapter
        '
        Me.Patient_WardsTableAdapter.ClearBeforeFill = True
        '
        'Add_Presscipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 1055)
        Me.Controls.Add(Me.m_endDate)
        Me.Controls.Add(Me.m_startDate)
        Me.Controls.Add(Me.btnCheck_doc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.doc_firstname)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.doc_lastname)
        Me.Controls.Add(Me.btnCheck_medicine)
        Me.Controls.Add(Me.btnCheck_patient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Presscipt"
        Me.Text = "Add_Presscipt"
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Med_MedicinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PW_PrescriptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents m_dosage As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents m_name As TextBox
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
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCheck_patient As Button
    Friend WithEvents btnCheck_medicine As Button
    Friend WithEvents btnCheck_doc As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents doc_firstname As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents doc_lastname As TextBox
    Friend WithEvents m_id As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As WellmeadowsDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents StaffsTableAdapter As WellmeadowsDataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents Med_MedicinesBindingSource As BindingSource
    Friend WithEvents Med_MedicinesTableAdapter As WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter
    Friend WithEvents m_startDate As DateTimePicker
    Friend WithEvents m_endDate As DateTimePicker
    Friend WithEvents PW_PrescriptsBindingSource As BindingSource
    Friend WithEvents PW_PrescriptsTableAdapter As WellmeadowsDataSetTableAdapters.PW_PrescriptsTableAdapter
    Friend WithEvents DoctorsBindingSource As BindingSource
    Friend WithEvents DoctorsTableAdapter As WellmeadowsDataSetTableAdapters.DoctorsTableAdapter
    Friend WithEvents Patient_WardsBindingSource As BindingSource
    Friend WithEvents Patient_WardsTableAdapter As WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter
End Class
