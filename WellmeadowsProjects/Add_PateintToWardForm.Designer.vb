<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_PateintToWardForm
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
        Me.patientToWardPanel = New System.Windows.Forms.Panel()
        Me.symptomlb = New System.Windows.Forms.Label()
        Me.symptom = New System.Windows.Forms.RichTextBox()
        Me.patientType = New System.Windows.Forms.ComboBox()
        Me.patientTypelb = New System.Windows.Forms.Label()
        Me.visitId = New System.Windows.Forms.ComboBox()
        Me.wardlb = New System.Windows.Forms.Label()
        Me.wardId = New System.Windows.Forms.TextBox()
        Me.patientVisitTable = New System.Windows.Forms.DataGridView()
        Me.staffId = New System.Windows.Forms.TextBox()
        Me.addStaffId = New System.Windows.Forms.Label()
        Me.visitlb = New System.Windows.Forms.Label()
        Me.pateintIdlb = New System.Windows.Forms.Label()
        Me.patientId = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.patientToWardPanel.SuspendLayout()
        CType(Me.patientVisitTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientToWardPanel
        '
        Me.patientToWardPanel.Controls.Add(Me.symptomlb)
        Me.patientToWardPanel.Controls.Add(Me.symptom)
        Me.patientToWardPanel.Controls.Add(Me.patientType)
        Me.patientToWardPanel.Controls.Add(Me.patientTypelb)
        Me.patientToWardPanel.Controls.Add(Me.visitId)
        Me.patientToWardPanel.Controls.Add(Me.wardlb)
        Me.patientToWardPanel.Controls.Add(Me.wardId)
        Me.patientToWardPanel.Controls.Add(Me.patientVisitTable)
        Me.patientToWardPanel.Controls.Add(Me.staffId)
        Me.patientToWardPanel.Controls.Add(Me.addStaffId)
        Me.patientToWardPanel.Controls.Add(Me.visitlb)
        Me.patientToWardPanel.Controls.Add(Me.pateintIdlb)
        Me.patientToWardPanel.Controls.Add(Me.patientId)
        Me.patientToWardPanel.Controls.Add(Me.btnSubmit)
        Me.patientToWardPanel.Controls.Add(Me.btnClear)
        Me.patientToWardPanel.Controls.Add(Me.headerlb)
        Me.patientToWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientToWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.patientToWardPanel.Name = "patientToWardPanel"
        Me.patientToWardPanel.Size = New System.Drawing.Size(1004, 611)
        Me.patientToWardPanel.TabIndex = 1
        '
        'symptomlb
        '
        Me.symptomlb.AutoSize = True
        Me.symptomlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptomlb.Location = New System.Drawing.Point(52, 391)
        Me.symptomlb.Name = "symptomlb"
        Me.symptomlb.Size = New System.Drawing.Size(183, 24)
        Me.symptomlb.TabIndex = 112
        Me.symptomlb.Text = "อาการเบื้องต้น (ถ้าทราบ)"
        '
        'symptom
        '
        Me.symptom.Location = New System.Drawing.Point(54, 418)
        Me.symptom.Name = "symptom"
        Me.symptom.Size = New System.Drawing.Size(325, 118)
        Me.symptom.TabIndex = 111
        Me.symptom.Text = ""
        '
        'patientType
        '
        Me.patientType.FormattingEnabled = True
        Me.patientType.Items.AddRange(New Object() {"ผู้ป่วยรอเตียง", "ผู้ป่วยนอก"})
        Me.patientType.Location = New System.Drawing.Point(54, 339)
        Me.patientType.Name = "patientType"
        Me.patientType.Size = New System.Drawing.Size(121, 21)
        Me.patientType.TabIndex = 110
        '
        'patientTypelb
        '
        Me.patientTypelb.AutoSize = True
        Me.patientTypelb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientTypelb.Location = New System.Drawing.Point(49, 308)
        Me.patientTypelb.Name = "patientTypelb"
        Me.patientTypelb.Size = New System.Drawing.Size(154, 29)
        Me.patientTypelb.TabIndex = 109
        Me.patientTypelb.Text = "ประเภทของผู้ป่วย"
        '
        'visitId
        '
        Me.visitId.FormattingEnabled = True
        Me.visitId.Location = New System.Drawing.Point(337, 159)
        Me.visitId.Name = "visitId"
        Me.visitId.Size = New System.Drawing.Size(121, 21)
        Me.visitId.TabIndex = 108
        '
        'wardlb
        '
        Me.wardlb.AutoSize = True
        Me.wardlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardlb.Location = New System.Drawing.Point(332, 213)
        Me.wardlb.Name = "wardlb"
        Me.wardlb.Size = New System.Drawing.Size(132, 29)
        Me.wardlb.TabIndex = 107
        Me.wardlb.Text = "หมายเลขวอร์ด"
        '
        'wardId
        '
        Me.wardId.Location = New System.Drawing.Point(337, 245)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(139, 20)
        Me.wardId.TabIndex = 106
        '
        'patientVisitTable
        '
        Me.patientVisitTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.patientVisitTable.Location = New System.Drawing.Point(587, 128)
        Me.patientVisitTable.Name = "patientVisitTable"
        Me.patientVisitTable.Size = New System.Drawing.Size(383, 366)
        Me.patientVisitTable.TabIndex = 105
        '
        'staffId
        '
        Me.staffId.Location = New System.Drawing.Point(54, 245)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(139, 20)
        Me.staffId.TabIndex = 104
        '
        'addStaffId
        '
        Me.addStaffId.AutoSize = True
        Me.addStaffId.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStaffId.Location = New System.Drawing.Point(49, 213)
        Me.addStaffId.Name = "addStaffId"
        Me.addStaffId.Size = New System.Drawing.Size(247, 29)
        Me.addStaffId.TabIndex = 103
        Me.addStaffId.Text = "หมายเลขเจ้าหน้าที่ที่เพิ่มข้อมูล"
        '
        'visitlb
        '
        Me.visitlb.AutoSize = True
        Me.visitlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitlb.Location = New System.Drawing.Point(332, 128)
        Me.visitlb.Name = "visitlb"
        Me.visitlb.Size = New System.Drawing.Size(224, 29)
        Me.visitlb.TabIndex = 101
        Me.visitlb.Text = "หมายเลขประวัติการมา รพ."
        '
        'pateintIdlb
        '
        Me.pateintIdlb.AutoSize = True
        Me.pateintIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pateintIdlb.Location = New System.Drawing.Point(49, 128)
        Me.pateintIdlb.Name = "pateintIdlb"
        Me.pateintIdlb.Size = New System.Drawing.Size(133, 29)
        Me.pateintIdlb.TabIndex = 99
        Me.pateintIdlb.Text = "หมายเลขผู้ป่วย"
        '
        'patientId
        '
        Me.patientId.Location = New System.Drawing.Point(54, 160)
        Me.patientId.Name = "patientId"
        Me.patientId.Size = New System.Drawing.Size(139, 20)
        Me.patientId.TabIndex = 98
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(850, 38)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmit.TabIndex = 97
        Me.btnSubmit.Text = "เพิ่ม"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(715, 38)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 37)
        Me.btnClear.TabIndex = 96
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(344, 38)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(238, 25)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "เพิ่มข้อมูลผู้ป่วยไปยังวอร์ด"
        '
        'Add_PateintToWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.patientToWardPanel)
        Me.Name = "Add_PateintToWardForm"
        Me.Text = "Add_PateintToWard"
        Me.patientToWardPanel.ResumeLayout(False)
        Me.patientToWardPanel.PerformLayout()
        CType(Me.patientVisitTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents patientToWardPanel As Panel
    Friend WithEvents addStaffId As Label
    Friend WithEvents visitlb As Label
    Friend WithEvents pateintIdlb As Label
    Friend WithEvents patientId As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents headerlb As Label
    Friend WithEvents staffId As TextBox
    Friend WithEvents wardlb As Label
    Friend WithEvents wardId As TextBox
    Friend WithEvents patientVisitTable As DataGridView
    Friend WithEvents patientType As ComboBox
    Friend WithEvents patientTypelb As Label
    Friend WithEvents visitId As ComboBox
    Friend WithEvents symptomlb As Label
    Friend WithEvents symptom As RichTextBox
End Class
