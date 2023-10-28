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
        Me.btnCheckDoctor = New System.Windows.Forms.Button()
        Me.symptomlb = New System.Windows.Forms.Label()
        Me.symptom = New System.Windows.Forms.RichTextBox()
        Me.patientType_combobox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.patientTypelb = New System.Windows.Forms.Label()
        Me.wardID_combobox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wardlb = New System.Windows.Forms.Label()
        Me.visitDatagrid = New System.Windows.Forms.DataGridView()
        Me.doctorID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cnID = New System.Windows.Forms.TextBox()
        Me.addStaffId = New System.Windows.Forms.Label()
        Me.visitlb = New System.Windows.Forms.Label()
        Me.pateintIdlb = New System.Windows.Forms.Label()
        Me.visitID = New System.Windows.Forms.TextBox()
        Me.patientId = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.patientToWardPanel.SuspendLayout()
        CType(Me.visitDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientToWardPanel
        '
        Me.patientToWardPanel.Controls.Add(Me.btnCheckDoctor)
        Me.patientToWardPanel.Controls.Add(Me.symptomlb)
        Me.patientToWardPanel.Controls.Add(Me.symptom)
        Me.patientToWardPanel.Controls.Add(Me.patientType_combobox)
        Me.patientToWardPanel.Controls.Add(Me.Label4)
        Me.patientToWardPanel.Controls.Add(Me.patientTypelb)
        Me.patientToWardPanel.Controls.Add(Me.wardID_combobox)
        Me.patientToWardPanel.Controls.Add(Me.Label2)
        Me.patientToWardPanel.Controls.Add(Me.Label1)
        Me.patientToWardPanel.Controls.Add(Me.wardlb)
        Me.patientToWardPanel.Controls.Add(Me.visitDatagrid)
        Me.patientToWardPanel.Controls.Add(Me.doctorID)
        Me.patientToWardPanel.Controls.Add(Me.Label3)
        Me.patientToWardPanel.Controls.Add(Me.cnID)
        Me.patientToWardPanel.Controls.Add(Me.addStaffId)
        Me.patientToWardPanel.Controls.Add(Me.visitlb)
        Me.patientToWardPanel.Controls.Add(Me.pateintIdlb)
        Me.patientToWardPanel.Controls.Add(Me.visitID)
        Me.patientToWardPanel.Controls.Add(Me.patientId)
        Me.patientToWardPanel.Controls.Add(Me.btnSubmit)
        Me.patientToWardPanel.Controls.Add(Me.btnClear)
        Me.patientToWardPanel.Controls.Add(Me.headerlb)
        Me.patientToWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientToWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.patientToWardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.patientToWardPanel.Name = "patientToWardPanel"
        Me.patientToWardPanel.Size = New System.Drawing.Size(1838, 853)
        Me.patientToWardPanel.TabIndex = 1
        '
        'btnCheckDoctor
        '
        Me.btnCheckDoctor.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCheckDoctor.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckDoctor.ForeColor = System.Drawing.Color.White
        Me.btnCheckDoctor.Location = New System.Drawing.Point(197, 726)
        Me.btnCheckDoctor.Name = "btnCheckDoctor"
        Me.btnCheckDoctor.Size = New System.Drawing.Size(127, 78)
        Me.btnCheckDoctor.TabIndex = 121
        Me.btnCheckDoctor.Text = "ตรวจสอบ"
        Me.btnCheckDoctor.UseVisualStyleBackColor = False
        '
        'symptomlb
        '
        Me.symptomlb.AutoSize = True
        Me.symptomlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptomlb.Location = New System.Drawing.Point(791, 511)
        Me.symptomlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptomlb.Name = "symptomlb"
        Me.symptomlb.Size = New System.Drawing.Size(220, 30)
        Me.symptomlb.TabIndex = 119
        Me.symptomlb.Text = "อาการเบื้องต้น (ถ้าทราบ)"
        '
        'symptom
        '
        Me.symptom.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom.Location = New System.Drawing.Point(794, 550)
        Me.symptom.Margin = New System.Windows.Forms.Padding(4)
        Me.symptom.Name = "symptom"
        Me.symptom.Size = New System.Drawing.Size(523, 264)
        Me.symptom.TabIndex = 118
        Me.symptom.Text = " -"
        '
        'patientType_combobox
        '
        Me.patientType_combobox.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientType_combobox.FormattingEnabled = True
        Me.patientType_combobox.Items.AddRange(New Object() {"ผู้ป่วยใน", "ผู้ป่วยนอก"})
        Me.patientType_combobox.Location = New System.Drawing.Point(794, 443)
        Me.patientType_combobox.Margin = New System.Windows.Forms.Padding(4)
        Me.patientType_combobox.Name = "patientType_combobox"
        Me.patientType_combobox.Size = New System.Drawing.Size(217, 38)
        Me.patientType_combobox.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(356, 405)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 30)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "หมายเลขผู้ป่วย"
        '
        'patientTypelb
        '
        Me.patientTypelb.AutoSize = True
        Me.patientTypelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientTypelb.Location = New System.Drawing.Point(787, 405)
        Me.patientTypelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.patientTypelb.Name = "patientTypelb"
        Me.patientTypelb.Size = New System.Drawing.Size(162, 30)
        Me.patientTypelb.TabIndex = 116
        Me.patientTypelb.Text = "ประเภทของผู้ป่วย"
        '
        'wardID_combobox
        '
        Me.wardID_combobox.Enabled = False
        Me.wardID_combobox.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardID_combobox.FormattingEnabled = True
        Me.wardID_combobox.Location = New System.Drawing.Point(1089, 443)
        Me.wardID_combobox.Margin = New System.Windows.Forms.Padding(4)
        Me.wardID_combobox.Name = "wardID_combobox"
        Me.wardID_combobox.Size = New System.Drawing.Size(228, 38)
        Me.wardID_combobox.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(858, 814)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 30)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "หมายเลขวอร์ด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(1628, 356)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 30)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "หมายเลขวอร์ด"
        '
        'wardlb
        '
        Me.wardlb.AutoSize = True
        Me.wardlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardlb.Location = New System.Drawing.Point(1083, 403)
        Me.wardlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardlb.Name = "wardlb"
        Me.wardlb.Size = New System.Drawing.Size(137, 30)
        Me.wardlb.TabIndex = 114
        Me.wardlb.Text = "หมายเลขวอร์ด"
        '
        'visitDatagrid
        '
        Me.visitDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visitDatagrid.Location = New System.Drawing.Point(93, 159)
        Me.visitDatagrid.Name = "visitDatagrid"
        Me.visitDatagrid.ReadOnly = True
        Me.visitDatagrid.RowHeadersWidth = 51
        Me.visitDatagrid.RowTemplate.Height = 24
        Me.visitDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visitDatagrid.Size = New System.Drawing.Size(1224, 227)
        Me.visitDatagrid.TabIndex = 113
        '
        'doctorID
        '
        Me.doctorID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctorID.Location = New System.Drawing.Point(361, 766)
        Me.doctorID.Margin = New System.Windows.Forms.Padding(4)
        Me.doctorID.Name = "doctorID"
        Me.doctorID.ReadOnly = True
        Me.doctorID.Size = New System.Drawing.Size(272, 38)
        Me.doctorID.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 726)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 30)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "หมายเลขแพทย์"
        '
        'cnID
        '
        Me.cnID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnID.Location = New System.Drawing.Point(361, 656)
        Me.cnID.Margin = New System.Windows.Forms.Padding(4)
        Me.cnID.Name = "cnID"
        Me.cnID.ReadOnly = True
        Me.cnID.Size = New System.Drawing.Size(272, 38)
        Me.cnID.TabIndex = 104
        '
        'addStaffId
        '
        Me.addStaffId.AutoSize = True
        Me.addStaffId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStaffId.Location = New System.Drawing.Point(354, 616)
        Me.addStaffId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addStaffId.Name = "addStaffId"
        Me.addStaffId.Size = New System.Drawing.Size(334, 30)
        Me.addStaffId.TabIndex = 103
        Me.addStaffId.Text = "หมายเลขหัวหน้าพยาบาล (ผู้เพิ่มข้อมูล)"
        '
        'visitlb
        '
        Me.visitlb.AutoSize = True
        Me.visitlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitlb.Location = New System.Drawing.Point(354, 511)
        Me.visitlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.visitlb.Name = "visitlb"
        Me.visitlb.Size = New System.Drawing.Size(234, 30)
        Me.visitlb.TabIndex = 101
        Me.visitlb.Text = "หมายเลขประวัติการมา รพ."
        '
        'pateintIdlb
        '
        Me.pateintIdlb.AutoSize = True
        Me.pateintIdlb.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pateintIdlb.Location = New System.Drawing.Point(89, 130)
        Me.pateintIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pateintIdlb.Name = "pateintIdlb"
        Me.pateintIdlb.Size = New System.Drawing.Size(407, 26)
        Me.pateintIdlb.TabIndex = 99
        Me.pateintIdlb.Text = "ตารางข้อมูลประวัติการมาโรงพยาบาลของผู้ป่วยแต่ละคน"
        '
        'visitID
        '
        Me.visitID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitID.Location = New System.Drawing.Point(359, 550)
        Me.visitID.Margin = New System.Windows.Forms.Padding(4)
        Me.visitID.Name = "visitID"
        Me.visitID.ReadOnly = True
        Me.visitID.Size = New System.Drawing.Size(274, 38)
        Me.visitID.TabIndex = 98
        '
        'patientId
        '
        Me.patientId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientId.Location = New System.Drawing.Point(361, 445)
        Me.patientId.Margin = New System.Windows.Forms.Padding(4)
        Me.patientId.Name = "patientId"
        Me.patientId.ReadOnly = True
        Me.patientId.Size = New System.Drawing.Size(272, 38)
        Me.patientId.TabIndex = 98
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1133, 47)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 46)
        Me.btnSubmit.TabIndex = 97
        Me.btnSubmit.Text = "เพิ่ม"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(953, 47)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
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
        Me.headerlb.Location = New System.Drawing.Point(459, 47)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(340, 43)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "เพิ่มข้อมูลผู้ป่วยไปยังวอร์ด"
        '
        'Add_PateintToWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1838, 853)
        Me.Controls.Add(Me.patientToWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_PateintToWardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_PateintToWard"
        Me.patientToWardPanel.ResumeLayout(False)
        Me.patientToWardPanel.PerformLayout()
        CType(Me.visitDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cnID As TextBox
    Friend WithEvents visitID As TextBox
    Friend WithEvents visitDatagrid As DataGridView
    Friend WithEvents symptomlb As Label
    Friend WithEvents symptom As RichTextBox
    Friend WithEvents patientType_combobox As ComboBox
    Friend WithEvents patientTypelb As Label
    Friend WithEvents wardID_combobox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents wardlb As Label
    Friend WithEvents btnCheckDoctor As Button
    Friend WithEvents doctorID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
