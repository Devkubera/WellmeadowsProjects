<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientInWardForm
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
        Me.patientInWardPanel = New System.Windows.Forms.Panel()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_open_inp = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pateintInWardTable = New System.Windows.Forms.DataGridView()
        Me.cbbPtype = New System.Windows.Forms.ComboBox()
        Me.patientInWardlb = New System.Windows.Forms.Label()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Patient_WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_WardsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.patientInWardPanel.SuspendLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientInWardPanel
        '
        Me.patientInWardPanel.Controls.Add(Me.searchBox)
        Me.patientInWardPanel.Controls.Add(Me.Label2)
        Me.patientInWardPanel.Controls.Add(Me.Label1)
        Me.patientInWardPanel.Controls.Add(Me.btn_open_inp)
        Me.patientInWardPanel.Controls.Add(Me.btnDel)
        Me.patientInWardPanel.Controls.Add(Me.btnEdit)
        Me.patientInWardPanel.Controls.Add(Me.btnReport)
        Me.patientInWardPanel.Controls.Add(Me.btnAdd)
        Me.patientInWardPanel.Controls.Add(Me.pateintInWardTable)
        Me.patientInWardPanel.Controls.Add(Me.cbbPtype)
        Me.patientInWardPanel.Controls.Add(Me.patientInWardlb)
        Me.patientInWardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientInWardPanel.Location = New System.Drawing.Point(0, 0)
        Me.patientInWardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.patientInWardPanel.Name = "patientInWardPanel"
        Me.patientInWardPanel.Size = New System.Drawing.Size(1339, 905)
        Me.patientInWardPanel.TabIndex = 0
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(953, 124)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(290, 38)
        Me.searchBox.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(948, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 26)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "ค้นหาผู้ป่วยด้วยชื่อ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(625, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 26)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "ประเภทผู้ป่วย"
        '
        'btn_open_inp
        '
        Me.btn_open_inp.BackColor = System.Drawing.Color.Black
        Me.btn_open_inp.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_open_inp.ForeColor = System.Drawing.Color.White
        Me.btn_open_inp.Location = New System.Drawing.Point(1019, 28)
        Me.btn_open_inp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_open_inp.Name = "btn_open_inp"
        Me.btn_open_inp.Size = New System.Drawing.Size(223, 46)
        Me.btn_open_inp.TabIndex = 36
        Me.btn_open_inp.Text = "ข้อมูลผู้ป่วยใน"
        Me.btn_open_inp.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(934, 629)
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
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(760, 629)
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
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(393, 629)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(347, 46)
        Me.btnReport.TabIndex = 33
        Me.btnReport.Text = "สร้างรีพอร์ท"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(1113, 629)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 46)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pateintInWardTable
        '
        Me.pateintInWardTable.AllowUserToAddRows = False
        Me.pateintInWardTable.AllowUserToDeleteRows = False
        Me.pateintInWardTable.AllowUserToOrderColumns = True
        Me.pateintInWardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pateintInWardTable.Location = New System.Drawing.Point(105, 185)
        Me.pateintInWardTable.Margin = New System.Windows.Forms.Padding(4)
        Me.pateintInWardTable.Name = "pateintInWardTable"
        Me.pateintInWardTable.RowHeadersWidth = 51
        Me.pateintInWardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pateintInWardTable.Size = New System.Drawing.Size(1137, 404)
        Me.pateintInWardTable.TabIndex = 30
        '
        'cbbPtype
        '
        Me.cbbPtype.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbPtype.FormattingEnabled = True
        Me.cbbPtype.Items.AddRange(New Object() {"ทั้งหมด", "ผู้ป่วยใน", "ผู้ป่วยนอก"})
        Me.cbbPtype.Location = New System.Drawing.Point(630, 124)
        Me.cbbPtype.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbPtype.Name = "cbbPtype"
        Me.cbbPtype.Size = New System.Drawing.Size(273, 38)
        Me.cbbPtype.TabIndex = 27
        '
        'patientInWardlb
        '
        Me.patientInWardlb.AutoSize = True
        Me.patientInWardlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientInWardlb.Location = New System.Drawing.Point(97, 116)
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
        'Patient_WardsBindingSource
        '
        Me.Patient_WardsBindingSource.DataMember = "Patient_Wards"
        Me.Patient_WardsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Patient_WardsTableAdapter
        '
        Me.Patient_WardsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.ChargeNursesTableAdapter = Nothing
        Me.TableAdapterManager.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.In_PatientsTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Login_logsTableAdapter = Nothing
        Me.TableAdapterManager.Med_EquipmentsTableAdapter = Nothing
        Me.TableAdapterManager.Med_MedicinesTableAdapter = Nothing
        Me.TableAdapterManager.MedicalDirectorsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_kinsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_VisitsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_WardsTableAdapter = Me.Patient_WardsTableAdapter
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PW_PrescriptsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.Staff_ExperiencesTableAdapter = Nothing
        Me.TableAdapterManager.Staff_QualificatesTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppilersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'PatientInWardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 905)
        Me.Controls.Add(Me.patientInWardPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientInWardForm"
        Me.Text = "PatientInWardForm"
        Me.patientInWardPanel.ResumeLayout(False)
        Me.patientInWardPanel.PerformLayout()
        CType(Me.pateintInWardTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents patientInWardPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pateintInWardTable As DataGridView
    Friend WithEvents cbbPtype As ComboBox
    Friend WithEvents patientInWardlb As Label
    Friend WithEvents btn_open_inp As Button
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents Patient_WardsBindingSource As BindingSource
    Friend WithEvents Patient_WardsTableAdapter As WellmeadowsDataSetTableAdapters.Patient_WardsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label2 As Label
End Class
