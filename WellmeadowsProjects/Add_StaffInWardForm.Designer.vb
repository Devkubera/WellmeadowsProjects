<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_StaffInWardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_StaffInWardForm))
        Me.addStaffPanel = New System.Windows.Forms.Panel()
        Me.Shift = New System.Windows.Forms.ComboBox()
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
        Me.addStaffPanel.SuspendLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ward_StaffsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'addStaffPanel
        '
        Me.addStaffPanel.Controls.Add(Me.Shift)
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
        Me.addStaffPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addStaffPanel.Name = "addStaffPanel"
        Me.addStaffPanel.Size = New System.Drawing.Size(1339, 847)
        Me.addStaffPanel.TabIndex = 0
        '
        'Shift
        '
        Me.Shift.FormattingEnabled = True
        Me.Shift.Items.AddRange(New Object() {"เช้า", "กลางวัน", "กลางคืน"})
        Me.Shift.Location = New System.Drawing.Point(253, 300)
        Me.Shift.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Shift.Name = "Shift"
        Me.Shift.Size = New System.Drawing.Size(184, 24)
        Me.Shift.TabIndex = 104
        '
        'shiftlb
        '
        Me.shiftlb.AutoSize = True
        Me.shiftlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftlb.Location = New System.Drawing.Point(247, 261)
        Me.shiftlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.shiftlb.Name = "shiftlb"
        Me.shiftlb.Size = New System.Drawing.Size(103, 36)
        Me.shiftlb.TabIndex = 103
        Me.shiftlb.Text = "กะทำงาน"
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(500, 156)
        Me.wardIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(163, 36)
        Me.wardIdlb.TabIndex = 101
        Me.wardIdlb.Text = "หมายเลขวอร์ด"
        '
        'wardId
        '
        Me.wardId.Location = New System.Drawing.Point(507, 196)
        Me.wardId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(184, 22)
        Me.wardId.TabIndex = 100
        '
        'staffIdlb
        '
        Me.staffIdlb.AutoSize = True
        Me.staffIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffIdlb.Location = New System.Drawing.Point(247, 156)
        Me.staffIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.staffIdlb.Name = "staffIdlb"
        Me.staffIdlb.Size = New System.Drawing.Size(195, 36)
        Me.staffIdlb.TabIndex = 99
        Me.staffIdlb.Text = "หมายเลขพนักงาน"
        '
        'staffId
        '
        Me.staffId.Location = New System.Drawing.Point(253, 196)
        Me.staffId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(184, 22)
        Me.staffId.TabIndex = 98
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1133, 47)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 46)
        Me.btnSubmit.TabIndex = 97
        Me.btnSubmit.Text = "เพิ่ม"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(953, 47)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.headerlb.Size = New System.Drawing.Size(368, 31)
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
        Me.Ward_StaffsBindingNavigator.Size = New System.Drawing.Size(1339, 27)
        Me.Ward_StaffsBindingNavigator.TabIndex = 1
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
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
        'Add_StaffInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 847)
        Me.Controls.Add(Me.Ward_StaffsBindingNavigator)
        Me.Controls.Add(Me.addStaffPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Add_StaffInWardForm"
        Me.Text = "เพิ่มข้อมูลเจ้าหน้าที่ในแต่ละวอร์ด"
        Me.addStaffPanel.ResumeLayout(False)
        Me.addStaffPanel.PerformLayout()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ward_StaffsBindingNavigator.ResumeLayout(False)
        Me.Ward_StaffsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addStaffPanel As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents headerlb As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents staffId As TextBox
    Friend WithEvents staffIdlb As Label
    Friend WithEvents wardIdlb As Label
    Friend WithEvents wardId As TextBox
    Friend WithEvents shiftlb As Label
    Friend WithEvents Shift As ComboBox
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
