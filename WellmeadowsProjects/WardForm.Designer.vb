<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WardForm
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
        Me.wardPanel = New System.Windows.Forms.Panel()
        Me.Wardlb = New System.Windows.Forms.Label()
        Me.btnStaffInWard = New System.Windows.Forms.Button()
        Me.btnWaitinglist = New System.Windows.Forms.Button()
        Me.WardTable = New System.Windows.Forms.DataGridView()
        Me.btnPInward = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SearchWard = New System.Windows.Forms.TextBox()
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.wardPanel.SuspendLayout()
        CType(Me.WardTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wardPanel
        '
        Me.wardPanel.Controls.Add(Me.Wardlb)
        Me.wardPanel.Controls.Add(Me.btnStaffInWard)
        Me.wardPanel.Controls.Add(Me.btnWaitinglist)
        Me.wardPanel.Controls.Add(Me.WardTable)
        Me.wardPanel.Controls.Add(Me.btnPInward)
        Me.wardPanel.Controls.Add(Me.btnSearch)
        Me.wardPanel.Controls.Add(Me.SearchWard)
        Me.wardPanel.Controls.Add(Me.placeholderlb)
        Me.wardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wardPanel.Location = New System.Drawing.Point(0, 0)
        Me.wardPanel.Name = "wardPanel"
        Me.wardPanel.Size = New System.Drawing.Size(1020, 650)
        Me.wardPanel.TabIndex = 0
        '
        'Wardlb
        '
        Me.Wardlb.AutoSize = True
        Me.Wardlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wardlb.Location = New System.Drawing.Point(75, 115)
        Me.Wardlb.Name = "Wardlb"
        Me.Wardlb.Size = New System.Drawing.Size(77, 36)
        Me.Wardlb.TabIndex = 15
        Me.Wardlb.Text = "Ward"
        '
        'btnStaffInWard
        '
        Me.btnStaffInWard.BackColor = System.Drawing.Color.Black
        Me.btnStaffInWard.Font = New System.Drawing.Font("Prompt SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffInWard.ForeColor = System.Drawing.Color.White
        Me.btnStaffInWard.Location = New System.Drawing.Point(844, 23)
        Me.btnStaffInWard.Name = "btnStaffInWard"
        Me.btnStaffInWard.Size = New System.Drawing.Size(120, 37)
        Me.btnStaffInWard.TabIndex = 29
        Me.btnStaffInWard.Text = "เจ้าหน้าที่แต่ละวอร์ด"
        Me.btnStaffInWard.UseVisualStyleBackColor = False
        '
        'btnWaitinglist
        '
        Me.btnWaitinglist.BackColor = System.Drawing.Color.Black
        Me.btnWaitinglist.Font = New System.Drawing.Font("Prompt SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaitinglist.ForeColor = System.Drawing.Color.White
        Me.btnWaitinglist.Location = New System.Drawing.Point(708, 23)
        Me.btnWaitinglist.Name = "btnWaitinglist"
        Me.btnWaitinglist.Size = New System.Drawing.Size(120, 37)
        Me.btnWaitinglist.TabIndex = 28
        Me.btnWaitinglist.Text = "ผู้ป่วยรอเตียง"
        Me.btnWaitinglist.UseVisualStyleBackColor = False
        '
        'WardTable
        '
        Me.WardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WardTable.Location = New System.Drawing.Point(70, 192)
        Me.WardTable.Name = "WardTable"
        Me.WardTable.RowHeadersWidth = 51
        Me.WardTable.Size = New System.Drawing.Size(853, 328)
        Me.WardTable.TabIndex = 20
        '
        'btnPInward
        '
        Me.btnPInward.BackColor = System.Drawing.Color.Black
        Me.btnPInward.Font = New System.Drawing.Font("Prompt SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPInward.ForeColor = System.Drawing.Color.White
        Me.btnPInward.Location = New System.Drawing.Point(571, 23)
        Me.btnPInward.Name = "btnPInward"
        Me.btnPInward.Size = New System.Drawing.Size(120, 37)
        Me.btnPInward.TabIndex = 27
        Me.btnPInward.Text = "ผู้ป่วยในวอร์ด"
        Me.btnPInward.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(864, 119)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 37)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'SearchWard
        '
        Me.SearchWard.Location = New System.Drawing.Point(708, 134)
        Me.SearchWard.Name = "SearchWard"
        Me.SearchWard.Size = New System.Drawing.Size(142, 20)
        Me.SearchWard.TabIndex = 18
        '
        'placeholderlb
        '
        Me.placeholderlb.AutoSize = True
        Me.placeholderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeholderlb.Location = New System.Drawing.Point(704, 105)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(150, 24)
        Me.placeholderlb.TabIndex = 21
        Me.placeholderlb.Text = "ค้นหาด้วยวอร์ดไอดี..."
        '
        'WardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 650)
        Me.Controls.Add(Me.wardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WardForm"
        Me.Text = "WardForm"
        Me.wardPanel.ResumeLayout(False)
        Me.wardPanel.PerformLayout()
        CType(Me.WardTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wardPanel As Panel
    Friend WithEvents placeholderlb As Label
    Friend WithEvents WardTable As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents SearchWard As TextBox
    Friend WithEvents Wardlb As Label
    Friend WithEvents btnWaitinglist As Button
    Friend WithEvents btnPInward As Button
    Friend WithEvents btnStaffInWard As Button
End Class
