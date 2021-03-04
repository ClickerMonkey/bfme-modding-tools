'//GameErrorClass
Public Class GameError
    '//Error List
    Public Enum ErrorType
        FileDoesntExist
        TextureNotAdded
        TextureNotFound
        TextureWrongFormat
        FontNotFound
        ErrorDrawingFont
        SoundNotFound
        SoundWrongFormat
        ErrorPlayingSound
        ErrorRendering
        ErrorUpdating
        ErrorInitializing
        ErrorResizing
        ErrorPresenting
        NameAlreadyExists
        NameDoesntExist
        AnimationAlreadyPlaying
        DeviceNotInitialized
        TimerError
        ParticleSystemNotFound
        MathematicalOverFlow
        ErrorParsing
    End Enum
    '//Game Error Type
    Public Enum ErrorSeverity
        Notice = 0
        Warning = 1
        Critical = 2
    End Enum
    Public Shared Event ErrorThrown(ByVal GameError As ErrorType, ByVal ErrorType As ErrorSeverity, ByVal SourceClass As Type, ByVal Details As String)
    Private Shared ErrorWriter As Xml.XmlTextWriter
    Private Shared TotalErrors As Integer
    Public Shared Sub Initialize()
        ErrorWriter = New Xml.XmlTextWriter("Config\Errors.xml", System.Text.Encoding.UTF8)
        ErrorWriter.Formatting = Xml.Formatting.Indented
        ErrorWriter.WriteStartElement("GameStarted")
        ErrorWriter.WriteAttributeString("Time", DateTime.Now.ToString)
    End Sub
    Public Shared Sub Raise(ByVal GameError As ErrorType, ByVal ErrorType As ErrorSeverity, ByVal SourceClass As Type, ByVal Details As String)
        If Not (ErrorWriter Is Nothing) Then
            With ErrorWriter
                .WriteStartElement("Error")
                .WriteElementString("TimeThrown", DateTime.Now.ToString)
                .WriteElementString("ErrorType", GameError.ToString)
                .WriteElementString("Severity", ErrorType.ToString)
                .WriteElementString("SourceClass", SourceClass.ToString)
                .WriteElementString("Details", Details)
                .WriteEndElement()
            End With
        End If
        RaiseEvent ErrorThrown(GameError, ErrorType, SourceClass, Details)
        TotalErrors += 1
        'If ErrorType = ErrorSeverity.Critical Then Scene.Dispose()
    End Sub
    Public Shared Sub Dispose()
        If Not (ErrorWriter Is Nothing) Then
            If TotalErrors = 0 Then
                ErrorWriter.WriteElementString("Total", "No Errors Found!")
            Else
                ErrorWriter.WriteElementString("Total", TotalErrors & " Errors Recorded")
            End If
            ErrorWriter.WriteEndElement()
            ErrorWriter.Close()
        End If
    End Sub
End Class
