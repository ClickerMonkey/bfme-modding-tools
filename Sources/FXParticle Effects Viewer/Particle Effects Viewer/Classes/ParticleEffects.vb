Imports System
Imports System.Math
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
'//Particle
Public Class Particle
    Public Structure ParticleColor
        Public R, G, B As Double
    End Structure
    Public Lifetime, VelocityDamping, Gravity, Size, SizeRate, SizeRateDamping, AngleZ, AngularDamping, AngularRateZ As Double
    Public Location, Velocity, DriftVelocity As Vector3
    Public Color, ColorDelta As ColorValue
    Public LastColor, LastAlpha As Integer
    Public Time, Theta, Omega As Double
    Public Alpha, AlphaDelta As Double
    Public Sub New()
    End Sub
    Public Function ActiveColor() As Integer
        Try

            Dim A As Integer = IIf(Alpha >= 128, Alpha - 256, Alpha)
            Return (A * 256 ^ 2 * 256) + (Color.Red * 256 ^ 2) + (Color.Green * 256) + Color.Blue
        Catch
            GameError.Raise(GameError.ErrorType.MathematicalOverFlow, GameError.ErrorSeverity.Warning, GetType(Particle), "Couldnt calculate Particles Color, overflow")
            Return -1
        End Try
    End Function
    Private Sub Resize(ByRef Value As Integer)
        If Value > 255 Then Value = 255
        If Value < 0 Then Value = 0
    End Sub
End Class
'//ParticleSystem
Public Class ParticleSystem
    '//Public Variables
    Public MaxParticles As Integer
    Public Info As ParticleSystemInfo
    Public BurstDelay, BurstCount, InitialDelay As Double
    Public Particles As ArrayList
    Public ParticlesAlive As Integer
    Public SystemLife As Double
    '//Private Variables
    Private UpdateSpeed, Residue As Double
    Private Time, BurstTime As Double
    Private CreateNew As Boolean = True
    Private VertexBuffer As VertexBuffer = Nothing
    Private IndexBuffer As IndexBuffer = Nothing
    Private Rotation As Vector3
    Public ReadOnly DesiredFPS As Double
    '//Public Functions
    Public Sub New(ByVal PSI As ParticleSystemInfo, Optional ByVal DesiredFPS As Double = 0.0F, Optional ByVal ParticlesAllowed As Integer = 1000)
        Info = PSI
        Particles = New ArrayList
        SystemLife = Info.tSystemLifetime
        Residue = 0.0F
        Me.DesiredFPS = DesiredFPS
        If (DesiredFPS <> 0.0F) Then UpdateSpeed = 1.0F / DesiredFPS Else UpdateSpeed = 0.0F
        BurstDelay = 0
        BurstCount = Scene.RandI(Info.tBurstCount.Min, Info.tBurstCount.Max)
        MaxParticles = ParticlesAllowed
        '//Initialize VertexBuffer
        Try
            VertexBuffer = New VertexBuffer(GetType(CustomVertex.PositionColoredTextured), MaxParticles * 4, Scene.LocalDevice, Usage.WriteOnly, CustomVertex.PositionColoredTextured.Format, Pool.Default)
        Catch ex As Exception
            GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Critical, GetType(ParticleSystem), "Error Initializing Particle Systems VertexBuffer" & vbCrLf & "More Info: " & ex.Message)
        End Try
        '//IndexBuffer
        Try
            IndexBuffer = New IndexBuffer(GetType(Integer), MaxParticles * 6, Scene.LocalDevice, Usage.Points, Pool.Default)
            '//SetupIndexBuffer
            Dim Indices() As Integer = IndexBuffer.Lock(0, LockFlags.Discard)
            For I As Integer = 0 To MaxParticles - 1
                Indices(I * 6) = I * 4
                Indices(I * 6 + 1) = I * 4 + 1
                Indices(I * 6 + 2) = I * 4 + 3
                Indices(I * 6 + 3) = I * 4 + 1
                Indices(I * 6 + 4) = I * 4 + 2
                Indices(I * 6 + 5) = I * 4 + 3
            Next
            IndexBuffer.Unlock()
            IndexBuffer.SetData(Indices, 0, LockFlags.Discard)
        Catch ex As Exception
            GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Critical, GetType(ParticleSystem), "Error Initializing Particle Systems IndexBuffer" & vbCrLf & "More Info: " & ex.Message)
        End Try
    End Sub
    Public Sub Update()
        If UpdateSpeed = 0.0F Then
            UpdateSystem(Scene.DeltaTime)
        Else
            Residue += Scene.DeltaTime
            If Residue >= UpdateSpeed Then
                UpdateSystem(UpdateSpeed)
                While Residue >= UpdateSpeed
                    Residue -= UpdateSpeed
                End While
            End If
        End If
    End Sub
    Public Sub Render()
        If ParticlesAlive <= 0 Then Return
        Try
            Dim D As Device = Scene.LocalDevice
            D.RenderState.ZBufferWriteEnable = False
            D.RenderState.AlphaBlendEnable = True
            If Info.Shader = ParticleSystemInfo.Shaders.ADDITIVE Then
                D.RenderState.SourceBlend = Blend.SourceAlpha
                D.RenderState.DestinationBlend = Blend.One
            Else
                D.RenderState.SourceBlend = Blend.InvSourceAlpha
                D.RenderState.DestinationBlend = Blend.One
            End If
            D.RenderState.Lighting = False
            D.SetTextureStageState(0, TextureStageStates.AlphaOperation, True)
            D.VertexFormat = CustomVertex.PositionColoredTextured.Format
            D.SetTexture(0, TextureManager.Texture(Info.tParticleName))
            D.SetStreamSource(0, VertexBuffer, 0)
            D.Indices = IndexBuffer
            Dim Vertices() As CustomVertex.PositionColoredTextured
            Vertices = VertexBuffer.Lock(0, LockFlags.Discard)
            For I As Integer = 0 To ParticlesAlive - 1
                Dim P As Particle = Particles(I)
                Quad.SetVertices(P.Location, P.AngleZ, P.Size, P.ActiveColor, Info.IsGroundAligned)
                Vertices(I * 4) = Quad.V(0)
                Vertices(I * 4 + 1) = Quad.V(1)
                Vertices(I * 4 + 2) = Quad.V(2)
                Vertices(I * 4 + 3) = Quad.V(3)
            Next
            VertexBuffer.Unlock()
            D.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, (ParticlesAlive - 1) * 4, 0, (ParticlesAlive - 1) * 2)
            D.RenderState.ZBufferWriteEnable = True
            D.RenderState.AlphaBlendEnable = False
        Catch ex As Exception
            GameError.Raise(GameError.ErrorType.ErrorRendering, GameError.ErrorSeverity.Critical, GetType(ParticleSystemInfo), "Couldnt Render Particle System" & vbCrLf & "More Info: " & ex.Message)
        End Try
    End Sub
    Public Sub Resized()
        Try
            '//Initialize VertexBuffer
            VertexBuffer = New VertexBuffer(GetType(CustomVertex.PositionColoredTextured), MaxParticles * 4, Scene.LocalDevice, Usage.WriteOnly, CustomVertex.PositionColoredTextured.Format, Pool.Default)
            '//IndexBuffer
            IndexBuffer = New IndexBuffer(GetType(Integer), MaxParticles * 6, Scene.LocalDevice, Usage.Points, Pool.Default)
            '//SetupIndexBuffer
            Dim Indices() As Integer = IndexBuffer.Lock(0, LockFlags.Discard)
            For I As Integer = 0 To MaxParticles - 1
                Indices(I * 6) = I * 4
                Indices(I * 6 + 1) = I * 4 + 1
                Indices(I * 6 + 2) = I * 4 + 3
                Indices(I * 6 + 3) = I * 4 + 1
                Indices(I * 6 + 4) = I * 4 + 2
                Indices(I * 6 + 5) = I * 4 + 3
            Next
            IndexBuffer.Unlock()
            IndexBuffer.SetData(Indices, 0, LockFlags.Discard)
        Catch ex As Exception
            GameError.Raise(GameError.ErrorType.ErrorResizing, GameError.ErrorSeverity.Warning, GetType(ParticleSystem), "Couldnt Resize Data of Particle System" & vbCrLf & "More Info: " & ex.Message)
        End Try
    End Sub
    Public Sub SetRotation(ByVal Theta As Double, ByVal Omega As Double)
        Rotation.X = Sin(Theta) * Cos(Omega)
        Rotation.Z = Sin(Theta) * Sin(Omega)
        Rotation.Y = Cos(Theta)
    End Sub
    '//Private Functions
    Private Sub UpdateSystem(ByVal Deltatime As Double)
        If Time < InitialDelay Then
            Time += Deltatime
        Else
            BurstTime += Deltatime
            CreateNew = True
            If Info.tIsOneShot Then
                Info.tSystemLifetime -= Deltatime
                If Info.tSystemLifetime <= 0.0F Then
                    CreateNew = False
                End If
            End If
            '//Create New
            If CreateNew Then
                If BurstTime >= BurstDelay Then
                    BurstTime -= BurstDelay
                    If Particles.Count + BurstCount > MaxParticles Then
                        BurstCount = MaxParticles - Particles.Count
                    End If
                    For I As Integer = 0 To BurstCount
                        Dim P As New Particle
                        NewParticle(P)
                        Particles.Add(P)
                    Next
                    BurstDelay = Info.Random(Info.tBurstDelay)
                    BurstCount = CInt(Info.Random(Info.tBurstCount))
                End If
            End If

            '//Update Each Particle Alive
            ParticlesAlive = 0
            For I As Integer = Particles.Count - 1 To 0 Step -1
                If UpdateParticle(Particles(I), Deltatime) = False Then
                    Particles.RemoveAt(I)
                End If
            Next
            ParticlesAlive = Particles.Count
        End If
    End Sub
    Private Sub NewParticle(ByRef P As Particle)
        AdvanceColor(P, 0)
        AdvanceAlpha(P, 0)
        P.Gravity = Info.Random(Info.tGravity)
        P.Lifetime = Info.Random(Info.tLifetime)
        P.DriftVelocity = Info.tDriftVelocity
        P.Size = Info.Random(Info.tSize)
        P.SizeRate = Info.Random(Info.tSizeRate)
        P.SizeRateDamping = Info.Random(Info.tSizeRateDamping)
        P.AngleZ = Info.Random(Info.tAngleZ)
        P.AngularRateZ = Info.Random(Info.tAngularRateZ)
        P.AngularDamping = Info.Random(Info.tAngularDamping)
        P.Theta = Scene.RandI(0, 360) * Math.PI / 180
        P.Omega = Scene.RandI(0, 360) * Math.PI / 180
        P.Location = InitialPosition(P)
        P.Velocity = InitialVelocity(P)
        P.VelocityDamping = Info.Random(Info.tVelocityDamping)
        P.DriftVelocity = Info.tDriftVelocity
    End Sub
    Private Function UpdateParticle(ByRef P As Particle, ByVal Deltatime As Double) As Boolean
        P.Lifetime -= Deltatime
        If P.Lifetime <= 0.0F Then
            Return False
        End If
        P.Time += Deltatime
        '//Alpha
        If P.Time > Info.tAlphas(1).Time And Info.tAlphas(2).Time <> 0 Then
            If P.Time > Info.tAlphas(2).Time And Info.tAlphas(3).Time <> 0 Then
                If P.Time > Info.tAlphas(3).Time And Info.tAlphas(4).Time <> 0 Then
                    If P.Time > Info.tAlphas(4).Time And Info.tAlphas(5).Time <> 0 Then
                        If P.Time > Info.tAlphas(5).Time And Info.tAlphas(6).Time <> 0 Then
                            If P.Time > Info.tAlphas(6).Time And Info.tAlphas(7).Time <> 0 Then
                                If P.LastAlpha <> 6 Then AdvanceAlpha(P, 6)
                            Else
                                If P.LastAlpha <> 5 Then AdvanceAlpha(P, 5)
                            End If
                        Else
                            If P.LastAlpha <> 4 Then AdvanceAlpha(P, 4)
                        End If
                    Else
                        If P.LastAlpha <> 3 Then AdvanceAlpha(P, 3)
                    End If
                Else
                    If P.LastAlpha <> 2 Then AdvanceAlpha(P, 2)
                End If
            Else
                If P.LastAlpha <> 1 Then AdvanceAlpha(P, 1)
            End If
        End If
        '//Color
        If P.Time > Info.tColors(1).Time And Info.tColors(2).Time <> 0 Then
            If P.Time > Info.tColors(2).Time And Info.tColors(3).Time <> 0 Then
                If P.Time > Info.tColors(3).Time And Info.tColors(4).Time <> 0 Then
                    If P.Time > Info.tColors(4).Time And Info.tColors(5).Time <> 0 Then
                        If P.Time > Info.tColors(5).Time And Info.tColors(6).Time <> 0 Then
                            If P.Time > Info.tColors(6).Time And Info.tColors(7).Time <> 0 Then
                                If P.LastColor <> 6 Then AdvanceColor(P, 6)
                            Else
                                If P.LastColor <> 5 Then AdvanceColor(P, 5)
                            End If
                        Else
                            If P.LastColor <> 4 Then AdvanceColor(P, 4)
                        End If
                    Else
                        If P.LastColor <> 3 Then AdvanceColor(P, 3)
                    End If
                Else
                    If P.LastColor <> 2 Then AdvanceColor(P, 2)
                End If
            Else
                If P.LastColor <> 1 Then AdvanceColor(P, 1)
            End If
        End If
        '//Physics
        P.Size += P.SizeRate * Deltatime
        P.SizeRate *= P.SizeRateDamping
        P.AngleZ += P.AngularRateZ * Deltatime
        P.AngularRateZ *= P.AngularDamping
        P.Color.Red += P.ColorDelta.Red * Deltatime
        P.Color.Green += P.ColorDelta.Green * Deltatime
        P.Color.Blue += P.ColorDelta.Blue * Deltatime
        P.Alpha += P.AlphaDelta * Deltatime
        P.Location += P.Velocity * Deltatime
        P.Location += P.DriftVelocity * Deltatime
        P.Location.Z += P.Gravity * Deltatime
        P.Velocity *= P.VelocityDamping
        Return True
    End Function
    Private Function InitialVelocity(ByVal P As Particle) As Vector3
        Dim X, Y, Z As Double
        Select Case Info.EmissionVelocity
            Case ParticleSystemInfo.EmissionVelocityType.CylindricalEmissionVelocity
                X = Cos(P.Theta) * Info.Random(Info.tRadial)
                Y = Sin(P.Theta) * Info.Random(Info.tRadial)
                Z = Info.Random(Info.tNormal)
            Case ParticleSystemInfo.EmissionVelocityType.OrthoEmissionVelocity
                X = Info.Random(Info.tX)
                Y = Info.Random(Info.tY)
                Z = Info.Random(Info.tZ)
            Case ParticleSystemInfo.EmissionVelocityType.OutwardEmissionVelocity
                X = Sin(P.Theta) * Cos(P.Omega) * Info.Random(Info.tSpeed)
                Y = Sin(P.Theta) * Sin(P.Omega) * Info.Random(Info.tSpeed)
                Z = Cos(P.Theta) * Info.Random(Info.tSpeed)
        End Select
        Return New Vector3(X, Y, Z)
    End Function
    Private Function InitialPosition(ByVal P As Particle) As Vector3
        Dim X, Y, Z As Double
        Select Case Info.EmissionVolume
            Case ParticleSystemInfo.EmissionVolumeType.CylinderEmissionVolume
                If Info.IsHollow Then
                    X = Cos(P.Theta) * Info.tRadius + Info.Offset.X
                    Y = Sin(P.Theta) * Info.tRadius + Info.Offset.Y
                    Z = Scene.RandS(0, Info.tLength) - Info.tLength / 2 + Info.Offset.Z
                Else
                    X = Cos(P.Theta) * Scene.RandS(0, Info.tRadius) + Info.Offset.X
                    Y = Sin(P.Theta) * Scene.RandS(0, Info.tRadius) + Info.Offset.Y
                    Z = Scene.RandS(0, Info.tLength) - Info.tLength / 2 + Info.Offset.Z
                End If
            Case ParticleSystemInfo.EmissionVolumeType.LineEmissionVolume
                Dim Position As Double = Scene.RandS(0, Info.LineDistance)
                X = (Info.tEndPoint.X - Info.tStartPoint.X) * (Position / Info.LineDistance) + Info.tStartPoint.X
                Y = (Info.tEndPoint.Y - Info.tStartPoint.Y) * (Position / Info.LineDistance) + Info.tStartPoint.Y
                Z = (Info.tEndPoint.Z - Info.tStartPoint.Z) * (Position / Info.LineDistance) + Info.tStartPoint.Z
            Case ParticleSystemInfo.EmissionVolumeType.PointEmissionVolume
                X = 0
                Y = 0
                Z = 0
            Case ParticleSystemInfo.EmissionVolumeType.SphereEmissionVolume
                If Info.IsHollow Then
                    X = Sin(P.Theta) * Cos(P.Omega) * Info.tRadius
                    Y = Sin(P.Theta) * Sin(P.Omega) * Info.tRadius
                    Z = Cos(P.Theta) * Info.tRadius
                Else
                    X = Sin(P.Theta) * Cos(P.Omega) * Scene.RandS(0, Info.tRadius)
                    Y = Sin(P.Theta) * Sin(P.Omega) * Scene.RandS(0, Info.tRadius)
                    Z = Cos(P.Theta) * Scene.RandS(0, Info.tRadius)
                End If
            Case ParticleSystemInfo.EmissionVolumeType.BoxEmissionVolume
                If Info.tIsHollow Then
                    Dim Side As Integer = Scene.RandI(1, 6)
                    X = Scene.RandS(0, Info.tHalfSize.X * 2) - Info.tHalfSize.X
                    Y = Scene.RandS(0, Info.tHalfSize.Z * 2) - Info.tHalfSize.Y
                    Z = Scene.RandS(0, Info.tHalfSize.Y * 2) - Info.tHalfSize.Y
                    Select Case Side
                        Case 1 '//Top
                            Z = Info.tHalfSize.Z
                        Case 2 '//Bottom
                            Z = -Info.tHalfSize.Z
                        Case 3 '//Right
                            X = Info.tHalfSize.X
                        Case 4 '//Left
                            X = -Info.tHalfSize.X
                        Case 5 '//Front
                            Y = Info.tHalfSize.Y
                        Case 6 '//Back
                            Y = -Info.tHalfSize.Y
                    End Select
                Else
                    X = Scene.RandS(0, Info.tHalfSize.X * 2) - Info.tHalfSize.X
                    Y = Scene.RandS(0, Info.tHalfSize.Z * 2) - Info.tHalfSize.Y
                    Z = Scene.RandS(0, Info.tHalfSize.Y * 2) - Info.tHalfSize.Y
                End If
        End Select
        Return New Vector3(X, Y, Z) + Info.tLocation
    End Function
    Private Sub AdvanceColor(ByRef P As Particle, ByVal Current As Integer)
        Dim Time As Double = Info.tColors(Current + 1).Time - Info.tColors(Current).Time
        P.Color.Red = Info.tColors(Current).R
        P.Color.Green = Info.tColors(Current).G
        P.Color.Blue = Info.tColors(Current).B
        P.ColorDelta.Red = (Info.tColors(Current + 1).R - Info.tColors(Current).R) / Time
        P.ColorDelta.Green = (Info.tColors(Current + 1).G - Info.tColors(Current).G) / Time
        P.ColorDelta.Blue = (Info.tColors(Current + 1).B - Info.tColors(Current).B) / Time
        P.LastColor = Current
    End Sub
    Private Sub AdvanceAlpha(ByRef P As Particle, ByVal Current As Integer)
        Dim StartAlpha, EndAlpha, Time As Double
        StartAlpha = Scene.RandS(Info.tAlphas(Current).A1, Info.tAlphas(Current).A2)
        EndAlpha = Scene.RandS(Info.tAlphas(Current + 1).A1, Info.tAlphas(Current + 1).A2)
        Time = Info.tAlphas(Current + 1).Time - Info.tAlphas(Current).Time
        P.Alpha = StartAlpha
        P.AlphaDelta = (EndAlpha - StartAlpha) / Time
        P.LastAlpha = Current
    End Sub
End Class
'//ParticleSystemInfo
Public Class ParticleSystemInfo
    '//Enums
    Public Enum Priorities
        ALWAYS_RENDER = 0
        CRITICAL = 1
        AREA_EFFECT = 2
        WEAPON_TRAIL = 3
        CONSTANT = 4
        SEMI_CONSTANT = 5
        DEATH_EXPLOSION = 6
        UNIT_DAMAGE_FX = 7
        DEBRIS_TRAIL = 8
        BUILDUP = 9
        DUST_TRAIL = 10
        SCORCH_MARK = 11
        WEAPON_EXPLOSION = 12
    End Enum
    Public Enum Shaders
        ALPHA = 0
        ADDITIVE = 1
    End Enum
    Public Enum EmissionVelocityType
        OutwardEmissionVelocity = 0
        OrthoEmissionVelocity = 1
        CylindricalEmissionVelocity = 2
    End Enum
    Public Enum EmissionVolumeType
        PointEmissionVolume = 0
        CylinderEmissionVolume = 1
        LineEmissionVolume = 2
        SphereEmissionVolume = 3
        BoxEmissionVolume = 4
    End Enum
    '//Structures
    Public Structure Value
        Public Min As Double
        Public Max As Double
    End Structure
    Public Structure ColorTime
        Public R As Double
        Public G As Double
        Public B As Double
        Public Time As Double
    End Structure
    Public Structure AlphaTime
        Public A1 As Double
        Public A2 As Double
        Public Time As Double
    End Structure
    Public Structure ColorDelta
        Public R, G, B As Integer
    End Structure
    '//==System==
    Public tParticleSystemName As String
    Public Property ParticleSystemName() As String
        Get
            Return tParticleSystemName
        End Get
        Set(ByVal value As String)
            tParticleSystemName = value
        End Set
    End Property
    Public tPriority As Priorities = Priorities.ALWAYS_RENDER '//Required
    Public Property Priority() As Priorities
        Get
            Return tPriority
        End Get
        Set(ByVal value As Priorities)
            tPriority = value
        End Set
    End Property
    Public tShader As Shaders = Shaders.ALPHA
    Public Property Shader() As Shaders
        Get
            Return tShader
        End Get
        Set(ByVal value As Shaders)
            tShader = value
        End Set
    End Property
    Public tParticleName As String = "" '//Required
    Public Property ParticleName() As String
        Get
            Return tParticleName
        End Get
        Set(ByVal value As String)
            tParticleName = value
        End Set
    End Property
    Public tIsOneShot As Boolean = False
    Public Property IsOneShot() As Boolean
        Get
            Return tIsOneShot
        End Get
        Set(ByVal value As Boolean)
            tIsOneShot = value
        End Set
    End Property
    Public tIsGroundAligned As Boolean = False
    Public Property IsGroundAligned() As Boolean
        Get
            Return tIsGroundAligned
        End Get
        Set(ByVal value As Boolean)
            tIsGroundAligned = value
        End Set
    End Property
    Public tSortLevel As Integer = 0
    Public Property SortLevel() As Integer
        Get
            Return tSortLevel
        End Get
        Set(ByVal value As Integer)
            tSortLevel = value
        End Set
    End Property
    Public tSystemLifetime As Double = 0.0F
    Public Property SystemLifetime() As Double
        Get
            Return tSystemLifetime * 25
        End Get
        Set(ByVal value As Double)
            tSystemLifetime = value / 25
        End Set
    End Property
    Public tLifetime As Value = CreateValue(0.0F, 0.0F) '//Required
    Public Property Lifetime() As Value
        Get
            Return CreateValue(tLifetime.Min * 25, tLifetime.Max * 25)
        End Get
        Set(ByVal value As Value)
            tLifetime.Min = value.Min / 25
            tLifetime.Max = value.Max / 25
        End Set
    End Property
    Public tSize As Value = CreateValue(1.0F, 1.0F) '//Requird
    Public Property Size() As Value
        Get
            Return tSize
        End Get
        Set(ByVal value As Value)
            tSize.Min = value.Min
            tSize.Max = value.Max
        End Set
    End Property
    Public tBurstDelay As Value = CreateValue(0.04F, 0.04F)
    Public Property BurstDelay() As Value
        Get
            Return CreateValue(tBurstDelay.Min * 25, tBurstDelay.Max * 25)
        End Get
        Set(ByVal value As Value)
            tBurstDelay.Min = value.Min / 25
            tBurstDelay.Max = value.Max / 25
        End Set
    End Property
    Public tBurstCount As Value = CreateValue(0.0F, 0.0F) '//Required
    Public Property BurstCount() As Value
        Get
            Return tBurstCount
        End Get
        Set(ByVal value As Value)
            tBurstCount.Min = value.Min
            tBurstCount.Max = value.Max
        End Set
    End Property
    Public tInitialDelay As Value = CreateValue(0.0F, 0.0F)
    Public Property InitialDelay() As Value
        Get
            Return CreateValue(tInitialDelay.Min * 25, tInitialDelay.Max * 25)
        End Get
        Set(ByVal value As Value)
            tInitialDelay.Min = value.Min / 25
            tInitialDelay.Max = value.Max / 25
        End Set
    End Property
    Public tStartSizeRate As Value = CreateValue(0.0F, 0.0F)
    Public Property StartSizeRate() As Value
        Get
            Return tStartSizeRate
        End Get
        Set(ByVal value As Value)
            tStartSizeRate.Min = value.Min
            tStartSizeRate.Max = value.Max
        End Set
    End Property
    '//==Colors, Alphas==	
    Public tColors() As ColorTime = CreateColor()
    Public Property Colors(ByVal Index As Integer) As ColorTime
        Get
            Return CreateColorTime(tColors(Index).R, tColors(Index).G, tColors(Index).B, tColors(Index).Time * 25)
        End Get
        Set(ByVal value As ColorTime)
            tColors(Index).R = value.R
            tColors(Index).G = value.G
            tColors(Index).B = value.B
            tColors(Index).Time = value.Time / 25
        End Set
    End Property
    Public tAlphas() As AlphaTime = CreateAlpha()
    Public Property Alphas(ByVal Index As Integer) As AlphaTime
        Get
            Return CreateAlphaTime(tAlphas(Index).A1 / 255, tAlphas(Index).A2 / 255, tAlphas(Index).Time * 25)
        End Get
        Set(ByVal value As AlphaTime)
            tAlphas(Index).A1 = value.A1
            tAlphas(Index).A2 = value.A2
            tAlphas(Index).Time = value.Time / 25
        End Set
    End Property
    '//==Update==
    Public tSizeRate As Value = CreateValue(0.0F, 0.0F)
    Public Property SizeRate() As Value
        Get
            Return CreateValue(tSizeRate.Min / 40, tSizeRate.Max / 40)
        End Get
        Set(ByVal value As Value)
            tSizeRate.Min = value.Min * 40
            tSizeRate.Max = value.Max * 40
        End Set
    End Property
    Public tSizeRateDamping As Value = CreateValue(1.0F, 1.0F)
    Public Property SizeRateDamping() As Value
        Get
            Return tSizeRateDamping
        End Get
        Set(ByVal value As Value)
            tSizeRateDamping.Min = value.Min
            tSizeRateDamping.Max = value.Max
        End Set
    End Property
    Public tAngleZ As Value = CreateValue(0.0F, 0.0F)
    Public Property AngleZ() As Value
        Get
            Return tAngleZ
        End Get
        Set(ByVal value As Value)
            tAngleZ.Min = value.Min
            tAngleZ.Max = value.Max
        End Set
    End Property
    Public tAngularDamping As Value = CreateValue(1.0F, 1.0F)
    Public Property AngularDamping() As Value
        Get
            Return tAngularDamping
        End Get
        Set(ByVal value As Value)
            tAngularDamping.Min = value.Min
            tAngularDamping.Max = value.Max
        End Set
    End Property
    Public tAngularRateZ As Value = CreateValue(0.0F, 0.0F)
    Public Property AngularRateZ() As Value
        Get
            Return CreateValue(tAngularRateZ.Min / 40, tAngularRateZ.Max / 40)
        End Get
        Set(ByVal value As Value)
            tAngularRateZ.Min = value.Min * 40
            tAngularRateZ.Max = value.Max * 40
        End Set
    End Property
    '//==Physics==
    Public tVelocityDamping As Value = CreateValue(1.0F, 1.0F)
    Public Property VelocityDamping() As Value
        Get
            Return tVelocityDamping
        End Get
        Set(ByVal value As Value)
            tVelocityDamping.Min = value.Min
            tVelocityDamping.Max = value.Max
        End Set
    End Property
    Public tGravity As Value = CreateValue(0.0F, 0.0F)
    Public Property Gravity() As Value
        Get
            Return CreateValue(tGravity.Min / 400, tGravity.Max / 400)
        End Get
        Set(ByVal value As Value)
            tGravity.Min = value.Min * 400
            tGravity.Max = value.Max * 400
        End Set
    End Property
    Public tDriftVelocity As Vector3
    Public Property DriftVelocity() As Vector3
        Get
            Return tDriftVelocity * (1 / 40)
        End Get
        Set(ByVal value As Vector3)
            tDriftVelocity = value * 40
        End Set
    End Property
    '//==EmissionVelocity==
    '//====OutwardEmissionVelocity
    Public tSpeed As Value = CreateValue(0.0F, 0.0F)
    Public Property Speed() As Value
        Get
            Return CreateValue(tSpeed.Min / 40, tSpeed.Max / 40)
        End Get
        Set(ByVal value As Value)
            tSpeed.Min = value.Min * 40
            tSpeed.Max = value.Max * 40
        End Set
    End Property
    Public tOtherSpeed As Value = CreateValue(0.0F, 0.0F)
    Public Property OtherSpeed() As Value
        Get
            Return CreateValue(tOtherSpeed.Min / 40, tOtherSpeed.Max / 40)
        End Get
        Set(ByVal value As Value)
            tOtherSpeed.Min = value.Min * 40
            tOtherSpeed.Max = value.Max * 40
        End Set
    End Property
    '//====OrthoEmissionVelocity
    Public tX As Value = CreateValue(0.0F, 0.0F)
    Public Property X() As Value
        Get
            Return CreateValue(tX.Min / 40, tX.Max / 40)
        End Get
        Set(ByVal value As Value)
            tX.Min = value.Min * 40
            tX.Max = value.Max * 40
        End Set
    End Property
    Public tY As Value = CreateValue(0.0F, 0.0F)
    Public Property Y() As Value
        Get
            Return CreateValue(tY.Min / 40, tY.Max / 40)
        End Get
        Set(ByVal value As Value)
            tY.Min = value.Min * 40
            tY.Max = value.Max * 40
        End Set
    End Property
    Public tZ As Value = CreateValue(0.0F, 0.0F)
    Public Property Z() As Value
        Get
            Return CreateValue(tZ.Min / 40, tZ.Max / 40)
        End Get
        Set(ByVal value As Value)
            tZ.Min = value.Min * 40
            tZ.Max = value.Max * 40
        End Set
    End Property
    '//====CylindricalEmissionVelocity
    Public tRadial As Value = CreateValue(0.0F, 0.0F)
    Public Property Radial() As Value
        Get
            Return CreateValue(tRadial.Min / 40, tRadial.Max / 40)
        End Get
        Set(ByVal value As Value)
            tRadial.Min = value.Min * 40
            tRadial.Max = value.Max * 40
        End Set
    End Property
    Public tNormal As Value = CreateValue(0.0F, 0.0F)
    Public Property Normal() As Value
        Get
            Return CreateValue(tNormal.Min / 40, tNormal.Max / 40)
        End Get
        Set(ByVal value As Value)
            tNormal.Min = value.Min * 40
            tNormal.Max = value.Max * 40
        End Set
    End Property
    '//==EmissionVolume==
    Public tIsHollow As Boolean = False
    Public Property IsHollow() As Boolean
        Get
            Return tIsHollow
        End Get
        Set(ByVal value As Boolean)
            tIsHollow = value
        End Set
    End Property
    Public tRadius As Double = 0.0F
    Public Property Radius() As Double
        Get
            Return tRadius
        End Get
        Set(ByVal value As Double)
            tRadius = value
        End Set
    End Property
    '//====CylinderEmissionVolume
    Public tOffset As Vector3
    Public Property Offset() As Vector3
        Get
            Return tOffset
        End Get
        Set(ByVal value As Vector3)
            tOffset = value
        End Set
    End Property
    Public tLength As Double
    Public Property Length() As Double
        Get
            Return tLength
        End Get
        Set(ByVal value As Double)
            tLength = value
        End Set
    End Property
    Public tRadiusRate As Value
    Public Property RadiusRate() As Value
        Get
            Return tRadiusRate
        End Get
        Set(ByVal value As Value)
            tRadiusRate.Min = value.Min
            tRadiusRate.Max = value.Max
        End Set
    End Property
    '//====LineEmissionVolume
    Public tStartPoint, tEndPoint As Vector3
    Public Property StartPoint() As Vector3
        Get
            Return tStartPoint
        End Get
        Set(ByVal value As Vector3)
            tStartPoint = value
        End Set
    End Property
    Public Property EndPoint() As Vector3
        Get
            Return tEndPoint
        End Get
        Set(ByVal value As Vector3)
            tEndPoint = value
        End Set
    End Property
    '//Line Distance
    Public ReadOnly Property LineDistance() As Double
        Get
            Return Vector3.Length(EndPoint - StartPoint)
        End Get
    End Property
    '//====SphereEmissionVolume
    '//====BoxEmissionVolume
    Public tHalfSize As Vector3
    Public Property HalfSize() As Vector3
        Get
            Return tHalfSize
        End Get
        Set(ByVal value As Vector3)
            tHalfSize = value
        End Set
    End Property
    '//Emitter
    Public tEmissionVolume As EmissionVolumeType = EmissionVolumeType.PointEmissionVolume
    Public Property EmissionVolume() As EmissionVolumeType
        Get
            Return tEmissionVolume
        End Get
        Set(ByVal value As EmissionVolumeType)
            tEmissionVolume = value
        End Set
    End Property
    Public tEmissionVelocity As EmissionVelocityType = EmissionVelocityType.OrthoEmissionVelocity
    Public Property EmissionVelocity() As EmissionVelocityType
        Get
            Return tEmissionVelocity
        End Get
        Set(ByVal value As EmissionVelocityType)
            tEmissionVelocity = value
        End Set
    End Property
    '//Location
    Public tLocation As Vector3
    Public Property Location() As Vector3
        Get
            Return tLocation
        End Get
        Set(ByVal value As Vector3)
            tLocation = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Function Random(ByVal V As Value) As Double
        Return Scene.RandS(V.Min, V.Max)
    End Function

    Public Sub Open(ByVal FilePath As String, ByVal ParticleSystemName As String)
        If IO.File.Exists(FilePath) Then
            Dim Reader As New INIReader
            Reader.Open(FilePath)
            Do While Reader.Read
                If Reader.Name.ToLower = "fxparticlesystem" Then
                    If Reader.GetAttribute(1).ToLower = ParticleSystemName.ToLower Then
                        SetDefaults()
                        Do Until Reader.EndFound
                            If Reader.Name = "System" Then
                                Do Until Reader.EndFound
                                    If Reader.Name = "Priority" Then Priority = PriorityFromReader(Reader)
                                    If Reader.Name = "Lifetime" Then Lifetime = ValueFromReader(Reader)
                                    If Reader.Name = "ParticleName" Then ParticleName = Media.GetFileName(Reader.GetAttribute(1))
                                    If Reader.Name = "BurstDelay" Then BurstDelay = ValueFromReader(Reader)
                                    If Reader.Name = "BurstCount" Then BurstCount = ValueFromReader(Reader)
                                    If Reader.Name = "Size" Then Size = ValueFromReader(Reader)
                                    If Reader.Name = "SortLevel" Then SortLevel = Reader.GetAttribute(1)
                                    If Reader.Name = "SystemLifetime" Then SystemLifetime = Reader.GetAttribute(1)
                                    If Reader.Name = "InitialDelay" Then InitialDelay = ValueFromReader(Reader)
                                    If Reader.Name = "IsOneShot" Then IsOneShot = BooleanFromReader(Reader)
                                    If Reader.Name = "IsGroundAligned" Then IsGroundAligned = BooleanFromReader(Reader)
                                Loop
                            End If
                            If Reader.Name = "Color" Then
                                Do Until Reader.EndFound
                                    If Reader.Name.StartsWith("Color") And Reader.Name <> "ColorScale" Then
                                        Dim Index As Integer = CInt(Reader.Name.Substring(5, 1)) - 1
                                        If Index >= 0 And Index <= 7 Then
                                            Colors(Index) = ColorTimeFromReader(Reader)
                                        End If
                                    End If
                                Loop
                            End If
                            If Reader.Name = "Alpha" Then
                                Do Until Reader.EndFound
                                    If Reader.Name.StartsWith("Alpha") Then
                                        Dim Index As Integer = CInt(Reader.Name.Substring(5, 1)) - 1
                                        If Index >= 0 And Index <= 7 Then
                                            Alphas(Index) = AlphaTimeFromReader(Reader)
                                        End If
                                    End If
                                Loop
                            End If
                            If Reader.Name = "Update" Then
                                Do Until Reader.EndFound
                                    If Reader.Name = "SizeRate" Then SizeRate = ValueFromReader(Reader)
                                    If Reader.Name = "SizeRateDamping" Then SizeRateDamping = ValueFromReader(Reader)
                                    If Reader.Name = "AngleZ" Then AngleZ = ValueFromReader(Reader)
                                    If Reader.Name = "AngularRateZ" Then AngularRateZ = ValueFromReader(Reader)
                                    If Reader.Name = "AngularDamping" Then AngularDamping = ValueFromReader(Reader)
                                Loop
                            End If
                            If Reader.Name = "Physics" Then
                                Do Until Reader.EndFound
                                    If Reader.Name = "Gravity" Then Gravity = ValueFromReader(Reader)
                                    If Reader.Name = "VelocityDamping" Then VelocityDamping = ValueFromReader(Reader)
                                    If Reader.Name = "DriftVelocity" Then DriftVelocity = VectorFromReader(Reader)
                                Loop
                            End If
                            If Reader.Name = "EmissionVolume" Then
                                EmissionVolume = VolumeFromReader(Reader)
                                Do Until Reader.EndFound
                                    If Reader.Name = "EndPoint" Then EndPoint = VectorFromReader(Reader)
                                    If Reader.Name = "StartPoint" Then StartPoint = VectorFromReader(Reader)
                                    If Reader.Name = "Radius" Then Radius = Reader.GetAttribute(1)
                                    If Reader.Name = "Length" Then Length = Reader.GetAttribute(1)
                                    If Reader.Name = "Offset" Then Offset = VectorFromReader(Reader)
                                    If Reader.Name = "IsHollow" Then IsHollow = BooleanFromReader(Reader)
                                    If Reader.Name = "Halfsize" Then HalfSize = VectorFromReader(Reader)
                                Loop
                            End If
                            If Reader.Name = "EmissionVelocity" Then
                                EmissionVelocity = VelocityFromReader(Reader)
                                Do Until Reader.EndFound
                                    If Reader.Name = "X" Then X = ValueFromReader(Reader)
                                    If Reader.Name = "Y" Then Y = ValueFromReader(Reader)
                                    If Reader.Name = "Z" Then Z = ValueFromReader(Reader)
                                    If Reader.Name = "Speed" Then Speed = ValueFromReader(Reader)
                                    If Reader.Name = "Normal" Then Normal = ValueFromReader(Reader)
                                    If Reader.Name = "Radial" Then Radial = ValueFromReader(Reader)
                                Loop
                            End If
                        Loop
                    End If
                End If
            Loop
        Else
            GameError.Raise(GameError.ErrorType.FileDoesntExist, GameError.ErrorSeverity.Notice, GetType(ParticleSystemInfo), "The file " & FilePath & " doesnt exist!")
        End If
    End Sub
    Public Sub Save(ByVal FilePath As String)
        Dim Writer As IO.StreamWriter
        If IO.File.Exists(FilePath) Then
            Writer = IO.File.AppendText(FilePath)
        Else
            Writer = IO.File.CreateText(FilePath)
        End If
        With Writer
            .WriteLine("FXParticleSystem " & ParticleSystemName)
            '//System
            .WriteLine(vbTab & "System")
            .WriteLine(vbTab & vbTab & "Priority = " & Priority.ToString)
            .WriteLine(vbTab & vbTab & "Shader = " & Shader.ToString)
            .WriteLine(vbTab & vbTab & "ParticleName = " & ParticleName)
            .WriteLine(vbTab & vbTab & "SystemLifetime = " & SystemLifetime)
            .WriteLine(vbTab & vbTab & "InitialDelay = " & InitialDelay.Min & " " & InitialDelay.Max)
            If SortLevel <> 0 Then
                .WriteLine(vbTab & vbTab & "SortLevel = " & SortLevel)
            End If
            .WriteLine(vbTab & vbTab & "Lifetime = " & Lifetime.Min & " " & Lifetime.Max)
            .WriteLine(vbTab & vbTab & "Size = " & Size.Min & " " & Size.Max)
            .WriteLine(vbTab & vbTab & "BurstCount = " & BurstCount.Min & " " & BurstCount.Max)
            .WriteLine(vbTab & vbTab & "BurstDelay = " & BurstDelay.Min & " " & BurstDelay.Max)
            If IsOneShot Then
                .WriteLine(vbTab & vbTab & "IsOneShot = Yes")
            End If
            If IsGroundAligned Then
                .WriteLine(vbTab & vbTab & "IsGroundAligned = Yes")
            End If
            .WriteLine(vbTab & "End")
            '//Color
            .WriteLine(vbTab & "Color = DefaultColor")
            For I As Integer = 0 To 7
                If I = 0 Then
                    .WriteLine(vbTab & vbTab & "Color1 = R:" & Colors(I).R & " G:" & Colors(I).G & " B:" & Colors(I).B & " " & Colors(I).Time)
                Else
                    If Colors(I).Time <> 0.0F Then
                        .WriteLine(vbTab & vbTab & "Color" & (I + 1) & " = R:" & Colors(I).R & " G:" & Colors(I).G & " B:" & Colors(I).B & " " & Colors(I).Time)
                    End If
                End If
            Next
            .WriteLine(vbTab & "End")
            '//Alpha
            .WriteLine(vbTab & "Alpha = DefaultAlpha")
            For I As Integer = 0 To 7
                If I = 0 Then
                    .WriteLine(vbTab & vbTab & "Alpha1 = " & Alphas(I).A1 & " " & Alphas(I).A2 & " " & Alphas(I).Time)
                Else
                    If Alphas(I).Time <> 0.0F Then
                        .WriteLine(vbTab & vbTab & "Alpha" & (I + 1) & " = " & Alphas(I).A1 & " " & Alphas(I).A2 & " " & Alphas(I).Time)
                    End If
                End If
            Next
            .WriteLine(vbTab & "End")
            '//Update
            .WriteLine(vbTab & "Update = DefaultUpdate")
            .WriteLine(vbTab & vbTab & "SizeRate = " & SizeRate.Min & " " & SizeRate.Max)
            .WriteLine(vbTab & vbTab & "SizeRateDamping = " & SizeRateDamping.Min & " " & SizeRateDamping.Max)
            .WriteLine(vbTab & vbTab & "AngleZ = " & AngleZ.Min & " " & AngleZ.Max)
            .WriteLine(vbTab & vbTab & "AngularRateZ = " & AngularRateZ.Min & " " & AngularRateZ.Max)
            .WriteLine(vbTab & vbTab & "AngularDamping = " & AngularDamping.Min & " " & AngularDamping.Max)
            .WriteLine(vbTab & "End")
            '//Physics
            .WriteLine(vbTab & "Physics = DefaultPhysics")
            .WriteLine(vbTab & vbTab & "VelocityDamping = " & VelocityDamping.Min & " " & VelocityDamping.Max)
            .WriteLine(vbTab & vbTab & "Gravity = " & Gravity.Min & " " & Gravity.Max)
            .WriteLine(vbTab & vbTab & "DriftVelocity = X:" & DriftVelocity.X & " Y:" & DriftVelocity.Y & " Z:" & DriftVelocity.Z)
            .WriteLine(vbTab & "End")
            '//EmissionVelocity
            .WriteLine(vbTab & "EmissionVelocity = " & EmissionVelocity.ToString)
            Select Case EmissionVelocity
                Case EmissionVelocityType.CylindricalEmissionVelocity
                    .WriteLine(vbTab & vbTab & "Radial = " & Radial.Min & " " & Radial.Max)
                    .WriteLine(vbTab & vbTab & "Normal = " & Normal.Min & " " & Normal.Max)
                Case EmissionVelocityType.OrthoEmissionVelocity
                    .WriteLine(vbTab & vbTab & "X = " & X.Min & " " & X.Max)
                    .WriteLine(vbTab & vbTab & "Y = " & Y.Min & " " & Z.Max)
                    .WriteLine(vbTab & vbTab & "Z = " & Z.Min & " " & Y.Max)
                Case EmissionVelocityType.OutwardEmissionVelocity
                    .WriteLine(vbTab & vbTab & "Speed = " & Speed.Min & " " & Speed.Max)
            End Select
            .WriteLine(vbTab & "End")
            '//EmissionVolume
            .WriteLine(vbTab & "EmissionVolume = " & EmissionVolume.ToString)
            If IsHollow Then
                .WriteLine(vbTab & vbTab & "IsHollow = Yes")
            End If
            Select Case EmissionVolume
                Case EmissionVolumeType.BoxEmissionVolume
                    .WriteLine(vbTab & vbTab & "HalfSize = X:" & HalfSize.X & " Y:" & HalfSize.Y & " Z:" & HalfSize.Z)
                Case EmissionVolumeType.CylinderEmissionVolume
                    .WriteLine(vbTab & vbTab & "Offset = X:" & Offset.X & " Y:" & Offset.Y & " Z:" & Offset.Z)
                    .WriteLine(vbTab & vbTab & "Radius = " & Radius)
                    .WriteLine(vbTab & vbTab & "Length = " & Length)
                Case EmissionVolumeType.LineEmissionVolume
                    .WriteLine(vbTab & vbTab & "StartPoint = X:" & StartPoint.X & " Y:" & StartPoint.Y & " Z:" & StartPoint.Z)
                    .WriteLine(vbTab & vbTab & "EndPoint = X:" & EndPoint.X & " Y:" & EndPoint.Y & " Z:" & EndPoint.Z)
                Case EmissionVolumeType.PointEmissionVolume
                Case EmissionVolumeType.SphereEmissionVolume
                    .WriteLine(vbTab & vbTab & "Radius = " & Radius)
            End Select
            .WriteLine(vbTab & "End")
            '//Draw
            .WriteLine(vbTab & "Draw = DefaultDraw")
            .WriteLine(vbTab & "End")
            .WriteLine(vbTab & "Wind = DefaultWind")
            .WriteLine(vbTab & "End")
            .WriteLine("End")
        End With
        Writer.Flush()
        Writer.Close()
        Writer.Dispose()
        Writer = Nothing
    End Sub
    Public Sub Import(ByVal FilePath As String)
        Dim Reader As New Xml.XmlTextReader(FilePath)
        SetDefaults()
        Do While Reader.Read
            Select Case Reader.Name
                Case "FXParticleSystem"
                    ParticleSystemName = Reader.GetAttribute("Name")
                Case "System"
                    Priority = Reader.GetAttribute("Priority")
                    Shader = Reader.GetAttribute("Shader")
                    ParticleName = Reader.GetAttribute("ParticleName")
                    SystemLifetime = Reader.GetAttribute("SystemLifetime")
                    SortLevel = Reader.GetAttribute("SortLevel")
                    InitialDelay = CreateValue(Reader.GetAttribute("InitialDelayMin"), Reader.GetAttribute("InitialDelayMax"))
                    Lifetime = CreateValue(Reader.GetAttribute("LifetimeMin"), Reader.GetAttribute("LifetimeMax"))
                    Size = CreateValue(Reader.GetAttribute("SizeMin"), Reader.GetAttribute("SizeMax"))
                    BurstCount = CreateValue(Reader.GetAttribute("BurstCountMin"), Reader.GetAttribute("BurstCountMax"))
                    BurstDelay = CreateValue(Reader.GetAttribute("BurstDelayMin"), Reader.GetAttribute("BurstDelayMax"))
                    IsOneShot = Reader.GetAttribute("IsOneShot")
                    IsGroundAligned = Reader.GetAttribute("IsGroundAligned")
                Case "Colors"
                    For I As Integer = 0 To 7
                        Colors(I) = CreateColorTime( _
                            Reader.GetAttribute("Color" & (I + 1) & "R"), _
                            Reader.GetAttribute("Color" & (I + 1) & "G"), _
                            Reader.GetAttribute("Color" & (I + 1) & "B"), _
                            Reader.GetAttribute("Color" & (I + 1) & "Time"))
                    Next
                Case "Alphas"
                    For I As Integer = 0 To 7
                        Alphas(I) = CreateAlphaTime( _
                            Reader.GetAttribute("Alpha" & (I + 1) & "Min") * 255, _
                            Reader.GetAttribute("Alpha" & (I + 1) & "Max") * 255, _
                            Reader.GetAttribute("Alpha" & (I + 1) & "Time"))
                    Next
                Case "Update"
                    SizeRate = CreateValue(Reader.GetAttribute("SizeRateMin"), Reader.GetAttribute("SizeRateMax"))
                    SizeRateDamping = CreateValue(Reader.GetAttribute("SizeRateDampingMin"), Reader.GetAttribute("SizeRateDampingMax"))
                    AngleZ = CreateValue(Reader.GetAttribute("AngleZMin"), Reader.GetAttribute("AngleZMax"))
                    AngularRateZ = CreateValue(Reader.GetAttribute("AngularRateZMin"), Reader.GetAttribute("AngularRateZMax"))
                    AngularDamping = CreateValue(Reader.GetAttribute("AngularDampingMin"), Reader.GetAttribute("AngularDampingMax"))
                Case "Physics"
                    VelocityDamping = CreateValue(Reader.GetAttribute("VelocityDampingMin"), Reader.GetAttribute("VelocityDampingMax"))
                    Gravity = CreateValue(Reader.GetAttribute("GravityMin"), Reader.GetAttribute("GravityMax"))
                    DriftVelocity = New Vector3( _
                        Reader.GetAttribute("DriftVelocityX"), _
                        Reader.GetAttribute("DriftVelocityY"), _
                        Reader.GetAttribute("DriftVelocityZ"))
                Case "EmissionVelocity"
                    EmissionVelocity = Reader.GetAttribute("Type")
                    Radial = CreateValue(Reader.GetAttribute("RadialMin"), Reader.GetAttribute("RadialMax"))
                    Normal = CreateValue(Reader.GetAttribute("NormalMin"), Reader.GetAttribute("NormalMax"))
                    X = CreateValue(Reader.GetAttribute("XMin"), Reader.GetAttribute("XMax"))
                    Y = CreateValue(Reader.GetAttribute("YMin"), Reader.GetAttribute("YMax"))
                    Z = CreateValue(Reader.GetAttribute("ZMin"), Reader.GetAttribute("ZMax"))
                    Speed = CreateValue(Reader.GetAttribute("SpeedMin"), Reader.GetAttribute("SpeedMax"))
                Case "EmissionVolume"
                    EmissionVolume = Reader.GetAttribute("Type")
                    IsHollow = Reader.GetAttribute("IsHollow")
                    HalfSize = New Vector3( _
                        Reader.GetAttribute("HalfSizeX"), _
                        Reader.GetAttribute("HalfSizeY"), _
                        Reader.GetAttribute("HalfSizeZ"))
                    Offset = New Vector3( _
                        Reader.GetAttribute("OffsetX"), _
                        Reader.GetAttribute("OffsetY"), _
                        Reader.GetAttribute("OffsetZ"))
                    Radius = Reader.GetAttribute("Radius")
                    Length = Reader.GetAttribute("Length")
                    StartPoint = New Vector3( _
                        Reader.GetAttribute("StartPointX"), _
                        Reader.GetAttribute("StartPointY"), _
                        Reader.GetAttribute("StartPointZ"))
                    EndPoint = New Vector3( _
                        Reader.GetAttribute("EndPointX"), _
                        Reader.GetAttribute("EndPointY"), _
                        Reader.GetAttribute("EndPointZ"))
            End Select
        Loop
        Reader.Close()
        Reader = Nothing
    End Sub
    Public Sub Export(ByVal FilePath As String)
        Dim Writer As New Xml.XmlTextWriter(FilePath, System.Text.Encoding.UTF8)
        Writer.Formatting = Xml.Formatting.Indented
        Writer.WriteComment("ParticleSystem in XML Format")
        Writer.WriteStartElement("FXParticleSystem")
        Writer.WriteAttributeString("Name", IIf(ParticleSystemName = "", "NewParticleSystem", ParticleSystemName))
        '//System
        Writer.WriteStartElement("System")
        Writer.WriteAttributeString("Priority", CInt(Priority))
        Writer.WriteAttributeString("Shader", CInt(Shader))
        Writer.WriteAttributeString("ParticleName", ParticleName)
        Writer.WriteAttributeString("SystemLifetime", SystemLifetime)
        Writer.WriteAttributeString("SortLevel", SortLevel)
        Writer.WriteAttributeString("InitialDelayMin", InitialDelay.Min)
        Writer.WriteAttributeString("InitialDelayMax", InitialDelay.Max)
        Writer.WriteAttributeString("LifetimeMin", Lifetime.Min)
        Writer.WriteAttributeString("LifetimeMax", Lifetime.Max)
        Writer.WriteAttributeString("SizeMin", Size.Min)
        Writer.WriteAttributeString("SizeMax", Size.Max)
        Writer.WriteAttributeString("BurstCountMin", BurstCount.Min)
        Writer.WriteAttributeString("BurstCountMax", BurstCount.Max)
        Writer.WriteAttributeString("BurstDelayMin", BurstDelay.Min)
        Writer.WriteAttributeString("BurstDelayMax", BurstDelay.Max)
        Writer.WriteAttributeString("IsOneShot", CInt(IsOneShot))
        Writer.WriteAttributeString("IsGroundAligned", CInt(IsGroundAligned))
        Writer.WriteEndElement()
        '//Colors
        Writer.WriteStartElement("Colors")
        For I As Integer = 0 To 7
            Writer.WriteAttributeString("Color" & (I + 1) & "R", Colors(I).R)
            Writer.WriteAttributeString("Color" & (I + 1) & "G", Colors(I).G)
            Writer.WriteAttributeString("Color" & (I + 1) & "B", Colors(I).B)
            Writer.WriteAttributeString("Color" & (I + 1) & "Time", Colors(I).Time)
        Next
        Writer.WriteEndElement()
        '//Alphas
        Writer.WriteStartElement("Alphas")
        For I As Integer = 0 To 7
            Writer.WriteAttributeString("Alpha" & (I + 1) & "Min", Alphas(I).A1)
            Writer.WriteAttributeString("Alpha" & (I + 1) & "Max", Alphas(I).A2)
            Writer.WriteAttributeString("Alpha" & (I + 1) & "Time", Alphas(I).Time)
        Next
        Writer.WriteEndElement()
        '//Update
        Writer.WriteStartElement("Update")
        Writer.WriteAttributeString("SizeRateMin", SizeRate.Min)
        Writer.WriteAttributeString("SizeRateMax", SizeRate.Max)
        Writer.WriteAttributeString("SizeRateDampingMin", SizeRateDamping.Min)
        Writer.WriteAttributeString("SizeRateDampingMax", SizeRateDamping.Max)
        Writer.WriteAttributeString("AngleZMin", AngleZ.Min)
        Writer.WriteAttributeString("AngleZMax", AngleZ.Max)
        Writer.WriteAttributeString("AngularRateZMin", AngularRateZ.Min)
        Writer.WriteAttributeString("AngularRateZMax", AngularRateZ.Max)
        Writer.WriteAttributeString("AngularDampingMin", AngularDamping.Min)
        Writer.WriteAttributeString("AngularDampingMax", AngularDamping.Max)
        Writer.WriteEndElement()
        '//Physics
        Writer.WriteStartElement("Physics")
        Writer.WriteAttributeString("VelocityDampingMin", VelocityDamping.Min)
        Writer.WriteAttributeString("VelocityDampingMax", VelocityDamping.Max)
        Writer.WriteAttributeString("GravityMin", Gravity.Min)
        Writer.WriteAttributeString("GravityMax", Gravity.Max)
        Writer.WriteAttributeString("DriftVelocityX", DriftVelocity.X)
        Writer.WriteAttributeString("DriftVelocityY", DriftVelocity.Y)
        Writer.WriteAttributeString("DriftVelocityZ", DriftVelocity.Z)
        Writer.WriteEndElement()
        '//Velocity
        Writer.WriteStartElement("EmissionVelocity")
        Writer.WriteAttributeString("Type", CInt(EmissionVelocity))
        Writer.WriteAttributeString("RadialMin", Radial.Min)
        Writer.WriteAttributeString("RadialMax", Radial.Max)
        Writer.WriteAttributeString("NormalMin", Normal.Min)
        Writer.WriteAttributeString("NormalMax", Normal.Max)
        Writer.WriteAttributeString("XMin", X.Min)
        Writer.WriteAttributeString("XMax", X.Max)
        Writer.WriteAttributeString("YMin", Y.Min)
        Writer.WriteAttributeString("YMax", Y.Max)
        Writer.WriteAttributeString("ZMin", Z.Min)
        Writer.WriteAttributeString("ZMax", Z.Max)
        Writer.WriteAttributeString("SpeedMin", Speed.Min)
        Writer.WriteAttributeString("SpeedMax", Speed.Max)
        Writer.WriteEndElement()
        '//Volume
        Writer.WriteStartElement("EmissionVolume")
        Writer.WriteAttributeString("Type", CInt(EmissionVolume))
        Writer.WriteAttributeString("IsHollow", CInt(IsHollow))
        Writer.WriteAttributeString("HalfSizeX", HalfSize.X)
        Writer.WriteAttributeString("HalfSizeY", HalfSize.Y)
        Writer.WriteAttributeString("HalfSizeZ", HalfSize.Z)
        Writer.WriteAttributeString("OffsetX", Offset.X)
        Writer.WriteAttributeString("OffsetY", Offset.Y)
        Writer.WriteAttributeString("OffsetZ", Offset.Z)
        Writer.WriteAttributeString("Radius", Radius)
        Writer.WriteAttributeString("Length", Length)
        Writer.WriteAttributeString("StartPointX", StartPoint.X)
        Writer.WriteAttributeString("StartPointY", StartPoint.Y)
        Writer.WriteAttributeString("StartPointZ", StartPoint.Z)
        Writer.WriteAttributeString("EndPointX", EndPoint.X)
        Writer.WriteAttributeString("EndPointY", EndPoint.Y)
        Writer.WriteAttributeString("EndPointZ", EndPoint.Z)
        Writer.WriteEndElement()
        '//End
        Writer.WriteEndElement()
        Writer.Flush()
        Writer.Close()
        Writer = Nothing
    End Sub

    Private Sub SetDefaults()
        tParticleSystemName = ""
        tPriority = Priorities.ALWAYS_RENDER
        tShader = Shaders.ALPHA
        tParticleName = ""
        tIsOneShot = False
        tIsGroundAligned = False
        tSortLevel = 0
        tSystemLifetime = 0.0F
        tLifetime = CreateValue(0.0F, 0.0F)
        tSize = CreateValue(1.0F, 1.0F)
        tBurstDelay = CreateValue(0.04F, 0.04F)
        tBurstCount = CreateValue(0.0F, 0.0F)
        tInitialDelay = CreateValue(0.0F, 0.0F)
        tStartSizeRate = CreateValue(0.0F, 0.0F)
        tColors = CreateColor()
        tAlphas = CreateAlpha()
        tSizeRate = CreateValue(0.0F, 0.0F)
        tSizeRateDamping = CreateValue(1.0F, 1.0F)
        tAngleZ = CreateValue(0.0F, 0.0F)
        tAngularDamping = CreateValue(1.0F, 1.0F)
        tAngularRateZ = CreateValue(0.0F, 0.0F)
        tVelocityDamping = CreateValue(1.0F, 1.0F)
        tGravity = CreateValue(0.0F, 0.0F)
        tDriftVelocity = New Vector3
        tSpeed = CreateValue(0.0F, 0.0F)
        tOtherSpeed = CreateValue(0.0F, 0.0F)
        tX = CreateValue(0.0F, 0.0F)
        tY = CreateValue(0.0F, 0.0F)
        tZ = CreateValue(0.0F, 0.0F)
        tRadial = CreateValue(0.0F, 0.0F)
        tNormal = CreateValue(0.0F, 0.0F)
        tIsHollow = False
        tRadius = 0.0F
        tOffset = New Vector3
        tLength = 0
        tRadiusRate = CreateValue(0, 0)
        tStartPoint = New Vector3
        tEndPoint = New Vector3
        tHalfSize = New Vector3
        tEmissionVolume = EmissionVolumeType.PointEmissionVolume
        tEmissionVelocity = EmissionVelocityType.OrthoEmissionVelocity
        tLocation = New Vector3
    End Sub

    Public Shared Function CreateValue(ByVal Min As Double, ByVal Max As Double) As Value
        Dim V As New Value
        V.Min = Min
        V.Max = Max
        Return V
    End Function
    Public Shared Function CreateColor() As ColorTime()
        Dim Cls(7) As ColorTime
        Cls(0).R = 255
        Cls(0).G = 255
        Cls(0).B = 255
        Cls(0).Time = 0
        Return Cls
    End Function
    Public Shared Function CreateAlpha() As AlphaTime()
        Dim Als(7) As AlphaTime
        Als(0).A1 = 1
        Als(0).A2 = 1
        Als(0).Time = 0
        Return Als
    End Function
    Public Shared Function CreateColorTime(ByVal R As Double, ByVal G As Double, ByVal B As Double, ByVal Time As Double) As ColorTime
        Dim C As ColorTime
        C.R = R
        C.G = G
        C.B = B
        C.Time = Time
        Return C
    End Function
    Public Shared Function CreateAlphaTime(ByVal A1 As Double, ByVal A2 As Double, ByVal Time As Double) As AlphaTime
        Dim A As AlphaTime
        A.A1 = A1
        A.A2 = A2
        A.Time = Time
        Return A
    End Function
    Private Shared Function ValueFromReader(ByVal Reader As INIReader) As Value
        Dim V As Value
        V.Min = Reader.GetAttribute(1)
        V.Max = Reader.GetAttribute(2)
        Return V
    End Function
    Private Shared Function BooleanFromReader(ByVal Reader As INIReader) As Boolean
        Select Case Reader.GetAttribute(1).ToLower
            Case "yes" : Return True
            Case "no" : Return False
        End Select
    End Function
    Private Shared Function ColorTimeFromReader(ByVal Reader As INIReader) As ColorTime
        Dim C As ColorTime
        C.R = Reader.GetAttribute("R:")
        C.G = Reader.GetAttribute("G:")
        C.B = Reader.GetAttribute("B:")
        C.Time = Reader.GetAttribute(4)
        Return C
    End Function
    Private Shared Function AlphaTimeFromReader(ByVal Reader As INIReader) As AlphaTime
        Dim A As AlphaTime
        A.A1 = Reader.GetAttribute(1) * 255
        A.A2 = Reader.GetAttribute(2) * 255
        A.Time = Reader.GetAttribute(3)
        Return A
    End Function
    Private Shared Function VolumeFromReader(ByVal Reader As INIReader) As EmissionVolumeType
        Select Case Reader.GetAttribute(1).ToLower
            Case EmissionVolumeType.PointEmissionVolume.ToString.ToLower : Return EmissionVolumeType.PointEmissionVolume
            Case EmissionVolumeType.SphereEmissionVolume.ToString.ToLower : Return EmissionVolumeType.SphereEmissionVolume
            Case EmissionVolumeType.LineEmissionVolume.ToString.ToLower : Return EmissionVolumeType.LineEmissionVolume
            Case EmissionVolumeType.CylinderEmissionVolume.ToString.ToLower : Return EmissionVolumeType.CylinderEmissionVolume
            Case EmissionVolumeType.BoxEmissionVolume.ToString.ToLower : Return EmissionVolumeType.BoxEmissionVolume
        End Select
    End Function
    Private Shared Function VelocityFromReader(ByVal Reader As INIReader) As EmissionVelocityType
        Select Case Reader.GetAttribute(1).ToLower
            Case EmissionVelocityType.OrthoEmissionVelocity.ToString.ToLower : Return EmissionVelocityType.OrthoEmissionVelocity
            Case EmissionVelocityType.OutwardEmissionVelocity.ToString.ToLower : Return EmissionVelocityType.OutwardEmissionVelocity
            Case EmissionVelocityType.CylindricalEmissionVelocity.ToString.ToLower : Return EmissionVelocityType.CylindricalEmissionVelocity
        End Select
    End Function
    Private Shared Function PriorityFromReader(ByVal Reader As INIReader) As Priorities
        Select Case Reader.GetAttribute(1)
            Case Priorities.ALWAYS_RENDER.ToString : Return Priorities.ALWAYS_RENDER
            Case Priorities.AREA_EFFECT.ToString : Return Priorities.AREA_EFFECT
            Case Priorities.BUILDUP.ToString : Return Priorities.BUILDUP
            Case Priorities.CONSTANT.ToString : Return Priorities.CONSTANT
            Case Priorities.CRITICAL.ToString : Return Priorities.CRITICAL
            Case Priorities.DEATH_EXPLOSION.ToString : Return Priorities.DEATH_EXPLOSION
            Case Priorities.DEBRIS_TRAIL.ToString : Return Priorities.DEBRIS_TRAIL
            Case Priorities.DUST_TRAIL.ToString : Return Priorities.DUST_TRAIL
            Case Priorities.SCORCH_MARK.ToString : Return Priorities.SCORCH_MARK
            Case Priorities.SEMI_CONSTANT.ToString : Return Priorities.SEMI_CONSTANT
            Case Priorities.UNIT_DAMAGE_FX.ToString : Return Priorities.UNIT_DAMAGE_FX
            Case Priorities.WEAPON_EXPLOSION.ToString : Return Priorities.WEAPON_EXPLOSION
            Case Priorities.WEAPON_TRAIL.ToString : Return Priorities.WEAPON_TRAIL
        End Select
    End Function
    Private Shared Function ShaderFromReader(ByVal Reader As INIReader) As Shaders
        Select Case Reader.GetAttribute(1).ToLower
            Case Shaders.ADDITIVE.ToString.ToLower : Return Shaders.ADDITIVE
            Case Shaders.ALPHA.ToString.ToLower : Return Shaders.ALPHA
        End Select
    End Function
    Private Shared Function VectorFromReader(ByVal Reader As INIReader) As Vector3
        Return New Vector3(Reader.GetAttribute("X:"), Reader.GetAttribute("Y:"), Reader.GetAttribute("Z:"))
    End Function
End Class
'//ParticleQuad
Public Class Quad
    Public Shared V(3) As CustomVertex.PositionColoredTextured
    Public Shared Sub SetVertices(ByVal Location As Vector3, ByVal Rotation As Double, ByVal Size As Double, ByVal Shade As Integer, ByVal GroundAligned As Boolean)
        If GroundAligned Then
            Dim vUp As New Vector3(Size * 0.5, 0, 0)
            Dim vRight As New Vector3(0, Size * 0.5, 0)
            If Rotation <> 0.0F Then
                Dim CosT As Double = Math.Cos(Rotation * Math.PI / 180)
                Dim SinT As Double = Math.Sin(Rotation * Math.PI / 180)
                Dim T As Double = Size * 0.5
                V(0) = New CustomVertex.PositionColoredTextured( _
                        New Vector3(-T * CosT - -T * SinT, -T * SinT + -T * CosT, 0) + Location, Shade, 0, 1)
                V(1) = New CustomVertex.PositionColoredTextured( _
                        New Vector3(T * CosT - -T * SinT, T * SinT + -T * CosT, 0) + Location, Shade, 0, 0)
                V(2) = New CustomVertex.PositionColoredTextured( _
                        New Vector3(T * CosT - T * SinT, T * SinT + T * CosT, 0) + Location, Shade, 1, 0)
                V(3) = New CustomVertex.PositionColoredTextured( _
                        New Vector3(-T * CosT - T * SinT, -T * SinT + T * CosT, 0) + Location, Shade, 1, 1)
            Else
                V(0) = New CustomVertex.PositionColoredTextured(Location - vUp - vRight, Shade, 0, 1)
                V(1) = New CustomVertex.PositionColoredTextured(Location + vUp - vRight, Shade, 0, 0)
                V(2) = New CustomVertex.PositionColoredTextured(Location + vUp + vRight, Shade, 1, 0)
                V(3) = New CustomVertex.PositionColoredTextured(Location - vUp + vRight, Shade, 1, 1)
            End If
        Else
            Dim View As Matrix = MainForm.Box.ViewMatrix
            Dim vUp As Vector3 = Vector3.Normalize(New Vector3(View.M12, View.M22, View.M32))
            Dim vRight As Vector3 = Vector3.Normalize(New Vector3(View.M11, View.M21, View.M31))
            If Rotation <> 0.0F Then
                Dim CosT As Double = Math.Cos(Rotation * Math.PI / 180)
                Dim SinT As Double = Math.Sin(Rotation * Math.PI / 180)
                Dim T As Double = Size * 0.5
                Dim X0, X1, X2, X3, Y0, Y1, Y2, Y3 As Double
                X0 = -T * CosT - -T * SinT
                Y0 = -T * SinT + -T * CosT
                X1 = T * CosT - -T * SinT
                Y1 = T * SinT + -T * CosT
                X2 = T * CosT - T * SinT
                Y2 = T * SinT + T * CosT
                X3 = -T * CosT - T * SinT
                Y3 = -T * SinT + T * CosT
                V(0) = New CustomVertex.PositionColoredTextured(Location + (vUp * Y0) + (vRight * X0), Shade, 0, 1)
                V(1) = New CustomVertex.PositionColoredTextured(Location + (vUp * Y1) + (vRight * X1), Shade, 0, 0)
                V(2) = New CustomVertex.PositionColoredTextured(Location + (vUp * Y2) + (vRight * X2), Shade, 1, 0)
                V(3) = New CustomVertex.PositionColoredTextured(Location + (vUp * Y3) + (vRight * X3), Shade, 1, 1)
            Else
                vRight *= Size * 0.5
                vUp *= Size * 0.5
                V(0) = New CustomVertex.PositionColoredTextured(Location - vUp - vRight, Shade, 0, 1)
                V(1) = New CustomVertex.PositionColoredTextured(Location + vUp - vRight, Shade, 0, 0)
                V(2) = New CustomVertex.PositionColoredTextured(Location + vUp + vRight, Shade, 1, 0)
                V(3) = New CustomVertex.PositionColoredTextured(Location - vUp + vRight, Shade, 1, 1)
            End If
        End If

    End Sub
End Class
