Imports System.Windows.Forms.AxHost
Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Add_Patient
    Public kinID As String = ""
    Public localID As String = ""
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(pt_firstName.Text) Then
            pt_firstName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_lastName.Text) Then
            pt_lastName.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_birthday.Text) Then
            pt_birthday.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_gender.Text) Then
            pt_gender.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_tel.Text) Then
            pt_tel.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_date.Text) Then
            pt_date.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_status.Text) Then
            pt_status.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(pt_address.Text) Then
            pt_address.Text = String.Empty
        End If

        If Not String.IsNullOrEmpty(kinID) Then
            kinID = Nothing
        End If
        If Not String.IsNullOrEmpty(localID) Then
            localID = Nothing
        End If


        SetEnabledKin()
        ResetKin()
        SetEnabledLocal()
        ResetLocal()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pt_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pt_status.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            'custom date format
            pt_birthday.Format = DateTimePickerFormat.Custom
            pt_birthday.CustomFormat = "dd/MM/yyyy"
            pt_date.Format = DateTimePickerFormat.Custom
            pt_date.CustomFormat = "dd/MM/yyyy"
            Dim Pfname = pt_firstName.Text
            Dim Plname = pt_lastName.Text
            Dim Pdob = pt_birthday.Text
            Dim Pgender = pt_gender.Text
            Dim Ptel = pt_tel.Text
            Dim PdateRegis = pt_date.Text
            Dim Pstatus = pt_status.Text
            Dim Paddress = pt_address.Text

            If (kinID <> "") Then
                System.Console.WriteLine("If Case from KIN" & kinID)
            Else
                Dim Kname = kin_fullName.Text
                Dim Kaddress = kin_address.Text
                Dim Krela = kin_rela.Text
                Dim Ktel = kin_tel.Text

                Patient_kinsTableAdapter.InsertKins(Kname, Kaddress, Krela, Ktel)
                kinID = Patient_kinsTableAdapter.getLastKinID()
                System.Console.WriteLine("Else Case")
                System.Console.WriteLine(kinID)
            End If

            If (localID <> "") Then
                System.Console.WriteLine("If Case from Local" & localID)
            Else
                Dim Lname = local_fullName.Text
                Dim Ltel = local_tel.Text
                Dim Laddress = local_address.Text
                Dim Lclinic = local_clinic_ID.Text

                LocalDoctorsTableAdapter.InsertLocalDoctor(Lname, Lclinic, Laddress, Ltel)
                localID = LocalDoctorsTableAdapter.getLastLocID()
                System.Console.WriteLine("Else Case")
                System.Console.WriteLine(localID)
            End If

            Console.WriteLine(pt_date.Value & " date regis")
            Console.WriteLine(pt_birthday.Value & " DOB")
            Me.PatientsTableAdapter.InsertPatient(Pfname, Plname, Paddress, Pgender, Pstatus, Ptel, pt_birthday.Value, pt_date.Value, kinID, localID)
            Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error. please check your data fill", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnCheck_kin_Click(sender As Object, e As EventArgs) Handles btnCheck_kin.Click
        popup_patientKin.ShowDialog()
    End Sub

    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub Add_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.LocalDoctors' table. You can move, or remove it, as needed.
        Me.LocalDoctorsTableAdapter.Fill(Me.WellmeadowsDataSet.LocalDoctors)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patient_kins' table. You can move, or remove it, as needed.
        Me.Patient_kinsTableAdapter.Fill(Me.WellmeadowsDataSet.Patient_kins)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.WellmeadowsDataSet.Patients)

    End Sub

    Public Sub SetDisabledKin()
        kin_fullName.Enabled = False
        kin_address.Enabled = False
        kin_rela.Enabled = False
        kin_tel.Enabled = False
    End Sub

    Public Sub SetEnabledKin()
        kin_fullName.Enabled = True
        kin_address.Enabled = True
        kin_rela.Enabled = True
        kin_tel.Enabled = True
    End Sub

    Public Sub ResetKin()
        kinID = String.Empty
        kin_address.Text = String.Empty
        kin_fullName.Text = String.Empty
        kin_rela.Text = String.Empty
        kin_tel.Text = String.Empty
    End Sub

    Public Sub SetEnabledLocal()
        local_fullName.Enabled = True
        local_address.Enabled = True
        local_clinic_ID.Enabled = True
        local_tel.Enabled = True
    End Sub

    Public Sub ResetLocal()
        localID = String.Empty
        local_fullName.Text = String.Empty
        local_address.Text = String.Empty
        local_clinic_ID.Text = String.Empty
        local_tel.Text = String.Empty
    End Sub

    Public Sub SetDisabledDoc()
        local_fullName.Enabled = False
        local_address.Enabled = False
        local_clinic_ID.Enabled = False
        local_tel.Enabled = False
    End Sub

    Private Sub btnCheckLocal_Click(sender As Object, e As EventArgs) Handles btnCheckLocal.Click
        popup_localDoctor.ShowDialog()
    End Sub

End Class