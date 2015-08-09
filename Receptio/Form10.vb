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

Public Class frmSignOutScreen
    Private reader As New ZXing.BarcodeReader
    Private result As ZXing.Result
    Private CurrentBitmapForDecoding As Bitmap
    Private trdDecodingThread As Thread

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
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub InitializeSettings()
        Dim VideoCaptureSource As VideoCaptureDevice
        Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        Dim time As DateTime = DateTime.Now
        Dim DateFormat As String = "d"
        Dim TimeFormat As String = "t"
        Dim VisitorNames As New List(Of EmployeeDirectoryClass)
        Dim SQLConnect As New SQLite.SQLiteConnection
        Dim VisitorLogFile As String
        Me.BackColor = My.Settings.SignOutBackgroundColor
        Me.ForeColor = My.Settings.FontColor
        lblInstructions.Text = My.Settings.SignOutInstructions
        cmbVisitorSignOut.CueText = My.Settings.SignOutVisitor
        vplSignOut.BackColor = My.Settings.WelcomeBackgroundColor
        VisitorLogFile = My.Settings.EmployeeDirectoryLocation & "Visitor Log.db3"
        Try
            SQLConnect.ConnectionString = "Data Source=" & VisitorLogFile & ";"
            Dim SQLCommand As New SQLite.SQLiteCommand("SELECT id, name FROM logfile WHERE date='" & time.ToString(DateFormat) & "' AND SignOut=''", SQLConnect)
            'Dim SQLCommand As New SQLite.SQLiteCommand("SELECT id, name FROM logfile", SQLConnect)
            SQLConnect.Open()
            Dim SQLReader As SQLite.SQLiteDataReader = SQLCommand.ExecuteReader()
            While SQLReader.Read()
                VisitorNames.Add(New EmployeeDirectoryClass(SQLReader("name"), SQLReader("id")))
                'DirectoryNames.Add(New EmployeeDirectoryClass(SQLReader("LastName") & ", " & SQLReader("FirstName"), SQLReader("id")))
            End While
            SQLReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLConnect.Close()
        End Try
        VisitorNames.Sort(Function(x, y) x.Description.CompareTo(y.Description))
        cmbVisitorSignOut.DataSource = VisitorNames
        cmbVisitorSignOut.DisplayMember = "Description"
        cmbVisitorSignOut.ValueMember = "Value"
        cmbVisitorSignOut.SelectedIndex = -1

        'If vplSignOut.IsRunning = True Then
        '    vplSignOut.SignalToStop()
        '    vplSignOut.WaitForStop()
        'End If
        VideoCaptureSource = New VideoCaptureDevice(VideoDevices(My.Settings.VideoSource).MonikerString)
        If (VideoCaptureSource.VideoCapabilities IsNot Nothing) And (VideoCaptureSource.VideoCapabilities.Length <> 0) Then
            VideoCaptureSource.VideoResolution = VideoCaptureSource.VideoCapabilities(My.Settings.CameraResolutionIndex)
        End If
        vplSignOut.VideoSource = VideoCaptureSource
        vplSignOut.Start()
        If trdDecodingThread IsNot Nothing Then
            If trdDecodingThread.IsAlive Then
                trdDecodingThread.Abort()
            End If
        End If
        If My.Settings.VisitorBadgePrinting Then
            trdDecodingThread = New Thread(AddressOf ProcessImage)
            trdDecodingThread.Start()
        End If
    End Sub

    Private Sub frmSignOutScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        vplSignOut.SignalToStop()
        vplSignOut.WaitForStop()
        If trdDecodingThread IsNot Nothing Then trdDecodingThread.Abort()
    End Sub

    Private Sub vplSignOut_Click(sender As Object, e As EventArgs) Handles vplSignOut.Click
        If cmbVisitorSignOut.SelectedIndex > -1 Then
            'MsgBox(cmbVisitorSignOut.SelectedValue.ToString)
            SignOut(cmbVisitorSignOut.SelectedValue)
        End If
    End Sub

    Private Sub vplSignOut_NewFrame(sender As Object, ByRef image As Bitmap) Handles vplSignOut.NewFrame
        image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        If CurrentBitmapForDecoding Is Nothing Then CurrentBitmapForDecoding = image.Clone()
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
        'Dim SQLconnectRead As New SQLite.SQLiteConnection
        'Dim SQLcommandRead As SQLiteCommand
        Dim dbLogFile As String
        dbLogFile = My.Settings.VisitorLogLocation & "Visitor Log.db3"
        If Not System.IO.File.Exists(dbLogFile) Then
            frmWelcome.CreateVisitorLogDB(dbLogFile)
        End If
        'Read the data of the QR code index
        'Try
        '    SQLconnectRead.ConnectionString = "Data Source=" & dbLogFile & ";"
        '    SQLconnectRead.Open()
        '    SQLcommandRead = SQLconnectRead.CreateCommand
        '    SQLcommandRead.CommandText = "SELECT * FROM logfile WHERE id=" & index & ";"
        '    Dim SQLReader As SQLite.SQLiteDataReader = SQLcommandRead.ExecuteReader
        '    While SQLReader.Read
        '        ReadName = SQLReader("Name")
        '        ReadCompany = SQLReader("Company")
        '        ReadVisiting = SQLReader("Visiting")
        '        ReadEmail = SQLReader("Email")
        '    End While
        '    SQLReader.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    SQLconnectRead.Close()
        'End Try
        'Insert the data read from the QR code index
        Try
            SQLconnect.ConnectionString = "Data Source=" & dbLogFile & ";"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            'SQLcommand.CommandText = "INSERT INTO logfile (Name, Company, Email, Visiting, Date, Time, Status) VALUES ('" & ReadName & "', '" & ReadCompany & "', '" & ReadEmail & "', '" & ReadVisiting & "', '" & time.ToString(DateFormat) & "', '" & time.ToString(TimeFormat) & "', 'OUT')"
            SQLcommand.CommandText = "UPDATE logfile SET SignOut='" & time.ToString(TimeFormat) & "' WHERE id=" & index & ";"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLconnect.Close()
        End Try
        If Me.InvokeRequired Then
            Application.Run(New frmSignOut)
            frmSignOut.Dispose()
            CloseMe()
        Else
            Dim frm As New frmSignOut
            frm.ShowDialog()
            frm.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub ProcessImage()
        Dim reader As New ZXing.BarcodeReader
        Dim result As ZXing.Result
        While (True)
            If CurrentBitmapForDecoding IsNot Nothing Then
                result = reader.Decode(CurrentBitmapForDecoding)
                If result IsNot Nothing Then
                    If result.Text.Length > 0 And IsNumeric(result.Text) Then
                        SignOut(Convert.ToInt32(result.Text))
                        Thread.Sleep(5000)
                    End If
                End If
                CurrentBitmapForDecoding.Dispose()
                CurrentBitmapForDecoding = Nothing
                Thread.Sleep(200)
            End If
        End While
    End Sub

    Private Sub CloseMe()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf CloseMe))
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub cmbVisitorSignOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVisitorSignOut.SelectedIndexChanged
        If cmbVisitorSignOut.SelectedIndex > -1 Then
            vplSignOut.Cursor = Cursors.Hand
        Else
            vplSignOut.Cursor = Cursors.No
        End If
    End Sub

    Private Sub frmSignOutScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeDisplay()
        InitializeSettings()
    End Sub
End Class