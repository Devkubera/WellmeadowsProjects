Public Class Medicine
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Medicine.Show()
    End Sub

    Private Sub btnVisit_Click(sender As Object, e As EventArgs) Handles btnVisit.Click
        Patient_Presscipt.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Edit_Medicine.Show()
    End Sub
End Class