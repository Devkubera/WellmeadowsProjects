<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup_shifts
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
        Me.shiftTable = New System.Windows.Forms.DataGridView()
        Me.ShiftsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShiftsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.ShiftsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.shiftID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.shiftTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shiftTable
        '
        Me.shiftTable.AllowUserToAddRows = False
        Me.shiftTable.AllowUserToDeleteRows = False
        Me.shiftTable.AllowUserToOrderColumns = True
        Me.shiftTable.AutoGenerateColumns = False
        Me.shiftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.shiftTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.shiftID, Me.ShiftNameDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.EndTimeDataGridViewTextBoxColumn})
        Me.shiftTable.DataSource = Me.ShiftsBindingSource
        Me.shiftTable.Location = New System.Drawing.Point(97, 177)
        Me.shiftTable.Name = "shiftTable"
        Me.shiftTable.ReadOnly = True
        Me.shiftTable.RowHeadersWidth = 51
        Me.shiftTable.Size = New System.Drawing.Size(936, 272)
        Me.shiftTable.TabIndex = 33
        '
        'ShiftsBindingSource
        '
        Me.ShiftsBindingSource.DataMember = "Shifts"
        Me.ShiftsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(911, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 50)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 35)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "เลือกข้อมูลที่ท่านต้องการ"
        '
        'ShiftsTableAdapter
        '
        Me.ShiftsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PW_PrescriptsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Me.ShiftsTableAdapter
        Me.TableAdapterManager.Staff_ExperiencesTableAdapter = Nothing
        Me.TableAdapterManager.Staff_QualificatesTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppilersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'shiftID
        '
        Me.shiftID.DataPropertyName = "shiftID"
        Me.shiftID.HeaderText = "ID"
        Me.shiftID.MinimumWidth = 6
        Me.shiftID.Name = "shiftID"
        Me.shiftID.ReadOnly = True
        Me.shiftID.Width = 125
        '
        'ShiftNameDataGridViewTextBoxColumn
        '
        Me.ShiftNameDataGridViewTextBoxColumn.DataPropertyName = "shiftName"
        Me.ShiftNameDataGridViewTextBoxColumn.HeaderText = "ชื่อกะเวลา"
        Me.ShiftNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ShiftNameDataGridViewTextBoxColumn.Name = "ShiftNameDataGridViewTextBoxColumn"
        Me.ShiftNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShiftNameDataGridViewTextBoxColumn.Width = 125
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "เวลาเริ่มทำงาน"
        Me.StartTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        Me.StartTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.StartTimeDataGridViewTextBoxColumn.Width = 125
        '
        'EndTimeDataGridViewTextBoxColumn
        '
        Me.EndTimeDataGridViewTextBoxColumn.DataPropertyName = "endTime"
        Me.EndTimeDataGridViewTextBoxColumn.HeaderText = "สิ้นสุดการทำงาน"
        Me.EndTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EndTimeDataGridViewTextBoxColumn.Name = "EndTimeDataGridViewTextBoxColumn"
        Me.EndTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EndTimeDataGridViewTextBoxColumn.Width = 125
        '
        'popup_shifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 606)
        Me.Controls.Add(Me.shiftTable)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "popup_shifts"
        Me.Text = "popup_shifts"
        CType(Me.shiftTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents shiftTable As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents ShiftsBindingSource As BindingSource
    Friend WithEvents ShiftsTableAdapter As WellmeadowsDataSetTableAdapters.ShiftsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents shiftID As DataGridViewTextBoxColumn
    Friend WithEvents ShiftNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
