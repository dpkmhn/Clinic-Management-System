Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class PatientReg


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
        query = "Select * from PatientDetail"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "PatientDetail")
        DataGridView1.DataSource = ds.Tables("PatientDetail")
    End Sub

    Private Sub gnav()







        'conn.Open()
        adpt = New OleDbDataAdapter("select * from PatientDetail", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        txtpatientid.DataBindings.Add("text", ds, "temp.Patientid")
        txtpatientname.DataBindings.Add("text", ds, "temp.FirstName")
        txtsurname.DataBindings.Add("text", ds, "temp.Surname")
        ' Dim genderBinder = New Binding("propGender", login, "Gender")
        '  Me.DataBindings.Add(genderBinder)
        ' Me.DataBindings.Add(genderBinder)

        ComboBox1.DataBindings.Add("text", ds, "temp.Gender")




        '  RadioButton1.DataBindings.Add("value", ds, "temp.Gender")
        '  RadioButton2.DataBindings.Add("value", ds, "temp.Gender")
        DateTimePicker1.DataBindings.Add("value", ds, "temp.Dateofbirth")
        txtaddhaarno.DataBindings.Add("text", ds, "temp.Aadhar")
        txtaddress.DataBindings.Add("text", ds, "temp.Address")
        txtmobileno.DataBindings.Add("text", ds, "temp.Mobileno")
        txtemail.DataBindings.Add("text", ds, "temp.Issue")
        txtissue.DataBindings.Add("text", ds, "temp.Email")


        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "temp"
        DataGridView1.Refresh()
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim x As Integer
        ' Try

        If (RadioButton1.Checked = True) Then
            Gender = RadioButton1.Text
        ElseIf (RadioButton2.Checked = True) Then
            Gender = RadioButton2.Text
        End If
        If txtpatientid.Text = "" Or txtpatientname.Text = "" Or RadioButton1.Checked = False And RadioButton2.Checked = False Or txtaddhaarno.Text = "" Or txtaddress.Text = "" Or txtmobileno.Text = "" Or DateTimePicker1.Checked = False Or txtissue.Text = "" Or txtemail.Text = "" Then
            a = MsgBox("Please Fill All Field", 1, "WARNING")
        Else
            query = "insert into PatientDetail values(" & CInt(txtpatientid.Text) & ",'" & txtpatientname.Text & " ','" & txtsurname.Text & " ','" & Gender & "','" & DateTimePicker1.Value & "'
      ,'" & txtaddress.Text & " ','" & txtaddhaarno.Text & " ','" & txtmobileno.Text & " ','" & txtissue.Text & "','" & txtemail.Text & " ')"


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


    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click

        Dim x As Integer

        If (RadioButton1.Checked = True) Then
            Gender = RadioButton1.Text
        ElseIf (RadioButton2.Checked = True) Then
            Gender = RadioButton2.Text
        End If
        query = "update PatientDetail set FirstName='" & txtpatientname.Text & " ',Surname= '" & txtsurname.Text & "',Gender='" & Gender & "',Dateofbirth='" & DateTimePicker1.Value & "',Address='" & txtaddress.Text & "',Aadhar='" & txtaddhaarno.Text & "',Mobileno='" & txtmobileno.Text & "',Email='" & txtemail.Text & "',Issue='" & txtissue.Text & "' where Patientid ='" & txtpatientid.Text & "'"
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






    Private Sub cmdaddnew_Click(sender As Object, e As EventArgs) Handles cmdaddnew.Click
        ComboBox1.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True


        txtpatientid.Text = ""
        txtpatientname.Text = ""
        txtsurname.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtaddhaarno.Text = ""
        txtaddress.Text = ""
        txtmobileno.Text = ""
        txtissue.Text = ""
        txtemail.Text = ""

        'ID Autogenerate code
        Dim q As String

        q = "select Patientid from PatientDetail where Patientid=(select max(Patientid) from PatientDetail)"
        Dim RDR As OleDbDataReader = New OleDbCommand(q, conn).ExecuteReader

        RDR.Read()

        Dim nid As Integer = RDR("Patientid") + 1
        txtpatientid.Text = nid
    End Sub






    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        ' Dim x As Integer

        Try
            query = "delete from PatientDetail where Patientid ='" & txtpatientid.Text & "'"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted!!")

        Catch ex As Exception
            MsgBox("Exception ")

        End Try
        cm.Position = 0

        gdisp()

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

    Private Sub PatientReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        conn = New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

        gnav()

    End Sub

    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        '' Note: call this from frm's Load event!
        Dim r As Rectangle
        If parent IsNot Nothing Then

            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If
        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        RprtPatient.Show()
    End Sub

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub


    Private Sub txtpatientid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpatientid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub





    Private Sub txtaddhaarno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaddhaarno.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub





    Private Sub txtpatientname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpatientname.KeyPress
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



    Private Sub txtsurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsurname.KeyPress
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





    Private Sub txtmobileno_TextChanged(sender As Object, e As EventArgs) Handles txtmobileno.TextChanged

    End Sub

    Private Sub txtissue_MouseClick(sender As Object, e As MouseEventArgs) Handles txtissue.MouseClick
        If (Val(txtmobileno.Text) < 6000000000) Then
            MsgBox("Invalid Mobile Number!!")
            txtmobileno.Text = ""
        End If
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txtmobileno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobileno.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If
    End Sub

    Private Sub txtaddhaarno_TextChanged(sender As Object, e As EventArgs) Handles txtaddhaarno.TextChanged

    End Sub

    Private Sub txtissue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtissue.KeyPress

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

    Private Sub txtaddhaarno_LostFocus(sender As Object, e As EventArgs) Handles txtaddhaarno.LostFocus
        If (Len(txtaddhaarno.Text) < 12) Then
            MsgBox("Enter 12 digit aadhar no!!")
        End If
    End Sub

    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemail.KeyPress

    End Sub
End Class


