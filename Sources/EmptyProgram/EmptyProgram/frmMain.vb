Imports Microsoft.Win32

Public Class frmMain

    Private RecentFiles As New List(Of String)

#Region "File"

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click, btnNew.Click
        NewFile()
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click, btnOpen.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFile(dlgOpen.FileNames)
        End If
    End Sub

    Private Sub mnuImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImport.Click
        If dlgImport.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImportFile(dlgImport.FileNames)
        End If
    End Sub

    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click, btnSave.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveFile(dlgSave.FileName)
        End If
    End Sub

    Private Sub mnuSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveAs.Click, btnSaveAs.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveFile(dlgSave.FileName)
        End If
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        If dlgExport.ShowDialog = Windows.Forms.DialogResult.OK Then
            ExportFile(dlgExport.FileName)
        End If
    End Sub

    Private Sub mnuRecentFilesItemClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        If Item IsNot Nothing Then
            If IO.File.Exists(Item.Tag.ToString) Then
                OpenFile(New String() {Item.Tag.ToString})
            End If
        End If
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MsgBox("Are you sure you want to leave?", MsgBoxStyle.Exclamation And MsgBoxStyle.YesNo, "Exit Program")
            Case MsgBoxResult.Yes
                'Closing
                'SaveSettings()
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'LoadSettings()
    End Sub

#End Region

#Region "View"

    Private Sub mnuStatusBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStatusBar.Click
        If mnuStatusBar.Image IsNot Nothing Then 'Checked
            mnuStatusBar.Image = Nothing
            stsMain.Visible = False
        Else 'UnChecked
            mnuStatusBar.Image = My.Resources.Check
            stsMain.Visible = True
        End If
    End Sub

    Private Sub mnuViewOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewOptions.Click
        If mnuViewOptions.Image IsNot Nothing Then 'Checked
            mnuViewOptions.Image = Nothing
            strFile.Visible = False
        Else 'UnChecked
            mnuViewOptions.Image = My.Resources.Check
            strFile.Visible = True
        End If
    End Sub

    Private Sub mnuViewEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewEdit.Click
        If mnuViewEdit.Image IsNot Nothing Then 'Checked
            mnuViewEdit.Image = Nothing
            strEdit.Visible = False
        Else 'UnChecked
            mnuViewEdit.Image = My.Resources.Check
            strEdit.Visible = True
        End If
    End Sub

    Private Sub mnuViewFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewFormat.Click
        If mnuViewFormat.Image IsNot Nothing Then 'Checked
            mnuViewFormat.Image = Nothing
            strFormat.Visible = False
        Else 'UnChecked
            mnuViewFormat.Image = My.Resources.Check
            strFormat.Visible = True
        End If
    End Sub

    Private Sub mnuViewHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewHelp.Click
        If mnuViewHelp.Image IsNot Nothing Then 'Checked
            mnuViewHelp.Image = Nothing
            strHelp.Visible = False
        Else 'UnChecked
            mnuViewHelp.Image = My.Resources.Check
            strHelp.Visible = True
        End If
    End Sub

#End Region

#Region "Help"

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Dim About As New dlgAbout
        About.ShowDialog()
    End Sub

    Private Sub mnuContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuContact.Click
        Dim Contact As New dlgContact
        Contact.ShowDialog()
    End Sub

#End Region

    Private Sub OpenFile(ByVal Filepath() As String)

    End Sub

    Private Sub SaveFile(ByVal Filepath As String)

    End Sub

    Private Sub ImportFile(ByVal Filepath() As String)

    End Sub

    Private Sub ExportFile(ByVal Filepath As String)

    End Sub

    Private Sub NewFile()

    End Sub

    Private Sub LoadSettings()
        Dim ProgramKey As RegistryKey
        ProgramKey = Registry.ClassesRoot.OpenSubKey("EmptyProgram")
        If ProgramKey IsNot Nothing Then
            Dim VisibleKey As RegistryKey
            VisibleKey = ProgramKey.OpenSubKey("Visible")
            If VisibleKey IsNot Nothing Then
                strFile.Visible = VisibleKey.GetValue("ToolBarOptions", True)
                strEdit.Visible = VisibleKey.GetValue("ToolBarEdit", True)
                strFormat.Visible = VisibleKey.GetValue("ToolBarFormat", True)
                strHelp.Visible = VisibleKey.GetValue("ToolBarHelp", False)
                stsMain.Visible = VisibleKey.GetValue("StatusBar", True)
                VisibleKey.Close()
            End If
            Dim PropertiesKey As RegistryKey
            PropertiesKey = ProgramKey.OpenSubKey("Properties")
            If PropertiesKey IsNot Nothing Then
                Dim Position As Point, Dimension As Size
                Position.X = PropertiesKey.GetValue("X", 0)
                Position.Y = PropertiesKey.GetValue("Y", 0)
                Dimension.Width = PropertiesKey.GetValue("Width", 300)
                Dimension.Height = PropertiesKey.GetValue("Height", 300)
                Me.Location = Position
                Me.Size = Dimension
                PropertiesKey.Close()
            End If
            Dim RecentKey As RegistryKey
            RecentKey = ProgramKey.OpenSubKey("RecentFiles")
            If RecentKey IsNot Nothing Then
                Dim Recent As Integer
                Recent = RecentKey.GetValue("", 0)
                For I As Integer = 1 To Recent
                    Dim File As String
                    File = RecentKey.GetValue(I.ToString, "")
                    If IO.File.Exists(File) Then
                        RecentFiles.Add(File)
                        Dim FileName As String = File.Substring(File.LastIndexOf("\") + 1)
                        Dim Item As New ToolStripMenuItem
                        Item.Text = FileName
                        Item.Tag = File
                        Item.ToolTipText = File
                        Item.ShortcutKeyDisplayString = "Ctrl+O+" & I.ToString
                        Item.ShortcutKeys = Keys.Control & Keys.O & DirectCast(I + 48, Keys)
                        AddHandler Item.Click, AddressOf mnuRecentFilesItemClicked
                        mnuRecentFiles.DropDownItems.Add(Item)
                    End If
                Next
                RecentKey.Close()
            End If
            ProgramKey.Close()
        End If
    End Sub

    Private Sub SaveSettings()
        Dim ProgramKey As RegistryKey
        ProgramKey = Registry.ClassesRoot.CreateSubKey("EmptyProgram")
        Dim VisibleKey As RegistryKey
        VisibleKey = ProgramKey.CreateSubKey("Visible")
        VisibleKey.SetValue("ToolBarOptions", strFile.Visible)
        VisibleKey.SetValue("ToolBarEdit", strEdit.Visible)
        VisibleKey.SetValue("ToolBarFormat", strFormat.Visible)
        VisibleKey.SetValue("ToolBarHelp", strHelp.Visible)
        VisibleKey.SetValue("StatusBar", stsMain.Visible)
        VisibleKey.Close()
        Dim PropertiesKey As RegistryKey
        PropertiesKey = ProgramKey.CreateSubKey("Properties")
        PropertiesKey.SetValue("X", Me.Location.X)
        PropertiesKey.SetValue("Y", Me.Location.Y)
        PropertiesKey.SetValue("Width", Me.Size.Width)
        PropertiesKey.SetValue("Height", Me.Size.Height)
        PropertiesKey.Close()
        Dim RecentKey As RegistryKey
        RecentKey = ProgramKey.CreateSubKey("RecentFiles")
        RecentKey.SetValue("", RecentFiles.Count)
        For I As Integer = 1 To RecentFiles.Count
            RecentKey.SetValue(I.ToString, RecentFiles(I))
        Next
        RecentKey.Close()
        ProgramKey.Close()
    End Sub

End Class
