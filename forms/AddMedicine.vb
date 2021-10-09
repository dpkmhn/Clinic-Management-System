Imports System.Data
Imports System.Data.OleDb
Public Class AddMedicine
    Public conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim adpt As New OleDbDataAdapter
    Dim cm As CurrencyManager


    Private Sub disp()

        cmd = New OleDbCommand("Select * from AddMedicine", conn)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            txtmid.Text = dr(0)
            txtmname.Text = dr(1)
            txtmprice.Text = dr(2)

        End If

    End Sub

    Private Sub gdisp()
        ds.Tables.Clear()
        query = "Select * from AddMedicine"
        da = New OleDb.OleDbDataAdapter(query, conn)
        da.Fill(ds, "AddMedicine")
        DataGridView1.DataSource = ds.Tables("AddMedicine")
    End Sub
    Private Sub gnav()
        'conn.Open()
        adpt = New OleDbDataAdapter("select * from AddMedicine", conn)
        adpt.Fill(ds, "temp")
        cm = CType(Me.BindingContext(ds, "temp"), CurrencyManager)
        txtmid.DataBindings.Add("text", ds, "temp.MedicineID")
        txtmname.DataBindings.Add("text", ds, "temp.MedicineName")
        txtmprice.DataBindings.Add("text", ds, "temp.MedicinePrice")


        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "temp"
        DataGridView1.Refresh()
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim x As Integer
        ' Try
        query = "insert into AddMedicine values(" & CInt(txtmid.Text) & ",'" &
            txtmname.Text & " ',' " & txtmprice.Text & "')"
            cmd = New OleDb.OleDbCommand(query, conn)
            x = cmd.ExecuteNonQuery()
        If (x) Then
            MsgBox("Record Inserted!!")

        Else
            MsgBox("data Not inserted")
        End If

        cm.Position = 0
        gdisp()



    End Sub

    Private Sub AddMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginDB1.accdb")
        conn.Open()

        gnav()


    End Sub

    Private Sub txtmedicineprice_TextChanged(sender As Object, e As EventArgs) Handles txtmprice.TextChanged

    End Sub

    Private Sub cmdaddnew_Click(sender As Object, e As EventArgs) Handles cmdaddnew.Click
        txtmid.Text = ""
        txtmname.Text = ""
        txtmprice.Text = ""

        'ID Autogenerate code
        Dim q As String

        q = "select MedicineID from AddMedicine where MedicineID=(select max(MedicineID) from AddMedicine)"
        Dim RDR As OleDbDataReader = New OleDbCommand(q, conn).ExecuteReader

        RDR.Read()

        Dim nid As Integer = RDR("MedicineID") + 1
        txtmid.Text = nid



    End Sub

    Private Sub cmdnext_Click(sender As Object, e As EventArgs) Handles cmdnext.Click
        If (cm.Position = cm.Count - 1) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position + 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cm.Position = cm.Count - 1
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Dim x As Integer
        query = "update AddMedicine set MedicineName='" & txtmname.Text & "',MedicinePrice= '" & txtmprice.Text & "' where MedicineID ='" & txtmid.Text & "'"
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
        ' Dim x As Integer

        Try
            query = "delete from AddMedicine where MedicineID ='" & txtmid.Text & "'"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted!!")

        Catch ex As Exception
            MsgBox("Exception ")

        End Try
        cm.Position = 0

        gdisp()

    End Sub

    Private Sub txtmid_TextChanged(sender As Object, e As EventArgs) Handles txtmid.TextChanged

    End Sub

    Private Sub txtmid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Only Integer value permitted!!")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdprevious_Click(sender As Object, e As EventArgs) Handles cmdprevious.Click
        If (cm.Position = 0) Then
            MsgBox("No More Records!!")
        Else
            cm.Position = cm.Position - 1
        End If
    End Sub

    Private Sub cmdfirst_Click(sender As Object, e As EventArgs) Handles cmdfirst.Click
        cm.Position = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'rprtmed.Show()
    End Sub

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub
End Class


