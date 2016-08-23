<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userpasschange
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userpasschange))
        Me.oldpassword = New System.Windows.Forms.TextBox()
        Me.newpassword = New System.Windows.Forms.TextBox()
        Me.confirmpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'oldpassword
        '
        Me.oldpassword.Location = New System.Drawing.Point(219, 118)
        Me.oldpassword.Name = "oldpassword"
        Me.oldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpassword.Size = New System.Drawing.Size(232, 20)
        Me.oldpassword.TabIndex = 1
        '
        'newpassword
        '
        Me.newpassword.Location = New System.Drawing.Point(220, 170)
        Me.newpassword.Name = "newpassword"
        Me.newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpassword.Size = New System.Drawing.Size(232, 20)
        Me.newpassword.TabIndex = 2
        '
        'confirmpassword
        '
        Me.confirmpassword.Location = New System.Drawing.Point(219, 227)
        Me.confirmpassword.Name = "confirmpassword"
        Me.confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmpassword.Size = New System.Drawing.Size(232, 20)
        Me.confirmpassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User  name                        :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Current password                :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "New password                    :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Re-enter new password      :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(49, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Change pasword"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightPink
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(292, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(219, 75)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(232, 20)
        Me.username.TabIndex = 1
        '
        'userpasschange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(476, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.confirmpassword)
        Me.Controls.Add(Me.newpassword)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.oldpassword)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "userpasschange"
        Me.Text = "User password change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents oldpassword As System.Windows.Forms.TextBox
    Friend WithEvents newpassword As System.Windows.Forms.TextBox
    Friend WithEvents confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents username As System.Windows.Forms.TextBox
End Class
