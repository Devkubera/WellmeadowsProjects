<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Presscript
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.m_endDate = New System.Windows.Forms.DateTimePicker()
        Me.m_startDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCheck_doc = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.doc_firstname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.doc_lastname = New System.Windows.Forms.TextBox()
        Me.btnCheck_medicine = New System.Windows.Forms.Button()
        Me.btnCheck_patient = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.m_method = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pt_firstName = New System.Windows.Forms.TextBox()
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
        Me.PW_PrescriptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.PW_PrescriptsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PW_PrescriptsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PatientsTableAdapter()
        CType(Me.PW_PrescriptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.Location = New System.Drawing.Point(1109, 29)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 46)
        Me.btnEdit.TabIndex = 46
        Me.btnEdit.Text = "แก้ไขข้อมูล"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(517, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 40)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "แก้ไขข้อมูลการจ่ายยา"
        '
        'm_endDate
        '
        Me.m_endDate.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_endDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.m_endDate.Location = New System.Drawing.Point(462, 693)
        Me.m_endDate.Name = "m_endDate"
        Me.m_endDate.Size = New System.Drawing.Size(276, 38)
        Me.m_endDate.TabIndex = 209
        '
        'm_startDate
        '
        Me.m_startDate.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_startDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.m_startDate.Location = New System.Drawing.Point(140, 693)
        Me.m_startDate.Name = "m_startDate"
        Me.m_startDate.Size = New System.Drawing.Size(265, 38)
        Me.m_startDate.TabIndex = 208
        '
        'btnCheck_doc
        '
        Me.btnCheck_doc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_doc.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_doc.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_doc.Location = New System.Drawing.Point(890, 152)
        Me.btnCheck_doc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck_doc.Name = "btnCheck_doc"
        Me.btnCheck_doc.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_doc.TabIndex = 207
        Me.btnCheck_doc.Text = "ตรวจสอบ"
        Me.btnCheck_doc.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(790, 154)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 30)
        Me.Label9.TabIndex = 206
        Me.Label9.Text = "แพทย์"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(794, 214)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 30)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "ชื่อ"
        '
        'doc_firstname
        '
        Me.doc_firstname.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc_firstname.Location = New System.Drawing.Point(799, 248)
        Me.doc_firstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.doc_firstname.Name = "doc_firstname"
        Me.doc_firstname.ReadOnly = True
        Me.doc_firstname.Size = New System.Drawing.Size(188, 38)
        Me.doc_firstname.TabIndex = 204
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1033, 214)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 30)
        Me.Label15.TabIndex = 203
        Me.Label15.Text = "นามสกุล"
        '
        'doc_lastname
        '
        Me.doc_lastname.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc_lastname.Location = New System.Drawing.Point(1038, 248)
        Me.doc_lastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.doc_lastname.Name = "doc_lastname"
        Me.doc_lastname.ReadOnly = True
        Me.doc_lastname.Size = New System.Drawing.Size(188, 38)
        Me.doc_lastname.TabIndex = 202
        '
        'btnCheck_medicine
        '
        Me.btnCheck_medicine.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_medicine.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_medicine.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_medicine.Location = New System.Drawing.Point(243, 415)
        Me.btnCheck_medicine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck_medicine.Name = "btnCheck_medicine"
        Me.btnCheck_medicine.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_medicine.TabIndex = 201
        Me.btnCheck_medicine.Text = "ตรวจสอบ"
        Me.btnCheck_medicine.UseVisualStyleBackColor = False
        '
        'btnCheck_patient
        '
        Me.btnCheck_patient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_patient.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_patient.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_patient.Location = New System.Drawing.Point(243, 147)
        Me.btnCheck_patient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck_patient.Name = "btnCheck_patient"
        Me.btnCheck_patient.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_patient.TabIndex = 200
        Me.btnCheck_patient.Text = "ตรวจสอบ"
        Me.btnCheck_patient.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(457, 652)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(251, 30)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "วันที่ให้ยาครบตามที่แพทย์สั่ง"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(136, 652)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 30)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "วันที่เริ่มให้ยา"
        '
        'm_method
        '
        Me.m_method.Enabled = False
        Me.m_method.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_method.FormattingEnabled = True
        Me.m_method.Items.AddRange(New Object() {"Oral", "Skin"})
        Me.m_method.Location = New System.Drawing.Point(141, 598)
        Me.m_method.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.m_method.Name = "m_method"
        Me.m_method.Size = New System.Drawing.Size(264, 38)
        Me.m_method.TabIndex = 197
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 559)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 30)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "วิธีการให้ยากับผู้ป่วย"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 415)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 30)
        Me.Label5.TabIndex = 195
        Me.Label5.Text = "ข้อมูลยา"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 30)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "ผู้ป่วย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 298)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 30)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "ชื่อ"
        '
        'pt_firstName
        '
        Me.pt_firstName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_firstName.Location = New System.Drawing.Point(148, 332)
        Me.pt_firstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pt_firstName.Name = "pt_firstName"
        Me.pt_firstName.ReadOnly = True
        Me.pt_firstName.Size = New System.Drawing.Size(188, 38)
        Me.pt_firstName.TabIndex = 192
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(455, 559)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(257, 30)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "ปริมาณยาที่ผู้ป่วยได้รับต่อวัน"
        '
        'm_dosage
        '
        Me.m_dosage.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_dosage.Location = New System.Drawing.Point(461, 600)
        Me.m_dosage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.m_dosage.Name = "m_dosage"
        Me.m_dosage.Size = New System.Drawing.Size(277, 38)
        Me.m_dosage.TabIndex = 190
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(455, 483)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 30)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "ชื่อยา"
        '
        'm_name
        '
        Me.m_name.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_name.Location = New System.Drawing.Point(461, 517)
        Me.m_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.m_name.Name = "m_name"
        Me.m_name.ReadOnly = True
        Me.m_name.Size = New System.Drawing.Size(277, 38)
        Me.m_name.TabIndex = 188
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(135, 483)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 30)
        Me.Label13.TabIndex = 187
        Me.Label13.Text = "หมายเลขยา"
        '
        'm_id
        '
        Me.m_id.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_id.Location = New System.Drawing.Point(140, 517)
        Me.m_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.m_id.Name = "m_id"
        Me.m_id.ReadOnly = True
        Me.m_id.Size = New System.Drawing.Size(265, 38)
        Me.m_id.TabIndex = 186
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(791, 466)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 30)
        Me.Label11.TabIndex = 185
        Me.Label11.Text = "รายละเอียดการรักษา"
        '
        'm_desc
        '
        Me.m_desc.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_desc.Location = New System.Drawing.Point(796, 517)
        Me.m_desc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(416, 117)
        Me.m_desc.TabIndex = 184
        Me.m_desc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 30)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "นามสกุล"
        '
        'pt_lastName
        '
        Me.pt_lastName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_lastName.Location = New System.Drawing.Point(387, 332)
        Me.pt_lastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pt_lastName.Name = "pt_lastName"
        Me.pt_lastName.ReadOnly = True
        Me.pt_lastName.Size = New System.Drawing.Size(188, 38)
        Me.pt_lastName.TabIndex = 182
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable1.Location = New System.Drawing.Point(143, 212)
        Me.Lable1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(140, 30)
        Me.Lable1.TabIndex = 181
        Me.Lable1.Text = "หมายเลขผู้ป่วย"
        '
        'pt_id
        '
        Me.pt_id.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_id.Location = New System.Drawing.Point(148, 245)
        Me.pt_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pt_id.Name = "pt_id"
        Me.pt_id.ReadOnly = True
        Me.pt_id.Size = New System.Drawing.Size(188, 38)
        Me.pt_id.TabIndex = 180
        '
        'PW_PrescriptsBindingSource
        '
        Me.PW_PrescriptsBindingSource.DataMember = "PW_Prescripts"
        Me.PW_PrescriptsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PW_PrescriptsTableAdapter
        '
        Me.PW_PrescriptsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PW_PrescriptsTableAdapter = Me.PW_PrescriptsTableAdapter
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
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'Edit_Presscript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 848)
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
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Presscript"
        Me.Text = "Edit_Presscript"
        CType(Me.PW_PrescriptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents m_endDate As DateTimePicker
    Friend WithEvents m_startDate As DateTimePicker
    Friend WithEvents btnCheck_doc As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents doc_firstname As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents doc_lastname As TextBox
    Friend WithEvents btnCheck_medicine As Button
    Friend WithEvents btnCheck_patient As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents m_method As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pt_firstName As TextBox
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
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PW_PrescriptsBindingSource As BindingSource
    Friend WithEvents PW_PrescriptsTableAdapter As WellmeadowsDataSetTableAdapters.PW_PrescriptsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As WellmeadowsDataSetTableAdapters.PatientsTableAdapter
End Class
