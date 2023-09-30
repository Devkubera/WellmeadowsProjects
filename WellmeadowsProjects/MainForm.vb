Public Class MainForm
    Private Sub switchForm(form As Form)
        pnlMain.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        pnlMain.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formHome = New InPatient()
        switchForm(formHome)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Controls.Add(New TextBox)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim formHome = New Patient()
        switchForm(formHome)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim formHome = New Medicine()
        switchForm(formHome)
    End Sub
End Class
