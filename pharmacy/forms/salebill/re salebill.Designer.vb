<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class re_salebill
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(re_salebill))
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.recmbtype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.resalebill_idsale = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.resalebill_user = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.resalebill_date = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.redgvsalebill = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.custnam = New System.Windows.Forms.TextBox()
        Me.resalebill_id = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lbltel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbldebt = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcredit = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.resalebill_reqired = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.resalebill_remaine = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.resalebill_paid = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.salebill_tax = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.resalebill_disc = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.resalebill_total = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6.SuspendLayout()
        CType(Me.redgvsalebill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'recmbtype
        '
        Me.recmbtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recmbtype.ForeColor = System.Drawing.Color.White
        Me.recmbtype.FormattingEnabled = True
        Me.recmbtype.Items.AddRange(New Object() {"نقدى", "اجل", "دفعات نقديه"})
        Me.recmbtype.Location = New System.Drawing.Point(94, 103)
        Me.recmbtype.Name = "recmbtype"
        Me.recmbtype.Size = New System.Drawing.Size(175, 22)
        Me.recmbtype.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "نوع الفاتوره:"
        '
        'resalebill_idsale
        '
        Me.resalebill_idsale.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_idsale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_idsale.ForeColor = System.Drawing.Color.White
        Me.resalebill_idsale.Location = New System.Drawing.Point(99, 138)
        Me.resalebill_idsale.Name = "resalebill_idsale"
        Me.resalebill_idsale.Size = New System.Drawing.Size(120, 22)
        Me.resalebill_idsale.TabIndex = 5
        Me.resalebill_idsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(177, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 14)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "دائن(له):"
        '
        'resalebill_user
        '
        Me.resalebill_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_user.ForeColor = System.Drawing.Color.White
        Me.resalebill_user.Location = New System.Drawing.Point(94, 75)
        Me.resalebill_user.Name = "resalebill_user"
        Me.resalebill_user.Size = New System.Drawing.Size(175, 22)
        Me.resalebill_user.TabIndex = 9
        Me.resalebill_user.Text = "0"
        Me.resalebill_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 14)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "اسم المستخدم:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "رقم فاتورة المبيعات:"
        '
        'resalebill_date
        '
        Me.resalebill_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_date.ForeColor = System.Drawing.Color.White
        Me.resalebill_date.Location = New System.Drawing.Point(94, 47)
        Me.resalebill_date.Name = "resalebill_date"
        Me.resalebill_date.ReadOnly = True
        Me.resalebill_date.Size = New System.Drawing.Size(175, 22)
        Me.resalebill_date.TabIndex = 3
        Me.resalebill_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(174, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 14)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "مدين(عليه):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(177, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "التليفون:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.redgvsalebill)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 362)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1176, 535)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        '
        'redgvsalebill
        '
        Me.redgvsalebill.AllowUserToAddRows = False
        Me.redgvsalebill.AllowUserToDeleteRows = False
        Me.redgvsalebill.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.redgvsalebill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.redgvsalebill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.redgvsalebill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.redgvsalebill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.redgvsalebill.DefaultCellStyle = DataGridViewCellStyle29
        Me.redgvsalebill.EnableHeadersVisualStyles = False
        Me.redgvsalebill.Location = New System.Drawing.Point(40, 21)
        Me.redgvsalebill.Name = "redgvsalebill"
        Me.redgvsalebill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black
        Me.redgvsalebill.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.redgvsalebill.Size = New System.Drawing.Size(1113, 508)
        Me.redgvsalebill.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(183, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "العنوان:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "تاريخ الفاتوره:"
        '
        'custnam
        '
        Me.custnam.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.custnam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.custnam.ForeColor = System.Drawing.Color.White
        Me.custnam.Location = New System.Drawing.Point(25, 36)
        Me.custnam.Name = "custnam"
        Me.custnam.ReadOnly = True
        Me.custnam.Size = New System.Drawing.Size(175, 22)
        Me.custnam.TabIndex = 5
        Me.custnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'resalebill_id
        '
        Me.resalebill_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_id.Location = New System.Drawing.Point(122, 18)
        Me.resalebill_id.Name = "resalebill_id"
        Me.resalebill_id.Size = New System.Drawing.Size(65, 23)
        Me.resalebill_id.TabIndex = 1
        Me.resalebill_id.Text = "___"
        Me.resalebill_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "اسم البائع:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(25, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 175)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.resalebill_user)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.recmbtype)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.resalebill_idsale)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.resalebill_date)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.resalebill_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(773, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 192)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "رقم الفاتوره:"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(71, 102)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(47, 14)
        Me.lbladdress.TabIndex = 11
        Me.lbladdress.Text = "_____"
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Location = New System.Drawing.Point(71, 132)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(47, 14)
        Me.lbltel.TabIndex = 12
        Me.lbltel.Text = "_____"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnprint)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 45)
        Me.Panel1.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1091, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 39)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "فاتورة مرتجع بيع"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(135, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 34)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.BackgroundImage = CType(resources.GetObject("btnprint.BackgroundImage"), System.Drawing.Image)
        Me.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Location = New System.Drawing.Point(3, 8)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(60, 34)
        Me.btnprint.TabIndex = 4
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(69, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1147, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 39)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lbldebt
        '
        Me.lbldebt.AutoSize = True
        Me.lbldebt.Location = New System.Drawing.Point(71, 160)
        Me.lbldebt.Name = "lbldebt"
        Me.lbldebt.Size = New System.Drawing.Size(47, 14)
        Me.lbldebt.TabIndex = 13
        Me.lbldebt.Text = "_____"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcredit)
        Me.GroupBox2.Controls.Add(Me.lbldebt)
        Me.GroupBox2.Controls.Add(Me.lbltel)
        Me.GroupBox2.Controls.Add(Me.lbladdress)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.custnam)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 277)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'lblcredit
        '
        Me.lblcredit.AutoSize = True
        Me.lblcredit.Location = New System.Drawing.Point(71, 183)
        Me.lblcredit.Name = "lblcredit"
        Me.lblcredit.Size = New System.Drawing.Size(47, 14)
        Me.lblcredit.TabIndex = 14
        Me.lblcredit.Text = "_____"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.resalebill_reqired)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.resalebill_remaine)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.resalebill_paid)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.salebill_tax)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.resalebill_disc)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.resalebill_total)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(414, 195)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'resalebill_reqired
        '
        Me.resalebill_reqired.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_reqired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_reqired.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resalebill_reqired.ForeColor = System.Drawing.Color.White
        Me.resalebill_reqired.Location = New System.Drawing.Point(136, 102)
        Me.resalebill_reqired.Name = "resalebill_reqired"
        Me.resalebill_reqired.ReadOnly = True
        Me.resalebill_reqired.Size = New System.Drawing.Size(129, 24)
        Me.resalebill_reqired.TabIndex = 16
        Me.resalebill_reqired.Text = "0"
        Me.resalebill_reqired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(271, 106)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 14)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "المطلوب:"
        '
        'resalebill_remaine
        '
        Me.resalebill_remaine.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_remaine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_remaine.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resalebill_remaine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.resalebill_remaine.Location = New System.Drawing.Point(136, 163)
        Me.resalebill_remaine.Name = "resalebill_remaine"
        Me.resalebill_remaine.ReadOnly = True
        Me.resalebill_remaine.Size = New System.Drawing.Size(129, 24)
        Me.resalebill_remaine.TabIndex = 14
        Me.resalebill_remaine.Text = "0"
        Me.resalebill_remaine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Lime
        Me.Label24.Location = New System.Drawing.Point(271, 167)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 14)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "الباقى:"
        '
        'resalebill_paid
        '
        Me.resalebill_paid.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_paid.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resalebill_paid.ForeColor = System.Drawing.Color.White
        Me.resalebill_paid.Location = New System.Drawing.Point(136, 132)
        Me.resalebill_paid.Name = "resalebill_paid"
        Me.resalebill_paid.Size = New System.Drawing.Size(129, 24)
        Me.resalebill_paid.TabIndex = 12
        Me.resalebill_paid.Text = "0"
        Me.resalebill_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(271, 136)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 14)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "المدفوع:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Location = New System.Drawing.Point(109, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 14)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "%"
        '
        'salebill_tax
        '
        Me.salebill_tax.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_tax.Enabled = False
        Me.salebill_tax.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salebill_tax.ForeColor = System.Drawing.Color.Maroon
        Me.salebill_tax.Location = New System.Drawing.Point(136, 72)
        Me.salebill_tax.Name = "salebill_tax"
        Me.salebill_tax.Size = New System.Drawing.Size(129, 24)
        Me.salebill_tax.TabIndex = 9
        Me.salebill_tax.Text = "0"
        Me.salebill_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(271, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 14)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "الضريبه:"
        '
        'resalebill_disc
        '
        Me.resalebill_disc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_disc.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resalebill_disc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.resalebill_disc.Location = New System.Drawing.Point(136, 44)
        Me.resalebill_disc.Name = "resalebill_disc"
        Me.resalebill_disc.Size = New System.Drawing.Size(129, 24)
        Me.resalebill_disc.TabIndex = 7
        Me.resalebill_disc.Text = "0"
        Me.resalebill_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(271, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 14)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "الخصم:"
        '
        'resalebill_total
        '
        Me.resalebill_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resalebill_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resalebill_total.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resalebill_total.ForeColor = System.Drawing.Color.White
        Me.resalebill_total.Location = New System.Drawing.Point(136, 16)
        Me.resalebill_total.Name = "resalebill_total"
        Me.resalebill_total.ReadOnly = True
        Me.resalebill_total.Size = New System.Drawing.Size(129, 24)
        Me.resalebill_total.TabIndex = 5
        Me.resalebill_total.Text = "0"
        Me.resalebill_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(271, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 14)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "اجمالى الفاتوره:"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "salebillid_item"
        Me.Column1.HeaderText = "الكود"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "barcode_item"
        Me.Column2.HeaderText = "باركود الصنف"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 180
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "item_name"
        Me.Column3.HeaderText = "اسم الصنف"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "salebill_unit"
        Me.Column4.HeaderText = "الوحده"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 77
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "salebill_price_s"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.Format = "N2"
        DataGridViewCellStyle26.NullValue = "0,0"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle26
        Me.Column8.HeaderText = "سعر البيع"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'Column9
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.Format = "N2"
        DataGridViewCellStyle27.NullValue = "0"
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle27
        Me.Column9.HeaderText = "الكميه"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 65
        '
        'Column10
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.Format = "N2"
        DataGridViewCellStyle28.NullValue = "0,0"
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle28
        Me.Column10.HeaderText = "الاجمالى"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 120
        '
        're_salebill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 900)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "re_salebill"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.redgvsalebill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents recmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents resalebill_idsale As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents resalebill_user As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents resalebill_date As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents redgvsalebill As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents custnam As System.Windows.Forms.TextBox
    Friend WithEvents resalebill_id As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbldebt As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcredit As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents resalebill_reqired As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents resalebill_remaine As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents resalebill_paid As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents salebill_tax As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents resalebill_disc As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents resalebill_total As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
