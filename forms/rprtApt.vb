Public Class rprtApt
    Private Sub rprtApt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New LoginDB1DataSet
        Dim ad As New LoginDB1DataSetTableAdapters.AppointmentTableAdapter
        ad.Fill(ds.Appointment)
        Dim rpt As New aptCrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class