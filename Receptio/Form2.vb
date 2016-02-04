
Public Class frmSettings

    Private VideoCaptureSource As AForge.Video.DirectShow.VideoCaptureDevice
    Private VideoDevices As New AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice)
    Private MySingleDevice As AForge.Video.DirectShow.FilterInfo
    Private motionlevel As Single
    Private FPS As Integer
    

    Private Sub cboPrinters_SelectedIndexChanged(sender As Object, e As EventArgs)
        UpdatePrinterStatus()
    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        AutoUpdaterDotNET.AutoUpdater.Start("http://lucylabs.com/download/receptio/receptio-updates.xml")
        'AutoUpdaterDotNET.AutoUpdater.Start("http://rbsoft.org/updates/right-click-enhancer.xml")
    End Sub

    Private Sub UpdateSystemInformation()
        'Dim ExpirationDate As String
        lblSoftwareVersion.Text = "Receptio " & frmWelcome.ThisVersion.ToString & "  Copyright 2015 Lucy Labs, Inc."
        lblLicense.Text = "Free License"
        'Dim result As Habanero.Licensing.Validation.LicenseValidationResult = LicenseValidator.CheckLicense
        'If result.ExpirationDate.ToString = "" Then ExpirationDate = "Never" Else ExpirationDate = result.ExpirationDate.ToString
        'If result.State = Habanero.Licensing.Validation.LicenseState.Invalid Then
        '    lblLicense.Text = "Invalid License"
        'ElseIf result.State = Habanero.Licensing.Validation.LicenseState.Trial Then
        '    lblLicense.Text = "Trial Mode, Expires " & ExpirationDate
        'ElseIf result.State = Habanero.Licensing.Validation.LicenseState.Valid Then
        '    If LicenseValidator.IsEdition("Pro") Then
        '        lblLicense.Text = "Pro Edition, Expires " & ExpirationDate
        '    ElseIf LicenseValidator.IsEdition("Enterprise") Then
        '        lblLicense.Text = "Enterprise Edition, Expires " & ExpirationDate
        '    End If
        'End If
    End Sub
    Private Sub UpdatepnlVisitorDetection()
        If slVisitorDetection.SwitchedOn Then
            lblMotionSensitivity.Enabled = True
            numMotionSensitivity.Enabled = True
            lblVoiceMessage.Enabled = True
            txtVoiceMessage.Enabled = True
            numMotionLockout.Enabled = True
            lblMotionLockout.Enabled = True
            chkFaceDetection.Enabled = True
            chkMotionDetection.Enabled = True
            lblFaceDetectionSensitivity.Enabled = True
            numFaceDetectionSensitivity.Enabled = True

        Else
            lblMotionSensitivity.Enabled = False
            numMotionSensitivity.Enabled = False
            lblVoiceMessage.Enabled = False
            txtVoiceMessage.Enabled = False
            numMotionLockout.Enabled = False
            lblMotionLockout.Enabled = False
            chkFaceDetection.Enabled = False
            chkMotionDetection.Enabled = False
            lblFaceDetectionSensitivity.Enabled = False
            numFaceDetectionSensitivity.Enabled = False
        End If
    End Sub


    Private Sub cboVideoSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVideoSource.SelectedIndexChanged
        Dim VideoDevice As AForge.Video.DirectShow.VideoCaptureDevice
        cboCameraResolution.Items.Clear()
        VideoDevice = New AForge.Video.DirectShow.VideoCaptureDevice(VideoDevices(cboVideoSource.SelectedIndex).MonikerString)
        For Each VideoCapability In VideoDevice.VideoCapabilities
            cboCameraResolution.Items.Add(String.Format("{0} x {1}", VideoCapability.FrameSize.Width, VideoCapability.FrameSize.Height))
        Next
        If VideoDevice.VideoCapabilities.Length = 0 Then
            cboCameraResolution.Items.Add("Not supported")
        End If

        cboCameraResolution.SelectedIndex = 0
        cboSnapshotResolution.SelectedIndex = 0
    End Sub


    'Public Sub New(ByVal Validator As Habanero.Licensing.Validation.LicenseValidator)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'LicenseValidator = Validator
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub txtSystemPassword_Click(sender As Object, e As EventArgs) Handles txtSystemPassword.Click
        Dim PasswordDialog1 As New Password()
        Dim PasswordDialog2 As New Password()
        Dim Password1 As String = ""
        Dim Password2 As String = ""
        Dim hashClass As New MD5Class
        PasswordDialog1.Text = "Enter New Password"
        If PasswordDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Password1 = PasswordDialog1.Password
            PasswordDialog2.Text = "Re-enter New Password for Confirmation"
            If PasswordDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Password2 = PasswordDialog2.Password
                If String.Equals(Password1, Password2) Then
                    MsgBox("Password changed.", MsgBoxStyle.Information, "Valid")
                    Dim hashpassword As String = hashClass.GetMd5Hash(Password1)
                    My.Settings.SystemPassword = hashpassword
                Else
                    MsgBox("Passwords don't match!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub btnCameraSettings_Click(sender As Object, e As EventArgs) Handles btnCameraSettings.Click
        VideoCaptureSource.DisplayPropertyPage(Me.Handle)
    End Sub



    Private Sub txtSMTPPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSMTPPort.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub SaveSettings()
        My.Settings.SMTPServerName = txtSMTPServerName.Text
        My.Settings.SMTPUserName = txtSMTPUserName.Text
        My.Settings.SMTPPassword = txtSMTPPassword.Text
        My.Settings.SMTPPort = txtSMTPPort.Text
        My.Settings.Authentication = chkAuthentication.Checked
        My.Settings.EnableSSL = chkEnableSSL.Checked
        My.Settings.MailFrom = txtMailFrom.Text
        My.Settings.LocationName = txtLocationName.Text
        My.Settings.WelcomeText = txtWelcomeText.Text
        My.Settings.SignInInstructions = txtSettingInstructions.Text
        My.Settings.NameText = txtNameText.Text
        My.Settings.CompanyText = txtCompanyText.Text
        My.Settings.VisitingText = txtVisitingText.Text
        My.Settings.SignInButtonText = txtSignInButtonText.Text
        My.Settings.SignOutButtonText = txtSignOutButtonText.Text
        'My.Settings.BackgroundImage = txtBackgroundImage.Text
        My.Settings.WelcomeBackgroundColor = pnlWelcomeScreen.BackColor
        My.Settings.SignInBackgroundColor = pnlSignInScreen.BackColor
        My.Settings.SignOutBackgroundColor = pnlSignOutScreen.BackColor
        My.Settings.SignOutText = txtSignOutText.Text
        My.Settings.NotifyText = txtNotifyText.Text
        My.Settings.FontName = lblFontSample.Font
        My.Settings.FontColor = lblFontSample.ForeColor
        My.Settings.UseMotionDetection = chkMotionDetection.Checked
        My.Settings.WelcomeMessage = txtVoiceMessage.Text
        My.Settings.MotionSensitivity = numMotionSensitivity.Value
        My.Settings.VideoSource = cboVideoSource.SelectedIndex
        My.Settings.EmailNotifications = slEmailNotifications.SwitchedOn
        My.Settings.EmailText = txtEmailText.Text
        My.Settings.EmailVisible = chkEmailVisible.Checked
        My.Settings.CompanyVisible = chkCompanyVisible.Checked
        My.Settings.VisitorBadgePrinting = slVisitorBadgePrinting.SwitchedOn
        My.Settings.MotionDelay = numMotionLockout.Value
        My.Settings.UseMailChimp = slMailChimp.SwitchedOn
        My.Settings.MailChimpAPIKey = txtMailChimpAPIKey.Text
        My.Settings.MailChimpListID = txtMailChimpListID.Text
        My.Settings.CameraResolutionIndex = cboCameraResolution.SelectedIndex
        My.Settings.SnapshotResolutionIndex = cboSnapshotResolution.SelectedIndex
        My.Settings.UseFaceDetection = chkFaceDetection.Checked
        My.Settings.UseTouchUI = slTouchscreenKeyboard.SwitchedOn
        My.Settings.PrinterIndex = cboPrinters.SelectedIndex
        My.Settings.CompanyLogo = picCompanyLogo.ImageLocation
        My.Settings.SignOutInstructions = txtSignOutInstructions.Text
        My.Settings.SignOutVisitor = txtSignOutVisitor.Text
        My.Settings.SignInButtonColor = btnSignIn.BackColor
        My.Settings.SignOutButtonColor = btnSignOut.BackColor
        My.Settings.UseVisitorDetection = slVisitorDetection.SwitchedOn
        My.Settings.EmailServerType = cboEmailServerType.SelectedIndex
        My.Settings.FaceDetectionSensitivity = numFaceDetectionSensitivity.Value

        My.Settings.Save()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SaveSettings()
        vplSettings.SignalToStop()
        vplSettings.WaitForStop()
        VideoDevices = Nothing
        VideoCaptureSource = Nothing
        Me.Close()
    End Sub

    Private Sub UpdatePrinterStatus()
        Dim doc As New bpac.Document
        Dim printers() As Object = doc.Printer.GetInstalledPrinters()
        If printers IsNot Nothing Then
            Dim InstalledPrinterName As String = printers(cboPrinters.SelectedIndex).ToString
            If (doc.Printer.IsPrinterOnline(InstalledPrinterName)) Then
                lblPrinterStatus.Text = "Status - Online"
            Else
                lblPrinterStatus.Text = "Status - Offline"
            End If
        Else
            lblPrinterStatus.Text = "Status - N/A"
        End If
    End Sub

    Private Sub LoadSettings()
        cboCameraResolution.Items.Clear()
        cboPrinters.Items.Clear()
        cboVideoSource.Items.Clear()
        cboEmailServerType.Items.Clear()
        txtSMTPServerName.Text = My.Settings.SMTPServerName
        txtSMTPUserName.Text = My.Settings.SMTPUserName
        txtSMTPPassword.Text = My.Settings.SMTPPassword
        txtSMTPPort.Text = My.Settings.SMTPPort
        chkAuthentication.Checked = My.Settings.Authentication
        chkEnableSSL.Checked = My.Settings.EnableSSL
        txtMailFrom.Text = My.Settings.MailFrom
        txtLocationName.Text = My.Settings.LocationName
        txtWelcomeText.Text = My.Settings.WelcomeText
        txtSettingInstructions.Text = My.Settings.SignInInstructions
        txtNameText.Text = My.Settings.NameText
        txtCompanyText.Text = My.Settings.CompanyText
        txtVisitingText.Text = My.Settings.VisitingText
        txtSignInButtonText.Text = My.Settings.SignInButtonText
        txtSignOutButtonText.Text = My.Settings.SignOutButtonText
        'txtBackgroundImage.Text = My.Settings.BackgroundImage
        txtSignOutText.Text = My.Settings.SignOutText
        txtNotifyText.Text = My.Settings.NotifyText
        lblFontSample.BackColor = My.Settings.WelcomeBackgroundColor
        lblFontSample.ForeColor = My.Settings.FontColor
        lblFontSample.Text = My.Settings.FontName.Name
        lblFontSample.Font = My.Settings.FontName
        chkMotionDetection.Checked = My.Settings.UseMotionDetection
        txtVoiceMessage.Text = My.Settings.WelcomeMessage
        numMotionSensitivity.Value = My.Settings.MotionSensitivity
        slEmailNotifications.SwitchedOn = My.Settings.EmailNotifications
        txtEmailText.Text = My.Settings.EmailText
        chkEmailVisible.Checked = My.Settings.EmailVisible
        chkCompanyVisible.Checked = My.Settings.CompanyVisible
        slVisitorBadgePrinting.SwitchedOn = My.Settings.VisitorBadgePrinting
        numMotionLockout.Value = My.Settings.MotionDelay
        slMailChimp.SwitchedOn = My.Settings.UseMailChimp
        txtMailChimpAPIKey.Text = My.Settings.MailChimpAPIKey
        txtMailChimpListID.Text = My.Settings.MailChimpListID
        chkFaceDetection.Checked = My.Settings.UseFaceDetection
        slTouchscreenKeyboard.SwitchedOn = My.Settings.UseTouchUI
        txtSignOutInstructions.Text = My.Settings.SignOutInstructions
        txtSignOutVisitor.Text = My.Settings.SignOutVisitor
        pnlWelcomeScreen.BackColor = My.Settings.WelcomeBackgroundColor
        pnlSignInScreen.BackColor = My.Settings.SignInBackgroundColor
        pnlSignOutScreen.BackColor = My.Settings.SignOutBackgroundColor
        btnSignIn.BackColor = My.Settings.SignInButtonColor
        btnSignOut.BackColor = My.Settings.SignOutButtonColor
        slVisitorDetection.SwitchedOn = My.Settings.UseVisitorDetection
        numFaceDetectionSensitivity.Value = My.Settings.FaceDetectionSensitivity

        If System.IO.File.Exists(My.Settings.CompanyLogo) Then
            picCompanyLogo.ImageLocation = My.Settings.CompanyLogo
        Else
            picCompanyLogo.Image = My.Resources.original_1358_2745186
        End If
        UpdatepnlVisitorDetection()
        If VideoDevices.Count = 0 Then
            cboVideoSource.Items.Add("No Video Devices")
        Else
            For Each Me.MySingleDevice In VideoDevices
                cboVideoSource.Items.Add(Me.MySingleDevice.Name)
            Next
        End If
        'Find all of the Brother label printers
        Dim doc As New bpac.Document
        Dim printers() As Object = doc.Printer.GetInstalledPrinters()
        If printers IsNot Nothing Then
            For Each printername In printers
                cboPrinters.Items.Add(printername.ToString)
            Next
        Else
            cboPrinters.Items.Add("No Printer Installed")
        End If
        cboVideoSource.SelectedIndex = My.Settings.VideoSource
        cboCameraResolution.SelectedIndex = My.Settings.CameraResolutionIndex
        cboSnapshotResolution.SelectedIndex = My.Settings.SnapshotResolutionIndex
        cboPrinters.SelectedIndex = My.Settings.PrinterIndex
        UpdatePrinterStatus()  'Update printer Online status
        cboEmailServerType.Items.Add("Custom")
        cboEmailServerType.Items.Add("Yahoo Mail")
        cboEmailServerType.Items.Add("Google Gmail")
        cboEmailServerType.Items.Add("Comcast")
        cboEmailServerType.Items.Add("Microsoft Hotmail/MSN/Outlook")
        cboEmailServerType.SelectedIndex = My.Settings.EmailServerType
        'Dim LicenseStatus As Habanero.Licensing.Validation.LicenseValidationResult = LicenseValidator.CheckLicense()
        'Dim ProOrHigher As String() = {"Pro", "EnterPrise"}
        'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Trial) Or ((LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Valid) And (LicenseValidator.IsEdition(ProOrHigher))) Then
        '    pnlVisitorBadgePrinting.Enabled = True
        '    pnlMailChimp.Enabled = True
        '    pnlTouchscreenKeyboard.Enabled = True
        'Else
        '    pnlVisitorBadgePrinting.Enabled = False
        '    pnlMailChimp.Enabled = False
        '    pnlTouchscreenKeyboard.Enabled = False
        'End If
        UpdateSystemInformation()
        If vplSettings.IsRunning = True Then
            vplSettings.SignalToStop()
            vplSettings.WaitForStop()
        End If
        VideoCaptureSource = New AForge.Video.DirectShow.VideoCaptureDevice(VideoDevices(My.Settings.VideoSource).MonikerString)
        If (VideoCaptureSource.VideoCapabilities IsNot Nothing) And (VideoCaptureSource.VideoCapabilities.Length <> 0) Then
            VideoCaptureSource.VideoResolution = VideoCaptureSource.VideoCapabilities(My.Settings.CameraResolutionIndex)
        End If
        vplSettings.VideoSource = VideoCaptureSource
        vplSettings.Start()
        tmrFPS.Enabled = True
        EmployeeDirectoryLoad()
        VisitorLogLoad()
        picSignInPicture.Image = My.Resources.blank_person
        'Me.TopMost = True
        'AutoUpdaterDotNET.AutoUpdater.Start("http://lucylabs.com/download/receptio/receptio-updates.xml")
    End Sub

    Private Sub frmSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        vplSettings.SignalToStop()
        vplSettings.WaitForStop()
        VideoDevices = Nothing
        VideoCaptureSource = Nothing
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSettings()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        vplSettings.SignalToStop()
        vplSettings.WaitForStop()
        VideoDevices = Nothing
        VideoCaptureSource = Nothing
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        SaveSettings()
        tmrFPS.Enabled = False
        vplSettings.SignalToStop()
        vplSettings.WaitForStop()
        'VideoDevices = Nothing
        VideoCaptureSource = Nothing
        LoadSettings()
    End Sub

    Private Sub tmrFPS_Tick(sender As Object, e As EventArgs) Handles tmrFPS.Tick
        FPS = VideoCaptureSource.FramesReceived
    End Sub

    Private Sub picCompanyLogo_Click(sender As Object, e As EventArgs) Handles picCompanyLogo.Click
        Dim dialog As New OpenFileDialog()
        dialog.InitialDirectory = Environment.SpecialFolder.Desktop
        dialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.JPG; *.PNG; *.BMP|All files (*.*)|*.*"
        'dialog.SelectedPath = "C:\"
        dialog.Title = "Select File for Company Logo"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picCompanyLogo.ImageLocation = dialog.FileName
        End If
    End Sub

    Private Sub vplSettings_NewFrame(sender As Object, ByRef image As Bitmap) Handles vplSettings.NewFrame
        image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        Dim g As Graphics = Graphics.FromImage(image)
        g.DrawString(FPS.ToString & " FPS", _
       New Font("Arial", 80), Brushes.White, New Rectangle(10, 10, 500, 100))
        g.Dispose()
    End Sub

    ' Employee Directory Tab
    '------------------------------------------------------
    Private Sub EmployeeDirectoryLoad()
        lstEmployees.View = View.List
        UpdateListBox()
        pnlEmployeeInformation.Enabled = False
    End Sub

    Private Sub UpdateListBox()
        Dim SQLConnect As New SQLite.SQLiteConnection
        Dim EmployeeDirectoryFile As String

        lstEmployees.Items.Clear()
        EmployeeDirectoryFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
        If Not System.IO.File.Exists(EmployeeDirectoryFile) Then
            frmWelcome.CreateEmployeeDirectoryDB(EmployeeDirectoryFile)
        End If
        Try
            SQLConnect.ConnectionString = "Data Source=" & EmployeeDirectoryFile & ";"
            Dim SQLCommand As New SQLite.SQLiteCommand("SELECT id, FirstName, LastName FROM employee", SQLConnect)
            SQLConnect.Open()
            Dim SQLReader As SQLite.SQLiteDataReader = SQLCommand.ExecuteReader()
            While SQLReader.Read()
                Dim items As New ListViewItem
                items.Text = SQLReader("LastName") & ", " & SQLReader("FirstName")
                items.Tag = SQLReader("id")
                lstEmployees.Items.Add(items)
            End While
            SQLReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLConnect.Close()
        End Try
    End Sub


    Private Sub lstEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEmployees.SelectedIndexChanged
        Dim SQLConnect As New SQLite.SQLiteConnection
        Dim EmployeeDirectoryFile As String
        If lstEmployees.FocusedItem IsNot Nothing Then
            EmployeeDirectoryFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
            Try
                SQLConnect.ConnectionString = "Data Source=" & EmployeeDirectoryFile & ";"
                Dim SQLCommand As New SQLite.SQLiteCommand("SELECT * FROM employee WHERE id=" & lstEmployees.FocusedItem.Tag.ToString & ";", SQLConnect)
                SQLConnect.Open()
                Dim SQLReader As SQLite.SQLiteDataReader = SQLCommand.ExecuteReader()
                While SQLReader.Read()
                    lblIDNum.Text = lstEmployees.FocusedItem.Tag.ToString
                    txtFirstName.Text = SQLReader("FirstName")
                    txtLastName.Text = SQLReader("LastName")
                    txtTitle.Text = SQLReader("Title")
                    txtEmail.Text = SQLReader("Email")
                    txtPhone.Text = SQLReader("Phone")
                End While
                pnlEmployeeInformation.Enabled = True
                SQLReader.Close()
            Catch ex As Exception
            Finally
                SQLConnect.Close()
            End Try
        Else
            pnlEmployeeInformation.Enabled = False
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SQLConnect As New SQLite.SQLiteConnection
        Dim EmployeeDirectoryFile As String
        If lstEmployees.FocusedItem IsNot Nothing Then
            EmployeeDirectoryFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
            Try
                SQLConnect.ConnectionString = "Data Source=" & EmployeeDirectoryFile & ";"
                Dim SQLCommand As New SQLite.SQLiteCommand("UPDATE employee SET FirstName = '" & txtFirstName.Text & "', LastName= '" & txtLastName.Text & "', Title = '" & txtTitle.Text & "', Email = '" & txtEmail.Text & "', Phone = '" & txtPhone.Text & _
                                                           "'WHERE id=" & lstEmployees.FocusedItem.Tag.ToString & ";", SQLConnect)
                SQLConnect.Open()
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                SQLConnect.Close()
            End Try
            UpdateListBox()
            pnlEmployeeInformation.Enabled = False
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim SQLConnect As New SQLite.SQLiteConnection
        Dim EmployeeDirectoryFile As String
        If lstEmployees.FocusedItem IsNot Nothing Then
            EmployeeDirectoryFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
            Try
                SQLConnect.ConnectionString = "Data Source=" & EmployeeDirectoryFile & ";"
                Dim SQLCommand As New SQLite.SQLiteCommand("DELETE from employee WHERE id=" & lstEmployees.FocusedItem.Tag.ToString & ";", SQLConnect)
                SQLConnect.Open()
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                SQLConnect.Close()
            End Try
            UpdateListBox()
            pnlEmployeeInformation.Enabled = False
        End If
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim SQLConnect As New SQLite.SQLiteConnection
        Dim EmployeeDirectoryFile As String

        EmployeeDirectoryFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
        Try
            SQLConnect.ConnectionString = "Data Source=" & EmployeeDirectoryFile & ";"
            Dim SQLCommand As New SQLite.SQLiteCommand("INSERT INTO employee (FirstName, LastName, Title, Email, Phone) VALUES ('<New Employee>', '<New Employee>', '', '', '');", SQLConnect)
            SQLConnect.Open()
            SQLCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            SQLConnect.Close()
        End Try
        UpdateListBox()
        pnlEmployeeInformation.Enabled = False
    End Sub


    Private Sub ImportFromCSVFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromCSVFileToolStripMenuItem.Click
        Dim dialog As New OpenFileDialog()
        Dim CurrentRow() As String
        Dim dbcon As New SQLite.SQLiteConnection("Data source=" & My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3;")
        dialog.InitialDirectory = Environment.SpecialFolder.Desktop
        dialog.Filter = "CSV File (*.csv)|*.csv|All files (*.*)|*.*"
        dialog.Title = "Select CSV to Import"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                dbcon.Open()
                Dim sbi As New Receptio.Data.SQLite.SQLiteBulkInsert(dbcon, "employee")
                sbi.AddParameter("FirstName", DbType.String)
                sbi.AddParameter("LastName", DbType.String)
                sbi.AddParameter("Title", DbType.String)
                sbi.AddParameter("Email", DbType.String)
                sbi.AddParameter("Phone", DbType.String)
                Using ioreader As New Microsoft.VisualBasic.FileIO.TextFieldParser(dialog.FileName)
                    ioreader.TextFieldType = FileIO.FieldType.Delimited
                    ioreader.SetDelimiters(",")
                    While Not ioreader.EndOfData
                        CurrentRow = ioreader.ReadFields()
                        sbi.Insert(New Object() {CurrentRow(0), CurrentRow(1), CurrentRow(2), CurrentRow(3)})
                    End While
                End Using
                sbi.Flush()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dbcon.Close()
            End Try
            UpdateListBox()
        End If
    End Sub


    '------------------------------------------------------------

    'Visitor Log Tab
    '------------------------------------------------------------
    Private Sub VisitorLogLoad()
        Dim DS = New DataSet()
        Dim SQLconnect As New SQLite.SQLiteConnection
        Dim dbLogFile As String

        Me.TopMost = True
        dbLogFile = My.Settings.VisitorLogLocation & "Visitor Log.db3"
        If Not System.IO.File.Exists(dbLogFile) Then
            frmWelcome.CreateVisitorLogDB(dbLogFile)
        End If
        Try
            SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
            SQLconnect.Open()
            Dim Adapter As New SQLite.SQLiteDataAdapter("SELECT id,date,name,company,email,visiting,SignIn,SignOut FROM logfile", SQLconnect)
            Adapter.Fill(DS, "logfile")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLconnect.Close()
        End Try
        FastDataListView1.DataSource = DS.Tables("logfile")
    End Sub

    Private Function BlobToImage(ByVal blob)
        Dim mStream As New System.IO.MemoryStream
        Dim pData() As Byte = DirectCast(blob, Byte())
        mStream.Write(pData, 0, Convert.ToInt32(pData.Length))
        Dim bm As Bitmap = New Bitmap(mStream, False)
        mStream.Dispose()
        Return bm
    End Function


    Private Sub FastDataListView1_CellClick(sender As Object, e As BrightIdeasSoftware.CellClickEventArgs) Handles FastDataListView1.CellClick
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLite.SQLiteCommand
        Dim dbLogFile As String
        Dim SelectedItem As New ListViewItem
        dbLogFile = My.Settings.VisitorLogLocation & "Visitor Log.db3"
        If Not System.IO.File.Exists(dbLogFile) Then
            frmWelcome.CreateVisitorLogDB(dbLogFile)
        End If
        SelectedItem = FastDataListView1.SelectedItem
        Try
            SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT Photo, Name FROM logfile WHERE id = '" & SelectedItem.Text & "'"
            Dim SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
            'If Not SQLreader.IsDBNull(SQLreader.GetOrdinal("Photo")) Then
            '    While SQLreader.Read()
            '        picSignInPicture.Image = BlobToImage(SQLreader("Photo"))
            '    End While
            'Else
            '    picSignInPicture.Image = Nothing
            'End If
            ' Work around SQLite bug where getordinal before read causes no row current row error
            While SQLreader.Read()
                If Not SQLreader.IsDBNull(SQLreader.GetOrdinal("Photo")) Then
                    picSignInPicture.Image = BlobToImage(SQLreader("Photo"))
                Else
                    picSignInPicture.Image = My.Resources.blank_person
                End If
                lblVisitorName.Text = SQLreader("Name")
            End While
            SQLcommand.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLconnect.Close()
        End Try
        Try
            SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT Date FROM logfile WHERE Name = '" & lblVisitorName.Text & "'"
            Dim SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
            Dim DateList As New List(Of String)
            While SQLreader.Read()
                If Not SQLreader.IsDBNull(SQLreader.GetOrdinal("Date")) Then
                    DateList.Add(SQLreader("Date"))
                End If
            End While
            lblTotalVisits.Text = "Total Visits: " & DateList.Count.ToString
            lblFirstVisit.Text = "First Visit: " & DateList.Item(0)
            lblLastVisit.Text = "Last Visit: " & DateList.Item(DateList.Count - 1)
            SQLcommand.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLconnect.Close()
        End Try

    End Sub

    Private Sub btnBackgroundColor_Click1(sender As Object, e As EventArgs)
        If clrBackgroundColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblFontSample.BackColor = clrBackgroundColor.Color
        End If
    End Sub

    'Private Sub txtBackgroundImage_Click1(sender As Object, e As EventArgs)
    '    Dim dialog As New OpenFileDialog()
    '    dialog.InitialDirectory = Environment.SpecialFolder.Desktop
    '    dialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.JPG; *.PNG; *.BMP|All files (*.*)|*.*"
    '    dialog.Title = "Select File for Background"
    '    If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        'txtBackgroundImage.Text = dialog.FileName
    '    Else
    '        'txtBackgroundImage.Text = ""
    '    End If
    'End Sub


    Private Sub pnlWelcomeScreen_Click(sender As Object, e As EventArgs) Handles pnlWelcomeScreen.Click
        If clrBackgroundColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pnlWelcomeScreen.BackColor = clrBackgroundColor.Color
        End If
    End Sub

    Private Sub pnlSignInScreen_Click(sender As Object, e As EventArgs) Handles pnlSignInScreen.Click
        If clrBackgroundColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pnlSignInScreen.BackColor = clrBackgroundColor.Color
        End If
    End Sub

    Private Sub pnlSignOutScreen_Click(sender As Object, e As EventArgs) Handles pnlSignOutScreen.Click
        If clrBackgroundColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pnlSignOutScreen.BackColor = clrBackgroundColor.Color
        End If
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If clrBackgroundColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            btnSignIn.BackColor = clrBackgroundColor.Color
        End If
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        If clrBackgroundColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            btnSignOut.BackColor = clrBackgroundColor.Color
        End If
    End Sub


    Private Sub slVisitorDetection_StateChanged() Handles slVisitorDetection.StateChanged
        UpdatepnlVisitorDetection()
    End Sub

    Private Sub slMailChimp_StateChanged() Handles slMailChimp.StateChanged
        If slMailChimp.SwitchedOn = True Then
            lblMailChimpListID.Enabled = True
            txtMailChimpListID.Enabled = True
            lblMailChimpAPIKey.Enabled = True
            txtMailChimpAPIKey.Enabled = True
        Else
            lblMailChimpListID.Enabled = False
            txtMailChimpListID.Enabled = False
            lblMailChimpAPIKey.Enabled = False
            txtMailChimpAPIKey.Enabled = False
        End If
    End Sub

    Private Sub slVisitorBadgePrinting_StateChanged() Handles slVisitorBadgePrinting.StateChanged
        If slVisitorBadgePrinting.SwitchedOn Then
            cboPrinters.Enabled = True
            lblPrinterStatus.Enabled = True
        Else
            cboPrinters.Enabled = False
            lblPrinterStatus.Enabled = False
        End If
    End Sub

    Private Sub slEmailNotifications_StateChanged() Handles slEmailNotifications.StateChanged
        If slEmailNotifications.SwitchedOn = True Then
            txtSMTPServerName.Enabled = True
            txtSMTPUserName.Enabled = True
            txtSMTPPassword.Enabled = True
            txtSMTPPort.Enabled = True
            chkAuthentication.Enabled = True
            chkEnableSSL.Enabled = True
            txtMailFrom.Enabled = True
            lblSMTPPassword.Enabled = True
            lblSMTPPort.Enabled = True
            lblSMTPServerName.Enabled = True
            lblSMTPUserName.Enabled = True
            lblEmailFrom.Enabled = True
            lblEmailServerType.Enabled = True
            cboEmailServerType.Enabled = True

        Else
            txtSMTPServerName.Enabled = False
            txtSMTPUserName.Enabled = False
            txtSMTPPassword.Enabled = False
            txtSMTPPort.Enabled = False
            chkAuthentication.Enabled = False
            chkEnableSSL.Enabled = False
            txtMailFrom.Enabled = False
            lblSMTPPassword.Enabled = False
            lblSMTPPort.Enabled = False
            lblSMTPServerName.Enabled = False
            lblSMTPUserName.Enabled = False
            lblEmailFrom.Enabled = False
            lblEmailServerType.Enabled = False
            cboEmailServerType.Enabled = False
        End If
    End Sub

    Private Sub lblFontSample_Click(sender As Object, e As EventArgs) Handles lblFontSample.Click
        FontDialog1.ShowColor = True
        FontDialog1.Font = My.Settings.FontName
        FontDialog1.Color = My.Settings.FontColor
        FontDialog1.MaxSize = 14
        FontDialog1.MinSize = 14
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblFontSample.Font = FontDialog1.Font
            lblFontSample.ForeColor = FontDialog1.Color
            lblFontSample.Text = FontDialog1.Font.Name
        End If
    End Sub

    Private Sub btnEditLicense_Click(sender As Object, e As EventArgs) Handles btnEditLicense.Click
        Dim frm As New frmLicense
        frm.ShowDialog()
        frm.Dispose()
        UpdateSystemInformation()
    End Sub

    Private Sub cboEmailServerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmailServerType.SelectedIndexChanged
        If cboEmailServerType.SelectedIndex = 1 Then 'Yahoo Mail
            txtSMTPServerName.Text = "smtp.mail.yahoo.com"
            txtSMTPServerName.Enabled = False
            txtSMTPPort.Text = "587"
            txtSMTPPort.Enabled = False
            'txtSMTPUserName.Text = "user@yahoo.com"
            'txtMailFrom.Text = "user@yahoo.com"
            chkAuthentication.Checked = True
            chkAuthentication.Enabled = False
            chkEnableSSL.Checked = True
            chkEnableSSL.Enabled = False
        ElseIf cboEmailServerType.SelectedIndex = 2 Then 'Gmail
            txtSMTPServerName.Text = "smtp.gmail.com"
            txtSMTPServerName.Enabled = False
            txtSMTPPort.Text = "587"
            txtSMTPPort.Enabled = False
            'txtSMTPUserName.Text = "user@gmail.com"
            'txtMailFrom.Text = "user@gmail.com"
            chkAuthentication.Checked = True
            chkAuthentication.Enabled = False
            chkEnableSSL.Checked = True
            chkEnableSSL.Enabled = False
        ElseIf cboEmailServerType.SelectedIndex = 3 Then ' Comcast
            txtSMTPServerName.Text = "smtp.comcast.net"
            txtSMTPServerName.Enabled = False
            txtSMTPPort.Text = "587"
            'txtSMTPUserName.Text = "user@comcast.net"
            'txtMailFrom.Text = "user@comcast.net"
            txtSMTPPort.Enabled = False
            chkAuthentication.Checked = True
            chkAuthentication.Enabled = False
            chkEnableSSL.Checked = True
            chkEnableSSL.Enabled = False
        ElseIf cboEmailServerType.SelectedIndex = 4 Then ' MSN/Hotmail/Outlook
            txtSMTPServerName.Text = "smtp.live.com"
            txtSMTPServerName.Enabled = False
            txtSMTPPort.Text = "587"
            txtSMTPPort.Enabled = False
            'txtSMTPUserName.Text = "user@live.com"
            'txtMailFrom.Text = "user@live.com"
            chkAuthentication.Checked = True
            chkAuthentication.Enabled = False
            chkEnableSSL.Checked = True
            chkEnableSSL.Enabled = False
        Else
            txtSMTPServerName.Enabled = True
            txtSMTPPort.Enabled = True
            chkAuthentication.Enabled = True
            chkEnableSSL.Enabled = True
            'txtSMTPUserName.Text = "user@domain.com"
            'txtMailFrom.Text = "user@domain.com"
            'txtSMTPPort.Text = "25"

        End If
    End Sub

    Private Sub EmployeeDirectoryLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDirectoryLocationToolStripMenuItem.Click
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Path for Employee Directory"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'txtEmployeeDirectoryLocation.Text = dialog.SelectedPath + "\"
            My.Settings.EmployeeDirectoryLocation = dialog.SelectedPath + "\"
        End If
    End Sub

    Private Sub VisitorLogLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitorLogLocationToolStripMenuItem.Click
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Path for Visitor Log"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'txtVisitorLogLocation.Text = dialog.SelectedPath + "\"
            My.Settings.VisitorLogLocation = dialog.SelectedPath + "\"
        End If
    End Sub

    Private Sub ExportVisitorLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportVisitorLogToolStripMenuItem.Click
        Dim dialog As New SaveFileDialog
        dialog.InitialDirectory = Environment.SpecialFolder.Desktop
        dialog.Title = "Export to CSV"
        dialog.DefaultExt = "CSV"
        dialog.OverwritePrompt = True
        dialog.Filter = "CSV files (*.CSV)|*.CSV|All files (*.*)|*.*"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(dialog.FileName, False)
            outFile.WriteLine("id, Date, Name, Company, E-mail, Visiting, , In, Out")
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLite.SQLiteCommand
            Dim dbLogFile As String
            dbLogFile = My.Settings.VisitorLogLocation & "Visitor Log.db3"
            If Not System.IO.File.Exists(dbLogFile) Then
                frmWelcome.CreateVisitorLogDB(dbLogFile)
            End If
            Try
                SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
                SQLconnect.Open()
                SQLcommand = SQLconnect.CreateCommand
                SQLcommand.CommandText = "SELECT id,date,name,company,email,visiting,SignIn,SignOut FROM logfile"
                Dim SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                'If Not SQLreader.IsDBNull(SQLreader.GetOrdinal("Photo")) Then
                '    While SQLreader.Read()
                '        picSignInPicture.Image = BlobToImage(SQLreader("Photo"))
                '    End While
                'Else
                '    picSignInPicture.Image = Nothing
                'End If
                ' Work around SQLite bug where getordinal before read causes no row current row error
                While SQLreader.Read()
                    'If Not SQLreader.IsDBNull(SQLreader.GetOrdinal("Photo")) Then
                    'picSignInPicture.Image = BlobToImage(SQLreader("Photo"))
                    'Else
                    'picSignInPicture.Image = My.Resources.blank_person
                    'End If
                    outFile.WriteLine(SQLreader("id") & "," & SQLreader("date") & "," & SQLreader("name") & "," & SQLreader("company") & _
                                      "," & SQLreader("email") & "," & SQLreader("visiting") & "," & SQLreader("SignIn") & "," & SQLreader("SignOut"))
                End While
                SQLcommand.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                SQLconnect.Close()
                outFile.Close()
                MsgBox("Export Complete")
            End Try

        End If
    End Sub
End Class
