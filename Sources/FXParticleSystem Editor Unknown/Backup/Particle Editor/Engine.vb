Imports System
Imports System.IO
Imports System.Configuration
Imports System.Math
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports D3D = Microsoft.DirectX.Direct3D
Imports DS = Microsoft.DirectX.DirectSound
Public Enum GameError
    FileDoesntExist
    TextureNotFound
    TextureWrongFormat
    FontNotFound
    ErrorDrawingFont
    SoundNotFound
    SoundWrongFormat
    ErrorPlayingSound
    ErrorRendering
    ErrorUpdating
End Enum
'//Scene
Public Class Scene
    Public Shared LocalDevice As Device
    Public Shared Timer As New GameTimer
    Public Shared Random As New Random
    Private Shared TimeElapsed As Single
    Private Shared DeviceSettings As New PresentParameters
    Public Shared ReadOnly Property DeltaTime() As Single
        Get
            Return TimeElapsed
        End Get
    End Property
    Public Shared Sub Initialize(ByVal Handle As IntPtr)
        Try
            DeviceSettings.Windowed = True
            DeviceSettings.SwapEffect = SwapEffect.Discard
            DeviceSettings.BackBufferFormat = Format.Unknown
            DeviceSettings.AutoDepthStencilFormat = DepthFormat.D16
            DeviceSettings.EnableAutoDepthStencil = True
            Dim AdapterOrdinal As Integer = D3D.Manager.Adapters.Default.Adapter
            Dim Flags As CreateFlags = CreateFlags.SoftwareVertexProcessing
            Dim Caps As D3D.Caps = D3D.Manager.GetDeviceCaps(AdapterOrdinal, D3D.DeviceType.Hardware)
            If Caps.DeviceCaps.SupportsHardwareTransformAndLight Then
                Flags = CreateFlags.HardwareVertexProcessing
            End If
            If Caps.DeviceCaps.SupportsPureDevice Then
                Flags = Flags Or CreateFlags.PureDevice
            End If
            LocalDevice = New D3D.Device(0, D3D.DeviceType.Hardware, Handle, Flags, DeviceSettings)
            AddHandler LocalDevice.DeviceReset, AddressOf OnResetDevice
            OnResetDevice(LocalDevice, Nothing)
            '//TextureManager
            TextureManager.Initialize(LocalDevice)
            '//QuadRender
            QuadRenderer.Initialize()
        Catch E As Exception
            Throw New Exception("DX Exception.  Extended Results: " + E.Message)
        End Try
    End Sub
    Public Shared Sub WindowResized()
        If Not (LocalDevice Is Nothing) Then
            DeviceSettings.BackBufferHeight = 0
            DeviceSettings.BackBufferWidth = 0
            LocalDevice.Reset(DeviceSettings)
        End If
    End Sub
    Public Shared Sub OnResetDevice(ByVal Sender As Object, ByVal E As EventArgs)
        Dim LocalDevice As D3D.Device = CType(Sender, D3D.Device)
    End Sub
    Public Shared Sub Begin()
        Timer.Start()
    End Sub
    Public Shared Sub StartScene(ByVal BackColor As System.Drawing.Color)
        LocalDevice.Clear(ClearFlags.Target, BackColor, 1.0F, 0)
        LocalDevice.BeginScene()
        TimeElapsed = Timer.ElapsedTime
    End Sub
    Public Shared Sub EndScene()
        LocalDevice.EndScene()
        LocalDevice.Present()
    End Sub
    Public Shared Sub Dispose()
        Timer.Stop()
        If Not (LocalDevice Is Nothing) Then
            LocalDevice.Dispose()
        End If
        TextureManager.Dispose()
        LocalDevice = Nothing
    End Sub
    Public Shared Function RandS(ByVal Min As Single, ByVal Max As Single) As Single
        Return (Max - Min + 1) * Rnd() + Min
    End Function
    Public Shared Function RandI(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Return Int((Max - Min + 1) * Rnd()) + Min
    End Function
    Public Shared Function FramesPerSecond() As Integer
        Static CurrentRate As Single
        Static FrameRate As Single
        Static LastFrameRate As Single
        CurrentRate += DeltaTime
        If CurrentRate >= 1.0F Then
            LastFrameRate = FrameRate
            FrameRate = 0
            CurrentRate = 0
        End If
        FrameRate += 1
        Return LastFrameRate
    End Function
End Class '//Done
'//Font
Public Class Text
    Private FontSprite As Sprite
    Private Texture As Texture
    Private FrameWidth, FrameHeight As Integer
    Private XSpacingScale, YSpacingScale, Scale, FontSize, Sizes(255) As Single
    Public Sub New(ByVal Device As Device, ByVal Texture As Texture, ByVal FilePath As String, ByVal XSpacingScale As Single, ByVal YSpacingScale As Single)
        Me.FontSprite = New Sprite(Device)
        Me.Texture = Texture
        Me.LoadFromFile(FilePath)
        Me.XSpacingScale = XSpacingScale
        Me.YSpacingScale = YSpacingScale
    End Sub
    Public Sub Render(ByVal Text As String, ByVal Size As Single, ByVal ForeColor As Drawing.Color, ByVal X As Single, ByVal Y As Single)
        Scale = Size / FontSize
        Dim Location As New Vector(X / Scale, Y / Scale)
        FontSprite.Begin(SpriteFlags.AlphaBlend)
        FontSprite.Transform = Matrix.Scaling(Scale, Scale, 1.0F)
        Dim Column, Row As Single
        Column = -(GetSize(Text(0)) * XSpacingScale)
        For I As Integer = 0 To Text.Length - 1
            Column += (GetSize(Text(IIf(I = 0, 0, I - 1))) * XSpacingScale)
            If Text(I) = vbCrLf(0) Then
                Row += (FrameHeight * YSpacingScale)
                Column = -(GetSize(Text(I)) * XSpacingScale)
            ElseIf Text(I) = " " Then
                Column += (GetSize("o") * XSpacingScale)
            Else
                FontSprite.Draw(Texture, GetLetter(Text(I)), Vector3.Empty, New Vector3(Location.X + Column, Location.Y + Row, 0), ForeColor.ToArgb)
            End If
        Next
        FontSprite.End()
    End Sub
    Public Sub Dispose()
        If Not (Texture Is Nothing) Then
            Texture.Dispose()
        End If
        If Not (FontSprite Is Nothing) Then
            FontSprite.Dispose()
        End If
        Texture = Nothing
        FontSprite = Nothing
        Sizes = Nothing
    End Sub
    Private Sub LoadFromFile(ByVal FilePath As String)
        Dim Sr As IO.StreamReader = IO.File.OpenText(FilePath)
        FontSize = Sr.ReadLine()
        FrameWidth = Sr.ReadLine()
        FrameHeight = Sr.ReadLine()
        For I As Integer = 0 To 255
            Sizes(I) = Sr.ReadLine
        Next
        Sr.Close()
    End Sub
    Private Function GetLetter(ByVal Letter As String) As Rectangle
        Dim X, Y As Integer
        Y = Int(Asc(Letter) / 16)
        X = Asc(Letter) - (Y * 16)
        Return New Rectangle(X * FrameWidth, Y * FrameHeight, GetSize(Letter), FrameHeight)
    End Function
    Private Function GetSize(ByVal T As String) As Single
        Return Sizes(Asc(T))
    End Function
    Private Function GetString(ByVal Line As String, ByVal After As String) As String
        Return Line.Substring(Line.LastIndexOf(After) + 1)
    End Function
End Class '//Done
'//TextureManager
Public Class TextureManager
    Private Structure TL
        Public Texture As Texture
        Public Name As String
    End Structure
    Private Shared Device As Device
    Private Shared Textures As ArrayList
    Private Shared LastTexture As String
    ''' <summary> Calls on new class to handle the game textures </summary>
    ''' <param name="LocalDevice"> Direct3d device used for loading textures </param>
    Public Sub New(ByVal LocalDevice As Device)
        Device = LocalDevice
        Textures = New ArrayList
    End Sub
    ''' <summary> Initializes the public class for handling game textures </summary>
    ''' <param name="LocalDevice"> Direct3d device used for loading textures </param>
    Public Shared Sub Initialize(ByVal LocalDevice As Device)
        Device = LocalDevice
        Textures = New ArrayList
    End Sub
    ''' <summary> Adds a texture to the List of game textures </summary>
    ''' <param name="FilePath"> Complete filepath as string of texture (including extension) </param>
    ''' <param name="ReferenceName"> The name to use when getting a texture </param>
    ''' <param name="TransparentColor"> The transparent color </param>
    ''' <remarks></remarks>
    Public Shared Sub Add(ByVal FilePath As String, ByVal ReferenceName As String, ByVal TransparentColor As System.Drawing.Color)
        Dim TL As New TL
        Try
            If IO.File.Exists(FilePath) Then
                If FilePath.ToLower.EndsWith(".bmp") Then
                    Dim Bm As New Bitmap(FilePath)
                    TL.Texture = TextureLoader.FromFile(Device, FilePath, Bm.Width, Bm.Height, 0, Usage.SoftwareProcessing, Format.A8B8G8R8, Pool.Managed, Filter.Point, Filter.Point, TransparentColor.ToArgb)
                    TL.Name = ReferenceName
                    LastTexture = ReferenceName
                    Textures.Add(TL)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub Add(ByVal Bmp As Bitmap, ByVal ReferenceName As String, ByVal TransparentColor As System.Drawing.Color)
        Dim TL As New TL
        Try
            Bmp.MakeTransparent(TransparentColor)
            TL.Texture = D3D.Texture.FromBitmap(Device, Bmp, Usage.SoftwareProcessing, Pool.Managed)
            TL.Name = ReferenceName
            LastTexture = ReferenceName
            Textures.Add(TL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary> Used when closing application, Disposes all the textures </summary>
    Public Shared Sub Dispose()
        Dim TL As TL
        For Each TL In Textures
            TL.Texture.Dispose()
        Next
    End Sub
    ''' <summary> Returns the texture that is stored under the specific name </summary>
    ''' <param name="Name"> Reference name that AddTexture called </param>
    Public Shared Function Texture(ByVal Name As String) As Texture
        Dim TL As TL
        For Each TL In Textures
            If TL.Name = Name Then
                Return TL.Texture
            End If
        Next
        Return Nothing
    End Function
    ''' <summary>
    ''' Returns last uploaded texture
    ''' </summary>
    Public Shared Function Last() As Texture
        If (LastTexture <> "") Then Return Texture(LastTexture) Else Return Nothing
    End Function
End Class '//Done
'//Particle Junk
#Region " Particle Stuff "
'//ParticleX
Public Class ParticleX
    Public Location, Velocity As Vector
    Public Gravity, RadialAcceleration, TangentialAcceleration, Size, SizeDelta, Age, TerminalAge As Single
    Public Color, ColorDelta As Color
    Public Sub New()
        Location = New Vector
        Velocity = New Vector
        Color = New Color
        ColorDelta = New Color
    End Sub
End Class
'//ParticleSystemX
Public Class ParticleSystemX
    Public Info As ParticleSystemInfo
    Public Location As Vector
    Public UpdateSpeed, Residue, Age, EmissionResidue As Single
    Public ParticlesAlive As Integer
    Public Const MaxParticles As Integer = 512
    Public Particles(MaxParticles) As ParticleX
    Public Sub New(ByVal PSI As ParticleSystemInfo, ByVal Location As Vector, ByVal DesiredFPS As Single)
        Me.Info = PSI
        Me.Location = Location
        EmissionResidue = 0.0F
        ParticlesAlive = 0
        Age = -2.0
        If (DesiredFPS <> 0.0F) Then UpdateSpeed = 1.0F / DesiredFPS Else UpdateSpeed = 0.0F
        Residue = 0.0F
        For I As Integer = 0 To MaxParticles
            Particles(I) = New ParticleX
            ResetParticle(I)
        Next
    End Sub
    Public Sub UpdateParticle(ByVal I As Integer, ByVal Deltatime As Single)
        With Particles(I)
            'Accel = Vector.Subtract(.Location, Location)
            'Accel.Normalize()
            'Accel2 = Accel
            'Accel = Vector.Multiply(Accel, .RadialAcceleration)
            'Angle = Accel2.X
            'Accel2.X = -Accel2.Y
            'Accel2.Y = Angle
            'Accel2 = Vector.Multiply(Accel2, .TangentialAcceleration)
            '.Velocity = Vector.Add(Vector.Multiply(Vector.Add(Accel, Accel2), Deltatime), .Velocity)
            .Velocity.Y += .Gravity * Deltatime
            .Location = Vector.Add(.Velocity, .Location)
            .Size += .SizeDelta * Deltatime
            .Color += .ColorDelta * Deltatime
        End With
    End Sub
    Public Sub ResetParticle(ByVal I As Integer)
        With Particles(I)
            .Age = 0.0F
            .TerminalAge = Scene.RandS(Info.ParticleLifeMin, Info.ParticleLifeMax)
            .Location = Location * Scene.RandS(0.0F, 1.0F)
            .Location.X += Scene.RandS(-2.0F, 2.0F)
            .Location.Y += Scene.RandS(-2.0F, 2.0F)
            .Velocity.X = Scene.RandS(Info.VelocityXMin, Info.VelocityXMax)
            .Velocity.Y = Scene.RandS(Info.VelocityYMin, Info.VelocityYMax)
            .Velocity = .Velocity * Scene.RandS(Info.SpeedMin, Info.SpeedMax)
            .Gravity = Scene.RandS(Info.GravityMin, Info.GravityMax)
            .RadialAcceleration = Scene.RandS(Info.RadialAccelMin, Info.RadialAccelMax)
            .TangentialAcceleration = Scene.RandS(Info.TangentialAccelMin, Info.TangentialAccelMax)
            .Size = Scene.RandS(Info.SizeStart, Info.SizeStart + (Info.SizeEnd - Info.SizeStart) * Info.SizeVar)
            .SizeDelta = (Info.SizeEnd - .Size) / .TerminalAge
            .Color.R = Scene.RandS(Info.ColorStart.R, Info.ColorStart.R + (Info.ColorEnd.R - Info.ColorStart.R) * Info.ColorVar)
            .Color.G = Scene.RandS(Info.ColorStart.G, Info.ColorStart.G + (Info.ColorEnd.G - Info.ColorStart.G) * Info.ColorVar)
            .Color.B = Scene.RandS(Info.ColorStart.B, Info.ColorStart.B + (Info.ColorEnd.B - Info.ColorStart.B) * Info.ColorVar)
            .Color.A = Scene.RandS(Info.ColorStart.A, Info.ColorStart.A + (Info.ColorEnd.A - Info.ColorStart.A) * Info.AlphaVar)
            .ColorDelta.R = (Info.ColorEnd.R - .Color.R) / .TerminalAge
            .ColorDelta.G = (Info.ColorEnd.G - .Color.G) / .TerminalAge
            .ColorDelta.B = (Info.ColorEnd.B - .Color.B) / .TerminalAge
            .ColorDelta.A = (Info.ColorEnd.A - .Color.A) / .TerminalAge
        End With
    End Sub
    Public Sub Update(ByVal Deltatime As Single)
        If UpdateSpeed = 0.0F Then
            _Update(Deltatime)
        Else
            Residue += Deltatime
            If Residue >= UpdateSpeed Then
                _Update(UpdateSpeed)
                While Residue >= UpdateSpeed
                    Residue -= UpdateSpeed
                End While
            End If
        End If
    End Sub
    Private Sub _Update(ByVal DeltaTime As Single)
        If Age >= 0 Then
            Age += DeltaTime
            If Age >= Info.Lifetime Then Age = -2.0F
        End If
        For I As Integer = 0 To ParticlesAlive - 1
            With Particles(I)
                UpdateParticle(I, DeltaTime)
                If .Age >= .TerminalAge Then
                    ResetParticle(I)
                End If
            End With
        Next
        Dim ParticlesNeeded As Single = Info.Emission * DeltaTime + EmissionResidue
        Dim ParticlesCreated As Integer = ParticlesNeeded
        EmissionResidue = ParticlesNeeded - ParticlesCreated
        For I As Integer = 0 To ParticlesCreated - 1
            If ParticlesAlive >= MaxParticles Then
                Exit For
            End If
            ResetParticle(ParticlesAlive)
            ParticlesAlive += 1
        Next
    End Sub
    Public Sub Render(ByVal Device As Device)
        Device.RenderState.ZBufferWriteEnable = False
        Device.RenderState.AlphaBlendEnable = True
        Device.RenderState.SourceBlend = Blend.SourceAlpha
        Device.RenderState.DestinationBlend = Blend.One
        Device.RenderState.Lighting = False
        Device.Transform.World = Matrix.Identity
        Device.RenderState.PointSpriteEnable = True
        Device.RenderState.PointScaleEnable = True
        Device.RenderState.PointSize = 20.0F
        Device.RenderState.PointScaleA = 0.0F
        Device.RenderState.PointScaleB = 1.0F
        Device.RenderState.PointScaleC = 1.0F
        Device.SetTextureStageState(0, TextureStageStates.AlphaOperation, True)
        Device.VertexFormat = CustomVertex.TransformedColoredTextured.Format
        Device.SetTexture(0, Info.ParticleTexture)
        '//Points
        Dim Points(ParticlesAlive - 1) As CustomVertex.TransformedColoredTextured
        For I As Integer = 0 To ParticlesAlive - 1
            Dim P As ParticleX = Particles(I)
            Points(I).Color = P.Color.ToARGB
            Points(I).X = P.Location.X
            Points(I).Y = P.Location.Y
        Next
        Device.DrawUserPrimitives(PrimitiveType.PointList, ParticlesAlive - 1, Points)
        Device.RenderState.PointSpriteEnable = False
        Device.RenderState.PointScaleEnable = False
        Device.RenderState.ZBufferWriteEnable = True
        Device.RenderState.AlphaBlendEnable = False
    End Sub
    Public Sub Relocate(ByVal X As Single, ByVal Y As Single)
        Location = New Vector(X, Y)
    End Sub
    Public Function Stats() As String
        Return "ParticlesAlive: " & ParticlesAlive & vbCrLf & _
               "UpdateSpeed: " & UpdateSpeed & vbCrLf & _
               "Age: " & Age & vbCrLf & _
               "EmissionResidue: " & EmissionResidue & vbCrLf & _
               "Emission: " & Info.Emission
    End Function
End Class
'//Particle
Public Class Particle
    Public Color As New Color
    Public Accel, Position, Speed As Vector
    Public Size, AlphaDecay As Single
    Public ReadOnly Property DisplayColor() As Integer
        Get
            Return System.Drawing.Color.FromArgb( _
                Color.A * 255, Color.R * 255, Color.G * 255, Color.B * 255).ToArgb
        End Get
    End Property
    Public Sub ResetColor(ByVal sngRed As Single, ByVal sngGreen As Single, ByVal sngBlue As Single, ByVal sngAlpha As Single, ByVal sngDecay As Single)
        Color.R = sngRed
        Color.G = sngGreen
        Color.B = sngBlue
        Color.A = sngAlpha
        AlphaDecay = sngDecay
    End Sub
    Public Sub ResetIt(ByVal X As Single, ByVal Y As Single, ByVal XSpeed As Single, ByVal YSpeed As Single, ByVal XAcc As Single, ByVal YAcc As Single, ByVal sngResetSize As Single)
        Position = New Vector(X, Y)
        Speed = New Vector(XSpeed, YSpeed)
        Accel = New Vector(XAcc, YAcc)
        Size = sngResetSize
    End Sub
    Public Sub UpdateParticle(ByVal DeltaTime As Single)
        DeltaTime *= 10
        Position.X += +Speed.X * DeltaTime
        Position.Y += Speed.Y * DeltaTime
        Speed.X += Accel.X * DeltaTime
        Speed.Y += Accel.Y * DeltaTime
        Color.A -= AlphaDecay * DeltaTime
    End Sub
End Class
'//ParticleSystem
Public Class ParticleSystem
    Public Info As ParticleSystemInfo
    Public Location As Vector
    Public ParticleCount As Single
    Public ParticleTexture As Texture
    Public Const MaxParticles As Integer = 512
    Private Particles(MaxParticles) As Particle
    Private VertexBuffer As VertexBuffer = Nothing
    Private Bounding As Bounding
    Public ShowBoundingBox As Boolean
    Public Sub New(ByVal particlecount As Single, ByVal startx As Single, ByVal starty As Single, ByVal particletexture As Texture)
        Me.ParticleCount = particlecount
        Me.Location = New Vector(startx, starty)
        Me.ParticleTexture = particletexture
        For I As Integer = 0 To MaxParticles
            Particles(I) = New Particle
            Reset(I)
        Next
        VertexBuffer = New VertexBuffer(GetType(CustomVertex.TransformedColoredTextured), MaxParticles, Scene.LocalDevice, Usage.WriteOnly, CustomVertex.TransformedColoredTextured.Format, Pool.Default)
        Bounding = New Bounding(startx, starty, 0.4)
    End Sub
    Public Sub New(ByVal PSI As ParticleSystemInfo, ByVal Location As Vector)
        Info = PSI
        Me.Location = Location

    End Sub
    Public Sub Reset(ByVal I As Long)
        Dim X As Single, Y As Single
        X = Location.X + (Rnd() * 10)
        Y = Location.Y
        With Particles(I)
            .ResetIt(X, Y, -0.6 + (Rnd() * 1.2), -(Rnd() * 1.0) - 0.5F, 0, -(Rnd() * 0.15), 50)
            .ResetColor(1, 0.5, 0.2, 0.6 + (0.2 * Rnd()), 0.01 + Rnd() * 0.05)
        End With
    End Sub
    Public Sub Update(ByVal DeltaTime As Single)
        For I As Integer = 0 To ParticleCount
            With Particles(I)
                .UpdateParticle(DeltaTime)
                If .Color.A <= 0 Then
                    Reset(I)
                End If
            End With
        Next I
    End Sub
    Public Sub Render(ByVal Device As Device)
        Device.RenderState.ZBufferWriteEnable = False
        Device.RenderState.AlphaBlendEnable = True
        Device.RenderState.SourceBlend = Blend.SourceAlpha
        Device.RenderState.DestinationBlend = Blend.One
        Device.RenderState.Lighting = False
        Device.Transform.World = Matrix.Identity
        Device.RenderState.PointSpriteEnable = True
        Device.RenderState.PointScaleEnable = True
        Device.RenderState.PointSize = 20.0F
        Device.RenderState.PointScaleA = 0.0F
        Device.RenderState.PointScaleB = 1.0F
        Device.RenderState.PointScaleC = 1.0F
        Device.SetTextureStageState(0, TextureStageStates.AlphaOperation, True)
        Device.VertexFormat = CustomVertex.TransformedColoredTextured.Format
        Device.SetTexture(0, ParticleTexture)
        Device.SetStreamSource(0, VertexBuffer, 0)
        Dim Points(ParticleCount - 1) As CustomVertex.TransformedColoredTextured
        Points = VertexBuffer.Lock(0, 0)
        Bounding.Clear(Location.X, Location.Y)
        For I As Integer = 0 To ParticleCount - 1
            Dim P As Particle = Particles(I)
            Points(I).Color = P.DisplayColor
            Points(I).X = P.Position.X
            Points(I).Y = P.Position.Y
            Bounding.Encapsulate(P.Position, P.Color.A)
        Next
        VertexBuffer.Unlock()
        Device.DrawPrimitives(PrimitiveType.PointList, 0, ParticleCount - 1)
        Device.RenderState.PointSpriteEnable = False
        Device.RenderState.PointScaleEnable = False
        Device.RenderState.ZBufferWriteEnable = True
        Device.RenderState.AlphaBlendEnable = False
        If ShowBoundingBox Then Bounding.Render(Device)
    End Sub
    Public Sub Relocate(ByVal X As Single, ByVal Y As Single)
        Location = New Vector(X, Y)
    End Sub
    Public Sub Dispose()
        If Not (ParticleTexture Is Nothing) Then
            ParticleTexture.Dispose()
        End If
        If Not (VertexBuffer Is Nothing) Then
            VertexBuffer.Dispose()
        End If
        ParticleTexture = Nothing
        VertexBuffer = Nothing
        Particles = Nothing
    End Sub
End Class
'//ParticleSystemInfo
Public Class ParticleSystemInfo
    Public Emission As Integer
    Public Lifetime, ParticleLifeMin, ParticleLifeMax, SpeedMax, SpeedMin, _
           GravityMin, GravityMax, RadialAccelMin, RadialAccelMax, TangentialAccelMin, _
           TangentialAccelMax, SizeStart, SizeEnd, SizeVar, ColorVar, AlphaVar, _
           VelocityXMax, VelocityXMin, VelocityYMax, VelocityYMin As Single
    Public Relative As Boolean
    Public ColorStart, ColorEnd As Color
    Public ParticleTexture As Texture
    Public Sub New()
    End Sub
    Public Sub SetInfo( _
        ByVal iEmission As Integer, ByVal iLifetime As Single, ByVal iParticleLifeMin As Single, _
        ByVal iParticleLifeMax As Single, ByVal iSpeedMax As Single, ByVal iSpeedMin As Single, ByVal iGravityMin As Single, _
        ByVal iGravityMax As Single, ByVal iRadialAccelMin As Single, ByVal iRadialAccelMax As Single, _
        ByVal iTangentialAccelMin As Single, ByVal iTangentialAccelMax As Single, ByVal iSizeStart As Single, _
        ByVal iSizeEnd As Single, ByVal iSizeVar As Single, ByVal iColorVar As Single, ByVal iAlphaVar As Single, ByVal iRelative As Boolean, _
        ByVal Texture As Texture, ByVal iColorStart As Color, ByVal iColorend As Color, _
        ByVal iVelocityXMax As Single, ByVal iVelocityXMin As Single, ByVal iVelocityYMax As Single, ByVal iVelocityYMin As Single)
        Emission = iEmission
        Lifetime = iLifetime
        ParticleLifeMin = iParticleLifeMin
        ParticleLifeMax = iParticleLifeMax
        SpeedMax = iSpeedMax
        SpeedMin = iSpeedMin
        GravityMin = iGravityMin
        GravityMax = iGravityMax
        RadialAccelMin = iRadialAccelMin
        RadialAccelMax = iRadialAccelMax
        TangentialAccelMin = iTangentialAccelMin
        TangentialAccelMax = iTangentialAccelMax
        SizeStart = iSizeStart
        SizeEnd = iSizeEnd
        SizeVar = iSizeVar
        ColorVar = iColorVar
        AlphaVar = iAlphaVar
        Relative = iRelative
        ColorStart = iColorStart
        ColorEnd = iColorend
        ParticleTexture = Texture
    End Sub
End Class
#End Region
'//Bounding
Public Class Bounding
    Public X1, Y1, X2, Y2 As Single
    Private Vertices(4) As CustomVertex.TransformedColored
    Private AcceptableAlpha As Single
    Public Sub New(ByVal X As Single, ByVal Y As Single, ByVal AcceptableAlpha As Single)
        Me.X1 = X
        Me.X2 = X
        Me.Y1 = Y
        Me.Y2 = Y
        Me.AcceptableAlpha = AcceptableAlpha
    End Sub
    Public Sub Clear(ByVal X As Single, ByVal Y As Single)
        X1 = X
        X2 = X
        Y1 = Y
        Y2 = Y
    End Sub
    Public Sub Encapsulate(ByVal V As Vector, ByVal Alpha As Single)
        If Alpha < AcceptableAlpha Then Return
        If V.X < X1 Then X1 = V.X
        If V.X > X2 Then X2 = V.X
        If V.Y < Y1 Then Y1 = V.Y
        If V.Y > Y2 Then Y2 = V.Y
    End Sub
    Public Sub Render(ByVal Device As Device)
        Device.VertexFormat = CustomVertex.TransformedColored.Format
        Vertices(0) = New CustomVertex.TransformedColored(X1, Y1, 0, 1.0F, Drawing.Color.White.ToArgb)
        Vertices(1) = New CustomVertex.TransformedColored(X1, Y2, 0, 1.0F, Drawing.Color.White.ToArgb)
        Vertices(2) = New CustomVertex.TransformedColored(X2, Y2, 0, 1.0F, Drawing.Color.White.ToArgb)
        Vertices(3) = New CustomVertex.TransformedColored(X2, Y1, 0, 1.0F, Drawing.Color.White.ToArgb)
        Vertices(4) = New CustomVertex.TransformedColored(X1, Y1, 0, 1.0F, Drawing.Color.White.ToArgb)
        Device.DrawUserPrimitives(PrimitiveType.LineStrip, 4, Vertices)
    End Sub
End Class '//Done
'//Vector
Public Class Vector
    Public X, Y As Single
    Public Sub New(ByVal x As Single, ByVal y As Single)
        Me.X = x
        Me.Y = y
    End Sub
    Public Sub New()

    End Sub
    Public Function This() As Vector
        Return New Vector(X, Y)
    End Function
    Public Sub Add(ByVal V As Vector)
        X += V.X
        Y += V.Y
    End Sub
    Public Shared Sub Add(ByRef Result As Vector, ByVal V1 As Vector, ByVal V2 As Vector)
        Result = Add(V1, V2)
    End Sub
    Public Shared Function Add(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X + V2.X, V1.Y + V2.Y)
    End Function
    Public Sub Subtract(ByVal V As Vector)
        X -= V.X
        Y -= V.Y
    End Sub
    Public Shared Sub Subtract(ByRef Result As Vector, ByVal V1 As Vector, ByVal V2 As Vector)
        Result = Subtract(V1, V2)
    End Sub
    Public Shared Function Subtract(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X - V2.X, V1.Y - V2.Y)
    End Function
    Public Sub Multiply(ByVal V As Vector)
        X *= V.X
        Y *= V.Y
    End Sub
    Public Shared Sub Multiply(ByRef Result As Vector, ByVal V1 As Vector, ByVal V2 As Vector)
        Result = Multiply(V1, V2)
    End Sub
    Public Shared Function Multiply(ByVal V As Vector, ByVal M As Single) As Vector
        Return Multiply(V, New Vector(M, M))
    End Function
    Public Shared Function Multiply(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X * V2.X, V1.Y * V2.Y)
    End Function
    Public Sub Divide(ByVal V As Vector)
        X /= V.X
        Y /= V.Y
    End Sub
    Public Sub Divide(ByVal S As Single)
        X /= S
        Y /= S
    End Sub
    Public Shared Sub Divide(ByRef Result As Vector, ByVal V1 As Vector, ByVal V2 As Vector)
        Result = Divide(V1, V2)
    End Sub
    Public Shared Function Divide(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X / V2.X, V1.Y / V2.Y)
    End Function
    Public Sub Scale(ByVal Amount As Single)
        X *= Amount
        Y *= Amount
    End Sub
    Public Shared Sub Scale(ByRef Result As Vector, ByVal V As Vector, ByVal Amount As Single)
        Result = Scale(V, Amount)
    End Sub
    Public Shared Function Scale(ByVal V As Vector, ByVal Amount As Single) As Vector
        Return New Vector(V.X * Amount, V.Y * Amount)
    End Function
    Public Function LengthSq() As Single
        Return Sqrt(X * X + Y * Y)
    End Function
    Public Shared Function LengthSq(ByVal V As Vector) As Single
        Return Sqrt(V.X * V.X + V.Y * V.Y)
    End Function
    Public Function InverseSqrt(ByVal X As Single) As Single
        Dim Int As Integer
        Dim Sng As Single
        Sng = X
        Int = "0x5f3759df" - (Int >> 1)
        Return Sng * (1.5F - 0.4999F * X * Sng * Sng)
    End Function
    Public Function Dot(ByVal V As Vector) As Single
        Return X * V.X + Y * V.Y
    End Function
    Public Function Rotate(ByVal A As Single) As Vector
        Dim V As New Vector
        V.X = X * Cos(A) - Y * Sin(A)
        V.Y = X * Sin(A) + Y * Cos(A)
        X = V.X
        Y = V.Y
        Return This()
    End Function
    Public Sub Normalize()
        This.Divide(This.LengthSq)
    End Sub
    Public Function Length() As Single
        Return Sqrt(Dot(This))
    End Function
    Public Function Angle(Optional ByVal V As Vector = Nothing) As Single
        If Not (V Is Nothing) Then
            Dim S As Vector = This()
            Dim T As Vector = V
            S.Normalize() : T.Normalize()
            Return Acos(S.Dot(T))
        Else
            Return Atan2(Y, X)
        End If
    End Function
    Public Function ToSO() As Vector3
        Return New Vector3(X, Y, 0)
    End Function
    Public Overrides Function ToString() As String
        Return "X:" & X & " Y:" & Y
    End Function
    Public Shared Operator +(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X + V2.X, V1.Y + V2.Y)
    End Operator
    Public Shared Operator +(ByVal V1 As Vector, ByVal S As Single) As Vector
        Return New Vector(V1.X + S, V1.Y + S)
    End Operator
    Public Shared Operator -(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X - V2.X, V1.Y - V2.Y)
    End Operator
    Public Shared Operator -(ByVal V1 As Vector, ByVal S As Single) As Vector
        Return New Vector(V1.X - S, V1.Y - S)
    End Operator
    Public Shared Operator *(ByVal V As Vector, ByVal S As Single) As Vector
        Return New Vector(V.X * S, V.Y * S)
    End Operator
    Public Shared Operator *(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X * V2.X, V1.Y * V2.Y)
    End Operator
    Public Shared Operator /(ByVal V1 As Vector, ByVal S As Single) As Vector
        Return New Vector(V1.X / S, V1.Y / S)
    End Operator
    Public Shared Operator /(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X / V2.X, V1.Y / V2.Y)
    End Operator
End Class '//Done
'//Color
Public Class Color
    Public A, R, G, B As Single
    Public Sub New(ByVal a As Single, ByVal r As Single, ByVal g As Single, ByVal b As Single)
        Me.A = a
        Me.R = r
        Me.G = g
        Me.B = b
    End Sub
    Public Sub New(ByVal C As System.Drawing.Color)
        Me.A = C.A
        Me.R = C.R
        Me.G = C.G
        Me.B = C.B
    End Sub
    Public Sub New()

    End Sub
    Public Shared Operator *(ByVal C As Color, ByVal Scale As Single) As Color
        Return New Color(Order(C.A * Scale), Order(C.R * Scale), Order(C.G * Scale), Order(C.B * Scale))
    End Operator
    Public Shared Operator *(ByVal C1 As Color, ByVal C2 As Color) As Color
        Return New Color(Order(C1.A * C2.A), Order(C1.R * C2.R), Order(C1.G * C2.G), Order(C1.B * C2.B))
    End Operator
    Public Shared Operator -(ByVal C1 As Color, ByVal C2 As Color) As Color
        Return New Color(Order(C1.A - C2.A), Order(C1.R - C2.R), Order(C1.G - C2.G), Order(C1.B - C2.B))
    End Operator
    Public Shared Operator +(ByVal C1 As Color, ByVal C2 As Color) As Color
        Return New Color(Order(C1.A + C2.A), Order(C1.R + C2.R), Order(C1.G + C2.G), Order(C1.B + C2.B))
    End Operator
    Public Shared Operator <>(ByVal C1 As Color, ByVal C2 As Color) As Boolean
        Return (C1.A <> C2.A Xor C1.R <> C2.R Xor C1.G <> C2.G Xor C1.B <> C2.B)
    End Operator
    Public Shared Operator =(ByVal C1 As Color, ByVal C2 As Color) As Boolean
        Return (C1.A = C2.A And C1.R = C2.R And C1.G = C2.G And C1.B = C2.B)
    End Operator
    Private Shared Function Order(ByVal Value As Integer) As Integer
        If Value > 1 Then Return 1
        If Value < 0 Then Return 0
        Return Value
    End Function
    Public Function toSO() As System.Drawing.Color
        Return System.Drawing.Color.FromArgb(A, R, G, B)
    End Function
    Public Function ToARGB() As Integer
        Return Me.toSO.ToArgb
    End Function
    Public Shared Function SystemColor(ByVal C As System.Drawing.Color) As Color
        Return New Color(C.A / 255, C.R / 255, C.B / 255, C.G / 255)
    End Function
End Class '//Done
'//Library
Public Class Library
    Public Class Rectangle
        Public X, Y, Width, ExtentX, ExtentY, Height, CenterX, CenterY As Single
        Public Size As Size
        Public Location As Point
        Public Sub New(ByVal Corner As Point, ByVal Sz As Size)
            Location = Corner
            Size = Sz
            SetStatistics()
        End Sub
        Public Sub New(ByVal Corner As Point, ByVal Wid As Single, ByVal Hgt As Single)
            Location = Corner
            Size = New Size(Wid, Hgt)
            SetStatistics()
        End Sub
        Public Sub New(ByVal CornerX As Single, ByVal CornerY As Single, ByVal Sz As Size)
            Location = New Point(CornerX, CornerY)
            Size = Sz
            SetStatistics()
        End Sub
        Public Sub New(ByVal CornerX As Single, ByVal CornerY As Single, ByVal Wid As Single, ByVal Hgt As Single)
            Location = New Point(CornerX, CornerY)
            Size = New Size(Wid, Hgt)
            SetStatistics()
        End Sub
        Private Sub SetStatistics()
            X = Location.X
            Y = Location.Y
            Width = Size.Width
            Height = Size.Height
            ExtentX = Width / 2
            ExtentY = Height / 2
            CenterX = X + ExtentX
            CenterY = Y + ExtentY
        End Sub
        Public Function Bounding() As Rectangle
            Return New Rectangle(X, Y, Width, Height)
        End Function
        Public Function ToRect() As System.Drawing.Rectangle
            Return New System.Drawing.Rectangle(X, Y, Width, Height)
        End Function
        Public Function ToRectF() As System.Drawing.RectangleF
            Return New System.Drawing.RectangleF(X, Y, Width, Height)
        End Function
        Public Function IntersectsWith(ByVal C As Circle) As Boolean
            Return Library.CircleRectangleIntersection(C, Bounding)
        End Function
        Public Function IntersectsWith(ByVal P As PointF) As Boolean
            Return Library.RectanglePointIntersection(Bounding, P)
        End Function
        Public Function IntersectsWith(ByVal R As Rectangle) As Boolean
            Return Library.RectangleRectangleIntersection(Me, R)
        End Function
        Public Function IntersectsWith(ByVal L As Line) As Boolean
            Return Library.RectangleLineIntersection(Me, L)
        End Function
        Public Function Top() As Single
            Return Y
        End Function
        Public Function Bottom() As Single
            Return Y + Height
        End Function
        Public Function Right() As Single
            Return X + Width
        End Function
        Public Function Left() As Single
            Return X
        End Function
        Public Function Center() As Point
            Return New Point(CenterX, CenterY)
        End Function
    End Class
    Public Class Circle
        Public X, Y, Diameter, Radius As Single
        Public Sub New(ByVal Center As Point, ByVal CircleRadius As Single)
            X = Center.X
            Y = Center.Y
            Radius = CircleRadius
            Diameter = 2 * Radius
        End Sub
        Public Sub New(ByVal CenterX As Integer, ByVal CenterY As Integer, ByVal CircleRadius As Single)
            X = CenterX
            Y = CenterY
            Radius = CircleRadius
            Diameter = 2 * Radius
        End Sub
        Public Function IntersectsWith(ByVal P As PointF) As Boolean
            Return Library.CirclePointIntersection(Me, P)
        End Function
        Public Function IntersectsWith(ByVal C As Circle) As Boolean
            Return Library.CircleCircleIntersection(Me, C)
        End Function
        Public Function IntersectsWith(ByVal L As Line) As Boolean
            Return Library.CircleLineIntersection(Me, L)
        End Function
        Public Function IntersectsWith(ByVal R As Rectangle) As Boolean
            Return Library.CircleRectangleIntersection(Me, R)
        End Function
        Public Function Bounding() As Rectangle
            Return New Rectangle(X - Radius, Y - Radius, Diameter, Diameter)
        End Function
        Public Function ToRect() As System.Drawing.Rectangle
            Return New System.Drawing.Rectangle(X - Radius, Y - Radius, Diameter, Diameter)
        End Function
        Public Function ToRectF() As System.Drawing.RectangleF
            Return New System.Drawing.RectangleF(X - Radius, Y - Radius, Diameter, Diameter)
        End Function
        Public Function Top() As Single
            Return Y - Radius
        End Function
        Public Function Bottom() As Single
            Return Y + Radius
        End Function
        Public Function Right() As Single
            Return X + Radius
        End Function
        Public Function Left() As Single
            Return X - Radius
        End Function
        Public Function Corner() As PointF
            Return New PointF(Left, Top)
        End Function
        Public Overrides Function ToString() As String
            Return "X:" & X & " Y:" & Y & " r:" & Radius
        End Function
    End Class
    Public Class Line
        Public X1, Y1, X2, Y2 As Single
        Public Sub New(ByVal StartPoint As Point, ByVal EndPoint As Point)
            X1 = StartPoint.X
            Y1 = StartPoint.Y
            X2 = EndPoint.X
            Y2 = EndPoint.Y
        End Sub
        Public Sub New(ByVal StartX As Single, ByVal StartY As Single, ByVal EndX As Single, ByVal EndY As Single)
            X1 = StartX
            Y1 = StartY
            X2 = EndX
            Y2 = EndY
        End Sub
        Public Function Distance() As Single
            Return Library.Distance(X1, X2, Y1, Y2)
        End Function
        Public Function IntersectsWith(ByVal C As Circle) As Boolean
            Return Library.CircleLineIntersection(C, Me)
        End Function
        Public Function IntersectsWith(ByVal R As Rectangle) As Boolean
            Return Library.RectangleLineIntersection(R, Me)
        End Function
        Public Function PointClosestTo(ByVal P As Point) As Point
            Dim Dist1 As Single = Library.Distance(X1, P.X, Y1, P.Y)
            Dim Dist2 As Single = Library.Distance(X2, P.X, Y2, P.Y)
            If Dist1 < Dist2 Then Return New Point(X1, Y1) Else Return New Point(X2, Y2)
        End Function
        Public Function PointFarthestTo(ByVal P As Point) As Point
            Dim Dist1 As Single = Library.Distance(X1, P.X, Y1, P.Y)
            Dim Dist2 As Single = Library.Distance(X2, P.X, Y2, P.Y)
            If Dist1 > Dist2 Then Return New Point(X1, Y1) Else Return New Point(X2, Y2)
        End Function
        Public Function MidPoint() As PointF
            Return Library.MidPoint(X1, X2, Y1, Y2)
        End Function
        Public Function Point1() As PointF
            Return New PointF(X1, Y1)
        End Function
        Public Function Point2() As PointF
            Return New PointF(X2, Y2)
        End Function
        Public Function BaseAngle() As Single
            Return Library.GetAngle(X2, X1, Y2, Y1)
        End Function
        Public Function InBoundingCircle(ByVal P As Point) As Boolean
            Dim LineLength As Single = Distance()
            Dim Mid As PointF = MidPoint()
            Dim Dist As Single = Library.Distance(Mid.X, P.X, Mid.Y, P.Y)
            If Dist < LineLength / 2 Then Return True Else Return False
        End Function
        Public Function InBoundingCircle(ByVal X As Single, ByVal Y As Single) As Boolean
            Dim LineLength As Single = Distance()
            Dim Mid As PointF = MidPoint()
            Dim Dist As Single = Library.Distance(Mid.X, X, Mid.Y, Y)
            If Dist < LineLength / 2 Then Return True Else Return False
        End Function
        Public Function ToRect() As System.Drawing.Rectangle
            Dim Mid As PointF = MidPoint()
            Dim Radius As Single = Distance() / 2
            Return New System.Drawing.Rectangle(Mid.X - Radius, Mid.Y - Radius, Radius * 2, Radius * 2)
        End Function
        Public Overrides Function ToString() As String
            Return "X1:" & X1 & " Y1:" & Y1 & " X2:" & X2 & " Y2:" & Y2
        End Function
    End Class
    Public Shared Function CircleCircleIntersection(ByVal C1 As Circle, ByVal C2 As Circle) As Boolean
        Return (Library.Distance(C1.X, C2.X, C1.Y, C2.Y) <= C1.Radius + C2.Radius)
    End Function
    Public Shared Function CircleLineIntersection(ByVal C As Circle, ByVal L As Line) As Boolean
        Dim Center As New Vector(C.X, C.Y)
        Dim Radius As Single = C.Radius
        Dim Pt1 As New Vector(L.X1, L.Y1)
        Dim Pt2 As New Vector(L.X2, L.Y2)
        Dim Direction As Vector = Vector.Subtract(Pt2, Pt1)
        Dim Difference As Vector = Vector.Subtract(Center, Pt1)
        Dim T As Single = Difference.Dot(Direction) / Direction.Dot(Direction)
        If T < 0.0F Then T = 0.0F
        If T > 1.0F Then T = 1.0F
        Dim Closest As Vector = Vector.Add(Pt1, Vector.Multiply(Direction, T))
        Dim D As Vector = Vector.Subtract(Center, Closest)
        Dim DistSqr As Single = D.Dot(D)
        Return (DistSqr <= Radius * Radius)
    End Function
    Public Shared Function CircleLineIntersectionUnused(ByVal C As Circle, ByVal L As Line) As Boolean
        Dim Dist As Single = Distance(C.X, L.X1, C.Y, L.Y1)
        Dim Angle As Single = GetAngle(L.X1, C.X, L.Y1, C.Y) - GetAngle(L.X1, L.X2, L.Y1, L.Y2)
        Dim ArmLength As Single = Math.Sin(Angle * Math.PI / 180) * Dist
        Return (ArmLength <= C.Radius)
    End Function '//Check
    Public Shared Function CirclePointIntersection(ByVal C As Circle, ByVal P As PointF) As Boolean
        Dim Distance As Single = Library.Distance(C.X, P.X, C.Y, P.Y)
        Return (Distance <= C.Radius)
    End Function
    Public Shared Function CirclePointIntersection(ByVal C As Circle, ByVal X As Single, ByVal Y As Single) As Boolean
        Dim Distance As Single = Library.Distance(C.X, X, C.Y, Y)
        Return (Distance <= C.Radius)
    End Function
    Public Shared Function CircleRectangleIntersection(ByVal C As Circle, ByVal R As Rectangle) As Boolean
        Dim DistanceX As Single = Math.Abs(C.X - (R.X + (R.Width / 2)))
        Dim DistanceY As Single = Math.Abs(C.Y - (R.Y + (R.Height / 2)))
        If DistanceX <= C.Radius + (R.Width / 2) Then
            If DistanceY <= C.Radius + (R.Height / 2) Then Return True Else Return False
        End If
    End Function '//Check
    Public Shared Function RectanglePointIntersection(ByVal R As Rectangle, ByVal P As PointF) As Boolean
        Dim DistX As Single = Math.Abs(R.CenterX - P.X) '//CenterX to Px
        Dim DistY As Single = Math.Abs(R.CenterY - P.Y) '//CenterY to Py
        If DistX <= R.Width / 2 Then
            If DistY < R.Height / 2 Then Return True Else Return False
        Else
            Return False
        End If
    End Function
    Public Shared Function RectangleRectangleIntersection(ByVal R1 As Rectangle, ByVal R2 As Rectangle) As Boolean
        Dim DistX As Single = Math.Abs(R1.CenterX - R2.CenterX)
        Dim DistY As Single = Math.Abs(R1.CenterY - R2.CenterY)
        If DistX <= R1.ExtentX + R2.ExtentX Then
            If DistY <= R1.ExtentY + R2.ExtentY Then Return True Else Return False
        End If
    End Function
    Public Shared Function RectangleLineIntersection(ByVal R As Rectangle, ByVal L As Line) As Boolean
        Return True
    End Function '//Check
    Public Shared Function LineLineIntersection(ByVal L1 As Line, ByVal L2 As Line) As Boolean
        Return True
    End Function '//Check
    Public Shared Function Reflection(ByVal C As Circle, ByVal L As Line, ByVal OldAngle As Single) As Single
        Dim BaseAngle, ReflectionAngle, InnerAngle, NewAngle As Single
        BaseAngle = L.BaseAngle
        ReflectionAngle = BaseAngle - 90
        InnerAngle = 90 - (OldAngle - ReflectionAngle)
        NewAngle = OldAngle + (InnerAngle * 2)
        Return NewAngle
    End Function
    Public Shared Function Distance(ByVal X1 As Single, ByVal X2 As Single, ByVal Y1 As Single, ByVal Y2 As Single) As Single
        Return Math.Sqrt((X1 - X2) ^ 2 + (Y1 - Y2) ^ 2)
    End Function
    Public Shared Function Distance(ByVal Pt1 As PointF, ByVal Pt2 As PointF) As Single
        Return Math.Sqrt((Pt1.X - Pt2.X) ^ 2 + (Pt1.Y - Pt2.Y) ^ 2)
    End Function
    Public Shared Function GetAngle(ByVal EndX As Single, ByVal StartX As Single, ByVal EndY As Single, ByVal StartY As Single) As Single
        Dim Angle As Single = Math.Atan2(EndX - StartX, EndY - StartY) * 180 / Math.PI
        Angle = IIf(Angle < 0, Angle + 360, Angle)
        Return Angle
    End Function
    Public Shared Function GetAngle(ByVal StartPoint As PointF, ByVal EndPoint As PointF) As Single
        Dim Angle As Single = Math.Atan2(EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y) * 180 / Math.PI
        Angle = IIf(Angle < 0, Angle + 360, Angle)
        Return Angle
    End Function
    Public Shared Function MidPoint(ByVal X1 As Single, ByVal X2 As Single, ByVal Y1 As Single, ByVal Y2 As Single) As PointF
        Return New PointF((X2 + X1) / 2, (Y2 + Y1) / 2)
    End Function
    Public Shared Function MidPoint(ByVal Pt1 As PointF, ByVal Pt2 As PointF) As PointF
        Return New PointF((Pt1.X + Pt2.X) / 2, (Pt1.Y + Pt2.Y) / 2)
    End Function
    Public Shared Function DegreeToRadian(ByVal A As Single) As Single
        Return A * Math.PI / 180
    End Function
    Public Shared Function RadianToDegree(ByVal A As Single) As Single
        Return A * 180 / Math.PI
    End Function
    Public Shared Function UpdatePosition(ByVal Angle As Single, ByVal Distance As Single) As Point
        Return New Point(Math.Sin(Library.DegreeToRadian(Angle)) * Distance, Math.Cos(Library.DegreeToRadian(Angle)) * Distance)
    End Function
End Class '//Done
'//GameTimer
Public Class GameTimer
    <System.Security.SuppressUnmanagedCodeSecurity()> _
    Private Declare Function QueryPerformanceFrequency Lib "Kernel32" (ByRef PerformanceFrequency As Long) As Boolean
    <System.Security.SuppressUnmanagedCodeSecurity()> _
    Private Declare Function QueryPerformanceCounter Lib "Kernel32" (ByRef PerformanceCount As Long) As Boolean
    Private TimerInitialized As Boolean = False
    Private UsingQPF As Boolean = False
    Private TimerStopped As Boolean = True
    Private TicksPerSecond As Long = 0
    Private StopTime As Long = 0
    Private LastElapsedTime As Long = 0
    Private BaseTime As Long = 0
    Private TimeNow As Long = 0
    Private ActualElapsedTime As Double = 0.0
    Public Sub New()
        TimerInitialized = True
        UsingQPF = QueryPerformanceFrequency(TicksPerSecond)
        If UsingQPF Then
            TicksPerSecond = TicksPerSecond
        Else
            Throw New Exception("Timer Init Failure -- No QueryPerformanceCounter")
        End If
    End Sub
    ''' <summary> Resets the timer to 0 </summary>
    Public Sub Reset()
        QueryPerformanceCounter(TimeNow)
        BaseTime = TimeNow
        LastElapsedTime = TimeNow
        StopTime = 0
        TimerStopped = False
    End Sub
    ''' <summary> Starts timer, call after Device initialization or when ready to start game </summary>
    Public Sub Start()
        If StopTime <> 0 Then
            TimeNow = StopTime
        Else
            QueryPerformanceCounter(TimeNow)
        End If
        If TimerStopped Then
            BaseTime += TimeNow - StopTime
        End If
        StopTime = 0
        LastElapsedTime = TimeNow
        TimerStopped = False
    End Sub
    ''' <summary> Stops timer, call when application is closing </summary>
    Public Sub [Stop]()
        QueryPerformanceCounter(TimeNow)
        StopTime = TimeNow
        LastElapsedTime = TimeNow
        TimerStopped = True
    End Sub
    Public ReadOnly Property Frequency() As Long
        Get
            Return TicksPerSecond
        End Get
    End Property
    Public Sub Advance()
        StopTime += TicksPerSecond / 10
    End Sub
    Public ReadOnly Property AbsoluteTime() As Single
        Get
            If StopTime <> 0 Then
                TimeNow = StopTime
            Else
                QueryPerformanceCounter(TimeNow)
            End If
            Return CSng(TimeNow / CDbl(TicksPerSecond))
        End Get
    End Property
    Public ReadOnly Property ApplicationTime() As Single
        Get
            Return TimeDelta(BaseTime)
        End Get
    End Property
    ''' <summary> Gets the Deltatime (Time elapsed since last call or render) </summary>
    Public ReadOnly Property ElapsedTime() As Single
        Get
            Return TimeDelta(LastElapsedTime)
        End Get
    End Property
    Private Function TimeDelta(ByVal RefTime As Single) As Single
        QueryPerformanceCounter(TimeNow)
        ActualElapsedTime = CDbl(TimeNow - RefTime) / CDbl(TicksPerSecond)
        LastElapsedTime = TimeNow
        Return CSng(ActualElapsedTime)
    End Function
    Public ReadOnly Property PeekTime() As Single
        Get
            Dim Peek As Long = 0
            QueryPerformanceCounter(Peek)
            Return CSng(Peek - LastElapsedTime) / CSng(TicksPerSecond)
        End Get
    End Property
End Class '//Done
'//QuadRenderer
Public Class QuadRenderer
    Private Structure QL
        Public Name As String
        Public Quad As Quad
    End Structure
    Public Shared Quads As ArrayList
    Private Shared LastQuad As String
    Public Sub New()
        Quads = New ArrayList
    End Sub
    Public Shared Sub Initialize()
        Quads = New ArrayList
    End Sub
    Public Shared Sub Clear()
        Quads = New ArrayList
    End Sub
    Public Shared Sub Add(ByVal Q As Quad, ByVal ReferenceName As String)
        Dim QL As QL
        QL.Name = ReferenceName
        QL.Quad = Q
        LastQuad = ReferenceName
        Quads.Add(QL)
    End Sub
    Public Shared Sub Remove(ByVal Name As String)
        For Each Q As QL In Quads
            If Q.Name = Name Then
                Quads.Remove(Q)
                Return
            End If
        Next
    End Sub
    Public Shared Sub Render(ByVal Device As Device)
        For Each Q As QL In Quads
            Q.Quad.Render(Device)
        Next
    End Sub
    Public Shared Function Quad(ByVal Name As String) As Quad
        For Each Q As QL In Quads
            If Q.Name = Name Then
                Return Q.Quad
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function Last() As Quad
        Return Quad(LastQuad)
    End Function
    Public Shared Sub Dispose()
        For Each Q As QL In Quads
            Q.Quad.Dispose()
        Next
    End Sub
End Class '//Done
'//Quad
Public Class Quad
    Public CustomVertexFlags As VertexFormats = CustomVertex.TransformedColoredTextured.Format 'VertexFormats.Transformed Or VertexFormats.Texture1
    Public Structure StructCustomVertex
        Public X As Single
        Public Y As Single
        Public Z As Single
        Public Rhw As Single
        Public Tu As Single
        Public Tv As Single
    End Structure
    Public Location As Vector
    Public Width, Height As Single
    Public Texture As Texture
    Public Vertices(3) As CustomVertex.TransformedColoredTextured
    Public Sub New(ByVal X As Single, ByVal Y As Single, ByVal Width As Single, ByVal Height As Single, ByVal Texture As Texture, ByVal Color As Integer)
        Me.Location = New Vector(X, Y)
        Me.Width = Width
        Me.Height = Height
        Me.Texture = Texture
        Vertices(0) = New CustomVertex.TransformedColoredTextured(X, Y, 0, 1, Color, 0, 0)
        Vertices(1) = New CustomVertex.TransformedColoredTextured(X + Width, Y, 0, 1, Color, 1, 0)
        Vertices(2) = New CustomVertex.TransformedColoredTextured(X, Y + Height, 0, 1, Color, 0, 1)
        Vertices(3) = New CustomVertex.TransformedColoredTextured(X + Width, Y + Height, 0, 1, Color, 1, 1)
    End Sub
    Public Sub Reset(ByVal X As Single, ByVal Y As Single, ByVal Width As Single, ByVal Height As Single, ByVal Color As Integer)
        Vertices(0) = New CustomVertex.TransformedColoredTextured(X, Y, 0, 1, Color, 0, 0)
        Vertices(1) = New CustomVertex.TransformedColoredTextured(X + Width, Y, 0, 1, Color, 1, 0)
        Vertices(2) = New CustomVertex.TransformedColoredTextured(X, Y + Height, 0, 1, Color, 0, 1)
        Vertices(3) = New CustomVertex.TransformedColoredTextured(X + Width, Y + Height, 0, 1, Color, 1, 1)
    End Sub
    Public Sub Render(ByVal Device As Device)
        Device.VertexFormat = CustomVertexFlags
        Device.SetTexture(0, Texture)
        Device.DrawUserPrimitives(PrimitiveType.TriangleStrip, 2, Vertices)
    End Sub
    Public Sub Dispose()
        If Not (Texture Is Nothing) Then
            Texture.Dispose()
        End If
        Texture = Nothing
    End Sub
End Class '//Done
'//AnimatedQuad
Public Class AnimatedQuad

End Class
'//SpriteQuad
Public Class SpriteQuad
    Public Location As Vector
    Public Width, Height As Single
    Public Texture As Texture
    Public Angle As Single
    Public Scale As Single
    Public ShadeColor As Color
    Private ReadOnly Property Center() As Vector
        Get
            Return New Vector(Location.X + Width / 2, Location.Y + Height / 2)
        End Get
    End Property
    Public Sub New(ByVal X As Single, ByVal Y As Single, ByVal Width As Single, ByVal Height As Single, ByVal Angle As Single, ByVal Scale As Single, ByVal Texture As Texture, ByVal ShadeColor As Color)
        Me.Location = New Vector(X, Y)
        Me.Width = Width
        Me.Height = Height
        Me.Angle = Angle
        Me.Scale = Scale
        Me.Texture = Texture
        Me.ShadeColor = ShadeColor
    End Sub
    Public Sub Render(ByVal Device As Device)
        Device.RenderState.ZBufferWriteEnable = False
        Device.RenderState.AlphaBlendEnable = True
        Device.RenderState.SourceBlend = Blend.SourceAlpha
        Device.RenderState.DestinationBlend = Blend.One
        Dim Sprite As New Sprite(Device)
        Try
            Sprite.Begin(SpriteFlags.SortTexture)
            Sprite.Transform = Matrix.Multiply(Matrix.Multiply(Matrix.RotationZ(Angle * Math.PI / 180), Matrix.Translation(Center.ToSO)), Matrix.Scaling(1.0F, 1.0F, 1.0F))
            Sprite.Draw(Texture, Center.ToSO, Location.ToSO, ShadeColor.ToARGB)
            Sprite.End()
        Finally
            Sprite.Dispose()
        End Try
        Device.RenderState.ZBufferWriteEnable = True
        Device.RenderState.AlphaBlendEnable = False
    End Sub
    Public Sub Dispose()
        If Not (Texture Is Nothing) Then
            Texture.Dispose()
        End If
        Texture = Nothing
    End Sub
End Class '//Done
'//Sound Manager
Public Class SoundManager
    Private Shared SoundDevice As DS.Device = Nothing
    Private Shared SoundBuffers As New ArrayList
    Private Shared LastSound As String
    ''' <summary> Calls on New SoundHandler class </summary>
    Public Sub New(ByVal Owner As Control)
        SoundDevice = New DS.Device
        SoundDevice.SetCooperativeLevel(Owner, DS.CooperativeLevel.Priority)
        SoundBuffers = New ArrayList
    End Sub
    ''' <summary> Initializes New SoundHandler class </summary>
    Public Shared Sub Initialize(ByVal Owner As Control)
        SoundDevice = New DS.Device
        SoundDevice.SetCooperativeLevel(Owner, DS.CooperativeLevel.Priority)
        SoundBuffers = New ArrayList
    End Sub
    ''' <summary> Clears the Device of all sounds </summary>
    ''' <remarks></remarks>
    Public Shared Sub ClearSounds()
        Dispose()
        SoundBuffers = New ArrayList
    End Sub
    ''' <summary> Adds A Sound to the system </summary>
    ''' <param name="Filename"> Full filepath </param>
    ''' <param name="ReferenceName"> Name to use to reference to play </param>
    ''' <param name="Looping"> Is it looping, or do you call on it </param>
    Public Shared Sub AddBuffer(ByVal Filename As String, ByVal ReferenceName As String, ByVal Looping As Boolean)
        SoundBuffers.Add(New SoundBuffer(SoundDevice, Filename, ReferenceName, Looping))
    End Sub
    ''' <summary> Plays the selected sound </summary>
    ''' <param name="Name"> Name you used to reference this Sound </param>
    Public Shared Sub Play(ByVal Name As String)
        Dim Buffer As SoundBuffer
        For Each Buffer In SoundBuffers
            Dim IsBufferOn As Boolean = (Buffer.Sound = Name)
            Buffer.Play(IsBufferOn)
        Next Buffer
        LastSound = Name
    End Sub
    ''' <summary> Used to dispose all the sound objects </summary>
    Public Shared Sub Dispose()
        Dim Sound As SoundBuffer
        For Each Sound In SoundBuffers
            Sound.Dispose()
        Next
    End Sub
End Class '//Done
'//Sound
Public Class SoundBuffer
    Private Buffer As DS.Buffer
    Private ThisSound As String
    Private Looping As Boolean
    Private LastValue As Boolean
    Public Sub New(ByVal SoundDevice As DS.Device, ByVal Filename As String, ByVal ThisSound As String, ByVal Looping As Boolean)
        Me.ThisSound = ThisSound
        Me.Looping = Looping
        Try
            Buffer = New DS.SecondaryBuffer(Filename, SoundDevice)
        Catch E As Exception
            Throw New Exception([String].Format("Error Opening {0}", Filename), E)
        End Try
    End Sub
    Public ReadOnly Property Sound() As String
        Get
            Return ThisSound
        End Get
    End Property
    Public Property Volume() As Integer
        Get
            Return Buffer.Volume
        End Get
        Set(ByVal Value As Integer)
            Buffer.Volume = Value
        End Set
    End Property
    Public Sub Play(ByVal [On] As Boolean)
        If Looping Then
            If [On] Then
                If Not LastValue Then
                    Buffer.SetCurrentPosition(1000)
                    Buffer.Play(0, DS.BufferPlayFlags.Looping)
                End If
            Else
                Buffer.Stop()
            End If
            LastValue = [On]
        Else
            If [On] Then
                Buffer.SetCurrentPosition(0)
                Buffer.Play(0, DS.BufferPlayFlags.Default)
            End If
        End If
    End Sub
    Public Sub StopSound()
        If Not (Buffer Is Nothing) Then
            Buffer.Stop()
        End If
    End Sub
    Public Sub Dispose()
        Buffer.Dispose()
    End Sub
End Class '//Done
'//Cursor
Public Class Cursor
    Private Pointer As Vector
    Private Texture As Texture
    Public Sub New(ByVal Texture As Texture)
        Me.Texture = Texture
        Pointer = New Vector
    End Sub
    Public Sub Update(ByVal X As Single, ByVal Y As Single)
        Pointer.X = X
        Pointer.Y = Y
    End Sub
    Public Sub Render(ByVal Scale As Single)
        Dim Sprite As New Sprite(Scene.LocalDevice)
        Sprite.Begin(SpriteFlags.AlphaBlend)
        Sprite.Transform = Matrix.Scaling(Scale, Scale, 1.0F)
        Dim Location As New Vector3(Pointer.X / Scale, Pointer.Y / Scale, 0)
        Sprite.Draw(Texture, Vector3.Empty, Location, Drawing.Color.White.ToArgb)
        Sprite.End()
        Sprite.Dispose()
    End Sub
End Class '//Done
'//Media
Public Class Media
    Public Shared StartupPath As String = Application.StartupPath
    Public Shared Function FindFile(ByVal FullName As String) As String
        If IO.File.Exists(AppendFolder(StartupPath) & FullName) Then
            Return AppendFolder(StartupPath) & FullName
        Else
            If IO.File.Exists(AppendFolder(StartupPath) & "..\\" & FullName) Then
                Return AppendFolder(StartupPath) & "..\\" & FullName
            Else
                If IO.File.Exists(AppendFolder(StartupPath) & "..\\..\\" & FullName) Then
                    Return AppendFolder(StartupPath) & "..\\..\\" & FullName
                End If
            End If
        End If
        Return FullName
    End Function
    Public Shared Function Exists(ByVal Path As String) As Boolean
        Return IO.File.Exists(Path)
    End Function
    Public Shared Function GetFolders(ByVal RootDirectory As String) As String()
        Return IO.Directory.GetDirectories(AppendFolder(RootDirectory))
    End Function
    Public Shared Function GetFiles(ByVal RootDirectory As String) As String()
        Return IO.Directory.GetFiles(AppendFolder(RootDirectory))
    End Function
    Public Shared Function GetFileExtension(ByVal Path As String) As String
        Return Path.Substring(Path.LastIndexOf(".") + 1)
    End Function
    Public Shared Function GetFileName(ByVal Path As String) As String
        Return Path.Substring(Path.LastIndexOf("\") + 1, Path.LastIndexOf(".") - Path.LastIndexOf("\") - 1)
    End Function
    Private Shared Function AppendFolder(ByVal Folder As String) As String
        Return IIf(Folder.EndsWith("\"), Folder, Folder & "\")
    End Function
End Class