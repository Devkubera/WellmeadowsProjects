Public Class Edit_Staff_Qualificates

    Private Sub Edit_Staff_Qualificates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' reset all field
        cert.Text = ""
        major.Text = ""
        endDate.Text = ""

        ' check if staffID textbox is not empty
        If Staff_number.Text IsNot Nothing And Staff_name.Text IsNot Nothing Then
            ' making sql code to query staff experiences
            Dim sql As String =
                $"select 
	                 qualID AS 'หมายเลขประวัติการศึกษา',
	                 staffID AS 'หมายเลขพนักงาน',
	                 type AS 'วุฒิการศึกษา',
	                 major AS 'คณะ/สาขา',
	                 dates AS 'วันที่จบการศึกษา'
                from Staff_Qualificates
                WHERE staffID = '{Staff_number.Text}';"

            ' query staff experiences
            Dim dt As DataTable = StaffForm.sqlQueryDataTable(sql)

            ' if staff experiences is not empty
            If dt IsNot Nothing Then
                ' show staff experiences in datagridview
                exp_table.DataSource = dt
                ' making exp_table not selected any field when start
                exp_table.ClearSelection()
                ' adjust column width to auto
                exp_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                ' if staff experiences is empty then show error message
                'MsgBox("ไม่พบข้อมูลประวัติการศึกษาของพนักงานที่ท่านเลือก." + Environment.NewLine + "ท่านสามารถเพิ่มข้อมูลประวัติการทำงานได้ด้วยการกรอกฟอร์มและกดเพิ่มข้อมูล")
                MsgBox("ไม่พบข้อมูลประวัติการศึกษาของพนักงานที่ท่านเลือก.")
            End If

        Else
            ' if staffID textbox is empty then show error message
            MsgBox("ไม่พบข้อมูลพนักงานที่ต้องการแก้ไข กรุณาเลือกข้อมูลพนักงานใหม่อีกครั้งในหน้าฟอร์ม Staff")
            ' close this form
            Me.Close()
        End If
    End Sub

    Private Sub exp_table_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles exp_table.RowHeaderMouseClick
        ' assign other field except staffID and staffName by value from exp_table
        cert.Text = exp_table.CurrentRow.Cells(2).Value
        major.Text = exp_table.CurrentRow.Cells(3).Value
        endDate.Text = exp_table.CurrentRow.Cells(4).Value
    End Sub

    Private Function CheckFieldValid() As Boolean
        If cert.Text <> "" And major.Text <> "" And endDate.Text <> "" Then
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
            ' making sql code to update staff qualificates
            Dim sql As String =
                $"UPDATE Staff_Qualificates
                    SET
                    type = '{cert.Text}',
                    major = '{major.Text}',
                    dates = '{endDate.Text}'
                WHERE qualID = '{exp_table.SelectedRows(0).Cells(0).Value.ToString}';"

            ' update staff qualificates
            StaffForm.sqlExecuteNonQuery(sql)
            MsgBox("แก้ไขข้อมูลสำเร็จ")

            ' reload this form
            Edit_Staff_Qualificates_Load(sender, e)

            StaffForm.cbbEduOrExp.SelectedIndex = 0
            StaffForm.StaffForm_Load(sender, e)
            StaffForm.cbbEduOrExp_SelectedIndexChanged(sender, e)

            Me.Close()

        Else
            ' if some field is empty then show error message
            MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน")
        End If
    End Sub
End Class