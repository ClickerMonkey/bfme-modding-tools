<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValueHolder
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
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.Value = New System.Windows.Forms.Label
        Me.txtMax = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtMin
        '
        Me.txtMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtMin.Location = New System.Drawing.Point(67, 4)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(40, 20)
        Me.txtMin.TabIndex = 0
        '
        'Value
        '
        Me.Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Value.AutoSize = True
        Me.Value.Location = New System.Drawing.Point(2, 6)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(55, 13)
        Me.Value.TabIndex = 1
        Me.Value.Text = "ValueText"
        '
        'txtMax
        '
        Me.txtMax.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtMax.Location = New System.Drawing.Point(113, 4)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(40, 20)
        Me.txtMax.TabIndex = 2
        '
        'ValueHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.txtMin)
        Me.Name = "ValueHolder"
        Me.Size = New System.Drawing.Size(156, 27)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents Value As System.Windows.Forms.Label

End Class
