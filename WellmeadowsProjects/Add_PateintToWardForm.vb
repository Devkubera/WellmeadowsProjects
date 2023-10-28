Public Class Add_PateintToWardForm
    Dim backupWardID As String
    Private Sub Add_PateintToWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' query patient visit data
        Dim sqlCode = "SELECT      
            PV.visitID, 
	        PV.patientID AS หมายเลขผู้ป่วย,
	        (P.firstName + ' ' + P.lastName) AS ชื่อผู้ป่วย,
	        PV.staffID AS หมายเลขพนักงาน,
	        PV.doctorID AS หมายเลขแพทย์, 
            (S.firstName + ' ' + S.lastName) AS ชื่อแพทย์,
	        PV.wardID AS หมายเลขวอร์ด, 
	        app_date AS เวลาที่เข้าพบแพทย์, 
	        app_type AS วิธีการพบแพทย์, 
	        PV.updateAt AS แก้ไขล่าสุด, 
	        PV.status AS สถานะ
        FROM Patient_Visits AS PV
        INNER JOIN Patients AS P ON (PV.patientID = P.patientID)
        INNER JOIN Doctors AS D ON (PV.doctorID = D.doctorID)
        INNER JOIN Staffs AS S ON (D.staffID = S.staffID)
		WHERE PV.visitID NOT IN (SELECT visitID FROM Patient_Wards);"
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' set value to data grid view
        visitDatagrid.DataSource = dataTable

        If dataTable IsNot Nothing Then
            ' frozen first column
            visitDatagrid.Columns(0).Frozen = True
        Else
            ' if no record found
            MessageBox.Show("ไม่พบข้อมูลประวัติผู้ป่วยรายใหม่" + Environment.NewLine + "กรุณาเพิ่มข้อมูลประวัติผู้ป่วยก่อนเป็นอันดับแรก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Return
        End If

        ' make data grid can't select all rows
        visitDatagrid.MultiSelect = False

        ' get wardID combobox
        wardID_combobox = StaffForm.getWardIDtoCombobox(wardID_combobox)
        Console.WriteLine("Count of wardID_combobox : " + wardID_combobox.Items.Count.ToString)
        wardID_combobox.Items.RemoveAt(17)

        ' get CNID from main form
        If MainForm.cnID <> "" Or MainForm.isAdmin = True Then
            cnID.Text = MainForm.cnID
        Else
            ' message box notify that not have permission to open this page
            MsgBox("คุณไม่มีสิทธิ์เข้าถึงหน้านี้")

            Me.Close()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        patientId.Text = ""
        visitID.Text = ""
        'cnID.Text = ""
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

            ' cut string in wardID in last 2 character
            Dim wardIDString As String = wardID.Substring(wardID.Length - 2)
            Console.WriteLine("Substring" + wardIDString)

            ' parse wardIDString to integer
            Dim wardIDInt As Integer = Integer.Parse(wardIDString)
            Console.WriteLine(wardIDInt)

            backupWardID = wardIDString

            ' check if wardIDInt is more than 17 it is out patient ward
            If wardIDInt > 17 Then
                ' set patient type to out patient
                patientType_combobox.SelectedIndex = 1
            Else
                ' set patient type to in patient
                patientType_combobox.SelectedIndex = 0
            End If

        Catch ex As Exception
            'Show Message box error to selected row
            MsgBox("เกิดข้อผิดพลาด : " + Environment.NewLine + ex.Message)
        End Try
    End Sub

    Private Sub btnCheckDoctor_Click(sender As Object, e As EventArgs) Handles btnCheckDoctor.Click
        pop_Doc.Show()
    End Sub

    Private Sub patientType_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientType_combobox.SelectedIndexChanged

        If patientType_combobox.SelectedIndex = 1 Then
            ' force wardID combobox to selected index 17
            ' is that Out Patient Ward

            ' clear wardID_combobox selected index
            wardID_combobox.SelectedIndex = -1
            ' check if wardID_combobox total item is more than 17
            If wardID_combobox.Items.Count = 17 Then
                wardID_combobox.Items.Add("W0018")
            End If
            wardID_combobox.SelectedIndex = 17
            wardID_combobox.Enabled = False
        Else
            wardID_combobox.Enabled = True
            If wardID_combobox.Items.Count = 18 Then
                wardID_combobox.Items.RemoveAt(17)
            End If

        End If
    End Sub

End Class