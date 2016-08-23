<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminpasschange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminpasschange))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.confirmpassword = New System.Windows.Forms.TextBox()
        Me.newpassword = New System.Windows.Forms.TextBox()
        Me.oldpassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(39, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Re-enter new password      :"
        Me.Label4.UseWaitCursor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(39, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New password                    :"
        Me.Label3.UseWaitCursor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(39, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Current password                :"
        Me.Label2.UseWaitCursor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(39, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name                                  :"
        Me.Label1.UseWaitCursor = true
        '
        'confirmpassword
        '
        Me.confirmpassword.Location = New System.Drawing.Point(199, 236)
        Me.confirmpassword.Name = "confirmpassword"
        Me.confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmpassword.Size = New System.Drawing.Size(232, 20)
        Me.confirmpassword.TabIndex = 15
        Me.confirmpassword.UseWaitCursor = true
        '
        'newpassword
        '
        Me.newpassword.Location = New System.Drawing.Point(200, 179)
        Me.newpassword.Name = "newpassword"
        Me.newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpassword.Size = New System.Drawing.Size(232, 20)
        Me.newpassword.TabIndex = 14
        Me.newpassword.UseWaitCursor = true
        '
        'oldpassword
        '
        Me.oldpassword.Location = New System.Drawing.Point(199, 127)
        Me.oldpassword.Name = "oldpassword"
        Me.oldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpassword.Size = New System.Drawing.Size(232, 20)
        Me.oldpassword.TabIndex = 13
        Me.oldpassword.UseWaitCursor = true
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Button1.Location = New System.Drawing.Point(42, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 34)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Change pasword"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Button2.Location = New System.Drawing.Point(278, 318)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 34)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.UseWaitCursor = True
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(200, 76)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(232, 20)
        Me.username.TabIndex = 13
        Me.username.UseWaitCursor = True
        '
        'adminpasschange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(480, 378)
        Me.ControlBox = false
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.confirmpassword)
        Me.Controls.Add(Me.newpassword)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.oldpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "adminpasschange"
        Me.Text = "Admin password change"
        Me.UseWaitCursor = true
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents newpassword As System.Windows.Forms.TextBox
    Friend WithEvents oldpassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents username As System.Windows.Forms.TextBox
End Class
