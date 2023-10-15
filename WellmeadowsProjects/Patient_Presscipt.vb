﻿Imports System.Data.SqlClient
Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Patient_Presscipt
    Public psData As New Dictionary(Of String, String)
    Public sqlConn As String = "Data Source=Zero\DATABASE66;Initial Catalog=Wellmeadows;Integrated Security=True"


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim selected As New List(Of String)
        If ViewPress.CurrentRow IsNot Nothing Then
            psData("ID") = ViewPress.SelectedRows(0).Cells(0).Value.ToString
            psData("pwID") = ViewPress.SelectedRows(0).Cells(1).Value.ToString
            psData("medID") = ViewPress.SelectedRows(0).Cells(2).Value.ToString
            psData("medName") = ViewPress.SelectedRows(0).Cells(3).Value.ToString
            psData("pID") = ViewPress.SelectedRows(0).Cells(4).Value.ToString
            psData("pName") = ViewPress.SelectedRows(0).Cells(5).Value.ToString
            psData("pLastName") = ViewPress.SelectedRows(0).Cells(6).Value.ToString
            psData("dID") = ViewPress.SelectedRows(0).Cells(7).Value.ToString
            psData("dName") = ViewPress.SelectedRows(0).Cells(8).Value.ToString
            psData("dLastName") = ViewPress.SelectedRows(0).Cells(9).Value.ToString
            psData("cnID") = ViewPress.SelectedRows(0).Cells(10).Value.ToString
            psData("cnName") = ViewPress.SelectedRows(0).Cells(11).Value.ToString
            psData("cnLastName") = ViewPress.SelectedRows(0).Cells(12).Value.ToString
            psData("method") = ViewPress.SelectedRows(0).Cells(13).Value.ToString
            psData("dosage") = ViewPress.SelectedRows(0).Cells(14).Value.ToString
            psData("startDate") = ViewPress.SelectedRows(0).Cells(15).Value.ToString
            psData("endDate") = ViewPress.SelectedRows(0).Cells(16).Value.ToString
            psData("desc") = ViewPress.SelectedRows(0).Cells(17).Value.ToString


            Edit_Presscript.ID = psData("ID")
            Edit_Presscript.m_startDate.Value = psData("startDate")
            Edit_Presscript.m_endDate.Value = psData("endDate")
            Edit_Presscript.m_dosage.Text = psData("dosage")
            Edit_Presscript.m_desc.Text = psData("desc")
            Edit_Presscript.m_method.Text = psData("method")

            Edit_Presscript.pwID = psData("pwID")
            Edit_Presscript.m_id.Text = psData("medID")
            Edit_Presscript.m_name.Text = psData("medName")

            Edit_Presscript.pt_id.Text = psData("pID")
            Edit_Presscript.pt_firstName.Text = psData("pName")
            Edit_Presscript.pt_lastName.Text = psData("pLastName")

            Edit_Presscript.doctorID = psData("dID")
            Edit_Presscript.doc_firstname.Text = psData("dName")
            Edit_Presscript.doc_lastname.Text = psData("dLastName")
            Edit_Presscript.cnID = psData("cnID")

        End If

        Edit_Presscript.Show()
    End Sub

    Public Sub Patient_Presscipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(sqlConn) ' แทนที่ Your_Connection_String ด้วยข้อมูลการเชื่อมต่อฐานข้อมูลของคุณ
            connection.Open()

            ' คำสั่ง SQL สำหรับรวมข้อมูลจากตาราง Doctors และ Staffs
            Dim sql As String = "SELECT
                    P.ID AS หมายเลขใบจ่ายยา,
                    PW.pwID As หมายเลขผู้ป่วยในวอร์ด,
	                M.mmID As หมายเลขยา,
                    M.name AS ชื่อยา,
	                Pt.ID As หมายเลขผู้ป่วย,
                    Pt.firstName AS ชื่อผู้ป่วย, 
	                Pt.lastName AS นามสกุลผู้ป่วย,
	                D.doctorID As หมายเลขแพทย์,
                    Dr.firstName AS ชื่อแพทย์,
	                Dr.lastName AS นามสกุลแพทย์,
	                CN.cnID As หมายเลขพยาบาล,
                    Dr.firstName AS ชื่อพยาบาล,
	                Dr.lastName AS นามสกุลพยาบาล,
	                M.method As วิธีการให้ยา,
                    P.dosage AS ปริมาณ,
                    P.startDate AS วันที่เริ่มให้ยา,
                    P.endDate AS วันที่สิ้นสุดการให้ยา,
                    P.descript AS รายละเอียด,
                    P.createAT AS วันที่สร้างข้อมูล
                    FROM PW_Prescripts AS P
                    INNER JOIN Med_Medicines AS M ON P.mmID = M.mmID
                    INNER JOIN Patient_Wards AS PW ON P.pwID = PW.pwID
                    INNER JOIN Patients AS Pt ON PW.patientID = Pt.patientID
                    INNER JOIN Doctors AS D ON P.doctorID = D.doctorID
                    INNER JOIN Staffs AS Dr ON D.staffID = Dr.staffID
                    INNER JOIN ChargeNurses AS CN ON PW.cnID = CN.cnID;"

            ' สร้าง SqlDataAdapter เพื่อดึงข้อมูล
            Dim adapter As New SqlDataAdapter(sql, connection)

            ' สร้าง DataTable เพื่อเก็บข้อมูล
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' แสดงข้อมูลบน DataGridView
            ViewPress.DataSource = dataTable

            ' ปิดการเชื่อมต่อ
            connection.Close()

        End Using


        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Med_Medicines' table. You can move, or remove it, as needed.
        Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.PW_Prescripts' table. You can move, or remove it, as needed.
        Me.PW_PrescriptsTableAdapter.Fill(Me.WellmeadowsDataSet.PW_Prescripts)




    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ViewPress.CurrentRow IsNot Nothing Then
            Dim ID = ViewPress.SelectedRows(0).Cells(0).Value.ToString
            Console.WriteLine(ID)
            ViewPress.Rows.RemoveAt(ViewPress.CurrentRow.Index)
            PW_PrescriptsTableAdapter.DeletePresscriptBycreateAt(ID)
        End If
    End Sub



    Public Function sqlQueryDataTable(sqlCode As String) As DataTable
        ' สร้าง DataTable เพื่อเก็บข้อมูล
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(sqlConn)
            connection.Open()
            Try
                Dim sql As String = sqlCode

                ' สร้าง SqlDataAdapter เพื่อดึงข้อมูล
                Dim adapter As New SqlDataAdapter(sql, connection)

                adapter.Fill(dataTable)

            Catch ex As Exception
                Console.WriteLine("Error to fetch staff exp : " & ex.Message)
            End Try
            connection.Close()
        End Using

        If dataTable.Rows.Count > 0 Then
            ' Return dataTable to using in Datasource = dataTable
            Return dataTable
        End If

    End Function
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Dim searchText As String = txtSearch.Text.Trim()
        'If String.IsNullOrEmpty(searchText) Then
        '    PWPrescriptsBindingSource.RemoveFilter()
        'Else
        '    PWPrescriptsBindingSource.Filter = $"CONVERT(ID, System.String) LIKE '*{searchText}*' "
        'End If
        Dim searchValue As String = txtSearch.Text
        Dim sqlMsg = $"SELECT
                    P.ID AS หมายเลขใบจ่ายยา,
                    PW.pwID As หมายเลขผู้ป่วยในวอร์ด,
	                M.mmID As หมายเลขยา,
                    M.name AS ชื่อยา,
	                Pt.ID As หมายเลขผู้ป่วย,
                    Pt.firstName AS ชื่อผู้ป่วย, 
	                Pt.lastName AS นามสกุลผู้ป่วย,
	                D.doctorID As หมายเลขแพทย์,
                    Dr.firstName AS ชื่อแพทย์,
	                Dr.lastName AS นามสกุลแพทย์,
	                CN.cnID As หมายเลขพยาบาล,
                    Dr.firstName AS ชื่อพยาบาล,
	                Dr.lastName AS นามสกุลพยาบาล,
	                M.method As วิธีการให้ยา,
                    P.dosage AS ปริมาณ,
                    P.startDate AS วันที่เริ่มให้ยา,
                    P.endDate AS วันที่สิ้นสุดการให้ยา,
                    P.descript AS รายละเอียด,
                    P.createAT AS วันที่สร้างข้อมูล
                    FROM PW_Prescripts AS P
                    INNER JOIN Med_Medicines AS M ON P.mmID = M.mmID
                    INNER JOIN Patient_Wards AS PW ON P.pwID = PW.pwID
                    INNER JOIN Patients AS Pt ON PW.patientID = Pt.patientID
                    INNER JOIN Doctors AS D ON P.doctorID = D.doctorID
                    INNER JOIN Staffs AS Dr ON D.staffID = Dr.staffID
                    INNER JOIN ChargeNurses AS CN ON PW.cnID = CN.cnID
                    WHERE Pt.firstName LIKE '%{searchValue}%' OR Pt.lastName LIKE '%{searchValue}%';"

        Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
        ViewPress.DataSource = dataTable
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Presscipt.Show()
    End Sub
End Class