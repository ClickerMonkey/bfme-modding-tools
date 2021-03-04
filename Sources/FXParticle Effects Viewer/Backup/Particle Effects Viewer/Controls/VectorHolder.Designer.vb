<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VectorHolder
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
        Me.txtY = New System.Windows.Forms.TextBox
        Me.txtX = New System.Windows.Forms.TextBox
        Me.txtZ = New System.Windows.Forms.TextBox
        Me.lblZ = New System.Windows.Forms.Label
        Me.lblY = New System.Windows.Forms.Label
        Me.lblX = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Value
        '
        Me.Value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Value.AutoSize = True
        Me.Value.Location = New System.Drawing.Point(2, 4)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(55, 13)
        Me.Value.TabIndex = 2
        Me.Value.Text = "ValueText"
        '
        'txtY
        '
        Me.txtY.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtY.Location = New System.Drawing.Point(147, 1)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(40, 20)
        Me.txtY.TabIndex = 4
        '
        'txtX
        '
        Me.txtX.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtX.Location = New System.Drawing.Point(98, 1)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(40, 20)
        Me.txtX.TabIndex = 3
        '
        'txtZ
        '
        Me.txtZ.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtZ.Location = New System.Drawing.Point(196, 1)
        Me.txtZ.Name = "txtZ"
        Me.txtZ.Size = New System.Drawing.Size(40, 20)
        Me.txtZ.TabIndex = 5
        '
        'lblZ
        '
        Me.lblZ.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblZ.AutoSize = True
        Me.lblZ.Location = New System.Drawing.Point(184, 3)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(17, 13)
        Me.lblZ.TabIndex = 6
        Me.lblZ.Text = "Z:"
        '
        'lblY
        '
        Me.lblY.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(135, 4)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 13)
        Me.lblY.TabIndex = 7
        Me.lblY.Text = "Y:"
        '
        'lblX
        '
        Me.lblX.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(86, 4)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 8
        Me.lblX.Text = "X:"
        '
        'VectorHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtZ)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.lblZ)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Name = "VectorHolder"
        Me.Size = New System.Drawing.Size(236, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Value As System.Windows.Forms.Label
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtZ As System.Windows.Forms.TextBox
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label

End Class
