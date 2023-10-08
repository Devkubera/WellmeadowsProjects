Public Class StaffInWardForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_StaffInWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_StaffInWardForm.Show()
    End Sub

    Private Sub StaffInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbWardId.SelectedIndex = 0
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Report_EachWard.Report_title = cbbWardId.Text


        Report_EachWard.Show()

    End Sub

    Private Sub cbbWardId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbWardId.SelectedIndexChanged
        btnReport.Text = "สร้างรายงานวอร์ด" + cbbWardId.Text
    End Sub
End Class