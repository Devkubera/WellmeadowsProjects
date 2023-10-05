<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup_localDoctor
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.seachbox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.doctorDG = New System.Windows.Forms.DataGridView()
        Me.LocalDoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.LocalDoctorsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.LocalDoctorsTableAdapter()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClinicIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalDocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.doctorDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalDoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(722, 306)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 41)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(752, 44)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ค้นหา"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(510, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ค้นหาด้วยชื่อ, เบอร์โทร"
        '
        'seachbox
        '
        Me.seachbox.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seachbox.Location = New System.Drawing.Point(514, 44)
        Me.seachbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.seachbox.Name = "seachbox"
        Me.seachbox.Size = New System.Drawing.Size(228, 29)
        Me.seachbox.TabIndex = 9
        Me.seachbox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "เลือกข้อมูลที่ท่านต้องการ"
        '
        'doctorDG
        '
        Me.doctorDG.AutoGenerateColumns = False
        Me.doctorDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.doctorDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocalDocIDDataGridViewTextBoxColumn, Me.ClinicIDDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn})
        Me.doctorDG.DataSource = Me.LocalDoctorsBindingSource
        Me.doctorDG.Location = New System.Drawing.Point(111, 90)
        Me.doctorDG.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.doctorDG.Name = "doctorDG"
        Me.doctorDG.RowHeadersWidth = 51
        Me.doctorDG.RowTemplate.Height = 24
        Me.doctorDG.Size = New System.Drawing.Size(702, 210)
        Me.doctorDG.TabIndex = 7
        '
        'LocalDoctorsBindingSource
        '
        Me.LocalDoctorsBindingSource.DataMember = "LocalDoctors"
        Me.LocalDoctorsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalDoctorsTableAdapter
        '
        Me.LocalDoctorsTableAdapter.ClearBeforeFill = True
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "เบอร์โทร"
        Me.TelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "ที่อยู่"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "ชื่อ - สกุล"
        Me.FullnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.Width = 125
        '
        'ClinicIDDataGridViewTextBoxColumn
        '
        Me.ClinicIDDataGridViewTextBoxColumn.DataPropertyName = "clinicID"
        Me.ClinicIDDataGridViewTextBoxColumn.HeaderText = "รหัสคลินิก"
        Me.ClinicIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClinicIDDataGridViewTextBoxColumn.Name = "ClinicIDDataGridViewTextBoxColumn"
        Me.ClinicIDDataGridViewTextBoxColumn.Width = 125
        '
        'LocalDocIDDataGridViewTextBoxColumn
        '
        Me.LocalDocIDDataGridViewTextBoxColumn.DataPropertyName = "localDocID"
        Me.LocalDocIDDataGridViewTextBoxColumn.HeaderText = "รหัสแพทย์"
        Me.LocalDocIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LocalDocIDDataGridViewTextBoxColumn.Name = "LocalDocIDDataGridViewTextBoxColumn"
        Me.LocalDocIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalDocIDDataGridViewTextBoxColumn.Width = 125
        '
        'popup_localDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 366)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.seachbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.doctorDG)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "popup_localDoctor"
        Me.Text = "popup_localDoctor"
        CType(Me.doctorDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalDoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents seachbox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents doctorDG As DataGridView
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents LocalDoctorsBindingSource As BindingSource
    Friend WithEvents LocalDoctorsTableAdapter As WellmeadowsDataSetTableAdapters.LocalDoctorsTableAdapter
    Friend WithEvents LocalDocIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClinicIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
