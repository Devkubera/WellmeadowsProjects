<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_OutPantientToWardForm
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
        Me.outPatientTable = New System.Windows.Forms.DataGridView()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.addPatientToWardPanel = New System.Windows.Forms.Panel()
        Me.symptomlb = New System.Windows.Forms.Label()
        Me.symptom = New System.Windows.Forms.RichTextBox()
        Me.visitId = New System.Windows.Forms.ComboBox()
        Me.wardIdlb = New System.Windows.Forms.Label()
        Me.wardId = New System.Windows.Forms.TextBox()
        Me.staffId = New System.Windows.Forms.TextBox()
        Me.addStaffIdlb = New System.Windows.Forms.Label()
        Me.visitIdlb = New System.Windows.Forms.Label()
        Me.patientIdlb = New System.Windows.Forms.Label()
        Me.patientId = New System.Windows.Forms.TextBox()
        CType(Me.outPatientTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addPatientToWardPanel.SuspendLayout()
        Me.SuspendLayout()
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
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnsubmit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Location = New System.Drawing.Point(1133, 47)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(160, 46)
        Me.btnsubmit.TabIndex = 97
        Me.btnsubmit.Text = "เพิ่ม"
        Me.btnsubmit.UseVisualStyleBackColor = False
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
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(432, 46)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(383, 40)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "เพิ่มข้อมูลผู้ป่วยนอกไปยังวอร์ด"
        '
        'addPatientToWardPanel
        '
        Me.addPatientToWardPanel.Controls.Add(Me.symptomlb)
        Me.addPatientToWardPanel.Controls.Add(Me.symptom)
        Me.addPatientToWardPanel.Controls.Add(Me.visitId)
        Me.addPatientToWardPanel.Controls.Add(Me.wardIdlb)
        Me.addPatientToWardPanel.Controls.Add(Me.wardId)
        Me.addPatientToWardPanel.Controls.Add(Me.staffId)
        Me.addPatientToWardPanel.Controls.Add(Me.addStaffIdlb)
        Me.addPatientToWardPanel.Controls.Add(Me.visitIdlb)
        Me.addPatientToWardPanel.Controls.Add(Me.patientIdlb)
        Me.addPatientToWardPanel.Controls.Add(Me.patientId)
        Me.addPatientToWardPanel.Controls.Add(Me.outPatientTable)
        Me.addPatientToWardPanel.Controls.Add(Me.btnsubmit)
        Me.addPatientToWardPanel.Controls.Add(Me.btnClear)
        Me.addPatientToWardPanel.Controls.Add(Me.headerlb)
        Me.addPatientToWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addPatientToWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.addPatientToWardPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addPatientToWardPanel.Name = "addPatientToWardPanel"
        Me.addPatientToWardPanel.Size = New System.Drawing.Size(1339, 752)
        Me.addPatientToWardPanel.TabIndex = 2
        '
        'symptomlb
        '
        Me.symptomlb.AutoSize = True
        Me.symptomlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptomlb.Location = New System.Drawing.Point(67, 374)
        Me.symptomlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptomlb.Name = "symptomlb"
        Me.symptomlb.Size = New System.Drawing.Size(220, 30)
        Me.symptomlb.TabIndex = 122
        Me.symptomlb.Text = "อาการเบื้องต้น (ถ้าทราบ)"
        '
        'symptom
        '
        Me.symptom.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom.Location = New System.Drawing.Point(69, 407)
        Me.symptom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.symptom.Name = "symptom"
        Me.symptom.Size = New System.Drawing.Size(608, 201)
        Me.symptom.TabIndex = 121
        Me.symptom.Text = ""
        '
        'visitId
        '
        Me.visitId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitId.FormattingEnabled = True
        Me.visitId.Location = New System.Drawing.Point(449, 196)
        Me.visitId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.visitId.Name = "visitId"
        Me.visitId.Size = New System.Drawing.Size(228, 38)
        Me.visitId.TabIndex = 120
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(443, 262)
        Me.wardIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(137, 30)
        Me.wardIdlb.TabIndex = 119
        Me.wardIdlb.Text = "หมายเลขวอร์ด"
        '
        'wardId
        '
        Me.wardId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardId.Location = New System.Drawing.Point(449, 302)
        Me.wardId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(228, 38)
        Me.wardId.TabIndex = 118
        '
        'staffId
        '
        Me.staffId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffId.Location = New System.Drawing.Point(72, 302)
        Me.staffId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(238, 38)
        Me.staffId.TabIndex = 117
        '
        'addStaffIdlb
        '
        Me.addStaffIdlb.AutoSize = True
        Me.addStaffIdlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStaffIdlb.Location = New System.Drawing.Point(65, 262)
        Me.addStaffIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addStaffIdlb.Name = "addStaffIdlb"
        Me.addStaffIdlb.Size = New System.Drawing.Size(258, 30)
        Me.addStaffIdlb.TabIndex = 116
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
        Me.visitIdlb.TabIndex = 115
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
        Me.patientIdlb.TabIndex = 114
        Me.patientIdlb.Text = "หมายเลขผู้ป่วย"
        '
        'patientId
        '
        Me.patientId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientId.Location = New System.Drawing.Point(72, 197)
        Me.patientId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.patientId.Name = "patientId"
        Me.patientId.Size = New System.Drawing.Size(238, 38)
        Me.patientId.TabIndex = 113
        '
        'Add_OutPantientToWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.addPatientToWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Add_OutPantientToWardForm"
        Me.Text = "Add_OutPantientToWard"
        CType(Me.outPatientTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addPatientToWardPanel.ResumeLayout(False)
        Me.addPatientToWardPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents outPatientTable As DataGridView
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents headerlb As Label
    Friend WithEvents addPatientToWardPanel As Panel
    Friend WithEvents symptomlb As Label
    Friend WithEvents symptom As RichTextBox
    Friend WithEvents visitId As ComboBox
    Friend WithEvents wardIdlb As Label
    Friend WithEvents wardId As TextBox
    Friend WithEvents staffId As TextBox
    Friend WithEvents addStaffIdlb As Label
    Friend WithEvents visitIdlb As Label
    Friend WithEvents patientIdlb As Label
    Friend WithEvents patientId As TextBox
End Class
