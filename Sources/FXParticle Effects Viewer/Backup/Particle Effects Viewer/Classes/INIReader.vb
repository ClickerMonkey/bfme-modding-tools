Public Class INIReader
    Private Reader As IO.StreamReader
    Public Name As String
    Private Line As String
    Public Sub New()
    End Sub
    Public Sub Open(ByVal FilePath As String)
        If IO.File.Exists(FilePath) Then
            Reader = IO.File.OpenText(FilePath)
        Else
            GameError.Raise(GameError.ErrorType.FileDoesntExist, GameError.ErrorSeverity.Notice, GetType(INIReader), "The file " & FilePath & " doesnt exist!")
        End If
    End Sub
    Public Function Read() As Boolean
        If Reader.Peek = -1 Then Return False
        Line = Reader.ReadLine.TrimStart.TrimEnd
        TrimLine()
        Name = Line
        SortName()
        Return True
    End Function
    Public Function EndFound() As Boolean
        If Not Read() Then Return True
        Return CBool(Name.ToLower = "end")
    End Function
    Public Function GetAttribute(ByVal Index As Integer) As String
        Dim Rip As String = Line
        If Rip.IndexOf("=") <> -1 Then
            Rip = Rip.Substring(Rip.IndexOf("=") + 1).TrimStart
            Dim Attrs() As String = Rip.Split(" "c)
            If Attrs.Length < Index Then Return String.Empty
            Return Attrs(Index - 1)
        End If
        If Rip.IndexOf(" ") <> -1 Then
            Rip = Rip.Substring(Rip.IndexOf(" ") + 1).TrimStart
            Dim Attrs() As String = Rip.Split(" "c)
            If Attrs.Length < Index Then Return String.Empty
            Return Attrs(Index - 1)
        End If
        Return String.Empty
    End Function
    Public Function GetAttribute(ByVal Value As String) As String
        Dim Rip As String = Line
        If Rip.IndexOf("=") <> -1 Then
            Rip = Rip.Substring(Rip.IndexOf("=") + 1).TrimStart
            If Rip.IndexOf(Value) <> -1 Then
                Rip &= " "
                Rip = Rip.Substring(Rip.IndexOf(Value) + Value.Length, Rip.IndexOf(" ", Rip.IndexOf(Value) + Value.Length) - (Rip.IndexOf(Value) + Value.Length))
                Return Rip
            End If
        End If
        Return String.Empty
    End Function

    Private Sub TrimLine()
        If Line.IndexOf(";") <> -1 Then
            Line = Line.Substring(0, Line.IndexOf(";"))
        End If
        If Line.IndexOf("//") <> -1 Then
            Line = Line.Substring(0, Line.IndexOf("//"))
        End If
        Line = Line.TrimEnd
    End Sub
    Private Sub SortName()
        If Name.IndexOf(" ") <> -1 Then
            Name = Name.Substring(0, Name.IndexOf(" "))
        End If
    End Sub
End Class
