<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignIn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignIn))
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.vplSignIn = New AForge.Controls.VideoSourcePlayer()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtName = New Qios.DevSuite.Components.QTextBox()
        Me.txtCompany = New Qios.DevSuite.Components.QTextBox()
        Me.cmbEmployeeDirectory = New Qios.DevSuite.Components.QComboBox()
        Me.txtEmail = New Qios.DevSuite.Components.QTextBox()
        Me.tmrSignIn = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New Qios.DevSuite.Components.QButton()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblInstructions.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(604, 504)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(655, 108)
        Me.lblInstructions.TabIndex = 12
        Me.lblInstructions.Text = "Please start by entering your information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the picture to take your webcam" & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "photo and announce your arrival. Thank you."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vplSignIn
        '
        Me.vplSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.vplSignIn.BorderColor = System.Drawing.Color.Transparent
        Me.vplSignIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vplSignIn.KeepAspectRatio = True
        Me.vplSignIn.Location = New System.Drawing.Point(706, 80)
        Me.vplSignIn.Name = "vplSignIn"
        Me.vplSignIn.Size = New System.Drawing.Size(483, 363)
        Me.vplSignIn.TabIndex = 0
        Me.vplSignIn.TabStop = False
        Me.vplSignIn.Text = "VideoSourcePlayer1"
        Me.vplSignIn.VideoSource = Nothing
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(129, 271)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(385, 39)
        Me.txtName.TabIndex = 2
        Me.txtName.ToolTipText = "Enter your name"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(130, 374)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(385, 39)
        Me.txtCompany.TabIndex = 3
        Me.txtCompany.ToolTipText = "Enter your company"
        '
        'cmbEmployeeDirectory
        '
        Me.cmbEmployeeDirectory.Configuration.DropDownStyle = Qios.DevSuite.Components.QComboBoxStyle.DropDownList
        Me.cmbEmployeeDirectory.CueText = ""
        Me.cmbEmployeeDirectory.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmployeeDirectory.Location = New System.Drawing.Point(130, 168)
        Me.cmbEmployeeDirectory.Name = "cmbEmployeeDirectory"
        Me.cmbEmployeeDirectory.Size = New System.Drawing.Size(384, 39)
        Me.cmbEmployeeDirectory.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(130, 481)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(385, 39)
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.ToolTipText = "Enter your company"
        '
        'tmrSignIn
        '
        Me.tmrSignIn.Enabled = True
        Me.tmrSignIn.Interval = 180000
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
        Me.btnBack.TabIndex = 15
        '
        'frmSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1346, 726)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cmbEmployeeDirectory)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.vplSignIn)
        Me.Controls.Add(Me.lblInstructions)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignIn"
        Me.ShowInTaskbar = False
        Me.Text = "Sign In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents vplSignIn As AForge.Controls.VideoSourcePlayer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtName As Qios.DevSuite.Components.QTextBox
    Friend WithEvents txtCompany As Qios.DevSuite.Components.QTextBox
    Friend WithEvents cmbEmployeeDirectory As Qios.DevSuite.Components.QComboBox
    Friend WithEvents txtEmail As Qios.DevSuite.Components.QTextBox
    Friend WithEvents tmrSignIn As System.Windows.Forms.Timer
    Friend WithEvents btnBack As Qios.DevSuite.Components.QButton

End Class
