Imports System.Data
Imports System.Data.OleDb

Imports System.Text.RegularExpressions

Public Class staff

    Public conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim query, Gender As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim cm As CurrencyManager
    Dim a, b As String

    Private Sub gdisp()
        ds.Tables.Clear()
        query = "Select * from staff"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "staff")
        DataGridView1.DataSource = ds.Tables("staff")
    End Sub
    Private Sub gnav()
        'conn.Open()
        adpt = New OleDbDataAdapter("select * from staff", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        txtID.DataBindings.Add("text", ds, "temp.ID")
        ComboBox1.DataBindings.Add("text", ds, "temp.Type")
        txtFirstName.DataBindings.Add("text", ds, "temp.first_name")
        txtLastName.DataBindings.Add("text", ds, "temp.last_name")
        ComboBox2.DataBindings.Add("text", ds, "temp.Gender")

        DateTimePicker1.DataBindings.Add("value", ds, "temp.dob")

        txtAadhar.DataBindings.Add("text", ds, "temp.aadhar")
        txtAddress.DataBindings.Add("text", ds, "temp.address")
        txtemail.DataBindings.Add("text", ds, "temp.mob")
        txtMobPhone.DataBindings.Add("text", ds, "temp.email")


        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "temp"
        DataGridView1.Refresh()
    End Sub

    Private Sub cmdaddnew_Click(sender As Object, e As EventArgs) Handles cmdaddnew.Click
        ComboBox2.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True


        txtID.Text = ""
        ComboBox1.Text = ""
        txtFirstName.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtLastName.Text = ""
        txtAadhar.Text = ""
        txtMobPhone.Text = ""
        txtemail.Text = ""
        txtAddress.Text = ""

        'ID Autogenerate code
        Dim q As String

        q = "select ID from Staff where ID=(select max(ID) from Staff)"
        Dim RDR As OleDbDataReader = New OleDbCommand(q, conn).ExecuteReader

        RDR.Read()

        Dim nid As Integer = RDR("ID") + 1
        txtID.Text = nid
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click

        Try
            query = "delete from Staff where ID ='" & txtID.Text & "'"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted!!")

        Catch ex As Exception
            MsgBox("Exception ")

        End Try
        cm.Position = 0

        gdisp()
    End Sub

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub cmdlast_Click(sender As Object, e As EventArgs) Handles cmdlast.Click
        cm.Position = cm.Count - 1
    End Sub

    Private Sub cmdfirst_Click(sender As Object, e As EventArgs) Handles cmdfirst.Click
        cm.Position = 0
    End Sub

    Private Sub cmdnext_Click(sender As Object, e As EventArgs) Handles cmdnext.Click
        If (cm.Position = cm.Count - 1) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position + 1
        End If
    End Sub

    Private Sub cmdprevious_Click(sender As Object, e As EventArgs) Handles cmdprevious.Click
        If (cm.Position = 0) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position - 1
        End If
    End Sub






    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

        gnav()
    End Sub


    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub txtAadhar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAadhar.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub

    Private Sub txtMobPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobPhone.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            MsgBox("Spaces not permitted!!")

        ElseIf Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            MsgBox("Numbers not permitted!!")
        End If
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click

        Dim x As Integer
        ' Try
        If (Val(txtMobPhone.Text) < 6000000000) Then
            MsgBox("Invalid Mobile Number!!")
            txtMobPhone.Text = ""
            Exit Sub
        End If

        If (RadioButton1.Checked = True) Then
            Gender = RadioButton1.Text
        ElseIf (RadioButton2.Checked = True) Then
            Gender = RadioButton2.Text
        End If
        If txtID.Text = "" Or ComboBox1.Text = "" Or RadioButton1.Checked = False And RadioButton2.Checked = False Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtAadhar.Text = "" Or DateTimePicker1.Checked = False Or txtMobPhone.Text = "" Or txtemail.Text = "" Then
            a = MsgBox("Please Fill All Field", 1, "WARNING")
        Else
            query = "insert into Staff values(" & CInt(txtID.Text) & ",'" & ComboBox1.Text & " ','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & Gender & "','" & DateTimePicker1.Value & "',
      '" & txtAadhar.Text & "','" & txtAddress.Text & "','" & txtemail.Text & "','" & txtMobPhone.Text & "')"


            cmd = New OleDb.OleDbCommand(query, conn)
            x = cmd.ExecuteNonQuery()
            If (x) Then
                MsgBox("Record Inserted!!")

            Else
                MsgBox("data Not inserted")
            End If
        End If
        cm.Position = 0

        gdisp()

    End Sub

    Private Sub txtAadhar_TextChanged(sender As Object, e As EventArgs) Handles txtAadhar.TextChanged

    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            MsgBox("Spaces not permitted!!")

        ElseIf Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            MsgBox("Numbers not permitted!!")
        End If
    End Sub

    Private Sub txtMobPhone_TextChanged(sender As Object, e As EventArgs) Handles txtMobPhone.TextChanged

    End Sub

    Private Sub txtemail_LostFocus(sender As Object, e As EventArgs) Handles txtemail.LostFocus
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtemail.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MsgBox("Invalid Email ID!!")
            txtemail.Clear()
            'txtemail.Focus()
        End If
    End Sub

    Private Sub txtAadhar_LostFocus(sender As Object, e As EventArgs) Handles txtAadhar.LostFocus
        If (Len(txtAadhar.Text) < 12) Then
            MsgBox("Enter 12 digit aadhar no!!")
        End If
    End Sub
End Class
