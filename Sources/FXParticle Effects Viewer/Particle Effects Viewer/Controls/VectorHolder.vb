Public Class VectorHolder
    Public Event ValueChanged(ByVal Sender As VectorHolder)
    Public Property X() As String
        Get
            Return Scene.Parse(txtX.Text)
        End Get
        Set(ByVal value As String)
            txtX.Text = CStr(value)
        End Set
    End Property
    Public Property Y() As String
        Get
            Return Scene.Parse(txtY.Text)
        End Get
        Set(ByVal value As String)
            txtY.Text = CStr(value)
        End Set
    End Property
    Public Property Z() As String
        Get
            Return Scene.Parse(txtZ.Text)
        End Get
        Set(ByVal value As String)
            txtZ.Text = CStr(value)
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

    Public Sub SetValues(ByVal V As Microsoft.DirectX.Vector3)
        X = V.X
        Y = V.Y
        Z = V.Z
    End Sub

    Public Sub RaiseChange()
        RaiseEvent ValueChanged(Me)
    End Sub

    Private Sub X_Y_Z_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtX.KeyPress, txtY.KeyPress, txtZ.KeyPress
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
    Private Sub X_Y_Z_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtX.TextChanged, txtY.TextChanged, txtZ.TextChanged
        RaiseEvent ValueChanged(Me)
    End Sub
End Class
