Public Class Rprtmedicine

    Private Sub Rprtmedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet1
        Dim ad As New DataSet1TableAdapters.AddMedicineTableAdapter
        ad.Fill(ds.AddMedicine)
        Dim rpt As New mdCrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class