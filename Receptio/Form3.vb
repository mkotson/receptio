Public Class frmNotify

    Private Sub frmNotify_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frmSignIn.TopMost = True
    End Sub

    Private Sub frmNotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.WelcomeBackgroundColor
        Me.ForeColor = My.Settings.FontColor
        'lblNotify.Text = username + My.Settings.NotifyText
        lblNotify.Text = My.Settings.NotifyText.Replace("%u", username)
        lblNotify.Left = (Me.ClientSize.Width / 2) - (lblNotify.Width / 2)
        tmrNotify.Start()
        Me.TopMost = True
    End Sub

    Private Sub tmrNotify_Tick(sender As Object, e As EventArgs) Handles tmrNotify.Tick

        Me.Close()
    End Sub
    Dim username As String = ""
    Public Sub New(ByVal User As String)

        ' This call is required by the designer.
        InitializeComponent()
        username = User
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
