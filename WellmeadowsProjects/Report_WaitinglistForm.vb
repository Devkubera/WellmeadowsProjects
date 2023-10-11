Public Class Report_WaitinglistForm
    Private Sub Report_WaitinglistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Waitinglist_Report_View' table. You can move, or remove it, as needed.
        Me.Waitinglist_Report_ViewTableAdapter.Fill(Me.WellmeadowsDataSet.Waitinglist_Report_View)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class