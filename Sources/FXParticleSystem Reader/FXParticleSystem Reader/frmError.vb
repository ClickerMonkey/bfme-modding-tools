
    Public Class frmError

        Public Sub New(ByVal E As GameError)
            InitializeComponent()
            txtSeverity.Text = E.Severity.ToString
            txtSourceClass.Text = E.SourceClass
            txtDescription.Text = E.Description
        End Sub

        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
            Close()
        End Sub

    End Class
