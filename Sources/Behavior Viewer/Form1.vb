Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Me.Text = "Form1"
    End Sub

#End Region

    Structure Behavior
        Dim vName As String
        Dim vString() As String
        Dim vInteger() As String
        Dim vBoolean() As String
        Dim vDouble() As String
        Dim vUpgrade() As String
        Dim vFX() As String
        Dim vKindof() As String
        Dim vOcl() As String
        Dim vVector() As String
        Dim vPercent() As String
        Dim vColor() As String
        Dim vImage() As String
        Dim vSound() As String
        Dim vMulti() As Behavior
        Dim vSeveral() As String
    End Structure
    Public Behaviors() As Behavior
    Sub ReadFile(ByVal FilePath As String)
        Dim SR As IO.StreamReader = IO.File.OpenText(FilePath)
        Dim Line As String, BehaviorEnd As Boolean
        Dim tBeh, tStr, tInt, tBoo, tDou, tUpg, tFX, tKin, tOcl, tVec, tPer, tCol, tIma, tSou, tMul, tSev, Errors As Integer
        Dim ALL() As Integer = {tBeh, tStr, tInt, tBoo, tDou, tUpg, tFX, tKin, tOcl, tVec, tPer, tCol, tIma, tSou, tMul, tSev}
        Do While SR.Peek <> -1
            Line = SR.ReadLine.TrimStart.TrimEnd
            If Line.StartsWith("<!|") Then
                For I As Integer = 0 To ALL.Length - 1
                    ALL(I) = -1
                Next
                tBeh += 1
                ReDim Preserve Behaviors(tBeh)
                Behaviors(tBeh).vName = Line.Replace("<!|", "").Replace("|!>", "").TrimStart.TrimEnd
                Do
                    Line = SR.ReadLine.TrimStart.TrimEnd
                    If Line.StartsWith("<!|") Then GoTo EndLoop
                    If Line.EndsWith("]") Then
                        tMul += 1
                        ReDim Preserve Behaviors(tBeh).vMulti(tMul)

                    ElseIf Line.EndsWith("}s") Then
                        tSev += 1
                        ReDim Preserve Behaviors(tBeh).vSeveral(tSev)
                        Behaviors(tBeh).vSeveral(tSev) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{string}") Then
                        tStr += 1
                        ReDim Preserve Behaviors(tBeh).vString(tStr)
                        Behaviors(tBeh).vString(tStr) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{integer}") Then
                        tInt += 1
                        ReDim Preserve Behaviors(tBeh).vInteger(tInt)
                        Behaviors(tBeh).vInteger(tInt) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{boolean}") Then
                        tBoo += 1
                        ReDim Preserve Behaviors(tBeh).vBoolean(tBoo)
                        Behaviors(tBeh).vBoolean(tBoo) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{double}") Then
                        tDou += 1
                        ReDim Preserve Behaviors(tBeh).vDouble(tDou)
                        Behaviors(tBeh).vDouble(tDou) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{upgrade}") Then
                        tUpg += 1
                        ReDim Preserve Behaviors(tBeh).vUpgrade(tUpg)
                        Behaviors(tBeh).vUpgrade(tUpg) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{fx}") Then
                        tFX += 1
                        ReDim Preserve Behaviors(tBeh).vFX(tFX)
                        Behaviors(tBeh).vFX(tFX) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{kindof}") Then
                        tKin += 1
                        ReDim Preserve Behaviors(tBeh).vKindof(tKin)
                        Behaviors(tBeh).vKindof(tKin) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{ocl}") Then
                        tOcl += 1
                        ReDim Preserve Behaviors(tBeh).vOcl(tOcl)
                        Behaviors(tBeh).vOcl(tOcl) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{vector}") Then
                        tVec += 1
                        ReDim Preserve Behaviors(tBeh).vVector(tVec)
                        Behaviors(tBeh).vVector(tVec) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{percent}") Then
                        tPer += 1
                        ReDim Preserve Behaviors(tBeh).vPercent(tPer)
                        Behaviors(tBeh).vPercent(tPer) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{color}") Then
                        tCol += 1
                        ReDim Preserve Behaviors(tBeh).vColor(tCol)
                        Behaviors(tBeh).vColor(tCol) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{image}") Then
                        tIma += 1
                        ReDim Preserve Behaviors(tBeh).vImage(tIma)
                        Behaviors(tBeh).vImage(tIma) = Line.Substring(0, Line.IndexOf(" "))
                    ElseIf Line.ToLower.EndsWith("{sound}") Then
                        tSou += 1
                        ReDim Preserve Behaviors(tBeh).vSound(tSou)
                        Behaviors(tBeh).vSound(tSou) = Line.Substring(0, Line.IndexOf(" "))
                    Else
                        Errors += 1
                    End If
                Loop
EndLoop:
            End If
        Loop
    End Sub
End Class
