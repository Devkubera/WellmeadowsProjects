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
        Me.StaffPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.searchlb = New System.Windows.Forms.Label()
        Me.StaffTable = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.cbbEduLevel = New System.Windows.Forms.ComboBox()
        Me.Stafflabel = New System.Windows.Forms.Label()
        Me.cbbEduOrExp = New System.Windows.Forms.ComboBox()
        Me.StaffPanel.SuspendLayout()
        CType(Me.StaffTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffPanel
        '
        Me.StaffPanel.Controls.Add(Me.btnDel)
        Me.StaffPanel.Controls.Add(Me.btnEdit)
        Me.StaffPanel.Controls.Add(Me.btnAdd)
        Me.StaffPanel.Controls.Add(Me.searchlb)
        Me.StaffPanel.Controls.Add(Me.StaffTable)
        Me.StaffPanel.Controls.Add(Me.btnSearch)
        Me.StaffPanel.Controls.Add(Me.SearchStaff)
        Me.StaffPanel.Controls.Add(Me.cbbEduLevel)
        Me.StaffPanel.Controls.Add(Me.Stafflabel)
        Me.StaffPanel.Controls.Add(Me.cbbEduOrExp)
        Me.StaffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffPanel.Location = New System.Drawing.Point(0, 0)
        Me.StaffPanel.Name = "StaffPanel"
        Me.StaffPanel.Size = New System.Drawing.Size(1020, 650)
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
        Me.searchlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlb.Location = New System.Drawing.Point(584, 80)
        Me.searchlb.Name = "searchlb"
        Me.searchlb.Size = New System.Drawing.Size(208, 24)
        Me.searchlb.TabIndex = 21
        Me.searchlb.Text = "ค้นหาเจ้าหน้าที่ด้วยชื่อองค์กร.."
        '
        'StaffTable
        '
        Me.StaffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffTable.Location = New System.Drawing.Point(86, 170)
        Me.StaffTable.Name = "StaffTable"
        Me.StaffTable.Size = New System.Drawing.Size(853, 328)
        Me.StaffTable.TabIndex = 20
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(771, 109)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 37)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'SearchStaff
        '
        Me.SearchStaff.Location = New System.Drawing.Point(588, 109)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(142, 20)
        Me.SearchStaff.TabIndex = 18
        '
        'cbbEduLevel
        '
        Me.cbbEduLevel.FormattingEnabled = True
        Me.cbbEduLevel.Items.AddRange(New Object() {"ปริญญาตรี", "ปริญญาโท", "ปริญญาเอก"})
        Me.cbbEduLevel.Location = New System.Drawing.Point(423, 111)
        Me.cbbEduLevel.Name = "cbbEduLevel"
        Me.cbbEduLevel.Size = New System.Drawing.Size(121, 21)
        Me.cbbEduLevel.TabIndex = 17
        '
        'Stafflabel
        '
        Me.Stafflabel.AutoSize = True
        Me.Stafflabel.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stafflabel.Location = New System.Drawing.Point(81, 103)
        Me.Stafflabel.Name = "Stafflabel"
        Me.Stafflabel.Size = New System.Drawing.Size(68, 36)
        Me.Stafflabel.TabIndex = 15
        Me.Stafflabel.Text = "Staff"
        '
        'cbbEduOrExp
        '
        Me.cbbEduOrExp.FormattingEnabled = True
        Me.cbbEduOrExp.Items.AddRange(New Object() {"เจ้าหน้าที่", "ประวัติการศึกษา", "ประวัติการทำงาน"})
        Me.cbbEduOrExp.Location = New System.Drawing.Point(261, 112)
        Me.cbbEduOrExp.Name = "cbbEduOrExp"
        Me.cbbEduOrExp.Size = New System.Drawing.Size(121, 21)
        Me.cbbEduOrExp.TabIndex = 16
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 650)
        Me.Controls.Add(Me.StaffPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffForm"
        Me.Text = "StaffForm"
        Me.StaffPanel.ResumeLayout(False)
        Me.StaffPanel.PerformLayout()
        CType(Me.StaffTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StaffPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents searchlb As Label
    Friend WithEvents StaffTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents cbbEduLevel As ComboBox
    Friend WithEvents Stafflabel As Label
    Friend WithEvents cbbEduOrExp As ComboBox
End Class
