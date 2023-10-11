Imports Microsoft.Reporting.WinForms

Public Class Report_EachWard

    Public Report_title As String = ""
    Private Sub Report_EachWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDataSet.Ward_Report_View' table. You can move, or remove it, as needed.

        Dim reportData As DataTable = Ward_Report_ViewTableAdapter.GetDataByWardID(Report_title)

        ' Create a data source for your report with the correct data source name.
        Dim reportDataSource As New ReportDataSource("Ward_dataset", reportData)

        ' Add the data source to your report viewer.
        ReportViewer1.LocalReport.DataSources.Add(reportDataSource)


        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("TitleParams", "Report Ward  " + Report_title))

        ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.RefreshReport()

        ' check report title
        Console.WriteLine("Report Title : " & Report_title)
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class