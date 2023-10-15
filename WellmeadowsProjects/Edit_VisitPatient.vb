Public Class Edit_VisitPatient
    Public visitID = ""
    Private Sub Edit_VisitPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Try
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

            Console.WriteLine("VISIT ID : " + visitID)

            ' sql update patient visit by using visitID and update all fields
            Dim sqlCode = $"UPDATE Patient_Visits SET 
            patientID = '{visit_p_ID.Text}',
            staffID = '{staffID}',
            doctorID = '{visit_d_ID.Text}',
            wardID = '{visit_w_Id.Text}',
            app_date = '{visit_date.Text}',
            app_type = '{visit_type.Text}',
            updateAt = GETDATE()
            WHERE visitID = '{visitID}'"
            StaffForm.sqlExecuteNonQuery(sqlCode)

            MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว")
            ' refresh patient visit data grid
            Patient_Visit.Patient_Visit_Load(sender, e)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไขข้อมูล " + Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class