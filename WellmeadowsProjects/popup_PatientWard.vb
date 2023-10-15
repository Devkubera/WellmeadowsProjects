Imports System.Data.SqlClient

Public Class popup_PatientWard
    Public pwData As New Dictionary(Of String, String)
    Public sqlConn As String = "Data Source=Zero\DATABASE66;Initial Catalog=Wellmeadows;Integrated Security=True"
    Private Sub popup_PatientWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Patient_WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Wards)

        ' check pwIDList from WaitingListForm is empty or not
        If WaitingListForm.pwIDList.Count = 0 Then
            ' if empty, query all data
            queryAllData()
        Else
            ' if not empty, query data that not in pwIDList
            queryDataNotInList()
        End If

    End Sub

    Private Sub queryDataNotInList()
        ' create sql string to query patients_ward data and join with patients table to get first name and last name where pwID not in pwIDList
        Dim sqlCode = "SELECT
	        pw.pwID AS 'หมายเลขการรักษา',
	        pw.cnID AS 'หมายเลขแพทย์',
	        pw.patientID AS 'หมายเลขผู้ป่วย',
	        p.firstName AS 'ชื่อผู้ป่วย',
            p.lastName AS 'นามสกุลผู้ป่วย',
            pw.visitID AS 'หมายเลขประวัติ',
	        pw.doctorID AS 'รหัสแพทย์',
	        pw.wardID AS 'รหัสวอร์ด',
	        pw.on_ward_date AS 'วันที่ทำการรักษา'
        FROM Patient_Wards AS pw
        INNER JOIN Patients AS p ON (pw.patientID = p.patientID)
        WHERE pw.pwID NOT IN ('" & String.Join("','", WaitingListForm.pwIDList.ToArray) & "')"
        ' query data from database
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' add data to the data grid view
        pwDG.DataSource = dataTable

    End Sub

    Private Sub queryAllData()
        ' create sql string to query patients_ward data and join with patients table to get first name and last name
        Dim sqlCode = "SELECT
	        pw.pwID AS 'หมายเลขการรักษา',
	        pw.cnID AS 'หมายเลขแพทย์',
	        pw.patientID AS 'หมายเลขผู้ป่วย',
	        p.firstName AS 'ชื่อผู้ป่วย',
            p.lastName AS 'นามสกุลผู้ป่วย',
            pw.visitID AS 'หมายเลขประวัติ',
	        pw.doctorID AS 'รหัสแพทย์',
	        pw.wardID AS 'รหัสวอร์ด',
	        pw.on_ward_date AS 'วันที่ทำการรักษา'
        FROM Patient_Wards AS pw
        INNER JOIN Patients AS p ON (pw.patientID = p.patientID)"
        ' query data from database
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' add data to the data grid view
        pwDG.DataSource = dataTable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If pwDG.CurrentRow IsNot Nothing Then
            pwData("pwID") = pwDG.SelectedRows(0).Cells(0).Value.ToString
            pwData("cnID") = pwDG.SelectedRows(0).Cells(1).Value.ToString
            pwData("patientID") = pwDG.SelectedRows(0).Cells(2).Value.ToString
            pwData("firstname") = pwDG.SelectedRows(0).Cells(3).Value.ToString
            pwData("lastname") = pwDG.SelectedRows(0).Cells(4).Value.ToString
            pwData("wardID") = pwDG.SelectedRows(0).Cells(7).Value.ToString
            pwData("dates") = pwDG.SelectedRows(0).Cells(8).Value.ToString

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

            ' add data to add_waitingList page
            Add_WaitingListForm.pwID_textbox.Text = pwData("pwID")
            Add_WaitingListForm.patientId.Text = pwData("patientID")
            Add_WaitingListForm.wardId.Text = pwData("wardID")
            Add_WaitingListForm.dateWaiting.Text = pwData("dates")

            Add_Presscipt.SetDisabledPW()
            Me.Close()
        End If
    End Sub
End Class