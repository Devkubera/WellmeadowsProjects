Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class WardForm
    Public backupData As DataTable

    Private Const ordinalIgnoreCase As StringComparison = StringComparison.OrdinalIgnoreCase
    Public wardData As New Dictionary(Of String, String)

    Private Sub btnStaffInWard_Click(sender As Object, e As EventArgs) Handles btnStaffInWard.Click
        StaffInWardForm.Show()
    End Sub

    Private Sub btnPInward_Click(sender As Object, e As EventArgs) Handles btnPInward.Click
        PatientInWardForm.Show()
    End Sub

    Private Sub btnWaitinglist_Click(sender As Object, e As EventArgs) Handles btnWaitinglist.Click
        WaitingListForm.Show()
    End Sub

    Public Sub WardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Wards)

        ' making sql code to get data form ward table
        Dim sql As String = "SELECT
	        wardID AS 'หมายเลขวอร์ด',
	        wardName AS 'ชื่อวอร์ด',
	        wardLocation AS 'สถานที่ตั้ง',
	        wardTel AS 'หมายเลขภายใน',
	        (SELECT COUNT(bedID) FROM Beds WHERE Beds.wardID = Wards.wardID) AS 'จำนวนเตียง'
        FROM WARDS;"

        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sql)

        If dataTable Is Nothing Then
            Console.WriteLine("Error not have ward in this ward : " & sql)
            Return
        End If

        WardTable.DataSource = dataTable

        ' backup data table
        backupData = dataTable

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Ward.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' get value from view pa
        Dim selected As New List(Of String)
        If WardTable.CurrentRow IsNot Nothing Then
            wardData("wardID") = WardTable.SelectedRows(0).Cells(0).Value.ToString
            wardData("wardName") = WardTable.SelectedRows(0).Cells(1).Value.ToString
            wardData("wardLocation") = WardTable.SelectedRows(0).Cells(2).Value.ToString
            wardData("wardTel") = WardTable.SelectedRows(0).Cells(3).Value.ToString
            wardData("wardBed") = WardTable.SelectedRows(0).Cells(4).Value.ToString


            Edit_Ward.wardID = wardData("wardID")
            Edit_Ward.ward_name.Text = wardData("wardName")
            Edit_Ward.ward_location.Text = wardData("wardLocation")
            Edit_Ward.ward_tel.Text = wardData("wardTel")

        Else
            MessageBox.Show("กรุณาเลือกข้อมูลก่อน")
        End If
        Edit_Ward.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If WardTable.CurrentRow IsNot Nothing Then
            Dim ID = WardTable.SelectedRows(0).Cells(0).Value.ToString
            Console.WriteLine(ID)
            WardTable.Rows.RemoveAt(WardTable.CurrentRow.Index)
            WardsTableAdapter.DeleteWard(ID)
        End If
    End Sub

    Private Sub SearchWard_TextChanged(sender As Object, e As EventArgs) Handles SearchWard.TextChanged
        'Dim WardsBindingSource1 As New BindingSource()
        Dim searchText As String = SearchWard.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            'เอา datasource มาใช้
            WardTable.DataSource = backupData
        Else
            'WardsBindingSource.Filter = $"wardID LIKE '%{searchText}%' OR wardName LIKE '%{searchText}%' "
            ' create sql code
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

    Private Sub placeholderlb_Click(sender As Object, e As EventArgs) Handles placeholderlb.Click

    End Sub

    Private Sub wardPanel_Paint(sender As Object, e As PaintEventArgs) Handles wardPanel.Paint

    End Sub
End Class