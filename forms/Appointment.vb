
Imports System.Data
Imports System.Data.OleDb
Public Class Appointment
    Public conn As New OleDbConnection
    Dim acmd As OleDbCommand
    Dim dcmd As OleDbCommand
    Dim pcmd As OleDbCommand
    Dim query As String
    Dim pdr As OleDbDataReader
    Dim ddr As OleDbDataReader
    Dim dr As OleDbDataReader

    Dim da As New OleDbDataAdapter

    Dim ds As New DataSet
    Dim pds As New DataSet
    Dim dds As New DataSet

    Dim adpt As New OleDbDataAdapter
    Dim padpt As New OleDbDataAdapter
    Dim dadpt As New OleDbDataAdapter

    Dim cm As CurrencyManager
    Dim dcm As CurrencyManager
    Dim pcm As CurrencyManager

    Private Sub disp()
        acmd = New OleDbCommand("Select * from AddMedicine", conn)
        dr = acmd.ExecuteReader
        If dr.Read() Then
            txttoken.Text = dr(0)
            txtstarttime.Text = dr(1)
            txtendtime.Text = dr(2)
            txtpid.Text = dr(3)
            txtpname.Text = dr(4)
            txtissue.Text = dr(5)
            txtdid.Text = dr(6)
            txtdname.Text = dr(7)

        End If


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

    Private Sub pnav()
        txtpid.DataBindings.Clear()
        txtpname.DataBindings.Clear()
        txtissue.DataBindings.Clear()

        padpt = New OleDbDataAdapter("select * from PatientDetail", conn)
        padpt.Fill(pds, "ptemp")
        pcm = CType(Me.BindingContext(pds, "ptemp"), CurrencyManager)
        txtpid.DataBindings.Add("text", pds, "ptemp.Patientid")
        txtpname.DataBindings.Add("text", pds, "ptemp.FirstName")
        txtissue.DataBindings.Add("text", pds, "ptemp.Issue")
    End Sub

    Private Sub gdisp()
        ds.Tables.Clear()
        query = "Select * from Appointment"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "Appointment")
        DataGridView1.DataSource = ds.Tables("Appointment")
    End Sub
    Private Sub gnav()
        'conn.Open()
        adpt = New OleDbDataAdapter("select * from Appointment", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        txttoken.DataBindings.Add("text", ds, "temp.token")
        txtstarttime.DataBindings.Add("text", ds, "temp.ap_start")
        txtendtime.DataBindings.Add("text", ds, "temp.ap_end")
        txtpid.DataBindings.Add("text", ds, "temp.PatientID")
        txtpname.DataBindings.Add("text", ds, "temp.first_name")
        txtdid.DataBindings.Add("text", ds, "temp.Doctor_id")
        txtdname.DataBindings.Add("text", ds, "temp.Doctor_name")
        txtissue.DataBindings.Add("text", ds, "temp.Issue")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "temp"
        DataGridView1.Refresh()
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

        gnav()

    End Sub


    Private Sub cmdaddnew_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub cmdnext_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub cmdupdate_Click(sender As Object, e As EventArgs)
        Dim x As Integer
        query = "update Appointment set ap_start='" & txtstarttime.Value & "',ap_end= '" & txtendtime.Value & "',PatientID= '" & txtpid.Text & "',first_name= '" & txtpname.Text & "',Issue= '" & txtissue.Text & "',Doctor_id= '" & txtdid.Text & "',Doctor_name= '" & txtdname.Text & "'  where token ='" & txttoken.Text & "'"

        acmd = New OleDb.OleDbCommand(query, conn)

        x = acmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("Data Updated!!")
        Else
            MsgBox("No data to update")
        End If

        'MOVE TO 1ST POSITION
        cm.Position = 0

    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs)



    End Sub


    Private Sub cmdprevious_Click(sender As Object, e As EventArgs)
        If (cm.Position = 0) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position - 1
        End If
    End Sub

    Private Sub cmdfirst_Click(sender As Object, e As EventArgs)
        cm.Position = 0
    End Sub

    Private Sub cmdlast_Click(sender As Object, e As EventArgs)
        cm.Position = cm.Count - 1

    End Sub

    Private Sub pnext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dnext_Click(sender As Object, e As EventArgs)
        If (dcm.Position = dcm.Count - 1) Then
            MsgBox("No More Records!!")
        Else
            dcm.Position = dcm.Position + 1
        End If
    End Sub

    Private Sub dpre_Click(sender As Object, e As EventArgs)
        If (dcm.Position = 0) Then
            MsgBox("No More Records!!")
        Else
            dcm.Position = dcm.Position - 1
        End If
    End Sub

    Private Sub ppre_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdfirst_Click_1(sender As Object, e As EventArgs) Handles cmdfirst.Click
        cm.Position = 0
    End Sub

    Private Sub cmdaddnew_Click_1(sender As Object, e As EventArgs) Handles cmdaddnew.Click


        'ID Autogenerate code
        Dim q As String

        q = "select token from Appointment where token=(select max(token) from Appointment)"
        Dim RDR As OleDbDataReader = New OleDbCommand(q, conn).ExecuteReader

        RDR.Read()

        Dim nid As Integer = RDR("token") + 1
        txttoken.Text = nid
        pnav()
        dnav()

        'txttoken.Text = ""
        txtstarttime.Text = ""
        txtendtime.Text = ""
        txtpid.Text = ""
        txtpname.Text = ""
        txtdid.Text = ""
        txtdname.Text = ""
        txtissue.Text = ""
    End Sub

    Private Sub cmdsave_Click_1(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim x As Integer
        ' Try
        query = "insert into Appointment values('" & CInt(txttoken.Text) & "','" &
            txtstarttime.Value & " ','" & txtendtime.Value & "','" & txtpid.Text & "','" & txtpname.Text & "','" & txtissue.Text & "','" & txtdid.Text & "','" & txtdname.Text & "')"
        acmd = New OleDb.OleDbCommand(query, conn)
        x = acmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("Record Inserted!!")

        Else
            MsgBox("data Not inserted")
        End If

        gdisp()

        cm.Position = 0
    End Sub

    Private Sub cmddelete_Click_1(sender As Object, e As EventArgs) Handles cmddelete.Click
        ' Dim x As Integer

        '     Try
        query = "delete from Appointment where token =" & txttoken.Text & " "
        acmd = New OleDbCommand(query, conn)
        acmd.ExecuteNonQuery()
        MsgBox("Record Deleted!!")

        '   Catch ex As Exception
        '     MsgBox("Exception ")

        ' End Try
        gdisp()

        cm.Position = 0
    End Sub

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub cmdprevious_Click_1(sender As Object, e As EventArgs) Handles cmdprevious.Click
        If (cm.Position = 0) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position - 1
        End If
    End Sub

    Private Sub cmdnext_Click_1(sender As Object, e As EventArgs) Handles cmdnext.Click
        If (cm.Position = cm.Count - 1) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position + 1
        End If
    End Sub

    Private Sub cmdlast_Click_1(sender As Object, e As EventArgs) Handles cmdlast.Click
        cm.Position = cm.Count - 1

    End Sub

    Private Sub pnext_Click_1(sender As Object, e As EventArgs) Handles pnext.Click
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

    Private Sub ppre_Click_1(sender As Object, e As EventArgs) Handles ppre.Click
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

    Private Sub dnext_Click_1(sender As Object, e As EventArgs) Handles dnext.Click
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

    Private Sub dpre_Click_1(sender As Object, e As EventArgs) Handles dpre.Click
        Try
            If (dcm.Position = 0) Then
                MsgBox("No More Records!!")
            Else
                dcm.Position = dcm.Position - 1
            End If
        Catch ex As Exception
            MsgBox("Action not permitted!")
        End Try

    End Sub
End Class



