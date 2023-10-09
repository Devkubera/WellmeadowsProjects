Public Class PatientInWardForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_PateintToWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_PateintToWardForm.Show()
    End Sub

    Private Sub PatientInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbPtype.SelectedIndex = 0
    End Sub

    Private Sub cbbPtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbPtype.SelectedIndexChanged
        If cbbPtype.SelectedIndex = 0 Then
            btnReport.Text = "สร้างรายงานผู้ป่วยใน"
        ElseIf cbbPtype.SelectedIndex = 1 Then
            btnReport.Text = "สร้างรายงานผู้ป่วยนอก"
        Else
            btnReport.Enabled = False
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If cbbPtype.SelectedIndex = 0 Then
            Report_In_PatientForm.Show()
        ElseIf cbbPtype.SelectedIndex = 1 Then
            Report_Out_PatientForm.Show()
        Else

        End If
    End Sub
End Class