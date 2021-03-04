Public Class AlphaDialog
    Public Enum Results
        OK = 1
        Close = 2
    End Enum
    Public Event Result(ByVal R As Results, ByVal A As Double, ByVal Index As Integer)
    Public Property Alpha() As Double
        Get
            Return CSng(trkAlpha.Value / 100)
        End Get
        Set(ByVal value As Double)
            trkAlpha.Value = value * 100
        End Set
    End Property
    Public Index As Integer
    Private Sub trkAlpha_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkAlpha.Scroll
        picAlpha.Invalidate()
    End Sub
    Private Sub picAlpha_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picAlpha.Paint
        Dim G As Graphics = e.Graphics
        Dim A As Double = trkAlpha.Value / 100 * 255
        G.Clear(Color.White)
        '//Shadow=Black
        For I As Integer = 0 To 4
            G.DrawString("Particle Effects", New Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Pixel), New SolidBrush(Color.FromArgb(A, 0, 0, 0)), 7 + I, 1 + I)
        Next
        G.DrawString("Particle Effects", New Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Pixel), New SolidBrush(Color.FromArgb(A, 0, 0, 255)), 7, 1)
        Me.Text = "Alpha = " & Alpha
    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        RaiseEvent Result(Results.OK, Alpha, Index)
        Me.Close()
    End Sub
    Private Sub AlphaDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent Result(Results.Close, Alpha, Index)
    End Sub
End Class