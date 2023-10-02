Public Class Patient
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Patient.Show()
    End Sub


    Private Sub btnVisit_Click(sender As Object, e As EventArgs) Handles btnVisit.Click
        Patient_Visit.Show()
    End Sub

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)

    End Sub
End Class