Public Class StaffForm
    Private Sub SearchStaff_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StafformTBlayout_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_StaffForm.Show()
    End Sub

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_Staff.Show()
    End Sub
End Class