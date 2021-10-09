Public Class RprtPatient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New LoginDB1DataSet
        Dim ad As New LoginDB1DataSetTableAdapters.PatientDetailTableAdapter
        ad.Fill(ds.PatientDetail)
        Dim rpt As New patCrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class