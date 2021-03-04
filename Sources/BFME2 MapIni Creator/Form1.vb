Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

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
    Friend WithEvents btnOpenINI As System.Windows.Forms.Button
    Friend WithEvents txtVarName As System.Windows.Forms.TextBox
    Friend WithEvents lblVarName As System.Windows.Forms.Label
    Friend WithEvents btnOpenFolder As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Status As System.Windows.Forms.StatusBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents tbbOpen As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbSave As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbNew As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbAbout As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents Sep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Sep2 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.btnOpenINI = New System.Windows.Forms.Button
        Me.txtVarName = New System.Windows.Forms.TextBox
        Me.lblVarName = New System.Windows.Forms.Label
        Me.btnOpenFolder = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Status = New System.Windows.Forms.StatusBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rtb = New System.Windows.Forms.RichTextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.tbbOpen = New System.Windows.Forms.ToolBarButton
        Me.tbbSave = New System.Windows.Forms.ToolBarButton
        Me.tbbNew = New System.Windows.Forms.ToolBarButton
        Me.tbbAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbAbout = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.Sep1 = New System.Windows.Forms.ToolBarButton
        Me.Sep2 = New System.Windows.Forms.ToolBarButton
        Me.SuspendLayout()
        '
        'btnOpenINI
        '
        Me.btnOpenINI.Location = New System.Drawing.Point(168, 40)
        Me.btnOpenINI.Name = "btnOpenINI"
        Me.btnOpenINI.Size = New System.Drawing.Size(112, 23)
        Me.btnOpenINI.TabIndex = 0
        Me.btnOpenINI.Text = "Open INI"
        '
        'txtVarName
        '
        Me.txtVarName.Location = New System.Drawing.Point(88, 40)
        Me.txtVarName.Name = "txtVarName"
        Me.txtVarName.Size = New System.Drawing.Size(72, 20)
        Me.txtVarName.TabIndex = 1
        Me.txtVarName.Text = "Unit"
        '
        'lblVarName
        '
        Me.lblVarName.Location = New System.Drawing.Point(8, 40)
        Me.lblVarName.Name = "lblVarName"
        Me.lblVarName.Size = New System.Drawing.Size(80, 23)
        Me.lblVarName.TabIndex = 2
        Me.lblVarName.Text = "Variable Name"
        Me.lblVarName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(288, 40)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(112, 23)
        Me.btnOpenFolder.TabIndex = 3
        Me.btnOpenFolder.Text = "Open Folder"
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(0, 440)
        Me.Status.Name = "Status"
        Me.Status.ShowPanels = True
        Me.Status.Size = New System.Drawing.Size(584, 22)
        Me.Status.TabIndex = 4
        '
        'rtb
        '
        Me.rtb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb.Location = New System.Drawing.Point(8, 72)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(568, 360)
        Me.rtb.TabIndex = 5
        Me.rtb.Text = ""
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbOpen, Me.tbbSave, Me.tbbNew, Me.Sep1, Me.tbbAdd, Me.tbbDelete, Me.tbbAbout, Me.Sep2})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(25, 25)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(584, 28)
        Me.ToolBar1.TabIndex = 6
        '
        'tbbOpen
        '
        Me.tbbOpen.ImageIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "&Save Map.ini"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "&Exit"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "&Edit"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem5.Text = "&Help"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "&About"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "&Credits"
        '
        'Sep1
        '
        Me.Sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'Sep2
        '
        Me.Sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.rtb)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.btnOpenFolder)
        Me.Controls.Add(Me.lblVarName)
        Me.Controls.Add(Me.txtVarName)
        Me.Controls.Add(Me.btnOpenINI)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "{IP}Gil-Galads Map.ini Creator (BFME II)"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " -=-Enums/Structures-=- "
    Enum ThingClass
        NONE = 0
        UNIT = 1
        SYSTEM = 2
        STRUCTUR = 3
        MISC_NATURAL = 4
        MISC_MAN_MADE = 5
        DEBRIS = 6
        SHRUBBERY = 7
        AUDIO = 8
        SELECTABLE = 9
        EMITTERS = 10
        OBSOLETE = 11
        CAVALRY_UNIT = 12
        HORDE_UNIT = 13
        CHARACTER_UNIT = 14
        LARGE_MONSTER = 15
        MACHINE = 16
        MEDIUM_MONSTER = 17
    End Enum
    Enum Type
        NormalObject = 0
        ObjectReskin = 1
        ChildObject = 2
        Null = 3
    End Enum
    Enum RadarPriority
        INVALID = 0
        UNIT = 1
        NOT_ON_RADAR = 2
        STRUCTUR = 3
    End Enum
    Public Enum ObjectType
        Hero = 0
        Unit = 1
        Building = 2
    End Enum
    Structure Percent
        Dim Value As Double
    End Structure
    Structure STR
        Dim Name As String
        Dim Value As String
    End Structure
    Structure Unit
        Dim UnitName As String
        Dim UnitType As Type
        Dim BuildTime As String
        Dim BuildCost As String
        Dim Health As String
        Dim Scale As String
        Dim ThreatLevel As String
        Dim CommandPoints As String
        Dim BountyValue As String
        Dim ThingClass As ThingClass
        Dim VisionRange As String
        Dim ShroudClearingRange As String
        Dim DisplayName As String
        Dim CrushableLevel As String
        Dim RadarPriority As RadarPriority
        Dim KindOf As String
        Dim Model As String  '(Changing Model, Changes its animations)
        Dim DefaultModel As String
        Dim Texture As String
        Dim ArmorSet As String
        Dim LocomotorSet As String
        Dim WeaponSet As String
        Dim Description As String
        Dim DisplayMeleeDamage As String
        Dim DisplayRangedDamage As String
        Dim ImmuneToShockWave As Boolean
        Dim MaxSimultaneousOfType As String
        Dim ShockwaveResistance As String
        Dim CrushAllies As Boolean
        Dim RamPower As String
        Dim IsTrainable As Boolean
    End Structure
    Structure Hero
        Dim ObjectType As ObjectType
        Dim Keep As Boolean
        Dim HeroName As String
        Dim Herotype As Type
        Dim BuildTime As String
        Dim BuildCost As String
        Dim Health As String
        Dim HeroSortOrder As String
        Dim HotKey As String
        Dim Scale As String
        Dim ThreatLevel As String
        Dim CommandPoints As String
        Dim BountyValue As String
        Dim ThingClass As ThingClass
        Dim VisionRange As String
        Dim ShroudClearingRange As String
        Dim DisplayName As STR
        Dim CrushableLevel As String
        Dim RadarPriority As RadarPriority
        Dim KindOf As String
        Dim Model As String  '(Changing Model, Changes its animations)
        Dim Texture As String
        Dim ArmorSet As String
        Dim LocomotorSet As String
        Dim WeaponSet As String
        Dim Description As String
        Dim DisplayMeleeDamage As String
        Dim DisplayRangedDamage As String
        Dim ImmuneToShockWave As Boolean
        Dim MaxSimultaneousOfType As String
        Dim MaxVisionBonusPercent As Percent
        Dim VisionBonusTestRadius As String
        Dim VisionBonusPercentPerFoot As Percent
        Dim ShockwaveResistance As String
        Dim CrushAllies As Boolean
        Dim RamPower As String
        Dim IsTrainable As Boolean
    End Structure
    Structure Building
        Dim BuildingName As String
        Dim BuildingType As Type
        Dim BuildTime As String
        Dim BuildCost As String
        Dim Health As String
        Dim Scale As String
        Dim Model As String  '(Changing Model, Changes its animations)
        Dim DefaultModel As String
        Dim Texture As String
        Dim ArmorSet As String
        Dim Description As String
        Dim RadarPriority As RadarPriority
        Dim KindOf
        Dim DisplayName As String
    End Structure
    Structure SpellBook
        Dim lol As String
    End Structure
#End Region

#Region " -=-Variables-=- "
    Public Shared _
    TotalUnits As Integer = -1, _
    CurrentUnit As Integer = 0, _
    Units(1000) As Unit, _
    TotalHeros As Integer = -1, _
    CurrentHero As Integer = 0, _
    Heros(100000) As Hero, _
    TotalBuildings As Integer = -1, _
    CurrentBuildings As Integer = 0, _
    Buildings(1000) As Building, _
    CurrentType As ObjectType

#End Region

#Region " -=-Subs/Functions-=- "

    Sub OpenINI(ByVal FilePath As String)
        Dim Reader As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim TrimmedLine, NormalLine, LowerLine, InnerLine As String
        Dim UnitType As Type
        Do While Reader.Peek <> -1
            NormalLine = Reader.ReadLine.TrimEnd
            Trim(NormalLine)
            If NormalLine.TrimStart = "" Then GoTo Skip
            TrimmedLine = NormalLine.TrimStart
            LowerLine = TrimmedLine.ToLower
            UnitType = Type.Null
            If LowerLine.StartsWith("object") Then UnitType = Type.NormalObject
            If LowerLine.StartsWith("childobject") Then UnitType = Type.ChildObject
            If LowerLine.StartsWith("objectreskin") Then UnitType = Type.ObjectReskin
            If UnitType <> Type.Null Then
                TotalUnits += 1
                Heros(TotalUnits) = New Hero
                With Heros(TotalUnits)
                    .Herotype = UnitType
                    .ObjectType = ObjectType.Unit
                    Select Case UnitType
                        Case Type.ChildObject, Type.ObjectReskin
                            If NumSpaces(TrimmedLine) = 2 Then
                                .HeroName = TrimmedLine.Substring(TrimmedLine.IndexOf(" ") + 1, TrimmedLine.LastIndexOf(" ") - TrimmedLine.IndexOf(" ") - 1)
                            ElseIf NumSpaces(TrimmedLine) = 1 Then
                                .HeroName = TrimmedLine.Substring(TrimmedLine.IndexOf(" ") + 1)
                            End If
                        Case Type.NormalObject
                            .HeroName = TrimmedLine.Substring(TrimmedLine.IndexOf(" ") + 1)
                    End Select
                End With
                Do Until NormalLine.ToLower.StartsWith("end")
                    If Reader.Peek = -1 Then
                        Reader.Close() : Exit Sub
                    End If
                    NormalLine = Reader.ReadLine.TrimEnd
                    Trim(NormalLine)
                    If NormalLine.TrimStart = "" Then : GoTo Skip2 : End If
                    TrimmedLine = NormalLine.TrimStart
                    LowerLine = TrimmedLine.ToLower.TrimStart
                    If Contain(TrimmedLine, "=") Then
                        Dim EqualStr As String = TrimmedLine.Substring(TrimmedLine.IndexOf("=") + 1).TrimStart.TrimEnd
                        If LowerLine.StartsWith("buildtime") Then : Heros(TotalUnits).BuildTime = EqualStr : End If
                        If LowerLine.StartsWith("buildcost") Then : Heros(TotalUnits).BuildCost = EqualStr : End If
                        If LowerLine.StartsWith("maxhealth") Then : Heros(TotalUnits).Health = EqualStr : End If
                        If LowerLine.StartsWith("herosortorder") Then : Heros(TotalUnits).HeroSortOrder = EqualStr : Heros(TotalUnits).ObjectType = ObjectType.Hero : End If
                        If LowerLine.StartsWith("hotkey") Then : Heros(TotalUnits).HotKey = EqualStr : End If
                        If LowerLine.StartsWith("scale") Then : Heros(TotalUnits).Scale = EqualStr : End If
                        If LowerLine.StartsWith("threatlevel") Then : Heros(TotalUnits).ThreatLevel = EqualStr : End If
                        If LowerLine.StartsWith("commandpoints") Then : Heros(TotalUnits).CommandPoints = EqualStr : End If
                        If LowerLine.StartsWith("bountyvalue") Then : Heros(TotalUnits).BountyValue = EqualStr : End If
                        If LowerLine.StartsWith("thingclass") Then : Heros(TotalUnits).ThingClass = GetThingClass(EqualStr) : End If
                        If LowerLine.StartsWith("shroudclearingrange") Then : Heros(TotalUnits).ShroudClearingRange = EqualStr : End If
                        If LowerLine.StartsWith("visionrange") Then : Heros(TotalUnits).VisionRange = EqualStr : End If
                        If LowerLine.StartsWith("displayname") Then : Heros(TotalUnits).DisplayName.Name = EqualStr : End If
                        If LowerLine.StartsWith("crushablelevel") Then : Heros(TotalUnits).CrushableLevel = EqualStr : End If
                        If LowerLine.StartsWith("radarpriority") Then : Heros(TotalUnits).RadarPriority = GetRadarPriority(EqualStr) : End If
                        If LowerLine.StartsWith("shroudclearingrange") Then : Heros(TotalUnits).ShroudClearingRange = EqualStr : End If
                        If LowerLine.StartsWith("kindof") Then : Heros(TotalUnits).KindOf = EqualStr : End If
                        If LowerLine.StartsWith("defaultmodel") Then
                            Do Until NormalLine.ToLower.TrimStart.StartsWith("end")
                                NormalLine = Reader.ReadLine.TrimEnd
                                Trim(NormalLine)
                                If NormalLine.TrimStart = "" Then : GoTo Skip2 : End If
                                TrimmedLine = NormalLine.TrimStart
                                LowerLine = TrimmedLine.ToLower
                                If Contain(TrimmedLine, "=") = True Then
                                    EqualStr = TrimmedLine.Substring(TrimmedLine.IndexOf("=") + 1).TrimStart.TrimEnd
                                    If LowerLine.StartsWith("model") Then : Heros(TotalUnits).Model = EqualStr : Exit Do : End If
                                End If
                            Loop
                        End If
                        If LowerLine.StartsWith("description") Then : Heros(TotalUnits).Description = EqualStr : End If
                        If LowerLine.StartsWith("displaymeleedamage") Then : Heros(TotalUnits).DisplayMeleeDamage = EqualStr : End If
                        If LowerLine.StartsWith("displayrangeddamage") Then : Heros(TotalUnits).DisplayRangedDamage = EqualStr : End If
                        If EqualStr.ToLower = "yes" And LowerLine.StartsWith("immunetoshockwave") Then : Heros(TotalUnits).ImmuneToShockWave = True : End If
                        If EqualStr.ToLower = "no" And LowerLine.StartsWith("immunetoshockwave") Then : Heros(TotalUnits).ImmuneToShockWave = False : End If
                        If LowerLine.StartsWith("maxsimultaneousoftype") Then : Heros(TotalUnits).MaxSimultaneousOfType = EqualStr : End If
                        If LowerLine.StartsWith("maxvisionbonuspercent") Then : Heros(TotalUnits).MaxVisionBonusPercent.Value = EqualStr.Replace("%", "") : End If
                        If LowerLine.StartsWith("visionbonustestradius") Then : Heros(TotalUnits).VisionBonusTestRadius = EqualStr : End If
                        If LowerLine.StartsWith("visionbonuspercentperfoot") Then : Heros(TotalUnits).VisionBonusPercentPerFoot.Value = EqualStr.Replace("%", "") : End If
                        If LowerLine.StartsWith("shockwaveresistance") Then : Heros(TotalUnits).ShockwaveResistance = EqualStr : End If
                        If EqualStr.ToLower = "yes" And LowerLine.StartsWith("crushallies") Then : Heros(TotalUnits).CrushAllies = True : End If
                        If EqualStr.ToLower = "no" And LowerLine.StartsWith("crushallies") Then : Heros(TotalUnits).CrushAllies = False : End If
                        If LowerLine.StartsWith("rampower") Then : Heros(TotalUnits).RamPower = EqualStr : End If
                        If EqualStr.ToLower = "yes" And LowerLine.StartsWith("istrainable") Then : Heros(TotalUnits).IsTrainable = True : End If
                        If EqualStr.ToLower = "no" And LowerLine.StartsWith("istrainable") Then : Heros(TotalUnits).IsTrainable = False : End If
                    End If
                    'If LowerLine.StartsWith("armorset") Then Heros(TotalUnits).ArmorSet = EqualStr
                    'If LowerLine.StartsWith("locomotorset") Then Heros(TotalUnits).LocomotorSet = EqualStr
                    'If LowerLine.StartsWith("weaponset") Then Heros(TotalUnits).WeaponSet = EqualStr
Skip2:
                Loop
            End If
Skip:
        Loop
        Reader.Close()
    End Sub
    Sub CodeInfo()
        Dim str As String
        Dim SB As New IO.StringWriter
        For i As Integer = 0 To TotalUnits
            SB.WriteLine("With Heros(" & i & ")")
            If Heros(i).HeroName <> "" Then SB.WriteLine(vbTab & ".HeroName = " & Heros(i).HeroName)
            If Heros(i).Herotype.ToString <> "" Then SB.WriteLine(vbTab & ".Herotype = " & Heros(i).Herotype.ToString)
            If Heros(i).BuildTime <> "" Then SB.WriteLine(vbTab & ".BuildTime = " & Heros(i).BuildTime)
            If Heros(i).BuildCost <> "" Then SB.WriteLine(vbTab & ".BuildCost = " & Heros(i).BuildCost)
            If Heros(i).Health <> "" Then SB.WriteLine(vbTab & ".Health = " & Heros(i).Health)
            If Heros(i).HeroSortOrder <> "" Then SB.WriteLine(vbTab & ".HeroSortOrder = " & Heros(i).HeroSortOrder)
            If Heros(i).HotKey <> "" Then SB.WriteLine(vbTab & ".HotKey = " & Heros(i).HotKey)
            If Heros(i).Scale <> "" Then SB.WriteLine(vbTab & ".Scale = " & Heros(i).Scale)
            If Heros(i).ThreatLevel <> "" Then SB.WriteLine(vbTab & ".ThreatLevel = " & Heros(i).ThreatLevel)
            If Heros(i).CommandPoints <> "" Then SB.WriteLine(vbTab & ".CommandPoints = " & Heros(i).CommandPoints)
            If Heros(i).BountyValue <> "" Then SB.WriteLine(vbTab & ".BountyValue = " & Heros(i).BountyValue)
            If Heros(i).ThingClass <> Nothing Then SB.WriteLine(vbTab & ".ThingClass = " & Heros(i).ThingClass)
            If Heros(i).VisionRange <> "" Then SB.WriteLine(vbTab & ".VisionRange = " & Heros(i).VisionRange)
            If Heros(i).ShroudClearingRange <> "" Then SB.WriteLine(vbTab & ".ShroudClearingRange = " & Heros(i).ShroudClearingRange)
            If Heros(i).DisplayName.Name <> "" Then SB.WriteLine(vbTab & ".DisplayName.Name = " & Heros(i).DisplayName.Name)
            If Heros(i).CrushableLevel <> "" Then SB.WriteLine(vbTab & ".CrushableLevel = " & Heros(i).CrushableLevel)
            If Heros(i).RadarPriority.ToString <> "" Then SB.WriteLine(vbTab & ".RadarPriority = " & Heros(i).RadarPriority.ToString)
            If Heros(i).KindOf <> "" Then SB.WriteLine(vbTab & ".KindOf = " & Heros(i).KindOf)
            If Heros(i).Model <> "" Then SB.WriteLine(vbTab & ".Model = " & Heros(i).Model)
            If Heros(i).Texture <> "" Then SB.WriteLine(vbTab & ".Texture = " & Heros(i).Texture)
            If Heros(i).ArmorSet <> "" Then SB.WriteLine(vbTab & ".ArmorSet = " & Heros(i).ArmorSet)
            If Heros(i).LocomotorSet <> "" Then SB.WriteLine(vbTab & ".LocomotorSet = " & Heros(i).LocomotorSet)
            If Heros(i).WeaponSet <> "" Then SB.WriteLine(vbTab & ".WeaponSet = " & Heros(i).WeaponSet)
            If Heros(i).Description <> "" Then SB.WriteLine(vbTab & ".Description = " & Heros(i).Description)
            If Heros(i).DisplayMeleeDamage <> "" Then SB.WriteLine(vbTab & ".DisplayMeleeDamage = " & Heros(i).DisplayMeleeDamage)
            If Heros(i).DisplayRangedDamage <> "" Then SB.WriteLine(vbTab & ".DisplayRangedDamage = " & Heros(i).DisplayRangedDamage)
            If Heros(i).ImmuneToShockWave.ToString <> "" Then SB.WriteLine(vbTab & ".ImmuneToShockWave = " & Heros(i).ImmuneToShockWave.ToString)
            If Heros(i).MaxSimultaneousOfType <> "" Then SB.WriteLine(vbTab & ".MaxSimultaneousOfType = " & Heros(i).MaxSimultaneousOfType)
            If Heros(i).MaxVisionBonusPercent.Value <> Nothing Then SB.WriteLine(vbTab & ".MaxVisionBonusPercent.Value = " & Heros(i).MaxVisionBonusPercent.Value)
            If Heros(i).VisionBonusTestRadius <> "" Then SB.WriteLine(vbTab & ".VisionBonusTestRadius = " & Heros(i).VisionBonusTestRadius)
            If Heros(i).VisionBonusPercentPerFoot.Value <> Nothing Then SB.WriteLine(vbTab & ".VisionBonusPercentPerFoot.Value = " & Heros(i).VisionBonusPercentPerFoot.Value)
            If Heros(i).ShockwaveResistance <> "" Then SB.WriteLine(vbTab & ".ShockwaveResistance = " & Heros(i).ShockwaveResistance)
            SB.WriteLine(vbTab & ".CrushAllies = " & Heros(i).CrushAllies)
            If Heros(i).RamPower <> "" Then SB.WriteLine(vbTab & ".RamPower = " & Heros(i).RamPower)
            SB.WriteLine(vbTab & ".IsTrainable = " & Heros(i).IsTrainable.ToString)
            SB.WriteLine("End With")
            SB.WriteLine("")
        Next
        rtb.Text = SB.ToString
    End Sub
    Public Shared Sub UpdateGroup(ByVal Type As ObjectType)
        Select Case CurrentType
            Case ObjectType.Building
            Case ObjectType.Hero
            Case ObjectType.Unit
        End Select
    End Sub
    Function GetThingClass(ByVal Line As String) As ThingClass
        Select Case Line.TrimStart.TrimEnd.ToUpper
            Case "AUDIO"
                Return ThingClass.AUDIO
            Case "CAVALRY_UNIT"
                Return ThingClass.CAVALRY_UNIT
            Case "CHARACTER_UNIT"
                Return ThingClass.CHARACTER_UNIT
            Case "DEBRIS"
                Return ThingClass.DEBRIS
            Case "EMITTERS"
                Return ThingClass.EMITTERS
            Case "HORDE_UNIT"
                Return ThingClass.HORDE_UNIT
            Case "LARGE_MONSTER"
                Return ThingClass.LARGE_MONSTER
            Case "MACHINE"
                Return ThingClass.MACHINE
            Case "MEDIUM_MONSTER"
                Return ThingClass.MEDIUM_MONSTER
            Case "MISC_MAN_MADE"
                Return ThingClass.MISC_MAN_MADE
            Case "MISC_NATURAL"
                Return ThingClass.MISC_NATURAL
            Case "NONE"
                Return ThingClass.NONE
            Case "OBSOLETE"
                Return ThingClass.OBSOLETE
            Case "SELECTABLE"
                Return ThingClass.SELECTABLE
            Case "SHRUBBERY"
                Return ThingClass.SHRUBBERY
            Case "STRUCTURE"
                Return ThingClass.STRUCTUR
            Case "SYSTEM"
                Return ThingClass.SYSTEM
            Case "UNIT"
                Return ThingClass.UNIT
        End Select
    End Function
    Function GetRadarPriority(ByVal Line As String) As RadarPriority
        Select Case Line.TrimStart.TrimEnd.ToUpper
            Case "INVALID"
                Return RadarPriority.INVALID
            Case "NOT_ON_RADAR"
                Return RadarPriority.NOT_ON_RADAR
            Case "UNIT"
                Return RadarPriority.UNIT
            Case "STRUCTURE"
                Return RadarPriority.STRUCTUR
        End Select
    End Function
    Function NumSpaces(ByVal line As String) As Integer
        Dim Spaces As Integer
        For i As Integer = 0 To line.Length - 1
            If line.Substring(i, 1) = " " Then
                Spaces += 1
            End If
        Next
        Return Spaces
    End Function
    Sub GetFiles(ByVal FileRoot As String)
        Dim dir() As String
        Dim file() As String
        Dim En As Collections.IEnumerator
        dir = IO.Directory.GetDirectories(FileRoot)
        En = dir.GetEnumerator
        While En.MoveNext
            GetFiles(CStr(En.Current))
        End While
        file = IO.Directory.GetFiles(FileRoot)
        En = file.GetEnumerator
        While En.MoveNext
            OpenINI(CStr(En.Current))
        End While
    End Sub
    Sub Trim(ByRef line As String)
        Dim TrimLetters As String() = {"/", ";"}
        For i As Integer = 0 To TrimLetters.Length - 1
            If Contain(line, TrimLetters(i)) = True Then
                line = line.Substring(0, line.IndexOf(TrimLetters(i)))
            End If
        Next
    End Sub
    Function Contain(ByVal Line As String, ByVal Str As String) As String
        For i As Integer = 0 To Line.Length - Str.Length
            If Line.Substring(i, Str.Length).ToLower = Str.ToLower Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Shared Sub SetKindOfs(ByVal LstBox As ListBox, ByVal Type As ObjectType)
        Dim TempKindOf As String
        For i As Integer = 0 To LstBox.Items.Count - 1
            TempKindOf &= LstBox.Items(i) & " "
        Next
        MsgBox(TempKindOf)
        Exit Sub
        Select Case Type
            Case ObjectType.Building
                Buildings(CurrentBuildings).KindOf = TempKindOf.TrimEnd
            Case ObjectType.Hero
                Heros(CurrentHero).KindOf = TempKindOf.TrimEnd
            Case ObjectType.Unit
                Units(CurrentUnit).KindOf = TempKindOf.TrimEnd
        End Select
        UpdateGroup(Type)
    End Sub
#End Region

#Region " -=-Operations-=- "
    Private Sub btnOpenINI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenINI.Click
        Dim Location As String = InputBox("What is the File's Path?")
        If IO.File.Exists(Location) Then
            Application.DoEvents()
            OpenINI(Location)
            CodeInfo()
        Else
            MsgBox("File does not exist")
        End If
    End Sub
    Private Sub btnOpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFolder.Click
        Dim Location As String = InputBox("What is the Folder's Path?")
        If IO.Directory.Exists(Location) Then
            Application.DoEvents()
            GetFiles(Location)
            CodeInfo()
        Else
            MsgBox("Folder does not exist")
        End If
    End Sub
#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Kindofs As New KindOf(ObjectType.Unit, "PRELOAD SELECTABLE CAN_CAST_REFLECTIONS INFANTRY PATH_THROUGH_EACH_OTHER SCORE THROWN_OBJECT ATTACK_NEEDS_LINE_OF_SIGHT NOTIFY_OF_PREATTACK GRAB_AND_DROP")
        'IO.File.SetAttributes("f:\big\data\bfme2\data\ini\commandbutton.ini", IO.FileAttributes.Normal)
    End Sub
End Class
