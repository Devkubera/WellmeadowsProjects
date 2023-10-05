Public Class Add_StaffForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a button to add more input items
    End Sub
    Private Sub ResetForm()

        Staff_firstName.Text = ""
        Staff_lastName.Text = ""
        Staff_dob.Value = DateTime.Now
        Staff_gender.Text = ""
        Staff_tel.Text = ""
        Staff_nin.Text = ""
        Staff_address.Text = ""

        Staff_position.Text = ""
        Staff_salary.Text = ""
        Staff_salaryScale.Text = ""
        Staff_paidType.SelectedIndex = -1
        Staff_hoursWeek.Text = ""
        Staff_contactType.SelectedIndex = -1

    End Sub


    Private Sub btnAddRow_MouseClick(sender As Object, e As MouseEventArgs)
        'AddInputItem()

    End Sub

    Private Sub btnDelRow_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub btnAddRow2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDelRow2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Me.Close()
        Dim position = Staff_position.Text
        Dim realPostion = Split(position, ".")
        Console.WriteLine(realPostion(1))
        If realPostion(1) Is Nothing Or realPostion(1) Is "" Then
            realPostion(1) = position
        End If

        If realPostion(1) Is "Doctor" Then
            ' generate doctor ID
        ElseIf realPostion(1) Is "Charge Nurse" Then
            ' generate cn ID
        ElseIf realPostion(1) Is "Medical Director" Then
            ' generate md ID
        Else

        End If

        'Staff Data
        'Dim firstName = Staff_firstName.Text
        'Dim lastName = Staff_lastName.Text
        'Dim dob = Staff_dob.Value
        'Dim gender = Staff_gender.Text
        'Dim tel = Staff_tel.Text
        'Dim nin = Staff_nin.Text
        'Dim address = Staff_address.Text

        'Dim salary = Staff_salary.Text
        'Dim salaryScale = Staff_salaryScale.Text
        'Dim paidType = Staff_paidType.Text
        'Dim hoursWeek = Staff_hoursWeek.Text
        'Dim contactType = Staff_contactType.Text

        'ResetForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetForm()
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click

    End Sub

    Private Sub btnAddRow2_Click_1(sender As Object, e As EventArgs) Handles btnAddRow2.Click

    End Sub

End Class
