Public Class WardForm
    Private Sub btnStaffInWard_Click(sender As Object, e As EventArgs) Handles btnStaffInWard.Click
        StaffInWardForm.Show()
    End Sub

    Private Sub btnPInward_Click(sender As Object, e As EventArgs) Handles btnPInward.Click
        PatientInWardForm.Show()
    End Sub

    Private Sub btnWaitinglist_Click(sender As Object, e As EventArgs) Handles btnWaitinglist.Click
        WaitingListForm.Show()
    End Sub



    Private Sub wardPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class