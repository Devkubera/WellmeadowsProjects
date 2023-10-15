Public Class WaitingListForm
    Public backUpDataTable As DataTable
    Public pwIDList As New List(Of String)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_WaitingListForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' check if data grid view that row selected is not empty
        If waitingListTable.SelectedRows.Count = 0 Then
            ' if empty, show message box
            MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไข", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' get data all row in selected row to Edit_waitingListForm
        Edit_WaitingListForm.pwID_textbox.Text = waitingListTable.SelectedRows(0).Cells(0).Value
        Edit_WaitingListForm.patientId.Text = waitingListTable.SelectedRows(0).Cells(1).Value
        Edit_WaitingListForm.wardId.Text = waitingListTable.SelectedRows(0).Cells(3).Value
        Edit_WaitingListForm.dateWaiting.Text = waitingListTable.SelectedRows(0).Cells(4).Value

        ' show Edit_waitingListForm
        Edit_WaitingListForm.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Report_WaitinglistForm.Show()
    End Sub

    Public Sub WaitingListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        INNER JOIN Patients AS P ON (PW.patientID = P.patientID)"

        ' query data from database
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' add data to the data grid view
        waitingListTable.DataSource = dataTable

        ' back up data table
        backUpDataTable = dataTable

        ' get all pwID in wating list data grid view

        For Each row As DataGridViewRow In waitingListTable.Rows
            pwIDList.Add(row.Cells(0).Value)
        Next

        ' frozen first column
        waitingListTable.Columns(0).Frozen = True

        ' set cbb bed status default value
        cbb_bed_status.SelectedIndex = 0
    End Sub

    Private Sub SearchWaiting_TextChanged(sender As Object, e As EventArgs) Handles SearchWaiting.TextChanged
        ' check if search text box is empty
        If SearchWaiting.Text Is Nothing Then
            ' if empty, show all data
            waitingListTable.DataSource = backUpDataTable
        Else
            ' if not empty, filter data
            Dim dataTable As DataTable = backUpDataTable
            dataTable.DefaultView.RowFilter = String.Format("ชื่อผู้ป่วย LIKE '%{0}%' OR หมายเลขวอร์ด LIKE '%{0}%'", SearchWaiting.Text)
            waitingListTable.DataSource = dataTable
        End If

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ' get pwID from selected row
        Dim pwID As String = waitingListTable.SelectedRows(0).Cells(0).Value

        Console.WriteLine("Delete At : " + pwID)

        ' create sql code to delete data
        Dim sqlCode = $"DELETE FROM In_patients WHERE pwID = '{pwID}'"

        ' message box to confirm delete
        Dim confirm = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' if confirm delete
        If confirm = DialogResult.Yes Then
            ' delete data from database
            StaffForm.sqlExecuteNonQuery(sqlCode)
            ' reload data
            WaitingListForm_Load(sender, e)
        End If
    End Sub

    Private Sub cbb_bed_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_bed_status.SelectedIndexChanged
        If cbb_bed_status.SelectedIndex = 0 Then
            ' if selected index is 0, show all data
            Dim dataTable As DataTable = backUpDataTable
            dataTable.DefaultView.RowFilter = ""
            waitingListTable.DataSource = backUpDataTable

        Else
            ' if not 0, filter data finding isGetBed Data type is bite = 1

            Dim dataTable As DataTable = backUpDataTable
            dataTable.DefaultView.RowFilter = "สถานะรอเตียง = 1"
            waitingListTable.DataSource = dataTable
        End If
    End Sub
End Class