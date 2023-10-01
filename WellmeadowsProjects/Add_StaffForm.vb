Public Class Add_StaffForm

    Dim panel As New Panel()

    Dim inputControls As New List(Of Control)()
    Dim inputControlsExp As New List(Of Control)()

    Dim count As Integer = 0
    Dim count2 As Integer = 0



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a button to add more input items

        panel.Dock = DockStyle.Fill
        panel.AutoScroll = False

        panel.Controls.Add(headerlb)

        panel.Controls.Add(subheaderlb1)
        panel.Controls.Add(fnamelb)
        panel.Controls.Add(lnamelb)
        panel.Controls.Add(doblb)
        panel.Controls.Add(genderlb)
        panel.Controls.Add(tellb)
        panel.Controls.Add(ninlb)
        panel.Controls.Add(addresslb)
        panel.Controls.Add(Staff_firstName)
        panel.Controls.Add(Staff_lastName)
        panel.Controls.Add(Staff_dob)
        panel.Controls.Add(Staff_gender)
        panel.Controls.Add(Staff_tel)
        panel.Controls.Add(Staff_nin)
        panel.Controls.Add(Staff_address)


        panel.Controls.Add(subheaderlb2)
        panel.Controls.Add(positionlb)
        panel.Controls.Add(salarylb)
        panel.Controls.Add(salaryscallb)
        panel.Controls.Add(paidtypelb)
        panel.Controls.Add(hoursweeklb)
        panel.Controls.Add(contacttylelb)
        panel.Controls.Add(Staff_position)
        panel.Controls.Add(Staff_salary)
        panel.Controls.Add(Staff_salaryScale)
        panel.Controls.Add(Staff_paidType)
        panel.Controls.Add(Staff_hoursWeek)
        panel.Controls.Add(Staff_contactType)


        panel.Controls.Add(subheader3)
        panel.Controls.Add(typelb)
        panel.Controls.Add(majorlb)
        panel.Controls.Add(finishdatelb)
        panel.Controls.Add(statuslb)


        panel.Controls.Add(subheader4)
        panel.Controls.Add(hiscompanylb)
        panel.Controls.Add(hisenddatelb)
        panel.Controls.Add(hispositionlb)
        panel.Controls.Add(hisstartdatelb)
        panel.Controls.Add(statuslb2)


        panel.Controls.Add(btnAddRow)
        panel.Controls.Add(btnAddRow2)
        panel.Controls.Add(btnDelRow)
        panel.Controls.Add(btnDelRow2)

        panel.Controls.Add(btnClear)
        panel.Controls.Add(btnSubmit)





        AddInputItem()
        AddInputItem2()
        Me.Controls.Add(panel)


    End Sub

    Private Sub AddInputItem()


        If inputControls.Count >= 15 Then
            btnAddRow.Enabled = False
            statuslb.Text = "เพิ่มข้อมูลได้สูงสุด 6**"
        End If

        count = count + 26
        ' Create two TextBox controls for each input item
        Dim textBox1 As New TextBox()
        textBox1.Scale(New SizeF(1.5F, 1.5F))
        textBox1.Location = New Point(76, 458 + count)
        panel.Controls.Add(textBox1)
        inputControls.Add(textBox1)

        Dim textBox2 As New TextBox()
        textBox2.Scale(New SizeF(1.5F, 1.5F))
        textBox2.Location = New Point(256, 458 + count)
        panel.Controls.Add(textBox2)
        inputControls.Add(textBox2)

        ' Create a DateTimePicker control for each input item
        Dim dateTimePicker As New DateTimePicker()
        dateTimePicker.Location = New Point(423 - 4, 458 + count)
        panel.Controls.Add(dateTimePicker)
        inputControls.Add(dateTimePicker)


        If inputControls.Count < 15 Then
            statuslb.Text = ""
        End If

        If inputControls.Count > 3 Then
            btnDelRow.Enabled = True

        End If


    End Sub

    Private Sub AddInputItem2()


        If inputControlsExp.Count >= 20 Then
            btnAddRow2.Enabled = False
            statuslb2.Text = "เพิ่มข้อมูลได้สูงสุด 6**"
        End If

        count2 = count2 + 26

        Dim positionbox As New TextBox()
        positionbox.Scale(New SizeF(1.5F, 1.5F))
        positionbox.Location = New Point(56, 700 + count2)
        panel.Controls.Add(positionbox)
        inputControlsExp.Add(positionbox)

        Dim companybox As New TextBox()
        companybox.Scale(New SizeF(1.5F, 1.5F))
        companybox.Location = New Point(234, 700 + count2)
        panel.Controls.Add(companybox)
        inputControlsExp.Add(companybox)


        Dim startdate As New DateTimePicker()
        startdate.Location = New Point(409, 700 + count2)
        panel.Controls.Add(startdate)
        inputControlsExp.Add(startdate)



        Dim enddate As New DateTimePicker()
        enddate.Location = New Point(635, 700 + count2)
        panel.Controls.Add(enddate)
        inputControlsExp.Add(enddate)



        If inputControlsExp.Count < 20 Then
            statuslb2.Text = ""
        End If

        If inputControlsExp.Count > 4 Then
            btnDelRow2.Enabled = True

        End If


    End Sub

    Private Sub DeleteLastInputItem()

        Console.WriteLine(inputControls.Count)
        If inputControls.Count = 3 Then
            btnDelRow.Enabled = False
            statuslb.Text = "ต้องมีอย่างน้อย1**"

            Return
        End If

        statuslb.Text = ""
        ' Check if there are any input items to delete
        If inputControls.Count > 1 Then
            ' Get the last added input item (3 controls per item)
            Dim lastInputIndex As Integer = inputControls.Count - 3
            If lastInputIndex >= 0 Then
                ' Remove and dispose of the controls associated with the last input item
                For i As Integer = lastInputIndex To lastInputIndex + 2
                    panel.Controls.Remove(inputControls(i))
                    inputControls(i).Dispose()
                Next

                ' Remove the last added input item from the list
                inputControls.RemoveRange(lastInputIndex, 3)
                count = count - 26

            End If
        End If

        ' Enable the add button (assuming it's named "btnAddRow")
        btnAddRow.Enabled = True
        statuslb.Text = "" ' Clear status message


    End Sub


    Private Sub DeleteLastInputItem2()

        Console.WriteLine(inputControlsExp.Count)
        If inputControlsExp.Count = 4 Then
            btnDelRow2.Enabled = False
            statuslb2.Text = "ต้องมีอย่างน้อย1**"

            Return
        End If

        ' Ensure that there is at least one item remaining before attempting to delete
        If inputControlsExp.Count >= 4 Then
            ' Get the index of the controls associated with the last input item
            Dim lastInputIndex As Integer = inputControlsExp.Count - 4

            ' Remove and dispose of the controls associated with the last input item
            For i As Integer = lastInputIndex To lastInputIndex + 3
                panel.Controls.Remove(inputControlsExp(i))
                inputControlsExp(i).Dispose()
            Next

            ' Remove the last added input item from the list
            inputControlsExp.RemoveRange(lastInputIndex, 4)
            count2 = count2 - 26
        Else
            ' Handle the case when there are not enough items to delete
            btnDelRow2.Enabled = False
            statuslb2.Text = "ต้องมีอย่างน้อย 1**"
            Return
        End If

        ' Enable the add button (assuming it's named "btnAddRow2")
        btnAddRow2.Enabled = True
        statuslb2.Text = "" ' Clear status message
    End Sub

    Private Sub PrintControlData()
        Console.WriteLine("Printing Control Data:")

        For Each control As Control In inputControlsExp
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                Console.WriteLine("TextBox Text: " & textBox.Text)
            ElseIf TypeOf control Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = DirectCast(control, DateTimePicker)
                Console.WriteLine("DateTimePicker Value: " & dateTimePicker.Value.ToString())
                ' Add more control types and their properties as needed
            End If
        Next
    End Sub

    Private Sub ResetInputControls()
        ' Remove and dispose of the controls associated with inputControlsExp
        For Each control As Control In inputControls
            panel.Controls.Remove(control)
            control.Dispose()
        Next

        ' Clear the inputControlsExp list
        inputControls.Clear()

        ' Reset any other variables or UI elements as needed
        count = 0
        'btnDelRow2.Enabled = True
        statuslb.Text = ""

    End Sub

    Private Sub ResetInputControlsExp()
        ' Remove and dispose of the controls associated with inputControlsExp
        For Each control As Control In inputControlsExp
            panel.Controls.Remove(control)
            control.Dispose()
        Next

        ' Clear the inputControlsExp list
        inputControlsExp.Clear()

        ' Reset any other variables or UI elements as needed
        count2 = 0
        'btnDelRow2.Enabled = True
        statuslb2.Text = ""
    End Sub

    Private Sub ResetForm()

        ResetInputControlsExp()
        ResetInputControls()

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
        AddInputItem2()
        AddInputItem()
    End Sub




    Private Sub btnAddRow_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddRow.MouseClick
        AddInputItem()
    End Sub

    Private Sub btnDelRow_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDelRow.MouseClick
        DeleteLastInputItem()
    End Sub

    Private Sub btnAddRow2_Click(sender As Object, e As EventArgs) Handles btnAddRow2.Click
        AddInputItem2()
    End Sub

    Private Sub btnDelRow2_Click(sender As Object, e As EventArgs) Handles btnDelRow2.Click
        DeleteLastInputItem2()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        PrintControlData()
        ResetForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub
End Class
