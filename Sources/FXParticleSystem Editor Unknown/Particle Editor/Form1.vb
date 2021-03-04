Public Class Form1
    Private ParticleSystem(3) As ParticleSystem
    Private Background(3) As Quad
    Private KelticFont, CourierNew, Ringbearer As Text
    Private FormLoaded As Boolean
    Private GameCursor As Cursor
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.B Then
            ToggleBoundingBoxes()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Scene.Initialize(Me.Handle)
        SoundManager.Initialize(Me)
        SetupDoubleBuffer()
        LoadObjects()
        Scene.Begin()
        FormLoaded = True
        Me.Invalidate()
    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Scene.StartScene(Drawing.Color.Black)
        DrawObjects()
        Scene.EndScene()
        Me.Invalidate()
    End Sub
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        DisposeScene()
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If FormLoaded Then
            Scene.WindowResized()
            ResetObjects()
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        GameCursor.Update(e.X, e.Y)
    End Sub

#Region " Loading & Rendering "
    Private Sub DisposeScene()
        Scene.Dispose()
        ParticleSystem(0).Dispose()
        ParticleSystem(1).Dispose()
        ParticleSystem(2).Dispose()
        ParticleSystem(3).Dispose()
        QuadRenderer.Dispose()
        CourierNew.Dispose()
        KelticFont.Dispose()
        Ringbearer.Dispose()
    End Sub
    Private Sub ToggleBoundingBoxes()
        For I As Integer = 0 To 3
            ParticleSystem(I).ShowBoundingBox = Not ParticleSystem(I).ShowBoundingBox
        Next
    End Sub
    Private Sub SetupDoubleBuffer()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.Opaque, True)
        Me.UpdateStyles()
    End Sub
    Private Sub DrawObjects()
        '//Background
        QuadRenderer.Render(Scene.LocalDevice)
        '//Particle System
        For I As Integer = 0 To 3
            ParticleSystem(I).Update(Scene.DeltaTime)
            ParticleSystem(I).Render(Scene.LocalDevice)
        Next
        '//Fonts
        Ringbearer.Render("Phils Fire Particle System" & vbCrLf & _
                          "FramesPerSecond: " & vbCrLf & _
                          "TotalParticles: " & "600", 18, Drawing.Color.Orange, 2, 2)
        Ringbearer.Render(Scene.FramesPerSecond, 35, Drawing.Color.Silver, 180, 15)
        KelticFont.Render("BFME Particle Editor", 40, Drawing.Color.Yellow, 2, Me.ClientSize.Height - 40)
        CourierNew.Render("Toggle Bounding Boxes {B}", 14, Drawing.Color.White, 2, 20)
        GameCursor.Render(0.7F)
    End Sub
    Private Sub ResetObjects()
        '//Reset Background
        Dim Dx As Single = Me.ClientSize.Width / 2
        Dim Dy As Single = Me.ClientSize.Height / 2
        Background(0).Reset(0, 0, Dx, Dy, Drawing.Color.White.ToArgb)
        Background(1).Reset(Dx, 0, Dx, Dy, Drawing.Color.White.ToArgb)
        Background(2).Reset(0, Dy, Dx, Dy, Drawing.Color.White.ToArgb)
        Background(3).Reset(Dx, Dy, Dx, Dy, Drawing.Color.White.ToArgb)
        '//ResetParticleSystems
        For I As Integer = 0 To 3
            ParticleSystem(I).Relocate(Width / 5 * (I + 1) - 10, Height / 4 * 3)
        Next
    End Sub
    Private Sub LoadObjects()
        '//Particle System
        TextureManager.Add(Application.StartupPath & "\Particle.bmp", "Particle", Drawing.Color.Black)
        For I As Integer = 0 To 3
            ParticleSystem(I) = New ParticleSystem(500, Width / 5 * (I + 1) - 10, Height / 4 * 3, TextureManager.Last)
            ParticleSystem(I).ShowBoundingBox = False
        Next
        '//BackGround
        TextureManager.Add(Application.StartupPath & "\Floor.bmp", "Floor", Drawing.Color.Transparent)
        Dim Dx As Single = Me.ClientSize.Width / 2
        Dim Dy As Single = Me.ClientSize.Height / 2
        Background(0) = New Quad(0, 0, Dx, Dy, TextureManager.Last, Drawing.Color.White.ToArgb)
        Background(1) = New Quad(Dx, 0, Dx, Dy, TextureManager.Last, Drawing.Color.White.ToArgb)
        Background(2) = New Quad(0, Dy, Dx, Dy, TextureManager.Last, Drawing.Color.White.ToArgb)
        Background(3) = New Quad(Dx, Dy, Dx, Dy, TextureManager.Last, Drawing.Color.White.ToArgb)
        For I As Integer = 0 To 3
            QuadRenderer.Add(Background(I), "Back" & I)
        Next
        '//Fonts
        TextureManager.Add("CourierNew.bmp", "CourierNew", Drawing.Color.Black)
        CourierNew = New Text(Scene.LocalDevice, TextureManager.Last, "CourierNew.txt", 1.0, 1.0)
        TextureManager.Add("Kelt.bmp", "Keltic", Drawing.Color.Black)
        KelticFont = New Text(Scene.LocalDevice, TextureManager.Last, "Kelt.txt", 1.0, 1.0)
        TextureManager.Add("RingBearer.bmp", "RingBearer", Drawing.Color.Black)
        Ringbearer = New Text(Scene.LocalDevice, TextureManager.Last, "RingBearer.txt", 1.0F, 1.0F)
        '//Sound
        SoundManager.AddBuffer("Fire.wav", "Fire", True)
        SoundManager.Play("Fire")
        '//Cursor
        TextureManager.Add("Cursor.bmp", "GameCursor", Drawing.Color.Magenta)
        GameCursor = New Cursor(TextureManager.Last)
        '//Dispose Cursor
        Me.Cursor.Dispose()
    End Sub
#End Region
End Class
