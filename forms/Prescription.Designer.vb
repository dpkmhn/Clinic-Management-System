<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prescription))
        Me.cmdnext = New System.Windows.Forms.Button()
        Me.cmdlast = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mnextt = New System.Windows.Forms.Button()
        Me.txtunits = New System.Windows.Forms.TextBox()
        Me.dnext = New System.Windows.Forms.Button()
        Me.mpree = New System.Windows.Forms.Button()
        Me.dprev = New System.Windows.Forms.Button()
        Me.cmdprevious = New System.Windows.Forms.Button()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.pnext = New System.Windows.Forms.Button()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.ppre = New System.Windows.Forms.Button()
        Me.txtdname = New System.Windows.Forms.TextBox()
        Me.txtdid = New System.Windows.Forms.TextBox()
        Me.cmdfirst = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdaddnew = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdnext
        '
        Me.cmdnext.Image = CType(resources.GetObject("cmdnext.Image"), System.Drawing.Image)
        Me.cmdnext.Location = New System.Drawing.Point(927, 529)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(63, 58)
        Me.cmdnext.TabIndex = 68
        Me.cmdnext.Text = " "
        Me.cmdnext.UseVisualStyleBackColor = True
        '
        'cmdlast
        '
        Me.cmdlast.Image = CType(resources.GetObject("cmdlast.Image"), System.Drawing.Image)
        Me.cmdlast.Location = New System.Drawing.Point(997, 529)
        Me.cmdlast.Name = "cmdlast"
        Me.cmdlast.Size = New System.Drawing.Size(58, 58)
        Me.cmdlast.TabIndex = 67
        Me.cmdlast.Text = " "
        Me.cmdlast.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(528, 69)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(784, 443)
        Me.DataGridView1.TabIndex = 60
        '
        'mnextt
        '
        Me.mnextt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnextt.Location = New System.Drawing.Point(320, 234)
        Me.mnextt.Margin = New System.Windows.Forms.Padding(2)
        Me.mnextt.Name = "mnextt"
        Me.mnextt.Size = New System.Drawing.Size(22, 25)
        Me.mnextt.TabIndex = 42
        Me.mnextt.Text = ">"
        Me.mnextt.UseVisualStyleBackColor = True
        '
        'txtunits
        '
        Me.txtunits.Location = New System.Drawing.Point(148, 295)
        Me.txtunits.Margin = New System.Windows.Forms.Padding(2)
        Me.txtunits.Name = "txtunits"
        Me.txtunits.Size = New System.Drawing.Size(162, 22)
        Me.txtunits.TabIndex = 34
        '
        'dnext
        '
        Me.dnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dnext.Location = New System.Drawing.Point(320, 153)
        Me.dnext.Margin = New System.Windows.Forms.Padding(2)
        Me.dnext.Name = "dnext"
        Me.dnext.Size = New System.Drawing.Size(22, 25)
        Me.dnext.TabIndex = 40
        Me.dnext.Text = ">"
        Me.dnext.UseVisualStyleBackColor = True
        '
        'mpree
        '
        Me.mpree.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mpree.Location = New System.Drawing.Point(320, 263)
        Me.mpree.Margin = New System.Windows.Forms.Padding(2)
        Me.mpree.Name = "mpree"
        Me.mpree.Size = New System.Drawing.Size(22, 25)
        Me.mpree.TabIndex = 41
        Me.mpree.Text = "<"
        Me.mpree.UseVisualStyleBackColor = True
        '
        'dprev
        '
        Me.dprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dprev.Location = New System.Drawing.Point(320, 182)
        Me.dprev.Margin = New System.Windows.Forms.Padding(2)
        Me.dprev.Name = "dprev"
        Me.dprev.Size = New System.Drawing.Size(22, 25)
        Me.dprev.TabIndex = 39
        Me.dprev.Text = "<"
        Me.dprev.UseVisualStyleBackColor = True
        '
        'cmdprevious
        '
        Me.cmdprevious.Image = CType(resources.GetObject("cmdprevious.Image"), System.Drawing.Image)
        Me.cmdprevious.Location = New System.Drawing.Point(860, 529)
        Me.cmdprevious.Name = "cmdprevious"
        Me.cmdprevious.Size = New System.Drawing.Size(62, 58)
        Me.cmdprevious.TabIndex = 66
        Me.cmdprevious.Text = " "
        Me.cmdprevious.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Image = CType(resources.GetObject("cmdclose.Image"), System.Drawing.Image)
        Me.cmdclose.Location = New System.Drawing.Point(437, 590)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(62, 62)
        Me.cmdclose.TabIndex = 64
        Me.cmdclose.Text = " "
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(148, 262)
        Me.txtmname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(162, 22)
        Me.txtmname.TabIndex = 33
        '
        'pnext
        '
        Me.pnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnext.Location = New System.Drawing.Point(319, 72)
        Me.pnext.Margin = New System.Windows.Forms.Padding(2)
        Me.pnext.Name = "pnext"
        Me.pnext.Size = New System.Drawing.Size(22, 25)
        Me.pnext.TabIndex = 40
        Me.pnext.Text = ">"
        Me.pnext.UseVisualStyleBackColor = True
        '
        'txtmid
        '
        Me.txtmid.Location = New System.Drawing.Point(148, 229)
        Me.txtmid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmid.Name = "txtmid"
        Me.txtmid.Size = New System.Drawing.Size(162, 22)
        Me.txtmid.TabIndex = 32
        '
        'ppre
        '
        Me.ppre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppre.Location = New System.Drawing.Point(319, 101)
        Me.ppre.Margin = New System.Windows.Forms.Padding(2)
        Me.ppre.Name = "ppre"
        Me.ppre.Size = New System.Drawing.Size(22, 25)
        Me.ppre.TabIndex = 39
        Me.ppre.Text = "<"
        Me.ppre.UseVisualStyleBackColor = True
        '
        'txtdname
        '
        Me.txtdname.Location = New System.Drawing.Point(148, 187)
        Me.txtdname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdname.Name = "txtdname"
        Me.txtdname.Size = New System.Drawing.Size(162, 22)
        Me.txtdname.TabIndex = 31
        '
        'txtdid
        '
        Me.txtdid.Location = New System.Drawing.Point(148, 142)
        Me.txtdid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdid.Name = "txtdid"
        Me.txtdid.Size = New System.Drawing.Size(162, 22)
        Me.txtdid.TabIndex = 30
        '
        'cmdfirst
        '
        Me.cmdfirst.Image = CType(resources.GetObject("cmdfirst.Image"), System.Drawing.Image)
        Me.cmdfirst.Location = New System.Drawing.Point(794, 529)
        Me.cmdfirst.Name = "cmdfirst"
        Me.cmdfirst.Size = New System.Drawing.Size(60, 58)
        Me.cmdfirst.TabIndex = 65
        Me.cmdfirst.Text = " "
        Me.cmdfirst.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Image = CType(resources.GetObject("cmdupdate.Image"), System.Drawing.Image)
        Me.cmdupdate.Location = New System.Drawing.Point(301, 590)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(62, 62)
        Me.cmdupdate.TabIndex = 63
        Me.cmdupdate.Text = " "
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Image = CType(resources.GetObject("cmdsave.Image"), System.Drawing.Image)
        Me.cmdsave.Location = New System.Drawing.Point(231, 590)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(62, 62)
        Me.cmdsave.TabIndex = 61
        Me.cmdsave.Text = " "
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(148, 104)
        Me.txtpname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(162, 22)
        Me.txtpname.TabIndex = 29
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(148, 62)
        Me.txtpid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(162, 22)
        Me.txtpid.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 296)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Units"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 230)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Medicine Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Doctor Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Doctor Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Patient Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Patient Id"
        '
        'cmddelete
        '
        Me.cmddelete.Image = CType(resources.GetObject("cmddelete.Image"), System.Drawing.Image)
        Me.cmddelete.Location = New System.Drawing.Point(369, 590)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(62, 62)
        Me.cmddelete.TabIndex = 62
        Me.cmddelete.Text = " "
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.mnextt)
        Me.GroupBox1.Controls.Add(Me.txtunits)
        Me.GroupBox1.Controls.Add(Me.dnext)
        Me.GroupBox1.Controls.Add(Me.mpree)
        Me.GroupBox1.Controls.Add(Me.dprev)
        Me.GroupBox1.Controls.Add(Me.txtmname)
        Me.GroupBox1.Controls.Add(Me.pnext)
        Me.GroupBox1.Controls.Add(Me.txtmid)
        Me.GroupBox1.Controls.Add(Me.ppre)
        Me.GroupBox1.Controls.Add(Me.txtdname)
        Me.GroupBox1.Controls.Add(Me.txtdid)
        Me.GroupBox1.Controls.Add(Me.txtpname)
        Me.GroupBox1.Controls.Add(Me.txtpid)
        Me.GroupBox1.Controls.Add(Me.pid)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(151, 253)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(364, 332)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prescription Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Prescription ID"
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(148, 23)
        Me.pid.Margin = New System.Windows.Forms.Padding(2)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(162, 22)
        Me.pid.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 263)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Medicine Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 282)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Prescription Id"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(151, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(789, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 29)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Add Prescription"
        '
        'cmdaddnew
        '
        Me.cmdaddnew.Image = CType(resources.GetObject("cmdaddnew.Image"), System.Drawing.Image)
        Me.cmdaddnew.Location = New System.Drawing.Point(164, 590)
        Me.cmdaddnew.Name = "cmdaddnew"
        Me.cmdaddnew.Size = New System.Drawing.Size(62, 62)
        Me.cmdaddnew.TabIndex = 70
        Me.cmdaddnew.Text = " "
        Me.cmdaddnew.UseVisualStyleBackColor = True
        '
        'Prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.cmdaddnew)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.cmdlast)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdprevious)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.cmdfirst)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Prescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Prescription"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdnext As Button
    Friend WithEvents cmdlast As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mnextt As Button
    Friend WithEvents txtunits As TextBox
    Friend WithEvents dnext As Button
    Friend WithEvents mpree As Button
    Friend WithEvents dprev As Button
    Friend WithEvents cmdprevious As Button
    Friend WithEvents cmdclose As Button
    Friend WithEvents txtmname As TextBox
    Friend WithEvents pnext As Button
    Friend WithEvents txtmid As TextBox
    Friend WithEvents ppre As Button
    Friend WithEvents txtdname As TextBox
    Friend WithEvents txtdid As TextBox
    Friend WithEvents cmdfirst As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdsave As Button
    Friend WithEvents txtpname As TextBox
    Friend WithEvents txtpid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmddelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdaddnew As Button
End Class
