﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient_Presscipt
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewPress = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MmIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PWPrescriptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.PW_PrescriptsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PW_PrescriptsTableAdapter()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.Med_MedicinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Med_MedicinesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.ViewPress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWPrescriptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Med_MedicinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(1081, 619)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 46)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "ลบข้อมูล"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(908, 619)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 46)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "แก้ไขข้อมูล"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReport.Location = New System.Drawing.Point(728, 619)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(160, 46)
        Me.btnReport.TabIndex = 27
        Me.btnReport.Text = "สร้างรายงาน"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Location = New System.Drawing.Point(1141, 96)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lableSearch.Location = New System.Drawing.Point(830, 77)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(171, 20)
        Me.lableSearch.TabIndex = 23
        Me.lableSearch.Text = "ค้นหาหมายเลขใบจ่ายยา"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(97, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 35)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Pateint Presscipt"
        '
        'ViewPress
        '
        Me.ViewPress.AllowUserToAddRows = False
        Me.ViewPress.AllowUserToDeleteRows = False
        Me.ViewPress.AllowUserToOrderColumns = True
        Me.ViewPress.AutoGenerateColumns = False
        Me.ViewPress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewPress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.MmIDDataGridViewTextBoxColumn, Me.PwIDDataGridViewTextBoxColumn, Me.DoctorIDDataGridViewTextBoxColumn, Me.CnIDDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.descript, Me.CreateATDataGridViewTextBoxColumn})
        Me.ViewPress.DataSource = Me.PWPrescriptsBindingSource
        Me.ViewPress.Location = New System.Drawing.Point(104, 171)
        Me.ViewPress.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewPress.Name = "ViewPress"
        Me.ViewPress.ReadOnly = True
        Me.ViewPress.RowHeadersWidth = 51
        Me.ViewPress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewPress.Size = New System.Drawing.Size(1137, 404)
        Me.ViewPress.TabIndex = 26
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'MmIDDataGridViewTextBoxColumn
        '
        Me.MmIDDataGridViewTextBoxColumn.DataPropertyName = "mmID"
        Me.MmIDDataGridViewTextBoxColumn.HeaderText = "mmID"
        Me.MmIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MmIDDataGridViewTextBoxColumn.Name = "MmIDDataGridViewTextBoxColumn"
        Me.MmIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MmIDDataGridViewTextBoxColumn.Width = 125
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
        'DoctorIDDataGridViewTextBoxColumn
        '
        Me.DoctorIDDataGridViewTextBoxColumn.DataPropertyName = "doctorID"
        Me.DoctorIDDataGridViewTextBoxColumn.HeaderText = "doctorID"
        Me.DoctorIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DoctorIDDataGridViewTextBoxColumn.Name = "DoctorIDDataGridViewTextBoxColumn"
        Me.DoctorIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DoctorIDDataGridViewTextBoxColumn.Width = 125
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
        'DosageDataGridViewTextBoxColumn
        '
        Me.DosageDataGridViewTextBoxColumn.DataPropertyName = "dosage"
        Me.DosageDataGridViewTextBoxColumn.HeaderText = "dosage"
        Me.DosageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DosageDataGridViewTextBoxColumn.Name = "DosageDataGridViewTextBoxColumn"
        Me.DosageDataGridViewTextBoxColumn.ReadOnly = True
        Me.DosageDataGridViewTextBoxColumn.Width = 125
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "startDate"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "startDate"
        Me.StartDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.StartDateDataGridViewTextBoxColumn.Width = 125
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "endDate"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "endDate"
        Me.EndDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        Me.EndDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.EndDateDataGridViewTextBoxColumn.Width = 125
        '
        'descript
        '
        Me.descript.DataPropertyName = "descript"
        Me.descript.HeaderText = "descript"
        Me.descript.MinimumWidth = 6
        Me.descript.Name = "descript"
        Me.descript.ReadOnly = True
        Me.descript.Width = 125
        '
        'CreateATDataGridViewTextBoxColumn
        '
        Me.CreateATDataGridViewTextBoxColumn.DataPropertyName = "createAT"
        Me.CreateATDataGridViewTextBoxColumn.HeaderText = "createAT"
        Me.CreateATDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreateATDataGridViewTextBoxColumn.Name = "CreateATDataGridViewTextBoxColumn"
        Me.CreateATDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreateATDataGridViewTextBoxColumn.Width = 125
        '
        'PWPrescriptsBindingSource
        '
        Me.PWPrescriptsBindingSource.DataMember = "PW_Prescripts"
        Me.PWPrescriptsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PW_PrescriptsTableAdapter
        '
        Me.PW_PrescriptsTableAdapter.ClearBeforeFill = True
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Patient_WardsTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Me.PatientsTableAdapter
        Me.TableAdapterManager.PW_PrescriptsTableAdapter = Me.PW_PrescriptsTableAdapter
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
        'Med_MedicinesBindingSource
        '
        Me.Med_MedicinesBindingSource.DataMember = "Med_Medicines"
        Me.Med_MedicinesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Med_MedicinesTableAdapter
        '
        Me.Med_MedicinesTableAdapter.ClearBeforeFill = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(834, 112)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(298, 30)
        Me.txtSearch.TabIndex = 30
        '
        'Patient_Presscipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.ViewPress)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Patient_Presscipt"
        Me.Text = "Patient_Presscipt"
        CType(Me.ViewPress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWPrescriptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Med_MedicinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lableSearch As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ViewPress As DataGridView
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PWPrescriptsBindingSource As BindingSource
    Friend WithEvents PW_PrescriptsTableAdapter As WellmeadowsDataSetTableAdapters.PW_PrescriptsTableAdapter
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As WellmeadowsDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Med_MedicinesBindingSource As BindingSource
    Friend WithEvents Med_MedicinesTableAdapter As WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents MmIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PwIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoctorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents descript As DataGridViewTextBoxColumn
    Friend WithEvents CreateATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
End Class
