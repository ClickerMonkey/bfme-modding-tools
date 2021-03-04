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
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents rtb2 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnBring As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents col1 As System.Windows.Forms.RichTextBox
    Friend WithEvents col2 As System.Windows.Forms.RichTextBox
    Friend WithEvents col3 As System.Windows.Forms.RichTextBox
    Friend WithEvents col4 As System.Windows.Forms.RichTextBox
    Friend WithEvents col5 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnHTML As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnOpenKP As System.Windows.Forms.Button
    Friend WithEvents KP As System.Windows.Forms.ProgressBar
    Friend WithEvents rtbKP As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.rtb = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnBring = New System.Windows.Forms.Button
        Me.rtb2 = New System.Windows.Forms.RichTextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnHTML = New System.Windows.Forms.Button
        Me.col5 = New System.Windows.Forms.RichTextBox
        Me.col4 = New System.Windows.Forms.RichTextBox
        Me.col3 = New System.Windows.Forms.RichTextBox
        Me.col2 = New System.Windows.Forms.RichTextBox
        Me.col1 = New System.Windows.Forms.RichTextBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.btnOpenKP = New System.Windows.Forms.Button
        Me.KP = New System.Windows.Forms.ProgressBar
        Me.rtbKP = New System.Windows.Forms.RichTextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt1.Location = New System.Drawing.Point(200, 0)
        Me.txt1.MaxLength = 9999999
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt1.Size = New System.Drawing.Size(458, 448)
        Me.txt1.TabIndex = 0
        Me.txt1.Text = ""
        Me.txt1.WordWrap = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.Items.AddRange(New Object() {"""BountyValue""", """BuildCost"" (R)", """BuildTime"" (R)", """CommandPoints"" (R)", """CrushableLevel""", """CrushRevengeWeapon""", """Description""", """DisplayMeleeDamage""", """DisplayName"" (R)", """DisplayRangedDamage""", """EditorSorting"" (R)", """EmotionRange""", """FormationDepth (1 or 2)""", """FormationWidth (1 or 2)""", """HeroSortOrder"" (H)", """HotKey""", """ImmuneToShockWave""", """IsTrainable""", """KindOf"" (R)", """MaxSimultaneousOfType""", """RecruitText""", """ReviveText""", """ShroudClearingRange""", """Side"" (R)", """ThingClass""", """ThreatLevel"" (R)", """TranportSlotCount""", """VisionRange"" (R)"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 448)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 472)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(656, 446)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Organizer"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.rtb)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(656, 446)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "GetBehaviors"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(320, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 24)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Open Ini to get all Behaviors"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(256, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Chop"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Alphabetize"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open Inis to get all Behaviors"
        '
        'rtb
        '
        Me.rtb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb.Location = New System.Drawing.Point(8, 40)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(640, 400)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnBring)
        Me.TabPage3.Controls.Add(Me.rtb2)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(656, 446)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Get Behavior Properties"
        '
        'btnBring
        '
        Me.btnBring.Location = New System.Drawing.Point(8, 8)
        Me.btnBring.Name = "btnBring"
        Me.btnBring.Size = New System.Drawing.Size(168, 23)
        Me.btnBring.TabIndex = 2
        Me.btnBring.Text = "Bring Over Behaviors"
        '
        'rtb2
        '
        Me.rtb2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb2.Location = New System.Drawing.Point(8, 40)
        Me.rtb2.Name = "rtb2"
        Me.rtb2.Size = New System.Drawing.Size(640, 392)
        Me.rtb2.TabIndex = 1
        Me.rtb2.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(184, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnHTML)
        Me.TabPage4.Controls.Add(Me.col5)
        Me.TabPage4.Controls.Add(Me.col4)
        Me.TabPage4.Controls.Add(Me.col3)
        Me.TabPage4.Controls.Add(Me.col2)
        Me.TabPage4.Controls.Add(Me.col1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(656, 446)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "DataTableMaker HTML"
        '
        'btnHTML
        '
        Me.btnHTML.Location = New System.Drawing.Point(400, 0)
        Me.btnHTML.Name = "btnHTML"
        Me.btnHTML.Size = New System.Drawing.Size(96, 24)
        Me.btnHTML.TabIndex = 5
        Me.btnHTML.Text = "intoHTML"
        '
        'col5
        '
        Me.col5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.col5.Location = New System.Drawing.Point(400, 24)
        Me.col5.Name = "col5"
        Me.col5.Size = New System.Drawing.Size(248, 416)
        Me.col5.TabIndex = 4
        Me.col5.Text = ""
        Me.col5.WordWrap = False
        '
        'col4
        '
        Me.col4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.col4.Location = New System.Drawing.Point(288, 24)
        Me.col4.Name = "col4"
        Me.col4.Size = New System.Drawing.Size(96, 416)
        Me.col4.TabIndex = 3
        Me.col4.Text = ""
        Me.col4.WordWrap = False
        '
        'col3
        '
        Me.col3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.col3.Location = New System.Drawing.Point(192, 24)
        Me.col3.Name = "col3"
        Me.col3.Size = New System.Drawing.Size(96, 416)
        Me.col3.TabIndex = 2
        Me.col3.Text = ""
        Me.col3.WordWrap = False
        '
        'col2
        '
        Me.col2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.col2.Location = New System.Drawing.Point(96, 24)
        Me.col2.Name = "col2"
        Me.col2.Size = New System.Drawing.Size(96, 416)
        Me.col2.TabIndex = 1
        Me.col2.Text = ""
        Me.col2.WordWrap = False
        '
        'col1
        '
        Me.col1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.col1.Location = New System.Drawing.Point(0, 24)
        Me.col1.Name = "col1"
        Me.col1.Size = New System.Drawing.Size(96, 416)
        Me.col1.TabIndex = 0
        Me.col1.Text = ""
        Me.col1.WordWrap = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.rtbKP)
        Me.TabPage5.Controls.Add(Me.KP)
        Me.TabPage5.Controls.Add(Me.btnOpenKP)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(656, 446)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "kelso Project"
        '
        'btnOpenKP
        '
        Me.btnOpenKP.Location = New System.Drawing.Point(8, 8)
        Me.btnOpenKP.Name = "btnOpenKP"
        Me.btnOpenKP.TabIndex = 0
        Me.btnOpenKP.Text = "Open File"
        '
        'KP
        '
        Me.KP.Location = New System.Drawing.Point(88, 8)
        Me.KP.Name = "KP"
        Me.KP.Size = New System.Drawing.Size(560, 24)
        Me.KP.Step = 1
        Me.KP.TabIndex = 1
        '
        'rtbKP
        '
        Me.rtbKP.Location = New System.Drawing.Point(8, 40)
        Me.rtbKP.Name = "rtbKP"
        Me.rtbKP.Size = New System.Drawing.Size(640, 400)
        Me.rtbKP.TabIndex = 2
        Me.rtbKP.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 470)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "{IP}Gil-Galads Tester"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "FirstPage"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt1.Text = ""
        For i As Integer = 0 To ListBox1.Items.Count - 1
            txt1.Text &= vbTab & vbTab & ListBox1.Items.Item(i) & vbCrLf
        Next
    End Sub
#End Region
#Region "Secondpage"
    Private BehaviorsTotal As Integer
    Private BLoaded As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With FolderBrowserDialog1
            .Description = "Pick the folder where your ini files are located for BFME"
            If .ShowDialog = DialogResult.OK Then
                BehaviorsTotal = 0
                Application.DoEvents()
                GetFiles(.SelectedPath)
                Me.Text = "Total Behaviors = " & BehaviorsTotal
            End If
        End With
    End Sub
    Sub GetFiles(ByVal FilePath As String)
        Dim Folder() As String
        Dim Files() As String
        Dim En As Collections.IEnumerator
        Folder = IO.Directory.GetDirectories(FilePath)
        En = Folder.GetEnumerator
        While En.MoveNext
            GetFiles(CStr(En.Current))
        End While
        Files = IO.Directory.GetFiles(FilePath)
        En = Files.GetEnumerator
        While En.MoveNext
            SearchINIFile(CStr(En.Current))
        End While
    End Sub
    Sub SearchINIFile(ByVal FilePath As String)
        Dim Reader As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim Line As String
        Do While Reader.Peek <> -1
            Line = Reader.ReadLine.TrimStart.TrimEnd
            If Contain(Line, ";") = True Then
                Line = Line.Substring(0, Line.IndexOf(";")).TrimEnd
            End If
            If Line.TrimStart = "" Then
                GoTo SkipInfo
            End If
            If Line.ToLower.StartsWith("behavior") Then
                Me.Text = "Behaviors Loaded = " & BLoaded
                BLoaded += 1
                Dim Behavior As String
                Behavior = Line.Substring(Line.IndexOf("=") + 1).TrimEnd.TrimStart
                Behavior = Behavior.Replace(vbTab, " ")
                If Contain(Behavior, " ") = True Then
                    Behavior = Behavior.Substring(0, Behavior.IndexOf(" "))
                End If
                Compare(Behavior, rtb)
            End If
SkipInfo:
        Loop
        Reader.Close()
    End Sub
    Sub Compare(ByVal NewBehavior As String, ByVal rtb_ As RichTextBox)
        If ContainBehavior(rtb.Lines.Length, NewBehavior) = False Then
            rtb_.Text &= vbCrLf & NewBehavior
            ComboBox1.Items.Add(NewBehavior)
            BehaviorsTotal += 1
        End If
    End Sub
    Sub Chop()
        Application.DoEvents()
        Dim lst As New ListBox
        Dim NumLines As Integer = rtb.Lines.Length
        For i As Integer = 0 To NumLines - 1
            lst.Items.Add(rtb.Lines(i))
        Next
        rtb.Text = ""
        For i As Integer = 0 To NumLines - 1
            If ContainBehavior(rtb.Lines.Length, lst.Items.Item(i)) = False Then
                rtb.Text &= vbCrLf & lst.Items.Item(i)
            End If
        Next
    End Sub
    Function ContainBehavior(ByVal lines As Integer, ByVal behavior As String) As Boolean
        For i As Integer = 0 To lines - 1
            If rtb.Lines(i).ToLower = behavior.ToLower Then
                Return True
            End If
        Next
        Return False
    End Function
    Function Contain(ByVal line As String, ByVal str As String) As Boolean
        For i As Integer = 0 To line.Length - str.Length
            If line.Substring(i, str.Length) = str Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.DoEvents()
        Dim lst As New ListBox
        Dim NumLines As Integer = rtb.Lines.Length
        For i As Integer = 0 To NumLines - 1
            lst.Items.Add(rtb.Lines(i))
        Next
        lst.Sorted = True
        ComboBox1.Sorted = True
        rtb.Text = ""
        For i As Integer = 0 To NumLines - 1
            rtb.Text &= vbCrLf & lst.Items.Item(i)
        Next
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Chop()
    End Sub
#End Region
#Region "ThirdPage"
    Enum Types
        Int = 0
        Doubl = 1
        Bool = 2
        Str = 3
        OCL = 4
        Csf = 5
        KindOf = 6
        FX = 7
        Percent = 8
        Upgrade = 9
        Color = 10
        XYZ = 11
        Image = 12
        Sound = 13
        Combo = 14
    End Enum
    Private rtbs() As RichTextBox
    Private TotalBehavs As Integer
    Private Loaded As Integer
    Private Sub btnBring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBring.Click
        TotalBehavs = rtb.Lines.Length - 1
        Application.DoEvents()
        ReDim rtbs(TotalBehavs)
        For i As Integer = 0 To TotalBehavs
            rtbs(i) = New RichTextBox
            rtbs(i).Text = rtb.Lines(i)
        Next
        With FolderBrowserDialog1
            .Description = "Pick the folder where your ini files are located for BFME"
            If .ShowDialog = DialogResult.OK Then
                Application.DoEvents()
                Me.Text = "Searching..."
                GetFiles2(.SelectedPath)
                Me.Text = "Done"
            End If
        End With
    End Sub
    Sub GetFiles2(ByVal FilePath As String)
        Dim Folder() As String
        Dim Files() As String
        Dim En As Collections.IEnumerator
        Folder = IO.Directory.GetDirectories(FilePath)
        En = Folder.GetEnumerator
        While En.MoveNext
            GetFiles2(CStr(En.Current))
        End While
        Files = IO.Directory.GetFiles(FilePath)
        En = Files.GetEnumerator
        While En.MoveNext
            SearchINIFile2(CStr(En.Current))
        End While
    End Sub
    Sub SearchINIFile2(ByVal FilePath As String)
        Dim Reader As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim Line As String
        Do While Reader.Peek <> -1
            Line = Reader.ReadLine.TrimStart.TrimEnd
            If Contain(Line, ";") Then
                Line = Line.Substring(0, Line.IndexOf(";")).TrimEnd
            ElseIf Contain(Line, "/") Then
                Line = Line.Substring(0, Line.IndexOf("/")).TrimEnd
            End If
            If Line.TrimStart = "" Then
                GoTo SkipInfo
            End If
            If Line.ToLower.StartsWith("behavior") Then
                Dim Behavior As String
                Behavior = Line.Substring(Line.IndexOf("=") + 1).TrimEnd.TrimStart
                Behavior = Behavior.Replace(vbTab, " ")
                If Contain(Behavior, " ") = True Then
                    Behavior = Behavior.Substring(0, Behavior.IndexOf(" "))
                End If
                For i As Integer = 0 To TotalBehavs
                    If Behavior.ToLower.StartsWith(rtb.Lines(i).ToLower.TrimStart) Then
                        Me.Text = "Behaviors Found = " & Loaded
                        Loaded += 1
                        Dim line2 As String
                        line2 = Line
                        Do Until line2.TrimStart.ToLower.StartsWith("end")
                            line2 = Reader.ReadLine.TrimStart.TrimEnd
                            If Contain(line2, " ") = True Then
                                line2 = line2.Substring(0, line2.IndexOf(" "))
                            End If
                            Dim Extra As String
                            If Contain(line2, "=") = True Then
                                Dim Whatsthis As String = line2.Substring(line2.IndexOf("=") + 1).TrimStart.TrimEnd
                                Select Case IsType(Whatsthis, line2)
                                    Case Types.Bool
                                        Extra = "{boolean}"
                                    Case Types.Doubl
                                        Extra = "{double}"
                                    Case Types.Int
                                        Extra = "{integer}"
                                    Case Types.Str
                                        Extra = "{string}"
                                    Case Types.Csf
                                        Extra = "{lotr.csf}"
                                    Case Types.KindOf
                                        Extra = "{kindof}"
                                    Case Types.OCL
                                        Extra = "{ocl}"
                                    Case Types.FX
                                        Extra = "{fx}"
                                    Case Types.Percent
                                        Extra = "{percent}"
                                    Case Types.Combo
                                        Extra = IsCombo(Whatsthis, line2)
                                    Case Types.Upgrade
                                        Extra = "{upgrade}"
                                    Case Types.Color
                                        Extra = "{color}"
                                    Case Types.XYZ
                                        Extra = "{vector}"
                                    Case Types.Image
                                        Extra = "{image}"
                                    Case Types.Sound
                                        Extra = "{sound}"
                                End Select
                            End If
                            Compare2(line2 & " " & Extra, rtbs(i))
                        Loop
                        line2 = ""
                        Exit For
                    End If
                Next
            End If
SkipInfo:
        Loop
        Reader.Close()
    End Sub
    Sub Compare2(ByVal BehavInfo As String, ByVal rtb_ As RichTextBox)
        If IsInThere(BehavInfo, rtb_) = False Then
            rtb_.Text &= vbCrLf & BehavInfo
        End If
    End Sub
    Function IsInThere(ByVal str As String, ByVal rtb As RichTextBox) As Boolean
        For i As Integer = 0 To rtb.Lines.Length - 1
            If rtb.Lines(i).TrimStart.ToLower.StartsWith(str.ToLower) = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Function IsType(ByVal line As String, ByVal wholeline As String) As Types
        line = line.TrimStart.TrimEnd
        If IsColor(line) Then
            Return Types.Color
        ElseIf IsVector(line) Then
            Return Types.XYZ
        ElseIf IsElse(line, wholeline, Types.Combo) Then
            Return Types.Combo
        ElseIf IsElse(line, wholeline, Types.Percent) Then
            Return Types.Percent
        ElseIf IsElse(line, wholeline, Types.Image) Then
            Return Types.Image
        ElseIf IsElse(line, wholeline, Types.Doubl) Then
            Return Types.Doubl
        ElseIf IsNumber(line) Then
            Return Types.Int
        ElseIf IsBoolean(line) Then
            Return Types.Bool
        ElseIf IsElse(line, wholeline, Types.Sound) Then
            Return Types.Sound
        ElseIf IsElse(line, wholeline, Types.Csf) And IsNumber(line.Substring(line.IndexOf(":") + 1)) Then
            Return Types.Int
        ElseIf IsElse(line, wholeline, Types.Csf) Then
            Return Types.Csf
        ElseIf IsKindOf(line, wholeline) Then
            Return Types.KindOf
        ElseIf IsElse(line, wholeline, Types.Upgrade) Then
            Return Types.Upgrade
        ElseIf IsElse(line, wholeline, Types.FX) Then
            Return Types.FX
        ElseIf IsElse(line, wholeline, Types.OCL) Then
            Return Types.OCL
        Else
            Return Types.Str
        End If
    End Function
    Function IsNumber(ByVal line As String) As Boolean
        line = line.TrimStart.TrimEnd.Replace(" ", "")
        Dim nums As Integer() = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim values As Integer
        For i As Integer = 0 To line.Length - 1
            For ii As Integer = 0 To nums.Length - 1
                If line.Substring(i, 1).StartsWith(nums(ii)) Then
                    values += 1
                End If
            Next
        Next
        If values >= line.Length Then
            Return True
        End If
        Return False
    End Function
    Function IsCombo(ByVal line As String, ByVal wholeline As String) As String
        Dim Spaces As Integer
        Dim IndividualStrs() As String
        Dim StrsTypes() As Types
        For i As Integer = 0 To line.Length - 1
            If line.Substring(i, 1) = " " Then
                Spaces += 1
            End If
        Next
        If Spaces = 0 Then
            Exit Function
        End If
        ReDim IndividualStrs(Spaces)
        For i As Integer = 0 To Spaces
            IndividualStrs(i) = ""
        Next
        ReDim StrsTypes(Spaces)
        Select Case Spaces
            Case 1
                IndividualStrs(0) = line.Substring(0, line.IndexOf(" "))
                IndividualStrs(1) = line.Substring(line.IndexOf(" ") + 1)
            Case Is >= 2
                Dim Spots(Spaces) As Integer
                Dim CurrSpot As Integer = 0
                Spots(0) = 0
                For i As Integer = 0 To line.Length - 1
                    If line.Substring(i, 1) = " " Then
                        CurrSpot += 1
                        Spots(CurrSpot) = i
                    End If
                Next
                IndividualStrs(0) = line.Substring(0, Spots(0))
                For i As Integer = 1 To Spaces - 1
                    IndividualStrs(i) = line.Substring(Spots(i), Spots(i + 1) - Spots(i) - 1)
                Next
                IndividualStrs(Spaces) = line.Substring(line.LastIndexOf(" ") + 1)
        End Select
        For i As Integer = 0 To Spaces
            For ii As Integer = 0 To 11
                If IsType(IndividualStrs(i).TrimStart.TrimEnd, wholeline) = ii Then
                    StrsTypes(i) = ii
                End If
            Next
        Next
        Dim FinalStr As String
        For i As Integer = 0 To Spaces
            Select Case StrsTypes(i)
                Case Types.Bool
                    FinalStr &= "{boolean} "
                Case Types.Doubl
                    FinalStr &= "{double} "
                Case Types.Int
                    FinalStr &= "{integer} "
                Case Types.Str
                    FinalStr &= "{string} "
                Case Types.Csf
                    FinalStr &= "{lotr.csf} "
                Case Types.KindOf
                    FinalStr &= "{kindof} "
                Case Types.OCL
                    FinalStr &= "{ocl} "
                Case Types.FX
                    FinalStr &= "{fx} "
                Case Types.Percent
                    FinalStr &= "{percent} "
                Case Types.Upgrade
                    FinalStr &= "{upgrade} "
                Case Types.Color
                    FinalStr &= "{color} "
                Case Types.XYZ
                    FinalStr &= "{vector} "
                Case Types.Sound
                    FinalStr &= "{sound} "
                Case Types.Image
                    FinalStr &= "{image} "
            End Select
        Next
        Return FinalStr.TrimEnd
    End Function
    Function IsColor(ByVal line As String) As Boolean
        Dim Coords As String() = {"r:", "g:", "b:"}
        line = line.TrimStart.TrimEnd
        Dim Occurences As Integer
        For i As Integer = 0 To 2
            If Contain(line.ToLower, Coords(i)) Then
                Occurences += 1
            End If
        Next
        If Occurences = 3 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function IsVector(ByVal line As String) As Boolean
        Dim Coords As String() = {"x:", "y:", "z:"}
        Dim Occurences As Integer
        For i As Integer = 0 To 2
            If Contain(line.ToLower, Coords(i)) Then
                Occurences += 1
            End If
        Next
        If Occurences = 3 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function IsBoolean(ByVal line As String) As Boolean
        If line.ToLower.EndsWith("no") Then
            Return True
        ElseIf line.ToLower.EndsWith("yes") Then
            Return True
        Else : Return False
        End If
    End Function
    Function IsKindOf(ByVal line As String, ByVal wholeline As String) As Boolean
        Dim kinds As String() = {"ALL", "NONE", "+", "-"}
        If Contain(wholeline.ToLower, "filter") Then
            Return True
        End If
        For i As Integer = 0 To 3
            If Contain(line, kinds(i)) Then
                Return True
            End If
        Next
        Return False
    End Function
    Function IsElse(ByVal line As String, ByVal wholeline As String, ByVal type As Types) As Boolean
        Select Case type
            Case Types.Upgrade
                If Contain(wholeline.ToLower, "upgrade") Then
                    Return True
                End If
            Case Types.FX
                If Contain(wholeline.ToLower, "fx") Then
                    Return True
                End If
            Case Types.OCL
                If Contain(wholeline.ToLower, "ocl") Then
                    Return True
                End If
            Case Types.Doubl
                If Contain(line, ".") Then
                    Return True
                End If
            Case Types.Percent
                If Contain(line, "%") Then
                    Return True
                End If
            Case Types.Csf
                If Contain(line, ":") Then
                    Return True
                End If
            Case Types.Combo
                If Contain(line.TrimStart.TrimEnd, " ") Then
                    Return True
                End If
            Case Types.Image
                If Contain(wholeline.ToLower, "image") Or Contain(wholeline.ToLower, "portrait") Then
                    Return True
                End If
            Case Types.Sound
                If Contain(wholeline.ToLower, "sound") Or Contain(wholeline.ToLower, "voice") Then
                    Return True
                End If
        End Select
        Return False
    End Function


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        rtb2 = rtbs(ComboBox1.SelectedIndex)
        Me.Text = "Selected Behavior = " & ComboBox1.SelectedItem
    End Sub
#End Region
#Region "FourthPage"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With OpenFileDialog1
            .InitialDirectory = "F:\BIG\DATA\"
            .FilterIndex = 1
            .Filter = "All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Select Case .FileName.Substring(.FileName.LastIndexOf(".") + 1).ToLower
                    Case "ini"
                        BehaviorsTotal = 0
                        Application.DoEvents()
                        SearchINIFile(.FileName)
                        Me.Text = "Total Behaviors = " & BehaviorsTotal
                End Select
            End If
        End With
    End Sub

    Private Sub btnHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHTML.Click
        col5.Text = GetHTML()
    End Sub
    Function GetHTML() As String
        Dim SB As New IO.StringWriter
        Dim MaxLines As Integer = GetHighestLines() - 1
        For i As Integer = 0 To MaxLines
            SB.WriteLine("<tr>")
            If col1.Lines.Length - 1 <= MaxLines Then
                SB.WriteLine(vbTab & "<td>" & col1.Lines(i).TrimStart & "</td>")
            Else
                SB.WriteLine(vbTab & "<td>&nbsp;</td>")
            End If
            If col2.Lines.Length - 1 <= MaxLines Then
                SB.WriteLine(vbTab & "<td>" & col2.Lines(i).TrimStart & "</td>")
            Else
                SB.WriteLine(vbTab & "<td>&nbsp;</td>")
            End If
            If col3.Lines.Length - 1 <= MaxLines Then
                SB.WriteLine(vbTab & "<td>" & col3.Lines(i).TrimStart & "</td>")
            Else
                SB.WriteLine(vbTab & "<td>&nbsp;</td>")
            End If
            If col4.Lines.Length - 1 <= MaxLines Then
                SB.WriteLine(vbTab & "<td>" & col4.Lines(i).TrimStart & "</td>")
            Else
                SB.WriteLine(vbTab & "<td>&nbsp;</td>")
            End If
            SB.WriteLine("</tr>")
        Next
        Return SB.ToString
    End Function
    Function GetHighestLines() As Integer
        Dim HighNum As Integer
        Dim rtbs As RichTextBox() = {col1, col2, col3, col4}
        For i As Integer = 0 To 3
            If rtbs(i).Lines.Length > HighNum Then
                HighNum = rtbs(i).Lines.Length
            End If
        Next
        Return HighNum
    End Function
#End Region
    Private Sub btnOpenKP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenKP.Click
        With OpenFileDialog1
            .InitialDirectory = "F:\BIG\DATA\"
            .FilterIndex = 1
            .Filter = "All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Select Case .FileName.Substring(.FileName.LastIndexOf(".") + 1).ToLower
                    Case "txt", "ini", "inc"
                        Application.DoEvents()
                        SearchFile(.FileName)
                End Select
            End If
        End With
    End Sub
    Enum BT
        Str = 0
        Int = 1
        Bool = 2
        Brackets = 3
        Sound = 4
        FX = 5
        OCL = 6
        KindOf = 7
        CSF = 8
        Percent = 9
        Upgrade = 10
        Doubl = 11
        Vector = 12
        Color = 13
        Image = 14
    End Enum
    Structure BehavType
        Dim Name As String
        Dim Type As BT
    End Structure
    Structure Behav
        Dim Name As String
        Dim Type() As BehavType
    End Structure
    Private Behavs(1000) As Behav
    Private CurrentBehav As Integer = -1
    Private TotalBehavTypes As Integer
    Sub FormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 1000
            Behavs(i) = New Behav
        Next
    End Sub
    Sub SearchFile(ByVal FilePath As String)
        Dim SR As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim SW As New IO.StringWriter
        Dim Ln, ModLn, TrimLn, LwrLn As String
        Do While SR.Peek <> -1
            Ln = SR.ReadLine.TrimEnd
            TrimLn = Ln.TrimStart
            LwrLn = Ln.ToLower
            ModLn = TrimLn.Replace(vbTab, "").Replace(" ", "")
            If LwrLn.StartsWith("<!|") Then
                Ln = SR.ReadLine
                CurrentBehav += 1
                TotalBehavTypes = -1
                Do Until Ln.TrimStart.TrimEnd = ""
                    If Contain(Ln, "=") Then
                        TotalBehavTypes += 1
                        ReDim Preserve Behavs(CurrentBehav).Type(TotalBehavTypes)
                        Behavs(CurrentBehav).Type(TotalBehavTypes).Name = GetTypeName(Ln)
                    End If
                    Ln = SR.ReadLine
                Loop
            End If
        Loop
    End Sub
    Function GetTypeName(ByVal Ln As String) As String
        Ln = Ln.TrimStart.TrimEnd
        Dim ReturnStr As String = Ln.Substring(0, Ln.IndexOf("=")).TrimEnd
        Return ReturnStr
    End Function
    Function GetTypeType(ByVal Ln As String) As BT
        Ln = Ln.Substring(Ln.IndexOf("=") + 1).TrimStart.TrimEnd.ToLower
        If Ln.StartsWith("{string}") Then

        End If
    End Function
End Class
Class Main
    Sub GetFiles(ByVal FileRoot As String)
        Dim dir() As String
        Dim files() As String
        Dim en As Collections.IEnumerator
        dir = IO.Directory.GetDirectories(FileRoot)
        en = dir.GetEnumerator
        While en.MoveNext
            GetFiles(CStr(en.Current))
        End While
        files = IO.Directory.GetFiles(FileRoot)
        en = files.GetEnumerator
        While en.MoveNext
            'SearchINI(CStr(en.Current))
        End While
    End Sub


    Private WithEvents tmr As Timer
    Private Proc As Process
    Sub Test(ByVal FilePath As String)
        If IO.File.Exists(FilePath) = True Then
            Proc = New Process
            Proc.Start(FilePath)
            With tmr
                .Interval = 300000 'Every 5 minutes
                .Enabled = True
            End With
        Else
            MsgBox("Bfme exe not found")
        End If
    End Sub
    Sub CheckProcess(ByVal Proc As Process)
        If Proc.HasExited = True Then

        End If
    End Sub
    Sub tmrTick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        CheckProcess(Proc)
    End Sub


End Class