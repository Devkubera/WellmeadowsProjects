Public Class Report_In_PatientForm
    Private Sub Report_In_PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Out_Patients_Report_View' table. You can move, or remove it, as needed.
        Try
            Me.IN_Patients_Report_ViewTableAdapter.Fill(Me.WellmeadowsDataSet.IN_Patients_Report_View)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Console.WriteLine("Error to open in-patient report: " & ex.Message)
        End Try

    End Sub
End Class