Public Class Add_Staff_ExpForm1

    Private Sub Add_Staff_ExpForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_check_staff_Click(sender As Object, e As EventArgs) Handles btn_check_staff.Click
        popup_staff.ShowDialog()
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
            Add_Staff_ExpForm1_Load(sender, e)

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
    ' making sub that working when this form is closing
    Private Sub Add_Staff_Experiences_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' reload StaffForm by another way without using staffLoad sub
        StaffForm.StaffForm_Load(sender, e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class