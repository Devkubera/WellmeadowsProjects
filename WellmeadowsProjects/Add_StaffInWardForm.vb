Public Class Add_StaffInWardForm
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        staffId.Text = ""
        wardId.Text = ""
        Shift.SelectedIndex = -1
    End Sub

    Private Sub Ward_StaffsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ward_StaffsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Ward_StaffsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub Add_StaffInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Ward_Staffs' table. You can move, or remove it, as needed.
        Me.Ward_StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Ward_Staffs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub
End Class