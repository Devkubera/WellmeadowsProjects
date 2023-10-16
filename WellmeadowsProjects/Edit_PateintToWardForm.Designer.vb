<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_PateintToWardForm
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
        Me.editPatientToWardPanel = New System.Windows.Forms.Panel()
        Me.btnCheckDoctor = New System.Windows.Forms.Button()
        Me.symptomlb = New System.Windows.Forms.Label()
        Me.symptom = New System.Windows.Forms.RichTextBox()
        Me.patientType_combobox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.patientTypelb = New System.Windows.Forms.Label()
        Me.wardID_combobox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wardlb = New System.Windows.Forms.Label()
        Me.doctorID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cnID = New System.Windows.Forms.TextBox()
        Me.addStaffId = New System.Windows.Forms.Label()
        Me.visitlb = New System.Windows.Forms.Label()
        Me.visitID = New System.Windows.Forms.TextBox()
        Me.doctorName = New System.Windows.Forms.TextBox()
        Me.patientName = New System.Windows.Forms.TextBox()
        Me.patientId = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.editPatientToWardPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'editPatientToWardPanel
        '
        Me.editPatientToWardPanel.Controls.Add(Me.btnCheckDoctor)
        Me.editPatientToWardPanel.Controls.Add(Me.symptomlb)
        Me.editPatientToWardPanel.Controls.Add(Me.symptom)
        Me.editPatientToWardPanel.Controls.Add(Me.patientType_combobox)
        Me.editPatientToWardPanel.Controls.Add(Me.Label8)
        Me.editPatientToWardPanel.Controls.Add(Me.Label7)
        Me.editPatientToWardPanel.Controls.Add(Me.Label4)
        Me.editPatientToWardPanel.Controls.Add(Me.patientTypelb)
        Me.editPatientToWardPanel.Controls.Add(Me.wardID_combobox)
        Me.editPatientToWardPanel.Controls.Add(Me.Label6)
        Me.editPatientToWardPanel.Controls.Add(Me.Label5)
        Me.editPatientToWardPanel.Controls.Add(Me.Label1)
        Me.editPatientToWardPanel.Controls.Add(Me.Label2)
        Me.editPatientToWardPanel.Controls.Add(Me.wardlb)
        Me.editPatientToWardPanel.Controls.Add(Me.doctorID)
        Me.editPatientToWardPanel.Controls.Add(Me.Label3)
        Me.editPatientToWardPanel.Controls.Add(Me.cnID)
        Me.editPatientToWardPanel.Controls.Add(Me.addStaffId)
        Me.editPatientToWardPanel.Controls.Add(Me.visitlb)
        Me.editPatientToWardPanel.Controls.Add(Me.visitID)
        Me.editPatientToWardPanel.Controls.Add(Me.doctorName)
        Me.editPatientToWardPanel.Controls.Add(Me.patientName)
        Me.editPatientToWardPanel.Controls.Add(Me.patientId)
        Me.editPatientToWardPanel.Controls.Add(Me.btnSubmit)
        Me.editPatientToWardPanel.Controls.Add(Me.headerlb)
        Me.editPatientToWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editPatientToWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.editPatientToWardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.editPatientToWardPanel.Name = "editPatientToWardPanel"
        Me.editPatientToWardPanel.Size = New System.Drawing.Size(1805, 1046)
        Me.editPatientToWardPanel.TabIndex = 2
        '
        'btnCheckDoctor
        '
        Me.btnCheckDoctor.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCheckDoctor.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckDoctor.ForeColor = System.Drawing.Color.White
        Me.btnCheckDoctor.Location = New System.Drawing.Point(71, 523)
        Me.btnCheckDoctor.Name = "btnCheckDoctor"
        Me.btnCheckDoctor.Size = New System.Drawing.Size(127, 78)
        Me.btnCheckDoctor.TabIndex = 142
        Me.btnCheckDoctor.Text = "ตรวจสอบ"
        Me.btnCheckDoctor.UseVisualStyleBackColor = False
        '
        'symptomlb
        '
        Me.symptomlb.AutoSize = True
        Me.symptomlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptomlb.Location = New System.Drawing.Point(950, 308)
        Me.symptomlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.symptomlb.Name = "symptomlb"
        Me.symptomlb.Size = New System.Drawing.Size(220, 30)
        Me.symptomlb.TabIndex = 141
        Me.symptomlb.Text = "อาการเบื้องต้น (ถ้าทราบ)"
        '
        'symptom
        '
        Me.symptom.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symptom.Location = New System.Drawing.Point(953, 347)
        Me.symptom.Margin = New System.Windows.Forms.Padding(4)
        Me.symptom.Name = "symptom"
        Me.symptom.Size = New System.Drawing.Size(523, 264)
        Me.symptom.TabIndex = 140
        Me.symptom.Text = " -"
        '
        'patientType_combobox
        '
        Me.patientType_combobox.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientType_combobox.FormattingEnabled = True
        Me.patientType_combobox.Items.AddRange(New Object() {"ผู้ป่วยใน", "ผู้ป่วยนอก"})
        Me.patientType_combobox.Location = New System.Drawing.Point(955, 240)
        Me.patientType_combobox.Margin = New System.Windows.Forms.Padding(4)
        Me.patientType_combobox.Name = "patientType_combobox"
        Me.patientType_combobox.Size = New System.Drawing.Size(217, 38)
        Me.patientType_combobox.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(631, 523)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 30)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "ชื่อแพทย์"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(631, 202)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 30)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "ชื่อผู้ป่วย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 30)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "หมายเลขผู้ป่วย"
        '
        'patientTypelb
        '
        Me.patientTypelb.AutoSize = True
        Me.patientTypelb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientTypelb.Location = New System.Drawing.Point(948, 202)
        Me.patientTypelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.patientTypelb.Name = "patientTypelb"
        Me.patientTypelb.Size = New System.Drawing.Size(162, 30)
        Me.patientTypelb.TabIndex = 137
        Me.patientTypelb.Text = "ประเภทของผู้ป่วย"
        '
        'wardID_combobox
        '
        Me.wardID_combobox.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardID_combobox.FormattingEnabled = True
        Me.wardID_combobox.Location = New System.Drawing.Point(1250, 240)
        Me.wardID_combobox.Margin = New System.Windows.Forms.Padding(4)
        Me.wardID_combobox.Name = "wardID_combobox"
        Me.wardID_combobox.Size = New System.Drawing.Size(228, 38)
        Me.wardID_combobox.TabIndex = 136
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(1655, 538)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 30)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "หมายเลขวอร์ด"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(948, 866)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 30)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "หมายเลขวอร์ด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(1655, 505)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 30)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "หมายเลขวอร์ด"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(685, 889)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 30)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "หมายเลขวอร์ด"
        '
        'wardlb
        '
        Me.wardlb.AutoSize = True
        Me.wardlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardlb.Location = New System.Drawing.Point(1244, 200)
        Me.wardlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardlb.Name = "wardlb"
        Me.wardlb.Size = New System.Drawing.Size(137, 30)
        Me.wardlb.TabIndex = 134
        Me.wardlb.Text = "หมายเลขวอร์ด"
        '
        'doctorID
        '
        Me.doctorID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctorID.Location = New System.Drawing.Point(235, 563)
        Me.doctorID.Margin = New System.Windows.Forms.Padding(4)
        Me.doctorID.Name = "doctorID"
        Me.doctorID.ReadOnly = True
        Me.doctorID.Size = New System.Drawing.Size(272, 38)
        Me.doctorID.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 523)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 30)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "หมายเลขแพทย์"
        '
        'cnID
        '
        Me.cnID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnID.Location = New System.Drawing.Point(235, 453)
        Me.cnID.Margin = New System.Windows.Forms.Padding(4)
        Me.cnID.Name = "cnID"
        Me.cnID.ReadOnly = True
        Me.cnID.Size = New System.Drawing.Size(272, 38)
        Me.cnID.TabIndex = 131
        '
        'addStaffId
        '
        Me.addStaffId.AutoSize = True
        Me.addStaffId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStaffId.Location = New System.Drawing.Point(228, 413)
        Me.addStaffId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.addStaffId.Name = "addStaffId"
        Me.addStaffId.Size = New System.Drawing.Size(334, 30)
        Me.addStaffId.TabIndex = 129
        Me.addStaffId.Text = "หมายเลขหัวหน้าพยาบาล (ผู้เพิ่มข้อมูล)"
        '
        'visitlb
        '
        Me.visitlb.AutoSize = True
        Me.visitlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitlb.Location = New System.Drawing.Point(228, 308)
        Me.visitlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.visitlb.Name = "visitlb"
        Me.visitlb.Size = New System.Drawing.Size(234, 30)
        Me.visitlb.TabIndex = 128
        Me.visitlb.Text = "หมายเลขประวัติการมา รพ."
        '
        'visitID
        '
        Me.visitID.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitID.Location = New System.Drawing.Point(233, 347)
        Me.visitID.Margin = New System.Windows.Forms.Padding(4)
        Me.visitID.Name = "visitID"
        Me.visitID.ReadOnly = True
        Me.visitID.Size = New System.Drawing.Size(274, 38)
        Me.visitID.TabIndex = 126
        '
        'doctorName
        '
        Me.doctorName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctorName.Location = New System.Drawing.Point(636, 563)
        Me.doctorName.Margin = New System.Windows.Forms.Padding(4)
        Me.doctorName.Name = "doctorName"
        Me.doctorName.ReadOnly = True
        Me.doctorName.Size = New System.Drawing.Size(272, 38)
        Me.doctorName.TabIndex = 125
        '
        'patientName
        '
        Me.patientName.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientName.Location = New System.Drawing.Point(636, 242)
        Me.patientName.Margin = New System.Windows.Forms.Padding(4)
        Me.patientName.Name = "patientName"
        Me.patientName.ReadOnly = True
        Me.patientName.Size = New System.Drawing.Size(272, 38)
        Me.patientName.TabIndex = 125
        '
        'patientId
        '
        Me.patientId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientId.Location = New System.Drawing.Point(235, 242)
        Me.patientId.Margin = New System.Windows.Forms.Padding(4)
        Me.patientId.Name = "patientId"
        Me.patientId.ReadOnly = True
        Me.patientId.Size = New System.Drawing.Size(272, 38)
        Me.patientId.TabIndex = 125
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1031, 45)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 46)
        Me.btnSubmit.TabIndex = 124
        Me.btnSubmit.Text = "บันทึก"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(444, 44)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(380, 43)
        Me.headerlb.TabIndex = 122
        Me.headerlb.Text = "แก้ไขข้อมูลผู้ป่วยในแต่ละวอร์ด"
        '
        'Edit_PateintToWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1805, 1046)
        Me.Controls.Add(Me.editPatientToWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Edit_PateintToWardForm"
        Me.Text = "Edit_StaffForm"
        Me.editPatientToWardPanel.ResumeLayout(False)
        Me.editPatientToWardPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents editPatientToWardPanel As Panel
    Friend WithEvents btnCheckDoctor As Button
    Friend WithEvents symptomlb As Label
    Friend WithEvents symptom As RichTextBox
    Friend WithEvents patientType_combobox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents patientTypelb As Label
    Friend WithEvents wardID_combobox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents wardlb As Label
    Friend WithEvents doctorID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cnID As TextBox
    Friend WithEvents addStaffId As Label
    Friend WithEvents visitlb As Label
    Friend WithEvents visitID As TextBox
    Friend WithEvents patientId As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents headerlb As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents doctorName As TextBox
    Friend WithEvents patientName As TextBox
End Class
