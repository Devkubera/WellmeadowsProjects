Public Class Add_PateintToWardForm
    Private Sub Add_PateintToWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' query patient visit data
        Dim sqlCode = Patient_Visit.sqlQueryPatientVisit
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' set value to data grid view
        visitDatagrid.DataSource = dataTable
        ' frozen first column and last column
        visitDatagrid.Columns(0).Frozen = True

        ' make data grid can't select all rows
        visitDatagrid.MultiSelect = False

        ' get wardID combobox
        wardID_combobox = StaffForm.getWardIDtoCombobox(wardID_combobox)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        patientId.Text = ""
        visitID.Text = ""
        cnID.Text = ""
        wardID_combobox.Text = ""
        patientType_combobox.SelectedIndex = -1
        symptom.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' check all field are not empty
        If patientId.Text = "" Or visitID.Text = "" Or cnID.Text = "" Or wardID_combobox.Text = "" Or patientType_combobox.Text = "" Or symptom.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบทุกช่อง")
            Return
        End If

        ' sql insert patient to Table Patient Wards
        Dim sqlCode = "INSERT INTO Patient_Wards 
            (
            patientID, 
            visitID, 
            doctorID, 
            cnID, 
            wardID,
            patientType, 
            on_ward_date,
            symptom,
            updateAt) 
            VALUES (
            '" & patientId.Text & "',
            '" & visitID.Text & "',
            '" & doctorID.Text & "',
            '" & cnID.Text & "',
            '" & wardID_combobox.Text & "',
            '" & patientType_combobox.Text & "',
            '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "',
            '" & symptom.Text & "',
            '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "'
            )"

        Try
            ' execute sql code
            StaffForm.sqlExecuteNonQuery(sqlCode)

            MessageBox.Show("เพิ่มข้อมูลสำเร็จ")

            ' refresh patientInWard data grid
            PatientInWardForm.PatientInWardForm_Load(sender, e)

            Me.Close()
        Catch ex As Exception
            MsgBox("เกิดข้อผิดพลาด : " + Environment.NewLine + ex.Message)
            Return
        End Try



    End Sub

    ' making event for when user select row in data grid view
    Private Sub visitDatagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles visitDatagrid.CellClick
        Try
            ' get selected row index
            Dim index As Integer = visitDatagrid.SelectedRows(0).Index
            ' get selected row id
            Dim visitID As String = visitDatagrid.SelectedRows(0).Cells(0).Value.ToString
            ' get selected row patient id
            Dim patientID As String = visitDatagrid.SelectedRows(0).Cells(1).Value.ToString
            ' get selected row doctor id
            Dim doctorID As String = visitDatagrid.SelectedRows(0).Cells(4).Value.ToString
            ' get selected row ward id
            Dim wardID As String = visitDatagrid.SelectedRows(0).Cells(6).Value.ToString

            ' set value to text box
            Me.visitID.Text = visitID
            Me.patientId.Text = patientID
            Me.doctorID.Text = doctorID
            Me.wardID_combobox.Text = wardID
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCheckDoctor_Click(sender As Object, e As EventArgs) Handles btnCheckDoctor.Click
        pop_Doc.Show()
    End Sub
End Class