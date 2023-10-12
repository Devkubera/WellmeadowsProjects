Imports System.Reflection

Public Class WardForm
    Private Sub btnStaffInWard_Click(sender As Object, e As EventArgs) Handles btnStaffInWard.Click

        StaffInWardForm.Show()
    End Sub

    Private Sub btnPInward_Click(sender As Object, e As EventArgs) Handles btnPInward.Click
        PatientInWardForm.Show()
    End Sub

    Private Sub btnWaitinglist_Click(sender As Object, e As EventArgs) Handles btnWaitinglist.Click

        WaitingListForm.Show()
    End Sub

    Private Sub btnMedcAndmede_Click(sender As Object, e As EventArgs) 
        Supplies.Show()
    End Sub

    Private Sub WardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Wards' table. You can move, or remove it, as needed.
        'If MainForm.personalID <> "" Or MainForm.cnID <> "" Then
        '    'Console.WriteLine("if")
        '    btnWaitinglist.Visible = False
        '    btnPInward.Visible = False

        'Else
        '    'Console.WriteLine("else")
        '    btnWaitinglist.Visible = True
        '    btnPInward.Visible = True
        'End If
        Me.WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Wards)

    End Sub
End Class