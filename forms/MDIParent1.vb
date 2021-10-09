Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Parent = PictureBox6
        ' Label1.BackColor = Color.Transparent
        ' MDIParent1.
    End Sub

    Private Sub PatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientToolStripMenuItem.Click

    End Sub

    Private Sub PatientRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientRegistrationToolStripMenuItem.Click
        PatientReg.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PatientReg.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub PatientSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientSearchToolStripMenuItem.Click
        Patientsearch.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        About.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        RprtPatient.Show()
    End Sub

    Private Sub PatientAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientAppointmentToolStripMenuItem.Click
        Appointment.Show()
    End Sub

    Private Sub AddPrescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPrescriptionToolStripMenuItem.Click
        Prescription.Show()
    End Sub

    Private Sub PatientInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientInvoiceToolStripMenuItem.Click
        PatientInvoiceME.Show()
    End Sub

    Private Sub AddDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDoctorToolStripMenuItem.Click
        Doc_Maintenence.Show()
    End Sub

    Private Sub MedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicineToolStripMenuItem.Click
    End Sub

    Private Sub AddMedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMedicineToolStripMenuItem.Click
        AddMedicine.Show()
    End Sub

    Private Sub StaffEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffEntryToolStripMenuItem.Click
        staff.Show()
    End Sub

    Private Sub StaffSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffSearchToolStripMenuItem.Click
        staffsearch.Show()
    End Sub

    Private Sub DoctorSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorSearchToolStripMenuItem.Click
        DoctorSearch.Show()
    End Sub

    Private Sub patreg_Click(sender As Object, e As EventArgs) Handles patreg.Click
        PatientReg.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub apt_Click(sender As Object, e As EventArgs) Handles apt.Click
        Appointment.Show()
    End Sub

    Private Sub doc_Click(sender As Object, e As EventArgs) Handles doc.Click
        Doc_Maintenence.Show()
    End Sub

    Private Sub bill_Click(sender As Object, e As EventArgs) Handles bill.Click
        PatientInvoiceME.Show()
    End Sub

    Private Sub logoff_Click(sender As Object, e As EventArgs) Handles logoff.Click
        Login.Show()
    End Sub

    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        Me.Close()

    End Sub

    Private Sub AppointmentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentReportToolStripMenuItem.Click
        rprtApt.Show()
    End Sub

    Private Sub BillingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingReportToolStripMenuItem.Click
        RprtInvoice.Show()

    End Sub

    Private Sub DoctorReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorReportToolStripMenuItem.Click
        rprtdoctor.Show()
    End Sub

    Private Sub MedicineReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicineReportToolStripMenuItem.Click
        Rprtmedicine.Show()
    End Sub

    Private Sub StaffReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffReportToolStripMenuItem.Click
        Rprtstf.Show()
    End Sub

    Private Sub PatientReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientReportToolStripMenuItem.Click
        RprtPatient.Show()
    End Sub

    Private Sub DoctorReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DoctorReportToolStripMenuItem1.Click
        rprtdoctor.Show()
    End Sub

    Private Sub AppointmentReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AppointmentReportToolStripMenuItem1.Click
        rprtApt.Show()
    End Sub

    Private Sub BillingReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BillingReportToolStripMenuItem1.Click
        RprtInvoice.Show()
    End Sub

    Private Sub MedicineReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MedicineReportToolStripMenuItem1.Click
        Rprtmedicine.Show()
    End Sub

    Private Sub StaffReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StaffReportToolStripMenuItem1.Click
        Rprtstf.Show()

    End Sub

    Private Sub PrescriptionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrescriptionReportToolStripMenuItem.Click
        RprtPrecription.Show()
    End Sub

    Private Sub cngpass_Click(sender As Object, e As EventArgs) Handles cngpass.Click
        Reset.Show()
    End Sub
End Class
