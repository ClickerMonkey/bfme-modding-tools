Public Class AlphaHolder
    Public Event ValueChanged(ByVal Sender As AlphaHolder)
    Public Event DialogPopUp()
    Public Event DialogPopDown()
    Public Property AlphaMin() As String
        Get
            Return Scene.Parse(btnAlpha1.Text)
        End Get
        Set(ByVal value As String)
            btnAlpha1.Text = value
        End Set
    End Property
    Public Property AlphaMax() As String
        Get
            Return Scene.Parse(btnAlpha2.Text)
        End Get
        Set(ByVal value As String)
            btnAlpha2.Text = value
        End Set
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

    Public Sub SetValues(ByVal AlphaTime As ParticleSystemInfo.AlphaTime)
        AlphaMin = AlphaTime.A1
        AlphaMax = AlphaTime.A2
        Time = AlphaTime.Time
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
    Private Sub txtTime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTime.TextChanged
        RaiseEvent ValueChanged(Me)
    End Sub
    Private Sub btnAlpha1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAlpha1.Click
        RaiseEvent DialogPopUp()
        Dim AlphaPicker As New AlphaDialog
        AlphaPicker.Index = 1
        AlphaPicker.Alpha = btnAlpha1.Text
        AddHandler AlphaPicker.Result, AddressOf AlphaResult
        AlphaPicker.Show()
    End Sub
    Private Sub btnAlpha2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAlpha2.Click
        RaiseEvent DialogPopUp()
        Dim AlphaPicker As New AlphaDialog
        AlphaPicker.Index = 2
        AlphaPicker.Alpha = btnAlpha2.Text
        AddHandler AlphaPicker.Result, AddressOf AlphaResult
        AlphaPicker.Show()
    End Sub
    Private Sub AlphaResult(ByVal R As AlphaDialog.Results, ByVal A As Double, ByVal Index As Integer)
        Select Case Index
            Case 1
                If R = AlphaDialog.Results.OK Then
                    btnAlpha1.Text = A
                End If
            Case 2
                If R = AlphaDialog.Results.OK Then
                    btnAlpha2.Text = A
                End If
        End Select
        RaiseEvent ValueChanged(Me)
        RaiseEvent DialogPopDown()
    End Sub
End Class
