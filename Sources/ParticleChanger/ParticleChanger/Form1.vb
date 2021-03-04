Imports System.Drawing.Imaging

Public Class frmChanger


    Public Function Change(ByVal Source As Bitmap) As Bitmap
        Dim Data As Drawing.Imaging.BitmapData
        Dim B(), Dest() As Byte
        Dim Current, W, H, Average As Integer
        W = Source.Width
        H = Source.Height
        ReDim B(W * 4 * H)
        ReDim Dest(W * 4 * H)
        Dim Result As New Bitmap(W, H, PixelFormat.Format32bppArgb)
        Dim ResultGraphics As Graphics = Graphics.FromImage(Result)
        ResultGraphics.DrawImage(Source, 0, 0)
        ResultGraphics.Dispose()
        Data = Result.LockBits(New Rectangle(0, 0, W, H), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)
        Runtime.InteropServices.Marshal.Copy(Data.Scan0, B, 0, (W * 4) * H)
        For Y As Integer = 0 To H - 1
            For X As Integer = 0 To W - 1
                Current = Y * (W * 4) + (X * 4)
                Average = 0.299 * B(Current + 2) + 0.587 * B(Current + 1) + 0.114 * B(Current)
                Dest(Current) = B(Current)
                Dest(Current + 1) = B(Current + 1)
                Dest(Current + 2) = B(Current + 2)
                Dest(Current + 3) = Average
            Next
        Next
        Runtime.InteropServices.Marshal.Copy(Dest, 0, Data.Scan0, W * 4 * H)
        Result.UnlockBits(Data)
        Return Result
    End Function

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "All Files (*.*)|*.*"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            If IO.File.Exists(OFD.FileName) Then
                Dim Bm As Bitmap = Nothing
                Try
                    Bm = New Bitmap(OFD.FileName)
                Catch ex As Exception
                    MsgBox("Error loading image, more information..." & vbCrLf & ex.Message)
                End Try
                If Bm IsNot Nothing Then
                    Dim Result As Bitmap = Change(Bm)
                    picResult.Image = Result
                    Dim Location As String = OFD.FileName.Substring(0, OFD.FileName.LastIndexOf("\") + 1)
                    Dim FileName As String = OFD.FileName.Substring(OFD.FileName.LastIndexOf("\") + 1)
                    FileName = FileName.Remove(FileName.LastIndexOf("."))
                    Result.Save(Location & FileName & "2.png", Imaging.ImageFormat.Png)
                End If
            End If
        End If
    End Sub

End Class
