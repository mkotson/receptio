Public Class frmTouchKeyboard
    Friend Input As String
    Private ShiftPressed As Boolean

    Private Sub TouchClick()
        My.Computer.Audio.Play(My.Resources.touch_click, AudioPlayMode.Background)
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        TouchClick()
        Me.Input = txtUserInput.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmTouchKeyboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUserInput.Text = ""
        ShiftPressed = False
        Me.TopMost = True
        txtUserInput.Focus()
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "Q" Else txtUserInput.Text = txtUserInput.Text + "q"
        ResetShift()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        TouchClick()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If txtUserInput.TextLength > 0 Then
            TouchClick()
            txtUserInput.Text = txtUserInput.Text.Remove(txtUserInput.TextLength - 1, 1)
        End If
    End Sub

    Private Sub btnLeftShift_Click(sender As Object, e As EventArgs) Handles btnLeftShift.Click
        TouchClick()
        If Not ShiftPressed Then
            ShiftPressed = True
            btnLeftShift.BackColor = btnLeftShift.ColorScheme.ButtonPressedBackground1
            btnLeftShift.BackColor2 = btnLeftShift.ColorScheme.ButtonPressedBackground2
            btnRightShift.BackColor = btnRightShift.ColorScheme.ButtonPressedBackground1
            btnRightShift.BackColor2 = btnRightShift.ColorScheme.ButtonPressedBackground2
        Else
            ResetShift()
        End If
    End Sub
    Private Sub ResetShift()
        btnLeftShift.BackColor = btn0.ColorScheme.ButtonBackground1
        btnLeftShift.BackColor2 = btn0.ColorScheme.ButtonBackground2
        btnRightShift.BackColor = btn0.ColorScheme.ButtonBackground1
        btnRightShift.BackColor2 = btn0.ColorScheme.ButtonBackground2
        ShiftPressed = False
    End Sub
    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "W" Else txtUserInput.Text = txtUserInput.Text + "w"
        ResetShift()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "E" Else txtUserInput.Text = txtUserInput.Text + "e"
        ResetShift()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "R" Else txtUserInput.Text = txtUserInput.Text + "r"
        ResetShift()
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "T" Else txtUserInput.Text = txtUserInput.Text + "t"
        ResetShift()
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "Y" Else txtUserInput.Text = txtUserInput.Text + "y"
        ResetShift()
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "U" Else txtUserInput.Text = txtUserInput.Text + "u"
        ResetShift()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "I" Else txtUserInput.Text = txtUserInput.Text + "i"
        ResetShift()
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "O" Else txtUserInput.Text = txtUserInput.Text + "o"
        ResetShift()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "P" Else txtUserInput.Text = txtUserInput.Text + "p"
        ResetShift()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "1" Else txtUserInput.Text = txtUserInput.Text + "1"
        ResetShift()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "2" Else txtUserInput.Text = txtUserInput.Text + "2"
        ResetShift()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "3" Else txtUserInput.Text = txtUserInput.Text + "3"
        ResetShift()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "4" Else txtUserInput.Text = txtUserInput.Text + "4"
        ResetShift()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "5" Else txtUserInput.Text = txtUserInput.Text + "5"
        ResetShift()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "6" Else txtUserInput.Text = txtUserInput.Text + "6"
        ResetShift()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "7" Else txtUserInput.Text = txtUserInput.Text + "7"
        ResetShift()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "8" Else txtUserInput.Text = txtUserInput.Text + "8"
        ResetShift()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "9" Else txtUserInput.Text = txtUserInput.Text + "9"
        ResetShift()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "0" Else txtUserInput.Text = txtUserInput.Text + "0"
        ResetShift()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "A" Else txtUserInput.Text = txtUserInput.Text + "a"
        ResetShift()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "S" Else txtUserInput.Text = txtUserInput.Text + "s"
        ResetShift()
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "D" Else txtUserInput.Text = txtUserInput.Text + "d"
        ResetShift()
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "F" Else txtUserInput.Text = txtUserInput.Text + "f"
        ResetShift()
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "G" Else txtUserInput.Text = txtUserInput.Text + "g"
        ResetShift()
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "H" Else txtUserInput.Text = txtUserInput.Text + "h"
        ResetShift()
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "J" Else txtUserInput.Text = txtUserInput.Text + "j"
        ResetShift()
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "K" Else txtUserInput.Text = txtUserInput.Text + "k"
        ResetShift()
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "L" Else txtUserInput.Text = txtUserInput.Text + "l"
        ResetShift()
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "Z" Else txtUserInput.Text = txtUserInput.Text + "z"
        ResetShift()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "X" Else txtUserInput.Text = txtUserInput.Text + "x"
        ResetShift()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "C" Else txtUserInput.Text = txtUserInput.Text + "c"
        ResetShift()
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "V" Else txtUserInput.Text = txtUserInput.Text + "v"
        ResetShift()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "B" Else txtUserInput.Text = txtUserInput.Text + "b"
        ResetShift()
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "N" Else txtUserInput.Text = txtUserInput.Text + "n"
        ResetShift()
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "M" Else txtUserInput.Text = txtUserInput.Text + "m"
        ResetShift()
    End Sub

    Private Sub btnAt_Click(sender As Object, e As EventArgs) Handles btnAt.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "@" Else txtUserInput.Text = txtUserInput.Text + "@"
        ResetShift()
    End Sub

    Private Sub btnPeriod_Click(sender As Object, e As EventArgs) Handles btnPeriod.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "." Else txtUserInput.Text = txtUserInput.Text + "."
        ResetShift()
    End Sub

    Private Sub btnDotCOM_Click(sender As Object, e As EventArgs) Handles btnDotCOM.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + ".COM" Else txtUserInput.Text = txtUserInput.Text + ".com"
        ResetShift()
    End Sub

    Private Sub btnSpace_Click(sender As Object, e As EventArgs) Handles btnSpace.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + " " Else txtUserInput.Text = txtUserInput.Text + " "
        ResetShift()
    End Sub

    Private Sub btnUnderscore_Click(sender As Object, e As EventArgs) Handles btnUnderscore.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "_" Else txtUserInput.Text = txtUserInput.Text + "_"
        ResetShift()
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        TouchClick()
        If ShiftPressed Then txtUserInput.Text = txtUserInput.Text + "-" Else txtUserInput.Text = txtUserInput.Text + "-"
        ResetShift()
    End Sub

    Private Sub btnRightShift_Click(sender As Object, e As EventArgs) Handles btnRightShift.Click
        TouchClick()
        If Not ShiftPressed Then
            ShiftPressed = True
            btnLeftShift.BackColor = btnLeftShift.ColorScheme.ButtonPressedBackground1
            btnLeftShift.BackColor2 = btnLeftShift.ColorScheme.ButtonPressedBackground2
            btnRightShift.BackColor = btnRightShift.ColorScheme.ButtonPressedBackground1
            btnRightShift.BackColor2 = btnRightShift.ColorScheme.ButtonPressedBackground2
        Else
            ResetShift()
        End If
    End Sub

    'Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
    '    Using brush As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.Gray, Color.Black, 90.0F)
    '        e.Graphics.FillRectangle(brush, Me.ClientRectangle)
    '    End Using
    'End Sub
End Class