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
        Me.View_Edit_Visit = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.visit_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.visit_doc_Id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.visit_w_Id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.visit_date = New System.Windows.Forms.TextBox()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.visit_p_Id = New System.Windows.Forms.TextBox()
        CType(Me.View_Edit_Visit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_Edit_Visit
        '
        Me.View_Edit_Visit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Edit_Visit.Location = New System.Drawing.Point(602, 111)
        Me.View_Edit_Visit.Margin = New System.Windows.Forms.Padding(4)
        Me.View_Edit_Visit.Name = "View_Edit_Visit"
        Me.View_Edit_Visit.RowHeadersWidth = 51
        Me.View_Edit_Visit.Size = New System.Drawing.Size(637, 587)
        Me.View_Edit_Visit.TabIndex = 47
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1079, 20)
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
        Me.Label1.Location = New System.Drawing.Point(398, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 36)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "แก้ไขข้อมูลประวัติการมาโรงพยาบาล"
        '
        'visit_type
        '
        Me.visit_type.FormattingEnabled = True
        Me.visit_type.Items.AddRange(New Object() {"นัดหมาย", "Walk in"})
        Me.visit_type.Location = New System.Drawing.Point(31, 410)
        Me.visit_type.Name = "visit_type"
        Me.visit_type.Size = New System.Drawing.Size(188, 24)
        Me.visit_type.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(26, 350)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 29)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "การเข้าพบแพทย์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(376, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 29)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "หมายเลขแพทย์"
        '
        'visit_doc_Id
        '
        Me.visit_doc_Id.Location = New System.Drawing.Point(382, 155)
        Me.visit_doc_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_doc_Id.Name = "visit_doc_Id"
        Me.visit_doc_Id.Size = New System.Drawing.Size(188, 22)
        Me.visit_doc_Id.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(376, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 29)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "หมายเลขวอร์ด"
        '
        'visit_w_Id
        '
        Me.visit_w_Id.Location = New System.Drawing.Point(382, 276)
        Me.visit_w_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_w_Id.Name = "visit_w_Id"
        Me.visit_w_Id.Size = New System.Drawing.Size(188, 22)
        Me.visit_w_Id.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(26, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "วันที่นัดหมาย"
        '
        'visit_date
        '
        Me.visit_date.Location = New System.Drawing.Point(31, 276)
        Me.visit_date.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_date.Name = "visit_date"
        Me.visit_date.Size = New System.Drawing.Size(188, 22)
        Me.visit_date.TabIndex = 55
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(26, 108)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(149, 29)
        Me.lableSearch.TabIndex = 54
        Me.lableSearch.Text = "หมายเลขผู้ป่วย"
        '
        'visit_p_Id
        '
        Me.visit_p_Id.Location = New System.Drawing.Point(31, 155)
        Me.visit_p_Id.Margin = New System.Windows.Forms.Padding(4)
        Me.visit_p_Id.Name = "visit_p_Id"
        Me.visit_p_Id.Size = New System.Drawing.Size(188, 22)
        Me.visit_p_Id.TabIndex = 53
        '
        'Edit_VisitPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 763)
        Me.Controls.Add(Me.visit_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.visit_doc_Id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.visit_w_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.visit_date)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.visit_p_Id)
        Me.Controls.Add(Me.View_Edit_Visit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_VisitPatient"
        Me.Text = "Edit_VisitPatient"
        CType(Me.View_Edit_Visit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents View_Edit_Visit As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents visit_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents visit_doc_Id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents visit_w_Id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents visit_date As TextBox
    Friend WithEvents lableSearch As Label
    Friend WithEvents visit_p_Id As TextBox
End Class
