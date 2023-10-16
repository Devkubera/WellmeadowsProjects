﻿Public Class Edit_Presscript
    Public pwID As String = ""
    Public cnID As String = ""
    Public doctorID As String = ""
    Public medicineID As String = ""
    Public ID As String = ""

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Console.WriteLine("ID : " & ID)
        Console.WriteLine("medicineID : " & m_id.Text)
        Console.WriteLine("pwID : " & pwID)
        Console.WriteLine("doctorID : " & doctorID)
        Console.WriteLine("cnID : " & MainForm.cnID)
        Console.WriteLine("m_dosage.Text : " & m_dosage.Text)
        Console.WriteLine("m_startDate.Value : " & m_startDate.Value)
        Console.WriteLine("m_endDate.Value : " & m_endDate.Value)
        Console.WriteLine("m_desc.Text : " & m_desc.Text)

        Try
            PW_PrescriptsTableAdapter.UpdatePresscript(m_id.Text, pwID, doctorID, MainForm.cnID, m_dosage.Text, m_startDate.Value, m_endDate.Value, m_desc.Text, ID)
            MessageBox.Show("ข้อมูลได้ถูกแก้ไขแล้ว", "แก้ไขข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' show message box error to update
            MessageBox.Show("ข้อมูลไม่สามารถแก้ไขได้", "แก้ไขข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' refresh data grid view
        Patient_Presscipt.Patient_Presscipt_Load(sender, e)

        Me.Close()
    End Sub

    Private Sub btnCheck_patient_Click(sender As Object, e As EventArgs) Handles btnCheck_patient.Click
        Dim backuppwID = pwID
        popup_PatientWard.ShowDialog()

        If popup_PatientWard.pwData("pwID") IsNot Nothing Then
            pwID = popup_PatientWard.pwData("pwID")
        Else
            pwID = backuppwID
        End If
        Console.WriteLine("pwID : " & pwID)
    End Sub

    Private Sub btnCheck_doc_Click(sender As Object, e As EventArgs) Handles btnCheck_doc.Click
        Dim backupdoctorID = doctorID
        pop_Doc.ShowDialog()

        If pop_Doc.DocsData("docID") IsNot Nothing Then
            doctorID = pop_Doc.DocsData("docID")
        Else
            doctorID = backupdoctorID
        End If
        Console.WriteLine("doctorID : " & doctorID)
    End Sub

    Private Sub btnCheck_medicine_Click(sender As Object, e As EventArgs) Handles btnCheck_medicine.Click
        Dim backupMedID = medicineID
        popup_medicine.ShowDialog()

        If popup_medicine.MedicinePressData("id") IsNot Nothing Then
            medicineID = popup_medicine.MedicinePressData("id")
        Else
            medicineID = backupMedID
        End If
        Console.WriteLine("medicineID : " & medicineID)
    End Sub

    Private Sub Edit_Presscript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.PW_Prescripts' table. You can move, or remove it, as needed.
        Me.PW_PrescriptsTableAdapter.Fill(Me.WellmeadowsDataSet.PW_Prescripts)
        System.Console.WriteLine("pwID : " & pwID)
        System.Console.WriteLine("cnID : " & cnID)
        System.Console.WriteLine("doctorID : " & doctorID)
        System.Console.WriteLine("medicineID : " & medicineID)
    End Sub

    Private Sub PW_PrescriptsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PW_PrescriptsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub
End Class