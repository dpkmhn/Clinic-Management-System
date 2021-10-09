Imports System.Data
Imports System.Data.OleDb
Public Class Prescription
    Public conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim query, Gender As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    ' Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    '  Dim cm As CurrencyManager
    Dim a, b As String

    Dim ds As New DataSet
    Dim pds As New DataSet
    Dim dds As New DataSet
    Dim mds As New DataSet

    Dim pdpt As New OleDbDataAdapter
    Dim dadpt As New OleDbDataAdapter
    Dim madpt As New OleDbDataAdapter

    Dim cm As CurrencyManager
    Dim dcm As CurrencyManager
    Dim pcm As CurrencyManager
    Dim mcm As CurrencyManager

    Dim nid As Integer

    Private Sub pnav()
        txtpid.DataBindings.Clear()
        txtpname.DataBindings.Clear()
        dadpt = New OleDbDataAdapter("select * from PatientDetail", conn)
        dadpt.Fill(pds, "ptemp")
        pcm = CType(Me.BindingContext(pds, "ptemp"), CurrencyManager)
        txtpid.DataBindings.Add("text", pds, "ptemp.Patientid")
        txtpname.DataBindings.Add("text", pds, "ptemp.FirstName")
    End Sub
    Private Sub dnav()
        txtdid.DataBindings.Clear()
        txtdname.DataBindings.Clear()
        dadpt = New OleDbDataAdapter("select * from Doctor", conn)
        dadpt.Fill(dds, "dtemp")
        dcm = CType(Me.BindingContext(dds, "dtemp"), CurrencyManager)
        txtdid.DataBindings.Add("text", dds, "dtemp.ID")
        txtdname.DataBindings.Add("text", dds, "dtemp.first_name")
    End Sub
    Private Sub mnav()
        txtmid.DataBindings.Clear()
        txtmname.DataBindings.Clear()
        madpt = New OleDbDataAdapter("select * from AddMedicine", conn)
        madpt.Fill(mds, "mtemp")
        mcm = CType(Me.BindingContext(mds, "mtemp"), CurrencyManager)
        txtmid.DataBindings.Add("text", mds, "mtemp.MedicineID")
        txtmname.DataBindings.Add("text", mds, "mtemp.MedicineName")
    End Sub


    Private Sub gdisp()
        ds.Tables.Clear()
        query = "Select * from Prescription"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "Prescription")
        DataGridView1.DataSource = ds.Tables("Prescription")
    End Sub
    Private Sub gnav()
        'conn.Open()
        adpt = New OleDbDataAdapter("select * from Prescription", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        pid.DataBindings.Add("text", ds, "temp.prid")
        txtpid.DataBindings.Add("text", ds, "temp.PatientID")
        txtpname.DataBindings.Add("text", ds, "temp.PatientName")
        txtdid.DataBindings.Add("text", ds, "temp.DoctorID")
        txtdname.DataBindings.Add("text", ds, "temp.DoctorName")
        txtmid.DataBindings.Add("text", ds, "temp.MedicineID")
        txtmname.DataBindings.Add("text", ds, "temp.MedicineName")
        txtunits.DataBindings.Add("text", ds, "temp.Units")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "temp"
        DataGridView1.Refresh()
    End Sub
    Private Sub cmdaddnew_Click(sender As Object, e As EventArgs) Handles cmdaddnew.Click

        'ID Autogenerate code
        Dim q As String

        q = "select prid from Prescription where prid=(select max(prid) from Prescription)"
        Dim RDR As OleDbDataReader = New OleDbCommand(q, conn).ExecuteReader

        RDR.Read()

        nid = RDR("prid") + 1
        pid.Text = nid
        pnav()
        dnav()
        mnav()

        ' pid.Text = ""
        txtpid.Text = ""
        txtpname.Text = ""
        txtdid.Text = ""
        txtdname.Text = ""
        txtmid.Text = ""
        txtmname.Text = ""
        txtunits.Text = ""
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click

        Dim x As Integer

        ' If txtpatientid.Text = "" Or txtpatientname.Text = "" Or RadioButton1.Checked = False And RadioButton2.Checked = False Or txtaddhaarno.Text = "" Or txtaddress.Text = "" Or txtmobileno.Text = "" Or DateTimePicker1.Checked = False Or txtissue.Text = "" Or txtemail.Text = "" Then
        ' a = MsgBox("Please Fill All Field", 1, "WARNING")
        ' Else


        query = "insert into Prescription values(" & CInt(pid.Text) & ",'" & txtpid.Text & " ','" & txtpname.Text & " ','" & txtdid.Text & " ',
      '" & txtdname.Text & " ','" & txtmid.Text & " ','" & txtmname.Text & " ','" & txtunits.Text & "')"


        cmd = New OleDb.OleDbCommand(query, conn)
        x = cmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("Record Inserted!!")

        Else
            MsgBox("data Not inserted")
        End If
        ' End If
        pid.Text = nid + 1

        cm.Position = 0

        gdisp()

        txtmid.Text = ""
        txtmname.Text = ""
        txtunits.Text = ""



    End Sub



    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Dim x As Integer


        query = "update Prescription set PatientID= " & txtpid.Text & ",PatientName='" & txtpname.Text & "',
DoctorID=" & txtdid.Text & ",DoctorName='" & txtdname.Text & "',MedicineID=" & txtmid.Text & ",MedicineName='" & txtmname.Text & "',Units=" & txtunits.Text & " where prid =" & pid.Text & " "
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
            query = "delete from Prescription where prid =" & pid.Text & " "
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted!!")

        Catch ex As Exception
            MsgBox("Exception ")

        End Try
        cm.Position = 0

        gdisp()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        RprtPrecription.Show()
    End Sub

    Private Sub Prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
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



    Private Sub pid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub


    Private Sub txtpid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub



    Private Sub txtdid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub



    Private Sub txtmid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub



    Private Sub txtunits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtunits.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub



    Private Sub txtpname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpname.KeyPress
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

    Private Sub dnext_Click(sender As Object, e As EventArgs) Handles dnext.Click
        Try
            If (dcm.Position = dcm.Count - 1) Then
                MsgBox("No More Records!!")
            Else
                dcm.Position = dcm.Position + 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")
        End Try

    End Sub

    Private Sub mnextt_Click(sender As Object, e As EventArgs) Handles mnextt.Click
        Try
            If (mcm.Position = mcm.Count - 1) Then
                MsgBox("No More Records!!")
            Else
                mcm.Position = mcm.Position + 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")
        End Try

    End Sub

    Private Sub ppre_Click(sender As Object, e As EventArgs) Handles ppre.Click
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

    Private Sub dprev_Click(sender As Object, e As EventArgs) Handles dprev.Click
        Try
            If (dcm.Position = 0) Then
                MsgBox("No More Records!!")
            Else
                dcm.Position = pcm.Position - 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")
        End Try

    End Sub

    Private Sub mpree_Click(sender As Object, e As EventArgs) Handles mpree.Click
        Try
            If (mcm.Position = 0) Then
                MsgBox("No More Records!!")
            Else
                mcm.Position = pcm.Position - 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")
        End Try

    End Sub

    Private Sub txtdname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdname.KeyPress
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

    Private Sub txtmname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmname.KeyPress
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
End Class