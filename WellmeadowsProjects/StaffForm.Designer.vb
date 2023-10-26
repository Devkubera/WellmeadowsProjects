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
        Me.DataGridV1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.searchlb = New System.Windows.Forms.Label()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.cbbEduLevel = New System.Windows.Forms.ComboBox()
        Me.Stafflabel = New System.Windows.Forms.Label()
        Me.cbbEduOrExp = New System.Windows.Forms.ComboBox()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StaffPanel.SuspendLayout()
        CType(Me.DataGridV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffPanel
        '
        Me.StaffPanel.Controls.Add(Me.DataGridV1)
        Me.StaffPanel.Controls.Add(Me.Label2)
        Me.StaffPanel.Controls.Add(Me.Label1)
        Me.StaffPanel.Controls.Add(Me.btnDel)
        Me.StaffPanel.Controls.Add(Me.btnEdit)
        Me.StaffPanel.Controls.Add(Me.btnAdd)
        Me.StaffPanel.Controls.Add(Me.searchlb)
        Me.StaffPanel.Controls.Add(Me.SearchStaff)
        Me.StaffPanel.Controls.Add(Me.cbbEduLevel)
        Me.StaffPanel.Controls.Add(Me.Stafflabel)
        Me.StaffPanel.Controls.Add(Me.cbbEduOrExp)
        Me.StaffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffPanel.Location = New System.Drawing.Point(0, 0)
        Me.StaffPanel.Name = "StaffPanel"
        Me.StaffPanel.Size = New System.Drawing.Size(1041, 811)
        Me.StaffPanel.TabIndex = 0
        '
        'DataGridV1
        '
        Me.DataGridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridV1.Location = New System.Drawing.Point(89, 195)
        Me.DataGridV1.Name = "DataGridV1"
        Me.DataGridV1.RowHeadersWidth = 51
        Me.DataGridV1.RowTemplate.Height = 24
        Me.DataGridV1.Size = New System.Drawing.Size(850, 284)
        Me.DataGridV1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "วิธีการแสดงข้อมูล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "วุฒิการศึกษา"
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(712, 505)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(120, 42)
        Me.btnDel.TabIndex = 24
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(582, 505)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 42)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(841, 505)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 42)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'searchlb
        '
        Me.searchlb.AutoSize = True
        Me.searchlb.Font = New System.Drawing.Font("Prompt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlb.Location = New System.Drawing.Point(716, 93)
        Me.searchlb.Name = "searchlb"
        Me.searchlb.Size = New System.Drawing.Size(188, 22)
        Me.searchlb.TabIndex = 21
        Me.searchlb.Text = "ค้นหาเจ้าหน้าที่ด้วยชื่อองค์กร"
        '
        'SearchStaff
        '
        Me.SearchStaff.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchStaff.Location = New System.Drawing.Point(720, 115)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(219, 33)
        Me.SearchStaff.TabIndex = 18
        '
        'cbbEduLevel
        '
        Me.cbbEduLevel.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbEduLevel.FormattingEnabled = True
        Me.cbbEduLevel.Location = New System.Drawing.Point(512, 114)
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
        Me.cbbEduOrExp.Items.AddRange(New Object() {"เจ้าหน้าที่", "ประวัติการทำงาน", "ประวัติการศึกษา"})
        Me.cbbEduOrExp.Location = New System.Drawing.Point(296, 114)
        Me.cbbEduOrExp.Name = "cbbEduOrExp"
        Me.cbbEduOrExp.Size = New System.Drawing.Size(183, 34)
        Me.cbbEduOrExp.TabIndex = 16
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 811)
        Me.Controls.Add(Me.StaffPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffForm"
        Me.StaffPanel.ResumeLayout(False)
        Me.StaffPanel.PerformLayout()
        CType(Me.DataGridV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents searchlb As Label
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents cbbEduLevel As ComboBox
    Friend WithEvents Stafflabel As Label
    Friend WithEvents cbbEduOrExp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridV1 As DataGridView
End Class
