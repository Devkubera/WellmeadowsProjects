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
            PatientData("patientId") = patientDG.SelectedRows(0).Cells(0).Value.ToString
            PatientData("firstname") = patientDG.SelectedRows(0).Cells(1).Value.ToString
            PatientData("lastname") = patientDG.SelectedRows(0).Cells(2).Value.ToString

            System.Console.WriteLine(PatientData("patientId"))
            System.Console.WriteLine(PatientData("firstname"))
            System.Console.WriteLine(PatientData("lastname"))

            Add_Presscipt.pt_id.Text = PatientData("patientId")
            Add_Presscipt.pt_firstName.Text = PatientData("firstname")
            Add_Presscipt.pt_lastName.Text = PatientData("lastname")

            Add_PatientVisit.visit_p_ID.Text = PatientData("patientId")
            Add_PatientVisit.visit_p_name.Text = PatientData("firstname") + " " + PatientData("lastname")

            Edit_VisitPatient.visit_p_ID.Text = PatientData("patientId")
            Edit_VisitPatient.visit_p_name.Text = PatientData("firstname") + " " + PatientData("lastname")

            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' making search filter for data grid view by firstname, lastname and patient_id
        Dim searchQuery As String = TextBox1.Text.Trim()
        If searchQuery IsNot "" Then
            Me.PatientsBindingSource.Filter = "firstName LIKE '%" & searchQuery & "%' OR lastName LIKE '%" & searchQuery & "%' OR patient_id LIKE '%" & searchQuery & "%'"
        Else
            Me.PatientsBindingSource.Filter = ""
        End If
    End Sub
End Class