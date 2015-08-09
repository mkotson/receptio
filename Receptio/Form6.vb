Public Class frmLicense
    'Dim LicenseValidator As Habanero.Licensing.Validation.LicenseValidator

    'Public Sub New(ByVal Validator As Habanero.Licensing.Validation.LicenseValidator)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LicenseValidator = Validator
    End Sub

    Private Sub frmLicense_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        'Dim result As Habanero.Licensing.Validation.LicenseValidationResult = LicenseValidator.CheckLicense()
        ''UpdateUI(result)
        'If (result.State = Habanero.Licensing.Validation.LicenseState.Invalid) And result.Issues.Contains(Habanero.Licensing.Validation.LicenseIssue.NoLicenseInfo) Then
        '    btnTrial.Enabled = True
        'End If
        AddContextMenu()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        'LicenseValidator.SaveLicense(txtLicense.Text)
        frmSignIn.TopMost = True
        Me.Close()
    End Sub

    Private Sub txtLicense_TextChanged(sender As Object, e As EventArgs) Handles txtLicense.TextChanged
        'Dim result As Habanero.Licensing.Validation.LicenseValidationResult
        'result = LicenseValidator.CheckLicense(txtLicense.Text)
        'UpdateUI(result)
        'If result.State = Habanero.Licensing.Validation.LicenseState.Valid Then
        '    btnActivate.Enabled = True
        'Else
        '    btnActivate.Enabled = False
        'End If
    End Sub

    Private Sub btnTrial_Click(sender As Object, e As EventArgs) Handles btnTrial.Click
        'Dim result As Habanero.Licensing.Validation.LicenseValidationResult = LicenseValidator.ActivateTrial(30)
        'LicenseValidator.SaveLicense(result.RawLicenseData)
        frmSignIn.TopMost = True
        Me.Close()
    End Sub

    'Private Sub UpdateUI(valResult As Habanero.Licensing.Validation.LicenseValidationResult)
    '    Dim licensestatestring1 As String = ""
    '    Dim licensestatestring2 As String = ""

    '    If valResult.State = Habanero.Licensing.Validation.LicenseState.Invalid Then
    '        lblLicenseStatus1.Text = "License Status: Invalid"
    '        If valResult.Issues.Contains(Habanero.Licensing.Validation.LicenseIssue.BadLicenseFormat) Then
    '            lblLicenseStatus2.Text = "Bad License Format"
    '        ElseIf valResult.Issues.Contains(Habanero.Licensing.Validation.LicenseIssue.BadLicenseKey) Then
    '            lblLicenseStatus2.Text = "Bad License Key"
    '        ElseIf valResult.Issues.Contains(Habanero.Licensing.Validation.LicenseIssue.ExpiredDateHard) Then
    '            lblLicenseStatus2.Text = "Expired License Key"
    '        ElseIf valResult.Issues.Contains(Habanero.Licensing.Validation.LicenseIssue.ExpiredDateSoft) Then
    '            lblLicenseStatus2.Text = "Expired License Key"
    '        ElseIf valResult.Issues.Contains(Habanero.Licensing.Validation.LicenseIssue.ExpiredVersion) Then
    '            lblLicenseStatus2.Text = "Expired Version"
    '        ElseIf valResult.Issues.Contains(Habanero.Licensing.Validation.LicenseIssue.WrongProduct) Then
    '            lblLicenseStatus2.Text = "Wrong Product"
    '        End If
    '    ElseIf valResult.State = Habanero.Licensing.Validation.LicenseState.Trial Then
    '        lblLicenseStatus1.Text = "License Status: Trial"
    '        lblLicenseStatus2.Text = "Expiration: " + valResult.ExpirationDate.ToString
    '    Else
    '        lblLicenseStatus1.Text = "License Status: Valid"
    '        If valResult.ExpirationDate.ToString = "" Then
    '            lblLicenseStatus2.Text = "Expiration: Never"
    '        Else
    '            lblLicenseStatus2.Text = "Expiration: " + valResult.ExpirationDate.ToString
    '        End If
    '        If LicenseValidator.IsEdition("Standard") Then
    '            lblEdition.Text = "Edition: Standard"
    '        ElseIf LicenseValidator.IsEdition("Pro") Then
    '            lblEdition.Text = "Edition: Pro"
    '        ElseIf LicenseValidator.IsEdition("Enterprise") Then
    '            lblEdition.Text = "Edition: Enterprise"
    '        End If
    '    End If
    'End Sub

    Private Sub AddContextMenu()
        Dim Contextmenu1 As New ContextMenu
        Dim menuItem3Paste As New MenuItem("Paste")
        AddHandler menuItem3Paste.Click, AddressOf menuItem3Paste_Click
        Contextmenu1.MenuItems.Add(menuItem3Paste)
        txtLicense.ContextMenu = Contextmenu1
    End Sub

    Private Sub menuItem3Paste_Click()
        txtLicense.Paste()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        Using brush As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.White, Color.LightSteelBlue, 45.0F)
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using
    End Sub
End Class