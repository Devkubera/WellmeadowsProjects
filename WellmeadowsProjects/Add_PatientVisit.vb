Public Class Add_PatientVisit

    Private Sub Add_PatientVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load ward data table and push it to ward_number combobox
        Dim sqlCode = "SELECT wardID FROM Wards"
        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)
        For Each row As DataRow In dataTable.Rows
            visit_w_Id.Items.Add(row("wardID"))
        Next
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' reset all fields

        If Not String.IsNullOrEmpty(visit_date.Text) Then
            visit_date.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_d_ID.Text) Then
            visit_d_ID.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_p_ID.Text) Then
            visit_p_ID.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_w_Id.Text) Then
            visit_w_Id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_type.Text) Then
            visit_type.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_d_name.Text) Then
            visit_d_name.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_p_name.Text) Then
            visit_p_name.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(visit_type.Text) Then
            visit_type.Text = String.Empty
        End If
    End Sub

    Private Sub btnShowPatient_Click(sender As Object, e As EventArgs) Handles btnShowPatient.Click
        popup_patient.Show()
    End Sub

    Private Sub btnShowDoctor_Click(sender As Object, e As EventArgs) Handles btnShowDoctor.Click
        pop_Doc.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' make sure that all fields are not empty
        If String.IsNullOrEmpty(visit_date.Text) Or
                    String.IsNullOrEmpty(visit_d_ID.Text) Or
                    String.IsNullOrEmpty(visit_p_ID.Text) Or
                    String.IsNullOrEmpty(visit_w_Id.Text) Or
                    String.IsNullOrEmpty(visit_type.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน")
            Return
        End If

        ' let say we already have staffID
        Dim staffID = "S1"

        ' sql query to insert data to patient visit table
        Dim sqlCode = $"INSERT INTO Patient_Visits (patientID, staffID, doctorID, wardID, app_date, app_type, status)
        VALUES ('{visit_p_ID.Text}', '{staffID}', '{visit_d_ID.Text}', '{visit_w_Id.Text}', '{visit_date.Text}', '{visit_type.Text}', 'Active');"
        StaffForm.sqlExecuteNonQuery(sqlCode)

        MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว")

        ' refresh patient visit data grid
        Patient_Visit.Patient_Visit_Load(sender, e)

        Me.Close()
    End Sub
End Class