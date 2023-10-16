Imports System.Data.SqlClient

Public Class pop_Doc

    Public DocsData As New Dictionary(Of String, String)
    Public sqlConn As String = "Data Source=Zero\DATABASE66;Initial Catalog=Wellmeadows;Integrated Security=True"

    Private Sub pop_Doc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sqlCode = "SELECT D.doctorID AS 'หมายเลขแพทย์', S.firstName AS 'ชื่อ', S.lastName AS 'สกุล'
                            FROM Doctors D
                            INNER JOIN Staffs S ON (D.staffID = S.staffID)
                            WHERE D.isActive = 'YES'"
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        docDG.DataSource = dataTable

        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Doctors' table. You can move, or remove it, as needed.
        Me.DoctorsTableAdapter.Fill(Me.WellmeadowsDataSet.Doctors)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)

        DocsData("id") = Nothing

        Console.WriteLine(MainForm.staffID)
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

            Add_PatientVisit.visit_d_ID.Text = DocsData("docID")
            Add_PatientVisit.visit_d_name.Text = DocsData("firstname") + " " + DocsData("lastname")


            Edit_VisitPatient.visit_d_ID.Text = DocsData("docID")
            Edit_VisitPatient.visit_d_name.Text = DocsData("firstname") + " " + DocsData("lastname")

            Add_PateintToWardForm.doctorID.Text = DocsData("docID")

            Edit_PateintToWardForm.doctorID.Text = DocsData("docID")
            Edit_PateintToWardForm.doctorName.Text = DocsData("firstname") + " " + DocsData("lastname")

            Add_Presscipt.SetDisabledDoc()
            Me.Close()
        End If

    End Sub

End Class