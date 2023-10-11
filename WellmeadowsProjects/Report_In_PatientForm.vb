Public Class Report_In_PatientForm
    Private Sub Report_In_PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.IN_Patients_Report_View' table. You can move, or remove it, as needed.
        Me.IN_Patients_Report_ViewTableAdapter.Fill(Me.WellmeadowsDataSet.IN_Patients_Report_View)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class