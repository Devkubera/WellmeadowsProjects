<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffForm
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
        Me.StaffPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.searchlb = New System.Windows.Forms.Label()
        Me.StaffTable = New System.Windows.Forms.DataGridView()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.cbbEduLevel = New System.Windows.Forms.ComboBox()
        Me.Stafflabel = New System.Windows.Forms.Label()
        Me.cbbEduOrExp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.StaffsTableAdapter()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursWeekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffPanel.SuspendLayout()
        CType(Me.StaffTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffPanel
        '
        Me.StaffPanel.Controls.Add(Me.Label2)
        Me.StaffPanel.Controls.Add(Me.Label1)
        Me.StaffPanel.Controls.Add(Me.btnDel)
        Me.StaffPanel.Controls.Add(Me.btnEdit)
        Me.StaffPanel.Controls.Add(Me.btnAdd)
        Me.StaffPanel.Controls.Add(Me.searchlb)
        Me.StaffPanel.Controls.Add(Me.StaffTable)
        Me.StaffPanel.Controls.Add(Me.SearchStaff)
        Me.StaffPanel.Controls.Add(Me.cbbEduLevel)
        Me.StaffPanel.Controls.Add(Me.Stafflabel)
        Me.StaffPanel.Controls.Add(Me.cbbEduOrExp)
        Me.StaffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffPanel.Location = New System.Drawing.Point(0, 0)
        Me.StaffPanel.Name = "StaffPanel"
        Me.StaffPanel.Size = New System.Drawing.Size(1041, 749)
        Me.StaffPanel.TabIndex = 0
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(819, 534)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(120, 37)
        Me.btnDel.TabIndex = 24
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(689, 534)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 37)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(864, 109)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 37)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'searchlb
        '
        Me.searchlb.AutoSize = True
        Me.searchlb.Font = New System.Drawing.Font("Prompt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlb.Location = New System.Drawing.Point(618, 91)
        Me.searchlb.Name = "searchlb"
        Me.searchlb.Size = New System.Drawing.Size(194, 22)
        Me.searchlb.TabIndex = 21
        Me.searchlb.Text = "ค้นหาเจ้าหน้าที่ด้วยชื่อองค์กร.."
        '
        'StaffTable
        '
        Me.StaffTable.AllowUserToAddRows = False
        Me.StaffTable.AllowUserToDeleteRows = False
        Me.StaffTable.AllowUserToOrderColumns = True
        Me.StaffTable.AutoGenerateColumns = False
        Me.StaffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.DoctorIDDataGridViewTextBoxColumn, Me.CnIDDataGridViewTextBoxColumn, Me.MdIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.NinDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.HoursWeekDataGridViewTextBoxColumn, Me.ContactTypeDataGridViewTextBoxColumn, Me.PaidTypeDataGridViewTextBoxColumn})
        Me.StaffTable.DataSource = Me.StaffsBindingSource
        Me.StaffTable.Location = New System.Drawing.Point(86, 170)
        Me.StaffTable.Name = "StaffTable"
        Me.StaffTable.ReadOnly = True
        Me.StaffTable.RowHeadersWidth = 51
        Me.StaffTable.Size = New System.Drawing.Size(853, 328)
        Me.StaffTable.TabIndex = 20
        '
        'SearchStaff
        '
        Me.SearchStaff.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchStaff.Location = New System.Drawing.Point(622, 113)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(219, 33)
        Me.SearchStaff.TabIndex = 18
        '
        'cbbEduLevel
        '
        Me.cbbEduLevel.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbEduLevel.FormattingEnabled = True
        Me.cbbEduLevel.Items.AddRange(New Object() {"ปริญญาตรี", "ปริญญาโท", "ปริญญาเอก"})
        Me.cbbEduLevel.Location = New System.Drawing.Point(414, 112)
        Me.cbbEduLevel.Name = "cbbEduLevel"
        Me.cbbEduLevel.Size = New System.Drawing.Size(176, 34)
        Me.cbbEduLevel.TabIndex = 17
        '
        'Stafflabel
        '
        Me.Stafflabel.AutoSize = True
        Me.Stafflabel.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stafflabel.Location = New System.Drawing.Point(81, 103)
        Me.Stafflabel.Name = "Stafflabel"
        Me.Stafflabel.Size = New System.Drawing.Size(87, 46)
        Me.Stafflabel.TabIndex = 15
        Me.Stafflabel.Text = "Staff"
        '
        'cbbEduOrExp
        '
        Me.cbbEduOrExp.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbEduOrExp.FormattingEnabled = True
        Me.cbbEduOrExp.Items.AddRange(New Object() {"เจ้าหน้าที่", "ประวัติการศึกษา", "ประวัติการทำงาน"})
        Me.cbbEduOrExp.Location = New System.Drawing.Point(198, 112)
        Me.cbbEduOrExp.Name = "cbbEduOrExp"
        Me.cbbEduOrExp.Size = New System.Drawing.Size(183, 34)
        Me.cbbEduOrExp.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "วุฒิการศึกษา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "วิธีการแสดงข้อมูล"
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID"
        Me.StaffIDDataGridViewTextBoxColumn.Frozen = True
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "รหัสเจ้าหน้าที่"
        Me.StaffIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffIDDataGridViewTextBoxColumn.Width = 125
        '
        'DoctorIDDataGridViewTextBoxColumn
        '
        Me.DoctorIDDataGridViewTextBoxColumn.DataPropertyName = "doctorID"
        Me.DoctorIDDataGridViewTextBoxColumn.HeaderText = "รหัสแพทย์"
        Me.DoctorIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DoctorIDDataGridViewTextBoxColumn.Name = "DoctorIDDataGridViewTextBoxColumn"
        Me.DoctorIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DoctorIDDataGridViewTextBoxColumn.Width = 125
        '
        'CnIDDataGridViewTextBoxColumn
        '
        Me.CnIDDataGridViewTextBoxColumn.DataPropertyName = "cnID"
        Me.CnIDDataGridViewTextBoxColumn.HeaderText = "รหัสหัวหน้าพยาบาล"
        Me.CnIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CnIDDataGridViewTextBoxColumn.Name = "CnIDDataGridViewTextBoxColumn"
        Me.CnIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CnIDDataGridViewTextBoxColumn.Width = 125
        '
        'MdIDDataGridViewTextBoxColumn
        '
        Me.MdIDDataGridViewTextBoxColumn.DataPropertyName = "mdID"
        Me.MdIDDataGridViewTextBoxColumn.HeaderText = "รหัสผู้อำนวยการทางการแพทย์"
        Me.MdIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MdIDDataGridViewTextBoxColumn.Name = "MdIDDataGridViewTextBoxColumn"
        Me.MdIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MdIDDataGridViewTextBoxColumn.Width = 125
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "ชื่อ"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "สกุล"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "ที่อยู่"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์"
        Me.TelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelDataGridViewTextBoxColumn.Width = 125
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "วันเกิด"
        Me.DobDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.ReadOnly = True
        Me.DobDataGridViewTextBoxColumn.Width = 125
        '
        'NinDataGridViewTextBoxColumn
        '
        Me.NinDataGridViewTextBoxColumn.DataPropertyName = "nin"
        Me.NinDataGridViewTextBoxColumn.HeaderText = "หมายเลขประกันสังคม"
        Me.NinDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NinDataGridViewTextBoxColumn.Name = "NinDataGridViewTextBoxColumn"
        Me.NinDataGridViewTextBoxColumn.ReadOnly = True
        Me.NinDataGridViewTextBoxColumn.Width = 125
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "ตำแหน่ง"
        Me.PositionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn.Width = 125
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "เงินเดือน"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalaryDataGridViewTextBoxColumn.Width = 125
        '
        'HoursWeekDataGridViewTextBoxColumn
        '
        Me.HoursWeekDataGridViewTextBoxColumn.DataPropertyName = "hoursWeek"
        Me.HoursWeekDataGridViewTextBoxColumn.HeaderText = "จำนวนชั่วโมงทำงานต่อสัปดาห์"
        Me.HoursWeekDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoursWeekDataGridViewTextBoxColumn.Name = "HoursWeekDataGridViewTextBoxColumn"
        Me.HoursWeekDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoursWeekDataGridViewTextBoxColumn.Width = 125
        '
        'ContactTypeDataGridViewTextBoxColumn
        '
        Me.ContactTypeDataGridViewTextBoxColumn.DataPropertyName = "contactType"
        Me.ContactTypeDataGridViewTextBoxColumn.HeaderText = "ประเภทสัญญาจ้าง"
        Me.ContactTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactTypeDataGridViewTextBoxColumn.Name = "ContactTypeDataGridViewTextBoxColumn"
        Me.ContactTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactTypeDataGridViewTextBoxColumn.Width = 125
        '
        'PaidTypeDataGridViewTextBoxColumn
        '
        Me.PaidTypeDataGridViewTextBoxColumn.DataPropertyName = "paidType"
        Me.PaidTypeDataGridViewTextBoxColumn.HeaderText = "วิธีรับเงินเดือน"
        Me.PaidTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaidTypeDataGridViewTextBoxColumn.Name = "PaidTypeDataGridViewTextBoxColumn"
        Me.PaidTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaidTypeDataGridViewTextBoxColumn.Width = 125
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 749)
        Me.Controls.Add(Me.StaffPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffForm"
        Me.Text = "StaffForm"
        Me.StaffPanel.ResumeLayout(False)
        Me.StaffPanel.PerformLayout()
        CType(Me.StaffTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents searchlb As Label
    Friend WithEvents StaffTable As DataGridView
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents cbbEduLevel As ComboBox
    Friend WithEvents Stafflabel As Label
    Friend WithEvents cbbEduOrExp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents StaffsTableAdapter As WellmeadowsDataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoctorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MdIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursWeekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaidTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
