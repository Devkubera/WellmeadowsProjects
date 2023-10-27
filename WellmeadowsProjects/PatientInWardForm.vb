Public Class PatientInWardForm
    Public backUpDataTable As DataTable
    Public Sub PatientInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' if user is not md and cn
        Console.WriteLine(MainForm.mdID & "mdID")
        Console.WriteLine(MainForm.cnID & "cnID")
        If MainForm.cnID <> "" Or MainForm.isAdmin = True Then
            Console.WriteLine("if")
            btnReport.Visible = True
            btnAdd.Visible = True
            btnEdit.Visible = True
            btnDel.Visible = True
        ElseIf MainForm.mdID <> "" Then
            Console.WriteLine("else if")
            btnReport.Visible = True
            btnAdd.Visible = False
            btnEdit.Visible = False
            btnDel.Visible = False
        Else
            Console.WriteLine("else")
            btnReport.Visible = False
            btnAdd.Visible = False
            btnEdit.Visible = False
            btnDel.Visible = False
        End If

        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Wards' table. You can move, or remove it, as needed.
        ' Me.Patient_WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Wards)

        ' query all patient in ward
        Dim sqlCode = "SELECT 
	                    PW.pwID,
	                    PW.patientID AS 'หมายเลขผู้ป่วย',
	                    P.firstName + ' ' + P.lastName AS 'ชื่อผู้ป่วย',
	                    PW.patientType AS 'ประเภทผู้ป่วย',
                        PW.visitID AS 'หมายเลขประวัติผู้ป่วย',
	                    PW.doctorID AS 'หมายเลขแพทย์',
	                    S.firstName + ' ' + S.lastName AS 'แพทย์',
	                    PW.cnID AS 'หมายเลขหัวหน้าพยาบาล',
	                    CN.firstName + ' ' + CN.lastName AS 'หัวหน้าพยาบาล',
	                    PW.wardID AS 'หมายเลขวอร์ด',
	                    PW.on_ward_date AS 'วันที่เข้ารับการรักษา',
	                    PW.symptom AS 'อาการเบื้องต้น',
	                    PW.updateAt AS 'อัพเดทล่าสุด'
                    FROM Patient_Wards AS PW
                    INNER JOIN Patients AS P ON (PW.patientID = P.patientID)
                    INNER JOIN Doctors AS D ON (PW.doctorID = D.doctorID)
                    INNER JOIN Staffs AS S ON (D.staffID = S.staffID)
                    INNER JOIN ChargeNurses AS C ON (PW.cnID = C.cnID)
                    INNER JOIN Staffs AS CN ON (C.staffID = CN.staffID)"
        ' execute sql code
        Dim result As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' set value to data grid view
        pateintInWardTable.DataSource = result

        ' set frozen first column
        If result IsNot Nothing Then
            pateintInWardTable.Columns(0).Frozen = True

        End If

        backUpDataTable = result

        cbbPtype.SelectedIndex = 0
        cbbPtype_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_PateintToWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' set value to edit patient to ward form
        Edit_PateintToWardForm.pwID =
            pateintInWardTable.SelectedRows(0).Cells(0).Value.ToString

        Edit_PateintToWardForm.patientId.Text =
            pateintInWardTable.SelectedRows(0).Cells(1).Value.ToString

        Edit_PateintToWardForm.patientName.Text =
            pateintInWardTable.SelectedRows(0).Cells(2).Value.ToString

        Edit_PateintToWardForm.patientType_combobox.Text =
            pateintInWardTable.SelectedRows(0).Cells(3).Value.ToString

        Edit_PateintToWardForm.visitID.Text =
            pateintInWardTable.SelectedRows(0).Cells(4).Value.ToString

        Edit_PateintToWardForm.doctorID.Text =
            pateintInWardTable.SelectedRows(0).Cells(5).Value.ToString

        Edit_PateintToWardForm.doctorName.Text =
            pateintInWardTable.SelectedRows(0).Cells(6).Value.ToString

        Edit_PateintToWardForm.cnID.Text =
            pateintInWardTable.SelectedRows(0).Cells(7).Value.ToString

        Edit_PateintToWardForm.wardID_combobox.Text =
            pateintInWardTable.SelectedRows(0).Cells(9).Value.ToString

        Edit_PateintToWardForm.symptom.Text =
            pateintInWardTable.SelectedRows(0).Cells(11).Value.ToString

        Edit_PateintToWardForm.Show()
    End Sub

    Private Sub cbbPtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbPtype.SelectedIndexChanged
        If cbbPtype.SelectedIndex = 0 Then
            btnReport.Text = "สร้างรายงานผู้ป่วยใน"
            ' set data source to data grid view
            pateintInWardTable.DataSource = backUpDataTable

            btnReport.Visible = False
        ElseIf cbbPtype.SelectedIndex = 1 Then

            ' check main form CN and MD is available
            If MainForm.cnID <> "" Or MainForm.mdID <> "" Then
                btnReport.Visible = True
            Else
                btnReport.Visible = False
            End If

            btnReport.Text = "สร้างรายงานผู้ป่วยใน"
            ' query in-patient to ward by patient type
            Dim sqlCode = "SELECT 
                        PW.pwID,
                        PW.patientID AS 'หมายเลขผู้ป่วย',
                        P.firstName + ' ' + P.lastName AS 'ชื่อผู้ป่วย',
                        PW.patientType AS 'ประเภทผู้ป่วย',
                        PW.visitID AS 'หมายเลขประวัติผู้ป่วย',
                        PW.doctorID AS 'หมายเลขแพทย์',
                        S.firstName + ' ' + S.lastName AS 'แพทย์',
                        PW.cnID AS 'หมายเลขหัวหน้าพยาบาล',
                        CN.firstName + ' ' + CN.lastName AS 'หัวหน้าพยาบาล',
                        PW.wardID AS 'หมายเลขวอร์ด',
                        PW.on_ward_date AS 'วันที่เข้ารับการรักษา',
                        PW.symptom AS 'อาการเบื้องต้น',
                        PW.updateAt AS 'อัพเดทล่าสุด'
                    FROM Patient_Wards AS PW
                    INNER JOIN Patients AS P ON (PW.patientID = P.patientID)
                    INNER JOIN Doctors AS D ON (PW.doctorID = D.doctorID)
                    INNER JOIN Staffs AS S ON (D.staffID = S.staffID)
                    INNER JOIN ChargeNurses AS C ON (PW.cnID = C.cnID)
                    INNER JOIN Staffs AS CN ON (C.staffID = CN.staffID)
                    WHERE PW.patientType = 'ผู้ป่วยใน'"
            ' execute sql code
            Dim datatable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
            ' set value to data grid view
            pateintInWardTable.DataSource = datatable
        Else

            ' check main form CN and MD is available
            If MainForm.cnID <> "" Or MainForm.mdID <> "" Then
                btnReport.Visible = True
            Else
                btnReport.Visible = False
            End If

            btnReport.Text = "สร้างรายงานผู้ป่วยนอก"
            ' query out-patient to ward by patient type
            Dim sqlCode = "SELECT 
                        PW.pwID,
                        PW.patientID AS 'หมายเลขผู้ป่วย',
                        P.firstName + ' ' + P.lastName AS 'ชื่อผู้ป่วย',
                        PW.patientType AS 'ประเภทผู้ป่วย',
                        PW.visitID AS 'หมายเลขประวัติผู้ป่วย',
                        PW.doctorID AS 'หมายเลขแพทย์',
                        S.firstName + ' ' + S.lastName AS 'แพทย์',
                        PW.cnID AS 'หมายเลขหัวหน้าพยาบาล',
                        CN.firstName + ' ' + CN.lastName AS 'หัวหน้าพยาบาล',
                        PW.wardID AS 'หมายเลขวอร์ด',
                        PW.on_ward_date AS 'วันที่เข้ารับการรักษา',
                        PW.symptom AS 'อาการเบื้องต้น',
                        PW.updateAt AS 'อัพเดทล่าสุด'
                    FROM Patient_Wards AS PW
                    INNER JOIN Patients AS P ON (PW.patientID = P.patientID)
                    INNER JOIN Doctors AS D ON (PW.doctorID = D.doctorID)
                    INNER JOIN Staffs AS S ON (D.staffID = S.staffID)
                    INNER JOIN ChargeNurses AS C ON (PW.cnID = C.cnID)
                    INNER JOIN Staffs AS CN ON (C.staffID = CN.staffID)
                    WHERE PW.patientType = 'ผู้ป่วยนอก'"
            ' execute sql code
            Dim datatable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
            ' set value to data grid view
            pateintInWardTable.DataSource = datatable
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If cbbPtype.SelectedIndex = 0 Then
            ' Nothing
        ElseIf cbbPtype.SelectedIndex = 1 Then
            Report_In_PatientForm.Show()
        Else
            Report_Out_PatientForm.Show()
        End If
    End Sub

    Private Sub patientInWardPanel_Paint(sender As Object, e As PaintEventArgs) Handles patientInWardPanel.Paint

    End Sub

    Private Sub Patient_WardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Patient_WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ' check if data grid selected row is empty by try cast
        Dim selectedRow As DataGridViewRow = pateintInWardTable.CurrentRow
        If selectedRow Is Nothing Then
            MsgBox("กรุณาเลือกข้อมูลที่ต้องการลบ")
            Return
        End If

        Try
            If pateintInWardTable.CurrentRow IsNot Nothing Then
                ' get patient in ward id
                Dim pwID As String = pateintInWardTable.SelectedRows(0).Cells(0).Value.ToString
                ' sql delete patient in ward by patient in ward id
                Dim sqlCode = $"DELETE FROM Patient_Wards WHERE pwID = '{pwID}'"
                ' execute sql code
                StaffForm.sqlExecuteNonQuery(sqlCode)

                MessageBox.Show("ลบข้อมูลสำเร็จ")

                ' reload data grid view
                PatientInWardForm_Load(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged

        ' check if search box is empty, Then data source is back up data table
        If searchBox.Text = "" Then
            pateintInWardTable.DataSource = backUpDataTable
        End If

        ' search data in data grid view with patient name by sql query
        Dim sqlCode = $"SELECT 
                        PW.pwID,
                        PW.patientID AS 'หมายเลขผู้ป่วย',
                        P.firstName + ' ' + P.lastName AS 'ชื่อผู้ป่วย',
                        PW.patientType AS 'ประเภทผู้ป่วย',
                        PW.visitID AS 'หมายเลขประวัติผู้ป่วย',
                        PW.doctorID AS 'หมายเลขแพทย์',
                        S.firstName + ' ' + S.lastName AS 'แพทย์',
                        PW.cnID AS 'หมายเลขหัวหน้าพยาบาล',
                        CN.firstName + ' ' + CN.lastName AS 'หัวหน้าพยาบาล',
                        PW.wardID AS 'หมายเลขวอร์ด',
                        PW.on_ward_date AS 'วันที่เข้ารับการรักษา',
                        PW.symptom AS 'อาการเบื้องต้น',
                        PW.updateAt AS 'อัพเดทล่าสุด'
                    FROM Patient_Wards AS PW
                    INNER JOIN Patients AS P ON (PW.patientID = P.patientID)
                    INNER JOIN Doctors AS D ON (PW.doctorID = D.doctorID)
                    INNER JOIN Staffs AS S ON (D.staffID = S.staffID)
                    INNER JOIN ChargeNurses AS C ON (PW.cnID = C.cnID)
                    INNER JOIN Staffs AS CN ON (C.staffID = CN.staffID)
                    WHERE P.firstName LIKE '%{searchBox.Text}%' 
                        OR P.lastName LIKE '%{searchBox.Text}%'"

        ' set data to data table
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        ' set value to data grid view
        pateintInWardTable.DataSource = dataTable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InPatient.Show()
    End Sub
End Class