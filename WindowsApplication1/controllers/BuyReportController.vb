Public Class BuyReportController
    Public Function getSalesReport() As DataTable
        Return buyReport.getAll()
    End Function
End Class
