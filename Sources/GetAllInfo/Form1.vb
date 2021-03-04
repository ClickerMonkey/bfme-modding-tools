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
    Friend WithEvents cmbInfo As System.Windows.Forms.ComboBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lstView As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbInfo = New System.Windows.Forms.ComboBox
        Me.btnOpen = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.lstView = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbInfo
        '
        Me.cmbInfo.Items.AddRange(New Object() {"AmbientStream", "Animation2d", "Armor", "BannerUI", "CommandButton", "CommandSet", "Crate", "DamageFX", "DebugCommandMap", "Emotions", "Eva", "ExperienceLevels", "FXList", "FXParticleSystem", "Gamedata", "Locomotors", "ModifierList", "ObjectCreationList", "ParticleSystem", "PlayerAIType", "PlayerTemplate", "Science", "SpecialPower", "Upgrade", "Weapons", "Objects", "ChildObjects", "ObjectReskins"})
        Me.cmbInfo.Location = New System.Drawing.Point(8, 48)
        Me.cmbInfo.Name = "cmbInfo"
        Me.cmbInfo.Size = New System.Drawing.Size(312, 21)
        Me.cmbInfo.TabIndex = 0
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(8, 8)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(312, 32)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Open Folder"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the folder that contains all the inis"
        '
        'lstView
        '
        Me.lstView.HorizontalScrollbar = True
        Me.lstView.IntegralHeight = False
        Me.lstView.Location = New System.Drawing.Point(8, 104)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(312, 96)
        Me.lstView.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Inis Loaded"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 438)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.cmbInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        With FolderBrowserDialog1
            If .ShowDialog = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Application.DoEvents()
                GetFiles(.SelectedPath)
                For i As Integer = 0 To lstView.Items.Count - 1
                    SearchINI(lstView.Items.Item(i))
                Next
                Cursor = Cursors.Default
            End If
        End With
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
                lstView.Items.Add(line) 'line.Substring(line.LastIndexOf("\") + 1)) ', line.LastIndexOf(".") - line.LastIndexOf("\") - 1))
            End If
        End While
        en = Dir.GetEnumerator
        While en.MoveNext
            GetFiles(CStr(en.Current))
        End While
    End Sub
    Sub SearchINI(ByVal Path As String)
        Dim str As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i"}
        Dim enumerator As Collections.IEnumerator
        enumerator = str.GetEnumerator
        Dim msg As String = Path
        While enumerator.MoveNext
            msg &= vbCrLf & CStr(enumerator.Current)
        End While
        MsgBox(msg)
    End Sub
    Function Contain(ByVal line As String, ByVal str As String) As Boolean
        For i As Integer = 0 To line.Length - str.Length
            If line.Substring(i, str.Length) = str Then
                Return True
            End If
        Next
        Return False
    End Function
End Class

