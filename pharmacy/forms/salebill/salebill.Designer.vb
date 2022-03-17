<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salebill
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salebill))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvsalebill = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.serchbybarcode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.serchbyid = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.salebill_reqired = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbnam = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.salebill_remaine = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.salebill_paid = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.salebill_tax = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.salebill_disc = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.salebill_total = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnprintbuy = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.salebill_id = New System.Windows.Forms.TextBox()
        Me.salebill_user = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.salebill_date = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblno_items = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbldaen = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblmadin = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvsalebill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvsalebill)
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1176, 535)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        '
        'dgvsalebill
        '
        Me.dgvsalebill.AllowUserToAddRows = False
        Me.dgvsalebill.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.dgvsalebill.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsalebill.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvsalebill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsalebill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvsalebill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsalebill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsalebill.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvsalebill.EnableHeadersVisualStyles = False
        Me.dgvsalebill.Location = New System.Drawing.Point(50, 12)
        Me.dgvsalebill.Name = "dgvsalebill"
        Me.dgvsalebill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvsalebill.Size = New System.Drawing.Size(1063, 517)
        Me.dgvsalebill.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "كود الصنف"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "باركود الصنف"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "اسم الصنف"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "الوحده"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "سعر البيع"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "الكميه"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "الاجمالى"
        Me.Column7.Name = "Column7"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(1119, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(51, 508)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "+"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(260, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 18)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "الادخال بكود الصنف:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.serchbybarcode)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(201, 265)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(415, 88)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        '
        'serchbybarcode
        '
        Me.serchbybarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.serchbybarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.serchbybarcode.ForeColor = System.Drawing.Color.White
        Me.serchbybarcode.Location = New System.Drawing.Point(16, 30)
        Me.serchbybarcode.Name = "serchbybarcode"
        Me.serchbybarcode.Size = New System.Drawing.Size(218, 22)
        Me.serchbybarcode.TabIndex = 7
        Me.serchbybarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(240, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 18)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "الادخال بباركود الصنف:"
        '
        'serchbyid
        '
        Me.serchbyid.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.serchbyid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.serchbyid.ForeColor = System.Drawing.Color.White
        Me.serchbyid.Location = New System.Drawing.Point(36, 31)
        Me.serchbyid.Name = "serchbyid"
        Me.serchbyid.Size = New System.Drawing.Size(218, 22)
        Me.serchbyid.TabIndex = 5
        Me.serchbyid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.serchbyid)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(757, 265)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(421, 88)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'salebill_reqired
        '
        Me.salebill_reqired.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_reqired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_reqired.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salebill_reqired.ForeColor = System.Drawing.Color.White
        Me.salebill_reqired.Location = New System.Drawing.Point(136, 102)
        Me.salebill_reqired.Name = "salebill_reqired"
        Me.salebill_reqired.ReadOnly = True
        Me.salebill_reqired.Size = New System.Drawing.Size(129, 24)
        Me.salebill_reqired.TabIndex = 16
        Me.salebill_reqired.Text = "0"
        Me.salebill_reqired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "العنوان:"
        '
        'cmbnam
        '
        Me.cmbnam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbnam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbnam.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbnam.ForeColor = System.Drawing.Color.White
        Me.cmbnam.FormattingEnabled = True
        Me.cmbnam.Location = New System.Drawing.Point(71, 21)
        Me.cmbnam.Name = "cmbnam"
        Me.cmbnam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbnam.Size = New System.Drawing.Size(175, 22)
        Me.cmbnam.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(252, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "اسم البائع:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.salebill_reqired)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.salebill_remaine)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.salebill_paid)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.salebill_tax)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.salebill_disc)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.salebill_total)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 195)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
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
        'salebill_remaine
        '
        Me.salebill_remaine.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_remaine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_remaine.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salebill_remaine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.salebill_remaine.Location = New System.Drawing.Point(136, 163)
        Me.salebill_remaine.Name = "salebill_remaine"
        Me.salebill_remaine.ReadOnly = True
        Me.salebill_remaine.Size = New System.Drawing.Size(129, 24)
        Me.salebill_remaine.TabIndex = 14
        Me.salebill_remaine.Text = "0"
        Me.salebill_remaine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'salebill_paid
        '
        Me.salebill_paid.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_paid.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salebill_paid.ForeColor = System.Drawing.Color.White
        Me.salebill_paid.Location = New System.Drawing.Point(136, 132)
        Me.salebill_paid.Name = "salebill_paid"
        Me.salebill_paid.Size = New System.Drawing.Size(129, 24)
        Me.salebill_paid.TabIndex = 12
        Me.salebill_paid.Text = "0"
        Me.salebill_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'salebill_disc
        '
        Me.salebill_disc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_disc.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salebill_disc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.salebill_disc.Location = New System.Drawing.Point(136, 44)
        Me.salebill_disc.Name = "salebill_disc"
        Me.salebill_disc.Size = New System.Drawing.Size(129, 24)
        Me.salebill_disc.TabIndex = 7
        Me.salebill_disc.Text = "0"
        Me.salebill_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'salebill_total
        '
        Me.salebill_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_total.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salebill_total.ForeColor = System.Drawing.Color.White
        Me.salebill_total.Location = New System.Drawing.Point(136, 16)
        Me.salebill_total.Name = "salebill_total"
        Me.salebill_total.ReadOnly = True
        Me.salebill_total.Size = New System.Drawing.Size(129, 24)
        Me.salebill_total.TabIndex = 5
        Me.salebill_total.Text = "0"
        Me.salebill_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnprintbuy)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 45)
        Me.Panel1.TabIndex = 9
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
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(563, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "فاتورة المبيعات"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(201, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 34)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
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
        'btnprintbuy
        '
        Me.btnprintbuy.BackColor = System.Drawing.Color.White
        Me.btnprintbuy.BackgroundImage = CType(resources.GetObject("btnprintbuy.BackgroundImage"), System.Drawing.Image)
        Me.btnprintbuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprintbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprintbuy.Location = New System.Drawing.Point(3, 8)
        Me.btnprintbuy.Name = "btnprintbuy"
        Me.btnprintbuy.Size = New System.Drawing.Size(60, 34)
        Me.btnprintbuy.TabIndex = 4
        Me.btnprintbuy.UseVisualStyleBackColor = False
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
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(99, 295)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(91, 19)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "عدد المواد:"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(244, 102)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(47, 14)
        Me.lbladdress.TabIndex = 11
        Me.lbladdress.Text = "_____"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(118, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 14)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "التليفون:"
        '
        'salebill_id
        '
        Me.salebill_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_id.ForeColor = System.Drawing.Color.White
        Me.salebill_id.Location = New System.Drawing.Point(110, 15)
        Me.salebill_id.Name = "salebill_id"
        Me.salebill_id.Size = New System.Drawing.Size(100, 22)
        Me.salebill_id.TabIndex = 10
        Me.salebill_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'salebill_user
        '
        Me.salebill_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_user.ForeColor = System.Drawing.Color.White
        Me.salebill_user.Location = New System.Drawing.Point(110, 75)
        Me.salebill_user.Name = "salebill_user"
        Me.salebill_user.Size = New System.Drawing.Size(175, 22)
        Me.salebill_user.TabIndex = 9
        Me.salebill_user.Text = "0"
        Me.salebill_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(286, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 14)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "اسم المستخدم:"
        '
        'cmbtype
        '
        Me.cmbtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbtype.ForeColor = System.Drawing.Color.White
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"نقدى", "اجل", "دفعات نقديه"})
        Me.cmbtype.Location = New System.Drawing.Point(110, 103)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(175, 22)
        Me.cmbtype.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "نوع الفاتوره:"
        '
        'salebill_date
        '
        Me.salebill_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salebill_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salebill_date.ForeColor = System.Drawing.Color.White
        Me.salebill_date.Location = New System.Drawing.Point(110, 47)
        Me.salebill_date.Name = "salebill_date"
        Me.salebill_date.ReadOnly = True
        Me.salebill_date.Size = New System.Drawing.Size(175, 22)
        Me.salebill_date.TabIndex = 3
        Me.salebill_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "تاريخ الفاتوره:"
        '
        'lblno_items
        '
        Me.lblno_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblno_items.Location = New System.Drawing.Point(13, 291)
        Me.lblno_items.Name = "lblno_items"
        Me.lblno_items.Size = New System.Drawing.Size(80, 31)
        Me.lblno_items.TabIndex = 17
        Me.lblno_items.Text = "0"
        Me.lblno_items.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "رقم الفاتوره:"
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Location = New System.Drawing.Point(31, 102)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(47, 14)
        Me.lbltel.TabIndex = 13
        Me.lbltel.Text = "_____"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcode)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lbldaen)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lblmadin)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lbltel)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lbladdress)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbnam)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(397, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 192)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(132, 55)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(47, 14)
        Me.lblcode.TabIndex = 21
        Me.lblcode.Text = "_____"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(198, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "كود البائع"
        '
        'lbldaen
        '
        Me.lbldaen.AutoSize = True
        Me.lbldaen.Location = New System.Drawing.Point(31, 153)
        Me.lbldaen.Name = "lbldaen"
        Me.lbldaen.Size = New System.Drawing.Size(47, 14)
        Me.lbldaen.TabIndex = 19
        Me.lbldaen.Text = "_____"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(118, 153)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 14)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "دائن(له):"
        '
        'lblmadin
        '
        Me.lblmadin.AutoSize = True
        Me.lblmadin.Location = New System.Drawing.Point(244, 153)
        Me.lblmadin.Name = "lblmadin"
        Me.lblmadin.Size = New System.Drawing.Size(47, 14)
        Me.lblmadin.TabIndex = 17
        Me.lblmadin.Text = "_____"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(310, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 14)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "مدين(عليه):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.salebill_id)
        Me.GroupBox1.Controls.Add(Me.salebill_user)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbtype)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.salebill_date)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(805, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 192)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'salebill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 900)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblno_items)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "salebill"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvsalebill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents serchbybarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents serchbyid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents salebill_reqired As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbnam As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents salebill_remaine As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents salebill_paid As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents salebill_tax As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents salebill_disc As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents salebill_total As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnprintbuy As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents salebill_id As System.Windows.Forms.TextBox
    Friend WithEvents salebill_user As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents salebill_date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblno_items As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcode As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbldaen As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblmadin As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvsalebill As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
