<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Textbox_password = New System.Windows.Forms.TextBox()
        Me.CB_ShowChar = New System.Windows.Forms.CheckBox()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Lbl_count = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(74, 66)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "&Cancel"
        '
        'Textbox_password
        '
        Me.Textbox_password.Location = New System.Drawing.Point(69, 5)
        Me.Textbox_password.Name = "Textbox_password"
        Me.Textbox_password.Size = New System.Drawing.Size(220, 20)
        Me.Textbox_password.TabIndex = 0
        '
        'CB_ShowChar
        '
        Me.CB_ShowChar.AutoSize = True
        Me.CB_ShowChar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CB_ShowChar.Checked = True
        Me.CB_ShowChar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_ShowChar.Location = New System.Drawing.Point(2, 32)
        Me.CB_ShowChar.Name = "CB_ShowChar"
        Me.CB_ShowChar.Size = New System.Drawing.Size(80, 17)
        Me.CB_ShowChar.TabIndex = 1
        Me.CB_ShowChar.Text = "&Show char."
        Me.CB_ShowChar.UseVisualStyleBackColor = True
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.Location = New System.Drawing.Point(4, 8)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(53, 13)
        Me.Lbl_Password.TabIndex = 3
        Me.Lbl_Password.Text = "&Password"
        '
        'Lbl_count
        '
        Me.Lbl_count.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_count.Location = New System.Drawing.Point(267, 30)
        Me.Lbl_count.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_count.Name = "Lbl_count"
        Me.Lbl_count.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_count.Size = New System.Drawing.Size(25, 17)
        Me.Lbl_count.TabIndex = 4
        Me.Lbl_count.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Password
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(297, 103)
        Me.Controls.Add(Me.Lbl_count)
        Me.Controls.Add(Me.Lbl_Password)
        Me.Controls.Add(Me.CB_ShowChar)
        Me.Controls.Add(Me.Textbox_password)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Password"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Password"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Textbox_password As System.Windows.Forms.TextBox
    Friend WithEvents CB_ShowChar As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Password As System.Windows.Forms.Label
    Friend WithEvents Lbl_count As System.Windows.Forms.Label

End Class
