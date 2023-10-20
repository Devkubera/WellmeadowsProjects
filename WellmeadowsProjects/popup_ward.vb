Public Class popup_ward
    Public wardsData As New Dictionary(Of String, String)
    Public backUpData As DataTable
    Private Sub popup_ward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Wards' table. You can move, or remove it, as needed.
        'Me.WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Wards)

        ' making sql code to get data form ward table
        Dim sql As String = "SELECT
            wardID AS 'หมายเลขวอร์ด',
            wardName AS 'ชื่อวอร์ด',
            wardLocation AS 'สถานที่ตั้ง',
            wardTel AS 'หมายเลขภายใน',
            (SELECT COUNT(bedID) FROM Beds WHERE Beds.wardID = Wards.wardID) AS 'จำนวนเตียง'
        FROM WARDS;"

        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sql)

        ' check column count in data table
        If dataTable Is Nothing Then
            ' show messsage box with icon 'ไม่พบข้อมูล' + button ok
            MessageBox.Show("ไม่พบข้อมูลในตารางวอร์ด", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Return
        End If

        WardTable.DataSource = dataTable

        ' backup data table
        backupData = dataTable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selected As New List(Of String)
        If WardTable.CurrentRow IsNot Nothing Then
            wardsData("wardID") = WardTable.SelectedRows(0).Cells(0).Value.ToString
            wardsData("wardName") = WardTable.SelectedRows(0).Cells(1).Value.ToString
            wardsData("location") = WardTable.SelectedRows(0).Cells(2).Value.ToString
            wardsData("tel") = WardTable.SelectedRows(0).Cells(3).Value.ToString
            wardsData("totalBed") = WardTable.SelectedRows(0).Cells(4).Value.ToString

            'Console.WriteLine(wardsData("wardID"))

            Add_StaffInWardForm.wardId.Text = wardsData("wardID")

            Edit_StaffInWardForm.wardId.Text = wardsData("wardID")

            Me.Close()
        End If
    End Sub

    Private Sub seachbox_TextChanged(sender As Object, e As EventArgs) Handles seachbox.TextChanged
        Dim searchText As String = seachbox.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            'เอา datasource มาใช้
            WardTable.DataSource = backUpData
        Else
            Dim sql As String = $"SELECT
	            wardID AS 'หมายเลขวอร์ด',
	            wardName AS 'ชื่อวอร์ด',
	            wardLocation AS 'สถานที่ตั้ง',
	            wardTel AS 'หมายเลขภายใน',
	            (SELECT COUNT(bedID) FROM Beds WHERE Beds.wardID = Wards.wardID) AS 'จำนวนเตียง'
            FROM WARDS
            WHERE Wards.wardID LIKE '%{searchText}%' OR Wards.wardName LIKE '%{searchText}%'"

            Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sql)

            WardTable.DataSource = dataTable
        End If
    End Sub
End Class