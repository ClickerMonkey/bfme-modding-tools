<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChanger
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
        Me.btnLoad = New System.Windows.Forms.Button
        Me.picResult = New System.Windows.Forms.PictureBox
        CType(Me.picResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(12, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Particle"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'picResult
        '
        Me.picResult.BackColor = System.Drawing.Color.Fuchsia
        Me.picResult.Location = New System.Drawing.Point(12, 41)
        Me.picResult.Name = "picResult"
        Me.picResult.Size = New System.Drawing.Size(128, 128)
        Me.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picResult.TabIndex = 1
        Me.picResult.TabStop = False
        '
        'frmChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.picResult)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "frmChanger"
        Me.Text = "Particle Changer"
        CType(Me.picResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents picResult As System.Windows.Forms.PictureBox

End Class
