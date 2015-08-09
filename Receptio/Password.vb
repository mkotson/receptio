Imports System.Windows.Forms

Public Class Password
    Friend Password As String
    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Textbox_password.UseSystemPasswordChar = True
        Me.TopMost = True
    End Sub
    Private Sub Textbox_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox_password.KeyPress
        If Me.Textbox_password.Text.Length = 0 Then
            Me.Lbl_count.Text = ""
        Else
            Me.Lbl_count.Text = "(" & (Me.Textbox_password.Text.Length + 1).ToString & ")"
        End If
    End Sub
    Private Sub CB_ShowChar_CheckedChanged(sender As Object, e As EventArgs) Handles CB_ShowChar.CheckedChanged
        If CB_ShowChar.Checked = True Then
            Me.Textbox_password.UseSystemPasswordChar = True
        Else
            Me.Textbox_password.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Password = Me.Textbox_password.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        Debug.Print(Me.Password)
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
