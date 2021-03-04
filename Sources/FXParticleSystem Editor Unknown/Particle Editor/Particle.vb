Imports System
Imports System.IO
Imports System.Configuration
Imports System.Math
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports D3D = Microsoft.DirectX.Direct3D
Namespace ParticleEffects
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
            ''' <summary> Additive </summary>
            OutwardEmissionVelocity = 0
            ''' <summary> Subtractive </summary>
            OrthoEmissionVelocity = 1
            ''' <summary> Additive Restrictive </summary>
            CylindricalEmissionVelocity = 2
        End Enum
        Public Enum EmissionVolumeType
            ''' <summary> Standard Volume </summary>
            PointEmissionVolume = 0
            ''' <summary> Radius, Length </summary>
            CylinderEmissionVolume = 1
            ''' <summary> LineStart, LineEnd </summary>
            LineEmissionVolume = 2
            ''' <summary> Radius </summary>
            SphereEmissionVolume = 3
        End Enum
        '//Structures
        Public Structure Value
            Public Min As Single
            Public Max As Single
        End Structure
        Public Structure ColorT
            Public R As Single
            Public G As Single
            Public B As Single
            Public Time As Single
        End Structure
        Public Structure AlphaT
            Public A1 As Single
            Public A2 As Single
            Public Time As Single
        End Structure
        '//Public
        '//==System==
        '//The game waits "InitialDelay" amout of millisecnds. Then creates "BurstCount" number of particles. Then waits "BurstDelay" amout of milisecnds. Then creates "BurstCount" number of particles again. Then waits "BurstDelay" amout of milisecnds again and etc. Until "SystemLifetime" time lasts.
        Public Priority As Priorities
        Public Shader As Shaders
        Public ParticleName As Texture
        Public SortLevel As Single
        Public SystemLifetime As Single
        Public Lifetime, Size, BurstDelay, BurstCount, InitialDelay, StartSizeRate As Value
        '//==Colors, Alphas==	
        Public Colors, Alphas As ArrayList
        Public ColorScale As Value
        '//==Update==
        Public Rotation As String
        Public SizeRate, SizeRateDamping, AngleZ, AngularDamping, AngularDampingXY, AngularRateZ, _
         StartSizeX, StartSizeY, StartSizeZ, SizeRateX, SizeRateY, SizeRateZ, SizeDampingX, _
         SizeDampingY, SizeDampingZ, AngularRateXY, AngleXY As Value
        '//==Physics==
        Public VelocityDamping, Gravity As Value
        Public DriftVelocity As Vector
        '//==EmissionVelocity==
        '//====OutwardEmissionVelocity
        Public Speed, OtherSpeed As Value
        '//====OrthoEmissionVelocity
        Public X, Y, Z As Single
        '//====CylindricalEmissionVelocity
        Public Radial, Normal As Value
        '//==EmissionVolume==
        Public IsHollow As Boolean
        Public Radius As Single
        '//====PointEmissionVolume
        '//====CylinderEmissionVolume
        Public Offset As Vector
        Public Length, RadiusRate As Single
        '//====LineEmissionVolume
        Public StartPoint, EndPoint As Vector
        '//====SphereEmissionVolume
        '//====BoxEmissionVolume
        Public HalfSize As Vector
        '//Emitter
        Public EmissionVolume As EmissionVolumeType
        Public EmissionVelocity As EmissionVelocityType
        Public Sub New()
        End Sub
    End Class
    Public Class ParticleEmitter '//Physics
        Public Info As ParticleSystemInfo
        Public BurstDelay, BurstCount, InitialDelay As Single
        Private Time, BurstTime As Single
        Public MaxParticles As Integer = 1000
        Public Particles(MaxParticles) As Particle
        Public ParticlesAlive As Integer
        Public SystemLife As Single
        Public Sub New(ByVal PSI As ParticleSystemInfo)
            Info = PSI
            SystemLife = Info.SystemLifetime
            ParticlesAlive = 0
            BurstDelay = Scene.RandS(Info.BurstDelay.Min, Info.BurstDelay.Max)
            BurstCount = Scene.RandI(Info.BurstCount.Min, Info.BurstCount.Max)
        End Sub
        Public Sub Update(ByVal Deltatime As Single)
            Dim RemovedParticles As New ArrayList
            BurstTime += Deltatime
            If Time < InitialDelay Then
                Time += Deltatime
            Else
                If Info.SystemLifetime <= 0.0F Then
                    Return
                End If
                Info.SystemLifetime -= Deltatime
                '//Create New
                If BurstTime >= BurstDelay Then
                    BurstTime = 0
                    If ParticlesAlive + BurstCount > MaxParticles Then
                        BurstCount = MaxParticles - ParticlesAlive
                    End If
                    For I As Integer = 1 To BurstCount
                        Dim P As New Particle
                        NewParticle(P)
                        ParticlesAlive += 1
                        Particles(ParticlesAlive) = P
                    Next
                    BurstDelay = Scene.RandS(Info.BurstDelay.Min, Info.BurstDelay.Max)
                    BurstCount = Scene.RandI(Info.BurstCount.Min, Info.BurstCount.Max)
                End If
                '//Update Each Particle Alive
                Dim ParticleUpdated As Boolean
                For I As Integer = 0 To ParticlesAlive - 1
                    ParticleUpdated = UpdateParticle(Particles(I), Deltatime)
                    If Not ParticleUpdated Then
                        RemovedParticles.Add(I)
                    End If
                Next
            End If
            '//Remove Dead Particles
            Dim OriginalIndex As Integer = -1
            For Each Index As Integer In RemovedParticles
                OriginalIndex += 1
                Particles(Index + OriginalIndex) = Nothing
                '//Adjust All Particles Back
                For I As Integer = Index To ParticlesAlive - 1
                    Particles(I) = Particles(I + 1)
                Next
            Next
        End Sub
        Public Sub NewParticle(ByRef P As Particle)
            P.CurrentColorVal = 0
            P.CurrentAlphaVal = 0
            P.CurrentColor = Info.Colors(P.CurrentColorVal)
            P.CurrentAlpha = Info.Alphas(P.CurrentAlphaVal)
            P.Color = New Color
            P.Color.A = Scene.RandS(P.CurrentAlpha.A1, P.CurrentAlpha.A2)
            P.Color.R = P.CurrentColor.R / 255
            P.Color.G = P.CurrentColor.G / 255
            P.Color.B = P.CurrentColor.B / 255
            P.Gravity = Scene.RandS(Info.Gravity.Min, Info.Gravity.Max)
            P.Lifetime = Scene.RandS(Info.Lifetime.Min, Info.Lifetime.Max)
            P.DriftVelocity = Info.DriftVelocity
            P.Size = Scene.RandS(Info.Size.Min, Info.Size.Max)
            P.SizeRate = Scene.RandS(Info.SizeRate.Min, Info.SizeRate.Max)
            P.SizeRateDamping = Scene.RandS(Info.SizeRateDamping.Min, Info.SizeRateDamping.Max)
            P.Velocity = VelocityVector()
            P.VelocityDamping = Scene.RandS(Info.VelocityDamping.Min, Info.VelocityDamping.Max)
        End Sub
        Public Function UpdateParticle(ByRef P As Particle, ByVal Deltatime As Single) As Boolean
            '//Color
            P.Lifetime -= Deltatime
            If P.Lifetime <= 0.0F Then
                Return False
            End If
            P.ColorTime += Deltatime
            P.AlphaTime += Deltatime
            If P.ColorTime >= P.CurrentColor.Time Then
                If P.CurrentColorVal < Info.Colors.Count - 1 Then
                    P.ColorTime = 0
                    P.CurrentColorVal += 1
                    P.CurrentColor = Info.Colors(P.CurrentColorVal)
                    P.Color.R = P.CurrentColor.R / 255
                    P.Color.G = P.CurrentColor.G / 255
                    P.Color.B = P.CurrentColor.B / 255
                End If
            End If
            If P.AlphaTime >= P.CurrentAlpha.Time Then
                If P.CurrentAlphaVal < Info.Alphas.Count - 1 Then
                    P.AlphaTime = 0
                    P.CurrentAlphaVal += 1
                    P.CurrentAlphaVal = Info.Alphas(P.CurrentAlphaVal)
                    P.Color.A = Scene.RandS(P.CurrentAlpha.A1, P.CurrentAlpha.A2)
                End If
            End If
            '//Physics
            P.Velocity += (P.DriftVelocity * Deltatime) + P.VelocityDamping
            P.Location += P.Velocity * Deltatime
            P.SizeRate += P.SizeRateDamping
            P.Size += P.SizeRate * Deltatime
            Return True
        End Function
        Public Function VelocityVector() As Vector
            Select Case Info.EmissionVelocity
                Case ParticleSystemInfo.EmissionVelocityType.CylindricalEmissionVelocity
                    Select Case Info.EmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.CylinderEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.LineEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.PointEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.SphereEmissionVolume
                    End Select
                Case ParticleSystemInfo.EmissionVelocityType.OrthoEmissionVelocity
                    Select Case Info.EmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.CylinderEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.LineEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.PointEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.SphereEmissionVolume
                    End Select
                Case ParticleSystemInfo.EmissionVelocityType.OutwardEmissionVelocity
                    Select Case Info.EmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.CylinderEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.LineEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.PointEmissionVolume
                        Case ParticleSystemInfo.EmissionVolumeType.SphereEmissionVolume
                    End Select
            End Select
            Return Nothing
        End Function
    End Class
    Public Class ParticleSystem '//Update + Display
        Public Emitter As ParticleEmitter
        Public UpdateSpeed, Residue As Single
        Public ReadOnly DesiredFPS As Single
        Private VertexBuffer As VertexBuffer = Nothing
        Public Sub New(ByVal PSI As ParticleSystemInfo, Optional ByVal DesiredFPS As Single = 0.0F)
            Emitter = New ParticleEmitter(PSI)
            Residue = 0.0F
            If (DesiredFPS <> 0.0F) Then UpdateSpeed = 1.0F / DesiredFPS Else UpdateSpeed = 0.0F
            VertexBuffer = New VertexBuffer(GetType(CustomVertex.TransformedColoredTextured), Emitter.MaxParticles, Scene.LocalDevice, Usage.WriteOnly, CustomVertex.TransformedColoredTextured.Format, Pool.Default)
        End Sub
        Public Shared Function FromFile(ByVal FilePath As String, Optional ByVal DesiredFPS As Single = 0.0F) As ParticleSystem
            Dim Sr As IO.StreamReader = IO.File.OpenText(FilePath)
            Dim Line, InnerLine As String
            Dim PSI As New ParticleSystemInfo
            Do While Sr.Peek <> -1
                Line = Sr.ReadLine.TrimStart.TrimEnd
                If Line.StartsWith("FXParticleSystem") Then
                    Do Until Line.StartsWith("End")
                        Line = Sr.ReadLine.TrimStart.TrimEnd
                        InnerLine = Line
                        If Line.StartsWith("System") Then
                            Do Until InnerLine.StartsWith("End")
                                InnerLine = Sr.ReadLine.TrimStart.TrimEnd
                            Loop
                        End If
                        If Line.StartsWith("Color") Then
                            Do Until InnerLine.StartsWith("End")
                                InnerLine = Sr.ReadLine.TrimStart.TrimEnd
                                Dim C As ParticleSystemInfo.ColorT

                            Loop
                        End If
                        If Line.StartsWith("Alpha") Then
                            Do Until InnerLine.StartsWith("End")
                                InnerLine = Sr.ReadLine.TrimStart.TrimEnd

                            Loop
                        End If
                        If Line.StartsWith("Update") Then
                            Do Until InnerLine.StartsWith("End")
                                InnerLine = Sr.ReadLine.TrimStart.TrimEnd

                            Loop
                        End If
                        If Line.StartsWith("Physics") Then
                            Do Until InnerLine.StartsWith("End")
                                InnerLine = Sr.ReadLine.TrimStart.TrimEnd

                            Loop
                        End If
                        If Line.StartsWith("EmissionVelocity") Then
                            Do Until InnerLine.StartsWith("End")
                                InnerLine = Sr.ReadLine.TrimStart.TrimEnd

                            Loop
                        End If
                        If Line.StartsWith("EmissionVolume") Then
                            Do Until InnerLine.StartsWith("End")
                                InnerLine = Sr.ReadLine.TrimStart.TrimEnd

                            Loop
                        End If
                    Loop
                End If
            Loop
            Dim PS As New ParticleSystem(PSI, DesiredFPS)
            Return PS
        End Function
        Public Sub Update(ByVal Deltatime As Single)
            If UpdateSpeed = 0.0F Then
                Emitter.Update(Deltatime)
            Else
                Residue += Deltatime
                If Residue >= UpdateSpeed Then
                    Emitter.Update(UpdateSpeed)
                    While Residue >= UpdateSpeed
                        Residue -= UpdateSpeed
                    End While
                End If
            End If
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
            Device.SetTexture(0, Emitter.Info.ParticleName)
            Device.SetStreamSource(0, VertexBuffer, 0)
            Dim Points(Emitter.ParticlesAlive - 1) As CustomVertex.TransformedColoredTextured
            Points = VertexBuffer.Lock(0, 0)
            For I As Integer = 0 To Emitter.ParticlesAlive - 1
                Dim P As Particle = Emitter.Particles(I)
                Points(I).Color = P.Color.ToARGB
                Points(I).X = P.Location.X
                Points(I).Y = P.Location.Y
            Next
            VertexBuffer.Unlock()
            Device.DrawPrimitives(PrimitiveType.PointList, 0, Emitter.ParticlesAlive - 1)
            Device.RenderState.PointSpriteEnable = False
            Device.RenderState.PointScaleEnable = False
            Device.RenderState.ZBufferWriteEnable = True
            Device.RenderState.AlphaBlendEnable = False
        End Sub
    End Class
    Public Class Particle '//Particle Object
        Public Lifetime, VelocityDamping, Gravity, Size, SizeRate, SizeRateDamping As Single
        Public Location, Velocity, DriftVelocity As Vector
        Public Color As Color
        Public CurrentColor As ParticleSystemInfo.ColorT
        Public CurrentAlpha As ParticleSystemInfo.AlphaT
        Public ColorTime, AlphaTime As Single
        Public CurrentColorVal, CurrentAlphaVal As Integer
        Public Sub New()
        End Sub
    End Class
End Namespace
