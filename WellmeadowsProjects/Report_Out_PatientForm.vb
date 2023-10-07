Public Class Report_Out_PatientForm
    Private Sub Report_Out_PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Out_Patients_Report_View' table. You can move, or remove it, as needed.
        Me.Out_Patients_Report_ViewTableAdapter.Fill(Me.WellmeadowsDataSet.Out_Patients_Report_View)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class