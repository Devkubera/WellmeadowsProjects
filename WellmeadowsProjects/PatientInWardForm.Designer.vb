<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientInWardForm
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
        Me.patientInWardPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.pateintInWardTable = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.cbbPtype = New System.Windows.Forms.ComboBox()
        Me.patientInWardlb = New System.Windows.Forms.Label()
        Me.patientInWardPanel.SuspendLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientInWardPanel
        '
        Me.patientInWardPanel.Controls.Add(Me.btnDel)
        Me.patientInWardPanel.Controls.Add(Me.btnEdit)
        Me.patientInWardPanel.Controls.Add(Me.btnReport)
        Me.patientInWardPanel.Controls.Add(Me.btnAdd)
        Me.patientInWardPanel.Controls.Add(Me.placeholderlb)
        Me.patientInWardPanel.Controls.Add(Me.pateintInWardTable)
        Me.patientInWardPanel.Controls.Add(Me.btnSearch)
        Me.patientInWardPanel.Controls.Add(Me.SearchStaff)
        Me.patientInWardPanel.Controls.Add(Me.cbbPtype)
        Me.patientInWardPanel.Controls.Add(Me.patientInWardlb)
        Me.patientInWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientInWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.patientInWardPanel.Name = "patientInWardPanel"
        Me.patientInWardPanel.Size = New System.Drawing.Size(1004, 611)
        Me.patientInWardPanel.TabIndex = 0
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(812, 514)
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
        Me.btnEdit.Location = New System.Drawing.Point(682, 514)
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
        Me.btnReport.Location = New System.Drawing.Point(452, 514)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(215, 37)
        Me.btnReport.TabIndex = 33
        Me.btnReport.Text = "สร้างรีพอร์ท"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(857, 89)
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
        Me.placeholderlb.Location = New System.Drawing.Point(577, 60)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(208, 24)
        Me.placeholderlb.TabIndex = 31
        Me.placeholderlb.Text = "ค้นหาเจ้าหน้าที่ด้วยชื่อองค์กร.."
        '
        'pateintInWardTable
        '
        Me.pateintInWardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pateintInWardTable.Location = New System.Drawing.Point(79, 150)
        Me.pateintInWardTable.Name = "pateintInWardTable"
        Me.pateintInWardTable.Size = New System.Drawing.Size(853, 328)
        Me.pateintInWardTable.TabIndex = 30
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(764, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 37)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'SearchStaff
        '
        Me.SearchStaff.Location = New System.Drawing.Point(581, 89)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(142, 20)
        Me.SearchStaff.TabIndex = 28
        '
        'cbbPtype
        '
        Me.cbbPtype.FormattingEnabled = True
        Me.cbbPtype.Items.AddRange(New Object() {"In-Patient", "Out-Patient"})
        Me.cbbPtype.Location = New System.Drawing.Point(416, 91)
        Me.cbbPtype.Name = "cbbPtype"
        Me.cbbPtype.Size = New System.Drawing.Size(121, 21)
        Me.cbbPtype.TabIndex = 27
        '
        'patientInWardlb
        '
        Me.patientInWardlb.AutoSize = True
        Me.patientInWardlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientInWardlb.Location = New System.Drawing.Point(73, 85)
        Me.patientInWardlb.Name = "patientInWardlb"
        Me.patientInWardlb.Size = New System.Drawing.Size(193, 36)
        Me.patientInWardlb.TabIndex = 26
        Me.patientInWardlb.Text = "Patient in ward"
        '
        'PatientInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.patientInWardPanel)
        Me.Name = "PatientInWardForm"
        Me.Text = "PatientInWardForm"
        Me.patientInWardPanel.ResumeLayout(False)
        Me.patientInWardPanel.PerformLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents patientInWardPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents placeholderlb As Label
    Friend WithEvents pateintInWardTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents cbbPtype As ComboBox
    Friend WithEvents patientInWardlb As Label
End Class
