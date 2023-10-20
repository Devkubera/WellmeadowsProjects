Public Class Patient_Visit
    Public backupDataTables As DataTable
    ' set sql stirng to re-use
    Public sqlQueryPatientVisit As String = "SELECT 
	        visitID, 
	        PV.patientID AS หมายเลขผู้ป่วย,
	        (P.firstName + ' ' + P.lastName) AS ชื่อผู้ป่วย,
	        PV.staffID AS หมายเลขพนักงาน,
	        PV.doctorID AS หมายเลขแพทย์, 
            (S.firstName + ' ' + S.lastName) AS ชื่อแพทย์,
	        wardID AS หมายเลขวอร์ด, 
	        app_date AS เวลาที่เข้าพบแพทย์, 
	        app_type AS วิธีการพบแพทย์, 
	        PV.updateAt AS แก้ไขล่าสุด, 
	        PV.status AS สถานะ
        FROM Patient_Visits AS PV
        INNER JOIN Patients AS P ON (PV.patientID = P.patientID)
        INNER JOIN Doctors AS D ON (PV.doctorID = D.doctorID)
        INNER JOIN Staffs AS S ON (D.staffID = S.staffID)
        WHERE status IS NOT NULL AND status = 'Active'"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_PatientVisit.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' set visitID to edit visit patient form
        Edit_VisitPatient.visitID = ViewVisit.SelectedRows(0).Cells(0).Value.ToString
        ' set all field to edit visit patient form
        Edit_VisitPatient.visit_p_ID.Text = ViewVisit.SelectedRows(0).Cells(1).Value.ToString
        Edit_VisitPatient.visit_p_name.Text = ViewVisit.SelectedRows(0).Cells(2).Value.ToString
        Edit_VisitPatient.visit_d_ID.Text = ViewVisit.SelectedRows(0).Cells(4).Value.ToString
        Edit_VisitPatient.visit_d_name.Text = ViewVisit.SelectedRows(0).Cells(5).Value.ToString
        Edit_VisitPatient.visit_w_Id.Text = ViewVisit.SelectedRows(0).Cells(6).Value.ToString
        Edit_VisitPatient.visit_date.Text = ViewVisit.SelectedRows(0).Cells(7).Value.ToString
        Edit_VisitPatient.visit_type.Text = ViewVisit.SelectedRows(0).Cells(8).Value.ToString

        Edit_VisitPatient.Show()

    End Sub

    Public Sub Patient_Visit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Visits' table. You can move, or remove it, as needed.
        Me.Patient_VisitsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Visits)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Wards' table. You can move, or remove it, as needed.
        Me.Patient_WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Wards)

        ' sql query patient visit
        Dim sqlCode = sqlQueryPatientVisit

        ' fill data grid ViewVisit
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)

        ' backup data table
        backupDataTables = dataTable

        ' set value to data grid view
        ViewVisit.DataSource = dataTable

        ' frozen first column and last column
        ViewVisit.Columns(0).Frozen = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch Is Nothing Then
            ' if search box is empty
            ViewVisit.DataSource = backupDataTables
        Else
            ' sql query patient visit
            Dim sqlCode = $"SELECT 
	        visitID, 
	        PV.patientID AS หมายเลขผู้ป่วย,
	        (P.firstName + ' ' + P.lastName) AS ชื่อผู้ป่วย,
	        PV.staffID AS หมายเลขพนักงาน, 
	        doctorID AS หมายเลขแพทย์, 
	        wardID AS หมายเลขวอร์ด, 
	        app_date AS เวลาที่เข้าพบแพทย์, 
	        app_type AS วิธีการพบแพทย์, 
	        updateAt AS แก้ไขล่าสุด, 
	        PV.status AS สถานะ
        FROM Patient_Visits AS PV
        INNER JOIN Patients AS P ON (PV.patientID = P.patientID)
        WHERE status IS NOT NULL AND status = 'Active' AND (p.firstName LIKE '%{txtSearch.Text}%' OR p.lastName LIKE '%{txtSearch.Text}%');"

            ' fill data grid ViewVisit
            Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
            ViewVisit.DataSource = dataTable
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' check data grid view selected is not empty
        If ViewVisit.SelectedRows.Count > 0 Then
            ' get selected row index
            Dim index As Integer = ViewVisit.SelectedRows(0).Index
            ' get selected row id
            Dim visitID As String = ViewVisit.SelectedRows(0).Cells(0).Value.ToString
            ' get selected row patient id
            Dim patientID As String = ViewVisit.SelectedRows(0).Cells(1).Value.ToString
            ' get selected row doctor id
            Dim doctorID As String = ViewVisit.SelectedRows(0).Cells(4).Value.ToString
            ' get selected row ward id
            Dim wardID As String = ViewVisit.SelectedRows(0).Cells(5).Value.ToString


            ' sql query to update Patient_Visits status to drop - not use
            Dim sqlCode3 = $"UPDATE Patient_Visits SET status = 'Drop' WHERE visitID = '{visitID}';"

            ' execute sql query
            StaffForm.sqlExecuteNonQuery(sqlCode3)

            ' remove selected row from data grid view
            ViewVisit.Rows.RemoveAt(index)

            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
        End If
    End Sub
End Class