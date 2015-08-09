Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Vision.Motion
Imports Accord.Imaging.Filters
Imports Accord.Vision.Detection
Imports Accord.Vision.Detection.Cascades
Imports System.Threading
Imports System.Speech.Synthesis
Imports System.IO
Imports System.Data
Imports System.Data.SQLite


Public Class frmWelcome

    Private CurrentBitmapForDecoding As Bitmap
    'Private trdWelcomeMessage As Thread
    Private trdDecodingThread As Thread
    'Private applicationSecret() As Byte = Convert.FromBase64String("1MwJISib7UapJpd7/aMKzA==")
    'create code for public key
    'Private publicKey() As Byte = Convert.FromBase64String("BgIAAACkAABSU0ExAAIAAAEAAQDLdYcn2V1VT3ODzg4ewbI7IeLXw7l4xokhVx+FM8JarAGde2BOShTnixLbI8RzQk0ONCJgnZyhQlm99OcDt7PI")
    'Public LicenseStatus As Habanero.Licensing.Validation.LicenseValidationResult = Validator.CheckLicense

    Private Const MOUSEEVENTF_MOVE = &H1 'Mouse movement occurred

    Private Declare Sub mouse_event Lib "user32" Alias "mouse_event" _
        (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, _
         ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

    'Private ReadOnly Property Validator As Habanero.Licensing.Validation.LicenseValidator
    '    Get
    '        'this version is for file system - Isolated storage is anther option
    '        Return New Habanero.Licensing.Validation.LicenseValidator(Habanero.Licensing.Validation.LicenseLocation.UserIsolatedStorage, "Path", "Hello", publicKey, applicationSecret, ThisVersion)
    '    End Get
    'End Property

    Public Shared ReadOnly Property ThisVersion As Version
        Get
            'Get the executing files filesversion
            Dim fileversion As FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Return New Version(fileversion.FileMajorPart, fileversion.FileMinorPart, fileversion.FileBuildPart, fileversion.FilePrivatePart)
        End Get
    End Property

    Private Sub frmWelcome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim InputPassword As String = ""
            Dim hashClass As New MD5Class
            Dim PasswordDialog As New Password()
            PasswordDialog.Text = "Security Check"
            Me.TopMost = False
            If My.Settings.SystemPassword.Length > 0 Then
                If PasswordDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    InputPassword = PasswordDialog.Password
                    If hashClass.VerifyMd5Hash(InputPassword, My.Settings.SystemPassword) Then
                        vplWelcome.SignalToStop()
                        vplWelcome.WaitForStop()
                        'VideoDevices = Nothing
                        'VideoCaptureSource = Nothing
                        If trdDecodingThread IsNot Nothing Then trdDecodingThread.Abort()
                    Else
                        e.Cancel = True
                    End If
                Else
                    e.Cancel = True
                End If
            Else
                vplWelcome.SignalToStop()
                vplWelcome.WaitForStop()
                'VideoDevices = Nothing
                'VideoCaptureSource = Nothing
                If trdDecodingThread IsNot Nothing Then trdDecodingThread.Abort()
            End If
        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        InitializeDisplay()
        InitializeSettings()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub InitializeDisplay()
        'Centers form to screen.
        Me.CenterToScreen()
        'Sets form to ontop of all other forms and Desktop!
        Me.TopMost = True
        'trdWelcomeMessage = New Thread(AddressOf WelcomeMessage)
        Dim DesignScreenWidth As Integer = 1366
        Dim DesignScreenHeight As Integer = 768
        Dim CurrentScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim CurrentScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim RatioX As Double = CurrentScreenWidth / DesignScreenWidth
        Dim RatioY As Double = CurrentScreenHeight / DesignScreenHeight
        For Each iControl In Me.Controls
            With iControl
                If (.GetType.GetProperty("Width").CanRead) Then .width = CInt(.width * RatioX)
                If (.GetType.GetProperty("Height").CanRead) Then .height = CInt(.height * RatioY)
                If (.GetType.GetProperty("Top").CanRead) Then .top = CInt(.top * RatioX)
                If (.GetType.GetProperty("Left").CanRead) Then .left = CInt(.left * RatioY)
                If (.GetType.GetProperty("Font").CanRead) Then .font = New Font(My.Settings.FontName.Name, .font.size * RatioX, My.Settings.FontName.Style)
            End With
        Next
        Me.Width = My.Computer.Screen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.CenterToScreen()
        If My.Settings.VisitorLogLocation = "" Then
            My.Settings.VisitorLogLocation = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Receptio\"
        End If
        If Not Directory.Exists(My.Settings.VisitorLogLocation) Then Directory.CreateDirectory(My.Settings.VisitorLogLocation)
        If My.Settings.EmployeeDirectoryLocation = "" Then
            My.Settings.EmployeeDirectoryLocation = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Receptio\"
        End If
        If Not Directory.Exists(My.Settings.EmployeeDirectoryLocation) Then Directory.CreateDirectory(My.Settings.EmployeeDirectoryLocation)
        Dim dbLogFile As String
        dbLogFile = My.Settings.VisitorLogLocation & "Visitor Log.db3"
        If Not System.IO.File.Exists(dbLogFile) Then
            CreateVisitorLogDB(dbLogFile)
        End If
        Dim EmpDirFile As String
        EmpDirFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
        If Not System.IO.File.Exists(EmpDirFile) Then
            CreateEmployeeDirectoryDB(EmpDirFile)
        End If
        'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Trial) Then
        '    Me.Text = Me.Text + " | Free 30 Day Trial"
        'End If
        'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Invalid) Then
        '    Me.Text = Me.Text + " | Demo Mode"
        'End If
    End Sub

    Public Sub InitializeSettings()
        Dim VideoCaptureSource As VideoCaptureDevice
        Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        'Dim MySingleDevice As FilterInfo
        btnSignIn.Text = My.Settings.SignInButtonText
        btnSignOut.Text = My.Settings.SignOutButtonText
        btnSignIn.BackColor = My.Settings.SignInButtonColor
        btnSignOut.BackColor = My.Settings.SignOutButtonColor
        Me.BackColor = My.Settings.WelcomeBackgroundColor
        Me.ForeColor = My.Settings.FontColor
        lblWelcome.Text = My.Settings.WelcomeText

        If System.IO.File.Exists(My.Settings.CompanyLogo) Then
            picLogo.ImageLocation = My.Settings.CompanyLogo
        Else
            picLogo.Image = My.Resources.original_1358_2745186
        End If
        If vplWelcome.IsRunning = True Then
            vplWelcome.SignalToStop()
            vplWelcome.WaitForStop()
        End If
        VideoCaptureSource = New VideoCaptureDevice(VideoDevices(My.Settings.VideoSource).MonikerString)
        If (VideoCaptureSource.VideoCapabilities IsNot Nothing) And (VideoCaptureSource.VideoCapabilities.Length <> 0) Then
            VideoCaptureSource.VideoResolution = VideoCaptureSource.VideoCapabilities(My.Settings.CameraResolutionIndex)
        End If
        vplWelcome.VideoSource = VideoCaptureSource
        vplWelcome.Start()
        If trdDecodingThread IsNot Nothing Then
            If trdDecodingThread.IsAlive Then
                trdDecodingThread.Abort()
            End If
        End If
        If My.Settings.UseVisitorDetection Then
            If My.Settings.UseMotionDetection Or My.Settings.UseFaceDetection Then
                trdDecodingThread = New Thread(AddressOf ProcessImage)
                trdDecodingThread.Start()
            End If
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim InputPassword As String = ""
        Dim hashClass As New MD5Class
        Dim PasswordDialog As New Password()
        PasswordDialog.Text = "Security Check"
        Me.TopMost = False
        If My.Settings.SystemPassword.Length > 0 Then
            If PasswordDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                InputPassword = PasswordDialog.Password
                If hashClass.VerifyMd5Hash(InputPassword, My.Settings.SystemPassword) Then
                    'Dim frm As New frmSettings(Validator)
                    Dim frm As New frmSettings
                    vplWelcome.SignalToStop()
                    vplWelcome.WaitForStop()
                    If trdDecodingThread IsNot Nothing Then trdDecodingThread.Abort()
                    frm.ShowDialog()
                    frm.Dispose()
                    InitializeSettings()
                End If
            End If
        Else
            'Dim frm As New frmSettings(Validator)
            Dim frm As New frmSettings
            vplWelcome.SignalToStop()
            vplWelcome.WaitForStop()
            If trdDecodingThread IsNot Nothing Then trdDecodingThread.Abort()
            frm.ShowDialog()
            frm.Dispose()
            InitializeSettings()
        End If
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim frm As New frmSignIn
        vplWelcome.SignalToStop()
        vplWelcome.WaitForStop()
        If trdDecodingThread IsNot Nothing Then trdDecodingThread.Abort()
        frm.ShowDialog()
        frm.Dispose()
        InitializeSettings()
    End Sub

    Private Sub ProcessImage()

        Dim FaceDetector As New HaarObjectDetector(New FaceHaarCascade, 30)
        Dim NumberOfFaces() As Rectangle
        Dim Detector As New MotionDetector(New SimpleBackgroundModelingDetector(True, True))
        Dim MotionLevel As Single

        'Dim AltHaar As HaarCascade
        'AltHaar = HaarCascade.FromXml("C:\Users\mkotson\Documents\AForge.NET-master\AForge.NET-master\haarcascade_frontalface_default.xml") 'frontalface_default fewest false positives
        'Dim FaceDetector As New HaarObjectDetector(AltHaar)

        If My.Settings.UseFaceDetection Then
            FaceDetector.SearchMode = ObjectDetectorSearchMode.Average
            FaceDetector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller
            FaceDetector.ScalingFactor = 1.5F   '1.5 was old value, 1.1 fewest false positives but requires 100% CPU
            FaceDetector.UseParallelProcessing = True
            'FaceDetector.Suppression = 4    '2 was old value
            FaceDetector.Suppression = My.Settings.FaceDetectionSensitivity
        End If
        While (True)
            If CurrentBitmapForDecoding IsNot Nothing Then
                If My.Settings.UseMotionDetection = True Then
                    If Detector IsNot Nothing Then
                        MotionLevel = Detector.ProcessFrame(CurrentBitmapForDecoding)
                        If MotionLevel > (My.Settings.MotionSensitivity / 10) Then
                            WelcomeMessage()
                        End If
                    End If
                End If
                If My.Settings.UseFaceDetection = True Then
                    If FaceDetector IsNot Nothing Then
                        NumberOfFaces = FaceDetector.ProcessFrame(CurrentBitmapForDecoding)
                        'For Each face In NumberOfFaces
                        'Me.BeginInvoke(Sub() Label1.Text = NumberOfFaces.Length)
                        If NumberOfFaces.Length > 0 Then
                            WelcomeMessage()
                        End If

                        'Next
                    End If
                End If
                CurrentBitmapForDecoding.Dispose()
                CurrentBitmapForDecoding = Nothing
                Thread.Sleep(200)
            End If
        End While
    End Sub

    Private Sub vplWelcome_NewFrame(sender As Object, ByRef image As Bitmap) Handles vplWelcome.NewFrame
        image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        If CurrentBitmapForDecoding Is Nothing Then CurrentBitmapForDecoding = image.Clone()
    End Sub

    Private Sub WelcomeMessage()
        Dim speaker As New SpeechSynthesizer()
        speaker.Rate = 0
        speaker.Volume = 100
        speaker.Speak(My.Settings.WelcomeMessage)
        speaker.Dispose()
        Thread.Sleep(My.Settings.MotionDelay * 1000)
    End Sub

    Public Sub CreateVisitorLogDB(ByVal dbLogFile As String)
        Dim SQLconnect As New SQLite.SQLiteConnection
        Dim SQLcommand As SQLiteCommand
        SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "CREATE TABLE logfile(id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Company TEXT, EMail TEXT, Visiting TEXT, Date TEXT, SignIn TEXT, SignOut TEXT, Photo BLOB);"
        SQLcommand.ExecuteNonQuery()
        'SQLcommand.CommandText = "CREATE TABLE guests(Name TEXT PRIMARY KEY, Company TEXT, Face BLOB);"
        'SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
        SQLconnect.Close()
    End Sub

    Public Sub CreateEmployeeDirectoryDB(ByVal dbEmployeeDirectoryFile As String)
        Dim SQLconnect As New SQLite.SQLiteConnection
        Dim SQLcommand As SQLiteCommand
        SQLconnect.ConnectionString = "Data Source=" & dbEmployeeDirectoryFile & ";"
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "CREATE TABLE employee(id INTEGER PRIMARY KEY AUTOINCREMENT, FirstName TEXT, LastName TEXT, Title TEXT, EMail TEXT, Phone TEXT, Photo BLOB);"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
        SQLconnect.Close()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim frm As New frmSignOutScreen
        vplWelcome.SignalToStop()
        vplWelcome.WaitForStop()
        If trdDecodingThread IsNot Nothing Then trdDecodingThread.Abort()
        frm.ShowDialog()
        frm.Dispose()
        InitializeSettings()
    End Sub


End Class