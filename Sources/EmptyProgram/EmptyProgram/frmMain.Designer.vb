<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.stsMain = New System.Windows.Forms.StatusStrip
        Me.cntMain = New System.Windows.Forms.ToolStripContainer
        Me.strFile = New System.Windows.Forms.ToolStrip
        Me.btnNew = New System.Windows.Forms.ToolStripButton
        Me.btnOpen = New System.Windows.Forms.ToolStripButton
        Me.btnSave = New System.Windows.Forms.ToolStripButton
        Me.btnSaveAs = New System.Windows.Forms.ToolStripButton
        Me.strEdit = New System.Windows.Forms.ToolStrip
        Me.btnUndo = New System.Windows.Forms.ToolStripButton
        Me.btnRedo = New System.Windows.Forms.ToolStripButton
        Me.btnAdd = New System.Windows.Forms.ToolStripButton
        Me.btnRemove = New System.Windows.Forms.ToolStripButton
        Me.btnClear = New System.Windows.Forms.ToolStripButton
        Me.btnCopy = New System.Windows.Forms.ToolStripButton
        Me.btnCut = New System.Windows.Forms.ToolStripButton
        Me.btnPaste = New System.Windows.Forms.ToolStripButton
        Me.btnGoto = New System.Windows.Forms.ToolStripButton
        Me.btnFind = New System.Windows.Forms.ToolStripButton
        Me.btnFindReplace = New System.Windows.Forms.ToolStripButton
        Me.btnSelectAll = New System.Windows.Forms.ToolStripButton
        Me.strFormat = New System.Windows.Forms.ToolStrip
        Me.btnProperties = New System.Windows.Forms.ToolStripButton
        Me.btnInterface = New System.Windows.Forms.ToolStripButton
        Me.strHelp = New System.Windows.Forms.ToolStrip
        Me.btnAbout = New System.Windows.Forms.ToolStripButton
        Me.btnContact = New System.Windows.Forms.ToolStripButton
        Me.btnHelpMe = New System.Windows.Forms.ToolStripButton
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuImport = New System.Windows.Forms.ToolStripMenuItem
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExport = New System.Windows.Forms.ToolStripMenuItem
        Me.sep4 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuRecentFiles = New System.Windows.Forms.ToolStripMenuItem
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem
        Me.sep6 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem
        Me.sep5 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.sep7 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuGoto = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFindReplace = New System.Windows.Forms.ToolStripMenuItem
        Me.sep8 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuStatusBar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToolbars = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuViewOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuViewEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuViewFormat = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuViewHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFormat = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProperties = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuInterface = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuContact = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpMe = New System.Windows.Forms.ToolStripMenuItem
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog
        Me.dlgImport = New System.Windows.Forms.OpenFileDialog
        Me.dlgExport = New System.Windows.Forms.SaveFileDialog
        Me.cntMain.TopToolStripPanel.SuspendLayout()
        Me.cntMain.SuspendLayout()
        Me.strFile.SuspendLayout()
        Me.strEdit.SuspendLayout()
        Me.strFormat.SuspendLayout()
        Me.strHelp.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsMain
        '
        Me.stsMain.Location = New System.Drawing.Point(0, 431)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(473, 22)
        Me.stsMain.TabIndex = 0
        Me.stsMain.Text = "StatusStrip1"
        '
        'cntMain
        '
        '
        'cntMain.ContentPanel
        '
        Me.cntMain.ContentPanel.Size = New System.Drawing.Size(473, 380)
        Me.cntMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cntMain.Location = New System.Drawing.Point(0, 24)
        Me.cntMain.Name = "cntMain"
        Me.cntMain.Size = New System.Drawing.Size(473, 407)
        Me.cntMain.TabIndex = 1
        Me.cntMain.Text = "ToolStripContainer1"
        '
        'cntMain.TopToolStripPanel
        '
        Me.cntMain.TopToolStripPanel.Controls.Add(Me.strFormat)
        Me.cntMain.TopToolStripPanel.Controls.Add(Me.strHelp)
        Me.cntMain.TopToolStripPanel.Controls.Add(Me.strFile)
        Me.cntMain.TopToolStripPanel.Controls.Add(Me.strEdit)
        '
        'strFile
        '
        Me.strFile.Dock = System.Windows.Forms.DockStyle.None
        Me.strFile.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.strFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnOpen, Me.btnSave, Me.btnSaveAs})
        Me.strFile.Location = New System.Drawing.Point(3, 0)
        Me.strFile.Name = "strFile"
        Me.strFile.Size = New System.Drawing.Size(108, 27)
        Me.strFile.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = Global.EmptyProgram.My.Resources.Resources.document_new
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(24, 24)
        Me.btnNew.Text = "ToolStripButton1"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = Global.EmptyProgram.My.Resources.Resources.document_open
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(24, 24)
        Me.btnOpen.Text = "ToolStripButton2"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = Global.EmptyProgram.My.Resources.Resources.document_save
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(24, 24)
        Me.btnSave.Text = "ToolStripButton3"
        '
        'btnSaveAs
        '
        Me.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveAs.Image = Global.EmptyProgram.My.Resources.Resources.document_save_as
        Me.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(24, 24)
        Me.btnSaveAs.Text = "ToolStripButton4"
        '
        'strEdit
        '
        Me.strEdit.Dock = System.Windows.Forms.DockStyle.None
        Me.strEdit.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.strEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUndo, Me.btnRedo, Me.btnAdd, Me.btnRemove, Me.btnClear, Me.btnCopy, Me.btnCut, Me.btnPaste, Me.btnGoto, Me.btnFind, Me.btnFindReplace, Me.btnSelectAll})
        Me.strEdit.Location = New System.Drawing.Point(111, 0)
        Me.strEdit.Name = "strEdit"
        Me.strEdit.Size = New System.Drawing.Size(300, 27)
        Me.strEdit.TabIndex = 1
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = Global.EmptyProgram.My.Resources.Resources.edit_undo
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(24, 24)
        Me.btnUndo.Text = "ToolStripButton15"
        '
        'btnRedo
        '
        Me.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRedo.Image = Global.EmptyProgram.My.Resources.Resources.edit_redo
        Me.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(24, 24)
        Me.btnRedo.Text = "ToolStripButton13"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = Global.EmptyProgram.My.Resources.Resources.list_add
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(24, 24)
        Me.btnAdd.Text = "ToolStripButton1"
        '
        'btnRemove
        '
        Me.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRemove.Image = Global.EmptyProgram.My.Resources.Resources.edit_delete
        Me.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(24, 24)
        Me.btnRemove.Text = "ToolStripButton9"
        '
        'btnClear
        '
        Me.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClear.Image = Global.EmptyProgram.My.Resources.Resources.edit_clear
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 24)
        Me.btnClear.Text = "ToolStripButton6"
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = Global.EmptyProgram.My.Resources.Resources.edit_copy
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(24, 24)
        Me.btnCopy.Text = "ToolStripButton7"
        '
        'btnCut
        '
        Me.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCut.Image = Global.EmptyProgram.My.Resources.Resources.edit_cut
        Me.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(24, 24)
        Me.btnCut.Text = "ToolStripButton8"
        '
        'btnPaste
        '
        Me.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaste.Image = Global.EmptyProgram.My.Resources.Resources.edit_paste
        Me.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(24, 24)
        Me.btnPaste.Text = "ToolStripButton12"
        '
        'btnGoto
        '
        Me.btnGoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGoto.Image = Global.EmptyProgram.My.Resources.Resources.go_jump
        Me.btnGoto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGoto.Name = "btnGoto"
        Me.btnGoto.Size = New System.Drawing.Size(24, 24)
        Me.btnGoto.Text = "ToolStripButton16"
        '
        'btnFind
        '
        Me.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFind.Image = Global.EmptyProgram.My.Resources.Resources.edit_find
        Me.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(24, 24)
        Me.btnFind.Text = "ToolStripButton10"
        '
        'btnFindReplace
        '
        Me.btnFindReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFindReplace.Image = Global.EmptyProgram.My.Resources.Resources.edit_find_replace
        Me.btnFindReplace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFindReplace.Name = "btnFindReplace"
        Me.btnFindReplace.Size = New System.Drawing.Size(24, 24)
        Me.btnFindReplace.Text = "ToolStripButton11"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSelectAll.Image = Global.EmptyProgram.My.Resources.Resources.edit_select_all
        Me.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(24, 24)
        Me.btnSelectAll.Text = "ToolStripButton14"
        '
        'strFormat
        '
        Me.strFormat.Dock = System.Windows.Forms.DockStyle.None
        Me.strFormat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.strFormat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProperties, Me.btnInterface})
        Me.strFormat.Location = New System.Drawing.Point(411, 0)
        Me.strFormat.Name = "strFormat"
        Me.strFormat.Size = New System.Drawing.Size(62, 27)
        Me.strFormat.TabIndex = 2
        Me.strFormat.Visible = False
        '
        'btnProperties
        '
        Me.btnProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProperties.Image = Global.EmptyProgram.My.Resources.Resources.document_properties
        Me.btnProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProperties.Name = "btnProperties"
        Me.btnProperties.Size = New System.Drawing.Size(24, 24)
        Me.btnProperties.Text = "ToolStripButton17"
        '
        'btnInterface
        '
        Me.btnInterface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnInterface.Image = Global.EmptyProgram.My.Resources.Resources.preferences_system
        Me.btnInterface.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInterface.Name = "btnInterface"
        Me.btnInterface.Size = New System.Drawing.Size(24, 24)
        Me.btnInterface.Text = "ToolStripButton18"
        '
        'strHelp
        '
        Me.strHelp.Dock = System.Windows.Forms.DockStyle.None
        Me.strHelp.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.strHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAbout, Me.btnContact, Me.btnHelpMe})
        Me.strHelp.Location = New System.Drawing.Point(175, 0)
        Me.strHelp.Name = "strHelp"
        Me.strHelp.Size = New System.Drawing.Size(115, 27)
        Me.strHelp.TabIndex = 3
        Me.strHelp.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbout.Image = Global.EmptyProgram.My.Resources.Resources.dialog_information
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(24, 24)
        Me.btnAbout.Text = "ToolStripButton19"
        '
        'btnContact
        '
        Me.btnContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnContact.Image = Global.EmptyProgram.My.Resources.Resources.mail_attachment
        Me.btnContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(24, 24)
        Me.btnContact.Text = "ToolStripButton21"
        '
        'btnHelpMe
        '
        Me.btnHelpMe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelpMe.Image = Global.EmptyProgram.My.Resources.Resources.help_browser
        Me.btnHelpMe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelpMe.Name = "btnHelpMe"
        Me.btnHelpMe.Size = New System.Drawing.Size(24, 24)
        Me.btnHelpMe.Text = "ToolStripButton20"
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuFormat, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(473, 24)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.sep1, Me.mnuOpen, Me.mnuImport, Me.sep2, Me.mnuSave, Me.mnuSaveAs, Me.mnuExport, Me.sep4, Me.mnuRecentFiles, Me.sep3, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuNew
        '
        Me.mnuNew.Image = Global.EmptyProgram.My.Resources.Resources.document_new
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(132, 22)
        Me.mnuNew.Text = "New"
        '
        'sep1
        '
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(129, 6)
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = Global.EmptyProgram.My.Resources.Resources.document_open
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(132, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuImport
        '
        Me.mnuImport.Name = "mnuImport"
        Me.mnuImport.Size = New System.Drawing.Size(132, 22)
        Me.mnuImport.Text = "Import"
        '
        'sep2
        '
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(129, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Image = Global.EmptyProgram.My.Resources.Resources.document_save
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(132, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Image = Global.EmptyProgram.My.Resources.Resources.document_save_as
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(132, 22)
        Me.mnuSaveAs.Text = "Save As"
        '
        'mnuExport
        '
        Me.mnuExport.Name = "mnuExport"
        Me.mnuExport.Size = New System.Drawing.Size(132, 22)
        Me.mnuExport.Text = "Export"
        '
        'sep4
        '
        Me.sep4.Name = "sep4"
        Me.sep4.Size = New System.Drawing.Size(129, 6)
        '
        'mnuRecentFiles
        '
        Me.mnuRecentFiles.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem})
        Me.mnuRecentFiles.Image = Global.EmptyProgram.My.Resources.Resources.applications_other
        Me.mnuRecentFiles.Name = "mnuRecentFiles"
        Me.mnuRecentFiles.Size = New System.Drawing.Size(132, 22)
        Me.mnuRecentFiles.Text = "Recent Files"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.NoneToolStripMenuItem.Text = "None"
        '
        'sep3
        '
        Me.sep3.Name = "sep3"
        Me.sep3.Size = New System.Drawing.Size(129, 6)
        '
        'mnuClose
        '
        Me.mnuClose.Image = Global.EmptyProgram.My.Resources.Resources.process_stop
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(132, 22)
        Me.mnuClose.Text = "Close"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.mnuRedo, Me.sep6, Me.mnuAdd, Me.mnuRemove, Me.mnuClear, Me.sep5, Me.mnuCopy, Me.mnuCut, Me.mnuPaste, Me.sep7, Me.mnuGoto, Me.mnuFind, Me.mnuFindReplace, Me.sep8, Me.mnuSelectAll})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(37, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuUndo
        '
        Me.mnuUndo.Image = Global.EmptyProgram.My.Resources.Resources.edit_undo
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.Size = New System.Drawing.Size(156, 26)
        Me.mnuUndo.Text = "Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Image = Global.EmptyProgram.My.Resources.Resources.edit_redo
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.Size = New System.Drawing.Size(156, 26)
        Me.mnuRedo.Text = "Redo"
        '
        'sep6
        '
        Me.sep6.Name = "sep6"
        Me.sep6.Size = New System.Drawing.Size(153, 6)
        '
        'mnuAdd
        '
        Me.mnuAdd.Image = Global.EmptyProgram.My.Resources.Resources.list_add
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(156, 26)
        Me.mnuAdd.Text = "Add"
        '
        'mnuRemove
        '
        Me.mnuRemove.Image = Global.EmptyProgram.My.Resources.Resources.edit_delete
        Me.mnuRemove.Name = "mnuRemove"
        Me.mnuRemove.Size = New System.Drawing.Size(156, 26)
        Me.mnuRemove.Text = "Remove"
        '
        'mnuClear
        '
        Me.mnuClear.Image = Global.EmptyProgram.My.Resources.Resources.edit_clear
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(156, 26)
        Me.mnuClear.Text = "Clear"
        '
        'sep5
        '
        Me.sep5.Name = "sep5"
        Me.sep5.Size = New System.Drawing.Size(153, 6)
        '
        'mnuCopy
        '
        Me.mnuCopy.Image = Global.EmptyProgram.My.Resources.Resources.edit_copy
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(156, 26)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuCut
        '
        Me.mnuCut.Image = Global.EmptyProgram.My.Resources.Resources.edit_cut
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(156, 26)
        Me.mnuCut.Text = "Cut"
        '
        'mnuPaste
        '
        Me.mnuPaste.Image = Global.EmptyProgram.My.Resources.Resources.edit_paste
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(156, 26)
        Me.mnuPaste.Text = "Paste"
        '
        'sep7
        '
        Me.sep7.Name = "sep7"
        Me.sep7.Size = New System.Drawing.Size(153, 6)
        '
        'mnuGoto
        '
        Me.mnuGoto.Image = Global.EmptyProgram.My.Resources.Resources.go_jump
        Me.mnuGoto.Name = "mnuGoto"
        Me.mnuGoto.Size = New System.Drawing.Size(156, 26)
        Me.mnuGoto.Text = "Goto"
        '
        'mnuFind
        '
        Me.mnuFind.Image = Global.EmptyProgram.My.Resources.Resources.edit_find
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(156, 26)
        Me.mnuFind.Text = "Find"
        '
        'mnuFindReplace
        '
        Me.mnuFindReplace.Image = Global.EmptyProgram.My.Resources.Resources.edit_find_replace
        Me.mnuFindReplace.Name = "mnuFindReplace"
        Me.mnuFindReplace.Size = New System.Drawing.Size(156, 26)
        Me.mnuFindReplace.Text = "Find/Replace"
        '
        'sep8
        '
        Me.sep8.Name = "sep8"
        Me.sep8.Size = New System.Drawing.Size(153, 6)
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Image = Global.EmptyProgram.My.Resources.Resources.edit_select_all
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.Size = New System.Drawing.Size(156, 26)
        Me.mnuSelectAll.Text = "SelectAll"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStatusBar, Me.mnuToolbars})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(41, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuStatusBar
        '
        Me.mnuStatusBar.Image = Global.EmptyProgram.My.Resources.Resources.Check
        Me.mnuStatusBar.Name = "mnuStatusBar"
        Me.mnuStatusBar.Size = New System.Drawing.Size(156, 26)
        Me.mnuStatusBar.Text = "&Status Bar"
        '
        'mnuToolbars
        '
        Me.mnuToolbars.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewOptions, Me.mnuViewEdit, Me.mnuViewFormat, Me.mnuViewHelp})
        Me.mnuToolbars.Name = "mnuToolbars"
        Me.mnuToolbars.Size = New System.Drawing.Size(156, 26)
        Me.mnuToolbars.Text = "&Toolbars"
        '
        'mnuViewOptions
        '
        Me.mnuViewOptions.Image = Global.EmptyProgram.My.Resources.Resources.Check
        Me.mnuViewOptions.Name = "mnuViewOptions"
        Me.mnuViewOptions.Size = New System.Drawing.Size(156, 26)
        Me.mnuViewOptions.Text = "Options"
        '
        'mnuViewEdit
        '
        Me.mnuViewEdit.Image = Global.EmptyProgram.My.Resources.Resources.Check
        Me.mnuViewEdit.Name = "mnuViewEdit"
        Me.mnuViewEdit.Size = New System.Drawing.Size(156, 26)
        Me.mnuViewEdit.Text = "Edit"
        '
        'mnuViewFormat
        '
        Me.mnuViewFormat.Name = "mnuViewFormat"
        Me.mnuViewFormat.Size = New System.Drawing.Size(156, 26)
        Me.mnuViewFormat.Text = "Format"
        '
        'mnuViewHelp
        '
        Me.mnuViewHelp.Name = "mnuViewHelp"
        Me.mnuViewHelp.Size = New System.Drawing.Size(156, 26)
        Me.mnuViewHelp.Text = "Help"
        '
        'mnuFormat
        '
        Me.mnuFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProperties, Me.mnuInterface})
        Me.mnuFormat.Name = "mnuFormat"
        Me.mnuFormat.Size = New System.Drawing.Size(53, 20)
        Me.mnuFormat.Text = "&Format"
        '
        'mnuProperties
        '
        Me.mnuProperties.Image = Global.EmptyProgram.My.Resources.Resources.document_properties
        Me.mnuProperties.Name = "mnuProperties"
        Me.mnuProperties.Size = New System.Drawing.Size(156, 26)
        Me.mnuProperties.Text = "&Properties"
        '
        'mnuInterface
        '
        Me.mnuInterface.Image = Global.EmptyProgram.My.Resources.Resources.preferences_system
        Me.mnuInterface.Name = "mnuInterface"
        Me.mnuInterface.Size = New System.Drawing.Size(156, 26)
        Me.mnuInterface.Text = "&Interface"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuContact, Me.mnuHelpMe})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Image = Global.EmptyProgram.My.Resources.Resources.dialog_information
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(156, 26)
        Me.mnuAbout.Text = "&About"
        '
        'mnuContact
        '
        Me.mnuContact.Image = Global.EmptyProgram.My.Resources.Resources.mail_attachment
        Me.mnuContact.Name = "mnuContact"
        Me.mnuContact.Size = New System.Drawing.Size(156, 26)
        Me.mnuContact.Text = "&Contact"
        '
        'mnuHelpMe
        '
        Me.mnuHelpMe.Image = Global.EmptyProgram.My.Resources.Resources.help_browser
        Me.mnuHelpMe.Name = "mnuHelpMe"
        Me.mnuHelpMe.Size = New System.Drawing.Size(156, 26)
        Me.mnuHelpMe.Text = "H&elp"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 453)
        Me.Controls.Add(Me.cntMain)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Empty Program"
        Me.cntMain.TopToolStripPanel.ResumeLayout(False)
        Me.cntMain.TopToolStripPanel.PerformLayout()
        Me.cntMain.ResumeLayout(False)
        Me.cntMain.PerformLayout()
        Me.strFile.ResumeLayout(False)
        Me.strFile.PerformLayout()
        Me.strEdit.ResumeLayout(False)
        Me.strEdit.PerformLayout()
        Me.strFormat.ResumeLayout(False)
        Me.strFormat.PerformLayout()
        Me.strHelp.ResumeLayout(False)
        Me.strHelp.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsMain As System.Windows.Forms.StatusStrip
    Friend WithEvents cntMain As System.Windows.Forms.ToolStripContainer
    Friend WithEvents strFile As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRecentFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStatusBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpMe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuToolbars As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents strEdit As System.Windows.Forms.ToolStrip
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRemove As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFindReplace As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSaveAs As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSelectAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGoto As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sep6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sep7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuGoto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFindReplace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sep8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents strFormat As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInterface As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnProperties As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInterface As System.Windows.Forms.ToolStripButton
    Friend WithEvents strHelp As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnContact As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHelpMe As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgImport As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgExport As System.Windows.Forms.SaveFileDialog

End Class
