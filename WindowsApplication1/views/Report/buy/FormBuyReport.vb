Imports Microsoft.Reporting.WinForms
Public Class FormBuyReport

    Private _controller As BuyReportController

    Private Sub BuyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _controller = New BuyReportController()
        LoadReport()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub LoadReport()
        Dim dt As DataTable = _controller.getSalesReport()
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(Application.StartupPath, "D:\VisualBasic\AplikasiPenjualan_UAS\WindowsApplication1\WindowsApplication1\Reports\BuyReport.rdlc")
        Dim rds As New ReportDataSource("DataSet1", dt)
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class