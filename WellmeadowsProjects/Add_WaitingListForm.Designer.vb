﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_WaitingListForm
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
        Me.wardIdlb = New System.Windows.Forms.Label()
        Me.datewaitinglb = New System.Windows.Forms.Label()
        Me.patientlb = New System.Windows.Forms.Label()
        Me.patientId = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.addWaitingListPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dateWaiting = New System.Windows.Forms.DateTimePicker()
        Me.wardId = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pwID_textbox = New System.Windows.Forms.TextBox()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.addWaitingListPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(643, 280)
        Me.wardIdlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(137, 30)
        Me.wardIdlb.TabIndex = 107
        Me.wardIdlb.Text = "หมายเลขวอร์ด"
        '
        'datewaitinglb
        '
        Me.datewaitinglb.AutoSize = True
        Me.datewaitinglb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datewaitinglb.Location = New System.Drawing.Point(643, 173)
        Me.datewaitinglb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.datewaitinglb.Name = "datewaitinglb"
        Me.datewaitinglb.Size = New System.Drawing.Size(152, 30)
        Me.datewaitinglb.TabIndex = 101
        Me.datewaitinglb.Text = "วันแรกที่รอเตียง"
        '
        'patientlb
        '
        Me.patientlb.AutoSize = True
        Me.patientlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientlb.Location = New System.Drawing.Point(390, 173)
        Me.patientlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.patientlb.Name = "patientlb"
        Me.patientlb.Size = New System.Drawing.Size(140, 30)
        Me.patientlb.TabIndex = 99
        Me.patientlb.Text = "หมายเลขผู้ป่วย"
        '
        'patientId
        '
        Me.patientId.Enabled = False
        Me.patientId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientId.Location = New System.Drawing.Point(397, 212)
        Me.patientId.Margin = New System.Windows.Forms.Padding(4)
        Me.patientId.Name = "patientId"
        Me.patientId.Size = New System.Drawing.Size(204, 38)
        Me.patientId.TabIndex = 98
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1133, 47)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 46)
        Me.btnSubmit.TabIndex = 97
        Me.btnSubmit.Text = "เพิ่ม"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(953, 47)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 46)
        Me.btnClear.TabIndex = 96
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'addWaitingListPanel
        '
        Me.addWaitingListPanel.Controls.Add(Me.Button1)
        Me.addWaitingListPanel.Controls.Add(Me.dateWaiting)
        Me.addWaitingListPanel.Controls.Add(Me.wardId)
        Me.addWaitingListPanel.Controls.Add(Me.wardIdlb)
        Me.addWaitingListPanel.Controls.Add(Me.datewaitinglb)
        Me.addWaitingListPanel.Controls.Add(Me.Label1)
        Me.addWaitingListPanel.Controls.Add(Me.patientlb)
        Me.addWaitingListPanel.Controls.Add(Me.pwID_textbox)
        Me.addWaitingListPanel.Controls.Add(Me.patientId)
        Me.addWaitingListPanel.Controls.Add(Me.btnSubmit)
        Me.addWaitingListPanel.Controls.Add(Me.btnClear)
        Me.addWaitingListPanel.Controls.Add(Me.headerlb)
        Me.addWaitingListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addWaitingListPanel.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addWaitingListPanel.Location = New System.Drawing.Point(0, 0)
        Me.addWaitingListPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.addWaitingListPanel.Name = "addWaitingListPanel"
        Me.addWaitingListPanel.Size = New System.Drawing.Size(1339, 752)
        Me.addWaitingListPanel.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(206, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 71)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "ตรวจสอบ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dateWaiting
        '
        Me.dateWaiting.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateWaiting.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateWaiting.Location = New System.Drawing.Point(648, 212)
        Me.dateWaiting.Margin = New System.Windows.Forms.Padding(4)
        Me.dateWaiting.Name = "dateWaiting"
        Me.dateWaiting.Size = New System.Drawing.Size(250, 38)
        Me.dateWaiting.TabIndex = 112
        '
        'wardId
        '
        Me.wardId.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardId.FormattingEnabled = True
        Me.wardId.Location = New System.Drawing.Point(648, 317)
        Me.wardId.Margin = New System.Windows.Forms.Padding(4)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(250, 38)
        Me.wardId.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 280)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 30)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "หมายเลขการรักษา"
        '
        'pwID_textbox
        '
        Me.pwID_textbox.Enabled = False
        Me.pwID_textbox.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwID_textbox.Location = New System.Drawing.Point(397, 319)
        Me.pwID_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.pwID_textbox.Name = "pwID_textbox"
        Me.pwID_textbox.Size = New System.Drawing.Size(204, 38)
        Me.pwID_textbox.TabIndex = 98
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Prompt", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(530, 47)
        Me.headerlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(250, 35)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "เพิ่มข้อมูลผู้ป่วยรอเตียง"
        '
        'Add_WaitingListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 752)
        Me.Controls.Add(Me.addWaitingListPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_WaitingListForm"
        Me.Text = "Add_WaitingListForm"
        Me.addWaitingListPanel.ResumeLayout(False)
        Me.addWaitingListPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wardIdlb As Label
    Friend WithEvents datewaitinglb As Label
    Friend WithEvents patientlb As Label
    Friend WithEvents patientId As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents addWaitingListPanel As Panel
    Friend WithEvents headerlb As Label
    Friend WithEvents dateWaiting As DateTimePicker
    Friend WithEvents wardId As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pwID_textbox As TextBox
    Friend WithEvents Button1 As Button
End Class
