<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_PrescriptForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PrescriptReportViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Prescript_Report_ViewTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Prescript_Report_ViewTableAdapter()
        Me.PrescriptReportViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PrescriptReportViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescriptReportViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrescriptReportViewBindingSource
        '
        Me.PrescriptReportViewBindingSource.DataMember = "Prescript_Report_View"
        Me.PrescriptReportViewBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dataset_prescript_report"
        ReportDataSource1.Value = Me.PrescriptReportViewBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WellmeadowsProjects.Report_Prescript.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1313, 1055)
        Me.ReportViewer1.TabIndex = 0
        '
        'Prescript_Report_ViewTableAdapter
        '
        Me.Prescript_Report_ViewTableAdapter.ClearBeforeFill = True
        '
        'PrescriptReportViewBindingSource1
        '
        Me.PrescriptReportViewBindingSource1.DataMember = "Prescript_Report_View"
        Me.PrescriptReportViewBindingSource1.DataSource = Me.WellmeadowsDataSet
        '
        'Report_PrescriptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 1055)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Report_PrescriptForm"
        Me.Text = "Report_PrescriptForm"
        CType(Me.PrescriptReportViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescriptReportViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PrescriptReportViewBindingSource As BindingSource
    Friend WithEvents Prescript_Report_ViewTableAdapter As WellmeadowsDataSetTableAdapters.Prescript_Report_ViewTableAdapter
    Friend WithEvents PrescriptReportViewBindingSource1 As BindingSource
End Class
