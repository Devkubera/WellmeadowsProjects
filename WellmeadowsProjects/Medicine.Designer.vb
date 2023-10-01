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
        Me.btnVisit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ViewMedi = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ViewMedi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVisit
        '
        Me.btnVisit.BackColor = System.Drawing.Color.Black
        Me.btnVisit.ForeColor = System.Drawing.Color.Snow
        Me.btnVisit.Location = New System.Drawing.Point(1093, 41)
        Me.btnVisit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVisit.Name = "btnVisit"
        Me.btnVisit.Size = New System.Drawing.Size(160, 46)
        Me.btnVisit.TabIndex = 31
        Me.btnVisit.Text = "การให้ยาผู้ป่วย"
        Me.btnVisit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(1093, 634)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 46)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "ลบข้อมูล"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(920, 634)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 46)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "แก้ไขข้อมูล"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'ViewMedi
        '
        Me.ViewMedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewMedi.Location = New System.Drawing.Point(116, 186)
        Me.ViewMedi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ViewMedi.Name = "ViewMedi"
        Me.ViewMedi.RowHeadersWidth = 51
        Me.ViewMedi.Size = New System.Drawing.Size(1137, 404)
        Me.ViewMedi.TabIndex = 27
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Location = New System.Drawing.Point(1153, 111)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 46)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1029, 111)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lableSearch.Location = New System.Drawing.Point(813, 102)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(184, 25)
        Me.lableSearch.TabIndex = 24
        Me.lableSearch.Text = "ค้นหาหมายเลขเวชภัณฑ์"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(819, 132)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(188, 22)
        Me.txtSearch.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(109, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 35)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Medicine"
        '
        'Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 800)
        Me.Controls.Add(Me.btnVisit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.ViewMedi)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Medicine"
        Me.Text = "Medicine"
        CType(Me.ViewMedi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVisit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents ViewMedi As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lableSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
End Class
