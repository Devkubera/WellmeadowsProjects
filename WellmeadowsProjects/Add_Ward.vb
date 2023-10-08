Imports System.Windows.Forms.AxHost
Imports WellmeadowsProjects.WellmeadowsDataSetTableAdapters

Public Class Add_Ward
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            Dim Wdname = ward_name.Text
            Dim Wdlocatione = ward_location.Text
            Dim Wdtel = ward_tel.Text
            Dim Wdbed = ward_bed.Text

            Me.WardsTableAdapter.InsertWard(Wdname, Wdlocatione, Wdtel, Wdbed)
            Me.WardsTableAdapter.Fill(Me.WellmeadowsDataSet.Wards)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error. please check your data fill", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

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