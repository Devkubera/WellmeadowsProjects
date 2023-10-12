Public Class popup_shifts

    Public shiftsData As New Dictionary(Of String, String)
    Private Sub popup_shifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Shifts' table. You can move, or remove it, as needed.
        Me.ShiftsTableAdapter.Fill(Me.WellmeadowsDataSet.Shifts)
        'shiftsData("id") = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If shiftTable.CurrentRow IsNot Nothing Then
            shiftsData("shiftID") = shiftTable.SelectedRows(0).Cells(0).Value.ToString
            shiftsData("shiftName") = shiftTable.SelectedRows(0).Cells(1).Value.ToString
            shiftsData("startTime") = shiftTable.SelectedRows(0).Cells(2).Value.ToString
            shiftsData("endTime") = shiftTable.SelectedRows(0).Cells(3).Value.ToString

            Add_StaffInWardForm.shID = shiftsData("shiftID")
            Add_StaffInWardForm.ShiftTime.Text = shiftsData("startTime")
            Add_StaffInWardForm.endTime.Text = shiftsData("endTime")

            Edit_StaffInWardForm.shID = shiftsData("shiftID")
            Edit_StaffInWardForm.ShiftTime.Text = shiftsData("startTime")
            Edit_StaffInWardForm.endTime.Text = shiftsData("endTime")

            Me.Close()
        End If
    End Sub
End Class