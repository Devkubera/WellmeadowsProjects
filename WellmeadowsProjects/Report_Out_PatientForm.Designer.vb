<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report_Out_PatientForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OutPatientsReportViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.OutPatientsReportViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Out_Patients_Report_ViewTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Out_Patients_Report_ViewTableAdapter()
        Me.OutPatientsReportViewBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.OutPatientsReportViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutPatientsReportViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutPatientsReportViewBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "out_patient_dataset"
        ReportDataSource1.Value = Me.OutPatientsReportViewBindingSource2
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WellmeadowsProjects.Report_OutPatient.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1313, 1055)
        Me.ReportViewer1.TabIndex = 0
        '
        'OutPatientsReportViewBindingSource1
        '
        Me.OutPatientsReportViewBindingSource1.DataMember = "Out_Patients_Report_View"
        Me.OutPatientsReportViewBindingSource1.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OutPatientsReportViewBindingSource
        '
        Me.OutPatientsReportViewBindingSource.DataMember = "Out_Patients_Report_View"
        Me.OutPatientsReportViewBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Out_Patients_Report_ViewTableAdapter
        '
        Me.Out_Patients_Report_ViewTableAdapter.ClearBeforeFill = True
        '
        'OutPatientsReportViewBindingSource2
        '
        Me.OutPatientsReportViewBindingSource2.DataMember = "Out_Patients_Report_View"
        Me.OutPatientsReportViewBindingSource2.DataSource = Me.WellmeadowsDataSet
        '
        'Report_Out_PatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 1055)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Report_Out_PatientForm"
        Me.Text = "Report_Out_PatientForm"
        CType(Me.OutPatientsReportViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutPatientsReportViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutPatientsReportViewBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents OutPatientsReportViewBindingSource As BindingSource
    Friend WithEvents Out_Patients_Report_ViewTableAdapter As WellmeadowsDataSetTableAdapters.Out_Patients_Report_ViewTableAdapter
    Friend WithEvents OutPatientsReportViewBindingSource1 As BindingSource
    Friend WithEvents OutPatientsReportViewBindingSource2 As BindingSource
End Class
