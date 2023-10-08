Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Add_InPatient
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(ip_id.Text) Then
            ip_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(ip_date.Text) Then
            ip_date.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(ipw_id.Text) Then
            ipw_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(ipb_id.Text) Then
            ipb_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(ips_id.Text) Then
            ips_id.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(ip_expect.Text) Then
            ip_expect.Text = String.Empty
        End If
    End Sub

    Private Sub Add_InPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Beds' table. You can move, or remove it, as needed.
        Me.BedsTableAdapter.Fill(Me.WellmeadowsDataSet.Beds)

    End Sub
End Class