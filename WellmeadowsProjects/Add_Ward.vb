Imports System.Windows.Forms.AxHost
Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Add_Ward
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            Dim Wdname = ward_name.Text
            Dim Wdlocatione = ward_location.Text
            Dim Wdtel = ward_tel.Text

            Me.WardsTableAdapter.InsertWard(Wdname, Wdlocatione, Wdtel)

            MessageBox.Show("เพิ่มข้อมูลสำเร็จ !", "เพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            WardForm.WardForm_Load(sender, e)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผผิดพลาดในการเพิ่มข้อมูล กรุณาตรวจสอบข้อมูลของท่าน " + Environment.NewLine + ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub WardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub Add_Ward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Wards)

    End Sub

End Class