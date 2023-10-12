<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_StaffInWardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_StaffInWardForm))
        Me.editStaffInWardPanel = New System.Windows.Forms.Panel()
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Ward_StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ward_StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Ward_StaffsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.Ward_StaffsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Ward_StaffsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.editStaffInWardPanel.SuspendLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ward_StaffsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'editStaffInWardPanel
        '
        Me.editStaffInWardPanel.Controls.Add(Me.Label6)
        Me.editStaffInWardPanel.Controls.Add(Me.endTime)
        Me.editStaffInWardPanel.Controls.Add(Me.Label5)
        Me.editStaffInWardPanel.Controls.Add(Me.Label4)
        Me.editStaffInWardPanel.Controls.Add(Me.Label3)
        Me.editStaffInWardPanel.Controls.Add(Me.Label2)
        Me.editStaffInWardPanel.Controls.Add(Me.Label1)
        Me.editStaffInWardPanel.Controls.Add(Me.lastname)
        Me.editStaffInWardPanel.Controls.Add(Me.firstname)
        Me.editStaffInWardPanel.Controls.Add(Me.ShiftTime)
        Me.editStaffInWardPanel.Controls.Add(Me.btnCheck_shift)
        Me.editStaffInWardPanel.Controls.Add(Me.btnCheck_ward)
        Me.editStaffInWardPanel.Controls.Add(Me.btnCheck_staff)
        Me.editStaffInWardPanel.Controls.Add(Me.shiftlb)
        Me.editStaffInWardPanel.Controls.Add(Me.wardIdlb)
        Me.editStaffInWardPanel.Controls.Add(Me.wardId)
        Me.editStaffInWardPanel.Controls.Add(Me.staffIdlb)
        Me.editStaffInWardPanel.Controls.Add(Me.staffId)
        Me.editStaffInWardPanel.Controls.Add(Me.btnEdit)
        Me.editStaffInWardPanel.Controls.Add(Me.btnClear)
        Me.editStaffInWardPanel.Controls.Add(Me.headerlb)
        Me.editStaffInWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editStaffInWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.editStaffInWardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.editStaffInWardPanel.Name = "editStaffInWardPanel"
        Me.editStaffInWardPanel.Size = New System.Drawing.Size(1423, 752)
        Me.editStaffInWardPanel.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(701, 401)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 26)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "เวลาเลิกงาน"
        '
        'endTime
        '
        Me.endTime.Location = New System.Drawing.Point(706, 431)
        Me.endTime.Margin = New System.Windows.Forms.Padding(4)
        Me.endTime.Name = "endTime"
        Me.endTime.Size = New System.Drawing.Size(184, 22)
        Me.endTime.TabIndex = 176
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(486, 401)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 26)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "เวลาเริ่มทำงาน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(486, 301)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 26)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "หมายเลขวอร์ด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(923, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 26)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "นามสกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(701, 207)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 26)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "ชื่อ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 26)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "หมายเลขพนักงาน"
        '
        'lastname
        '
        Me.lastname.Location = New System.Drawing.Point(928, 237)
        Me.lastname.Margin = New System.Windows.Forms.Padding(4)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(184, 22)
        Me.lastname.TabIndex = 170
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(706, 237)
        Me.firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(184, 22)
        Me.firstname.TabIndex = 169
        '
        'ShiftTime
        '
        Me.ShiftTime.Location = New System.Drawing.Point(491, 431)
        Me.ShiftTime.Margin = New System.Windows.Forms.Padding(4)
        Me.ShiftTime.Name = "ShiftTime"
        Me.ShiftTime.Size = New System.Drawing.Size(184, 22)
        Me.ShiftTime.TabIndex = 168
        '
        'btnCheck_shift
        '
        Me.btnCheck_shift.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_shift.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_shift.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_shift.Location = New System.Drawing.Point(240, 421)
        Me.btnCheck_shift.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_shift.Name = "btnCheck_shift"
        Me.btnCheck_shift.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_shift.TabIndex = 167
        Me.btnCheck_shift.Text = "ตรวจสอบ"
        Me.btnCheck_shift.UseVisualStyleBackColor = False
        '
        'btnCheck_ward
        '
        Me.btnCheck_ward.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_ward.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_ward.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_ward.Location = New System.Drawing.Point(240, 321)
        Me.btnCheck_ward.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_ward.Name = "btnCheck_ward"
        Me.btnCheck_ward.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_ward.TabIndex = 166
        Me.btnCheck_ward.Text = "ตรวจสอบ"
        Me.btnCheck_ward.UseVisualStyleBackColor = False
        '
        'btnCheck_staff
        '
        Me.btnCheck_staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_staff.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_staff.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_staff.Location = New System.Drawing.Point(235, 227)
        Me.btnCheck_staff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck_staff.Name = "btnCheck_staff"
        Me.btnCheck_staff.Size = New System.Drawing.Size(188, 38)
        Me.btnCheck_staff.TabIndex = 165
        Me.btnCheck_staff.Text = "ตรวจสอบ"
        Me.btnCheck_staff.UseVisualStyleBackColor = False
        '
        'shiftlb
        '
        Me.shiftlb.AutoSize = True
        Me.shiftlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftlb.Location = New System.Drawing.Point(233, 381)
        Me.shiftlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.shiftlb.Name = "shiftlb"
        Me.shiftlb.Size = New System.Drawing.Size(169, 36)
        Me.shiftlb.TabIndex = 164
        Me.shiftlb.Text = "ช่วงเวลาทำงาน"
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(233, 281)
        Me.wardIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(131, 36)
        Me.wardIdlb.TabIndex = 163
        Me.wardIdlb.Text = "ข้อมูลวอร์ด"
        '
        'wardId
        '
        Me.wardId.Location = New System.Drawing.Point(491, 331)
        Me.wardId.Margin = New System.Windows.Forms.Padding(4)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(184, 22)
        Me.wardId.TabIndex = 162
        '
        'staffIdlb
        '
        Me.staffIdlb.AutoSize = True
        Me.staffIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffIdlb.Location = New System.Drawing.Point(233, 178)
        Me.staffIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.staffIdlb.Name = "staffIdlb"
        Me.staffIdlb.Size = New System.Drawing.Size(163, 36)
        Me.staffIdlb.TabIndex = 161
        Me.staffIdlb.Text = "ข้อมูลพนักงาน"
        '
        'staffId
        '
        Me.staffId.Location = New System.Drawing.Point(491, 237)
        Me.staffId.Margin = New System.Windows.Forms.Padding(4)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(184, 22)
        Me.staffId.TabIndex = 160
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(1133, 47)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 46)
        Me.btnEdit.TabIndex = 97
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.headerlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(459, 47)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(385, 31)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "แก้ไขข้อมูลเจ้าหน้าที่ในแต่ละวอร์ด"
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
        'Ward_StaffsBindingNavigator
        '
        Me.Ward_StaffsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Ward_StaffsBindingNavigator.BindingSource = Me.Ward_StaffsBindingSource
        Me.Ward_StaffsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Ward_StaffsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Ward_StaffsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Ward_StaffsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Ward_StaffsBindingNavigatorSaveItem})
        Me.Ward_StaffsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Ward_StaffsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Ward_StaffsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Ward_StaffsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Ward_StaffsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Ward_StaffsBindingNavigator.Name = "Ward_StaffsBindingNavigator"
        Me.Ward_StaffsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Ward_StaffsBindingNavigator.Size = New System.Drawing.Size(1423, 29)
        Me.Ward_StaffsBindingNavigator.TabIndex = 2
        Me.Ward_StaffsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Ward_StaffsBindingNavigatorSaveItem
        '
        Me.Ward_StaffsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ward_StaffsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Ward_StaffsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Ward_StaffsBindingNavigatorSaveItem.Name = "Ward_StaffsBindingNavigatorSaveItem"
        Me.Ward_StaffsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Ward_StaffsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Edit_StaffInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 752)
        Me.Controls.Add(Me.Ward_StaffsBindingNavigator)
        Me.Controls.Add(Me.editStaffInWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Edit_StaffInWardForm"
        Me.Text = "แก้ไขข้อมูลเจ้าหน้าที่ในแต่ละวอร์ด"
        Me.editStaffInWardPanel.ResumeLayout(False)
        Me.editStaffInWardPanel.PerformLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ward_StaffsBindingNavigator.ResumeLayout(False)
        Me.Ward_StaffsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents editStaffInWardPanel As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents headerlb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents endTime As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents firstname As TextBox
    Friend WithEvents ShiftTime As TextBox
    Friend WithEvents btnCheck_shift As Button
    Friend WithEvents btnCheck_ward As Button
    Friend WithEvents btnCheck_staff As Button
    Friend WithEvents shiftlb As Label
    Friend WithEvents wardIdlb As Label
    Friend WithEvents wardId As TextBox
    Friend WithEvents staffIdlb As Label
    Friend WithEvents staffId As TextBox
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents Ward_StaffsBindingSource As BindingSource
    Friend WithEvents Ward_StaffsTableAdapter As WellmeadowsDataSetTableAdapters.Ward_StaffsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Ward_StaffsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Ward_StaffsBindingNavigatorSaveItem As ToolStripButton
End Class
