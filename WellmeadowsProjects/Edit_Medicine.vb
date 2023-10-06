Public Class Edit_Medicine
    Public mmID As String = ""
    Public supID As String = ""

    Private Sub Edit_Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Med_Medicines' table. You can move, or remove it, as needed.
        Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)
        Console.WriteLine(mmID)
        Console.WriteLine(supID & "sup")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim supID As Integer? = Nothing ' หรือค่าเริ่มต้นอื่น ๆ ที่เหมาะสม
        Med_MedicinesTableAdapter.UpdateMedicineBymmID(
        supID,
        m_name.Text,
        m_desc.Text,
        m_dosage.Text,
        m_method.Text,
        m_stock.Text,
        m_scale.Text,
        m_unit.Text,
        mmID
        )

        Me.Close()
    End Sub

    Private Sub Med_MedicinesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Med_MedicinesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub btnCheck_sup_Click(sender As Object, e As EventArgs) Handles btnCheck_sup.Click
        Dim backupSupId = supID
        popup_supplies.ShowDialog()

        If popup_supplies.supData("id") IsNot Nothing Then
            supID = popup_supplies.supData("id")
        End If
    End Sub
End Class