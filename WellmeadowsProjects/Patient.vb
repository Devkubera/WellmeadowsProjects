Public Class Patient
    Private Const ordinalIgnoreCase As StringComparison = StringComparison.OrdinalIgnoreCase
    Public patientData As New Dictionary(Of String, String)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Patient.Show()
    End Sub


    Private Sub btnVisit_Click(sender As Object, e As EventArgs) Handles btnVisit.Click
        Patient_Visit.Show()
    End Sub

    Public Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_kins' table. You can move, or remove it, as needed.
        Me.Patient_kinsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_kins)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.LocalDoctors' table. You can move, or remove it, as needed.
        Me.LocalDoctorsTableAdapter.Fill(Me.WellmeadowsDataSet.LocalDoctors)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)

        ViewPa.ClearSelection()
        ViewPa.ClearSelection()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ViewPa.CurrentRow IsNot Nothing Then
            Dim ID = ViewPa.SelectedRows(0).Cells(0).Value.ToString
            Console.WriteLine(ID)
            ViewPa.Rows.RemoveAt(ViewPa.CurrentRow.Index)
            PatientsTableAdapter.DeleteByPatientID(ID)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' get value from view pa
        Dim selected As New List(Of String)
        If ViewPa.CurrentRow IsNot Nothing Then
            patientData("patientID") = ViewPa.SelectedRows(0).Cells(0).Value.ToString
            patientData("kinID") = ViewPa.SelectedRows(0).Cells(1).Value.ToString
            patientData("localID") = ViewPa.SelectedRows(0).Cells(2).Value.ToString
            patientData("firstName") = ViewPa.SelectedRows(0).Cells(3).Value.ToString
            patientData("lastName") = ViewPa.SelectedRows(0).Cells(4).Value.ToString
            patientData("address") = ViewPa.SelectedRows(0).Cells(5).Value.ToString
            patientData("gender") = ViewPa.SelectedRows(0).Cells(6).Value.ToString
            patientData("status") = ViewPa.SelectedRows(0).Cells(7).Value.ToString
            patientData("tel") = ViewPa.SelectedRows(0).Cells(8).Value.ToString
            patientData("dob") = ViewPa.SelectedRows(0).Cells(9).Value.ToString
            patientData("dateRegis") = ViewPa.SelectedRows(0).Cells(10).Value.ToString

            Edit_Patient.patientID = patientData("patientID")
            Edit_Patient.kinID = patientData("kinID")
            Edit_Patient.localDoctorID = patientData("localID")
            Edit_Patient.pt_firstName.Text = patientData("firstName")
            Edit_Patient.pt_lastName.Text = patientData("lastName")
            Edit_Patient.pt_address.Text = patientData("address")
            Edit_Patient.pt_gender.Text = patientData("gender")
            Edit_Patient.pt_status.Text = patientData("status")
            Edit_Patient.pt_tel.Text = patientData("tel")
            Edit_Patient.pt_birthday.Value = patientData("dob")
            Edit_Patient.pt_date.Value = patientData("dateRegis")

            Dim kinObject = Patient_kinsTableAdapter.GetDataByKinID(patientData("kinID"))
            For Each row In kinObject
                Edit_Patient.kin_fullName.Text = row.fullname
                Edit_Patient.kin_rela.Text = row.relationship
                Edit_Patient.kin_address.Text = row.address
                Edit_Patient.kin_tel.Text = row.tel
            Next

            Dim localObject = LocalDoctorsTableAdapter.GetDataByDoclocalID(patientData("localID"))
            For Each row In localObject
                Edit_Patient.local_clinic_ID.Text = row.clinicID
                Edit_Patient.local_fullName.Text = row.fullname
                Edit_Patient.local_address.Text = row.address
                Edit_Patient.local_tel.Text = row.tel
                Console.WriteLine(row.clinicID)
            Next
        Else
            MessageBox.Show("กรุณาเลือกข้อมูลก่อน")
        End If
        Edit_Patient.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            PatientsBindingSource1.RemoveFilter()
        Else
            PatientsBindingSource1.Filter = $"patientID LIKE '*{searchText}*' OR firstName LIKE '*{searchText}*' OR lastName LIKE '*{searchText}*' "
        End If
    End Sub

End Class