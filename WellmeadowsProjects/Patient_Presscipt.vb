﻿Public Class Patient_Presscipt
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Presscipt.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Edit_Presscript.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Report_PrescriptForm.Show()
    End Sub

    Private Sub Patient_Presscipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class