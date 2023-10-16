<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup_waitingListForm
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
        Me.placeholderlb = New System.Windows.Forms.Label()
        Me.waitingListTable = New System.Windows.Forms.DataGridView()
        Me.SearchWaiting = New System.Windows.Forms.TextBox()
        Me.waitingListlb = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.waitingListTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'placeholderlb
        '
        Me.placeholderlb.AutoSize = True
        Me.placeholderlb.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeholderlb.Location = New System.Drawing.Point(839, 60)
        Me.placeholderlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.placeholderlb.Name = "placeholderlb"
        Me.placeholderlb.Size = New System.Drawing.Size(377, 30)
        Me.placeholderlb.TabIndex = 60
        Me.placeholderlb.Text = "ค้นหาผู้ป่วยรอเตียงด้วยชื่อ, หมายเลขวอร์ด"
        '
        'waitingListTable
        '
        Me.waitingListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.waitingListTable.Location = New System.Drawing.Point(124, 161)
        Me.waitingListTable.Margin = New System.Windows.Forms.Padding(4)
        Me.waitingListTable.MultiSelect = False
        Me.waitingListTable.Name = "waitingListTable"
        Me.waitingListTable.ReadOnly = True
        Me.waitingListTable.RowHeadersWidth = 51
        Me.waitingListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.waitingListTable.Size = New System.Drawing.Size(1137, 404)
        Me.waitingListTable.TabIndex = 59
        '
        'SearchWaiting
        '
        Me.SearchWaiting.Font = New System.Drawing.Font("Prompt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchWaiting.Location = New System.Drawing.Point(844, 94)
        Me.SearchWaiting.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchWaiting.Name = "SearchWaiting"
        Me.SearchWaiting.Size = New System.Drawing.Size(417, 38)
        Me.SearchWaiting.TabIndex = 58
        '
        'waitingListlb
        '
        Me.waitingListlb.AutoSize = True
        Me.waitingListlb.Font = New System.Drawing.Font("Prompt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waitingListlb.Location = New System.Drawing.Point(116, 86)
        Me.waitingListlb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.waitingListlb.Name = "waitingListlb"
        Me.waitingListlb.Size = New System.Drawing.Size(194, 46)
        Me.waitingListlb.TabIndex = 57
        Me.waitingListlb.Text = "Waiting List"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Prompt", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(1138, 584)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 50)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'popup_waitingListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1793, 724)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.placeholderlb)
        Me.Controls.Add(Me.waitingListTable)
        Me.Controls.Add(Me.SearchWaiting)
        Me.Controls.Add(Me.waitingListlb)
        Me.Name = "popup_waitingListForm"
        Me.Text = "popup_waitingListForm"
        CType(Me.waitingListTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents placeholderlb As Label
    Friend WithEvents waitingListTable As DataGridView
    Friend WithEvents SearchWaiting As TextBox
    Friend WithEvents waitingListlb As Label
    Friend WithEvents Button2 As Button
End Class
