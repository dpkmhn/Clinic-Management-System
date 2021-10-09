Public Class Rprtstf
    Private Sub Rprtstf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim ds As New DataSet1
        Dim ad As New DataSet1TableAdapters.staffTableAdapter
        ad.Fill(ds.staff)
        Dim rpt As New stfCrystalReport2
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class