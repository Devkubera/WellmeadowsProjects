Public Class popup_staff
	Private Sub popup_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' making sql string
		Dim sqlCode = "SELECT 
	            staffID AS 'รหัสเจ้าหน้าที่',
	            CONCAT(firstName, ' ', lastName) AS 'ชื่อ - สกุล',
                gender AS 'เพศ',
	            address AS 'ที่อยู่',
	            tel AS 'เบอร์โทรศัพท์',
	            dob  AS 'วันเกิด',
	            nin AS 'หมายเลขประกันสังคม',
	            position AS 'ตำแหน่ง',
	            salary AS 'เงินเดือน',
	            salaryScale AS 'ฐานเงินเดือน',
	            hoursWeek AS 'ชั่วโมงทำงานต่อสัปดาห์',
	            contactType AS 'สัญญาจ้าง',
	            paidType AS 'การจ่ายเงินเดือน'
                FROM STAFFS;"
		' query staffs
		Dim dt As DataTable = StaffForm.sqlQueryDataTable(sqlCode)

		' show staffs in datagridview
		staff_table.DataSource = dt

		' making staff_table not selected any field when start
		staff_table.ClearSelection()

	End Sub

	Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
		' make sure that user select data in staff_table
		If staff_table.CurrentRow IsNot Nothing Then
			' assign staffID and staffName to Add_Staff_ExpForm1
			Add_Staff_ExpForm1.Staff_number.Text = staff_table.SelectedRows(0).Cells(0).Value.ToString
			Add_Staff_ExpForm1.Staff_name.Text = staff_table.SelectedRows(0).Cells(1).Value.ToString
			' close this form
			Me.Close()
		End If
	End Sub
End Class