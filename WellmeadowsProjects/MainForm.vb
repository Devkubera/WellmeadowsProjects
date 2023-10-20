Public Class MainForm
    Public staffID As String = ""
    Public position As String = ""
    Public cnID As String = ""
    Public mdID As String = ""
    Public doctorID As String = ""
    Public personalID As String = ""
    Public isAdmin As Boolean = False

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

        Console.WriteLine($"cnID {cnID}")
        Console.WriteLine($"mdID {mdID}")
        Console.WriteLine($"personalID {personalID}")
        Console.WriteLine($"doctorID {doctorID}")
        Console.WriteLine($"staffID {staffID}")
        Console.WriteLine($"position {position}")

        If personalID = "" And isAdmin = False Then
            ' remove column in table layout panel
            TableLayoutPanel1.ColumnStyles(1).Width = 0
        End If

        If cnID = "" And isAdmin = False Then
            ' remove column in table layout panel
            TableLayoutPanel1.ColumnStyles(4).Width = 0
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Controls.Add(New TextBox)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim home = New HomeForm()
        switchForm(home)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
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
        Dim medicine = New Medicine()
        switchForm(medicine)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboard = New DashbordForm()
        switchForm(dashboard)

    End Sub
End Class
