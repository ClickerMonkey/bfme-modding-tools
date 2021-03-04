Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Public Class MainForm
    Public PS As ParticleSystem
    Public Started As Boolean
    Public Paused As Boolean
    Public DrawnText As String
    Public Help As Boolean
    Public RedArrow As Arrow '//X=Left
    Public GreenArrow As Arrow '//Y=Back
    Public BlueArrow As Arrow '//Z=Up
    Public ArrowsHidden As Boolean
    '//Defaults
    Public SceneBackColor As Color = Color.Black
    Public CurrentFloor As String = "GrassBig"
    Public CurrentFont As String = "Mystorica"
    Public FontsFolder As String = Application.StartupPath & "\Fonts\"
    Public ParticlesFolder As String = Application.StartupPath & "\Particles\"
    Public FloorsFolder As String = Application.StartupPath & "\Floors\"
    Public ConfigFolder As String = Application.StartupPath & "\Config\"

    Private Sub Particle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Box.HelpRectangle = New Rectangle(2, 2, 80, 20)
        '//Load Defaults
        LoadDefaults()
        '//Create Error Handler for Critical Errors
        AddHandler GameError.ErrorThrown, AddressOf ErrorThrown
        GameError.Initialize()
        '//Initialize Scene
        Scene.Initialize(Box)
        '//Arrows
        RedArrow = New Arrow(Color.Red, 0.4)
        GreenArrow = New Arrow(Color.Green, 0.4)
        BlueArrow = New Arrow(Color.Blue, 0.4)
        BlueArrow.RotationY = 90
        RedArrow.RotationY = -90
        RedArrow.RotationX = -90
        '//LoadFonts
        Dim Fonts() As String = Media.GetFilesWithExtension(FontsFolder, ".bmp")
        Dim FontFiles() As String = Media.GetFilesWithExtension(FontsFolder, ".txt")
        For Each Font As String In Fonts
            TextureManager.Add(Font, Media.GetFileName(Font), Color.Black, 1024, 1024)
        Next
        For Each FontFile As String In FontFiles
            FontManager.Add(Media.GetFileName(FontFile), Media.GetFileName(FontFile), FontFile, 10, 1.0F, 1.0F)
        Next
        '//Load Particles
        ParticleName.Items.Clear()
        Dim Files() As String = Media.GetFiles(ParticlesFolder)
        For Each File As String In Files
            TextureManager.Add(File, Media.GetFileName(File), Color.Black, 64, 64)
            ParticleName.Items.Add(Media.GetFileName(File))
        Next
        '//LoadFloors
        Dim Floors() As String = Media.GetFiles(FloorsFolder)
        For Each F As String In Floors
            TextureManager.Add(F, Media.GetFileName(F), Color.Black, 0, 0)
        Next
        Floor.Initialize()
        Floor.Texture = CurrentFloor
        '//ParticleSystem
        Dim PSI As New ParticleSystemInfo
        PSI.Import(ConfigFolder & "ParticleSystem.xml")
        PS = New ParticleSystem(PSI)
        AddHandler Box.Render, AddressOf Box_Render
        AddHandler Box.HelpPressed, AddressOf Box_Help
        SetUI()
        LoadUI()
        Scene.Begin()
        Started = True
        ParticleName.SelectedIndex = 0
        Me.UpdateStyles()
        Me.tabOptions.BringToFront()
        Me.tabOptions.Invalidate()
        Me.Show()
        Box.Invalidate()
    End Sub
    Private Sub Box_Render()
        If Paused Then Return
        Try
            Scene.StartScene(SceneBackColor)
            Scene.LocalDevice.Transform.View = Box.ViewMatrix
            Scene.LocalDevice.Transform.Projection = Matrix.PerspectiveFovLH(Math.PI / 4, Box.Width / Box.Height, 1.0, 5000.0)
            Scene.LocalDevice.Transform.World = Matrix.Identity
            Floor.Render()
            PS.Update()
            PS.Render()
            If Not ArrowsHidden Then
                '//Update
                RedArrow.Location = New Vector3(PS.Info.Location.X, PS.Info.Location.Z, PS.Info.Location.Y)
                GreenArrow.Location = New Vector3(PS.Info.Location.X, PS.Info.Location.Z, PS.Info.Location.Y)
                BlueArrow.Location = New Vector3(PS.Info.Location.X, PS.Info.Location.Z, PS.Info.Location.Y)
                If Box.LockView Then
                    RedArrow.SetRotationMatrix(Box.OtherMatrix)
                    GreenArrow.SetRotationMatrix(Box.OtherMatrix)
                    BlueArrow.SetRotationMatrix(Box.OtherMatrix)
                    PS.SetRotation(Box.OtherTheta, Box.OtherOmega)
                End If
                '//Render
                RedArrow.Render()
                GreenArrow.Render()
                BlueArrow.Render()
            End If
            If Help Then
                DrawnText = "Hide Help [H]" & vbCrLf & _
                            "ParticlesAlive: " & PS.ParticlesAlive & vbCrLf & _
                            "FramesPerSecond: " & Scene.FramesPerSecond & vbCrLf & _
                            "Left Mouse Button: 'Look Around'" & vbCrLf & _
                            "Right Mouse Button: 'Move Horizontally'" & vbCrLf & _
                            "Middle Mouse Button: 'Move Vertically" & vbCrLf & _
                            "Lock View: [L]" & vbCrLf & _
                            "Hide Arrows: [A]" & vbCrLf & _
                            "Made by Philip Diffenderfer aka {IP}Gil-Galad"
            Else
                DrawnText = "Show Help [H]"
            End If
            FontManager.Render(CurrentFont, DrawnText, 20, 2, 2, Color.Goldenrod)
            FontManager.Render("RingBearer", "The Lord of the Rings The Battle for Middle Earth", 20, 10, Box.Height - 25, Color.FromArgb(122, Color.Goldenrod))
        Catch ex As Exception
            GameError.Raise(GameError.ErrorType.ErrorRendering, GameError.ErrorSeverity.Critical, GetType(MainForm), "Error Rendering" & vbCrLf & "More Info: " & ex.Message)
        Finally
            Scene.EndScene()
            Box.Invalidate()
        End Try
    End Sub
    Private Sub Box_Help()
        Help = Not Help
    End Sub
    Private Sub Particle_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Scene.WindowResized()
        If Not (Scene.LocalDevice Is Nothing) Then
            Floor.Initialize()
            PS.Resized()
            RedArrow.ResetVertexBuffer()
            RedArrow.ResetIndexBuffer()
            GreenArrow.ResetVertexBuffer()
            GreenArrow.ResetIndexBuffer()
            BlueArrow.ResetVertexBuffer()
            BlueArrow.ResetIndexBuffer()
        End If
    End Sub
    Private Sub Particle_KeyDown(ByVal Sender As Object, ByVal E As KeyEventArgs)
        Select Case E.KeyCode
            Case Keys.H
                Help = Not Help
            Case Keys.U
                Me.UpdateStyles()
                Me.tabOptions.BringToFront()
                Me.tabOptions.Invalidate()
            Case Keys.L
                Box.LockView = Not Box.LockView
            Case Keys.A
                ArrowsHidden = Not ArrowsHidden
        End Select
    End Sub
    Private Sub Particle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Scene.Dispose()
        GameError.Dispose()
        SaveDefaults()
    End Sub

    Private Sub SetUI()
        '//ComboBoxes
        Priority.Items.Clear()
        For I As Integer = 0 To 12
            Priority.Items.Add(CType(I, ParticleSystemInfo.Priorities).ToString)
        Next
        Shader.Items.Clear()
        For I As Integer = 0 To 1
            Shader.Items.Add(CType(I, ParticleSystemInfo.Shaders).ToString)
        Next
        SortLevel.Items.Clear()
        For I As Integer = 0 To 1
            SortLevel.Items.Add(I)
        Next
        VelocityType.Items.Clear()
        For I As Integer = 0 To 2
            VelocityType.Items.Add(CType(I, ParticleSystemInfo.EmissionVelocityType).ToString)
        Next
        VolumeType.Items.Clear()
        For I As Integer = 0 To 4
            VolumeType.Items.Add(CType(I, ParticleSystemInfo.EmissionVolumeType).ToString)
        Next
        UpdateUI()
    End Sub
    Private Sub LoadUI()
        '//Alphas
        AddHandler Alpha1.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha2.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha3.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha4.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha5.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha6.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha7.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha8.ValueChanged, AddressOf AlphasValueChanged
        AddHandler Alpha1.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha2.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha3.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha4.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha5.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha6.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha7.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha8.DialogPopUp, AddressOf DialogUP
        AddHandler Alpha1.DialogPopDown, AddressOf DialogDOWN
        AddHandler Alpha2.DialogPopDown, AddressOf DialogDOWN
        AddHandler Alpha3.DialogPopDown, AddressOf DialogDOWN
        AddHandler Alpha4.DialogPopDown, AddressOf DialogDOWN
        AddHandler Alpha5.DialogPopDown, AddressOf DialogDOWN
        AddHandler Alpha6.DialogPopDown, AddressOf DialogDOWN
        AddHandler Alpha7.DialogPopDown, AddressOf DialogDOWN
        AddHandler Alpha8.DialogPopDown, AddressOf DialogDOWN
        '//Colors
        AddHandler Color1.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color2.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color3.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color4.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color5.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color6.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color7.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color8.ValueChanged, AddressOf ColorsValueChanged
        AddHandler Color1.DialogPopUp, AddressOf DialogUP
        AddHandler Color2.DialogPopUp, AddressOf DialogUP
        AddHandler Color3.DialogPopUp, AddressOf DialogUP
        AddHandler Color4.DialogPopUp, AddressOf DialogUP
        AddHandler Color5.DialogPopUp, AddressOf DialogUP
        AddHandler Color6.DialogPopUp, AddressOf DialogUP
        AddHandler Color7.DialogPopUp, AddressOf DialogUP
        AddHandler Color8.DialogPopUp, AddressOf DialogUP
        AddHandler Color1.DialogPopDown, AddressOf DialogDOWN
        AddHandler Color2.DialogPopDown, AddressOf DialogDOWN
        AddHandler Color3.DialogPopDown, AddressOf DialogDOWN
        AddHandler Color4.DialogPopDown, AddressOf DialogDOWN
        AddHandler Color5.DialogPopDown, AddressOf DialogDOWN
        AddHandler Color6.DialogPopDown, AddressOf DialogDOWN
        AddHandler Color7.DialogPopDown, AddressOf DialogDOWN
        AddHandler Color8.DialogPopDown, AddressOf DialogDOWN
        '//Ranges
        AddHandler AngleZ.ValueChanged, AddressOf RangeValueChanged
        AddHandler AngularDamping.ValueChanged, AddressOf RangeValueChanged
        AddHandler AngularRateZ.ValueChanged, AddressOf RangeValueChanged
        AddHandler BurstCount.ValueChanged, AddressOf RangeValueChanged
        AddHandler BurstDelay.ValueChanged, AddressOf RangeValueChanged
        AddHandler Gravity.ValueChanged, AddressOf RangeValueChanged
        AddHandler InitialDelay.ValueChanged, AddressOf RangeValueChanged
        AddHandler Lifetime.ValueChanged, AddressOf RangeValueChanged
        AddHandler Normal.ValueChanged, AddressOf RangeValueChanged
        AddHandler PSize.ValueChanged, AddressOf RangeValueChanged
        AddHandler Radial.ValueChanged, AddressOf RangeValueChanged
        AddHandler RadiusRate.ValueChanged, AddressOf RangeValueChanged
        AddHandler SizeRate.ValueChanged, AddressOf RangeValueChanged
        AddHandler SizeRateDamping.ValueChanged, AddressOf RangeValueChanged
        AddHandler Speed.ValueChanged, AddressOf RangeValueChanged
        AddHandler VelocityDamping.ValueChanged, AddressOf RangeValueChanged
        AddHandler X.ValueChanged, AddressOf RangeValueChanged
        AddHandler Y.ValueChanged, AddressOf RangeValueChanged
        AddHandler Z.ValueChanged, AddressOf RangeValueChanged
        '//Vectors
        AddHandler DriftVelocity.ValueChanged, AddressOf VectorsValueChanged
        AddHandler Halfsize.ValueChanged, AddressOf VectorsValueChanged
        AddHandler StartPoint.ValueChanged, AddressOf VectorsValueChanged
        AddHandler EndPoint.ValueChanged, AddressOf VectorsValueChanged
        AddHandler Offset.ValueChanged, AddressOf VectorsValueChanged
        AddHandler SystemLocation.ValueChanged, AddressOf VectorsValueChanged
        SystemLocation.RaiseChange()
        '//CheckBoxes
        AddHandler BoxIsHollow.CheckedChanged, AddressOf CheckBoxesChanged
        AddHandler CylinderIsHollow.CheckedChanged, AddressOf CheckBoxesChanged
        AddHandler LineIsHollow.CheckedChanged, AddressOf CheckBoxesChanged
        AddHandler PointIsHollow.CheckedChanged, AddressOf CheckBoxesChanged
        AddHandler SphereIsHollow.CheckedChanged, AddressOf CheckBoxesChanged
        AddHandler IsOneShot.CheckedChanged, AddressOf CheckBoxesChanged
        AddHandler IsGroundAligned.CheckedChanged, AddressOf CheckBoxesChanged
        '//AddHandler IsOneShot.CheckedChanged, AddressOf CheckBoxesChanged
        '//ComboBoxes
        '//Textboxes
        AddHandler CylinderRadius.KeyPress, AddressOf TextboxKeyPress
        AddHandler Length.KeyPress, AddressOf TextboxKeyPress
        AddHandler SphereRadius.KeyPress, AddressOf TextboxKeyPress
        AddHandler SystemLifetime.KeyPress, AddressOf TextboxKeyPress

        For Each C As Control In Me.Controls
            AddHandler C.KeyDown, AddressOf Particle_KeyDown
        Next
    End Sub
    Private Sub UpdateUI()
        '//Alphas
        Me.Alpha1.SetValues(PS.Info.Alphas(0))
        Me.Alpha2.SetValues(PS.Info.Alphas(1))
        Me.Alpha3.SetValues(PS.Info.Alphas(2))
        Me.Alpha4.SetValues(PS.Info.Alphas(3))
        Me.Alpha5.SetValues(PS.Info.Alphas(4))
        Me.Alpha6.SetValues(PS.Info.Alphas(5))
        Me.Alpha7.SetValues(PS.Info.Alphas(6))
        Me.Alpha8.SetValues(PS.Info.Alphas(7))
        '//Colors
        Me.Color1.SetValues(PS.Info.Colors(0))
        Me.Color2.SetValues(PS.Info.Colors(1))
        Me.Color3.SetValues(PS.Info.Colors(2))
        Me.Color4.SetValues(PS.Info.Colors(3))
        Me.Color5.SetValues(PS.Info.Colors(4))
        Me.Color6.SetValues(PS.Info.Colors(5))
        Me.Color7.SetValues(PS.Info.Colors(6))
        Me.Color8.SetValues(PS.Info.Colors(7))
        '//Ranges
        Me.AngleZ.SetValues(PS.Info.AngleZ)
        Me.AngularDamping.SetValues(PS.Info.AngularDamping)
        Me.AngularRateZ.SetValues(PS.Info.AngularRateZ)
        Me.BurstCount.SetValues(PS.Info.BurstCount)
        Me.BurstDelay.SetValues(PS.Info.BurstDelay)
        Me.Gravity.SetValues(PS.Info.Gravity)
        Me.InitialDelay.SetValues(PS.Info.InitialDelay)
        Me.Lifetime.SetValues(PS.Info.Lifetime)
        Me.Normal.SetValues(PS.Info.Normal)
        Me.Radial.SetValues(PS.Info.Radial)
        Me.RadiusRate.SetValues(PS.Info.RadiusRate)
        Me.PSize.SetValues(PS.Info.Size)
        Me.SizeRate.SetValues(PS.Info.SizeRate)
        Me.SizeRateDamping.SetValues(PS.Info.SizeRateDamping)
        Me.VelocityDamping.SetValues(PS.Info.VelocityDamping)
        Me.X.SetValues(PS.Info.X)
        Me.Y.SetValues(PS.Info.Y)
        Me.Z.SetValues(PS.Info.Z)
        '//Vectors
        Me.EndPoint.SetValues(PS.Info.EndPoint)
        Me.StartPoint.SetValues(PS.Info.StartPoint)
        Me.Offset.SetValues(PS.Info.Offset)
        Me.DriftVelocity.SetValues(PS.Info.DriftVelocity)
        Me.SystemLocation.SetValues(PS.Info.Location)
        '//TextBoxes
        Me.CylinderRadius.Text = PS.Info.Radius
        Me.Length.Text = PS.Info.Radius
        Me.SphereRadius.Text = PS.Info.Radius
        Me.SystemLifetime.Text = PS.Info.SystemLifetime
        Me.ParticleSystemName.Text = PS.Info.ParticleSystemName
        '//CheckBoxes
        Me.BoxIsHollow.Checked = PS.Info.IsHollow
        Me.LineIsHollow.Checked = PS.Info.IsHollow
        Me.SphereIsHollow.Checked = PS.Info.IsHollow
        Me.PointIsHollow.Checked = PS.Info.IsHollow
        Me.CylinderIsHollow.Checked = PS.Info.IsHollow
        Me.IsOneShot.Checked = PS.Info.IsOneShot
        Me.IsGroundAligned.Checked = PS.Info.IsGroundAligned
        Me.Priority.SelectedIndex = PS.Info.Priority
        Me.Priority.Text = PS.Info.Priority.ToString
        Me.Shader.SelectedIndex = PS.Info.Shader
        Me.Shader.Text = PS.Info.Shader.ToString
        Me.SortLevel.SelectedIndex = PS.Info.SortLevel
        Me.SortLevel.Text = PS.Info.SortLevel.ToString
        Me.VolumeType.SelectedIndex = PS.Info.EmissionVolume
        Me.VolumeType.Text = PS.Info.EmissionVolume.ToString
        Me.tabVolume.SelectedTab = tabVolume.TabPages.Item(PS.Info.EmissionVolume)
        Me.VelocityType.SelectedIndex = PS.Info.EmissionVelocity
        Me.VelocityType.Text = PS.Info.EmissionVelocity.ToString
        Me.tabVelocity.SelectedTab = tabVelocity.TabPages.Item(PS.Info.EmissionVelocity)

        Me.RedArrow.SetRotationMatrix(Matrix.Identity)
        Me.BlueArrow.SetRotationMatrix(Matrix.Identity)
        Me.GreenArrow.SetRotationMatrix(Matrix.Identity)
    End Sub
    Private Sub AlphasValueChanged(ByVal Sender As AlphaHolder)
        If Started Then
            Dim Index As Integer
            Try
                Index = Sender.Name.Substring(Sender.Name.Length - 1, 1) - 1
                PS.Info.Alphas(Index) = ParticleSystemInfo.CreateAlphaTime(Sender.AlphaMin, Sender.AlphaMax, Sender.Time)
            Catch
                GameError.Raise(GameError.ErrorType.ErrorParsing, GameError.ErrorSeverity.Notice, GetType(MainForm), "Error setting Alpha" & (Index + 1))
            End Try
        End If
    End Sub
    Private Sub ColorsValueChanged(ByVal Sender As ColorHolder)
        If Started Then
            Dim Index As Integer
            Try
                Index = Sender.Name.Substring(Sender.Name.Length - 1, 1) - 1
                PS.Info.Colors(Index) = ParticleSystemInfo.CreateColorTime(Sender.R, Sender.G, Sender.B, Sender.Time)
            Catch
                GameError.Raise(GameError.ErrorType.ErrorParsing, GameError.ErrorSeverity.Notice, GetType(MainForm), "Error setting Color" & (Index + 1))
            End Try
        End If
    End Sub
    Private Sub RangeValueChanged(ByVal Sender As ValueHolder)
        If Started Then
            Select Case Sender.Name.ToLower
                Case "AngleZ".ToLower
                    PS.Info.AngleZ = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "AngularDamping".ToLower
                    PS.Info.AngularDamping = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "AngularRateZ".ToLower
                    PS.Info.AngularRateZ = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "BurstCount".ToLower
                    PS.Info.BurstCount = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "BurstDelay".ToLower
                    PS.Info.BurstDelay = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "Gravity".ToLower
                    PS.Info.Gravity = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "InitialDelay".ToLower
                    PS.Info.InitialDelay = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "Lifetime".ToLower
                    PS.Info.Lifetime = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "Normal".ToLower
                    PS.Info.Normal = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "PSize".ToLower
                    PS.Info.Size = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "Radial".ToLower
                    PS.Info.Radial = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "RadiusRate".ToLower
                    PS.Info.RadiusRate = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "SizeRate".ToLower
                    PS.Info.SizeRate = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "SizeRateDamping".ToLower
                    PS.Info.SizeRateDamping = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "Speed".ToLower
                    PS.Info.Speed = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "VelocityDamping".ToLower
                    PS.Info.VelocityDamping = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "X".ToLower
                    PS.Info.X = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "Y".ToLower
                    PS.Info.Y = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
                Case "Z".ToLower
                    PS.Info.Z = ParticleSystemInfo.CreateValue(Sender.Min, Sender.Max)
            End Select
        End If
    End Sub
    Private Sub VectorsValueChanged(ByVal Sender As VectorHolder)
        If Started Then
            Select Case Sender.Name.ToLower
                Case "DriftVelocity".ToLower
                    PS.Info.DriftVelocity = New Vector3(Sender.X, Sender.Y, Sender.Z)
                Case "Halfsize".ToLower
                    PS.Info.HalfSize = New Vector3(Sender.X, Sender.Y, Sender.Z)
                Case "StartPoint".ToLower
                    PS.Info.StartPoint = New Vector3(Sender.X, Sender.Y, Sender.Z)
                Case "EndPoint".ToLower
                    PS.Info.EndPoint = New Vector3(Sender.X, Sender.Y, Sender.Z)
                Case "Offset".ToLower
                    PS.Info.Offset = New Vector3(Sender.X, Sender.Y, Sender.Z)
            End Select
        End If
        If Sender.Name.ToLower = "SystemLocation".ToLower Then
            PS.Info.Location = New Vector3(Sender.X, Sender.Y, Sender.Z)
        End If
    End Sub
    Private Sub CheckBoxesChanged(ByVal Sender As Object, ByVal E As EventArgs)
        If Started Then
            Select Case Sender.Name.ToLower
                Case "isoneshot"
                    PS.Info.IsOneShot = CType(Sender, CheckBox).Checked
                Case "isgroundaligned"
                    PS.Info.IsGroundAligned = CType(Sender, CheckBox).Checked
                Case Else
                    PS.Info.IsHollow = CType(Sender, CheckBox).Checked
            End Select
        End If
    End Sub
    '//ComboBoxes
    Private Sub Priority_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Priority.SelectedIndexChanged
        If Started Then
            PS.Info.Priority = CType(Priority.SelectedIndex, ParticleSystemInfo.Priorities)
        End If
    End Sub
    Private Sub SortLevel_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SortLevel.SelectedValueChanged
        If Started Then
            PS.Info.SortLevel = SortLevel.SelectedIndex
        End If
    End Sub
    Private Sub VelocityType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VelocityType.SelectedIndexChanged
        If Started Then
            PS.Info.EmissionVelocity = CType(VelocityType.SelectedIndex, ParticleSystemInfo.EmissionVelocityType)
            Me.tabVelocity.SelectedTab = tabVelocity.TabPages.Item(PS.Info.EmissionVelocity)
        End If
    End Sub
    Private Sub VolumeType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VolumeType.SelectedIndexChanged
        If Started Then
            PS.Info.EmissionVolume = CType(VolumeType.SelectedIndex, ParticleSystemInfo.EmissionVolumeType)
            Me.tabVolume.SelectedTab = tabVolume.TabPages.Item(PS.Info.EmissionVolume)
        End If
    End Sub
    Private Sub ParticleName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParticleName.SelectedIndexChanged
        If Started Then
            PS.Info.ParticleName = ParticleName.Items.Item(ParticleName.SelectedIndex)
        End If
    End Sub
    Private Sub Shader_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Shader.SelectedIndexChanged
        If Started Then
            PS.Info.Shader = Shader.SelectedIndex
        End If
    End Sub
    '//Textboxes
    Private Sub CylinderRadius_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CylinderRadius.TextChanged
        If Started Then PS.Info.Radius = IIf(CylinderRadius.Text = "." Or CylinderRadius.Text = "", "0", CylinderRadius.Text)
    End Sub
    Private Sub Length_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Length.TextChanged
        If Started Then PS.Info.Radius = IIf(Length.Text = "." Or Length.Text = "", "0", Length.Text)
    End Sub
    Private Sub SphereRadius_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SphereRadius.TextChanged
        If Started Then PS.Info.Radius = IIf(SphereRadius.Text = "." Or SphereRadius.Text = "", "0", SphereRadius.Text)
    End Sub
    Private Sub SystemLifetime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SystemLifetime.TextChanged
        If Started Then PS.Info.SystemLifetime = IIf(SystemLifetime.Text = "." Or SystemLifetime.Text = "", "0", SystemLifetime.Text)
    End Sub
    Private Sub ParticleSystemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParticleSystemName.TextChanged
        If Started Then
            PS.Info.ParticleSystemName = ParticleSystemName.Text
        End If
    End Sub
    '//Textbox KeyPress
    Private Sub TextboxKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim C As Char = e.KeyChar
        Dim Allowed() As Char = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "."}
        Dim Safe As Boolean
        For Each A As Char In Allowed
            If A = C Then Safe = True
        Next
        If Asc(C) = Keys.Delete Then Safe = True
        If Asc(C) = Keys.Back Then Safe = True
        If Not Safe Then e.Handled = True
    End Sub
    '//DialogPopUp
    Private Sub DialogUP()
        Paused = True
    End Sub
    '//DialogPopDown
    Private Sub DialogDOWN()
        Scene.Timer.Reset()
        Paused = False
        Box.Invalidate()
    End Sub
    '//Options
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        With SaveDLG
            .Filter = "XML |*.xml"
            DialogUP()
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                PS.Info.Export(.FileName)
            End If
            DialogDOWN()
        End With
    End Sub
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        With OpenDLG
            .Filter = "XML |*.xml"
            DialogUP()
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                PS.Info.Import(.FileName)
                UpdateUI()
            End If
            DialogDOWN()
        End With
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        With SaveDLG
            .Filter = "INI |*.ini"
            DialogUP()
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                PS.Info.Save(.FileName)
            End If
            DialogDOWN()
        End With
    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        With OpenDLG
            .Filter = "INI |*.ini"
            DialogUP()
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim SystemName As String = InputBox("Particle System Name")
                PS.Info.Open(.FileName, SystemName)
                UpdateUI()
            End If
            DialogDOWN()
        End With
    End Sub
    '//Errors!
    Private Sub ErrorThrown(ByVal _GameError As GameError.ErrorType, ByVal ErrorType As GameError.ErrorSeverity, ByVal SourceClass As Type, ByVal Details As String)
        If ErrorType = Particle_Effects_Viewer.GameError.ErrorSeverity.Critical Then
            DialogUP()
            MsgBox("Critical Error!" & vbCrLf & "Check Errors.xml for more information" & vbCrLf & vbCrLf & "For help Email me at 'freaklotr4@yahoo.com'", MsgBoxStyle.Critical, "ERROR!! Sorry...")
            DialogDOWN()
            Me.Close()
        End If
    End Sub
    '//Save Defaults
    Private Sub SaveDefaults()
        Dim Writer As New Xml.XmlTextWriter(ConfigFolder & "Configuration.xml", System.Text.Encoding.UTF8)
        Writer.Formatting = Xml.Formatting.Indented
        With Writer
            .WriteStartElement("ParticleSystemEditor")
            .WriteStartElement("Form")
            .WriteElementString("Width", Me.Width)
            .WriteElementString("Height", Me.Height)
            .WriteElementString("X", Me.Location.X)
            .WriteElementString("Y", Me.Location.Y)
            .WriteEndElement() 'Form
            .WriteStartElement("Scene")
            .WriteStartElement("BackColor")
            .WriteAttributeString("R", SceneBackColor.R)
            .WriteAttributeString("G", SceneBackColor.G)
            .WriteAttributeString("B", SceneBackColor.B)
            .WriteEndElement() 'BackColor
            .WriteElementString("Floor", CurrentFloor)
            .WriteStartElement("Camera")
            .WriteAttributeString("X", Box.Camera.X)
            .WriteAttributeString("Y", Box.Camera.Y)
            .WriteAttributeString("Z", Box.Camera.Z)
            .WriteAttributeString("Theta", Box.Theta)
            .WriteAttributeString("Omega", Box.Omega)
            .WriteEndElement() 'Camera
            .WriteStartElement("Font")
            .WriteAttributeString("FontName", CurrentFont)
            .WriteEndElement() 'Font
            .WriteEndElement() 'Scene
            .WriteStartElement("Output")
            .WriteStartElement("Particles")
            .WriteAttributeString("FromDirectory", ParticlesFolder)
            .WriteEndElement() 'Particles
            .WriteStartElement("Floors")
            .WriteAttributeString("FromDirectory", FloorsFolder)
            .WriteEndElement() 'Floors
            .WriteStartElement("Fonts")
            .WriteAttributeString("FromDirectory", FontsFolder)
            .WriteEndElement() 'Fonts
            .WriteStartElement("Config")
            .WriteAttributeString("FromDirectory", ConfigFolder)
            .WriteEndElement() 'Config
            .WriteEndElement() 'Output
            .WriteEndElement() 'ParticleSystemEditor
        End With
        Writer.Flush()
        Writer.Close()
        Writer = Nothing
    End Sub
    '//Load Defaults
    Private Sub LoadDefaults()
        Dim Reader As New Xml.XmlTextReader(ConfigFolder & "Configuration.xml")
        Dim dWidth, dHeight, dX, dY As Integer
        Do While Reader.Read
            Select Case Reader.Name.ToLower
                Case "width"
                    dWidth = Reader.ReadString
                Case "height"
                    dHeight = Reader.ReadString
                Case "x"
                    dX = Reader.ReadString
                Case "y"
                    dY = Reader.ReadString
                Case "backcolor"
                    SceneBackColor = Color.FromArgb(255, Reader.GetAttribute("R"), Reader.GetAttribute("G"), Reader.GetAttribute("B"))
                Case "camera"
                    Box.Camera.X = Reader.GetAttribute("X")
                    Box.Camera.Y = Reader.GetAttribute("Y")
                    Box.Camera.Z = Reader.GetAttribute("Z")
                    Box.Theta = Reader.GetAttribute("Theta")
                    Box.Omega = Reader.GetAttribute("Omega")
                Case "font"
                    CurrentFont = Reader.GetAttribute("FontName")
            End Select
        Loop
        Reader.Close()
        Reader = Nothing
        Me.Location = New Point(dX, dY)
        Me.Size = New Size(dWidth, dHeight)
    End Sub

End Class

Public Class DoubleBufferedBox
    Inherits PictureBox
    Public Event Render()
    Public Event HelpPressed()
    Public Theta, Omega As Double
    Public OtherTheta, OtherOmega As Double
    Public Camera As Vector3
    Public HelpRectangle As Rectangle
    Public LockView As Boolean
    Public ReadOnly Property ViewMatrix() As Matrix
        Get
            Return Matrix.Translation(Camera) * Matrix.RotationZ(Theta * Math.PI / 180) * Matrix.RotationX(Omega * Math.PI / 180)
        End Get
    End Property
    Public ReadOnly Property OtherMatrix()
        Get
            Return Matrix.RotationZ(OtherTheta * Math.PI / 180) * Matrix.RotationX(OtherOmega * Math.PI / 180)
        End Get
    End Property
    Public Sub New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.Opaque, True)
        Me.UpdateStyles()
        Me.DoubleBuffered = False
        Me.Camera = New Vector3(-28, -110, 244)
        Me.Theta = 0.00000004470348
        Me.Omega = -18.30001
    End Sub
    Private Sub PanCamera(ByVal FBSpeed As Double, ByVal RLSpeed As Double)
        Dim FBTheta As Double = Theta + 90
        '//Right Left
        Camera.X += Math.Cos(Omega * Math.PI / 180) * Math.Cos(Theta * Math.PI / 180) * RLSpeed * 0.6
        Camera.Y += Math.Sin(Theta * Math.PI / 180) * RLSpeed * 0.6
        '//Forward Backward
        Camera.X -= Math.Cos(Omega * Math.PI / 180) * Math.Cos(FBTheta * Math.PI / 180) * FBSpeed * 0.6
        Camera.Y -= Math.Sin(FBTheta * Math.PI / 180) * FBSpeed * 0.6
    End Sub
    Private Sub HeightCamera(ByVal UDSpeed As Double, ByVal RLSpeed As Double)
        Camera.Z += UDSpeed * 0.6
        Camera.X += Math.Cos(Omega * Math.PI / 180) * Math.Cos(Theta * Math.PI / 180) * RLSpeed * 0.6
        Camera.Y += Math.Sin(Theta * Math.PI / 180) * RLSpeed * 0.9
    End Sub
    Private Sub AdjustCamera(ByVal XOffset As Double, ByVal YOffset As Double)
        Theta -= XOffset / 10
        Omega -= YOffset / 10
    End Sub
    Private Sub AdjustOther(ByVal XOffset As Double, ByVal YOffset As Double)
        OtherTheta -= XOffset / 2
        OtherOmega -= YOffset / 2
    End Sub
    Private Sub DoubleBufferedBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If HelpRectangle.Contains(e.X, e.Y) Then
            RaiseEvent HelpPressed()
        End If
    End Sub
    Private Sub DoubleBufferedBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Static Oldy As Double
        Static Oldx As Double
        If Oldy <> 0 And Oldx <> 0 Then
            If Not LockView Then
                Select Case e.Button
                    Case Windows.Forms.MouseButtons.Left
                        AdjustCamera(e.X - Oldx, e.Y - Oldy)
                    Case Windows.Forms.MouseButtons.Right
                        PanCamera(e.Y - Oldy, e.X - Oldx)
                    Case Windows.Forms.MouseButtons.Middle
                        HeightCamera(e.Y - Oldy, e.X - Oldx)
                End Select
            Else
                Select Case e.Button
                    Case Windows.Forms.MouseButtons.Left
                        AdjustOther(e.X - Oldx, 0)
                    Case Windows.Forms.MouseButtons.Right
                        AdjustOther(0, e.Y - Oldy)
                    Case Windows.Forms.MouseButtons.Middle
                        AdjustOther(e.X - Oldx, e.Y - Oldy)
                End Select
            End If
        End If
        Oldy = e.Y
        Oldx = e.X
    End Sub
    Private Sub DoubleBufferedBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        RaiseEvent Render()
    End Sub
    Public Overrides Function ToString() As String
        Return "X: " & FormatNumber(Camera.X, 0) & vbCrLf & _
               "Y: " & FormatNumber(-Camera.Y, 0) & vbCrLf & _
               "Z: " & FormatNumber(Camera.Z, 0) & vbCrLf & _
               "Theta: " & Theta & vbCrLf & _
               "Omega: " & Omega & vbCrLf
    End Function
End Class

