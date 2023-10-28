<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup_medicine
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
        Me.medicineDG = New System.Windows.Forms.DataGridView()
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
        Me.Med_MedicinesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.medicineDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedMedicinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(843, 386)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 50)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 43)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "เลือกข้อมูลที่ท่านต้องการ"
        '
        'medicineDG
        '
        Me.medicineDG.AllowUserToAddRows = False
        Me.medicineDG.AllowUserToDeleteRows = False
        Me.medicineDG.AllowUserToOrderColumns = True
        Me.medicineDG.AutoGenerateColumns = False
        Me.medicineDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medicineDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MmIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.MethodDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.BuyscaleDataGridViewTextBoxColumn, Me.PriceperunitDataGridViewTextBoxColumn})
        Me.medicineDG.DataSource = Me.MedMedicinesBindingSource
        Me.medicineDG.Location = New System.Drawing.Point(32, 115)
        Me.medicineDG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.medicineDG.Name = "medicineDG"
        Me.medicineDG.ReadOnly = True
        Me.medicineDG.RowHeadersWidth = 51
        Me.medicineDG.RowTemplate.Height = 24
        Me.medicineDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.medicineDG.Size = New System.Drawing.Size(936, 258)
        Me.medicineDG.TabIndex = 20
        '
        'MmIDDataGridViewTextBoxColumn
        '
        Me.MmIDDataGridViewTextBoxColumn.DataPropertyName = "mmID"
        Me.MmIDDataGridViewTextBoxColumn.Frozen = True
        Me.MmIDDataGridViewTextBoxColumn.HeaderText = "หมายเลขยา"
        Me.MmIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MmIDDataGridViewTextBoxColumn.Name = "MmIDDataGridViewTextBoxColumn"
        Me.MmIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MmIDDataGridViewTextBoxColumn.Width = 125
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "ซัพพลายเออร์"
        Me.SupplierIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIDDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "ชื่อยา"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "คำอธิบายยา"
        Me.DescriptionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 125
        '
        'DosageDataGridViewTextBoxColumn
        '
        Me.DosageDataGridViewTextBoxColumn.DataPropertyName = "dosage"
        Me.DosageDataGridViewTextBoxColumn.HeaderText = "ปริมาณยา"
        Me.DosageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DosageDataGridViewTextBoxColumn.Name = "DosageDataGridViewTextBoxColumn"
        Me.DosageDataGridViewTextBoxColumn.ReadOnly = True
        Me.DosageDataGridViewTextBoxColumn.Width = 125
        '
        'MethodDataGridViewTextBoxColumn
        '
        Me.MethodDataGridViewTextBoxColumn.DataPropertyName = "method"
        Me.MethodDataGridViewTextBoxColumn.HeaderText = "วิธีใช้"
        Me.MethodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MethodDataGridViewTextBoxColumn.Name = "MethodDataGridViewTextBoxColumn"
        Me.MethodDataGridViewTextBoxColumn.ReadOnly = True
        Me.MethodDataGridViewTextBoxColumn.Width = 125
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "จำนวนคงคลัง"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 125
        '
        'BuyscaleDataGridViewTextBoxColumn
        '
        Me.BuyscaleDataGridViewTextBoxColumn.DataPropertyName = "buy_scale"
        Me.BuyscaleDataGridViewTextBoxColumn.HeaderText = "ระดับการสั่งซื้อ"
        Me.BuyscaleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BuyscaleDataGridViewTextBoxColumn.Name = "BuyscaleDataGridViewTextBoxColumn"
        Me.BuyscaleDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuyscaleDataGridViewTextBoxColumn.Width = 125
        '
        'PriceperunitDataGridViewTextBoxColumn
        '
        Me.PriceperunitDataGridViewTextBoxColumn.DataPropertyName = "price_per_unit"
        Me.PriceperunitDataGridViewTextBoxColumn.HeaderText = "ราคาต่อหน่วย"
        Me.PriceperunitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceperunitDataGridViewTextBoxColumn.Name = "PriceperunitDataGridViewTextBoxColumn"
        Me.PriceperunitDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceperunitDataGridViewTextBoxColumn.Width = 125
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
        'Med_MedicinesTableAdapter
        '
        Me.Med_MedicinesTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(641, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 38)
        Me.TextBox1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(636, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 30)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ค้นหาด้วยชื่อยา"
        '
        'popup_medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 481)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.medicineDG)
        Me.Name = "popup_medicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "popup_medicine"
        CType(Me.medicineDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedMedicinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents medicineDG As DataGridView
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents MedMedicinesBindingSource As BindingSource
    Friend WithEvents Med_MedicinesTableAdapter As WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MmIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyscaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceperunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
