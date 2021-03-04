Imports System.Math
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
'//FontManager
Public Class FontManager
    Private Structure FontStruct
        Public Name As String
        Public Texture As String
        Public Sizes() As Double
        Public FrameWidth, FrameHeight As Integer
        Public XSpacing, YSpacing, SpaceWidth, FontSize As Double
    End Structure
    Private Structure AppearingStruct
        Public Name, Text, Texture As String
        Public Location, Positions() As Vector3
        Public SourceRects() As Rectangle
        Public CurrentLetter As Integer
        Public Time, Scale, Speed As Double
        Public ForeColor As Drawing.Color
    End Structure
    Private Shared FontSprite As Sprite
    Private Shared Fonts As ArrayList
    Private Shared Appearings As ArrayList
    Private Shared Scale As Double
    Public Sub New()
        Try
            FontSprite = New Sprite(Scene.LocalDevice)
            Fonts = New ArrayList
            Appearings = New ArrayList
        Catch
            GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Warning, GetType(FontManager), "Couldnt Start Font Class")
        End Try
    End Sub
    Public Shared Sub Initialize()
        Try
            FontSprite = New Sprite(Scene.LocalDevice)
            Fonts = New ArrayList
            Appearings = New ArrayList
        Catch
            GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Warning, GetType(FontManager), "Couldnt Start Font Class")
        End Try
    End Sub
    Public Shared Sub Add(ByVal FontName As String, ByVal FontTexture As String, ByVal FontFilePath As String, ByVal SpaceWidth As Double, ByVal XSpacing As Double, ByVal YSpacing As Double)
        If Not (Fonts Is Nothing) Then
            If IO.File.Exists(FontFilePath) Then
                Dim NameUsed As Boolean
                For Each Ft As FontStruct In Fonts
                    If Ft.Name = FontName Then
                        NameUsed = True
                    End If
                Next
                If Not NameUsed Then
                    Dim NewFont As FontStruct
                    NewFont = LoadSizesFromFile(FontFilePath)
                    NewFont.Name = FontName
                    NewFont.Texture = FontTexture
                    NewFont.SpaceWidth = SpaceWidth
                    NewFont.XSpacing = XSpacing
                    NewFont.YSpacing = YSpacing
                    Fonts.Add(NewFont)
                Else
                    GameError.Raise(GameError.ErrorType.NameAlreadyExists, GameError.ErrorSeverity.Notice, GetType(FontManager), "Name of Font already Exists")
                End If
            Else
                GameError.Raise(GameError.ErrorType.FileDoesntExist, GameError.ErrorSeverity.Notice, GetType(FontManager), "FontFile doesnt exist")
            End If
        End If
    End Sub
    Public Shared Sub Remove(ByVal Name As String)
        If Not (Fonts Is Nothing) Then
            For Each Font As FontStruct In Fonts
                If Font.Name = Name Then
                    Fonts.Remove(Font)
                    Return
                End If
            Next
        End If
    End Sub
    Public Shared Sub Render(ByVal FontName As String, ByVal Text As String, ByVal Size As Double, ByVal X As Double, ByVal Y As Double, ByVal ForeColor As Drawing.Color)
        If Text = "" Then Return
        Try
            Dim Ft As FontStruct = GetFont(FontName)
            Scale = Size / Ft.FontSize
            Dim DrawingPosition As New Vector3(X / Scale, Y / Scale, 0)
            Dim Column, Row As Double
            FontSprite.Begin(SpriteFlags.AlphaBlend)
            FontSprite.Transform = Matrix.Scaling(Scale, Scale, 1.0F)
            Column = -(GetSize(Text(0), Ft) * Ft.XSpacing)
            For I As Integer = 0 To Text.Length - 1
                Column += (GetSize(Text(IIf(I = 0, 0, I - 1)), Ft) * Ft.XSpacing)
                If Text(I) = vbCrLf(0) Then
                    Row += (Ft.FrameHeight * Ft.YSpacing)
                    Column = -(GetSize(Text(I), Ft) * Ft.XSpacing)
                ElseIf Text(I) = " " Then
                    Column += Ft.SpaceWidth * Scale
                Else
                    FontSprite.Draw(TextureManager.Texture(Ft.Texture), GetLetter(Text(I), Ft), Vector3.Empty, New Vector3(DrawingPosition.X + Column, DrawingPosition.Y + Row, 0), ForeColor.ToArgb)
                End If
            Next
            FontSprite.End()
        Catch
            GameError.Raise(GameError.ErrorType.ErrorDrawingFont, GameError.ErrorSeverity.Notice, GetType(FontManager), "Couldnt Render Font")
        End Try
    End Sub
    Public Shared Function StringHeight(ByVal Font As String, ByVal FontSize As Double) As Double
        Dim Ft As FontStruct = GetFont(Font)
        Return (FontSize / Ft.FontSize) * Ft.FrameHeight
    End Function
    Public Shared Function StringWidth(ByVal Text As String, ByVal Font As String, ByVal FontSize As Double) As Double
        Dim Ft As FontStruct = GetFont(Font)
        Scale = FontSize / Ft.FontSize
        Dim Width As Double = -(GetSize(Text(0), Ft) * Ft.XSpacing)
        For I As Integer = 0 To Text.Length - 1
            Width += (GetSize(Text(IIf(I = 0, 0, I - 1)), Ft) * Ft.XSpacing) * Scale
            If Text(I) = " " Then
                Width += Ft.SpaceWidth * Scale
            End If
        Next
        Return Width
    End Function
    Public Shared Sub Dispose()
        If Not (FontSprite Is Nothing) Then
            FontSprite.Dispose()
        End If
        If Not (Fonts Is Nothing) Then
            Fonts.Clear()
        End If
        If Not (Appearings Is Nothing) Then
            Appearings.Clear()
        End If
        FontSprite = Nothing
        Fonts = Nothing
        Appearings = Nothing
    End Sub
    Public Shared Sub AddAppearing(ByVal Name As String, ByVal Font As String, ByVal Text As String, ByVal Speed As Double, ByVal StartX As Double, ByVal StartY As Double, ByVal Size As Double, ByVal ForeColor As Drawing.Color)
        If Not (Appearings Is Nothing) Then
            Dim Ft As FontStruct = GetFont(Font)
            Dim Column, Row As Double
            Dim A As AppearingStruct
            A.Scale = Size / Ft.FontSize
            A.Location = New Vector3(StartX / A.Scale, StartY / A.Scale, 0)
            A.Name = Name
            A.Text = Text
            A.Speed = 1.0F / Speed
            A.Texture = Ft.Texture
            A.CurrentLetter = -1
            A.ForeColor = ForeColor
            ReDim A.Positions(Text.Length - 1)
            ReDim A.SourceRects(Text.Length - 1)
            Column = -(GetSize(Text(0), Ft) * Ft.XSpacing)
            For I As Integer = 0 To Text.Length - 1
                Column += (GetSize(Text(IIf(I = 0, 0, I - 1)), Ft) * Ft.XSpacing)
                If Text(I) = vbCrLf(0) Then
                    Row += (Ft.FrameHeight * Ft.YSpacing)
                    Column = -(GetSize(Text(I), Ft) * Ft.XSpacing)
                ElseIf Text(I) = " " Then
                    Column += Ft.SpaceWidth * Scale
                Else
                    A.Positions(I) = New Vector3(A.Location.X + Column, A.Location.Y + Row, 0)
                    A.SourceRects(I) = GetLetter(Text(I), Ft)
                End If
            Next
            Appearings.Add(A)
        End If
    End Sub
    Public Shared Sub StartAppearing(ByVal Name As String)
        Dim A As AppearingStruct = GetAppearing(Name)
        A.CurrentLetter = 0
    End Sub
    Public Shared Sub RenderAppearing(ByVal Name As String)
        Dim A As AppearingStruct = GetAppearing(Name)
        If A.Name <> "" Then
            If A.CurrentLetter <> -1 Then
                A.Time += Scene.DeltaTime
                If A.Time >= A.Speed Then
                    A.Time = 0
                    A.CurrentLetter += 1
                    If A.CurrentLetter >= A.Text.Length - 1 Then
                        A.CurrentLetter = 0
                    End If
                End If
                FontSprite.Begin(SpriteFlags.AlphaBlend)
                FontSprite.Transform = Matrix.Scaling(A.Scale, A.Scale, 1.0F)
                For I As Integer = 0 To A.CurrentLetter
                    FontSprite.Draw(TextureManager.Texture(A.Texture), A.SourceRects(I), Vector3.Empty, A.Positions(I), A.ForeColor)
                Next
                FontSprite.End()
            End If
        End If
    End Sub
    Private Shared Function LoadSizesFromFile(ByVal FilePath As String) As FontStruct
        Dim Sr As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim Ft As New FontStruct
        Ft.FontSize = Sr.ReadLine()
        Ft.FrameWidth = Sr.ReadLine()
        Ft.FrameHeight = Sr.ReadLine()
        ReDim Preserve Ft.Sizes(255)
        For I As Integer = 0 To 255
            Ft.Sizes(I) = Sr.ReadLine
        Next
        Sr.Close()
        Return Ft
    End Function
    Private Shared Function GetAppearing(ByVal Name As String) As AppearingStruct
        For Each A As AppearingStruct In Appearings
            If A.Name = Name Then
                Return A
            End If
        Next
        Return New AppearingStruct
    End Function
    Private Shared Function GetFont(ByVal FontName As String) As FontStruct
        For Each Ft As FontStruct In Fonts
            If Ft.Name = FontName Then
                Return Ft
            End If
        Next
        GameError.Raise(GameError.ErrorType.NameDoesntExist, GameError.ErrorSeverity.Notice, GetType(FontManager), "Font name doesnt exist")
    End Function
    Private Shared Function GetSize(ByVal T As String, ByVal Ft As FontStruct) As Double
        Return Ft.Sizes(Asc(T))
    End Function
    Private Shared Function GetLetter(ByVal Letter As String, ByVal Ft As FontStruct) As Rectangle
        Dim X, Y As Integer
        Y = Int(Asc(Letter) / 16)
        X = Asc(Letter) - (Y * 16)
        Return New Rectangle(X * Ft.FrameWidth, Y * Ft.FrameHeight, GetSize(Letter, Ft) + 4, Ft.FrameHeight)
    End Function
End Class