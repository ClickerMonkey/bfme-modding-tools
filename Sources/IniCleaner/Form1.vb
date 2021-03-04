Imports System.Drawing.Drawing2D
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lstchkinis As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents btnFile As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnOpen As System.Windows.Forms.MenuItem
    Friend WithEvents btnClean As System.Windows.Forms.MenuItem
    Friend WithEvents btnExit As System.Windows.Forms.MenuItem
    Friend WithEvents btnHelp As System.Windows.Forms.MenuItem
    Friend WithEvents btnAbout As System.Windows.Forms.MenuItem
    Friend WithEvents btnWhatsThis As System.Windows.Forms.MenuItem
    Friend WithEvents Status As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnOpenINI As System.Windows.Forms.MenuItem
    Friend WithEvents btnOpenFolder As System.Windows.Forms.MenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents sep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnClean2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnCredits2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents sep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents btnAbout2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnOpenFolder2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents picT3A As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpenINI2 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lstchkinis = New System.Windows.Forms.ListBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnFile = New System.Windows.Forms.MenuItem
        Me.btnOpen = New System.Windows.Forms.MenuItem
        Me.btnOpenINI = New System.Windows.Forms.MenuItem
        Me.btnOpenFolder = New System.Windows.Forms.MenuItem
        Me.btnClean = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.btnExit = New System.Windows.Forms.MenuItem
        Me.btnHelp = New System.Windows.Forms.MenuItem
        Me.btnAbout = New System.Windows.Forms.MenuItem
        Me.btnWhatsThis = New System.Windows.Forms.MenuItem
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.sep1 = New System.Windows.Forms.ToolBarButton
        Me.btnOpenINI2 = New System.Windows.Forms.ToolBarButton
        Me.btnOpenFolder2 = New System.Windows.Forms.ToolBarButton
        Me.btnClean2 = New System.Windows.Forms.ToolBarButton
        Me.btnCredits2 = New System.Windows.Forms.ToolBarButton
        Me.btnAbout2 = New System.Windows.Forms.ToolBarButton
        Me.sep2 = New System.Windows.Forms.ToolBarButton
        Me.picT3A = New System.Windows.Forms.PictureBox
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'lstchkinis
        '
        Me.lstchkinis.BackColor = System.Drawing.Color.White
        Me.lstchkinis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstchkinis.ForeColor = System.Drawing.Color.Black
        Me.lstchkinis.HorizontalScrollbar = True
        Me.lstchkinis.IntegralHeight = False
        Me.lstchkinis.Location = New System.Drawing.Point(8, 40)
        Me.lstchkinis.Name = "lstchkinis"
        Me.lstchkinis.Size = New System.Drawing.Size(256, 232)
        Me.lstchkinis.TabIndex = 2
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(0, 277)
        Me.Status.Name = "Status"
        Me.Status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.Status.ShowPanels = True
        Me.Status.Size = New System.Drawing.Size(274, 22)
        Me.Status.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Status, "Total Inis Loaded")
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "Total Inis = "
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "Status = "
        Me.StatusBarPanel2.Width = 300
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnFile, Me.btnHelp})
        '
        'btnFile
        '
        Me.btnFile.Index = 0
        Me.btnFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnOpen, Me.btnClean, Me.MenuItem1, Me.btnExit})
        Me.btnFile.Text = "&File"
        '
        'btnOpen
        '
        Me.btnOpen.Index = 0
        Me.btnOpen.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnOpenINI, Me.btnOpenFolder})
        Me.btnOpen.Text = "&Open "
        '
        'btnOpenINI
        '
        Me.btnOpenINI.Index = 0
        Me.btnOpenINI.Text = "Ini"
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Index = 1
        Me.btnOpenFolder.Text = "Folder"
        '
        'btnClean
        '
        Me.btnClean.Index = 1
        Me.btnClean.Text = "&Clean Ini's"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "-"
        '
        'btnExit
        '
        Me.btnExit.Index = 3
        Me.btnExit.Text = "&Exit"
        '
        'btnHelp
        '
        Me.btnHelp.Index = 1
        Me.btnHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.btnAbout, Me.btnWhatsThis})
        Me.btnHelp.Text = "&Help"
        '
        'btnAbout
        '
        Me.btnAbout.Index = 0
        Me.btnAbout.Text = "&About"
        '
        'btnWhatsThis
        '
        Me.btnWhatsThis.Index = 1
        Me.btnWhatsThis.Text = "&Whats This?"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.sep1, Me.btnOpenINI2, Me.btnOpenFolder2, Me.btnClean2, Me.btnCredits2, Me.btnAbout2, Me.sep2})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(26, 26)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(274, 28)
        Me.ToolBar1.TabIndex = 4
        '
        'sep1
        '
        Me.sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnOpenINI2
        '
        Me.btnOpenINI2.ImageIndex = 4
        Me.btnOpenINI2.Tag = "openini"
        '
        'btnOpenFolder2
        '
        Me.btnOpenFolder2.ImageIndex = 1
        Me.btnOpenFolder2.Tag = "openfolder"
        '
        'btnClean2
        '
        Me.btnClean2.ImageIndex = 2
        Me.btnClean2.Tag = "clean"
        '
        'btnCredits2
        '
        Me.btnCredits2.ImageIndex = 3
        Me.btnCredits2.Tag = "credits"
        '
        'btnAbout2
        '
        Me.btnAbout2.ImageIndex = 0
        Me.btnAbout2.Tag = "about"
        '
        'sep2
        '
        Me.sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'picT3A
        '
        Me.picT3A.Image = CType(resources.GetObject("picT3A.Image"), System.Drawing.Image)
        Me.picT3A.Location = New System.Drawing.Point(168, 4)
        Me.picT3A.Name = "picT3A"
        Me.picT3A.Size = New System.Drawing.Size(96, 24)
        Me.picT3A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picT3A.TabIndex = 5
        Me.picT3A.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(274, 299)
        Me.Controls.Add(Me.picT3A)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.lstchkinis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "{IP}Gil-Galad's Ini Cleaner"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " -=-Variables-=- "
    Public Structure Ini
        Dim InitialChars As Integer
        Dim FinalChars As Integer
        Dim FilePath As String
        Dim IniName As String
        Dim CleanIni As Boolean
    End Structure
    Private InisLoaded As Integer = -1
    Private Inis(1000) As Ini
#End Region

#Region " -=-Functions/Subs-=- "
    Sub CleanFile(ByVal Path As String, ByRef InitLns As Integer, ByRef FinLns As Integer)
        Dim FileName As String = Path.Substring(Path.LastIndexOf("\") + 1)
        Dim sr As IO.StreamReader = IO.File.OpenText(Path)
        Dim sw As IO.StreamWriter = IO.File.CreateText(FileName)
        Dim Currln As String
        Dim lnToWrite As String
        Dim InitialLines As Integer
        Dim FinalLines As Integer
        Do While sr.Peek <> -1
            Currln = sr.ReadLine
            InitialLines += 1
            If TrimLine(Currln) = True Then
                sw.WriteLine(Currln)
                FinalLines += 1
            End If
        Loop
        sr.Close()
        sw.Close()
        InitLns = InitialLines
        FinLns = FinalLines
    End Sub
    Sub UpdateLst()
        lstchkinis.Items.Clear()
        For i As Integer = 0 To InisLoaded
            lstchkinis.Items.Add(Inis(i).IniName)
        Next
    End Sub
    Sub SetToolTips()
        btnOpenINI2.ToolTipText = "Select an .ini file to add to list."
        btnOpenFolder2.ToolTipText = "Select a folder to get all ini's from, to add to list."
        btnClean2.ToolTipText = "Copy the ini's in the list into this programs folder" & vbCrLf & "and then clean them"
        btnAbout2.ToolTipText = "About My INI Cleaner"
        btnCredits2.ToolTipText = "Credits"
    End Sub
    Sub GetFiles(ByVal Path As String)
        Dim Dir() As String
        Dim File() As String
        File = IO.Directory.GetFiles(Path)
        Dir = IO.Directory.GetDirectories(Path)
        Dim en As System.Collections.IEnumerator
        en = File.GetEnumerator
        While en.MoveNext
            Dim line As String = CStr(en.Current)
            If line.Substring(line.LastIndexOf(".") + 1) = "ini" Then
                InisLoaded += 1
                Inis(InisLoaded).FilePath = line
                Inis(InisLoaded).IniName = line.Substring(line.LastIndexOf("\") + 1)
            End If
        End While
        en = Dir.GetEnumerator
        While en.MoveNext
            GetFiles(CStr(en.Current))
        End While
    End Sub
    Function LineContains(ByVal line As String, ByVal str As String) As Boolean
        For i As Integer = 0 To line.Length - str.Length
            If line.Substring(i, str.Length) = str Then
                Return True
            End If
        Next
        Return False
    End Function
    Function TrimLine(ByRef line As String) As Boolean
        Dim Chars As String() = {";", "/"}
        For i As Integer = 0 To 1
            If LineContains(line, Chars(i)) = True Then
                line = line.Substring(0, line.IndexOf(Chars(i)))
            End If
            If line.TrimStart = "" Then
                Return False
            End If
        Next
        Return True
    End Function
#End Region

#Region " -=-Operations-=- "
    Private Sub lstchkinis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstchkinis.SelectedIndexChanged
        ToolTip1.SetToolTip(lstchkinis, "IniName: " & Inis(lstchkinis.SelectedIndex).IniName & vbCrLf & "Location: " & Inis(lstchkinis.SelectedIndex).FilePath)
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateLst()
        SetToolTips()
    End Sub
#End Region

#Region " -=-Menu/Toolbar-=- "
    Private Sub btnOpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFolder.Click
        With FolderBrowserDialog1
            If .ShowDialog = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Application.DoEvents()
                GetFiles(.SelectedPath)
                UpdateLst()
                Status.Panels(0).Text = "Total Inis = " & InisLoaded + 1
                Cursor = Cursors.Default
            End If
        End With
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.Tag
            Case "clean"
                btnClean_Click(sender, e)
            Case "openini"
                btnOpen_Click(sender, e)
            Case "openfolder"
                btnOpenFolder_Click(sender, e)
            Case "about"
                btnAbout_Click(sender, e)
            Case "credits"
                btnCredits_Click(sender, e)
        End Select
    End Sub
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenINI.Click
        Status.Panels(1).Text = "Status = Opening Files..."
        Try
            With OpenFileDialog1
                .InitialDirectory = Application.StartupPath
                .Filter = "Ini Files (*.*)|*.*"
                .FilterIndex = 1
                .RestoreDirectory = True
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    For i As Integer = 0 To .FileNames.Length - 1
                        If .FileNames(i).Substring(.FileNames(i).LastIndexOf(".") + 1).ToLower = "ini" Then
                            InisLoaded += 1
                            Inis(InisLoaded).FilePath = .FileNames(i)
                            Inis(InisLoaded).IniName = .FileNames(i).Substring(.FileNames(i).LastIndexOf("\") + 1)
                        End If
                    Next
                    UpdateLst()
                    Status.Panels(0).Text = "Total Inis = " & InisLoaded + 1
                    btnOpen_Click(sender, e)
                Else
                    Status.Panels(1).Text = "Status = Opened Files"
                End If
            End With
        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
        Try
            Application.DoEvents()
            Status.Panels(1).Text = "Status = Cleaning Files..."
            Dim msg As String
            Dim Init, Fin, TTLInitLines, TTLInitSize, TTLFinLines, TTLFinSize As Integer
            Dim FrmResults As New Results
            Dim fmtStr As String = "{0,-35}{1,16}{2,16}{3,18}{4,18}"
            Dim fmtStr2 As String = "{0,-30}{1,-30}{2,-30}"
            FrmResults.lstResults.Items.Add(String.Format(fmtStr, "FileName", "InitialLines", "FinalLines", "InitialSize", "FinalSize"))
            For i As Integer = 0 To InisLoaded
                CleanFile(Inis(i).FilePath, Init, Fin)
                Dim FileInfo As IO.FileInfo
                FileInfo = New IO.FileInfo(Inis(i).FilePath)
                Dim InitSize As String = FileInfo.Length
                FileInfo = New IO.FileInfo(Application.StartupPath & "\" & Inis(i).IniName)
                Dim FinSize As String = FileInfo.Length
                TTLInitSize += CInt(InitSize)
                TTLFinSize += CInt(FinSize)
                TTLInitLines += Init
                TTLFinLines += Fin
                FrmResults.lstResults.Items.Add(String.Format(fmtStr, Inis(i).IniName, Init, Fin, FormatNumber(InitSize / 1000, 2) & "kb", FormatNumber(FinSize / 1000, 2) & "kb"))
            Next
            FrmResults.lstResults.Items.Add(String.Format(fmtStr2, "Lines Saved", "Size Saved(kb)", "Size Saved(mb)"))
            FrmResults.lstResults.Items.Add(String.Format(fmtStr2, TTLInitLines - TTLFinLines, FormatNumber((TTLInitSize - TTLFinSize) / 1000, 2) & "kb", FormatNumber((TTLInitSize - TTLFinSize) / 1000000, 2) & "mb"))
            UpdateLst()
            FrmResults.Show()
            Status.Panels(1).Text = "Status = Files Cleaned"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Select Case MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Me.Close()
        End Select
    End Sub
    Private Sub btnCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        MsgBox("Created on December 23 2005" & vbCrLf & _
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
       "Ini Cleaner " & Chr(153) & vbCrLf & _
       "------------------------------------------------", MsgBoxStyle.OKOnly.Information, "Ini Cleaner")
    End Sub
    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhatsThis.Click
        MsgBox( _
        "This Program will open up Ini files and save their location." & vbCrLf & _
        "Once you hit clean this program will copy those files in the" & vbCrLf & _
        "programs folder, and then remove all empty lines and all comments.")
    End Sub
    Private Sub picT3A_Clicked(ByVal sender As System.Object, ByVal e As EventArgs) Handles picT3A.Click
        Dim IE As New SHDocVw.InternetExplorer
        IE.Visible = True
        IE.Navigate("www.The3rdAge.net")
    End Sub
#End Region

End Class



