Public Class popup_localDoctor
    Public DocsData As New Dictionary(Of String, String)
    Private Sub popup_localDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.LocalDoctors' table. You can move, or remove it, as needed.
        Me.LocalDoctorsTableAdapter.Fill(Me.WellmeadowsDataSet.LocalDoctors)
        DocsData("id") = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If doctorDG.CurrentRow IsNot Nothing Then
            DocsData("id") = doctorDG.SelectedRows(0).Cells(0).Value.ToString
            DocsData("clinic") = doctorDG.SelectedRows(0).Cells(1).Value.ToString
            DocsData("name") = doctorDG.SelectedRows(0).Cells(2).Value.ToString
            DocsData("address") = doctorDG.SelectedRows(0).Cells(3).Value.ToString
            DocsData("tel") = doctorDG.SelectedRows(0).Cells(4).Value.ToString

            'System.Console.WriteLine(kinsData("id"))
            'System.Console.WriteLine(kinsData("name"))
            'System.Console.WriteLine(kinsData("rela"))

            Add_Patient.localID = DocsData("id")
            Add_Patient.local_clinic_ID.Text = DocsData("clinic")
            Add_Patient.local_fullName.Text = DocsData("name")
            Add_Patient.local_address.Text = DocsData("address")
            Add_Patient.local_tel.Text = DocsData("tel")

            Edit_Patient.localDoctorID = DocsData("id")
            Edit_Patient.local_clinic_ID.Text = DocsData("clinic")
            Edit_Patient.local_fullName.Text = DocsData("name")
            Edit_Patient.local_address.Text = DocsData("address")
            Edit_Patient.local_tel.Text = DocsData("tel")

            ' disabled textbox
            Add_Patient.SetDisabledDoc()


            Me.Close()
        End If
    End Sub

    Private Sub seachbox_TextChanged(sender As Object, e As EventArgs) Handles seachbox.TextChanged
        ' making search filter for the datagrid to search with firstname, lastname, and tel
        Dim searchQuery As String = seachbox.Text.Trim()
        If searchQuery IsNot "" Then
            Me.LocalDoctorsBindingSource.Filter = "clinic_id LIKE '%" & searchQuery & "%' OR name LIKE '%" & searchQuery & "%' OR address LIKE '%" & searchQuery & "%' OR tel LIKE '%" & searchQuery & "%'"
        Else
            Me.LocalDoctorsBindingSource.Filter = ""
        End If
    End Sub
End Class