<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorHolder
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
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.btnColor = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Value
        '
        Me.Value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Value.AutoSize = True
        Me.Value.Location = New System.Drawing.Point(3, 7)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(55, 13)
        Me.Value.TabIndex = 2
        Me.Value.Text = "ValueText"
        '
        'txtTime
        '
        Me.txtTime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTime.Location = New System.Drawing.Point(152, 4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(40, 20)
        Me.txtTime.TabIndex = 3
        '
        'btnColor
        '
        Me.btnColor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnColor.BackColor = System.Drawing.Color.White
        Me.btnColor.Location = New System.Drawing.Point(71, 2)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 23)
        Me.btnColor.TabIndex = 4
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'ColorHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Value)
        Me.Name = "ColorHolder"
        Me.Size = New System.Drawing.Size(195, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Value As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents btnColor As System.Windows.Forms.Button

End Class
