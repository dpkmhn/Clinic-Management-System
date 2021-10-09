Public Class RprtPrecription


    Private Sub RprtPrecription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New LoginDB1DataSet
        Dim ad As New LoginDB1DataSetTableAdapters.PrescriptionTableAdapter
        ad.Fill(ds.Prescription)
        Dim rpt As New presCrystalReport2
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class