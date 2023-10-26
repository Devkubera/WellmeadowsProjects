Public Class Edit_Staff_Experiences
    Private Sub Edit_Staff_Experiences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' check if staffID textbox is not empty
        If Staff_number.Text IsNot Nothing And Staff_name.Text IsNot Nothing Then
            ' making sql code to query staff experiences
            Dim sql As String =
                $"SELECT 
	                expID AS 'รหัสประวัติการทำงาน',
	                staffID AS 'หมายเลขพนักงาน',
	                organization AS 'องค์กร',
	                position AS 'ตำแหน่ง',
	                startDate AS 'วันทำงานวันแรก',
	                endDate AS 'วันทำงานวันสุดท้าย'
                FROM Staff_Experiences
                WHERE staffID = '{Staff_number.Text}';"

            ' query staff experiences
            Dim dt As DataTable = StaffForm.sqlQueryDataTable(sql)

            ' if staff experiences is not empty
            If dt IsNot Nothing Then
                ' show staff experiences in datagridview
                exp_table.DataSource = dt
                ' making exp_table not selected any field when start
                exp_table.ClearSelection()
            Else
                ' if staff experiences is empty then show error message
                'MsgBox("ไม่พบข้อมูลประวัติการทำงานของพนักงานที่ท่านเลือก." + Environment.NewLine + "ท่านสามารถเพิ่มข้อมูลประวัติการทำงานได้ด้วยการกรอกฟอร์มและกดเพิ่มข้อมูล")
                MsgBox("ไม่พบข้อมูลประวัติการทำงานของพนักงานที่ท่านเลือก.")
            End If

        Else
            ' if staffID textbox is empty then show error message
            MsgBox("ไม่พบข้อมูลพนักงานที่ต้องการแก้ไข กรุณาเลือกข้อมูลพนักงานใหม่อีกครั้งในหน้าฟอร์ม Staff")
            ' close this form
            Me.Close()
        End If

    End Sub

    Private Sub btnAddRow2_Click(sender As Object, e As EventArgs) Handles btnAddRow2.Click
        ' make sure that all field is valid
        Dim check As Boolean = CheckFieldValid()
        If check = True Then
            ' making sql code to insert staff experiences
            Dim sql As String =
                $"INSERT INTO Staff_Experiences
                    (staffID, organization, position, startDate, endDate)
                VALUES
                    ('{Staff_number.Text}', '{old_company.Text}', '{old_position.Text}', '{old_startDate.Text}', '{old_endDate.Text}');"

            ' insert staff experiences
            StaffForm.sqlExecuteNonQuery(sql)

            MsgBox("เพิ่มข้อมูลสำเร็จ")

            ' reload this form
            Edit_Staff_Experiences_Load(sender, e)

            ' reset all field
            resetAllField()
        Else
            ' if some field is empty then show error message
            MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน")
        End If
    End Sub

    ' making sub reset all field
    Private Sub resetAllField()
        old_company.Text = ""
        old_position.Text = ""
        old_startDate.Text = ""
        old_endDate.Text = ""
    End Sub

    Private Sub exp_table_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles exp_table.RowHeaderMouseClick
        ' assign other field except staffID and staffName by value from exp_table
        old_company.Text = exp_table.CurrentRow.Cells(2).Value
        old_position.Text = exp_table.CurrentRow.Cells(3).Value
        old_startDate.Text = exp_table.CurrentRow.Cells(4).Value
        old_endDate.Text = exp_table.CurrentRow.Cells(5).Value
    End Sub

    Private Function CheckFieldValid() As Boolean
        If old_startDate.Text <> "" And old_endDate.Text <> "" And old_position.Text <> "" And old_company.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' check all field is valid
        Dim check As Boolean = CheckFieldValid()
        ' check if exp_table is selected any field
        If exp_table.SelectedRows.Count = 0 Then
            MsgBox("กรุณาเลือกข้อมูลที่ต้องการแก้ไข")
            Return
        End If
        If check = True Then
            ' making sql code to update staff experiences
            Dim sql As String =
                $"UPDATE Staff_Experiences
                SET
                    organization = '{old_company.Text}',
                    position = '{old_position.Text}',
                    startDate = '{old_startDate.Text}',
                    endDate = '{old_endDate.Text}'
                WHERE expID = '{exp_table.CurrentRow.Cells(0).Value}';"

            ' update staff experiences
            StaffForm.sqlExecuteNonQuery(sql)

            MsgBox("แก้ไขข้อมูลสำเร็จ")

            ' reload this form
            Edit_Staff_Experiences_Load(sender, e)

            ' reload StaffForm by another way without using staffLoad sub
            StaffForm.StaffForm_Load(sender, e)

            StaffForm.cbbEduOrExp.SelectedIndex = 1

            ' close this form
            Me.Close()

        Else
            ' if some field is empty then show error message
            MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน")
        End If
    End Sub

    ' making sub delete staff experiences
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' check if exp_table is selected any field
        If exp_table.SelectedRows.Count = 0 Then
            MsgBox("กรุณาเลือกข้อมูลที่ต้องการลบ")
            Return
        End If

        ' making sql code to delete staff experiences
        Dim sql As String =
            $"DELETE FROM Staff_Experiences
            WHERE expID = '{exp_table.CurrentRow.Cells(0).Value}';"

        ' delete staff experiences
        StaffForm.sqlExecuteNonQuery(sql)

        MsgBox("ลบข้อมูลสำเร็จ")

        ' reload this form
        Edit_Staff_Experiences_Load(sender, e)

        ' reset all field
        resetAllField()
    End Sub

    ' making sub that working when this form is closing
    Private Sub Edit_Staff_Experiences_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' reload StaffForm by another way without using staffLoad sub
        StaffForm.StaffForm_Load(sender, e)
    End Sub
End Class