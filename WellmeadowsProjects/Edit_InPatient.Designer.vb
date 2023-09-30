<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_InPatient
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.expect = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bad_Id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.s_Id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.w_Id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.p_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_Inpa_table = New System.Windows.Forms.DataGridView()
        Me.start_Date = New System.Windows.Forms.DateTimePicker()
        CType(Me.View_Inpa_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(847, 31)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "แก้ไขข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(260, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "จำนวนวันที่อยู่"
        '
        'expect
        '
        Me.expect.Location = New System.Drawing.Point(264, 354)
        Me.expect.Name = "expect"
        Me.expect.Size = New System.Drawing.Size(142, 20)
        Me.expect.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(58, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "หมายเลขเตียง"
        '
        'bad_Id
        '
        Me.bad_Id.Location = New System.Drawing.Point(62, 354)
        Me.bad_Id.Name = "bad_Id"
        Me.bad_Id.Size = New System.Drawing.Size(142, 20)
        Me.bad_Id.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(260, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "หมายเลขพนักงาน"
        '
        's_Id
        '
        Me.s_Id.Location = New System.Drawing.Point(264, 253)
        Me.s_Id.Name = "s_Id"
        Me.s_Id.Size = New System.Drawing.Size(142, 20)
        Me.s_Id.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(58, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "หมายเลขวอร์ด"
        '
        'w_Id
        '
        Me.w_Id.Location = New System.Drawing.Point(62, 253)
        Me.w_Id.Name = "w_Id"
        Me.w_Id.Size = New System.Drawing.Size(142, 20)
        Me.w_Id.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(260, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "วันที่เข้า"
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(58, 105)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(115, 24)
        Me.lableSearch.TabIndex = 19
        Me.lableSearch.Text = "หมายเลขผู้ป่วย"
        '
        'p_Id
        '
        Me.p_Id.Location = New System.Drawing.Point(62, 143)
        Me.p_Id.Name = "p_Id"
        Me.p_Id.Size = New System.Drawing.Size(142, 20)
        Me.p_Id.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "แก้ไขข้อมูลผู้ป่วยใน"
        '
        'View_Inpa_table
        '
        Me.View_Inpa_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Inpa_table.Location = New System.Drawing.Point(489, 105)
        Me.View_Inpa_table.Name = "View_Inpa_table"
        Me.View_Inpa_table.Size = New System.Drawing.Size(478, 477)
        Me.View_Inpa_table.TabIndex = 32
        '
        'start_Date
        '
        Me.start_Date.Location = New System.Drawing.Point(264, 143)
        Me.start_Date.Name = "start_Date"
        Me.start_Date.Size = New System.Drawing.Size(200, 20)
        Me.start_Date.TabIndex = 33
        '
        'Edit_InPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 650)
        Me.Controls.Add(Me.start_Date)
        Me.Controls.Add(Me.View_Inpa_table)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.expect)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bad_Id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.s_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.w_Id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.p_Id)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_InPatient"
        Me.Text = "Edit_InPatient"
        CType(Me.View_Inpa_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents expect As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bad_Id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents s_Id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents w_Id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lableSearch As Label
    Friend WithEvents p_Id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents View_Inpa_table As DataGridView
    Friend WithEvents start_Date As DateTimePicker
End Class
