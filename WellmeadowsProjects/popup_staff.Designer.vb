<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup_staff
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
        Me.staff_table = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchlb = New System.Windows.Forms.Label()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.cbbEduLevel = New System.Windows.Forms.ComboBox()
        Me.cbbEduOrExp = New System.Windows.Forms.ComboBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        CType(Me.staff_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'staff_table
        '
        Me.staff_table.AllowUserToAddRows = False
        Me.staff_table.AllowUserToDeleteRows = False
        Me.staff_table.AllowUserToOrderColumns = True
        Me.staff_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.staff_table.Location = New System.Drawing.Point(113, 144)
        Me.staff_table.Name = "staff_table"
        Me.staff_table.ReadOnly = True
        Me.staff_table.RowHeadersWidth = 51
        Me.staff_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.staff_table.Size = New System.Drawing.Size(989, 272)
        Me.staff_table.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt SemiBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 35)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "เลือกข้อมูลที่ท่านต้องการ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(451, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 26)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "วิธีการแสดงข้อมูล"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(667, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 26)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "วุฒิการศึกษา"
        '
        'searchlb
        '
        Me.searchlb.AutoSize = True
        Me.searchlb.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlb.Location = New System.Drawing.Point(875, 44)
        Me.searchlb.Name = "searchlb"
        Me.searchlb.Size = New System.Drawing.Size(216, 26)
        Me.searchlb.TabIndex = 36
        Me.searchlb.Text = "ค้นหาเจ้าหน้าที่ด้วยชื่อองค์กร"
        '
        'SearchStaff
        '
        Me.SearchStaff.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchStaff.Location = New System.Drawing.Point(880, 82)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(219, 33)
        Me.SearchStaff.TabIndex = 35
        '
        'cbbEduLevel
        '
        Me.cbbEduLevel.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbEduLevel.FormattingEnabled = True
        Me.cbbEduLevel.Location = New System.Drawing.Point(672, 81)
        Me.cbbEduLevel.Name = "cbbEduLevel"
        Me.cbbEduLevel.Size = New System.Drawing.Size(176, 34)
        Me.cbbEduLevel.TabIndex = 34
        '
        'cbbEduOrExp
        '
        Me.cbbEduOrExp.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbEduOrExp.FormattingEnabled = True
        Me.cbbEduOrExp.Items.AddRange(New Object() {"เจ้าหน้าที่", "ประวัติการทำงาน", "ประวัติการศึกษา"})
        Me.cbbEduOrExp.Location = New System.Drawing.Point(456, 81)
        Me.cbbEduOrExp.Name = "cbbEduOrExp"
        Me.cbbEduOrExp.Size = New System.Drawing.Size(183, 34)
        Me.cbbEduOrExp.TabIndex = 33
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_ok.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_ok.Location = New System.Drawing.Point(980, 440)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(122, 50)
        Me.btn_ok.TabIndex = 39
        Me.btn_ok.Text = "ตกลง"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'popup_staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 559)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.searchlb)
        Me.Controls.Add(Me.SearchStaff)
        Me.Controls.Add(Me.cbbEduLevel)
        Me.Controls.Add(Me.cbbEduOrExp)
        Me.Controls.Add(Me.staff_table)
        Me.Controls.Add(Me.Label1)
        Me.Name = "popup_staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "popup_staff"
        CType(Me.staff_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents staff_table As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents searchlb As Label
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents cbbEduLevel As ComboBox
    Friend WithEvents cbbEduOrExp As ComboBox
    Friend WithEvents btn_ok As Button
End Class
