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
        Me.staffInWardPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.StaffInWardTable = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.cbbWardId = New System.Windows.Forms.ComboBox()
        Me.StaffInWardlb = New System.Windows.Forms.Label()
        Me.staffInWardPanel.SuspendLayout()
        CType(Me.StaffInWardTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'staffInWardPanel
        '
        Me.staffInWardPanel.Controls.Add(Me.btnDel)
        Me.staffInWardPanel.Controls.Add(Me.btnEdit)
        Me.staffInWardPanel.Controls.Add(Me.btnReport)
        Me.staffInWardPanel.Controls.Add(Me.btnAdd)
        Me.staffInWardPanel.Controls.Add(Me.placeholderlb)
        Me.staffInWardPanel.Controls.Add(Me.StaffInWardTable)
        Me.staffInWardPanel.Controls.Add(Me.btnSearch)
        Me.staffInWardPanel.Controls.Add(Me.SearchStaff)
        Me.staffInWardPanel.Controls.Add(Me.cbbWardId)
        Me.staffInWardPanel.Controls.Add(Me.StaffInWardlb)
        Me.staffInWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.staffInWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.staffInWardPanel.Name = "staffInWardPanel"
        Me.staffInWardPanel.Size = New System.Drawing.Size(1020, 650)
        Me.staffInWardPanel.TabIndex = 0
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(811, 514)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(120, 37)
        Me.btnDel.TabIndex = 35
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(681, 514)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 37)
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(546, 514)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(120, 37)
        Me.btnReport.TabIndex = 33
        Me.btnReport.Text = "สร้างราบงาน"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(856, 89)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 37)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'placeholderlb
        '
        Me.placeholderlb.AutoSize = True
        Me.placeholderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeholderlb.Location = New System.Drawing.Point(576, 60)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(208, 24)
        Me.placeholderlb.TabIndex = 31
        Me.placeholderlb.Text = "ค้นหาเจ้าหน้าที่ด้วยชื่อองค์กร.."
        '
        'StaffInWardTable
        '
        Me.StaffInWardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffInWardTable.Location = New System.Drawing.Point(78, 150)
        Me.StaffInWardTable.Name = "StaffInWardTable"
        Me.StaffInWardTable.Size = New System.Drawing.Size(853, 328)
        Me.StaffInWardTable.TabIndex = 30
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(763, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 37)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'SearchStaff
        '
        Me.SearchStaff.Location = New System.Drawing.Point(580, 89)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(142, 20)
        Me.SearchStaff.TabIndex = 28
        '
        'cbbWardId
        '
        Me.cbbWardId.FormattingEnabled = True
        Me.cbbWardId.Items.AddRange(New Object() {"ward1", "ward2", "ward3", "ward4", "ward5", "ward6", "ward7", "ward8", "ward9", "ward10", "ward11", "ward12", "ward13", "ward14", "ward15", "ward16", "ward17"})
        Me.cbbWardId.Location = New System.Drawing.Point(415, 91)
        Me.cbbWardId.Name = "cbbWardId"
        Me.cbbWardId.Size = New System.Drawing.Size(121, 21)
        Me.cbbWardId.TabIndex = 27
        '
        'StaffInWardlb
        '
        Me.StaffInWardlb.AutoSize = True
        Me.StaffInWardlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffInWardlb.Location = New System.Drawing.Point(73, 83)
        Me.StaffInWardlb.Name = "StaffInWardlb"
        Me.StaffInWardlb.Size = New System.Drawing.Size(238, 36)
        Me.StaffInWardlb.TabIndex = 26
        Me.StaffInWardlb.Text = "เจ้าหน้าที่ในแต่ละวอร์ด"
        '
        'StaffInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 650)
        Me.Controls.Add(Me.staffInWardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "StaffInWardForm"
        Me.Text = "เจ้าหน้าที่ในแต่ละวอร์ด"
        Me.staffInWardPanel.ResumeLayout(False)
        Me.staffInWardPanel.PerformLayout()
        CType(Me.StaffInWardTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents staffInWardPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents placeholderlb As Label
    Friend WithEvents StaffInWardTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents cbbWardId As ComboBox
    Friend WithEvents StaffInWardlb As Label
End Class
