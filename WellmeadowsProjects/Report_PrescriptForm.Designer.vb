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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.PrescriptReportViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prescript_Report_ViewTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Prescript_Report_ViewTableAdapter()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescriptReportViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Prescript_DataSet"
        ReportDataSource1.Value = Me.PrescriptReportViewBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WellmeadowsProjects.Report_Prescript.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(985, 861)
        Me.ReportViewer1.TabIndex = 0
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrescriptReportViewBindingSource
        '
        Me.PrescriptReportViewBindingSource.DataMember = "Prescript_Report_View"
        Me.PrescriptReportViewBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Prescript_Report_ViewTableAdapter
        '
        Me.Prescript_Report_ViewTableAdapter.ClearBeforeFill = True
        '
        'Report_PrescriptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 861)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Report_PrescriptForm"
        Me.Text = "Report_PrescriptForm"
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescriptReportViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents PrescriptReportViewBindingSource As BindingSource
    Friend WithEvents Prescript_Report_ViewTableAdapter As WellmeadowsDataSetTableAdapters.Prescript_Report_ViewTableAdapter
End Class
