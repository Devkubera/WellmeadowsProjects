Public Class popup_patient
    Public PatientData As New Dictionary(Of String, String)
    Private Sub popup_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)
        PatientData("id") = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If patientDG.CurrentRow IsNot Nothing Then
            PatientData("patientId") = patientDG.SelectedRows(0).Cells(1).Value.ToString
            PatientData("firstname") = patientDG.SelectedRows(0).Cells(4).Value.ToString
            PatientData("lastname") = patientDG.SelectedRows(0).Cells(5).Value.ToString

            System.Console.WriteLine(PatientData("patientId"))
            System.Console.WriteLine(PatientData("firstname"))
            System.Console.WriteLine(PatientData("lastname"))


            Add_Presscipt.pt_id.Text = PatientData("patientId")
            Add_Presscipt.pt_firstName.Text = PatientData("firstname")
            Add_Presscipt.pt_lastName.Text = PatientData("lastname")


            Me.Close()
        End If
    End Sub
End Class