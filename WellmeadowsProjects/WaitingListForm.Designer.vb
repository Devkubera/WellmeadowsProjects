﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaitingListForm
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
        Me.waitingListPanel = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.waitingListTable = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SearchStaff = New System.Windows.Forms.TextBox()
        Me.waitingListlb = New System.Windows.Forms.Label()
        Me.waitingListPanel.SuspendLayout()
        CType(Me.waitingListTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'waitingListPanel
        '
        Me.waitingListPanel.Controls.Add(Me.btnDel)
        Me.waitingListPanel.Controls.Add(Me.btnEdit)
        Me.waitingListPanel.Controls.Add(Me.btnReport)
        Me.waitingListPanel.Controls.Add(Me.btnAdd)
        Me.waitingListPanel.Controls.Add(Me.placeholderlb)
        Me.waitingListPanel.Controls.Add(Me.waitingListTable)
        Me.waitingListPanel.Controls.Add(Me.btnSearch)
        Me.waitingListPanel.Controls.Add(Me.SearchStaff)
        Me.waitingListPanel.Controls.Add(Me.waitingListlb)
        Me.waitingListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.waitingListPanel.Location = New System.Drawing.Point(0, 0)
        Me.waitingListPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.waitingListPanel.Name = "waitingListPanel"
        Me.waitingListPanel.Size = New System.Drawing.Size(1339, 752)
        Me.waitingListPanel.TabIndex = 0
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(1083, 633)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(160, 46)
        Me.btnDel.TabIndex = 54
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(909, 633)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 46)
        Me.btnEdit.TabIndex = 53
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(729, 633)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(160, 46)
        Me.btnReport.TabIndex = 52
        Me.btnReport.Text = "สร้างรีพอร์ท"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(1143, 110)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 51
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'placeholderlb
        '
        Me.placeholderlb.AutoSize = True
        Me.placeholderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeholderlb.Location = New System.Drawing.Point(769, 74)
        Me.placeholderlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(257, 30)
        Me.placeholderlb.TabIndex = 50
        Me.placeholderlb.Text = "ค้นหาผู้ป่วยรอเตียงด้วยไอดี.."
        '
        'waitingListTable
        '
        Me.waitingListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.waitingListTable.Location = New System.Drawing.Point(105, 185)
        Me.waitingListTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.waitingListTable.Name = "waitingListTable"
        Me.waitingListTable.RowHeadersWidth = 51
        Me.waitingListTable.Size = New System.Drawing.Size(1137, 404)
        Me.waitingListTable.TabIndex = 49
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(1019, 110)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 48
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'SearchStaff
        '
        Me.SearchStaff.Location = New System.Drawing.Point(775, 110)
        Me.SearchStaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(188, 22)
        Me.SearchStaff.TabIndex = 47
        '
        'waitingListlb
        '
        Me.waitingListlb.AutoSize = True
        Me.waitingListlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waitingListlb.Location = New System.Drawing.Point(97, 105)
        Me.waitingListlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.waitingListlb.Name = "waitingListlb"
        Me.waitingListlb.Size = New System.Drawing.Size(194, 46)
        Me.waitingListlb.TabIndex = 46
        Me.waitingListlb.Text = "Waiting List"
        '
        'WaitingListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.waitingListPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "WaitingListForm"
        Me.Text = "WaitingListForm"
        Me.waitingListPanel.ResumeLayout(False)
        Me.waitingListPanel.PerformLayout()
        CType(Me.waitingListTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents waitingListPanel As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents placeholderlb As Label
    Friend WithEvents waitingListTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents SearchStaff As TextBox
    Friend WithEvents waitingListlb As Label
End Class
