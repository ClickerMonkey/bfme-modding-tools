Public Class Form1
    Public Sub OpenFile(ByVal FilePath As String)
        If Not (IO.File.Exists(FilePath)) Then
            MsgBox("File doesn't Exist")
            Return
        End If
        Dim Found As Boolean, Map As Integer = 1
        Do Until Found
            If IO.File.Exists("Map" & Map & ".ini") Then
                Map += 1
            Else
                Found = True
            End If
        Loop
        Dim SR As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim SW As IO.StreamWriter = IO.File.CreateText("Map" & Map & ".ini")
        Dim Line, Free, Correct As String, Ends As Integer
        Do While SR.Peek <> -1
            Line = SR.ReadLine
            If Line.TrimStart.StartsWith(";") Or Line.TrimStart.StartsWith("//") Or Line.TrimStart = "" Then
                GoTo SkipLine
            ElseIf Line.IndexOf(";") <> -1 Then
                Line = Line.Substring(0, Line.IndexOf(";"))
            ElseIf Line.IndexOf("//") <> -1 Then
                Line = Line.Substring(0, Line.IndexOf("//"))
            End If
            Free = Line.TrimStart.TrimEnd
            Correct = Free.Replace(" ", "")
            Correct = Correct.Replace(vbTab, "")
            Correct = Correct.Replace("=", " = ")
            SW.WriteLine(Correct)
SkipLine:
        Loop
        SR.Close()
        SW.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim FilePath As String = InputBox("FilePath")
        OpenFile(FilePath)
        Me.Close()
    End Sub
    Public Function IsParent(ByVal Line As String) As Boolean

    End Function
    Public Function IsEnd(ByVal Line As String) As Boolean
        If Line.TrimStart.ToLower = "end" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function IsChild(ByVal Line As String) As Boolean

    End Function
End Class
