Imports System.Data.SqlClient

Public Class popup_PatientWard
    Public pwData As New Dictionary(Of String, String)
    Public sqlConn As String = "Data Source=BOB1EE\PROJECTSQL;Initial Catalog=Wellmeadows;Integrated Security=True"
    Private Sub popup_PatientWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(sqlConn) ' แทนที่ Your_Connection_String ด้วยข้อมูลการเชื่อมต่อฐานข้อมูลของคุณ
            connection.Open()

            ' คำสั่ง SQL สำหรับรวมข้อมูลจากตาราง Doctors และ Staffs
            Dim sql As String = "SELECT pw.pwID, pw.cnID, pw.patientID,  p.firstName, p.lastName " &
                            "FROM  Patient_Wards pw " &
                            "INNER Join Patients p ON pw.patientID = p.patientID;"

            ' สร้าง SqlDataAdapter เพื่อดึงข้อมูล
            Dim adapter As New SqlDataAdapter(sql, connection)

            ' สร้าง DataTable เพื่อเก็บข้อมูล
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' แสดงข้อมูลบน DataGridView
            pwDG.DataSource = dataTable

            ' ปิดการเชื่อมต่อ
            connection.Close()

        End Using


        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Wards' table. You can move, or remove it, as needed.
        Me.Patient_WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Wards)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If pwDG.CurrentRow IsNot Nothing Then
            pwData("pwID") = pwDG.SelectedRows(0).Cells(0).Value.ToString
            pwData("cnID") = pwDG.SelectedRows(0).Cells(1).Value.ToString
            pwData("patientID") = pwDG.SelectedRows(0).Cells(2).Value.ToString
            pwData("firstname") = pwDG.SelectedRows(0).Cells(3).Value.ToString
            pwData("lastname") = pwDG.SelectedRows(0).Cells(4).Value.ToString

            System.Console.WriteLine(pwData("pwID"))
            System.Console.WriteLine(pwData("cnID"))
            System.Console.WriteLine(pwData("patientID"))
            System.Console.WriteLine(pwData("firstname"))
            System.Console.WriteLine(pwData("lastname"))

            Add_Presscipt.pwID = pwData("pwID")
            Add_Presscipt.cnID = pwData("cnID")
            Add_Presscipt.pt_id.Text = pwData("patientID")
            Add_Presscipt.pt_firstName.Text = pwData("firstname")
            Add_Presscipt.pt_lastName.Text = pwData("lastname")


            Edit_Presscript.pwID = pwData("pwID")
            Edit_Presscript.cnID = pwData("cnID")
            Edit_Presscript.pt_id.Text = pwData("patientID")
            Edit_Presscript.pt_firstName.Text = pwData("firstname")
            Edit_Presscript.pt_lastName.Text = pwData("lastname")

            Add_Presscipt.SetDisabledPW()
            Me.Close()
        End If
    End Sub
End Class