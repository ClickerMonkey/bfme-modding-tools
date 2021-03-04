Public Class KindOf
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
    Friend WithEvents lstCurrent As System.Windows.Forms.ListBox
    Friend WithEvents lstAll As System.Windows.Forms.ListBox
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnDone As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Description = New System.Windows.Forms.Label
        Me.lstCurrent = New System.Windows.Forms.ListBox
        Me.lstAll = New System.Windows.Forms.ListBox
        Me.btnLeft = New System.Windows.Forms.Button
        Me.btnRight = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnDone = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(8, 8)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(320, 56)
        Me.Description.TabIndex = 0
        Me.Description.Text = "The ones on the right are the units current kindofs On the right are the remaing " & _
        "kindofs. Just click the two buttons to switch them around."
        Me.Description.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lstCurrent
        '
        Me.lstCurrent.HorizontalScrollbar = True
        Me.lstCurrent.IntegralHeight = False
        Me.lstCurrent.Location = New System.Drawing.Point(8, 64)
        Me.lstCurrent.Name = "lstCurrent"
        Me.lstCurrent.Size = New System.Drawing.Size(144, 208)
        Me.lstCurrent.TabIndex = 1
        '
        'lstAll
        '
        Me.lstAll.HorizontalScrollbar = True
        Me.lstAll.IntegralHeight = False
        Me.lstAll.Items.AddRange(New Object() {"NONE", "PRELOAD", "SELECTABLE", "CAN_CAST_REFLECTIONS", "PATH_THROUGH_EACH_OTHER", "SCORE", "THROWN_OBJECT", "DOZER", "NO_COLLIDE", "IGNORED_IN_GUI", "INFANTRY", "IMMOBILE", "ARCHER", "GRAB_AND_DROP", "ATTACK_NEEDS_LINE_OF_SIGHT", "CAVALRY", "STRUCTURE", "CHUNK_VENDOR", "NOT_AUTOACQUIRABLE", "PORTER", "IGNORES_SELECT_ALL", "HERO", "HOBBIT", "ROCK_VENDOR", "ARMY_SUMMARY", "MONSTER", "CAN_ATTACK", "WORKING_PASSENGER", "NO_FREEWILL_ENTER", "CLUB", "ROCK", "INFANTRY", "CAN_USE_SIEGE_TOWER", "WALK_ON_TOP_OF_WALL", "HULK", "MACHINE", "PROJECTILE", "CLEARED_BY_BUILD", "PATH_THROUGH_INFANTRY", "TRANSPORT", "SHRUBBERY", "NEED_BASE_FOUNDATION", "GARRISON", "GARRISONABLE_UNTIL_DESTROYED", "URUK", "CAN_BE_REPULSED", "AUTO_RALLYPOINT", "CASTLE_KEEP", "AIRCRAFT", "MOVE_ONLY", "UNATTACKABLE", "ENVIRONMENT", "HORDE", "MELEE_HORDE", "CAN_ATTACK_WALLS", "CAN_SEE_THROUGH_STRUCTURE", "NOTIFY_OF_PREATTACK", "BANNER", "COMBO_HORDE", "INERT_SHROUD_REVEALER", "OPTIMIZED_PROP", "BASE_FOUNDATION", "CASTLE_CENTER", "MP_COUNT_FOR_VICTORY", "BASE_SITE", "IGNORE_FOR_VICTORY", "NEVER_CULL_FOR_MP", "SUPPLY_GATHERING_CENTER", "FS_FACTORY", "FS_CASH_PRODUCER", "INDUSTRY_AFFECTED", "DEFENSIVE_WALL", "NONOCCLUDING", "BLOCKING_GATE", "WALL_SEGMENT", "SCALEABLE_WALL", "MADE_OF_STONE", "WALL_UPGRADE", "WALL_HUB", "MADE_OF_WOOD", "ALWAYS_VISIBLE", "HIDE_IF_FOGGED", "PARACHUTABLE", "WB_DISPLAY_SCRIPT_NAME", "OPTIMIZED_SOUND", "AMBIENTSOUND_KINDOF", "DOZER_FACTORY", "ALWAYS_SHOW_HOUSE_COLOR", "VITAL_FOR_BASE_SURVIVAL", "WALL_GATE", "CLICK_THROUGH", "SCARY", "FS_BASE_DEFENSE", "LINKED_TO_FLAG", "CREATE_A_HERO", "CAN_CLIMB_WALLS", "DO_NOT_CLASSIFY", "IGNORE_FOR_EVA_SPEECH_POSITION", "LARGE_RECTANGLE_PATHFIND", "PIKEMAN", "SUMMONED", "ORC", "FACE_AWAY_FROM_CASTLE_KEEP", "LIVING_WORLD_BUILDING_MIRROR", "BASE_DEFENSE_FOUNDATION", "MADE_OF_METAL", "COMMANDCENTER", "LIVING_WORLD_BUILDING_MIRROR", "ECONOMY_STRUCTURE", "MADE_OF_DIRT", "HAS_HEALTH_BAR", "CREEP", "WILD_HOLE_KINDOF", "ECONOMY_STRUCTURE", "TAINT", "CANNOT_RETALIATE", "CLEANUP_HAZARD", "SHIP", "PASS_EXPERIENCE_TO_CONTAINER", "SHIP_BATTLESHIP", "SHIP_BOMBARD", "SHIP_SUICIDE", "BIG_MONSTER", "MUMAKIL_BUFF_NUGGET", "BANNER", "SIEGEWEAPON", "CAN_RIDE_SIEGE_LADDER", "MINE_TRIGGER", "DEPLOYED_MINE", "SIEGE_TOWER", "SIEGE_LADDER", "CAN_RIDE_SIEGE_LADDER", "TROLL_BUFF_NUGGET", "GRAB_AND_DROP", "MOVE_FOR_NOONE", "MONSTER", "SWARM_DOZER", "HARVESTER", "GIANT_BIRD", "NONCOM", "DEFLECT_BY_SPECIAL_POWER", "OCL_BIT", "TAINTEFFECT", "WEBBED", "SUMMONED", "NO_FORMATION_MOVEMENT", "ARMY_OF_DEAD", "GARRISON", "GARRISONABLE_UNTIL_DESTROYED", "DWARVENRICHES_AFFECTED", "FS_TECHNOLOGY", "DONT_USE_CANCEL_BUILD_BUTTON", "GIMLI", "ARAGORN", "DISGUISER", "GANDALF", "DRAWABLE_ONLY", "SKYBOX", "TREE", "NATUREUNITS_KINDOF", "NO_BASE_CAPTURE", "CRITTER_EMITTER", "SALT_LICK", "CAPTURABLE", "CAPTUREFLAG", "TACTICAL_MARKER", "REBUILD_HOLE", "NEUTRALGOLLUM", "ORIENTS_TO_CAMERA", "THREAT_FINDER", "BUFF", "SPELL_BOOK", "BRIDGE", "NO_HEAL_ICON", "REVEAL_TO_ALL", "OATHBREAKER", "NEEDS_CASTLE_KINDOF", "CRATE"})
        Me.lstAll.Location = New System.Drawing.Point(184, 64)
        Me.lstAll.Name = "lstAll"
        Me.lstAll.Size = New System.Drawing.Size(144, 208)
        Me.lstAll.TabIndex = 2
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(160, 64)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(16, 24)
        Me.btnLeft.TabIndex = 3
        Me.btnLeft.Text = "<"
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(160, 96)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(16, 24)
        Me.btnRight.TabIndex = 4
        Me.btnRight.Text = ">"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(96, 277)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(136, 20)
        Me.btnDone.TabIndex = 5
        Me.btnDone.Text = "Done"
        '
        'KindOf
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 302)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.lstAll)
        Me.Controls.Add(Me.lstCurrent)
        Me.Controls.Add(Me.Description)
        Me.Name = "KindOf"
        Me.Text = "KindOf"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Shared ObjType As Form1.ObjectType
    Public Sub New(ByVal ObjType_ As Form1.ObjectType, ByVal KindOfs As String)
        MyBase.New()
        InitializeComponent()
        Dim Type As String
        Select Case ObjType_
            Case Form1.ObjectType.Building
                Type = "Building"
            Case Form1.ObjectType.Hero
                Type = "Hero"
            Case Form1.ObjectType.Unit
                Type = "Unit"
        End Select
        '<New Form>
        ObjType = ObjType_
        Description.Text = "The ones on the left are the " & Type & "s current KindOfs, On the right are the remaing KindOfs. Just click the two buttons to switch them around. To see what the KindOf means hold the mouse over it."
        SortLists(KindOfs)
        Me.Show()
        '</New Form>
    End Sub
    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        Dim TempStr As String = lstCurrent.SelectedItem
        lstCurrent.Items.RemoveAt(lstCurrent.SelectedIndex)
        lstAll.Items.Add(TempStr)
        lstCurrent.Sorted = True
        lstAll.Sorted = True
    End Sub
    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        Dim TempStr As String = lstAll.SelectedItem
        lstAll.Items.RemoveAt(lstAll.SelectedIndex)
        lstCurrent.Items.Add(TempStr)
        lstCurrent.Sorted = True
        lstAll.Sorted = True
    End Sub
    Sub SortLists(ByVal KindOfs As String)
        Dim Spaces As String() = {"      ", "     ", "    ", "   ", "  "}
        KindOfs = KindOfs.Replace(vbTab, " ")
        For i As Integer = 0 To Spaces.Length - 1
            KindOfs = KindOfs.Replace(Spaces(i), " ")
        Next
        KindOfs = KindOfs.Replace(" ", vbCrLf)
        Dim TempTxtBox As New TextBox
        TempTxtBox.Text = KindOfs
        For i As Integer = 0 To TempTxtBox.Lines.Length - 1
            lstCurrent.Items.Add(TempTxtBox.Lines(i).TrimStart.TrimEnd)
        Next
        lstCurrent.Sorted = True
        lstAll.Sorted = True
        Exit Sub
        For i As Integer = 0 To lstCurrent.Items.Count - 2
            For ii As Integer = 0 To lstAll.Items.Count - 2
                If lstAll.Items.Item(ii) = lstCurrent.Items.Item(i) Then
                    lstAll.Items.RemoveAt(ii)
                End If
            Next
        Next
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Form1.SetKindOfs(lstCurrent, ObjType)
    End Sub
End Class
