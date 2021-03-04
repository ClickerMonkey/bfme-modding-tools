Imports System
Imports Microsoft.DirectX.Direct3D
Public Class Floor
    Public Const Tiles As Integer = 100
    Public Shared Texture As String
    Private Shared IndexBuffer As IndexBuffer
    Private Shared VertexBuffer As VertexBuffer
    Public Shared Sub Initialize()
        Try : VertexBuffer = CreateVertexBuffer(Scene.LocalDevice)
        Catch
            GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Warning, GetType(Floor), "Couldnt Initialize Floor VertexBuffer")
        End Try
        Try : IndexBuffer = CreateIndexBuffer(Scene.LocalDevice)
        Catch
            GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Warning, GetType(Floor), "Couldnt Initialize Floor IndexBuffer")
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
        With Scene.LocalDevice
            Try
                .RenderState.CullMode = Cull.None
                .RenderState.Lighting = False
                .RenderState.ZBufferEnable = True
                .RenderState.FillMode = FillMode.Solid
                .RenderState.Clipping = True
                .VertexFormat = CustomVertex.PositionTextured.Format
                .SetTexture(0, TextureManager.Texture(Texture))
                .SetStreamSource(0, VertexBuffer, 0)
                .Indices = IndexBuffer
                .DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, Tiles * 4, 0, Tiles * 2)
            Catch
                GameError.Raise(GameError.ErrorType.ErrorRendering, GameError.ErrorSeverity.Warning, GetType(Floor), "Error Rendering Floor")
            End Try
        End With
    End Sub
End Class
