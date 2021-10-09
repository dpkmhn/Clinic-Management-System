Imports System.Data.OleDb
Public Class MedicineCharges
    Public conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim cm As CurrencyManager
    Dim total, bill As Integer

    Private Sub MedicineCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

        gnav()
        gdisp()
    End Sub
    Private Sub gnav()
        'conn.Open()
        adpt = New OleDbDataAdapter("select * from AddMedicine", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        txtname.DataBindings.Add("text", ds, "temp.MedicineName")
        txtprice.DataBindings.Add("text", ds, "temp.MedicinePrice")

    End Sub

    Private Sub gdisp()
        ds.Tables.Clear()
        query = "Select * from Prescription"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "Prescription")
        DataGridView1.DataSource = ds.Tables("Prescription")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        txtname.Text = ""
        txtunits.Text = ""
        txtprice.Text = ""
        txttotal.Text = ""
        txtbill.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If (cm.Position = cm.Count - 1) Then
                MsgBox("No More Records!!")
            Else
                cm.Position = cm.Position + 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (cm.Position = 0) Then
                MsgBox("No More Records!!")
            Else
                cm.Position = cm.Position - 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")

        End Try

    End Sub

    Private Sub btnaddd_Click(sender As Object, e As EventArgs) Handles btnaddd.Click


        txttotal.Text = txtunits.Text * txtprice.Text
        total = Val(txttotal.Text)

        bill = bill + total
        txtbill.Text = bill
    End Sub

    Public Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        PatientInvoiceME.TextBox5.Text = txtbill.Text
        Me.Close()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class