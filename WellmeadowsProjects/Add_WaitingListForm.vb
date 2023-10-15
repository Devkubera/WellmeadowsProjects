Public Class Add_WaitingListForm

    Private Sub Add_WaitingListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load all wardID from get ward ID function in staff Form to wardID combobox
        wardId = StaffForm.getWardIDtoCombobox(wardId)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all field
        patientId.Text = ""
        wardId.Text = ""
        dateWaiting.Value = Date.Now
        pwID_textbox.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' show popup form
        popup_PatientWard.Show()
    End Sub

    Private Sub addWaitingListPanel_Paint(sender As Object, e As PaintEventArgs) Handles addWaitingListPanel.Paint

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' chcek all field is not empty
        If patientId.Text = "" Or wardId.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' create sql code to insert data
            Dim sqlCode = $"INSERT INTO In_Patients 
                    (pwID, wardID, on_wating_date, isGetBed) 
                    VALUES ('{pwID_textbox.Text}', '{wardId.Text}', '{dateWaiting.Value}', 0)"
            ' execute sql code
            StaffForm.sqlExecuteNonQuery(sqlCode)

            ' show message box
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "เพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' clear all field
            btnClear_Click(sender, e)

            ' refresh data grid view
            WaitingListForm.WaitingListForm_Load(sender, e)

            Me.Close()
        End If
    End Sub
End Class