Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StaffForm
    Public sqlConn = "Data Source=Zero\DATABASE66;Initial Catalog=Wellmeadows;Integrated Security=True"
    Public staffDataSourceBackup As DataTable
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_StaffForm.Show()
    End Sub

    Public Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Qualificates' table. You can move, or remove it, as needed.
        Me.Staff_QualificatesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Qualificates)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Experiences' table. You can move, or remove it, as needed.
        Me.Staff_ExperiencesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Experiences)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Experiences' table. You can move, or remove it, as needed.
        Me.Staff_ExperiencesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Experiences)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Experiences' table. You can move, or remove it, as needed.
        Me.Staff_ExperiencesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Experiences)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)

        'connection string
        Using connection As New SqlConnection("Data Source=Zero\DATABASE66;Initial Catalog=Wellmeadows;Integrated Security=True")
            connection.Open()
            Try
                ' Set deafault combobox edu level
                cbbEduLevel.Items.Add("ทั้งหมด")
                ' Create a String to hold the query.
                Dim sql As String = "SELECT DISTINCT type FROM Staff_Qualificates;"

                ' Create a command to execute the query.
                Dim command As New SqlCommand(sql, connection)

                ' Execute the query and get a SqlDataReader.
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    cbbEduLevel.Items.Add(reader("type").ToString())
                End While

            Catch ex As Exception

            End Try
            connection.Close()
        End Using

        ' Set default data grid view to show staffs
        cbbEduOrExp.SelectedIndex = 0

        Dim sqlMsg = "SELECT 
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

        Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
        DataGridV1.DataSource = dataTable

        ' Set default combobox qualificates
        cbbEduLevel.SelectedIndex = 0

        ' Set DataTable Selection Mode
        DataGridV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' if user it's not personal department, Then hide add button and edit button

        If MainForm.personalID = "" Then
            btnAdd.Visible = False
            btnEdit.Visible = False
            btnDel.Visible = False
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If cbbEduOrExp.SelectedIndex = 0 Then
            Dim staffID = DataGridV1.SelectedRows(0).Cells(0).Value.ToString()
            ' cut first name and last name
            Dim firstName = DataGridV1.SelectedRows(0).Cells(1).Value.ToString().Split(" ")(0)
            Dim lastName = DataGridV1.SelectedRows(0).Cells(1).Value.ToString().Split(" ")(1)
            Dim gender = DataGridV1.SelectedRows(0).Cells(2).Value.ToString()
            Dim address = DataGridV1.SelectedRows(0).Cells(3).Value.ToString()
            Dim tel = DataGridV1.SelectedRows(0).Cells(4).Value.ToString()
            Dim dob = DataGridV1.SelectedRows(0).Cells(5).Value.ToString()
            Dim nin = DataGridV1.SelectedRows(0).Cells(6).Value.ToString()
            Dim position = DataGridV1.SelectedRows(0).Cells(7).Value.ToString()
            Dim salary = DataGridV1.SelectedRows(0).Cells(8).Value.ToString()
            Dim salaryScale = DataGridV1.SelectedRows(0).Cells(9).Value.ToString()
            Dim hoursWeek = DataGridV1.SelectedRows(0).Cells(10).Value.ToString()
            Dim contactType = DataGridV1.SelectedRows(0).Cells(11).Value.ToString()
            Dim paidType = DataGridV1.SelectedRows(0).Cells(12).Value.ToString()

            ' Initialize Edit_Staff form
            Edit_Staff.staffID = staffID
            Edit_Staff.Staff_firstName.Text = firstName
            Edit_Staff.Staff_lastName.Text = lastName
            Edit_Staff.Staff_dob.Value = dob
            Edit_Staff.Staff_tel.Text = tel
            Edit_Staff.Staff_nin.Text = nin
            Edit_Staff.Staff_address.Text = address
            Edit_Staff.staffPosition = position
            Edit_Staff.Staff_salary.Text = salary
            Edit_Staff.Staff_salaryScale.Text = salaryScale
            Edit_Staff.Staff_hoursWeek.Text = hoursWeek
            Edit_Staff.Staff_contactType.Text = contactType
            Edit_Staff.Staff_paidType.Text = paidType

            If gender IsNot Nothing Then
                Edit_Staff.Staff_gender.SelectedItem = gender
            End If

            Edit_Staff.Show()
        ElseIf cbbEduOrExp.SelectedIndex = 1 Then


            Edit_Staff_Experiences.Show()
        Else
            Edit_Staff_Qualificates.Show()
        End If
    End Sub

    Private Sub SearchStaff_TextChanged_1(sender As Object, e As EventArgs) Handles SearchStaff.TextChanged

        If SearchStaff.Text = "" Or SearchStaff.Text Is Nothing Then
            'StaffsBindingSource.RemoveFilter()
            DataGridV1.DataSource = Nothing
            'DataGridV1.DataSource = staffDataSourceBackup
            cbbEduOrExp_SelectedIndexChanged(sender, e)
        Else
            Try
                If cbbEduOrExp.SelectedIndex = 0 Then
                    Dim searchValue As String = SearchStaff.Text
                    Dim sqlMsg = $"SELECT 
                        staffID AS 'รหัสเจ้าหน้าที่',
                        CONCAT(firstName, ' ', lastName) AS 'ชื่อ - สกุล',
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
                        FROM STAFFS
                        WHERE firstName LIKE '%{searchValue}%' OR lastName LIKE '%{searchValue}%';"

                    Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
                    DataGridV1.DataSource = dataTable
                End If

                If cbbEduOrExp.SelectedIndex = 1 Then
                    Dim selectedValue As String = SearchStaff.Text
                    Dim sqlMsg = $"SELECT
                        s.staffID AS 'รหัสเจ้าหน้าที่', 
                        CONCAT(s.firstName, ' ', s.lastName) AS 'ชื่อเจ้าหน้าที่', 
                        se.organization AS 'ชื่อองค์กร', 
                        se.position AS 'ตำแหน่ง', 
                        se.startDate AS 'วันทำงานวันแรก', 
                        se.endDate AS 'วันทำงานวันสุดท้าย'  
                        FROM Staff_Experiences AS se
                        INNER JOIN Staffs AS s ON (se.staffID = s.staffID)
                        WHERE organization LIKE '%{selectedValue}%';"
                    Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
                    DataGridV1.DataSource = dataTable
                End If

                If cbbEduOrExp.SelectedIndex = 2 Then
                    Dim searchValue As String = SearchStaff.Text
                    Dim sqlMsg = $"SELECT 
	                    S.staffID AS 'รหัสพนักงาน',
	                    CONCAT(S.firstName, ' ', S.lastName) AS 'ชื่อ - สกุล',
	                    type AS 'วุฒิการศึกษา',
	                    dates AS 'วันจบการศึกษา',
	                    major AS 'คณะ/สาขา'
                    FROM Staff_Qualificates AS sq
                    INNER JOIN Staffs AS S ON (S.staffID = sq.staffID)
                    WHERE major LIKE '%{searchValue}%'   
                    ORDER BY sq.staffID;"
                    Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
                    DataGridV1.DataSource = dataTable
                End If


            Catch ex As Exception
                Console.WriteLine("Error to search : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DelaySearch(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub cbbEduOrExp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEduOrExp.SelectedIndexChanged
        ' reset data source
        DataGridV1.DataSource = Nothing

        Dim seacrhLabelName As String = ""

        If cbbEduOrExp.SelectedIndex = 0 Then
            Dim sqlMsg = "SELECT 
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

            Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
            DataGridV1.DataSource = dataTable
            staffDataSourceBackup = dataTable

            seacrhLabelName = "ค้นหาด้วยชื่อ"
        End If

        If cbbEduOrExp.SelectedIndex = 1 Then
            Dim sqlMsg = "SELECT 
	            s.staffID AS 'รหัสเจ้าหน้าที่', 
	            CONCAT(s.firstName, ' ', s.lastName) AS 'ชื่อเจ้าหน้าที่', 
	            se.organization AS 'ชื่อองค์กร', 
	            se.position AS 'ตำแหน่ง', 
	            se.startDate AS 'วันทำงานวันแรก', 
	            se.endDate AS 'วันทำงานวันสุดท้าย'  
                FROM Staff_Experiences AS se
                INNER JOIN Staffs AS s ON (se.staffID = s.staffID);"

            Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
            DataGridV1.DataSource = dataTable

            seacrhLabelName = "ค้นหาด้วยชื่อองค์กร"
        End If

        If cbbEduOrExp.SelectedIndex = 2 Then

            Dim sqlMsg = "SELECT 
	            S.staffID AS 'รหัสพนักงาน',
	            CONCAT(S.firstName, ' ', S.lastName) AS 'ชื่อ - สกุล',
	            type AS 'วุฒิการศึกษา',
	            dates AS 'วันจบการศึกษา',
	            major AS 'คณะ/สาขา'
                FROM Staff_Qualificates AS sq
                INNER JOIN Staffs AS S ON (S.staffID = sq.staffID)
                ORDER BY sq.staffID;"

            Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
            DataGridV1.DataSource = dataTable

            seacrhLabelName = "ค้นหาด้วยชื่อคณะ / สาขา"
        End If

        searchlb.Text = seacrhLabelName

        ' Frozen first column
        DataGridV1.Columns(0).Frozen = True

        ' Making cloumn auto size mode is ON !!
        For Each column As DataGridViewColumn In DataGridV1.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        Console.WriteLine("cbbEddorExp selected indeX : " & cbbEduOrExp.SelectedIndex)
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

                adapter.Fill(DataTable)

            Catch ex As Exception
                Console.WriteLine("Error to fetch data : " & ex.Message)
            End Try
            connection.Close()
        End Using

        If dataTable.Rows.Count > 0 Then
            ' Return dataTable to using in Datasource = dataTable
            Return dataTable
        Else
            dataTable = Nothing
            Return dataTable
        End If

    End Function

    Private Sub cbbEduLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEduLevel.SelectionChangeCommitted
        cbbEduOrExp.SelectedIndex = 2
        DataGridV1.DataSource = Nothing

        If cbbEduLevel.SelectedIndex = 0 Then
            DataGridV1.DataSource = Nothing
            cbbEduOrExp.SelectedIndex = 0
        Else
            Dim sqlMsg = $"SELECT 
                S.staffID AS 'รหัสพนักงาน',
                CONCAT(S.firstName, ' ', S.lastName) AS 'ชื่อ - สกุล',
                type AS 'วุฒิการศึกษา',
                dates AS 'วันจบการศึกษา',
                major AS 'คณะ/สาขา'
                FROM Staff_Qualificates AS sq
                INNER JOIN Staffs AS S ON (S.staffID = sq.staffID)
                WHERE type = '{cbbEduLevel.SelectedItem.ToString}'
                ORDER BY sq.staffID;"

            Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)
            DataGridV1.DataSource = dataTable
        End If
    End Sub

    Public Sub frozenFirstColumn(dataGridView As DataGridView)
        dataGridView.Columns(0).Frozen = True
    End Sub

    Private Sub StaffPanel_Paint(sender As Object, e As PaintEventArgs) Handles StaffPanel.Paint

    End Sub

    'create sql query to insert data to database
    Public Function sqlExecuteNonQuery(sqlCode As String)
        Using connection As New SqlConnection(sqlConn)
            connection.Open()
            Try
                Dim sql As String = sqlCode

                ' Create a command to execute the query.
                Dim command As New SqlCommand(sql, connection)

                ' Execute the query and get a SqlDataReader.
                command.ExecuteNonQuery()

            Catch ex As Exception
                Console.WriteLine("Error to insert data : " & ex.Message)
            End Try
            connection.Close()
        End Using
    End Function

    Public Function getWardIDtoCombobox(cbb As Object)
        Dim sqlMsg = "SELECT wardID FROM Wards"
        Dim dataTable As DataTable = sqlQueryDataTable(sqlMsg)

        For Each row As DataRow In dataTable.Rows
            cbb.Items.Add(row("wardID").ToString())
        Next

        Return cbb
    End Function
End Class