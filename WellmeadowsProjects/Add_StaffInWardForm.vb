Imports System.Security.Cryptography
Imports System.Windows.Forms.AxHost
Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Add_StaffInWardForm
    Public StID As String = ""
    Public wID As String = ""
    Public shID As String = ""

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        staffId.Text = ""
        firstname.Text = ""
        lastname.Text = ""
        wardId.Text = ""
        ShiftTime.Text = ""
        endTime.Text = ""
    End Sub

    Private Sub btnCheck_staff_Click(sender As Object, e As EventArgs) Handles btnCheck_staff.Click
        popup_wardstaffs.ShowDialog()
    End Sub

    Private Sub btnCheck_ward_Click(sender As Object, e As EventArgs) Handles btnCheck_ward.Click
        popup_ward.ShowDialog()
    End Sub

    Private Sub btnCheck_shift_Click(sender As Object, e As EventArgs) Handles btnCheck_shift.Click
        popup_shifts.ShowDialog()
    End Sub

    Private Sub staffId_TextChanged(sender As Object, e As EventArgs) Handles staffId.TextChanged
        staffId.Enabled = False
    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs) Handles firstname.TextChanged
        firstname.Enabled = False
    End Sub

    Private Sub lastname_TextChanged(sender As Object, e As EventArgs) Handles lastname.TextChanged
        lastname.Enabled = False
    End Sub

    Private Sub wardId_TextChanged(sender As Object, e As EventArgs) Handles wardId.TextChanged
        wardId.Enabled = False
    End Sub

    Private Sub ShiftTime_TextChanged(sender As Object, e As EventArgs) Handles ShiftTime.TextChanged
        ShiftTime.Enabled = False
    End Sub

    Private Sub endTime_TextChanged(sender As Object, e As EventArgs) Handles endTime.TextChanged
        endTime.Enabled = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If staffId.Text IsNot Nothing And wardId.Text IsNot Nothing And shID IsNot Nothing Then
            Console.WriteLine("wardID : " & wardId.Text)
            Console.WriteLine("staffID : " & staffId.Text)
            Console.WriteLine("shiftID : " & shID)

            Ward_StaffsTableAdapter.InsertWardStaffs(shID, staffId.Text, wardId.Text)

            MessageBox.Show("เพิ่มข้อมูลสำเร็จ")
            Me.Close()
        End If

    End Sub

    Private Sub Ward_StaffsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Ward_StaffsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub Add_StaffInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Ward_Staffs' table. You can move, or remove it, as needed.
        Me.Ward_StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Ward_Staffs)

    End Sub
End Class