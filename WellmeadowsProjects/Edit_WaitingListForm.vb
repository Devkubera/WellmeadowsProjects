Public Class Edit_WaitingListForm

    Private Sub Edit_WaitingListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load all wardID from get ward ID function in staff Form to wardID combobox
        wardId = StaffForm.getWardIDtoCombobox(wardId)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' chcek all field is not empty
        If patientId.Text = "" Or wardId.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' create sql code to edit data
            Dim sqlCode = $"UPDATE In_Patients 
                    SET wardID = '{wardId.Text}', on_wating_date = '{dateWaiting.Value}'
                    WHERE pwID = '{pwID_textbox.Text}'"
            ' execute sql code
            StaffForm.sqlExecuteNonQuery(sqlCode)

            ' show message box
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "แก้ไขข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' refresh data grid view
            WaitingListForm.WaitingListForm_Load(sender, e)

            Me.Close()
        End If
    End Sub
End Class