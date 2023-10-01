Public Class Add_StaffInWardForm
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        staffId.Text = ""
        wardId.Text = ""
        Shift.SelectedIndex = -1
    End Sub


End Class