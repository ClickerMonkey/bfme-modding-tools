Public Class Media
    Public Shared Function FindFile(ByVal Filename As String) As String
        If IO.File.Exists(Filename) Then
            Return Filename
        Else
            GameError.Raise(GameError.ErrorType.FileDoesntExist, GameError.ErrorSeverity.Notice, GetType(Media), "The file " & Filename & " doesnt exist!")
            Return ""
        End If
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
    Public Shared Function GetFilesWithExtension(ByVal RootDirectory As String, ByVal Extension As String) As String()
        Dim Files() As String = GetFiles(RootDirectory)
        Dim Found() As String = {}
        For Each File As String In Files
            If File.EndsWith(Extension) Then
                ReDim Preserve Found(Found.GetUpperBound(0) + 1)
                Found(Found.GetUpperBound(0)) = File
            End If
        Next
        Return Found
    End Function
    Public Shared Function GetFileExtension(ByVal Path As String) As String
        Return Path.Substring(Path.LastIndexOf(".") + 1)
    End Function
    Public Shared Function GetFileName(ByVal Path As String) As String
        If Path.IndexOf("\") <> -1 Then
            If Path.LastIndexOf(".") <> -1 Then
                Return Path.Substring(Path.LastIndexOf("\") + 1, Path.LastIndexOf(".") - Path.LastIndexOf("\") - 1)
            Else
                Return Path.Substring(Path.LastIndexOf("\") + 1)
            End If
        Else
            If Path.LastIndexOf(".") <> -1 Then
                Return Path.Substring(0, Path.LastIndexOf("."))
            Else
                Return Path
            End If
        End If
    End Function
    Private Shared Function AppendFolder(ByVal Folder As String) As String
        Return IIf(Folder.EndsWith("\"), Folder, Folder & "\")
    End Function
End Class