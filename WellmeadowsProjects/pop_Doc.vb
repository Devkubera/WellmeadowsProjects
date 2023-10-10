Imports System.Data.SqlClient

Public Class pop_Doc

    Public DocsData As New Dictionary(Of String, String)

    Private Sub pop_Doc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection("Data Source=BOB1EE\SQLEXPRESS;Initial Catalog=Wellmeadows;Integrated Security=True") ' แทนที่ Your_Connection_String ด้วยข้อมูลการเชื่อมต่อฐานข้อมูลของคุณ
            connection.Open()

            ' คำสั่ง SQL สำหรับรวมข้อมูลจากตาราง Doctors และ Staffs
            Dim sql As String = "SELECT D.doctorID,D.staffID, S.firstName, S.lastName " &
                            "FROM Doctors D " &
                            "INNER JOIN Staffs S ON D.staffID = S.staffID"

            ' สร้าง SqlDataAdapter เพื่อดึงข้อมูล
            Dim adapter As New SqlDataAdapter(sql, connection)

            ' สร้าง DataTable เพื่อเก็บข้อมูล
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' แสดงข้อมูลบน DataGridView
            docDG.DataSource = dataTable

            ' ปิดการเชื่อมต่อ
            connection.Close()

        End Using
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Doctors' table. You can move, or remove it, as needed.
        Me.DoctorsTableAdapter.Fill(Me.WellmeadowsDataSet.Doctors)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)

        DocsData("id") = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim selected As New List(Of String)
        If docDG.CurrentRow IsNot Nothing Then
            DocsData("docID") = docDG.SelectedRows(0).Cells(0).Value.ToString
            'DocsData("staffID") = docDG.SelectedRows(0).Cells(1).Value.ToString
            DocsData("firstname") = docDG.SelectedRows(0).Cells(1).Value.ToString
            DocsData("lastname") = docDG.SelectedRows(0).Cells(2).Value.ToString
            'DocsData("1name") = docDG.SelectedRows(0).Cells(4).Value.ToString

            System.Console.WriteLine(DocsData("docID"))
            System.Console.WriteLine(DocsData("firstname"))
            System.Console.WriteLine(DocsData("lastname"))
            'System.Console.WriteLine(DocsData("1name"))



            Add_Presscipt.doctorID = DocsData("docID")
            Add_Presscipt.doc_firstname.Text = DocsData("firstname")
            Add_Presscipt.doc_lastname.Text = DocsData("lastname")

            Edit_Presscript.doctorID = DocsData("docID")
            Edit_Presscript.doc_firstname.Text = DocsData("firstname")
            Edit_Presscript.doc_lastname.Text = DocsData("lastname")


            Add_Presscipt.SetDisabledDoc()
            Me.Close()
        End If

    End Sub

End Class