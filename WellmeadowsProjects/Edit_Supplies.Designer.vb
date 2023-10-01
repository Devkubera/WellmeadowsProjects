<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Supplies
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
        Me.sup_address = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sup_tel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sup_fax = New System.Windows.Forms.TextBox()
        Me.lableSearch = New System.Windows.Forms.Label()
        Me.sup_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_Edit_Sup = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.View_Edit_Sup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sup_address
        '
        Me.sup_address.Location = New System.Drawing.Point(327, 587)
        Me.sup_address.Margin = New System.Windows.Forms.Padding(4)
        Me.sup_address.Name = "sup_address"
        Me.sup_address.Size = New System.Drawing.Size(676, 184)
        Me.sup_address.TabIndex = 73
        Me.sup_address.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(566, 438)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "เบอร์โทร"
        '
        'sup_tel
        '
        Me.sup_tel.Location = New System.Drawing.Point(571, 485)
        Me.sup_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.sup_tel.Name = "sup_tel"
        Me.sup_tel.Size = New System.Drawing.Size(188, 22)
        Me.sup_tel.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(322, 540)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 29)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "ที่อยู่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(810, 438)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 29)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "แฟกซ์"
        '
        'sup_fax
        '
        Me.sup_fax.Location = New System.Drawing.Point(815, 485)
        Me.sup_fax.Margin = New System.Windows.Forms.Padding(4)
        Me.sup_fax.Name = "sup_fax"
        Me.sup_fax.Size = New System.Drawing.Size(188, 22)
        Me.sup_fax.TabIndex = 66
        '
        'lableSearch
        '
        Me.lableSearch.AutoSize = True
        Me.lableSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lableSearch.Location = New System.Drawing.Point(322, 438)
        Me.lableSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lableSearch.Name = "lableSearch"
        Me.lableSearch.Size = New System.Drawing.Size(90, 29)
        Me.lableSearch.TabIndex = 65
        Me.lableSearch.Text = "ชื่อผู้ผลิต"
        '
        'sup_name
        '
        Me.sup_name.Location = New System.Drawing.Point(327, 485)
        Me.sup_name.Margin = New System.Windows.Forms.Padding(4)
        Me.sup_name.Name = "sup_name"
        Me.sup_name.Size = New System.Drawing.Size(188, 22)
        Me.sup_name.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 36)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "แก้ไขข้อมูลผู้ผลิต"
        '
        'View_Edit_Sup
        '
        Me.View_Edit_Sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Edit_Sup.Location = New System.Drawing.Point(132, 126)
        Me.View_Edit_Sup.Name = "View_Edit_Sup"
        Me.View_Edit_Sup.RowHeadersWidth = 51
        Me.View_Edit_Sup.RowTemplate.Height = 24
        Me.View_Edit_Sup.Size = New System.Drawing.Size(1030, 260)
        Me.View_Edit_Sup.TabIndex = 74
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1002, 53)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 46)
        Me.btnAdd.TabIndex = 75
        Me.btnAdd.Text = "แก้ไขข้อมูล"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Edit_Supplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 874)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.View_Edit_Sup)
        Me.Controls.Add(Me.sup_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sup_tel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sup_fax)
        Me.Controls.Add(Me.lableSearch)
        Me.Controls.Add(Me.sup_name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Supplies"
        Me.Text = "Edit_Supplies"
        CType(Me.View_Edit_Sup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sup_address As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sup_tel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sup_fax As TextBox
    Friend WithEvents lableSearch As Label
    Friend WithEvents sup_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents View_Edit_Sup As DataGridView
    Friend WithEvents btnAdd As Button
End Class
