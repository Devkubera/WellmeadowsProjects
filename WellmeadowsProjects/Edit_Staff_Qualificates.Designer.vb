<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Staff_Qualificates
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.exp_table = New System.Windows.Forms.DataGridView()
        Me.major = New System.Windows.Forms.TextBox()
        Me.cert = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.hiscompanylb = New System.Windows.Forms.Label()
        Me.hispositionlb = New System.Windows.Forms.Label()
        Me.btnAddRow2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.statuslb = New System.Windows.Forms.Label()
        Me.lnamelb = New System.Windows.Forms.Label()
        Me.Staff_number = New System.Windows.Forms.TextBox()
        Me.fnamelb = New System.Windows.Forms.Label()
        Me.Staff_name = New System.Windows.Forms.TextBox()
        Me.MedicalDirectorsTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.MedicalDirectorsTableAdapter()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.DoctorsTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.DoctorsTableAdapter()
        Me.Staff_QualificatesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Staff_QualificatesTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.Staff_ExperiencesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Staff_ExperiencesTableAdapter()
        Me.StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.StaffsTableAdapter()
        Me.StaffQualificatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_ExperiencesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChargeNursesTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.ChargeNursesTableAdapter()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.endDate = New System.Windows.Forms.DateTimePicker()
        Me.hisenddatelb = New System.Windows.Forms.Label()
        CType(Me.exp_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffQualificatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_ExperiencesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_delete.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(782, 601)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(135, 46)
        Me.btn_delete.TabIndex = 187
        Me.btn_delete.Text = "ลบข้อมูล"
        Me.btn_delete.UseVisualStyleBackColor = False
        Me.btn_delete.Visible = False
        '
        'exp_table
        '
        Me.exp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.exp_table.Location = New System.Drawing.Point(230, 131)
        Me.exp_table.Name = "exp_table"
        Me.exp_table.RowHeadersWidth = 51
        Me.exp_table.RowTemplate.Height = 24
        Me.exp_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.exp_table.Size = New System.Drawing.Size(911, 238)
        Me.exp_table.TabIndex = 183
        '
        'major
        '
        Me.major.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.major.Location = New System.Drawing.Point(852, 433)
        Me.major.Margin = New System.Windows.Forms.Padding(4)
        Me.major.Name = "major"
        Me.major.Size = New System.Drawing.Size(289, 33)
        Me.major.TabIndex = 181
        '
        'cert
        '
        Me.cert.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cert.Location = New System.Drawing.Point(529, 433)
        Me.cert.Margin = New System.Windows.Forms.Padding(4)
        Me.cert.Name = "cert"
        Me.cert.Size = New System.Drawing.Size(289, 33)
        Me.cert.TabIndex = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(597, 727)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 30)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "ตำแหน่ง"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LimeGreen
        Me.btnUpdate.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(602, 600)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 49)
        Me.btnUpdate.TabIndex = 177
        Me.btnUpdate.Text = "บันทึกข้อมูล"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'hiscompanylb
        '
        Me.hiscompanylb.AutoSize = True
        Me.hiscompanylb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hiscompanylb.Location = New System.Drawing.Point(847, 391)
        Me.hiscompanylb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hiscompanylb.Name = "hiscompanylb"
        Me.hiscompanylb.Size = New System.Drawing.Size(103, 30)
        Me.hiscompanylb.TabIndex = 172
        Me.hiscompanylb.Text = "คณะ/สาขา"
        '
        'hispositionlb
        '
        Me.hispositionlb.AutoSize = True
        Me.hispositionlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hispositionlb.Location = New System.Drawing.Point(524, 391)
        Me.hispositionlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hispositionlb.Name = "hispositionlb"
        Me.hispositionlb.Size = New System.Drawing.Size(124, 30)
        Me.hispositionlb.TabIndex = 171
        Me.hispositionlb.Text = "วุฒิการศึกษา"
        '
        'btnAddRow2
        '
        Me.btnAddRow2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddRow2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRow2.ForeColor = System.Drawing.Color.White
        Me.btnAddRow2.Location = New System.Drawing.Point(416, 601)
        Me.btnAddRow2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRow2.Name = "btnAddRow2"
        Me.btnAddRow2.Size = New System.Drawing.Size(135, 49)
        Me.btnAddRow2.TabIndex = 169
        Me.btnAddRow2.Text = "เพิ่มข้อมูล"
        Me.btnAddRow2.UseVisualStyleBackColor = False
        Me.btnAddRow2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(83, 236)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 167
        '
        'statuslb
        '
        Me.statuslb.AutoSize = True
        Me.statuslb.ForeColor = System.Drawing.Color.Red
        Me.statuslb.Location = New System.Drawing.Point(1283, 187)
        Me.statuslb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(0, 16)
        Me.statuslb.TabIndex = 167
        '
        'lnamelb
        '
        Me.lnamelb.AutoSize = True
        Me.lnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnamelb.Location = New System.Drawing.Point(225, 391)
        Me.lnamelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnamelb.Name = "lnamelb"
        Me.lnamelb.Size = New System.Drawing.Size(164, 30)
        Me.lnamelb.TabIndex = 135
        Me.lnamelb.Text = "หมายเลขพนักงาน"
        '
        'Staff_number
        '
        Me.Staff_number.Enabled = False
        Me.Staff_number.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_number.Location = New System.Drawing.Point(230, 433)
        Me.Staff_number.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_number.Name = "Staff_number"
        Me.Staff_number.Size = New System.Drawing.Size(253, 33)
        Me.Staff_number.TabIndex = 134
        '
        'fnamelb
        '
        Me.fnamelb.AutoSize = True
        Me.fnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnamelb.Location = New System.Drawing.Point(225, 487)
        Me.fnamelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fnamelb.Name = "fnamelb"
        Me.fnamelb.Size = New System.Drawing.Size(37, 30)
        Me.fnamelb.TabIndex = 132
        Me.fnamelb.Text = "ชื่อ"
        '
        'Staff_name
        '
        Me.Staff_name.Enabled = False
        Me.Staff_name.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_name.Location = New System.Drawing.Point(230, 528)
        Me.Staff_name.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_name.Name = "Staff_name"
        Me.Staff_name.Size = New System.Drawing.Size(253, 33)
        Me.Staff_name.TabIndex = 131
        '
        'MedicalDirectorsTableAdapter1
        '
        Me.MedicalDirectorsTableAdapter1.ClearBeforeFill = True
        '
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "Staffs"
        Me.StaffsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorsTableAdapter1
        '
        Me.DoctorsTableAdapter1.ClearBeforeFill = True
        '
        'Staff_QualificatesTableAdapter
        '
        Me.Staff_QualificatesTableAdapter.ClearBeforeFill = True
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
        'StaffQualificatesBindingSource
        '
        Me.StaffQualificatesBindingSource.DataMember = "Staff_Qualificates"
        Me.StaffQualificatesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Staff_ExperiencesBindingSource
        '
        Me.Staff_ExperiencesBindingSource.DataMember = "Staff_Experiences"
        Me.Staff_ExperiencesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'ChargeNursesTableAdapter1
        '
        Me.ChargeNursesTableAdapter1.ClearBeforeFill = True
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(510, 57)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(329, 40)
        Me.headerlb.TabIndex = 133
        Me.headerlb.Text = "แก้ไขข้อมูลประวัติการศึกษา"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.endDate)
        Me.Panel1.Controls.Add(Me.hisenddatelb)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.exp_table)
        Me.Panel1.Controls.Add(Me.major)
        Me.Panel1.Controls.Add(Me.cert)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.hiscompanylb)
        Me.Panel1.Controls.Add(Me.hispositionlb)
        Me.Panel1.Controls.Add(Me.btnAddRow2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.statuslb)
        Me.Panel1.Controls.Add(Me.lnamelb)
        Me.Panel1.Controls.Add(Me.Staff_number)
        Me.Panel1.Controls.Add(Me.headerlb)
        Me.Panel1.Controls.Add(Me.fnamelb)
        Me.Panel1.Controls.Add(Me.Staff_name)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1693, 874)
        Me.Panel1.TabIndex = 3
        '
        'endDate
        '
        Me.endDate.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.endDate.Location = New System.Drawing.Point(529, 530)
        Me.endDate.Margin = New System.Windows.Forms.Padding(4)
        Me.endDate.Name = "endDate"
        Me.endDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.endDate.Size = New System.Drawing.Size(612, 33)
        Me.endDate.TabIndex = 190
        '
        'hisenddatelb
        '
        Me.hisenddatelb.AutoSize = True
        Me.hisenddatelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hisenddatelb.Location = New System.Drawing.Point(524, 487)
        Me.hisenddatelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hisenddatelb.Name = "hisenddatelb"
        Me.hisenddatelb.Size = New System.Drawing.Size(154, 30)
        Me.hisenddatelb.TabIndex = 189
        Me.hisenddatelb.Text = "วันที่จบการศึกษา"
        '
        'Edit_Staff_Qualificates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1693, 874)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Edit_Staff_Qualificates"
        Me.Text = "Edit_Staff_Qualificates"
        CType(Me.exp_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffQualificatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_ExperiencesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_delete As Button
    Friend WithEvents exp_table As DataGridView
    Friend WithEvents major As TextBox
    Friend WithEvents cert As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents hiscompanylb As Label
    Friend WithEvents hispositionlb As Label
    Friend WithEvents btnAddRow2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents statuslb As Label
    Friend WithEvents lnamelb As Label
    Friend WithEvents Staff_number As TextBox
    Friend WithEvents fnamelb As Label
    Friend WithEvents Staff_name As TextBox
    Friend WithEvents MedicalDirectorsTableAdapter1 As WellmeadowsDataSetTableAdapters.MedicalDirectorsTableAdapter
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents DoctorsTableAdapter1 As WellmeadowsDataSetTableAdapters.DoctorsTableAdapter
    Friend WithEvents Staff_QualificatesTableAdapter As WellmeadowsDataSetTableAdapters.Staff_QualificatesTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Staff_ExperiencesTableAdapter As WellmeadowsDataSetTableAdapters.Staff_ExperiencesTableAdapter
    Friend WithEvents StaffsTableAdapter As WellmeadowsDataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents StaffQualificatesBindingSource As BindingSource
    Friend WithEvents Staff_ExperiencesBindingSource As BindingSource
    Friend WithEvents ChargeNursesTableAdapter1 As WellmeadowsDataSetTableAdapters.ChargeNursesTableAdapter
    Friend WithEvents headerlb As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents endDate As DateTimePicker
    Friend WithEvents hisenddatelb As Label
End Class
