<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbb_bed_status = New System.Windows.Forms.ComboBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.waitingListTable = New System.Windows.Forms.DataGridView()
        Me.SearchWaiting = New System.Windows.Forms.TextBox()
        Me.waitingListlb = New System.Windows.Forms.Label()
        Me.waitingListPanel.SuspendLayout()
        CType(Me.waitingListTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'waitingListPanel
        '
        Me.waitingListPanel.Controls.Add(Me.Label1)
        Me.waitingListPanel.Controls.Add(Me.cbb_bed_status)
        Me.waitingListPanel.Controls.Add(Me.btnDel)
        Me.waitingListPanel.Controls.Add(Me.btnEdit)
        Me.waitingListPanel.Controls.Add(Me.btnReport)
        Me.waitingListPanel.Controls.Add(Me.btnAdd)
        Me.waitingListPanel.Controls.Add(Me.placeholderlb)
        Me.waitingListPanel.Controls.Add(Me.waitingListTable)
        Me.waitingListPanel.Controls.Add(Me.SearchWaiting)
        Me.waitingListPanel.Controls.Add(Me.waitingListlb)
        Me.waitingListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.waitingListPanel.Location = New System.Drawing.Point(0, 0)
        Me.waitingListPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.waitingListPanel.Name = "waitingListPanel"
        Me.waitingListPanel.Size = New System.Drawing.Size(1339, 752)
        Me.waitingListPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(514, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "สถานะรอเตียง"
        '
        'cbb_bed_status
        '
        Me.cbb_bed_status.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_bed_status.FormattingEnabled = True
        Me.cbb_bed_status.Items.AddRange(New Object() {"ยังไม่ได้เตียง", "ได้รับเตียงแล้ว"})
        Me.cbb_bed_status.Location = New System.Drawing.Point(519, 117)
        Me.cbb_bed_status.Name = "cbb_bed_status"
        Me.cbb_bed_status.Size = New System.Drawing.Size(206, 38)
        Me.cbb_bed_status.TabIndex = 55
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(961, 620)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(160, 46)
        Me.btnDel.TabIndex = 54
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(787, 620)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 46)
        Me.btnEdit.TabIndex = 53
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(607, 620)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(160, 46)
        Me.btnReport.TabIndex = 52
        Me.btnReport.Text = "สร้างรีพอร์ท"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(1142, 620)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
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
        Me.placeholderlb.Location = New System.Drawing.Point(822, 83)
        Me.placeholderlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(377, 30)
        Me.placeholderlb.TabIndex = 50
        Me.placeholderlb.Text = "ค้นหาผู้ป่วยรอเตียงด้วยชื่อ, หมายเลขวอร์ด"
        '
        'waitingListTable
        '
        Me.waitingListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.waitingListTable.Location = New System.Drawing.Point(105, 185)
        Me.waitingListTable.Margin = New System.Windows.Forms.Padding(4)
        Me.waitingListTable.MultiSelect = False
        Me.waitingListTable.Name = "waitingListTable"
        Me.waitingListTable.ReadOnly = True
        Me.waitingListTable.RowHeadersWidth = 51
        Me.waitingListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.waitingListTable.Size = New System.Drawing.Size(1137, 404)
        Me.waitingListTable.TabIndex = 49
        '
        'SearchWaiting
        '
        Me.SearchWaiting.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchWaiting.Location = New System.Drawing.Point(827, 117)
        Me.SearchWaiting.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchWaiting.Name = "SearchWaiting"
        Me.SearchWaiting.Size = New System.Drawing.Size(417, 38)
        Me.SearchWaiting.TabIndex = 47
        '
        'waitingListlb
        '
        Me.waitingListlb.AutoSize = True
        Me.waitingListlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waitingListlb.Location = New System.Drawing.Point(97, 110)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents SearchWaiting As TextBox
    Friend WithEvents waitingListlb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbb_bed_status As ComboBox
End Class
