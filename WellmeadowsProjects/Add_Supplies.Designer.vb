<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Supplies
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sup_tel = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sup_fax = New System.Windows.Forms.TextBox()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.sup_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sup_address = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(446, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "เบอร์โทร"
        '
        'sup_tel
        '
        Me.sup_tel.Location = New System.Drawing.Point(450, 164)
        Me.sup_tel.Name = "sup_tel"
        Me.sup_tel.Size = New System.Drawing.Size(142, 20)
        Me.sup_tel.TabIndex = 60
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(821, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 37)
        Me.btnAdd.TabIndex = 59
        Me.btnAdd.Text = "เพิ่มข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Snow
        Me.btnClear.Location = New System.Drawing.Point(730, 28)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "ล้างค่า"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(263, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 24)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "ที่อยู่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(629, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 24)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "แฟกซ์"
        '
        'sup_fax
        '
        Me.sup_fax.Location = New System.Drawing.Point(633, 164)
        Me.sup_fax.Name = "sup_fax"
        Me.sup_fax.Size = New System.Drawing.Size(142, 20)
        Me.sup_fax.TabIndex = 54
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(263, 126)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(72, 24)
        Me.lableSearch.TabIndex = 53
        Me.lableSearch.Text = "ชื่อผู้ผลิต"
        '
        'sup_name
        '
        Me.sup_name.Location = New System.Drawing.Point(267, 164)
        Me.sup_name.Name = "sup_name"
        Me.sup_name.Size = New System.Drawing.Size(142, 20)
        Me.sup_name.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 29)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "เพิ่มข้อมูลผู้ผลิต"
        '
        'sup_address
        '
        Me.sup_address.Location = New System.Drawing.Point(267, 247)
        Me.sup_address.Name = "sup_address"
        Me.sup_address.Size = New System.Drawing.Size(508, 150)
        Me.sup_address.TabIndex = 62
        Me.sup_address.Text = ""
        '
        'Add_Supplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 611)
        Me.Controls.Add(Me.sup_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sup_tel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sup_fax)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.sup_name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Supplies"
        Me.Text = "Add_Supplies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents sup_tel As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sup_fax As TextBox
    Friend WithEvents lableSearch As Label
    Friend WithEvents sup_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sup_address As RichTextBox
End Class
