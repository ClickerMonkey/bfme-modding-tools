Public Class ValueHolder
    Public Event ValueChanged(ByVal Sender As ValueHolder)
    Public Property Max() As String
        Get
            Return Scene.Parse(txtMax.Text)
        End Get
        Set(ByVal value As String)
            txtMax.Text = CStr(value)
        End Set
    End Property
    Public Property Min() As String
        Get
            Return Scene.Parse(txtMin.Text)
        End Get
        Set(ByVal value As String)
            txtMin.Text = CStr(value)
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

    Public Sub SetValues(ByVal Range As ParticleSystemInfo.Value)
        Max = Range.Max
        Min = Range.Min
    End Sub

    Private Sub Max_Min_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMax.KeyPress, txtMin.KeyPress
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
    Private Sub Max_Min_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMax.TextChanged, txtMin.TextChanged
        RaiseEvent ValueChanged(Me)
    End Sub
End Class
