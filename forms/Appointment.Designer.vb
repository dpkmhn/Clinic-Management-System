<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtissue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtendtime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtstarttime = New System.Windows.Forms.DateTimePicker()
        Me.dnext = New System.Windows.Forms.Button()
        Me.dpre = New System.Windows.Forms.Button()
        Me.pnext = New System.Windows.Forms.Button()
        Me.ppre = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdname = New System.Windows.Forms.TextBox()
        Me.txtdid = New System.Windows.Forms.TextBox()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.txttoken = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdlast = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmdnext = New System.Windows.Forms.Button()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.cmdprevious = New System.Windows.Forms.Button()
        Me.cmdaddnew = New System.Windows.Forms.Button()
        Me.cmdfirst = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmddelete = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(462, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'txtissue
        '
        Me.txtissue.Location = New System.Drawing.Point(212, 147)
        Me.txtissue.Name = "txtissue"
        Me.txtissue.Size = New System.Drawing.Size(187, 23)
        Me.txtissue.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Issue"
        '
        'txtendtime
        '
        Me.txtendtime.CustomFormat = "dd-MM-yyyy, hh:mm:ss"
        Me.txtendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtendtime.Location = New System.Drawing.Point(212, 309)
        Me.txtendtime.Name = "txtendtime"
        Me.txtendtime.Size = New System.Drawing.Size(206, 23)
        Me.txtendtime.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtissue)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtstarttime)
        Me.GroupBox1.Controls.Add(Me.txtendtime)
        Me.GroupBox1.Controls.Add(Me.dnext)
        Me.GroupBox1.Controls.Add(Me.dpre)
        Me.GroupBox1.Controls.Add(Me.pnext)
        Me.GroupBox1.Controls.Add(Me.ppre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdname)
        Me.GroupBox1.Controls.Add(Me.txtdid)
        Me.GroupBox1.Controls.Add(Me.txtpname)
        Me.GroupBox1.Controls.Add(Me.txtpid)
        Me.GroupBox1.Controls.Add(Me.txttoken)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(74, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 343)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment"
        '
        'txtstarttime
        '
        Me.txtstarttime.CustomFormat = "dd-MM-yyyy, hh:mm:ss"
        Me.txtstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtstarttime.Location = New System.Drawing.Point(212, 275)
        Me.txtstarttime.Name = "txtstarttime"
        Me.txtstarttime.Size = New System.Drawing.Size(206, 23)
        Me.txtstarttime.TabIndex = 52
        Me.txtstarttime.Value = New Date(2021, 6, 1, 4, 45, 0, 0)
        '
        'dnext
        '
        Me.dnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dnext.Location = New System.Drawing.Point(405, 186)
        Me.dnext.Name = "dnext"
        Me.dnext.Size = New System.Drawing.Size(30, 31)
        Me.dnext.TabIndex = 38
        Me.dnext.Text = ">"
        Me.dnext.UseVisualStyleBackColor = True
        '
        'dpre
        '
        Me.dpre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpre.Location = New System.Drawing.Point(405, 216)
        Me.dpre.Name = "dpre"
        Me.dpre.Size = New System.Drawing.Size(30, 31)
        Me.dpre.TabIndex = 37
        Me.dpre.Text = "<"
        Me.dpre.UseVisualStyleBackColor = True
        '
        'pnext
        '
        Me.pnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnext.Location = New System.Drawing.Point(405, 73)
        Me.pnext.Name = "pnext"
        Me.pnext.Size = New System.Drawing.Size(30, 31)
        Me.pnext.TabIndex = 36
        Me.pnext.Text = ">"
        Me.pnext.UseVisualStyleBackColor = True
        '
        'ppre
        '
        Me.ppre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppre.Location = New System.Drawing.Point(405, 103)
        Me.ppre.Name = "ppre"
        Me.ppre.Size = New System.Drawing.Size(30, 31)
        Me.ppre.TabIndex = 35
        Me.ppre.Text = "<"
        Me.ppre.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Token No."
        '
        'txtdname
        '
        Me.txtdname.Location = New System.Drawing.Point(212, 225)
        Me.txtdname.Name = "txtdname"
        Me.txtdname.Size = New System.Drawing.Size(187, 23)
        Me.txtdname.TabIndex = 31
        '
        'txtdid
        '
        Me.txtdid.Location = New System.Drawing.Point(212, 184)
        Me.txtdid.Name = "txtdid"
        Me.txtdid.Size = New System.Drawing.Size(187, 23)
        Me.txtdid.TabIndex = 30
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(212, 111)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(187, 23)
        Me.txtpname.TabIndex = 28
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(212, 70)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(187, 23)
        Me.txtpid.TabIndex = 27
        '
        'txttoken
        '
        Me.txttoken.Location = New System.Drawing.Point(212, 25)
        Me.txttoken.Name = "txttoken"
        Me.txttoken.Size = New System.Drawing.Size(187, 23)
        Me.txttoken.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Appointmrnt End Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Appointment Start Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Doctor Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Doctor ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Patient First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Patient ID"
        '
        'cmdlast
        '
        Me.cmdlast.Image = CType(resources.GetObject("cmdlast.Image"), System.Drawing.Image)
        Me.cmdlast.Location = New System.Drawing.Point(855, 519)
        Me.cmdlast.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdlast.Name = "cmdlast"
        Me.cmdlast.Size = New System.Drawing.Size(58, 54)
        Me.cmdlast.TabIndex = 82
        Me.cmdlast.Text = " "
        Me.cmdlast.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(869, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 29)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Appointment"
        '
        'cmdsave
        '
        Me.cmdsave.Image = CType(resources.GetObject("cmdsave.Image"), System.Drawing.Image)
        Me.cmdsave.Location = New System.Drawing.Point(235, 630)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(61, 62)
        Me.cmdsave.TabIndex = 84
        Me.cmdsave.Text = " "
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdnext
        '
        Me.cmdnext.Image = CType(resources.GetObject("cmdnext.Image"), System.Drawing.Image)
        Me.cmdnext.Location = New System.Drawing.Point(789, 519)
        Me.cmdnext.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(58, 54)
        Me.cmdnext.TabIndex = 83
        Me.cmdnext.Text = " "
        Me.cmdnext.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Image = CType(resources.GetObject("cmdclose.Image"), System.Drawing.Image)
        Me.cmdclose.Location = New System.Drawing.Point(373, 629)
        Me.cmdclose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(61, 63)
        Me.cmdclose.TabIndex = 86
        Me.cmdclose.Text = " "
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdprevious
        '
        Me.cmdprevious.Image = CType(resources.GetObject("cmdprevious.Image"), System.Drawing.Image)
        Me.cmdprevious.Location = New System.Drawing.Point(723, 519)
        Me.cmdprevious.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdprevious.Name = "cmdprevious"
        Me.cmdprevious.Size = New System.Drawing.Size(58, 54)
        Me.cmdprevious.TabIndex = 81
        Me.cmdprevious.Text = " "
        Me.cmdprevious.UseVisualStyleBackColor = True
        '
        'cmdaddnew
        '
        Me.cmdaddnew.Image = CType(resources.GetObject("cmdaddnew.Image"), System.Drawing.Image)
        Me.cmdaddnew.Location = New System.Drawing.Point(166, 629)
        Me.cmdaddnew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdaddnew.Name = "cmdaddnew"
        Me.cmdaddnew.Size = New System.Drawing.Size(61, 63)
        Me.cmdaddnew.TabIndex = 87
        Me.cmdaddnew.Text = " "
        Me.cmdaddnew.UseVisualStyleBackColor = True
        '
        'cmdfirst
        '
        Me.cmdfirst.Image = CType(resources.GetObject("cmdfirst.Image"), System.Drawing.Image)
        Me.cmdfirst.Location = New System.Drawing.Point(657, 519)
        Me.cmdfirst.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdfirst.Name = "cmdfirst"
        Me.cmdfirst.Size = New System.Drawing.Size(58, 53)
        Me.cmdfirst.TabIndex = 80
        Me.cmdfirst.Text = " "
        Me.cmdfirst.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(549, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(724, 434)
        Me.DataGridView1.TabIndex = 79
        '
        'cmddelete
        '
        Me.cmddelete.Image = CType(resources.GetObject("cmddelete.Image"), System.Drawing.Image)
        Me.cmddelete.Location = New System.Drawing.Point(304, 629)
        Me.cmddelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(61, 63)
        Me.cmddelete.TabIndex = 85
        Me.cmddelete.Text = " "
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdlast)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.cmdprevious)
        Me.Controls.Add(Me.cmdaddnew)
        Me.Controls.Add(Me.cmdfirst)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmddelete)
        Me.Name = "Appointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Appointment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtissue As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtendtime As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtstarttime As DateTimePicker
    Friend WithEvents dnext As Button
    Friend WithEvents dpre As Button
    Friend WithEvents pnext As Button
    Friend WithEvents ppre As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdname As TextBox
    Friend WithEvents txtdid As TextBox
    Friend WithEvents txtpname As TextBox
    Friend WithEvents txtpid As TextBox
    Friend WithEvents txttoken As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdlast As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdsave As Button
    Friend WithEvents cmdnext As Button
    Friend WithEvents cmdclose As Button
    Friend WithEvents cmdprevious As Button
    Friend WithEvents cmdaddnew As Button
    Friend WithEvents cmdfirst As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmddelete As Button
End Class
