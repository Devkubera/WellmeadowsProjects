<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup_PatientWard
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pwDG = New System.Windows.Forms.DataGridView()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.PatientWardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_WardsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter()
        Me.PwIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pwDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientWardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(873, 426)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 50)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "เลือกข้อมูลที่ท่านต้องการ"
        '
        'pwDG
        '
        Me.pwDG.AllowUserToAddRows = False
        Me.pwDG.AllowUserToDeleteRows = False
        Me.pwDG.AllowUserToOrderColumns = True
        Me.pwDG.AutoGenerateColumns = False
        Me.pwDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pwDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PwIDDataGridViewTextBoxColumn, Me.CnIDDataGridViewTextBoxColumn, Me.PatientIDDataGridViewTextBoxColumn, Me.firstname, Me.lastname})
        Me.pwDG.DataSource = Me.PatientWardsBindingSource
        Me.pwDG.Location = New System.Drawing.Point(58, 161)
        Me.pwDG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pwDG.Name = "pwDG"
        Me.pwDG.ReadOnly = True
        Me.pwDG.RowHeadersWidth = 51
        Me.pwDG.RowTemplate.Height = 24
        Me.pwDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pwDG.Size = New System.Drawing.Size(936, 258)
        Me.pwDG.TabIndex = 16
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientWardsBindingSource
        '
        Me.PatientWardsBindingSource.DataMember = "Patient_Wards"
        Me.PatientWardsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Patient_WardsTableAdapter
        '
        Me.Patient_WardsTableAdapter.ClearBeforeFill = True
        '
        'PwIDDataGridViewTextBoxColumn
        '
        Me.PwIDDataGridViewTextBoxColumn.DataPropertyName = "pwID"
        Me.PwIDDataGridViewTextBoxColumn.HeaderText = "pwID"
        Me.PwIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PwIDDataGridViewTextBoxColumn.Name = "PwIDDataGridViewTextBoxColumn"
        Me.PwIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PwIDDataGridViewTextBoxColumn.Width = 125
        '
        'CnIDDataGridViewTextBoxColumn
        '
        Me.CnIDDataGridViewTextBoxColumn.DataPropertyName = "cnID"
        Me.CnIDDataGridViewTextBoxColumn.HeaderText = "cnID"
        Me.CnIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CnIDDataGridViewTextBoxColumn.Name = "CnIDDataGridViewTextBoxColumn"
        Me.CnIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CnIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "patientID"
        Me.PatientIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientIDDataGridViewTextBoxColumn.Width = 125
        '
        'firstname
        '
        Me.firstname.DataPropertyName = "firstname"
        Me.firstname.HeaderText = "firstname"
        Me.firstname.MinimumWidth = 6
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        Me.firstname.Width = 125
        '
        'lastname
        '
        Me.lastname.DataPropertyName = "lastname"
        Me.lastname.HeaderText = "lastname"
        Me.lastname.MinimumWidth = 6
        Me.lastname.Name = "lastname"
        Me.lastname.ReadOnly = True
        Me.lastname.Width = 125
        '
        'popup_PatientWard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 580)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pwDG)
        Me.Name = "popup_PatientWard"
        Me.Text = "popup_PatientWard"
        CType(Me.pwDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientWardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pwDG As DataGridView
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PatientWardsBindingSource As BindingSource
    Friend WithEvents Patient_WardsTableAdapter As WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter
    Friend WithEvents PwIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
End Class
