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
                ward_bed.Text,
                wardID
            )

            'Patient.ViewPa.Refresh()
            'Patient.Patient_Load(New Object, Nothing)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error. please check your data fill", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class