<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_InPatient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.ip_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ips_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ip_expect = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ipb_id = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ip_date = New System.Windows.Forms.DateTimePicker()
        Me.ipw_id = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เพิ่มข้อมูลผู้ป่วยใน"
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(307, 135)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(115, 24)
        Me.lableSearch.TabIndex = 4
        Me.lableSearch.Text = "หมายเลขผู้ป่วย"
        '
        'ip_id
        '
        Me.ip_id.Location = New System.Drawing.Point(311, 173)
        Me.ip_id.Name = "ip_id"
        Me.ip_id.Size = New System.Drawing.Size(142, 20)
        Me.ip_id.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(570, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "วันที่เข้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(570, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "หมายเลขพนักงาน"
        '
        'ips_id
        '
        Me.ips_id.Location = New System.Drawing.Point(574, 283)
        Me.ips_id.Name = "ips_id"
        Me.ips_id.Size = New System.Drawing.Size(142, 20)
        Me.ips_id.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(307, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "หมายเลขวอร์ด"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(570, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "จำนวนวันที่อยู่"
        '
        'ip_expect
        '
        Me.ip_expect.Location = New System.Drawing.Point(574, 384)
        Me.ip_expect.Name = "ip_expect"
        Me.ip_expect.Size = New System.Drawing.Size(142, 20)
        Me.ip_expect.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(307, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "หมายเลขเตียง"
        '
        'ipb_id
        '
        Me.ipb_id.Location = New System.Drawing.Point(311, 384)
        Me.ipb_id.Name = "ipb_id"
        Me.ipb_id.Size = New System.Drawing.Size(142, 20)
        Me.ipb_id.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(849, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(758, 36)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'ip_date
        '
        Me.ip_date.Location = New System.Drawing.Point(574, 173)
        Me.ip_date.Name = "ip_date"
        Me.ip_date.Size = New System.Drawing.Size(200, 20)
        Me.ip_date.TabIndex = 34
        '
        'ipw_id
        '
        Me.ipw_id.FormattingEnabled = True
        Me.ipw_id.Items.AddRange(New Object() {"W1", "W2", "W3", "W4", "W5", "W6", "W7", "W8", "W9", "W10"})
        Me.ipw_id.Location = New System.Drawing.Point(311, 282)
        Me.ipw_id.Name = "ipw_id"
        Me.ipw_id.Size = New System.Drawing.Size(142, 21)
        Me.ipw_id.TabIndex = 35
        '
        'Add_InPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 650)
        Me.Controls.Add(Me.ipw_id)
        Me.Controls.Add(Me.ip_date)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ip_expect)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ipb_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ips_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.ip_id)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Add_InPatient"
        Me.Text = "Add_InPatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lableSearch As Label
    Friend WithEvents ip_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ips_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ip_expect As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ipb_id As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ip_date As DateTimePicker
    Friend WithEvents ipw_id As ComboBox
End Class
