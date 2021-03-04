<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.btnOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.btnNew = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSave = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.btnFind = New System.Windows.Forms.ToolStripMenuItem
        Me.btnGoto = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSelect = New System.Windows.Forms.ToolStripMenuItem
        Me.btnHighlight = New System.Windows.Forms.ToolStripMenuItem
        Me.btnUnHighlight = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnFont = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem
        Me.btnClose = New System.Windows.Forms.ToolStripMenuItem
        Me.btnToggle = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnThirdAge = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.stLine = New System.Windows.Forms.ToolStripStatusLabel
        Me.stCurrent = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabManager = New System.Windows.Forms.TabControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.lyClipboard = New System.Windows.Forms.TableLayoutPanel
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnClear = New System.Windows.Forms.ToolStripButton
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.FormatToolStripMenuItem, Me.mnuView, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.btnNew, Me.btnSave, Me.btnSaveAs, Me.btnExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'btnOpen
        '
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(136, 22)
        Me.btnOpen.Text = "&Open INI"
        '
        'btnNew
        '
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(136, 22)
        Me.btnNew.Text = "&New INI"
        '
        'btnSave
        '
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 22)
        Me.btnSave.Text = "&Save INI"
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(136, 22)
        Me.btnSaveAs.Text = "Save As..."
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 22)
        Me.btnExit.Text = "&Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFind, Me.btnGoto, Me.btnSelect, Me.btnHighlight, Me.btnUnHighlight})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(37, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'btnFind
        '
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(167, 22)
        Me.btnFind.Text = "Fi&nd Word"
        '
        'btnGoto
        '
        Me.btnGoto.Name = "btnGoto"
        Me.btnGoto.Size = New System.Drawing.Size(167, 22)
        Me.btnGoto.Text = "&Goto Line"
        '
        'btnSelect
        '
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(167, 22)
        Me.btnSelect.Text = "&Select All"
        '
        'btnHighlight
        '
        Me.btnHighlight.Name = "btnHighlight"
        Me.btnHighlight.Size = New System.Drawing.Size(167, 22)
        Me.btnHighlight.Text = "&Highlight Word"
        '
        'btnUnHighlight
        '
        Me.btnUnHighlight.Name = "btnUnHighlight"
        Me.btnUnHighlight.Size = New System.Drawing.Size(167, 22)
        Me.btnUnHighlight.Text = "&Unhighlight Word"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFont})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'btnFont
        '
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(152, 22)
        Me.btnFont.Text = "&Font"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose, Me.btnToggle})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(41, 20)
        Me.mnuView.Text = "&View"
        '
        'btnClose
        '
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(165, 22)
        Me.btnClose.Text = "&Close Tabpage"
        '
        'btnToggle
        '
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(165, 22)
        Me.btnToggle.Text = "&Toggle ClipBoard"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThirdAge})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'btnThirdAge
        '
        Me.btnThirdAge.Name = "btnThirdAge"
        Me.btnThirdAge.Size = New System.Drawing.Size(165, 22)
        Me.btnThirdAge.Text = "The3rdaAge.Net"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stLine, Me.stCurrent})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 349)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(534, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stLine
        '
        Me.stLine.Name = "stLine"
        Me.stLine.Size = New System.Drawing.Size(259, 17)
        Me.stLine.Spring = True
        '
        'stCurrent
        '
        Me.stCurrent.Name = "stCurrent"
        Me.stCurrent.Size = New System.Drawing.Size(259, 17)
        Me.stCurrent.Spring = True
        '
        'TabManager
        '
        Me.TabManager.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabManager.Location = New System.Drawing.Point(1, 26)
        Me.TabManager.Name = "TabManager"
        Me.TabManager.SelectedIndex = 0
        Me.TabManager.Size = New System.Drawing.Size(375, 320)
        Me.TabManager.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = """INI files|*.ini|All files|*.*"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.ReadOnlyChecked = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = """INI files|*.ini|Text files|*.txt|All files|*.*"
        '
        'lyClipboard
        '
        Me.lyClipboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lyClipboard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.lyClipboard.ColumnCount = 1
        Me.lyClipboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.lyClipboard.Location = New System.Drawing.Point(381, 50)
        Me.lyClipboard.Name = "lyClipboard"
        Me.lyClipboard.RowCount = 1
        Me.lyClipboard.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.lyClipboard.Size = New System.Drawing.Size(146, 294)
        Me.lyClipboard.TabIndex = 3
        '
        'pnlOptions
        '
        Me.pnlOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOptions.Controls.Add(Me.ToolStrip2)
        Me.pnlOptions.Location = New System.Drawing.Point(381, 27)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(146, 23)
        Me.pnlOptions.TabIndex = 4
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClear, Me.btnDelete})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(146, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnClear
        '
        Me.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(36, 22)
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 22)
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 371)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.lyClipboard)
        Me.Controls.Add(Me.TabManager)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Ini Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlOptions.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stLine As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stCurrent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabManager As System.Windows.Forms.TabControl
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lyClipboard As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnToggle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGoto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnThirdAge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHighlight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUnHighlight As System.Windows.Forms.ToolStripMenuItem

End Class
