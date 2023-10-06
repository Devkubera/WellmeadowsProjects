<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine
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
        Me.btnVisit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ViewMedi = New System.Windows.Forms.DataGridView()
        Me.MmIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyscaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceperunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedMedicinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Med_MedicinesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter()
        Me.SuppilersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppilersTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.SuppilersTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        CType(Me.ViewMedi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedMedicinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppilersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVisit
        '
        Me.btnVisit.BackColor = System.Drawing.Color.Black
        Me.btnVisit.ForeColor = System.Drawing.Color.Snow
        Me.btnVisit.Location = New System.Drawing.Point(820, 33)
        Me.btnVisit.Name = "btnVisit"
        Me.btnVisit.Size = New System.Drawing.Size(120, 37)
        Me.btnVisit.TabIndex = 31
        Me.btnVisit.Text = "การให้ยาผู้ป่วย"
        Me.btnVisit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(820, 515)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 37)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "ลบข้อมูล"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(690, 515)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 37)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "แก้ไขข้อมูล"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'ViewMedi
        '
        Me.ViewMedi.AllowUserToAddRows = False
        Me.ViewMedi.AllowUserToDeleteRows = False
        Me.ViewMedi.AllowUserToOrderColumns = True
        Me.ViewMedi.AutoGenerateColumns = False
        Me.ViewMedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewMedi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MmIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.MethodDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.BuyscaleDataGridViewTextBoxColumn, Me.PriceperunitDataGridViewTextBoxColumn})
        Me.ViewMedi.DataSource = Me.MedMedicinesBindingSource
        Me.ViewMedi.Location = New System.Drawing.Point(87, 151)
        Me.ViewMedi.Name = "ViewMedi"
        Me.ViewMedi.ReadOnly = True
        Me.ViewMedi.RowHeadersWidth = 51
        Me.ViewMedi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewMedi.Size = New System.Drawing.Size(853, 328)
        Me.ViewMedi.TabIndex = 27
        '
        'MmIDDataGridViewTextBoxColumn
        '
        Me.MmIDDataGridViewTextBoxColumn.DataPropertyName = "mmID"
        Me.MmIDDataGridViewTextBoxColumn.HeaderText = "หมายเลขยา"
        Me.MmIDDataGridViewTextBoxColumn.Name = "MmIDDataGridViewTextBoxColumn"
        Me.MmIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "หมายเลขผู้ผลิต"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "ชื่อยา"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "รายละเอียดยา"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DosageDataGridViewTextBoxColumn
        '
        Me.DosageDataGridViewTextBoxColumn.DataPropertyName = "dosage"
        Me.DosageDataGridViewTextBoxColumn.HeaderText = "ปริมาณ"
        Me.DosageDataGridViewTextBoxColumn.Name = "DosageDataGridViewTextBoxColumn"
        Me.DosageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MethodDataGridViewTextBoxColumn
        '
        Me.MethodDataGridViewTextBoxColumn.DataPropertyName = "method"
        Me.MethodDataGridViewTextBoxColumn.HeaderText = "วิธีการให้ยา"
        Me.MethodDataGridViewTextBoxColumn.Name = "MethodDataGridViewTextBoxColumn"
        Me.MethodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "จำนวนในคลัง"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuyscaleDataGridViewTextBoxColumn
        '
        Me.BuyscaleDataGridViewTextBoxColumn.DataPropertyName = "buy_scale"
        Me.BuyscaleDataGridViewTextBoxColumn.HeaderText = "ปริมาณการซื้อ"
        Me.BuyscaleDataGridViewTextBoxColumn.Name = "BuyscaleDataGridViewTextBoxColumn"
        Me.BuyscaleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceperunitDataGridViewTextBoxColumn
        '
        Me.PriceperunitDataGridViewTextBoxColumn.DataPropertyName = "price_per_unit"
        Me.PriceperunitDataGridViewTextBoxColumn.HeaderText = "ราคา/หน่วย"
        Me.PriceperunitDataGridViewTextBoxColumn.Name = "PriceperunitDataGridViewTextBoxColumn"
        Me.PriceperunitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedMedicinesBindingSource
        '
        Me.MedMedicinesBindingSource.DataMember = "Med_Medicines"
        Me.MedMedicinesBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Location = New System.Drawing.Point(865, 90)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 37)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lableSearch.Location = New System.Drawing.Point(610, 83)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(75, 20)
        Me.lableSearch.TabIndex = 24
        Me.lableSearch.Text = "ค้นหาชื่อยา"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(614, 107)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(228, 20)
        Me.txtSearch.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(82, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Medicine"
        '
        'Med_MedicinesTableAdapter
        '
        Me.Med_MedicinesTableAdapter.ClearBeforeFill = True
        '
        'SuppilersBindingSource
        '
        Me.SuppilersBindingSource.DataMember = "Suppilers"
        Me.SuppilersBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'SuppilersTableAdapter
        '
        Me.SuppilersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
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
        Me.TableAdapterManager.SuppilersTableAdapter = Me.SuppilersTableAdapter
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 650)
        Me.Controls.Add(Me.btnVisit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.ViewMedi)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Medicine"
        Me.Text = "Medicine"
        CType(Me.ViewMedi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedMedicinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppilersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVisit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents ViewMedi As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents lableSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents MedMedicinesBindingSource As BindingSource
    Friend WithEvents Med_MedicinesTableAdapter As WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter
    Friend WithEvents MmIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyscaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceperunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppilersBindingSource As BindingSource
    Friend WithEvents SuppilersTableAdapter As WellmeadowsDataSetTableAdapters.SuppilersTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
End Class
