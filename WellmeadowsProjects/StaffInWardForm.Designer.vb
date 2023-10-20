<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffInWardForm
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
        Me.staffInWardPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ward_StaffsTable = New System.Windows.Forms.DataGridView()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbbWardId = New System.Windows.Forms.ComboBox()
        Me.StaffInWardlb = New System.Windows.Forms.Label()
        Me.WellmeadowsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.WardStaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ward_StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Ward_StaffsTableAdapter()
        Me.staffInWardPanel.SuspendLayout()
        CType(Me.Ward_StaffsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardStaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'staffInWardPanel
        '
        Me.staffInWardPanel.Controls.Add(Me.Label1)
        Me.staffInWardPanel.Controls.Add(Me.Ward_StaffsTable)
        Me.staffInWardPanel.Controls.Add(Me.btnDel)
        Me.staffInWardPanel.Controls.Add(Me.btnEdit)
        Me.staffInWardPanel.Controls.Add(Me.btnReport)
        Me.staffInWardPanel.Controls.Add(Me.btnAdd)
        Me.staffInWardPanel.Controls.Add(Me.cbbWardId)
        Me.staffInWardPanel.Controls.Add(Me.StaffInWardlb)
        Me.staffInWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.staffInWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.staffInWardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.staffInWardPanel.Name = "staffInWardPanel"
        Me.staffInWardPanel.Size = New System.Drawing.Size(1360, 800)
        Me.staffInWardPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(850, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 30)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "ค้นหาเจ้าหน้าที่ตามวอร์ด"
        '
        'Ward_StaffsTable
        '
        Me.Ward_StaffsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ward_StaffsTable.Location = New System.Drawing.Point(105, 187)
        Me.Ward_StaffsTable.Name = "Ward_StaffsTable"
        Me.Ward_StaffsTable.RowHeadersWidth = 51
        Me.Ward_StaffsTable.RowTemplate.Height = 24
        Me.Ward_StaffsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Ward_StaffsTable.Size = New System.Drawing.Size(1136, 410)
        Me.Ward_StaffsTable.TabIndex = 36
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(962, 634)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(160, 46)
        Me.btnDel.TabIndex = 35
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(789, 634)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 46)
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(609, 634)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(160, 46)
        Me.btnReport.TabIndex = 33
        Me.btnReport.Text = "สร้างรายงาน"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(1141, 634)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cbbWardId
        '
        Me.cbbWardId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbWardId.FormattingEnabled = True
        Me.cbbWardId.Items.AddRange(New Object() {"ทั้งหมด"})
        Me.cbbWardId.Location = New System.Drawing.Point(855, 118)
        Me.cbbWardId.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbWardId.Name = "cbbWardId"
        Me.cbbWardId.Size = New System.Drawing.Size(229, 38)
        Me.cbbWardId.TabIndex = 27
        '
        'StaffInWardlb
        '
        Me.StaffInWardlb.AutoSize = True
        Me.StaffInWardlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffInWardlb.Location = New System.Drawing.Point(97, 102)
        Me.StaffInWardlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StaffInWardlb.Name = "StaffInWardlb"
        Me.StaffInWardlb.Size = New System.Drawing.Size(298, 46)
        Me.StaffInWardlb.TabIndex = 26
        Me.StaffInWardlb.Text = "เจ้าหน้าที่ในแต่ละวอร์ด"
        '
        'WellmeadowsDataSetBindingSource
        '
        Me.WellmeadowsDataSetBindingSource.DataSource = Me.WellmeadowsDataSet
        Me.WellmeadowsDataSetBindingSource.Position = 0
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WardStaffsBindingSource
        '
        Me.WardStaffsBindingSource.DataMember = "Ward_Staffs"
        Me.WardStaffsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Ward_StaffsTableAdapter
        '
        Me.Ward_StaffsTableAdapter.ClearBeforeFill = True
        '
        'StaffInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 800)
        Me.Controls.Add(Me.staffInWardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StaffInWardForm"
        Me.Text = "เจ้าหน้าที่ในแต่ละวอร์ด"
        Me.staffInWardPanel.ResumeLayout(False)
        Me.staffInWardPanel.PerformLayout()
        CType(Me.Ward_StaffsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardStaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents staffInWardPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbbWardId As ComboBox
    Friend WithEvents StaffInWardlb As Label
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents WardStaffsBindingSource As BindingSource
    Friend WithEvents Ward_StaffsTableAdapter As WellmeadowsDataSetTableAdapters.Ward_StaffsTableAdapter
    Friend WithEvents Ward_StaffsTable As DataGridView
    Friend WithEvents WellmeadowsDataSetBindingSource As BindingSource
    Friend WithEvents Label1 As Label
End Class
