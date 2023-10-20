<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_OutPantientToWardForm
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
        Me.symptomlb = New System.Windows.Forms.Label()
        Me.symptom = New System.Windows.Forms.RichTextBox()
        Me.visitId = New System.Windows.Forms.ComboBox()
        Me.wardIdlb = New System.Windows.Forms.Label()
        Me.wardId = New System.Windows.Forms.TextBox()
        Me.outPatientTable = New System.Windows.Forms.DataGridView()
        Me.staffId = New System.Windows.Forms.TextBox()
        Me.addStaffIdlb = New System.Windows.Forms.Label()
        Me.visitIdlb = New System.Windows.Forms.Label()
        Me.patientIdlb = New System.Windows.Forms.Label()
        Me.patientId = New System.Windows.Forms.TextBox()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.editPatientToWardPanel = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.outPatientTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.editPatientToWardPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'symptomlb
        '
        Me.symptomlb.AutoSize = True
        Me.symptomlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptomlb.Location = New System.Drawing.Point(67, 374)
        Me.symptomlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptomlb.Name = "symptomlb"
        Me.symptomlb.Size = New System.Drawing.Size(220, 30)
        Me.symptomlb.TabIndex = 112
        Me.symptomlb.Text = "อาการเบื้องต้น (ถ้าทราบ)"
        '
        'symptom
        '
        Me.symptom.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom.Location = New System.Drawing.Point(69, 407)
        Me.symptom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.symptom.Name = "symptom"
        Me.symptom.Size = New System.Drawing.Size(640, 201)
        Me.symptom.TabIndex = 111
        Me.symptom.Text = ""
        '
        'visitId
        '
        Me.visitId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitId.FormattingEnabled = True
        Me.visitId.Location = New System.Drawing.Point(449, 196)
        Me.visitId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.visitId.Name = "visitId"
        Me.visitId.Size = New System.Drawing.Size(260, 38)
        Me.visitId.TabIndex = 108
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(443, 262)
        Me.wardIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(137, 30)
        Me.wardIdlb.TabIndex = 107
        Me.wardIdlb.Text = "หมายเลขวอร์ด"
        '
        'wardId
        '
        Me.wardId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardId.Location = New System.Drawing.Point(449, 302)
        Me.wardId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(260, 38)
        Me.wardId.TabIndex = 106
        '
        'outPatientTable
        '
        Me.outPatientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.outPatientTable.Location = New System.Drawing.Point(783, 158)
        Me.outPatientTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.outPatientTable.Name = "outPatientTable"
        Me.outPatientTable.RowHeadersWidth = 51
        Me.outPatientTable.Size = New System.Drawing.Size(511, 450)
        Me.outPatientTable.TabIndex = 105
        '
        'staffId
        '
        Me.staffId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffId.Location = New System.Drawing.Point(72, 302)
        Me.staffId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(279, 38)
        Me.staffId.TabIndex = 104
        '
        'addStaffIdlb
        '
        Me.addStaffIdlb.AutoSize = True
        Me.addStaffIdlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStaffIdlb.Location = New System.Drawing.Point(65, 262)
        Me.addStaffIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addStaffIdlb.Name = "addStaffIdlb"
        Me.addStaffIdlb.Size = New System.Drawing.Size(258, 30)
        Me.addStaffIdlb.TabIndex = 103
        Me.addStaffIdlb.Text = "หมายเลขเจ้าหน้าที่ที่เพิ่มข้อมูล"
        '
        'visitIdlb
        '
        Me.visitIdlb.AutoSize = True
        Me.visitIdlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitIdlb.Location = New System.Drawing.Point(443, 158)
        Me.visitIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.visitIdlb.Name = "visitIdlb"
        Me.visitIdlb.Size = New System.Drawing.Size(234, 30)
        Me.visitIdlb.TabIndex = 101
        Me.visitIdlb.Text = "หมายเลขประวัติการมา รพ."
        '
        'patientIdlb
        '
        Me.patientIdlb.AutoSize = True
        Me.patientIdlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientIdlb.Location = New System.Drawing.Point(65, 158)
        Me.patientIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.patientIdlb.Name = "patientIdlb"
        Me.patientIdlb.Size = New System.Drawing.Size(140, 30)
        Me.patientIdlb.TabIndex = 99
        Me.patientIdlb.Text = "หมายเลขผู้ป่วย"
        '
        'patientId
        '
        Me.patientId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientId.Location = New System.Drawing.Point(72, 197)
        Me.patientId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.patientId.Name = "patientId"
        Me.patientId.Size = New System.Drawing.Size(279, 38)
        Me.patientId.TabIndex = 98
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(372, 44)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(396, 40)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "แก้ไขข้อมูลผู้ป่วยนอกไปยังวอร์ด"
        '
        'editPatientToWardPanel
        '
        Me.editPatientToWardPanel.Controls.Add(Me.btnEdit)
        Me.editPatientToWardPanel.Controls.Add(Me.btnClear)
        Me.editPatientToWardPanel.Controls.Add(Me.symptomlb)
        Me.editPatientToWardPanel.Controls.Add(Me.symptom)
        Me.editPatientToWardPanel.Controls.Add(Me.visitId)
        Me.editPatientToWardPanel.Controls.Add(Me.wardIdlb)
        Me.editPatientToWardPanel.Controls.Add(Me.wardId)
        Me.editPatientToWardPanel.Controls.Add(Me.outPatientTable)
        Me.editPatientToWardPanel.Controls.Add(Me.staffId)
        Me.editPatientToWardPanel.Controls.Add(Me.addStaffIdlb)
        Me.editPatientToWardPanel.Controls.Add(Me.visitIdlb)
        Me.editPatientToWardPanel.Controls.Add(Me.patientIdlb)
        Me.editPatientToWardPanel.Controls.Add(Me.patientId)
        Me.editPatientToWardPanel.Controls.Add(Me.headerlb)
        Me.editPatientToWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editPatientToWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.editPatientToWardPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.editPatientToWardPanel.Name = "editPatientToWardPanel"
        Me.editPatientToWardPanel.Size = New System.Drawing.Size(1339, 752)
        Me.editPatientToWardPanel.TabIndex = 3
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(1046, 41)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 46)
        Me.btnEdit.TabIndex = 114
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(866, 41)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 46)
        Me.btnClear.TabIndex = 113
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Edit_OutPantientToWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.editPatientToWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Edit_OutPantientToWardForm"
        Me.Text = "Edit_OutPantientToWard"
        CType(Me.outPatientTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.editPatientToWardPanel.ResumeLayout(False)
        Me.editPatientToWardPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents symptomlb As Label
    Friend WithEvents symptom As RichTextBox
    Friend WithEvents visitId As ComboBox
    Friend WithEvents wardIdlb As Label
    Friend WithEvents wardId As TextBox
    Friend WithEvents outPatientTable As DataGridView
    Friend WithEvents staffId As TextBox
    Friend WithEvents addStaffIdlb As Label
    Friend WithEvents visitIdlb As Label
    Friend WithEvents patientIdlb As Label
    Friend WithEvents patientId As TextBox
    Friend WithEvents headerlb As Label
    Friend WithEvents editPatientToWardPanel As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
End Class
