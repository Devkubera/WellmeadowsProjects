Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Add_StaffForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Experiences' table. You can move, or remove it, as needed.
        Me.Staff_ExperiencesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Experiences)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Qualificates' table. You can move, or remove it, as needed.
        Me.Staff_QualificatesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Qualificates)
        ' Create a button to add more input items
    End Sub
    Private Sub ResetForm()

        Staff_firstName.Text = ""
        Staff_lastName.Text = ""
        Staff_dob.Value = DateTime.Now
        Staff_gender.Text = ""
        Staff_tel.Text = ""
        Staff_nin.Text = ""
        Staff_address.Text = ""

        Staff_position.Text = ""
        Staff_salary.Text = ""
        Staff_salaryScale.Text = ""
        Staff_paidType.SelectedIndex = -1
        Staff_hoursWeek.Text = ""
        Staff_contactType.SelectedIndex = -1

    End Sub


    Private Sub btnAddRow_MouseClick(sender As Object, e As MouseEventArgs)
        'AddInputItem()

    End Sub

    Private Sub btnDelRow_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub btnAddRow2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDelRow2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Staff Data
        Dim firstName = Staff_firstName.Text
        Dim lastName = Staff_lastName.Text
        Dim dob = Staff_dob.Value
        Dim gender = Staff_gender.Text
        Dim tel = Staff_tel.Text
        Dim nin = Staff_nin.Text
        Dim address = Staff_address.Text

        Dim salary = Staff_salary.Text
        Dim salaryScale = Staff_salaryScale.Text
        Dim paidType = Staff_paidType.Text
        Dim hoursWeek = Staff_hoursWeek.Text
        Dim contactType = Staff_contactType.Text

        Dim position = Staff_position.Text
        Dim realPostion = Split(position, ".")

        realPostion(1) = realPostion(1).Trim()
        realPostion(0) = realPostion(0).Trim()

        Console.WriteLine(realPostion(1))
        Console.WriteLine("postion index: " & Staff_position.SelectedIndex)

        'Insert Staff Data
        StaffsTableAdapter.InsertStaff(
            firstName,
            lastName,
            address,
            tel,
            nin,
            realPostion(0),
            Double.Parse(salary),
            Double.Parse(salaryScale),
            hoursWeek,
            contactType,
            paidType,
            dob
        )

        ' code get latest staff_id here
        Dim staffID = StaffsTableAdapter.getLatestStaffID()

        ' insert data to table doctors, md, CN
        If Staff_position.SelectedIndex = 0 Then
            ChargeNursesTableAdapter1.InsertCN(staffID)

        ElseIf Staff_position.SelectedIndex = 1 Then
            MedicalDirectorsTableAdapter1.InsertMD(staffID)

        ElseIf Staff_position.SelectedIndex = 2 Then
            DoctorsTableAdapter1.InsertDoctor(staffID)
        End If

        ' Staff Qualification insert
        Dim qualID As Int32 = Int32.Parse(Staff_QualificatesTableAdapter.CountData()) + 1

        For Each row As DataGridViewRow In study_table.Rows

            If Not row.IsNewRow Then
                Dim rowData As New List(Of String)
                rowData.Add(staffID)
                For Each cell As DataGridViewCell In row.Cells
                    Dim cellData = cell.Value
                    rowData.Add(cellData)

                Next
                Dim dates = CDate(rowData(3))

                Console.WriteLine("qual data: " & rowData(0))
                Console.WriteLine("qual data: " & rowData(1))
                Console.WriteLine("qual data: " & rowData(2))
                Console.WriteLine(dates.GetType())

                Staff_QualificatesTableAdapter.InsertQualification(
                    qualID,
                    rowData(0),
                    rowData(1),
                    rowData(2),
                    dates
                )

            End If
        Next

        ' Staff Experiences insert
        Dim expID As Int32 = Int32.Parse(Staff_ExperiencesTableAdapter.CountData()) + 1

        For Each row As DataGridViewRow In old_table.Rows
            If Not row.IsNewRow Then
                Dim rowdata As New List(Of String)
                For Each cell As DataGridViewCell In row.Cells
                    Dim celldata As String = cell.Value.ToString()
                    rowdata.Add(celldata)
                    Console.WriteLine(celldata)
                Next
                ' insert here
                ' insert many rows
            End If
        Next


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetForm()
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        Dim name = study_cer.Text
        Dim major = study_major.Text
        Dim congratDate = study_endDate.Text
        study_table.Rows.Add(name, major, congratDate)
    End Sub

    Private Sub btnAddRow2_Click_1(sender As Object, e As EventArgs) Handles btnAddRow2.Click
        Dim name = old_company.Text
        Dim position = old_position.Text
        Dim startDate = old_startDate.Text
        Dim endDate = old_endDate.Text
        old_table.Rows.Add(name, position, startDate, endDate)
    End Sub

    Private Sub study_delete_Click(sender As Object, e As EventArgs) Handles study_delete.Click
        Try
            If study_table.CurrentRow IsNot Nothing Then
                study_table.Rows.RemoveAt(study_table.CurrentRow.Index)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub old_delete_Click(sender As Object, e As EventArgs) Handles old_delete.Click
        Try
            If old_table.CurrentRow IsNot Nothing Then
                old_table.Rows.RemoveAt(old_table.CurrentRow.Index)
            End If
        Catch ex As Exception
            'MessageBox.Show("ไม่")
        End Try
    End Sub


End Class
