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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lstTitle As System.Windows.Forms.ListBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents btnOpen As System.Windows.Forms.MenuItem
    Friend WithEvents btnSave As System.Windows.Forms.MenuItem
    Friend WithEvents btnExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents btnAdd As System.Windows.Forms.MenuItem
    Friend WithEvents btnDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents btnAbout As System.Windows.Forms.MenuItem
    Friend WithEvents Status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnFile As System.Windows.Forms.MenuItem
    Friend WithEvents btnNew As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSaveSameLocation As System.Windows.Forms.MenuItem
    Friend WithEvents btnInsert As System.Windows.Forms.MenuItem
    Friend WithEvents btnRecent As System.Windows.Forms.MenuItem
    Friend WithEvents btnRS0 As System.Windows.Forms.MenuItem
    Friend WithEvents btnRS1 As System.Windows.Forms.MenuItem
    Friend WithEvents btnRS2 As System.Windows.Forms.MenuItem
    Friend WithEvents btnRS3 As System.Windows.Forms.MenuItem
    Friend WithEvents txtStr As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents sep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnOpen2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnSave2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnSaveAs2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents sep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnAdd2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnDelete2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnInsert2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents sep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnMoveUp2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnMoveDown2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents sep4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnCopy2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnCredits2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnAbout2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnNew2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents sep5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents picT3A As System.Windows.Forms.PictureBox
    Friend WithEvents btnCopy As System.Windows.Forms.MenuItem
    Friend WithEvents btnCredits As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.lstTitle = New System.Windows.Forms.ListBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnFile = New System.Windows.Forms.MenuItem
        Me.btnOpen = New System.Windows.Forms.MenuItem
        Me.btnSaveSameLocation = New System.Windows.Forms.MenuItem
        Me.btnSave = New System.Windows.Forms.MenuItem
        Me.btnNew = New System.Windows.Forms.MenuItem
        Me.btnRecent = New System.Windows.Forms.MenuItem
        Me.btnRS0 = New System.Windows.Forms.MenuItem
        Me.btnRS1 = New System.Windows.Forms.MenuItem
        Me.btnRS2 = New System.Windows.Forms.MenuItem
        Me.btnRS3 = New System.Windows.Forms.MenuItem
        Me.btnExit = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.btnAdd = New System.Windows.Forms.MenuItem
        Me.btnInsert = New System.Windows.Forms.MenuItem
        Me.btnDelete = New System.Windows.Forms.MenuItem
        Me.btnCopy = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.btnAbout = New System.Windows.Forms.MenuItem
        Me.btnCredits = New System.Windows.Forms.MenuItem
        Me.Status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtStr = New System.Windows.Forms.TextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.sep1 = New System.Windows.Forms.ToolBarButton
        Me.btnOpen2 = New System.Windows.Forms.ToolBarButton
        Me.btnNew2 = New System.Windows.Forms.ToolBarButton
        Me.btnSave2 = New System.Windows.Forms.ToolBarButton
        Me.btnSaveAs2 = New System.Windows.Forms.ToolBarButton
        Me.sep2 = New System.Windows.Forms.ToolBarButton
        Me.btnAdd2 = New System.Windows.Forms.ToolBarButton
        Me.btnDelete2 = New System.Windows.Forms.ToolBarButton
        Me.btnInsert2 = New System.Windows.Forms.ToolBarButton
        Me.btnCopy2 = New System.Windows.Forms.ToolBarButton
        Me.sep3 = New System.Windows.Forms.ToolBarButton
        Me.btnMoveUp2 = New System.Windows.Forms.ToolBarButton
        Me.btnMoveDown2 = New System.Windows.Forms.ToolBarButton
        Me.sep4 = New System.Windows.Forms.ToolBarButton
        Me.btnCredits2 = New System.Windows.Forms.ToolBarButton
        Me.btnAbout2 = New System.Windows.Forms.ToolBarButton
        Me.sep5 = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.picT3A = New System.Windows.Forms.PictureBox
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTitle
        '
        Me.lstTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTitle.HorizontalScrollbar = True
        Me.lstTitle.IntegralHeight = False
        Me.lstTitle.Location = New System.Drawing.Point(8, 32)
        Me.lstTitle.Name = "lstTitle"
        Me.lstTitle.Size = New System.Drawing.Size(152, 312)
        Me.lstTitle.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(168, 32)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(272, 20)
        Me.txtTitle.TabIndex = 7
        Me.txtTitle.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtTitle, "This is the title of the string that you will reference in the ini.")
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnFile, Me.MenuItem5, Me.MenuItem8})
        '
        'btnFile
        '
        Me.btnFile.Index = 0
        Me.btnFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnOpen, Me.btnSaveSameLocation, Me.btnSave, Me.btnNew, Me.btnRecent, Me.btnExit})
        Me.btnFile.Text = "&File"
        '
        'btnOpen
        '
        Me.btnOpen.Index = 0
        Me.btnOpen.Text = "&Open "
        '
        'btnSaveSameLocation
        '
        Me.btnSaveSameLocation.Index = 1
        Me.btnSaveSameLocation.Text = "&Save"
        '
        'btnSave
        '
        Me.btnSave.Index = 2
        Me.btnSave.Text = "S&ave As.."
        '
        'btnNew
        '
        Me.btnNew.Index = 3
        Me.btnNew.Text = "&New"
        '
        'btnRecent
        '
        Me.btnRecent.Index = 4
        Me.btnRecent.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnRS0, Me.btnRS1, Me.btnRS2, Me.btnRS3})
        Me.btnRecent.Text = "Recent Files.."
        '
        'btnRS0
        '
        Me.btnRS0.Index = 0
        Me.btnRS0.Text = "..."
        '
        'btnRS1
        '
        Me.btnRS1.Index = 1
        Me.btnRS1.Text = "..."
        '
        'btnRS2
        '
        Me.btnRS2.Index = 2
        Me.btnRS2.Text = "..."
        '
        'btnRS3
        '
        Me.btnRS3.Index = 3
        Me.btnRS3.Text = "..."
        '
        'btnExit
        '
        Me.btnExit.Index = 5
        Me.btnExit.Text = "&Exit"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnAdd, Me.btnInsert, Me.btnDelete, Me.btnCopy})
        Me.MenuItem5.Text = "&Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Index = 0
        Me.btnAdd.Text = "&Add String"
        '
        'btnInsert
        '
        Me.btnInsert.Index = 1
        Me.btnInsert.Text = "&Insert String"
        '
        'btnDelete
        '
        Me.btnDelete.Index = 2
        Me.btnDelete.Text = "&Delete Selected String"
        '
        'btnCopy
        '
        Me.btnCopy.Index = 3
        Me.btnCopy.Text = "&Copy String"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnAbout, Me.btnCredits})
        Me.MenuItem8.Text = "&Help"
        '
        'btnAbout
        '
        Me.btnAbout.Index = 0
        Me.btnAbout.Text = "&About"
        '
        'btnCredits
        '
        Me.btnCredits.Index = 1
        Me.btnCredits.Text = "&Credits"
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(0, 347)
        Me.Status.Name = "Status"
        Me.Status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.Status.ShowPanels = True
        Me.Status.Size = New System.Drawing.Size(448, 22)
        Me.Status.TabIndex = 8
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "Current String = "
        Me.StatusBarPanel1.Width = 110
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "Total String's Loaded = "
        Me.StatusBarPanel2.Width = 170
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "Last File Uploaded = "
        Me.StatusBarPanel3.Width = 200
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        '
        'txtStr
        '
        Me.txtStr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStr.Location = New System.Drawing.Point(168, 56)
        Me.txtStr.Multiline = True
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(272, 288)
        Me.txtStr.TabIndex = 4
        Me.txtStr.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtStr, "This is what the string contains.")
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.sep1, Me.btnOpen2, Me.btnNew2, Me.btnSave2, Me.btnSaveAs2, Me.sep2, Me.btnAdd2, Me.btnDelete2, Me.btnInsert2, Me.btnCopy2, Me.sep3, Me.btnMoveUp2, Me.btnMoveDown2, Me.sep4, Me.btnCredits2, Me.btnAbout2, Me.sep5})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(26, 26)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(448, 26)
        Me.ToolBar1.TabIndex = 9
        '
        'sep1
        '
        Me.sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnOpen2
        '
        Me.btnOpen2.ImageIndex = 4
        Me.btnOpen2.Tag = "open"
        '
        'btnNew2
        '
        Me.btnNew2.ImageIndex = 0
        Me.btnNew2.Tag = "new"
        '
        'btnSave2
        '
        Me.btnSave2.ImageIndex = 2
        Me.btnSave2.Tag = "save"
        '
        'btnSaveAs2
        '
        Me.btnSaveAs2.ImageIndex = 3
        Me.btnSaveAs2.Tag = "saveas"
        '
        'sep2
        '
        Me.sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnAdd2
        '
        Me.btnAdd2.ImageIndex = 8
        Me.btnAdd2.Tag = "add"
        '
        'btnDelete2
        '
        Me.btnDelete2.ImageIndex = 10
        Me.btnDelete2.Tag = "delete"
        '
        'btnInsert2
        '
        Me.btnInsert2.ImageIndex = 5
        Me.btnInsert2.Tag = "insert"
        '
        'btnCopy2
        '
        Me.btnCopy2.ImageIndex = 1
        Me.btnCopy2.Tag = "copy"
        '
        'sep3
        '
        Me.sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnMoveUp2
        '
        Me.btnMoveUp2.ImageIndex = 11
        Me.btnMoveUp2.Tag = "up"
        '
        'btnMoveDown2
        '
        Me.btnMoveDown2.ImageIndex = 9
        Me.btnMoveDown2.Tag = "down"
        '
        'sep4
        '
        Me.sep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnCredits2
        '
        Me.btnCredits2.ImageIndex = 6
        Me.btnCredits2.Tag = "credits"
        '
        'btnAbout2
        '
        Me.btnAbout2.ImageIndex = 7
        Me.btnAbout2.Tag = "about"
        '
        'sep5
        '
        Me.sep5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'picT3A
        '
        Me.picT3A.Image = CType(resources.GetObject("picT3A.Image"), System.Drawing.Image)
        Me.picT3A.Location = New System.Drawing.Point(320, 4)
        Me.picT3A.Name = "picT3A"
        Me.picT3A.Size = New System.Drawing.Size(96, 20)
        Me.picT3A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picT3A.TabIndex = 10
        Me.picT3A.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 369)
        Me.Controls.Add(Me.picT3A)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtStr)
        Me.Controls.Add(Me.lstTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "{IP}Gil-Galad's Str Editor (BFME2)"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " -=-Variables-=- "
    Enum Direction
        Up = 0
        Down = 1
    End Enum
    Public Structure RecentFile
        Dim FilePath As String
        Dim Filename As String
        Dim Loaded As Boolean
    End Structure
    Structure Str
        Dim Value As String
        Dim Name As String
        Dim Lines As Integer
    End Structure

    Dim ttlStrs As Integer = -1, CurrStr As Integer
    Dim Strs(1000) As Str
    Dim INILoaded As Boolean
    Dim RecentStr(3) As RecentFile
#End Region

#Region " -=-Functions and subs-=- "
    Sub OpenSTRFile(ByVal path As String)
        Dim sr As IO.StreamReader = IO.File.OpenText(path)
        Dim line() As String, CurrLine As Integer = -1
        Do While sr.Peek <> -1
            CurrLine += 1
            ReDim Preserve line(CurrLine)
            line(CurrLine) = sr.ReadLine
        Loop
        Dim II As Integer
        Dim str As String
        Dim lines As Integer
        For i As Integer = 0 To CurrLine
            If BeginsWith(line(i).TrimStart, Chr(34)) = True Then
                II = i - 1
                Do
                    II += 1
                    lines += 1
                    str &= line(II).TrimStart
                    If line(II).ToLower.EndsWith(Chr(34)) Then
                        Exit Do
                    End If
                Loop
                ttlStrs += 1
                Strs(ttlStrs) = New Str
                With Strs(ttlStrs)
                    .Value = str
                    .Name = line(i - 1)
                    .Lines = lines
                End With
                str = ""
                lines = 0
            End If
        Next
        For i As Integer = 0 To ttlStrs
            Strs(i).Value = Strs(i).Value.Replace("\n", vbCrLf).Replace(Chr(34), "").TrimStart
        Next
        sr.Close()
        ReloadStrs()
        Dim Filename As String = path.Substring(path.LastIndexOf("\") + 1)
        Status.Panels(2).Text = "Last File Uploaded = " & Filename
        Status.Panels(1).Text = "Total Strings Loaded = " & ttlStrs + 1
        Status.Panels(0).Text = "Current String = " & CurrStr + 1
    End Sub
    Sub OpenCSFFile(ByVal path As String)
        Dim sr As IO.StreamReader = IO.File.OpenText(path)
        Dim str As String
        Do While sr.Peek <> -1
            str &= sr.Read & vbCrLf
        Loop
        sr.Close()
        txtStr.Text = str
    End Sub
    Sub SaveSTRFile(ByVal path As String)
        Dim sw As IO.StreamWriter = IO.File.CreateText(path)
        Dim txtBox As New TextBox
        txtBox.Multiline = True
        For i As Integer = 0 To ttlStrs
            txtBox.Text = Strs(i).Value
            sw.WriteLine(Strs(i).Name)
            If txtBox.Lines.Length = 1 Then
                sw.WriteLine(Chr(34) & Strs(i).Value & Chr(34))
            ElseIf txtBox.Lines.Length > 1 Then
                sw.WriteLine(Chr(34) & txtBox.Lines(0) & " \n")
                If txtBox.Lines.Length > 2 Then
                    For ii As Integer = 1 To txtBox.Lines.Length - 2
                        If ii = txtBox.Lines.Length - 2 Then
                            Exit For
                        End If
                        sw.WriteLine(" " & txtBox.Lines(ii) & " \n")
                    Next
                End If
                sw.WriteLine(" " & txtBox.Lines(txtBox.Lines.Length - 1) & Chr(34))
            End If
            sw.WriteLine("END")
            sw.WriteLine()
        Next
        sw.Close()
        MsgBox("File created at:" & vbCrLf & path)
    End Sub
    Sub ReloadStrs()
        lstTitle.Items.Clear()
        For i As Integer = 0 To ttlStrs
            lstTitle.Items.Add(Strs(i).Name)
        Next
    End Sub
    Sub LoadStringOne()
        ttlStrs += 1
        Strs(ttlStrs) = New Str
        With Strs(ttlStrs)
            .Value = "Value"
            .Name = "String" & ttlStrs + 1
            .Lines = 1
        End With
        ReloadStrs()
    End Sub
    Sub LoadToolTips()
        btnOpen2.ToolTipText = "Open Str file" & vbCrLf & "[Ctrl + O]"
        btnSave2.ToolTipText = "Save Str file" & vbCrLf & "[Ctrl + S]"
        btnSaveAs2.ToolTipText = "Save As new file" & vbCrLf & "[Ctrl + Shift + S]"
        btnNew2.ToolTipText = "Start New" & vbCrLf & "[Ctrl + N]"
        btnAdd2.ToolTipText = "Add String" & vbCrLf & "[Ctrl + Z]"
        btnInsert2.ToolTipText = "Insert String" & vbCrLf & "[Ctrl + V]"
        btnCopy2.ToolTipText = "Copy String" & vbCrLf & "[Ctrl + C]"
        btnDelete2.ToolTipText = "DeleteString" & vbCrLf & "[Ctrl + X]"
        btnAbout2.ToolTipText = "About Str Editor"
        btnCredits2.ToolTipText = "Credits"
        btnMoveDown2.ToolTipText = "Move Selected Str Up" & vbCrLf & "[Ctrl + Up]"
        btnMoveUp2.ToolTipText = "Move Selected Str Down" & vbCrLf & "[Ctrl + Down]"
    End Sub
    Sub SaveRecentFiles()
        For i As Integer = 0 To 3
            SaveSetting("Str Edittor", "Form1", "RS" & i & ",00", RecentStr(i).Filename)
            SaveSetting("Str Edittor", "Form1", "RS" & i & ",11", RecentStr(i).FilePath)
            SaveSetting("Str Edittor", "Form1", "RS" & i & ",22", RecentStr(i).Loaded)
        Next
    End Sub
    Sub LoadRecentFiles()
        For i As Integer = 0 To 3
            RecentStr(i).Filename = GetSetting("Str Edittor", "Form1", "RS" & i & ",00", RecentStr(i).Filename)
            RecentStr(i).FilePath = GetSetting("Str Edittor", "Form1", "RS" & i & ",11", RecentStr(i).FilePath)
            RecentStr(i).Loaded = GetSetting("Str Edittor", "Form1", "RS" & i & ",22", RecentStr(i).Loaded.ToString)
        Next
        btnRS0.Text = RecentStr(0).Filename
        btnRS1.Text = RecentStr(1).Filename
        btnRS2.Text = RecentStr(2).Filename
        btnRS3.Text = RecentStr(3).Filename
    End Sub
    Sub AddRecentFile(ByVal path As String)
        RecentStr(3) = RecentStr(2)
        RecentStr(2) = RecentStr(1)
        RecentStr(1) = RecentStr(0)
        RecentStr(0).FilePath = path
        RecentStr(0).Filename = path.Substring(path.LastIndexOf("\") + 1)
        RecentStr(0).Loaded = True
        btnRS0.Text = RecentStr(0).FilePath
        btnRS1.Text = RecentStr(1).FilePath
        btnRS2.Text = RecentStr(2).FilePath
        btnRS3.Text = RecentStr(3).FilePath
    End Sub
    Sub DeleteStr(ByVal Position As Integer)
        Dim temp As Str = Strs(Position + 1)
        For i As Integer = Position To ttlStrs - 1
            Strs(i) = Strs(i + 1)
        Next
        ttlStrs -= 1
        ReloadStrs()
    End Sub
    Sub MoveStr(ByVal direction As Direction)
        Select Case direction
            Case direction.Down
                If CurrStr <= ttlStrs - 1 Then
                    MoveStr(CurrStr, CurrStr + 1)
                    lstTitle.SetSelected(CurrStr + 1, True)
                End If
            Case direction.Up
                If CurrStr >= 1 Then
                    MoveStr(CurrStr, CurrStr - 1)
                    lstTitle.SetSelected(CurrStr - 1, True)
                End If
        End Select
    End Sub
    Sub MoveStr(ByVal index1 As Integer, ByVal index2 As Integer)
        Dim StartingPoint, EndingPoint As Integer
        Dim Down As Boolean
        If index1 > index2 Then
            Down = False
            EndingPoint = index1 : StartingPoint = index2
        ElseIf index1 < index2 Then
            Down = True
            EndingPoint = index2 : StartingPoint = index1
        ElseIf index1 = index2 Then
            Exit Sub
        End If
        If Down = True Then
            Dim Tempstr As Str = Strs(StartingPoint)
            For i As Integer = StartingPoint To EndingPoint - 1
                Strs(i) = Strs(i + 1)
            Next
            Strs(EndingPoint) = Tempstr
            ReloadStrs()
        End If
        If Down = False Then
            Dim Tempstr As Str = Strs(EndingPoint)
            Dim Increment As Integer = EndingPoint - StartingPoint
            For i As Integer = StartingPoint To EndingPoint - 1
                Strs(i + Increment) = Strs(i + Increment - 1)
                Increment -= 2
            Next
            Strs(StartingPoint) = Tempstr
            ReloadStrs()
        End If
    End Sub
    Sub CopyStr(ByVal selected As Integer)
        ttlStrs += 1
        Strs(ttlStrs) = New Str
        With Strs(ttlStrs)
            .Name = "String" & ttlStrs + 1
            .Value = "Value"
            .Lines = 1
        End With
        Dim Increment As Integer = ttlStrs - selected
        For i As Integer = selected To ttlStrs - 1
            Strs(i + Increment) = Strs(i + Increment - 1)
            Increment -= 2
        Next
        Strs(selected) = Strs(selected + 1)
        ReloadStrs()
        lstTitle.SetSelected(CurrStr, True)
        Status.Panels(0).Text = "Current String = " & CurrStr + 1
        Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
    End Sub
    Sub InsertStr(ByVal selected As Integer)
        ttlStrs += 1
        Strs(ttlStrs) = New Str
        With Strs(ttlStrs)
            .Name = "String" & ttlStrs + 1
            .Value = "Value"
            .Lines = 1
        End With
        Dim Increment As Integer = ttlStrs - selected
        For i As Integer = selected To ttlStrs - 1
            Strs(i + Increment) = Strs(i + Increment - 1)
            Increment -= 2
        Next
        Strs(selected) = New Str
        With Strs(selected)
            .Name = "String" & ttlStrs + 1
            .Value = "Value"
            .Lines = 1
        End With
        ReloadStrs()
        lstTitle.SetSelected(CurrStr, True)
        Status.Panels(0).Text = "Current String = " & CurrStr + 1
        Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
    End Sub
    Function BeginsWith(ByVal str As String, ByVal character As String) As Boolean
        If str.StartsWith(character) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function EndsWith(ByVal str As String, ByVal character As String) As Boolean
        For i As Integer = 0 To str.Length - character.Length
            If str.Substring(i, character.Length) = character Then
                Return True
            End If
        Next
        Return False
    End Function
    Function EmptyLines(ByVal Filepath As String) As String
        Dim File As String
        Dim sr As IO.StreamReader = IO.File.OpenText(Filepath)
        Dim line As String
        Do While sr.Peek <> -1
            line = sr.ReadLine
            If line.TrimEnd.TrimStart <> "" Then
                File &= line & vbCrLf
            End If
        Loop
        sr.Close()
        Return File
    End Function
    Function GetLines(ByVal str As String) As Integer
        Dim line As String
        Dim sr As New IO.StringReader(str)
        Do While sr.Peek <> -1
            line &= "0"
        Loop
        sr.Close()
        Return line.Length
    End Function
    Function GetCurrFile() As String
        If OpenFileDialog1.FileName <> "" Then
            Return OpenFileDialog1.FileName
        ElseIf SaveFileDialog1.FileName <> "" Then
            Return SaveFileDialog1.FileName
        End If
    End Function
    Function DrawBackground(ByVal clr1 As Color, ByVal clr2 As Color, ByVal lgm As System.Drawing.Drawing2D.LinearGradientMode) As Bitmap
        Dim bm As New Bitmap(Me.Width, Me.Height)
        Dim gr As Graphics = Graphics.FromImage(bm)
        Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim br As New System.Drawing.Drawing2D.LinearGradientBrush(rec, clr1, clr2, lgm)
        gr.FillRectangle(br, rec)
        Return bm
    End Function
#End Region

#Region " -=-Main Operations-=- "
    Private Sub txtStr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStr.TextChanged
        Try
            If Not ttlStrs <= 0 Then
                Strs(CurrStr).Lines = txtStr.Lines.Length + 1
                Strs(CurrStr).Value = txtStr.Text
                txtStr.Text = Strs(CurrStr).Value
                txtTitle.Text = Strs(CurrStr).Name
                lstTitle.SetSelected(CurrStr, True)
                Status.Panels(0).Text = "Current String = " & CurrStr + 1
                Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
            End If
        Catch ex As Exception
            MsgBox("Couldnt save string")
        End Try
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTitle.SelectedIndexChanged
        Try
            If Not ttlStrs <= 0 Then
                CurrStr = lstTitle.SelectedIndex
                txtStr.Text = Strs(CurrStr).Value
                txtTitle.Text = Strs(CurrStr).Name
                Status.Panels(0).Text = "Current String = " & CurrStr + 1
                Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
            End If
        Catch ex As Exception
            MsgBox("Select another item")
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadStringOne()
        If lstTitle.Items.Count > 0 Then
            lstTitle.SetSelected(0, True)
        End If
        txtTitle.Text = Strs(CurrStr).Name
        txtStr.Text = Strs(CurrStr).Value
        Status.Panels(0).Text = "Current String = " & CurrStr + 1
        Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
        LoadToolTips()
    End Sub
    Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.TextChanged
        Try
            If Not ttlStrs <= 0 Then
                Strs(CurrStr).Name = txtTitle.Text
                lstTitle.SetSelected(CurrStr, True)
                Status.Panels(0).Text = "Current String = " & CurrStr + 1
                Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtTitle_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.LostFocus
        Try
            If Not ttlStrs <= 0 Then
                If Not lstTitle.Items.Item(CurrStr) = txtTitle.Text Then
                    ReloadStrs()
                    lstTitle.SetSelected(CurrStr, True)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub picT3A_Clicked(ByVal sender As System.Object, ByVal e As EventArgs) Handles picT3A.Click
        Try
            Dim IE As New SHDocVw.InternetExplorer
            IE.Visible = True
            IE.Navigate("www.the3rdage.net")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub lstTitle_MouseMove(ByVal sender As Object, ByVal e As System.windows.Forms.MouseEventArgs) Handles lstTitle.MouseMove
        If ttlStrs <> -1 Then
            ToolTip1.SetToolTip(lstTitle, Strs(CurrStr).Name & " =" & vbCrLf & Strs(CurrStr).Value)
        End If
    End Sub
    Sub OpenStrEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadRecentFiles()
        Catch ex As Exception
            MsgBox("Could not load recent files.")
        End Try
    End Sub
    Sub SaveStrEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            SaveRecentFiles()
        Catch ex As Exception
            MsgBox("Could not save recent files.")
        End Try
    End Sub
#End Region

#Region " -=-Menu Items-=- "
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        With OpenFileDialog1
            .InitialDirectory = Application.StartupPath
            .Filter = "Str Files (*.str)|*.str|Csf Files (*.csf)|*.csf|All Files (*.*)|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    Select Case .FileName.Substring(.FileName.LastIndexOf(".") + 1).ToLower
                        Case "csf"
                            MsgBox("CSF Files are not yet supported")
                            'OpenCSFFile(.FileName)
                        Case "str"
                            INILoaded = True
                            OpenSTRFile(.FileName)
                            AddRecentFile(.FileName)
                            btnSaveSameLocation.Text = "Save " & RecentStr(0).Filename
                        Case "txt"
                            INILoaded = True
                            OpenSTRFile(.FileName)
                            AddRecentFile(.FileName)
                        Case Not "csf", "str", "txt"
                            MsgBox("Invalid File Type:" & vbCrLf & "Must be a Txt file, Csf File or Str File")
                    End Select
                    lstTitle.SetSelected(CurrStr, True)
                Catch ex As Exception
                    MsgBox("Couldnt load file, try again")
                End Try
            End If
        End With
    End Sub
    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        With SaveFileDialog1
            .Filter = "Str Files (*.str)|*.str" '|Csf Files (*.csf)|*.csf"
            .FilterIndex = 1
            .RestoreDirectory = True
            .InitialDirectory = Application.StartupPath
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                INILoaded = True
                Try
                    SaveSTRFile(.FileName)
                    lstTitle.SetSelected(CurrStr, True)
                Catch ex As Exception
                    MsgBox("Couldnt save file, try again")
                End Try
            End If
        End With
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            Select Case MsgBox("This will erase all strings are you sure you want to start anew?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    For i As Integer = 0 To 1000
                        Strs(i) = Nothing
                    Next
                    ttlStrs = -1
                    CurrStr = 0
                    lstTitle.Items.Clear()
                    Status.Panels(0).Text = "Current String = " & CurrStr + 1
                    Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
                    Status.Panels(2).Text = "Last File Uploaded = "
                    LoadStringOne()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Select Case MsgBox("Are you sure you want to leave?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Me.Close()
        End Select
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            ttlStrs += 1
            Strs(ttlStrs) = New Str
            With Strs(ttlStrs)
                .Value = "Value"
                .Name = "String" & ttlStrs + 1
                .Lines = 1
            End With
            CurrStr = ttlStrs
            ReloadStrs()
            lstTitle.SetSelected(CurrStr, True)
            Status.Panels(0).Text = "Current String = " & CurrStr + 1
            Status.Panels(1).Text = "Total String's Loaded = " & ttlStrs + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If ttlStrs <> -1 Then
                lstTitle.SetSelected(CurrStr, True)
                Dim SelectedItem As Integer = lstTitle.SelectedIndex
                If lstTitle.SelectedIndex < ttlStrs Then
                    DeleteStr(CurrStr)
                    lstTitle.SetSelected(SelectedItem, True)
                ElseIf lstTitle.SelectedIndex = ttlStrs And ttlStrs <> 0 Then
                    lstTitle.SetSelected(SelectedItem - 1, True)
                    lstTitle.Items.RemoveAt(ttlStrs)
                    CurrStr = SelectedItem - 1
                    ttlStrs -= 1
                    ReloadStrs()
                    lstTitle.SetSelected(SelectedItem - 1, True)
                ElseIf ttlStrs = 0 Then
                    lstTitle.Items.RemoveAt(ttlStrs)
                    ttlStrs -= 1
                    txtTitle.Text = ""
                    txtStr.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        MsgBox("Created on December 17 2005" & vbCrLf & _
               "------------------------------------------------" & vbCrLf & _
               "Author: Phil, {IP}Gil-Galad" & vbCrLf & _
               vbCrLf & _
               "Made for modding BFME" & vbCrLf & _
               vbCrLf & _
               "Contact Me:" & vbCrLf & _
               "Msn:Freaklotr4@yahoo.com" & vbCrLf & _
               "Email:Freaklotr4@yahoo.com" & vbCrLf & _
               "Aim:Freaklotr4" & vbCrLf & _
               vbCrLf & _
               "Str Editor " & Chr(153) & vbCrLf & _
               "------------------------------------------------", MsgBoxStyle.OKOnly.Information, "Str Editor")
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, txtTitle.KeyDown, lstTitle.KeyDown, txtStr.KeyDown
        If e.KeyCode = Keys.O And e.Control Then btnOpen_Click(sender, e)
        If e.KeyCode = Keys.S And e.Control Then btnSave_Click(sender, e)
        If e.KeyCode = Keys.S And e.Control And e.Shift Then btnSaveAs_Click(sender, e)
        If e.KeyCode = Keys.N And e.Control Then btnNew_Click(sender, e)
        If e.KeyCode = Keys.Z And e.Control Then btnAdd_Click(sender, e)
        If e.KeyCode = Keys.X And e.Control Then btnDelete_Click(sender, e)
        If e.KeyCode = Keys.C And e.Control Then btnCopy_Click(sender, e)
        If e.KeyCode = Keys.V And e.Control Then btnInsert_Click(sender, e)
        If e.KeyCode = Keys.Up And e.Control Then MoveStr(Direction.Up)
        If e.KeyCode = Keys.Down And e.Control Then MoveStr(Direction.Down)
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSameLocation.Click
        Try
            If INILoaded = True Then
                SaveSTRFile(GetCurrFile)
                lstTitle.SetSelected(CurrStr, True)
            Else
                MsgBox("Cannot do save, first you must Save as")
            End If
        Catch ex As Exception
            MsgBox("Couldnt save file, try again")
        End Try
    End Sub
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            InsertStr(CurrStr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredits.Click
        MsgBox("Created on December 17 2005" & vbCrLf & _
               "------------------------------------------------" & vbCrLf & _
               "Author: Phil, {IP}Gil-Galad" & vbCrLf & _
               vbCrLf & _
               "Made for modding BFME" & vbCrLf & _
               vbCrLf & _
               "Contact Me:" & vbCrLf & _
               "Msn:Freaklotr4@yahoo.com" & vbCrLf & _
               "Email:Freaklotr4@yahoo.com" & vbCrLf & _
               "Aim:Freaklotr4" & vbCrLf & _
               vbCrLf & _
               "Str Editor " & Chr(153) & vbCrLf & _
               "------------------------------------------------", MsgBoxStyle.OKOnly.Information, "Str Editor")
    End Sub
    Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            CopyStr(CurrStr)
        Catch ex As Exception
            MsgBox("Error Copying Str")
        End Try
    End Sub
    Private Sub btnRS0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRS0.Click
        If IO.File.Exists(RecentStr(0).FilePath) Then
            Try
                OpenSTRFile(RecentStr(0).FilePath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnRS1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRS1.Click
        If IO.File.Exists(RecentStr(1).FilePath) Then
            Try
                OpenSTRFile(RecentStr(1).FilePath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnRS2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRS2.Click
        If IO.File.Exists(RecentStr(2).FilePath) Then
            Try
                OpenSTRFile(RecentStr(2).FilePath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnRS3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRS3.Click
        If IO.File.Exists(RecentStr(3).FilePath) Then
            Try
                OpenSTRFile(RecentStr(3).FilePath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.Tag
            Case "save"
                btnSave_Click(sender, e)
            Case "open"
                btnOpen_Click(sender, e)
            Case "new"
                btnNew_Click(sender, e)
            Case "saveas"
                btnSaveAs_Click(sender, e)

            Case "delete"
                btnDelete_Click(sender, e)
            Case "add"
                btnAdd_Click(sender, e)
            Case "insert"
                btnInsert_Click(sender, e)
            Case "copy"
                btnCopy_Click(sender, e)

            Case "up"
                MoveStr(Direction.Up)
            Case "down"
                MoveStr(Direction.Down)

            Case "about"
                btnAbout_Click(sender, e)
            Case "credits"
                btnCredits_Click(sender, e)
        End Select
    End Sub
#End Region

#Region " -=-Drag Drop-=- "
    Dim InitIndex, FinIndex As Integer
    Private Sub lstTitle_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTitle.MouseUp
        Try
            FinIndex = lstTitle.SelectedIndex
            MoveStr(InitIndex, FinIndex)
            lstTitle.SetSelected(FinIndex, True)
            Me.Text = "{IP}Gil-Galad's Str Editor (BFME2)"
        Catch ex As Exception
            MsgBox("Error Dragging")
        End Try
    End Sub
    Private Sub lstTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTitle.MouseDown
        InitIndex = lstTitle.SelectedIndex
        Me.Text = "{IP}Gil-Galad's Str Editor (BFME2)-Dragging Str..."
    End Sub
#End Region

End Class
