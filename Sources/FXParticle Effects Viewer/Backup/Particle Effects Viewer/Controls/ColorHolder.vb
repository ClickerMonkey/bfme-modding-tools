Public Class ColorHolder
    Public Event ValueChanged(ByVal Sender As ColorHolder)
    Public Event DialogPopUp()
    Public Event DialogPopDown()
    Public ReadOnly Property R() As Integer
        Get
            Return btnColor.BackColor.R
        End Get
    End Property
    Public ReadOnly Property G() As Integer
        Get
            Return btnColor.BackColor.G
        End Get
    End Property
    Public ReadOnly Property B() As Integer
        Get
            Return btnColor.BackColor.B
        End Get
    End Property
    Public Property Time() As String
        Get
            Return Scene.Parse(txtTime.Text)
        End Get
        Set(ByVal value As String)
            txtTime.Text = CStr(value)
        End Set
    End Property
    Public Property ValueName() As String
        Get
            Return Me.Value.Text
        End Get
        Set(ByVal value As String)
            Me.Value.Text = value
        End Set
    End Property

    Public Sub SetValues(ByVal ColorTime As ParticleSystemInfo.ColorTime)
        btnColor.BackColor = Color.FromArgb(255, ColorTime.R, ColorTime.G, ColorTime.B)
        Time = ColorTime.Time
    End Sub

    Private Sub Time_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
        Dim C As Char = e.KeyChar
        Dim Allowed() As Char = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", "-"}
        Dim Safe As Boolean
        For Each A As Char In Allowed
            If A = C Then Safe = True
        Next
        If Asc(C) = Keys.Delete Then Safe = True
        If Asc(C) = Keys.Back Then Safe = True
        If Not Safe Then e.Handled = True
    End Sub
    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        RaiseEvent DialogPopUp()
        Dim ColorPicker As New ColorDialog
        ColorPicker.Color = btnColor.BackColor
        If ColorPicker.ShowDialog = DialogResult.OK Then
            btnColor.BackColor = ColorPicker.Color
            RaiseEvent ValueChanged(Me)
        End If
        ColorPicker.Dispose()
        ColorPicker = Nothing
        RaiseEvent DialogPopDown()
    End Sub
    Private Sub txtTime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTime.TextChanged
        RaiseEvent ValueChanged(Me)
    End Sub
End Class
