'//GameTimer
Public Class Timer
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
    Public Sub New()
        TimerInitialized = True
        UsingQPF = QueryPerformanceFrequency(TicksPerSecond)
        If UsingQPF Then
            TicksPerSecond = TicksPerSecond
        Else
            Throw New Exception("Timer Init Failure -- No QueryPerformanceCounter")
        End If
    End Sub
    ''' <summary> Resets the timer to 0 </summary>
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
        StopTime += TicksPerSecond / 10
    End Sub
    Public ReadOnly Property AbsoluteTime() As Double
        Get
            If StopTime <> 0 Then
                TimeNow = StopTime
            Else
                QueryPerformanceCounter(TimeNow)
            End If
            Return CSng(TimeNow / CDbl(TicksPerSecond))
        End Get
    End Property
    Public ReadOnly Property ApplicationTime() As Double
        Get
            Return TimeDelta(BaseTime)
        End Get
    End Property
    ''' <summary> Gets the Deltatime (Time elapsed since last call or render) </summary>
    Public ReadOnly Property ElapsedTime() As Double
        Get
            Return TimeDelta(LastElapsedTime)
        End Get
    End Property
    Private Function TimeDelta(ByVal RefTime As Double) As Double
        QueryPerformanceCounter(TimeNow)
        ActualElapsedTime = CDbl(TimeNow - RefTime) / CDbl(TicksPerSecond)
        LastElapsedTime = TimeNow
        Return CSng(ActualElapsedTime)
    End Function
    Public ReadOnly Property PeekTime() As Double
        Get
            Dim Peek As Long = 0
            QueryPerformanceCounter(Peek)
            Return CSng(Peek - LastElapsedTime) / CSng(TicksPerSecond)
        End Get
    End Property
End Class