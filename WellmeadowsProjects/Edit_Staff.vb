Public Class Edit_Staff
    Public staffID As String
    Public backupPosition As String
    Private Sub Edit_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Experiences' table. You can move, or remove it, as needed.
        Me.Staff_ExperiencesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Experiences)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Qualificates' table. You can move, or remove it, as needed.
        Me.Staff_QualificatesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Qualificates)

        Console.WriteLine("Current Staff ID: " & staffID)
        backupPosition = Staff_position.Text
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

        Dim realPostion As String()
        ' check if position contains "."
        If position.Contains(".") Then
            realPostion = Split(position, ".")
            realPostion(1) = realPostion(1).Trim()
            realPostion(0) = realPostion(0).Trim()
            position = realPostion(0)
        End If

        Console.WriteLine(position)
        Console.WriteLine("postion index: " & Staff_position.SelectedIndex)

        'Update Staff Data
        Try

            ' check if position is changed
            ' if changed delete data from table doctors, md, CN
            'If Staff_position.SelectedText <> backupPosition Then
            '    If Staff_position.SelectedIndex = 0 Then
            '        Console.WriteLine("Delete CN")
            '        ChargeNursesTableAdapter1.DeleteCN(staffID)
            '    End If
            '    If Staff_position.SelectedIndex = 1 Then
            '        Console.WriteLine("Delete MD")
            '        MedicalDirectorsTableAdapter1.DeleteMD(staffID)
            '    End If
            '    If Staff_position.SelectedIndex = 2 Then
            '        Console.WriteLine("Delete Doctors")
            '        DoctorsTableAdapter1.DeleteDoctor(staffID)
            '    End If
            'End If

            ' insert data to table doctors, md, CN
            If Staff_position.SelectedIndex = 0 Then
                ' check it charge nurse table has staff id
                Dim cn = StaffForm.sqlQueryDataTable($"SELECT * FROM ChargeNurses WHERE staffID =  {staffID}")
                ChargeNursesTableAdapter1.InsertCN(staffID)
            End If

            If Staff_position.SelectedIndex = 1 Then
                ' check it staff id is in medical director table
                Dim md = StaffForm.sqlQueryDataTable($"SELECT * FROM MedicalDirectors WHERE staffID = {staffID}")
                MedicalDirectorsTableAdapter1.InsertMD(staffID)
            End If

            If Staff_position.SelectedIndex = 2 Then
                ' check it staff id is in doctors table
                Dim doctor = StaffForm.sqlQueryDataTable("SELECT * FROM Doctors WHERE staffID = " & staffID)
                DoctorsTableAdapter1.InsertDoctor(staffID)
            End If

            StaffsTableAdapter.UpdateStaff(
                firstName,
                lastName,
                address,
                tel,
                dob,
                nin,
                position,
                Double.Parse(salary),
                Double.Parse(salaryScale),
                hoursWeek,
                contactType,
                paidType,
                Staff_gender.Text,
                staffID
            )

        Catch ex As Exception
            MessageBox.Show("แก้ไขข้อมูลผิดพลาด กรุณาเช็คข้อมูลของท่าน" & ex.Message, "แก้ไขข้อมูลผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine("Error to update staff data: " & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetForm()
    End Sub

    Private Sub Staff_position_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Staff_position.SelectedIndexChanged

    End Sub
End Class