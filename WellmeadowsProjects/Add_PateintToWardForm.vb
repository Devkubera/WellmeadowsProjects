Public Class Add_PateintToWardForm
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        patientId.Text = ""
        visitId.SelectedIndex = -1
        staffId.Text = ""
        wardId.Text = ""
        patientType.SelectedIndex = -1
        symptom.Text = ""
    End Sub
End Class