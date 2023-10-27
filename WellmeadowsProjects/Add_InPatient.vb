Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Add_InPatient
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all field
        ipw_id.Text = ""
        ipb_id.Text = ""
        ip_expect.Text = ""
        ip_date.Text = ""
        ippw_id.Text = ""
        ip_id.Text = ""
    End Sub

    Private Sub Add_InPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Beds' table. You can move, or remove it, as needed.
        Me.BedsTableAdapter.Fill(Me.WellmeadowsDataSet.Beds)

        ' get wardID into combobox
        ipw_id = StaffForm.getWardIDtoCombobox(ipw_id)
    End Sub

    Private Sub ipb_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ipb_id.SelectedIndexChanged

    End Sub

    Private Sub ipw_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ipw_id.SelectedIndexChanged
        ' selected bedID from beds table
        Dim sqlCode As String = "
            SELECT bedID FROM Beds WHERE wardID = '" & ipw_id.Text & "'"

        Dim dataTable As DataTable = StaffForm.sqlQueryDataTable(sqlCode)

        If dataTable Is Nothing Then
            Console.WriteLine("Error not have bed in this ward : " & sqlCode)
            Return
        End If

        ' check dataTable is not empty
        If dataTable.Rows.Count > 0 Then
            ' for each row in datatable
            For Each row As DataRow In dataTable.Rows
                ' check if bedID is exits in datarow
                If Not ipb_id.Items.Contains(row("bedID").ToString()) Then
                    ' add bedID to combobox
                    ipb_id.Items.Add(row("bedID").ToString())
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' open waiting list popup form
        popup_waitingListForm.Show()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' make sure that all field is not empty
        If ip_id.Text = "" Or ippw_id.Text = "" Or ipw_id.Text = "" Or ip_date.Text = "" Or ipb_id.Text = "" Or ip_expect.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' sum date_expected and date_place store in variable
        Dim selectedDate As Date = ip_date.Value
        Dim resultDate As Date = selectedDate.AddDays(Integer.Parse(ip_expect.Text))
        Console.WriteLine("Sum date is : " + resultDate)

        Dim sqlCode As String = $"
            UPDATE In_Patients
            SET
                pwID = '{ippw_id.Text}',
                isGetBed = 1,
                date_place = '{ip_date.Text}',
                date_expected = '{ip_expect.Text}',
                date_leave = '{resultDate}',
                patient_status = 0,
                bedID = '{ipb_id.Text}'
            WHERE pwID = '{ippw_id.Text}';"

        Try
            ' execute sql code
            StaffForm.sqlExecuteNonQuery(sqlCode)
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการเพิ่มข้อมูล")
        End Try

        ' show message box
        MessageBox.Show("เพิ่มข้อมูลเรียบร้อย")

        ' refresh datagridview in inpatient form
        InPatient.InPatient_Load(sender, e)

        ' close this form
        Me.Close()
    End Sub
End Class