<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutPatientForm
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
        Me.OutPatientPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.outPatientTable = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.searchPatient = New System.Windows.Forms.TextBox()
        Me.wardId = New System.Windows.Forms.ComboBox()
        Me.outPatientlb = New System.Windows.Forms.Label()
        Me.OutPatientPanel.SuspendLayout()
        CType(Me.outPatientTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutPatientPanel
        '
        Me.OutPatientPanel.Controls.Add(Me.btnDel)
        Me.OutPatientPanel.Controls.Add(Me.btnEdit)
        Me.OutPatientPanel.Controls.Add(Me.btnReport)
        Me.OutPatientPanel.Controls.Add(Me.btnAdd)
        Me.OutPatientPanel.Controls.Add(Me.placeholderlb)
        Me.OutPatientPanel.Controls.Add(Me.outPatientTable)
        Me.OutPatientPanel.Controls.Add(Me.btnSearch)
        Me.OutPatientPanel.Controls.Add(Me.searchPatient)
        Me.OutPatientPanel.Controls.Add(Me.wardId)
        Me.OutPatientPanel.Controls.Add(Me.outPatientlb)
        Me.OutPatientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutPatientPanel.Location = New System.Drawing.Point(0, 0)
        Me.OutPatientPanel.Name = "OutPatientPanel"
        Me.OutPatientPanel.Size = New System.Drawing.Size(1004, 611)
        Me.OutPatientPanel.TabIndex = 0
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(812, 514)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(120, 37)
        Me.btnDel.TabIndex = 45
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
        Me.btnEdit.TabIndex = 44
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(547, 514)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(120, 37)
        Me.btnReport.TabIndex = 43
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
        Me.btnAdd.TabIndex = 42
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'placeholderlb
        '
        Me.placeholderlb.AutoSize = True
        Me.placeholderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeholderlb.Location = New System.Drawing.Point(577, 60)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(183, 24)
        Me.placeholderlb.TabIndex = 41
        Me.placeholderlb.Text = "ค้นหาด้วยหมายเลขผู้ป่วย.."
        '
        'outPatientTable
        '
        Me.outPatientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.outPatientTable.Location = New System.Drawing.Point(79, 150)
        Me.outPatientTable.Name = "outPatientTable"
        Me.outPatientTable.Size = New System.Drawing.Size(853, 328)
        Me.outPatientTable.TabIndex = 40
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(764, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 37)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'searchPatient
        '
        Me.searchPatient.Location = New System.Drawing.Point(581, 89)
        Me.searchPatient.Name = "searchPatient"
        Me.searchPatient.Size = New System.Drawing.Size(142, 20)
        Me.searchPatient.TabIndex = 38
        '
        'wardId
        '
        Me.wardId.FormattingEnabled = True
        Me.wardId.Items.AddRange(New Object() {"ward1", "ward2", "ward3", "ward4", "ward5", "ward6", "ward7", "ward8", "ward9", "ward10", "ward11", "ward12", "ward13", "ward14", "ward15", "ward16", "ward17"})
        Me.wardId.Location = New System.Drawing.Point(416, 91)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(121, 21)
        Me.wardId.TabIndex = 37
        '
        'outPatientlb
        '
        Me.outPatientlb.AutoSize = True
        Me.outPatientlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outPatientlb.Location = New System.Drawing.Point(73, 85)
        Me.outPatientlb.Name = "outPatientlb"
        Me.outPatientlb.Size = New System.Drawing.Size(147, 36)
        Me.outPatientlb.TabIndex = 36
        Me.outPatientlb.Text = "Out Patient"
        '
        'OutPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.OutPatientPanel)
        Me.Name = "OutPatientForm"
        Me.Text = "OutPatientForm"
        Me.OutPatientPanel.ResumeLayout(False)
        Me.OutPatientPanel.PerformLayout()
        CType(Me.outPatientTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OutPatientPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents placeholderlb As Label
    Friend WithEvents outPatientTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents searchPatient As TextBox
    Friend WithEvents wardId As ComboBox
    Friend WithEvents outPatientlb As Label
End Class
