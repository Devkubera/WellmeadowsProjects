Imports System.Net

Public Class Add_Presscipt
    Public pwID As String = ""
    Public cnID As String = ""
    Public doctorID As String = ""
    Public medicineID As String = ""

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(pt_firstName.Text) Then
            pt_firstName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_lastName.Text) Then
            pt_lastName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_id.Text) Then
            pt_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_id.Text) Then
            m_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_name.Text) Then
            m_name.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_dosage.Text) Then
            m_dosage.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_method.Text) Then
            m_method.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_startDate.Text) Then
            m_startDate.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_endDate.Text) Then
            m_endDate.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_desc.Text) Then
            m_desc.Text = String.Empty
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If (pwID = "") Then
            System.Console.WriteLine("If Case from pwID " & pwID)
            MessageBox.Show("กรุณากรอกข้อมูลผู้ป่วย", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim Pid = pt_id.Text
            Dim Pfirstname = pt_firstName.Text
            Dim Plastname = pt_lastName.Text
            'Console.WriteLine(Pid & " Pid")
            'Console.WriteLine(Pfirstname & " Pfirstname")
            'Console.WriteLine(Plastname & " Plastname")
            Patient_WardsTableAdapter.SelectPwTOPresscript()
            'pwID = PatientsTableAdapter.getLastPatientID()
        End If

            If (doctorID = "") Then
                System.Console.WriteLine("If Case from doctorID " & doctorID)
                MessageBox.Show("กรุณากรอกข้อมูลหมอ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                Dim Docfitstname = doc_firstname.Text
                Dim Doclastname = doc_lastname.Text
            'Console.WriteLine(Docfitstname & " Docfitstname")
            'Console.WriteLine(Doclastname & " Doclastname")
            DoctorsTableAdapter.SelectDortor()
            doctorID = DoctorsTableAdapter.getLastDocID()
        End If

            If (medicineID = "") Then
                System.Console.WriteLine("If Case from medicineID " & medicineID)
                MessageBox.Show("กรุณากรอกข้อมูลยา", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                Dim Mid = m_id.Text
                Dim Mname = m_name.Text
                Dim Mmethod = m_method.Text
            'Console.WriteLine(Mid & " Mid")
            'Console.WriteLine(Mname & " Mname")
            'Console.WriteLine(Mmethod & " Mmethod")
            Med_MedicinesTableAdapter.SelectMedicinePresscript()
            'medicineID = Med_MedicinesTableAdapter.getLastmmID()
        End If

        'm_startDate.Format = DateTimePickerFormat.Custom
        'm_startDate.CustomFormat = "dd/MM/yyyy"
        'm_endDate.Format = DateTimePickerFormat.Custom
        'm_endDate.CustomFormat = "dd/MM/yyyy"

        Dim MstartDate = m_startDate.Text
        Dim MendDate = m_endDate.Text
        Dim Mdosage = m_dosage.Text
        Dim Mdesc = m_desc.Text

        Me.PW_PrescriptsTableAdapter.InsertPresscript(medicineID, pwID, doctorID, MainForm.cnID, Mdosage, MstartDate, MendDate, Mdesc)

        Me.PW_PrescriptsTableAdapter.Fill(Me.WellmeadowsDataSet.PW_Prescripts)
        MessageBox.Show("ข้อมูลได้ถูกเพิ่มแล้ว", "บันทึกข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' refresh patient presscript data
        Patient_Presscipt.Patient_Presscipt_Load(sender, e)

        Me.Close()

    End Sub

    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub Add_Presscipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Wards' table. You can move, or remove it, as needed.
        Me.Patient_WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Wards)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Doctors' table. You can move, or remove it, as needed.
        Me.DoctorsTableAdapter.Fill(Me.WellmeadowsDataSet.Doctors)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.PW_Prescripts' table. You can move, or remove it, as needed.
        Me.PW_PrescriptsTableAdapter.Fill(Me.WellmeadowsDataSet.PW_Prescripts)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Med_Medicines' table. You can move, or remove it, as needed.
        Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)

    End Sub

    Private Sub btnCheck_patient_Click(sender As Object, e As EventArgs) Handles btnCheck_patient.Click
        popup_PatientWard.ShowDialog()
    End Sub

    Public Sub SetDisabledPW()
        pt_id.Enabled = False
        pt_firstName.Enabled = False
        pt_lastName.Enabled = False
    End Sub

    Private Sub btnCheck_doc_Click(sender As Object, e As EventArgs) Handles btnCheck_doc.Click
        pop_Doc.ShowDialog()
    End Sub

    Public Sub SetDisabledDoc()

        doc_firstname.Enabled = False
        doc_lastname.Enabled = False
    End Sub

    Private Sub btnCheck_medicine_Click(sender As Object, e As EventArgs) Handles btnCheck_medicine.Click
        popup_medicine.ShowDialog()
    End Sub

    Public Sub SetDisabledMedicine()
        m_id.Enabled = False
        m_name.Enabled = False
        m_method.Enabled = False
    End Sub

End Class