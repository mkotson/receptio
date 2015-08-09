<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotify
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
        Me.lblNotify = New System.Windows.Forms.Label()
        Me.tmrNotify = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblNotify
        '
        Me.lblNotify.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNotify.AutoSize = True
        Me.lblNotify.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotify.Location = New System.Drawing.Point(225, 47)
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(106, 39)
        Me.lblNotify.TabIndex = 0
        Me.lblNotify.Text = "Notify"
        Me.lblNotify.UseWaitCursor = True
        '
        'tmrNotify
        '
        Me.tmrNotify.Interval = 7000
        '
        'frmNotify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNotify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmNotify"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNotify As System.Windows.Forms.Label
    Friend WithEvents tmrNotify As System.Windows.Forms.Timer
End Class
