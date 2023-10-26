Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class StaffInWardForm
    Public sqlConn = StaffForm.sqlConn

    Private Const ordinalIgnoreCase As StringComparison = StringComparison.OrdinalIgnoreCase
    Public wardStaffsData As New Dictionary(Of String, String)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_StaffInWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' get value from view pa
        Dim selected As New List(Of String)
        If Ward_StaffsTable.CurrentRow IsNot Nothing Then
            wardStaffsData("wsID") = Ward_StaffsTable.SelectedRows(0).Cells(0).Value.ToString
            wardStaffsData("staffid") = Ward_StaffsTable.SelectedRows(0).Cells(1).Value.ToString
            wardStaffsData("firstName") = Ward_StaffsTable.SelectedRows(0).Cells(2).Value.ToString
            wardStaffsData("lastName") = Ward_StaffsTable.SelectedRows(0).Cells(3).Value.ToString
            wardStaffsData("shiftID") = Ward_StaffsTable.SelectedRows(0).Cells(4).Value.ToString
            wardStaffsData("startTime") = Ward_StaffsTable.SelectedRows(0).Cells(5).Value.ToString
            wardStaffsData("endTime") = Ward_StaffsTable.SelectedRows(0).Cells(6).Value.ToString
            wardStaffsData("wardID") = Ward_StaffsTable.SelectedRows(0).Cells(7).Value.ToString
            wardStaffsData("wardName") = Ward_StaffsTable.SelectedRows(0).Cells(8).Value.ToString

            Edit_StaffInWardForm.wsID = wardStaffsData("wsID")
            Edit_StaffInWardForm.staffId.Text = wardStaffsData("staffid")
            Edit_StaffInWardForm.firstname.Text = wardStaffsData("firstName")
            Edit_StaffInWardForm.lastname.Text = wardStaffsData("lastName")
            Edit_StaffInWardForm.shID = wardStaffsData("shiftID")
            Edit_StaffInWardForm.ShiftTime.Text = wardStaffsData("startTime")
            Edit_StaffInWardForm.endTime.Text = wardStaffsData("endTime")
            Edit_StaffInWardForm.wardId.Text = wardStaffsData("wardID")

        Else
            MessageBox.Show("กรุณาเลือกข้อมูลก่อน")
        End If
        Edit_StaffInWardForm.Show()
    End Sub

    Public Sub StaffInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(StaffForm.sqlConn) ' แทนที่ Your_Connection_String ด้วยข้อมูลการเชื่อมต่อฐานข้อมูลของคุณ
            connection.Open()

            Dim sql As String = "SELECT Ward_Staffs.wsID AS 'ID', staffs.staffID AS 'หมายเลขพนักงาน', staffs.firstName AS 'ชื่อ', staffs.lastName AS 'นามสกุล', shifts.shiftID As 'หมายเลขกะ',
                                 shifts.startTime AS 'เวลาเริ่มงาน', shifts.endTime AS 'เวลาเลิกงาน', 
                                 wards.wardID AS 'หมายเลขวอร์ด', wards.wardName AS 'ชื่อวอร์ด'
                            FROM Ward_Staffs 
                                INNER JOIN staffs ON Ward_Staffs.staffID = staffs.staffID
                                INNER JOIN shifts ON Ward_Staffs.shiftID = shifts.shiftID
                                INNER JOIN wards ON Ward_Staffs.wardID = wards.wardID;"

            ' สร้าง SqlDataAdapter เพื่อดึงข้อมูล
            Dim adapter As New SqlDataAdapter(sql, connection)

            ' สร้าง DataTable เพื่อเก็บข้อมูล
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' แสดงข้อมูลบน DataGridView
            Ward_StaffsTable.DataSource = dataTable

            ' ปิดการเชื่อมต่อ
            connection.Close()

        End Using

        'connection string
        Using connection As New SqlConnection(StaffForm.sqlConn)
            connection.Open()
            Try
                Dim sql As String = "SELECT wardID FROM Wards ORDER BY ID;"

                ' Create a command to execute the query.
                Dim command As New SqlCommand(sql, connection)

                ' Execute the query and get a SqlDataReader.
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    cbbWardId.Items.Add(reader("wardID").ToString())
                End While

            Catch ex As Exception

            End Try
            connection.Close()
        End Using

        cbbWardId.SelectedIndex = 0

        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Wards' table. You can move, or remove it, as needed.
        Me.Ward_StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Ward_Staffs)

        'check if user is md or cn or personal -> invisible button report
        If MainForm.mdID = "" And MainForm.cnID = "" And MainForm.personalID = "" And MainForm.isAdmin = False Then
            btnReport.Visible = False
        End If

        cbbWardId_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Ward_StaffsTable.CurrentRow IsNot Nothing Then
            Dim ID = Ward_StaffsTable.SelectedRows(0).Cells(0).Value.ToString
            Console.WriteLine(ID)
            Ward_StaffsTable.Rows.RemoveAt(Ward_StaffsTable.CurrentRow.Index)
            Ward_StaffsTableAdapter.DeleteWardStaffs(ID)
        End If
    End Sub

    Private Sub cbbWardId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbWardId.SelectedIndexChanged
        If cbbWardId.SelectedIndex = 0 Then
            Dim sqlMsg = "SELECT Ward_Staffs.wsID AS 'ID', staffs.staffID AS 'หมายเลขพนักงาน', staffs.firstName AS 'ชื่อ', staffs.lastName AS 'นามสกุล', shifts.shiftID As 'หมายเลขกะ',
                                 shifts.startTime AS 'เวลาเริ่มงาน', shifts.endTime AS 'เวลาเลิกงาน', 
                                 wards.wardID AS 'หมายเลขวอร์ด', wards.wardName AS 'ชื่อวอร์ด'
                            FROM Ward_Staffs 
                                INNER JOIN staffs ON Ward_Staffs.staffID = staffs.staffID
                                INNER JOIN shifts ON Ward_Staffs.shiftID = shifts.shiftID
                                INNER JOIN wards ON Ward_Staffs.wardID = wards.wardID;"

            Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
            Ward_StaffsTable.DataSource = dataTable

            btnReport.Visible = False
        Else
            btnReport.Visible = True

            Dim sqlMsg = $"SELECT Ward_Staffs.wsID AS 'ID', staffs.staffID AS 'หมายเลขพนักงาน', staffs.firstName AS 'ชื่อ', staffs.lastName AS 'นามสกุล', shifts.shiftID As 'หมายเลขกะ',
                                 shifts.startTime AS 'เวลาเริ่มงาน', shifts.endTime AS 'เวลาเลิกงาน', 
                                 wards.wardID AS 'หมายเลขวอร์ด', wards.wardName AS 'ชื่อวอร์ด'
                            FROM Ward_Staffs 
                                INNER JOIN staffs ON Ward_Staffs.staffID = staffs.staffID
                                INNER JOIN shifts ON Ward_Staffs.shiftID = shifts.shiftID
                                INNER JOIN wards ON Ward_Staffs.wardID = wards.wardID
                            WHERE wards.wardId = '{cbbWardId.Text}';" 'set ค่าตาม wardname หรือ wardid ได้ ตาม combobox

            Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
            Ward_StaffsTable.DataSource = dataTable
        End If

        ' check count of record in ward_staffs table
        If Ward_StaffsTable.Columns.Count > 0 Then
            ' make frozen at first column
            Ward_StaffsTable.Columns(0).Frozen = True
        Else
            MessageBox.Show("ไม่พบข้อมูล", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbbWardId.SelectedIndex = 0
            cbbWardId_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Public Function sqlQueryReader(sqlCode As String)
        Using connection As New SqlConnection(sqlConn)
            connection.Open()
            Try
                Dim sql As String = sqlCode

                ' Create a command to execute the query.
                Dim command As New SqlCommand(sql, connection)

                ' สร้าง SqlDataAdapter เพื่อดึงข้อมูล
                Dim adapter As New SqlDataAdapter(sql, connection)

                ' Execute the query and get a SqlDataReader.
                Dim reader As SqlDataReader = command.ExecuteReader()

                Return reader
            Catch ex As Exception
                Console.WriteLine("Error to pull data from staff qualificates : " & ex.Message)
            End Try
            connection.Close()
        End Using

    End Function

    Public Function sqlQueryDataTable(sqlCode As String) As DataTable
        ' สร้าง DataTable เพื่อเก็บข้อมูล
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(sqlConn)
            connection.Open()
            Try
                Dim sql As String = sqlCode

                ' สร้าง SqlDataAdapter เพื่อดึงข้อมูล
                Dim adapter As New SqlDataAdapter(sql, connection)

                adapter.Fill(dataTable)

            Catch ex As Exception
                Console.WriteLine("Error to fetch staff exp : " & ex.Message)
            End Try
            connection.Close()
        End Using

        If dataTable.Rows.Count > 0 Then
            ' Return dataTable to using in Datasource = dataTable
            Return dataTable
        End If
    End Function

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Report_EachWard.Report_title = cbbWardId.Text
        Report_EachWard.Show()
    End Sub
End Class