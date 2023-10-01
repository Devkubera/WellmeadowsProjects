<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.btnStaff = New System.Windows.Forms.PictureBox()
        Me.btnWard = New System.Windows.Forms.PictureBox()
        Me.PatientBtn = New System.Windows.Forms.PictureBox()
        Me.btnMedical = New System.Windows.Forms.PictureBox()
        Me.btnDashboard = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMedical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnHome, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaff, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWard, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PatientBtn, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMedical, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDashboard, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 592)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1191, 59)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHome.Image = Global.WellmeadowsProjects.My.Resources.Resources.home1
        Me.btnHome.Location = New System.Drawing.Point(3, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(192, 53)
        Me.btnHome.TabIndex = 4
        Me.btnHome.TabStop = False
        '
        'btnStaff
        '
        Me.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaff.Image = Global.WellmeadowsProjects.My.Resources.Resources.staff
        Me.btnStaff.Location = New System.Drawing.Point(201, 3)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(192, 53)
        Me.btnStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnStaff.TabIndex = 5
        Me.btnStaff.TabStop = False
        '
        'btnWard
        '
        Me.btnWard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWard.Image = Global.WellmeadowsProjects.My.Resources.Resources.ward
        Me.btnWard.Location = New System.Drawing.Point(399, 3)
        Me.btnWard.Name = "btnWard"
        Me.btnWard.Size = New System.Drawing.Size(192, 53)
        Me.btnWard.TabIndex = 6
        Me.btnWard.TabStop = False
        '
        'PatientBtn
        '
        Me.PatientBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientBtn.Image = Global.WellmeadowsProjects.My.Resources.Resources.patient
        Me.PatientBtn.Location = New System.Drawing.Point(597, 3)
        Me.PatientBtn.Name = "PatientBtn"
        Me.PatientBtn.Size = New System.Drawing.Size(192, 53)
        Me.PatientBtn.TabIndex = 7
        Me.PatientBtn.TabStop = False
        '
        'btnMedical
        '
        Me.btnMedical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMedical.Image = Global.WellmeadowsProjects.My.Resources.Resources.medical
        Me.btnMedical.Location = New System.Drawing.Point(795, 3)
        Me.btnMedical.Name = "btnMedical"
        Me.btnMedical.Size = New System.Drawing.Size(192, 53)
        Me.btnMedical.TabIndex = 8
        Me.btnMedical.TabStop = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDashboard.Image = Global.WellmeadowsProjects.My.Resources.Resources.dashbord
        Me.btnDashboard.Location = New System.Drawing.Point(993, 3)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(195, 53)
        Me.btnDashboard.TabIndex = 9
        Me.btnDashboard.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelMain)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1191, 651)
        Me.Panel1.TabIndex = 1
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1191, 592)
        Me.PanelMain.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMedical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents btnStaff As PictureBox
    Friend WithEvents btnWard As PictureBox
    Friend WithEvents PatientBtn As PictureBox
    Friend WithEvents btnMedical As PictureBox
    Friend WithEvents btnDashboard As PictureBox
End Class
