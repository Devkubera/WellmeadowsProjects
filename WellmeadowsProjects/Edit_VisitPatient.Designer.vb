<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_VisitPatient
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
        Me.btnShowDoctor = New System.Windows.Forms.Button()
        Me.btnShowPatient = New System.Windows.Forms.Button()
        Me.visit_w_Id = New System.Windows.Forms.ComboBox()
        Me.visit_date = New System.Windows.Forms.DateTimePicker()
        Me.visit_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.visit_d_name = New System.Windows.Forms.TextBox()
        Me.visit_d_ID = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.visit_p_name = New System.Windows.Forms.TextBox()
        Me.visit_p_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowDoctor
        '
        Me.btnShowDoctor.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnShowDoctor.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDoctor.ForeColor = System.Drawing.Color.White
        Me.btnShowDoctor.Location = New System.Drawing.Point(253, 284)
        Me.btnShowDoctor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowDoctor.Name = "btnShowDoctor"
        Me.btnShowDoctor.Size = New System.Drawing.Size(135, 80)
        Me.btnShowDoctor.TabIndex = 182
        Me.btnShowDoctor.Text = "ตรวจสอบ"
        Me.btnShowDoctor.UseVisualStyleBackColor = False
        '
        'btnShowPatient
        '
        Me.btnShowPatient.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnShowPatient.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPatient.ForeColor = System.Drawing.Color.White
        Me.btnShowPatient.Location = New System.Drawing.Point(253, 171)
        Me.btnShowPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowPatient.Name = "btnShowPatient"
        Me.btnShowPatient.Size = New System.Drawing.Size(135, 80)
        Me.btnShowPatient.TabIndex = 181
        Me.btnShowPatient.Text = "ตรวจสอบ"
        Me.btnShowPatient.UseVisualStyleBackColor = False
        '
        'visit_w_Id
        '
        Me.visit_w_Id.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visit_w_Id.FormattingEnabled = True
        Me.visit_w_Id.Location = New System.Drawing.Point(460, 454)
        Me.visit_w_Id.Name = "visit_w_Id"
        Me.visit_w_Id.Size = New System.Drawing.Size(258, 34)
        Me.visit_w_Id.TabIndex = 180
        '
        'visit_date
        '
        Me.visit_date.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visit_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.visit_date.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.visit_date.Location = New System.Drawing.Point(460, 573)
        Me.visit_date.Name = "visit_date"
        Me.visit_date.Size = New System.Drawing.Size(583, 33)
        Me.visit_date.TabIndex = 179
        '
        'visit_type
        '
        Me.visit_type.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visit_type.FormattingEnabled = True
        Me.visit_type.Items.AddRange(New Object() {"นัดหมาย", "Walk-in"})
        Me.visit_type.Location = New System.Drawing.Point(785, 454)
        Me.visit_type.Name = "visit_type"
        Me.visit_type.Size = New System.Drawing.Size(258, 34)
        Me.visit_type.TabIndex = 178
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(780, 407)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 30)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "การเข้าพบแพทย์"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(780, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 30)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "ชื่อแพทย์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 284)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 30)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "หมายเลขแพทย์"
        '
        'visit_d_name
        '
        Me.visit_d_name.Enabled = False
        Me.visit_d_name.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visit_d_name.Location = New System.Drawing.Point(785, 330)
        Me.visit_d_name.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_d_name.Name = "visit_d_name"
        Me.visit_d_name.Size = New System.Drawing.Size(258, 33)
        Me.visit_d_name.TabIndex = 174
        '
        'visit_d_ID
        '
        Me.visit_d_ID.Enabled = False
        Me.visit_d_ID.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visit_d_ID.Location = New System.Drawing.Point(460, 330)
        Me.visit_d_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_d_ID.Name = "visit_d_ID"
        Me.visit_d_ID.Size = New System.Drawing.Size(258, 33)
        Me.visit_d_ID.TabIndex = 173
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1122, 68)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 46)
        Me.btnAdd.TabIndex = 172
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(1001, 68)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 46)
        Me.btnClear.TabIndex = 171
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 407)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 30)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "หมายเลขวอร์ด"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(455, 526)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 30)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "วันที่นัดหมาย"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(780, 171)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 30)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "ชื่อผู้ป่วย"
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lableSearch.Location = New System.Drawing.Point(455, 171)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(140, 30)
        Me.lableSearch.TabIndex = 167
        Me.lableSearch.Text = "หมายเลขผู้ป่วย"
        '
        'visit_p_name
        '
        Me.visit_p_name.Enabled = False
        Me.visit_p_name.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visit_p_name.Location = New System.Drawing.Point(785, 218)
        Me.visit_p_name.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_p_name.Name = "visit_p_name"
        Me.visit_p_name.Size = New System.Drawing.Size(258, 33)
        Me.visit_p_name.TabIndex = 165
        '
        'visit_p_ID
        '
        Me.visit_p_ID.Enabled = False
        Me.visit_p_ID.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visit_p_ID.Location = New System.Drawing.Point(460, 218)
        Me.visit_p_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_p_ID.Name = "visit_p_ID"
        Me.visit_p_ID.Size = New System.Drawing.Size(258, 33)
        Me.visit_p_ID.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(491, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 43)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "แก้ไขข้อมูลประวัติการมาโรงพยาบาล"
        '
        'Edit_VisitPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1536, 763)
        Me.Controls.Add(Me.btnShowDoctor)
        Me.Controls.Add(Me.btnShowPatient)
        Me.Controls.Add(Me.visit_w_Id)
        Me.Controls.Add(Me.visit_date)
        Me.Controls.Add(Me.visit_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.visit_d_name)
        Me.Controls.Add(Me.visit_d_ID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.visit_p_name)
        Me.Controls.Add(Me.visit_p_ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_VisitPatient"
        Me.Text = "Edit_VisitPatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowDoctor As Button
    Friend WithEvents btnShowPatient As Button
    Friend WithEvents visit_w_Id As ComboBox
    Friend WithEvents visit_date As DateTimePicker
    Friend WithEvents visit_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents visit_d_name As TextBox
    Friend WithEvents visit_d_ID As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lableSearch As Label
    Friend WithEvents visit_p_name As TextBox
    Friend WithEvents visit_p_ID As TextBox
    Friend WithEvents Label1 As Label
End Class
