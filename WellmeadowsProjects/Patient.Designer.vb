﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ViewPa = New System.Windows.Forms.DataGridView()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KinsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalDocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateregisterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnVisit = New System.Windows.Forms.Button()
        Me.PatientsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PatientsTableAdapter()
        Me.LocalDoctorsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.LocalDoctorsTableAdapter()
        Me.Patient_kinsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Patient_kinsTableAdapter()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalDoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.Patient_kinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ViewPa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalDoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_kinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Patient"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(771, 120)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(241, 38)
        Me.txtSearch.TabIndex = 12
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lableSearch.Location = New System.Drawing.Point(766, 90)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(158, 26)
        Me.lableSearch.TabIndex = 13
        Me.lableSearch.Text = "ค้นหาหมายเลขผู้ป่วย"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1035, 112)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1159, 112)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'ViewPa
        '
        Me.ViewPa.AllowUserToAddRows = False
        Me.ViewPa.AllowUserToDeleteRows = False
        Me.ViewPa.AllowUserToOrderColumns = True
        Me.ViewPa.AutoGenerateColumns = False
        Me.ViewPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewPa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.KinsIDDataGridViewTextBoxColumn, Me.LocalDocIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.MarryStatusDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.DateregisterDataGridViewTextBoxColumn})
        Me.ViewPa.DataSource = Me.PatientsBindingSource1
        Me.ViewPa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ViewPa.Location = New System.Drawing.Point(121, 195)
        Me.ViewPa.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewPa.Name = "ViewPa"
        Me.ViewPa.ReadOnly = True
        Me.ViewPa.RowHeadersWidth = 51
        Me.ViewPa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewPa.Size = New System.Drawing.Size(1154, 404)
        Me.ViewPa.TabIndex = 16
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID"
        Me.PatientIDDataGridViewTextBoxColumn.Frozen = True
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "รหัสผู้ป่วย"
        Me.PatientIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientIDDataGridViewTextBoxColumn.Width = 90
        '
        'KinsIDDataGridViewTextBoxColumn
        '
        Me.KinsIDDataGridViewTextBoxColumn.DataPropertyName = "kinsID"
        Me.KinsIDDataGridViewTextBoxColumn.HeaderText = "รหัสญาติผู้ป่วย"
        Me.KinsIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KinsIDDataGridViewTextBoxColumn.Name = "KinsIDDataGridViewTextBoxColumn"
        Me.KinsIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.KinsIDDataGridViewTextBoxColumn.Width = 125
        '
        'LocalDocIDDataGridViewTextBoxColumn
        '
        Me.LocalDocIDDataGridViewTextBoxColumn.DataPropertyName = "localDocID"
        Me.LocalDocIDDataGridViewTextBoxColumn.HeaderText = "รหัสหมอท้องถิ่น"
        Me.LocalDocIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LocalDocIDDataGridViewTextBoxColumn.Name = "LocalDocIDDataGridViewTextBoxColumn"
        Me.LocalDocIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalDocIDDataGridViewTextBoxColumn.Width = 125
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "ชื่อ"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "นามสกุล"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "ที่อยู่"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "เพศภาพ"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 3
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 74
        '
        'MarryStatusDataGridViewTextBoxColumn
        '
        Me.MarryStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MarryStatusDataGridViewTextBoxColumn.DataPropertyName = "marryStatus"
        Me.MarryStatusDataGridViewTextBoxColumn.HeaderText = "สถานภาพ"
        Me.MarryStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MarryStatusDataGridViewTextBoxColumn.Name = "MarryStatusDataGridViewTextBoxColumn"
        Me.MarryStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarryStatusDataGridViewTextBoxColumn.Width = 81
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์"
        Me.TelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelDataGridViewTextBoxColumn.Width = 125
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "วันเกิด"
        Me.DobDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.ReadOnly = True
        Me.DobDataGridViewTextBoxColumn.Width = 125
        '
        'DateregisterDataGridViewTextBoxColumn
        '
        Me.DateregisterDataGridViewTextBoxColumn.DataPropertyName = "date_register"
        Me.DateregisterDataGridViewTextBoxColumn.HeaderText = "วันที่ลงทะเบียน"
        Me.DateregisterDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateregisterDataGridViewTextBoxColumn.Name = "DateregisterDataGridViewTextBoxColumn"
        Me.DateregisterDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateregisterDataGridViewTextBoxColumn.Width = 125
        '
        'PatientsBindingSource1
        '
        Me.PatientsBindingSource1.DataMember = "Patients"
        Me.PatientsBindingSource1.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReport.Location = New System.Drawing.Point(745, 635)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(160, 46)
        Me.btnReport.TabIndex = 18
        Me.btnReport.Text = "สร้างรายงาน"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(925, 635)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 46)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "แก้ไขข้อมูล"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(1099, 635)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 46)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "ลบข้อมูล"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnVisit
        '
        Me.btnVisit.BackColor = System.Drawing.Color.Black
        Me.btnVisit.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVisit.Location = New System.Drawing.Point(1035, 42)
        Me.btnVisit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVisit.Name = "btnVisit"
        Me.btnVisit.Size = New System.Drawing.Size(224, 46)
        Me.btnVisit.TabIndex = 21
        Me.btnVisit.Text = "การนัดหมายผู้ป่วย"
        Me.btnVisit.UseVisualStyleBackColor = False
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'LocalDoctorsTableAdapter
        '
        Me.LocalDoctorsTableAdapter.ClearBeforeFill = True
        '
        'Patient_kinsTableAdapter
        '
        Me.Patient_kinsTableAdapter.ClearBeforeFill = True
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'LocalDoctorsBindingSource
        '
        Me.LocalDoctorsBindingSource.DataMember = "LocalDoctors"
        Me.LocalDoctorsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.In_PatientsTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Login_logsTableAdapter = Nothing
        Me.TableAdapterManager.Med_EquipmentsTableAdapter = Nothing
        Me.TableAdapterManager.Med_MedicinesTableAdapter = Nothing
        Me.TableAdapterManager.Patient_kinsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_VisitsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_WardsTableAdapter = Nothing
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
        'Patient_kinsBindingSource
        '
        Me.Patient_kinsBindingSource.DataMember = "Patient_kins"
        Me.Patient_kinsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 942)
        Me.Controls.Add(Me.btnVisit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.ViewPa)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Patient"
        Me.Text = "Patient"
        CType(Me.ViewPa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalDoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_kinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lableSearch As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ViewPa As DataGridView
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnVisit As Button
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As WellmeadowsDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents PatientsBindingSource1 As BindingSource
    Friend WithEvents LocalDoctorsBindingSource As BindingSource
    Friend WithEvents LocalDoctorsTableAdapter As WellmeadowsDataSetTableAdapters.LocalDoctorsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KinsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalDocIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateregisterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Patient_kinsBindingSource As BindingSource
    Friend WithEvents Patient_kinsTableAdapter As WellmeadowsDataSetTableAdapters.Patient_kinsTableAdapter
End Class
