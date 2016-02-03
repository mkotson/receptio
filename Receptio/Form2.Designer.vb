<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form
    'Dim LicenseValidator As Habanero.Licensing.Validation.LicenseValidator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabWelcomeScreen = New System.Windows.Forms.TabPage()
        Me.pnlVisitorDetection = New System.Windows.Forms.Panel()
        Me.numFaceDetectionSensitivity = New System.Windows.Forms.NumericUpDown()
        Me.lblFaceDetectionSensitivity = New System.Windows.Forms.Label()
        Me.slVisitorDetection = New CustomControls.slider()
        Me.numMotionSensitivity = New System.Windows.Forms.NumericUpDown()
        Me.lblMotionSensitivity = New System.Windows.Forms.Label()
        Me.lblVoiceMessage = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVoiceMessage = New System.Windows.Forms.TextBox()
        Me.lblVisitorDetection = New System.Windows.Forms.Label()
        Me.numMotionLockout = New System.Windows.Forms.NumericUpDown()
        Me.lblMotionLockout = New System.Windows.Forms.Label()
        Me.chkFaceDetection = New System.Windows.Forms.CheckBox()
        Me.chkMotionDetection = New System.Windows.Forms.CheckBox()
        Me.pnlWelcomeScreen = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtWelcomeText = New System.Windows.Forms.TextBox()
        Me.txtSignOutButtonText = New System.Windows.Forms.TextBox()
        Me.picCompanyLogo = New System.Windows.Forms.PictureBox()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.txtSignInButtonText = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.tabSignInScreen = New System.Windows.Forms.TabPage()
        Me.pnlMailChimp = New System.Windows.Forms.Panel()
        Me.txtMailChimpListID = New System.Windows.Forms.TextBox()
        Me.txtMailChimpAPIKey = New System.Windows.Forms.TextBox()
        Me.lblMailChimpAPIKey = New System.Windows.Forms.Label()
        Me.slMailChimp = New CustomControls.slider()
        Me.lblMailChimpListID = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblMailChimp = New System.Windows.Forms.Label()
        Me.pnlVisitorBadgePrinting = New System.Windows.Forms.Panel()
        Me.lblPrinterStatus = New System.Windows.Forms.Label()
        Me.slVisitorBadgePrinting = New CustomControls.slider()
        Me.cboPrinters = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblVisitorBadgePrinting = New System.Windows.Forms.Label()
        Me.pnlTouchscreenKeyboard = New System.Windows.Forms.Panel()
        Me.slTouchscreenKeyboard = New CustomControls.slider()
        Me.lblTouchscreenKeyboard = New System.Windows.Forms.Label()
        Me.pnlNotificationPopup = New System.Windows.Forms.Panel()
        Me.txtNotifyText = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNotifyText = New System.Windows.Forms.Label()
        Me.lblNotificationPopup = New System.Windows.Forms.Label()
        Me.pnlSignInScreen = New System.Windows.Forms.Panel()
        Me.picVisitor = New System.Windows.Forms.PictureBox()
        Me.txtSettingInstructions = New System.Windows.Forms.TextBox()
        Me.chkEmailVisible = New System.Windows.Forms.CheckBox()
        Me.chkCompanyVisible = New System.Windows.Forms.CheckBox()
        Me.txtVisitingText = New System.Windows.Forms.TextBox()
        Me.txtNameText = New System.Windows.Forms.TextBox()
        Me.txtEmailText = New System.Windows.Forms.TextBox()
        Me.txtCompanyText = New System.Windows.Forms.TextBox()
        Me.tabSignOutScreen = New System.Windows.Forms.TabPage()
        Me.pnlSignOutMessagePopup = New System.Windows.Forms.Panel()
        Me.txtSignOutText = New System.Windows.Forms.TextBox()
        Me.lblSignOutText = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblSignOutMessagePopup = New System.Windows.Forms.Label()
        Me.pnlSignOutScreen = New System.Windows.Forms.Panel()
        Me.txtSignOutVisitor = New System.Windows.Forms.TextBox()
        Me.txtSignOutInstructions = New System.Windows.Forms.TextBox()
        Me.picSignOut = New System.Windows.Forms.PictureBox()
        Me.tabEmployeeDirectory = New System.Windows.Forms.TabPage()
        Me.pnlEmployeeDirectory = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.lblEmployeeDirectory = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstEmployees = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlEmployeeInformation = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmployeeInformation = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblIDNum = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromCSVFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeDirectoryLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabVisitorLog = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalVisits = New System.Windows.Forms.Label()
        Me.lblFirstVisit = New System.Windows.Forms.Label()
        Me.lblLastVisit = New System.Windows.Forms.Label()
        Me.lblVisitorName = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lblVisitorInformation = New System.Windows.Forms.Label()
        Me.picSignInPicture = New System.Windows.Forms.PictureBox()
        Me.FastDataListView1 = New BrightIdeasSoftware.FastDataListView()
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitorLogLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabSystem = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlSystemInformation = New System.Windows.Forms.Panel()
        Me.btnEditLicense = New System.Windows.Forms.Button()
        Me.lblLicense = New System.Windows.Forms.Label()
        Me.lblSoftwareVersion = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblSystemInformation = New System.Windows.Forms.Label()
        Me.pnlEmailSettings = New System.Windows.Forms.Panel()
        Me.cboEmailServerType = New System.Windows.Forms.ComboBox()
        Me.lblEmailServerType = New System.Windows.Forms.Label()
        Me.slEmailNotifications = New CustomControls.slider()
        Me.txtMailFrom = New System.Windows.Forms.TextBox()
        Me.chkEnableSSL = New System.Windows.Forms.CheckBox()
        Me.lblEmailFrom = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkAuthentication = New System.Windows.Forms.CheckBox()
        Me.lblEmailNotifications = New System.Windows.Forms.Label()
        Me.lblSMTPUserName = New System.Windows.Forms.Label()
        Me.lblSMTPServerName = New System.Windows.Forms.Label()
        Me.txtSMTPPort = New System.Windows.Forms.TextBox()
        Me.txtSMTPUserName = New System.Windows.Forms.TextBox()
        Me.lblSMTPPort = New System.Windows.Forms.Label()
        Me.lblSMTPPassword = New System.Windows.Forms.Label()
        Me.txtSMTPPassword = New System.Windows.Forms.TextBox()
        Me.txtSMTPServerName = New System.Windows.Forms.TextBox()
        Me.pnlCameraSettings = New System.Windows.Forms.Panel()
        Me.vplSettings = New AForge.Controls.VideoSourcePlayer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cboSnapshotResolution = New System.Windows.Forms.ComboBox()
        Me.lblCameraSettings = New System.Windows.Forms.Label()
        Me.lblSnapshotResolution = New System.Windows.Forms.Label()
        Me.cboCameraResolution = New System.Windows.Forms.ComboBox()
        Me.lblSelectCamera = New System.Windows.Forms.Label()
        Me.cboVideoSource = New System.Windows.Forms.ComboBox()
        Me.lblCameraResolution = New System.Windows.Forms.Label()
        Me.btnCameraSettings = New System.Windows.Forms.Button()
        Me.pnlSystemSettings = New System.Windows.Forms.Panel()
        Me.lblGlobalFont = New System.Windows.Forms.Label()
        Me.txtLocationName = New System.Windows.Forms.TextBox()
        Me.lblFontSample = New System.Windows.Forms.Label()
        Me.lblSystemPassword = New System.Windows.Forms.Label()
        Me.lblLocationName = New System.Windows.Forms.Label()
        Me.txtSystemPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblSystemSettings = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.clrBackgroundColor = New System.Windows.Forms.ColorDialog()
        Me.clrButton = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrMotionLevel = New System.Windows.Forms.Timer(Me.components)
        Me.btnApply = New System.Windows.Forms.Button()
        Me.tmrFPS = New System.Windows.Forms.Timer(Me.components)
        Me.ExportVisitorLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tabWelcomeScreen.SuspendLayout()
        Me.pnlVisitorDetection.SuspendLayout()
        CType(Me.numFaceDetectionSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMotionSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMotionLockout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWelcomeScreen.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompanyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSignInScreen.SuspendLayout()
        Me.pnlMailChimp.SuspendLayout()
        Me.pnlVisitorBadgePrinting.SuspendLayout()
        Me.pnlTouchscreenKeyboard.SuspendLayout()
        Me.pnlNotificationPopup.SuspendLayout()
        Me.pnlSignInScreen.SuspendLayout()
        CType(Me.picVisitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSignOutScreen.SuspendLayout()
        Me.pnlSignOutMessagePopup.SuspendLayout()
        Me.pnlSignOutScreen.SuspendLayout()
        CType(Me.picSignOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEmployeeDirectory.SuspendLayout()
        Me.pnlEmployeeDirectory.SuspendLayout()
        Me.pnlEmployeeInformation.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabVisitorLog.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picSignInPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FastDataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.tabSystem.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSystemInformation.SuspendLayout()
        Me.pnlEmailSettings.SuspendLayout()
        Me.pnlCameraSettings.SuspendLayout()
        Me.pnlSystemSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabWelcomeScreen)
        Me.TabControl1.Controls.Add(Me.tabSignInScreen)
        Me.TabControl1.Controls.Add(Me.tabSignOutScreen)
        Me.TabControl1.Controls.Add(Me.tabEmployeeDirectory)
        Me.TabControl1.Controls.Add(Me.tabVisitorLog)
        Me.TabControl1.Controls.Add(Me.tabSystem)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(853, 657)
        Me.TabControl1.TabIndex = 0
        '
        'tabWelcomeScreen
        '
        Me.tabWelcomeScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.tabWelcomeScreen.Controls.Add(Me.pnlVisitorDetection)
        Me.tabWelcomeScreen.Controls.Add(Me.pnlWelcomeScreen)
        Me.tabWelcomeScreen.ImageIndex = 2
        Me.tabWelcomeScreen.Location = New System.Drawing.Point(4, 31)
        Me.tabWelcomeScreen.Name = "tabWelcomeScreen"
        Me.tabWelcomeScreen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWelcomeScreen.Size = New System.Drawing.Size(845, 622)
        Me.tabWelcomeScreen.TabIndex = 3
        Me.tabWelcomeScreen.Text = "Welcome Screen"
        '
        'pnlVisitorDetection
        '
        Me.pnlVisitorDetection.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlVisitorDetection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlVisitorDetection.Controls.Add(Me.numFaceDetectionSensitivity)
        Me.pnlVisitorDetection.Controls.Add(Me.lblFaceDetectionSensitivity)
        Me.pnlVisitorDetection.Controls.Add(Me.slVisitorDetection)
        Me.pnlVisitorDetection.Controls.Add(Me.numMotionSensitivity)
        Me.pnlVisitorDetection.Controls.Add(Me.lblMotionSensitivity)
        Me.pnlVisitorDetection.Controls.Add(Me.lblVoiceMessage)
        Me.pnlVisitorDetection.Controls.Add(Me.GroupBox1)
        Me.pnlVisitorDetection.Controls.Add(Me.txtVoiceMessage)
        Me.pnlVisitorDetection.Controls.Add(Me.lblVisitorDetection)
        Me.pnlVisitorDetection.Controls.Add(Me.numMotionLockout)
        Me.pnlVisitorDetection.Controls.Add(Me.lblMotionLockout)
        Me.pnlVisitorDetection.Controls.Add(Me.chkFaceDetection)
        Me.pnlVisitorDetection.Controls.Add(Me.chkMotionDetection)
        Me.pnlVisitorDetection.Location = New System.Drawing.Point(103, 419)
        Me.pnlVisitorDetection.Name = "pnlVisitorDetection"
        Me.pnlVisitorDetection.Size = New System.Drawing.Size(363, 169)
        Me.pnlVisitorDetection.TabIndex = 51
        '
        'numFaceDetectionSensitivity
        '
        Me.numFaceDetectionSensitivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFaceDetectionSensitivity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numFaceDetectionSensitivity.Location = New System.Drawing.Point(303, 83)
        Me.numFaceDetectionSensitivity.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numFaceDetectionSensitivity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFaceDetectionSensitivity.Name = "numFaceDetectionSensitivity"
        Me.numFaceDetectionSensitivity.Size = New System.Drawing.Size(42, 22)
        Me.numFaceDetectionSensitivity.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.numFaceDetectionSensitivity, "Face Detection Sensitivity - 1  for most sensitive and 10 for least sensitive")
        Me.numFaceDetectionSensitivity.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'lblFaceDetectionSensitivity
        '
        Me.lblFaceDetectionSensitivity.AutoSize = True
        Me.lblFaceDetectionSensitivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaceDetectionSensitivity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblFaceDetectionSensitivity.Location = New System.Drawing.Point(229, 86)
        Me.lblFaceDetectionSensitivity.Name = "lblFaceDetectionSensitivity"
        Me.lblFaceDetectionSensitivity.Size = New System.Drawing.Size(68, 16)
        Me.lblFaceDetectionSensitivity.TabIndex = 59
        Me.lblFaceDetectionSensitivity.Text = "Sensitivity"
        Me.ToolTip1.SetToolTip(Me.lblFaceDetectionSensitivity, "Face detection sensitivity")
        '
        'slVisitorDetection
        '
        Me.slVisitorDetection.Location = New System.Drawing.Point(243, 11)
        Me.slVisitorDetection.Name = "slVisitorDetection"
        Me.slVisitorDetection.Size = New System.Drawing.Size(102, 29)
        Me.slVisitorDetection.SwitchedOn = False
        Me.slVisitorDetection.TabIndex = 52
        '
        'numMotionSensitivity
        '
        Me.numMotionSensitivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMotionSensitivity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numMotionSensitivity.Location = New System.Drawing.Point(303, 59)
        Me.numMotionSensitivity.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numMotionSensitivity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMotionSensitivity.Name = "numMotionSensitivity"
        Me.numMotionSensitivity.Size = New System.Drawing.Size(42, 22)
        Me.numMotionSensitivity.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.numMotionSensitivity, "Motion Detection Sensitivity - 1  for most sensitive and 10 for least sensitive")
        Me.numMotionSensitivity.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblMotionSensitivity
        '
        Me.lblMotionSensitivity.AutoSize = True
        Me.lblMotionSensitivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotionSensitivity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblMotionSensitivity.Location = New System.Drawing.Point(229, 63)
        Me.lblMotionSensitivity.Name = "lblMotionSensitivity"
        Me.lblMotionSensitivity.Size = New System.Drawing.Size(68, 16)
        Me.lblMotionSensitivity.TabIndex = 40
        Me.lblMotionSensitivity.Text = "Sensitivity"
        Me.ToolTip1.SetToolTip(Me.lblMotionSensitivity, "Motion detection sensitivity")
        '
        'lblVoiceMessage
        '
        Me.lblVoiceMessage.AutoSize = True
        Me.lblVoiceMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoiceMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblVoiceMessage.Location = New System.Drawing.Point(5, 131)
        Me.lblVoiceMessage.Name = "lblVoiceMessage"
        Me.lblVoiceMessage.Size = New System.Drawing.Size(119, 16)
        Me.lblVoiceMessage.TabIndex = 37
        Me.lblVoiceMessage.Text = "Greeting Message"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 2)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtVoiceMessage
        '
        Me.txtVoiceMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoiceMessage.Location = New System.Drawing.Point(128, 130)
        Me.txtVoiceMessage.Name = "txtVoiceMessage"
        Me.txtVoiceMessage.Size = New System.Drawing.Size(217, 22)
        Me.txtVoiceMessage.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.txtVoiceMessage, "Welcome message to be spoken when motion or face detection is found")
        '
        'lblVisitorDetection
        '
        Me.lblVisitorDetection.AutoSize = True
        Me.lblVisitorDetection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorDetection.ForeColor = System.Drawing.Color.White
        Me.lblVisitorDetection.Location = New System.Drawing.Point(3, 15)
        Me.lblVisitorDetection.Name = "lblVisitorDetection"
        Me.lblVisitorDetection.Size = New System.Drawing.Size(169, 25)
        Me.lblVisitorDetection.TabIndex = 1
        Me.lblVisitorDetection.Text = "Visitor Detection"
        '
        'numMotionLockout
        '
        Me.numMotionLockout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMotionLockout.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numMotionLockout.Location = New System.Drawing.Point(303, 105)
        Me.numMotionLockout.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.numMotionLockout.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMotionLockout.Name = "numMotionLockout"
        Me.numMotionLockout.Size = New System.Drawing.Size(42, 22)
        Me.numMotionLockout.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.numMotionLockout, "The amount of time in seconds between voice message announcements")
        Me.numMotionLockout.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblMotionLockout
        '
        Me.lblMotionLockout.AutoSize = True
        Me.lblMotionLockout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotionLockout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblMotionLockout.Location = New System.Drawing.Point(5, 109)
        Me.lblMotionLockout.Name = "lblMotionLockout"
        Me.lblMotionLockout.Size = New System.Drawing.Size(238, 16)
        Me.lblMotionLockout.TabIndex = 53
        Me.lblMotionLockout.Text = "Seconds Between Greeting Messages"
        Me.ToolTip1.SetToolTip(Me.lblMotionLockout, "The amount of time in seconds between voice message announcements")
        '
        'chkFaceDetection
        '
        Me.chkFaceDetection.AutoSize = True
        Me.chkFaceDetection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFaceDetection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.chkFaceDetection.Location = New System.Drawing.Point(8, 85)
        Me.chkFaceDetection.Name = "chkFaceDetection"
        Me.chkFaceDetection.Size = New System.Drawing.Size(118, 20)
        Me.chkFaceDetection.TabIndex = 54
        Me.chkFaceDetection.Text = "Face Detection"
        Me.ToolTip1.SetToolTip(Me.chkFaceDetection, "Enable face detection")
        Me.chkFaceDetection.UseVisualStyleBackColor = True
        '
        'chkMotionDetection
        '
        Me.chkMotionDetection.AutoSize = True
        Me.chkMotionDetection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMotionDetection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.chkMotionDetection.Location = New System.Drawing.Point(8, 62)
        Me.chkMotionDetection.Name = "chkMotionDetection"
        Me.chkMotionDetection.Size = New System.Drawing.Size(127, 20)
        Me.chkMotionDetection.TabIndex = 39
        Me.chkMotionDetection.Text = "Motion Detection"
        Me.ToolTip1.SetToolTip(Me.chkMotionDetection, "Enable motion detection")
        Me.chkMotionDetection.UseVisualStyleBackColor = True
        '
        'pnlWelcomeScreen
        '
        Me.pnlWelcomeScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlWelcomeScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlWelcomeScreen.Controls.Add(Me.PictureBox3)
        Me.pnlWelcomeScreen.Controls.Add(Me.txtWelcomeText)
        Me.pnlWelcomeScreen.Controls.Add(Me.txtSignOutButtonText)
        Me.pnlWelcomeScreen.Controls.Add(Me.picCompanyLogo)
        Me.pnlWelcomeScreen.Controls.Add(Me.btnSignOut)
        Me.pnlWelcomeScreen.Controls.Add(Me.txtSignInButtonText)
        Me.pnlWelcomeScreen.Controls.Add(Me.btnSignIn)
        Me.pnlWelcomeScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlWelcomeScreen.Location = New System.Drawing.Point(103, 28)
        Me.pnlWelcomeScreen.Name = "pnlWelcomeScreen"
        Me.pnlWelcomeScreen.Size = New System.Drawing.Size(652, 353)
        Me.pnlWelcomeScreen.TabIndex = 50
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Receptio.My.Resources.Resources.blank_person
        Me.PictureBox3.Location = New System.Drawing.Point(373, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(241, 141)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'txtWelcomeText
        '
        Me.txtWelcomeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWelcomeText.Location = New System.Drawing.Point(351, 233)
        Me.txtWelcomeText.Multiline = True
        Me.txtWelcomeText.Name = "txtWelcomeText"
        Me.txtWelcomeText.Size = New System.Drawing.Size(277, 40)
        Me.txtWelcomeText.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtWelcomeText, "Welcome message")
        '
        'txtSignOutButtonText
        '
        Me.txtSignOutButtonText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignOutButtonText.Location = New System.Drawing.Point(90, 274)
        Me.txtSignOutButtonText.Name = "txtSignOutButtonText"
        Me.txtSignOutButtonText.Size = New System.Drawing.Size(79, 22)
        Me.txtSignOutButtonText.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.txtSignOutButtonText, "Text for Sign Out button")
        '
        'picCompanyLogo
        '
        Me.picCompanyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCompanyLogo.Location = New System.Drawing.Point(8, 12)
        Me.picCompanyLogo.Name = "picCompanyLogo"
        Me.picCompanyLogo.Size = New System.Drawing.Size(235, 130)
        Me.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCompanyLogo.TabIndex = 1
        Me.picCompanyLogo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picCompanyLogo, "Company logo, click to change")
        '
        'btnSignOut
        '
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.Location = New System.Drawing.Point(64, 255)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(138, 61)
        Me.btnSignOut.TabIndex = 49
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'txtSignInButtonText
        '
        Me.txtSignInButtonText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignInButtonText.Location = New System.Drawing.Point(90, 208)
        Me.txtSignInButtonText.Name = "txtSignInButtonText"
        Me.txtSignInButtonText.Size = New System.Drawing.Size(82, 22)
        Me.txtSignInButtonText.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.txtSignInButtonText, "Text for Sign In buttom")
        '
        'btnSignIn
        '
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.Location = New System.Drawing.Point(64, 188)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(138, 61)
        Me.btnSignIn.TabIndex = 47
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'tabSignInScreen
        '
        Me.tabSignInScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.tabSignInScreen.Controls.Add(Me.pnlMailChimp)
        Me.tabSignInScreen.Controls.Add(Me.pnlVisitorBadgePrinting)
        Me.tabSignInScreen.Controls.Add(Me.pnlTouchscreenKeyboard)
        Me.tabSignInScreen.Controls.Add(Me.pnlNotificationPopup)
        Me.tabSignInScreen.Controls.Add(Me.pnlSignInScreen)
        Me.tabSignInScreen.ImageIndex = 4
        Me.tabSignInScreen.Location = New System.Drawing.Point(4, 31)
        Me.tabSignInScreen.Name = "tabSignInScreen"
        Me.tabSignInScreen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSignInScreen.Size = New System.Drawing.Size(845, 622)
        Me.tabSignInScreen.TabIndex = 2
        Me.tabSignInScreen.Text = "Sign In Screen"
        '
        'pnlMailChimp
        '
        Me.pnlMailChimp.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlMailChimp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMailChimp.Controls.Add(Me.txtMailChimpListID)
        Me.pnlMailChimp.Controls.Add(Me.txtMailChimpAPIKey)
        Me.pnlMailChimp.Controls.Add(Me.lblMailChimpAPIKey)
        Me.pnlMailChimp.Controls.Add(Me.slMailChimp)
        Me.pnlMailChimp.Controls.Add(Me.lblMailChimpListID)
        Me.pnlMailChimp.Controls.Add(Me.GroupBox4)
        Me.pnlMailChimp.Controls.Add(Me.lblMailChimp)
        Me.pnlMailChimp.Location = New System.Drawing.Point(440, 500)
        Me.pnlMailChimp.Name = "pnlMailChimp"
        Me.pnlMailChimp.Size = New System.Drawing.Size(372, 116)
        Me.pnlMailChimp.TabIndex = 62
        '
        'txtMailChimpListID
        '
        Me.txtMailChimpListID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailChimpListID.Location = New System.Drawing.Point(59, 51)
        Me.txtMailChimpListID.Name = "txtMailChimpListID"
        Me.txtMailChimpListID.Size = New System.Drawing.Size(295, 22)
        Me.txtMailChimpListID.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.txtMailChimpListID, "The List ID associated with the desired list.  NOT THE LIST NAME!")
        '
        'txtMailChimpAPIKey
        '
        Me.txtMailChimpAPIKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailChimpAPIKey.Location = New System.Drawing.Point(70, 80)
        Me.txtMailChimpAPIKey.Name = "txtMailChimpAPIKey"
        Me.txtMailChimpAPIKey.Size = New System.Drawing.Size(284, 22)
        Me.txtMailChimpAPIKey.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.txtMailChimpAPIKey, "The MailChimp API key associated with your account")
        '
        'lblMailChimpAPIKey
        '
        Me.lblMailChimpAPIKey.AutoSize = True
        Me.lblMailChimpAPIKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailChimpAPIKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblMailChimpAPIKey.Location = New System.Drawing.Point(9, 79)
        Me.lblMailChimpAPIKey.Name = "lblMailChimpAPIKey"
        Me.lblMailChimpAPIKey.Size = New System.Drawing.Size(55, 16)
        Me.lblMailChimpAPIKey.TabIndex = 37
        Me.lblMailChimpAPIKey.Text = "API Key"
        Me.ToolTip1.SetToolTip(Me.lblMailChimpAPIKey, "The MailChimp API key associated with your account")
        '
        'slMailChimp
        '
        Me.slMailChimp.Location = New System.Drawing.Point(252, 6)
        Me.slMailChimp.Name = "slMailChimp"
        Me.slMailChimp.Size = New System.Drawing.Size(102, 29)
        Me.slMailChimp.SwitchedOn = False
        Me.slMailChimp.TabIndex = 62
        '
        'lblMailChimpListID
        '
        Me.lblMailChimpListID.AutoSize = True
        Me.lblMailChimpListID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailChimpListID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblMailChimpListID.Location = New System.Drawing.Point(9, 54)
        Me.lblMailChimpListID.Name = "lblMailChimpListID"
        Me.lblMailChimpListID.Size = New System.Drawing.Size(44, 16)
        Me.lblMailChimpListID.TabIndex = 54
        Me.lblMailChimpListID.Text = "List ID"
        Me.ToolTip1.SetToolTip(Me.lblMailChimpListID, "The List ID associated with the desired list.  NOT THE LIST NAME!")
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'lblMailChimp
        '
        Me.lblMailChimp.AutoSize = True
        Me.lblMailChimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailChimp.ForeColor = System.Drawing.Color.White
        Me.lblMailChimp.Location = New System.Drawing.Point(7, 10)
        Me.lblMailChimp.Name = "lblMailChimp"
        Me.lblMailChimp.Size = New System.Drawing.Size(228, 25)
        Me.lblMailChimp.TabIndex = 2
        Me.lblMailChimp.Text = "MailChimp Mailing List"
        '
        'pnlVisitorBadgePrinting
        '
        Me.pnlVisitorBadgePrinting.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlVisitorBadgePrinting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlVisitorBadgePrinting.Controls.Add(Me.lblPrinterStatus)
        Me.pnlVisitorBadgePrinting.Controls.Add(Me.slVisitorBadgePrinting)
        Me.pnlVisitorBadgePrinting.Controls.Add(Me.cboPrinters)
        Me.pnlVisitorBadgePrinting.Controls.Add(Me.GroupBox3)
        Me.pnlVisitorBadgePrinting.Controls.Add(Me.lblVisitorBadgePrinting)
        Me.pnlVisitorBadgePrinting.Location = New System.Drawing.Point(440, 396)
        Me.pnlVisitorBadgePrinting.Name = "pnlVisitorBadgePrinting"
        Me.pnlVisitorBadgePrinting.Size = New System.Drawing.Size(372, 84)
        Me.pnlVisitorBadgePrinting.TabIndex = 61
        '
        'lblPrinterStatus
        '
        Me.lblPrinterStatus.AutoSize = True
        Me.lblPrinterStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrinterStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPrinterStatus.Location = New System.Drawing.Point(231, 57)
        Me.lblPrinterStatus.Name = "lblPrinterStatus"
        Me.lblPrinterStatus.Size = New System.Drawing.Size(88, 16)
        Me.lblPrinterStatus.TabIndex = 60
        Me.lblPrinterStatus.Text = "Status - None"
        Me.ToolTip1.SetToolTip(Me.lblPrinterStatus, "Selected printer status")
        '
        'slVisitorBadgePrinting
        '
        Me.slVisitorBadgePrinting.Location = New System.Drawing.Point(252, 6)
        Me.slVisitorBadgePrinting.Name = "slVisitorBadgePrinting"
        Me.slVisitorBadgePrinting.Size = New System.Drawing.Size(102, 29)
        Me.slVisitorBadgePrinting.SwitchedOn = False
        Me.slVisitorBadgePrinting.TabIndex = 62
        '
        'cboPrinters
        '
        Me.cboPrinters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrinters.FormattingEnabled = True
        Me.cboPrinters.Location = New System.Drawing.Point(12, 52)
        Me.cboPrinters.Name = "cboPrinters"
        Me.cboPrinters.Size = New System.Drawing.Size(181, 24)
        Me.cboPrinters.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.cboPrinters, "Select printer for badge printing")
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'lblVisitorBadgePrinting
        '
        Me.lblVisitorBadgePrinting.AutoSize = True
        Me.lblVisitorBadgePrinting.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorBadgePrinting.ForeColor = System.Drawing.Color.White
        Me.lblVisitorBadgePrinting.Location = New System.Drawing.Point(7, 10)
        Me.lblVisitorBadgePrinting.Name = "lblVisitorBadgePrinting"
        Me.lblVisitorBadgePrinting.Size = New System.Drawing.Size(219, 25)
        Me.lblVisitorBadgePrinting.TabIndex = 2
        Me.lblVisitorBadgePrinting.Text = "Visitor Badge Printing"
        '
        'pnlTouchscreenKeyboard
        '
        Me.pnlTouchscreenKeyboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlTouchscreenKeyboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTouchscreenKeyboard.Controls.Add(Me.slTouchscreenKeyboard)
        Me.pnlTouchscreenKeyboard.Controls.Add(Me.lblTouchscreenKeyboard)
        Me.pnlTouchscreenKeyboard.Location = New System.Drawing.Point(22, 500)
        Me.pnlTouchscreenKeyboard.Name = "pnlTouchscreenKeyboard"
        Me.pnlTouchscreenKeyboard.Size = New System.Drawing.Size(372, 62)
        Me.pnlTouchscreenKeyboard.TabIndex = 60
        '
        'slTouchscreenKeyboard
        '
        Me.slTouchscreenKeyboard.Location = New System.Drawing.Point(252, 6)
        Me.slTouchscreenKeyboard.Name = "slTouchscreenKeyboard"
        Me.slTouchscreenKeyboard.Size = New System.Drawing.Size(102, 29)
        Me.slTouchscreenKeyboard.SwitchedOn = False
        Me.slTouchscreenKeyboard.TabIndex = 53
        '
        'lblTouchscreenKeyboard
        '
        Me.lblTouchscreenKeyboard.AutoSize = True
        Me.lblTouchscreenKeyboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTouchscreenKeyboard.ForeColor = System.Drawing.Color.White
        Me.lblTouchscreenKeyboard.Location = New System.Drawing.Point(7, 10)
        Me.lblTouchscreenKeyboard.Name = "lblTouchscreenKeyboard"
        Me.lblTouchscreenKeyboard.Size = New System.Drawing.Size(235, 25)
        Me.lblTouchscreenKeyboard.TabIndex = 2
        Me.lblTouchscreenKeyboard.Text = "Touchscreen Keyboard"
        '
        'pnlNotificationPopup
        '
        Me.pnlNotificationPopup.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlNotificationPopup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNotificationPopup.Controls.Add(Me.txtNotifyText)
        Me.pnlNotificationPopup.Controls.Add(Me.GroupBox2)
        Me.pnlNotificationPopup.Controls.Add(Me.lblNotifyText)
        Me.pnlNotificationPopup.Controls.Add(Me.lblNotificationPopup)
        Me.pnlNotificationPopup.Location = New System.Drawing.Point(22, 396)
        Me.pnlNotificationPopup.Name = "pnlNotificationPopup"
        Me.pnlNotificationPopup.Size = New System.Drawing.Size(372, 84)
        Me.pnlNotificationPopup.TabIndex = 59
        '
        'txtNotifyText
        '
        Me.txtNotifyText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotifyText.Location = New System.Drawing.Point(149, 52)
        Me.txtNotifyText.Name = "txtNotifyText"
        Me.txtNotifyText.Size = New System.Drawing.Size(205, 22)
        Me.txtNotifyText.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.txtNotifyText, "Text for Notification Pop Up (use %u for employee name)")
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'lblNotifyText
        '
        Me.lblNotifyText.AutoSize = True
        Me.lblNotifyText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifyText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblNotifyText.Location = New System.Drawing.Point(9, 55)
        Me.lblNotifyText.Name = "lblNotifyText"
        Me.lblNotifyText.Size = New System.Drawing.Size(134, 16)
        Me.lblNotifyText.TabIndex = 39
        Me.lblNotifyText.Text = "Notification Message"
        Me.ToolTip1.SetToolTip(Me.lblNotifyText, "Text for Notification Pop Up (use %u for employee name)")
        '
        'lblNotificationPopup
        '
        Me.lblNotificationPopup.AutoSize = True
        Me.lblNotificationPopup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificationPopup.ForeColor = System.Drawing.Color.White
        Me.lblNotificationPopup.Location = New System.Drawing.Point(7, 10)
        Me.lblNotificationPopup.Name = "lblNotificationPopup"
        Me.lblNotificationPopup.Size = New System.Drawing.Size(281, 25)
        Me.lblNotificationPopup.TabIndex = 2
        Me.lblNotificationPopup.Text = "Notification Message Popup"
        '
        'pnlSignInScreen
        '
        Me.pnlSignInScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlSignInScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSignInScreen.Controls.Add(Me.picVisitor)
        Me.pnlSignInScreen.Controls.Add(Me.txtSettingInstructions)
        Me.pnlSignInScreen.Controls.Add(Me.chkEmailVisible)
        Me.pnlSignInScreen.Controls.Add(Me.chkCompanyVisible)
        Me.pnlSignInScreen.Controls.Add(Me.txtVisitingText)
        Me.pnlSignInScreen.Controls.Add(Me.txtNameText)
        Me.pnlSignInScreen.Controls.Add(Me.txtEmailText)
        Me.pnlSignInScreen.Controls.Add(Me.txtCompanyText)
        Me.pnlSignInScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlSignInScreen.Location = New System.Drawing.Point(103, 28)
        Me.pnlSignInScreen.Name = "pnlSignInScreen"
        Me.pnlSignInScreen.Size = New System.Drawing.Size(652, 353)
        Me.pnlSignInScreen.TabIndex = 58
        '
        'picVisitor
        '
        Me.picVisitor.Image = Global.Receptio.My.Resources.Resources.blank_person
        Me.picVisitor.Location = New System.Drawing.Point(373, 36)
        Me.picVisitor.Name = "picVisitor"
        Me.picVisitor.Size = New System.Drawing.Size(241, 141)
        Me.picVisitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVisitor.TabIndex = 50
        Me.picVisitor.TabStop = False
        '
        'txtSettingInstructions
        '
        Me.txtSettingInstructions.Location = New System.Drawing.Point(394, 231)
        Me.txtSettingInstructions.Multiline = True
        Me.txtSettingInstructions.Name = "txtSettingInstructions"
        Me.txtSettingInstructions.Size = New System.Drawing.Size(203, 59)
        Me.txtSettingInstructions.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtSettingInstructions, "Enter text for Instructions")
        '
        'chkEmailVisible
        '
        Me.chkEmailVisible.AutoSize = True
        Me.chkEmailVisible.ForeColor = System.Drawing.Color.White
        Me.chkEmailVisible.Location = New System.Drawing.Point(304, 211)
        Me.chkEmailVisible.Name = "chkEmailVisible"
        Me.chkEmailVisible.Size = New System.Drawing.Size(56, 17)
        Me.chkEmailVisible.TabIndex = 48
        Me.chkEmailVisible.Text = "Visible"
        Me.ToolTip1.SetToolTip(Me.chkEmailVisible, "Enable to make this option visible")
        Me.chkEmailVisible.UseVisualStyleBackColor = True
        '
        'chkCompanyVisible
        '
        Me.chkCompanyVisible.AutoSize = True
        Me.chkCompanyVisible.ForeColor = System.Drawing.Color.White
        Me.chkCompanyVisible.Location = New System.Drawing.Point(304, 160)
        Me.chkCompanyVisible.Name = "chkCompanyVisible"
        Me.chkCompanyVisible.Size = New System.Drawing.Size(56, 17)
        Me.chkCompanyVisible.TabIndex = 49
        Me.chkCompanyVisible.Text = "Visible"
        Me.ToolTip1.SetToolTip(Me.chkCompanyVisible, "Enable to make this option visible")
        Me.chkCompanyVisible.UseVisualStyleBackColor = True
        '
        'txtVisitingText
        '
        Me.txtVisitingText.Location = New System.Drawing.Point(19, 52)
        Me.txtVisitingText.Name = "txtVisitingText"
        Me.txtVisitingText.Size = New System.Drawing.Size(279, 20)
        Me.txtVisitingText.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.txtVisitingText, "Text for Visitor field of form")
        '
        'txtNameText
        '
        Me.txtNameText.Location = New System.Drawing.Point(19, 108)
        Me.txtNameText.Name = "txtNameText"
        Me.txtNameText.Size = New System.Drawing.Size(279, 20)
        Me.txtNameText.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.txtNameText, "Text for Name field of form")
        '
        'txtEmailText
        '
        Me.txtEmailText.Location = New System.Drawing.Point(19, 208)
        Me.txtEmailText.Name = "txtEmailText"
        Me.txtEmailText.Size = New System.Drawing.Size(279, 20)
        Me.txtEmailText.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.txtEmailText, "Text for E-mail Address field of form")
        '
        'txtCompanyText
        '
        Me.txtCompanyText.Location = New System.Drawing.Point(19, 157)
        Me.txtCompanyText.Name = "txtCompanyText"
        Me.txtCompanyText.Size = New System.Drawing.Size(279, 20)
        Me.txtCompanyText.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.txtCompanyText, "Text for Company field of form")
        '
        'tabSignOutScreen
        '
        Me.tabSignOutScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.tabSignOutScreen.Controls.Add(Me.pnlSignOutMessagePopup)
        Me.tabSignOutScreen.Controls.Add(Me.pnlSignOutScreen)
        Me.tabSignOutScreen.ImageIndex = 5
        Me.tabSignOutScreen.Location = New System.Drawing.Point(4, 31)
        Me.tabSignOutScreen.Name = "tabSignOutScreen"
        Me.tabSignOutScreen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSignOutScreen.Size = New System.Drawing.Size(845, 622)
        Me.tabSignOutScreen.TabIndex = 5
        Me.tabSignOutScreen.Text = "Sign Out Screen"
        '
        'pnlSignOutMessagePopup
        '
        Me.pnlSignOutMessagePopup.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlSignOutMessagePopup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSignOutMessagePopup.Controls.Add(Me.txtSignOutText)
        Me.pnlSignOutMessagePopup.Controls.Add(Me.lblSignOutText)
        Me.pnlSignOutMessagePopup.Controls.Add(Me.GroupBox5)
        Me.pnlSignOutMessagePopup.Controls.Add(Me.lblSignOutMessagePopup)
        Me.pnlSignOutMessagePopup.Location = New System.Drawing.Point(103, 417)
        Me.pnlSignOutMessagePopup.Name = "pnlSignOutMessagePopup"
        Me.pnlSignOutMessagePopup.Size = New System.Drawing.Size(372, 84)
        Me.pnlSignOutMessagePopup.TabIndex = 60
        '
        'txtSignOutText
        '
        Me.txtSignOutText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignOutText.Location = New System.Drawing.Point(133, 50)
        Me.txtSignOutText.Name = "txtSignOutText"
        Me.txtSignOutText.Size = New System.Drawing.Size(221, 22)
        Me.txtSignOutText.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.txtSignOutText, "Text for Sign Out Pop Up")
        '
        'lblSignOutText
        '
        Me.lblSignOutText.AutoSize = True
        Me.lblSignOutText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignOutText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSignOutText.Location = New System.Drawing.Point(9, 54)
        Me.lblSignOutText.Name = "lblSignOutText"
        Me.lblSignOutText.Size = New System.Drawing.Size(118, 16)
        Me.lblSignOutText.TabIndex = 39
        Me.lblSignOutText.Text = "Sign Out Message"
        Me.ToolTip1.SetToolTip(Me.lblSignOutText, "Text for Sign Out Pop Up")
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'lblSignOutMessagePopup
        '
        Me.lblSignOutMessagePopup.AutoSize = True
        Me.lblSignOutMessagePopup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignOutMessagePopup.ForeColor = System.Drawing.Color.White
        Me.lblSignOutMessagePopup.Location = New System.Drawing.Point(7, 10)
        Me.lblSignOutMessagePopup.Name = "lblSignOutMessagePopup"
        Me.lblSignOutMessagePopup.Size = New System.Drawing.Size(257, 25)
        Me.lblSignOutMessagePopup.TabIndex = 2
        Me.lblSignOutMessagePopup.Text = "Sign Out Message Popup"
        '
        'pnlSignOutScreen
        '
        Me.pnlSignOutScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlSignOutScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSignOutScreen.Controls.Add(Me.txtSignOutVisitor)
        Me.pnlSignOutScreen.Controls.Add(Me.txtSignOutInstructions)
        Me.pnlSignOutScreen.Controls.Add(Me.picSignOut)
        Me.pnlSignOutScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlSignOutScreen.Location = New System.Drawing.Point(103, 28)
        Me.pnlSignOutScreen.Name = "pnlSignOutScreen"
        Me.pnlSignOutScreen.Size = New System.Drawing.Size(652, 353)
        Me.pnlSignOutScreen.TabIndex = 59
        '
        'txtSignOutVisitor
        '
        Me.txtSignOutVisitor.Location = New System.Drawing.Point(39, 123)
        Me.txtSignOutVisitor.Name = "txtSignOutVisitor"
        Me.txtSignOutVisitor.Size = New System.Drawing.Size(279, 20)
        Me.txtSignOutVisitor.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.txtSignOutVisitor, "Text for Visitor field of form")
        '
        'txtSignOutInstructions
        '
        Me.txtSignOutInstructions.Location = New System.Drawing.Point(394, 231)
        Me.txtSignOutInstructions.Multiline = True
        Me.txtSignOutInstructions.Name = "txtSignOutInstructions"
        Me.txtSignOutInstructions.Size = New System.Drawing.Size(203, 59)
        Me.txtSignOutInstructions.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.txtSignOutInstructions, "Enter text for Instructions")
        '
        'picSignOut
        '
        Me.picSignOut.Image = Global.Receptio.My.Resources.Resources.blank_person
        Me.picSignOut.Location = New System.Drawing.Point(373, 36)
        Me.picSignOut.Name = "picSignOut"
        Me.picSignOut.Size = New System.Drawing.Size(241, 141)
        Me.picSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSignOut.TabIndex = 50
        Me.picSignOut.TabStop = False
        '
        'tabEmployeeDirectory
        '
        Me.tabEmployeeDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.tabEmployeeDirectory.Controls.Add(Me.pnlEmployeeDirectory)
        Me.tabEmployeeDirectory.Controls.Add(Me.pnlEmployeeInformation)
        Me.tabEmployeeDirectory.Controls.Add(Me.MenuStrip1)
        Me.tabEmployeeDirectory.ImageIndex = 1
        Me.tabEmployeeDirectory.Location = New System.Drawing.Point(4, 31)
        Me.tabEmployeeDirectory.Name = "tabEmployeeDirectory"
        Me.tabEmployeeDirectory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmployeeDirectory.Size = New System.Drawing.Size(845, 622)
        Me.tabEmployeeDirectory.TabIndex = 6
        Me.tabEmployeeDirectory.Text = "Employee Directory"
        '
        'pnlEmployeeDirectory
        '
        Me.pnlEmployeeDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlEmployeeDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEmployeeDirectory.Controls.Add(Me.GroupBox13)
        Me.pnlEmployeeDirectory.Controls.Add(Me.lblEmployeeDirectory)
        Me.pnlEmployeeDirectory.Controls.Add(Me.btnDelete)
        Me.pnlEmployeeDirectory.Controls.Add(Me.lstEmployees)
        Me.pnlEmployeeDirectory.Controls.Add(Me.btnAdd)
        Me.pnlEmployeeDirectory.Location = New System.Drawing.Point(32, 78)
        Me.pnlEmployeeDirectory.Name = "pnlEmployeeDirectory"
        Me.pnlEmployeeDirectory.Size = New System.Drawing.Size(372, 370)
        Me.pnlEmployeeDirectory.TabIndex = 69
        '
        'GroupBox13
        '
        Me.GroupBox13.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox13.TabIndex = 3
        Me.GroupBox13.TabStop = False
        '
        'lblEmployeeDirectory
        '
        Me.lblEmployeeDirectory.AutoSize = True
        Me.lblEmployeeDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeDirectory.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeDirectory.Location = New System.Drawing.Point(7, 10)
        Me.lblEmployeeDirectory.Name = "lblEmployeeDirectory"
        Me.lblEmployeeDirectory.Size = New System.Drawing.Size(199, 25)
        Me.lblEmployeeDirectory.TabIndex = 2
        Me.lblEmployeeDirectory.Text = "Employee Directory"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(232, 96)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 35)
        Me.btnDelete.TabIndex = 65
        Me.btnDelete.Text = "Delete Employee"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lstEmployees
        '
        Me.lstEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEmployees.FullRowSelect = True
        Me.lstEmployees.HideSelection = False
        Me.lstEmployees.Location = New System.Drawing.Point(12, 54)
        Me.lstEmployees.MultiSelect = False
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(207, 301)
        Me.lstEmployees.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstEmployees.TabIndex = 67
        Me.lstEmployees.UseCompatibleStateImageBehavior = False
        Me.lstEmployees.View = System.Windows.Forms.View.List
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(232, 54)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(122, 35)
        Me.btnAdd.TabIndex = 66
        Me.btnAdd.Text = "Add Employee"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnlEmployeeInformation
        '
        Me.pnlEmployeeInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlEmployeeInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEmployeeInformation.Controls.Add(Me.btnSave)
        Me.pnlEmployeeInformation.Controls.Add(Me.txtLastName)
        Me.pnlEmployeeInformation.Controls.Add(Me.txtPhone)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblLastName)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblPhone)
        Me.pnlEmployeeInformation.Controls.Add(Me.GroupBox12)
        Me.pnlEmployeeInformation.Controls.Add(Me.txtEmail)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblEmployeeInformation)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblEmail)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblIDNum)
        Me.pnlEmployeeInformation.Controls.Add(Me.txtTitle)
        Me.pnlEmployeeInformation.Controls.Add(Me.PictureBox1)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblTitle)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblID)
        Me.pnlEmployeeInformation.Controls.Add(Me.lblFirstName)
        Me.pnlEmployeeInformation.Controls.Add(Me.txtFirstName)
        Me.pnlEmployeeInformation.Location = New System.Drawing.Point(434, 78)
        Me.pnlEmployeeInformation.Name = "pnlEmployeeInformation"
        Me.pnlEmployeeInformation.Size = New System.Drawing.Size(372, 370)
        Me.pnlEmployeeInformation.TabIndex = 68
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(133, 320)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 35)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(91, 187)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(263, 22)
        Me.txtLastName.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(64, 274)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(292, 22)
        Me.txtPhone.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(12, 190)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(73, 16)
        Me.lblLastName.TabIndex = 14
        Me.lblLastName.Text = "Last Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(12, 277)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(47, 16)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone"
        '
        'GroupBox12
        '
        Me.GroupBox12.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(133, 245)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(224, 22)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmployeeInformation
        '
        Me.lblEmployeeInformation.AutoSize = True
        Me.lblEmployeeInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeInformation.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeInformation.Location = New System.Drawing.Point(7, 10)
        Me.lblEmployeeInformation.Name = "lblEmployeeInformation"
        Me.lblEmployeeInformation.Size = New System.Drawing.Size(219, 25)
        Me.lblEmployeeInformation.TabIndex = 2
        Me.lblEmployeeInformation.Text = "Employee Information"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(12, 248)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(115, 16)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "E-Mail Address(s)"
        '
        'lblIDNum
        '
        Me.lblIDNum.AutoSize = True
        Me.lblIDNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblIDNum.Location = New System.Drawing.Point(32, 54)
        Me.lblIDNum.Name = "lblIDNum"
        Me.lblIDNum.Size = New System.Drawing.Size(15, 16)
        Me.lblIDNum.TabIndex = 12
        Me.lblIDNum.Text = "0"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(52, 216)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(304, 22)
        Me.txtTitle.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(270, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 85)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 219)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(34, 16)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Title"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(9, 54)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 16)
        Me.lblID.TabIndex = 11
        Me.lblID.Text = "ID:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(12, 160)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(73, 16)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(91, 157)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(263, 22)
        Me.txtFirstName.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(839, 25)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFromCSVFileToolStripMenuItem, Me.EmployeeDirectoryLocationToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ImportFromCSVFileToolStripMenuItem
        '
        Me.ImportFromCSVFileToolStripMenuItem.Name = "ImportFromCSVFileToolStripMenuItem"
        Me.ImportFromCSVFileToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ImportFromCSVFileToolStripMenuItem.Text = "Import From CSV File"
        '
        'EmployeeDirectoryLocationToolStripMenuItem
        '
        Me.EmployeeDirectoryLocationToolStripMenuItem.Name = "EmployeeDirectoryLocationToolStripMenuItem"
        Me.EmployeeDirectoryLocationToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.EmployeeDirectoryLocationToolStripMenuItem.Text = "Employee Directory Location"
        '
        'tabVisitorLog
        '
        Me.tabVisitorLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.tabVisitorLog.Controls.Add(Me.Panel1)
        Me.tabVisitorLog.Controls.Add(Me.FastDataListView1)
        Me.tabVisitorLog.Controls.Add(Me.MenuStrip2)
        Me.tabVisitorLog.ImageIndex = 0
        Me.tabVisitorLog.Location = New System.Drawing.Point(4, 31)
        Me.tabVisitorLog.Name = "tabVisitorLog"
        Me.tabVisitorLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVisitorLog.Size = New System.Drawing.Size(845, 622)
        Me.tabVisitorLog.TabIndex = 7
        Me.tabVisitorLog.Text = "Visitor Log"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblTotalVisits)
        Me.Panel1.Controls.Add(Me.lblFirstVisit)
        Me.Panel1.Controls.Add(Me.lblLastVisit)
        Me.Panel1.Controls.Add(Me.lblVisitorName)
        Me.Panel1.Controls.Add(Me.GroupBox10)
        Me.Panel1.Controls.Add(Me.lblVisitorInformation)
        Me.Panel1.Controls.Add(Me.picSignInPicture)
        Me.Panel1.Location = New System.Drawing.Point(246, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 218)
        Me.Panel1.TabIndex = 66
        '
        'lblTotalVisits
        '
        Me.lblTotalVisits.AutoSize = True
        Me.lblTotalVisits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVisits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblTotalVisits.Location = New System.Drawing.Point(9, 149)
        Me.lblTotalVisits.Name = "lblTotalVisits"
        Me.lblTotalVisits.Size = New System.Drawing.Size(74, 16)
        Me.lblTotalVisits.TabIndex = 66
        Me.lblTotalVisits.Text = "Total Visits"
        Me.ToolTip1.SetToolTip(Me.lblTotalVisits, "Total number of visits")
        '
        'lblFirstVisit
        '
        Me.lblFirstVisit.AutoSize = True
        Me.lblFirstVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstVisit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblFirstVisit.Location = New System.Drawing.Point(9, 96)
        Me.lblFirstVisit.Name = "lblFirstVisit"
        Me.lblFirstVisit.Size = New System.Drawing.Size(61, 16)
        Me.lblFirstVisit.TabIndex = 65
        Me.lblFirstVisit.Text = "First Visit"
        Me.ToolTip1.SetToolTip(Me.lblFirstVisit, "First visit")
        '
        'lblLastVisit
        '
        Me.lblLastVisit.AutoSize = True
        Me.lblLastVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastVisit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblLastVisit.Location = New System.Drawing.Point(9, 121)
        Me.lblLastVisit.Name = "lblLastVisit"
        Me.lblLastVisit.Size = New System.Drawing.Size(61, 16)
        Me.lblLastVisit.TabIndex = 15
        Me.lblLastVisit.Text = "Last Visit"
        Me.ToolTip1.SetToolTip(Me.lblLastVisit, "Last visit")
        '
        'lblVisitorName
        '
        Me.lblVisitorName.AutoSize = True
        Me.lblVisitorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblVisitorName.Location = New System.Drawing.Point(8, 54)
        Me.lblVisitorName.Name = "lblVisitorName"
        Me.lblVisitorName.Size = New System.Drawing.Size(77, 24)
        Me.lblVisitorName.TabIndex = 2
        Me.lblVisitorName.Text = "Nobody"
        Me.ToolTip1.SetToolTip(Me.lblVisitorName, "Version information")
        '
        'GroupBox10
        '
        Me.GroupBox10.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        '
        'lblVisitorInformation
        '
        Me.lblVisitorInformation.AutoSize = True
        Me.lblVisitorInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorInformation.ForeColor = System.Drawing.Color.White
        Me.lblVisitorInformation.Location = New System.Drawing.Point(7, 10)
        Me.lblVisitorInformation.Name = "lblVisitorInformation"
        Me.lblVisitorInformation.Size = New System.Drawing.Size(184, 25)
        Me.lblVisitorInformation.TabIndex = 2
        Me.lblVisitorInformation.Text = "Visitor Information"
        '
        'picSignInPicture
        '
        Me.picSignInPicture.BackColor = System.Drawing.Color.Transparent
        Me.picSignInPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picSignInPicture.Location = New System.Drawing.Point(161, 51)
        Me.picSignInPicture.Name = "picSignInPicture"
        Me.picSignInPicture.Size = New System.Drawing.Size(193, 149)
        Me.picSignInPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSignInPicture.TabIndex = 64
        Me.picSignInPicture.TabStop = False
        '
        'FastDataListView1
        '
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn2)
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn9)
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn10)
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn11)
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn1)
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn12)
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn13)
        Me.FastDataListView1.AllColumns.Add(Me.OlvColumn14)
        Me.FastDataListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FastDataListView1.AutoGenerateColumns = False
        Me.FastDataListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn2, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn11, Me.OlvColumn1, Me.OlvColumn12, Me.OlvColumn13, Me.OlvColumn14})
        Me.FastDataListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.FastDataListView1.DataSource = Nothing
        Me.FastDataListView1.EmptyListMsg = "No data"
        Me.FastDataListView1.FullRowSelect = True
        Me.FastDataListView1.Location = New System.Drawing.Point(8, 280)
        Me.FastDataListView1.Name = "FastDataListView1"
        Me.FastDataListView1.ShowGroups = False
        Me.FastDataListView1.ShowItemCountOnGroups = True
        Me.FastDataListView1.Size = New System.Drawing.Size(822, 320)
        Me.FastDataListView1.TabIndex = 65
        Me.FastDataListView1.UseAlternatingBackColors = True
        Me.FastDataListView1.UseCompatibleStateImageBehavior = False
        Me.FastDataListView1.UseFilterIndicator = True
        Me.FastDataListView1.UseFiltering = True
        Me.FastDataListView1.UseHotItem = True
        Me.FastDataListView1.UseTranslucentHotItem = True
        Me.FastDataListView1.UseTranslucentSelection = True
        Me.FastDataListView1.View = System.Windows.Forms.View.Details
        Me.FastDataListView1.VirtualMode = True
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "id"
        Me.OlvColumn2.Text = "ID"
        Me.OlvColumn2.Width = 40
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "date"
        Me.OlvColumn9.Text = "Date"
        Me.OlvColumn9.Width = 80
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "name"
        Me.OlvColumn10.Text = "Name"
        Me.OlvColumn10.Width = 140
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "company"
        Me.OlvColumn11.Text = "Company"
        Me.OlvColumn11.Width = 140
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "email"
        Me.OlvColumn1.Text = "E-Mail"
        Me.OlvColumn1.Width = 140
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "visiting"
        Me.OlvColumn12.Text = "Visiting"
        Me.OlvColumn12.Width = 140
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "SignIn"
        Me.OlvColumn13.Text = "In"
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "SignOut"
        Me.OlvColumn14.Text = "Out"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(839, 25)
        Me.MenuStrip2.TabIndex = 68
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitorLogLocationToolStripMenuItem, Me.ExportVisitorLogToolStripMenuItem})
        Me.OptionsToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(66, 21)
        Me.OptionsToolStripMenuItem1.Text = "Options"
        '
        'VisitorLogLocationToolStripMenuItem
        '
        Me.VisitorLogLocationToolStripMenuItem.Name = "VisitorLogLocationToolStripMenuItem"
        Me.VisitorLogLocationToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VisitorLogLocationToolStripMenuItem.Text = "Visitor Log Location"
        '
        'tabSystem
        '
        Me.tabSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.tabSystem.Controls.Add(Me.PictureBox2)
        Me.tabSystem.Controls.Add(Me.pnlSystemInformation)
        Me.tabSystem.Controls.Add(Me.pnlEmailSettings)
        Me.tabSystem.Controls.Add(Me.pnlCameraSettings)
        Me.tabSystem.Controls.Add(Me.pnlSystemSettings)
        Me.tabSystem.ImageIndex = 3
        Me.tabSystem.Location = New System.Drawing.Point(4, 31)
        Me.tabSystem.Name = "tabSystem"
        Me.tabSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSystem.Size = New System.Drawing.Size(845, 622)
        Me.tabSystem.TabIndex = 1
        Me.tabSystem.Text = "System"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(737, 558)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'pnlSystemInformation
        '
        Me.pnlSystemInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlSystemInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSystemInformation.Controls.Add(Me.btnEditLicense)
        Me.pnlSystemInformation.Controls.Add(Me.lblLicense)
        Me.pnlSystemInformation.Controls.Add(Me.lblSoftwareVersion)
        Me.pnlSystemInformation.Controls.Add(Me.GroupBox9)
        Me.pnlSystemInformation.Controls.Add(Me.lblSystemInformation)
        Me.pnlSystemInformation.Location = New System.Drawing.Point(432, 387)
        Me.pnlSystemInformation.Name = "pnlSystemInformation"
        Me.pnlSystemInformation.Size = New System.Drawing.Size(372, 167)
        Me.pnlSystemInformation.TabIndex = 65
        '
        'btnEditLicense
        '
        Me.btnEditLicense.Enabled = False
        Me.btnEditLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditLicense.Location = New System.Drawing.Point(133, 110)
        Me.btnEditLicense.Name = "btnEditLicense"
        Me.btnEditLicense.Size = New System.Drawing.Size(100, 40)
        Me.btnEditLicense.TabIndex = 16
        Me.btnEditLicense.Text = "Edit License"
        Me.btnEditLicense.UseVisualStyleBackColor = True
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblLicense.Location = New System.Drawing.Point(9, 82)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(55, 16)
        Me.lblLicense.TabIndex = 15
        Me.lblLicense.Text = "License"
        Me.ToolTip1.SetToolTip(Me.lblLicense, "License information")
        '
        'lblSoftwareVersion
        '
        Me.lblSoftwareVersion.AutoSize = True
        Me.lblSoftwareVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoftwareVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSoftwareVersion.Location = New System.Drawing.Point(9, 54)
        Me.lblSoftwareVersion.Name = "lblSoftwareVersion"
        Me.lblSoftwareVersion.Size = New System.Drawing.Size(109, 16)
        Me.lblSoftwareVersion.TabIndex = 2
        Me.lblSoftwareVersion.Text = "Software Version"
        Me.ToolTip1.SetToolTip(Me.lblSoftwareVersion, "Version information")
        '
        'GroupBox9
        '
        Me.GroupBox9.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        '
        'lblSystemInformation
        '
        Me.lblSystemInformation.AutoSize = True
        Me.lblSystemInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemInformation.ForeColor = System.Drawing.Color.White
        Me.lblSystemInformation.Location = New System.Drawing.Point(7, 10)
        Me.lblSystemInformation.Name = "lblSystemInformation"
        Me.lblSystemInformation.Size = New System.Drawing.Size(195, 25)
        Me.lblSystemInformation.TabIndex = 2
        Me.lblSystemInformation.Text = "System Information"
        '
        'pnlEmailSettings
        '
        Me.pnlEmailSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlEmailSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEmailSettings.Controls.Add(Me.cboEmailServerType)
        Me.pnlEmailSettings.Controls.Add(Me.lblEmailServerType)
        Me.pnlEmailSettings.Controls.Add(Me.slEmailNotifications)
        Me.pnlEmailSettings.Controls.Add(Me.txtMailFrom)
        Me.pnlEmailSettings.Controls.Add(Me.chkEnableSSL)
        Me.pnlEmailSettings.Controls.Add(Me.lblEmailFrom)
        Me.pnlEmailSettings.Controls.Add(Me.GroupBox8)
        Me.pnlEmailSettings.Controls.Add(Me.chkAuthentication)
        Me.pnlEmailSettings.Controls.Add(Me.lblEmailNotifications)
        Me.pnlEmailSettings.Controls.Add(Me.lblSMTPUserName)
        Me.pnlEmailSettings.Controls.Add(Me.lblSMTPServerName)
        Me.pnlEmailSettings.Controls.Add(Me.txtSMTPPort)
        Me.pnlEmailSettings.Controls.Add(Me.txtSMTPUserName)
        Me.pnlEmailSettings.Controls.Add(Me.lblSMTPPort)
        Me.pnlEmailSettings.Controls.Add(Me.lblSMTPPassword)
        Me.pnlEmailSettings.Controls.Add(Me.txtSMTPPassword)
        Me.pnlEmailSettings.Controls.Add(Me.txtSMTPServerName)
        Me.pnlEmailSettings.Location = New System.Drawing.Point(432, 52)
        Me.pnlEmailSettings.Name = "pnlEmailSettings"
        Me.pnlEmailSettings.Size = New System.Drawing.Size(372, 290)
        Me.pnlEmailSettings.TabIndex = 64
        '
        'cboEmailServerType
        '
        Me.cboEmailServerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmailServerType.FormattingEnabled = True
        Me.cboEmailServerType.Location = New System.Drawing.Point(133, 49)
        Me.cboEmailServerType.Name = "cboEmailServerType"
        Me.cboEmailServerType.Size = New System.Drawing.Size(221, 24)
        Me.cboEmailServerType.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.cboEmailServerType, "Select which Email server type to use")
        '
        'lblEmailServerType
        '
        Me.lblEmailServerType.AutoSize = True
        Me.lblEmailServerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailServerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblEmailServerType.Location = New System.Drawing.Point(9, 54)
        Me.lblEmailServerType.Name = "lblEmailServerType"
        Me.lblEmailServerType.Size = New System.Drawing.Size(120, 16)
        Me.lblEmailServerType.TabIndex = 63
        Me.lblEmailServerType.Text = "Email Server Type"
        '
        'slEmailNotifications
        '
        Me.slEmailNotifications.Location = New System.Drawing.Point(252, 6)
        Me.slEmailNotifications.Name = "slEmailNotifications"
        Me.slEmailNotifications.Size = New System.Drawing.Size(102, 29)
        Me.slEmailNotifications.SwitchedOn = False
        Me.slEmailNotifications.TabIndex = 62
        '
        'txtMailFrom
        '
        Me.txtMailFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailFrom.Location = New System.Drawing.Point(91, 204)
        Me.txtMailFrom.Name = "txtMailFrom"
        Me.txtMailFrom.Size = New System.Drawing.Size(263, 22)
        Me.txtMailFrom.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtMailFrom, "Email address that all mail is from")
        '
        'chkEnableSSL
        '
        Me.chkEnableSSL.AutoSize = True
        Me.chkEnableSSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnableSSL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.chkEnableSSL.Location = New System.Drawing.Point(12, 258)
        Me.chkEnableSSL.Name = "chkEnableSSL"
        Me.chkEnableSSL.Size = New System.Drawing.Size(52, 20)
        Me.chkEnableSSL.TabIndex = 9
        Me.chkEnableSSL.Text = "SSL"
        Me.ToolTip1.SetToolTip(Me.chkEnableSSL, "Enable if the server requires SSL connection")
        Me.chkEnableSSL.UseVisualStyleBackColor = True
        '
        'lblEmailFrom
        '
        Me.lblEmailFrom.AutoSize = True
        Me.lblEmailFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblEmailFrom.Location = New System.Drawing.Point(9, 207)
        Me.lblEmailFrom.Name = "lblEmailFrom"
        Me.lblEmailFrom.Size = New System.Drawing.Size(76, 16)
        Me.lblEmailFrom.TabIndex = 10
        Me.lblEmailFrom.Text = "Email From"
        Me.ToolTip1.SetToolTip(Me.lblEmailFrom, "Email address that all mail is from")
        '
        'GroupBox8
        '
        Me.GroupBox8.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        '
        'chkAuthentication
        '
        Me.chkAuthentication.AutoSize = True
        Me.chkAuthentication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuthentication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.chkAuthentication.Location = New System.Drawing.Point(12, 232)
        Me.chkAuthentication.Name = "chkAuthentication"
        Me.chkAuthentication.Size = New System.Drawing.Size(161, 20)
        Me.chkAuthentication.TabIndex = 12
        Me.chkAuthentication.Text = "Require Authentication"
        Me.ToolTip1.SetToolTip(Me.chkAuthentication, "Enable f the server requires authentication")
        Me.chkAuthentication.UseVisualStyleBackColor = True
        '
        'lblEmailNotifications
        '
        Me.lblEmailNotifications.AutoSize = True
        Me.lblEmailNotifications.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailNotifications.ForeColor = System.Drawing.Color.White
        Me.lblEmailNotifications.Location = New System.Drawing.Point(7, 10)
        Me.lblEmailNotifications.Name = "lblEmailNotifications"
        Me.lblEmailNotifications.Size = New System.Drawing.Size(189, 25)
        Me.lblEmailNotifications.TabIndex = 2
        Me.lblEmailNotifications.Text = "Email Notifications"
        '
        'lblSMTPUserName
        '
        Me.lblSMTPUserName.AutoSize = True
        Me.lblSMTPUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMTPUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSMTPUserName.Location = New System.Drawing.Point(9, 115)
        Me.lblSMTPUserName.Name = "lblSMTPUserName"
        Me.lblSMTPUserName.Size = New System.Drawing.Size(118, 16)
        Me.lblSMTPUserName.TabIndex = 2
        Me.lblSMTPUserName.Text = "SMTP User Name"
        Me.ToolTip1.SetToolTip(Me.lblSMTPUserName, "User name associated with the SMTP server")
        '
        'lblSMTPServerName
        '
        Me.lblSMTPServerName.AutoSize = True
        Me.lblSMTPServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMTPServerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSMTPServerName.Location = New System.Drawing.Point(9, 83)
        Me.lblSMTPServerName.Name = "lblSMTPServerName"
        Me.lblSMTPServerName.Size = New System.Drawing.Size(129, 16)
        Me.lblSMTPServerName.TabIndex = 0
        Me.lblSMTPServerName.Text = "SMTP Server Name"
        Me.ToolTip1.SetToolTip(Me.lblSMTPServerName, "Name of the SMTP server (example: smtp.gmail.com)")
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMTPPort.Location = New System.Drawing.Point(88, 174)
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(266, 22)
        Me.txtSMTPPort.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtSMTPPort, "Server port used for SMTP connection")
        '
        'txtSMTPUserName
        '
        Me.txtSMTPUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMTPUserName.Location = New System.Drawing.Point(133, 112)
        Me.txtSMTPUserName.Name = "txtSMTPUserName"
        Me.txtSMTPUserName.Size = New System.Drawing.Size(221, 22)
        Me.txtSMTPUserName.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtSMTPUserName, "User name associated with the SMTP server")
        '
        'lblSMTPPort
        '
        Me.lblSMTPPort.AutoSize = True
        Me.lblSMTPPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMTPPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSMTPPort.Location = New System.Drawing.Point(9, 177)
        Me.lblSMTPPort.Name = "lblSMTPPort"
        Me.lblSMTPPort.Size = New System.Drawing.Size(73, 16)
        Me.lblSMTPPort.TabIndex = 6
        Me.lblSMTPPort.Text = "SMTP Port"
        Me.ToolTip1.SetToolTip(Me.lblSMTPPort, "Server port used for SMTP connection")
        '
        'lblSMTPPassword
        '
        Me.lblSMTPPassword.AutoSize = True
        Me.lblSMTPPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMTPPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSMTPPassword.Location = New System.Drawing.Point(9, 143)
        Me.lblSMTPPassword.Name = "lblSMTPPassword"
        Me.lblSMTPPassword.Size = New System.Drawing.Size(68, 16)
        Me.lblSMTPPassword.TabIndex = 4
        Me.lblSMTPPassword.Text = "Password"
        Me.ToolTip1.SetToolTip(Me.lblSMTPPassword, "Password associated with the SMTP server")
        '
        'txtSMTPPassword
        '
        Me.txtSMTPPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMTPPassword.Location = New System.Drawing.Point(83, 143)
        Me.txtSMTPPassword.Name = "txtSMTPPassword"
        Me.txtSMTPPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMTPPassword.Size = New System.Drawing.Size(271, 22)
        Me.txtSMTPPassword.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtSMTPPassword, "Password associated with the SMTP server")
        '
        'txtSMTPServerName
        '
        Me.txtSMTPServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMTPServerName.Location = New System.Drawing.Point(144, 80)
        Me.txtSMTPServerName.Name = "txtSMTPServerName"
        Me.txtSMTPServerName.Size = New System.Drawing.Size(210, 22)
        Me.txtSMTPServerName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtSMTPServerName, "Name of the SMTP server (example: smtp.gmail.com)")
        '
        'pnlCameraSettings
        '
        Me.pnlCameraSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlCameraSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCameraSettings.Controls.Add(Me.vplSettings)
        Me.pnlCameraSettings.Controls.Add(Me.GroupBox7)
        Me.pnlCameraSettings.Controls.Add(Me.cboSnapshotResolution)
        Me.pnlCameraSettings.Controls.Add(Me.lblCameraSettings)
        Me.pnlCameraSettings.Controls.Add(Me.lblSnapshotResolution)
        Me.pnlCameraSettings.Controls.Add(Me.cboCameraResolution)
        Me.pnlCameraSettings.Controls.Add(Me.lblSelectCamera)
        Me.pnlCameraSettings.Controls.Add(Me.cboVideoSource)
        Me.pnlCameraSettings.Controls.Add(Me.lblCameraResolution)
        Me.pnlCameraSettings.Controls.Add(Me.btnCameraSettings)
        Me.pnlCameraSettings.Location = New System.Drawing.Point(31, 242)
        Me.pnlCameraSettings.Name = "pnlCameraSettings"
        Me.pnlCameraSettings.Size = New System.Drawing.Size(372, 312)
        Me.pnlCameraSettings.TabIndex = 63
        '
        'vplSettings
        '
        Me.vplSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.vplSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vplSettings.KeepAspectRatio = True
        Me.vplSettings.Location = New System.Drawing.Point(84, 140)
        Me.vplSettings.Name = "vplSettings"
        Me.vplSettings.Size = New System.Drawing.Size(213, 160)
        Me.vplSettings.TabIndex = 56
        Me.vplSettings.TabStop = False
        Me.vplSettings.Text = "vplSettings"
        Me.vplSettings.VideoSource = Nothing
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        '
        'cboSnapshotResolution
        '
        Me.cboSnapshotResolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSnapshotResolution.FormattingEnabled = True
        Me.cboSnapshotResolution.Items.AddRange(New Object() {"Small", "Medium", "Large", "Camera Resolution"})
        Me.cboSnapshotResolution.Location = New System.Drawing.Point(155, 107)
        Me.cboSnapshotResolution.Name = "cboSnapshotResolution"
        Me.cboSnapshotResolution.Size = New System.Drawing.Size(142, 24)
        Me.cboSnapshotResolution.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.cboSnapshotResolution, "Select resolution to save the snapshots")
        '
        'lblCameraSettings
        '
        Me.lblCameraSettings.AutoSize = True
        Me.lblCameraSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCameraSettings.ForeColor = System.Drawing.Color.White
        Me.lblCameraSettings.Location = New System.Drawing.Point(7, 10)
        Me.lblCameraSettings.Name = "lblCameraSettings"
        Me.lblCameraSettings.Size = New System.Drawing.Size(171, 25)
        Me.lblCameraSettings.TabIndex = 2
        Me.lblCameraSettings.Text = "Camera Settings"
        '
        'lblSnapshotResolution
        '
        Me.lblSnapshotResolution.AutoSize = True
        Me.lblSnapshotResolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnapshotResolution.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSnapshotResolution.Location = New System.Drawing.Point(17, 110)
        Me.lblSnapshotResolution.Name = "lblSnapshotResolution"
        Me.lblSnapshotResolution.Size = New System.Drawing.Size(132, 16)
        Me.lblSnapshotResolution.TabIndex = 56
        Me.lblSnapshotResolution.Text = "Snapshot Resolution"
        '
        'cboCameraResolution
        '
        Me.cboCameraResolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCameraResolution.FormattingEnabled = True
        Me.cboCameraResolution.Location = New System.Drawing.Point(141, 79)
        Me.cboCameraResolution.Name = "cboCameraResolution"
        Me.cboCameraResolution.Size = New System.Drawing.Size(156, 24)
        Me.cboCameraResolution.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.cboCameraResolution, "Select camera resolution")
        '
        'lblSelectCamera
        '
        Me.lblSelectCamera.AutoSize = True
        Me.lblSelectCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectCamera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSelectCamera.Location = New System.Drawing.Point(12, 54)
        Me.lblSelectCamera.Name = "lblSelectCamera"
        Me.lblSelectCamera.Size = New System.Drawing.Size(97, 16)
        Me.lblSelectCamera.TabIndex = 7
        Me.lblSelectCamera.Text = "Select Camera"
        '
        'cboVideoSource
        '
        Me.cboVideoSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoSource.FormattingEnabled = True
        Me.cboVideoSource.Location = New System.Drawing.Point(117, 51)
        Me.cboVideoSource.Name = "cboVideoSource"
        Me.cboVideoSource.Size = New System.Drawing.Size(180, 24)
        Me.cboVideoSource.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.cboVideoSource, "Select which USB camera to use")
        '
        'lblCameraResolution
        '
        Me.lblCameraResolution.AutoSize = True
        Me.lblCameraResolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCameraResolution.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblCameraResolution.Location = New System.Drawing.Point(12, 82)
        Me.lblCameraResolution.Name = "lblCameraResolution"
        Me.lblCameraResolution.Size = New System.Drawing.Size(123, 16)
        Me.lblCameraResolution.TabIndex = 55
        Me.lblCameraResolution.Text = "Camera Resolution"
        '
        'btnCameraSettings
        '
        Me.btnCameraSettings.Image = Global.Receptio.My.Resources.Resources.webcam
        Me.btnCameraSettings.Location = New System.Drawing.Point(316, 43)
        Me.btnCameraSettings.Name = "btnCameraSettings"
        Me.btnCameraSettings.Size = New System.Drawing.Size(38, 38)
        Me.btnCameraSettings.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.btnCameraSettings, "Camera settings")
        Me.btnCameraSettings.UseVisualStyleBackColor = True
        '
        'pnlSystemSettings
        '
        Me.pnlSystemSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlSystemSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSystemSettings.Controls.Add(Me.lblGlobalFont)
        Me.pnlSystemSettings.Controls.Add(Me.txtLocationName)
        Me.pnlSystemSettings.Controls.Add(Me.lblFontSample)
        Me.pnlSystemSettings.Controls.Add(Me.lblSystemPassword)
        Me.pnlSystemSettings.Controls.Add(Me.lblLocationName)
        Me.pnlSystemSettings.Controls.Add(Me.txtSystemPassword)
        Me.pnlSystemSettings.Controls.Add(Me.GroupBox6)
        Me.pnlSystemSettings.Controls.Add(Me.lblSystemSettings)
        Me.pnlSystemSettings.Location = New System.Drawing.Point(31, 52)
        Me.pnlSystemSettings.Name = "pnlSystemSettings"
        Me.pnlSystemSettings.Size = New System.Drawing.Size(372, 156)
        Me.pnlSystemSettings.TabIndex = 62
        '
        'lblGlobalFont
        '
        Me.lblGlobalFont.AutoSize = True
        Me.lblGlobalFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGlobalFont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblGlobalFont.Location = New System.Drawing.Point(9, 105)
        Me.lblGlobalFont.Name = "lblGlobalFont"
        Me.lblGlobalFont.Size = New System.Drawing.Size(77, 16)
        Me.lblGlobalFont.TabIndex = 15
        Me.lblGlobalFont.Text = "Global Font"
        Me.ToolTip1.SetToolTip(Me.lblGlobalFont, "The global font and font color used")
        '
        'txtLocationName
        '
        Me.txtLocationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocationName.Location = New System.Drawing.Point(131, 77)
        Me.txtLocationName.Name = "txtLocationName"
        Me.txtLocationName.Size = New System.Drawing.Size(223, 22)
        Me.txtLocationName.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtLocationName, "Name of the location of deployment (example: Front Lobby)")
        '
        'lblFontSample
        '
        Me.lblFontSample.AutoSize = True
        Me.lblFontSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFontSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFontSample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblFontSample.Location = New System.Drawing.Point(114, 105)
        Me.lblFontSample.Name = "lblFontSample"
        Me.lblFontSample.Size = New System.Drawing.Size(229, 16)
        Me.lblFontSample.TabIndex = 37
        Me.lblFontSample.Text = "This is a Sample of the Selected Font"
        Me.ToolTip1.SetToolTip(Me.lblFontSample, "Sample of the selected settings")
        '
        'lblSystemPassword
        '
        Me.lblSystemPassword.AutoSize = True
        Me.lblSystemPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSystemPassword.Location = New System.Drawing.Point(9, 54)
        Me.lblSystemPassword.Name = "lblSystemPassword"
        Me.lblSystemPassword.Size = New System.Drawing.Size(116, 16)
        Me.lblSystemPassword.TabIndex = 2
        Me.lblSystemPassword.Text = "System Password"
        '
        'lblLocationName
        '
        Me.lblLocationName.AutoSize = True
        Me.lblLocationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocationName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblLocationName.Location = New System.Drawing.Point(9, 80)
        Me.lblLocationName.Name = "lblLocationName"
        Me.lblLocationName.Size = New System.Drawing.Size(99, 16)
        Me.lblLocationName.TabIndex = 13
        Me.lblLocationName.Text = "Location Name"
        Me.ToolTip1.SetToolTip(Me.lblLocationName, "Name of the location of deployment (example: Front Lobby)")
        '
        'txtSystemPassword
        '
        Me.txtSystemPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemPassword.Location = New System.Drawing.Point(131, 51)
        Me.txtSystemPassword.Name = "txtSystemPassword"
        Me.txtSystemPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSystemPassword.Size = New System.Drawing.Size(223, 22)
        Me.txtSystemPassword.TabIndex = 3
        Me.txtSystemPassword.Text = "12345678"
        Me.ToolTip1.SetToolTip(Me.txtSystemPassword, "Password to restrict access to Settings and Vistor Logs")
        Me.txtSystemPassword.UseSystemPasswordChar = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(342, 2)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'lblSystemSettings
        '
        Me.lblSystemSettings.AutoSize = True
        Me.lblSystemSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemSettings.ForeColor = System.Drawing.Color.White
        Me.lblSystemSettings.Location = New System.Drawing.Point(7, 10)
        Me.lblSystemSettings.Name = "lblSystemSettings"
        Me.lblSystemSettings.Size = New System.Drawing.Size(167, 25)
        Me.lblSystemSettings.TabIndex = 2
        Me.lblSystemSettings.Text = "System Settings"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Hwrreg exe 01 19.png")
        Me.ImageList1.Images.SetKeyName(1, "Windows 7 (87).png")
        Me.ImageList1.Images.SetKeyName(2, "Windows 7 (198).png")
        Me.ImageList1.Images.SetKeyName(3, "Windows 7 (113).png")
        Me.ImageList1.Images.SetKeyName(4, "signin.png")
        Me.ImageList1.Images.SetKeyName(5, "signout.png")
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(621, 662)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 38)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(501, 662)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 38)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Save"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'tmrMotionLevel
        '
        Me.tmrMotionLevel.Enabled = True
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(741, 662)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(100, 38)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'tmrFPS
        '
        Me.tmrFPS.Interval = 1000
        '
        'ExportVisitorLogToolStripMenuItem
        '
        Me.ExportVisitorLogToolStripMenuItem.Name = "ExportVisitorLogToolStripMenuItem"
        Me.ExportVisitorLogToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ExportVisitorLogToolStripMenuItem.Text = "Export Visitor Log"
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(853, 708)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.tabWelcomeScreen.ResumeLayout(False)
        Me.pnlVisitorDetection.ResumeLayout(False)
        Me.pnlVisitorDetection.PerformLayout()
        CType(Me.numFaceDetectionSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMotionSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMotionLockout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWelcomeScreen.ResumeLayout(False)
        Me.pnlWelcomeScreen.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompanyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSignInScreen.ResumeLayout(False)
        Me.pnlMailChimp.ResumeLayout(False)
        Me.pnlMailChimp.PerformLayout()
        Me.pnlVisitorBadgePrinting.ResumeLayout(False)
        Me.pnlVisitorBadgePrinting.PerformLayout()
        Me.pnlTouchscreenKeyboard.ResumeLayout(False)
        Me.pnlTouchscreenKeyboard.PerformLayout()
        Me.pnlNotificationPopup.ResumeLayout(False)
        Me.pnlNotificationPopup.PerformLayout()
        Me.pnlSignInScreen.ResumeLayout(False)
        Me.pnlSignInScreen.PerformLayout()
        CType(Me.picVisitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSignOutScreen.ResumeLayout(False)
        Me.pnlSignOutMessagePopup.ResumeLayout(False)
        Me.pnlSignOutMessagePopup.PerformLayout()
        Me.pnlSignOutScreen.ResumeLayout(False)
        Me.pnlSignOutScreen.PerformLayout()
        CType(Me.picSignOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEmployeeDirectory.ResumeLayout(False)
        Me.tabEmployeeDirectory.PerformLayout()
        Me.pnlEmployeeDirectory.ResumeLayout(False)
        Me.pnlEmployeeDirectory.PerformLayout()
        Me.pnlEmployeeInformation.ResumeLayout(False)
        Me.pnlEmployeeInformation.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabVisitorLog.ResumeLayout(False)
        Me.tabVisitorLog.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picSignInPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FastDataListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.tabSystem.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSystemInformation.ResumeLayout(False)
        Me.pnlSystemInformation.PerformLayout()
        Me.pnlEmailSettings.ResumeLayout(False)
        Me.pnlEmailSettings.PerformLayout()
        Me.pnlCameraSettings.ResumeLayout(False)
        Me.pnlCameraSettings.PerformLayout()
        Me.pnlSystemSettings.ResumeLayout(False)
        Me.pnlSystemSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabSystem As System.Windows.Forms.TabPage
    Friend WithEvents tabSignInScreen As System.Windows.Forms.TabPage
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtSystemPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblSystemPassword As System.Windows.Forms.Label
    Friend WithEvents lblSelectCamera As System.Windows.Forms.Label
    Friend WithEvents clrBackgroundColor As System.Windows.Forms.ColorDialog
    Friend WithEvents clrButton As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents cboVideoSource As System.Windows.Forms.ComboBox
    Friend WithEvents btnCameraSettings As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    'Public Sub New(ByVal Validator As Habanero.Licensing.Validation.LicenseValidator)

    '    ' This call is required by the designer.
    '    InitializeComponent()
    '    LicenseValidator = Validator
    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub

    Friend WithEvents txtLocationName As System.Windows.Forms.TextBox
    Friend WithEvents lblLocationName As System.Windows.Forms.Label
    Friend WithEvents chkEnableSSL As System.Windows.Forms.CheckBox
    Friend WithEvents chkAuthentication As System.Windows.Forms.CheckBox
    Friend WithEvents lblSMTPUserName As System.Windows.Forms.Label
    Friend WithEvents txtMailFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblSMTPServerName As System.Windows.Forms.Label
    Friend WithEvents lblEmailFrom As System.Windows.Forms.Label
    Friend WithEvents txtSMTPServerName As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPPort As System.Windows.Forms.TextBox
    Friend WithEvents lblSMTPPassword As System.Windows.Forms.Label
    Friend WithEvents lblSMTPPort As System.Windows.Forms.Label
    Friend WithEvents txtSMTPPassword As System.Windows.Forms.TextBox
    Friend WithEvents cboSnapshotResolution As System.Windows.Forms.ComboBox
    Friend WithEvents cboCameraResolution As System.Windows.Forms.ComboBox
    Friend WithEvents lblSnapshotResolution As System.Windows.Forms.Label
    Friend WithEvents lblCameraResolution As System.Windows.Forms.Label
    Friend WithEvents tmrMotionLevel As System.Windows.Forms.Timer
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents tmrFPS As System.Windows.Forms.Timer
    Friend WithEvents tabWelcomeScreen As System.Windows.Forms.TabPage
    Friend WithEvents txtWelcomeText As System.Windows.Forms.TextBox
    Friend WithEvents picCompanyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtSignOutButtonText As System.Windows.Forms.TextBox
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents txtSignInButtonText As System.Windows.Forms.TextBox
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents chkFaceDetection As System.Windows.Forms.CheckBox
    Friend WithEvents lblMotionLockout As System.Windows.Forms.Label
    Friend WithEvents numMotionLockout As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMotionSensitivity As System.Windows.Forms.Label
    Friend WithEvents chkMotionDetection As System.Windows.Forms.CheckBox
    Friend WithEvents lblVoiceMessage As System.Windows.Forms.Label
    Friend WithEvents txtVoiceMessage As System.Windows.Forms.TextBox
    Friend WithEvents tabSignOutScreen As System.Windows.Forms.TabPage
    Friend WithEvents tabEmployeeDirectory As System.Windows.Forms.TabPage
    Friend WithEvents tabVisitorLog As System.Windows.Forms.TabPage
    Friend WithEvents vplSettings As AForge.Controls.VideoSourcePlayer
    Friend WithEvents txtMailChimpListID As System.Windows.Forms.TextBox
    Friend WithEvents lblMailChimpListID As System.Windows.Forms.Label
    Friend WithEvents lblMailChimpAPIKey As System.Windows.Forms.Label
    Friend WithEvents txtMailChimpAPIKey As System.Windows.Forms.TextBox
    Friend WithEvents lblPrinterStatus As System.Windows.Forms.Label
    Friend WithEvents cboPrinters As System.Windows.Forms.ComboBox
    Friend WithEvents lblFontSample As System.Windows.Forms.Label
    Friend WithEvents txtNotifyText As System.Windows.Forms.TextBox
    Friend WithEvents lblNotifyText As System.Windows.Forms.Label
    Friend WithEvents lblSignOutText As System.Windows.Forms.Label
    Friend WithEvents txtSignOutText As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportFromCSVFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lstEmployees As System.Windows.Forms.ListView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblIDNum As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents FastDataListView1 As BrightIdeasSoftware.FastDataListView
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents picSignInPicture As System.Windows.Forms.PictureBox
    Friend WithEvents picSignOut As System.Windows.Forms.PictureBox
    Friend WithEvents txtSignOutInstructions As System.Windows.Forms.TextBox
    Friend WithEvents txtSignOutVisitor As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pnlWelcomeScreen As System.Windows.Forms.Panel
    Friend WithEvents pnlSignOutScreen As System.Windows.Forms.Panel
    Friend WithEvents pnlSignInScreen As System.Windows.Forms.Panel
    Friend WithEvents picVisitor As System.Windows.Forms.PictureBox
    Friend WithEvents txtSettingInstructions As System.Windows.Forms.TextBox
    Friend WithEvents chkEmailVisible As System.Windows.Forms.CheckBox
    Friend WithEvents chkCompanyVisible As System.Windows.Forms.CheckBox
    Friend WithEvents txtVisitingText As System.Windows.Forms.TextBox
    Friend WithEvents txtNameText As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailText As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyText As System.Windows.Forms.TextBox
    Friend WithEvents pnlVisitorDetection As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVisitorDetection As System.Windows.Forms.Label
    Friend WithEvents numMotionSensitivity As System.Windows.Forms.NumericUpDown
    Friend WithEvents slVisitorDetection As CustomControls.slider
    Friend WithEvents pnlNotificationPopup As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNotificationPopup As System.Windows.Forms.Label
    Friend WithEvents pnlTouchscreenKeyboard As System.Windows.Forms.Panel
    Friend WithEvents slTouchscreenKeyboard As CustomControls.slider
    Friend WithEvents lblTouchscreenKeyboard As System.Windows.Forms.Label
    Friend WithEvents pnlVisitorBadgePrinting As System.Windows.Forms.Panel
    Friend WithEvents slVisitorBadgePrinting As CustomControls.slider
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVisitorBadgePrinting As System.Windows.Forms.Label
    Friend WithEvents pnlMailChimp As System.Windows.Forms.Panel
    Friend WithEvents slMailChimp As CustomControls.slider
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMailChimp As System.Windows.Forms.Label
    Friend WithEvents pnlSignOutMessagePopup As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSignOutMessagePopup As System.Windows.Forms.Label
    Friend WithEvents pnlSystemSettings As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSystemSettings As System.Windows.Forms.Label
    Friend WithEvents pnlCameraSettings As System.Windows.Forms.Panel
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCameraSettings As System.Windows.Forms.Label
    Friend WithEvents pnlEmailSettings As System.Windows.Forms.Panel
    Friend WithEvents slEmailNotifications As CustomControls.slider
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmailNotifications As System.Windows.Forms.Label
    Friend WithEvents lblGlobalFont As System.Windows.Forms.Label
    Friend WithEvents pnlSystemInformation As System.Windows.Forms.Panel
    Friend WithEvents lblLicense As System.Windows.Forms.Label
    Friend WithEvents lblSoftwareVersion As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSystemInformation As System.Windows.Forms.Label
    Friend WithEvents btnEditLicense As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblLastVisit As System.Windows.Forms.Label
    Friend WithEvents lblVisitorName As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVisitorInformation As System.Windows.Forms.Label
    Friend WithEvents pnlEmployeeInformation As System.Windows.Forms.Panel
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmployeeInformation As System.Windows.Forms.Label
    Friend WithEvents pnlEmployeeDirectory As System.Windows.Forms.Panel
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmployeeDirectory As System.Windows.Forms.Label
    Friend WithEvents lblTotalVisits As System.Windows.Forms.Label
    Friend WithEvents lblFirstVisit As System.Windows.Forms.Label
    Friend WithEvents cboEmailServerType As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmailServerType As System.Windows.Forms.Label
    Friend WithEvents EmployeeDirectoryLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitorLogLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents numFaceDetectionSensitivity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFaceDetectionSensitivity As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ExportVisitorLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
