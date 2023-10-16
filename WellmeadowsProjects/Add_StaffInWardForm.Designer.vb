<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_StaffInWardForm
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
        Me.addStaffPanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.endTime = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.ShiftTime = New System.Windows.Forms.TextBox()
        Me.btnCheck_shift = New System.Windows.Forms.Button()
        Me.btnCheck_ward = New System.Windows.Forms.Button()
        Me.btnCheck_staff = New System.Windows.Forms.Button()
        Me.shiftlb = New System.Windows.Forms.Label()
        Me.wardIdlb = New System.Windows.Forms.Label()
        Me.wardId = New System.Windows.Forms.TextBox()
        Me.staffIdlb = New System.Windows.Forms.Label()
        Me.staffId = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Ward_StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ward_StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Ward_StaffsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.addStaffPanel.SuspendLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addStaffPanel
        '
        Me.addStaffPanel.Controls.Add(Me.Label6)
        Me.addStaffPanel.Controls.Add(Me.endTime)
        Me.addStaffPanel.Controls.Add(Me.Label5)
        Me.addStaffPanel.Controls.Add(Me.Label4)
        Me.addStaffPanel.Controls.Add(Me.Label3)
        Me.addStaffPanel.Controls.Add(Me.Label2)
        Me.addStaffPanel.Controls.Add(Me.Label1)
        Me.addStaffPanel.Controls.Add(Me.lastname)
        Me.addStaffPanel.Controls.Add(Me.firstname)
        Me.addStaffPanel.Controls.Add(Me.ShiftTime)
        Me.addStaffPanel.Controls.Add(Me.btnCheck_shift)
        Me.addStaffPanel.Controls.Add(Me.btnCheck_ward)
        Me.addStaffPanel.Controls.Add(Me.btnCheck_staff)
        Me.addStaffPanel.Controls.Add(Me.shiftlb)
        Me.addStaffPanel.Controls.Add(Me.wardIdlb)
        Me.addStaffPanel.Controls.Add(Me.wardId)
        Me.addStaffPanel.Controls.Add(Me.staffIdlb)
        Me.addStaffPanel.Controls.Add(Me.staffId)
        Me.addStaffPanel.Controls.Add(Me.btnSubmit)
        Me.addStaffPanel.Controls.Add(Me.btnClear)
        Me.addStaffPanel.Controls.Add(Me.headerlb)
        Me.addStaffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addStaffPanel.Location = New System.Drawing.Point(0, 0)
        Me.addStaffPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.addStaffPanel.Name = "addStaffPanel"
        Me.addStaffPanel.Size = New System.Drawing.Size(1339, 752)
        Me.addStaffPanel.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(702, 387)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 30)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "เวลาเลิกงาน"
        '
        'endTime
        '
        Me.endTime.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endTime.Location = New System.Drawing.Point(707, 430)
        Me.endTime.Margin = New System.Windows.Forms.Padding(4)
        Me.endTime.Name = "endTime"
        Me.endTime.Size = New System.Drawing.Size(184, 38)
        Me.endTime.TabIndex = 158
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(487, 387)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 30)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "เวลาเริ่มทำงาน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(487, 287)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 30)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "หมายเลขวอร์ด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(924, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 30)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "นามสกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(702, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 30)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "ชื่อ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(487, 193)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 30)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "หมายเลขพนักงาน"
        '
        'lastname
        '
        Me.lastname.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(929, 236)
        Me.lastname.Margin = New System.Windows.Forms.Padding(4)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(184, 38)
        Me.lastname.TabIndex = 152
        '
        'firstname
        '
        Me.firstname.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(707, 236)
        Me.firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(184, 38)
        Me.firstname.TabIndex = 151
        '
        'ShiftTime
        '
        Me.ShiftTime.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftTime.Location = New System.Drawing.Point(492, 430)
        Me.ShiftTime.Margin = New System.Windows.Forms.Padding(4)
        Me.ShiftTime.Name = "ShiftTime"
        Me.ShiftTime.Size = New System.Drawing.Size(184, 38)
        Me.ShiftTime.TabIndex = 150
        '
        'btnCheck_shift
        '
        Me.btnCheck_shift.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_shift.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_shift.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_shift.Location = New System.Drawing.Point(241, 430)
        Me.btnCheck_shift.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_shift.Name = "btnCheck_shift"
        Me.btnCheck_shift.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_shift.TabIndex = 149
        Me.btnCheck_shift.Text = "ตรวจสอบ"
        Me.btnCheck_shift.UseVisualStyleBackColor = False
        '
        'btnCheck_ward
        '
        Me.btnCheck_ward.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_ward.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_ward.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_ward.Location = New System.Drawing.Point(241, 330)
        Me.btnCheck_ward.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_ward.Name = "btnCheck_ward"
        Me.btnCheck_ward.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_ward.TabIndex = 148
        Me.btnCheck_ward.Text = "ตรวจสอบ"
        Me.btnCheck_ward.UseVisualStyleBackColor = False
        '
        'btnCheck_staff
        '
        Me.btnCheck_staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_staff.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_staff.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_staff.Location = New System.Drawing.Point(236, 236)
        Me.btnCheck_staff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_staff.Name = "btnCheck_staff"
        Me.btnCheck_staff.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_staff.TabIndex = 147
        Me.btnCheck_staff.Text = "ตรวจสอบ"
        Me.btnCheck_staff.UseVisualStyleBackColor = False
        '
        'shiftlb
        '
        Me.shiftlb.AutoSize = True
        Me.shiftlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftlb.Location = New System.Drawing.Point(234, 390)
        Me.shiftlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.shiftlb.Name = "shiftlb"
        Me.shiftlb.Size = New System.Drawing.Size(169, 36)
        Me.shiftlb.TabIndex = 103
        Me.shiftlb.Text = "ช่วงเวลาทำงาน"
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(234, 290)
        Me.wardIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(131, 36)
        Me.wardIdlb.TabIndex = 101
        Me.wardIdlb.Text = "ข้อมูลวอร์ด"
        '
        'wardId
        '
        Me.wardId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardId.Location = New System.Drawing.Point(492, 330)
        Me.wardId.Margin = New System.Windows.Forms.Padding(4)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(184, 38)
        Me.wardId.TabIndex = 100
        '
        'staffIdlb
        '
        Me.staffIdlb.AutoSize = True
        Me.staffIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffIdlb.Location = New System.Drawing.Point(234, 187)
        Me.staffIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.staffIdlb.Name = "staffIdlb"
        Me.staffIdlb.Size = New System.Drawing.Size(163, 36)
        Me.staffIdlb.TabIndex = 99
        Me.staffIdlb.Text = "ข้อมูลพนักงาน"
        '
        'staffId
        '
        Me.staffId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffId.Location = New System.Drawing.Point(492, 236)
        Me.staffId.Margin = New System.Windows.Forms.Padding(4)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(184, 38)
        Me.staffId.TabIndex = 98
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1133, 47)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 46)
        Me.btnSubmit.TabIndex = 97
        Me.btnSubmit.Text = "เพิ่ม"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(953, 47)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 46)
        Me.btnClear.TabIndex = 96
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(459, 47)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(400, 43)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "เพิ่มข้อมูลเจ้าหน้าที่ในแต่ละวอร์ด"
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ward_StaffsBindingSource
        '
        Me.Ward_StaffsBindingSource.DataMember = "Ward_Staffs"
        Me.Ward_StaffsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Ward_StaffsTableAdapter
        '
        Me.Ward_StaffsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Staff_ExperiencesTableAdapter = Nothing
        Me.TableAdapterManager.Staff_QualificatesTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppilersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Me.Ward_StaffsTableAdapter
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'Add_StaffInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.addStaffPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_StaffInWardForm"
        Me.Text = "เพิ่มข้อมูลเจ้าหน้าที่ในแต่ละวอร์ด"
        Me.addStaffPanel.ResumeLayout(False)
        Me.addStaffPanel.PerformLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addStaffPanel As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents headerlb As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents staffIdlb As Label
    Friend WithEvents wardIdlb As Label
    Friend WithEvents wardId As TextBox
    Friend WithEvents shiftlb As Label
    Friend WithEvents btnCheck_ward As Button
    Friend WithEvents btnCheck_staff As Button
    Friend WithEvents btnCheck_shift As Button
    Friend WithEvents staffId As TextBox
    Friend WithEvents ShiftTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents endTime As TextBox
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents Ward_StaffsBindingSource As BindingSource
    Friend WithEvents Ward_StaffsTableAdapter As WellmeadowsDataSetTableAdapters.Ward_StaffsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
End Class
