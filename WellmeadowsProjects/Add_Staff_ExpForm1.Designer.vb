<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Staff_ExpForm1
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
        Me.old_endDate = New System.Windows.Forms.DateTimePicker()
        Me.old_startDate = New System.Windows.Forms.DateTimePicker()
        Me.hisenddatelb = New System.Windows.Forms.Label()
        Me.hisstartdatelb = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exp_table = New System.Windows.Forms.DataGridView()
        Me.old_company = New System.Windows.Forms.TextBox()
        Me.old_position = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hiscompanylb = New System.Windows.Forms.Label()
        Me.hispositionlb = New System.Windows.Forms.Label()
        Me.btn_check_staff = New System.Windows.Forms.Button()
        Me.btnAddRow2 = New System.Windows.Forms.Button()
        Me.statuslb = New System.Windows.Forms.Label()
        Me.lnamelb = New System.Windows.Forms.Label()
        Me.Staff_number = New System.Windows.Forms.TextBox()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.fnamelb = New System.Windows.Forms.Label()
        Me.Staff_name = New System.Windows.Forms.TextBox()
        Me.MedicalDirectorsTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.MedicalDirectorsTableAdapter()
        Me.ChargeNursesTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.ChargeNursesTableAdapter()
        Me.Staff_ExperiencesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.StaffsTableAdapter()
        Me.Staff_ExperiencesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Staff_ExperiencesTableAdapter()
        Me.StaffQualificatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_QualificatesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Staff_QualificatesTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.DoctorsTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.DoctorsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.exp_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_ExperiencesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffQualificatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'old_endDate
        '
        Me.old_endDate.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.old_endDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.old_endDate.Location = New System.Drawing.Point(863, 529)
        Me.old_endDate.Margin = New System.Windows.Forms.Padding(4)
        Me.old_endDate.Name = "old_endDate"
        Me.old_endDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.old_endDate.Size = New System.Drawing.Size(289, 33)
        Me.old_endDate.TabIndex = 190
        '
        'old_startDate
        '
        Me.old_startDate.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.old_startDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.old_startDate.Location = New System.Drawing.Point(540, 527)
        Me.old_startDate.Margin = New System.Windows.Forms.Padding(4)
        Me.old_startDate.Name = "old_startDate"
        Me.old_startDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.old_startDate.Size = New System.Drawing.Size(289, 33)
        Me.old_startDate.TabIndex = 191
        '
        'hisenddatelb
        '
        Me.hisenddatelb.AutoSize = True
        Me.hisenddatelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hisenddatelb.Location = New System.Drawing.Point(858, 486)
        Me.hisenddatelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hisenddatelb.Name = "hisenddatelb"
        Me.hisenddatelb.Size = New System.Drawing.Size(177, 30)
        Me.hisenddatelb.TabIndex = 189
        Me.hisenddatelb.Text = "วันทำงานวันสุดท้าย"
        '
        'hisstartdatelb
        '
        Me.hisstartdatelb.AutoSize = True
        Me.hisstartdatelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hisstartdatelb.Location = New System.Drawing.Point(535, 486)
        Me.hisstartdatelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hisstartdatelb.Name = "hisstartdatelb"
        Me.hisstartdatelb.Size = New System.Drawing.Size(151, 30)
        Me.hisstartdatelb.TabIndex = 188
        Me.hisstartdatelb.Text = "วันทำงานวันแรก"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.old_endDate)
        Me.Panel1.Controls.Add(Me.old_startDate)
        Me.Panel1.Controls.Add(Me.hisenddatelb)
        Me.Panel1.Controls.Add(Me.hisstartdatelb)
        Me.Panel1.Controls.Add(Me.exp_table)
        Me.Panel1.Controls.Add(Me.old_company)
        Me.Panel1.Controls.Add(Me.old_position)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.hiscompanylb)
        Me.Panel1.Controls.Add(Me.hispositionlb)
        Me.Panel1.Controls.Add(Me.btn_check_staff)
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
        Me.Panel1.Size = New System.Drawing.Size(1363, 667)
        Me.Panel1.TabIndex = 3
        '
        'exp_table
        '
        Me.exp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.exp_table.Location = New System.Drawing.Point(241, 130)
        Me.exp_table.Name = "exp_table"
        Me.exp_table.RowHeadersWidth = 51
        Me.exp_table.RowTemplate.Height = 24
        Me.exp_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.exp_table.Size = New System.Drawing.Size(911, 238)
        Me.exp_table.TabIndex = 183
        '
        'old_company
        '
        Me.old_company.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.old_company.Location = New System.Drawing.Point(863, 432)
        Me.old_company.Margin = New System.Windows.Forms.Padding(4)
        Me.old_company.Name = "old_company"
        Me.old_company.Size = New System.Drawing.Size(289, 33)
        Me.old_company.TabIndex = 181
        '
        'old_position
        '
        Me.old_position.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.old_position.Location = New System.Drawing.Point(540, 432)
        Me.old_position.Margin = New System.Windows.Forms.Padding(4)
        Me.old_position.Name = "old_position"
        Me.old_position.Size = New System.Drawing.Size(289, 33)
        Me.old_position.TabIndex = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(626, 600)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 30)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "ตำแหน่ง"
        '
        'hiscompanylb
        '
        Me.hiscompanylb.AutoSize = True
        Me.hiscompanylb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hiscompanylb.Location = New System.Drawing.Point(858, 390)
        Me.hiscompanylb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hiscompanylb.Name = "hiscompanylb"
        Me.hiscompanylb.Size = New System.Drawing.Size(97, 30)
        Me.hiscompanylb.TabIndex = 172
        Me.hiscompanylb.Text = "ชื่อองค์กร"
        '
        'hispositionlb
        '
        Me.hispositionlb.AutoSize = True
        Me.hispositionlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hispositionlb.Location = New System.Drawing.Point(535, 390)
        Me.hispositionlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hispositionlb.Name = "hispositionlb"
        Me.hispositionlb.Size = New System.Drawing.Size(198, 30)
        Me.hispositionlb.TabIndex = 171
        Me.hispositionlb.Text = "ตำแหน่ง (ที่ทำงานเก่า)"
        '
        'btn_check_staff
        '
        Me.btn_check_staff.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_check_staff.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check_staff.ForeColor = System.Drawing.Color.White
        Me.btn_check_staff.Location = New System.Drawing.Point(72, 424)
        Me.btn_check_staff.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_check_staff.Name = "btn_check_staff"
        Me.btn_check_staff.Size = New System.Drawing.Size(135, 49)
        Me.btn_check_staff.TabIndex = 169
        Me.btn_check_staff.Text = "ตรวจสอบ"
        Me.btn_check_staff.UseVisualStyleBackColor = False
        '
        'btnAddRow2
        '
        Me.btnAddRow2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddRow2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRow2.ForeColor = System.Drawing.Color.White
        Me.btnAddRow2.Location = New System.Drawing.Point(1017, 47)
        Me.btnAddRow2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRow2.Name = "btnAddRow2"
        Me.btnAddRow2.Size = New System.Drawing.Size(135, 49)
        Me.btnAddRow2.TabIndex = 169
        Me.btnAddRow2.Text = "เพิ่มข้อมูล"
        Me.btnAddRow2.UseVisualStyleBackColor = False
        '
        'statuslb
        '
        Me.statuslb.AutoSize = True
        Me.statuslb.ForeColor = System.Drawing.Color.Red
        Me.statuslb.Location = New System.Drawing.Point(1323, 186)
        Me.statuslb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(0, 16)
        Me.statuslb.TabIndex = 167
        '
        'lnamelb
        '
        Me.lnamelb.AutoSize = True
        Me.lnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnamelb.Location = New System.Drawing.Point(236, 390)
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
        Me.Staff_number.Location = New System.Drawing.Point(241, 432)
        Me.Staff_number.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_number.Name = "Staff_number"
        Me.Staff_number.Size = New System.Drawing.Size(253, 33)
        Me.Staff_number.TabIndex = 134
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(458, 56)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(423, 40)
        Me.headerlb.TabIndex = 133
        Me.headerlb.Text = "เพิ่มข้อมูลประวัติการทำงานเจ้าหน้าที่"
        '
        'fnamelb
        '
        Me.fnamelb.AutoSize = True
        Me.fnamelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnamelb.Location = New System.Drawing.Point(236, 486)
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
        Me.Staff_name.Location = New System.Drawing.Point(241, 527)
        Me.Staff_name.Margin = New System.Windows.Forms.Padding(4)
        Me.Staff_name.Name = "Staff_name"
        Me.Staff_name.Size = New System.Drawing.Size(253, 33)
        Me.Staff_name.TabIndex = 131
        '
        'MedicalDirectorsTableAdapter1
        '
        Me.MedicalDirectorsTableAdapter1.ClearBeforeFill = True
        '
        'ChargeNursesTableAdapter1
        '
        Me.ChargeNursesTableAdapter1.ClearBeforeFill = True
        '
        'Staff_ExperiencesBindingSource
        '
        Me.Staff_ExperiencesBindingSource.DataMember = "Staff_Experiences"
        Me.Staff_ExperiencesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
        '
        'Staff_ExperiencesTableAdapter
        '
        Me.Staff_ExperiencesTableAdapter.ClearBeforeFill = True
        '
        'StaffQualificatesBindingSource
        '
        Me.StaffQualificatesBindingSource.DataMember = "Staff_Qualificates"
        Me.StaffQualificatesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "Staffs"
        Me.StaffsBindingSource.DataSource = Me.WellmeadowsDataSet
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
        'DoctorsTableAdapter1
        '
        Me.DoctorsTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(31, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(31, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 192
        '
        'Add_Staff_ExpForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Add_Staff_ExpForm1"
        Me.Text = "Add_Staff_ExpForm1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.exp_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_ExperiencesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffQualificatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents old_endDate As DateTimePicker
    Friend WithEvents old_startDate As DateTimePicker
    Friend WithEvents hisenddatelb As Label
    Friend WithEvents hisstartdatelb As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents exp_table As DataGridView
    Friend WithEvents old_company As TextBox
    Friend WithEvents old_position As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents hiscompanylb As Label
    Friend WithEvents hispositionlb As Label
    Friend WithEvents btn_check_staff As Button
    Friend WithEvents btnAddRow2 As Button
    Friend WithEvents statuslb As Label
    Friend WithEvents lnamelb As Label
    Friend WithEvents Staff_number As TextBox
    Friend WithEvents headerlb As Label
    Friend WithEvents fnamelb As Label
    Friend WithEvents Staff_name As TextBox
    Friend WithEvents MedicalDirectorsTableAdapter1 As WellmeadowsDataSetTableAdapters.MedicalDirectorsTableAdapter
    Friend WithEvents ChargeNursesTableAdapter1 As WellmeadowsDataSetTableAdapters.ChargeNursesTableAdapter
    Friend WithEvents Staff_ExperiencesBindingSource As BindingSource
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents StaffsTableAdapter As WellmeadowsDataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents Staff_ExperiencesTableAdapter As WellmeadowsDataSetTableAdapters.Staff_ExperiencesTableAdapter
    Friend WithEvents StaffQualificatesBindingSource As BindingSource
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents Staff_QualificatesTableAdapter As WellmeadowsDataSetTableAdapters.Staff_QualificatesTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorsTableAdapter1 As WellmeadowsDataSetTableAdapters.DoctorsTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
