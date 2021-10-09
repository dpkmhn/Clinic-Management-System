Imports System.Data
Imports System.Data.OleDb
Public Class PatientInvoiceME

    Public conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim query, Gender As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim cm As CurrencyManager
    Dim a, b As String

    ' Dim ds As New DataSet
    Dim pds As New DataSet
    Dim dds As New DataSet
    Dim mds As New DataSet

    Dim pdpt As New OleDbDataAdapter
    Dim dadpt As New OleDbDataAdapter
    Dim madpt As New OleDbDataAdapter

    ' Dim cm As CurrencyManager
    Dim dcm As CurrencyManager
    Dim pcm As CurrencyManager
    Dim mcm As CurrencyManager

    Dim nid As Integer

    Private Sub pnav()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        dadpt = New OleDbDataAdapter("select * from PatientDetail", conn)
        dadpt.Fill(pds, "ptemp")
        pcm = CType(Me.BindingContext(pds, "ptemp"), CurrencyManager)
        TextBox3.DataBindings.Add("text", pds, "ptemp.Patientid")
        TextBox4.DataBindings.Add("text", pds, "ptemp.FirstName")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        RprtInvoice.Show()
    End Sub

    Private Sub gdisp()
        ds.Tables.Clear()
        query = "Select * from PatientInvoice"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "PatientInvoice")
        DataGridView1.DataSource = ds.Tables("PatientInvoice")
    End Sub
    Private Sub gnav()
        'conn.Open()
        adpt = New OleDbDataAdapter("select * from PatientInvoice", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        TextBox1.DataBindings.Add("text", ds, "temp.Invoiceid")
        TextBox3.DataBindings.Add("text", ds, "temp.Patientid")
        TextBox4.DataBindings.Add("text", ds, "temp.PatientName")


        DateTimePicker1.DataBindings.Add("value", ds, "temp.Billingdate")
        TextBox7.DataBindings.Add("text", ds, "temp.checkup")
        TextBox5.DataBindings.Add("text", ds, "temp.MedicineCharges")
        TextBox6.DataBindings.Add("text", ds, "temp.Totalcost")


        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "temp"
        DataGridView1.Refresh()
    End Sub


    Private Sub PatientInvoiceME_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

        gnav()
    End Sub

    Private Sub cmdlast_Click(sender As Object, e As EventArgs) Handles cmdlast.Click

        cm.Position = cm.Count - 1
    End Sub

    Private Sub cmdfirst_Click(sender As Object, e As EventArgs) Handles cmdfirst.Click

        cm.Position = 0
    End Sub



    Private Sub cmdaddnew_Click(sender As Object, e As EventArgs) Handles cmdaddnew.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        'ID Autogenerate code
        Dim q As String

        q = "select Invoiceid from PatientInvoice where Invoiceid=(select max(Invoiceid) from PatientInvoice)"
        Dim RDR As OleDbDataReader = New OleDbCommand(q, conn).ExecuteReader

        RDR.Read()

        Dim nid As Integer = RDR("Invoiceid") + 1
        TextBox1.Text = nid
        pnav()



    End Sub




    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim x As Integer

        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or DateTimePicker1.Checked = False Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            a = MsgBox("Please Fill All Field", 1, "WARNING")
        Else
            query = "insert into PatientInvoice values(" & CInt(TextBox1.Text) & ",'" & DateTimePicker1.Value & "','" & TextBox3.Text & " ','" & TextBox4.Text & "',
      '" & TextBox7.Text & " ','" & TextBox5.Text & " ','" & TextBox6.Text & "')"


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

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click

        Dim x As Integer

        query = "update PatientInvoice set Totalcost=" & TextBox6.Text & ",MedicineCharges= " & TextBox5.Text & ",Billingdate='" & DateTimePicker1.Value & "',checkup=" & TextBox7.Text & ",PatientName='" & TextBox4.Text & "',Patientid=" & TextBox3.Text & " where Invoiceid =" & TextBox1.Text & " "
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

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click

        Try
            query = "delete from PatientInvoice where Invoiceid =" & TextBox1.Text & " "
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted!!")

        Catch ex As Exception
            MsgBox("Exception ")

        End Try
        cm.Position = 0

        gdisp()
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



    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If
    End Sub

    Private Sub pnext_Click(sender As Object, e As EventArgs) Handles pnext.Click
        Try
            If (pcm.Position = pcm.Count - 1) Then
                MsgBox("No More Records!!")
            Else
                pcm.Position = pcm.Position + 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")

        End Try

    End Sub

    Private Sub pprev_Click(sender As Object, e As EventArgs) Handles pprev.Click
        Try
            If (pcm.Position = 0) Then
                MsgBox("No More Records!!")
            Else
                pcm.Position = pcm.Position - 1
            End If

        Catch ex As Exception
            MsgBox("Action not permitted!")

        End Try

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Alphabets not permitted!!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '  Me.Hide()
        MedicineCharges.Show()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        TextBox6.Text = Int(TextBox7.Text) + Int(TextBox5.Text)

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

    End Sub
End Class