<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignOutScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.vplSignOut = New AForge.Controls.VideoSourcePlayer()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.cmbVisitorSignOut = New Qios.DevSuite.Components.QComboBox()
        Me.btnBack = New Qios.DevSuite.Components.QButton()
        Me.SuspendLayout()
        '
        'vplSignOut
        '
        Me.vplSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.vplSignOut.BorderColor = System.Drawing.Color.Transparent
        Me.vplSignOut.Cursor = System.Windows.Forms.Cursors.No
        Me.vplSignOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vplSignOut.KeepAspectRatio = True
        Me.vplSignOut.Location = New System.Drawing.Point(646, 120)
        Me.vplSignOut.Name = "vplSignOut"
        Me.vplSignOut.Size = New System.Drawing.Size(483, 363)
        Me.vplSignOut.TabIndex = 2
        Me.vplSignOut.TabStop = False
        Me.vplSignOut.Text = "VideoSourcePlayer1"
        Me.vplSignOut.VideoSource = Nothing
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblInstructions.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(582, 540)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(644, 72)
        Me.lblInstructions.TabIndex = 16
        Me.lblInstructions.Text = "Please scan your visitor badge or select your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " name and click your picture. Than" & _
    "k you."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbVisitorSignOut
        '
        Me.cmbVisitorSignOut.Configuration.DropDownStyle = Qios.DevSuite.Components.QComboBoxStyle.DropDownList
        Me.cmbVisitorSignOut.CueText = ""
        Me.cmbVisitorSignOut.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVisitorSignOut.Location = New System.Drawing.Point(143, 270)
        Me.cmbVisitorSignOut.Name = "cmbVisitorSignOut"
        Me.cmbVisitorSignOut.Size = New System.Drawing.Size(384, 39)
        Me.cmbVisitorSignOut.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.ColorScheme.ButtonBackground1.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonBackground2.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonBorder.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonHotBackground1.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonHotBackground2.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonHotBorder.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonPressedBackground1.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonPressedBackground2.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.ColorScheme.ButtonPressedBorder.SetColor("VistaBlack", System.Drawing.Color.Transparent, False)
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FontScope = Qios.DevSuite.Components.QFontScope.Local
        Me.btnBack.Image = Global.Receptio.My.Resources.Resources.red_square_back
        Me.btnBack.LocalFont = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(97, 93)
        Me.btnBack.TabIndex = 3
        '
        'frmSignOutScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbVisitorSignOut)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.vplSignOut)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignOutScreen"
        Me.Text = "Sign Out"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Qios.DevSuite.Components.QButton
    Friend WithEvents vplSignOut As AForge.Controls.VideoSourcePlayer
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents cmbVisitorSignOut As Qios.DevSuite.Components.QComboBox
End Class
