<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashbordForm
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MedEquipmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDataSet = New WellmeadowsProjects.WellmeadowsDataSet()
        Me.CountstaffviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountwardviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountInPatientviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CounttotalBedviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountPatientTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.StaffsTableAdapter()
        Me.Med_EquipmentsTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Med_EquipmentsTableAdapter()
        Me.Count_staff_viewTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.count_staff_viewTableAdapter()
        Me.Count_ward_viewTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.count_ward_viewTableAdapter()
        Me.Count_InPatient_viewTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.count_InPatient_viewTableAdapter()
        Me.Count_totalBed_viewTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.count_totalBed_viewTableAdapter()
        Me.Count_PatientTypeTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Count_PatientTypeTableAdapter()
        Me.Count_PatientAgeTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Count_PatientAgeTableAdapter()
        Me.Count_PatientAgeTableAdapter2 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Count_PatientAgeTableAdapter()
        Me.Count_StaffInWardTableAdapter1 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Count_StaffInWardTableAdapter()
        Me.Count_StaffInWardTableAdapter2 = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Count_StaffInWardTableAdapter()
        Me.Count_StaffInWardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager()
        Me.Count_PatientInWardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Count_PatientInWardTableAdapter = New WellmeadowsProjects.WellmeadowsDataSetTableAdapters.Count_PatientInWardTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.MedEquipmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountstaffviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountwardviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountInPatientviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CounttotalBedviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountPatientTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Count_StaffInWardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Count_PatientInWardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedEquipmentsBindingSource
        '
        Me.MedEquipmentsBindingSource.DataMember = "Med_Equipments"
        Me.MedEquipmentsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'WellmeadowsDataSet
        '
        Me.WellmeadowsDataSet.DataSetName = "WellmeadowsDataSet"
        Me.WellmeadowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CountstaffviewBindingSource
        '
        Me.CountstaffviewBindingSource.DataMember = "count_staff_view"
        Me.CountstaffviewBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'CountwardviewBindingSource
        '
        Me.CountwardviewBindingSource.DataMember = "count_ward_view"
        Me.CountwardviewBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'CountInPatientviewBindingSource
        '
        Me.CountInPatientviewBindingSource.DataMember = "count_InPatient_view"
        Me.CountInPatientviewBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'CounttotalBedviewBindingSource
        '
        Me.CounttotalBedviewBindingSource.DataMember = "count_totalBed_view"
        Me.CounttotalBedviewBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'CountPatientTypeBindingSource
        '
        Me.CountPatientTypeBindingSource.DataMember = "Count_PatientType"
        Me.CountPatientTypeBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "Staffs"
        Me.StaffsBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
        '
        'Med_EquipmentsTableAdapter
        '
        Me.Med_EquipmentsTableAdapter.ClearBeforeFill = True
        '
        'Count_staff_viewTableAdapter
        '
        Me.Count_staff_viewTableAdapter.ClearBeforeFill = True
        '
        'Count_ward_viewTableAdapter
        '
        Me.Count_ward_viewTableAdapter.ClearBeforeFill = True
        '
        'Count_InPatient_viewTableAdapter
        '
        Me.Count_InPatient_viewTableAdapter.ClearBeforeFill = True
        '
        'Count_totalBed_viewTableAdapter
        '
        Me.Count_totalBed_viewTableAdapter.ClearBeforeFill = True
        '
        'Count_PatientTypeTableAdapter
        '
        Me.Count_PatientTypeTableAdapter.ClearBeforeFill = True
        '
        'Count_PatientAgeTableAdapter1
        '
        Me.Count_PatientAgeTableAdapter1.ClearBeforeFill = True
        '
        'Count_PatientAgeTableAdapter2
        '
        Me.Count_PatientAgeTableAdapter2.ClearBeforeFill = True
        '
        'Count_StaffInWardTableAdapter1
        '
        Me.Count_StaffInWardTableAdapter1.ClearBeforeFill = True
        '
        'Count_StaffInWardTableAdapter2
        '
        Me.Count_StaffInWardTableAdapter2.ClearBeforeFill = True
        '
        'Count_StaffInWardBindingSource
        '
        Me.Count_StaffInWardBindingSource.DataMember = "Count_StaffInWard"
        Me.Count_StaffInWardBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.ChargeNursesTableAdapter = Nothing
        Me.TableAdapterManager.DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.In_PatientsTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Login_logsTableAdapter = Nothing
        Me.TableAdapterManager.Med_EquipmentsTableAdapter = Me.Med_EquipmentsTableAdapter
        Me.TableAdapterManager.Med_MedicinesTableAdapter = Nothing
        Me.TableAdapterManager.MedicalDirectorsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_kinsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_VisitsTableAdapter = Nothing
        Me.TableAdapterManager.Patient_WardsTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PW_PrescriptsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.Staff_ExperiencesTableAdapter = Nothing
        Me.TableAdapterManager.Staff_QualificatesTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Me.StaffsTableAdapter
        Me.TableAdapterManager.SuppilersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsProjects.WellmeadowsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_RequestsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_StaffsTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'Count_PatientInWardBindingSource
        '
        Me.Count_PatientInWardBindingSource.DataMember = "Count_PatientInWard"
        Me.Count_PatientInWardBindingSource.DataSource = Me.WellmeadowsDataSet
        '
        'Count_PatientInWardTableAdapter
        '
        Me.Count_PatientInWardTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MedEquipmentsBindingSource
        ReportDataSource2.Name = "StaffCount_ds"
        ReportDataSource2.Value = Me.CountstaffviewBindingSource
        ReportDataSource3.Name = "WardCount_ds"
        ReportDataSource3.Value = Me.CountwardviewBindingSource
        ReportDataSource4.Name = "CountAdmitPT_ds"
        ReportDataSource4.Value = Me.CountInPatientviewBindingSource
        ReportDataSource5.Name = "BedCount_ds"
        ReportDataSource5.Value = Me.CounttotalBedviewBindingSource
        ReportDataSource6.Name = "CountPtType_ds"
        ReportDataSource6.Value = Me.CountPatientTypeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WellmeadowsProjects.DashboardData.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1288, 757)
        Me.ReportViewer1.TabIndex = 0
        '
        'DashbordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 757)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DashbordForm"
        Me.Text = "DashbordForm"
        CType(Me.MedEquipmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountstaffviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountwardviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountInPatientviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CounttotalBedviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountPatientTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Count_StaffInWardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Count_PatientInWardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WellmeadowsDataSet As WellmeadowsDataSet
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents StaffsTableAdapter As WellmeadowsDataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents MedEquipmentsBindingSource As BindingSource
    Friend WithEvents Med_EquipmentsTableAdapter As WellmeadowsDataSetTableAdapters.Med_EquipmentsTableAdapter
    Friend WithEvents CountstaffviewBindingSource As BindingSource
    Friend WithEvents Count_staff_viewTableAdapter As WellmeadowsDataSetTableAdapters.count_staff_viewTableAdapter
    Friend WithEvents CountwardviewBindingSource As BindingSource
    Friend WithEvents Count_ward_viewTableAdapter As WellmeadowsDataSetTableAdapters.count_ward_viewTableAdapter
    Friend WithEvents CountInPatientviewBindingSource As BindingSource
    Friend WithEvents Count_InPatient_viewTableAdapter As WellmeadowsDataSetTableAdapters.count_InPatient_viewTableAdapter
    Friend WithEvents CounttotalBedviewBindingSource As BindingSource
    Friend WithEvents Count_totalBed_viewTableAdapter As WellmeadowsDataSetTableAdapters.count_totalBed_viewTableAdapter
    Friend WithEvents CountPatientTypeBindingSource As BindingSource
    Friend WithEvents Count_PatientTypeTableAdapter As WellmeadowsDataSetTableAdapters.Count_PatientTypeTableAdapter
    Friend WithEvents Count_PatientAgeTableAdapter1 As WellmeadowsDataSetTableAdapters.Count_PatientAgeTableAdapter
    Friend WithEvents Count_PatientAgeTableAdapter2 As WellmeadowsDataSetTableAdapters.Count_PatientAgeTableAdapter
    Friend WithEvents Count_StaffInWardTableAdapter1 As WellmeadowsDataSetTableAdapters.Count_StaffInWardTableAdapter
    Friend WithEvents Count_StaffInWardTableAdapter2 As WellmeadowsDataSetTableAdapters.Count_StaffInWardTableAdapter
    Friend WithEvents Count_StaffInWardBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As WellmeadowsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Count_PatientInWardBindingSource As BindingSource
    Friend WithEvents Count_PatientInWardTableAdapter As WellmeadowsDataSetTableAdapters.Count_PatientInWardTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
