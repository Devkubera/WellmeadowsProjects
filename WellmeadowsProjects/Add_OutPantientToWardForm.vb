Public Class Add_OutPantientToWardForm
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        patientId.Text = ""
        visitId.SelectedIndex = -1
        staffId.Text = ""
        wardId.Text = ""
        symptom.Text = ""
    End Sub
End Class