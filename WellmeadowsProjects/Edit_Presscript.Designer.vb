<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Presscript
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
        Me.View_Edit_Press = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.m_endDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.m_startDate = New System.Windows.Forms.TextBox()
        Me.m_method = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pt_firstName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.m_dosage = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.m_id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.m_desc = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pt_lastName = New System.Windows.Forms.TextBox()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.pt_id = New System.Windows.Forms.TextBox()
        CType(Me.View_Edit_Press, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_Edit_Press
        '
        Me.View_Edit_Press.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Edit_Press.Location = New System.Drawing.Point(58, 120)
        Me.View_Edit_Press.Margin = New System.Windows.Forms.Padding(4)
        Me.View_Edit_Press.Name = "View_Edit_Press"
        Me.View_Edit_Press.RowHeadersWidth = 51
        Me.View_Edit_Press.Size = New System.Drawing.Size(1211, 223)
        Me.View_Edit_Press.TabIndex = 47
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1109, 29)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 46)
        Me.btnAdd.TabIndex = 46
        Me.btnAdd.Text = "แก้ไขข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(517, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 36)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "แก้ไขข้อมูลการจ่ายยา"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(953, 615)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 29)
        Me.Label7.TabIndex = 186
        Me.Label7.Text = "วันที่ให้ยาครบตามที่แพทย์สั่ง"
        '
        'm_endDate
        '
        Me.m_endDate.Location = New System.Drawing.Point(958, 662)
        Me.m_endDate.Margin = New System.Windows.Forms.Padding(4)
        Me.m_endDate.Name = "m_endDate"
        Me.m_endDate.Size = New System.Drawing.Size(188, 22)
        Me.m_endDate.TabIndex = 185
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(726, 615)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 29)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "วันที่เริ่มให้ยา"
        '
        'm_startDate
        '
        Me.m_startDate.Location = New System.Drawing.Point(731, 662)
        Me.m_startDate.Margin = New System.Windows.Forms.Padding(4)
        Me.m_startDate.Name = "m_startDate"
        Me.m_startDate.Size = New System.Drawing.Size(189, 22)
        Me.m_startDate.TabIndex = 183
        '
        'm_method
        '
        Me.m_method.FormattingEnabled = True
        Me.m_method.Items.AddRange(New Object() {"Oral", "Skin"})
        Me.m_method.Location = New System.Drawing.Point(731, 567)
        Me.m_method.Margin = New System.Windows.Forms.Padding(4)
        Me.m_method.Name = "m_method"
        Me.m_method.Size = New System.Drawing.Size(188, 24)
        Me.m_method.TabIndex = 182
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(726, 522)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 29)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "วิธีการให้ยากับผู้ป่วย"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(723, 386)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 31)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "ข้อมูลยา"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 386)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 31)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "ผู้ป่วย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(130, 522)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 29)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "ชื่อ"
        '
        'pt_firstName
        '
        Me.pt_firstName.Location = New System.Drawing.Point(135, 569)
        Me.pt_firstName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_firstName.Name = "pt_firstName"
        Me.pt_firstName.Size = New System.Drawing.Size(188, 22)
        Me.pt_firstName.TabIndex = 177
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label14.Location = New System.Drawing.Point(951, 522)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(276, 29)
        Me.Label14.TabIndex = 176
        Me.Label14.Text = "ปริมาณยาที่ผู้ป่วยได้รับต่อวัน"
        '
        'm_dosage
        '
        Me.m_dosage.Location = New System.Drawing.Point(957, 569)
        Me.m_dosage.Margin = New System.Windows.Forms.Padding(4)
        Me.m_dosage.Name = "m_dosage"
        Me.m_dosage.Size = New System.Drawing.Size(188, 22)
        Me.m_dosage.TabIndex = 175
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(951, 439)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 29)
        Me.Label12.TabIndex = 174
        Me.Label12.Text = "ชื่อยา"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(957, 486)
        Me.m_name.Margin = New System.Windows.Forms.Padding(4)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(188, 22)
        Me.m_name.TabIndex = 173
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(725, 439)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 29)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "หมายเลขยา"
        '
        'm_id
        '
        Me.m_id.Location = New System.Drawing.Point(730, 486)
        Me.m_id.Margin = New System.Windows.Forms.Padding(4)
        Me.m_id.Name = "m_id"
        Me.m_id.Size = New System.Drawing.Size(189, 22)
        Me.m_id.TabIndex = 171
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(725, 711)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 29)
        Me.Label11.TabIndex = 170
        Me.Label11.Text = "รายละเอียดการรักษา"
        '
        'm_desc
        '
        Me.m_desc.Location = New System.Drawing.Point(730, 762)
        Me.m_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(416, 117)
        Me.m_desc.TabIndex = 169
        Me.m_desc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(369, 522)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "นามสกุล"
        '
        'pt_lastName
        '
        Me.pt_lastName.Location = New System.Drawing.Point(374, 569)
        Me.pt_lastName.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_lastName.Name = "pt_lastName"
        Me.pt_lastName.Size = New System.Drawing.Size(188, 22)
        Me.pt_lastName.TabIndex = 167
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lable1.Location = New System.Drawing.Point(130, 436)
        Me.Lable1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(149, 29)
        Me.Lable1.TabIndex = 166
        Me.Lable1.Text = "หมายเลขผู้ป่วย"
        '
        'pt_id
        '
        Me.pt_id.Location = New System.Drawing.Point(135, 482)
        Me.pt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.pt_id.Name = "pt_id"
        Me.pt_id.Size = New System.Drawing.Size(188, 22)
        Me.pt_id.TabIndex = 165
        '
        'Edit_Presscript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 934)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.m_endDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.m_startDate)
        Me.Controls.Add(Me.m_method)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pt_firstName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.m_dosage)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.m_name)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.m_id)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.m_desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pt_lastName)
        Me.Controls.Add(Me.Lable1)
        Me.Controls.Add(Me.pt_id)
        Me.Controls.Add(Me.View_Edit_Press)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Presscript"
        Me.Text = "Edit_Presscript"
        CType(Me.View_Edit_Press, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents View_Edit_Press As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents m_endDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents m_startDate As TextBox
    Friend WithEvents m_method As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pt_firstName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents m_dosage As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents m_name As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents m_id As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents m_desc As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pt_lastName As TextBox
    Friend WithEvents Lable1 As Label
    Friend WithEvents pt_id As TextBox
End Class
