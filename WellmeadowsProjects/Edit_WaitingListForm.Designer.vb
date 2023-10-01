<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_WaitingListForm
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
        Me.addWaitingListPanel = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.headerlb = New System.Windows.Forms.Label()
        Me.dateWaiting = New System.Windows.Forms.DateTimePicker()
        Me.wardId = New System.Windows.Forms.ComboBox()
        Me.wardIdlb = New System.Windows.Forms.Label()
        Me.waitingListTable = New System.Windows.Forms.DataGridView()
        Me.staffId = New System.Windows.Forms.TextBox()
        Me.staffIdlb = New System.Windows.Forms.Label()
        Me.datewaitinglb = New System.Windows.Forms.Label()
        Me.patientlb = New System.Windows.Forms.Label()
        Me.patientId = New System.Windows.Forms.TextBox()
        Me.addWaitingListPanel.SuspendLayout()
        CType(Me.waitingListTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addWaitingListPanel
        '
        Me.addWaitingListPanel.Controls.Add(Me.dateWaiting)
        Me.addWaitingListPanel.Controls.Add(Me.wardId)
        Me.addWaitingListPanel.Controls.Add(Me.wardIdlb)
        Me.addWaitingListPanel.Controls.Add(Me.waitingListTable)
        Me.addWaitingListPanel.Controls.Add(Me.staffId)
        Me.addWaitingListPanel.Controls.Add(Me.staffIdlb)
        Me.addWaitingListPanel.Controls.Add(Me.datewaitinglb)
        Me.addWaitingListPanel.Controls.Add(Me.patientlb)
        Me.addWaitingListPanel.Controls.Add(Me.patientId)
        Me.addWaitingListPanel.Controls.Add(Me.btnEdit)
        Me.addWaitingListPanel.Controls.Add(Me.btnClear)
        Me.addWaitingListPanel.Controls.Add(Me.headerlb)
        Me.addWaitingListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addWaitingListPanel.Location = New System.Drawing.Point(0, 0)
        Me.addWaitingListPanel.Name = "addWaitingListPanel"
        Me.addWaitingListPanel.Size = New System.Drawing.Size(1004, 611)
        Me.addWaitingListPanel.TabIndex = 3
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(850, 38)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 37)
        Me.btnEdit.TabIndex = 114
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(715, 38)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 37)
        Me.btnClear.TabIndex = 113
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'headerlb
        '
        Me.headerlb.AllowDrop = True
        Me.headerlb.AutoSize = True
        Me.headerlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerlb.Location = New System.Drawing.Point(344, 38)
        Me.headerlb.Name = "headerlb"
        Me.headerlb.Size = New System.Drawing.Size(224, 25)
        Me.headerlb.TabIndex = 95
        Me.headerlb.Text = "แก้ไขข้อมูลผู้ป่วยรอเตียง"
        '
        'dateWaiting
        '
        Me.dateWaiting.Location = New System.Drawing.Point(330, 154)
        Me.dateWaiting.Name = "dateWaiting"
        Me.dateWaiting.Size = New System.Drawing.Size(200, 20)
        Me.dateWaiting.TabIndex = 123
        '
        'wardId
        '
        Me.wardId.FormattingEnabled = True
        Me.wardId.Items.AddRange(New Object() {"ward1", "ward2", "ward3", "ward4", "ward5", "ward6", "ward7", "ward8", "ward9", "ward10", "ward11", "ward12", "ward13", "ward14", "ward15", "ward16", "ward17"})
        Me.wardId.Location = New System.Drawing.Point(330, 239)
        Me.wardId.Name = "wardId"
        Me.wardId.Size = New System.Drawing.Size(121, 21)
        Me.wardId.TabIndex = 122
        '
        'wardIdlb
        '
        Me.wardIdlb.AutoSize = True
        Me.wardIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wardIdlb.Location = New System.Drawing.Point(325, 207)
        Me.wardIdlb.Name = "wardIdlb"
        Me.wardIdlb.Size = New System.Drawing.Size(132, 29)
        Me.wardIdlb.TabIndex = 121
        Me.wardIdlb.Text = "หมายเลขวอร์ด"
        '
        'waitingListTable
        '
        Me.waitingListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.waitingListTable.Location = New System.Drawing.Point(580, 122)
        Me.waitingListTable.Name = "waitingListTable"
        Me.waitingListTable.Size = New System.Drawing.Size(383, 366)
        Me.waitingListTable.TabIndex = 120
        '
        'staffId
        '
        Me.staffId.Location = New System.Drawing.Point(47, 239)
        Me.staffId.Name = "staffId"
        Me.staffId.Size = New System.Drawing.Size(139, 20)
        Me.staffId.TabIndex = 119
        '
        'staffIdlb
        '
        Me.staffIdlb.AutoSize = True
        Me.staffIdlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffIdlb.Location = New System.Drawing.Point(42, 207)
        Me.staffIdlb.Name = "staffIdlb"
        Me.staffIdlb.Size = New System.Drawing.Size(157, 29)
        Me.staffIdlb.TabIndex = 118
        Me.staffIdlb.Text = "หมายเลขพนักงาน"
        '
        'datewaitinglb
        '
        Me.datewaitinglb.AutoSize = True
        Me.datewaitinglb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datewaitinglb.Location = New System.Drawing.Point(325, 122)
        Me.datewaitinglb.Name = "datewaitinglb"
        Me.datewaitinglb.Size = New System.Drawing.Size(146, 29)
        Me.datewaitinglb.TabIndex = 117
        Me.datewaitinglb.Text = "วันแรกที่รอเตียง"
        '
        'patientlb
        '
        Me.patientlb.AutoSize = True
        Me.patientlb.Font = New System.Drawing.Font("Prompt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientlb.Location = New System.Drawing.Point(42, 122)
        Me.patientlb.Name = "patientlb"
        Me.patientlb.Size = New System.Drawing.Size(133, 29)
        Me.patientlb.TabIndex = 116
        Me.patientlb.Text = "หมายเลขผู้ป่วย"
        '
        'patientId
        '
        Me.patientId.Location = New System.Drawing.Point(47, 154)
        Me.patientId.Name = "patientId"
        Me.patientId.Size = New System.Drawing.Size(139, 20)
        Me.patientId.TabIndex = 115
        '
        'Edit_WaitingListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.addWaitingListPanel)
        Me.Name = "Edit_WaitingListForm"
        Me.Text = "Edit_WaitingListForm"
        Me.addWaitingListPanel.ResumeLayout(False)
        Me.addWaitingListPanel.PerformLayout()
        CType(Me.waitingListTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addWaitingListPanel As Panel
    Friend WithEvents headerlb As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dateWaiting As DateTimePicker
    Friend WithEvents wardId As ComboBox
    Friend WithEvents wardIdlb As Label
    Friend WithEvents waitingListTable As DataGridView
    Friend WithEvents staffId As TextBox
    Friend WithEvents staffIdlb As Label
    Friend WithEvents datewaitinglb As Label
    Friend WithEvents patientlb As Label
    Friend WithEvents patientId As TextBox
End Class
