Public Class Supplies
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Supplies.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Edit_Supplies.Show()
    End Sub

    Private Sub Supplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Suppilers' table. You can move, or remove it, as needed.
        Me.SuppilersTableAdapter.Fill(Me.WellmeadowsDataSet.Suppilers)

    End Sub
End Class