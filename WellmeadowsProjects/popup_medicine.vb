Public Class popup_medicine
    Public MedicinePressData As New Dictionary(Of String, String)
    Private Sub popup_medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Med_Medicines' table. You can move, or remove it, as needed.
        Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)
        MedicinePressData("id") = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If medicineDG.CurrentRow IsNot Nothing Then
            MedicinePressData("id") = medicineDG.SelectedRows(0).Cells(0).Value.ToString
            MedicinePressData("name") = medicineDG.SelectedRows(0).Cells(2).Value.ToString
            MedicinePressData("method") = medicineDG.SelectedRows(0).Cells(5).Value.ToString

            System.Console.WriteLine(MedicinePressData("id"))
            System.Console.WriteLine(MedicinePressData("name"))
            System.Console.WriteLine(MedicinePressData("method"))

            Add_Presscipt.medicineID = MedicinePressData("id")
            Add_Presscipt.m_id.Text = MedicinePressData("id")
            Add_Presscipt.m_name.Text = MedicinePressData("name")
            Add_Presscipt.m_method.Text = MedicinePressData("method")

            Add_Presscipt.SetDisabledMedicine()
            Me.Close()
        End If
    End Sub
End Class