Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Edit_Patient
    Public patientID As String = ""
    Public kinID As String = ""
    Public localDoctorID As String = ""
    Private Sub Edit_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(patientID)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        Try
            Console.WriteLine("PatientKins : " & kinID)
            Console.WriteLine("localDoctorID : " & localDoctorID)
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

            Patient_kinsTableAdapter.UpdateByKinsID(
                kin_fullName.Text,
                kin_address.Text,
                kin_rela.Text,
                kin_tel.Text,
                kinID
            )

            LocalDoctorsTableAdapter.UpdateByLocalDocID(
                local_fullName.Text,
                local_clinic_ID.Text,
                local_address.Text,
                local_tel.Text,
                localDoctorID
            )

            'Patient.ViewPa.Refresh()
            'Patient.Patient_Load(New Object, Nothing)

            ' refresh patient form
            Patient.Patient_Load(sender, e)

            ' show message อัพเดทสำเร็จ
            MessageBox.Show("อัพเดทสำเร็จ !", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด กรุณากรอกข้อมูลให้ครบทุกช่อง", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCheck_kin_Click(sender As Object, e As EventArgs) Handles btnCheck_kin.Click
        Dim backupKinID = kinID
        popup_patientKin.ShowDialog()

        If popup_patientKin.kinsData("id") IsNot Nothing Then
            kinID = popup_patientKin.kinsData("id")
        Else
            kinID = backupKinID
        End If
        Console.WriteLine("KinsID : " & kinID)
    End Sub

    Private Sub btnCheckLocal_Click(sender As Object, e As EventArgs) Handles btnCheckLocal.Click
        Dim backupLocalID = localDoctorID
        popup_localDoctor.ShowDialog()

        If popup_localDoctor.DocsData("id") IsNot Nothing Then
            localDoctorID = popup_localDoctor.DocsData("id")
        Else
            localDoctorID = backupLocalID
        End If
        Console.WriteLine("localDoctorID : " & localDoctorID)
    End Sub
End Class