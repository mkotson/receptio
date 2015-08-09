Option Explicit On

Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.IO
Imports System.Data
Imports System.Data.SQLite
Imports System.Drawing
Imports System.Speech.Synthesis
Imports System.Threading
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Vision.Motion
Imports System.Drawing.Drawing2D
Imports MailChimp
Imports MailChimp.Lists
Imports MailChimp.Helper
Imports Accord.Imaging.Filters
Imports Accord.Vision.Detection
Imports Accord.Vision.Detection.Cascades



Public Class frmSignIn

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        vplSignIn.SignalToStop()
        vplSignIn.WaitForStop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDisplay()
        InitializeSettings()
    End Sub

    Public Sub InitializeSettings()
        Dim VideoCaptureSource As VideoCaptureDevice
        Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        lblInstructions.Text = My.Settings.SignInInstructions
        txtName.CueText = My.Settings.NameText
        txtCompany.CueText = My.Settings.CompanyText
        txtEmail.CueText = My.Settings.EmailText
        cmbEmployeeDirectory.CueText = My.Settings.VisitingText
        txtEmail.Visible = My.Settings.EmailVisible
        txtCompany.Visible = My.Settings.CompanyVisible
        Me.BackColor = My.Settings.SignInBackgroundColor
        Me.ForeColor = My.Settings.FontColor
        '
        'Adjust font settings
        For Each iControl In Me.Controls
            With iControl
                If (.GetType.GetProperty("Font").CanRead) Then .font = New Font(My.Settings.FontName.Name, .font.size, My.Settings.FontName.Style)
            End With
        Next
        vplSignIn.BackColor = My.Settings.WelcomeBackgroundColor
        If System.IO.File.Exists(My.Settings.BackgroundImage) Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.BackgroundImage)
        Else
            Me.BackgroundImage = Nothing
        End If
        Dim DirectoryNames As New List(Of EmployeeDirectoryClass)
        Dim SQLConnect As New SQLite.SQLiteConnection
        Dim EmployeeDirectoryFile As String

        EmployeeDirectoryFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
        Try
            SQLConnect.ConnectionString = "Data Source=" & EmployeeDirectoryFile & ";"
            Dim SQLCommand As New SQLite.SQLiteCommand("SELECT id, FirstName, LastName FROM employee", SQLConnect)
            SQLConnect.Open()
            Dim SQLReader As SQLite.SQLiteDataReader = SQLCommand.ExecuteReader()
            While SQLReader.Read()
                DirectoryNames.Add(New EmployeeDirectoryClass(SQLReader("LastName") & ", " & SQLReader("FirstName"), SQLReader("id")))
            End While
            SQLReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLConnect.Close()
        End Try
        DirectoryNames.Sort(Function(x, y) x.Description.CompareTo(y.Description))
        cmbEmployeeDirectory.DataSource = DirectoryNames
        cmbEmployeeDirectory.DisplayMember = "Description"
        cmbEmployeeDirectory.ValueMember = "Value"
        cmbEmployeeDirectory.SelectedIndex = -1
        If vplSignIn.IsRunning = True Then
            vplSignIn.SignalToStop()
            vplSignIn.WaitForStop()
        End If
        VideoCaptureSource = New VideoCaptureDevice(VideoDevices(My.Settings.VideoSource).MonikerString)
        If (VideoCaptureSource.VideoCapabilities IsNot Nothing) And (VideoCaptureSource.VideoCapabilities.Length <> 0) Then
            VideoCaptureSource.VideoResolution = VideoCaptureSource.VideoCapabilities(My.Settings.CameraResolutionIndex)
        End If
        vplSignIn.VideoSource = VideoCaptureSource
        vplSignIn.Start()
    End Sub
    Private Sub InitializeDisplay()

        'Centers form to screen.
        Me.CenterToScreen()
        'Sets form to ontop of all other forms and Desktop!
        Me.TopMost = True
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
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overloads Function ImageToBlob(ByVal id As String, ByVal filePath As String)
        Dim fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim bm() As Byte = br.ReadBytes(fs.Length)
        br.Close()
        fs.Close()
        'Create Parm
        Dim photo() As Byte = bm
        Dim SQLparm As New SQLiteParameter("@image", photo)
        SQLparm.DbType = DbType.Binary
        SQLparm.Value = photo
        Return SQLparm
    End Function

    Private Sub vplSignIn_Click(sender As Object, e As EventArgs) Handles vplSignIn.Click
        If txtName.TextLength > 0 And cmbEmployeeDirectory.SelectedIndex > -1 Then

            My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
            Dim TempFileName As String = System.IO.Path.GetTempPath + "thumbnail.jpg"
            Dim CapturedImage As Image = Nothing
            Dim ResizedImage As Image = Nothing
            Dim BrightnessCorrection As New AForge.Imaging.Filters.BrightnessCorrection(25)
            If vplSignIn.IsRunning = True Then
                CapturedImage = vplSignIn.GetCurrentVideoFrame
                BrightnessCorrection.ApplyInPlace(CapturedImage)
                If My.Settings.SnapshotResolutionIndex = 0 Then
                    ResizedImage = ResizeImage(CapturedImage, New Size(160, 120), True)
                ElseIf My.Settings.SnapshotResolutionIndex = 1 Then
                    ResizedImage = ResizeImage(CapturedImage, New Size(320, 240), True)
                ElseIf My.Settings.SnapshotResolutionIndex = 2 Then
                    ResizedImage = ResizeImage(CapturedImage, New Size(640, 480), True)
                Else
                    ResizedImage = CapturedImage
                End If
                ResizedImage.Save(TempFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
            Dim mail As New MailMessage()
            Dim attachment As System.Net.Mail.Attachment
            'set the addresses
            'configure mail settings
            If My.Settings.EmailNotifications Then
                mail.From = New MailAddress(My.Settings.MailFrom)
                Dim SQLConnectEmp As New SQLite.SQLiteConnection
                Dim EmployeeDirectoryFile As String

                EmployeeDirectoryFile = My.Settings.EmployeeDirectoryLocation & "Employee Directory.db3"
                Try
                    SQLConnectEmp.ConnectionString = "Data Source=" & EmployeeDirectoryFile & ";"
                    Dim SQLCommandEmp As New SQLite.SQLiteCommand("SELECT * FROM employee WHERE id=" & cmbEmployeeDirectory.SelectedValue.ToString & ";", SQLConnectEmp)
                    SQLConnectEmp.Open()
                    Dim SQLReader As SQLite.SQLiteDataReader = SQLCommandEmp.ExecuteReader()
                    While SQLReader.Read()
                        mail.[To].Add(SQLReader("Email"))
                    End While
                    SQLReader.Close()
                Catch ex As Exception
                Finally
                    SQLConnectEmp.Close()
                End Try
                'set the content
                mail.Subject = "Visitor Notification - " + My.Settings.LocationName
                If txtCompany.TextLength > 0 Then
                    mail.Body = "Announcing the arrival of " + txtName.Text + " from " + txtCompany.Text + "."
                Else
                    mail.Body = "Announcing the arrival of " + txtName.Text + "."
                End If

                mail.Priority = MailPriority.High
                attachment = New System.Net.Mail.Attachment(TempFileName)
                mail.Attachments.Add(attachment)
                'set the server
                Dim smtp As New SmtpClient(My.Settings.SMTPServerName, My.Settings.SMTPPort)
                If My.Settings.Authentication Then smtp.Credentials = New Net.NetworkCredential(My.Settings.SMTPUserName, My.Settings.SMTPPassword)
                smtp.EnableSsl = My.Settings.EnableSSL
                Try
                    smtp.Send(mail)
                    Dim frm As New frmNotify(cmbEmployeeDirectory.SelectedText)
                    frm.ShowDialog()
                Catch exc As Exception
                    MsgBox(exc.ToString)
                End Try
                attachment.Dispose()
            End If
            'Dim CSVLogFile As String
            Dim time As DateTime = DateTime.Now
            Dim DateFormat As String = "d"
            Dim TimeFormat As String = "t"

            'CSVLogFile = My.Settings.LogFile & "LobbyLink Logfile.csv"
            'Using LogFile As StreamWriter = New StreamWriter(CSVLogFile, True)
            'LogFile.WriteLine("IN," + txtName.Text + "," + txtCompany.Text + "," + arrName(cmbContacts.SelectedIndex) + "," + time.ToString(DateFormat) + "," + time.ToString(TimeFormat))
            'LogFile.Close()
            'End Using

            Dim SQLconnect As New SQLite.SQLiteConnection
            Dim SQLcommand As SQLiteCommand
            Dim LastID As String = ""
            Dim dbLogFile As String
            dbLogFile = My.Settings.VisitorLogLocation & "Visitor Log.db3"
            If Not System.IO.File.Exists(dbLogFile) Then
                frmWelcome.CreateVisitorLogDB(dbLogFile)
            End If
            Try
                SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
                SQLconnect.Open()
                SQLcommand = SQLconnect.CreateCommand
                SQLcommand.CommandText = "INSERT INTO logfile (Name, Company, Email, Visiting, Date, SignIn, SignOut, Photo) VALUES ('" & txtName.Text & "', '" & txtCompany.Text & "', '" & txtEmail.Text & "', '" & cmbEmployeeDirectory.SelectedText & "', '" & time.ToString(DateFormat) & "', '" & time.ToString(TimeFormat) & "', '',  @image)"
                SQLcommand.Parameters.Add(ImageToBlob("@image", TempFileName))
                SQLcommand.ExecuteNonQuery()
                SQLcommand.CommandText = "SELECT last_insert_rowid()"
                LastID = SQLcommand.ExecuteScalar
                SQLcommand.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                SQLconnect.Close()
            End Try
            If My.Settings.VisitorBadgePrinting Then PrintBadge(txtName.Text, txtCompany.Text, LastID, TempFileName)
            'Mailchimp section
            If My.Settings.UseMailChimp And txtEmail.TextLength > 0 Then
                MailChimpSubscribe()
            End If
            'MailChimp End
            txtName.Text = ""
            txtCompany.Text = ""
            txtEmail.Text = ""
            cmbEmployeeDirectory.SelectedIndex = 0
            cmbEmployeeDirectory.SelectedIndex = -1
            System.IO.File.Delete(TempFileName)
            Me.Close()
        End If
    End Sub

    Private Sub VideoSourcePlayer1_NewFrame(sender As Object, ByRef image As Bitmap) Handles vplSignIn.NewFrame
        image.RotateFlip(RotateFlipType.RotateNoneFlipX)
    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        If My.Settings.UseTouchUI Then
            'Dim LicenseStatus As Habanero.Licensing.Validation.LicenseValidationResult = Validator.CheckLicense()
            'Dim ProOrHigher As String() = {"Pro", "EnterPrise"}
            'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Trial) Or ((LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Valid) And (Validator.IsEdition(ProOrHigher))) Then
            Dim TouchKeyboard As New frmTouchKeyboard
            If frmTouchKeyboard.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtName.Text = frmTouchKeyboard.Input
            End If
            'End If
        End If
    End Sub

    Private Sub txtName_TextChanged1(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If txtName.TextLength > 0 And cmbEmployeeDirectory.SelectedIndex > -1 Then
            vplSignIn.Cursor = Cursors.Hand
        Else
            vplSignIn.Cursor = Cursors.No
        End If
        tmrSignIn.Enabled = False
        tmrSignIn.Enabled = True
    End Sub

    Private Sub txtCompany_Click(sender As Object, e As EventArgs) Handles txtCompany.Click
        If My.Settings.UseTouchUI Then
            'Dim LicenseStatus As Habanero.Licensing.Validation.LicenseValidationResult = Validator.CheckLicense()
            'Dim ProOrHigher As String() = {"Pro", "EnterPrise"}
            'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Trial) Or ((LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Valid) And (Validator.IsEdition(ProOrHigher))) Then
            Dim TouchKeyboard As New frmTouchKeyboard
            If frmTouchKeyboard.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCompany.Text = frmTouchKeyboard.Input
            End If
            'End If
        End If
    End Sub

    Private Sub txtCompany_TextChanged1(sender As Object, e As EventArgs) Handles txtCompany.TextChanged
        If txtName.TextLength > 0 And cmbEmployeeDirectory.SelectedIndex > -1 Then
            vplSignIn.Cursor = Cursors.Hand
        Else
            vplSignIn.Cursor = Cursors.No
        End If
        tmrSignIn.Enabled = False
        tmrSignIn.Enabled = True
    End Sub

    Private Sub cmbContacts_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles cmbEmployeeDirectory.SelectedIndexChanged
        If txtName.TextLength > 0 And cmbEmployeeDirectory.SelectedIndex > -1 Then
            vplSignIn.Cursor = Cursors.Hand
        Else
            vplSignIn.Cursor = Cursors.No
        End If
        tmrSignIn.Enabled = False
        tmrSignIn.Enabled = True
    End Sub

    Public Sub PrintBadge(VisitorName As String, VisitorCompany As String, VisitorIDNumber As String, VisitorPicture As String)
        'Dim LicenseStatus As Habanero.Licensing.Validation.LicenseValidationResult = Validator.CheckLicense()
        'Dim ProOrHigher As String() = {"Pro", "EnterPrise"}
        'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Trial) Or ((LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Valid) And (Validator.IsEdition(ProOrHigher))) Then
        Dim objDoc As bpac.Document
        objDoc = CreateObject("bpac.Document")
        If (objDoc.Open(Path.GetDirectoryName(Application.ExecutablePath) + "\Brother\Visitorbadge.lbx") <> False) Then
            objDoc.GetObject("objName").Text = VisitorName
            objDoc.GetObject("objCompany").Text = VisitorCompany
            objDoc.GetObject("objQRCode").Text = VisitorIDNumber
            objDoc.GetObject("objPicture").SetData(0, VisitorPicture, 4)

            objDoc.StartPrint("", bpac.PrintOptionConstants.bpoDefault)
            objDoc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault)
            objDoc.EndPrint()
            objDoc.Close()
        End If
    End Sub

    Public Sub MailChimpSubscribe()
        'Dim LicenseStatus As Habanero.Licensing.Validation.LicenseValidationResult = Validator.CheckLicense()
        'Dim ProOrHigher As String() = {"Pro", "EnterPrise"}
        'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Trial) Or ((LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Valid) And (Validator.IsEdition(ProOrHigher))) Then
        Try
            Dim mc As New MailChimpManager(My.Settings.MailChimpAPIKey)
            Dim email As New EmailParameter
            'Dim list As ListResult
            Dim MyMergeVar As New MergeVar
            Dim Name() As String
            Dim FirstName, LastName As String
            Dim counter As Integer

            FirstName = ""
            LastName = ""
            Name = txtName.Text.Split()
            FirstName = Name(0)
            For counter = 1 To Name.Length - 1
                LastName = LastName + Name(counter)
            Next

            email.Email = txtEmail.Text
            MyMergeVar.Add("FNAME", FirstName)
            MyMergeVar.Add("LNAME", LastName)

            'mc.Subscribe("Hello", email)
            'list = mc.GetLists()
            'For Each listitem In list.Data
            '    MessageBox.Show(listitem.Name)
            '    MessageBox.Show(listitem.Id)
            '    MessageBox.Show(FirstName)
            '    MessageBox.Show(LastName)
            '    mc.Subscribe(listitem.Id, email, MyMergeVar)
            'Next
            mc.Subscribe(My.Settings.MailChimpListID, email, MyMergeVar, , , True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'End If
    End Sub

    Public Shared Function ResizeImage(ByVal image As Image, _
  ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function


    Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click
        If My.Settings.UseTouchUI Then
            'Dim LicenseStatus As Habanero.Licensing.Validation.LicenseValidationResult = Validator.CheckLicense()
            'Dim ProOrHigher As String() = {"Pro", "EnterPrise"}
            'If (LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Trial) Or ((LicenseStatus.State = Habanero.Licensing.Validation.LicenseState.Valid) And (Validator.IsEdition(ProOrHigher))) Then
            Dim TouchKeyboard As New frmTouchKeyboard
            If frmTouchKeyboard.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtEmail.Text = frmTouchKeyboard.Input
                'MsgBox(frmTouchKeyboard.Input)
            End If
            'End If
        End If
    End Sub

    Private Sub SignOut(ByVal index As Integer)
        Dim time As DateTime = DateTime.Now
        Dim DateFormat As String = "d"
        Dim TimeFormat As String = "t"
        Dim ReadName As String = "Unknown"
        Dim ReadCompany As String = "Unknown"
        Dim ReadVisiting As String = "Unknown"
        Dim ReadEmail As String = "Unknown"

        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        Dim SQLconnect As New SQLite.SQLiteConnection
        Dim SQLcommand As SQLiteCommand
        Dim SQLconnectRead As New SQLite.SQLiteConnection
        Dim SQLcommandRead As SQLiteCommand
        Dim dbLogFile As String
        dbLogFile = My.Settings.VisitorLogLocation & "Visitor Log.db3"
        If Not System.IO.File.Exists(dbLogFile) Then
            frmWelcome.CreateVisitorLogDB(dbLogFile)
        End If
        'Read the data of the QR code index
        Try
            SQLconnectRead.ConnectionString = "Data Source=" & dbLogFile & ";"
            SQLconnectRead.Open()
            SQLcommandRead = SQLconnectRead.CreateCommand
            SQLcommandRead.CommandText = "SELECT * FROM logfile WHERE id=" & index & ";"
            Dim SQLReader As SQLite.SQLiteDataReader = SQLcommandRead.ExecuteReader
            While SQLReader.Read
                ReadName = SQLReader("Name")
                ReadCompany = SQLReader("Company")
                ReadVisiting = SQLReader("Visiting")
                ReadEmail = SQLReader("Email")
            End While
            SQLReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLconnectRead.Close()
        End Try
        'Insert the data read from the QR code index
        Try
            SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "INSERT INTO logfile (Name, Company, Email, Visiting, Date, Time, Status) VALUES ('" & ReadName & "', '" & ReadCompany & "', '" & ReadEmail & "', '" & ReadVisiting & "', '" & time.ToString(DateFormat) & "', '" & time.ToString(TimeFormat) & "', 'OUT')"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLconnect.Close()
        End Try
        Application.Run(New frmSignOut)
        frmSignOut.Dispose()
    End Sub


    'Private Sub slideToDestination(destination As Control, control As Control, delay As Integer)

    '    ' form could be disposed


    '    Dim t As New Task(Function()
    '                          Dim directionX As Integer = If(destination.Left > control.Left, 1, -1)
    '                          Dim directionY As Integer = If(destination.Bottom > control.Top, 1, -1)
    '                          While control.Left <> destination.Left OrElse control.Top <> destination.Bottom
    '                              Try
    '                                  If control.Left <> destination.Left Then
    '                                      Me.Invoke(DirectCast(Sub() control.Left += directionX, Action))
    '                                  End If
    '                                  If control.Top <> destination.Bottom Then
    '                                      Me.Invoke(DirectCast(Sub() control.Top += directionY, Action))
    '                                  End If
    '                                  Thread.Sleep(delay)
    '                              Catch
    '                                  Exit Try
    '                              End Try
    '                          End While

    '                      End Function)
    '    t.Start()
    'End Sub

    Private Sub tmrSignIn_Tick(sender As Object, e As EventArgs) Handles tmrSignIn.Tick
        Me.Close()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If txtName.TextLength > 0 And cmbEmployeeDirectory.SelectedIndex > -1 Then
            vplSignIn.Cursor = Cursors.Hand
        Else
            vplSignIn.Cursor = Cursors.No
        End If
        tmrSignIn.Enabled = False
        tmrSignIn.Enabled = True
    End Sub

    Private Sub btnBack_Click1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class

