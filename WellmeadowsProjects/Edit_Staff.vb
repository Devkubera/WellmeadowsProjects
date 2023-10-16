Public Class Edit_Staff
    Public staffID As String
    Public staffPosition As String
    Private Sub Edit_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Experiences' table. You can move, or remove it, as needed.
        Me.Staff_ExperiencesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Experiences)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.WellmeadowsDataSet.Staffs)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Staff_Qualificates' table. You can move, or remove it, as needed.
        Me.Staff_QualificatesTableAdapter.Fill(Me.WellmeadowsDataSet.Staff_Qualificates)

        Console.WriteLine("Current Staff ID: " & staffID)

        ' try to check position of staff and fill data to staff_position combobox with selected index
        Dim index As Integer = -1

        For i As Integer = 0 To Staff_position.Items.Count - 1
            Dim itemText As String = Staff_position.Items(i).ToString()
            If itemText.Contains(staffPosition) Then
                index = i ' Set the index when a match is found
                Exit For ' Exit the loop once a match is found
            End If
        Next

        If index <> -1 Then
            Staff_position.SelectedIndex = index ' Set the ComboBox selected index
            ' Call the SelectedIndexChanged event if needed
            Staff_position_SelectedIndexChanged(sender, e)
        Else
            Console.WriteLine("Staff position not found.")
        End If

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
        Staff_paidType.SelectedIndex = 0
        Staff_hoursWeek.Text = ""
        Staff_contactType.SelectedIndex = 0

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

            ' insert data to table doctors, md, CN
            If Staff_position.SelectedIndex = 0 Then
                ' check it charge nurse table has staff id
                Dim cn = StaffForm.sqlQueryDataTable($"SELECT cnID FROM ChargeNurses WHERE staffID =  {staffID}")
                If cn Is Nothing Then
                    ' If already have, update it
                    ChargeNursesTableAdapter1.UpdateQuery("YES", staffID)
                End If

                MedicalDirectorsTableAdapter1.UpdateMD("NO", staffID)
                DoctorsTableAdapter1.UpdateDoctors("NO", staffID)

            ElseIf Staff_position.SelectedIndex = 1 Then
                ' check it staff id is in medical director table
                Dim md = StaffForm.sqlQueryDataTable($"SELECT mdID FROM MedicalDirectors WHERE staffID = {staffID}")
                If md Is Nothing Then
                    ' If is already have, active it
                    MedicalDirectorsTableAdapter1.UpdateMD("YES", staffID)
                End If

                ChargeNursesTableAdapter1.UpdateQuery("NO", staffID)
                DoctorsTableAdapter1.UpdateDoctors("NO", staffID)

            ElseIf Staff_position.SelectedIndex = 2 Then
                ' check it staff id is in doctors table
                Dim doctor = StaffForm.sqlQueryDataTable("SELECT doctorID FROM Doctors WHERE staffID = " & staffID)
                If doctor Is Nothing Then
                    ' If is already have, active it
                    DoctorsTableAdapter1.UpdateDoctors("YES", staffID)
                End If

                ChargeNursesTableAdapter1.UpdateQuery("NO", staffID)
                MedicalDirectorsTableAdapter1.UpdateMD("NO", staffID)
            Else
                ChargeNursesTableAdapter1.UpdateQuery("NO", staffID)
                MedicalDirectorsTableAdapter1.UpdateMD("NO", staffID)
                DoctorsTableAdapter1.UpdateDoctors("NO", staffID)
                Console.WriteLine("Check else case : " & Staff_position.SelectedIndex)
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

            ' show message box insert success with icon
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว", "แก้ไขข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' refresh staffForm data grid view
            StaffForm.StaffForm_Load(sender, e)

            ' close this form
            Me.Close()


        Catch ex As Exception
            MessageBox.Show("แก้ไขข้อมูลผิดพลาด กรุณาเช็คข้อมูลของท่าน" & Environment.NewLine & ex.Message, "แก้ไขข้อมูลผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine("Error to update staff data: " & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetForm()
    End Sub

    Private Sub Staff_position_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Staff_position.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class