Public Class InPatient
    Public dataBackup As DataTable
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_InPatient.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' check sekected row in datagridview name viewInPatient
        If ViewInPa.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim pwID As String = ViewInPa.CurrentRow.Cells(0).Value.ToString()
        Dim patientID As String = ViewInPa.CurrentRow.Cells(1).Value.ToString()
        Dim wardID As String = ViewInPa.CurrentRow.Cells(3).Value.ToString()
        Dim on_wating_date As String = ViewInPa.CurrentRow.Cells(4).Value.ToString()
        Dim bedID As String = ViewInPa.CurrentRow.Cells(5).Value.ToString()
        Dim date_place As String = ViewInPa.CurrentRow.Cells(6).Value.ToString()
        Dim date_expected As String = ViewInPa.CurrentRow.Cells(7).Value.ToString()

        ' assign to edit in patient form
        Edit_InPatient.ip_id.Text = patientID
        Edit_InPatient.ippw_id.Text = pwID
        Edit_InPatient.ipw_id.Text = wardID
        Edit_InPatient.ip_date.Value = date_place
        Edit_InPatient.ipb_id.Text = bedID
        Edit_InPatient.ip_expect.Text = date_expected

        Edit_InPatient.Show()
    End Sub

    Public Sub InPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' get data in in_patient table and display in datagridview name viewInPatient
        Dim sqlCode = "SELECT
	        inp.pwID AS 'หมายเลขการรักษา',
            P.patientID AS 'หมายเลขผู้ป่วย',
	        p.firstName + ' ' + p.lastName AS 'ชื่อผู้ป่วย',
	        inp.wardID AS 'หมายเลขวอร์ด',
	        inp.on_wating_date AS 'วันที่เข้ารอเตียง',
	        inp.bedID AS 'หมายเลขเตียง',
	        inp.date_place AS 'วันที่ได้รับเตียง',
            inp.date_expected AS 'จำนวนวันที่จะอยู่',
	        inp.date_leave AS 'วันที่ออกจากวอร์ด',
            inp.patient_status AS 'สถานะออกจากวอร์ด'
        FROM In_Patients AS INP
        INNER JOIN Patient_Wards AS PW ON (INP.pwID = PW.pwID)
        INNER JOIN Patients AS P ON (PW.patientID = P.patientID)
        WHERE inp.isGetBed = 1;"

        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)

        ViewInPa.DataSource = dataTable

        ' frozen first and last column
        ViewInPa.Columns(0).Frozen = True

        dataBackup = dataTable
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text() IsNot Nothing Or txtSearch.Text() <> "" Then
            ' search data in datagridview name viewInPatient with ชื่อผู้ป่วย and หมายเลขวอร์ด
            Dim searchTxt = txtSearch.Text.Trim()
            Dim sqlCode = $"SELECT
	        inp.pwID AS 'หมายเลขการรักษา',
            P.patientID AS 'หมายเลขผู้ป่วย',
	        p.firstName + ' ' + p.lastName AS 'ชื่อผู้ป่วย',
	        inp.wardID AS 'หมายเลขวอร์ด',
	        inp.on_wating_date AS 'วันที่เข้ารอเตียง',
	        inp.bedID AS 'หมายเลขเตียง',
	        inp.date_place AS 'วันที่ได้รับเตียง',
            inp.date_expected AS 'จำนวนวันที่จะอยู่',
	        inp.date_leave AS 'วันที่ออกจากวอร์ด',
            inp.patient_status AS 'สถานะออกจากวอร์ด'
        FROM In_Patients AS INP
        INNER JOIN Patient_Wards AS PW ON (INP.pwID = PW.pwID)
        INNER JOIN Patients AS P ON (PW.patientID = P.patientID)
        WHERE inp.isGetBed = 1
        AND 
            ( p.firstName LIKE '%{searchTxt}%' 
            OR p.lastName LIKE '%{searchTxt}%' 
            OR inp.wardID LIKE '%{searchTxt}%');"

            ' get data from sql query
            Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)

            'display on data grid view
            ViewInPa.DataSource = dataTable
        Else
            ViewInPa.DataSource = dataBackup
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' check if data grid view selected row
        If ViewInPa.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' get pwID from selected row
        Dim pwID As String = ViewInPa.CurrentRow.Cells(0).Value.ToString()

        ' delete data in in_patient table
        Dim sqlCode = $"DELETE FROM In_Patients WHERE pwID = '{pwID}';"
        StaffForm.sqlExecuteNonQuery(sqlCode)

        'Show messagebox delete success
        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' reload data in data grid view
        InPatient_Load(sender, e)
    End Sub

    Private Sub btnUp_Out_ward_Click(sender As Object, e As EventArgs) Handles btnUp_Out_ward.Click
        ' check if data grid view selected row
        If ViewInPa.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการอัพเดทสถานะของผู้ป่วย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' get pwID from selected row
        Dim pwID As String = ViewInPa.CurrentRow.Cells(0).Value.ToString()

        ' update patient status where pwID = pwID
        Dim sqlCode = $"UPDATE In_Patients SET patient_status = 1 WHERE pwID = '{pwID}';"
        StaffForm.sqlExecuteNonQuery(sqlCode)

        'Show messagebox update success
        MessageBox.Show("อัพเดทสถานะของผู้ป่วยเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' reload data in data grid view
        InPatient_Load(sender, e)
    End Sub
End Class