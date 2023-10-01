Public Class Edit_PateintToWardForm
    Private Sub Edit_PateintToWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        patientId.Text = ""
        visitId.SelectedIndex = -1
        staffId.Text = ""
        wardId.Text = ""
        patientType.SelectedIndex = -1
        symptom.Text = ""
    End Sub
End Class