Public Class WaitingListForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_WaitingListForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_WaitingListForm.Show()
    End Sub

    Private Sub waitingListPanel_Paint(sender As Object, e As PaintEventArgs) Handles waitingListPanel.Paint
        If MainForm.cnID <> "" Or MainForm.mdID <> "" Then
            Console.WriteLine("if")
            btnReport.Visible = True
            btnAdd.Visible = True
            btnEdit.Visible = True
            btnDel.Visible = True
        Else
            Console.WriteLine("else")
            btnReport.Visible = False
            btnAdd.Visible = False
            btnEdit.Visible = False
            btnDel.Visible = False
        End If
    End Sub
End Class