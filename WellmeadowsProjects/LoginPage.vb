Imports System.Data.SqlClient

Public Class LoginPage
    Dim constr As String = "Data Source=BOB1EE\SQLEXPRESS;Initial Catalog=Wellmeadows;Integrated Security=True"

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim staffIDValue As String = staffID.Text
        Dim staffTelValue As String = staffTel.Text

        If String.IsNullOrEmpty(staffIDValue) OrElse String.IsNullOrEmpty(staffTelValue) Then
            MessageBox.Show("Please enter both Staff ID and Telephone.")
            Return
        End If

        Try
            Using con As New SqlConnection(constr)
                con.Open()
                Dim sql As String = "SELECT * FROM Staffs WHERE staffID=@staffID AND tel=@tel"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@staffID", staffIDValue)
                    cmd.Parameters.AddWithValue("@tel", staffTelValue)
                    Using adater As New SqlDataAdapter(cmd)
                        Dim ds As New DataSet
                        adater.Fill(ds)

                        If ds.Tables(0).Rows.Count > 0 Then
                            'Get data from each column
                            Dim staffID As String = ds.Tables(0).Rows(0)("staffID").ToString()
                            Dim position As String = ds.Tables(0).Rows(0)("position").ToString()
                            If position = "หัวหน้าพยาบาล" Then
                                ' get cnID from ChargNurses Table by sql string
                                Dim sql2 As String = "SELECT cnID FROM ChargeNurses WHERE staffID=@staffID"

                                Using cmd2 As New SqlCommand(sql2, con)
                                    cmd2.Parameters.AddWithValue("@staffID", staffIDValue)
                                    Using adater2 As New SqlDataAdapter(cmd2)
                                        Dim ds2 As New DataSet
                                        adater2.Fill(ds2)

                                        If ds2.Tables(0).Rows.Count > 0 Then
                                            Dim cnID As String = ds2.Tables(0).Rows(0)("cnID").ToString()
                                            MessageBox.Show("cnID : " & cnID)
                                            MainForm.cnID = cnID
                                        End If
                                    End Using
                                End Using
                            ElseIf position = "ผู้อำนวยการโรงพยาบาล" Then
                                ' get mdID from MedicalDirectors Table by sql string
                                Dim sql2 As String = "SELECT mdID FROM MedicalDirectors WHERE staffID=@staffID"
                                Using cmd2 As New SqlCommand(sql2, con)
                                    cmd2.Parameters.AddWithValue("@staffID", staffIDValue)
                                    Using adater2 As New SqlDataAdapter(cmd2)
                                        Dim ds2 As New DataSet
                                        adater2.Fill(ds2)

                                        If ds2.Tables(0).Rows.Count > 0 Then
                                            Dim mdID As String = ds2.Tables(0).Rows(0)("mdID").ToString()
                                            MessageBox.Show("mdID : " & mdID)
                                            MainForm.mdID = mdID
                                        End If
                                    End Using
                                End Using

                            ElseIf position = "แพทย์" Then
                                ' get doctorID from Doctors Table by sql string
                                Dim sql2 As String = "SELECT doctorID FROM Doctors WHERE staffID=@staffID"
                                Using cmd2 As New SqlCommand(sql2, con)
                                    cmd2.Parameters.AddWithValue("@staffID", staffIDValue)
                                    Using adater2 As New SqlDataAdapter(cmd2)
                                        Dim ds2 As New DataSet
                                        adater2.Fill(ds2)

                                        If ds2.Tables(0).Rows.Count > 0 Then
                                            Dim doctorID As String = ds2.Tables(0).Rows(0)("doctorID").ToString()
                                            MessageBox.Show("doctorID : " & doctorID)
                                            MainForm.doctorID = doctorID
                                        End If
                                    End Using
                                End Using

                            ElseIf position = "เจ้าหน้าที่ฝ่ายบุคคล" Then
                                ' get staffID from Staffs Table where position = 'เจ้าหน้าที่ฝ่ายบุคคล' by sql string
                                Dim sql2 As String = "SELECT staffID FROM Staffs WHERE position=@position"
                                Using cmd2 As New SqlCommand(sql2, con)
                                    cmd2.Parameters.AddWithValue("@position", "เจ้าหน้าที่ฝ่ายบุคคล")
                                    Using adater2 As New SqlDataAdapter(cmd2)
                                        Dim ds2 As New DataSet
                                        adater2.Fill(ds2)

                                        If ds2.Tables(0).Rows.Count > 0 Then
                                            Dim staffID2 As String = ds2.Tables(0).Rows(0)("staffID").ToString()
                                            MessageBox.Show("staffID : " & staffID2)
                                            MainForm.personalID = staffID2
                                        End If
                                    End Using
                                End Using

                            End If

                            'MessageBox.Show("staffID : " & staffID & " position : " & position)
                            MessageBox.Show("เข้าสู่ระบบสำเร็จ")
                            Me.Hide()
                            MainForm.Show()
                            'Save staffID to Reuse in Another Form
                            MainForm.staffID = staffIDValue
                            MainForm.position = position


                        Else
                            MessageBox.Show("เข้าสู่ระบบไม่สำเร็จ กรุณาตรวจสอบ")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
