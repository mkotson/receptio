<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicense))
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnTrial = New System.Windows.Forms.Button()
        Me.txtLicense = New System.Windows.Forms.RichTextBox()
        Me.lblEnterLicense = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnActivate
        '
        Me.btnActivate.Enabled = False
        Me.btnActivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivate.Location = New System.Drawing.Point(12, 172)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(101, 51)
        Me.btnActivate.TabIndex = 0
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnTrial
        '
        Me.btnTrial.Enabled = False
        Me.btnTrial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrial.Location = New System.Drawing.Point(228, 172)
        Me.btnTrial.Name = "btnTrial"
        Me.btnTrial.Size = New System.Drawing.Size(101, 51)
        Me.btnTrial.TabIndex = 2
        Me.btnTrial.Text = "Free 30 Day Trial"
        Me.btnTrial.UseVisualStyleBackColor = True
        '
        'txtLicense
        '
        Me.txtLicense.Location = New System.Drawing.Point(12, 40)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(317, 126)
        Me.txtLicense.TabIndex = 3
        Me.txtLicense.Text = ""
        '
        'lblEnterLicense
        '
        Me.lblEnterLicense.AutoSize = True
        Me.lblEnterLicense.BackColor = System.Drawing.Color.Transparent
        Me.lblEnterLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterLicense.Location = New System.Drawing.Point(12, 24)
        Me.lblEnterLicense.Name = "lblEnterLicense"
        Me.lblEnterLicense.Size = New System.Drawing.Size(92, 16)
        Me.lblEnterLicense.TabIndex = 4
        Me.lblEnterLicense.Text = "Enter License:"
        '
        'frmLicense
        '
        Me.AcceptButton = Me.btnActivate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(338, 232)
        Me.Controls.Add(Me.lblEnterLicense)
        Me.Controls.Add(Me.txtLicense)
        Me.Controls.Add(Me.btnTrial)
        Me.Controls.Add(Me.btnActivate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmLicense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "License"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents btnTrial As System.Windows.Forms.Button
    Friend WithEvents txtLicense As System.Windows.Forms.RichTextBox
    Friend WithEvents lblEnterLicense As System.Windows.Forms.Label
End Class
