Public Class RprtInvoice
    Private Sub RprtInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New LoginDB1DataSet
        Dim ad As New LoginDB1DataSetTableAdapters.PatientInvoiceTableAdapter
        ad.Fill(ds.PatientInvoice)
        Dim rpt As New invCrystalReport3
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class