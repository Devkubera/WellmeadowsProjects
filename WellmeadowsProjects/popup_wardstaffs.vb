Imports System.Text.Json.Nodes
Public Class popup_wardstaffs

    Public staffsData As New Dictionary(Of String, String)

    Private Sub popup_staffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)
        staffsData("id") = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If StaffTable.CurrentRow IsNot Nothing Then
            staffsData("id") = StaffTable.SelectedRows(0).Cells(0).Value.ToString
            staffsData("firstname") = StaffTable.SelectedRows(0).Cells(1).Value.ToString
            staffsData("lastname") = StaffTable.SelectedRows(0).Cells(2).Value.ToString

            Add_StaffInWardForm.staffId.Text = staffsData("id")
            Add_StaffInWardForm.firstname.Text = staffsData("firstname")
            Add_StaffInWardForm.lastname.Text = staffsData("lastname")

            Edit_StaffInWardForm.staffId.Text = staffsData("id")
            Edit_StaffInWardForm.firstname.Text = staffsData("firstname")
            Edit_StaffInWardForm.lastname.Text = staffsData("lastname")

            Me.Close()
        End If
    End Sub

    Private Sub seachbox_TextChanged(sender As Object, e As EventArgs) Handles seachbox.TextChanged
        Dim searchText As String = seachbox.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            'เอา datasource มาใช้
            StaffsBindingSource.RemoveFilter()
        Else
            StaffsBindingSource.Filter = $"staffID LIKE '%{searchText}%' OR firstName LIKE '%{searchText}%' OR lastName LIKE '%{searchText}%' "
        End If
    End Sub
End Class