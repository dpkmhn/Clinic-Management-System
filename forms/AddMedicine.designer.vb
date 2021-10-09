<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddMedicine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMedicine))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdnext = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdfirst = New System.Windows.Forms.Button()
        Me.cmdprevious = New System.Windows.Forms.Button()
        Me.cmdaddnew = New System.Windows.Forms.Button()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.AddMedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtmprice = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MedicineIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicinePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddMedicineTableAdapter = New WindowsApplication1.DataSet1TableAdapters.AddMedicineTableAdapter()
        CType(Me.AddMedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdnext
        '
        Me.cmdnext.Image = CType(resources.GetObject("cmdnext.Image"), System.Drawing.Image)
        Me.cmdnext.Location = New System.Drawing.Point(943, 560)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(62, 53)
        Me.cmdnext.TabIndex = 82
        Me.cmdnext.Text = " "
        Me.cmdnext.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1011, 560)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 53)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdfirst
        '
        Me.cmdfirst.Image = CType(resources.GetObject("cmdfirst.Image"), System.Drawing.Image)
        Me.cmdfirst.Location = New System.Drawing.Point(807, 560)
        Me.cmdfirst.Name = "cmdfirst"
        Me.cmdfirst.Size = New System.Drawing.Size(62, 53)
        Me.cmdfirst.TabIndex = 79
        Me.cmdfirst.Text = " "
        Me.cmdfirst.UseVisualStyleBackColor = True
        '
        'cmdprevious
        '
        Me.cmdprevious.Image = CType(resources.GetObject("cmdprevious.Image"), System.Drawing.Image)
        Me.cmdprevious.Location = New System.Drawing.Point(875, 560)
        Me.cmdprevious.Name = "cmdprevious"
        Me.cmdprevious.Size = New System.Drawing.Size(62, 53)
        Me.cmdprevious.TabIndex = 80
        Me.cmdprevious.Text = " "
        Me.cmdprevious.UseVisualStyleBackColor = True
        '
        'cmdaddnew
        '
        Me.cmdaddnew.Image = CType(resources.GetObject("cmdaddnew.Image"), System.Drawing.Image)
        Me.cmdaddnew.Location = New System.Drawing.Point(459, 551)
        Me.cmdaddnew.Name = "cmdaddnew"
        Me.cmdaddnew.Size = New System.Drawing.Size(62, 62)
        Me.cmdaddnew.TabIndex = 78
        Me.cmdaddnew.Text = " "
        Me.cmdaddnew.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Image = CType(resources.GetObject("cmdclose.Image"), System.Drawing.Image)
        Me.cmdclose.Location = New System.Drawing.Point(497, 620)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(62, 62)
        Me.cmdclose.TabIndex = 77
        Me.cmdclose.Text = " "
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Image = CType(resources.GetObject("cmdupdate.Image"), System.Drawing.Image)
        Me.cmdupdate.Location = New System.Drawing.Point(596, 551)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(62, 62)
        Me.cmdupdate.TabIndex = 76
        Me.cmdupdate.Text = " "
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Image = CType(resources.GetObject("cmddelete.Image"), System.Drawing.Image)
        Me.cmddelete.Location = New System.Drawing.Point(565, 620)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(62, 62)
        Me.cmddelete.TabIndex = 75
        Me.cmddelete.Text = " "
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Image = CType(resources.GetObject("cmdsave.Image"), System.Drawing.Image)
        Me.cmdsave.Location = New System.Drawing.Point(528, 551)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(62, 62)
        Me.cmdsave.TabIndex = 74
        Me.cmdsave.Text = " "
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Medicine Price"
        '
        'txtmid
        '
        Me.txtmid.Enabled = False
        Me.txtmid.Location = New System.Drawing.Point(173, 38)
        Me.txtmid.Name = "txtmid"
        Me.txtmid.Size = New System.Drawing.Size(229, 23)
        Me.txtmid.TabIndex = 5
        '
        'AddMedicineBindingSource
        '
        Me.AddMedicineBindingSource.DataMember = "AddMedicine"
        Me.AddMedicineBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(173, 82)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(229, 23)
        Me.txtmname.TabIndex = 6
        '
        'txtmprice
        '
        Me.txtmprice.Location = New System.Drawing.Point(173, 120)
        Me.txtmprice.Name = "txtmprice"
        Me.txtmprice.Size = New System.Drawing.Size(229, 23)
        Me.txtmprice.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(343, 115)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(411, 228)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medicine ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicineIDDataGridViewTextBoxColumn, Me.MedicineNameDataGridViewTextBoxColumn, Me.MedicinePriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AddMedicineBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(789, 115)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(358, 431)
        Me.DataGridView1.TabIndex = 71
        '
        'MedicineIDDataGridViewTextBoxColumn
        '
        Me.MedicineIDDataGridViewTextBoxColumn.DataPropertyName = "MedicineID"
        Me.MedicineIDDataGridViewTextBoxColumn.HeaderText = "MedicineID"
        Me.MedicineIDDataGridViewTextBoxColumn.Name = "MedicineIDDataGridViewTextBoxColumn"
        '
        'MedicineNameDataGridViewTextBoxColumn
        '
        Me.MedicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName"
        Me.MedicineNameDataGridViewTextBoxColumn.HeaderText = "MedicineName"
        Me.MedicineNameDataGridViewTextBoxColumn.Name = "MedicineNameDataGridViewTextBoxColumn"
        '
        'MedicinePriceDataGridViewTextBoxColumn
        '
        Me.MedicinePriceDataGridViewTextBoxColumn.DataPropertyName = "MedicinePrice"
        Me.MedicinePriceDataGridViewTextBoxColumn.HeaderText = "MedicinePrice"
        Me.MedicinePriceDataGridViewTextBoxColumn.Name = "MedicinePriceDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(687, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 29)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Add Medicine"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Medicine Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtmid)
        Me.GroupBox1.Controls.Add(Me.txtmname)
        Me.GroupBox1.Controls.Add(Me.txtmprice)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(343, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 175)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Medicine"
        '
        'AddMedicineTableAdapter
        '
        Me.AddMedicineTableAdapter.ClearBeforeFill = True
        '
        'AddMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 749)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdfirst)
        Me.Controls.Add(Me.cmdprevious)
        Me.Controls.Add(Me.cmdaddnew)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddMedicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AddMedicine"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AddMedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdnext As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdfirst As Button
    Friend WithEvents cmdprevious As Button
    Friend WithEvents cmdaddnew As Button
    Friend WithEvents cmdclose As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmddelete As Button
    Friend WithEvents cmdsave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmid As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtmprice As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents AddMedicineBindingSource As BindingSource
    Friend WithEvents AddMedicineTableAdapter As DataSet1TableAdapters.AddMedicineTableAdapter
    Friend WithEvents MedicineIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicineNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicinePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
