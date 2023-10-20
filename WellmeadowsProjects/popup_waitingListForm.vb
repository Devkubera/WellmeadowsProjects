Public Class popup_waitingListForm
    Public backUpDataTable As DataTable
    Private Sub popup_waitingListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' create sql string to query waiting list data
        Dim sqlCode = "SELECT
	        inp.pwID,
            PW.patientID AS 'หมายเลขผู้ป่วย',
	        p.firstName + ' ' + p.lastName AS 'ชื่อผู้ป่วย',
            inp.wardID AS 'หมายเลขวอร์ด',
	        inp.on_wating_date AS 'วันที่เข้ารอเตียง',
	        isGetBed AS 'สถานะรอเตียง'
        FROM In_Patients AS INP
        INNER JOIN Patient_Wards AS PW ON (INP.pwID = PW.pwID)
        INNER JOIN Patients AS P ON (PW.patientID = P.patientID)
        WHERE inp.isGetBed = 0"

        ' query data from database
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' add data to the data grid view
        waitingListTable.DataSource = dataTable

        ' back up data table
        backUpDataTable = dataTable

        ' check count record in data table
        If waitingListTable.Rows.Count <= 0 Then
            ' if no record found
            MessageBox.Show("ไม่พบข้อมูลผู้ป่วยที่รอเตียง ณ ขณะนี้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Return
        End If

        ' frozen first column
        waitingListTable.Columns(0).Frozen = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' check if selected row is empty
        If waitingListTable.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' get data from each row from data grid row

            ' send it to add-patient-form
            Add_InPatient.ippw_id.Text = waitingListTable.SelectedRows(0).Cells(0).Value
            Add_InPatient.ip_id.Text = waitingListTable.SelectedRows(0).Cells(1).Value
            Add_InPatient.ipw_id.Text = waitingListTable.SelectedRows(0).Cells(3).Value
            Add_InPatient.ip_date.Text = waitingListTable.SelectedRows(0).Cells(4).Value

            ' close this form
            Me.Close()

        End If
    End Sub
End Class