Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Medicine
    Public MedicineData As New Dictionary(Of String, String)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Medicine.Show()
    End Sub

    Private Sub btnVisit_Click(sender As Object, e As EventArgs) Handles btnVisit.Click
        Patient_Presscipt.Show()
    End Sub


    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Med_Medicines' table. You can move, or remove it, as needed.
        Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ViewMedi.CurrentRow IsNot Nothing Then
            Dim ID = ViewMedi.SelectedRows(0).Cells(0).Value.ToString
            Console.WriteLine(ID)
            ViewMedi.Rows.RemoveAt(ViewMedi.CurrentRow.Index)
            Med_MedicinesTableAdapter.DeleteBymmID(ID)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selected As New List(Of String)
        If ViewMedi.CurrentRow IsNot Nothing Then
            MedicineData("mmID") = ViewMedi.SelectedRows(0).Cells(0).Value.ToString
            MedicineData("supID") = ViewMedi.SelectedRows(0).Cells(1).Value.ToString
            MedicineData("name") = ViewMedi.SelectedRows(0).Cells(2).Value.ToString
            MedicineData("desc") = ViewMedi.SelectedRows(0).Cells(3).Value.ToString
            MedicineData("dosage") = ViewMedi.SelectedRows(0).Cells(4).Value.ToString
            MedicineData("method") = ViewMedi.SelectedRows(0).Cells(5).Value.ToString
            MedicineData("stock") = ViewMedi.SelectedRows(0).Cells(6).Value.ToString
            MedicineData("buy") = ViewMedi.SelectedRows(0).Cells(7).Value.ToString
            MedicineData("unit") = ViewMedi.SelectedRows(0).Cells(8).Value.ToString


            Edit_Medicine.mmID = MedicineData("mmID")
            Edit_Medicine.supID = MedicineData("supID")
            Edit_Medicine.m_name.Text = MedicineData("name")
            Edit_Medicine.m_desc.Text = MedicineData("desc")
            Edit_Medicine.m_dosage.Text = MedicineData("dosage")
            Edit_Medicine.m_method.Text = MedicineData("method")
            Edit_Medicine.m_stock.Text = MedicineData("stock")
            Edit_Medicine.m_scale.Text = MedicineData("buy")
            Edit_Medicine.m_unit.Text = MedicineData("unit")

        Else
            MessageBox.Show("โปรดกรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Edit_Medicine.Show()
    End Sub
End Class