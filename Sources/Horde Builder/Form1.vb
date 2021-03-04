Imports System.Drawing.Drawing2D

Public Class Form1

    Inherits System.Windows.Forms.Form

#Region " -=-Windows Form Designer generated code-=- "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents sbpCurrentHorde As System.Windows.Forms.StatusBarPanel
    Friend WithEvents spbCurrentRank As System.Windows.Forms.StatusBarPanel
    Friend WithEvents spbTotalHordes As System.Windows.Forms.StatusBarPanel
    Friend WithEvents txtPositions As System.Windows.Forms.TextBox
    Friend WithEvents grpSplit As System.Windows.Forms.GroupBox
    Friend WithEvents grpAlternate As System.Windows.Forms.GroupBox
    Friend WithEvents btnAlternate As System.Windows.Forms.Button
    Friend WithEvents grpCombo As System.Windows.Forms.GroupBox
    Friend WithEvents btnCombo As System.Windows.Forms.Button
    Friend WithEvents grpRanks As System.Windows.Forms.GroupBox
    Friend WithEvents btnRanks As System.Windows.Forms.Button
    Friend WithEvents grpHordeS As System.Windows.Forms.GroupBox
    Friend WithEvents btnHordeS As System.Windows.Forms.Button
    Friend WithEvents grpHordeP As System.Windows.Forms.GroupBox
    Friend WithEvents btnHordeP As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents btnSplit As System.Windows.Forms.Button
    Friend WithEvents Scroll As System.Windows.Forms.VScrollBar
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRemove As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHowTo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCredits As System.Windows.Forms.MenuItem
    Friend WithEvents mnuContactMe As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sbpXY As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sbpCurrentCell As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Status As System.Windows.Forms.StatusBar
    Friend WithEvents btnAddCoord As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chkAddRank As System.Windows.Forms.CheckBox
    Friend WithEvents chkJustFree As System.Windows.Forms.CheckBox
    Friend WithEvents chkRankStop As System.Windows.Forms.CheckBox
    Friend WithEvents chkReleaseRank As System.Windows.Forms.CheckBox
    Friend WithEvents updDistanceApart As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtUnitCount As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitName As System.Windows.Forms.TextBox
    Friend WithEvents cmbRank As System.Windows.Forms.ComboBox
    Friend WithEvents chkAddCombo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCVoice As System.Windows.Forms.TextBox
    Friend WithEvents txtCResult As System.Windows.Forms.TextBox
    Friend WithEvents txtCTarget As System.Windows.Forms.TextBox
    Friend WithEvents cmbCombo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAlternate As System.Windows.Forms.ComboBox
    Friend WithEvents txtAHordeName As System.Windows.Forms.TextBox
    Friend WithEvents chkAddAlternate As System.Windows.Forms.CheckBox
    Friend WithEvents txtSUnitType As System.Windows.Forms.TextBox
    Friend WithEvents txtSResult As System.Windows.Forms.TextBox
    Friend WithEvents cmbSplit As System.Windows.Forms.ComboBox
    Friend WithEvents chkAddSplit As System.Windows.Forms.CheckBox
    Friend WithEvents txtHPercentage As System.Windows.Forms.TextBox
    Friend WithEvents txtHMaxDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtHMinDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtHMinDelay As System.Windows.Forms.TextBox
    Friend WithEvents chkHIncludeBackUp As System.Windows.Forms.CheckBox
    Friend WithEvents chkHMarching As System.Windows.Forms.CheckBox
    Friend WithEvents chkHIsCombo As System.Windows.Forms.CheckBox
    Friend WithEvents txtHUnitType As System.Windows.Forms.TextBox
    Friend WithEvents chkHSlowHorde As System.Windows.Forms.CheckBox
    Friend WithEvents txtHAModifier As System.Windows.Forms.TextBox
    Friend WithEvents txtHMeleeDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtHY As System.Windows.Forms.TextBox
    Friend WithEvents txtHX As System.Windows.Forms.TextBox
    Friend WithEvents txtHFilter As System.Windows.Forms.TextBox
    Friend WithEvents txtHSlots As System.Windows.Forms.TextBox
    Friend WithEvents txtHStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtHName As System.Windows.Forms.TextBox
    Friend WithEvents chkHMainFormation As System.Windows.Forms.CheckBox
    Friend WithEvents chkHShowPips As System.Windows.Forms.CheckBox
    Friend WithEvents chkHPorcupine As System.Windows.Forms.CheckBox
    Friend WithEvents lstHordes As System.Windows.Forms.ListBox
    Friend WithEvents chkHCreate As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grpBanner As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnBanner As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtBUnitType As System.Windows.Forms.TextBox
    Friend WithEvents txtBAllowed As System.Windows.Forms.TextBox
    Friend WithEvents chkBAddToHorde As System.Windows.Forms.CheckBox
    Friend WithEvents txtBPositions As System.Windows.Forms.TextBox
    Friend WithEvents chkBActivate As System.Windows.Forms.CheckBox
    Friend WithEvents lblRankColor As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents chkRActivate As System.Windows.Forms.CheckBox
    Friend WithEvents txtHMaxDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.chkAddRank = New System.Windows.Forms.CheckBox
        Me.chkJustFree = New System.Windows.Forms.CheckBox
        Me.chkRankStop = New System.Windows.Forms.CheckBox
        Me.chkReleaseRank = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.updDistanceApart = New System.Windows.Forms.NumericUpDown
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.grpHordeP = New System.Windows.Forms.GroupBox
        Me.txtHMaxDelay = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.chkHCreate = New System.Windows.Forms.CheckBox
        Me.txtHPercentage = New System.Windows.Forms.TextBox
        Me.txtHMaxDistance = New System.Windows.Forms.TextBox
        Me.txtHMinDistance = New System.Windows.Forms.TextBox
        Me.txtHMinDelay = New System.Windows.Forms.TextBox
        Me.chkHIncludeBackUp = New System.Windows.Forms.CheckBox
        Me.chkHMarching = New System.Windows.Forms.CheckBox
        Me.chkHIsCombo = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtHUnitType = New System.Windows.Forms.TextBox
        Me.chkHSlowHorde = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtHAModifier = New System.Windows.Forms.TextBox
        Me.txtHMeleeDistance = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtHY = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtHX = New System.Windows.Forms.TextBox
        Me.txtHFilter = New System.Windows.Forms.TextBox
        Me.txtHSlots = New System.Windows.Forms.TextBox
        Me.txtHStatus = New System.Windows.Forms.TextBox
        Me.txtHName = New System.Windows.Forms.TextBox
        Me.chkHMainFormation = New System.Windows.Forms.CheckBox
        Me.chkHShowPips = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnHordeP = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.chkHPorcupine = New System.Windows.Forms.CheckBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.grpRanks = New System.Windows.Forms.GroupBox
        Me.lblRankColor = New System.Windows.Forms.Label
        Me.chkRActivate = New System.Windows.Forms.CheckBox
        Me.btnAddCoord = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUnitCount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUnitName = New System.Windows.Forms.TextBox
        Me.cmbRank = New System.Windows.Forms.ComboBox
        Me.btnRanks = New System.Windows.Forms.Button
        Me.grpBanner = New System.Windows.Forms.GroupBox
        Me.chkBActivate = New System.Windows.Forms.CheckBox
        Me.txtBPositions = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtBUnitType = New System.Windows.Forms.TextBox
        Me.txtBAllowed = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.chkBAddToHorde = New System.Windows.Forms.CheckBox
        Me.btnBanner = New System.Windows.Forms.Button
        Me.grpHordeS = New System.Windows.Forms.GroupBox
        Me.lstHordes = New System.Windows.Forms.ListBox
        Me.btnHordeS = New System.Windows.Forms.Button
        Me.grpCombo = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkAddCombo = New System.Windows.Forms.CheckBox
        Me.txtCVoice = New System.Windows.Forms.TextBox
        Me.txtCResult = New System.Windows.Forms.TextBox
        Me.txtCTarget = New System.Windows.Forms.TextBox
        Me.cmbCombo = New System.Windows.Forms.ComboBox
        Me.btnCombo = New System.Windows.Forms.Button
        Me.grpAlternate = New System.Windows.Forms.GroupBox
        Me.cmbAlternate = New System.Windows.Forms.ComboBox
        Me.txtAHordeName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkAddAlternate = New System.Windows.Forms.CheckBox
        Me.btnAlternate = New System.Windows.Forms.Button
        Me.grpSplit = New System.Windows.Forms.GroupBox
        Me.txtSUnitType = New System.Windows.Forms.TextBox
        Me.txtSResult = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbSplit = New System.Windows.Forms.ComboBox
        Me.chkAddSplit = New System.Windows.Forms.CheckBox
        Me.btnSplit = New System.Windows.Forms.Button
        Me.Scroll = New System.Windows.Forms.VScrollBar
        Me.Status = New System.Windows.Forms.StatusBar
        Me.sbpCurrentHorde = New System.Windows.Forms.StatusBarPanel
        Me.spbCurrentRank = New System.Windows.Forms.StatusBarPanel
        Me.spbTotalHordes = New System.Windows.Forms.StatusBarPanel
        Me.sbpXY = New System.Windows.Forms.StatusBarPanel
        Me.sbpCurrentCell = New System.Windows.Forms.StatusBarPanel
        Me.txtPositions = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuOpen = New System.Windows.Forms.MenuItem
        Me.mnuSave = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuRemove = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.mnuHowTo = New System.Windows.Forms.MenuItem
        Me.mnuCredits = New System.Windows.Forms.MenuItem
        Me.mnuContactMe = New System.Windows.Forms.MenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        CType(Me.updDistanceApart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.grpHordeP.SuspendLayout()
        Me.grpRanks.SuspendLayout()
        Me.grpBanner.SuspendLayout()
        Me.grpHordeS.SuspendLayout()
        Me.grpCombo.SuspendLayout()
        Me.grpAlternate.SuspendLayout()
        Me.grpSplit.SuspendLayout()
        CType(Me.sbpCurrentHorde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spbCurrentRank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spbTotalHordes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpXY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpCurrentCell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAddRank
        '
        Me.chkAddRank.Location = New System.Drawing.Point(16, 280)
        Me.chkAddRank.Name = "chkAddRank"
        Me.chkAddRank.Size = New System.Drawing.Size(120, 32)
        Me.chkAddRank.TabIndex = 10
        Me.chkAddRank.Text = "Include this rank in the Horde"
        '
        'chkJustFree
        '
        Me.chkJustFree.Location = New System.Drawing.Point(16, 184)
        Me.chkJustFree.Name = "chkJustFree"
        Me.chkJustFree.Size = New System.Drawing.Size(120, 32)
        Me.chkJustFree.TabIndex = 9
        Me.chkJustFree.Text = "Just Rank free when attacking"
        '
        'chkRankStop
        '
        Me.chkRankStop.Location = New System.Drawing.Point(16, 216)
        Me.chkRankStop.Name = "chkRankStop"
        Me.chkRankStop.Size = New System.Drawing.Size(120, 32)
        Me.chkRankStop.TabIndex = 8
        Me.chkRankStop.Text = "Rank that stops advance"
        '
        'chkReleaseRank
        '
        Me.chkReleaseRank.Location = New System.Drawing.Point(16, 248)
        Me.chkReleaseRank.Name = "chkReleaseRank"
        Me.chkReleaseRank.Size = New System.Drawing.Size(120, 32)
        Me.chkReleaseRank.TabIndex = 7
        Me.chkReleaseRank.Text = "Release Rank when attacking"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Unit Distance Apart"
        '
        'updDistanceApart
        '
        Me.updDistanceApart.Location = New System.Drawing.Point(32, 160)
        Me.updDistanceApart.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.updDistanceApart.Name = "updDistanceApart"
        Me.updDistanceApart.Size = New System.Drawing.Size(88, 20)
        Me.updDistanceApart.TabIndex = 4
        Me.updDistanceApart.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(16, 312)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReset.Size = New System.Drawing.Size(72, 20)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(96, 312)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 20)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Rotate Horde"
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Controls.Add(Me.grpHordeP)
        Me.pnlMain.Controls.Add(Me.grpRanks)
        Me.pnlMain.Controls.Add(Me.grpBanner)
        Me.pnlMain.Controls.Add(Me.grpHordeS)
        Me.pnlMain.Controls.Add(Me.grpCombo)
        Me.pnlMain.Controls.Add(Me.grpAlternate)
        Me.pnlMain.Controls.Add(Me.grpSplit)
        Me.pnlMain.Location = New System.Drawing.Point(8, 8)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(240, 408)
        Me.pnlMain.TabIndex = 9
        '
        'grpHordeP
        '
        Me.grpHordeP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpHordeP.Controls.Add(Me.txtHMaxDelay)
        Me.grpHordeP.Controls.Add(Me.Label27)
        Me.grpHordeP.Controls.Add(Me.chkHCreate)
        Me.grpHordeP.Controls.Add(Me.txtHPercentage)
        Me.grpHordeP.Controls.Add(Me.txtHMaxDistance)
        Me.grpHordeP.Controls.Add(Me.txtHMinDistance)
        Me.grpHordeP.Controls.Add(Me.txtHMinDelay)
        Me.grpHordeP.Controls.Add(Me.chkHIncludeBackUp)
        Me.grpHordeP.Controls.Add(Me.chkHMarching)
        Me.grpHordeP.Controls.Add(Me.chkHIsCombo)
        Me.grpHordeP.Controls.Add(Me.Label19)
        Me.grpHordeP.Controls.Add(Me.txtHUnitType)
        Me.grpHordeP.Controls.Add(Me.chkHSlowHorde)
        Me.grpHordeP.Controls.Add(Me.Label18)
        Me.grpHordeP.Controls.Add(Me.txtHAModifier)
        Me.grpHordeP.Controls.Add(Me.txtHMeleeDistance)
        Me.grpHordeP.Controls.Add(Me.Label17)
        Me.grpHordeP.Controls.Add(Me.Label15)
        Me.grpHordeP.Controls.Add(Me.txtHY)
        Me.grpHordeP.Controls.Add(Me.Label14)
        Me.grpHordeP.Controls.Add(Me.txtHX)
        Me.grpHordeP.Controls.Add(Me.txtHFilter)
        Me.grpHordeP.Controls.Add(Me.txtHSlots)
        Me.grpHordeP.Controls.Add(Me.txtHStatus)
        Me.grpHordeP.Controls.Add(Me.txtHName)
        Me.grpHordeP.Controls.Add(Me.chkHMainFormation)
        Me.grpHordeP.Controls.Add(Me.chkHShowPips)
        Me.grpHordeP.Controls.Add(Me.Label13)
        Me.grpHordeP.Controls.Add(Me.Label12)
        Me.grpHordeP.Controls.Add(Me.Label11)
        Me.grpHordeP.Controls.Add(Me.Label10)
        Me.grpHordeP.Controls.Add(Me.btnHordeP)
        Me.grpHordeP.Controls.Add(Me.Label16)
        Me.grpHordeP.Controls.Add(Me.chkHPorcupine)
        Me.grpHordeP.Controls.Add(Me.Label23)
        Me.grpHordeP.Controls.Add(Me.Label22)
        Me.grpHordeP.Controls.Add(Me.Label21)
        Me.grpHordeP.Controls.Add(Me.Label20)
        Me.grpHordeP.Location = New System.Drawing.Point(8, 40)
        Me.grpHordeP.Name = "grpHordeP"
        Me.grpHordeP.Size = New System.Drawing.Size(224, 20)
        Me.grpHordeP.TabIndex = 1
        Me.grpHordeP.TabStop = False
        Me.grpHordeP.Text = "      Horde Properties"
        '
        'txtHMaxDelay
        '
        Me.txtHMaxDelay.Location = New System.Drawing.Point(136, 464)
        Me.txtHMaxDelay.Name = "txtHMaxDelay"
        Me.txtHMaxDelay.Size = New System.Drawing.Size(80, 20)
        Me.txtHMaxDelay.TabIndex = 37
        Me.txtHMaxDelay.Text = ""
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 464)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(136, 24)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "BackUp Max Delay Time"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkHCreate
        '
        Me.chkHCreate.Location = New System.Drawing.Point(8, 24)
        Me.chkHCreate.Name = "chkHCreate"
        Me.chkHCreate.Size = New System.Drawing.Size(144, 24)
        Me.chkHCreate.TabIndex = 36
        Me.chkHCreate.Text = "Create Horde"
        '
        'txtHPercentage
        '
        Me.txtHPercentage.Location = New System.Drawing.Point(136, 536)
        Me.txtHPercentage.Name = "txtHPercentage"
        Me.txtHPercentage.Size = New System.Drawing.Size(80, 20)
        Me.txtHPercentage.TabIndex = 34
        Me.txtHPercentage.Text = ""
        '
        'txtHMaxDistance
        '
        Me.txtHMaxDistance.Location = New System.Drawing.Point(136, 512)
        Me.txtHMaxDistance.Name = "txtHMaxDistance"
        Me.txtHMaxDistance.Size = New System.Drawing.Size(80, 20)
        Me.txtHMaxDistance.TabIndex = 32
        Me.txtHMaxDistance.Text = ""
        '
        'txtHMinDistance
        '
        Me.txtHMinDistance.Location = New System.Drawing.Point(136, 488)
        Me.txtHMinDistance.Name = "txtHMinDistance"
        Me.txtHMinDistance.Size = New System.Drawing.Size(80, 20)
        Me.txtHMinDistance.TabIndex = 30
        Me.txtHMinDistance.Text = ""
        '
        'txtHMinDelay
        '
        Me.txtHMinDelay.Location = New System.Drawing.Point(136, 440)
        Me.txtHMinDelay.Name = "txtHMinDelay"
        Me.txtHMinDelay.Size = New System.Drawing.Size(80, 20)
        Me.txtHMinDelay.TabIndex = 28
        Me.txtHMinDelay.Text = ""
        '
        'chkHIncludeBackUp
        '
        Me.chkHIncludeBackUp.Location = New System.Drawing.Point(8, 416)
        Me.chkHIncludeBackUp.Name = "chkHIncludeBackUp"
        Me.chkHIncludeBackUp.Size = New System.Drawing.Size(144, 24)
        Me.chkHIncludeBackUp.TabIndex = 27
        Me.chkHIncludeBackUp.Text = "Include Back Up"
        '
        'chkHMarching
        '
        Me.chkHMarching.Location = New System.Drawing.Point(8, 392)
        Me.chkHMarching.Name = "chkHMarching"
        Me.chkHMarching.Size = New System.Drawing.Size(144, 24)
        Me.chkHMarching.TabIndex = 26
        Me.chkHMarching.Text = "Use Marching Anims"
        '
        'chkHIsCombo
        '
        Me.chkHIsCombo.Location = New System.Drawing.Point(8, 368)
        Me.chkHIsCombo.Name = "chkHIsCombo"
        Me.chkHIsCombo.Size = New System.Drawing.Size(144, 24)
        Me.chkHIsCombo.TabIndex = 25
        Me.chkHIsCombo.Text = "Not Combo Formation"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 344)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 23)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Unit Type"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHUnitType
        '
        Me.txtHUnitType.Location = New System.Drawing.Point(96, 344)
        Me.txtHUnitType.Name = "txtHUnitType"
        Me.txtHUnitType.Size = New System.Drawing.Size(112, 20)
        Me.txtHUnitType.TabIndex = 23
        Me.txtHUnitType.Text = ""
        '
        'chkHSlowHorde
        '
        Me.chkHSlowHorde.Location = New System.Drawing.Point(8, 312)
        Me.chkHSlowHorde.Name = "chkHSlowHorde"
        Me.chkHSlowHorde.Size = New System.Drawing.Size(144, 32)
        Me.chkHSlowHorde.TabIndex = 22
        Me.chkHSlowHorde.Text = "Use Slow Horde Movement"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 256)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 32)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Attribute Modifiers"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHAModifier
        '
        Me.txtHAModifier.Location = New System.Drawing.Point(96, 256)
        Me.txtHAModifier.Name = "txtHAModifier"
        Me.txtHAModifier.Size = New System.Drawing.Size(112, 20)
        Me.txtHAModifier.TabIndex = 19
        Me.txtHAModifier.Text = ""
        '
        'txtHMeleeDistance
        '
        Me.txtHMeleeDistance.Location = New System.Drawing.Point(96, 224)
        Me.txtHMeleeDistance.Name = "txtHMeleeDistance"
        Me.txtHMeleeDistance.Size = New System.Drawing.Size(112, 20)
        Me.txtHMeleeDistance.TabIndex = 18
        Me.txtHMeleeDistance.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 224)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 32)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Melee Attack Leech Distance"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(96, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 24)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "X:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHY
        '
        Me.txtHY.Location = New System.Drawing.Point(168, 200)
        Me.txtHY.Name = "txtHY"
        Me.txtHY.Size = New System.Drawing.Size(40, 20)
        Me.txtHY.TabIndex = 14
        Me.txtHY.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 23)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Random Offset"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHX
        '
        Me.txtHX.Location = New System.Drawing.Point(112, 200)
        Me.txtHX.Name = "txtHX"
        Me.txtHX.Size = New System.Drawing.Size(40, 20)
        Me.txtHX.TabIndex = 12
        Me.txtHX.Text = ""
        '
        'txtHFilter
        '
        Me.txtHFilter.Location = New System.Drawing.Point(96, 128)
        Me.txtHFilter.Name = "txtHFilter"
        Me.txtHFilter.Size = New System.Drawing.Size(112, 20)
        Me.txtHFilter.TabIndex = 10
        Me.txtHFilter.Text = ""
        '
        'txtHSlots
        '
        Me.txtHSlots.Location = New System.Drawing.Point(96, 104)
        Me.txtHSlots.Name = "txtHSlots"
        Me.txtHSlots.Size = New System.Drawing.Size(112, 20)
        Me.txtHSlots.TabIndex = 9
        Me.txtHSlots.Text = ""
        '
        'txtHStatus
        '
        Me.txtHStatus.Location = New System.Drawing.Point(96, 72)
        Me.txtHStatus.Name = "txtHStatus"
        Me.txtHStatus.Size = New System.Drawing.Size(112, 20)
        Me.txtHStatus.TabIndex = 8
        Me.txtHStatus.Text = ""
        '
        'txtHName
        '
        Me.txtHName.Location = New System.Drawing.Point(96, 48)
        Me.txtHName.Name = "txtHName"
        Me.txtHName.Size = New System.Drawing.Size(112, 20)
        Me.txtHName.TabIndex = 1
        Me.txtHName.Text = ""
        '
        'chkHMainFormation
        '
        Me.chkHMainFormation.Location = New System.Drawing.Point(8, 176)
        Me.chkHMainFormation.Name = "chkHMainFormation"
        Me.chkHMainFormation.Size = New System.Drawing.Size(144, 24)
        Me.chkHMainFormation.TabIndex = 7
        Me.chkHMainFormation.Text = "Is Main Formation"
        '
        'chkHShowPips
        '
        Me.chkHShowPips.Location = New System.Drawing.Point(8, 152)
        Me.chkHShowPips.Name = "chkHShowPips"
        Me.chkHShowPips.Size = New System.Drawing.Size(144, 24)
        Me.chkHShowPips.TabIndex = 6
        Me.chkHShowPips.Text = "ShowPips"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 23)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Passenger Filter"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Slots"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 32)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Object Status Of Contained"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Object Name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHordeP
        '
        Me.btnHordeP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHordeP.Location = New System.Drawing.Point(10, 0)
        Me.btnHordeP.Name = "btnHordeP"
        Me.btnHordeP.Size = New System.Drawing.Size(15, 15)
        Me.btnHordeP.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(152, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 24)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Y:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkHPorcupine
        '
        Me.chkHPorcupine.Location = New System.Drawing.Point(8, 288)
        Me.chkHPorcupine.Name = "chkHPorcupine"
        Me.chkHPorcupine.Size = New System.Drawing.Size(144, 24)
        Me.chkHPorcupine.TabIndex = 21
        Me.chkHPorcupine.Text = "Use Porcupine Body"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 536)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 24)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "BackUp Percentage"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 512)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 24)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "BackUp Max Distance"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 488)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 24)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "BackUp Min Distance"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 440)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 24)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "BackUp Min Delay Time"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpRanks
        '
        Me.grpRanks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRanks.Controls.Add(Me.lblRankColor)
        Me.grpRanks.Controls.Add(Me.chkRActivate)
        Me.grpRanks.Controls.Add(Me.btnAddCoord)
        Me.grpRanks.Controls.Add(Me.Label3)
        Me.grpRanks.Controls.Add(Me.txtUnitCount)
        Me.grpRanks.Controls.Add(Me.Label2)
        Me.grpRanks.Controls.Add(Me.txtUnitName)
        Me.grpRanks.Controls.Add(Me.cmbRank)
        Me.grpRanks.Controls.Add(Me.btnRanks)
        Me.grpRanks.Controls.Add(Me.chkAddRank)
        Me.grpRanks.Controls.Add(Me.chkJustFree)
        Me.grpRanks.Controls.Add(Me.chkRankStop)
        Me.grpRanks.Controls.Add(Me.chkReleaseRank)
        Me.grpRanks.Controls.Add(Me.Label1)
        Me.grpRanks.Controls.Add(Me.updDistanceApart)
        Me.grpRanks.Controls.Add(Me.btnReset)
        Me.grpRanks.Controls.Add(Me.btnUpdate)
        Me.grpRanks.Location = New System.Drawing.Point(8, 72)
        Me.grpRanks.Name = "grpRanks"
        Me.grpRanks.Size = New System.Drawing.Size(224, 20)
        Me.grpRanks.TabIndex = 2
        Me.grpRanks.TabStop = False
        Me.grpRanks.Text = "      Ranks"
        '
        'lblRankColor
        '
        Me.lblRankColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRankColor.Location = New System.Drawing.Point(152, 56)
        Me.lblRankColor.Name = "lblRankColor"
        Me.lblRankColor.Size = New System.Drawing.Size(40, 24)
        Me.lblRankColor.TabIndex = 19
        '
        'chkRActivate
        '
        Me.chkRActivate.Location = New System.Drawing.Point(8, 24)
        Me.chkRActivate.Name = "chkRActivate"
        Me.chkRActivate.Size = New System.Drawing.Size(200, 32)
        Me.chkRActivate.TabIndex = 18
        Me.chkRActivate.Text = "Activate to Graph"
        '
        'btnAddCoord
        '
        Me.btnAddCoord.Location = New System.Drawing.Point(16, 336)
        Me.btnAddCoord.Name = "btnAddCoord"
        Me.btnAddCoord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddCoord.Size = New System.Drawing.Size(192, 20)
        Me.btnAddCoord.TabIndex = 17
        Me.btnAddCoord.Text = "Add Premade Coordinates"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Unit Count"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitCount
        '
        Me.txtUnitCount.Location = New System.Drawing.Point(104, 112)
        Me.txtUnitCount.Name = "txtUnitCount"
        Me.txtUnitCount.Size = New System.Drawing.Size(88, 20)
        Me.txtUnitCount.TabIndex = 15
        Me.txtUnitCount.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Unit Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(104, 88)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(88, 20)
        Me.txtUnitName.TabIndex = 12
        Me.txtUnitName.Text = ""
        '
        'cmbRank
        '
        Me.cmbRank.Items.AddRange(New Object() {"Rank1", "Rank2", "Rank3", "Rank4", "Rank5", "Rank6", "Rank7"})
        Me.cmbRank.Location = New System.Drawing.Point(16, 56)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.Size = New System.Drawing.Size(128, 21)
        Me.cmbRank.TabIndex = 11
        Me.cmbRank.Text = "Rank1"
        '
        'btnRanks
        '
        Me.btnRanks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRanks.Location = New System.Drawing.Point(10, 0)
        Me.btnRanks.Name = "btnRanks"
        Me.btnRanks.Size = New System.Drawing.Size(15, 15)
        Me.btnRanks.TabIndex = 0
        '
        'grpBanner
        '
        Me.grpBanner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBanner.Controls.Add(Me.chkBActivate)
        Me.grpBanner.Controls.Add(Me.txtBPositions)
        Me.grpBanner.Controls.Add(Me.Label26)
        Me.grpBanner.Controls.Add(Me.txtBUnitType)
        Me.grpBanner.Controls.Add(Me.txtBAllowed)
        Me.grpBanner.Controls.Add(Me.Label24)
        Me.grpBanner.Controls.Add(Me.Label25)
        Me.grpBanner.Controls.Add(Me.chkBAddToHorde)
        Me.grpBanner.Controls.Add(Me.btnBanner)
        Me.grpBanner.Location = New System.Drawing.Point(8, 104)
        Me.grpBanner.Name = "grpBanner"
        Me.grpBanner.Size = New System.Drawing.Size(224, 20)
        Me.grpBanner.TabIndex = 7
        Me.grpBanner.TabStop = False
        Me.grpBanner.Text = "      Banner Carrier"
        '
        'chkBActivate
        '
        Me.chkBActivate.Location = New System.Drawing.Point(8, 24)
        Me.chkBActivate.Name = "chkBActivate"
        Me.chkBActivate.Size = New System.Drawing.Size(200, 32)
        Me.chkBActivate.TabIndex = 9
        Me.chkBActivate.Text = "Activate to Graph"
        '
        'txtBPositions
        '
        Me.txtBPositions.Location = New System.Drawing.Point(96, 128)
        Me.txtBPositions.Name = "txtBPositions"
        Me.txtBPositions.Size = New System.Drawing.Size(120, 20)
        Me.txtBPositions.TabIndex = 7
        Me.txtBPositions.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(8, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 32)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Banner Carrier Positions"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBUnitType
        '
        Me.txtBUnitType.Location = New System.Drawing.Point(96, 96)
        Me.txtBUnitType.Name = "txtBUnitType"
        Me.txtBUnitType.Size = New System.Drawing.Size(120, 20)
        Me.txtBUnitType.TabIndex = 2
        Me.txtBUnitType.Text = ""
        '
        'txtBAllowed
        '
        Me.txtBAllowed.Location = New System.Drawing.Point(96, 64)
        Me.txtBAllowed.Name = "txtBAllowed"
        Me.txtBAllowed.Size = New System.Drawing.Size(120, 20)
        Me.txtBAllowed.TabIndex = 1
        Me.txtBAllowed.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 32)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Banner Carriers Allowed"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 24)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Unit Type"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkBAddToHorde
        '
        Me.chkBAddToHorde.Location = New System.Drawing.Point(24, 160)
        Me.chkBAddToHorde.Name = "chkBAddToHorde"
        Me.chkBAddToHorde.Size = New System.Drawing.Size(128, 24)
        Me.chkBAddToHorde.TabIndex = 3
        Me.chkBAddToHorde.Text = "Add to Horde"
        '
        'btnBanner
        '
        Me.btnBanner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBanner.Location = New System.Drawing.Point(10, 0)
        Me.btnBanner.Name = "btnBanner"
        Me.btnBanner.Size = New System.Drawing.Size(15, 15)
        Me.btnBanner.TabIndex = 0
        '
        'grpHordeS
        '
        Me.grpHordeS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpHordeS.Controls.Add(Me.lstHordes)
        Me.grpHordeS.Controls.Add(Me.btnHordeS)
        Me.grpHordeS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpHordeS.Location = New System.Drawing.Point(8, 8)
        Me.grpHordeS.Name = "grpHordeS"
        Me.grpHordeS.Size = New System.Drawing.Size(224, 20)
        Me.grpHordeS.TabIndex = 0
        Me.grpHordeS.TabStop = False
        Me.grpHordeS.Text = "      Horde Selection"
        '
        'lstHordes
        '
        Me.lstHordes.Location = New System.Drawing.Point(8, 24)
        Me.lstHordes.Name = "lstHordes"
        Me.lstHordes.Size = New System.Drawing.Size(208, 56)
        Me.lstHordes.TabIndex = 1
        '
        'btnHordeS
        '
        Me.btnHordeS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHordeS.Location = New System.Drawing.Point(10, 0)
        Me.btnHordeS.Name = "btnHordeS"
        Me.btnHordeS.Size = New System.Drawing.Size(15, 15)
        Me.btnHordeS.TabIndex = 0
        '
        'grpCombo
        '
        Me.grpCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCombo.Controls.Add(Me.Label6)
        Me.grpCombo.Controls.Add(Me.Label4)
        Me.grpCombo.Controls.Add(Me.Label5)
        Me.grpCombo.Controls.Add(Me.chkAddCombo)
        Me.grpCombo.Controls.Add(Me.txtCVoice)
        Me.grpCombo.Controls.Add(Me.txtCResult)
        Me.grpCombo.Controls.Add(Me.txtCTarget)
        Me.grpCombo.Controls.Add(Me.cmbCombo)
        Me.grpCombo.Controls.Add(Me.btnCombo)
        Me.grpCombo.Location = New System.Drawing.Point(8, 136)
        Me.grpCombo.Name = "grpCombo"
        Me.grpCombo.Size = New System.Drawing.Size(224, 20)
        Me.grpCombo.TabIndex = 3
        Me.grpCombo.TabStop = False
        Me.grpCombo.Text = "      Combo Hordes"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Initiate Voice"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Target"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Result"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAddCombo
        '
        Me.chkAddCombo.Location = New System.Drawing.Point(40, 136)
        Me.chkAddCombo.Name = "chkAddCombo"
        Me.chkAddCombo.Size = New System.Drawing.Size(128, 24)
        Me.chkAddCombo.TabIndex = 5
        Me.chkAddCombo.Text = "Add to horde"
        '
        'txtCVoice
        '
        Me.txtCVoice.Location = New System.Drawing.Point(88, 104)
        Me.txtCVoice.Name = "txtCVoice"
        Me.txtCVoice.Size = New System.Drawing.Size(128, 20)
        Me.txtCVoice.TabIndex = 4
        Me.txtCVoice.Text = ""
        '
        'txtCResult
        '
        Me.txtCResult.Location = New System.Drawing.Point(88, 80)
        Me.txtCResult.Name = "txtCResult"
        Me.txtCResult.Size = New System.Drawing.Size(128, 20)
        Me.txtCResult.TabIndex = 3
        Me.txtCResult.Text = ""
        '
        'txtCTarget
        '
        Me.txtCTarget.Location = New System.Drawing.Point(88, 56)
        Me.txtCTarget.Name = "txtCTarget"
        Me.txtCTarget.Size = New System.Drawing.Size(128, 20)
        Me.txtCTarget.TabIndex = 2
        Me.txtCTarget.Text = ""
        '
        'cmbCombo
        '
        Me.cmbCombo.Items.AddRange(New Object() {"ComboHorde1", "ComboHorde2", "ComboHorde3", "ComboHorde4", "ComboHorde5", "ComboHorde6", "ComboHorde7"})
        Me.cmbCombo.Location = New System.Drawing.Point(16, 24)
        Me.cmbCombo.Name = "cmbCombo"
        Me.cmbCombo.Size = New System.Drawing.Size(192, 21)
        Me.cmbCombo.TabIndex = 1
        '
        'btnCombo
        '
        Me.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCombo.Location = New System.Drawing.Point(10, 0)
        Me.btnCombo.Name = "btnCombo"
        Me.btnCombo.Size = New System.Drawing.Size(15, 15)
        Me.btnCombo.TabIndex = 0
        '
        'grpAlternate
        '
        Me.grpAlternate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAlternate.Controls.Add(Me.cmbAlternate)
        Me.grpAlternate.Controls.Add(Me.txtAHordeName)
        Me.grpAlternate.Controls.Add(Me.Label9)
        Me.grpAlternate.Controls.Add(Me.chkAddAlternate)
        Me.grpAlternate.Controls.Add(Me.btnAlternate)
        Me.grpAlternate.Location = New System.Drawing.Point(8, 168)
        Me.grpAlternate.Name = "grpAlternate"
        Me.grpAlternate.Size = New System.Drawing.Size(224, 20)
        Me.grpAlternate.TabIndex = 4
        Me.grpAlternate.TabStop = False
        Me.grpAlternate.Text = "      Alternate Formations"
        '
        'cmbAlternate
        '
        Me.cmbAlternate.Items.AddRange(New Object() {"AlternateFormation1", "AlternateFormation2", "AlternateFormation3", "AlternateFormation4", "AlternateFormation5", "AlternateFormation6", "AlternateFormation7"})
        Me.cmbAlternate.Location = New System.Drawing.Point(40, 24)
        Me.cmbAlternate.Name = "cmbAlternate"
        Me.cmbAlternate.Size = New System.Drawing.Size(152, 21)
        Me.cmbAlternate.TabIndex = 9
        '
        'txtAHordeName
        '
        Me.txtAHordeName.Location = New System.Drawing.Point(80, 56)
        Me.txtAHordeName.Name = "txtAHordeName"
        Me.txtAHordeName.Size = New System.Drawing.Size(120, 20)
        Me.txtAHordeName.TabIndex = 6
        Me.txtAHordeName.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Horde Name"
        '
        'chkAddAlternate
        '
        Me.chkAddAlternate.Location = New System.Drawing.Point(48, 88)
        Me.chkAddAlternate.Name = "chkAddAlternate"
        Me.chkAddAlternate.Size = New System.Drawing.Size(128, 24)
        Me.chkAddAlternate.TabIndex = 7
        Me.chkAddAlternate.Text = "Add to Horde"
        '
        'btnAlternate
        '
        Me.btnAlternate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlternate.Location = New System.Drawing.Point(10, 0)
        Me.btnAlternate.Name = "btnAlternate"
        Me.btnAlternate.Size = New System.Drawing.Size(15, 15)
        Me.btnAlternate.TabIndex = 0
        '
        'grpSplit
        '
        Me.grpSplit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSplit.Controls.Add(Me.txtSUnitType)
        Me.grpSplit.Controls.Add(Me.txtSResult)
        Me.grpSplit.Controls.Add(Me.Label8)
        Me.grpSplit.Controls.Add(Me.Label7)
        Me.grpSplit.Controls.Add(Me.cmbSplit)
        Me.grpSplit.Controls.Add(Me.chkAddSplit)
        Me.grpSplit.Controls.Add(Me.btnSplit)
        Me.grpSplit.Location = New System.Drawing.Point(8, 200)
        Me.grpSplit.Name = "grpSplit"
        Me.grpSplit.Size = New System.Drawing.Size(224, 20)
        Me.grpSplit.TabIndex = 5
        Me.grpSplit.TabStop = False
        Me.grpSplit.Text = "      Split Hordes"
        '
        'txtSUnitType
        '
        Me.txtSUnitType.Location = New System.Drawing.Point(80, 80)
        Me.txtSUnitType.Name = "txtSUnitType"
        Me.txtSUnitType.Size = New System.Drawing.Size(120, 20)
        Me.txtSUnitType.TabIndex = 2
        Me.txtSUnitType.Text = ""
        '
        'txtSResult
        '
        Me.txtSResult.Location = New System.Drawing.Point(80, 56)
        Me.txtSResult.Name = "txtSResult"
        Me.txtSResult.Size = New System.Drawing.Size(120, 20)
        Me.txtSResult.TabIndex = 1
        Me.txtSResult.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Split Result"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Unit Type"
        '
        'cmbSplit
        '
        Me.cmbSplit.Items.AddRange(New Object() {"SplitHorde1", "SplitHorde2", "SplitHorde3", "SplitHorde4", "SplitHorde5"})
        Me.cmbSplit.Location = New System.Drawing.Point(40, 24)
        Me.cmbSplit.Name = "cmbSplit"
        Me.cmbSplit.Size = New System.Drawing.Size(152, 21)
        Me.cmbSplit.TabIndex = 4
        '
        'chkAddSplit
        '
        Me.chkAddSplit.Location = New System.Drawing.Point(48, 112)
        Me.chkAddSplit.Name = "chkAddSplit"
        Me.chkAddSplit.Size = New System.Drawing.Size(128, 24)
        Me.chkAddSplit.TabIndex = 3
        Me.chkAddSplit.Text = "Add to Horde"
        '
        'btnSplit
        '
        Me.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSplit.Location = New System.Drawing.Point(10, 0)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(15, 15)
        Me.btnSplit.TabIndex = 0
        '
        'Scroll
        '
        Me.Scroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Scroll.Location = New System.Drawing.Point(248, 8)
        Me.Scroll.Name = "Scroll"
        Me.Scroll.Size = New System.Drawing.Size(16, 408)
        Me.Scroll.TabIndex = 10
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(0, 465)
        Me.Status.Name = "Status"
        Me.Status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbpCurrentHorde, Me.spbCurrentRank, Me.spbTotalHordes, Me.sbpXY, Me.sbpCurrentCell})
        Me.Status.ShowPanels = True
        Me.Status.Size = New System.Drawing.Size(688, 24)
        Me.Status.TabIndex = 11
        '
        'sbpCurrentHorde
        '
        Me.sbpCurrentHorde.Text = "CurrentHorde = "
        Me.sbpCurrentHorde.Width = 200
        '
        'spbCurrentRank
        '
        Me.spbCurrentRank.Text = "CurrentRank = "
        Me.spbCurrentRank.Width = 120
        '
        'spbTotalHordes
        '
        Me.spbTotalHordes.Text = "Total Hordes Loaded = "
        Me.spbTotalHordes.Width = 160
        '
        'sbpXY
        '
        Me.sbpXY.Text = "Cursor:X: Y:"
        Me.sbpXY.Width = 110
        '
        'sbpCurrentCell
        '
        Me.sbpCurrentCell.Text = "Cell# = "
        '
        'txtPositions
        '
        Me.txtPositions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPositions.Location = New System.Drawing.Point(8, 422)
        Me.txtPositions.Multiline = True
        Me.txtPositions.Name = "txtPositions"
        Me.txtPositions.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPositions.Size = New System.Drawing.Size(672, 40)
        Me.txtPositions.TabIndex = 12
        Me.txtPositions.Text = ""
        Me.txtPositions.WordWrap = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit, Me.MenuItem9})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.mnuSave, Me.mnuExit})
        Me.mnuFile.Text = "File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "Open"
        '
        'mnuSave
        '
        Me.mnuSave.Index = 1
        Me.mnuSave.Text = "Save"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 2
        Me.mnuExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuRemove, Me.MenuItem8})
        Me.mnuEdit.Text = "Edit"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "Add Horde"
        '
        'mnuRemove
        '
        Me.mnuRemove.Index = 1
        Me.mnuRemove.Text = "Remove Horde"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = ""
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHowTo, Me.mnuCredits, Me.mnuContactMe})
        Me.MenuItem9.Text = "Help"
        '
        'mnuHowTo
        '
        Me.mnuHowTo.Index = 0
        Me.mnuHowTo.Text = "HowTo"
        '
        'mnuCredits
        '
        Me.mnuCredits.Index = 1
        Me.mnuCredits.Text = "Credits"
        '
        'mnuContactMe
        '
        Me.mnuContactMe.Index = 2
        Me.mnuContactMe.Text = "ContactMe"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 489)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.txtPositions)
        Me.Controls.Add(Me.Scroll)
        Me.Controls.Add(Me.pnlMain)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "{IP}Gil-Galad's Horde Builder (BFME)"
        CType(Me.updDistanceApart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.grpHordeP.ResumeLayout(False)
        Me.grpRanks.ResumeLayout(False)
        Me.grpBanner.ResumeLayout(False)
        Me.grpHordeS.ResumeLayout(False)
        Me.grpCombo.ResumeLayout(False)
        Me.grpAlternate.ResumeLayout(False)
        Me.grpSplit.ResumeLayout(False)
        CType(Me.sbpCurrentHorde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spbCurrentRank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spbTotalHordes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpXY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpCurrentCell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " -=-Horde Variables-=- "
    Private _
        CurrentHorde As Integer = 0, _
        CurrentInitialPayload As Integer, _
        CurrentRank As Integer, _
        CurrentAlternateFormation As Integer, _
        CurrentComboHorde As Integer, _
        CurrentSplitHorde As Integer, _
        CurrentBannerCarrier As Integer, _
        AmountOfHordes As Integer = -1, _
        TotalHordes As Integer = -1
    Private _
        Rank(1000, 6) As Ranks, _
        AlternateFormation(1000, 6) As AlternateFormation, _
        ComboHorde(1000, 6) As ComboHorde, _
        InitialPayload(1000, 5) As InitialPayload, _
        SplitHorde(1000, 4) As SplitHorde, _
        BannerCarrier(1000) As BannerCarrier, _
        Horde(1000) As Horde
    Private FormLoaded As Boolean = False
    Private CurrentColor As Color
    Private Colors() As Color = {Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Black, Color.Indigo, Color.Violet}
#End Region

#Region " -=-Open File-=- "
    Sub OpenINI(ByVal FilePath As String)
        If IO.File.Exists(FilePath) Then
            SaveSetting("Horde Builder", "Form1", "LastFile", FilePath)
            ReadINI(FilePath)
            UpdateAll()
        Else
            MsgBox("File: " & FilePath & " does not exist.")
        End If
    End Sub
    Sub ReadINI(ByVal FilePath As String)
        Dim Reader As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim line(2) As String
        CurrentHorde = TotalHordes
        Do While Reader.Peek <> -1
            line(0) = Reader.ReadLine.TrimStart
            If EmptyLine(line(0)) = True Then
                GoTo Skip2
            End If
            Dim moddedline As String = line(0).Replace(vbTab, " ").Replace(" ", "").ToLower.TrimStart.TrimEnd
            If EmptyLine(moddedline) = True Then
                GoTo Skip2
            End If
            If moddedline.StartsWith("behavior=hordecontain") Or moddedline.StartsWith("behavior=horsehordecontain") Then
                CurrentHorde += 1
                TotalHordes += 1
                Horde(CurrentHorde) = New Horde
                With Horde(CurrentHorde)
                    .TypeOfhorde = HordeType.Infantry
                    .ObjectName = "Object Name"
                    .PassengerFillter = "None +Infantry"
                    .ShowPips = False
                    .MainFormation = False
                    .RandomOffset = New Point(0, 0)
                    .UsePorcupineBody = False
                    .UseSlowHordeMovement = False
                    .NotComboFormation = True
                    .UseMarchingAnims = False
                    .CreateHorde = False
                End With
                CurrentRank = -1
                CurrentComboHorde = -1
                CurrentAlternateFormation = -1
                line(2) = line(0)
                Do Until line(2).StartsWith("end")
                    line(1) = Reader.ReadLine.TrimStart
                    line(2) = line(1).ToLower.TrimEnd
                    If EmptyLine(line(1)) = True Then GoTo Skip1
                    If line(2).StartsWith("objectstatusofcontained") Then Horde(CurrentHorde).ObjectStatusOfContained = GetStr(line(1), "=")
                    If line(2).StartsWith("initialpayload") Then
                        CurrentInitialPayload += 1
                        Dim ln As String = GetStr(line(1), "=")
                        Dim unit_ As String = ln.Substring(0, ln.IndexOf(" "))
                        Dim unitnumber_ As String = ln.Substring(ln.IndexOf(" "))
                        InitialPayload(CurrentHorde, CurrentInitialPayload) = New InitialPayload
                        With InitialPayload(CurrentHorde, CurrentInitialPayload)
                            .Unit = unit_
                            .UnitNumber = unitnumber_
                        End With
                    End If
                    If line(2).StartsWith("slots") Then Horde(CurrentHorde).Slots = GetStr(line(1), "=")
                    If line(2).StartsWith("passengerfilter") Then Horde(CurrentHorde).PassengerFillter = GetStr(line(1), "=")
                    If line(2).StartsWith("showpips") Then Horde(CurrentHorde).ShowPips = GetBool(line(1))
                    If line(2).StartsWith("randomoffset") Then
                        Dim X As Integer = GetStr(line(1), "x:", "y:")
                        Dim Y As Integer = GetStr(line(1), "y:")
                        Horde(CurrentHorde).RandomOffset = New Point(X, Y)
                    End If
                    If line(2).StartsWith("thisformationisthemainformation") Then Horde(CurrentHorde).MainFormation = GetBool(line(1))
                    If line(2).StartsWith("attributemodifiers") Then Horde(CurrentHorde).AttributeModifiers = GetStr(line(1), "=")
                    If line(2).StartsWith("bannercarriersallowed") Then
                        CurrentBannerCarrier += 1
                        BannerCarrier(CurrentHorde).BannerCarriersAllowed = GetStr(line(1), "=")
                    End If
                    If line(2).StartsWith("bannercarrierposition") Then
                        Dim position As String = line(1).Substring(line(1).IndexOf(" ", line(1).IndexOf("UnitType:") + 10)).TrimStart.TrimEnd
                        Dim unit As String = line(1).Substring(line(1).IndexOf("UnitType:") + 9, line(1).IndexOf(" ", line(1).IndexOf("UnitType:") + 10) - (line(1).IndexOf("UnitType:")) - 1)
                        BannerCarrier(CurrentHorde).UnitType = unit
                        BannerCarrier(CurrentHorde).BannerCarrierPosition = position
                    End If
                    If line(2).StartsWith("rankinfo") Then
                        CurrentRank += 1
                        Rank(CurrentHorde, CurrentRank) = New Ranks
                        With Rank(CurrentHorde, CurrentRank)
                            .Color = Colors(CurrentRank)
                            .AddToHorde = True
                        End With
                    End If
                    If line(2).StartsWith("ranksthatstopadvance") Then Rank(CurrentHorde, CurrentRank).RanksThatStopAdvance = GetStr(line(1), "=")
                    If line(2).StartsWith("rankstoreleasewhenattacking") Then Rank(CurrentHorde, CurrentRank).ReleaseWhenAttacking = GetStr(line(1), "=")
                    If line(2).StartsWith("rankstojustfreewhenattacking") Then Rank(CurrentHorde, CurrentRank).JustFreeWhenAttacking = GetStr(line(1), "=")
                    If line(2).StartsWith("combohorde") Then
                        Dim target As String = GetStr(line(1), "target:", "result:")
                        Dim result As String = GetStr(line(1), "result:", "initiatevoice:")
                        Dim voice As String = GetStr(line(1), "initiatevoice:")
                        CurrentComboHorde += 1
                        ComboHorde(CurrentHorde, CurrentComboHorde) = New ComboHorde
                        With ComboHorde(CurrentHorde, CurrentComboHorde)
                            .AddToHorde = True
                            .InitiateVoice = voice
                            .Result = result
                            .Target = target
                        End With
                    End If
                    If line(2).StartsWith("splithorde") Then

                    End If
                    If line(2).StartsWith("alternateformation") Then
                        CurrentAlternateFormation += 1
                        AlternateFormation(CurrentHorde, CurrentAlternateFormation) = New AlternateFormation
                        With AlternateFormation(CurrentHorde, CurrentAlternateFormation)
                            .Name = GetStr(line(1), "=")
                            .AddToHorde = True
                        End With
                    End If
                    If line(2).StartsWith("meleeattackleashdistance") Then Horde(CurrentHorde).MeleeAttackLeashDistance = GetStr(line(1), "=")
                    If line(2).StartsWith("backupmindelaytime") Then Horde(CurrentHorde).BackUpMinDelaytime = GetStr(line(1), "=")
                    If line(2).StartsWith("backupmaxdelaytime") Then Horde(CurrentHorde).BackUpMaxDelaytime = GetStr(line(1), "=")
                    If line(2).StartsWith("backupmindistance") Then Horde(CurrentHorde).BackUpMinDistance = GetStr(line(1), "=")
                    If line(2).StartsWith("backupmaxdistance") Then Horde(CurrentHorde).BackUpMaxDistance = GetStr(line(1), "=")
                    If line(2).StartsWith("backuppercentage") Then Horde(CurrentHorde).BackUpPercentage = GetStr(line(1), "=")
                    If line(2).StartsWith("notcomboformation") Then Horde(CurrentHorde).NotComboFormation = GetBool(line(1))
Skip1:
                Loop
            End If
Skip2:
        Loop
    End Sub
    Function GetStr(ByVal line As String, ByVal word1 As String, Optional ByVal word2 As String = "none") As String
        Dim RetStr As String
        Select Case word2
            Case "none"
                RetStr = line.Substring(line.IndexOf(word1) + word1.Length)
            Case Is <> "none"
                Select Case line.IndexOf(word2) - line.IndexOf(word1) - word1.Length
                    Case Is < 0
                        RetStr = line.Substring(line.IndexOf(word1) + word1.Length, line.IndexOf(word2) - line.IndexOf(word1) - word1.Length)
                    Case Is >= 0
                        RetStr = line.Substring(line.IndexOf(word1) + word1.Length, line.IndexOf(word2) - line.IndexOf(word1) - word1.Length)
                End Select
        End Select
        Return RetStr.TrimStart.TrimEnd
    End Function
    Function GetBool(ByVal line As String, Optional ByVal beginword As String = "=") As Boolean
        Dim boolstr As String = line.Substring(line.IndexOf(beginword) + beginword.Length)
        Select Case boolstr.ToLower.TrimStart.TrimEnd
            Case "no"
                Return False
            Case "yes"
                Return True
            Case Else
                Return False
        End Select
    End Function
    Function EmptyLine(ByRef line As String) As Boolean
        Dim chars As String() = {";", "/"}
        For i As Integer = 0 To 1
            If Contain(line, chars(i)) Then
                line = line.Substring(0, line.IndexOf(chars(i)))
            End If
        Next
        line = line.Replace(vbTab, " ")
        If line.TrimStart = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Function Contain(ByVal line As String, ByVal str As String) As Boolean
        For i As Integer = 0 To line.Length - str.Length
            If line.Substring(i, str.Length).ToLower = str.ToLower Then
                Return True
            End If
        Next
        Return False
    End Function
    Sub Position(ByVal rank As String)

    End Sub
    '<update>
    Sub UpdateAll()
        If FormLoaded = True Then
            UpdateStatus()
            UpdateRank()
            UpdateHordeP()
            UpdateSplit()
            UpdateCombo()
            UpdateAlternate()
            UpdateHordeS()
            UpdateBanner()
        End If
    End Sub
    Sub UpdateHordeS()
        If FormLoaded = True Then
            lstHordes.Items.Clear()
            For i As Integer = 0 To TotalHordes
                lstHordes.Items.Add(Horde(i).ObjectName)
            Next
        End If
    End Sub
    '</update>
    Function ReturnObjects(ByVal filename As String) As Integer
        Dim number As Integer
        Dim Reader As IO.StreamReader = IO.File.OpenText(filename)
        Dim line As String
        Do Until Reader.Peek <> -1
            line = Reader.ReadLine.TrimStart.ToLower
            If line.StartsWith("behavior = hordecontain") Or line.StartsWith("behavior = horsehordecontain") Then
                number += 1
            End If
        Loop
        Reader.Close()
        Return number
    End Function
#End Region
#Region " -=-Save File-=- "
    Structure Payload
        Dim Count As Integer
        Dim UnitName As String
        Dim Include As Boolean
    End Structure
    Sub ComputePayload(ByVal sw As IO.StreamWriter, ByVal i As Integer)
        Dim PayloadNeeded(6) As Payload
        For ii As Integer = 0 To 6
            PayloadNeeded(ii) = New Payload
            With PayloadNeeded(ii)
                .Count = Rank(i, ii).UNITCOUNT
                .UnitName = Rank(i, ii).UNITNAME
                .Include = False
            End With
        Next
        For ii As Integer = 0 To 6

        Next
        '.WriteLine(vbtab & vbtab & "InitialPayload = " & initialpayload(i,0).UNIT_ & " " & initialpayload(i,0).UNITNUMBER_
    End Sub
    Sub SaveINIFile(ByVal FilePath As String)
        Dim INIWriter As IO.StreamWriter = IO.File.CreateText(FilePath)
        With INIWriter
            For i As Integer = 0 To TotalHordes
                If Horde(i).CreateHorde = True Then
                    .WriteLine()
                    .WriteLine()
                    If Horde(i).TypeOfhorde = "Normal" Then
                        .WriteLine(vbTab & "Behavior = HordeContain ModuleTag_HordeContain")
                    ElseIf Horde(i).TypeOfhorde = "Horse" Then
                        .WriteLine(vbTab & "Behavior = HorseHordeContain ModuleTag_HordeContain")
                    ElseIf Horde(i).TypeOfhorde <> "Horse" Xor Horde(i).TypeOfhorde <> "Normal" Then
                        .WriteLine(vbTab & "Behavior = HordeContain ModuleTag_HordeContain")
                    End If
                    .WriteLine(vbTab & vbTab & "ObjectStatusOfContained	= " & Horde(i).ObjectStatusOfContained)
                    '<InitialPayload>============================
                    ComputePayload(INIWriter, i)
                    '</InitialPayload>===========================
                    .WriteLine(vbTab & vbTab & "Slots = " & Horde(i).Slots)
                    .WriteLine(vbTab & vbTab & "PassengerFilter = " & Horde(i).PassengerFillter)
                    If Horde(i).ShowPips = True Then
                        .WriteLine(vbTab & vbTab & "ShowPips = Yes")
                    ElseIf Horde(i).ShowPips = False Then
                        .WriteLine(vbTab & vbTab & "ShowPips = No")
                    End If
                    If Horde(i).ShowPips = True Then
                        .WriteLine(vbTab & vbTab & "ThisFormationIsTheMainFormation = Yes")
                    ElseIf Horde(i).ShowPips = False Then
                        .WriteLine(vbTab & vbTab & "ThisFormationIsTheMainFormation = No")
                    End If
                    For ii As Integer = 0 To 6
                        If AlternateFormation(i, ii).ADDTOHORDE = True Then
                            .WriteLine(vbTab & vbTab & "AlternateFormation = " & AlternateFormation(i, ii).NAME)
                        End If
                    Next
                    .WriteLine()
                    If BannerCarrier(i).AddToHorde = True Then
                        .WriteLine(vbTab & vbTab & "BannerCarriersAllowed = " & BannerCarrier(i).BannerCarriersAllowed)
                        .WriteLine(vbTab & vbTab & "BannerCarrierPosition = UnitType:" & BannerCarrier(i).UnitType & vbTab & vbTab & BannerCarrier(i).BannerCarrierPosition)
                    End If
                    .WriteLine()
                    .WriteLine(vbTab & vbTab & "RandomOffset=X:" & Horde(i).RandomOffset.X & " Y:" & Horde(i).RandomOffset.Y)
                    For ii As Integer = 0 To 6
                        If Rank(i, ii).ADDTOHORDE = True Then
                            .WriteLine(vbTab & vbTab & "RankInfo = RankNumber:" & ii & " " & Rank(i, ii).UNITNAME & vbTab & vbTab & Rank(i, ii).RANKINFO)
                        End If
                    Next
                    .WriteLine()
                    Dim Release, JustFree, StopAdvance As String
                    Dim BRelease, BJustFree, BStopAdvance As Boolean
                    For ii As Integer = 0 To 6
                        If Rank(i, ii).ReleaseWhenAttacking = True Then
                            Release &= ii & " "
                            BRelease = True
                        End If
                        If Rank(i, ii).JustFreeWhenAttacking = True Then
                            JustFree &= ii & " "
                            BJustFree = True
                        End If
                        If Rank(i, ii).RanksThatStopAdvance = True Then
                            StopAdvance &= ii & " "
                            BStopAdvance = True
                        End If
                    Next
                    For ii As Integer = 0 To 6
                        If BRelease = True Then
                            .WriteLine(vbTab & vbTab & "RanksToReleaseWhenAttacking = " & Release)
                        End If
                        If BJustFree = True Then
                            .WriteLine(vbTab & vbTab & "RanksToJustFreeWhenAttacking = " & JustFree)
                        End If
                        If BStopAdvance = True Then
                            .WriteLine(vbTab & vbTab & "RanksThatStopAdvance = " & StopAdvance)
                        End If
                    Next
                    .WriteLine()
                    For ii As Integer = 0 To 6
                        If ComboHorde(i, ii).AddToHorde = True Then
                            .WriteLine(vbTab & vbTab & "ComboHorde = Target:" & ComboHorde(i, ii).Target & _
                            " Result:" & ComboHorde(i, ii).Result & _
                            " InitiateVoice:" & ComboHorde(i, ii).InitiateVoice)
                        End If
                    Next
                    .WriteLine()
                    For ii As Integer = 0 To 4
                        If SplitHorde(i, ii).ADDTOHORDE = True Then
                            .WriteLine(vbTab & vbTab & "SplitHorde = SplitResult:" & SplitHorde(i, ii).SPLITRESULT & _
                            " UnitType:" & SplitHorde(i, ii).UNITTYPE)
                        End If
                    Next
                    .WriteLine()
                    If Horde(i).MeleeAttackLeashDistance.TrimStart.TrimEnd <> "" Then
                        .WriteLine(vbTab & vbTab & "MeleeAttackLeashDistance = " & Horde(i).MeleeAttackLeashDistance)
                    End If
                    If Horde(i).AttributeModifiers.TrimStart.TrimEnd <> "" Then
                        .WriteLine(vbTab & vbTab & "AttributeModifiers = " & Horde(i).AttributeModifiers)
                    End If
                    If Horde(i).NotComboFormation = True Then
                        .WriteLine(vbTab & vbTab & "NotComboFormation = Yes")
                    End If
                    If Horde(i).UseMarchingAnims = True Then
                        .WriteLine(vbTab & vbTab & "")
                    End If
                    If Horde(i).UsePorcupineBody = True Then
                        .WriteLine(vbTab & vbTab & "UsePorcupineBody = Yes")
                    End If
                    If Horde(i).UseSlowHordeMovement = True Then
                        .WriteLine(vbTab & vbTab & "UseSlowHordeMovement = Yes")
                    End If
                    If Horde(i).InludeBackUp = True Then
                        .WriteLine()
                        If Horde(i).BackUpMinDelaytime.TrimStart <> "" Then
                            .WriteLine(vbTab & vbTab & "BackUpMinDelayTime		= " & Horde(i).BackUpMinDelaytime)
                        End If
                        If Horde(i).BackUpMaxDelaytime.TrimStart <> "" Then
                            .WriteLine(vbTab & vbTab & "BackUpMaxDelayTime		= " & Horde(i).BackUpMaxDelaytime)
                        End If
                        If Horde(i).BackUpMinDelaytime.TrimStart <> "" Then
                            .WriteLine(vbTab & vbTab & "BackUpMinDistance		= " & Horde(i).BackUpMinDistance)
                        End If
                        If Horde(i).BackUpMinDelaytime.TrimStart <> "" Then
                            .WriteLine(vbTab & vbTab & "BackUpMaxDistance		= " & Horde(i).BackUpMaxDistance)
                        End If
                        If Horde(i).BackUpMinDelaytime.TrimStart <> "" Then
                            .WriteLine(vbTab & vbTab & "BackUpMaxDistance		= " & Horde(i).BackUpPercentage & "%")
                        End If
                    End If
                    .WriteLine(vbTab & "End")
                    .WriteLine()
                End If
            Next
        End With
        INIWriter.Close()
        MsgBox("Files created:" & vbCrLf & FilePath)
    End Sub
#End Region

#Region " -=-Graph Operations-=- "
    Dim chks(24, 24) As CheckBox
    Dim BackIM As Bitmap
    Sub LoadGraph()
        Dim XOff, YOff As Integer
        For Y As Integer = 0 To 24
            For X As Integer = 0 To 24
                chks(Y, X) = New CheckBox
                With chks(Y, X)
                    If X = 12 Then XOff = 1
                    If X >= 13 Then XOff = 2
                    If X < 12 Then XOff = 0
                    If Y = 12 Then YOff = 1
                    If Y >= 13 Then YOff = 2
                    If Y < 12 Then YOff = 0
                    .Location = New System.Drawing.Point(X * 16 + 272 + XOff, Y * 16 + 8 + YOff)
                    .Size = New Size(16, 16)
                    .Name = (X - 12) & "," & -(Y - 12)
                    .FlatStyle = FlatStyle.Popup
                    .Text = ""
                    .Appearance = Appearance.Button
                    .BackColor = Color.White
                    AddHandler chks(Y, X).MouseEnter, AddressOf GraphEnter
                    AddHandler chks(Y, X).MouseLeave, AddressOf GraphLeave
                    AddHandler chks(Y, X).Click, AddressOf GraphClick
                    Me.Controls.Add(chks(Y, X))
                End With
            Next
        Next
        BackIM = New Bitmap(20, 20)
        Dim gr As Graphics = Graphics.FromImage(BackIM)
        Dim br As New Drawing.Drawing2D.LinearGradientBrush(New Rectangle(0, 0, 20, 20), Color.Red, Color.DarkCyan, Drawing2D.LinearGradientMode.ForwardDiagonal)
        gr.FillRectangle(br, 0, 0, 20, 20)
        gr.DrawRectangle(Pens.Red, 1, 1, 14, 14)
    End Sub
    Sub GraphEnter(ByVal sender As Object, ByVal e As EventArgs)
        Dim chk As CheckBox = CType(sender, CheckBox)
        If chk.BackColor.Equals(Color.White) Then
            chk.BackColor = Color.FromArgb(50, 200, 200, 200)
        End If
        Me.Text = chk.Name
    End Sub
    Sub GraphLeave(ByVal sender As Object, ByVal e As EventArgs)
        Dim chk As CheckBox = CType(sender, CheckBox)
        If chk.BackColor.Equals(Color.FromArgb(50, 200, 200, 200)) Then
            chk.BackColor = Color.White
        End If
    End Sub
    Sub GraphClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim chk As CheckBox = CType(sender, CheckBox)
        If chk.Checked = True Then
            chk.Image = BackIM
        Else
            chk.Image = Nothing
        End If
        UpdateGraph()
    End Sub
    Sub UpdateGraph()
        txtPositions.Text = ""
        For Y As Integer = 0 To 24
            For X As Integer = 0 To 24
                If chks(Y, X).Checked = True Then
                    Dim name As String = chks(Y, X).Name
                    Dim sep As Double = Rank(CurrentHorde, CurrentRank).Separation
                    txtPositions.Text &= "Position:X:" & (name.Substring(0, name.IndexOf(",")) * sep) & "Y:" & (name.Substring(name.IndexOf(",") + 1) * sep) & "   "
                End If
            Next
        Next
    End Sub
    Sub LoadGraph(ByVal pos As String)
        pos = pos.Replace(vbTab, "").Replace(" ", "").ToLower.Replace("position:", "").Replace("x", "").Replace("y", "")
        Dim sep As String = txtPositions.Text, pts() As Point, CurrPt As Integer = -1
        Do Until pos.Length < 1
            If pos.StartsWith(":") Then
                CurrPt += 1
                pos = pos.Substring(1)
                Dim X As Integer = pos.Substring(0, pos.IndexOf(":"))
                pos = pos.Substring(pos.IndexOf(":") + 1)
                Dim Y As Integer
                If pos.IndexOf(":") <> -1 Then
                    Y = pos.Substring(0, pos.IndexOf(":"))
                    pos = pos.Substring(pos.IndexOf(":"))
                Else
                    Y = pos
                End If
                ReDim Preserve pts(CurrPt)
                pts(CurrPt) = New Point(X / sep, Y / sep)
            End If
        Loop
        For X As Integer = 0 To 24
            For Y As Integer = 0 To 24
                For C As Integer = 0 To CurrPt
                    If chks(X, Y).Name.ToLower = pts(C).X & "," & pts(C).Y Then
                        chks(X, Y).Checked = True
                        chks(X, Y).Image = BackIM
                        GoTo SkipIt
                    End If
                Next
SkipIt:
            Next
        Next
    End Sub
    Sub ClearGraph()
        For X As Integer = 0 To 24
            For Y As Integer = 0 To 24
                chks(X, Y).Image = Nothing
                chks(X, Y).Checked = False
            Next
        Next
        txtPositions.Text = ""
    End Sub
    Sub RotateGraph()
        'Order = Get Checked Names, Save as Strings, ChangeStrings, Look Through CheckBoxes to do it.
        Dim strs() As String
        Dim TotalChks As Integer = -1
        For X As Integer = 0 To 24
            For Y As Integer = 0 To 24
                If chks(X, Y).Checked = True Then
                    TotalChks += 1
                    ReDim Preserve strs(TotalChks)
                    strs(TotalChks) = chks(X, Y).Name
                    chks(X, Y).Checked = False
                    chks(X, Y).Image = Nothing
                End If
            Next
        Next
        For C As Integer = 0 To TotalChks
            strs(C) = CInt(strs(C).Substring(strs(C).IndexOf(",") + 1)) & "," & -CInt(strs(C).Substring(0, strs(C).IndexOf(",")))
        Next
        For X As Integer = 0 To 24
            For Y As Integer = 0 To 24
                For C As Integer = 0 To TotalChks
                    If chks(X, Y).Name.ToLower = strs(c).ToLower Then
                        chks(X, Y).Checked = True
                        chks(X, Y).Image = BackIM
                        GoTo SkipC
                    End If
                Next
SkipC:
            Next
        Next
        UpdateGraph()
    End Sub
    Function LineContains(ByVal line As String, ByVal str As String) As Boolean
        For i As Integer = 0 To line.Length - str.Length
            If line.Substring(i, str.Length) = str Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function
#End Region

#Region " -=-Menu Options-=- "
    Private Sub mnuAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        TotalHordes += 1
        Horde(TotalHordes) = New Horde
        With Horde(TotalHordes)
            .TypeOfhorde = HordeType.Infantry
            .ObjectName = "Object Name"
            .PassengerFillter = "None +Infantry"
            .ShowPips = False
            .MainFormation = True
            .RandomOffset = New Point(0, 0)
            .UsePorcupineBody = False
            .UseSlowHordeMovement = False
            .NotComboFormation = True
            .UseMarchingAnims = False
            .InludeBackUp = False
            .CreateHorde = True
        End With
        Rank(TotalHordes, 0) = New Ranks
        With Rank(TotalHordes, 0)
            .RankName = "Rank1"
            .UnitName = "Archer"
            .UnitCount = "4"
            .RankInfo = "Position:X:0Y:0 Position:X:5Y:0 Position:X:5Y:5 Position:X:0Y:5"
            .AddToHorde = True
            .JustFreeWhenAttacking = "1"
            .RanksThatStopAdvance = "1"
            .ReleaseWhenAttacking = "1"
            .Color = Color.Red
        End With
        UpdateAll()
    End Sub
    Private Sub mnuContactMe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuContactMe.Click

    End Sub
    Private Sub mnuCredits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCredits.Click

    End Sub
    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click

    End Sub
    Private Sub mnuHowTo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHowTo.Click

    End Sub
    Private Sub mnuOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        With OpenFileDialog1
            .InitialDirectory = GetSetting("Horde Builder", "Form1", "LastFile")
            .FilterIndex = 1
            .Filter = "All Files (*.*)|*.*"
            .RestoreDirectory = True
            If .ShowDialog = DialogResult.OK Then
                Select Case .FileName.Substring(.FileName.LastIndexOf(".") + 1).ToLower
                    Case "ini"
                        Application.DoEvents()
                        OpenINI(.FileName)
                End Select
            End If
        End With
    End Sub
    Private Sub mnuRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRemove.Click

    End Sub
    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        With SaveFileDialog1
            .FilterIndex = 1
            .Filter = "Ini Files (*.ini)|*ini|All Files (*.*)|*.*"
            .InitialDirectory = Application.StartupPath
            .RestoreDirectory = True
            If .ShowDialog = DialogResult.OK Then
                SaveINIFile(.FileName)
            End If
        End With
    End Sub
#End Region
#Region " -=-Other Operations-=- "

#End Region
#Region " -=-Form Functions-=- "
    Sub SetStartingHorde()
        TotalHordes += 1
        Horde(TotalHordes) = New Horde
        With Horde(TotalHordes)
            .TypeOfhorde = HordeType.Infantry
            .ObjectName = "Object Name"
            .PassengerFillter = "None +Infantry"
            .ShowPips = False
            .MainFormation = True
            .RandomOffset = New Point(0, 0)
            .UsePorcupineBody = False
            .UseSlowHordeMovement = False
            .NotComboFormation = True
            .UseMarchingAnims = False
            .InludeBackUp = False
            .CreateHorde = True
        End With
        Rank(TotalHordes, 0) = New Ranks
        With Rank(TotalHordes, 0)
            .RankName = "Rank1"
            .UnitName = "Archer"
            .UnitCount = "4"
            .RankInfo = "Position:X:0Y:0 Position:X:5Y:0 Position:X:5Y:5 Position:X:0Y:5"
            .AddToHorde = True
            .JustFreeWhenAttacking = "1"
            .RanksThatStopAdvance = "1"
            .ReleaseWhenAttacking = "1"
            .Color = Color.Red
            .Separation = 8
        End With
        UpdateAll()
    End Sub
    Sub SetAllHordes()
        For i As Integer = 0 To 1000
            Horde(i) = New Horde
            With Horde(i)
                .TypeOfhorde = HordeType.Infantry
                .ShowPips = False
                .MainFormation = True
                .RandomOffset = New Point(0, 0)
                .UsePorcupineBody = False
                .UseSlowHordeMovement = False
                .NotComboFormation = True
                .UseMarchingAnims = False
                .InludeBackUp = False
                .CreateHorde = False
            End With
            BannerCarrier(i) = New BannerCarrier
            With BannerCarrier(i)
                .AddToHorde = True
            End With
            For ii As Integer = 0 To 6
                Rank(i, ii) = New Ranks
                With Rank(i, ii)
                    .Color = Colors(ii)
                    .AddToHorde = False
                    .UnitCount = "0"
                    .Separation = 8
                End With
                AlternateFormation(i, ii) = New AlternateFormation
                With AlternateFormation(i, ii)
                    .AddToHorde = False
                End With
                ComboHorde(i, ii) = New ComboHorde
                With ComboHorde(i, ii)
                    .AddToHorde = False
                End With
            Next
            For ii As Integer = 0 To 5
                InitialPayload(i, ii) = New InitialPayload
            Next
            For ii As Integer = 0 To 4
                SplitHorde(i, ii) = New SplitHorde
                With SplitHorde(i, ii)
                    .AddToHorde = False
                End With
            Next
        Next
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGraph()
        SetAllHordes()
        SetStartingHorde()
        FormLoaded = True
    End Sub
#End Region

#Region " -=-Group Effects-=- "
    Sub SetGroups(ByVal value As Single)
        Dim TotalHeighths As Integer = grpBanner.Height + grpHordeS.Height + grpHordeP.Height + grpRanks.Height + grpCombo.Height + grpAlternate.Height + grpSplit.Height + 98
        If TotalHeighths > Scroll.Height Then
            Scroll.Maximum = TotalHeighths - Scroll.Height
        Else
            Scroll.Maximum = TotalHeighths
        End If
        grpHordeS.Location = New System.Drawing.Point(8, -value + 8)
        grpHordeP.Location = New System.Drawing.Point(8, -value + grpHordeS.Height + 20)
        grpRanks.Location = New System.Drawing.Point(8, -value + grpHordeP.Height + grpHordeS.Height + 32)
        grpBanner.Location = New System.Drawing.Point(8, -value + grpRanks.Height + grpHordeP.Height + grpHordeS.Height + 44)
        grpCombo.Location = New System.Drawing.Point(8, -value + grpBanner.Height + grpRanks.Height + grpHordeP.Height + grpHordeS.Height + 56)
        grpAlternate.Location = New System.Drawing.Point(8, -value + grpBanner.Height + grpCombo.Height + grpRanks.Height + grpHordeP.Height + grpHordeS.Height + 68)
        grpSplit.Location = New System.Drawing.Point(8, -value + grpBanner.Height + grpAlternate.Height + grpCombo.Height + grpRanks.Height + grpHordeP.Height + grpHordeS.Height + 80)
    End Sub
    Private Sub Scroll_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Scroll.Scroll
        SetGroups(e.NewValue)
    End Sub
    Private Sub btnRanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRanks.Click
        btnRanks.BackgroundImage = Draw.TwoSided(btnRanks.Width, btnRanks.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        '368 - 20
        If grpRanks.Height = 20 Then
            grpRanks.Height = 368
            btnRanks.BackgroundImage = Strings.Shadowed(btnRanks.BackgroundImage, "-", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
        If grpRanks.Height = 368 Then
            grpRanks.Height = 20
            btnRanks.BackgroundImage = Strings.Shadowed(btnRanks.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
    End Sub
    Private Sub btnHordeP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHordeP.Click
        btnHordeP.BackgroundImage = Draw.TwoSided(btnHordeP.Width, btnHordeP.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        '568 - 20
        If grpHordeP.Height = 20 Then
            grpHordeP.Height = 568
            btnHordeP.BackgroundImage = Strings.Shadowed(btnHordeP.BackgroundImage, "-", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
        If grpHordeP.Height = 568 Then
            grpHordeP.Height = 20
            btnHordeP.BackgroundImage = Strings.Shadowed(btnHordeP.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
    End Sub
    Private Sub btnHordeS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHordeS.Click
        btnHordeS.BackgroundImage = Draw.TwoSided(btnHordeS.Width, btnHordeS.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        '88 - 20
        If grpHordeS.Height = 20 Then
            grpHordeS.Height = 88
            btnHordeS.BackgroundImage = Strings.Shadowed(btnHordeS.BackgroundImage, "-", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
        If grpHordeS.Height = 88 Then
            grpHordeS.Height = 20
            btnHordeS.BackgroundImage = Strings.Shadowed(btnHordeS.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
    End Sub
    Private Sub btnCombo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCombo.Click
        btnCombo.BackgroundImage = Draw.TwoSided(btnCombo.Width, btnCombo.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        '168 - 20
        If grpCombo.Height = 20 Then
            grpCombo.Height = 168
            btnCombo.BackgroundImage = Strings.Shadowed(btnCombo.BackgroundImage, "-", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
        If grpCombo.Height = 168 Then
            grpCombo.Height = 20
            btnCombo.BackgroundImage = Strings.Shadowed(btnCombo.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
    End Sub
    Private Sub btnAlternate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlternate.Click
        btnAlternate.BackgroundImage = Draw.TwoSided(btnAlternate.Width, btnAlternate.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        '120 - 20
        If grpAlternate.Height = 20 Then
            grpAlternate.Height = 120
            btnAlternate.BackgroundImage = Strings.Shadowed(btnAlternate.BackgroundImage, "-", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
        If grpAlternate.Height = 120 Then
            grpAlternate.Height = 20
            btnAlternate.BackgroundImage = Strings.Shadowed(btnAlternate.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
    End Sub
    Private Sub btnSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplit.Click
        btnSplit.BackgroundImage = Draw.TwoSided(btnSplit.Width, btnSplit.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        '144 - 20
        If grpSplit.Height = 20 Then
            grpSplit.Height = 144
            btnSplit.BackgroundImage = Strings.Shadowed(btnSplit.BackgroundImage, "-", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
        If grpSplit.Height = 144 Then
            grpSplit.Height = 20
            btnSplit.BackgroundImage = Strings.Shadowed(btnSplit.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
    End Sub
    Private Sub btnBanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBanner.Click
        btnBanner.BackgroundImage = Draw.TwoSided(btnBanner.Width, btnBanner.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        '192 - 20
        If grpBanner.Height = 20 Then
            grpBanner.Height = 192
            btnBanner.BackgroundImage = Strings.Shadowed(btnBanner.BackgroundImage, "-", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
        If grpBanner.Height = 192 Then
            grpBanner.Height = 20
            btnBanner.BackgroundImage = Strings.Shadowed(btnBanner.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
            SetGroups(Scroll.Value)
            Exit Sub
        End If
    End Sub
#End Region

#Region " -=-Functions/Subs-=- "
    Sub UpdateStatus()
        Status.Panels(0).Text = "CurrentHorde = " & Horde(CurrentHorde).ObjectName
        Status.Panels(1).Text = "CurrentRank = " & "Rank" & CurrentRank + 1
        Status.Panels(2).Text = "Total Hordes Loaded = " & TotalHordes
    End Sub
    Sub LoadImages(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnHordeS.BackgroundImage = Draw.TwoSided(btnHordeS.Width, btnHordeS.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        btnHordeS.BackgroundImage = Strings.Shadowed(btnHordeS.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
        btnHordeP.BackgroundImage = Draw.TwoSided(btnHordeP.Width, btnHordeP.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        btnHordeP.BackgroundImage = Strings.Shadowed(btnHordeP.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
        btnRanks.BackgroundImage = Draw.TwoSided(btnRanks.Width, btnRanks.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        btnRanks.BackgroundImage = Strings.Shadowed(btnRanks.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
        btnCombo.BackgroundImage = Draw.TwoSided(btnCombo.Width, btnCombo.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        btnCombo.BackgroundImage = Strings.Shadowed(btnCombo.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
        btnAlternate.BackgroundImage = Draw.TwoSided(btnAlternate.Width, btnAlternate.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        btnAlternate.BackgroundImage = Strings.Shadowed(btnAlternate.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
        btnSplit.BackgroundImage = Draw.TwoSided(btnSplit.Width, btnSplit.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        btnSplit.BackgroundImage = Strings.Shadowed(btnSplit.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)
        btnBanner.BackgroundImage = Draw.TwoSided(btnBanner.Width, btnBanner.Height, Color.WhiteSmoke, Color.Gainsboro, 8)
        btnBanner.BackgroundImage = Strings.Shadowed(btnBanner.BackgroundImage, "+", New FontFamily("Courier New"), 12, 0, -1, 1, Color.Black, Color.DimGray, FontStyle.Bold)

        'pnlMain.BackgroundImage = Draw.OneSided(pnlMain.Width, pnlMain.Height, Color.Gainsboro, Color.Gray, LinearGradientMode.Vertical)
        'grpHordeS.BackColor = Color.WhiteSmoke
        'grpHordeP.BackColor = Color.WhiteSmoke
        'grpRanks.BackColor = Color.WhiteSmoke
        'grpCombo.BackColor = Color.WhiteSmoke
        'grpAlternate.BackColor = Color.WhiteSmoke
        'grpSplit.BackColor = Color.WhiteSmoke
        'pnlMain.BackColor = Color.WhiteSmoke
        'Me.BackgroundImage = Draw.OneSided(Me.Width, Me.Height, Color.WhiteSmoke, Color.Gainsboro, LinearGradientMode.Vertical)
    End Sub
    Function GetsFactor(ByVal str As String, ByVal num As Integer) As Integer
        Dim pts(num - 1) As Point
        Dim CurrPoint As Integer = -1
        'Gets all points within the string
        For i As Integer = 0 To str.Length - "position:".Length
            If str.Substring(i).StartsWith("pos") Then
                Dim X As Integer = str.Substring(str.IndexOf("x:", i) + 2, str.IndexOf("y:", i) - str.IndexOf("x:", i) - 2)
                Dim Y As Integer = str.Substring(str.IndexOf("y:", i) + 2, 4)
                CurrPoint += 1
                pts(CurrPoint) = New Point(X, Y)
            End If
        Next
        'Starts From 0 to 30. As it gets higher it checks if the points coordinates divided by
        'the number from 0 to 30 are equal. If so it sets the greatest common denominator to the 
        'value that ranges from 0 to 30
        Dim HighestNumber(num - 1) As Integer 'Highest number for each point
        For i As Integer = 0 To 20
            For ii As Integer = 0 To num - 1
                Dim Xinit As Double = pts(ii).X / i
                Dim Yinit As Double = pts(ii).Y / i
                If Xinit = Math.Round(Xinit) And Yinit = Math.Round(Yinit) Then
                    HighestNumber(ii) = i 'sets the highestnumber for the current point to 
                    'the highest possible number
                End If
            Next
        Next
        'For this it will check for each positions HighestNumber which occured the most.
        'Very full-proof
        Dim winner As Integer 'Highest Occuring Number Overall
        Dim lengthStrings(20) As String 'this is used so each time the number matches the one
        'from 0 to 30 it adds a character to that string. Then the strings are compared to 
        'see which string is the longest. Then it takes the digits in that string and sets 
        'it as the Final Answer
        For ii As Integer = 0 To num - 1
            For i As Integer = 0 To 20
                If HighestNumber(ii) = i Then
                    If HighestNumber(ii) >= 10 Then
                        lengthStrings(i) &= i & " "
                    ElseIf HighestNumber(ii) < 10 Then
                        lengthStrings(i) &= i & "  "
                    End If
                End If
            Next
        Next
        'Goes through all 30 lengthstrings and checks which one has the highest length,
        'or in other words which one has the most recurring numbers in it.
        For i As Integer = 0 To 20
            lengthStrings(i) &= " "
        Next
        Dim LongestString As String = "5"
        For i As Integer = 0 To 20
            Try
                If lengthStrings(i).Length > LongestString.Length Then
                    LongestString = lengthStrings(i)
                End If
            Catch ex As Exception
                MsgBox(i)
            End Try
        Next
        Dim FinalAnswer As Integer = LongestString.Substring(0, 3)
        Return FinalAnswer
    End Function
#End Region

#Region " -=-Rank-=- "
    Private Sub btnAddCoord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddCoord.Click
        Dim Positions As String = "Position:X:-8Y:96   Position:X:0Y:96   Position:X:8Y:96   Position:X:-16Y:88   Position:X:8Y:88   Position:X:-16Y:80   Position:X:16Y:80   Position:X:-16Y:72   Position:X:16Y:72   Position:X:-16Y:64   Position:X:16Y:64   Position:X:-16Y:56   Position:X:16Y:56   Position:X:-16Y:48   Position:X:16Y:48   Position:X:-16Y:40   Position:X:16Y:40   Position:X:-32Y:32   Position:X:-24Y:32   Position:X:-16Y:32   Position:X:16Y:32   Position:X:24Y:32   Position:X:32Y:32   Position:X:48Y:32   Position:X:56Y:32   Position:X:-56Y:24   Position:X:-48Y:24   Position:X:-40Y:24   Position:X:-16Y:24   Position:X:16Y:24   Position:X:40Y:24   Position:X:64Y:24   Position:X:-64Y:16   Position:X:-40Y:16   Position:X:-16Y:16   Position:X:16Y:16   Position:X:40Y:16   Position:X:64Y:16   Position:X:-64Y:8   Position:X:-40Y:8   Position:X:-16Y:8   Position:X:16Y:8   Position:X:40Y:8   Position:X:64Y:8   Position:X:-64Y:0   Position:X:64Y:0   Position:X:-64Y:-8   Position:X:64Y:-8   Position:X:-64Y:-16   Position:X:64Y:-16   Position:X:-56Y:-24   Position:X:64Y:-24   Position:X:-56Y:-32   Position:X:56Y:-32   Position:X:-48Y:-40   Position:X:56Y:-40   Position:X:-40Y:-48   Position:X:56Y:-48   Position:X:-40Y:-56   Position:X:48Y:-56   Position:X:-40Y:-64   Position:X:48Y:-64"
        Dim Coords As String = InputBox("Put a premade position string into this box" & vbCrLf & vbCrLf & "Example:" & vbCrLf & "Position:X:10Y:-10 Position:X:10Y:10... etc", , Positions).ToLower
        Cursor = Cursors.WaitCursor
        Try
            ClearGraph()
            LoadGraph(Coords)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cursor = Cursors.Default
        MsgBox("Rank Drawn")
    End Sub
    'Update Boxes
    Sub UpdateRank()
        If FormLoaded = True Then
            txtUnitName.Text = Rank(CurrentHorde, CurrentRank).UnitName
            txtUnitCount.Text = Rank(CurrentHorde, CurrentRank).UnitCount
            chkReleaseRank.Checked = Rank(CurrentHorde, CurrentRank).ReleaseWhenAttacking
            chkRankStop.Checked = Rank(CurrentHorde, CurrentRank).RanksThatStopAdvance
            chkJustFree.Checked = Rank(CurrentHorde, CurrentRank).JustFreeWhenAttacking
            chkAddRank.Checked = Rank(CurrentHorde, CurrentRank).AddToHorde
            txtPositions.Text = Rank(CurrentHorde, CurrentRank).RankInfo
            CurrentColor = Rank(CurrentHorde, CurrentRank).Color
            lblRankColor.BackColor = Rank(CurrentHorde, CurrentRank).Color
            updDistanceApart.Value = Rank(CurrentHorde, CurrentRank).Separation
        End If
    End Sub
    'Update Rank Inf
    Private Sub chkAddRank_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAddRank.CheckedChanged
        Rank(CurrentHorde, CurrentRank).AddToHorde = chkAddRank.Checked
        UpdateRank()
    End Sub
    Private Sub chkJustFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJustFree.CheckedChanged
        Rank(CurrentHorde, CurrentRank).JustFreeWhenAttacking = chkJustFree.Checked
        UpdateRank()
    End Sub
    Private Sub chkReleaseRank_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReleaseRank.CheckedChanged
        Rank(CurrentHorde, CurrentRank).ReleaseWhenAttacking = chkReleaseRank.Checked
        UpdateRank()
    End Sub
    Private Sub chkRankStop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRankStop.CheckedChanged
        Rank(CurrentHorde, CurrentRank).RanksThatStopAdvance = chkRankStop.Checked
        UpdateRank()
    End Sub
    Private Sub cmbRank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRank.SelectedIndexChanged
        CurrentRank = cmbRank.SelectedIndex
        UpdateRank()
        Dim Coords As String = Rank(CurrentHorde, CurrentRank).RankInfo
        Try
            If Coords.TrimStart = "" Then
                ClearGraph()
                Exit Sub
            Else
                ClearGraph()
                LoadGraph(Coords)
                UpdateGraph()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtUnitName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitName.TextChanged
        Rank(CurrentHorde, CurrentRank).UnitName = txtUnitName.Text
        UpdateRank()
    End Sub
    Private Sub txtUnitCount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitCount.TextChanged
        Rank(CurrentHorde, CurrentRank).UnitCount = txtUnitCount.Text
        UpdateRank()
    End Sub
    Private Sub txtPositions_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPositions.TextChanged
        Rank(CurrentHorde, CurrentRank).RankInfo = txtPositions.Text
        UpdateRank()
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If MsgBox("Are you sure? This graph will be cleared and information lost.", MsgBoxStyle.YesNo, "Attention") = MsgBoxResult.Yes Then
            ClearGraph()
        End If
        txtPositions.Text = ""
    End Sub
    Private Sub lblRankColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRankColor.Click
        With ColorDialog1
            .FullOpen = True
            If ColorDialog1.ShowDialog = DialogResult.OK Then
                Rank(CurrentHorde, CurrentRank).Color = .Color
                lblRankColor.BackColor = .Color
                UpdateRank()
            End If
        End With
    End Sub
    Private Sub updDistanceApart_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles updDistanceApart.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub updDistanceApart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updDistanceApart.ValueChanged
        If updDistanceApart.Text <> "" Then
            Rank(CurrentHorde, CurrentRank).Separation = CInt(updDistanceApart.Value)
        End If
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        RotateGraph()
    End Sub
#End Region
#Region " -=-ComboHorde-=- "
    'Update Boxes
    Sub UpdateCombo()
        If FormLoaded = True Then
            chkAddCombo.Checked = ComboHorde(CurrentRank, CurrentComboHorde).AddToHorde
            txtCVoice.Text = ComboHorde(CurrentRank, CurrentComboHorde).InitiateVoice
            txtCResult.Text = ComboHorde(CurrentRank, CurrentComboHorde).Result
            txtCTarget.Text = ComboHorde(CurrentRank, CurrentComboHorde).Target
        End If
    End Sub
    'Update Combo Info
    Private Sub chkAddCombo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddCombo.CheckedChanged
        ComboHorde(CurrentRank, CurrentComboHorde).AddToHorde = chkAddCombo.Checked
        UpdateCombo()
    End Sub
    Private Sub txtCVoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCVoice.TextChanged
        ComboHorde(CurrentRank, CurrentComboHorde).InitiateVoice = txtCVoice.Text
        UpdateCombo()
    End Sub
    Private Sub txtCResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCResult.TextChanged
        ComboHorde(CurrentRank, CurrentComboHorde).Result = txtCResult.Text
        UpdateCombo()
    End Sub
    Private Sub txtCTarget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCTarget.TextChanged
        ComboHorde(CurrentRank, CurrentComboHorde).Target = txtCTarget.Text
        UpdateCombo()
    End Sub
    Private Sub cmbCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCombo.SelectedIndexChanged
        CurrentComboHorde = cmbCombo.SelectedIndex
        UpdateCombo()
    End Sub
#End Region
#Region " -=-AlternateFormation-=- "
    'Update textboxes
    Sub UpdateAlternate()
        If FormLoaded = True Then
            txtAHordeName.Text = AlternateFormation(CurrentHorde, CurrentAlternateFormation).Name
            chkAddAlternate.Checked = AlternateFormation(CurrentHorde, CurrentAlternateFormation).AddToHorde
        End If
    End Sub
    'Update Alternate Formations
    Private Sub chkAddAlternate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddAlternate.CheckedChanged
        AlternateFormation(CurrentHorde, CurrentAlternateFormation).AddToHorde = chkAddAlternate.Checked
        UpdateAlternate()
    End Sub
    Private Sub txtAHordeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAHordeName.TextChanged
        AlternateFormation(CurrentHorde, CurrentAlternateFormation).Name = txtAHordeName.Text
        UpdateAlternate()
    End Sub
    Private Sub cmbAlternate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlternate.SelectedIndexChanged
        CurrentAlternateFormation = cmbAlternate.SelectedIndex
        UpdateAlternate()
    End Sub
#End Region
#Region " -=-SplitHorde-=- "
    'Update textboxes
    Sub UpdateSplit()
        If FormLoaded = True Then
            txtSResult.Text = SplitHorde(CurrentHorde, CurrentSplitHorde).SplitResult
            txtSUnitType.Text = SplitHorde(CurrentHorde, CurrentSplitHorde).UnitType
            chkAddSplit.Checked = SplitHorde(CurrentHorde, CurrentSplitHorde).AddToHorde
        End If
    End Sub
    'Update SplitHorde
    Private Sub txtSResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSResult.TextChanged
        SplitHorde(CurrentHorde, CurrentSplitHorde).SplitResult = txtSResult.Text
        UpdateSplit()
    End Sub
    Private Sub txtSUnitType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSUnitType.TextChanged
        SplitHorde(CurrentHorde, CurrentSplitHorde).UnitType = txtSUnitType.Text
        UpdateSplit()
    End Sub
    Private Sub chkAddSplit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddSplit.CheckedChanged
        SplitHorde(CurrentHorde, CurrentSplitHorde).AddToHorde = chkAddSplit.Checked
        UpdateSplit()
    End Sub
    Private Sub cmbSplit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSplit.SelectedIndexChanged
        CurrentSplitHorde = cmbSplit.SelectedIndex
        UpdateSplit()
    End Sub
#End Region
#Region " -=-HordeProperties-=- "
    Private Sub lstHordes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHordes.SelectedIndexChanged
        CurrentHorde = lstHordes.SelectedIndex
        UpdateAll()
    End Sub
    'update textboxes
    Sub UpdateHordeP()
        If FormLoaded = True Then
            chkHShowPips.Checked = Horde(CurrentHorde).ShowPips
            chkHMainFormation.Checked = Horde(CurrentHorde).MainFormation
            txtHFilter.Text = Horde(CurrentHorde).PassengerFillter
            txtHX.Text = Horde(CurrentHorde).RandomOffset.X
            txtHY.Text = Horde(CurrentHorde).RandomOffset.Y
            chkHPorcupine.Checked = Horde(CurrentHorde).UsePorcupineBody
            txtHMeleeDistance.Text = Horde(CurrentHorde).MeleeAttackLeashDistance
            txtHAModifier.Text = Horde(CurrentHorde).AttributeModifiers
            chkHSlowHorde.Checked = Horde(CurrentHorde).UseSlowHordeMovement
            txtHUnitType.Text = Horde(CurrentHorde).UnitType
            chkHIsCombo.Checked = Horde(CurrentHorde).NotComboFormation
            chkHMarching.Checked = Horde(CurrentHorde).UseMarchingAnims
            chkHIncludeBackUp.Checked = Horde(CurrentHorde).InludeBackUp
            txtHMinDelay.Text = Horde(CurrentHorde).BackUpMinDelaytime
            txtHMaxDelay.Text = Horde(CurrentHorde).BackUpMaxDelaytime
            txtHMinDistance.Text = Horde(CurrentHorde).BackUpMinDistance
            txtHMaxDistance.Text = Horde(CurrentHorde).BackUpMaxDistance
            txtHPercentage.Text = Horde(CurrentHorde).BackUpPercentage
            txtHName.Text = Horde(CurrentHorde).ObjectName
            txtHStatus.Text = Horde(CurrentHorde).ObjectStatusOfContained
            txtHSlots.Text = Horde(CurrentHorde).Slots
            chkHCreate.Checked = Horde(CurrentHorde).CreateHorde
        End If
    End Sub
    'update horde
    Private Sub chkHShowPips_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHShowPips.CheckedChanged
        Horde(CurrentHorde).ShowPips = chkHShowPips.Checked
        UpdateHordeP()
    End Sub
    Private Sub chkHMainFormation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHMainFormation.CheckedChanged
        Horde(CurrentHorde).MainFormation = chkHMainFormation.Checked
        UpdateHordeP()
    End Sub
    Private Sub txtHFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHFilter.TextChanged
        Horde(CurrentHorde).PassengerFillter = txtHFilter.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHX.TextChanged
        Dim _X_ As String = txtHX.Text
        Dim _Y_ As String = txtHY.Text
        If _X_ = "" Then _X_ = "0"
        If _Y_ = "" Then _Y_ = "0"
        Horde(CurrentHorde).RandomOffset = New Point(_X_, _Y_)
        UpdateHordeP()
    End Sub
    Private Sub txtHY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHY.TextChanged
        Dim _X_ As String = txtHX.Text
        Dim _Y_ As String = txtHY.Text
        If _X_ = "" Then _X_ = "0"
        If _Y_ = "" Then _Y_ = "0"
        Horde(CurrentHorde).RandomOffset = New Point(_X_, _Y_)
        UpdateHordeP()
    End Sub
    Private Sub chkHPorcupine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHPorcupine.CheckedChanged
        Horde(CurrentHorde).UsePorcupineBody = chkHPorcupine.Checked
        UpdateHordeP()
    End Sub
    Private Sub txtHMeleeDistance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHMeleeDistance.TextChanged
        Horde(CurrentHorde).MeleeAttackLeashDistance = txtHMeleeDistance.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHAModifier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHAModifier.TextChanged
        Horde(CurrentHorde).AttributeModifiers = txtHAModifier.Text
        UpdateHordeP()
    End Sub
    Private Sub chkHSlowHorde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHSlowHorde.CheckedChanged
        Horde(CurrentHorde).UseSlowHordeMovement = chkHSlowHorde.Checked
        UpdateHordeP()
    End Sub
    Private Sub txtHUnitType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHUnitType.TextChanged
        Horde(CurrentHorde).UnitType = txtHUnitType.Text
        UpdateHordeP()
    End Sub
    Private Sub chkHIsCombo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHIsCombo.CheckedChanged
        Horde(CurrentHorde).NotComboFormation = chkHIsCombo.Checked
        UpdateHordeP()
    End Sub
    Private Sub chkHMarching_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHMarching.CheckedChanged
        Horde(CurrentHorde).UseMarchingAnims = chkHMarching.Checked
        UpdateHordeP()
    End Sub
    Private Sub chkHIncludeBackUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHIncludeBackUp.CheckedChanged
        Horde(CurrentHorde).InludeBackUp = chkHIncludeBackUp.Checked
        UpdateHordeP()
    End Sub
    Private Sub txtHMinDelay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHMinDelay.TextChanged
        Horde(CurrentHorde).BackUpMinDelaytime = txtHMinDelay.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHMaxDelay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHMaxDelay.TextChanged
        Horde(CurrentHorde).BackUpMaxDelaytime = txtHMaxDelay.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHMinDistance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHMinDistance.TextChanged
        Horde(CurrentHorde).BackUpMinDistance = txtHMinDistance.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHMaxDistance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHMaxDistance.TextChanged
        Horde(CurrentHorde).BackUpMaxDistance = txtHMaxDistance.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHPercentage.TextChanged
        Horde(CurrentHorde).BackUpPercentage = txtHPercentage.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHName.TextChanged
        Horde(CurrentHorde).ObjectName = txtHName.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHStatus.TextChanged
        Horde(CurrentHorde).ObjectStatusOfContained = txtHStatus.Text
        UpdateHordeP()
    End Sub
    Private Sub txtHSlots_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHSlots.TextChanged
        Horde(CurrentHorde).Slots = txtHSlots.Text
        UpdateHordeP()
    End Sub
    Private Sub chkHCreate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkHCreate.CheckedChanged
        Horde(CurrentHorde).CreateHorde = chkHCreate.Checked
        UpdateHordeP()
    End Sub
    Private Sub txtHName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHName.LostFocus
        UpdateHordeS()
    End Sub
#End Region
#Region " -=-BannerCarrier-=- "
    'Update textboxes
    Sub UpdateBanner()
        If FormLoaded = True Then
            txtBUnitType.Text = BannerCarrier(CurrentHorde).UnitType
            txtBPositions.Text = BannerCarrier(CurrentHorde).BannerCarrierPosition
            chkBAddToHorde.Checked = BannerCarrier(CurrentHorde).AddToHorde
            txtBAllowed.Text = BannerCarrier(CurrentHorde).BannerCarriersAllowed
        End If
    End Sub
    Private Sub txtBUnitType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUnitType.TextChanged
        BannerCarrier(CurrentHorde).UnitType = txtBUnitType.Text
        UpdateBanner()
    End Sub
    Private Sub txtBPositions_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBPositions.TextChanged
        BannerCarrier(CurrentHorde).BannerCarrierPosition = txtBPositions.Text
        UpdateBanner()
    End Sub
    Private Sub chkBAddToHorde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBAddToHorde.CheckedChanged
        BannerCarrier(CurrentHorde).AddToHorde = chkBAddToHorde.Checked
        UpdateBanner()
    End Sub
    Private Sub txtBAllowed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBAllowed.TextChanged
        BannerCarrier(CurrentHorde).BannerCarriersAllowed = txtBAllowed.Text
        UpdateBanner()
    End Sub
    Private Sub chkBActivate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBActivate.CheckedChanged

    End Sub
#End Region


End Class

Class Draw

    Public Shared Function FourSided(ByVal width As Integer, ByVal height As Integer, ByVal outercolor As Color, ByVal innercolor As Color, ByVal depth As Integer) As Bitmap
        Dim bm As New Bitmap(width, height)
        Dim gr As Graphics = Graphics.FromImage(bm)
        gr.FillRectangle(New SolidBrush(innercolor), 0, 0, width, height)
        Dim rec(3) As Rectangle
        rec(0) = New Rectangle(0, 0, depth, height)
        rec(1) = New Rectangle(0, 0, width, depth)
        rec(2) = New Rectangle(0, height - depth, width, depth)
        rec(3) = New Rectangle(width - depth, 0, depth, height)
        Dim br(3) As LinearGradientBrush
        br(0) = New LinearGradientBrush(rec(0), outercolor, Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        br(1) = New LinearGradientBrush(rec(1), outercolor, Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Vertical)
        br(2) = New LinearGradientBrush(rec(2), Color.FromArgb(0, 0, 0, 0), outercolor, LinearGradientMode.Vertical)
        br(3) = New LinearGradientBrush(rec(3), Color.FromArgb(0, 0, 0, 0), outercolor, LinearGradientMode.Horizontal)
        For i As Integer = 0 To 3
            gr.FillRectangle(br(i), rec(i))
            'gr.DrawRectangle(New Pen(Color.FromArgb(255, outercolor.R - innercolor.R, outercolor.G - innercolor.G, outercolor.B - innercolor.B)), CInt(i / 15), CInt(i / 15), CInt(width - 2 * (i / 15)), CInt(height - 2 * (i / 15)))
        Next
        Return bm
    End Function
    Public Shared Function TwoSided(ByVal width As Integer, ByVal height As Integer, ByVal outercolor As Color, ByVal innercolor As Color, ByVal depth As Integer) As Bitmap
        Dim bm As New Bitmap(width, height)
        Dim gr As Graphics = Graphics.FromImage(bm)
        gr.FillRectangle(New SolidBrush(innercolor), 0, 0, width, height)
        Dim rec(1) As Rectangle
        rec(0) = New Rectangle(0, 0, width, depth)
        rec(1) = New Rectangle(0, height - depth, width, depth)
        Dim br(1) As LinearGradientBrush
        br(0) = New LinearGradientBrush(rec(0), outercolor, Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Vertical)
        br(1) = New LinearGradientBrush(rec(1), Color.FromArgb(0, 0, 0, 0), outercolor, LinearGradientMode.Vertical)
        For i As Integer = 0 To 1
            gr.FillRectangle(br(i), rec(i))
        Next
        Return bm
    End Function
    Public Shared Function OneSided(ByVal width As Integer, ByVal height As Integer, ByVal color1 As Color, ByVal color2 As Color, ByVal mode As LinearGradientMode) As Bitmap
        Dim bm As New Bitmap(width, height)
        Dim gr As Graphics = Graphics.FromImage(bm)
        gr.FillRectangle(New SolidBrush(color1), 0, 0, width, height)
        Dim rec As Rectangle
        rec = New Rectangle(0, 0, width, height)
        Dim br As LinearGradientBrush
        br = New LinearGradientBrush(rec, color1, color2, LinearGradientMode.Vertical)
        gr.FillRectangle(br, rec)
        Return bm
    End Function
    Public Shared Function BlendPanel(ByVal width As Integer, ByVal height As Integer, ByVal outercolor As Color, ByVal innercolor As Color, ByVal depth As Integer, ByVal direction As LinearGradientMode) As Bitmap
        Dim bm As New Bitmap(width, height)
        Dim gr As Graphics = Graphics.FromImage(bm)
        gr.FillRectangle(New SolidBrush(innercolor), 0, 0, width, height)
        'dim rec as Rectangle(0,0
    End Function
    Public Shared Function Effect3d(ByVal im As Image, ByVal upcolor As Color, ByVal downcolor As Color, ByVal depth As Integer) As Bitmap
        Dim bm As New Bitmap(im)
        Dim gr As Graphics = Graphics.FromImage(bm)
        Dim pts(5) As Point
        pts(0) = New Point(0, 0)
        pts(1) = New Point(im.Width, 0)
        pts(2) = New Point(im.Width - depth, depth)
        pts(3) = New Point(depth, depth)
        pts(4) = New Point(depth, im.Height - depth)
        pts(5) = New Point(0, im.Height)
        gr.FillPolygon(New SolidBrush(upcolor), pts)
        pts(0) = New Point(im.Width, 0)
        pts(1) = New Point(im.Width, im.Height)
        pts(2) = New Point(0, im.Height)
        pts(3) = New Point(depth, im.Height - depth)
        pts(4) = New Point(im.Width - depth, im.Height - depth)
        pts(5) = New Point(im.Width - depth, depth)
        gr.FillPolygon(New SolidBrush(downcolor), pts)
        Return bm
    End Function

End Class
Class Strings

    Public Shared Function Shadowed(ByVal im As Image, ByVal str As String, ByVal ftFam As FontFamily, ByVal ftsz As Integer, ByVal x As Integer, ByVal y As Integer, ByVal depth As Integer, ByVal ftColor As Color, ByVal bkColor As Color, ByVal ftStyle As FontStyle) As Bitmap
        Dim bm As New Bitmap(im)
        Dim gr As Graphics = Graphics.FromImage(bm)
        Dim ft As New System.Drawing.Font(ftFam, ftsz, ftStyle)
        For i As Integer = 1 To depth
            gr.DrawString(str, ft, New SolidBrush(bkColor), x + i, y + i)
        Next
        gr.DrawString(str, ft, New SolidBrush(ftColor), x, y)
        Return bm
    End Function
    Public Shared Function Outlined(ByVal im As Image, ByVal str As String, ByVal ftFam As FontFamily, ByVal ftsz1 As Integer, ByVal ftsz2 As Integer, ByVal x As Integer, ByVal y As Integer, ByVal ftColor As Color, ByVal bkColor As Color, ByVal ftStyle As FontStyle) As Bitmap
        Dim bm As New Bitmap(im)
        Dim gr As Graphics = Graphics.FromImage(bm)
        Dim path As New GraphicsPath
        path.AddString(str, ftFam, ftStyle, ftsz2, New Point(x, y), StringFormat.GenericDefault)
        gr.FillPath(New SolidBrush(ftColor), path)
        gr.DrawPath(New Pen(bkColor, 1), path)
        Return bm
    End Function
    Public Shared Function Normal(ByVal im As Image, ByVal str As String, ByVal ftFam As FontFamily, ByVal ftsz As Integer, ByVal x As Integer, ByVal y As Integer, ByVal ftColor As Color, ByVal ftStyle As FontStyle) As Bitmap
        Dim bm As New Bitmap(im)
        Dim gr As Graphics = Graphics.FromImage(bm)
        Dim ft As New System.Drawing.Font(ftFam, ftsz, ftStyle)
        gr.DrawString(str, ft, New SolidBrush(ftColor), x, y)
        Return bm
    End Function

End Class
Enum HordeType
    Horse = 0
    Infantry = 1
    Archer = 2
    Pikeman = 3
    Other = 4
End Enum
Structure Horde
    Dim TypeOfhorde As HordeType
    Dim ObjectName As String
    Dim ObjectStatusOfContained As String
    Dim Slots As String
    Dim PassengerFillter As String
    Dim ShowPips As Boolean
    Dim MainFormation As Boolean
    Dim RandomOffset As Point
    Dim MeleeAttackLeashDistance As String
    Dim AttributeModifiers As String
    Dim UsePorcupineBody As Boolean
    Dim UseSlowHordeMovement As Boolean
    Dim UnitType As String
    Dim NotComboFormation As Boolean
    Dim UseMarchingAnims As Boolean
    Dim InludeBackUp As Boolean
    Dim BackUpMinDelaytime As String
    Dim BackUpMaxDelaytime As String
    Dim BackUpMinDistance As String
    Dim BackUpMaxDistance As String
    Dim BackUpPercentage As String
    Dim CreateHorde As Boolean
End Structure
Structure ComboHorde
    Dim Target As String
    Dim Result As String
    Dim InitiateVoice As String
    Dim AddToHorde As Boolean
End Structure
Structure AlternateFormation
    Dim Name As String
    Dim AddToHorde As Boolean
End Structure
Structure Ranks
    Dim RankName As String
    Dim UnitName As String
    Dim UnitCount As String
    Dim RankInfo As String
    Dim ReleaseWhenAttacking As Boolean
    Dim RanksThatStopAdvance As Boolean
    Dim JustFreeWhenAttacking As Boolean
    Dim AddToHorde As Boolean
    Dim Color As Color
    Dim Separation As Integer
End Structure
Structure BannerCarrier
    Dim BannerCarriersAllowed As String
    Dim BannerCarrierPosition As String
    Dim UnitType As String
    Dim AddToHorde As Boolean
End Structure
Structure InitialPayload
    Dim Unit As String
    Dim UnitNumber As String
End Structure
Structure SplitHorde
    Dim SplitResult As String
    Dim UnitType As String
    Dim AddToHorde As Boolean
End Structure

