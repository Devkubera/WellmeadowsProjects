<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Medicine
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.m_sup = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCheck_sup = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.m_dosage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.m_unit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.m_scale = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.m_stock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.m_method = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.m_desc = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.m_name = New System.Windows.Forms.TextBox()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.Med_MedicinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Med_MedicinesTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter()
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Med_MedicinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 29)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "แก้ไขข้อมูลเวชภัณฑ์"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(776, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 83
        Me.btnAdd.Text = "บันทึกข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'm_sup
        '
        Me.m_sup.Location = New System.Drawing.Point(513, 161)
        Me.m_sup.Name = "m_sup"
        Me.m_sup.Size = New System.Drawing.Size(142, 20)
        Me.m_sup.TabIndex = 166
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(285, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 24)
        Me.Label9.TabIndex = 165
        Me.Label9.Text = "ตรวจสอบผู้ผลิต"
        '
        'btnCheck_sup
        '
        Me.btnCheck_sup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheck_sup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck_sup.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnCheck_sup.Location = New System.Drawing.Point(289, 154)
        Me.btnCheck_sup.Name = "btnCheck_sup"
        Me.btnCheck_sup.Size = New System.Drawing.Size(141, 31)
        Me.btnCheck_sup.TabIndex = 164
        Me.btnCheck_sup.Text = "ตรวจสอบ"
        Me.btnCheck_sup.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(285, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 24)
        Me.Label8.TabIndex = 163
        Me.Label8.Text = "ปริมาณ(Dosage)"
        '
        'm_dosage
        '
        Me.m_dosage.Location = New System.Drawing.Point(289, 325)
        Me.m_dosage.Name = "m_dosage"
        Me.m_dosage.Size = New System.Drawing.Size(142, 20)
        Me.m_dosage.TabIndex = 162
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(509, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 24)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "ราคาต่อชิ้น"
        '
        'm_unit
        '
        Me.m_unit.Location = New System.Drawing.Point(513, 408)
        Me.m_unit.Name = "m_unit"
        Me.m_unit.Size = New System.Drawing.Size(142, 20)
        Me.m_unit.TabIndex = 160
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(285, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 24)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "ระดับการสั่งซื้อในแต่ละครั้ง"
        '
        'm_scale
        '
        Me.m_scale.Location = New System.Drawing.Point(289, 409)
        Me.m_scale.Name = "m_scale"
        Me.m_scale.Size = New System.Drawing.Size(142, 20)
        Me.m_scale.TabIndex = 158
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(509, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "จำนวนในสต็อก"
        '
        'm_stock
        '
        Me.m_stock.Location = New System.Drawing.Point(513, 325)
        Me.m_stock.Name = "m_stock"
        Me.m_stock.Size = New System.Drawing.Size(142, 20)
        Me.m_stock.TabIndex = 156
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(509, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 24)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "วิธีการให้ยากับผู้ป่วย"
        '
        'm_method
        '
        Me.m_method.FormattingEnabled = True
        Me.m_method.Items.AddRange(New Object() {"Oral", "Skin"})
        Me.m_method.Location = New System.Drawing.Point(513, 243)
        Me.m_method.Name = "m_method"
        Me.m_method.Size = New System.Drawing.Size(142, 21)
        Me.m_method.TabIndex = 154
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(285, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 24)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "คำอธิบายเกี่ยวกับตัวยา"
        '
        'm_desc
        '
        Me.m_desc.Location = New System.Drawing.Point(289, 504)
        Me.m_desc.Name = "m_desc"
        Me.m_desc.Size = New System.Drawing.Size(366, 100)
        Me.m_desc.TabIndex = 152
        Me.m_desc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(285, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "ชื่อยา"
        '
        'm_name
        '
        Me.m_name.Location = New System.Drawing.Point(289, 244)
        Me.m_name.Name = "m_name"
        Me.m_name.Size = New System.Drawing.Size(142, 20)
        Me.m_name.TabIndex = 150
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.In_PatientsTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Login_logsTableAdapter = Nothing
        Me.TableAdapterManager.Med_EquipmentsTableAdapter = Nothing
        Me.TableAdapterManager.Med_MedicinesTableAdapter = Me.Med_MedicinesTableAdapter
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
        'Edit_Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 656)
        Me.Controls.Add(Me.m_sup)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCheck_sup)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.m_dosage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.m_unit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.m_scale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.m_stock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.m_method)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.m_desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.m_name)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Edit_Medicine"
        Me.Text = "Edit_Medicine"
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Med_MedicinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents m_sup As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCheck_sup As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents m_dosage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents m_unit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents m_scale As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents m_stock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents m_method As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents m_desc As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents m_name As TextBox
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents Med_MedicinesBindingSource As BindingSource
    Friend WithEvents Med_MedicinesTableAdapter As WellmeadowsDataSetTableAdapters.Med_MedicinesTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
End Class
