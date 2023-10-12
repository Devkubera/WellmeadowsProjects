Public Class PatientInWardForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_PateintToWardForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit_PateintToWardForm.Show()
    End Sub

    Private Sub PatientInWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_Wards' table. You can move, or remove it, as needed.
        Me.Patient_WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_Wards)
        Console.WriteLine(MainForm.mdID & "mdID")
        Console.WriteLine(MainForm.cnID & "cnID")
        If MainForm.cnID <> "" Then
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



    End Sub

End Class