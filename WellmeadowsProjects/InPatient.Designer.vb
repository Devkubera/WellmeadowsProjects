<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InPatient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ViewInPa = New System.Windows.Forms.DataGridView()
        Me.btnUp_Out_ward = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.ViewInPa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(103, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "In-Pateint"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(812, 99)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(188, 22)
        Me.txtSearch.TabIndex = 1
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lableSearch.Location = New System.Drawing.Point(807, 70)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(182, 25)
        Me.lableSearch.TabIndex = 2
        Me.lableSearch.Text = "ค้นหาหมายเลขผู้ป่วยใน"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1023, 79)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Location = New System.Drawing.Point(1147, 79)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'ViewInPa
        '
        Me.ViewInPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewInPa.Location = New System.Drawing.Point(109, 154)
        Me.ViewInPa.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewInPa.Name = "ViewInPa"
        Me.ViewInPa.RowHeadersWidth = 51
        Me.ViewInPa.Size = New System.Drawing.Size(1137, 404)
        Me.ViewInPa.TabIndex = 5
        '
        'btnUp_Out_ward
        '
        Me.btnUp_Out_ward.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUp_Out_ward.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUp_Out_ward.Location = New System.Drawing.Point(109, 602)
        Me.btnUp_Out_ward.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUp_Out_ward.Name = "btnUp_Out_ward"
        Me.btnUp_Out_ward.Size = New System.Drawing.Size(333, 46)
        Me.btnUp_Out_ward.TabIndex = 6
        Me.btnUp_Out_ward.Text = "อัพเดตผู้ป่วยที่ออกจากวอร์ดไปแล้ว"
        Me.btnUp_Out_ward.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReport.Location = New System.Drawing.Point(733, 602)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(160, 46)
        Me.btnReport.TabIndex = 7
        Me.btnReport.Text = "สร้างรายงาน"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(913, 602)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 46)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "แก้ไขข้อมูล"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(1087, 602)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 46)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "ลบข้อมูล"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'InPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 800)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnUp_Out_ward)
        Me.Controls.Add(Me.ViewInPa)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InPatient"
        Me.Text = "InPatient"
        CType(Me.ViewInPa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lableSearch As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ViewInPa As DataGridView
    Friend WithEvents btnUp_Out_ward As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
