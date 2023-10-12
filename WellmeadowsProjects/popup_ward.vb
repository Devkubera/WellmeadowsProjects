Public Class popup_ward
    Public wardsData As New Dictionary(Of String, String)
    Private Sub popup_ward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Wards)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If WardTable.CurrentRow IsNot Nothing Then
            wardsData("wardID") = WardTable.SelectedRows(0).Cells(0).Value.ToString
            wardsData("wardName") = WardTable.SelectedRows(0).Cells(1).Value.ToString
            wardsData("location") = WardTable.SelectedRows(0).Cells(2).Value.ToString
            wardsData("tel") = WardTable.SelectedRows(0).Cells(3).Value.ToString
            wardsData("totalBed") = WardTable.SelectedRows(0).Cells(4).Value.ToString

            'Console.WriteLine(wardsData("wardID"))

            Add_StaffInWardForm.wardId.Text = wardsData("wardID")

            Edit_StaffInWardForm.wardId.Text = wardsData("wardID")

            Me.Close()
        End If
    End Sub

    Private Sub seachbox_TextChanged(sender As Object, e As EventArgs) Handles seachbox.TextChanged
        Dim searchText As String = seachbox.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            'เอา datasource มาใช้
            WardsBindingSource.RemoveFilter()
        Else
            WardsBindingSource.Filter = $"wardID LIKE '%{searchText}%' OR wardName LIKE '%{searchText}%' "
        End If
    End Sub
End Class