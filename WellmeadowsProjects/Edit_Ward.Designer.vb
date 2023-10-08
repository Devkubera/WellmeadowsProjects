<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Ward
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
        Me.EditWard = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.ward_bed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ward_tel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ward_location = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ward_name = New System.Windows.Forms.TextBox()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.WardsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditWard
        '
        Me.EditWard.AutoSize = True
        Me.EditWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditWard.Location = New System.Drawing.Point(361, 31)
        Me.EditWard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EditWard.Name = "EditWard"
        Me.EditWard.Size = New System.Drawing.Size(259, 31)
        Me.EditWard.TabIndex = 126
        Me.EditWard.Text = "แก้ไขข้อมูลวอร์ดผู้ป่วย"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(421, 427)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 49)
        Me.btnAdd.TabIndex = 160
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(517, 244)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(149, 25)
        Me.label5.TabIndex = 168
        Me.label5.Text = "จำนวนเตียงทั้งหมด"
        '
        'ward_bed
        '
        Me.ward_bed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ward_bed.Location = New System.Drawing.Point(522, 292)
        Me.ward_bed.Margin = New System.Windows.Forms.Padding(4)
        Me.ward_bed.Name = "ward_bed"
        Me.ward_bed.Size = New System.Drawing.Size(188, 30)
        Me.ward_bed.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 244)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "หมายเลขโทรศัพท์"
        '
        'ward_tel
        '
        Me.ward_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ward_tel.Location = New System.Drawing.Point(295, 292)
        Me.ward_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.ward_tel.Name = "ward_tel"
        Me.ward_tel.Size = New System.Drawing.Size(188, 30)
        Me.ward_tel.TabIndex = 165
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(517, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "ตำแน่งที่ตั้งของวอร์ด"
        '
        'ward_location
        '
        Me.ward_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ward_location.Location = New System.Drawing.Point(522, 171)
        Me.ward_location.Margin = New System.Windows.Forms.Padding(4)
        Me.ward_location.Name = "ward_location"
        Me.ward_location.Size = New System.Drawing.Size(188, 30)
        Me.ward_location.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "ชื่อวอร์ด"
        '
        'ward_name
        '
        Me.ward_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ward_name.Location = New System.Drawing.Point(295, 171)
        Me.ward_name.Margin = New System.Windows.Forms.Padding(4)
        Me.ward_name.Name = "ward_name"
        Me.ward_name.Size = New System.Drawing.Size(188, 30)
        Me.ward_name.TabIndex = 161
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
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.Staff_ExperiencesTableAdapter = Nothing
        Me.TableAdapterManager.Staff_QualificatesTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppilersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Me.WardsTableAdapter
        '
        'Edit_Ward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 703)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.ward_bed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ward_tel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ward_location)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ward_name)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.EditWard)
        Me.Name = "Edit_Ward"
        Me.Text = "Edit_Ward"
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EditWard As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents label5 As Label
    Friend WithEvents ward_bed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ward_tel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ward_location As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ward_name As TextBox
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As WellmeadowsDataSetTableAdapters.WardsTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
End Class