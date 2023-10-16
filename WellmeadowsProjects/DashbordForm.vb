Imports Microsoft.Reporting.WinForms
Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class DashbordForm
    Private Sub DashbordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Count_PatientInWard' table. You can move, or remove it, as needed.
        Me.Count_PatientInWardTableAdapter.Fill(Me.WellmeadowsDataSet.Count_PatientInWard)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Count_PatientType' table. You can move, or remove it, as needed.
        Me.Count_PatientTypeTableAdapter.Fill(Me.WellmeadowsDataSet.Count_PatientType)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.count_totalBed_view' table. You can move, or remove it, as needed.
        Me.Count_totalBed_viewTableAdapter.Fill(Me.WellmeadowsDataSet.count_totalBed_view)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.count_InPatient_view' table. You can move, or remove it, as needed.
        Me.Count_InPatient_viewTableAdapter.Fill(Me.WellmeadowsDataSet.count_InPatient_view)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.count_ward_view' table. You can move, or remove it, as needed.
        Me.Count_ward_viewTableAdapter.Fill(Me.WellmeadowsDataSet.count_ward_view)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.count_staff_view' table. You can move, or remove it, as needed.
        Me.Count_staff_viewTableAdapter.Fill(Me.WellmeadowsDataSet.count_staff_view)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.Count_PatientAgeTableAdapter2.Fill(Me.WellmeadowsDataSet.Count_PatientAge)

        Dim PtAge As DataTable = Count_PatientAgeTableAdapter2.GetData()
        Dim PtAgeDataSource As New ReportDataSource("CountPtAge_ds", PtAge)
        ReportViewer1.LocalReport.DataSources.Add(PtAgeDataSource)


        Dim staffInWard As DataTable = Count_StaffInWardTableAdapter2.GetData()
        Dim staffInWardDataSource As New ReportDataSource("StaffInWardCount_ds", staffInWard)
        ReportViewer1.LocalReport.DataSources.Add(staffInWardDataSource)

        Dim ptInWard As DataTable = Count_PatientInWardTableAdapter.GetData()
        Dim ptInWardDataSource As New ReportDataSource("CountPtInWard_ds", ptInWard)
        ReportViewer1.LocalReport.DataSources.Add(ptInWardDataSource)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class