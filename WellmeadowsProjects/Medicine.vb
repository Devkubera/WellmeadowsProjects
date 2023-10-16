Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Medicine
    Public MedicineData As New Dictionary(Of String, String)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Medicine.Show()
    End Sub

    Private Sub btnVisit_Click(sender As Object, e As EventArgs) Handles btnVisit.Click
        Patient_Presscipt.Show()
    End Sub


    Public Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Suppilers' table. You can move, or remove it, as needed.
        Me.SuppilersTableAdapter.Fill(Me.WellmeadowsDataSet.Suppilers)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Med_Medicines' table. You can move, or remove it, as needed.
        Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)

        If MainForm.cnID <> "" Then
            Console.WriteLine("if")
            btnAdd.Visible = True
            btnUpdate.Visible = True
            btnDelete.Visible = True

        Else
            Console.WriteLine("else")
            btnAdd.Visible = False
            btnUpdate.Visible = False
            btnDelete.Visible = False
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If ViewMedi.CurrentRow IsNot Nothing Then
                Dim ID = ViewMedi.SelectedRows(0).Cells(0).Value.ToString
                Console.WriteLine(ID)
                Med_MedicinesTableAdapter.DeleteBymmID(ID)
                ViewMedi.Rows.RemoveAt(ViewMedi.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show("กรุณาลบข้อมูลภายในตารางอื่นๆก่อน ถึงจะสามารถลบข้อมูลนี้ได้", "เกิดข้อผิดพลาดในการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
            Console.WriteLine("mmID : " & Edit_Medicine.mmID)
            Console.WriteLine("mmID : " & Edit_Medicine.supID)
            Console.WriteLine("mmID : " & Edit_Medicine.m_name.Text)
            Console.WriteLine("mmID : " & Edit_Medicine.m_desc.Text)
            Console.WriteLine("mmID : " & Edit_Medicine.m_dosage.Text)
            Console.WriteLine("mmID : " & Edit_Medicine.m_method.Text)
            Console.WriteLine("mmID : " & Edit_Medicine.m_stock.Text)
            Console.WriteLine("mmID : " & Edit_Medicine.m_scale.Text)
            Console.WriteLine("mmID : " & Edit_Medicine.m_unit.Text)



            Dim kinObject = SuppilersTableAdapter.GetDataSup(MedicineData("supID"))
            For Each row In kinObject
                Edit_Medicine.m_sup.Text = row.name

            Next

        Else
            MessageBox.Show("โปรดกรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Edit_Medicine.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            MedMedicinesBindingSource.RemoveFilter()
        Else
            MedMedicinesBindingSource.Filter = $" name LIKE '*{searchText}*'"
        End If
    End Sub

End Class