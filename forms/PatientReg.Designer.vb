<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientReg))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtissue = New System.Windows.Forms.TextBox()
        Me.txtmobileno = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtaddhaarno = New System.Windows.Forms.TextBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpatientid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdprevious = New System.Windows.Forms.Button()
        Me.cmdfirst = New System.Windows.Forms.Button()
        Me.cmdlast = New System.Windows.Forms.Button()
        Me.cmdnext = New System.Windows.Forms.Button()
        Me.cmdaddnew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 280)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Issue"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(143, 135)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 75
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(197, 135)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton2.TabIndex = 76
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 164)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(210, 22)
        Me.DateTimePicker1.TabIndex = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.txtissue)
        Me.GroupBox1.Controls.Add(Me.txtmobileno)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtaddhaarno)
        Me.GroupBox1.Controls.Add(Me.txtsurname)
        Me.GroupBox1.Controls.Add(Me.txtpatientname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtpatientid)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(94, 293)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(389, 369)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Registration"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male ", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(143, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 24)
        Me.ComboBox1.TabIndex = 77
        '
        'txtissue
        '
        Me.txtissue.Location = New System.Drawing.Point(144, 277)
        Me.txtissue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtissue.Name = "txtissue"
        Me.txtissue.Size = New System.Drawing.Size(210, 22)
        Me.txtissue.TabIndex = 35
        '
        'txtmobileno
        '
        Me.txtmobileno.Location = New System.Drawing.Point(144, 250)
        Me.txtmobileno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmobileno.MaxLength = 10
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(210, 22)
        Me.txtmobileno.TabIndex = 34
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(144, 221)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(210, 22)
        Me.txtaddress.TabIndex = 33
        '
        'txtaddhaarno
        '
        Me.txtaddhaarno.Location = New System.Drawing.Point(144, 195)
        Me.txtaddhaarno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaddhaarno.MaxLength = 12
        Me.txtaddhaarno.Name = "txtaddhaarno"
        Me.txtaddhaarno.Size = New System.Drawing.Size(210, 22)
        Me.txtaddhaarno.TabIndex = 32
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(144, 100)
        Me.txtsurname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(210, 22)
        Me.txtsurname.TabIndex = 29
        '
        'txtpatientname
        '
        Me.txtpatientname.Location = New System.Drawing.Point(144, 68)
        Me.txtpatientname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(210, 22)
        Me.txtpatientname.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Patient ID"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(144, 309)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(210, 22)
        Me.txtemail.TabIndex = 36
        '
        'txtpatientid
        '
        Me.txtpatientid.Enabled = False
        Me.txtpatientid.Location = New System.Drawing.Point(144, 33)
        Me.txtpatientid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(210, 22)
        Me.txtpatientid.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 312)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "First Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 254)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Mobile No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Surname"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 225)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Addhaar No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Date Of Birth"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(94, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(810, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 29)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Patient Registration"
        '
        'cmdsave
        '
        Me.cmdsave.Image = CType(resources.GetObject("cmdsave.Image"), System.Drawing.Image)
        Me.cmdsave.Location = New System.Drawing.Point(783, 522)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(66, 60)
        Me.cmdsave.TabIndex = 51
        Me.cmdsave.Text = " "
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Image = CType(resources.GetObject("cmddelete.Image"), System.Drawing.Image)
        Me.cmddelete.Location = New System.Drawing.Point(919, 522)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(66, 60)
        Me.cmddelete.TabIndex = 52
        Me.cmddelete.Text = " "
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Image = CType(resources.GetObject("cmdupdate.Image"), System.Drawing.Image)
        Me.cmdupdate.Location = New System.Drawing.Point(851, 522)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(66, 60)
        Me.cmdupdate.TabIndex = 53
        Me.cmdupdate.Text = " "
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Image = CType(resources.GetObject("cmdclose.Image"), System.Drawing.Image)
        Me.cmdclose.Location = New System.Drawing.Point(991, 522)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(68, 60)
        Me.cmdclose.TabIndex = 54
        Me.cmdclose.Text = " "
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(496, 91)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(796, 394)
        Me.DataGridView1.TabIndex = 50
        '
        'cmdprevious
        '
        Me.cmdprevious.Image = CType(resources.GetObject("cmdprevious.Image"), System.Drawing.Image)
        Me.cmdprevious.Location = New System.Drawing.Point(815, 591)
        Me.cmdprevious.Name = "cmdprevious"
        Me.cmdprevious.Size = New System.Drawing.Size(66, 56)
        Me.cmdprevious.TabIndex = 57
        Me.cmdprevious.Text = " "
        Me.cmdprevious.UseVisualStyleBackColor = True
        '
        'cmdfirst
        '
        Me.cmdfirst.Image = CType(resources.GetObject("cmdfirst.Image"), System.Drawing.Image)
        Me.cmdfirst.Location = New System.Drawing.Point(747, 591)
        Me.cmdfirst.Name = "cmdfirst"
        Me.cmdfirst.Size = New System.Drawing.Size(66, 56)
        Me.cmdfirst.TabIndex = 56
        Me.cmdfirst.Text = " "
        Me.cmdfirst.UseVisualStyleBackColor = True
        '
        'cmdlast
        '
        Me.cmdlast.Image = CType(resources.GetObject("cmdlast.Image"), System.Drawing.Image)
        Me.cmdlast.Location = New System.Drawing.Point(951, 591)
        Me.cmdlast.Name = "cmdlast"
        Me.cmdlast.Size = New System.Drawing.Size(66, 56)
        Me.cmdlast.TabIndex = 58
        Me.cmdlast.Text = " "
        Me.cmdlast.UseVisualStyleBackColor = True
        '
        'cmdnext
        '
        Me.cmdnext.Image = CType(resources.GetObject("cmdnext.Image"), System.Drawing.Image)
        Me.cmdnext.Location = New System.Drawing.Point(883, 591)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(66, 56)
        Me.cmdnext.TabIndex = 59
        Me.cmdnext.Text = " "
        Me.cmdnext.UseVisualStyleBackColor = True
        '
        'cmdaddnew
        '
        Me.cmdaddnew.Image = CType(resources.GetObject("cmdaddnew.Image"), System.Drawing.Image)
        Me.cmdaddnew.Location = New System.Drawing.Point(715, 522)
        Me.cmdaddnew.Name = "cmdaddnew"
        Me.cmdaddnew.Size = New System.Drawing.Size(66, 60)
        Me.cmdaddnew.TabIndex = 55
        Me.cmdaddnew.Text = " "
        Me.cmdaddnew.UseVisualStyleBackColor = True
        '
        'PatientReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.cmdlast)
        Me.Controls.Add(Me.cmdfirst)
        Me.Controls.Add(Me.cmdprevious)
        Me.Controls.Add(Me.cmdaddnew)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PatientReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtissue As TextBox
    Friend WithEvents txtmobileno As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtaddhaarno As TextBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpatientid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdsave As Button
    Friend WithEvents cmddelete As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdclose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdprevious As Button
    Friend WithEvents cmdfirst As Button
    Friend WithEvents cmdlast As Button
    Friend WithEvents cmdnext As Button
    Friend WithEvents cmdaddnew As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
