Imports System.Text.Json.Nodes

Public Class popup_patientKin
    Public kinsData As New Dictionary(Of String, String)


    Private Sub Patient_kinsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Patient_kinsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub popup_patientKin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_kins' table. You can move, or remove it, as needed.
        Me.Patient_kinsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_kins)
        kinsData("id") = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If pateintKinDG.CurrentRow IsNot Nothing Then
            kinsData("id") = pateintKinDG.SelectedRows(0).Cells(0).Value.ToString
            kinsData("name") = pateintKinDG.SelectedRows(0).Cells(1).Value.ToString
            kinsData("address") = pateintKinDG.SelectedRows(0).Cells(2).Value.ToString
            kinsData("rela") = pateintKinDG.SelectedRows(0).Cells(3).Value.ToString
            kinsData("tel") = pateintKinDG.SelectedRows(0).Cells(4).Value.ToString

            'System.Console.WriteLine(kinsData("id"))
            'System.Console.WriteLine(kinsData("name"))
            'System.Console.WriteLine(kinsData("rela"))

            Add_Patient.kinID = kinsData("id")
            Add_Patient.kin_fullName.Text = kinsData("name")
            Add_Patient.kin_address.Text = kinsData("address")
            Add_Patient.kin_rela.Text = kinsData("rela")
            Add_Patient.kin_tel.Text = kinsData("tel")

            Edit_Patient.kinID = kinsData("id")
            Edit_Patient.kin_fullName.Text = kinsData("name")
            Edit_Patient.kin_address.Text = kinsData("address")
            Edit_Patient.kin_rela.Text = kinsData("rela")
            Edit_Patient.kin_tel.Text = kinsData("tel")

            ' disabled textbox
            Add_Patient.SetDisabledKin()


            Me.Close()
        End If


    End Sub

End Class