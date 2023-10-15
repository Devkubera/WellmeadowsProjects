Public Class popup_supplies
    Public supData As New Dictionary(Of String, String)
    Private Sub popup_supplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Suppilers' table. You can move, or remove it, as needed.
        Me.SuppilersTableAdapter.Fill(Me.WellmeadowsDataSet.Suppilers)
        supData("id") = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If supDG.CurrentRow IsNot Nothing Then
            supData("id") = supDG.SelectedRows(0).Cells(0).Value.ToString
            supData("mdID") = supDG.SelectedRows(0).Cells(1).Value.ToString
            supData("name") = supDG.SelectedRows(0).Cells(2).Value.ToString
            supData("address") = supDG.SelectedRows(0).Cells(3).Value.ToString
            supData("tel") = supDG.SelectedRows(0).Cells(4).Value.ToString
            supData("fax") = supDG.SelectedRows(0).Cells(5).Value.ToString
            supData("create") = supDG.SelectedRows(0).Cells(6).Value.ToString

            'System.Console.WriteLine(supData("mdID"))
            'System.Console.WriteLine(supData("name"))
            'System.Console.WriteLine(supData("address"))
            'System.Console.WriteLine(supData("tel"))
            'System.Console.WriteLine(supData("fax"))
            'System.Console.WriteLine(supData("create"))
            Add_Medicine.supID = supData("id")
            Add_Medicine.m_sup.Text = supData("name")

            Edit_Medicine.supID = supData("id")
            Edit_Medicine.m_sup.Text = supData("name")
            'Edit_Patient.kinID = supData("id")
            'Edit_Patient.kin_fullName.Text = supData("name")
            'Edit_Patient.kin_address.Text = supData("address")
            'Edit_Patient.kin_rela.Text = supData("rela")
            'Edit_Patient.kin_tel.Text = supData("tel")

            'disabled TextBox
            'Add_Supplies.SetDisabledKin()


            Me.Close()
        End If
    End Sub
End Class