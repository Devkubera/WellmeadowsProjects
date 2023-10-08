Public Class PatientInWardForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_PateintToWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_PateintToWardForm.Show()
    End Sub

    Private Sub PatientInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Wards' table. You can move, or remove it, as needed.
        Me.Patient_WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Wards)

    End Sub
End Class