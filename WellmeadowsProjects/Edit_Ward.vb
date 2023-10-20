Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Edit_Ward
    Public wardID As String = ""

    Private Sub Edit_Ward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Wards)
        Console.WriteLine(wardID)
    End Sub

    Private Sub WardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDataSet)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            WardsTableAdapter.UpdateWard(
                ward_name.Text,
                ward_location.Text,
                ward_tel.Text,
                wardID
            )

            MessageBox.Show("เพิ่มข้อมูลสำเร็จ !", "เพิ่มข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            WardForm.WardForm_Load(sender, e)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผผิดพลาดในการแก้ไขข้อมูล กรุณาตรวจสอบข้อมูลของท่าน " + Environment.NewLine + ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
End Class