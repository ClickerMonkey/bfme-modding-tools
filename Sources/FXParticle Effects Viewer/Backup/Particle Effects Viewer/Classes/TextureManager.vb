Imports System.Math
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
'//TextureManager
Public Class TextureManager
    Private Structure TextureStruct
        Public Texture As Texture
        Public Name As String
    End Structure
    Private Shared Device As Device
    Private Shared Textures As ArrayList
    Private Shared LastTexture As String
    ''' <summary> Calls on new class to handle the game textures </summary>
    Public Sub New()
        Device = Scene.LocalDevice
        Textures = New ArrayList
    End Sub
    ''' <summary> Initializes the public class for handling game textures </summary>
    Public Shared Sub Initialize()
        Device = Scene.LocalDevice
        Textures = New ArrayList
    End Sub
    ''' <summary> Adds a texture to the List of game textures </summary>
    ''' <param name="FilePath"> Complete filepath as string of texture (including extension) </param>
    ''' <param name="ReferenceName"> The name to use when getting a texture </param>
    ''' <param name="TransparentColor"> The transparent color </param>
    ''' <remarks></remarks>
    Public Shared Sub Add(ByVal FilePath As String, ByVal ReferenceName As String, ByVal TransparentColor As System.Drawing.Color, ByVal Width As Double, ByVal Height As Double)
        Dim TL As New TextureStruct
        Try
            If IO.File.Exists(FilePath) Then
                TL.Texture = TextureLoader.FromFile(Device, FilePath, Width, Height, 0, Usage.SoftwareProcessing, Format.A8B8G8R8, Pool.Managed, Filter.Point, Filter.Point, TransparentColor.ToArgb)
                TL.Name = ReferenceName
                LastTexture = ReferenceName
                Textures.Add(TL)
            Else
                GameError.Raise(GameError.ErrorType.TextureNotFound, GameError.ErrorSeverity.Notice, GetType(TextureManager), "Texture " & ReferenceName & " at " & FilePath & " with Size (" & Width & "," & Height & ") was not Found!")
            End If
        Catch ex As Exception
            GameError.Raise(GameError.ErrorType.TextureNotAdded, GameError.ErrorSeverity.Notice, GetType(TextureManager), "Error Adding Texture " & ReferenceName & " at " & FilePath & " with Size (" & Width & "," & Height & ")" & vbCrLf & "More Info: " & ex.Message)
        End Try
    End Sub
    ''' <summary> Used when closing application, Disposes all the textures </summary>
    Public Shared Sub Dispose()
        For Each TL As TextureStruct In Textures
            TL.Texture.Dispose()
        Next
    End Sub
    ''' <summary> Returns the texture that is stored under the specific name </summary>
    ''' <param name="Name"> Reference name that AddTexture called </param>
    Public Shared Function Texture(ByVal Name As String) As Texture
        For Each T As TextureStruct In Textures
            If T.Name = Name Then
                Return T.Texture
            End If
        Next
        GameError.Raise(GameError.ErrorType.TextureNotFound, GameError.ErrorSeverity.Notice, GetType(TextureManager), "Couldnt find " & Name & " in TextureManager anywhere!")
        Return Nothing
    End Function
    ''' <summary>
    ''' Returns last uploaded texture
    ''' </summary>
    Public Shared Function Last() As Texture
        If (LastTexture <> "") Then Return Texture(LastTexture) Else Return Nothing
    End Function
End Class