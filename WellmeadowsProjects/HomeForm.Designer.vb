<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.day_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timeLabel
        '
        Me.timeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Prompt", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(491, 322)
        Me.timeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.timeLabel.Size = New System.Drawing.Size(0, 43)
        Me.timeLabel.TabIndex = 3
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'day_label
        '
        Me.day_label.AutoSize = True
        Me.day_label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.day_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_label.Location = New System.Drawing.Point(0, 0)
        Me.day_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.day_label.Name = "day_label"
        Me.day_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.day_label.Size = New System.Drawing.Size(0, 46)
        Me.day_label.TabIndex = 4
        Me.day_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.day_label.Visible = False
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.day_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeLabel As Label
    Friend WithEvents day_label As Label
End Class
