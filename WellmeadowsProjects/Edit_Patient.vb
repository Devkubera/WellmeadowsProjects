Public Class Edit_Patient
    Public patientID As String = ""
    Public kinID As String = ""
    Public localDoctorID As String = ""
    Private Sub Edit_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(patientID)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        PatientsTableAdapter.UpdatePatient(
            kinID,
            localDoctorID,
            pt_firstName.Text,
            pt_lastName.Text,
            pt_address.Text,
            pt_gender.Text,
            pt_status.Text,
            pt_tel.Text,
            pt_birthday.Value,
            pt_date.Value,
            patientID
        )

    End Sub

    Private Sub btnCheck_kin_Click(sender As Object, e As EventArgs) Handles btnCheck_kin.Click
        popup_patientKin.ShowDialog()
        If popup_patientKin.kinsData("id") IsNot Nothing Or popup_patientKin.kinsData("id") <> "" Then
            kinID = popup_patientKin.kinsData("id")
        Else

        End If
        Console.WriteLine("KinsID : " & kinID)
    End Sub

    Private Sub btnCheckLocal_Click(sender As Object, e As EventArgs) Handles btnCheckLocal.Click
        popup_localDoctor.ShowDialog()
        If popup_localDoctor.DocsData("id") IsNot Nothing Or popup_localDoctor.DocsData("id") <> "" Then
            localDoctorID = popup_localDoctor.DocsData("id")
        Else

        End If
        Console.WriteLine("localDoctorID : " & localDoctorID)
    End Sub
End Class