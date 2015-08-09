<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignOut
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
        Me.lblSignOut = New System.Windows.Forms.Label()
        Me.tmrSignOut = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblSignOut
        '
        Me.lblSignOut.AutoSize = True
        Me.lblSignOut.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignOut.Location = New System.Drawing.Point(91, 43)
        Me.lblSignOut.Name = "lblSignOut"
        Me.lblSignOut.Size = New System.Drawing.Size(402, 39)
        Me.lblSignOut.TabIndex = 0
        Me.lblSignOut.Text = "Thank you for signing out"
        '
        'tmrSignOut
        '
        Me.tmrSignOut.Interval = 7000
        '
        'frmSignOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSignOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSignOut"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSignOut As System.Windows.Forms.Label
    Friend WithEvents tmrSignOut As System.Windows.Forms.Timer
End Class
