<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class expire_date
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
        Me.dt_expiredate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'dt_expiredate
        '
        Me.dt_expiredate.CustomFormat = "yyyy-MM-dd"
        Me.dt_expiredate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_expiredate.Location = New System.Drawing.Point(12, 12)
        Me.dt_expiredate.Name = "dt_expiredate"
        Me.dt_expiredate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dt_expiredate.Size = New System.Drawing.Size(200, 33)
        Me.dt_expiredate.TabIndex = 0
        '
        'expire_date
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(211, 51)
        Me.Controls.Add(Me.dt_expiredate)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "expire_date"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt_expiredate As System.Windows.Forms.DateTimePicker
End Class
