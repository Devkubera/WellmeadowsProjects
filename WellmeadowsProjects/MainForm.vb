Public Class MainForm
    Public staffID As String = ""
    Public position As String = ""
    Public cnID As String = ""
    Public mdID As String = ""
    Public doctorID As String = ""
    Public personalID As String = ""
    Private Sub switchForm(form As Form)
        PanelMain.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        PanelMain.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim homeform = New HomeForm()
        switchForm(homeform)
        Console.WriteLine(cnID & "cnId")
        Console.WriteLine(mdID & "mdId")
        Console.WriteLine(personalID & "personalID")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Controls.Add(New TextBox)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim home = New HomeForm()
        switchForm(home)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        If personalID = "" Then
            MessageBox.Show("คุณไม่มีสิทธิเข้าถึงหน้า Staff ได้")
            Return
        End If
        Dim staff = New StaffForm()
        switchForm(staff)
    End Sub

    Private Sub btnWard_Click(sender As Object, e As EventArgs) Handles btnWard.Click
        Dim ward = New WardForm()
        switchForm(ward)
    End Sub

    Private Sub PatientBtn_Click(sender As Object, e As EventArgs) Handles PatientBtn.Click
        Dim patient = New Patient()
        switchForm(patient)
    End Sub

    Private Sub btnMedical_Click(sender As Object, e As EventArgs) Handles btnMedical.Click
        If cnID = "" Then
            MessageBox.Show("คุณไม่มีสิทธิเข้าถึงหน้า Medicine ได้")
            Return
        End If
        Dim medicine = New Medicine()
        switchForm(medicine)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub
End Class
