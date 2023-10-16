Public Class Add_Medicine
    Public supID As String = ""
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If Not String.IsNullOrEmpty(m_name.Text) Then
            m_name.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_desc.Text) Then
            m_desc.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_method.Text) Then
            m_method.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_scale.Text) Then
            m_scale.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_stock.Text) Then
            m_stock.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_unit.Text) Then
            m_unit.Text = String.Empty
        End If
        If Not String.IsNullOrEmpty(m_dosage.Text) Then
            m_dosage.Text = String.Empty
        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim Mname = m_name.Text
            Dim Mdesc = m_desc.Text
            Dim Mdosage = m_dosage.Text
            Dim Mmethod = m_method.Text
            Dim Mstock = m_stock.Text
            Dim Mscale = m_scale.Text
            Dim Munit = m_unit.Text

            If (supID <> "") Then
                System.Console.WriteLine("If Case from KIN" & supID)

            Else
                Dim supName = m_sup.Text

                SuppilersTableAdapter.InsertSupID(supName)
                supID = SuppilersTableAdapter.getLastSupID()
                System.Console.WriteLine("Else Case")
                System.Console.WriteLine(supID)
            End If

            ' เช็คว่าข้อมูลถูกกรอกหรือไม่
            If String.IsNullOrEmpty(Mname) OrElse String.IsNullOrEmpty(Mdesc) OrElse String.IsNullOrEmpty(Mdosage) OrElse
        String.IsNullOrEmpty(Mmethod) OrElse String.IsNullOrEmpty(Mstock) OrElse String.IsNullOrEmpty(Mscale) OrElse
        String.IsNullOrEmpty(Munit) Then
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' เมื่อข้อมูลถูกกรอกครบ ให้เพิ่มข้อมูลลงในฐานข้อมูล
            ' ในส่วนนี้คุณสามารถกำหนดค่า Msup เป็นค่าว่างหรือค่าเริ่มต้นจากตาราง Supplies ที่ถูกต้อง
            'Dim Msup As Integer? = Nothing ' หรือค่าเริ่มต้นอื่น ๆ ที่เหมาะสม
            Me.Med_MedicinesTableAdapter.InsertMedicine(supID, Mname, Mdesc, Mdosage, Mmethod, Mstock, Mscale, Munit)
            Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)

            ' message box notify insert success
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error. please check your data fill", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub



    Private Sub Med_MedicinesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Med_MedicinesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub Add_Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Suppilers' table. You can move, or remove it, as needed.
        Me.SuppilersTableAdapter.Fill(Me.WellmeadowsDataSet.Suppilers)
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Suppilers' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Med_Medicines' table. You can move, or remove it, as needed.
        Me.Med_MedicinesTableAdapter.Fill(Me.WellmeadowsDataSet.Med_Medicines)

        SetEnabledSuplier()
        SetDisabledSupplier()
    End Sub

    Private Sub btnCheck_sup_Click(sender As Object, e As EventArgs) Handles btnCheck_sup.Click
        popup_supplies.ShowDialog()
    End Sub

    Public Sub SetDisabledSupplier()
        m_sup.Enabled = False

    End Sub

    Public Sub SetEnabledSuplier()
        m_sup.Enabled = True
    End Sub
End Class