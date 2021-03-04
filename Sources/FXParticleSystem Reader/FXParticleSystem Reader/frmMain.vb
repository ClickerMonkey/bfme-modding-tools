Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports DI = Microsoft.DirectX.DirectInput

Public Class frmMain
    Private Initialized As Boolean = False
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Scene.Parent = Me
        If Scene.Initialize Then
            Initialized = True
            AddHandler Scene.SceneUpdate, AddressOf SceneUpdating
            AddHandler Scene.SceneRender, AddressOf SceneRendering
            Me.Invalidate()
        End If
    End Sub
    Private Sub frmMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Initialized Then
            Scene.Update()
            Scene.Render()
            Application.DoEvents()
            Me.Invalidate()
        End If
    End Sub
    Public Sub SceneUpdating()

    End Sub
    Public Sub SceneRendering()

    End Sub
End Class

'Notes:
'GPU_PARTICLE Type has 'Gpu' Draw
'PARTICLE Type has 'Default' Draw
'TRAIL Type has 'Trail' Draw
'DRAWABLE Type has 'RenderObject' Draw and 'RenderObject' Update and a W3D Object for Drawable Attribute

Public Enum Priorities As Byte
    VERY_LOW_OR_ABOVE = 0
    LOW_OR_ABOVE = 1
    MEDIUM_OR_ABOVE = 2
    HIGH_OR_ABOVE = 3
    ULTRA_HIGH_ONLY = 4
    ALWAYS_RENDER = 5
End Enum
Public Enum Shaders As Byte
    ALPHA = 0
    ADDITIVE = 1
End Enum
Public Enum Types As Byte
    PARTICLE = 0
    GPU_PARTICLE = 1
    DRAWABLE = 2
    TRAIL = 3
End Enum
Public Enum Drawables As Byte
    NONE
    EXTIBCLUSTER
    EXNODMINE
    EMPCARD
    FXCASING
    FXEMP
    FXEMPXPLOSION
    FXCASINGS
    FXNODCHEVRON1
    FXNODCHEVRON2
    FXNODCHEVRON3
    FXALIENCHEVRON1
    FXALIENCHEVRON2
    FXALIENCHEVRON3
    FXNUKEEX
    FXNUKEEX2
    FXSPHEREA
    FXSPHEREDISTORT
    FXCATALYSTRAYS
    FXLEVELUPRAYS
    FXALIENSHIELDGEO
End Enum
Public Enum Velocities As Byte
    Outward = 0
    Ortho = 1
    Cylindrical = 2
    Spherical = 3
End Enum
Public Enum Volumes As Byte
    Point = 0
    Cylinder = 1
    Line = 2
    Sphere = 3
    Spline = 4
    Box = 5
End Enum
Public Enum Rotations As Byte
    ROTATION_X = 0
    ROTATION_Y = 1
    ROTATION_Z = 2
    ROTATION_V = 3
    ROTATION_OFF = 4
End Enum
Public Enum GeometryTypes As Byte
    CENTERED_QUAD = 0
    SIMPLE_QUAD = 1
    TWO_CONCENTRIC_QUADS = 2
End Enum
Public Enum ObjectSetShaders As Byte
    W3D_DIFFUSE = 0
    W3D_ALPHA = 1
End Enum
Public Enum ErrorSeverity
    Notice = 0
    Warning = 1
    Critical = 2
End Enum
Public Class Range
    Public Low As Single
    Public High As Single
    Public Sub New()
    End Sub
    Public Sub New(ByVal Low As Single, ByVal High As Single)
        Me.Low = Low
        Me.High = High
    End Sub
    Public Sub ReadXML(ByVal Reader As Xml.XmlTextReader)
        Low = Reader.GetAttribute("low")
        High = Reader.GetAttribute("high")
    End Sub
    Public Sub WriteXML(ByVal Tag As String, ByVal Writer As Xml.XmlTextWriter)
        Writer.WriteStartElement(Tag)
        Writer.WriteAttributeString("low", Low)
        Writer.WriteAttributeString("high", High)
        Writer.WriteEndElement()
    End Sub
    Public Function Random() As Single
        Return (High - Low) * Rnd() + Low
    End Function
    Public Shared Function Empty(Optional ByVal Base As Single = 0.0F) As Range
        Return New Range(Base, Base)
    End Function
End Class
Public Class ColorTime
    Public R As Single = 255.0F
    Public G As Single = 255.0F
    Public B As Single = 255.0F
    Public RelativeAge As Single = 0.0F
    Public Sub New()
    End Sub
    Public Sub New(ByVal R As Single, ByVal G As Single, ByVal B As Single, ByVal RelativeAge As Single)
        Me.R = R
        Me.G = G
        Me.B = B
        Me.RelativeAge = RelativeAge
    End Sub
    Public Sub ReadXML(ByVal Reader As Xml.XmlTextReader)
        R = Reader.GetAttribute("r") * 255
        G = Reader.GetAttribute("g") * 255
        B = Reader.GetAttribute("b") * 255
        RelativeAge = Reader.GetAttribute("RelativeAge")
    End Sub
    Public Sub WriteXML(ByVal Frame As Integer, ByVal Writer As Xml.XmlTextWriter)
        Writer.WriteStartElement("Color")
        Writer.WriteAttributeString("r", R / 255)
        Writer.WriteAttributeString("g", G / 255)
        Writer.WriteAttributeString("b", B / 255)
        Writer.WriteAttributeString("Frame", Frame)
        Writer.WriteAttributeString("RelativeAge", RelativeAge)
        Writer.WriteEndElement()
    End Sub
    Public Shared Function Empty() As ColorTime
        Return New ColorTime
    End Function
    Public Shared Operator =(ByVal C1 As ColorTime, ByVal C2 As ColorTime) As Boolean
        Return (C1.R = C2.R And C1.G = C2.G And C1.B = C2.B And C1.RelativeAge = C1.RelativeAge)
    End Operator
    Public Shared Operator <>(ByVal C1 As ColorTime, ByVal C2 As ColorTime) As Boolean
        Return (C1.R <> C2.R Or C1.G <> C2.G Or C1.B <> C2.B Or C1.RelativeAge <> C1.RelativeAge)
    End Operator
End Class
Public Class AlphaTime
    Public Low As Single = 1.0F
    Public High As Single = 1.0F
    Public RelativeAge As Single = 0.0F
    Public Sub New()
    End Sub
    Public Sub New(ByVal Low As Single, ByVal High As Single, ByVal RelativeAge As Single)
        Me.Low = Low
        Me.High = High
        Me.RelativeAge = RelativeAge
    End Sub
    Public Sub ReadXML(ByVal Reader As Xml.XmlTextReader)
        Low = Reader.GetAttribute("low") * 255
        High = Reader.GetAttribute("high") * 255
        RelativeAge = Reader.GetAttribute("RelativeAge")
    End Sub
    Public Sub WriteXML(ByVal Frame As Integer, ByVal Writer As Xml.XmlTextWriter)
        Writer.WriteStartElement("Alpha")
        Writer.WriteAttributeString("low", Low / 255)
        Writer.WriteAttributeString("high", High / 255)
        Writer.WriteAttributeString("Frame", Frame)
        Writer.WriteAttributeString("RelativeAge", RelativeAge)
        Writer.WriteEndElement()
    End Sub
    Public Function Random() As Single
        Return (High - Low) * Rnd() + Low
    End Function
    Public Shared Function Empty() As AlphaTime
        Return New AlphaTime
    End Function
End Class
Public Class Vector
    Public X As Single = 0.0F
    Public Y As Single = 0.0F
    Public Z As Single = 0.0F
    Public Sub New()
    End Sub
    Public Sub New(ByVal X As Single, ByVal Y As Single, ByVal Z As Single)
        Me.X = X
        Me.Y = Y
        Me.Z = Z
    End Sub
    Public Sub ReadXML(ByVal Reader As Xml.XmlTextReader)
        X = Reader.GetAttribute("x")
        Y = Reader.GetAttribute("y")
        Z = Reader.GetAttribute("z")
    End Sub
    Public Sub WriteXML(ByVal Tag As String, ByVal Writer As Xml.XmlTextWriter)
        Writer.WriteStartElement(Tag)
        Writer.WriteAttributeString("x", X)
        Writer.WriteAttributeString("y", Y)
        Writer.WriteAttributeString("z", Z)
        Writer.WriteEndElement()
    End Sub
    Public Function Vector3() As Vector3
        Return New Vector3(X, Y, Z)
    End Function
    Public Shared Function Empty(Optional ByVal Base As Single = 0.0F) As Vector
        Return New Vector(Base, Base, Base)
    End Function
    Public Shared Operator +(ByVal V1 As Vector, ByVal V2 As Single) As Vector
        Return New Vector(V1.X + V2, V1.Y + V2, V1.Z + V2)
    End Operator
    Public Shared Operator +(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X + V2.X, V1.Y + V2.Y, V1.Z + V2.Z)
    End Operator
    Public Shared Operator *(ByVal V1 As Vector, ByVal V2 As Single) As Vector
        Return New Vector(V1.X * V2, V1.Y * V2, V1.Z * V2)
    End Operator
    Public Shared Operator *(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X * V2.X, V1.Y * V2.Y, V1.Z * V2.Z)
    End Operator
    Public Shared Operator -(ByVal V1 As Vector, ByVal V2 As Single) As Vector
        Return New Vector(V1.X - V2, V1.Y - V2, V1.Z - V2)
    End Operator
    Public Shared Operator -(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X - V2.X, V1.Y - V2.Y, V1.Z - V2.Z)
    End Operator
    Public Shared Operator /(ByVal V1 As Vector, ByVal V2 As Single) As Vector
        Return New Vector(V1.X / V2, V1.Y / V2, V1.Z / V2)
    End Operator
    Public Shared Operator /(ByVal V1 As Vector, ByVal V2 As Vector) As Vector
        Return New Vector(V1.X / V2.X, V1.Y / V2.Y, V1.Z / V2.Z)
    End Operator
End Class
Public Class ObjectSet
    Public RenderGroup As String = String.Empty
    Public NumObjects As Integer = 0
    Public Percent As Single = 0.0F
    Public Shader As ObjectSetShaders
    Public Sub ReadXML(ByVal Reader As Xml.XmlTextReader)
        RenderGroup = Reader.GetAttribute("RenderGroup")
        NumObjects = Reader.GetAttribute("NumObjects")
        Percent = Reader.GetAttribute("Percent")
        Select Case Reader.GetAttribute("Shader")
            Case "W3D_DIFFUSE"
                Shader = ObjectSetShaders.W3D_DIFFUSE
            Case "W3D_ALPHA"
                Shader = ObjectSetShaders.W3D_ALPHA
        End Select
    End Sub
    Public Sub WriteXML(ByVal Writer As Xml.XmlTextWriter)
        Writer.WriteStartElement("ObjectSet")
        Writer.WriteAttributeString("RenderGroup", RenderGroup)
        Writer.WriteAttributeString("NumObjects", NumObjects)
        Writer.WriteAttributeString("Percent", Percent)
        Writer.WriteAttributeString("Shader", Shader.ToString)
        Writer.WriteEndElement()
    End Sub
End Class
Public Class Color
    Public A As Byte = 255
    Public R As Byte = 255
    Public G As Byte = 255
    Public B As Byte = 255
    Public Sub New()
    End Sub
    Public Sub New(ByVal Alpha As Integer, ByVal Red As Integer, ByVal Green As Integer, ByVal Blue As Integer)
        A = Restrict(Alpha)
        R = Restrict(Red)
        G = Restrict(Green)
        B = Restrict(Blue)
    End Sub
    Public Function ToInteger() As Integer
        Return (A << 24) + (R << 16) + (G << 8) + B
    End Function
    Private Function Restrict(ByVal Value As Integer) As Byte
        If Value > 255 Then Return 255
        If Value < 0 Then Return 0
        Return Value
    End Function
    Public Shared Function Empty() As Color
        Return New Color
    End Function
End Class
Public Class FXParticleSystemEmitter
    Public Template As FXParticleSystemTemplate
    Public Particles As New List(Of FXParticle)
    Public Location As Vector = Vector.Empty
    Public CurrentFrame As Long = 0
    Public Delay As Integer = 0
    Public BurstDelay As Integer
    Public BurstTime As Integer
    Public Active As Boolean = False
    Public CreateNew As Boolean = True
    Public Sub Update()
        If Active Then
            CurrentFrame += 1
            If CurrentFrame >= Delay Then
                'If its still living then create new particles
                If CreateNew Then
                    'Increment time for burst of particles
                    BurstTime += 1
                    'If time is greater then delay threshold then
                    If BurstTime >= BurstDelay Then
                        BurstTime = 0
                        'Reset burst delay to a new count
                        BurstDelay = Template.BurstDelay.Random
                        'Release a bursts amount of particles
                        Dim Bursts As Integer = Template.BurstCount.Random
                        For I As Integer = 1 To Bursts
                            'Add new particle
                            Particles.Add(NewParticle)
                        Next
                    End If
                End If
                'Update particles going from last to first
                For I As Integer = Particles.Count - 1 To 0 Step -1
                    'If particle is not updated, it's dead so remove it
                    If Not UpdateParticle(Particles(I)) Then
                        Particles.RemoveAt(I)
                    End If
                Next
                'If the time since particles have been releasing is 
                '   greater than or equal to the lifetime then stop creating new
                If CurrentFrame - Delay >= Template.SystemLifetime Then
                    CreateNew = False
                End If
                'If no more particles are going to be created and there
                '   are no more to be updated then it's no longer active
                If Not CreateNew And Particles.Count = 0 Then
                    Active = False
                End If
            End If
        End If
    End Sub
    Public Sub Render()

    End Sub
    Public Sub ResetFrame()
        CurrentFrame = 0
    End Sub
    Public Sub Start()
        CurrentFrame = 0
        Delay = Template.InitialDelay.Random
        BurstDelay = Template.BurstDelay.Random
        CreateNew = True
        Active = True
    End Sub
    Public Sub Pause()
        Active = False
    End Sub
    Private Function NewParticle() As FXParticle
        Dim P As New FXParticle
        P.AngleXY = Template.AngleXY.Random
        P.AngleZ = Template.AngleZ.Random
        P.AngularDamping = Template.AngularDamping.Random
        P.AngularDampingXY = Template.AngularDampingXY.Random
        P.AngularRateXY = Template.AngularRateXY.Random
        P.AngularRateZ = Template.AngularRateZ.Random
        P.Life = Template.Lifetime.Random
        P.VelocityDamping = Template.VelocityDamping.Random
        P.Shade.A = Template.Alphas(0).Random
        P.Shade.R = Template.Colors(0).R
        P.Shade.G = Template.Colors(0).G
        P.Shade.B = Template.Colors(0).B
        P.Size = Template.Size.Random
        P.SizeRate = Template.SizeRate.Random
        P.SizeRateDamping = Template.SizeRateDamping.Random
        P.Delta = Random(0, 360)
        P.Theta = Random(0, 360)
        P.Location = InitialVolume(P)
        P.Velocity = InitialVelocity(P)
        Return P
    End Function
    Private Function UpdateParticle(ByRef P As FXParticle) As Boolean
        P.Location += P.Velocity
        P.Velocity.Z -= Template.Gravity
        P.Velocity += Template.DriftVelocity
        P.Velocity *= P.VelocityDamping
        P.Size += P.SizeRate
        P.SizeRate *= P.SizeRateDamping
        P.AngleZ += P.AngularRateZ
        P.AngularRateZ *= P.AngularDamping
        P.AngleXY += P.AngularRateXY
        P.AngularRateXY *= P.AngularDampingXY
        P.Life -= 1
        If P.Life <= 0 Then Return False
        Return True
    End Function
    Private Function InitialVolume(ByVal P As FXParticle) As Vector
        Dim V As Vector = Vector.Empty
        Select Case Template.Volume
            Case Volumes.Box
                V.X = Random(-Template.HalfSize.X, Template.HalfSize.X)
                V.Y = Random(-Template.HalfSize.Y, Template.HalfSize.Y)
                V.Z = Random(-Template.HalfSize.Z, Template.HalfSize.Z)
                If Template.IsHollow Then
                    Select Case Int(Rnd() * 5)
                        Case 0 : V.Z = Template.HalfSize.Z 'Top
                        Case 1 : V.Z = -Template.HalfSize.Z 'Bottom
                        Case 2 : V.X = Template.HalfSize.X 'Right
                        Case 3 : V.X = -Template.HalfSize.X 'Left
                        Case 4 : V.Y = -Template.HalfSize.Y 'Front
                        Case 5 : V.Y = Template.HalfSize.Y 'Back
                    End Select
                End If
            Case Volumes.Cylinder
                If Template.IsHollow Then
                    V.X = Cos(P.Delta) * Template.Radius
                    V.Y = Sin(P.Delta) * Template.Radius
                    V.Z = Random(0, Template.Length) - Template.Length / 2
                Else
                    V.X = Cos(P.Delta) * (Template.Radius * Rnd())
                    V.Y = Sin(P.Delta) * (Template.Radius * Rnd())
                    V.Z = Random(0, Template.Length) - Template.Length / 2
                End If
            Case Volumes.Line, Volumes.Spline
                V = RandomPoint(Template.StartPoint, Template.EndPoint)
            Case Volumes.Sphere
                If Template.IsHollow Then
                    V.X = Sin(P.Delta) * Cos(P.Theta) * Template.Radius
                    V.Y = Sin(P.Delta) * Sin(P.Theta) * Template.Radius
                    V.Z = Cos(P.Delta) * Template.Radius
                Else
                    V.X = Sin(P.Delta) * Cos(P.Theta) * (Template.Radius * Rnd())
                    V.Y = Sin(P.Delta) * Sin(P.Theta) * (Template.Radius * Rnd())
                    V.Z = Cos(P.Delta) * (Template.Radius * Rnd())
                End If
            Case Volumes.Point
        End Select
        Return V + Location
    End Function
    Private Function InitialVelocity(ByVal P As FXParticle) As Vector
        Dim V As Vector = Vector.Empty
        Select Case Template.Velocity
            Case Velocities.Cylindrical
                V.X = Cos(P.Delta) * Template.Radial.Random
                V.Y = Sin(P.Delta) * Template.Radial.Random
                V.Z = Template.Normal.Random
            Case Velocities.Ortho
                V.X = Template.X.Random
                V.Y = Template.Y.Random
                V.Z = Template.Z.Random
            Case Velocities.Outward
                Select Case Int(Rnd())
                    Case 0
                        V.X = Sin(P.Delta) * Cos(P.Theta) * Template.Speed.Random
                        V.Y = Sin(P.Delta) * Sin(P.Theta) * Template.Speed.Random
                        V.Z = Cos(P.Delta) * Template.Speed.Random
                    Case 1
                        V.X = Sin(P.Delta) * Cos(P.Theta) * Template.OtherSpeed.Random
                        V.Y = Sin(P.Delta) * Sin(P.Theta) * Template.OtherSpeed.Random
                        V.Z = Cos(P.Delta) * Template.OtherSpeed.Random
                End Select
            Case Velocities.Spherical
                V.X = Sin(P.Delta) * Cos(P.Theta) * Template.Speed.Random
                V.Y = Sin(P.Delta) * Sin(P.Theta) * Template.Speed.Random
                V.Z = Cos(P.Delta) * Template.Speed.Random
        End Select
        Return V
    End Function
    Private Function Random(ByVal Low As Single, ByVal High As Single) As Single
        Return (High - Low) * Rnd() + Low
    End Function
    Private Function RandomPoint(ByVal Low As Vector, ByVal High As Vector) As Vector
        Dim Delta As Single = Rnd()
        Return New Vector((High.X - Low.X) * Delta + Low.X, (High.Y - Low.Y) * Delta + Low.Y, (High.Z - Low.Z) * Delta + Low.Z)
    End Function
End Class
Public Class FXParticleSystemTemplate
    Public id As String = String.Empty 'Attribute
    Public Priority As Priorities = Priorities.ALWAYS_RENDER 'Attribute 
    Public Shader As Shaders = Shaders.ALPHA 'Attribute
    Public Type As Types = Types.GPU_PARTICLE 'Attribute
    Public ParticleTexture As String = String.Empty 'Attribute
    Public SystemLifetime As Integer = 0 'Attribute
    Public SortLevel As Integer = 0 'Attribute
    Public EmitterSound As String = String.Empty 'Attribute
    Public IsOneShot As Boolean = False 'Attribute
    Public IsGroundAligned As Boolean = False 'Attribute
    Public IsEmitAboveGroundOnly As Boolean = False 'Attribute
    Public IsParticleUpTowardsEmitter As Boolean = False 'Attribute
    Public UseMaximumHeight As Boolean = False 'Attribute
    Public Drawable As Drawables = Drawables.NONE 'Attribute
    Public SlaveSystem As String = String.Empty 'Attribute
    Public PerParticleAttached As String = String.Empty 'Attribute
    Public SlavePosOffset As Vector = Vector.Empty 'Element
    Public Lifetime As Range = Range.Empty 'Element
    Public Size As Range = Range.Empty 'Element
    Public StartSizeRate As Range = Range.Empty 'Element
    Public BurstDelay As Range = Range.Empty 'Element
    Public BurstCount As Range = Range.Empty 'Element
    Public InitialDelay As Range = Range.Empty 'Element
    'Colors
    Public UseHouseColor As Boolean = False 'Attribute
    Public HouseColorSaturation As Single = 0.0F 'Attribute
    Public Colors(8) As ColorTime 'Element(s)
    'Alphas
    Public Alphas(8) As AlphaTime 'Element(s)
    'Physics~Default
    Public Gravity As Single = 0.0F 'Attribute
    Public Swirly As Boolean = False 'Attribute
    Public ParticlesAttachToBone As Boolean = False 'Attribute
    Public VelocityDamping As Range = Range.Empty(1.0F) 'Element
    Public DriftVelocity As Vector = Vector.Empty 'Element
    'Physics~Swarm
    Public AttractStrength As Single = 0.0F 'Attribute
    'Draw~Default (Nothing)
    'Draw~Streak (Nothing)
    'Draw~Trail
    Public TrailLife As Single = 0.0F 'Attribute
    Public UTile As Single = 1.0F 'Attribute
    Public VTile As Single = 1.0F 'Attribute
    Public UScrollRate As Single = 0.0F 'Attribute
    Public VScrollRate As Single = 0.0F 'Attribute
    'Draw~Gpu
    Public GpuShader As String = String.Empty 'Attribute
    Public FramesPerRow As Integer = 0 'Attribute
    Public TotalFrames As Integer = 0 'Attribute
    Public DetailTexture As String = String.Empty 'Attribute
    Public SpeedMultiplier As Single = 1.0F 'Attribute
    Public GeometryType As GeometryTypes 'Attribute
    Public SoftParticles As Boolean = False 'Attribute
    'Draw~RenderObject
    Public MultiRenderObjects As Boolean = False 'Attribute
    Public SinkOnCollision As Boolean = False 'Attribute
    Public SinkRate As Single = 0.0F 'Attribute
    Public ObjectSets(3) As ObjectSet 'Element
    'Volume~Sphere (IsHollow, Radius)
    'Volume~Cylinder (IsHollow, Radius, RadiusRate, Length)
    'Volume~Line (IsHollow, StartPoint, EndPoint)
    'Volume~Spline (IsHollow, StartPoint, EndPoint)
    'Volume~Box (IsHollow, HalfSize)
    'Volume~Point (IsHollow)
    'Volume~Lightning
    Public Volume As Volumes = Volumes.Point
    Public IsHollow As Boolean = False 'Attribute
    Public Radius As Single = 0.0F 'Attribute
    Public Offset As Vector = Vector.Empty 'Element
    Public RadiusRate As Single = 0.0F 'Attribute
    Public Length As Single = 0.0F 'Attribute
    Public StartPoint As Vector = Vector.Empty 'Element
    Public EndPoint As Vector = Vector.Empty ' Element
    Public HalfSize As Vector = Vector.Empty 'Element
    'Velocity~Ortho (X, Y, Z)
    'Velocity~Spherical (Speed)
    'Velocity~Outward (Speed, OtherSpeed)
    'Velocity~Cylindrical (Radial, Normal)
    Public Velocity As Velocities
    Public X As Range = Range.Empty 'Element
    Public Y As Range = Range.Empty 'Element
    Public Z As Range = Range.Empty 'Element
    Public Speed As Range = Range.Empty 'Element
    Public OtherSpeed As Range = Range.Empty 'Element
    Public Radial As Range = Range.Empty 'Element
    Public Normal As Range = Range.Empty 'Element
    'Update~Default
    Public Rotation As Rotations = Rotations.ROTATION_OFF 'Attribute
    Public SizeRate As Range = Range.Empty
    Public SizeRateDamping As Range = Range.Empty(1.0F)
    Public AngleZ As Range = Range.Empty
    Public AngularRateZ As Range = Range.Empty
    Public AngularDamping As Range = Range.Empty(1.0F)
    Public AngleXY As Range = Range.Empty
    Public AngularRateXY As Range = Range.Empty
    Public AngularDampingXY As Range = Range.Empty(1.0F)
    'Update~RenderObject (Rotation, AngleZ, AngularRateZ, AngularDamping)
    Public StartSizeX As Range = Range.Empty
    Public StartSizeY As Range = Range.Empty
    Public StartSizeZ As Range = Range.Empty
    Public SizeRateX As Range = Range.Empty
    Public SizeRateY As Range = Range.Empty
    Public SizeRateZ As Range = Range.Empty
    Public SizeDampingX As Range = Range.Empty
    Public SizeDampingY As Range = Range.Empty
    Public SizeDampingZ As Range = Range.Empty

    Public Sub New()
    End Sub
    Public Sub ReadXML(ByVal Reader As Xml.XmlTextReader)
        ReadXML(Reader, "")
    End Sub
    Public Sub ReadXML(ByVal Reader As Xml.XmlTextReader, ByVal SystemName As String)
        Dim Name As String = ""
        Do Until Reader.EOF 'Loop Until End-Of-File

        Loop
    End Sub
    Public Sub WriteXML(ByVal Writer As Xml.XmlTextWriter)
        'Template Attributes and Elements
        Writer.WriteStartElement("FXParticleSystemTemplate")
        Writer.WriteAttributeString("id", Me.id)
        Writer.WriteAttributeString("Priority", Me.Priority.ToString)
        Writer.WriteAttributeString("Shader", Me.Shader.ToString)
        Writer.WriteAttributeString("Type", Me.Type.ToString)
        Writer.WriteAttributeString("ParticleTexture", Me.ParticleTexture)
        Writer.WriteAttributeString("SystemLifetime", Me.SystemLifetime)
        Writer.WriteAttributeString("SortLevel", Me.SortLevel)
        Writer.WriteAttributeString("EmitterSound", Me.EmitterSound)
        Writer.WriteAttributeString("IsOneShot", Me.IsOneShot.ToString)
        Writer.WriteAttributeString("IsGroundAligned", Me.IsGroundAligned.ToString)
        Writer.WriteAttributeString("IsEmitAboveGroundOnly", Me.IsEmitAboveGroundOnly.ToString)
        Writer.WriteAttributeString("IsParticleUpTowardsEmitter", Me.IsParticleUpTowardsEmitter.ToString)
        Writer.WriteAttributeString("UseMaximumHeight", Me.UseMaximumHeight.ToString)
        Writer.WriteAttributeString("Drawable", IIf(Me.Drawable = Drawables.NONE, String.Empty, Me.Drawable.ToString))
        Writer.WriteAttributeString("SlaveSystem", Me.SlaveSystem)
        Writer.WriteAttributeString("PerParticleAttached", Me.PerParticleAttached)
        Me.SlavePosOffset.WriteXML("SlavePosOffset", Writer)
        Me.Lifetime.WriteXML("Lifetime", Writer)
        Me.Size.WriteXML("Size", Writer)
        Me.StartSizeRate.WriteXML("StartSizeRate", Writer)
        Me.BurstCount.WriteXML("BurstCount", Writer)
        Me.BurstDelay.WriteXML("BurstDelay", Writer)
        Me.InitialDelay.WriteXML("InitialDelay", Writer)
        'Alphas
        Writer.WriteStartElement("Alphas")
        For I As Integer = 1 To 8
            If I > 1 Then
                If Alphas(I).RelativeAge <> 0 Then
                    Alphas(I).WriteXML(I, Writer)
                End If
            Else
                Alphas(I).WriteXML(I, Writer)
            End If
        Next
        Writer.WriteEndElement()
        'Colors
        Writer.WriteStartElement("Colors")
        Writer.WriteAttributeString("UseHouseColor", Me.UseHouseColor.ToString)
        Writer.WriteAttributeString("HouseColorSaturation", Me.HouseColorSaturation)
        For I As Integer = 1 To 8
            If I > 1 Then
                If Colors(I).RelativeAge <> 0 Then
                    Colors(I).WriteXML(I, Writer)
                End If
            Else
                If Colors(I) <> ColorTime.Empty Then
                    Colors(I).WriteXML(I, Writer)
                End If
            End If
        Next
        Writer.WriteEndElement()
        'Physics
        Writer.WriteStartElement("Physics")
        Writer.WriteStartElement("Default")
        Writer.WriteAttributeString("Gravity", Me.Gravity)
        Writer.WriteAttributeString("Swirly", Me.Swirly.ToString)
        Writer.WriteAttributeString("ParticlesAttachToBone", Me.ParticlesAttachToBone.ToString)
        Me.VelocityDamping.WriteXML("VelocityDamping", Writer)
        Me.DriftVelocity.WriteXML("DriftVelocity", Writer)
        Writer.WriteEndElement()
        Writer.WriteEndElement()
        'Draw
        Writer.WriteStartElement("Draw")
        Select Case Type
            Case Types.DRAWABLE
                Writer.WriteStartElement("RenderObject")
                Writer.WriteAttributeString("MultiRenderObjects", Me.MultiRenderObjects.ToString)
                Writer.WriteAttributeString("SinkOnCollision", Me.SinkOnCollision.ToString)
                Writer.WriteAttributeString("SinkRate", Me.SinkRate)
                For I As Integer = 1 To 3
                    ObjectSets(I).WriteXML(Writer)
                Next
                Writer.WriteEndElement()
            Case Types.GPU_PARTICLE
                Writer.WriteStartElement("Gpu")
                Writer.WriteAttributeString("Shader", Me.GpuShader)
                Writer.WriteAttributeString("FramesPerRow", Me.FramesPerRow)
                Writer.WriteAttributeString("TotalFrames", Me.TotalFrames)
                Writer.WriteAttributeString("DetailTexture", Me.DetailTexture)
                Writer.WriteAttributeString("SpeedMultiplier", Me.SpeedMultiplier)
                Writer.WriteAttributeString("GeometryType", Me.GeometryType.ToString)
                Writer.WriteAttributeString("SoftParticles", Me.SoftParticles.ToString)
                Writer.WriteEndElement()
            Case Types.PARTICLE
                Writer.WriteStartElement("Default")
                Writer.WriteEndElement()
            Case Types.TRAIL
                Writer.WriteStartElement("Trail")
                Writer.WriteAttributeString("TrailLife", Me.TrailLife)
                Writer.WriteAttributeString("UTile", Me.UTile)
                Writer.WriteAttributeString("VTile", Me.VTile)
                Writer.WriteAttributeString("UScrollRate", Me.UScrollRate)
                Writer.WriteAttributeString("VScrollRate", Me.VScrollRate)
                Writer.WriteEndElement()
        End Select
        Writer.WriteEndElement()
        'Volume
        Writer.WriteStartElement("Volume")
        Select Case Volume
            Case Volumes.Box
                Writer.WriteStartElement("Box")
                Writer.WriteAttributeString("IsHollow", Me.IsHollow.ToString)
                Me.HalfSize.WriteXML("HalfSize", Writer)
                Writer.WriteEndElement()
            Case Volumes.Point
                Writer.WriteStartElement("Point")
                Writer.WriteAttributeString("IsHollow", Me.IsHollow.ToString)
                Writer.WriteEndElement()
            Case Volumes.Sphere
                Writer.WriteStartElement("Sphere")
                Writer.WriteAttributeString("IsHollow", Me.IsHollow.ToString)
                Writer.WriteAttributeString("Radius", Me.Radius)
                Writer.WriteEndElement()
            Case Volumes.Spline
                Writer.WriteStartElement("Spline")
                Writer.WriteAttributeString("IsHollow", Me.IsHollow.ToString)
                Me.StartPoint.WriteXML("StartPoint", Writer)
                Me.EndPoint.WriteXML("EndPoint", Writer)
                Writer.WriteEndElement()
            Case Volumes.Cylinder
                Writer.WriteStartElement("Cylinder")
                Writer.WriteAttributeString("IsHollow", Me.IsHollow.ToString)
                Writer.WriteAttributeString("Radius", Me.Radius)
                Writer.WriteAttributeString("RadiusRate", Me.RadiusRate)
                Writer.WriteAttributeString("Length", Me.Length)
                Me.Offset.WriteXML("Offset", Writer)
                Writer.WriteEndElement()
            Case Volumes.Line
                Writer.WriteStartElement("Line")
                Writer.WriteAttributeString("IsHollow", Me.IsHollow.ToString)
                Me.StartPoint.WriteXML("StartPoint", Writer)
                Me.EndPoint.WriteXML("EndPoint", Writer)
                Writer.WriteEndElement()
        End Select
        Writer.WriteEndElement()
        'Velocity
        Writer.WriteStartElement("Velocity")
        Select Case Velocity
            Case Velocities.Cylindrical
                Writer.WriteStartElement("Cylindrical")
                Me.Radial.WriteXML("Radial", Writer)
                Me.Normal.WriteXML("Normal", Writer)
                Writer.WriteEndElement()
            Case Velocities.Ortho
                Writer.WriteStartElement("Ortho")
                Writer.WriteStartElement("Position")
                Me.X.WriteXML("X", Writer)
                Me.Y.WriteXML("Y", Writer)
                Me.Z.WriteXML("Z", Writer)
                Writer.WriteEndElement()
                Writer.WriteEndElement()
            Case Velocities.Outward
                Writer.WriteStartElement("Outward")
                Me.Speed.WriteXML("Speed", Writer)
                Me.OtherSpeed.WriteXML("OtherSpeed", Writer)
                Writer.WriteEndElement()
            Case Velocities.Spherical
                Writer.WriteStartElement("Spherical")
                Me.Speed.WriteXML("Speed", Writer)
                Writer.WriteEndElement()
        End Select
        Writer.WriteEndElement()
        'Update
        Select Case Type
            Case Types.DRAWABLE
                Writer.WriteStartElement("RenderObject")
                Writer.WriteAttributeString("Rotation", Me.Rotation.ToString)
                Me.AngleZ.WriteXML("AngleZ", Writer)
                Me.AngularRateZ.WriteXML("AngularRateZ", Writer)
                Me.AngularDamping.WriteXML("AngularDamping", Writer)
                Writer.WriteStartElement("StartSize")
                Me.StartSizeX.WriteXML("x", Writer)
                Me.StartSizeY.WriteXML("y", Writer)
                Me.StartSizeZ.WriteXML("z", Writer)
                Writer.WriteEndElement()
                Writer.WriteStartElement("SizeRate")
                Me.SizeRateX.WriteXML("x", Writer)
                Me.SizeRateY.WriteXML("y", Writer)
                Me.SizeRateZ.WriteXML("z", Writer)
                Writer.WriteEndElement()
                Writer.WriteStartElement("SizeDamping")
                Me.SizeDampingX.WriteXML("x", Writer)
                Me.SizeDampingY.WriteXML("y", Writer)
                Me.SizeDampingZ.WriteXML("z", Writer)
                Writer.WriteEndElement()
                Writer.WriteEndElement()
            Case Else
                Writer.WriteStartElement("Default")
                Writer.WriteAttributeString("Rotation", Me.Rotation.ToString)
                Me.SizeRate.WriteXML("SizeRate", Writer)
                Me.SizeRateDamping.WriteXML("SizeRateDamping", Writer)
                Me.AngleZ.WriteXML("AngleZ", Writer)
                Me.AngularRateZ.WriteXML("AngularRateZ", Writer)
                Me.AngularDamping.WriteXML("AngularDamping", Writer)
                Me.AngleXY.WriteXML("AngleXY", Writer)
                Me.AngularRateXY.WriteXML("AngularRateXY", Writer)
                Me.AngularDampingXY.WriteXML("AngularDampingXY", Writer)
                Writer.WriteEndElement()
        End Select
        Writer.WriteEndElement()
    End Sub

End Class
Public Class FXParticle
    Public Life, Size, SizeRate, SizeRateDamping, VelocityDamping As Single
    Public AngleZ, AngularRateZ, AngularDamping As Single
    Public AngleXY, AngularRateXY, AngularDampingXY As Single
    Public Location As Vector = Vector.Empty
    Public Velocity As Vector = Vector.Empty
    Public Shade As Color = Color.Empty
    Public Delta, Theta As Single
    Public Sub New()
    End Sub
End Class
Public Class Scene
    Public Shared Event SceneRender()
    Public Shared Event SceneUpdate()
    Public Shared CameraLocation As Vector = Vector.Empty
    Public Shared CameraTheta, CameraOmega As Single
    Public Shared CameraMatrix As Matrix
    Public Shared Device As Device = Nothing
    Public Shared Active As Boolean = False
    Public Shared BackColor As Drawing.Color
    Public Shared Deltatime As Single = 0.0F
    Public Shared DesiredFrameRate As Single = 0.0F
    Public Shared Timer As GameTimer = Nothing
    Public Shared Time As Single = 0.0F
    Public Shared WithEvents Parent As Control = Nothing
    Public Shared Function Initialize() As Boolean
        Try
            Dim Settings As New PresentParameters
            Dim AdapterOrdinal As Integer = Direct3D.Manager.Adapters.Default.Adapter
            Dim Display As DisplayMode = Direct3D.Manager.Adapters(AdapterOrdinal).CurrentDisplayMode
            Settings.Windowed = False
            Settings.BackBufferFormat = Display.Format
            Settings.BackBufferWidth = Display.Width
            Settings.BackBufferHeight = Display.Height
            Settings.SwapEffect = SwapEffect.Discard
            Settings.AutoDepthStencilFormat = DepthFormat.D16
            Settings.EnableAutoDepthStencil = False
            Dim Flags As CreateFlags = CreateFlags.SoftwareVertexProcessing
            Dim Capabilities As Caps = Manager.GetDeviceCaps(AdapterOrdinal, DeviceType.Hardware)
            If Capabilities.DeviceCaps.SupportsHardwareTransformAndLight Then
                Flags = CreateFlags.HardwareVertexProcessing
            End If
            If Capabilities.DeviceCaps.SupportsPureDevice Then
                Flags = Flags Or CreateFlags.PureDevice
            End If
            Device = New Device(0, DeviceType.Hardware, Parent.Handle, Flags, Settings)
            AddHandler Device.DeviceReset, AddressOf OnResetDevice
            OnResetDevice(Device, Nothing)
        Catch ex As Direct3D.InvalidCallException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Timer = New GameTimer
            Timer.Start()
            Active = True
        End Try
        Return True
    End Function
    Public Shared Sub Update()
        If Active Then
            Deltatime = Timer.ElapsedTime
            Time += Deltatime
            If Time >= 1 / DesiredFrameRate Then
                Time -= 1 / DesiredFrameRate
                'Update Scene
                RaiseEvent SceneUpdate()
            End If
        End If
    End Sub
    Public Shared Sub Render()
        If Active Then
            'Render Scene
            Device.Clear(ClearFlags.Target Or ClearFlags.ZBuffer, BackColor, 1.0F, 0)
            Device.BeginScene()
            Device.Transform.View = CameraMatrix
            Device.Transform.Projection = Matrix.PerspectiveFovLH(Math.PI / 4, Parent.Width / Parent.Height, 1.0, 5000.0)
            Device.Transform.World = Matrix.Identity
            RaiseEvent SceneRender()
            Device.EndScene()
            Device.Present()
        End If
    End Sub
    Public Shared Sub Dispose()
        If Device IsNot Nothing Then
            Device.Dispose()
            Device = Nothing
        End If
    End Sub
    Private Shared Sub OnResetDevice(ByVal Sender As Object, ByVal E As EventArgs)

    End Sub
    Private Shared Sub PanCamera(ByVal FBSpeed As Double, ByVal RLSpeed As Double)
        Dim FBTheta As Double = CameraTheta + 90
        'Right Left
        CameraLocation.X += Cos(CameraOmega) * Cos(CameraTheta) * RLSpeed * 0.6
        CameraLocation.Y += Sin(CameraTheta) * RLSpeed * 0.6
        'Forward Backward
        CameraLocation.X -= Cos(CameraOmega) * Cos(FBTheta) * FBSpeed * 0.6
        CameraLocation.Y -= Sin(FBTheta) * FBSpeed * 0.6
        'Update Matrix
        CameraMatrix = Matrix.Translation(CameraLocation.Vector3) * Matrix.RotationZ(OmegaAngleToMath(CameraTheta)) * Matrix.RotationX(OmegaAngleToMath(CameraOmega))
    End Sub
    Private Shared Sub HeightCamera(ByVal UDSpeed As Double, ByVal RLSpeed As Double)
        CameraLocation.Z += UDSpeed * 0.6
        CameraLocation.X += Cos(CameraOmega) * Cos(CameraTheta) * RLSpeed * 0.6
        CameraLocation.Y += Sin(CameraTheta) * RLSpeed * 0.9
        'Update Matrix
        CameraMatrix = Matrix.Translation(CameraLocation.Vector3) * Matrix.RotationZ(OmegaAngleToMath(CameraTheta)) * Matrix.RotationX(OmegaAngleToMath(CameraOmega))
    End Sub
    Private Shared Sub AdjustCamera(ByVal XOffset As Double, ByVal YOffset As Double)
        CameraTheta -= XOffset / 10
        CameraOmega -= YOffset / 10
        'Update Matrix
        CameraMatrix = Matrix.Translation(CameraLocation.Vector3) * Matrix.RotationZ(OmegaAngleToMath(CameraTheta)) * Matrix.RotationX(OmegaAngleToMath(CameraOmega))
    End Sub
    Private Shared Sub Parent_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Parent.MouseMove
        Static Oldy As Double
        Static Oldx As Double
        If Oldy <> 0 And Oldx <> 0 Then
            Select Case e.Button
                Case Windows.Forms.MouseButtons.Left
                    AdjustCamera(e.X - Oldx, e.Y - Oldy)
                Case Windows.Forms.MouseButtons.Right
                    PanCamera(e.Y - Oldy, e.X - Oldx)
                Case Windows.Forms.MouseButtons.Middle
                    HeightCamera(e.Y - Oldy, e.X - Oldx)
            End Select
        End If
        Oldy = e.Y
        Oldx = e.X
    End Sub
End Class
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

    ''' <summary> Initializes GameTimer </summary>
    Public Sub New()
        TimerInitialized = True
        UsingQPF = QueryPerformanceFrequency(TicksPerSecond)
        If UsingQPF Then
            TicksPerSecond = TicksPerSecond
        Else
            Throw New Exception("Timer Init Failure -- No QueryPerformanceCounter")
        End If
    End Sub
    ''' <summary> Resets the time to 0 </summary>
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
        StopTime += CLng(TicksPerSecond / 10)
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

End Class
Public Class TextureNode
    Public Event ReactivateTexture(ByVal Sender As TextureNode)
    Public Event TextureDoesntExist(ByVal Sender As TextureNode)
    Public Texture As Texture
    Public Name As String
    Public TransparentColor As Drawing.Color
    Public SourcePath As String
    Public SelfUnloading As Boolean
    Public LifeTime As Single
    Public CurrentFrame As Single
    Public Alive As Boolean
    Public Size As Drawing.Size
    Public Sub New(ByVal Texture As Texture, ByVal Name As String, ByVal TransparentColor As Drawing.Color, ByVal SourcePath As String)
        If Texture IsNot Nothing Then
            Me.Alive = True
            Me.Texture = Texture
            Me.Name = Name
            Me.TransparentColor = TransparentColor
            Me.SourcePath = SourcePath
            Me.Size = New Drawing.Size
            Me.Size.Width = Texture.GetLevelDescription(0).Width
            Me.Size.Height = Texture.GetLevelDescription(0).Height
        Else
            Me.Alive = False
            RaiseEvent TextureDoesntExist(Me)
        End If
    End Sub
    Public Sub Update()
        If SelfUnloading Then
            CurrentFrame += 1
            If CurrentFrame >= LifeTime Then
                Alive = False
                Texture.Dispose()
                Texture = Nothing
            End If
        End If
    End Sub
    Public Sub ReActivate(ByVal Device As Device)
        Texture = TextureLoader.FromFile(Device, SourcePath, 0, 0, 1, Usage.None, Format.A8R8G8B8, Pool.Managed, Filter.None, Filter.None, TransparentColor.ToArgb)
    End Sub
    Public ReadOnly Property GetTexture() As Texture
        Get
            If Not Alive Then
                RaiseEvent ReactivateTexture(Me)
            End If
            If SelfUnloading Then
                CurrentFrame = 0
            End If
            Return Texture
        End Get
    End Property
    Public WriteOnly Property SetSelfUnloading(Optional ByVal LifeTime As Integer = -1) As Boolean
        Set(ByVal value As Boolean)
            SelfUnloading = value
            If SelfUnloading Then
                If LifeTime <> -1 Then
                    Me.LifeTime = LifeTime
                End If
            End If
        End Set
    End Property
End Class
Public Class TextureLibrary
    Public Shared Sub Add(ByVal FilePath As String, ByVal ReferenceName As String, ByVal TransparentColor As Drawing.Color)
        Dim Node As TextureNode
        Try
            If IO.File.Exists(FilePath) Then
                For I As Integer = 0 To _Textures.Count - 1
                    If _Textures(I).Name = ReferenceName Then
                        Errors.Add(ErrorSeverity.Warning, "TextureLibrary", "Texture with name " & ReferenceName & " already exists", "Name texture something different")
                    End If
                Next
                Node = New TextureNode( _
                    TextureLoader.FromFile(Scene.Device, FilePath, 0, 0, 1, Usage.None, Format.A8R8G8B8, Pool.Managed, Filter.None, Filter.None, TransparentColor.ToArgb), _
                    ReferenceName, TransparentColor, FilePath)
                AddHandler Node.ReactivateTexture, AddressOf ReactivateTexture
                _Textures.Add(Node)
                _LastTexture += 1
            Else
                Errors.Add(ErrorSeverity.Critical, "TextureLibrary", "Texture file " & FilePath & " doesn't exist", "Check spelling on filepath or if file even exists")
            End If
        Catch ex As Exception
            Errors.Add(ErrorSeverity.Critical, "TextureLibrary", "Error adding " & ReferenceName & " at filepath " & FilePath, "Check image type or if valid image file")
        End Try
    End Sub
    Public Shared Sub Dispose()
        Dispose(True)
    End Sub
    Public Shared Function TextureIndex(ByVal Name As String) As Integer
        For I As Integer = 0 To _Textures.Count - 1
            If _Textures(I).Name = Name Then
                Return I
            End If
        Next
        Return -1
    End Function
    Public Shared Function Texture(ByVal Index As Integer) As Texture
        Return _Textures(Index).GetTexture
    End Function
    Public Shared Function Texture(ByVal Name As String) As Texture
        For I As Integer = 0 To _Textures.Count - 1
            If _Textures(I).Name = Name Then
                Return _Textures(I).GetTexture
            End If
        Next
        Return Nothing
    End Function
    Public Shared Sub Update(ByVal Deltatime As Single)
        For I As Integer = 0 To _Textures.Count - 1
            _Textures(I).Update()
        Next
    End Sub
    Public Shared Sub ReactivateTexture(ByVal Sender As TextureNode)
        Sender.ReActivate(Scene.Device)
    End Sub
    Public Shared Function Last() As Texture
        If (_LastTexture <> 0) Then Return _Textures(_LastTexture).Texture Else Return Nothing
    End Function
    Private Shared Sub Dispose(ByVal Disposing As Boolean)
        If Not _Disposed Then
            If Disposing Then
                For I As Integer = 0 To _Textures.Count - 1
                    _Textures(I).Texture.Dispose()
                    _Textures(I) = Nothing
                Next
            End If
        End If
        _Disposed = True
    End Sub
    Public Shared Property Nodes() As List(Of TextureNode)
        Get
            Return _Textures
        End Get
        Set(ByVal value As List(Of TextureNode))
            _Textures = value
        End Set
    End Property

    Private Shared _Textures As New List(Of TextureNode)
    Private Shared _LastTexture As Integer = -1
    Private Shared _Scene As Scene
    Private Shared _Disposed As Boolean = False

End Class
Public Class GameError
    Public SourceClass As String
    Public Description As String
    Public Suggestion As String
    Public Severity As ErrorSeverity
    Public Occurence As Long
    Public Sub New(ByVal Severity As ErrorSeverity, ByVal SourceClass As String, ByVal Description As String, ByVal Suggestion As String)
        Severity = Severity
        SourceClass = SourceClass
        Description = Description
        Suggestion = Suggestion
    End Sub
End Class
Public Class Errors
    Public Shared Event CriticalError(ByVal E As GameError)
    Public Shared Event WarningError(ByVal E As GameError)
    Public Shared Frame As Long
    Public Shared Notices As Integer
    Public Shared Errors As New List(Of GameError)
    Public Shared Sub Add(ByVal E As GameError)
        E.Occurence = Frame
        Errors.Add(E)
        Select Case E.Severity
            Case ErrorSeverity.Critical
                RaiseEvent CriticalError(E)
                Scene.Active = False
                Dim frm As New frmError(E)
                If frm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Scene.Dispose()
                End If
            Case ErrorSeverity.Notice
                Notices += 1
            Case ErrorSeverity.Warning
                RaiseEvent WarningError(E)
                Scene.Active = False
                Dim frm As New frmError(E)
                If frm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    Scene.Dispose()
                End If
        End Select
    End Sub
    Public Shared Sub Add(ByVal Severity As ErrorSeverity, ByVal SourceClass As String, ByVal Description As String, ByVal Suggestion As String)
        Add(New GameError(Severity, SourceClass, Description, Suggestion))
    End Sub
    Public Shared Sub Update()
        Frame += 1
    End Sub
    Public Shared Sub WriteErrors(ByVal Filepath As String)
        Dim SW As New IO.StreamWriter(Filepath)
        SW.WriteLine("Omega Game Engine Error File")
        SW.WriteLine("Statistics:")
        SW.WriteLine("Total Notices = " & Notices)
        SW.WriteLine("File Write Frame = " & Frame & "s")
        For Each E As GameError In Errors
            SW.WriteLine("New Error: " & E.Occurence & "s")
            SW.WriteLine("Severity: " & E.Severity.ToString)
            SW.WriteLine("SourceClass: " & E.SourceClass)
            SW.WriteLine("Description: " & E.Description)
            SW.WriteLine("Suggestion: " & E.Suggestion)
        Next
    End Sub
End Class
Public Class Floor
    Public Const Tiles As Integer = 100
    Public Shared Texture As Integer = -1
    Private Shared IndexBuffer As IndexBuffer
    Private Shared VertexBuffer As VertexBuffer
    Public Shared Sub Initialize()
        Try
            VertexBuffer = CreateVertexBuffer(Scene.Device)
        Catch
            'GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Warning, GetType(Floor), "Couldnt Initialize Floor VertexBuffer")
        End Try
        Try
            IndexBuffer = CreateIndexBuffer(Scene.Device)
        Catch
            'GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Warning, GetType(Floor), "Couldnt Initialize Floor IndexBuffer")
        End Try
    End Sub
    Private Shared Function CreateVertexBuffer(ByVal Device As Device) As VertexBuffer
        Dim Buffer As New VertexBuffer(GetType(CustomVertex.PositionTextured), Tiles * 4, Device, 0, CustomVertex.PositionTextured.Format, Pool.Default)
        Dim Vertices As CustomVertex.PositionTextured()
        Vertices = Buffer.Lock(0, 0)
        Dim Current As Integer = 0
        For Y As Integer = -5 To 4
            For X As Integer = -5 To 4
                Vertices(Current) = New CustomVertex.PositionTextured(X * 25.6, Y * 25.6, 0, 0, 0)
                Vertices(Current + 1) = New CustomVertex.PositionTextured(X * 25.6 + 25.6, Y * 25.6, 0, 1, 0)
                Vertices(Current + 2) = New CustomVertex.PositionTextured(X * 25.6 + 25.6, Y * 25.6 + 25.6, 0, 1, 1)
                Vertices(Current + 3) = New CustomVertex.PositionTextured(X * 25.6, Y * 25.6 + 25.6, 0, 0, 1)
                Current += 4
            Next
        Next
        Buffer.Unlock()
        Buffer.SetData(Vertices, 0, LockFlags.Discard)
        Return Buffer
    End Function
    Private Shared Function CreateIndexBuffer(ByVal Device As Device) As IndexBuffer
        Dim Buffer As New IndexBuffer(GetType(Short), Tiles * 6, Device, 0, Pool.Default)
        Dim Indices() As Short = Buffer.Lock(0, 0)
        For I As Integer = 0 To Tiles - 1
            Indices(I * 6) = I * 4
            Indices(I * 6 + 1) = I * 4 + 1
            Indices(I * 6 + 2) = I * 4 + 3
            Indices(I * 6 + 3) = I * 4 + 1
            Indices(I * 6 + 4) = I * 4 + 2
            Indices(I * 6 + 5) = I * 4 + 3
        Next
        Buffer.Unlock()
        Buffer.SetData(Indices, 0, LockFlags.Discard)
        Return Buffer
    End Function
    Public Shared Sub Render()
        With Scene.Device
            Try
                .RenderState.CullMode = Cull.None
                .RenderState.Lighting = False
                .RenderState.ZBufferEnable = True
                .RenderState.FillMode = FillMode.Solid
                .RenderState.Clipping = True
                .VertexFormat = CustomVertex.PositionTextured.Format
                .SetTexture(0, TextureLibrary.Texture(Texture))
                .SetStreamSource(0, VertexBuffer, 0)
                .Indices = IndexBuffer
                .DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, Tiles * 4, 0, Tiles * 2)
            Catch
                'GameError.Raise(GameError.ErrorType.ErrorRendering, GameError.ErrorSeverity.Warning, GetType(Floor), "Error Rendering Floor")
            End Try
        End With
    End Sub
End Class
Public Class Font
    Public Name As String = String.Empty
    Public Texture As Integer
    Public Chars(255) As Single
    Public OriginalSize As Single = 0.0F
    Public FrameWidth As Single = 0.0F
    Public FrameHeight As Single = 0.0F
    Public SpaceWidth As Single = 0.0F
    Public XSpaceScale As Single = 0.0F
    Public YSpaceScale As Single = 0.0F
    Public Scale As Drawing.Point = New Drawing.Point(1.0F, 1.0F)
    Public Sub New(ByVal Name As String, ByVal Texture As Integer, ByVal SpaceWidth As Single, ByVal XScaling As Single, ByVal YScaling As Single)
        Me.Name = Name
        Me.Texture = Texture
        Me.SpaceWidth = SpaceWidth
        Me.XSpaceScale = XScaling
        Me.YSpaceScale = YScaling
    End Sub
    Public Sub FromFile(ByVal FilePath As String)
        Dim Sr As IO.StreamReader = IO.File.OpenText(FilePath)
        OriginalSize = CSng(Sr.ReadLine())
        FrameWidth = CSng(Sr.ReadLine())
        FrameHeight = CSng(Sr.ReadLine())
        For I As Integer = 0 To 255
            Chars(I) = CSng(Sr.ReadLine)
        Next
        Sr.Close()
    End Sub
    Public Function FontHeight(ByVal TextSize As Single) As Single
        Return (TextSize / OriginalSize) * FrameHeight
    End Function
    Public Function CharWidth(ByVal C As Char) As Single
        Return Chars(Asc(C))
    End Function
    Public Function Source(ByVal C As Char) As Drawing.Rectangle
        Dim Y As Single = CSng(Int(Asc(C) / 16))
        Dim X As Single = Asc(C) - (Y * 16)
        Return New System.Drawing.Rectangle(CInt(X * FrameWidth), CInt(Y * FrameHeight), CInt(CharWidth(C) + 4), CInt(FrameHeight - 1))
    End Function
End Class
Public Class TextManager
    Public Rendering As Boolean = False
    Private Sprite As Microsoft.DirectX.Direct3D.Sprite
    Public Sub New()
        Sprite = New Microsoft.DirectX.Direct3D.Sprite(Scene.Device)
    End Sub
    Public Sub Begin()
        If Sprite IsNot Nothing Then
            Sprite.Begin(SpriteFlags.AlphaBlend Or SpriteFlags.SortTexture)
            Rendering = True
        End If
    End Sub
    Public Sub Draw(ByVal Text As String, ByVal Font As Font, ByVal Size As Single, ByVal ForeColor As Drawing.Color, ByVal X As Single, ByVal Y As Single)
        If Text = "" Then Return
        If Font Is Nothing Then Return
        Dim Scale As Single = Size / Font.OriginalSize
        Dim Column, Row As Single
        Dim ARGB As Integer = ForeColor.ToArgb
        Column = -Font.CharWidth(Text(0)) * Font.XSpaceScale * Scale
        For I As Integer = 0 To Text.Length - 1
            Column += Font.CharWidth(Text(CInt(IIf(I = 0, 0, I - 1)))) * Font.XSpaceScale * Scale
            If Text(I) = vbCrLf(0) Then
                Row += Font.FrameHeight * Font.YSpaceScale * Scale
                Column = -Font.CharWidth(Text(I)) * Font.XSpaceScale * Scale
            Else
                If Text(I) = " " Then
                    Column += Font.SpaceWidth * Scale
                Else
                    Sprite.Transform = Microsoft.DirectX.Matrix.Scaling(CSng(Font.CharWidth(Text(I)) / Font.Source(Text(I)).Width * Scale * Font.Scale.X), CSng(Font.FrameHeight / Font.Source(Text(I)).Height * Scale * Font.Scale.Y), 1.0F) * _
                     Microsoft.DirectX.Matrix.Translation(CSng(X + Column), CSng(Y + Row), 0.0F)
                    Sprite.Draw(TextureLibrary.Texture(Font.Texture), Font.Source(Text(I)), Vector3.Empty, Vector3.Empty, ARGB)
                End If
            End If
        Next
    End Sub
    Public Sub Draw(ByVal Text As String, ByVal Font As Font, ByVal Size As Single, ByVal ForeColor As Drawing.Color, ByVal Location As Vector)
        Draw(Text, Font, Size, ForeColor, Location.X, Location.Y)
    End Sub
    Public Sub [End]()
        If Sprite IsNot Nothing Then
            Sprite.End()
            Rendering = False
        End If
    End Sub
End Class
Public Module Geometry
    Public Function Distance(ByVal X1 As Single, ByVal Y1 As Single, ByVal X2 As Single, ByVal Y2 As Single) As Single
        Return CSng(System.Math.Sqrt((X1 - X2) ^ 2 + (Y1 - Y2) ^ 2))
    End Function
    Public Function Distance(ByVal V1 As Vector, ByVal V2 As Vector) As Single
        Return CSng(System.Math.Sqrt((V1.X - V2.X) ^ 2 + (V1.Y - V2.Y) ^ 2))
    End Function
    Public Function DistanceSquared(ByVal X1 As Single, ByVal X2 As Single, ByVal Y1 As Single, ByVal Y2 As Single) As Single
        Return CSng((X1 - X2) ^ 2 + (Y1 - Y2) ^ 2)
    End Function
    Public Function DistanceSquared(ByVal V1 As Vector, ByVal V2 As Vector) As Single
        Return CSng((V1.X - V2.X) ^ 2 + (V1.Y - V2.Y) ^ 2)
    End Function
    Public Function OmegaAngleToMath(ByVal Angle As Single) As Single
        Return CSng(System.Math.Atan2(Geometry.Sin(Angle), Geometry.Cos(Angle)))
    End Function
    Public Function DegreeToRadian(ByVal A As Single) As Single
        Return CSng(A * System.Math.PI / 180)
    End Function
    Public Function RadianToDegree(ByVal A As Single) As Single
        Return CSng(A * 180 / System.Math.PI)
    End Function
    Public Function Cos(ByVal Degree As Single) As Single
        Return CSng(System.Math.Cos(DegreeToRadian(Degree)))
    End Function
    Public Function Sin(ByVal Degree As Single) As Single
        Return -CSng(System.Math.Sin(DegreeToRadian(Degree)))
    End Function
    Public Function Tan(ByVal Angle As Single) As Single
        Return CSng(System.Math.Tan(DegreeToRadian(Angle)))
    End Function
    Public Function Sec(ByVal Angle As Single) As Single
        Return CSng(System.Math.Acos(DegreeToRadian(Angle)))
    End Function
    Public Function Csc(ByVal Angle As Single) As Single
        Return CSng(System.Math.Asin(DegreeToRadian(Angle)))
    End Function
    Public Function Cot(ByVal Angle As Single) As Single
        Return CSng(System.Math.Atan(DegreeToRadian(Angle)))
    End Function
    Public Function InvCos(ByVal Angle As Single) As Single
        Return CSng(1.0F / System.Math.Cos(DegreeToRadian(Angle)))
    End Function
    Public Function InvSin(ByVal Angle As Single) As Single
        Return CSng(1.0F / System.Math.Sin(DegreeToRadian(Angle)))
    End Function
    Public Function InvTan(ByVal Angle As Single) As Single
        Return CSng(1.0F / System.Math.Tan(DegreeToRadian(Angle)))
    End Function
    Public Function InvSec(ByVal Angle As Single) As Single
        Return CSng(1.0F / System.Math.Acos(DegreeToRadian(Angle)))
    End Function
    Public Function InvCsc(ByVal Angle As Single) As Single
        Return CSng(1.0F / System.Math.Asin(DegreeToRadian(Angle)))
    End Function
    Public Function InvCot(ByVal Angle As Single) As Single
        Return CSng(1.0F / System.Math.Atan(DegreeToRadian(Angle)))
    End Function
    Public Function Abs(ByVal Value As Single) As Single
        Return Math.Abs(Value)
    End Function
End Module
