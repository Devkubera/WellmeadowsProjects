<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class popup_PatientWard
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
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pwDG = New System.Windows.Forms.DataGridView()
        Me.PatientWardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Patient_WardsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter()
        CType(Me.pwDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientWardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
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
        Me.Label1.Font = New System.Drawing.Font("Prompt", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 35)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "เลือกข้อมูลที่ท่านต้องการ"
        '
        'pwDG
        '
        Me.pwDG.AllowUserToAddRows = False
        Me.pwDG.AllowUserToDeleteRows = False
        Me.pwDG.AllowUserToOrderColumns = True
        Me.pwDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pwDG.Location = New System.Drawing.Point(58, 149)
        Me.pwDG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pwDG.Name = "pwDG"
        Me.pwDG.ReadOnly = True
        Me.pwDG.RowHeadersWidth = 51
        Me.pwDG.RowTemplate.Height = 24
        Me.pwDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pwDG.Size = New System.Drawing.Size(936, 258)
        Me.pwDG.TabIndex = 16
        '
        'PatientWardsBindingSource
        '
        Me.PatientWardsBindingSource.DataMember = "Patient_Wards"
        Me.PatientWardsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_WardsTableAdapter
        '
        Me.Patient_WardsTableAdapter.ClearBeforeFill = True
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
        CType(Me.PatientWardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pwDG As DataGridView
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PatientWardsBindingSource As BindingSource
    Friend WithEvents Patient_WardsTableAdapter As WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter
End Class
