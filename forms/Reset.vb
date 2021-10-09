
Imports System.Data
Imports System.Data.OleDb
Public Class Reset



    Public conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim query, Gender As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim a, b As String

    Private Sub cmdconfirmpassword_TextChanged(sender As Object, e As EventArgs) Handles cmdconfirmpassword.TextChanged

    End Sub


    Private Sub cmdverify_Click(sender As Object, e As EventArgs) Handles cmdverify.Click
        Dim pw As String

        cmd = New OleDbCommand("Select * from LoginTbl", conn)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            pw = dr(1)

        End If


        If (txtcurrentpassword.Text = pw) Then
            Label2.Show()
            Label2.Text = "Validation successful!"
            GroupBox2.Show()
        Else
            Label2.Show()
            Label2.Text = "Incorrect Password!"
        End If


    End Sub

    Private Sub cmdcngpassword_Click(sender As Object, e As EventArgs) Handles cmdcngpassword.Click
        'conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        Dim password = txtnewpassword.Text
        Dim confirmpassword = cmdconfirmpassword.Text
        If password = confirmpassword Then
            cmd.CommandText = "update LoginTbl set [Password]='" & txtnewpassword.Text & "' where [Password]='" & txtcurrentpassword.Text & "' "
            cmd.ExecuteNonQuery()
            conn.Close()

            Dim ans As String
            ans = MsgBox("Password Changed!!", vbOKOnly + vbInformation)
        Else
            Dim ans As String
            ans = MsgBox("invalid Password !", vbOKOnly + vbCritical)
        End If


        cmdconfirmpassword.Text = ""
        txtnewpassword.Text = ""
        txtcurrentpassword.Text = ""
    End Sub

    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()
    End Sub
End Class