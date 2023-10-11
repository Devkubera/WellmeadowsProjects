<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientInWardForm
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
        Me.patientInWardPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pateintInWardTable = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbbPtype = New System.Windows.Forms.ComboBox()
        Me.patientInWardlb = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.patientInWardPanel.SuspendLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientInWardPanel
        '
        Me.patientInWardPanel.Controls.Add(Me.Button1)
        Me.patientInWardPanel.Controls.Add(Me.btnDel)
        Me.patientInWardPanel.Controls.Add(Me.btnEdit)
        Me.patientInWardPanel.Controls.Add(Me.btnReport)
        Me.patientInWardPanel.Controls.Add(Me.btnAdd)
        Me.patientInWardPanel.Controls.Add(Me.pateintInWardTable)
        Me.patientInWardPanel.Controls.Add(Me.btnSearch)
        Me.patientInWardPanel.Controls.Add(Me.cbbPtype)
        Me.patientInWardPanel.Controls.Add(Me.patientInWardlb)
        Me.patientInWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientInWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.patientInWardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.patientInWardPanel.Name = "patientInWardPanel"
        Me.patientInWardPanel.Size = New System.Drawing.Size(1339, 752)
        Me.patientInWardPanel.TabIndex = 0
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(1083, 633)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(160, 46)
        Me.btnDel.TabIndex = 35
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(909, 633)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 46)
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(729, 633)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(160, 46)
        Me.btnReport.TabIndex = 33
        Me.btnReport.Text = "สร้างรีพอร์ท"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(1143, 110)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pateintInWardTable
        '
        Me.pateintInWardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pateintInWardTable.Location = New System.Drawing.Point(105, 185)
        Me.pateintInWardTable.Margin = New System.Windows.Forms.Padding(4)
        Me.pateintInWardTable.Name = "pateintInWardTable"
        Me.pateintInWardTable.RowHeadersWidth = 51
        Me.pateintInWardTable.Size = New System.Drawing.Size(1137, 404)
        Me.pateintInWardTable.TabIndex = 30
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(1019, 110)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cbbPtype
        '
        Me.cbbPtype.FormattingEnabled = True
        Me.cbbPtype.Items.AddRange(New Object() {"In-Patient", "Out-Patient"})
        Me.cbbPtype.Location = New System.Drawing.Point(557, 122)
        Me.cbbPtype.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbPtype.Name = "cbbPtype"
        Me.cbbPtype.Size = New System.Drawing.Size(332, 24)
        Me.cbbPtype.TabIndex = 27
        '
        'patientInWardlb
        '
        Me.patientInWardlb.AutoSize = True
        Me.patientInWardlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientInWardlb.Location = New System.Drawing.Point(97, 105)
        Me.patientInWardlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.patientInWardlb.Name = "patientInWardlb"
        Me.patientInWardlb.Size = New System.Drawing.Size(244, 46)
        Me.patientInWardlb.TabIndex = 26
        Me.patientInWardlb.Text = "Patient in ward"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(1019, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 46)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "ข้อมูลผู้ป่วยใน"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PatientInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.patientInWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientInWardForm"
        Me.Text = "PatientInWardForm"
        Me.patientInWardPanel.ResumeLayout(False)
        Me.patientInWardPanel.PerformLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents patientInWardPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pateintInWardTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents cbbPtype As ComboBox
    Friend WithEvents patientInWardlb As Label
    Friend WithEvents Button1 As Button
End Class
