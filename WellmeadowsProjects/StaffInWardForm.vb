Public Class StaffInWardForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_StaffInWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_StaffInWardForm.Show()
    End Sub

    Private Sub staffInWardPanel_Paint(sender As Object, e As PaintEventArgs) Handles staffInWardPanel.Paint

        If MainForm.personalID <> "" Or MainForm.cnID <> "" Then
            Console.WriteLine("if")
            btnReport.Visible = True

        Else
            Console.WriteLine("else")
            btnReport.Visible = False
        End If
    End Sub
End Class