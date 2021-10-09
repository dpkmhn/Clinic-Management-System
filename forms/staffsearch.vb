Imports System.Data
Imports System.Data.OleDb
Public Class staffsearch

    Public conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim query, Gender As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim cm As CurrencyManager
    Dim a, b As String

    Private Sub staffsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        ' conn.Open()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        id = txtsearch.Text
        conn.Open()

        cmd = New OleDbCommand("select * from Staff where ID='" & id & "' ", conn)
        dr = cmd.ExecuteReader()

        If dr.Read Then
            txtstaffid.Text = dr(0)

            txttype.Text = dr(1)

            TextBox1.Text = dr(2)
            txtsurname.Text = dr(3)
            txtgender.Text = dr(4)
            txtdob.Text = dr(5)
            txtaddhaarno.Text = dr(6)
            txtaddress.Text = dr(7)
            txtmobileno.Text = dr(8)
            txtemail.Text = dr(9)
            ' DateTimePicker1.Value = DateValue(dr(7))
            '   showgrid()
            txtsearch.Text = ""
        Else
            MsgBox("Record was not exist!!!", MsgBoxStyle.Exclamation, "PatientDetail")

        End If

        conn.Close()
    End Sub
End Class