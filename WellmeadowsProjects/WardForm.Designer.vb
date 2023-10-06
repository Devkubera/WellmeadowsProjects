<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WardForm
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
        Me.wardPanel = New System.Windows.Forms.Panel()
        Me.Wardlb = New System.Windows.Forms.Label()
        Me.btnStaffInWard = New System.Windows.Forms.Button()
        Me.btnWaitinglist = New System.Windows.Forms.Button()
        Me.WardTable = New System.Windows.Forms.DataGridView()
        Me.btnPInward = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SearchWard = New System.Windows.Forms.TextBox()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.WardsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wardPanel.SuspendLayout()
        CType(Me.WardTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wardPanel
        '
        Me.wardPanel.Controls.Add(Me.Wardlb)
        Me.wardPanel.Controls.Add(Me.btnStaffInWard)
        Me.wardPanel.Controls.Add(Me.btnWaitinglist)
        Me.wardPanel.Controls.Add(Me.WardTable)
        Me.wardPanel.Controls.Add(Me.btnPInward)
        Me.wardPanel.Controls.Add(Me.btnSearch)
        Me.wardPanel.Controls.Add(Me.SearchWard)
        Me.wardPanel.Controls.Add(Me.placeholderlb)
        Me.wardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wardPanel.Location = New System.Drawing.Point(0, 0)
        Me.wardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.wardPanel.Name = "wardPanel"
        Me.wardPanel.Size = New System.Drawing.Size(1360, 800)
        Me.wardPanel.TabIndex = 0
        '
        'Wardlb
        '
        Me.Wardlb.AutoSize = True
        Me.Wardlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wardlb.Location = New System.Drawing.Point(100, 142)
        Me.Wardlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Wardlb.Name = "Wardlb"
        Me.Wardlb.Size = New System.Drawing.Size(98, 46)
        Me.Wardlb.TabIndex = 15
        Me.Wardlb.Text = "Ward"
        '
        'btnStaffInWard
        '
        Me.btnStaffInWard.BackColor = System.Drawing.Color.Black
        Me.btnStaffInWard.Font = New System.Drawing.Font("Prompt SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffInWard.ForeColor = System.Drawing.Color.White
        Me.btnStaffInWard.Location = New System.Drawing.Point(1125, 28)
        Me.btnStaffInWard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStaffInWard.Name = "btnStaffInWard"
        Me.btnStaffInWard.Size = New System.Drawing.Size(160, 46)
        Me.btnStaffInWard.TabIndex = 29
        Me.btnStaffInWard.Text = "เจ้าหน้าที่แต่ละวอร์ด"
        Me.btnStaffInWard.UseVisualStyleBackColor = False
        '
        'btnWaitinglist
        '
        Me.btnWaitinglist.BackColor = System.Drawing.Color.Black
        Me.btnWaitinglist.Font = New System.Drawing.Font("Prompt SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaitinglist.ForeColor = System.Drawing.Color.White
        Me.btnWaitinglist.Location = New System.Drawing.Point(944, 28)
        Me.btnWaitinglist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWaitinglist.Name = "btnWaitinglist"
        Me.btnWaitinglist.Size = New System.Drawing.Size(160, 46)
        Me.btnWaitinglist.TabIndex = 28
        Me.btnWaitinglist.Text = "ผู้ป่วยรอเตียง"
        Me.btnWaitinglist.UseVisualStyleBackColor = False
        '
        'WardTable
        '
        Me.WardTable.AutoGenerateColumns = False
        Me.WardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WardTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.WardIDDataGridViewTextBoxColumn, Me.WardNameDataGridViewTextBoxColumn, Me.WardLocationDataGridViewTextBoxColumn, Me.WardTelDataGridViewTextBoxColumn, Me.TotalBedDataGridViewTextBoxColumn})
        Me.WardTable.DataSource = Me.WardsBindingSource
        Me.WardTable.Location = New System.Drawing.Point(93, 236)
        Me.WardTable.Margin = New System.Windows.Forms.Padding(4)
        Me.WardTable.Name = "WardTable"
        Me.WardTable.RowHeadersWidth = 51
        Me.WardTable.Size = New System.Drawing.Size(1137, 404)
        Me.WardTable.TabIndex = 20
        '
        'btnPInward
        '
        Me.btnPInward.BackColor = System.Drawing.Color.Black
        Me.btnPInward.Font = New System.Drawing.Font("Prompt SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPInward.ForeColor = System.Drawing.Color.White
        Me.btnPInward.Location = New System.Drawing.Point(761, 28)
        Me.btnPInward.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPInward.Name = "btnPInward"
        Me.btnPInward.Size = New System.Drawing.Size(160, 46)
        Me.btnPInward.TabIndex = 27
        Me.btnPInward.Text = "ผู้ป่วยในวอร์ด"
        Me.btnPInward.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(1152, 146)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'SearchWard
        '
        Me.SearchWard.Location = New System.Drawing.Point(944, 165)
        Me.SearchWard.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchWard.Name = "SearchWard"
        Me.SearchWard.Size = New System.Drawing.Size(188, 22)
        Me.SearchWard.TabIndex = 18
        '
        'placeholderlb
        '
        Me.placeholderlb.AutoSize = True
        Me.placeholderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeholderlb.Location = New System.Drawing.Point(939, 129)
        Me.placeholderlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(191, 30)
        Me.placeholderlb.TabIndex = 21
        Me.placeholderlb.Text = "ค้นหาด้วยวอร์ดไอดี..."
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "Wards"
        Me.WardsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'WardIDDataGridViewTextBoxColumn
        '
        Me.WardIDDataGridViewTextBoxColumn.DataPropertyName = "wardID"
        Me.WardIDDataGridViewTextBoxColumn.HeaderText = "wardID"
        Me.WardIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardIDDataGridViewTextBoxColumn.Name = "WardIDDataGridViewTextBoxColumn"
        Me.WardIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WardIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardNameDataGridViewTextBoxColumn
        '
        Me.WardNameDataGridViewTextBoxColumn.DataPropertyName = "wardName"
        Me.WardNameDataGridViewTextBoxColumn.HeaderText = "wardName"
        Me.WardNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn.Name = "WardNameDataGridViewTextBoxColumn"
        Me.WardNameDataGridViewTextBoxColumn.Width = 125
        '
        'WardLocationDataGridViewTextBoxColumn
        '
        Me.WardLocationDataGridViewTextBoxColumn.DataPropertyName = "wardLocation"
        Me.WardLocationDataGridViewTextBoxColumn.HeaderText = "wardLocation"
        Me.WardLocationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardLocationDataGridViewTextBoxColumn.Name = "WardLocationDataGridViewTextBoxColumn"
        Me.WardLocationDataGridViewTextBoxColumn.Width = 125
        '
        'WardTelDataGridViewTextBoxColumn
        '
        Me.WardTelDataGridViewTextBoxColumn.DataPropertyName = "wardTel"
        Me.WardTelDataGridViewTextBoxColumn.HeaderText = "wardTel"
        Me.WardTelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardTelDataGridViewTextBoxColumn.Name = "WardTelDataGridViewTextBoxColumn"
        Me.WardTelDataGridViewTextBoxColumn.Width = 125
        '
        'TotalBedDataGridViewTextBoxColumn
        '
        Me.TotalBedDataGridViewTextBoxColumn.DataPropertyName = "totalBed"
        Me.TotalBedDataGridViewTextBoxColumn.HeaderText = "totalBed"
        Me.TotalBedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalBedDataGridViewTextBoxColumn.Name = "TotalBedDataGridViewTextBoxColumn"
        Me.TotalBedDataGridViewTextBoxColumn.Width = 125
        '
        'WardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 800)
        Me.Controls.Add(Me.wardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "WardForm"
        Me.Text = "WardForm"
        Me.wardPanel.ResumeLayout(False)
        Me.wardPanel.PerformLayout()
        CType(Me.WardTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wardPanel As Panel
    Friend WithEvents placeholderlb As Label
    Friend WithEvents WardTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents SearchWard As TextBox
    Friend WithEvents Wardlb As Label
    Friend WithEvents btnWaitinglist As Button
    Friend WithEvents btnPInward As Button
    Friend WithEvents btnStaffInWard As Button
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As WellmeadowsDataSetTableAdapters.WardsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalBedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
