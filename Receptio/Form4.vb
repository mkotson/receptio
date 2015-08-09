Public Class frmSignOut

    Private Sub frmSignOut_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frmSignIn.TopMost = True
    End Sub


    Private Sub frmSignOut_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = My.Settings.WelcomeBackgroundColor
        Me.ForeColor = My.Settings.FontColor
        lblSignOut.Text = My.Settings.SignOutText
        lblSignOut.Left = (Me.ClientSize.Width / 2) - (lblSignOut.Width / 2)
        tmrSignOut.Start()
        Me.TopMost = True
    End Sub

    Private Sub tmrSignOut_Tick(sender As Object, e As EventArgs) Handles tmrSignOut.Tick
        Me.Close()
    End Sub
End Class