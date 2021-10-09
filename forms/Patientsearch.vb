Imports System.Data
Imports System.Data.OleDb
Public Class Patientsearch

    Public conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim query, Gender As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim cm As CurrencyManager
    Dim a, b As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        id = txtsearch.Text
        conn.Open()

        cmd = New OleDbCommand("select * from PatientDetail where Patientid='" & id & "' ", conn)
        dr = cmd.ExecuteReader()

        If dr.Read Then
            txtpatientid.Text = dr(0)
            txtpatientname.Text = dr(1)
            txtsurname.Text = dr(2)
            TextBox1.Text = dr(3)
            txtgender.Text = dr(4)
            txtdob.Text = dr(5)
            txtaddhaarno.Text = dr(6)
            txtaddress.Text = dr(7)
            txtemail.Text = dr(8)
            txtmobileno.Text = dr(9)
            txtsearch.Text = ""
        Else
            MsgBox("Record does not exist!!!", MsgBoxStyle.Exclamation, "PatientDetail")
        End If

        conn.Close()

    End Sub

    Private Sub Patientsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        ' conn.Open()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If
    End Sub
End Class