Public Class Form1
    Private WithEvents CurrentTab As TabControl
    Private ClipBoardAttached As Boolean = True
    Private NewPages As Integer
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MsgBox("Are you sure you want to leave?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.No
                e.Cancel = True
            Case MsgBoxResult.Yes
                SaveLastOpenedFiles()
        End Select
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RestoreOpenedFiles()
        AddHandler ClipBoard.ObjectPaste, AddressOf ClipBoardObjectPaste
    End Sub
    Private Sub TabManager_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabManager.Selecting
        If e.Action = TabControlAction.Selecting Then
            If e.TabPageIndex <> -1 Then
                CurrentTab = e.TabPage
                stCurrent.Text = CurrentTab.Text
            End If
        End If
    End Sub
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        With OpenFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                For Each S As String In .FileNames
                    Dim NewFile As New TabControl(S.Substring(S.LastIndexOf("\") + 1), S)
                    NewFile.LoadFile(S)
                    TabManager.TabPages.Add(NewFile)
                    CurrentTab = NewFile
                Next
            End If
        End With
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim NewFile As New TabControl("newini" & NewPages + 1 & ".ini", "")
        TabManager.TabPages.Add(NewFile)
        CurrentTab = NewFile
        stCurrent.Text = "newini" & NewPages & ".ini"
        NewPages += 1
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not (CurrentTab Is Nothing) Then
            If CurrentTab.FileSaved Then
                CurrentTab.SaveFile(CurrentTab.LastFile)
            Else
                btnSaveAs_Click(btnSaveAs, Nothing)
            End If
        End If
    End Sub
    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAs.Click
        With SaveFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not (CurrentTab Is Nothing) Then
                    CurrentTab.SaveFile(.FileName)
                Else
                    MsgBox("Cannot save a non-existent File")
                End If
            End If
        End With
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub TabUpdated() Handles CurrentTab.TabUpdateBar
        If Not (CurrentTab Is Nothing) Then
            stLine.Text = "Line: " & CurrentTab.RichTextLine
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If Not (CurrentTab Is Nothing) Then
            Select Case MsgBox("Are you sure you want to close " & CurrentTab.Text & " without saving?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    TabManager.Controls.Remove(CurrentTab)
                Case MsgBoxResult.No
                    btnSave_Click(btnSave, Nothing)
                    TabManager.Controls.Remove(CurrentTab)
            End Select
            If TabManager.Controls.Count = 0 Then
                CurrentTab = Nothing
            End If
        Else
            MsgBox("No tabpages to remove!")
        End If
    End Sub
    Private Sub SaveLastOpenedFiles()
        Dim Files As String = ""
        For Each TC As TabControl In TabManager.TabPages
            Files &= TC.Source & "@"
        Next
        SaveSetting("INI Editor", "OpenedFiles", "Files", Files)
    End Sub
    Private Sub RestoreOpenedFiles()
        Dim Files As String = ""
        Files = GetSetting("INI Editor", "OpenedFiles", "Files")
        If Files <> "" Then
            Dim INIS() As String = Files.Substring(0, Files.Length - 1).Split("@")
            For Each S As String In INIS
                Dim NewFile As New TabControl(S.Substring(S.LastIndexOf("\") + 1), S)
                NewFile.LoadFile(NewFile.Source)
                TabManager.TabPages.Add(NewFile)
                CurrentTab = NewFile
            Next
        End If
        If Not (CurrentTab Is Nothing) Then
            stCurrent.Text = CurrentTab.Text
        End If
    End Sub
    Private Sub ClipBoardObjectPaste()
        lyClipboard.RowStyles.Add(New RowStyle)
        lyClipboard.Controls.Add(New ClipBoardTextBox(ClipBoard.Board.Item(ClipBoard.Board.Count - 1), lyClipboard.Width - 6))
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lyClipboard.Controls.Clear()
        lyClipboard.RowStyles.Clear()
        lyClipboard.RowStyles.Add(New RowStyle)
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        For Each CBTB As ClipBoardTextBox In lyClipboard.Controls
            If CBTB.Selected Then
                ClipBoard.Delete(CBTB.Text)
                lyClipboard.RowStyles.Remove(New RowStyle)
                lyClipboard.Controls.Remove(CBTB)
                Return
            End If
        Next
    End Sub
    Private Sub btnToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggle.Click
        ClipBoardAttached = Not ClipBoardAttached
        If ClipBoardAttached Then
            TabManager.Anchor = AnchorStyles.Left Or AnchorStyles.Top
            Me.ClientSize = New Size(Me.ClientSize.Width + 185, Me.ClientSize.Height)
            TabManager.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
            lyClipboard.Location = New Point(Me.ClientSize.Width - 152, 50)
            lyClipboard.Size = New Size(146, Me.ClientSize.Height - 77)
            lyClipboard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
            pnlOptions.Anchor = AnchorStyles.Right Or AnchorStyles.Top
            pnlOptions.Location = New Point(Me.ClientSize.Width - 152, 27)
        Else
            lyClipboard.Anchor = AnchorStyles.None
            lyClipboard.Location = New Point(Me.ClientSize.Width, 50)
            pnlOptions.Anchor = AnchorStyles.None
            pnlOptions.Location = New Point(Me.ClientSize.Width, 27)
            TabManager.Anchor = AnchorStyles.Left Or AnchorStyles.Top
            Me.ClientSize = New Size(Me.ClientSize.Width - 185, Me.ClientSize.Height)
            TabManager.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
            lyClipboard.Anchor = AnchorStyles.Right
            pnlOptions.Anchor = AnchorStyles.Right
        End If
    End Sub
    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        If Not (CurrentTab Is Nothing) Then
            With FontDialog1
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    CurrentTab.SetFont(.Font)
                End If
            End With
        End If
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

    End Sub
    Private Sub btnGoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoto.Click
        If Not (CurrentTab Is Nothing) Then
            Dim LineNumber As Integer
            Try
                LineNumber = InputBox("Line to go to (Max = " & CurrentTab.MaxLines & ")")
            Catch ex As Exception
                MsgBox(LineNumber & " is not a valid line number")
            End Try
        End If
    End Sub
    Private Sub btnHighlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighlight.Click
        If Not (CurrentTab Is Nothing) Then
            Dim Word As String
            Word = InputBox("Word to Highlight")
            CurrentTab.Highlight(Word)
        End If
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Not (CurrentTab Is Nothing) Then
            CurrentTab.SelectAll()
        End If
    End Sub
    Private Sub btnThirdAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThirdAge.Click
        MsgBox("The3rdage.net is a modding resource site dedicated to teaching and exploring new levels of modding." & vbCrLf & _
        "To get more programs like this visit the Tool section of their site." & vbCrLf & "Program By Phil '{IP}Gil-Galad'", MsgBoxStyle.Information, "www.the3rdage.net")
    End Sub
    Private Sub btnUnHighlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnHighlight.Click
        If Not (CurrentTab Is Nothing) Then
            Dim Word As String
            Word = InputBox("Word to UnHighlight")
            CurrentTab.UnHighlight(Word)
        End If
    End Sub
End Class
Public Class TabControl
    Inherits TabPage
    Public Event TabUpdateBar()
    Private WithEvents RichText As RichText
    Private Selected As Boolean
    Public FileSaved As Boolean
    Public LastFile As String
    Public Source As String
    Public Sub New(ByVal Name As String, ByVal Source As String)
        Me.Text = Name
        Me.RichText = New RichText(6, 6, Width - 14, Height - 13)
        Me.Controls.Add(RichText)
        Me.Source = Source
    End Sub
    Public ReadOnly Property FocusedTab() As Boolean
        Get
            Return Selected
        End Get
    End Property
    Public Sub LoadFile(ByVal FilePath As String)
        If IO.File.Exists(FilePath) Then
            Try
                RichText.LoadINI(FilePath)
            Catch ex As Exception
                MsgBox("Error loading file: More Info:" & vbCrLf & vbCrLf & ex.Message)
            End Try
        Else
            MsgBox("File doesn't exist")
        End If
    End Sub
    Public Sub SaveFile(ByVal FilePath As String)
        Try
            RichText.SaveFile(FilePath, RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            MsgBox("Error saving file: More Info:" & vbCrLf & vbCrLf & ex.Message)
        End Try
        FileSaved = True
        LastFile = FilePath
    End Sub
    Private Sub TabControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Selected = True
    End Sub
    Private Sub TabControl_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Selected = False
    End Sub
    '//Texbox stuff
    Public Function RichTextLine() As Integer
        Return RichText.CurrentLine
    End Function
    Public Sub BarUpdated() Handles RichText.TextUpdateBar
        RaiseEvent TabUpdateBar()
    End Sub
    Public Sub Find(ByVal S As String)
        Dim C As Integer = RichText.SelectionStart + RichText.SelectionLength + 1 'currentpositon
        RichText.Find(S, C, RichTextBoxFinds.None)
    End Sub
    Public Sub Highlight(ByVal S As String)
        Dim Position, LastPosition As Integer
        RichText.SelectionStart = 0
        LastPosition = -1
        Do Until Position = LastPosition
            LastPosition = Position
            Position = RichText.SelectionStart + RichText.SelectionLength
            RichText.Find(S, Position, RichTextBoxFinds.None)
            RichText.SelectionBackColor = Color.LightGray
        Loop
        RichText.SelectionLength = 0
    End Sub
    Public Sub UnHighlight(ByVal S As String)
        Dim Position, LastPosition As Integer
        RichText.SelectionStart = 0
        LastPosition = -1
        Do Until Position = LastPosition
            LastPosition = Position
            Position = RichText.SelectionStart + RichText.SelectionLength
            RichText.Find(S, Position, RichTextBoxFinds.None)
            RichText.SelectionBackColor = Color.White
        Loop
        RichText.SelectionLength = 0
    End Sub
    Public Sub GotoLine(ByVal Line As Integer)
        RichText.Find(RichText.Lines(Line - 1), RichTextBoxFinds.NoHighlight)
    End Sub
    Public Function MaxLines() As Integer
        Return RichText.Lines.Length
    End Function
    Public Sub SelectAll()
        RichText.SelectAll()
    End Sub
    Public Sub SetFont(ByVal F As Font)
        RichText.Font = F
    End Sub
End Class
Public Class RichText
    Inherits RichTextBox
    Public Event TextUpdateBar()
    Public Sub New(ByVal X As Short, ByVal Y As Short, ByVal Width As Short, ByVal Height As Short)
        Me.Location = New Point(X, Y)
        Me.Size = New Size(Width, Height)
        Me.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top)
        Me.ContextMenu = New ContextMenu()
        Me.WordWrap = False
    End Sub
    Public ReadOnly Property CurrentLine() As Long
        Get
            Return Me.GetLineFromCharIndex(Me.SelectionStart) + 1
        End Get
    End Property
    Private Sub RichText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Enter Then
            Me.Find(Lines(CurrentLine - 1))
        End If
    End Sub
    Private Sub RichText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.C And e.Control = True Then
            ClipBoard.Paste(Me.SelectedText)
        End If
        If e.KeyCode = Keys.V And e.Control = True Then

        End If
        RaiseEvent TextUpdateBar()
    End Sub
    Private Sub RichText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenu.Show(Me, New Point(e.X, e.Y))
        End If
        RaiseEvent TextUpdateBar()
    End Sub
    Private Sub MenuClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim LineIndex As Integer = CType(sender, MenuItem).Tag
        Dim Line As String = Lines(LineIndex - 1)
        Me.SelectionStart = Me.Find(Line, RichTextBoxFinds.NoHighlight)
    End Sub
    Public Sub LoadINI(ByVal FilePath As String)
        ContextMenu.MenuItems.Clear()
        Dim SR As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim Line As String, LineCount As Integer
        Dim Parents() As String = {"AmbientStream", "Animation", "Armor", _
"ModifierList", "CommandButton", "CommandSet", "CrateData", "ChildObject", _
"Weapon", "DamageFX", "NewEvaEvent", "ExperienceLevel", "FXList", "FXParticleSystem", _
"#define", "Object", "ObjectCreationList", "ParticleSystem", "AudioEvent", _
"SpecialPower", "Upgrade", "Science", "ObjectReskin"}
        Dim ArrParents(Parents.Length - 1) As ArrayList
        For I As Integer = 0 To Parents.Length - 1
            ArrParents(I) = New ArrayList
        Next
        Do While SR.Peek <> -1
            Line = SR.ReadLine
            LineCount += 1
            For I As Integer = 0 To Parents.Length - 1
                If Line.StartsWith(Parents(I)) Then
                    If Line.IndexOf(" ") <> -1 Then
                        ArrParents(I).Add(Line.Substring(Line.IndexOf(" ")))
                        ArrParents(I).Add(LineCount)
                    End If
                End If
            Next
            Text &= Line & vbCrLf
        Loop
        Dim TotalLoaded As Integer
        For I As Integer = 0 To Parents.Length - 1
            If ArrParents(I).Count <> 0 Then
                Dim Parent As New MenuItem(Parents(I))
                For II As Integer = 0 To ArrParents(I).Count - 1 Step 2
                    TotalLoaded += 1
                    If TotalLoaded = 200 Then Exit Sub
                    Dim Child As New MenuItem(ArrParents(I)(II) & ", Line " & ArrParents(I)(II + 1))
                    AddHandler Child.Click, AddressOf MenuClick
                    Child.Tag = ArrParents(I)(II + 1)
                    Parent.MenuItems.Add(Child)
                Next
                ContextMenu.MenuItems.Add(Parent)
            End If
        Next
    End Sub
End Class
Public Class ClipBoard
    Public Shared Event ObjectPaste()
    Public Shared Board As New ArrayList
    Public Shared Sub Paste(ByVal S As String)
        Board.Add(S)
        RaiseEvent ObjectPaste()
    End Sub
    Public Shared Sub Delete(ByVal S As String)
        Board.Remove(S)
    End Sub
    Public Shared Sub Clear()
        Board = New ArrayList
    End Sub
End Class
Public Class ClipBoardTextBox
    Inherits TextBox
    Public Selected As Boolean
    Public Sub New(ByVal Text As String, ByVal Width As Short)
        Me.Text = Text
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Dim Height As Single = (Me.Lines.Length + 1) * Me.Font.Height
        Me.Size = New Size(Width, Height)
        Me.Multiline = True
        Me.AcceptsTab = True
    End Sub
    Private Sub ClipBoardTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Selected = True
    End Sub
    Private Sub ClipBoardTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        e.Handled = True
    End Sub
    Private Sub ClipBoardTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Selected = False
    End Sub
End Class

Public Class INIConverter
    Private Structure Modules
        Public Name, Tag, Info As String
    End Structure
    Public aModule As ArrayList

End Class