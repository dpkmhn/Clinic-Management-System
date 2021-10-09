Imports System.Data.OleDb
Public Class Login
    Public conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button.Click

        Dim flag As Integer
        Dim cmd As OleDbCommand = New OleDbCommand("select * from LoginTbl where [Username]='" & txtUserName.Text & "'and [Password]='" & txtPassword.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            MsgBox("Login Successful!!")
            flag = 1

        Else
            flag = 0
            MsgBox("Incorrect Username or Password!!")

        End If

        If (flag = 0) Then

        Else
            Me.Close()
            MDIParent1.Show()
        End If

    End Sub




    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtUserName.Text = "" Then
            MsgBox("Please enter the Username...")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please enter the Password...")
        End If


        If txtUserName.Text <> "admin" Or txtPassword.Text <> "admin" Then
            MsgBox("Incorrect Username or Password!!")
            txtUserName.Text = ""
            txtPassword.Text = ""
            txtUserName.Focus()


            ' ElseIf txtPassword.Text <> "admin" Then
            '    MsgBox("Incorrect Username or Password!!")
            '    txtPassword.Text = ""
            '   Me.Show()
        Else
            MsgBox("Login Successful!!")
            Me.Hide()
            MDIParent1.Show()
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class





