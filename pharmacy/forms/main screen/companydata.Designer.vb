<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class companydata
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.compnam = New System.Windows.Forms.TextBox()
        Me.comptogary = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comptaxes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comptel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(27, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "اختيار الشعار"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "اسم الشركه:"
        '
        'compnam
        '
        Me.compnam.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.compnam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.compnam.ForeColor = System.Drawing.Color.White
        Me.compnam.Location = New System.Drawing.Point(208, 57)
        Me.compnam.Name = "compnam"
        Me.compnam.Size = New System.Drawing.Size(196, 24)
        Me.compnam.TabIndex = 2
        '
        'comptogary
        '
        Me.comptogary.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comptogary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comptogary.ForeColor = System.Drawing.Color.White
        Me.comptogary.Location = New System.Drawing.Point(208, 99)
        Me.comptogary.Name = "comptogary"
        Me.comptogary.Size = New System.Drawing.Size(196, 24)
        Me.comptogary.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "السجل التجارى:"
        '
        'comptaxes
        '
        Me.comptaxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comptaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comptaxes.ForeColor = System.Drawing.Color.White
        Me.comptaxes.Location = New System.Drawing.Point(208, 140)
        Me.comptaxes.Name = "comptaxes"
        Me.comptaxes.Size = New System.Drawing.Size(196, 24)
        Me.comptaxes.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "الرقم الضريبى:"
        '
        'comptel
        '
        Me.comptel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comptel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comptel.ForeColor = System.Drawing.Color.White
        Me.comptel.Location = New System.Drawing.Point(208, 180)
        Me.comptel.Name = "comptel"
        Me.comptel.Size = New System.Drawing.Size(196, 24)
        Me.comptel.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "تليفون:"
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(190, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 211)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الشركه"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "شعار الشركه"
        '
        'btnsave
        '
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Image = Global.pharmacy.My.Resources.Resources.icons8_save_32
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.Location = New System.Drawing.Point(382, 251)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(147, 52)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "حفظ البيانات"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic1.Location = New System.Drawing.Point(12, 60)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(172, 188)
        Me.pic1.TabIndex = 13
        Me.pic1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'companydata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(545, 330)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comptel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comptaxes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comptogary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.compnam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "companydata"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيانات الشركه"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents compnam As System.Windows.Forms.TextBox
    Friend WithEvents comptogary As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comptaxes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comptel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
