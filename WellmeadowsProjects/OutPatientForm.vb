Public Class OutPatientForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_OutPantientToWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_OutPantientToWardForm.Show()
    End Sub
End Class