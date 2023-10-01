<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_PatientVisit
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.visit_w_Id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.visit_date = New System.Windows.Forms.TextBox()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.visit_p_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.visit_doc_Id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.visit_type = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1125, 30)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 46)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.Text = "เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(1004, 30)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 46)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(753, 272)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 29)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "หมายเลขวอร์ด"
        '
        'visit_w_Id
        '
        Me.visit_w_Id.Location = New System.Drawing.Point(759, 319)
        Me.visit_w_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_w_Id.Name = "visit_w_Id"
        Me.visit_w_Id.Size = New System.Drawing.Size(188, 22)
        Me.visit_w_Id.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(403, 272)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "วันที่นัดหมาย"
        '
        'visit_date
        '
        Me.visit_date.Location = New System.Drawing.Point(408, 319)
        Me.visit_date.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_date.Name = "visit_date"
        Me.visit_date.Size = New System.Drawing.Size(188, 22)
        Me.visit_date.TabIndex = 39
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(403, 151)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(149, 29)
        Me.lableSearch.TabIndex = 37
        Me.lableSearch.Text = "หมายเลขผู้ป่วย"
        '
        'visit_p_Id
        '
        Me.visit_p_Id.Location = New System.Drawing.Point(408, 198)
        Me.visit_p_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_p_Id.Name = "visit_p_Id"
        Me.visit_p_Id.Size = New System.Drawing.Size(188, 22)
        Me.visit_p_Id.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(457, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 36)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "เพิ่มข้อมูลประวัติการมาโรงพยาบาล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(753, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 29)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "หมายเลขแพทย์"
        '
        'visit_doc_Id
        '
        Me.visit_doc_Id.Location = New System.Drawing.Point(759, 198)
        Me.visit_doc_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_doc_Id.Name = "visit_doc_Id"
        Me.visit_doc_Id.Size = New System.Drawing.Size(188, 22)
        Me.visit_doc_Id.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(403, 393)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 29)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "การเข้าพบแพทย์"
        '
        'visit_type
        '
        Me.visit_type.FormattingEnabled = True
        Me.visit_type.Items.AddRange(New Object() {"นัดหมาย", "Walk in"})
        Me.visit_type.Location = New System.Drawing.Point(408, 453)
        Me.visit_type.Name = "visit_type"
        Me.visit_type.Size = New System.Drawing.Size(188, 24)
        Me.visit_type.TabIndex = 52
        '
        'Add_PatientVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.visit_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.visit_doc_Id)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.visit_w_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.visit_date)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.visit_p_Id)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_PatientVisit"
        Me.Text = "Add_PatientVisit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents visit_w_Id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents visit_date As TextBox
    Friend WithEvents lableSearch As Label
    Friend WithEvents visit_p_Id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents visit_doc_Id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents visit_type As ComboBox
End Class
