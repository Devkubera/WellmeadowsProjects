Public Class Add_WaitingListForm
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        patientId.Text = ""
        dateWaiting.Value = DateTime.Now
        staffId.Text = ""
        wardId.SelectedIndex = -1
    End Sub
End Class