<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_StaffInWardForm
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
        Me.addStaffPanel = New System.Windows.Forms.Panel()
        Me.Shift = New System.Windows.Forms.ComboBox()
        Me.shiftlb = New System.Windows.Forms.Label()
        Me.wardIdlb = New System.Windows.Forms.Label()
        Me.wardId = New System.Windows.Forms.TextBox()
        Me.staffIdlb = New System.Windows.Forms.Label()
        Me.staffId = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.addStaffPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'addStaffPanel
        '
        Me.addStaffPanel.Controls.Add(Me.Shift)
        Me.addStaffPanel.Controls.Add(Me.shiftlb)
        Me.addStaffPanel.Controls.Add(Me.wardIdlb)
        Me.addStaffPanel.Controls.Add(Me.wardId)
        Me.addStaffPanel.Controls.Add(Me.staffIdlb)
        Me.addStaffPanel.Controls.Add(Me.staffId)
        Me.addStaffPanel.Controls.Add(Me.btnSubmit)
        Me.addStaffPanel.Controls.Add(Me.btnClear)
        Me.addStaffPanel.Controls.Add(Me.headerlb)
        Me.addStaffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addStaffPanel.Location = New System.Drawing.Point(0, 0)
        Me.addStaffPanel.Name = "addStaffPanel"
        Me.addStaffPanel.Size = New System.Drawing.Size(1004, 611)
        Me.addStaffPanel.TabIndex = 0
        '
        'Shift
        '
        Me.Shift.FormattingEnabled = True
        Me.Shift.Items.AddRange(New Object() {"เช้า", "กลางวัน", "กลางคืน"})
        Me.Shift.Location = New System.Drawing.Point(190, 244)
        Me.Shift.Name = "Shift"
        Me.Shift.Size = New System.Drawing.Size(139, 21)
        Me.Shift.TabIndex = 104
        '
        'shiftlb
        '
        Me.shiftlb.AutoSize = True
        Me.shiftlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftlb.Location = New System.Drawing.Point(185, 212)
        Me.shiftlb.Name = "shiftlb"
        Me.shiftlb.Size = New System.Drawing.Size(83, 29)
        Me.shiftlb.TabIndex = 103
        Me.shiftlb.Text = "กะทำงาน"
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(375, 127)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(132, 29)
        Me.wardIdlb.TabIndex = 101
        Me.wardIdlb.Text = "หมายเลขวอร์ด"
        '
        'wardId
        '
        Me.wardId.Location = New System.Drawing.Point(380, 159)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(139, 20)
        Me.wardId.TabIndex = 100
        '
        'staffIdlb
        '
        Me.staffIdlb.AutoSize = True
        Me.staffIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffIdlb.Location = New System.Drawing.Point(185, 127)
        Me.staffIdlb.Name = "staffIdlb"
        Me.staffIdlb.Size = New System.Drawing.Size(157, 29)
        Me.staffIdlb.TabIndex = 99
        Me.staffIdlb.Text = "หมายเลขพนักงาน"
        '
        'staffId
        '
        Me.staffId.Location = New System.Drawing.Point(190, 159)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(139, 20)
        Me.staffId.TabIndex = 98
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
        Me.headerlb.Size = New System.Drawing.Size(293, 25)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "เพิ่มข้อมูลเจ้าหน้าที่ในแต่ละวอร์ด"
        '
        'Add_StaffInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.addStaffPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Add_StaffInWardForm"
        Me.Text = "เพิ่มข้อมูลเจ้าหน้าที่ในแต่ละวอร์ด"
        Me.addStaffPanel.ResumeLayout(False)
        Me.addStaffPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addStaffPanel As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents headerlb As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents staffId As TextBox
    Friend WithEvents staffIdlb As Label
    Friend WithEvents wardIdlb As Label
    Friend WithEvents wardId As TextBox
    Friend WithEvents shiftlb As Label
    Friend WithEvents Shift As ComboBox
End Class
