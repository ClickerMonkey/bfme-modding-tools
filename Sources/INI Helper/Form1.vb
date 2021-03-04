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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContxtMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents progress As System.Windows.Forms.ProgressBar
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents TabCon As System.Windows.Forms.TabControl
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ContxtMenu = New System.Windows.Forms.ContextMenu
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.progress = New System.Windows.Forms.ProgressBar
        Me.status = New System.Windows.Forms.StatusBar
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.TabCon = New System.Windows.Forms.TabControl
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'ContxtMenu
        '
        '
        'ToolBar1
        '
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(25, 25)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(584, 31)
        Me.ToolBar1.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'progress
        '
        Me.progress.Location = New System.Drawing.Point(440, 500)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(125, 16)
        Me.progress.TabIndex = 2
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(0, 475)
        Me.status.Name = "status"
        Me.status.ShowPanels = True
        Me.status.Size = New System.Drawing.Size(584, 22)
        Me.status.TabIndex = 3
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem17, Me.MenuItem21})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem16, Me.MenuItem8, Me.MenuItem7, Me.MenuItem9, Me.MenuItem10, Me.MenuItem11})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15})
        Me.MenuItem2.Text = "&Edit"
        '
        'TabCon
        '
        Me.TabCon.Location = New System.Drawing.Point(0, 32)
        Me.TabCon.Name = "TabCon"
        Me.TabCon.SelectedIndex = 0
        Me.TabCon.Size = New System.Drawing.Size(584, 448)
        Me.TabCon.TabIndex = 4
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "&Undo"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "&New"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "&Open File"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "O&pen Folder"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "&Save.."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 6
        Me.MenuItem9.Text = "Save &As"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 8
        Me.MenuItem11.Text = "&Exit.."
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "&Redo"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "&Find.."
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "R&eplace.."
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "&Goto.."
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Text = "&Close File"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem19})
        Me.MenuItem17.Text = "&Help"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Text = "&About"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Text = "&Credits"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 3
        Me.MenuItem21.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem20, Me.MenuItem22})
        Me.MenuItem21.Text = "&Goto"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 0
        Me.MenuItem20.Text = "BFME Modding Programs"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "The 3rd Age"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 497)
        Me.Controls.Add(Me.TabCon)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.ToolBar1)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "{IP}Gil-Galad's Battle for Middle Earth INI Helper"
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " -=-Context Menu-=- "
    Private MenuItems As String() = {"&Object", "O&bjectReskin", "&ChildObject", "&Armor", "&Weapon", "&Locomotor", _
                                    "Co&mmandSet", "Comma&ndButton", "A&udioEvent", "&Particlesystem", "&FXParticleSystem", _
                                    "&Damagefx", "Mod&ifierlist", "Up&grade", "&Science", "Fxlis&t", "&EmotionNugget", _
                                    "Specialpo&wer", "Addmodule", "Replacemodule", "Removemodule", "ObjectCreationList", _
                                    "&Rank", "Roads", "PlayerTemplate", "DialogE&vent", "PlayerAIT&ype", "Cratedata"}
    Private KeyWords As String() = {"object", "objectreskin", "childobject", "armor", "weapon", "locomotor", _
                                "commandset", "commandbutton", "audioevent", "particlesystem", "fxparticlesystem", _
                                "damagefx", "modifierlist", "upgrade", "science", "fxlist", "emotionnugget", _
                                "specialpower", "addmodule", "replacemodule", "removemodule", "objectcreationlist", _
                                "rank", "roads", "playertemplate", "dialogevent", "playeraitype", "cratedata"}
    Private WordsFind(,) As String
    Sub LoadContext()
        Dim ln As String
        For i As Integer = 0 To rtb.Lines.Length - 1
            ln = rtb.Lines(i).ToLower.TrimStart
            For ii As Integer = 0 To KeyWords.Length - 1
                If ln.StartsWith(KeyWords(ii)) Then
                    AddContext(ln)
                    Exit For
                End If
            Next
        Next
    End Sub
    Private Sub rtb_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        HandleMouseUp(rtb, e)
    End Sub
    Protected Sub ContextHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ContxtMenu.MenuItems.Clear()
        For i As Integer = 0 To MenuItems.Length - 1
            Dim Item As String
            Dim SubItem As New MenuItem
            For ii As Integer = 0 To WordsFind.Length - 1
                Item = WordsFind(i, ii)
                AddContextMenu(Item, SubItem)
            Next
            ContxtMenu.MenuItems.Add(SubItem)
        Next
    End Sub
    Private Sub HandlePopup(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContxtMenu.Popup
        ContextHandler(sender, e)
    End Sub
    Private Sub AddContextMenu(ByVal Caption As String, ByVal ContxtMnu As MenuItem, Optional ByVal IsEnabled As Boolean = True)
        Dim objMenuItem As MenuItem
        objMenuItem = New MenuItem
        objMenuItem.Text = Caption
        objMenuItem.Enabled = IsEnabled
        ContxtMnu.MenuItems.Add(objMenuItem)
        ' Handling Popup menu item click event
        AddHandler objMenuItem.Click, AddressOf CMenuClick
    End Sub
    Private Sub HandleMouseUp(ByVal Control As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Checking the Mouse right Button
        If e.Button = MouseButtons.Right Then
            Control.ContextMenu.Show(Control, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub CMenuClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Point to menu item clicked
        Dim objCurMenuItem As MenuItem = CType(sender, MenuItem)
        'create the submenu based on whatever selection is being made, mnuSelection
        Select Case objCurMenuItem.Text

        End Select
        objCurMenuItem = Nothing
    End Sub
#End Region
#Region " -=-Tab Control-=- "
    Structure File
        Dim Page As TabPage
        Dim RTB As RichTextBox
        Dim FileName As String
        Dim Menu As ContextMenu
    End Structure
    Dim Pages(1000) As File
    Dim MaxPages As Integer = -1
    Sub DeletePage()
        Dim CurrPage As Integer = TabCon.TabIndex
        TabCon.Controls.Remove(Pages(CurrPage).Page)
    End Sub
    Sub AddPage(Optional ByVal FileName As String = "NewFile")
        MaxPages += 1
        Pages(MaxPages) = New File
        With Pages(MaxPages).Page
            .Width = Me.Width
            .Height = Me.Height - 100
            With Pages(MaxPages).RTB
                .Width = Me.Width
                .Height = Me.Height - 100
            End With
            .Controls.Add(Pages(MaxPages).RTB)
        End With
        TabCon.Controls.Add(Pages(MaxPages).Page)
        AddHandler Pages(MaxPages).RTB.MouseDown, AddressOf HandleRichTexboxes
    End Sub
    Private Sub HandleRichTexboxes(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim CurrPage As TabPage = CType(sender, TabPage)
        Select Case CurrPage.Text

        End Select
    End Sub
#End Region
End Class
