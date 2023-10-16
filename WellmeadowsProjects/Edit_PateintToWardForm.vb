Public Class Edit_PateintToWardForm
    Public pwID As String = ""
    Private Sub Edit_PateintToWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' get wardID combobox
        wardID_combobox = StaffForm.getWardIDtoCombobox(wardID_combobox)

        ' get CNID from main form
        If MainForm.cnID <> "" Then
            cnID.Text = MainForm.cnID
        Else
            ' message box notify that not have permission to open this page
            MsgBox("คุณไม่มีสิทธิ์เข้าถึงหน้านี้")

            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        patientId.Text = ""
        visitID.Text = ""
        cnID.Text = ""
        wardID_combobox.Text = ""
        patientType_combobox.SelectedIndex = -1
        symptom.Text = ""
    End Sub

    Private Sub btnCheckDoctor_Click(sender As Object, e As EventArgs) Handles btnCheckDoctor.Click
        pop_Doc.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' check all field are not empty
        If patientId.Text = "" Or visitID.Text = "" Or cnID.Text = "" Or wardID_combobox.Text = "" Or patientType_combobox.Text = "" Or symptom.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบทุกช่อง")
            Return
        End If

        ' sql update patient to Table Patient Wards
        Dim sqlCode = "UPDATE Patient_Wards SET 
            patientID = '" & patientId.Text & "',
            visitID = '" & visitID.Text & "',
            doctorID = '" & doctorID.Text & "',
            cnID = '" & cnID.Text & "',
            wardID = '" & wardID_combobox.Text & "',
            patientType = '" & patientType_combobox.Text & "',
            symptom = '" & symptom.Text & "',
            updateAt = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "'
            WHERE pwID = '" & pwID & "'"

        Try
            ' execute sql code
            StaffForm.sqlExecuteNonQuery(sqlCode)

            MessageBox.Show("อัปเดตข้อมูลสำเร็จ")

            ' refresh patientInWard data grid
            PatientInWardForm.PatientInWardForm_Load(sender, e)

            Me.Close()
        Catch ex As Exception
            MsgBox("เกิดข้อผิดพลาด : " + Environment.NewLine + ex.Message)
            Return
        End Try

    End Sub
End Class