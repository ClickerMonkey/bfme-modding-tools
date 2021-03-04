<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlphaDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOK = New System.Windows.Forms.Button
        Me.trkAlpha = New System.Windows.Forms.TrackBar
        Me.picAlpha = New System.Windows.Forms.PictureBox
        CType(Me.trkAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(60, 66)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'trkAlpha
        '
        Me.trkAlpha.AutoSize = False
        Me.trkAlpha.Location = New System.Drawing.Point(12, 47)
        Me.trkAlpha.Maximum = 100
        Me.trkAlpha.Name = "trkAlpha"
        Me.trkAlpha.Size = New System.Drawing.Size(163, 21)
        Me.trkAlpha.TabIndex = 1
        Me.trkAlpha.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trkAlpha.Value = 1
        '
        'picAlpha
        '
        Me.picAlpha.Location = New System.Drawing.Point(16, 12)
        Me.picAlpha.Name = "picAlpha"
        Me.picAlpha.Size = New System.Drawing.Size(158, 35)
        Me.picAlpha.TabIndex = 2
        Me.picAlpha.TabStop = False
        '
        'AlphaDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 96)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.picAlpha)
        Me.Controls.Add(Me.trkAlpha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AlphaDialog"
        Me.Text = "AlphaDialog"
        CType(Me.trkAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents trkAlpha As System.Windows.Forms.TrackBar
    Friend WithEvents picAlpha As System.Windows.Forms.PictureBox
End Class
