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
        Me.components = New System.ComponentModel.Container()
        Me.patientInWardPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.pateintInWardTable = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.cbbEduLevel = New System.Windows.Forms.ComboBox()
        Me.patientInWardlb = New System.Windows.Forms.Label()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.WellmeadowsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.patientInWardPanel.SuspendLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientInWardPanel
        '
        Me.patientInWardPanel.Controls.Add(Me.btnDel)
        Me.patientInWardPanel.Controls.Add(Me.btnEdit)
        Me.patientInWardPanel.Controls.Add(Me.btnReport)
        Me.patientInWardPanel.Controls.Add(Me.btnAdd)
        Me.patientInWardPanel.Controls.Add(Me.placeholderlb)
        Me.patientInWardPanel.Controls.Add(Me.pateintInWardTable)
        Me.patientInWardPanel.Controls.Add(Me.btnSearch)
        Me.patientInWardPanel.Controls.Add(Me.SearchStaff)
        Me.patientInWardPanel.Controls.Add(Me.cbbEduLevel)
        Me.patientInWardPanel.Controls.Add(Me.patientInWardlb)
        Me.patientInWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientInWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.patientInWardPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'placeholderlb
        '
        Me.placeholderlb.AutoSize = True
        Me.placeholderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeholderlb.Location = New System.Drawing.Point(769, 74)
        Me.placeholderlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(262, 30)
        Me.placeholderlb.TabIndex = 31
        Me.placeholderlb.Text = "ค้นหาเจ้าหน้าที่ด้วยชื่อองค์กร.."
        '
        'pateintInWardTable
        '
        Me.pateintInWardTable.AllowUserToAddRows = False
        Me.pateintInWardTable.AutoGenerateColumns = False
        Me.pateintInWardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pateintInWardTable.DataSource = Me.WellmeadowsDataSetBindingSource
        Me.pateintInWardTable.Location = New System.Drawing.Point(105, 185)
        Me.pateintInWardTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'SearchStaff
        '
        Me.SearchStaff.Location = New System.Drawing.Point(775, 110)
        Me.SearchStaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(188, 22)
        Me.SearchStaff.TabIndex = 28
        '
        'cbbEduLevel
        '
        Me.cbbEduLevel.FormattingEnabled = True
        Me.cbbEduLevel.Items.AddRange(New Object() {"In-Patient", "Out-Patient"})
        Me.cbbEduLevel.Location = New System.Drawing.Point(555, 112)
        Me.cbbEduLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbEduLevel.Name = "cbbEduLevel"
        Me.cbbEduLevel.Size = New System.Drawing.Size(160, 24)
        Me.cbbEduLevel.TabIndex = 27
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
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WellmeadowsDataSetBindingSource
        '
        Me.WellmeadowsDataSetBindingSource.DataSource = Me.WellmeadowsDataSet
        Me.WellmeadowsDataSetBindingSource.Position = 0
        '
        'PatientInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.patientInWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PatientInWardForm"
        Me.Text = "PatientInWardForm"
        Me.patientInWardPanel.ResumeLayout(False)
        Me.patientInWardPanel.PerformLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents patientInWardPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents placeholderlb As Label
    Friend WithEvents pateintInWardTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents cbbEduLevel As ComboBox
    Friend WithEvents patientInWardlb As Label
    Friend WithEvents WellmeadowsDataSetBindingSource As BindingSource
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
End Class
