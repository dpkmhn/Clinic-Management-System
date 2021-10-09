Public Class rprtdoctor

    Private Sub rprtdoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet1
        Dim ad As New DataSet1TableAdapters.DoctorTableAdapter
        ad.Fill(ds.Doctor)
        Dim rpt As New docCrystalReport3
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

End Class