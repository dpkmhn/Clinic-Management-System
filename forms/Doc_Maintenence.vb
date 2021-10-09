Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Doc_Maintenence
    Public conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim query, Gender As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim cm As CurrencyManager
    Dim a, b As String

    Private Sub gnav()
        'conn.Open()
        adpt = New OleDbDataAdapter("select * from Doctor", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        TextBox11.DataBindings.Add("text", ds, "temp.ID")
        TextBox1.DataBindings.Add("text", ds, "temp.first_name")
        TextBox2.DataBindings.Add("text", ds, "temp.last_name")
        ComboBox1.DataBindings.Add("text", ds, "temp.Gender")


        DateTimePicker1.DataBindings.Add("value", ds, "temp.dob")
        TextBox4.DataBindings.Add("text", ds, "temp.qualification")
        TextBox5.DataBindings.Add("text", ds, "temp.experience")
        TextBox7.DataBindings.Add("text", ds, "temp.email")
        TextBox8.DataBindings.Add("text", ds, "temp.aadhar")
        TextBox9.DataBindings.Add("text", ds, "temp.mob")
        RichTextBox1.DataBindings.Add("text", ds, "temp.address")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "temp"
        DataGridView1.Refresh()
    End Sub
    Private Sub cmdfirst_Click(sender As Object, e As EventArgs) Handles cmdfirst.Click
        cm.Position = 0
    End Sub

    Private Sub cmdprevious_Click(sender As Object, e As EventArgs) Handles cmdprevious.Click
        If (cm.Position = 0) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position - 1
        End If
    End Sub

    Private Sub cmdnext_Click(sender As Object, e As EventArgs) Handles cmdnext.Click
        If (cm.Position = cm.Count - 1) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position + 1
        End If
    End Sub

    Private Sub cmdlast_Click(sender As Object, e As EventArgs) Handles cmdlast.Click
        cm.Position = cm.Count - 1
    End Sub



    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub


    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub


    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub Doc_Maintenence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

        gnav()
    End Sub

    Private Sub cmdaddnew_Click(sender As Object, e As EventArgs) Handles cmdaddnew.Click
        ComboBox1.Visible = False
        Male.Visible = True
        Female.Visible = True

        TextBox11.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Male.Checked = False
        Female.Checked = False
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        RichTextBox1.Text = ""


        'ID Autogenerate code
        Dim q As String

        q = "select ID from Doctor where ID=(select max(ID) from Doctor)"
        Dim RDR As OleDbDataReader = New OleDbCommand(q, conn).ExecuteReader

        RDR.Read()

        Dim nid As Integer = RDR("ID") + 1
        TextBox11.Text = nid
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Dim x As Integer

        If (Male.Checked = True) Then
            Gender = Male.Text
        ElseIf (Female.Checked = True) Then
            Gender = Female.Text
        End If
        query = "update Doctor set first_name='" & TextBox1.Text & "',last_name= '" & TextBox2.Text & "',Gender='" & Gender & "',dob='" & DateTimePicker1.Value & "',address='" & RichTextBox1.Text & "',aadhar='" & TextBox8.Text & "',mob=" & TextBox9.Text & ",experience='" & TextBox5.Text & "',qualification='" & TextBox4.Text & "',email='" & TextBox7.Text & "' where ID ='" & TextBox11.Text & "'"
        cmd = New OleDb.OleDbCommand(query, conn)

        x = cmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("Data Updated!!")
        Else
            MsgBox("No data to update")

        End If
        'MOVE TO 1ST POSITION
        cm.Position = 0
        gdisp()
    End Sub



    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim x As Integer
        ' Try

        If (Male.Checked = True) Then
            Gender = Male.Text
        ElseIf (Female.Checked = True) Then
            Gender = Female.Text
        End If
        If TextBox11.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or Male.Checked = False And Female.Checked = False Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox7.Text = "" Or DateTimePicker1.Checked = False Or TextBox9.Text = "" Or TextBox8.Text = "" Or RichTextBox1.Text = "" Then
            a = MsgBox("Please Fill All Field", 1, "WARNING")
        Else
            query = "insert into Doctor values(" & CInt(TextBox11.Text) & ",'" & TextBox1.Text & " ','" & TextBox2.Text & " ',
      '" & TextBox4.Text & " ','" & TextBox5.Text & " ','" & Gender & "','" & DateTimePicker1.Value & "','" & TextBox8.Text & "','" & RichTextBox1.Text & "','" & TextBox9.Text & "','" & TextBox7.Text & " ')"


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

    Private Sub gdisp()
        ds.Tables.Clear()
        query = "Select * from Doctor"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "Doctor")
        DataGridView1.DataSource = ds.Tables("Doctor")
    End Sub


    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click

        Try
            query = "delete from Doctor where ID ='" & TextBox11.Text & "'"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted!!")

        Catch ex As Exception
            MsgBox("Exception ")

        End Try
        cm.Position = 0

        gdisp()
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
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

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
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

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(TextBox7.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MsgBox("Invalid Email ID!!")
            TextBox7.Clear()
            'txtemail.Focus()
        End If
    End Sub






    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub

    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        If (Len(TextBox8.Text) < 12) Then
            MsgBox("Enter 12 digit aadhar no!!")
        End If
    End Sub

    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click

        If (Val(TextBox9.Text) < 6000000000) Then
            MsgBox("Invalid Mobile Number!!")
            TextBox9.Text = ""
        End If
    End Sub
End Class