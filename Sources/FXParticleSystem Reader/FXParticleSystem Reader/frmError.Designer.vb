<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmError
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
        Me.lblSeverity = New System.Windows.Forms.Label
        Me.lblSourceClass = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtSeverity = New System.Windows.Forms.TextBox
        Me.txtSourceClass = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblSeverity
        '
        Me.lblSeverity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeverity.Location = New System.Drawing.Point(12, 9)
        Me.lblSeverity.Name = "lblSeverity"
        Me.lblSeverity.Size = New System.Drawing.Size(83, 20)
        Me.lblSeverity.TabIndex = 0
        Me.lblSeverity.Text = "Severity"
        Me.lblSeverity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSourceClass
        '
        Me.lblSourceClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSourceClass.Location = New System.Drawing.Point(12, 35)
        Me.lblSourceClass.Name = "lblSourceClass"
        Me.lblSourceClass.Size = New System.Drawing.Size(83, 20)
        Me.lblSourceClass.TabIndex = 1
        Me.lblSourceClass.Text = "Source Class"
        Me.lblSourceClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Location = New System.Drawing.Point(12, 61)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 20)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSeverity
        '
        Me.txtSeverity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSeverity.Location = New System.Drawing.Point(101, 9)
        Me.txtSeverity.Name = "txtSeverity"
        Me.txtSeverity.ReadOnly = True
        Me.txtSeverity.Size = New System.Drawing.Size(305, 20)
        Me.txtSeverity.TabIndex = 3
        '
        'txtSourceClass
        '
        Me.txtSourceClass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSourceClass.Location = New System.Drawing.Point(101, 36)
        Me.txtSourceClass.Name = "txtSourceClass"
        Me.txtSourceClass.ReadOnly = True
        Me.txtSourceClass.Size = New System.Drawing.Size(305, 20)
        Me.txtSourceClass.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(101, 61)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(305, 79)
        Me.txtDescription.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(12, 113)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 27)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 154)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtSourceClass)
        Me.Controls.Add(Me.txtSeverity)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblSourceClass)
        Me.Controls.Add(Me.lblSeverity)
        Me.Name = "frmError"
        Me.Text = "Error in Omega Game Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeverity As System.Windows.Forms.Label
    Friend WithEvents lblSourceClass As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtSeverity As System.Windows.Forms.TextBox
    Friend WithEvents txtSourceClass As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
