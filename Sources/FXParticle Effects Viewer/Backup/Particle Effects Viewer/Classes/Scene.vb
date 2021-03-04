Imports System
Imports System.IO
Imports System.Configuration
Imports System.Math
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
'//Scene
Public Class Scene
    Public Shared LocalDevice As Device
    Public Shared Timer As New Timer
    Public Shared GameStarted As Boolean
    Private Shared TimeElapsed As Double
    Private Shared DeviceSettings As New PresentParameters
    Public Shared ReadOnly Property DeltaTime() As Double
        Get
            Return TimeElapsed
        End Get
    End Property
    Public Shared Sub Initialize(ByVal Owner As Control)
        Try
            DeviceSettings.Windowed = True
            DeviceSettings.SwapEffect = SwapEffect.Discard
            DeviceSettings.BackBufferFormat = Format.Unknown
            DeviceSettings.AutoDepthStencilFormat = DepthFormat.D16
            DeviceSettings.EnableAutoDepthStencil = True
            Dim AdapterOrdinal As Integer = Manager.Adapters.Default.Adapter
            Dim Flags As CreateFlags = CreateFlags.SoftwareVertexProcessing
            Dim Caps As Caps = Manager.GetDeviceCaps(AdapterOrdinal, DeviceType.Hardware)
            If Caps.DeviceCaps.SupportsHardwareTransformAndLight Then
                Flags = CreateFlags.HardwareVertexProcessing
            End If
            If Caps.DeviceCaps.SupportsPureDevice Then
                Flags = Flags Or CreateFlags.PureDevice
            End If
            LocalDevice = New Device(0, DeviceType.Hardware, Owner.Handle, Flags, DeviceSettings)
            AddHandler LocalDevice.DeviceReset, AddressOf OnResetDevice
            OnResetDevice(LocalDevice, Nothing)
            '//TextureManager
            TextureManager.Initialize()
            '//FontManager
            FontManager.Initialize()
        Catch ex As Exception
            GameError.Raise(GameError.ErrorType.ErrorInitializing, GameError.ErrorSeverity.Critical, GetType(Scene), "Error Initializing Scene" & vbCrLf & "More Info: " & ex.Message)
        End Try
    End Sub
    Public Shared Sub WindowResized()
        If Not (LocalDevice Is Nothing) Then
            Try
                If GameStarted Then
                    DeviceSettings.BackBufferHeight = 0
                    DeviceSettings.BackBufferWidth = 0
                    LocalDevice.Reset(DeviceSettings)
                End If
            Catch ex As Exception
                GameError.Raise(GameError.ErrorType.ErrorResizing, GameError.ErrorSeverity.Warning, GetType(Scene), "Error Resizing Scene" & vbCrLf & "More Info: " & ex.Message)
            End Try
        End If
    End Sub
    Public Shared Sub OnResetDevice(ByVal Sender As Object, ByVal E As EventArgs)
        Dim LocalDevice As Device = CType(Sender, Device)
    End Sub
    Public Shared Sub Begin()
        GameStarted = True
        Timer.Start()
    End Sub
    Public Shared Sub StartScene(ByVal BackColor As System.Drawing.Color)
        If GameStarted Then
            LocalDevice.Clear(ClearFlags.Target Or ClearFlags.ZBuffer, BackColor, 1.0F, 0)
            LocalDevice.BeginScene()
            TimeElapsed = Timer.ElapsedTime
        End If
    End Sub
    Public Shared Sub EndScene()
        If GameStarted Then
            Try
                LocalDevice.EndScene()
                LocalDevice.Present()
            Catch ex As Exception
                GameError.Raise(GameError.ErrorType.ErrorPresenting, GameError.ErrorSeverity.Critical, GetType(Scene), "Error Presenting Scene" & vbCrLf & "More Info: " & ex.Message)
            End Try
        End If
    End Sub
    Public Shared Sub Dispose()
        GameStarted = False
        Timer.Stop()

        If Not (LocalDevice Is Nothing) Then
            LocalDevice.Dispose()
        End If
        LocalDevice = Nothing
        TextureManager.Dispose()
    End Sub
    Public Shared Function FramesPerSecond() As Integer
        Static CurrentRate As Double
        Static FrameRate As Double
        Static LastFrameRate As Double
        CurrentRate += DeltaTime
        If CurrentRate >= 1.0F Then
            LastFrameRate = FrameRate
            FrameRate = 0
            CurrentRate = 0
        End If
        FrameRate += 1
        Return LastFrameRate
    End Function
    Public Shared Function RandS(ByVal V1 As Double, ByVal V2 As Double) As Double
        Dim Max As Double = Math.Max(V1, V2)
        Dim Min As Double = Math.Min(V1, V2)
        Return (Max - Min) * Rnd() + Min
    End Function
    Public Shared Function RandI(ByVal V1 As Integer, ByVal V2 As Integer) As Integer
        Dim Max As Double = Math.Max(V1, V2)
        Dim Min As Double = Math.Min(V1, V2)
        Return Int((Max - Min) * Rnd()) + Min
    End Function
    Public Shared Function Parse(ByRef Sng As String) As Double
        Try
            If Sng = "." Or Sng.Trim = "" Or Sng = "-" Or Sng = "-." Or Sng = ".-" Then Return 0.0F Else Return CSng(Sng)
        Catch
            GameError.Raise(GameError.ErrorType.ErrorParsing, GameError.ErrorSeverity.Notice, GetType(Scene), "Error Parsing '" & Sng & "' as Double")
            Sng = 0
        End Try
    End Function
End Class

