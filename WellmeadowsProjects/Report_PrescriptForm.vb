Public Class Report_PrescriptForm
    Private Sub Report_PrescriptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Prescript_Report_View' table. You can move, or remove it, as needed.
        Me.Prescript_Report_ViewTableAdapter.Fill(Me.WellmeadowsDataSet.Prescript_Report_View)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class