Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D

Public Class Arrow
    Public Property LineColor() As Color
        Get
            Return Color.FromArgb(tLineColor)
        End Get
        Set(ByVal value As Color)
            tLineColor = value.ToArgb
            ResetIndexBuffer()
        End Set
    End Property
    Public Property Scale()
        Get
            Return tScale
        End Get
        Set(ByVal value)
            tScale = value
        End Set
    End Property
    Public Property Location() As Vector3
        Get
            Return tLocation
        End Get
        Set(ByVal value As Vector3)
            tLocation = New Vector3(value.X, value.Z, value.Y)
        End Set
    End Property
    Public Property RotationX() As Double
        Get
            Return tRotation.X * 180 / Math.PI
        End Get
        Set(ByVal value As Double)
            tRotation.X = value * Math.PI / 180
        End Set
    End Property
    Public Property RotationY() As Double
        Get
            Return tRotation.Y * 180 / Math.PI
        End Get
        Set(ByVal value As Double)
            tRotation.Y = value * Math.PI / 180
        End Set
    End Property
    Public Property RotationZ() As Double
        Get
            Return tRotation.Z * 180 / Math.PI
        End Get
        Set(ByVal value As Double)
            tRotation.Z = value * Math.PI / 180
        End Set
    End Property

    Public Sub New(ByVal LineColor As Color, ByVal Scale As Double)
        tLineColor = LineColor.ToArgb
        tScale = Scale
        VertexBuffer = New VertexBuffer(GetType(CustomVertex.PositionColored), 14, Scene.LocalDevice, Usage.Points, CustomVertex.PositionColored.Format, Pool.Default)
        IndexBuffer = New IndexBuffer(GetType(Short), 40, Scene.LocalDevice, Usage.Points, Pool.Default)
        ResetVertexBuffer()
        ResetIndexBuffer()
    End Sub
    Public Sub ResetPoints()
        '//Points
        tPoints(0) = New Vector3(0, 0, 0)
        tPoints(1) = New Vector3(3, 8, 3)
        tPoints(2) = New Vector3(3, 8, -3)
        tPoints(3) = New Vector3(-3, 8, -3)
        tPoints(4) = New Vector3(-3, 8, 3)
        tPoints(5) = New Vector3(3, 25, 3)
        tPoints(6) = New Vector3(3, 25, -3)
        tPoints(7) = New Vector3(-3, 25, -3)
        tPoints(8) = New Vector3(-3, 25, 3)
        tPoints(9) = New Vector3(5, 25, 5)
        tPoints(10) = New Vector3(5, 25, -5)
        tPoints(11) = New Vector3(-5, 25, -5)
        tPoints(12) = New Vector3(-5, 25, 5)
        tPoints(13) = New Vector3(0, 32, 0)
        '//Vertices
        For t As Integer = 0 To 13
            Vertices(t) = New CustomVertex.PositionColored(tPoints(t), tLineColor)
        Next
    End Sub
    Public Sub ResetVertexBuffer()
        Vertices = VertexBuffer.Lock(0, LockFlags.Discard)
        ResetPoints()
        VertexBuffer.Unlock()
        VertexBuffer.SetData(Vertices, 0, LockFlags.Discard)
    End Sub
    Public Sub ResetIndexBuffer()
        Dim Indices(39) As Short
        Indices = IndexBuffer.Lock(0, LockFlags.Discard)
        Indices(0) = 0 '
        Indices(1) = 1
        Indices(2) = 0 '
        Indices(3) = 2
        Indices(4) = 0 '
        Indices(5) = 3
        Indices(6) = 0 '
        Indices(7) = 4
        Indices(8) = 1 '
        Indices(9) = 5
        Indices(10) = 2 '
        Indices(11) = 6
        Indices(12) = 3 '
        Indices(13) = 7
        Indices(14) = 4 '
        Indices(15) = 8
        Indices(16) = 5 '
        Indices(17) = 6
        Indices(18) = 6 '
        Indices(19) = 7
        Indices(20) = 7 '
        Indices(21) = 8
        Indices(22) = 8 '
        Indices(23) = 5
        Indices(24) = 9 '
        Indices(25) = 10
        Indices(26) = 10 '
        Indices(27) = 11
        Indices(28) = 11 '
        Indices(29) = 12
        Indices(30) = 12 '
        Indices(31) = 9
        Indices(32) = 9 '
        Indices(33) = 13
        Indices(34) = 10 '
        Indices(35) = 13
        Indices(36) = 11 '
        Indices(37) = 13
        Indices(38) = 12 '
        Indices(39) = 13
        IndexBuffer.Unlock()
        IndexBuffer.SetData(Indices, 0, LockFlags.Discard)
    End Sub
    Public Sub SetRotationMatrix(ByVal M As Matrix)
        tMatrix = M
    End Sub
    Public Sub Render()
        With Scene.LocalDevice
            '//Rotate, Scale, Translate
            .Transform.World = Matrix.RotationYawPitchRoll(tRotation.X, tRotation.Y, tRotation.Z) * tMatrix * Matrix.Scaling(tScale, tScale, tScale) * Matrix.Translation(tLocation)
            .VertexFormat = CustomVertex.PositionColored.Format
            .SetTexture(0, Nothing)
            .Indices = IndexBuffer
            .SetStreamSource(0, VertexBuffer, 0)
            .DrawIndexedPrimitives(PrimitiveType.LineList, 0, 0, 14, 0, 20)
            .Transform.World = Matrix.Identity
        End With
    End Sub

    Private IndexBuffer As IndexBuffer
    Private VertexBuffer As VertexBuffer
    Private Vertices(13) As CustomVertex.PositionColored
    Private tPoints(13) As Vector3
    Private tRotation As Vector3
    Private tMatrix As Matrix = Matrix.Identity
    Private tLocation As Vector3
    Private tScale As Double
    Private tLineColor As Integer
End Class
