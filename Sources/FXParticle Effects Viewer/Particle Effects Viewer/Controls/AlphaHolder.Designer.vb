<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlphaHolder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Value = New System.Windows.Forms.Label
        Me.btnAlpha1 = New System.Windows.Forms.Button
        Me.btnAlpha2 = New System.Windows.Forms.Button
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Value
        '
        Me.Value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Value.AutoSize = True
        Me.Value.Location = New System.Drawing.Point(3, 7)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(55, 13)
        Me.Value.TabIndex = 3
        Me.Value.Text = "ValueText"
        '
        'btnAlpha1
        '
        Me.btnAlpha1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAlpha1.Location = New System.Drawing.Point(63, 2)
        Me.btnAlpha1.Name = "btnAlpha1"
        Me.btnAlpha1.Size = New System.Drawing.Size(43, 23)
        Me.btnAlpha1.TabIndex = 4
        Me.btnAlpha1.Text = "1.0"
        Me.btnAlpha1.UseVisualStyleBackColor = True
        '
        'btnAlpha2
        '
        Me.btnAlpha2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAlpha2.Location = New System.Drawing.Point(107, 2)
        Me.btnAlpha2.Name = "btnAlpha2"
        Me.btnAlpha2.Size = New System.Drawing.Size(43, 23)
        Me.btnAlpha2.TabIndex = 5
        Me.btnAlpha2.Text = "1.0"
        Me.btnAlpha2.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTime.Location = New System.Drawing.Point(152, 4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(40, 20)
        Me.txtTime.TabIndex = 6
        '
        'AlphaHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnAlpha2)
        Me.Controls.Add(Me.btnAlpha1)
        Me.Controls.Add(Me.Value)
        Me.Name = "AlphaHolder"
        Me.Size = New System.Drawing.Size(195, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Value As System.Windows.Forms.Label
    Friend WithEvents btnAlpha1 As System.Windows.Forms.Button
    Friend WithEvents btnAlpha2 As System.Windows.Forms.Button
    Friend WithEvents txtTime As System.Windows.Forms.TextBox

End Class
