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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Status As System.Windows.Forms.StatusBar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents lstArmors As System.Windows.Forms.ListBox
    Friend WithEvents txtPercent As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents chkCreate As System.Windows.Forms.CheckBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents lblArmorType As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblArmorName As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents mnuCreate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPreview As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPreviewAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTip As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblArmorType = New System.Windows.Forms.Label
        Me.lblArmorName = New System.Windows.Forms.Label
        Me.chkCreate = New System.Windows.Forms.CheckBox
        Me.btnAbout = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.btnPreview = New System.Windows.Forms.Button
        Me.lblPercent = New System.Windows.Forms.Label
        Me.Status = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.lstArmors = New System.Windows.Forms.ListBox
        Me.txtPercent = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuPreviewAll = New System.Windows.Forms.MenuItem
        Me.mnuNew = New System.Windows.Forms.MenuItem
        Me.mnuCreate = New System.Windows.Forms.MenuItem
        Me.mnuOpen = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuPreview = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuAbout = New System.Windows.Forms.MenuItem
        Me.mnuTip = New System.Windows.Forms.MenuItem
        Me.txtName = New System.Windows.Forms.TextBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblArmorType
        '
        Me.lblArmorType.Location = New System.Drawing.Point(192, 104)
        Me.lblArmorType.Name = "lblArmorType"
        Me.lblArmorType.Size = New System.Drawing.Size(152, 16)
        Me.lblArmorType.TabIndex = 18
        Me.lblArmorType.Text = "Armor Type"
        Me.lblArmorType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblArmorType, "The armor type.")
        '
        'lblArmorName
        '
        Me.lblArmorName.Location = New System.Drawing.Point(192, 64)
        Me.lblArmorName.Name = "lblArmorName"
        Me.lblArmorName.Size = New System.Drawing.Size(152, 16)
        Me.lblArmorName.TabIndex = 28
        Me.lblArmorName.Text = "Armor Name"
        Me.lblArmorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblArmorName, "The name of the Armor")
        '
        'chkCreate
        '
        Me.chkCreate.Location = New System.Drawing.Point(192, 40)
        Me.chkCreate.Name = "chkCreate"
        Me.chkCreate.Size = New System.Drawing.Size(136, 24)
        Me.chkCreate.TabIndex = 16
        Me.chkCreate.Text = "Create in Ini"
        Me.ToolTip1.SetToolTip(Me.chkCreate, "If checked this Armor will be created in the Ini")
        '
        'btnAbout
        '
        Me.btnAbout.BackgroundImage = CType(resources.GetObject("btnAbout.BackgroundImage"), System.Drawing.Image)
        Me.btnAbout.Location = New System.Drawing.Point(144, 4)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(24, 24)
        Me.btnAbout.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnAbout, "About")
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(116, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(24, 24)
        Me.btnDelete.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Delete Armor")
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(88, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(24, 24)
        Me.btnAdd.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add Armor")
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(60, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(24, 24)
        Me.btnNew.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnNew, "Start New Armor.ini")
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(32, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(24, 24)
        Me.btnSave.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save Armor.ini")
        '
        'btnOpen
        '
        Me.btnOpen.BackgroundImage = CType(resources.GetObject("btnOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnOpen.Location = New System.Drawing.Point(4, 4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(24, 24)
        Me.btnOpen.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btnOpen, "Open Armor.ini")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.Location = New System.Drawing.Point(262, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 16)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "The3rdAge.Net"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "www.The3rdAge.Net")
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(192, 192)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(152, 20)
        Me.btnPreview.TabIndex = 29
        Me.btnPreview.Text = "Preview Armor"
        Me.ToolTip1.SetToolTip(Me.btnPreview, "Preview Current Armor")
        '
        'lblPercent
        '
        Me.lblPercent.Location = New System.Drawing.Point(192, 144)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(152, 16)
        Me.lblPercent.TabIndex = 13
        Me.lblPercent.Text = "Percent"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(0, 221)
        Me.Status.Name = "Status"
        Me.Status.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.Status.ShowPanels = True
        Me.Status.Size = New System.Drawing.Size(354, 22)
        Me.Status.TabIndex = 6
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "Current Armor = "
        Me.StatusBarPanel1.Width = 150
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "Total Armors = "
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Width = 120
        '
        'lstArmors
        '
        Me.lstArmors.Location = New System.Drawing.Point(8, 40)
        Me.lstArmors.Name = "lstArmors"
        Me.lstArmors.Size = New System.Drawing.Size(168, 173)
        Me.lstArmors.TabIndex = 10
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(192, 160)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(152, 20)
        Me.txtPercent.TabIndex = 12
        Me.txtPercent.Text = ""
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPreviewAll, Me.mnuNew, Me.mnuCreate, Me.mnuOpen, Me.mnuExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuPreviewAll
        '
        Me.mnuPreviewAll.Index = 0
        Me.mnuPreviewAll.Text = "&Preview all Armors"
        '
        'mnuNew
        '
        Me.mnuNew.Index = 1
        Me.mnuNew.Text = "&New"
        '
        'mnuCreate
        '
        Me.mnuCreate.Index = 2
        Me.mnuCreate.Text = "&Save"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 3
        Me.mnuOpen.Text = "&Open"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 4
        Me.mnuExit.Text = "&Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuDelete, Me.mnuPreview})
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "&Add Armor"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 1
        Me.mnuDelete.Text = "&Delete Armor"
        '
        'mnuPreview
        '
        Me.mnuPreview.Index = 2
        Me.mnuPreview.Text = "&Preview Armor"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout, Me.mnuTip})
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 0
        Me.mnuAbout.Text = "&About"
        '
        'mnuTip
        '
        Me.mnuTip.Index = 1
        Me.mnuTip.Text = "&Tips"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(192, 80)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 20)
        Me.txtName.TabIndex = 15
        Me.txtName.Text = ""
        '
        'cmbType
        '
        Me.cmbType.Items.AddRange(New Object() {"FORCE", "CRUSH", "SLASH", "PIERCE", "SIEGE", "FLAME", "HEALING", "UNRESISTABLE", "WATER", "PENALTY", "FALLING", "TOPPLING", "HERO_RANGED", "HERO", "URUK", "DEFAULT", "SPECIALIST", "MAGIC", "STRUCTURAL", "CHOP"})
        Me.cmbType.Location = New System.Drawing.Point(192, 120)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(152, 21)
        Me.cmbType.TabIndex = 17
        Me.cmbType.Text = "FORCE"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(162, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "For more on modding"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 32)
        Me.Label2.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(354, 243)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.lblArmorName)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblArmorType)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.chkCreate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.lstArmors)
        Me.Controls.Add(Me.Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "{IP}Gil-Galad's Armor Editor (BFME)"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " -=-Variables-=- "

    Private _
    Armor(1000) As Armor, _
    Types(1000, 19) As ArmorTypes, _
    TtlArmors As Integer = -1, _
    CurrArmors As Integer = -1, _
    CurrTypes As Integer = 0
    Private Loaded As Boolean

#End Region
#Region " -=-Armor Types/Info Arrays-=- "

    Dim Armor_Types As String() = _
    { _
        "FORCE", _
        "CRUSH", _
        "SLASH", _
        "PIERCE", _
        "SIEGE", _
        "FLAME", _
        "HEALING", _
        "UNRESISTABLE", _
        "WATER", _
        "PENALTY", _
        "FALLING", _
        "TOPPLING", _
        "HERO_RANGED", _
        "HERO", _
        "URUK", _
        "DEFAULT", _
        "SPECIALIST", _
        "MAGIC", _
        "STRUCTURAL", _
        "CHOP" _
    }
    Dim Armor_Types_Info As String() = _
    { _
        "Formless force, like Shockwave", _
        "Blunt and Heavy hit (Calvary)", _
        "Sharp and Slicey hit (Soldiers)", _
        "Pointy and Pokey hit (Archers)", _
        "Siege weapons", _
        "Fire damage", _
        "Special use healing", _
        "Special use system damage", _
        "Falling in water", _
        "Special use system damage", _
        "Falling far and hitting ground", _
        "Trees", _
        "Hero long range damage", _
        "Hero damage", _
        "Uruk damage", _
        "This sets the level for all nonspecified damage types", _
        "Pikemen Damage", _
        "Magic Damage", _
        "Structural Damage (Ent rocks)", _
        "Axe Damage" _
    }

#End Region
#Region " -=-Main Functions-=- "

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click, mnuOpen.Click
        With OpenFileDialog1
            .InitialDirectory = Application.StartupPath
            .Filter = "All files (*.*)|*.*|" & "Ini Files (*.ini)|*.ini"
            .FilterIndex = 1
            .RestoreDirectory = True
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Application.DoEvents()
                Try
                    OpenArmorINI(.FileName)
                Catch ex As Exception
                    MsgBox("Error Opening File", , "Error")
                End Try
            End If
        End With
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click, mnuDelete.Click
        Try
            If TtlArmors <> -1 Then
                lstArmors.SetSelected(CurrArmors, True)
                If CurrArmors < TtlArmors Then
                    DeleteArmor(CurrArmors)
                    lstArmors.SetSelected(CurrArmors, True)
                ElseIf CurrArmors = TtlArmors And TtlArmors <> 0 Then
                    lstArmors.SetSelected(CurrArmors - 1, True)
                    lstArmors.Items.RemoveAt(TtlArmors)
                    CurrArmors = CurrArmors - 1
                    TtlArmors -= 1
                    UpdateArmors(True)
                    lstArmors.SetSelected(CurrArmors - 1, True)
                ElseIf TtlArmors = 0 Then

                End If
            End If
        Catch ex As Exception
            MsgBox("Error Deleting Armor", , "Armor Editor")
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click, mnuAdd.Click
        Try
            TtlArmors += 1
            Armor(TtlArmors) = New Armor("NewArmor", True)
            CurrArmors = TtlArmors : CurrTypes = 0
            UpdateArmors(True)
        Catch ex As Exception
            MsgBox("Error Opening File", , "Error")
        End Try
    End Sub
    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click, mnuAbout.Click
        MsgBox("Created on January 2 2006" & vbCrLf & _
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
               "Armor Editor " & Chr(153) & vbCrLf & _
               "------------------------------------------------", MsgBoxStyle.OKOnly.Information, "Armor Editor")
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click, mnuCreate.Click
        With SaveFileDialog1
            .Filter = "Ini files (*.ini)|*.ini|" & "All Files (*.*)|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
            .InitialDirectory = Application.StartupPath
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Application.DoEvents()
                SaveArmorINI(.FileName)
            End If
        End With
    End Sub
    Private Sub lstArmors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstArmors.SelectedIndexChanged
        CurrArmors = lstArmors.SelectedIndex
        UpdateArmors(False)
    End Sub
    Private Sub txtPercent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPercent.TextChanged
        If Loaded = True Then
            Types(CurrArmors, CurrTypes).PERCENT_ = txtPercent.Text
            UpdateArmors(False)
        End If
    End Sub
    Private Sub chkCreate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCreate.CheckedChanged
        If Loaded = True Then
            Armor(CurrArmors).CREATE_ = chkCreate.Checked
            UpdateArmors(False)
        End If
    End Sub
    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        Dim curr As Integer = cmbType.SelectedIndex
        CurrTypes = curr
        ToolTip1.SetToolTip(cmbType, Armor_Types(curr) & vbCrLf & Armor_Types_Info(curr))
        UpdateArmors(False)
    End Sub
    Private Sub txtName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.LostFocus
        If Loaded = True Then
            Dim name As String = txtName.Text
            If name <> Armor(CurrArmors).NAME_ Then
                Armor(CurrArmors).NAME_ = name
                UpdateArmors(True)
            End If
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadArmors()
        Loaded = True
        SetDefaultArmor()
    End Sub
    Private Sub cmbType_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.MouseHover
        Dim curr As Integer = cmbType.SelectedIndex
        CurrTypes = curr
        ToolTip1.SetToolTip(cmbType, Armor_Types(curr + 1) & vbCrLf & Armor_Types_Info(curr + 1))
    End Sub
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click, mnuPreview.Click
        Dim Prev As New Preview
        Dim fmtstr As String = "{0,-30}{1,-10}"
        With Prev.lstPreview
            .Items.Add("Armor " & Armor(CurrArmors).NAME_)
            For ii As Integer = 0 To 19
                If Types(CurrArmors, ii).PERCENT_ <> "" Then
                    Dim _percent As String = Types(CurrArmors, ii).PERCENT_
                    If _percent.Substring(_percent.Length - 1, 1) <> "%" Then
                        _percent &= "%"
                    End If
                    .Items.Add(String.Format(fmtstr, vbTab & "Armor = " & Types(CurrArmors, ii).TYPE_, _percent))
                End If
            Next
            .Items.Add("End")
        End With
        Prev.Show()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim IE As New SHDocVw.InternetExplorer
            IE.Visible = True
            IE.Navigate("www.the3rdage.net")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click, mnuNew.Click
        LoadArmors()
        TtlArmors = -1
        CurrArmors = -1
        SetDefaultArmor()
    End Sub
    Private Sub mnuPreviewAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPreviewAll.Click
        Dim Prev As New Preview
        Prev.Height = 300
        Dim fmtstr As String = "{0,-30}{1,-10}"
        With Prev.lstPreview
            For i As Integer = 0 To TtlArmors
                If Armor(i).CREATE_ = True Then
                    .Items.Add("Armor " & Armor(i).NAME_)
                    For ii As Integer = 0 To 19
                        If Types(i, ii).PERCENT_ <> "" Then
                            Dim _percent As String = Types(i, ii).PERCENT_
                            If _percent.Substring(_percent.Length - 1, 1) <> "%" Then
                                _percent &= "%"
                            End If
                            .Items.Add(String.Format(fmtstr, vbTab & "Armor = " & Types(i, ii).TYPE_, _percent))
                        End If
                    Next
                    .Items.Add("End")
                    .Items.Add("")
                End If
            Next
        End With
        Prev.Show()
    End Sub
    Private Sub mnuTip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTip.Click
        Dim msg As String
        msg = _
        "To get help just drag the cursor " & _
        "over the words or objects, and " & _
        "it will be explained"
        MsgBox(msg, MsgBoxStyle.Exclamation, "Armor Editor")
    End Sub
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Select Case MsgBox("Are you sre you want to leave?", MsgBoxStyle.YesNo, "Armor Editor")
            Case MsgBoxResult.Yes
                Me.Close()
        End Select
    End Sub

#End Region
#Region " -=-Subs/Functions-=- "
    Sub SaveArmorINI(ByVal Filepath As String)
        Dim ArmorWriter As IO.StreamWriter = IO.File.CreateText(Filepath)
        Dim fmtstr As String = "{0,-30}{1,-10}"
        With ArmorWriter
            For i As Integer = 0 To TtlArmors
                If Armor(i).CREATE_ = True Then
                    .WriteLine("Armor " & Armor(i).NAME_)
                    For ii As Integer = 0 To 19
                        If Types(i, ii).PERCENT_ <> "" Then
                            Dim _percent As String = Types(i, ii).PERCENT_
                            If _percent.Substring(_percent.Length - 1, 1) <> "%" Then
                                _percent &= "%"
                            End If
                            .WriteLine(String.Format(fmtstr, vbTab & "Armor = " & Types(i, ii).TYPE_, _percent))
                        End If
                    Next
                    .WriteLine("End")
                    .WriteLine()
                End If
            Next
        End With
        ArmorWriter.Close()
        MsgBox("File Created in:" & vbCrLf & Filepath)
    End Sub
    Sub OpenArmorINI(ByVal Filepath As String)
        Dim ArmorReader As IO.StreamReader = IO.File.OpenText(Filepath)
        Dim line(1) As String, temp As Integer = TtlArmors
        With ArmorReader
            Do While ArmorReader.Peek <> -1
                line(0) = .ReadLine.TrimStart
                If Contain(line(0), ";") = True Then
                    line(0) = line(0).Substring(0, line(0).IndexOf(";"))
                End If
                If line(0).TrimStart = "" Then
                    GoTo SkipInfo
                End If
                If line(0).ToLower.StartsWith("armor ") And Contain(line(0), "=") = False Then
                    temp += 1
                    Dim name As String = line(0).Substring(line(0).IndexOf(" ") + 1).TrimEnd
                    Armor(temp) = New Armor(name, True)
                    Dim Ended As Boolean = False
                    line(1) = line(0)
                    Do Until Ended = True
                        If line(1).ToLower.StartsWith("end") Then
                            Ended = True
                            Exit Do
                        End If
                        line(1) = .ReadLine.TrimStart
                        If Contain(line(1), ";") = True Then
                            line(1) = line(1).Substring(0, line(1).IndexOf(";"))
                        End If
                        Dim type As String = GetVar(line(1).IndexOf("=") + 2, line(1)).TrimEnd.TrimStart.ToUpper
                        'Dim msg As String
                        For i As Integer = 0 To 19
                            'msg &= type & vbTab & vbTab & Armor_Types(i) & vbCrLf
                            If type = Armor_Types(i).ToUpper Then
                                Types(temp, i).TYPE_ = type.ToUpper
                                Dim percent As String = line(1).Substring(line(1).IndexOf(type.ToUpper) + type.Length).TrimStart.TrimEnd
                                'MsgBox(type & vbCrLf & percent)
                                Types(temp, i).PERCENT_ = percent
                            End If
                        Next
                        'MsgBox(msg)
                        'msg = ""
                    Loop
                End If
SkipInfo:
            Loop
        End With
        TtlArmors = temp
        ArmorReader.Close()
        UpdateArmors(True)
    End Sub
    Sub UpdateArmors(ByVal _armors As Boolean)
        If TtlArmors = -1 Then
            Loaded = False
        End If
        If Loaded = True Then
            txtName.Text = Armor(CurrArmors).NAME_
            chkCreate.Checked = Armor(CurrArmors).CREATE_
            txtPercent.Text = Types(CurrArmors, CurrTypes).PERCENT_
            UpdateStatus()
            If _armors = True Then
                lstArmors.Items.Clear()
                For i As Integer = 0 To TtlArmors
                    lstArmors.Items.Add(Armor(i).NAME_)
                Next
            End If
        End If
    End Sub
    Sub UpdateStatus()
        Status.Panels(0).Text = "Current Armor = " & Armor(CurrArmors).NAME_
        Status.Panels(1).Text = "Total Armors = " & TtlArmors
        Status.Panels(2).Text = Armor_Types(CurrTypes)
    End Sub
    Sub LoadArmors()
        For i As Integer = 0 To 1000
            Armor(i) = New Armor("", False)
            For ii As Integer = 0 To 19
                Types(i, ii) = New ArmorTypes(Armor_Types(ii), "")
            Next
        Next
    End Sub
    Sub SetDefaultArmor()
        TtlArmors += 1
        CurrArmors = TtlArmors
        CurrTypes = 0
        Armor(TtlArmors) = New Armor("DefaultArmor", True)
        UpdateArmors(True)
    End Sub
    Sub DeleteArmor(ByVal Position As Integer)
        Dim temp As Armor = Armor(Position + 1)
        For i As Integer = Position To TtlArmors - 1
            Armor(i) = Armor(i + 1)
            For ii As Integer = 0 To 19
                Types(i, ii) = Types(i + 1, ii)
            Next
        Next
        TtlArmors -= 1
        UpdateArmors(True)
    End Sub

    Function Contain(ByVal line As String, ByVal str As String) As Boolean
        For i As Integer = 0 To line.Length - str.Length
            If line.Substring(i, str.Length) = str Then
                Return True
            End If
        Next
        Return False
    End Function
    Function GetVar(ByVal startpos As Integer, ByVal line As String) As String
        line = line & " "
        For i As Integer = startpos To line.Length - 1
            If line.Substring(i, 1) = " " Then
                Return line.Substring(startpos, i - startpos)
            End If
        Next
    End Function

#End Region

End Class

Class Armor
    Private Name As String
    Private Create As Boolean
    Public Sub New()
    End Sub
    Public Sub New(ByVal _name As String, ByVal _create As Boolean)
        NAME_ = _name
        CREATE_ = _create
    End Sub
    Public Property NAME_() As String
        Get
            Return Name
        End Get
        Set(ByVal Value As String)
            Name = Value
        End Set
    End Property
    Public Property CREATE_() As Boolean
        Get
            Return Create
        End Get
        Set(ByVal Value As Boolean)
            Create = Value
        End Set
    End Property
End Class
Class ArmorTypes
    Private Type As String
    Private Percent As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal _type As String, ByVal _percent As String)
        TYPE_ = _type
        PERCENT_ = _percent
    End Sub
    Public Property TYPE_() As String
        Get
            Return Type
        End Get
        Set(ByVal Value As String)
            Type = Value
        End Set
    End Property
    Public Property PERCENT_() As String
        Get
            Return Percent
        End Get
        Set(ByVal Value As String)
            Percent = Value
        End Set
    End Property
End Class
