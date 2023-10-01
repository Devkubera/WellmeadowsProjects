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
        Me.View_Edit_Inpa = New System.Windows.Forms.DataGridView()
        Me.start_Date = New System.Windows.Forms.DateTimePicker()
        CType(Me.View_Edit_Inpa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1129, 38)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 46)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "แก้ไขข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(347, 389)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 29)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "จำนวนวันที่อยู่"
        '
        'expect
        '
        Me.expect.Location = New System.Drawing.Point(352, 436)
        Me.expect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.expect.Name = "expect"
        Me.expect.Size = New System.Drawing.Size(188, 22)
        Me.expect.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(77, 389)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 29)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "หมายเลขเตียง"
        '
        'bad_Id
        '
        Me.bad_Id.Location = New System.Drawing.Point(83, 436)
        Me.bad_Id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bad_Id.Name = "bad_Id"
        Me.bad_Id.Size = New System.Drawing.Size(188, 22)
        Me.bad_Id.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(347, 265)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 29)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "หมายเลขพนักงาน"
        '
        's_Id
        '
        Me.s_Id.Location = New System.Drawing.Point(352, 311)
        Me.s_Id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.s_Id.Name = "s_Id"
        Me.s_Id.Size = New System.Drawing.Size(188, 22)
        Me.s_Id.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(77, 265)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 29)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "หมายเลขวอร์ด"
        '
        'w_Id
        '
        Me.w_Id.Location = New System.Drawing.Point(83, 311)
        Me.w_Id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.w_Id.Name = "w_Id"
        Me.w_Id.Size = New System.Drawing.Size(188, 22)
        Me.w_Id.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(347, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "วันที่เข้า"
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(77, 129)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(149, 29)
        Me.lableSearch.TabIndex = 19
        Me.lableSearch.Text = "หมายเลขผู้ป่วย"
        '
        'p_Id
        '
        Me.p_Id.Location = New System.Drawing.Point(83, 176)
        Me.p_Id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.p_Id.Name = "p_Id"
        Me.p_Id.Size = New System.Drawing.Size(188, 22)
        Me.p_Id.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 36)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "แก้ไขข้อมูลผู้ป่วยใน"
        '
        'View_Edit_Inpa
        '
        Me.View_Edit_Inpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Edit_Inpa.Location = New System.Drawing.Point(652, 129)
        Me.View_Edit_Inpa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.View_Edit_Inpa.Name = "View_Edit_Inpa"
        Me.View_Edit_Inpa.RowHeadersWidth = 51
        Me.View_Edit_Inpa.Size = New System.Drawing.Size(637, 587)
        Me.View_Edit_Inpa.TabIndex = 32
        '
        'start_Date
        '
        Me.start_Date.Location = New System.Drawing.Point(352, 176)
        Me.start_Date.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.start_Date.Name = "start_Date"
        Me.start_Date.Size = New System.Drawing.Size(265, 22)
        Me.start_Date.TabIndex = 33
        '
        'Edit_InPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 800)
        Me.Controls.Add(Me.start_Date)
        Me.Controls.Add(Me.View_Edit_Inpa)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Edit_InPatient"
        Me.Text = "Edit_InPatient"
        CType(Me.View_Edit_Inpa, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents View_Edit_Inpa As DataGridView
    Friend WithEvents start_Date As DateTimePicker
End Class
